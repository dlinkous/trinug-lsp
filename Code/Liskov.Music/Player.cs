using System;
using System.Collections.Generic;

namespace Liskov.Music
{
    public class Player
    {
		private readonly List<Chord> chords = new List<Chord>();

		public void AddChord(Chord chord) => chords.Add(chord);

		public void PlayAll() => chords.ForEach(chord => chord.Play());
    }
}
