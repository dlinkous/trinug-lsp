using System;

namespace Liskov.UserManagement
{
    public class AdminUser : User
    {
		public override string GetName()
		{
			return "Admin";
		}

		public void ActivateAdminPowers()
		{
			// Admin powers
		}
	}
}
