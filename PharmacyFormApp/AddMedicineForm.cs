using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using PharmacyFormApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyFormApp
{
    public partial class AddMedicineForm : Form
    {
        PharmacyDBContext db = new();
        public AddMedicineForm()
        {
            InitializeComponent();
        }
        #region FirmFill
        private void FillFirmCombo()
        {
            cmbFirms.Items.AddRange(db.Firms.Select(x => x.Name).ToArray());
        }
        #endregion

        #region TagsFill
        private void FillTagsCombo()
        {
            cmbTags.Items.AddRange(db.Tags.Select(x => x.Name).ToArray());
        }
        #endregion 

        #region Grid Fill
        private void FillGridMedicine()
        {
            dtgMedicine.DataSource = db.Medicines.Include(x => x.Firm).Select(x => new
            {
                x.Name,
                x.Price,
                x.Quantity,
                x.ProductionDate,
                x.ExpireDate,
                Ressept = x.IsReceipt ? "Resseptli" : "Resseptsiz",
                FirmName = x.Firm.Name,

            }).ToList();
            dtgMedicine.RowsDefaultCellStyle.ForeColor = Color.Black;
            for (int i = 0; i < dtgMedicine.RowCount; i++)
            {
                if (i % 2 == 0)
                {
                    dtgMedicine.Rows[i].DefaultCellStyle.BackColor = Color.DarkCyan;
                    dtgMedicine.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }

            }
        }
        #endregion
        #region ClearItem
        private void ClearItem()
        {
            foreach (var item in AddMedicineForm.ActiveForm.Controls)
            {
                if (item is TextBox || item is ComboBox)
                {
                    var d = (Control)item;
                    d.Text = "";
                } else if(item is NumericUpDown)
                {
                    NumericUpDown nm = (NumericUpDown)item;
                    nm.Value = 1;
                } else if (item is CheckedListBox)
                {
                    CheckedListBox ck = (CheckedListBox)item;
                    ck.Items.Clear();
                }else if (item is DateTimePicker)
                {
                    DateTimePicker dt = (DateTimePicker)item;
                    dt.Value = DateTime.Now;
                }else if (item is CheckBox)
                {
                    CheckBox ckb = (CheckBox)item;
                    ckb.Checked = false;
                }
            }
        }
        #endregion

        #region MedicineForm load
        private void AddMedicineForm_Load(object sender, EventArgs e)
        {
            FillFirmCombo();
            FillTagsCombo();
            FillGridMedicine();
        }
        #endregion

        public int FindFirm(string firmName)
        {
            Firm selectedFirm = db.Firms.FirstOrDefault(x => x.Name == firmName);
            if (selectedFirm == null)
            {
                Firm newFirm = new();
                newFirm.Name = firmName;
                db.Firms.Add(newFirm);
                db.SaveChanges();
                return newFirm.FirmId;
            }
            return selectedFirm.FirmId;
        }
        private void btnMedicine_Click(object sender, EventArgs e)
        {
            string MedicineName = txtMedicineName.Text;
            string FirmName = cmbFirms.Text;
            int Count = (int)nmQuantity.Value;
            decimal Price = nmPrice.Value;
            string Desc = rcDescription.Text;
            DateTime ProDate = dtProduction.Value;
            DateTime ExDate = dtExpire.Value;
            bool IsRec = cbChecked.Checked;
            string[] myarr = { MedicineName, FirmName, Desc };
            if (Utilities.IsEmpty(myarr))
            {
                lblError.Visible = false;
                int firmId = FindFirm(FirmName);
                Medicine newmedicine = new()
                {
                    Name = MedicineName,
                    Price = Price,
                    Quantity = Count,
                    Description = Desc,
                    ProductionDate = ProDate,
                    ExpireDate = ExDate,
                    FirmId = firmId,
                    IsReceipt = IsRec ? true : false,
                    
                };
                db.Medicines.Add(newmedicine);
                db.SaveChanges();
                MedicineAddtag(newmedicine.MedicineId);
                MessageBox.Show("Derman Ugurla elave edildi");
                FillGridMedicine();
                ClearItem();
            }
            else
            {
                lblError.Text = "Zehmet olmasa xanalari tam doldurun";
                lblError.Visible = true;
            }

        }


        private void cmbTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddTagItem();
        }

        private void cmbTags_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddTagItem();
            }

        }
        private bool checkTagName(string tg)
        {
            Tag tag = db.Tags.FirstOrDefault(x => x.Name == tg);
            if (tag == null)
            {
                return false;
            }
            return true;
        }
        private void MedicineAddtag(int MedId)
        {
            for (int i = 0; i < ckTagList.Items.Count; i++)
            {
                string tagName = ckTagList.Items[i].ToString();
                int TagId;
                if (checkTagName(tagName))
                {
                    TagId = db.Tags.First(x => x.Name == tagName).TagId;
                    TagToMedicine newTagMedicine = new()
                    {
                        MedicineId = MedId,
                        TagId = TagId
                    };
                    db.TagToMedicines.Add(newTagMedicine);
                    db.SaveChanges();
                }
                else
                {
                    Tag newTag = new()
                    {
                        Name = tagName,
                    };
                    db.Tags.Add(newTag);
                    db.SaveChanges();
                    TagId = newTag.TagId;
                    TagToMedicine newTagMedicine = new()
                    {
                        MedicineId = MedId,
                        TagId = TagId
                    };
                    db.TagToMedicines.Add(newTagMedicine);
                    db.SaveChanges();


                }
            }
        }
        private void AddTagItem()
        {
            string TagName = cmbTags.Text;
            if (!ckTagList.Items.Contains(TagName) && !string.IsNullOrWhiteSpace(TagName))
            {
                ckTagList.Items.Add(TagName, true);
            }
        }
        private void ckTagList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = ckTagList.SelectedIndex;
            if (selectedIndex != -1)
            {
                ckTagList.Items.RemoveAt(selectedIndex);
            }
        }
    }
}
