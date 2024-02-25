

namespace IMS.Entity.InventoryProducts.User;

using IMS.Entity.InventoryProducts.Orders;

public class Users
{
    public int Id { get; set; }
    public string UserId { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string EmailAddress { get; set; } = string.Empty;
    public int Age { get; set; } = 0;
    public string Role { get; set; } = string.Empty;
    public DateTime JoinDate { get; set; }
    public DateTime BirthDate { get; set; }
    public string PhoneNumber { get; set; } = string.Empty;

    public virtual ICollection<Orders> Orders { get; set; }
}

