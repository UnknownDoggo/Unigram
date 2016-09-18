// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLKeyboardButtonRequestGeoLocation : TLKeyboardButtonBase 
	{

		public TLKeyboardButtonRequestGeoLocation() { }
		public TLKeyboardButtonRequestGeoLocation(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.KeyboardButtonRequestGeoLocation; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Text = from.ReadString();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0xFC796B3F);
			to.Write(Text);
			if (cache) WriteToCache(to);
		}
	}
}