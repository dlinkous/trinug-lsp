using System;

namespace Liskov.UserManagement
{
    public class Manager
    {
		public void Manage(User user)
		{
			switch (user.GetName())
			{
				case "Anonymous":
					break;
				case "Admin":
					DoAdminStuff(user);
					break;
				default:
					DoNormalStuff(user);
					break;
			}
			user.OtherStuff();
		}

		private void DoAdminStuff(User adminUser)
		{
			((AdminUser)adminUser).ActivateAdminPowers();
		}

		private void DoNormalStuff(User normalUser)
		{
			Console.WriteLine(((NormalUser)normalUser).Name);
		}
    }
}
