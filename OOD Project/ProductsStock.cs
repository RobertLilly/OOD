//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OOD_Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductsStock
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductSection { get; set; }
        public string Supplier { get; set; }
        public string OrderDay { get; set; }
        public int CaseSize { get; set; }
        public int StockLeft { get; set; }
    
        public virtual ProductsMargin ProductsMargin { get; set; }
    }
}
