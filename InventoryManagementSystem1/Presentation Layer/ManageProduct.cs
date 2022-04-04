using InventoryManagementSystem1.Data_Acess_Layer;
using InventoryManagementSystem1.Entities;
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
    public partial class ManageProduct : Form
    {
        public ManageProduct()
        {
            InitializeComponent();
        }

        private void ManageProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ManageProduct_Load(object sender, EventArgs e)
        {
            UpdateGridView();
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            addCategoryComboBox.DataSource = categoryDataAccess.GetCategoryNames();
            categoryDataAccess = new CategoryDataAccess();
            updateCategoryComboBox.DataSource = categoryDataAccess.GetCategoryNames();

        }
        void UpdateGridView()
        {
            ProductDataAccess productDataAccess = new ProductDataAccess();
            listOfProductsDataGridView.DataSource = productDataAccess.GetProducts();
        }
        void ClearFields()
        {
            addProductNameTextBox.Text = string.Empty;
            addPriceTextBox.Text = string.Empty;
            addQuantityNumericUpDown.Text = string.Empty;
            updateProductIdTextBox.Text = string.Empty;
            updateProductNameTextBox.Text = string.Empty;
            updateProductPriceTextBox.Text = string.Empty;
            updateProductQuantityNumericUpDown1.Text = string.Empty;
            deleteProductIdTextBox.Text = string.Empty;
           
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ProductDataAccess productDataAccess = new ProductDataAccess();
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            int categoryId = categoryDataAccess.GetCategoryByName(addCategoryComboBox.Text).CategoryId;
            if(productDataAccess.CreateProduct(addProductNameTextBox.Text,Convert.ToDouble(addPriceTextBox.Text),Convert.ToInt32(addQuantityNumericUpDown.Text),categoryId))
            {
                MessageBox.Show("New Product created");
                UpdateGridView();
                ClearFields();

            }
            else
            {
                MessageBox.Show("Error in creating");
                ClearFields();
            }
        }
        int categoryId;

        private void listOfProductsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            ProductDataAccess productDataAccess = new ProductDataAccess();
            updateProductIdTextBox.Text = listOfProductsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            updateProductNameTextBox.Text = listOfProductsDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            updateProductPriceTextBox.Text = listOfProductsDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            updateProductQuantityNumericUpDown1.Text = listOfProductsDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            categoryId=(int)listOfProductsDataGridView.Rows[e.RowIndex].Cells[4].Value;
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            string categoryName = categoryDataAccess.GetCategoryById(categoryId).CategoryName;
            updateCategoryComboBox.Text = categoryName;
            deleteProductIdTextBox.Text= listOfProductsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            ProductDataAccess productDataAccess = new ProductDataAccess();
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            int categoryId = categoryDataAccess.GetCategoryByName(updateCategoryComboBox.Text).CategoryId;
            if (productDataAccess.UpdateProduct(Convert.ToInt32(updateProductIdTextBox),updateProductNameTextBox.Text, Convert.ToDouble(updateProductPriceTextBox.Text), Convert.ToInt32(updateProductQuantityNumericUpDown1.Text),categoryId))
            {
                MessageBox.Show("Product Updated");
                UpdateGridView();
                ClearFields();

            }
            else
            {
                MessageBox.Show("Error in creating");
                ClearFields();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            
            ProductDataAccess productDataAccess = new ProductDataAccess();
            if (deleteProductIdTextBox.Text == "")
            {
                MessageBox.Show("Enter product Id");
            }
            else if (productDataAccess.DeleteProduct(Convert.ToInt32(deleteProductIdTextBox.Text)))
            {
                MessageBox.Show("Product deleted");
                UpdateGridView();
                ClearFields();

            }
            else
            {
                MessageBox.Show("Error in deleting");
                ClearFields();

            }
        }

        private void searchNameTextBox_TextChanged(object sender, EventArgs e)
        {
            ProductDataAccess productDataAccess = new ProductDataAccess();
            searchProductDataGridView.DataSource = productDataAccess.GetProductListByNames(searchNameTextBox.Text);

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

       
    }
}
