// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Channels
{
	/// <summary>
	/// RCP method channels.deleteUserHistory
	/// </summary>
	public partial class TLChannelsDeleteUserHistory : TLObject
	{
		public TLInputChannelBase Channel { get; set; }
		public TLInputUserBase UserId { get; set; }

		public TLChannelsDeleteUserHistory() { }
		public TLChannelsDeleteUserHistory(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.ChannelsDeleteUserHistory; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Channel = TLFactory.Read<TLInputChannelBase>(from, cache);
			UserId = TLFactory.Read<TLInputUserBase>(from, cache);
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0xD10DD71B);
			to.WriteObject(Channel, cache);
			to.WriteObject(UserId, cache);
			if (cache) WriteToCache(to);
		}
	}
}