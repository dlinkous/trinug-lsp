using System;

namespace Liskov.Music
{
    public class Program
    {
		public void Execute()
		{
			var player = new Player();
			player.AddChord(GetA());
			player.AddChord(GetA());
			player.AddChord(GetA());
			player.AddChord(GetAminorArpeggiated());
			player.PlayAll();
		}

		private Chord GetA() => new Monochord(440);

		private Chord GetAminorArpeggiated() => new Trichord(440, 523.25m, 659.25m) { Arpeggiate = true };
	}
}
