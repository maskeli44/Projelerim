// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Classlar.Resimleme
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Makina_Ikmal.Classlar
{
  internal class Resimleme
  {
    public byte[] resimyukle(Image resim)
    {
      using (MemoryStream memoryStream = new MemoryStream())
      {
        resim.Save((Stream) memoryStream, ImageFormat.Jpeg);
        return memoryStream.ToArray();
      }
    }

    public Image resimigetir(byte[] glenarray)
    {
      using (MemoryStream memoryStream = new MemoryStream(glenarray))
        return Image.FromStream((Stream) memoryStream);
    }
  }
}
