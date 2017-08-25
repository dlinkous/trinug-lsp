using System;

namespace Liskov.Music
{
    public abstract class Chord
    {
		protected abstract void PlayChord();

		public void Play()
		{
			PrePlay();
			PlayChord();
			PostPlay();
		}

		private void PrePlay()
		{
			// Pre-play functionality
		}

		private void PostPlay()
		{
			// Post-play functionality
		}
    }
}
