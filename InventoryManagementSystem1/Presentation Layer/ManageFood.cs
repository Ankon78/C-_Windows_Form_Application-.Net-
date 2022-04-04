using ChefsFoodManagement.Data_Access_Layer;
using ChefsFoodManagement.Entities;
using InventoryManagementSystem1.Presentation_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChefsFoodManagement.Presentation_Layer
{
    public partial class ManageFood : Form
    {
        public ManageFood()
        {
            InitializeComponent();
        }

        private void ManageFood_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ManageFood_Load(object sender, EventArgs e)
        {
            UpdateGridView();
            timer.Start();
        }

        void UpdateGridView()
        {
            FoodDataAccess foodDataAccess = new FoodDataAccess();
            listOfFoodsGridView.DataSource = foodDataAccess.GetFoods();
        }
        void ClearFields()
        {
            addFoodNameTextBox.Text = string.Empty;
            addFoodCategoryTextBox.Text = string.Empty;
            addMfgDateDateTimePicker.Text = string.Empty;
            addExpDateDateTimePicker.Text = string.Empty;
            addQuantityTextBox.Text = string.Empty;
            addPerUnitPriceTextBox.Text = string.Empty;
            addIngredientsTextBox.Text = string.Empty;
            addCheckBox.Checked = false;

            updateFoodIdTextBox.Text = string.Empty;
            updateFoodNameTextBox.Text = string.Empty;
            updateFoodCategoryTextBox.Text = string.Empty;
            updateMfgDateDateTimePicker.Text = string.Empty;
            updateExpDateDateTimePicker.Text = string.Empty;
            updateQuantityTextBox.Text = string.Empty;
            updatePerUnitPriceTextBox.Text = string.Empty;
            updateIngredientsTextBox.Text = string.Empty;
            updateCheckBox.Checked = false;

            addButton.Enabled = false;
            updateButton.Enabled = false;

            deleteFoodIdTextBox.Text = string.Empty;
        }

        private void AddCheckBox_Click(object sender, EventArgs e)
        {
            if (addCheckBox.Checked == true)
            {
                addButton.Enabled = true;
            }
            else
                addButton.Enabled = false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(addFoodNameTextBox.Text=="")
            {
                MessageBox.Show("Food Name cannot be Empty");
            }
            else if (addFoodCategoryTextBox.Text == "")
            {
                MessageBox.Show("Food Category cannot be Empty");
            }
            else if (addMfgDateDateTimePicker.Text == "")
            {
                MessageBox.Show("Mfg date cannot be Empty");
            }
            else if (addExpDateDateTimePicker.Text == "")
            {
                MessageBox.Show("Exp Date cannot be Empty");
            }
            else if (addQuantityTextBox.Text == "")
            {
                MessageBox.Show("Quantity cannot be Empty");
            }
            else if (addPerUnitPriceTextBox.Text == "")
            {
                MessageBox.Show("Per Unit Price cannot be Empty");
            }
            else if (addIngredientsTextBox.Text == "")
            {
                MessageBox.Show("Ingredients cannot be Empty");
            }
            else
            {
                FoodDataAccess foodDataAccess = new FoodDataAccess();
                if (updateQuantityTextBox.Text.All(Char.IsNumber) == true && updatePerUnitPriceTextBox.Text.All(Char.IsNumber) == true)
                {

                    if (foodDataAccess.CreateFood(addFoodNameTextBox.Text, addFoodCategoryTextBox.Text, addMfgDateDateTimePicker.Text, addExpDateDateTimePicker.Text, Convert.ToInt32(addQuantityTextBox.Text), Convert.ToInt32(addPerUnitPriceTextBox.Text), addIngredientsTextBox.Text))
                    {
                        MessageBox.Show("New Food Item Successfully Added");
                        UpdateGridView();
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Error in adding");
                        ClearFields();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Input in Quantity or PerUnit Price");
                    ClearFields();
                }
            }
        }
        private void addButton_MouseHover(object sender, EventArgs e)
        {
            addButton.BackColor = Color.Lime;
        }

        private void addButton_MouseLeave(object sender, EventArgs e)
        {
            addButton.BackColor = Color.Transparent;
        }



        private void loadButton_Click(object sender, EventArgs e)
        {
            if(updateFoodIdTextBox.Text=="")
            {
                MessageBox.Show("Please give the Food ID");
            }
            else
            {
                FoodDataAccess foodDataAccess = new FoodDataAccess();

                if (updateFoodIdTextBox.Text.All(Char.IsNumber) == true)
                {
                    int id = Convert.ToInt32(updateFoodIdTextBox.Text);
                    List<Food> food = new List<Food>();
                    food = foodDataAccess.GetFoodById(id);

                    if (food.Count() == 0)
                    {
                        MessageBox.Show("Food Item Not Available");
                        ClearFields();
                    }

                    else
                    {
                        updateFoodNameTextBox.Text = food[0].FoodName;
                        updateFoodCategoryTextBox.Text = food[0].FoodCategory;
                        updateMfgDateDateTimePicker.Text = food[0].MfgDate;
                        updateExpDateDateTimePicker.Text = food[0].ExpDate;
                        updateQuantityTextBox.Text = food[0].Quantity.ToString();
                        updatePerUnitPriceTextBox.Text = food[0].PerUnitPrice.ToString();
                        updateIngredientsTextBox.Text = food[0].Ingredients;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Input");
                    ClearFields();
                }
                
            }
        }
        private void loadButton_MouseHover(object sender, EventArgs e)
        {
            loadButton.BackColor = Color.Lime;
        }

        private void loadButton_MouseLeave(object sender, EventArgs e)
        {
            loadButton.BackColor = Color.Transparent;
        }



        private void updateCheckBox_Click(object sender, EventArgs e)
        {
            if (updateCheckBox.Checked == true)
            {
                updateButton.Enabled = true;
            }
            else
                updateButton.Enabled = false;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (updateFoodNameTextBox.Text == "")
            {
                MessageBox.Show("Food Name cannot be Empty");
            }
            else if (updateFoodCategoryTextBox.Text == "")
            {
                MessageBox.Show("Food Category cannot be Empty");
            }
            else if (updateMfgDateDateTimePicker.Text == "")
            {
                MessageBox.Show("Mfg date cannot be Empty");
            }
            else if (updateExpDateDateTimePicker.Text == "")
            {
                MessageBox.Show("Exp Date cannot be Empty");
            }
            else if (updateQuantityTextBox.Text == "")
            {
                MessageBox.Show("Quantity cannot be Empty");
            }
            else if (updatePerUnitPriceTextBox.Text == "")
            {
                MessageBox.Show("Per Unit Price cannot be Empty");
            }
            else if (updateIngredientsTextBox.Text == "")
            {
                MessageBox.Show("Ingredients cannot be Empty");
            }
            else
            {
                FoodDataAccess foodDataAccess = new FoodDataAccess();

                if (updateQuantityTextBox.Text.All(Char.IsNumber) == true && updatePerUnitPriceTextBox.Text.All(Char.IsNumber)==true)
                {

                    if (foodDataAccess.UpdateFood(Convert.ToInt32(updateFoodIdTextBox.Text), updateFoodNameTextBox.Text, updateFoodCategoryTextBox.Text, updateMfgDateDateTimePicker.Text, updateExpDateDateTimePicker.Text, Convert.ToInt32(updateQuantityTextBox.Text), Convert.ToInt32(updatePerUnitPriceTextBox.Text), updateIngredientsTextBox.Text))
                    {
                        MessageBox.Show("Food Successfully Updated");
                        UpdateGridView();
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Error in Updating");
                        ClearFields();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Input in Quantity or PerUnit Price");
                    ClearFields();
                }
            }
        }
        private void updateFoodIdTextBox_MouseHover(object sender, EventArgs e)
        {
            label15.Text = "Numbers";
            label15.ForeColor = System.Drawing.Color.Red;
        }

        private void updateFoodIdTextBox_MouseLeave(object sender, EventArgs e)
        {
            label15.Text = "Food ID";
            label15.ForeColor = System.Drawing.Color.Black;
        }
        private void updateButton_MouseHover(object sender, EventArgs e)
        {
            updateButton.BackColor = Color.Lime;
        }

        private void updateButton_MouseLeave(object sender, EventArgs e)
        {
            updateButton.BackColor = Color.Transparent;
        }




        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (deleteFoodIdTextBox.Text == "")
            {
                MessageBox.Show("Enter Food ID to Delete");
            }
            else
            {
                FoodDataAccess foodDataAccess = new FoodDataAccess();

                if (deleteFoodIdTextBox.Text.All(Char.IsNumber) == true)
                {

                    int id = Convert.ToInt32(deleteFoodIdTextBox.Text);
                    List<Food> food = new List<Food>();
                    food = foodDataAccess.GetFoodById(id);

                    if (food.Count() == 0)
                    {
                        MessageBox.Show("Food Item Not Available");
                        ClearFields();
                    }

                    else
                    {
                        DialogResult result = MessageBox.Show("--------Are You Sure?--------\n------Delete This Item?------", "Confirmation", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            foodDataAccess = new FoodDataAccess();
                            if (foodDataAccess.DeleteFood(Convert.ToInt32(deleteFoodIdTextBox.Text)))
                            {
                                MessageBox.Show("Food Item Deleted");
                                UpdateGridView();
                                ClearFields();
                            }
                            else
                            {
                                MessageBox.Show("Error in Deleting");
                                ClearFields();
                            }
                        }
                        else
                        {
                            //nothing
                            ClearFields();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("invalid Input");
                    ClearFields();
                }
            }
        }
        private void deleteFoodIdTextBox_MouseHover(object sender, EventArgs e)
        {
            label16.Text = "Numbers";
            label16.ForeColor = System.Drawing.Color.Red;
        }

        private void deleteFoodIdTextBox_MouseLeave(object sender, EventArgs e)
        {
            label16.Text = "Food ID";
            label16.ForeColor = System.Drawing.Color.Black;
        }
        private void deleteButton_MouseHover(object sender, EventArgs e)
        {
            deleteButton.BackColor = Color.Red;
        }

        private void deleteButton_MouseLeave(object sender, EventArgs e)
        {
            deleteButton.BackColor = Color.Transparent;
        }



        private void searchFoodNameTextBox_TextChanged(object sender, EventArgs e)
        {
            FoodDataAccess foodDataAccess = new FoodDataAccess();
            searchFoodDataGridView.DataSource = foodDataAccess.GetFoodListByNames(searchFoodNameTextBox.Text);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("HH:mm");
            secondLabel.Text = DateTime.Now.ToString("ss");
            dayLabel.Text = DateTime.Now.ToString("ddddd");
            dateLabel.Text = DateTime.Now.ToString("dd MMM yyyy");         
        }

       

        private void backButton_Click(object sender, EventArgs e)
        {
            Dashboard2 dashboard2 = new Dashboard2();
            dashboard2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
