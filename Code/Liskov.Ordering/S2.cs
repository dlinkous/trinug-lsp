using System;

namespace Liskov.Ordering
{
	public class S2 : T
	{
		private bool step1Complete;
		private bool step2Complete;
		private bool step3Complete;

		public override void Step1()
		{
			VerifyStepViaAssertions(false, true, false);
			step1Complete = true;
		}

		public override void Step2()
		{
			VerifyStepViaAssertions(false, false, false);
			step2Complete = true;
		}

		public override void Step3()
		{
			VerifyStepViaAssertions(true, true, false);
			step3Complete = true;
		}

		private void VerifyStepViaAssertions(bool step1, bool step2, bool step3)
		{
			if (step1Complete != step1) throw new InvalidOperationException();
			if (step2Complete != step2) throw new InvalidOperationException();
			if (step3Complete != step3) throw new InvalidOperationException();
		}
	}
}
