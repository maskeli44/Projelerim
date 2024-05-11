// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Classlar.appconfig
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using System.Configuration;

namespace Makina_Ikmal.Classlar
{
  internal class appconfig
  {
    private System.Configuration.Configuration config;

    public appconfig() => this.config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

    public string GetConnectionString(string key) => this.config.ConnectionStrings.ConnectionStrings[key].ConnectionString;

    public void SaveConnectionString(string key, string value)
    {
      this.config.ConnectionStrings.ConnectionStrings[key].ConnectionString = value;
      this.config.ConnectionStrings.ConnectionStrings[key].ProviderName = "System.Data.SqlClient";
      this.config.Save(ConfigurationSaveMode.Modified);
    }

    public void entit()
    {
    }
  }
}
