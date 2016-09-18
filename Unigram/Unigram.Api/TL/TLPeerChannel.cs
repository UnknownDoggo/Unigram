// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLPeerChannel : TLPeerBase 
	{
		public Int32 ChannelId { get; set; }

		public TLPeerChannel() { }
		public TLPeerChannel(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.PeerChannel; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			ChannelId = from.ReadInt32();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0xBDDDE532);
			to.Write(ChannelId);
			if (cache) WriteToCache(to);
		}
	}
}