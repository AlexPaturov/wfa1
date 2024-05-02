// Decompiled with JetBrains decompiler
// Type: wfa1.Properties.Settings
// Assembly: wfa1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7ED32045-7058-479A-A9C3-646DCED5C6E6
// Assembly location: D:\repos\cSharp\job\wfa1\wfa1.exe

using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace wfa1.Properties
{
  [CompilerGenerated]
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
  internal sealed class Settings : ApplicationSettingsBase
  {
    private static Settings defaultInstance = (Settings) SettingsBase.Synchronized((SettingsBase) new Settings());

    public static Settings Default
    {
      get
      {
        Settings defaultInstance = Settings.defaultInstance;
        return defaultInstance;
      }
    }
  }
}
