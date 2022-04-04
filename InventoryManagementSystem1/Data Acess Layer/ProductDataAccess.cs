using InventoryManagementSystem1.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem1.Data_Acess_Layer
{
    class ProductDataAccess : DataAccess
    {
        public List<Product> GetProducts()
        {
            string sql = "SELECT * FROM Products";
            SqlDataReader reader = this.GetData(sql);
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product();
                product.ProductId = (int)reader["ProductId"];
                product.ProductName = reader["ProductName"].ToString();
                product.Price = Convert.ToDouble(reader["Price"]);
                product.Quantity = (int)reader["Quantity"];
                product.CategoryId = (int)reader["CategoryId"];
                products.Add(product);
            }
            return products;
        }

        public Product GetProductById(int productId)
        {
            string sql = "SELECT * FROM Products WHERE ProductId=" + productId;
            SqlDataReader reader = this.GetData(sql);
            if (reader.HasRows)
            {
                reader.Read();
                Product product = new Product();
                product.ProductId = (int)reader["ProductId"];
                product.ProductName = reader["ProductName"].ToString();
                product.Price = Convert.ToDouble(reader["Price"]);
                product.Quantity = (int)reader["Quantity"];
                product.CategoryId = (int)reader["CategoryId"];
                return product;
            }
            return null;
        }

        public bool CreateProduct(string productName, double price, int quantity, int categoryId)
        {
            string sql = "INSERT INTO Products(ProductName,Price,Quantity,CategoryId) VALUES('" + productName + "'," + price + "," + quantity + "," + categoryId + ")";

            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            else
                return false;

        }

        public bool UpdateProduct(int productId, string productName, double price, int quantity, int categoryId)
        {
            string sql = "UPDATE Products set ProductName='" + productName + "',Price=" + price + ",Quantity=" + quantity + ",CategoryId=" + categoryId + " where ProductId=" + productId;

            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            else
                return false;

        }

        public bool DeleteProduct(int productId)
        {
            string sql = "DELETE Products WHERE ProductId=" + productId;

            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            else
                return false;

        }
        public List<Product> GetProductListByNames(string str)
        {
            string sql = "SELECT * FROM Products WHERE ProductName LIKE '" + str + "%'";
            SqlDataReader reader = this.GetData(sql);
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product();
                product.ProductId = (int)reader["ProductId"];
                product.ProductName = reader["ProductName"].ToString();
                product.Price = Convert.ToDouble(reader["Price"]);
                product.Quantity = (int)reader["Quantity"];
                product.CategoryId = (int)reader["CategoryId"];
                products.Add(product);
            }
            return products;


        }
        public List<Product> GetProductsByCategoryId(int categoryId)
        {
            string sql = "SELECT * FROM Products WHERE CategoryId="+categoryId;
            SqlDataReader reader = this.GetData(sql);
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product();
                product.ProductId = (int)reader["ProductId"];
                product.ProductName = reader["ProductName"].ToString();
                product.Price = Convert.ToDouble(reader["Price"]);
                product.Quantity = (int)reader["Quantity"];
                product.CategoryId = (int)reader["CategoryId"];
                products.Add(product);
            }
            return products;
        }
        public List<Product> GetProductsById(int productId)
        {
            string sql = "SELECT * FROM Products WHERE ProductId=" + productId;
            SqlDataReader reader = this.GetData(sql);
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product();
                product.ProductId = (int)reader["ProductId"];
                product.ProductName = reader["ProductName"].ToString();
                product.Price = Convert.ToDouble(reader["Price"]);
                product.Quantity = (int)reader["Quantity"];
                product.CategoryId = (int)reader["CategoryId"];
                products.Add(product);
            }
            return products;
        }
    }
}
