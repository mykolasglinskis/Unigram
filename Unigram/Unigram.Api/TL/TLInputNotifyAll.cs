// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLInputNotifyAll : TLInputNotifyPeerBase 
	{
		public TLInputNotifyAll() { }
		public TLInputNotifyAll(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InputNotifyAll; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xA429B886);
		}
	}
}