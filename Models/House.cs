using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpGregslist.Models
{
    public class House
    {
        public int Id { get; set; }
        public int Bedrooms { get; set; }
        public int Bathrooms { get; set; }
        public int Year { get; set; } = 1900;
        public double? Price { get; set; } = 1.00;
        public string Description { get; set; }
        public string ImgUrl { get; set; }
    }
}