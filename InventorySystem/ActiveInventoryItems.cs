using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    internal class ActiveInventoryItems
    {
        public int ItemID { get; set; }
        public String ItemCode { get; set; }
        public String ItemName { get; set; }
        public String DisplayName { get; set; }
        public String Description { get; set; }
        public String DateAdded { get; set; }
        public double DP { get; set; }
        public double SRP { get; set; }
        public double VAT { get; set; }
        public double EffectivePrice { get; set; }
        public int Quantity { get; set; }

    }
}
