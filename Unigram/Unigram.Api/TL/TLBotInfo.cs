// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLBotInfo : TLObject 
	{
		public Int32 UserId { get; set; }
		public String Description { get; set; }
		public TLVector<TLBotCommand> Commands { get; set; }

		public TLBotInfo() { }
		public TLBotInfo(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.BotInfo; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			UserId = from.ReadInt32();
			Description = from.ReadString();
			Commands = TLFactory.Read<TLVector<TLBotCommand>>(from, cache);
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x98E81D3A);
			to.Write(UserId);
			to.Write(Description);
			to.WriteObject(Commands, cache);
			if (cache) WriteToCache(to);
		}
	}
}