using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4_it
{
    internal class AgedProduct : Product
    {
        public int ReleaseYear { get; set; }

        public AgedProduct(string name, double price, int quantity, int releaseYear) : base(name, price, quantity)
        {
            ReleaseYear = releaseYear;
        }

        public override double GetQuality()
        {
            return base.GetQuality() + 0.5 * (DateTime.Now.Year - ReleaseYear);
        }

        public override string? ToString()
        {
            return $"AgedProduct: {Name}, price = {Price}, quantity = {Quantity}, releaseYear = {ReleaseYear}, Q = {GetQuality()}";
        }
    }
}
