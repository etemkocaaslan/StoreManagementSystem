namespace IMS.Entity.InventoryProducts
{
    public class ThirdCategories
    {
        public int ThirdCategoryId { get; set; }
        public string ThirdCategoryName { get; set; }
        public int SecondCategoryId { get; set; }
        public string ThirdCategoryDescription { get; set; }
        public byte[] ThirdCategoryImage { get; set; }

        //public string SecondCategoryName { get; set; }

        //public virtual SecondCategories SecondCategory { get; set; }
        //public virtual ICollection<Vendors> Vendors { get; set; }
    }
}
