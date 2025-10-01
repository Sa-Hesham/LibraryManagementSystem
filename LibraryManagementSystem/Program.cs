using LibraryManagementSystem.Data;
using LibraryManagementSystem.DataSeeding;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using LibraryDbcontext db =new LibraryDbcontext();    
            bool data = false;


            try
            {
                // data = SeedingData.seeding<Member>("Files/Members.json", db);
                // data = SeedingData.seeding<Category>("Files/Categories.json", db);
                // data = SeedingData.seeding<Author>("Files/Authors.json", db);
                data = SeedingData.seeding<Book>("Files/Books.json", db);

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(" File not found: " + ex.FileName);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error while seeding Airlines: {ex.Message}");



            }


            if (data)
            {

                Console.WriteLine(" Airlines data saved successfully.");
            }
          
        }
    }
}
