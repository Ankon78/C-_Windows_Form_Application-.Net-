using InventoryManagementSystem1.Data_Acess_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem1.Presentation_Layer
{
    public partial class ManageEmployee : Form
    {
        public ManageEmployee()
        {
            InitializeComponent();
        }
        
        
       SqlConnection connection=new SqlConnection(ConfigurationManager.ConnectionStrings["OOP2[i]"].ConnectionString);

        private void ManageEmployee_Load(object sender, EventArgs e)
        {
            UpdateGridView();
            EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
        }
            void UpdateGridView()
            {
            EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
            listOfEmployeesDataGridView.DataSource = employeeDataAccess.GetEmployees();
           

            }
            private void ManageEmployee_FormClosing(object sender, FormClosingEventArgs e)
            {
                Application.Exit();
            }
            void ClearFields()
            {
            
                 addNameTextBox.Text = string.Empty;
                 addMobileNumberTextBox.Text = string.Empty;
                 addRoleTextBox.Text = string.Empty;
                 addAddressTextBox.Text = string.Empty;
                 addSalaryTextBox.Text = string.Empty;
                 updateIdTextBox.Text = string.Empty;
                 updateNameTextBox.Text = string.Empty;
                 updateMobileNumberTextBox.Text = string.Empty;
                 updateRoleTextBox.Text = string.Empty;
                 updateAddressTextBox.Text = string.Empty;
                 updateSalaryTextBox.Text = string.Empty;
                 deleteIdTextBox.Text = string.Empty;

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (addNameTextBox.Text == "")
            {
                MessageBox.Show("Name can not be Empty");
            }
            else if (addMobileNumberTextBox.Text == "")
            {
                MessageBox.Show("Mobile Number can not be Empty");
            }
            else if (addRoleTextBox.Text=="")
            {
                MessageBox.Show("Role can not be Empty");
            }
            else if (addAddressTextBox.Text == "")
            {
                MessageBox.Show("Address can not be Empty");
            }
            else if (addSalaryTextBox.Text == "")
            {
                MessageBox.Show("Salary can not be Empty");
            }
            else
            {
                EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();

                if (employeeDataAccess.CreateEmployee(addNameTextBox.Text, addMobileNumberTextBox.Text, addRoleTextBox.Text, addAddressTextBox.Text, addSalaryTextBox.Text))
                {
                    MessageBox.Show("New Employee added");
                    UpdateGridView();
                    ClearFields();

                }
                else
                {
                    MessageBox.Show("Error in adding");
                    ClearFields();
                }

            }
        }

        private void listOfEmployeesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();

            updateIdTextBox.Text = listOfEmployeesDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            updateNameTextBox.Text = listOfEmployeesDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            updateMobileNumberTextBox.Text = listOfEmployeesDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            updateRoleTextBox.Text = listOfEmployeesDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            updateAddressTextBox.Text = listOfEmployeesDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            updateSalaryTextBox.Text = listOfEmployeesDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
           
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
          
            if (employeeDataAccess.UpdateEmployee(Convert.ToInt32(updateIdTextBox.Text), updateNameTextBox.Text,updateMobileNumberTextBox.Text, updateRoleTextBox.Text,updateAddressTextBox.Text,updateSalaryTextBox.Text))
            {
                MessageBox.Show("Employee Updated");
                UpdateGridView();
                ClearFields();

            }
            else
            {
                MessageBox.Show("Error in updating");
                ClearFields();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
           
            if (deleteIdTextBox.Text == "")
            {
                MessageBox.Show("Employee not available");
                ClearFields();
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    employeeDataAccess = new EmployeeDataAccess();
                    if (employeeDataAccess.DeleteEmployee(Convert.ToInt32(deleteIdTextBox.Text)))

                    {
                        MessageBox.Show("Category deleted");
                        UpdateGridView();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
           listOfEmployeesDataGridView.DataSource = employeeDataAccess.GetEmployeeListByNames(textBox1.Text);
        }
    }
}
