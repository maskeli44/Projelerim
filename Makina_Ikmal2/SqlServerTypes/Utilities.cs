// Decompiled with JetBrains decompiler
// Type: SqlServerTypes.Utilities
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using System;
using System.IO;
using System.Runtime.InteropServices;

namespace SqlServerTypes
{
  public class Utilities
  {
    [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern IntPtr LoadLibrary(string libname);

    public static void LoadNativeAssemblies(string rootApplicationPath)
    {
      string nativeBinaryPath = IntPtr.Size > 4 ? Path.Combine(rootApplicationPath, "SqlServerTypes\\x64\\") : Path.Combine(rootApplicationPath, "SqlServerTypes\\x86\\");
      Utilities.LoadNativeAssembly(nativeBinaryPath, "msvcr120.dll");
      Utilities.LoadNativeAssembly(nativeBinaryPath, "SqlServerSpatial140.dll");
    }

    private static void LoadNativeAssembly(string nativeBinaryPath, string assemblyName)
    {
      if (Utilities.LoadLibrary(Path.Combine(nativeBinaryPath, assemblyName)) == IntPtr.Zero)
        throw new Exception(string.Format("Error loading {0} (ErrorCode: {1})", (object) assemblyName, (object) Marshal.GetLastWin32Error()));
    }
  }
}
