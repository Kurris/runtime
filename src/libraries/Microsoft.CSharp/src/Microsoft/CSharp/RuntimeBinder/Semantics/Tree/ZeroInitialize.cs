// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
    internal sealed class ExprZeroInit : ExprWithType
    {
        public ExprZeroInit(CType type)
            : base(ExpressionKind.ZeroInit, type)
        {
        }

        public override object Object => Activator.CreateInstance(Type.AssociatedSystemType);
    }
}
