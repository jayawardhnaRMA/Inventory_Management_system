using ShopManagementSystem.Models;

namespace ShopManagementSystem.Helpers
{
    // Remembers who is logged in until they log out.
    public static class Session
    {
        public static User? CurrentUser { get; private set; }

        public static bool CanManageEmployees => CurrentUser?.Role is "Admin" or "Manager";

        public static void Start(User user)
        {
            CurrentUser = user;
        }

        public static void End()
        {
            CurrentUser = null;
        }
    }
}
