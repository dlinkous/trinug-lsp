using System;

namespace Liskov.Ordering
{
    public class P
    {
		public void ProcessT(T t)
		{
			if (t is S1)
			{
				t.Step1();
				t.Step2();
			} else if (t is S2)
			{
				t.Step2();
				t.Step1();
			}
			t.Step3();
			t.OtherStuff();
		}
	}
}
