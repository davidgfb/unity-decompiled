﻿// Decompiled with JetBrains decompiler
// Type: UnityEditor.LightingDataAsset
// Assembly: UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 01B28312-B6F5-4E06-90F6-BE297B711E41
// Assembly location: C:\Users\Blake\sandbox\unity\test-project\Library\UnityAssemblies\UnityEditor.dll

using System.Runtime.CompilerServices;
using UnityEngine;

namespace UnityEditor
{
  /// <summary>
  ///   <para>The lighting data asset used by the active scene.</para>
  /// </summary>
  public sealed class LightingDataAsset : Object
  {
    internal bool isValid { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; }

    internal string validityErrorMessage { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; }
  }
}
