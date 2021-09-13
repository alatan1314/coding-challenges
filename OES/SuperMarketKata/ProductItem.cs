using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace OES.SuperMarketKata
{
    public class ProductItem
    {
        public int Quantity { get; set; }
        public string SKU { get; set; }
        SampleDB myDB;

        public ProductItem(string item, SampleDB db)
        {
            Quantity = 0;
            SKU = "";
            myDB = db;
            SKU = item;
            Quantity = 1;
        }

        public int GetAmount()
        {
            DataRow[] myRow = myDB.GetSKUDetail(SKU);

            if ((int.Parse(myRow[0]["SpecialPriceUnit"].ToString()) == 0) || (Quantity < int.Parse(myRow[0]["SpecialPriceUnit"].ToString())))
                return (Quantity * int.Parse(myRow[0]["UnitPrice"].ToString()));
            else
            {
                double mydivi = (double) Quantity / int.Parse(myRow[0]["SpecialPriceUnit"].ToString());
                double remainder = mydivi - Math.Truncate(mydivi);

                int amount = (int)Math.Truncate(mydivi) * int.Parse(myRow[0]["SpecialPrice"].ToString());
                if (remainder > 0)
                    amount += int.Parse(myRow[0]["UnitPrice"].ToString());

                return amount;
            }
        }

    }
}
