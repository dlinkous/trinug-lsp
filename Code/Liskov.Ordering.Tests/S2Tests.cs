using System;
using Xunit;
using Liskov.Ordering;

namespace Liskov.Ordering.Tests
{
    public class S2Tests
    {
		[Fact]
		public void HappyPath()
		{
			var s2 = new S2();
			s2.Step2();
			s2.Step1();
			s2.Step3();
		}

		[Fact]
		public void InvalidOrderShouldThrowInvalidOperationException()
		{
			var s2 = new S2();
			Assert.Throws<InvalidOperationException>(() =>
			{
				s2.Step1();
			});
		}
	}
}
