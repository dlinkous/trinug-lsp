using System;
using Xunit;
using Liskov.Ordering;

namespace Liskov.Ordering.Tests
{
    public class PTests
    {
		[Fact]
		public void ProcessesS1()
		{
			var p = new P();
			p.ProcessT(new S1());
			// No assertions
		}

		[Fact]
		public void ProcessesS2()
		{
			var p = new P();
			p.ProcessT(new S2());
			// No assertions
		}
	}
}
