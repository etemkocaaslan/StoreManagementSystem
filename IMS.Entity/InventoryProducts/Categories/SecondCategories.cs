namespace IMS.Entity.InventoryProducts
{
    public class SecondCategories
    {
        public int SecondCategoryId { get; set; }
        public string SecondCategoryName { get; set; }
        public int MainCategoryId { get; set; }
        public string SecondCategoryDescription { get; set; }
        public byte[] SecondCategoryImage { get; set; }

        //public string MainCategoryName { get; set; }

        //public virtual MainCategories MainCategory { get; set; }
        //public virtual ICollection<ThirdCategories> ThirdCategories { get; set; 
    }
}
