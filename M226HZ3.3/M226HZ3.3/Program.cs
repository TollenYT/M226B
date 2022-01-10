using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace M226HZ3._3
{
    class Program
    {
        public class Product
        {
            public string Name { get; set; }
            public DateTime ExpiryDate { get; set; }
            public decimal Price { get; set; }
            public List<OldPrices> OldPrices { get; set; }
        }
        public class OldPrices
        {
            public decimal Price { get; set; }
            public DateTime Date { get; set; }
        }
        public static async Task Main()
        {
            //Console.WriteLine("enter radius");
            //string radiusString = Console.ReadLine();
            //double radius = Int32.Parse(radiusString);

            //Console.WriteLine("calculating...");
            //double circle = Math.PI * radius * 2;

            //Console.WriteLine("result: " + circle);

            //Console.WriteLine("enter first number");
            //string number1String = Console.ReadLine();

            //Console.WriteLine("enter second number");
            //string number2String = Console.ReadLine();

            //int number1 = Int32.Parse(number1String);
            //int number2 = Int32.Parse(number2String);

            //int result = number1 + number2;

            //Console.WriteLine("result: " + result);
            bool boolean = false;
            string fileName = @"C:\GIBZ\M226B\M226HZ3.3\data.json";

            while (boolean == false)
            {
                Console.WriteLine("enter read for read jsonfile or add for add jsonfile or exit ");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "read":
                        Product items;
                        using (StreamReader r = new StreamReader(fileName))
                        {
                            string json = r.ReadToEnd();
                            items = JsonConvert.DeserializeObject<Product>(json);
                        }
                        Console.WriteLine("Name:        " + items.Name);
                        Console.WriteLine("ExpiryDate:  " + items.ExpiryDate);
                        Console.WriteLine("Price:       " + items.Price);
                        Console.WriteLine("OldPrices:");
                        foreach (var item in items.OldPrices)
                        {
                            Console.WriteLine("     Price:      " + item.Price);
                            Console.WriteLine("     Date:       " + item.Date);
                        }
                        break;
                    case "add":
                        Console.WriteLine("enter name");
                        string name = Console.ReadLine();

                        Console.WriteLine("enter date");
                        string dateString = Console.ReadLine();
                        DateTime date = DateTime.Parse(dateString);


                        Console.WriteLine("enter price");
                        string priceString = Console.ReadLine();
                        decimal price = Convert.ToDecimal(priceString);

                        List<OldPrices> oldPricesList = new List<OldPrices>();

                        bool oldpricebool = false;
                        while (oldpricebool == false)
                        {
                            try
                            {
                                Console.WriteLine("enter for oldprice price");
                                decimal oldPrice = (Convert.ToDecimal(Console.ReadLine()));

                                Console.WriteLine("enter for oldprice date");
                                DateTime oldDate = (Convert.ToDateTime(Console.ReadLine()));

                                OldPrices oldPrices = new OldPrices()
                                {
                                    Price = oldPrice,
                                    Date = oldDate
                                };
                                oldPricesList.Add(oldPrices);
                            }
                            catch (Exception e)
                            {
                                oldpricebool = true;
                            }
                            
                        }
                        Product product = new Product();

                        product.Name = name;
                        product.ExpiryDate = date;
                        product.Price = price;
                        product.OldPrices = oldPricesList;

                        string output = JsonConvert.SerializeObject(product);

                        File.WriteAllText(fileName, output);

                        break;
                    case "exit":
                        boolean = true;
                        break;
                }
            }
            
        }
    }
}