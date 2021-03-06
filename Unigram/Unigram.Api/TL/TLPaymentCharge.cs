// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLPaymentCharge : TLObject 
	{
		public String Id { get; set; }
		public String ProviderChargeId { get; set; }

		public TLPaymentCharge() { }
		public TLPaymentCharge(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.PaymentCharge; } }

		public override void Read(TLBinaryReader from)
		{
			Id = from.ReadString();
			ProviderChargeId = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xEA02C27E);
			to.Write(Id);
			to.Write(ProviderChargeId);
		}
	}
}