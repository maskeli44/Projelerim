﻿// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Model.TalepKayitTabloCekTableAdapters.DataTable2TableAdapter
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using Makina_Ikmal.Properties;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Makina_Ikmal.Model.TalepKayitTabloCekTableAdapters
{
  [DesignerCategory("code")]
  [ToolboxItem(true)]
  [DataObject(true)]
  [Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [HelpKeyword("vs.data.TableAdapter")]
  public class DataTable2TableAdapter : Component
  {
    private SqlDataAdapter _adapter;
    private SqlConnection _connection;
    private SqlTransaction _transaction;
    private SqlCommand[] _commandCollection;
    private bool _clearBeforeFill;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataTable2TableAdapter() => this.ClearBeforeFill = true;

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
        DataSetTable = "DataTable2",
        ColumnMappings = {
          {
            "ISEMRIID",
            "ISEMRIID"
          },
          {
            "KOD",
            "KOD"
          },
          {
            "MALZEMEADI",
            "MALZEMEADI"
          },
          {
            "MALZACIKLAMA",
            "MALZACIKLAMA"
          },
          {
            "PLAKA",
            "PLAKA"
          },
          {
            "MIKTAR",
            "MIKTAR"
          },
          {
            "FIYAT",
            "FIYAT"
          },
          {
            "TUTAR",
            "TUTAR"
          },
          {
            "TALEPFISID",
            "TALEPFISID"
          },
          {
            "TALEPKAYITID",
            "TALEPKAYITID"
          },
          {
            "BIRIMADI",
            "BIRIMADI"
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
      this._commandCollection = new SqlCommand[2];
      this._commandCollection[0] = new SqlCommand();
      this._commandCollection[0].Connection = this.Connection;
      this._commandCollection[0].CommandText = "SELECT        TBLTALEPFIS.ISEMRIID, TBLTALEPFIS.KOD, TBLMALZEMELER.MALZEMEADI, TBLTALEPFISHRKT.MALZACIKLAMA, TBLARACLAR.PLAKA, TBLTALEPFISHRKT.MIKTAR, TBLTALEPFISHRKT.FIYAT, TBLTALEPFISHRKT.TUTAR, \r\n                         TBLTALEPFISHRKT.TALEPFISID, TBLTALEPFIS.TALEPKAYITID, TBLMALZBIRIM.BIRIMADI\r\nFROM            TBLTALEPFIS AS TBLTALEPFIS INNER JOIN\r\n                         TBLTALEPFISHRKT AS TBLTALEPFISHRKT ON TBLTALEPFISHRKT.TALEPFISID = TBLTALEPFIS.ID LEFT OUTER JOIN\r\n                         TBLMALZEMELER AS TBLMALZEMELER ON TBLMALZEMELER.ID = TBLTALEPFISHRKT.MALZEMEID INNER JOIN\r\n                         TBLISEMRI AS TBLISEMRI ON TBLISEMRI.ID = TBLTALEPFIS.ISEMRIID LEFT OUTER JOIN\r\n                         TBLARACLAR AS TBLARACLAR ON TBLARACLAR.ID = TBLISEMRI.ARACID INNER JOIN\r\n                         TBLMALZBIRIM AS TBLMALZBIRIM ON TBLMALZBIRIM.ID = TBLMALZEMELER.BIRIMID\r\nWHERE        (TBLTALEPFIS.TALEPKAYITID = @para)";
      this._commandCollection[0].CommandType = CommandType.Text;
      this._commandCollection[0].Parameters.Add(new SqlParameter("@para", SqlDbType.Int, 4, ParameterDirection.Input, (byte) 0, (byte) 0, "TALEPKAYITID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._commandCollection[1] = new SqlCommand();
      this._commandCollection[1].Connection = new SqlConnection(Settings.Default.bellConnectionString);
      this._commandCollection[1].CommandText = "SELECT        TBLTALEPFIS.ISEMRIID, TBLTALEPFIS.KOD, TBLMALZEMELER.MALZEMEADI, TBLTALEPFISHRKT.MALZACIKLAMA, TBLARACLAR.PLAKA, TBLTALEPFISHRKT.MIKTAR, TBLTALEPFISHRKT.FIYAT, TBLTALEPFISHRKT.TUTAR, \r\n                         TBLTALEPFISHRKT.TALEPFISID, TBLTALEPFIS.TALEPKAYITID\r\nFROM            TBLTALEPFIS AS TBLTALEPFIS INNER JOIN\r\n                         TBLTALEPFISHRKT AS TBLTALEPFISHRKT ON TBLTALEPFISHRKT.TALEPFISID = TBLTALEPFIS.ID LEFT OUTER JOIN\r\n                         TBLMALZEMELER AS TBLMALZEMELER ON TBLMALZEMELER.ID = TBLTALEPFISHRKT.MALZEMEID INNER JOIN\r\n                         TBLISEMRI AS TBLISEMRI ON TBLISEMRI.ID = TBLTALEPFIS.ISEMRIID LEFT OUTER JOIN\r\n                         TBLARACLAR AS TBLARACLAR ON TBLARACLAR.ID = TBLISEMRI.ARACID INNER JOIN\r\n                         TBLMALZBIRIM AS TBLMALZBIRIM ON TBLMALZBIRIM.ID = TBLMALZEMELER.BIRIMID\r\n";
      this._commandCollection[1].CommandType = CommandType.Text;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    public virtual int Fill(TalepKayitTabloCek.DataTable2DataTable dataTable, int? para)
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      if (para.HasValue)
        this.Adapter.SelectCommand.Parameters[0].Value = (object) para.Value;
      else
        this.Adapter.SelectCommand.Parameters[0].Value = (object) DBNull.Value;
      if (this.ClearBeforeFill)
        dataTable.Clear();
      return this.Adapter.Fill((DataTable) dataTable);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Select, true)]
    public virtual TalepKayitTabloCek.DataTable2DataTable GetData(int? para)
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      if (para.HasValue)
        this.Adapter.SelectCommand.Parameters[0].Value = (object) para.Value;
      else
        this.Adapter.SelectCommand.Parameters[0].Value = (object) DBNull.Value;
      TalepKayitTabloCek.DataTable2DataTable data = new TalepKayitTabloCek.DataTable2DataTable();
      this.Adapter.Fill((DataTable) data);
      return data;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Fill, false)]
    public virtual int FillBy(TalepKayitTabloCek.DataTable2DataTable dataTable)
    {
      this.Adapter.SelectCommand = this.CommandCollection[1];
      if (this.ClearBeforeFill)
        dataTable.Clear();
      return this.Adapter.Fill((DataTable) dataTable);
    }
  }
}
