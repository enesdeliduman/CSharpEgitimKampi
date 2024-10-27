using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Menu Siparis Islem Sayfasi *****");

            #region Kategori ekleme islemi
            //Console.Write("Ekllemek istediginiz kategori adi : ");
            //string categoryName = Console.ReadLine(); 
            //SqlConnection connection = new SqlConnection("Data Source=ENES;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("INSERT INTO TblCategory (CategoryName) values(@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Kategori basariyla eklendi");
            #endregion

            #region Urun ekleme islemi

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Eklemek istediginiz urun adi : ");
            //productName = Console.ReadLine();

            //Console.Write("Eklemek istediginiz urunun fiyati : ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=ENES;initial Catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("INSERT INTO TblProduct (ProductName,ProductPrice,ProductStatus) VALUES (@productName,@productPrice,@productStatus)", connection);
            //command.Parameters.AddWithValue("@productName",productName);
            //command.Parameters.AddWithValue("@productPrice",productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Urun eklendi");
            #endregion

            #region Urun Listeleme Islemi

            //SqlConnection connection = new SqlConnection("Data Source=ENES;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("SELECT * FROM TblProduct", connection);

            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray) { 
            //    Console.WriteLine(item.ToString());
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();

            #endregion

            #region Urun silme islemi

            //Console.Write("Silinecek urun id : ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=ENES;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("DELETE FROM TblProduct WHERE ProductID=@productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //Console.WriteLine("Silme islemi yapildi");
            //connection.Close();

            #endregion

            #region urun guncelleme islemi

            Console.Write("Guncellenecek urun id : ");
            int productId = int.Parse(Console.ReadLine());

            Console.Write("Guncellenecek urun adi : ");
            string productName = Console.ReadLine();

            Console.Write("Guncellenecek urun fiyati : ");
            decimal productPrice = decimal.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source=ENES;initial Catalog=EgitimKampiDb;integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("UPDATE TblProduct SET ProductName=@productName,ProductPrice=@productPrice WHERE ProductID=@productId",connection);
            command.Parameters.AddWithValue("@productId", productId);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("Guncelleme tamamlandii");
            #endregion
            Console.Read();
        }
    }
}
