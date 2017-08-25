using System;

namespace Liskov.Storage
{
    public class SimpleStorageManager
    {
		private readonly IStore store;

		public SimpleStorageManager(IStore store) => this.store = store;

		public ReadResponse Read(string key) => new ReadResponse() { Data = store.Read(key), Successful = true };
	}
}
