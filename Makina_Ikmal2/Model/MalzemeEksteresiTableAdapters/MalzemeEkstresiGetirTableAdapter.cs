﻿// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Model.MalzemeEksteresiTableAdapters.MalzemeEkstresiGetirTableAdapter
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

namespace Makina_Ikmal.Model.MalzemeEksteresiTableAdapters
{
  [DesignerCategory("code")]
  [ToolboxItem(true)]
  [DataObject(true)]
  [Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [HelpKeyword("vs.data.TableAdapter")]
  public class MalzemeEkstresiGetirTableAdapter : Component
  {
    private SqlDataAdapter _adapter;
    private SqlConnection _connection;
    private SqlTransaction _transaction;
    private SqlCommand[] _commandCollection;
    private bool _clearBeforeFill;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public MalzemeEkstresiGetirTableAdapter() => this.ClearBeforeFill = true;

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
        DataSetTable = "MalzemeEkstresiGetir",
        ColumnMappings = {
          {
            "ISLEMTIPI",
            "ISLEMTIPI"
          },
          {
            "PLAKA",
            "PLAKA"
          },
          {
            "MALZEMEADI",
            "MALZEMEADI"
          },
          {
            "BIRIMADI",
            "BIRIMADI"
          },
          {
            "GIRISMIKTAR",
            "GIRISMIKTAR"
          },
          {
            "CIKISMIKTAR",
            "CIKISMIKTAR"
          },
          {
            "DEGISIMKMSI",
            "DEGISIMKMSI"
          },
          {
            "DEPOADI",
            "DEPOADI"
          },
          {
            "ID",
            "ID"
          },
          {
            "Malzeme ID",
            "Malzeme ID"
          },
          {
            "MALZURTTARIH",
            "MALZURTTARIH"
          },
          {
            "KOD",
            "KOD"
          }
        }
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitConnection()
    {
      this._connection = new SqlConnection();
      this._connection.ConnectionString = Settings.Default.bellConnectionString;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitCommandCollection()
    {
      this._commandCollection = new SqlCommand[1];
      this._commandCollection[0] = new SqlCommand();
      this._commandCollection[0].Connection = this.Connection;
      this._commandCollection[0].CommandText = "SELECT TBLDEPOFISHRKT.ID, TBLISLEMTIPI.ISLEMTIPI, TBLARACLAR.PLAKA, TBLMALZBIRIM.BIRIMADI, TBLMALZDEPO.DEPOADI, TBLMALZEMELER.MALZEMEADI, TBLMALZEMELER.ID AS [Malzeme ID], \r\n                  TBLDEPOFISHRKT.MALZURTTARIH, TBLDEPOFISHRKT.DEGISIMKMSI, TBLDEPOFISHRKT.GIRISMIKTAR, TBLDEPOFISHRKT.CIKISMIKTAR, TBLISEMRI.KOD\r\nFROM     TBLDEPOFISHRKT INNER JOIN\r\n                  TBLDEPOFIS ON TBLDEPOFISHRKT.DEPOFISID = TBLDEPOFIS.ID LEFT OUTER JOIN\r\n                  TBLMALZEMELER ON TBLDEPOFISHRKT.MALZEMEID = TBLMALZEMELER.ID LEFT OUTER JOIN\r\n                  TBLISEMRI ON TBLDEPOFIS.ISEMRIID = TBLISEMRI.ID LEFT OUTER JOIN\r\n                  TBLISLEMTIPI ON TBLDEPOFIS.ISLEMTIPIID = TBLISLEMTIPI.ID LEFT OUTER JOIN\r\n                  TBLARACLAR ON TBLISEMRI.ARACID = TBLARACLAR.ID LEFT OUTER JOIN\r\n                  TBLMALZBIRIM ON TBLDEPOFISHRKT.BIRIMID = TBLMALZBIRIM.ID LEFT OUTER JOIN\r\n                  TBLMALZDEPO ON TBLDEPOFISHRKT.DEPOID = TBLMALZDEPO.ID\r\nWHERE  (TBLMALZEMELER.ID = @id)";
      this._commandCollection[0].CommandType = CommandType.Text;
      this._commandCollection[0].Parameters.Add(new SqlParameter("@id", SqlDbType.Int, 4, ParameterDirection.Input, (byte) 0, (byte) 0, "Malzeme ID", DataRowVersion.Current, false, (object) null, "", "", ""));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    public virtual int Fill(
      MalzemeEksteresi.MalzemeEkstresiGetirDataTable dataTable,
      int id)
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      this.Adapter.SelectCommand.Parameters[0].Value = (object) id;
      if (this.ClearBeforeFill)
        dataTable.Clear();
      return this.Adapter.Fill((DataTable) dataTable);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Select, true)]
    public virtual MalzemeEksteresi.MalzemeEkstresiGetirDataTable GetData(int id)
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      this.Adapter.SelectCommand.Parameters[0].Value = (object) id;
      MalzemeEksteresi.MalzemeEkstresiGetirDataTable data = new MalzemeEksteresi.MalzemeEkstresiGetirDataTable();
      this.Adapter.Fill((DataTable) data);
      return data;
    }
  }
}
