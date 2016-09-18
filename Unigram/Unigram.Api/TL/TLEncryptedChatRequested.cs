// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLEncryptedChatRequested : TLEncryptedChatBase 
	{
		public Byte[] GA { get; set; }

		public TLEncryptedChatRequested() { }
		public TLEncryptedChatRequested(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.EncryptedChatRequested; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Id = from.ReadInt32();
			AccessHash = from.ReadInt64();
			Date = from.ReadInt32();
			AdminId = from.ReadInt32();
			ParticipantId = from.ReadInt32();
			GA = from.ReadByteArray();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0xC878527E);
			to.Write(Id);
			to.Write(AccessHash);
			to.Write(Date);
			to.Write(AdminId);
			to.Write(ParticipantId);
			to.WriteByteArray(GA);
			if (cache) WriteToCache(to);
		}
	}
}