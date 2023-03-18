


using System.Numerics;
using task4_it;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            string? inp = null;
            while (inp != null || inp != "")
            {
                Console.WriteLine("1 - Create 'Product'\n2 - Create 'AgedProduct'");
                inp = Console.ReadLine();
                if (int.TryParse(inp, out int cmd))
                {
                    switch (cmd)
                    {
                        case 1:
                            Console.WriteLine("Enter name, price and quantity for 'Product'");
                            string? pInp = Console.ReadLine();
                            if (pInp != null)
                            {
                                string[] splittedInp = pInp.Split(' ');
                                if (
                                        splittedInp.Length == 3 && 
                                        double.TryParse(splittedInp[1], out double price) && 
                                        int.TryParse(splittedInp[2], out int quantity)
                                    )
                                {
                                    Console.WriteLine(new Product(splittedInp[0], price, quantity).ToString());
                                }
                            }

                            break;
                        case 2:
                            Console.WriteLine("Enter name, price, quantity, release year for 'AgedProduct'");
                            pInp = Console.ReadLine();
                            if (pInp != null)
                            {
                                string[] splittedInp = pInp.Split(' ');
                                if (
                                        splittedInp.Length == 4 &&
                                        double.TryParse(splittedInp[1], out double price) &&
                                        int.TryParse(splittedInp[2], out int quantity) &&
                                        int.TryParse(splittedInp[3], out int releaseYear)
                                    )
                                {
                                    Console.WriteLine(new AgedProduct(splittedInp[0], price, quantity, releaseYear).ToString());
                                }
                            }
                            break;
                        default:
                            Console.WriteLine("Unrecognised");
                            break;
                    }
                }
            }
        }
    }
}