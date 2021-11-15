using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace IM91_LINQ_Console_DF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tim hieu LINQ - DotNet Framework");
            // Slide 9
            /*
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
            IEnumerable<int> subset
                = from i in numbers
                  where i < 10
                  select i;
            foreach (int i in subset)
                Console.WriteLine("Item: {0}", i);
            */

            //Slide 11
            /*string[] fruits = { "Chuoi", "Thanh Long","Sau rieng",
                "Cam", "Dua Hau"};
            IEnumerable<string> subset = from g in fruits
                                         where g.Contains(" ")
                                         orderby g
                                         select g;
            foreach (string s in subset)
                Console.WriteLine("Item : {0}", s);
            */

            // SLIDE 15
            /*int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            IEnumerable<int> subset = nums.Where(n => n % 2 == 0);
            foreach (var n in subset)
                Console.WriteLine("Even number: {0}", n);
            */

            // SLIDE 19 - 20
            List<Car> myCars = new List<Car>()
            {
                new Car{ PetName="Xe1", Color="Bạc", Speed=100, Make="BMW"},
                new Car{ PetName="Xe2", Color="Đen", Speed=55, Make="Toyota"},
                new Car{ PetName="Xe3", Color="Xanh", Speed=5, Make="Honda"},
                new Car{ PetName="Xe4", Color="Trắng", Speed=43, Make="Ford"},
            };
            // lấy ra xe có tốc độ lớn hơn 50
            /*
            IEnumerable<Car> subset = from c in myCars
                                      where c.Speed > 50
                                      select c;
            Console.WriteLine("********* CACH 1 ********");
            foreach (var c in subset)
            {
                Console.WriteLine(" - Car: {0} - {1} - {2} - {3}", c.PetName,
                    c.Color, c.Speed, c.Make);
            }

            IEnumerable<Car> subset2 = myCars.Where(c => c.Speed > 50);
            Console.WriteLine("\n********* CACH 2 ********");
            foreach (var c in subset2)
            {
                Console.WriteLine(" - Car: {0} - {1} - {2} - {3}", c.PetName,
                    c.Color, c.Speed, c.Make);
            }
            */

            // SLIDE 22-23-24-25-26-27
            /*
            Categories[] categories = new Categories[]
            {
                new Categories{CategoryId=1, CategoryName="Nuoc ngot"},
                new Categories{CategoryId=2, CategoryName="Van phong pham"},
                new Categories{CategoryId=3, CategoryName="Thuc pham"}
            };
            Products[] products = new Products[]
            {
                new Products {ProductId =11, ProductName="Pepsi",
                    NumberInStock= 10, CategoryId=1},
                new Products {ProductId =12, ProductName="Coca",
                    NumberInStock= 20, CategoryId=1},
                new Products {ProductId =21, ProductName="But bi",
                    NumberInStock= 100, CategoryId=2},
                new Products {ProductId =23, ProductName="But chi",
                    NumberInStock= 50, CategoryId=2},
                new Products {ProductId =24, ProductName="But muc",
                    NumberInStock= 15, CategoryId=2}
            };
            var allProducts = from p in products
                              select p;
            foreach (var p in allProducts)
                Console.WriteLine(p.ToString());

            var cate2 = from p in products
                        where p.CategoryId == 2
                        select p;
            Console.WriteLine("\nCac sp co cateID =2 : ");
            foreach (var p in cate2)
                Console.WriteLine(p.ToString());
            ///
            var nameDesc = from p in products
                           select new
                           {
                               p.ProductId,
                               p.ProductName
                           };
            Console.WriteLine("\nSLIDE so 24: ");
            foreach (var p in nameDesc)
                Console.WriteLine(p.ToString());
            ///
            var nameDesc2 = products.Select(p => new { p.ProductId, p.ProductName });
            Console.WriteLine("\nSLIDE so 25: ");
            foreach (var p in nameDesc2)
                Console.WriteLine(p.ToString());
            ///26
            var overstock = from p in products
                            where p.NumberInStock > 25
                            select p;
            Console.WriteLine("\nSLIDE so 26, Over stock ");
            foreach (var p in overstock)
                Console.WriteLine(p.ToString());
            ///27
            var overstock2 = products.Where(p => p.NumberInStock > 25);
            Console.WriteLine("\nSLIDE so 27, Over stock cach 2 ");
            foreach (var p in overstock2)
                Console.WriteLine(p.ToString());
            */

            // SLIDE 28
            /*
            ArrayList myStuff = new ArrayList();
            myStuff.AddRange(new Object[] { 10,400,8, false,
            new Car(),"string data"});
            var myInts = myStuff.OfType<int>();
            foreach (int i in myInts)
                Console.WriteLine("Int value: {0}", i);
            */

            // SLIDE 29
            /*
            ArrayList myCars = new ArrayList()
            {
                new Car{ PetName="Xe1", Color="Bạc", Speed=100, Make="BMW"},
                new Car{ PetName="Xe2", Color="Đen", Speed=55, Make="Toyota"},
                new Car{ PetName="Xe3", Color="Xanh", Speed=5, Make="Honda"},
                new Car{ PetName="Xe4", Color="Trắng", Speed=43, Make="Ford"}
            };
            var myCarsEnum = myCars.OfType<Car>();
            var fastCars = from c in myCarsEnum
                           where c.Speed > 55
                           select c;
            foreach (var c in fastCars)
                Console.WriteLine("{0} is going too fast!!", c.PetName);
            */

            // SLIDE 30
            /*
            Products[] products = new Products[]
            {
                new Products {ProductId =11, ProductName="Pepsi",
                    NumberInStock= 10, CategoryId=1},
                new Products {ProductId =12, ProductName="Coca",
                    NumberInStock= 20, CategoryId=1},
                new Products {ProductId =21, ProductName="But bi",
                    NumberInStock= 100, CategoryId=2},
                new Products {ProductId =23, ProductName="But chi",
                    NumberInStock= 50, CategoryId=2},
                new Products {ProductId =24, ProductName="But muc",
                    NumberInStock= 15, CategoryId=2}
            };
            var subset = from p in products
                         orderby p.ProductName
                         select p;
            Console.WriteLine("Ordered by Name:");
            foreach (var p in subset)
                Console.WriteLine(p.ToString());
            // SLIDE 31
            var subset2 = products.OrderBy(p => p.ProductName);
            Console.WriteLine("Ordered by Name - Cach 2:");
            foreach (var p in subset2)
                Console.WriteLine(p.ToString());
            */

            // SLIDE 32
            /*
            Products[] products = new Products[]
            {
                new Products {ProductId =11, ProductName="Pepsi",
                    NumberInStock= 10, CategoryId=1},
                new Products {ProductId =12, ProductName="Coca",
                    NumberInStock= 20, CategoryId=1},
                new Products {ProductId =21, ProductName="But bi",
                    NumberInStock= 100, CategoryId=2},
                new Products {ProductId =23, ProductName="But chi",
                    NumberInStock= 50, CategoryId=2},
                new Products {ProductId =24, ProductName="But muc",
                    NumberInStock= 15, CategoryId=2}
            };
            var subset = products.OrderBy(p => p.ProductName)
                .ThenBy(p => p.ProductId);           
            Console.WriteLine("Ordered by Name, ID - Cach 2:");
            foreach (var p in subset)
                Console.WriteLine(p.ToString());
            // sap xep theo CatgoryId tang dan, NumberInStock tang dan
            var subset2 = products.OrderBy(p => p.CategoryId)
                .ThenBy(p => p.NumberInStock);
            Console.WriteLine("\nOrdered by Category, Stock - Cach 2:");
            foreach (var p in subset2)
                Console.WriteLine(p.ToString());
            */

            //SLIDE 33
            /*
            Products[] products = new Products[]
            {
                new Products {ProductId =11, ProductName="Pepsi",
                    NumberInStock= 10, CategoryId=1},
                new Products {ProductId =12, ProductName="Coca",
                    NumberInStock= 20, CategoryId=1},
                new Products {ProductId =21, ProductName="But bi",
                    NumberInStock= 100, CategoryId=2},
                new Products {ProductId =23, ProductName="But chi",
                    NumberInStock= 50, CategoryId=2},
                new Products {ProductId =24, ProductName="But muc",
                    NumberInStock= 15, CategoryId=2}
            };
            var query = from p in products
                        group p by p.CategoryId;
            foreach (var category in query)
            {
                Console.WriteLine("\n--- Category ID ={0} ----", category.Key);
                foreach (var item in category)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            // Slide 34
            var query2 = products.GroupBy(p => p.CategoryId);
            Console.WriteLine("\n\nGroup by CategoryID - Cach 2");
            foreach (var category in query2)
            {
                Console.WriteLine("\n--- Category ID = {0} ----", category.Key);
                foreach (var item in category)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            */

            //SLIDE 35
            Categories[] categories = new Categories[]
            {
                new Categories{CategoryId=1, CategoryName="Nuoc ngot"},
                new Categories{CategoryId=2, CategoryName="Van phong pham"},
                new Categories{CategoryId=3, CategoryName="Thuc pham"}
            };
            Products[] products = new Products[]
            {
                new Products {ProductId =11, ProductName="Pepsi",
                    NumberInStock= 10, CategoryId=1},
                new Products {ProductId =12, ProductName="Coca",
                    NumberInStock= 20, CategoryId=1},
                new Products {ProductId =21, ProductName="But bi",
                    NumberInStock= 100, CategoryId=2},
                new Products {ProductId =23, ProductName="But chi",
                    NumberInStock= 50, CategoryId=2},
                new Products {ProductId =24, ProductName="But muc",
                    NumberInStock= 15, CategoryId=2}
            };
            var query = from p in products
                        join c in categories
                        on p.CategoryId equals c.CategoryId
                        group p by new
                        {
                            c.CategoryId,
                            c.CategoryName
                        };
            foreach (var category in query)
            {
                Console.WriteLine(category.Key);
                foreach (var item in category)
                {
                    Console.WriteLine(item.ToString());
                }
            }

        }
    }
}
