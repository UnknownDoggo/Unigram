// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLChannelParticipantSelf : TLChannelParticipantBase, ITLChannelInviter 
	{

		public TLChannelParticipantSelf() { }
		public TLChannelParticipantSelf(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.ChannelParticipantSelf; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			UserId = from.ReadInt32();
			InviterId = from.ReadInt32();
			Date = from.ReadInt32();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0xA3289A6D);
			to.Write(UserId);
			to.Write(InviterId);
			to.Write(Date);
			if (cache) WriteToCache(to);
		}
	}
}