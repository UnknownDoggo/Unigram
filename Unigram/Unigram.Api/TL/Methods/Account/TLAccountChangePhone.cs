// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Account
{
	/// <summary>
	/// RCP method account.changePhone
	/// </summary>
	public partial class TLAccountChangePhone : TLObject
	{
		public String PhoneNumber { get; set; }
		public String PhoneCodeHash { get; set; }
		public String PhoneCode { get; set; }

		public TLAccountChangePhone() { }
		public TLAccountChangePhone(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.AccountChangePhone; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			PhoneNumber = from.ReadString();
			PhoneCodeHash = from.ReadString();
			PhoneCode = from.ReadString();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x70C32EDB);
			to.Write(PhoneNumber);
			to.Write(PhoneCodeHash);
			to.Write(PhoneCode);
			if (cache) WriteToCache(to);
		}
	}
}