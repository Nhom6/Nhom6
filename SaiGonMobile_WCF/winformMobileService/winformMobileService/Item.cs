using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winformMobileService
{
    public class Item
    {
        public string value { get; set; }
        public string display { get; set; }
        public Item(string value, string display)
        {
            this.value = value;
            this.display = display;
        }

    }
}
