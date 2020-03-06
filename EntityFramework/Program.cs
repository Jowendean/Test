using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new EfExampleEntities())
            {
                Console.WriteLine("All Students");
                var allstudents = db.Students.Select(s => s.Name);
                //new
                foreach(var v in allstudents)
                {
                    Console.WriteLine(v);
                }

                Console.ReadLine();
            }

        }
    }
}
