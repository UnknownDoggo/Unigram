// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Account
{
	/// <summary>
	/// RCP method account.confirmPhone
	/// </summary>
	public partial class TLAccountConfirmPhone : TLObject
	{
		public String PhoneCodeHash { get; set; }
		public String PhoneCode { get; set; }

		public TLAccountConfirmPhone() { }
		public TLAccountConfirmPhone(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.AccountConfirmPhone; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			PhoneCodeHash = from.ReadString();
			PhoneCode = from.ReadString();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x5F2178C3);
			to.Write(PhoneCodeHash);
			to.Write(PhoneCode);
			if (cache) WriteToCache(to);
		}
	}
}