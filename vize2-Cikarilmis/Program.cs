// Decompiled with JetBrains decompiler
// Type: vize2.Program
// Assembly: vize2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2B51AE39-F2E9-466B-AE8E-E46B77637AE0
// Assembly location: C:\Users\alika\AppData\Local\Apps\2.0\Z0554ZKO.T39\MRGGENCW.A9Q\vize..tion_da83c66a6ba25ef2_0001.0000_efe3df4567b02f2a\vize2.exe

using System;
using System.Windows.Forms;

namespace vize2
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new Form1());
    }
  }
}
