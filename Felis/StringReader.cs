﻿#region Using

using System;

#endregion

namespace Felis
{
    public sealed class StringReader : TypeReader
    {
        public override string TargetType
        {
            get { return "System.String"; }
        }

        public override string ReaderName
        {
            get { return "Microsoft.Xna.Framework.Content.StringReader"; }
        }

        protected internal override object Read(ContentReader input)
        {
            return input.ReadString();
        }
    }
}
