using System;

namespace Liskov.UserManagement
{
	public class AnonymousUser : User
	{
		public override string GetName()
		{
			return "Anonymous";
		}
	}
}
