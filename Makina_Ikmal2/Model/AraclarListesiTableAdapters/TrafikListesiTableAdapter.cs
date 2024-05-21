﻿// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Model.AraclarListesiTableAdapters.TrafikListesiTableAdapter
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

namespace Makina_Ikmal.Model.AraclarListesiTableAdapters
{
  [DesignerCategory("code")]
  [ToolboxItem(true)]
  [DataObject(true)]
  [Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [HelpKeyword("vs.data.TableAdapter")]
  public class TrafikListesiTableAdapter : Component
  {
    private SqlDataAdapter _adapter;
    private SqlConnection _connection;
    private SqlTransaction _transaction;
    private SqlCommand[] _commandCollection;
    private bool _clearBeforeFill;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public TrafikListesiTableAdapter() => this.ClearBeforeFill = true;

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
        DataSetTable = "TrafikListesi",
        ColumnMappings = {
          {
            "ID",
            "ID"
          },
          {
            "PLAKA",
            "PLAKA"
          },
          {
            "BELDMUDURLUK",
            "BELDMUDURLUK"
          },
          {
            "BELDBIRIMADI",
            "BELDBIRIMADI"
          },
          {
            "KAYITTARIHI",
            "KAYITTARIHI"
          },
          {
            "FISNO",
            "FISNO"
          },
          {
            "CEZATARIHI",
            "CEZATARIHI"
          },
          {
            "CEZASAATI",
            "CEZASAATI"
          },
          {
            "CEZAACIKLAMA",
            "CEZAACIKLAMA"
          },
          {
            "CEZATUTARI",
            "CEZATUTARI"
          },
          {
            "ODEMEDURUM",
            "ODEMEDURUM"
          },
          {
            "ILGILINOT",
            "ILGILINOT"
          },
          {
            "GOREVDURUM",
            "GOREVDURUM"
          }
        }
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitConnection()
    {
      this._connection = new SqlConnection();
      this._connection.ConnectionString = Settings.Default.belediyeConnectionString;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitCommandCollection()
    {
      this._commandCollection = new SqlCommand[1];
      this._commandCollection[0] = new SqlCommand();
      this._commandCollection[0].Connection = this.Connection;
      this._commandCollection[0].CommandText = "SELECT TBLARACTRFCEZA.ID, TBLARACLAR.PLAKA, TBLARACTRFCEZA.KAYITTARIHI, TBLARACTRFCEZA.FISNO, TBLARACTRFCEZA.CEZATARIHI, TBLARACTRFCEZA.CEZASAATI, TBLARACTRFCEZA.CEZAACIKLAMA, \r\n                  TBLARACTRFCEZA.CEZATUTARI, TBLARACTRFCEZA.ODEMEDURUM, TBLARACTRFCEZA.ILGILINOT, TBLARACLAR.GOREVDURUM, TBLBELDMUDURLUK.BELDMUDURLUK, TBLBELDBIRIMLER.BELDBIRIMADI\r\nFROM     TBLARACTRFCEZA INNER JOIN\r\n                  TBLARACLAR ON TBLARACTRFCEZA.ARACID = TBLARACLAR.ID LEFT OUTER JOIN\r\n                  TBLBELDMUDURLUK ON TBLARACTRFCEZA.BELDMUDURLUKID = TBLBELDMUDURLUK.ID LEFT OUTER JOIN\r\n                  TBLBELDBIRIMLER ON TBLARACTRFCEZA.BELDBIRIMID = TBLBELDBIRIMLER.ID";
      this._commandCollection[0].CommandType = CommandType.Text;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    public virtual int Fill(AraclarListesi.TrafikListesiDataTable dataTable)
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
    public virtual AraclarListesi.TrafikListesiDataTable GetData()
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      AraclarListesi.TrafikListesiDataTable data = new AraclarListesi.TrafikListesiDataTable();
      this.Adapter.Fill((DataTable) data);
      return data;
    }
  }
}