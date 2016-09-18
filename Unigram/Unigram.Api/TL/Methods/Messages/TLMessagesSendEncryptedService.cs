// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Messages
{
	/// <summary>
	/// RCP method messages.sendEncryptedService
	/// </summary>
	public partial class TLMessagesSendEncryptedService : TLObject
	{
		public TLInputEncryptedChat Peer { get; set; }
		public Int64 RandomId { get; set; }
		public Byte[] Data { get; set; }

		public TLMessagesSendEncryptedService() { }
		public TLMessagesSendEncryptedService(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.MessagesSendEncryptedService; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Peer = TLFactory.Read<TLInputEncryptedChat>(from, cache);
			RandomId = from.ReadInt64();
			Data = from.ReadByteArray();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x32D439A4);
			to.WriteObject(Peer, cache);
			to.Write(RandomId);
			to.WriteByteArray(Data);
			if (cache) WriteToCache(to);
		}
	}
}