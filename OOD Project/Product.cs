using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Project
{
    public enum Variation { All, Alcohol, Biscuits, ChilledMeats, Cigarettes, Dairies, FruitVeg, Minerals, SweetsCrisps }
    public class Product
    {
        //props
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int CaseSize { get; set; }
        public int StockLeft { get; set; }
        public string Supplier { get; set; }
        public string OrderDay { get; set; }
        public int Margin_ProductID { get; set; }
        public decimal UnitCost { get; set; }
        public decimal UnitSell { get; set; }
        public decimal ProfitMargin { get; set;}
        public decimal ProfitMarginp { get; set; }
        public Variation Section { get; set; }
       
    
    //ctors
    public Product(int id, int stockleft, string name, int casesize, string supplier, string orderday, int margin_productID, decimal unitcost, decimal unitsell, decimal profitmargin, decimal profitmarginp, Variation variation)
    {
        ProductID = id;
        Supplier = supplier;
        Name = name;
        CaseSize = casesize;
        StockLeft = stockleft;
        OrderDay = orderday;
       Margin_ProductID = margin_productID;
            UnitCost = UnitCost;
            UnitSell = UnitSell;
            ProfitMargin = profitmargin;
            ProfitMarginp = profitmarginp;
       Section = variation;
    }

        public Product()
        {

        }
        //methods

        //public int casesize()
        //{
        //    return $"{CaseSize}";
        //}
        //public int stockleft()
        //{
        //    return $"{StockLeft}";
        //}
        //public string supplier()
        //{
        //    return $"{Supplier}";
        //}


        public override string ToString()
        {
            return this.Name;
        }


    }
}
