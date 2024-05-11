// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Program
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.UserSkins;
using Makina_Ikmal.LoginIslemleri;
using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace Makina_Ikmal
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Thread.CurrentThread.CurrentCulture = new CultureInfo("tr-TR");
      Thread.CurrentThread.CurrentUICulture = new CultureInfo("tr-TR");
      BonusSkins.Register();
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new TahaGiris());
    }
  }
}
