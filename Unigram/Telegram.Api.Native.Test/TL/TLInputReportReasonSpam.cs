// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLInputReportReasonSpam : TLReportReasonBase 
	{
		public TLInputReportReasonSpam() { }
		public TLInputReportReasonSpam(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InputReportReasonSpam; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteUInt32(0x58DBCAB8);
		}
	}
}