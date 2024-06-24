using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstData.Models
{
    internal class Book
    {
        public int id { get; set; }
        public string name { get; set; }
        public string genre { get; set; }
        public int page_nubmer { get; set; }
        public int price { get; set; }
    }
}
