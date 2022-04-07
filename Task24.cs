using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lynq
{
    class Task24
    {
        
            
            public static void Main()
            {
                IList<BookStore> StrData = new List<BookStore>()
                {
                  new BookStore() { BookID = 1, Title = "TheAlchemist", Author ="PauloColehlo", Price =350 },
                 new BookStore() { BookID = 2, Title = "AgathaChristy", Author ="Christy", Price =200 },
                 new BookStore() { BookID = 3, Title = "HarryPotter", Author = "J.K.Rowling", Price =600 },
                 new BookStore() { BookID = 4, Title = "TheBookThief", Author = "MarkusZusak", Price =500 },
                 new BookStore() { BookID = 5, Title = "TheWingsOfFire", Author ="APJ.AbdulKalam", Price =1000},
                };
            //Display all Data
                var myQry = from str in StrData
                            select str;
                foreach (var s in myQry)
                    Console.WriteLine("{0} {1} {2} {3}",s.BookID,s.Title,s.Author,s.Price);

                Console.WriteLine("***********************");

            //Order by Author
               var stuqry = StrData.OrderBy(s => s.Author);
               foreach (var s in stuqry)
                Console.WriteLine(s.Author);

            Console.WriteLine("***********************");

            //order by Price
            var stuqry2 = StrData.OrderBy(s => s.Price);
               foreach (var s in stuqry2)
                Console.WriteLine(s.Price);

            Console.WriteLine("***********************");

            //particular author
            string A = Console.ReadLine();
            var stuqry3 = from str in StrData
                          select str;
            foreach (var s in stuqry)
                if (A == s.Author)
                {
                    Console.WriteLine(s.Title);
                }


        }
    }
    class BookStore
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
    }
}

