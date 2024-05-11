// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Properties.Settings
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Makina_Ikmal.Properties
{
  [CompilerGenerated]
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
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

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("")]
    public string KulanıcıAdı
    {
      get => (string) this[nameof (KulanıcıAdı)];
      set => this[nameof (KulanıcıAdı)] = (object) value;
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("")]
    public string Sifre
    {
      get => (string) this[nameof (Sifre)];
      set => this[nameof (Sifre)] = (object) value;
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("False")]
    public bool BeniHatırla
    {
      get => (bool) this[nameof (BeniHatırla)];
      set => this[nameof (BeniHatırla)] = (object) value;
    }

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [SpecialSetting(SpecialSetting.ConnectionString)]
    [DefaultSettingValue("Data Source=10.0.8.220;Network Library=DBMSSOCN;Initial Catalog=makina_ikmal_2022;Integrated Security=True;User ID=makina_ikmal;Password=ikmaL123!!!**")]
    public string belediyeConnectionString => (string) this[nameof (belediyeConnectionString)];

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [SpecialSetting(SpecialSetting.ConnectionString)]
    [DefaultSettingValue("Data Source=10.0.8.220;Initial Catalog=makina_ikmal_2022;Persist Security Info=True;User ID=makina_ikmal;Password=ikmaL123!!!**")]
    public string bellConnectionString => (string) this[nameof (bellConnectionString)];

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [SpecialSetting(SpecialSetting.ConnectionString)]
    [DefaultSettingValue("Data Source=10.0.8.220;Initial Catalog=makina_ikmal_2022;Persist Security Info=True;User ID=makina_ikmal;Password=ikmaL123!!!**")]
    public string bellConnectionString1 => (string) this[nameof (bellConnectionString1)];

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [SpecialSetting(SpecialSetting.ConnectionString)]
    [DefaultSettingValue("Data Source=10.0.8.220;Initial Catalog=makina_ikmal_2022;Persist Security Info=True;User ID=makina_ikmal;Password=ikmaL123!!!**")]
    public string makina_ikmalConnectionString => (string) this[nameof (makina_ikmalConnectionString)];

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("")]
    public string TemaSkin
    {
      get => (string) this[nameof (TemaSkin)];
      set => this[nameof (TemaSkin)] = (object) value;
    }
  }
}
