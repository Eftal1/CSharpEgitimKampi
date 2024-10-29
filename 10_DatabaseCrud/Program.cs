using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region KategoriEklemeIslemi
            ////Crud --> Create, Read, Update, Delete
            //Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            //Console.WriteLine();

            //Console.WriteLine("---------------------------------");
            //Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();


            //SqlConnection connection =  new SqlConnection("Data Source=EFTALY\\EFTSRV; initial Catalog = EgitimKampiDb; integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("INSERT INTO TblCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Kaegori Başarıyla Eklendi");
            #endregion

            #region UrunEklemeIslemi

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            //Console.WriteLine();

            //Console.WriteLine("---------------------------------");
            //Console.Write("Ürün Adı: ");
            //productName = Console.ReadLine();

            //Console.Write("Ürün Fiyat: ");
            //productPrice = decimal.Parse(Console.ReadLine());


            //SqlConnection connection = new SqlConnection("Data Source=EFTALY\\EFTSRV; initial Catalog = EgitimKampiDb; integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("INSERT INTO TblProduct (ProductName, ProductPrice, ProductStatus) values (@productName, @productPrice, @productStatus)", connection);

            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);

            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Ürün Başarıyla Eklendi");
            #endregion

            #region UrunListelemeIslemi

            //SqlConnection connection = new SqlConnection("Data Source=EFTALY\\EFTSRV; initial Catalog = EgitimKampiDb; integrated security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("SELECT * FROM TblProduct",connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " " );
            //    }
            //    Console.WriteLine();
            //}


            //connection.Close();

            #endregion

            #region UrunSilmeIslemi

            //Console.WriteLine("***** Ürün İşlem Paneli *****");
            //Console.WriteLine();

            //Console.WriteLine("---------------------------------");
            //Console.Write("Silmek İstediğiniz Ürün ID Giriniz: ");
            //int ProductId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=EFTALY\\EFTSRV; initial Catalog = EgitimKampiDb; integrated security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("DELETE FROM TblProduct WHERE ProductId = @ProductId",connection);
            //command.Parameters.AddWithValue("@productId", ProductId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Silme İşlemi Tamamlandı");

            #endregion

            #region UrunGuncellemeIslemi

            //Console.WriteLine("***** Ürün İşlem Paneli *****");
            //Console.WriteLine();

            //Console.WriteLine("---------------------------------");

            //Console.Write("Güncellemek İstediğiniz Ürün ID Giriniz: ");
            //int productID = int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek Ürün Adı: ");
            //string productName = Console.ReadLine();

            //Console.Write("Güncellenecek Ürün Fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=EFTALY\\EFTSRV; initial Catalog = EgitimKampiDb; integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("UPDATE TblProduct SET ProductName=@productName, ProductPrice = @productPrice WHERE ProductId = @productID", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productID);
            //command.ExecuteNonQuery();

            //connection.Close();
            //Console.WriteLine("Güncelleme Başarılı");

            #endregion

            Console.Read();

        }
    }
}
