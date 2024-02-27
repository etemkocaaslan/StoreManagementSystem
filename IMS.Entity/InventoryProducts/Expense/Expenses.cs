namespace IMS.Entity.InventoryProducts.Expense
{
    public class Expenses
    {
        public int      ExpenseId    {get;  set;}
        public string   ExpenseName  { get; set; }
        public double   ExpenseAmount{ get; set; }
        public DateTime ExpenseDate  { get; set; }
    }
}
