// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLTopPeerCategoryCorrespondents : TLTopPeerCategoryBase 
	{
		public TLTopPeerCategoryCorrespondents() { }
		public TLTopPeerCategoryCorrespondents(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.TopPeerCategoryCorrespondents; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x637B7ED);
			if (cache) WriteToCache(to);
		}
	}
}