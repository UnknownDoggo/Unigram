// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLPhotoSizeEmpty : TLPhotoSizeBase 
	{

		public TLPhotoSizeEmpty() { }
		public TLPhotoSizeEmpty(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.PhotoSizeEmpty; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Type = from.ReadString();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0xE17E23C);
			to.Write(Type);
			if (cache) WriteToCache(to);
		}
	}
}