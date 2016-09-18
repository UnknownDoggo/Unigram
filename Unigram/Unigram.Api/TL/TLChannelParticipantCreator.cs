// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLChannelParticipantCreator : TLChannelParticipantBase 
	{

		public TLChannelParticipantCreator() { }
		public TLChannelParticipantCreator(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.ChannelParticipantCreator; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			UserId = from.ReadInt32();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0xE3E2E1F9);
			to.Write(UserId);
			if (cache) WriteToCache(to);
		}
	}
}