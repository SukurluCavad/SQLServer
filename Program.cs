using FirstData.DAL;
using FirstData.Models;

namespace FirstData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InsertBook();
            
        }
        static void InsertBook()
        {
            AppDbContex dbContex = new AppDbContex();
            dbContex.Books.Add(new Book { name = "Cinayet ve Ceza" });
            dbContex.SaveChanges();
        }
        static void DeleteBook()
        {
            AppDbContex dbContex=new AppDbContex();
            dbContex.Books.Remove(new Book { name = "Cinayet ve Ceza" });
            dbContex.SaveChanges();
        }
    }
}
