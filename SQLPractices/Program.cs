using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLPractices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Veri Tabanına Bağlanma

            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; initial catalog=Sirket_Takip;integrated security=true");

            #endregion


            // Bağlantı açma -> connection.Open();

            Console.WriteLine("Başarıyla bağlandı");

            #region CRUD İşlemleri

            /* READ

            SqlCommand read = new SqlCommand("SELECT * FROM Department", connection);

            SqlDataAdapter adapter = new SqlDataAdapter(read); // SqlDataAdapter, SqlCommand ile veri tabanından veri çekmek için kullanılır.

            DataTable datatable = new DataTable(); // DataTable, verileri saklamak için kullanılan bir veri yapısıdır.

            adapter.Fill(datatable); // Fill metodu, SqlDataAdapter ile veri tabanından çekilen verileri DataTable'a doldurur.

            connection.Close();
            
            foreach(DataRow row in datatable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item + " ");
                }
            }
            
            */

            /* CREATE

            Console.WriteLine("Departman adı giriniz: ");
            string DepartmentName = Console.ReadLine();

            Console.WriteLine("Departmanda çalışan kişi sayısı: ");
            int EmployeeNumber = int.Parse(Console.ReadLine());

            SqlCommand command = new SqlCommand("INSERT INTO Department (DepartmentName, EmployeeNumber) VALUES (@DepartmentName, @EmployeeNumber)", connection);
            command.Parameters.AddWithValue("@DepartmentName", DepartmentName);
            command.Parameters.AddWithValue("@EmployeeNumber", EmployeeNumber);

            command.ExecuteNonQuery();

            Console.WriteLine("Başarıyla eklendi !");

            connection.Close();

            */

            /* UPDATE

            Console.WriteLine("Güncellemek istediğiniz departman ID: ");
            int DepartmentID = int.Parse(Console.ReadLine());

            Console.WriteLine("Departman ismi: ");
            string DepartmentName = Console.ReadLine();

            Console.WriteLine("Çalışan Sayısı: ");
            string EmployeeNumber = Console.ReadLine();

            SqlCommand command = new SqlCommand("UPDATE Department SET EmployeeNumber = @EmployeeNumber, DepartmentName = @DepartmentName WHERE DepartmentID = @DepartmentID", connection);
            command.Parameters.AddWithValue("@DepartmentID", DepartmentID);
            command.Parameters.AddWithValue("@DepartmentName", DepartmentName);
            command.Parameters.AddWithValue("@EmployeeNumber", EmployeeNumber);

            command.ExecuteNonQuery();

            connection.Close();

            Console.WriteLine("Başarıyla Eklendi !!");

            */

            /* DELETE

            int DepartmentId;

            Console.Write("Silmek istediğiniz departman ID: ");
            DepartmentId = int.Parse(Console.ReadLine());

            SqlCommand command = new SqlCommand("DELETE FROM Department WHERE DepartmentID = @DepartmentID", connection);

            command.Parameters.AddWithValue("@DepartmentID", DepartmentId);

            command.ExecuteNonQuery();

            Console.WriteLine("Başarıyla silindi !!");

            */

            #endregion


            Console.ReadLine();

        }
    }
}
