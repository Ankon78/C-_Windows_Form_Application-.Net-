using InventoryManagementSystem1.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem1.Data_Acess_Layer
{
    class EmployeeDataAccess : DataAccess
    {
        public List<Employee> GetEmployees()
        {
            string sql = "SELECT * FROM EmployeesTable";
            SqlDataReader reader = this.GetData(sql);
            List<Employee> employees = new List<Employee>();
            while (reader.Read())
            {
                Employee employee = new Employee();
                employee.Id =(int) reader["Id"];
                employee.Name = reader["Name"].ToString();
                employee.MobileNumber = reader["MobileNumber"].ToString();
                employee.Role = reader["Role"].ToString();
                employee.Address = reader["Address"].ToString();
                employee.Salary = reader["Salary"].ToString();
                employees.Add(employee);
            }
            return employees;
        }
        public Employee GetEmployeeById(int id)
        {
            string sql = "SELECT * FROM EmployeesTable WHERE Id=" + id;
            SqlDataReader reader = this.GetData(sql);
            if (reader.HasRows)
            {
                reader.Read();
                Employee employee = new Employee();
                employee.Id = (int)reader["Id"];
                employee.Name = reader["Name"].ToString();
                employee.MobileNumber = reader["MobileNumber"].ToString();
                employee.Role = reader["Role"].ToString();
                employee.Address = reader["Address"].ToString();
                employee.Salary = reader["Salary"].ToString();
                return employee;
            }
            return null;
        }
        public bool CreateEmployee(string name, string mobileNumber, string role, string address,string salary)
        {
            string sql = "INSERT INTO EmployeesTable(Name,MobileNumber,Role,Address,Salary) VALUES('" + name + "','" + mobileNumber + "','" + role + "','" + address + "','"+salary+"')";

            int result = this.ExecuteQuery(sql);
            
             if (result > 0)
             {
                 return true;
             }
             else
                 return false;
            
        }
        public bool UpdateEmployee(int id,string name, string mobileNumber, string role, string address,string salary)
        {
            string sql = "UPDATE EmployeesTable set Name='" + name + "',MobileNumber='" + mobileNumber + "',Role='" + role + "',Address='" + address + "',Salary='"+salary+"' where Id=" + id;

            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            else
                return false;

        }
        public bool DeleteEmployee(int id)
        {
            string sql = "DELETE EmployeesTable WHERE Id=" + id;

            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            else
                return false;

        }

        public List<Employee> GetEmployeeListByNames(string str)
        {
            string sql = "SELECT * FROM EmployeesTable WHERE Name LIKE '" + str + "%'";
            SqlDataReader reader = this.GetData(sql);
            List<Employee> employees = new List<Employee>();
            while (reader.Read())
            {
                Employee employee = new Employee();
                employee.Id =(int) reader["Id"];
                employee.Name = reader["Name"].ToString();
                employee.MobileNumber = reader["MobileNumber"].ToString();
                employee.Role = reader["Role"].ToString();
                employee.Address = reader["Address"].ToString();
                employee.Salary = reader["Salary"].ToString();
                employees.Add(employee);
            }
            return employees;


        }
       
    }

}
