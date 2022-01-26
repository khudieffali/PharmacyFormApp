using Microsoft.EntityFrameworkCore;
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
    public partial class Form1 : Form
    {
        PharmacyDBContext db = new();
        Medicine selectedMedicine;
        public Form1()
        {
            InitializeComponent();
        }

        private void medicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMedicineForm admf = new();
            admf.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillGridMedicine();
            FillMedicineCombo();
            FilltagsCombo();
        }
        private void FilltagsCombo()
        {
            cmbTags.Items.AddRange(db.Tags.Select(x => x.Name).ToArray());
        }
        private void FillMedicineCombo()
        {
            cmbMedicine.Items.AddRange(db.Medicines.Select(x => x.Name).ToArray());
        }
        private void FillGridMedicine()
        {
            dtgOrders.DataSource = db.TagToMedicines.Where(x=>x.Medicine.Name.Contains(cmbMedicine.Text) && x.Tag.Name.Contains(cmbTags.Text)).Select(x => new
            {
                x.Medicine.MedicineId,
                x.Medicine.Name,
                x.Medicine.Price,
                x.Medicine.Quantity,
                x.Medicine.ProductionDate,
                x.Medicine.ExpireDate,
                Ressept = x.Medicine.IsReceipt ? "Resseptli" : "Resseptsiz",
               

            }).Distinct().ToList();
            dtgOrders.RowsDefaultCellStyle.ForeColor = Color.Black;
            dtgOrders.Columns[0].Visible = false;
            for (int i = 0; i < dtgOrders.RowCount; i++)
            {
                int quant = (int)dtgOrders.Rows[i].Cells[3].Value;
                if (quant == 0)
                {
                    dtgOrders.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    dtgOrders.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }
            }
            for (int i = 0; i < dtgOrders.RowCount; i++)
            {
                if (i % 2 == 0)
                {
                    dtgOrders.Rows[i].DefaultCellStyle.BackColor = Color.DarkCyan;
                    dtgOrders.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }

            }
        }

        private void cmbMedicine_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillGridMedicine();
        }

        private void cmbMedicine_KeyUp(object sender, KeyEventArgs e)
        {
            FillGridMedicine();
        }

        private void cmbTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillGridMedicine();
        }

        private void cmbTags_KeyUp(object sender, KeyEventArgs e)
        {
            FillGridMedicine();
        }

        private void dtgOrders_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int MedicineId = (int)dtgOrders.Rows[e.RowIndex].Cells[0].Value;
           selectedMedicine= db.Medicines.FirstOrDefault(x => x.MedicineId == MedicineId);
            if(selectedMedicine.Quantity>0)
            {
                txtMedicineName.Text = selectedMedicine.Name;
                panel1.Visible = true;
                nmQuantity.Value = 1;
                nmQuantity.Maximum = selectedMedicine.Quantity;
            }
            

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string MedName = txtMedicineName.Text;
            int Quantity =(int) nmQuantity.Value;
            bool IsCorrect = false;
            if (ckSellList.Items.Count == 0)
            {
                ckSellList.Items.Add(MedName + "-" + Quantity,true);
            }
            else
            {
                for (int i=0;i<ckSellList.Items.Count;i++)
                {
                    var item = ckSellList.Items[i];
                    var CurrentName = item.ToString().Split("-")[0];
                    var quant = Convert.ToInt32(item.ToString().Split("-")[1]);
                    if (MedName == CurrentName)
                    {
                        ckSellList.Items.Remove(item);
                        quant += Quantity;
                        ckSellList.Items.Add(MedName + "-" + quant, true);
                        IsCorrect = true;
                    }
                 
                }
                if (!IsCorrect)
                {
                    ckSellList.Items.Add(MedName + "-" + Quantity, true);
                }
            }
         
           

        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            string Message = "";
            decimal TotalPrice = 0;
            foreach (var med in ckSellList.Items)
            {
               
                string MedName = med.ToString().Split("-")[0];
                Medicine selectMed = db.Medicines.FirstOrDefault(x => x.Name == MedName);
                int Quantity = Convert.ToInt32(med.ToString().Split("-")[1]);
                Message +=$"Derman adi: {MedName}, Sayi: { Quantity},Qiymet: {selectMed.Price*Quantity}\n";
                TotalPrice += selectMed.Price * Quantity;
                selectMed.Quantity -= Quantity;
                db.SaveChanges();
            }
            MessageBox.Show(Message + "\n" + "Umumi Qiymet: " + TotalPrice, "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FillGridMedicine();
            ckSellList.Items.Clear();
            panel1.Visible = false;
        }
    }
}
