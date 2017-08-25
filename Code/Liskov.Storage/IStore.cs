using System;

namespace Liskov.Storage
{
    public interface IStore
    {
		byte[] Read(string key);
    }
}
