// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLHelpNoAppUpdate : TLHelpAppUpdateBase 
	{
		public TLHelpNoAppUpdate() { }
		public TLHelpNoAppUpdate(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.HelpNoAppUpdate; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0xC45A6536);
			if (cache) WriteToCache(to);
		}
	}
}