// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using ObjCRuntime;

namespace Microsoft.AppCenter.Distribute.iOS.Bindings
{
	[Native]
	public enum MSUpdateAction : ulong
	{
        Update = 0,
        Postpone = 1
	}

	[Native]
	public enum MSUpdateTrack : ulong
	{
        Public = 1,
        Private = 2
	}
}
