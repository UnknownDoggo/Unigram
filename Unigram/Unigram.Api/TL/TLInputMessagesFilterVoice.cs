// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLInputMessagesFilterVoice : TLMessagesFilterBase 
	{
		public TLInputMessagesFilterVoice() { }
		public TLInputMessagesFilterVoice(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.InputMessagesFilterVoice; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x50F5C392);
			if (cache) WriteToCache(to);
		}
	}
}