// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Auth
{
	/// <summary>
	/// RCP method auth.exportAuthorization
	/// </summary>
	public partial class TLAuthExportAuthorization : TLObject
	{
		public Int32 DCId { get; set; }

		public TLAuthExportAuthorization() { }
		public TLAuthExportAuthorization(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.AuthExportAuthorization; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			DCId = from.ReadInt32();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0xE5BFFFCD);
			to.Write(DCId);
			if (cache) WriteToCache(to);
		}
	}
}