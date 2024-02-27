namespace IMS.Entity.InventoryProducts
{
    public class OrdersProductsMap
    {
        public int OrderProductsCategoriesId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }

        public virtual Orders Order { get; set; }
        public virtual Products Product { get; set; }
    }
}
