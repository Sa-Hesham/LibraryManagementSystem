using LibraryManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DataSeeding
{
    public static class SeedingData
    {
       public static bool seeding  <T>(string FilePath , LibraryDbcontext dbcontext) where T : class
        {
            if ( !File.Exists(FilePath)) throw new FileNotFoundException("The specified file was not found.", FilePath); 

            var data = File.ReadAllText(FilePath);
            if (String.IsNullOrEmpty(data)) return false;



           if (dbcontext.Set<T>().Any()  ) return false;




            var options = new JsonSerializerOptions()
            {

                PropertyNameCaseInsensitive = true,

                Converters = { new JsonStringEnumConverter() }

            };

            //convert json file to  list of obects  obj 
            var libraryData = JsonSerializer.Deserialize<List<T>>(data, options);

            if (libraryData == null) return false;



            //add data to database 

            dbcontext.Set<T>().AddRange(libraryData);
            dbcontext.SaveChanges();
            return true;


        }

    }
}
