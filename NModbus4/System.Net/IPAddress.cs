using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Net
{
	//https://referencesource.microsoft.com/#System/net/System/Net/IPAddress.cs
	public class IPAddress
	{
		public static short HostToNetworkOrder(short host)
		{
#if BIGENDIAN
            return host;
#else
			return (short)((((int)host & 0xFF) << 8) | (int)((host >> 8) & 0xFF));
#endif
		}

		public static short NetworkToHostOrder(short network)
		{
			return HostToNetworkOrder(network);
		}
	}
}
