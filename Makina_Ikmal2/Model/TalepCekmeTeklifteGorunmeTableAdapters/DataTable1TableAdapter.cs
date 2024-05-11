// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Model.TalepCekmeTeklifteGorunmeTableAdapters.DataTable1TableAdapter
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

namespace Makina_Ikmal.Model.TalepCekmeTeklifteGorunmeTableAdapters
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
            "ARACID",
            "ARACID"
          },
          {
            "BIRIMFIYAT",
            "BIRIMFIYAT"
          },
          {
            "BIRIMID",
            "BIRIMID"
          },
          {
            "MALZEMEADI",
            "MALZEMEADI"
          },
          {
            "FIRMA1ID",
            "FIRMA1ID"
          },
          {
            "F1BIRIMFIYAT",
            "F1BIRIMFIYAT"
          },
          {
            "F1TUTAR",
            "F1TUTAR"
          },
          {
            "FIRMA2ID",
            "FIRMA2ID"
          },
          {
            "F2BIRIMFIYAT",
            "F2BIRIMFIYAT"
          },
          {
            "F2TUTAR",
            "F2TUTAR"
          },
          {
            "FIRMA3ID",
            "FIRMA3ID"
          },
          {
            "F3BIRIMFIYAT",
            "F3BIRIMFIYAT"
          },
          {
            "F3TUTAR",
            "F3TUTAR"
          },
          {
            "FIRMA4ID",
            "FIRMA4ID"
          },
          {
            "F4BIRIMFIYAT",
            "F4BIRIMFIYAT"
          },
          {
            "F4TUTAR",
            "F4TUTAR"
          },
          {
            "FIRMA5ID",
            "FIRMA5ID"
          },
          {
            "F5BIRIMFIYAT",
            "F5BIRIMFIYAT"
          },
          {
            "F5TUTAR",
            "F5TUTAR"
          },
          {
            "FIRMA6ID",
            "FIRMA6ID"
          },
          {
            "F6BIRIMFIYAT",
            "F6BIRIMFIYAT"
          },
          {
            "F6TUTAR",
            "F6TUTAR"
          },
          {
            "FIRMA7ID",
            "FIRMA7ID"
          },
          {
            "F7BIRIMFIYAT",
            "F7BIRIMFIYAT"
          },
          {
            "F7TUTAR",
            "F7TUTAR"
          },
          {
            "FIRMA8ID",
            "FIRMA8ID"
          },
          {
            "F8BIRIMFIYAT",
            "F8BIRIMFIYAT"
          },
          {
            "F8TUTAR",
            "F8TUTAR"
          },
          {
            "TalepID",
            "TalepID"
          },
          {
            "MALZACIKLAMA",
            "MALZACIKLAMA"
          },
          {
            "MIKTAR",
            "MIKTAR"
          },
          {
            "TUTAR",
            "TUTAR"
          },
          {
            "MARKA",
            "MARKA1"
          },
          {
            "MALZEMEID",
            "MALZEMEID1"
          },
          {
            "HRKTID",
            "HRKTID"
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
      this._commandCollection[0].CommandText = "SELECT TBLTEKLIFHRKT.ARACID, TBLTEKLIFHRKT.MALZACIKLAMA, TBLTEKLIFHRKT.MIKTAR, TBLTEKLIFHRKT.MARKA, TBLTEKLIFHRKT.BIRIMFIYAT, TBLTEKLIFHRKT.TUTAR, TBLTEKLIFHRKT.BIRIMID, TBLTEKLIFHRKT.FIRMA1ID, \r\n                  TBLTEKLIFHRKT.F1BIRIMFIYAT, TBLTEKLIFHRKT.F1TUTAR, TBLTEKLIFHRKT.FIRMA2ID, TBLTEKLIFHRKT.F2BIRIMFIYAT, TBLTEKLIFHRKT.F2TUTAR, TBLTEKLIFHRKT.FIRMA3ID, TBLTEKLIFHRKT.F3BIRIMFIYAT, \r\n                  TBLTEKLIFHRKT.F3TUTAR, TBLTEKLIFHRKT.FIRMA4ID, TBLTEKLIFHRKT.F4BIRIMFIYAT, TBLTEKLIFHRKT.F4TUTAR, TBLTEKLIFHRKT.FIRMA5ID, TBLTEKLIFHRKT.F5BIRIMFIYAT, TBLTEKLIFHRKT.F5TUTAR, TBLTEKLIFHRKT.FIRMA6ID, \r\n                  TBLTEKLIFHRKT.F6BIRIMFIYAT, TBLTEKLIFHRKT.F6TUTAR, TBLTEKLIFHRKT.FIRMA7ID, TBLTEKLIFHRKT.F7BIRIMFIYAT, TBLTEKLIFHRKT.F7TUTAR, TBLTEKLIFHRKT.FIRMA8ID, TBLTEKLIFHRKT.F8BIRIMFIYAT, \r\n                  TBLTEKLIFHRKT.F8TUTAR, TBLTEKLIFHRKT.MALZEMEID, TBLMALZEMELER.MALZEMEADI, TBLTEKLIFHRKT.ID AS HRKTID, TBLTALEP.ID AS TalepID\r\nFROM     TBLTEKLIFHRKT AS TBLTEKLIFHRKT INNER JOIN\r\n                  TBLTEKLIF ON TBLTEKLIFHRKT.TEKLIFID = TBLTEKLIF.ID INNER JOIN\r\n                  TBLTALEP ON TBLTEKLIF.ID = TBLTALEP.TEKLIFID INNER JOIN\r\n                  TBLMALZEMELER ON TBLTEKLIFHRKT.MALZEMEID = TBLMALZEMELER.ID\r\nWHERE  (TBLTEKLIF.ID = @Param6)";
      this._commandCollection[0].CommandType = CommandType.Text;
      this._commandCollection[0].Parameters.Add(new SqlParameter("@Param6", SqlDbType.Int, 4, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._commandCollection[1] = new SqlCommand();
      this._commandCollection[1].Connection = new SqlConnection(Settings.Default.bellConnectionString);
      this._commandCollection[1].CommandText = "SELECT        TBLTALEP.TEKLIFID AS TeklifID, TBLTALEP.ID AS TalepID, TBLARACLAR.ID AS aracID, TBLTALEPFISHRKT.MALZACIKLAMA, TBLMALZEMELER.MALZEMEADI, TBLMALZBIRIM.BIRIMADI, TBLARACLAR.PLAKA, \r\n                         TBLTALEPFISHRKT.MIKTAR, TBLTALEPFISHRKT.FIYAT, TBLTALEPFISHRKT.TUTAR\r\nFROM            TBLTALEP INNER JOIN\r\n                         TBLTALEPFIS ON TBLTALEP.ID = TBLTALEPFIS.TALEPKAYITID INNER JOIN\r\n                         TBLISEMRI ON TBLTALEPFIS.ISEMRIID = TBLISEMRI.ID INNER JOIN\r\n                         TBLARACLAR ON TBLISEMRI.ARACID = TBLARACLAR.ID INNER JOIN\r\n                         TBLTALEPFISHRKT ON TBLTALEPFIS.ID = TBLTALEPFISHRKT.TALEPFISID INNER JOIN\r\n                         TBLMALZEMELER ON TBLTALEPFISHRKT.MALZEMEID = TBLMALZEMELER.ID INNER JOIN\r\n                         TBLMALZBIRIM ON TBLMALZEMELER.BIRIMID = TBLMALZBIRIM.ID\r\nWHERE        (TBLTALEP.ID = @Param1)";
      this._commandCollection[1].CommandType = CommandType.Text;
      this._commandCollection[1].Parameters.Add(new SqlParameter("@Param1", SqlDbType.Int, 4, ParameterDirection.Input, (byte) 0, (byte) 0, "TalepID", DataRowVersion.Current, false, (object) null, "", "", ""));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    public virtual int Fill(
      TalepCekmeTeklifteGorunme.DataTable1DataTable dataTable,
      int Param6)
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      this.Adapter.SelectCommand.Parameters[0].Value = (object) Param6;
      if (this.ClearBeforeFill)
        dataTable.Clear();
      return this.Adapter.Fill((DataTable) dataTable);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Select, true)]
    public virtual TalepCekmeTeklifteGorunme.DataTable1DataTable GetData(int Param6)
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      this.Adapter.SelectCommand.Parameters[0].Value = (object) Param6;
      TalepCekmeTeklifteGorunme.DataTable1DataTable data = new TalepCekmeTeklifteGorunme.DataTable1DataTable();
      this.Adapter.Fill((DataTable) data);
      return data;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Fill, false)]
    public virtual int FillBy(
      TalepCekmeTeklifteGorunme.DataTable1DataTable dataTable,
      int Param1)
    {
      this.Adapter.SelectCommand = this.CommandCollection[1];
      this.Adapter.SelectCommand.Parameters[0].Value = (object) Param1;
      if (this.ClearBeforeFill)
        dataTable.Clear();
      return this.Adapter.Fill((DataTable) dataTable);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Select, false)]
    public virtual TalepCekmeTeklifteGorunme.DataTable1DataTable GetDataBy(int Param1)
    {
      this.Adapter.SelectCommand = this.CommandCollection[1];
      this.Adapter.SelectCommand.Parameters[0].Value = (object) Param1;
      TalepCekmeTeklifteGorunme.DataTable1DataTable dataBy = new TalepCekmeTeklifteGorunme.DataTable1DataTable();
      this.Adapter.Fill((DataTable) dataBy);
      return dataBy;
    }
  }
}
