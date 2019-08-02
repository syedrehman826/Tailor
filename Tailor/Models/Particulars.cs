using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.Models
{
    class Particulars
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Particulars> GetList()
        {
            return new List<Particulars>()
            {
                //Upper 1
                //Lower 2
                new Particulars() {ID=0,Name="" },
                new Particulars() {ID=1,Name="Kurta" },
                new Particulars() {ID=1,Name="Shirt" },
                new Particulars() {ID=1,Name="Coat" },
                new Particulars() {ID=1,Name="Waist Coat" },
                new Particulars() {ID=1,Name="Sherwani" },
                new Particulars() {ID=2,Name="Pant" },
                new Particulars() {ID=2,Name="Touser" },
                new Particulars() {ID=2,Name="Sherwani" }
            };

        }
    }
}
