// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLMessagesAffectedMessages : TLObject, ITLMultiPts 
	{
		public Int32 Pts { get; set; }
		public Int32 PtsCount { get; set; }

		public TLMessagesAffectedMessages() { }
		public TLMessagesAffectedMessages(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.MessagesAffectedMessages; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Pts = from.ReadInt32();
			PtsCount = from.ReadInt32();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x84D19185);
			to.Write(Pts);
			to.Write(PtsCount);
			if (cache) WriteToCache(to);
		}
	}
}