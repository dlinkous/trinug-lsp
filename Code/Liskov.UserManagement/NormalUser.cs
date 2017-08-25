using System;

namespace Liskov.UserManagement
{
    public class NormalUser : User
    {
		public string Name { get; set; }

		public override string GetName()
		{
			return Name;
		}
	}
}
