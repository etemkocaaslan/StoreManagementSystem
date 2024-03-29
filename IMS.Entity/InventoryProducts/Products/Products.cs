﻿namespace IMS.Entity.InventoryProducts
{
    public class Products
    {
        public int ProductId { get; set; }
        public string ProductIdTag { get; set; }
        public string ProductName { get; set; }
        public int BrandId { get; set; }
        public string ProductDescription { get; set; }
        public double ProductQuantityPerUnit { get; set; }
        public double ProductPerUnitPrice { get; set; }
        public double ProductMSRP { get; set; }
        public string ProductStatus { get; set; }
        public double ProductDiscountRate { get; set; }
        public double ProductSize { get; set; }
        public string ProductColor { get; set; }

        public double ProductWeight { get; set; }
        public int ProductUnitStock { get; set; }

        //public string BrandName { get; set; }
        //public string VendorName { get; set; }
        //public string ThirdCategoryName { get; set; }
        //public string SecondCategoryName { get; set; }
        //public string MainCategoryName { get; set; }

        //public virtual Brands Brand { get; set; }
    }
}
