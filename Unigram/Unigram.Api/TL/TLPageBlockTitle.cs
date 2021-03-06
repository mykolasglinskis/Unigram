// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLPageBlockTitle : TLPageBlockBase 
	{
		public TLRichTextBase Text { get; set; }

		public TLPageBlockTitle() { }
		public TLPageBlockTitle(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.PageBlockTitle; } }

		public override void Read(TLBinaryReader from)
		{
			Text = TLFactory.Read<TLRichTextBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x70ABC3FD);
			to.WriteObject(Text);
		}
	}
}