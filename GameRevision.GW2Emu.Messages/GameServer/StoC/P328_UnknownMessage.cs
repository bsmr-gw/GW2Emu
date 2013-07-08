/*
 * This code was autogenerated by
 * GameRevision.GW2Emu.CodeWriter.
 * Date generated: 08-07-13
 */

using System;
using System.IO;
using System.Net;
using GameRevision.GW2Emu.Core;
using GameRevision.GW2Emu.Core.Types;
using GameRevision.GW2Emu.Core.Serializers;

namespace GameRevision.GW2Emu.Messages.GameServer.StoC
{
    public class P328_UnknownMessage : GenericMessage
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;
        public Vector3 Unknown3;
        public float Unknown4;
        
        public override ushort Header
        {
            get
            {
                return 328;
            }
        }
        
        public override void Serialize(Serializer serializer)
        {
            base.Serialize(serializer);
            serializer.WriteVarint(this.Unknown0);
            serializer.WriteVarint(this.Unknown1);
            serializer.WriteVarint(this.Unknown2);
            serializer.WriteVector3(this.Unknown3);
            serializer.Write(this.Unknown4);
        }
    }
}