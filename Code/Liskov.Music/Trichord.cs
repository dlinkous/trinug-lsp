using System;

namespace Liskov.Music
{
	public class Trichord : Chord
	{
		private readonly decimal frequency1;
		private readonly decimal frequency2;
		private readonly decimal frequency3;

		public bool Arpeggiate { get; set; }

		public Trichord(decimal frequency1, decimal frequency2, decimal frequency3)
		{
			this.frequency1 = frequency1;
			this.frequency2 = frequency2;
			this.frequency3 = frequency3;
		}

		protected override void PlayChord()
		{
			if (Arpeggiate)
			{
				// Call instrument three times, each call sending one note frequency
			}
			{
				// Call instrument one time, with all three note frequencies
			}
		}
	}
}
