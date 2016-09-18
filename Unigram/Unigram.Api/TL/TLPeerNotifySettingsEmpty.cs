// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLPeerNotifySettingsEmpty : TLPeerNotifySettingsBase 
	{
		public TLPeerNotifySettingsEmpty() { }
		public TLPeerNotifySettingsEmpty(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.PeerNotifySettingsEmpty; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x70A68512);
			if (cache) WriteToCache(to);
		}
	}
}