using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace databasedemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new databaseEntities())
            {

                var query = from b in db.Students
                            orderby b.Firstname
                            select b;

                Console.WriteLine("All All student in the database:");

                foreach (var item in query)
                {
                    Console.WriteLine(item.Firstname + " " + item.Lastname);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
