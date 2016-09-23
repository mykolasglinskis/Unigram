// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLUpdatesChannelDifference : TLUpdatesChannelDifferenceBase 
	{
		[Flags]
		public enum Flag : Int32
		{
			Final = (1 << 0),
			Timeout = (1 << 1),
		}

		public override bool IsFinal { get { return Flags.HasFlag(Flag.Final); } set { Flags = value ? (Flags | Flag.Final) : (Flags & ~Flag.Final); } }
		public bool HasTimeout { get { return Flags.HasFlag(Flag.Timeout); } set { Flags = value ? (Flags | Flag.Timeout) : (Flags & ~Flag.Timeout); } }

		public Flag Flags { get; set; }
		public TLVector<TLMessageBase> NewMessages { get; set; }
		public TLVector<TLUpdateBase> OtherUpdates { get; set; }

		public TLUpdatesChannelDifference() { }
		public TLUpdatesChannelDifference(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.UpdatesChannelDifference; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Flags = (Flag)from.ReadInt32();
			Pts = from.ReadInt32();
			if (HasTimeout) Timeout = from.ReadInt32();
			NewMessages = TLFactory.Read<TLVector<TLMessageBase>>(from, cache);
			OtherUpdates = TLFactory.Read<TLVector<TLUpdateBase>>(from, cache);
			Chats = TLFactory.Read<TLVector<TLChatBase>>(from, cache);
			Users = TLFactory.Read<TLVector<TLUserBase>>(from, cache);
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			UpdateFlags();

			to.Write(0x2064674E);
			to.Write((Int32)Flags);
			to.Write(Pts);
			if (HasTimeout) to.Write(Timeout.Value);
			to.WriteObject(NewMessages, cache);
			to.WriteObject(OtherUpdates, cache);
			to.WriteObject(Chats, cache);
			to.WriteObject(Users, cache);
			if (cache) WriteToCache(to);
		}

		private void UpdateFlags()
		{
			HasTimeout = Timeout != null;
		}
	}
}