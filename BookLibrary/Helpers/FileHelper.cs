using BookLibrary.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Helpers
{
    public class FileHelper
    {
        public static void WriteBooks(List<Book> books)
        {
            var serializer = new JsonSerializer();

            using (var sw = new StreamWriter("books.json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Formatting.Indented;
                    serializer.Serialize(jw, books);
                }
            }
        }

        public static List<Book> ReadBooks()
        {
            List<Book> books = null;
            var serializer = new JsonSerializer();
            using (var sr = new StreamReader("books.json"))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    books = serializer.Deserialize<List<Book>>(jr);
                }
            }
            return books;
        }
    }
}
