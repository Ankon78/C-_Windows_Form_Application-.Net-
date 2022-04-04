using DGVPrinterHelper;
using InventoryManagementSystem1.Data_Acess_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem1.Presentation_Layer
{
    public partial class ManagePayment : Form
    {
        public ManagePayment()
        {
            InitializeComponent();
        }


        private void ManagePayment_Load(object sender, EventArgs e)
        {
            UpdateGridView();
           

        }
        void UpdateGridView()
        {
            
        }

        private void ManagePayment_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void searchProductTextBox_TextChanged(object sender, EventArgs e)
        {
            ProductDataAccess productDataAccess = new ProductDataAccess();
            searchProductDataGridView1.DataSource = productDataAccess.GetProductListByNames(searchProductTextBox.Text);
        }
        
        private void searchProductDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            itemQuantityNumericUpDown1.ResetText();
            itemTotalTakaTextBox.Clear();
            ProductDataAccess productDataAccess = new ProductDataAccess();
            itemNameTextBox.Text = searchProductDataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
          
            itemPriceTextBox.Text = searchProductDataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void itemQuantityNumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Int64 quantity = Int64.Parse(itemQuantityNumericUpDown1.Value.ToString());
            Int64 price = Int64.Parse(itemPriceTextBox.Text);
            itemTotalTakaTextBox.Text = (quantity * price).ToString();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        protected int n, total = 0;
        

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            if (itemPriceTextBox.Text != "0" && itemPriceTextBox.Text != " ")
            {

                n = paymentCartDataGridView.Rows.Add();
                paymentCartDataGridView.Rows[n].Cells[0].Value = itemNameTextBox.Text;
                paymentCartDataGridView.Rows[n].Cells[1].Value = itemPriceTextBox.Text;
                paymentCartDataGridView.Rows[n].Cells[2].Value = itemQuantityNumericUpDown1.Value;
                paymentCartDataGridView.Rows[n].Cells[3].Value = itemTotalTakaTextBox.Text;

                total += int.Parse(itemTotalTakaTextBox.Text);
                totatTkLabel.Text = "Rs. " + total;
            }
            else
            {
                MessageBox.Show("Minimum Quantity need to be 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        int amount;
        private void paymentCartDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(paymentCartDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch
            {

            }
        }

        

        private void removeButton_Click(object sender, EventArgs e)
        {
            try
            {
                paymentCartDataGridView.Rows.RemoveAt(this.paymentCartDataGridView.SelectedRows[0].Index);
               
            }
            catch { }
            total -= amount;
            totatTkLabel.Text = "Rs.  " + total;
        }
        private void printButton_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Customer Bill";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Total Payable Ammount : " + totatTkLabel.Text;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(paymentCartDataGridView);

            total = 0;
            paymentCartDataGridView.Rows.Clear();
            totatTkLabel.Text = "Rs.  " + total;

        }

    }
}
