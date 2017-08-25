using System;

namespace Liskov.Music
{
	public class Monochord : Chord
	{
		private readonly decimal frequency;

		public Monochord(decimal frequency) => this.frequency = frequency;

		protected override void PlayChord()
		{
			// Call instrument with single note frequency
		}
	}
}
