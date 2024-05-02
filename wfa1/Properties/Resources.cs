// Decompiled with JetBrains decompiler
// Type: wfa1.Properties.Resources
// Assembly: wfa1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7ED32045-7058-479A-A9C3-646DCED5C6E6
// Assembly location: D:\repos\cSharp\job\wfa1\wfa1.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace wfa1.Properties
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [CompilerGenerated]
  [DebuggerNonUserCode]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Resources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (wfa1.Properties.Resources.resourceMan == null)
          wfa1.Properties.Resources.resourceMan = new ResourceManager("wfa1.Properties.Resources", typeof (wfa1.Properties.Resources).Assembly);
        return wfa1.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => wfa1.Properties.Resources.resourceCulture;
      set => wfa1.Properties.Resources.resourceCulture = value;
    }
  }
}
