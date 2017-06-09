// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Methods.Messages
{
	/// <summary>
	/// RCP method messages.getDocumentByHash.
	/// Returns <see cref="Telegram.Api.TL.TLDocumentBase"/>
	/// </summary>
	public partial class TLMessagesGetDocumentByHash : TLObject
	{
		public Byte[] Sha256 { get; set; }
		public Int32 Size { get; set; }
		public String MimeType { get; set; }

		public TLMessagesGetDocumentByHash() { }
		public TLMessagesGetDocumentByHash(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesGetDocumentByHash; } }

		public override void Read(TLBinaryReader from)
		{
			Sha256 = from.ReadByteArray();
			Size = from.ReadInt32();
			MimeType = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteByteArray(Sha256);
			to.WriteInt32(Size);
			to.WriteString(MimeType ?? string.Empty);
		}
	}
}