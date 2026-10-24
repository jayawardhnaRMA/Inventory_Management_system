namespace ShopManagementSystem.Models
{
    // Implemented by anyone the shop can contact by phone or email.
    public interface IContactable
    {
        string Phone { get; set; }
        string Email { get; set; }
    }
}
