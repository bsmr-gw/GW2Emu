/*
 * This code was autogenerated by
 * GameRevision.GW2Emu.CodeWriter.
 * Date generated: 22-07-13
 */

using System;
using System.IO;
using System.Net;
using GameRevision.GW2Emu.Common;
using GameRevision.GW2Emu.Common.Math;
using GameRevision.GW2Emu.Common.Messaging;
using GameRevision.GW2Emu.Common.Serialization;
using GameRevision.GW2Emu.Common.Session;

namespace GameRevision.GW2Emu.LoginServer.Messages.CtoS
{
    public class P21_UnknownMessage : IMessage
    {
        public int Unknown0;
        public UID Unknown1;
        public string Unknown2;
        
        public ushort Header
        {
            get
            {
                return 21;
            }
        }
        
        public ISession Owner {  get;  set; }
        
        public void Serialize(Serializer serializer) {}
        public void Deserialize(Deserializer deserializer)
        {
            this.Unknown0 = deserializer.ReadVarint();
            this.Unknown1 = deserializer.ReadUID();
            this.Unknown2 = deserializer.ReadUtf16String();
        }
    }
}