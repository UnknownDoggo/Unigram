// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLInputMediaGifExternal : TLInputMediaBase 
	{
		public String Q { get; set; }

		public TLInputMediaGifExternal() { }
		public TLInputMediaGifExternal(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.InputMediaGifExternal; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Url = from.ReadString();
			Q = from.ReadString();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x4843B0FD);
			to.Write(Url);
			to.Write(Q);
			if (cache) WriteToCache(to);
		}
	}
}