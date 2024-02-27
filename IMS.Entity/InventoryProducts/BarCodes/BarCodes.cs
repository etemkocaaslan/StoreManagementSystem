namespace IMS.Entity.InventoryProducts
{
    public class BarCodes
    {
        public int BarCodeId { get; set; }
        public string BarCode { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
