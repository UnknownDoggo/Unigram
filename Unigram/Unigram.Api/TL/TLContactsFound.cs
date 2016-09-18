// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLContactsFound : TLObject 
	{
		public TLVector<TLPeerBase> Results { get; set; }
		public TLVector<TLChatBase> Chats { get; set; }
		public TLVector<TLUserBase> Users { get; set; }

		public TLContactsFound() { }
		public TLContactsFound(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.ContactsFound; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Results = TLFactory.Read<TLVector<TLPeerBase>>(from, cache);
			Chats = TLFactory.Read<TLVector<TLChatBase>>(from, cache);
			Users = TLFactory.Read<TLVector<TLUserBase>>(from, cache);
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x1AA1F784);
			to.WriteObject(Results, cache);
			to.WriteObject(Chats, cache);
			to.WriteObject(Users, cache);
			if (cache) WriteToCache(to);
		}
	}
}