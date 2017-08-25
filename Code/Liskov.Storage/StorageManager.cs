using System;
using System.IO;
using System.Net.Sockets;

namespace Liskov.Storage
{
    public class StorageManager
    {
		private readonly IStore store;

		public StorageManager(IStore store) => this.store = store;

		public ReadResponse Read(string key)
		{
			byte[] data = null;
			try
			{
				data = store.Read(key);
			}
			catch (FileNotFoundException)
			{
				return new ReadResponse() { Data = data, Successful = false };
			}
			catch (SocketException)
			{
				return new ReadResponse() { Data = data, Successful = false };
			}
			return new ReadResponse() { Data = data, Successful = true };
		}
    }
}
