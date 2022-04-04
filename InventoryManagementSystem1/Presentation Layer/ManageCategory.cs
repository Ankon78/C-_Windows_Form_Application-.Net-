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
    public partial class ManageCategory : Form
    {
        public ManageCategory()
        {
            InitializeComponent();
        }

        private void ManageCategory_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ManageCategory_Load(object sender, EventArgs e)
        {
            GridViewUpdate();
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            categoryWiseProductListComboBox.DataSource = categoryDataAccess.GetCategoryNames();
        }
        void GridViewUpdate()
        {
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            listOfCategoriesGridView1.DataSource = categoryDataAccess.GetCategories();

        }
        void ClearFields()
        {
            addCategoryNameTextBox1.Text = string.Empty;
            updateCategoryIdtextBox2.Text = string.Empty;
            updateCategoryNameTextBox1.Text = string.Empty;
            deleteCategoryIdTextBox1.Text = string.Empty;
        }

        private void addButton1_Click(object sender, EventArgs e)
        {
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            if(categoryDataAccess.CreateCategory(addCategoryNameTextBox1.Text))
            {
                MessageBox.Show("New Category added");
                listOfCategoriesGridView1.DataSource = categoryDataAccess.GetCategories();
                GridViewUpdate();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Error in adding");
            }
        }

        private void loadButton2_Click(object sender, EventArgs e)
        {
            if(updateCategoryIdtextBox2.Text=="")
            {
                MessageBox.Show("Please give a category ID");
            }
            else
            {
                CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
                int id = Convert.ToInt32(updateCategoryIdtextBox2.Text);
                Category category= categoryDataAccess.GetCategoryById(id);
                if(category==null)
                {
                    MessageBox.Show("Category not available");
                    ClearFields();
                }
                else
                {
                    updateCategoryNameTextBox1.Text = category.CategoryName;
                }
               

            }
        }

        private void updateButton1_Click(object sender, EventArgs e)
        {
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            if (categoryDataAccess.UpdateCategory(Convert.ToInt32(updateCategoryIdtextBox2.Text), updateCategoryNameTextBox1.Text))

            {
                MessageBox.Show("Category updated");
                GridViewUpdate();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Error in updating");
            }
        }

        private void DeleteButton1_Click(object sender, EventArgs e)
        {
            

            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            int id = Convert.ToInt32(deleteCategoryIdTextBox1.Text);
            Category category = categoryDataAccess.GetCategoryById(id);
            if (deleteCategoryIdTextBox1.Text=="")
            {
                MessageBox.Show("Enter Category Id to delete");
            }
            
            else if (category == null)
            {
                MessageBox.Show("Category not available");
                ClearFields();
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
                if(result==DialogResult.Yes)
                {
                    categoryDataAccess = new CategoryDataAccess();
                    if (categoryDataAccess.DeleteCategory(Convert.ToInt32(deleteCategoryIdTextBox1.Text)))

                    {
                        MessageBox.Show("Category deleted");
                        GridViewUpdate();
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Error in deleting");
                    }
                }
            }

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void categoryWiseProductListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            int category = categoryDataAccess.GetCategoryByName(categoryWiseProductListComboBox.Text).CategoryId;
            ProductDataAccess productDataAccess = new ProductDataAccess();
            categoryWiseProductGataGridView.DataSource = productDataAccess.GetProductsByCategoryId(category);
        }
    }
}
