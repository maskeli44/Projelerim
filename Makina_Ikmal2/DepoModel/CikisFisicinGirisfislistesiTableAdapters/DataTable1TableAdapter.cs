// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.DepoModel.CikisFisicinGirisfislistesiTableAdapters.DataTable1TableAdapter
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using Makina_Ikmal.Properties;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Makina_Ikmal.DepoModel.CikisFisicinGirisfislistesiTableAdapters
{
  [DesignerCategory("code")]
  [ToolboxItem(true)]
  [DataObject(true)]
  [Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [HelpKeyword("vs.data.TableAdapter")]
  public class DataTable1TableAdapter : Component
  {
    private SqlDataAdapter _adapter;
    private SqlConnection _connection;
    private SqlTransaction _transaction;
    private SqlCommand[] _commandCollection;
    private bool _clearBeforeFill;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataTable1TableAdapter() => this.ClearBeforeFill = true;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected internal SqlDataAdapter Adapter
    {
      get
      {
        if (this._adapter == null)
          this.InitAdapter();
        return this._adapter;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal SqlConnection Connection
    {
      get
      {
        if (this._connection == null)
          this.InitConnection();
        return this._connection;
      }
      set
      {
        this._connection = value;
        if (this.Adapter.InsertCommand != null)
          this.Adapter.InsertCommand.Connection = value;
        if (this.Adapter.DeleteCommand != null)
          this.Adapter.DeleteCommand.Connection = value;
        if (this.Adapter.UpdateCommand != null)
          this.Adapter.UpdateCommand.Connection = value;
        for (int index = 0; index < this.CommandCollection.Length; ++index)
        {
          if (this.CommandCollection[index] != null)
            this.CommandCollection[index].Connection = value;
        }
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal SqlTransaction Transaction
    {
      get => this._transaction;
      set
      {
        this._transaction = value;
        for (int index = 0; index < this.CommandCollection.Length; ++index)
          this.CommandCollection[index].Transaction = this._transaction;
        if (this.Adapter != null && this.Adapter.DeleteCommand != null)
          this.Adapter.DeleteCommand.Transaction = this._transaction;
        if (this.Adapter != null && this.Adapter.InsertCommand != null)
          this.Adapter.InsertCommand.Transaction = this._transaction;
        if (this.Adapter == null || this.Adapter.UpdateCommand == null)
          return;
        this.Adapter.UpdateCommand.Transaction = this._transaction;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected SqlCommand[] CommandCollection
    {
      get
      {
        if (this._commandCollection == null)
          this.InitCommandCollection();
        return this._commandCollection;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool ClearBeforeFill
    {
      get => this._clearBeforeFill;
      set => this._clearBeforeFill = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitAdapter()
    {
      this._adapter = new SqlDataAdapter();
      this._adapter.TableMappings.Add((object) new DataTableMapping()
      {
        SourceTable = "Table",
        DataSetTable = "DataTable1",
        ColumnMappings = {
          {
            "İş Emri Kodu",
            "İş Emri Kodu"
          },
          {
            "ARACID",
            "ARACID"
          },
          {
            "Depo Fiş Kodu",
            "Depo Fiş Kodu"
          },
          {
            "TARIH",
            "TARIH"
          },
          {
            "FIRMAID",
            "FIRMAID"
          },
          {
            "FISTUTAR",
            "FISTUTAR"
          },
          {
            "TOPKDVTUTAR",
            "TOPKDVTUTAR"
          },
          {
            "Talep Fiş Kodu",
            "Talep Fiş Kodu"
          },
          {
            "IMZADEPOYETKILIID",
            "IMZADEPOYETKILIID"
          },
          {
            "ISLEMTIPIID",
            "ISLEMTIPIID"
          },
          {
            "ISLEMTIPI",
            "ISLEMTIPI"
          },
          {
            "Expr1",
            "Expr1"
          },
          {
            "Expr2",
            "Expr2"
          },
          {
            "Expr3",
            "Expr3"
          },
          {
            "Expr4",
            "Expr4"
          },
          {
            "ISEMRIID",
            "ISEMRIID"
          },
          {
            "KOD",
            "KOD"
          },
          {
            "SAAT",
            "SAAT"
          },
          {
            "TALEPDURUMID",
            "TALEPDURUMID"
          },
          {
            "TALEPIPTALACIKLAMA",
            "TALEPIPTALACIKLAMA"
          },
          {
            "TALEPEDENUSTAID",
            "TALEPEDENUSTAID"
          },
          {
            "ATOLYESEFID",
            "ATOLYESEFID"
          },
          {
            "DEPOYETKILIID",
            "DEPOYETKILIID"
          },
          {
            "MUDURID",
            "MUDURID"
          },
          {
            "MUDONAYZAMAN",
            "MUDONAYZAMAN"
          },
          {
            "TALEPKAYITID",
            "TALEPKAYITID"
          },
          {
            "SAVEUSER",
            "SAVEUSER"
          },
          {
            "SAVEDATE",
            "SAVEDATE"
          },
          {
            "EDITUSER",
            "EDITUSER"
          },
          {
            "EDITDATE",
            "EDITDATE"
          },
          {
            "SAVEMAC",
            "SAVEMAC"
          },
          {
            "EDITMAC",
            "EDITMAC"
          },
          {
            "SAVEIP",
            "SAVEIP"
          },
          {
            "EDITIP",
            "EDITIP"
          }
        }
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitConnection()
    {
      this._connection = new SqlConnection();
      this._connection.ConnectionString = Settings.Default.makina_ikmalConnectionString;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitCommandCollection()
    {
      this._commandCollection = new SqlCommand[1];
      this._commandCollection[0] = new SqlCommand();
      this._commandCollection[0].Connection = this.Connection;
      this._commandCollection[0].CommandText = "SELECT DISTINCT \r\n                  TBLDEPOFIS.ID AS Expr1, TBLISEMRI.KOD AS [İş Emri Kodu], TBLISEMRI.ARACID, TBLDEPOFIS.KOD AS [Depo Fiş Kodu], TBLDEPOFIS.TARIH AS Expr2, TBLDEPOFIS.FIRMAID AS Expr3, TBLDEPOFIS.FISTUTAR AS Expr4, \r\n                  TBLDEPOFIS.TOPKDVTUTAR, TBLTALEPFIS.KOD AS [Talep Fiş Kodu], TBLDEPOFIS.IMZADEPOYETKILIID, TBLDEPOFIS.ISLEMTIPIID, TBLISLEMTIPI.ISLEMTIPI, TBLTALEPFIS.ISEMRIID, TBLTALEPFIS.KOD, TBLTALEPFIS.TARIH, \r\n                  TBLTALEPFIS.SAAT, TBLTALEPFIS.FIRMAID, TBLTALEPFIS.FISTUTAR, TBLTALEPFIS.TALEPDURUMID, TBLTALEPFIS.TALEPIPTALACIKLAMA, TBLTALEPFIS.TALEPEDENUSTAID, TBLTALEPFIS.ATOLYESEFID, \r\n                  TBLTALEPFIS.DEPOYETKILIID, TBLTALEPFIS.MUDURID, TBLTALEPFIS.MUDONAYZAMAN, TBLTALEPFIS.TALEPKAYITID, TBLTALEPFIS.SAVEUSER, TBLTALEPFIS.SAVEDATE, TBLTALEPFIS.EDITUSER, TBLTALEPFIS.EDITDATE, \r\n                  TBLTALEPFIS.SAVEMAC, TBLTALEPFIS.EDITMAC, TBLTALEPFIS.SAVEIP, TBLTALEPFIS.EDITIP\r\nFROM     TBLDEPOFIS INNER JOIN\r\n                  TBLISEMRI ON TBLDEPOFIS.ISEMRIID = TBLISEMRI.ID INNER JOIN\r\n                  TBLISLEMTIPI ON TBLDEPOFIS.ISLEMTIPIID = TBLISLEMTIPI.ID INNER JOIN\r\n                  TBLTALEPFIS ON TBLDEPOFIS.TALEPFISID = TBLTALEPFIS.ID\r\nWHERE  (TBLDEPOFIS.ISLEMTIPIID = N'2')\r\nORDER BY Expr1 DESC";
      this._commandCollection[0].CommandType = CommandType.Text;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    public virtual int Fill(
      CikisFisicinGirisfislistesi.DataTable1DataTable dataTable)
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      if (this.ClearBeforeFill)
        dataTable.Clear();
      return this.Adapter.Fill((DataTable) dataTable);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Select, true)]
    public virtual CikisFisicinGirisfislistesi.DataTable1DataTable GetData()
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      CikisFisicinGirisfislistesi.DataTable1DataTable data = new CikisFisicinGirisfislistesi.DataTable1DataTable();
      this.Adapter.Fill((DataTable) data);
      return data;
    }
  }
}
