using System;

namespace Liskov.Storage
{
    public class SimplestStorageManager
    {
		private readonly IStore store;

		public SimplestStorageManager(IStore store) => this.store = store;

		public byte[] Read(string key) => store.Read(key);
	}
}
