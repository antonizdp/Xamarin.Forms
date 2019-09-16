﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using System.Diagnostics;

namespace Xamarin.Forms.Xaml.Diagnostics
{
	static class DebuggerHelper
	{
		internal static bool _mockDebuggerIsAttached;
		public static bool DebuggerIsAttached => _mockDebuggerIsAttached || Debugger.IsAttached;
	}
}