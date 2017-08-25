using System;
using Xunit;
using Liskov.Ordering;

namespace Liskov.Ordering.Tests
{
    public class S1Tests
    {
        [Fact]
        public void HappyPath()
        {
			var s1 = new S1();
			s1.Step1();
			s1.Step2();
			s1.Step3();
		}

		[Fact]
		public void InvalidOrderShouldThrowInvalidOperationException()
		{
			var s1 = new S1();
			Assert.Throws<InvalidOperationException>(() =>
			{
				s1.Step2();
			});
		}
	}
}
