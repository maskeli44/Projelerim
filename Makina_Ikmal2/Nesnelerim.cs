// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Nesnelerim
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using System.Drawing;

namespace Makina_Ikmal
{
  internal class Nesnelerim
  {
    public static class TemaColores
    {
      public static Color PanelPadre;
      public static Color PanelBotones;
      public static Color BarraTitulo;
      public static Color TextBusqueda;
      public static Color FuenteIconos;
      private static readonly Color PanelPadreD = Color.FromArgb(59, 17, 27);
      private static readonly Color PanelBotonesD = Color.FromArgb(122, 35, 56);
      private static readonly Color BarraTituloD = Color.FromArgb(186, 54, 85);
      private static readonly Color TextBusquedaD = Color.FromArgb(250, 73, 115);
      private static readonly Color FuenteIconosD = Color.White;
      private static readonly Color PanelPadreM = Color.FromArgb(92, 36, 97);
      private static readonly Color PanelBotonesM = Color.FromArgb(94, 65, 97);
      private static readonly Color BarraTituloM = Color.FromArgb(164, 64, 173);
      private static readonly Color TextBusquedaM = Color.FromArgb(223, 154, 230);
      private static readonly Color FuenteIconosM = Color.White;
      private static readonly Color PanelPadreV = Color.FromArgb(71, 102, 0);
      private static readonly Color PanelBotonesV = Color.FromArgb(121, 173, 0);
      private static readonly Color BarraTituloV = Color.FromArgb(157, 224, 0);
      private static readonly Color TextBusquedaV = Color.FromArgb(181, 230, 63);
      private static readonly Color FuenteIconosV = Color.White;
      private static readonly Color PanelPadreC = Color.FromArgb(35, 94, 97);
      private static readonly Color PanelBotonesC = Color.FromArgb(74, 101, 102);
      private static readonly Color BarraTituloC = Color.FromArgb(115, 156, 158);
      private static readonly Color TextBusquedaC = Color.FromArgb(164, 221, 224);
      private static readonly Color FuenteIconosC = Color.White;
      private static readonly Color PanelPadreA = Color.FromArgb(17, 47, 51);
      private static readonly Color PanelBotonesA = Color.FromArgb(33, 92, 99);
      private static readonly Color BarraTituloA = Color.FromArgb(37, 115, 125);
      private static readonly Color TextBusquedaA = Color.FromArgb(58, 162, 176);
      private static readonly Color FuenteIconosA = Color.White;
      private static readonly Color PanelPadreN = Color.FromArgb(51, 35, 3);
      private static readonly Color PanelBotonesN = Color.FromArgb(99, 68, 6);
      private static readonly Color BarraTituloN = Color.FromArgb(125, 85, 4);
      private static readonly Color TextBusquedaN = Color.FromArgb(181, 124, 11);
      private static readonly Color FuenteIconosN = Color.White;
      private static readonly Color PanelPadreB = Color.FromArgb(15, 6, 51);
      private static readonly Color PanelBotonesB = Color.FromArgb(30, 11, 99);
      private static readonly Color BarraTituloB = Color.FromArgb(35, 10, 125);
      private static readonly Color TextBusquedaB = Color.FromArgb(55, 20, 179);
      private static readonly Color FuenteIconosB = Color.White;

      public static void ElegirTema(string Tema)
      {
        if (Tema == "Renk Adı1")
        {
          Nesnelerim.TemaColores.PanelPadre = Nesnelerim.TemaColores.PanelPadreD;
          Nesnelerim.TemaColores.PanelBotones = Nesnelerim.TemaColores.PanelBotonesD;
          Nesnelerim.TemaColores.BarraTitulo = Nesnelerim.TemaColores.BarraTituloD;
          Nesnelerim.TemaColores.TextBusqueda = Nesnelerim.TemaColores.TextBusquedaD;
          Nesnelerim.TemaColores.FuenteIconos = Nesnelerim.TemaColores.FuenteIconosD;
        }
        if (Tema == "Renk Adı2")
        {
          Nesnelerim.TemaColores.PanelPadre = Nesnelerim.TemaColores.PanelPadreM;
          Nesnelerim.TemaColores.PanelBotones = Nesnelerim.TemaColores.PanelBotonesM;
          Nesnelerim.TemaColores.BarraTitulo = Nesnelerim.TemaColores.BarraTituloM;
          Nesnelerim.TemaColores.TextBusqueda = Nesnelerim.TemaColores.TextBusquedaM;
          Nesnelerim.TemaColores.FuenteIconos = Nesnelerim.TemaColores.FuenteIconosM;
        }
        if (Tema == "Renk Adı3")
        {
          Nesnelerim.TemaColores.PanelPadre = Nesnelerim.TemaColores.PanelPadreV;
          Nesnelerim.TemaColores.PanelBotones = Nesnelerim.TemaColores.PanelBotonesV;
          Nesnelerim.TemaColores.BarraTitulo = Nesnelerim.TemaColores.BarraTituloV;
          Nesnelerim.TemaColores.TextBusqueda = Nesnelerim.TemaColores.TextBusquedaV;
          Nesnelerim.TemaColores.FuenteIconos = Nesnelerim.TemaColores.FuenteIconosV;
        }
        if (Tema == "Renk Adı4")
        {
          Nesnelerim.TemaColores.PanelPadre = Nesnelerim.TemaColores.PanelPadreC;
          Nesnelerim.TemaColores.PanelBotones = Nesnelerim.TemaColores.PanelBotonesC;
          Nesnelerim.TemaColores.BarraTitulo = Nesnelerim.TemaColores.BarraTituloC;
          Nesnelerim.TemaColores.TextBusqueda = Nesnelerim.TemaColores.TextBusquedaC;
          Nesnelerim.TemaColores.FuenteIconos = Nesnelerim.TemaColores.FuenteIconosC;
        }
        if (Tema == "Renk Adı5")
        {
          Nesnelerim.TemaColores.PanelPadre = Nesnelerim.TemaColores.PanelPadreA;
          Nesnelerim.TemaColores.PanelBotones = Nesnelerim.TemaColores.PanelBotonesA;
          Nesnelerim.TemaColores.BarraTitulo = Nesnelerim.TemaColores.BarraTituloA;
          Nesnelerim.TemaColores.TextBusqueda = Nesnelerim.TemaColores.TextBusquedaA;
          Nesnelerim.TemaColores.FuenteIconos = Nesnelerim.TemaColores.FuenteIconosA;
        }
        if (Tema == "Renk Adı6")
        {
          Nesnelerim.TemaColores.PanelPadre = Nesnelerim.TemaColores.PanelPadreN;
          Nesnelerim.TemaColores.PanelBotones = Nesnelerim.TemaColores.PanelBotonesN;
          Nesnelerim.TemaColores.BarraTitulo = Nesnelerim.TemaColores.BarraTituloN;
          Nesnelerim.TemaColores.TextBusqueda = Nesnelerim.TemaColores.TextBusquedaN;
          Nesnelerim.TemaColores.FuenteIconos = Nesnelerim.TemaColores.FuenteIconosN;
        }
        if (!(Tema == "Renk Adı7"))
          return;
        Nesnelerim.TemaColores.PanelPadre = Nesnelerim.TemaColores.PanelPadreB;
        Nesnelerim.TemaColores.PanelBotones = Nesnelerim.TemaColores.PanelBotonesB;
        Nesnelerim.TemaColores.BarraTitulo = Nesnelerim.TemaColores.BarraTituloB;
        Nesnelerim.TemaColores.TextBusqueda = Nesnelerim.TemaColores.TextBusquedaB;
        Nesnelerim.TemaColores.FuenteIconos = Nesnelerim.TemaColores.FuenteIconosB;
      }
    }
  }
}
