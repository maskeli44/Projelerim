// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.bellDataSet1TableAdapters.TBLTALEPHRKTTableAdapter
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

namespace Makina_Ikmal.bellDataSet1TableAdapters
{
  [DesignerCategory("code")]
  [ToolboxItem(true)]
  [DataObject(true)]
  [Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [HelpKeyword("vs.data.TableAdapter")]
  public class TBLTALEPHRKTTableAdapter : Component
  {
    private SqlDataAdapter _adapter;
    private SqlConnection _connection;
    private SqlTransaction _transaction;
    private SqlCommand[] _commandCollection;
    private bool _clearBeforeFill;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public TBLTALEPHRKTTableAdapter() => this.ClearBeforeFill = true;

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
        DataSetTable = "TBLTALEPHRKT",
        ColumnMappings = {
          {
            "ID",
            "ID"
          },
          {
            "TALEPID",
            "TALEPID"
          },
          {
            "ARACID",
            "ARACID"
          },
          {
            "MALZEMEID",
            "MALZEMEID"
          },
          {
            "MALZACIKLAMA",
            "MALZACIKLAMA"
          },
          {
            "BIRIMID",
            "BIRIMID"
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
          }
        }
      });
      this._adapter.DeleteCommand = new SqlCommand();
      this._adapter.DeleteCommand.Connection = this.Connection;
      this._adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[TBLTALEPHRKT] WHERE (([ID] = @Original_ID) AND ((@IsNull_TALEPID = 1 AND [TALEPID] IS NULL) OR ([TALEPID] = @Original_TALEPID)) AND ((@IsNull_ARACID = 1 AND [ARACID] IS NULL) OR ([ARACID] = @Original_ARACID)) AND ((@IsNull_MALZEMEID = 1 AND [MALZEMEID] IS NULL) OR ([MALZEMEID] = @Original_MALZEMEID)) AND ((@IsNull_MALZACIKLAMA = 1 AND [MALZACIKLAMA] IS NULL) OR ([MALZACIKLAMA] = @Original_MALZACIKLAMA)) AND ((@IsNull_BIRIMID = 1 AND [BIRIMID] IS NULL) OR ([BIRIMID] = @Original_BIRIMID)) AND ((@IsNull_MIKTAR = 1 AND [MIKTAR] IS NULL) OR ([MIKTAR] = @Original_MIKTAR)) AND ((@IsNull_FIYAT = 1 AND [FIYAT] IS NULL) OR ([FIYAT] = @Original_FIYAT)) AND ((@IsNull_TUTAR = 1 AND [TUTAR] IS NULL) OR ([TUTAR] = @Original_TUTAR)) AND ((@IsNull_TALEPFISID = 1 AND [TALEPFISID] IS NULL) OR ([TALEPFISID] = @Original_TALEPFISID)))";
      this._adapter.DeleteCommand.CommandType = CommandType.Text;
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TALEPID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TALEPID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TALEPID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TALEPID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ARACID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ARACID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_MALZEMEID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZEMEID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_MALZEMEID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZEMEID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_MALZACIKLAMA", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZACIKLAMA", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_MALZACIKLAMA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZACIKLAMA", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_BIRIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BIRIMID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_BIRIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BIRIMID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_MIKTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MIKTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_MIKTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "MIKTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_FIYAT", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIYAT", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_FIYAT", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "FIYAT", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TUTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TUTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "TUTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TALEPFISID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TALEPFISID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TALEPFISID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TALEPFISID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.InsertCommand = new SqlCommand();
      this._adapter.InsertCommand.Connection = this.Connection;
      this._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[TBLTALEPHRKT] ([TALEPID], [ARACID], [MALZEMEID], [MALZACIKLAMA], [BIRIMID], [MIKTAR], [FIYAT], [TUTAR], [TALEPFISID]) VALUES (@TALEPID, @ARACID, @MALZEMEID, @MALZACIKLAMA, @BIRIMID, @MIKTAR, @FIYAT, @TUTAR, @TALEPFISID);\r\nSELECT ID, TALEPID, ARACID, MALZEMEID, MALZACIKLAMA, BIRIMID, MIKTAR, FIYAT, TUTAR, TALEPFISID FROM TBLTALEPHRKT WHERE (ID = SCOPE_IDENTITY())";
      this._adapter.InsertCommand.CommandType = CommandType.Text;
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@TALEPID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TALEPID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ARACID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@MALZEMEID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZEMEID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@MALZACIKLAMA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZACIKLAMA", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@BIRIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BIRIMID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@MIKTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "MIKTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@FIYAT", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "FIYAT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@TUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "TUTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@TALEPFISID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TALEPFISID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand = new SqlCommand();
      this._adapter.UpdateCommand.Connection = this.Connection;
      this._adapter.UpdateCommand.CommandText = "UPDATE [dbo].[TBLTALEPHRKT] SET [TALEPID] = @TALEPID, [ARACID] = @ARACID, [MALZEMEID] = @MALZEMEID, [MALZACIKLAMA] = @MALZACIKLAMA, [BIRIMID] = @BIRIMID, [MIKTAR] = @MIKTAR, [FIYAT] = @FIYAT, [TUTAR] = @TUTAR, [TALEPFISID] = @TALEPFISID WHERE (([ID] = @Original_ID) AND ((@IsNull_TALEPID = 1 AND [TALEPID] IS NULL) OR ([TALEPID] = @Original_TALEPID)) AND ((@IsNull_ARACID = 1 AND [ARACID] IS NULL) OR ([ARACID] = @Original_ARACID)) AND ((@IsNull_MALZEMEID = 1 AND [MALZEMEID] IS NULL) OR ([MALZEMEID] = @Original_MALZEMEID)) AND ((@IsNull_MALZACIKLAMA = 1 AND [MALZACIKLAMA] IS NULL) OR ([MALZACIKLAMA] = @Original_MALZACIKLAMA)) AND ((@IsNull_BIRIMID = 1 AND [BIRIMID] IS NULL) OR ([BIRIMID] = @Original_BIRIMID)) AND ((@IsNull_MIKTAR = 1 AND [MIKTAR] IS NULL) OR ([MIKTAR] = @Original_MIKTAR)) AND ((@IsNull_FIYAT = 1 AND [FIYAT] IS NULL) OR ([FIYAT] = @Original_FIYAT)) AND ((@IsNull_TUTAR = 1 AND [TUTAR] IS NULL) OR ([TUTAR] = @Original_TUTAR)) AND ((@IsNull_TALEPFISID = 1 AND [TALEPFISID] IS NULL) OR ([TALEPFISID] = @Original_TALEPFISID)));\r\nSELECT ID, TALEPID, ARACID, MALZEMEID, MALZACIKLAMA, BIRIMID, MIKTAR, FIYAT, TUTAR, TALEPFISID FROM TBLTALEPHRKT WHERE (ID = @ID)";
      this._adapter.UpdateCommand.CommandType = CommandType.Text;
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TALEPID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TALEPID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ARACID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MALZEMEID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZEMEID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MALZACIKLAMA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZACIKLAMA", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@BIRIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BIRIMID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MIKTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "MIKTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@FIYAT", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "FIYAT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "TUTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TALEPFISID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TALEPFISID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TALEPID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TALEPID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TALEPID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TALEPID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ARACID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ARACID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_MALZEMEID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZEMEID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_MALZEMEID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZEMEID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_MALZACIKLAMA", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZACIKLAMA", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_MALZACIKLAMA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZACIKLAMA", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_BIRIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BIRIMID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_BIRIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BIRIMID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_MIKTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MIKTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_MIKTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "MIKTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_FIYAT", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIYAT", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_FIYAT", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "FIYAT", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TUTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TUTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "TUTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TALEPFISID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TALEPFISID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TALEPFISID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TALEPFISID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Current, false, (object) null, "", "", ""));
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
      this._commandCollection[0].CommandText = "SELECT ID, TALEPID, ARACID, MALZEMEID, MALZACIKLAMA, BIRIMID, MIKTAR, FIYAT, TUTAR, TALEPFISID FROM dbo.TBLTALEPHRKT";
      this._commandCollection[0].CommandType = CommandType.Text;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    public virtual int Fill(bellDataSet1.TBLTALEPHRKTDataTable dataTable)
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
    public virtual bellDataSet1.TBLTALEPHRKTDataTable GetData()
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      bellDataSet1.TBLTALEPHRKTDataTable data = new bellDataSet1.TBLTALEPHRKTDataTable();
      this.Adapter.Fill((DataTable) data);
      return data;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(bellDataSet1.TBLTALEPHRKTDataTable dataTable) => this.Adapter.Update((DataTable) dataTable);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(bellDataSet1 dataSet) => this.Adapter.Update((DataSet) dataSet, "TBLTALEPHRKT");

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(DataRow dataRow) => this.Adapter.Update(new DataRow[1]
    {
      dataRow
    });

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(DataRow[] dataRows) => this.Adapter.Update(dataRows);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Delete, true)]
    public virtual int Delete(
      int Original_ID,
      int? Original_TALEPID,
      int? Original_ARACID,
      int? Original_MALZEMEID,
      string Original_MALZACIKLAMA,
      int? Original_BIRIMID,
      Decimal? Original_MIKTAR,
      Decimal? Original_FIYAT,
      Decimal? Original_TUTAR,
      int? Original_TALEPFISID)
    {
      this.Adapter.DeleteCommand.Parameters[0].Value = (object) Original_ID;
      if (Original_TALEPID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[1].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[2].Value = (object) Original_TALEPID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[1].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[2].Value = (object) DBNull.Value;
      }
      if (Original_ARACID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[3].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[4].Value = (object) Original_ARACID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[3].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[4].Value = (object) DBNull.Value;
      }
      if (Original_MALZEMEID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[6].Value = (object) Original_MALZEMEID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[6].Value = (object) DBNull.Value;
      }
      if (Original_MALZACIKLAMA == null)
      {
        this.Adapter.DeleteCommand.Parameters[7].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[8].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[7].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[8].Value = (object) Original_MALZACIKLAMA;
      }
      if (Original_BIRIMID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) Original_BIRIMID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) DBNull.Value;
      }
      if (Original_MIKTAR.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[11].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[12].Value = (object) Original_MIKTAR.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[11].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[12].Value = (object) DBNull.Value;
      }
      if (Original_FIYAT.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[13].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[14].Value = (object) Original_FIYAT.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[13].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[14].Value = (object) DBNull.Value;
      }
      if (Original_TUTAR.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[15].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[16].Value = (object) Original_TUTAR.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[15].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[16].Value = (object) DBNull.Value;
      }
      if (Original_TALEPFISID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[17].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[18].Value = (object) Original_TALEPFISID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[17].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[18].Value = (object) DBNull.Value;
      }
      ConnectionState state = this.Adapter.DeleteCommand.Connection.State;
      if ((this.Adapter.DeleteCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
        this.Adapter.DeleteCommand.Connection.Open();
      try
      {
        return this.Adapter.DeleteCommand.ExecuteNonQuery();
      }
      finally
      {
        if (state == ConnectionState.Closed)
          this.Adapter.DeleteCommand.Connection.Close();
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Insert, true)]
    public virtual int Insert(
      int? TALEPID,
      int? ARACID,
      int? MALZEMEID,
      string MALZACIKLAMA,
      int? BIRIMID,
      Decimal? MIKTAR,
      Decimal? FIYAT,
      Decimal? TUTAR,
      int? TALEPFISID)
    {
      if (TALEPID.HasValue)
        this.Adapter.InsertCommand.Parameters[0].Value = (object) TALEPID.Value;
      else
        this.Adapter.InsertCommand.Parameters[0].Value = (object) DBNull.Value;
      if (ARACID.HasValue)
        this.Adapter.InsertCommand.Parameters[1].Value = (object) ARACID.Value;
      else
        this.Adapter.InsertCommand.Parameters[1].Value = (object) DBNull.Value;
      if (MALZEMEID.HasValue)
        this.Adapter.InsertCommand.Parameters[2].Value = (object) MALZEMEID.Value;
      else
        this.Adapter.InsertCommand.Parameters[2].Value = (object) DBNull.Value;
      if (MALZACIKLAMA == null)
        this.Adapter.InsertCommand.Parameters[3].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[3].Value = (object) MALZACIKLAMA;
      if (BIRIMID.HasValue)
        this.Adapter.InsertCommand.Parameters[4].Value = (object) BIRIMID.Value;
      else
        this.Adapter.InsertCommand.Parameters[4].Value = (object) DBNull.Value;
      if (MIKTAR.HasValue)
        this.Adapter.InsertCommand.Parameters[5].Value = (object) MIKTAR.Value;
      else
        this.Adapter.InsertCommand.Parameters[5].Value = (object) DBNull.Value;
      if (FIYAT.HasValue)
        this.Adapter.InsertCommand.Parameters[6].Value = (object) FIYAT.Value;
      else
        this.Adapter.InsertCommand.Parameters[6].Value = (object) DBNull.Value;
      if (TUTAR.HasValue)
        this.Adapter.InsertCommand.Parameters[7].Value = (object) TUTAR.Value;
      else
        this.Adapter.InsertCommand.Parameters[7].Value = (object) DBNull.Value;
      if (TALEPFISID.HasValue)
        this.Adapter.InsertCommand.Parameters[8].Value = (object) TALEPFISID.Value;
      else
        this.Adapter.InsertCommand.Parameters[8].Value = (object) DBNull.Value;
      ConnectionState state = this.Adapter.InsertCommand.Connection.State;
      if ((this.Adapter.InsertCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
        this.Adapter.InsertCommand.Connection.Open();
      try
      {
        return this.Adapter.InsertCommand.ExecuteNonQuery();
      }
      finally
      {
        if (state == ConnectionState.Closed)
          this.Adapter.InsertCommand.Connection.Close();
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Update, true)]
    public virtual int Update(
      int? TALEPID,
      int? ARACID,
      int? MALZEMEID,
      string MALZACIKLAMA,
      int? BIRIMID,
      Decimal? MIKTAR,
      Decimal? FIYAT,
      Decimal? TUTAR,
      int? TALEPFISID,
      int Original_ID,
      int? Original_TALEPID,
      int? Original_ARACID,
      int? Original_MALZEMEID,
      string Original_MALZACIKLAMA,
      int? Original_BIRIMID,
      Decimal? Original_MIKTAR,
      Decimal? Original_FIYAT,
      Decimal? Original_TUTAR,
      int? Original_TALEPFISID,
      int ID)
    {
      if (TALEPID.HasValue)
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) TALEPID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) DBNull.Value;
      if (ARACID.HasValue)
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) ARACID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) DBNull.Value;
      if (MALZEMEID.HasValue)
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) MALZEMEID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) DBNull.Value;
      if (MALZACIKLAMA == null)
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) MALZACIKLAMA;
      if (BIRIMID.HasValue)
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) BIRIMID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) DBNull.Value;
      if (MIKTAR.HasValue)
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) MIKTAR.Value;
      else
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) DBNull.Value;
      if (FIYAT.HasValue)
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) FIYAT.Value;
      else
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) DBNull.Value;
      if (TUTAR.HasValue)
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) TUTAR.Value;
      else
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) DBNull.Value;
      if (TALEPFISID.HasValue)
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) TALEPFISID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) DBNull.Value;
      this.Adapter.UpdateCommand.Parameters[9].Value = (object) Original_ID;
      if (Original_TALEPID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) Original_TALEPID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) DBNull.Value;
      }
      if (Original_ARACID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) Original_ARACID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) DBNull.Value;
      }
      if (Original_MALZEMEID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) Original_MALZEMEID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) DBNull.Value;
      }
      if (Original_MALZACIKLAMA == null)
      {
        this.Adapter.UpdateCommand.Parameters[16].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[17].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[16].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[17].Value = (object) Original_MALZACIKLAMA;
      }
      if (Original_BIRIMID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[18].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[19].Value = (object) Original_BIRIMID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[18].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[19].Value = (object) DBNull.Value;
      }
      if (Original_MIKTAR.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[20].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[21].Value = (object) Original_MIKTAR.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[20].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[21].Value = (object) DBNull.Value;
      }
      if (Original_FIYAT.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[22].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[23].Value = (object) Original_FIYAT.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[22].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[23].Value = (object) DBNull.Value;
      }
      if (Original_TUTAR.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[24].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[25].Value = (object) Original_TUTAR.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[24].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[25].Value = (object) DBNull.Value;
      }
      if (Original_TALEPFISID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[26].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[27].Value = (object) Original_TALEPFISID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[26].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[27].Value = (object) DBNull.Value;
      }
      this.Adapter.UpdateCommand.Parameters[28].Value = (object) ID;
      ConnectionState state = this.Adapter.UpdateCommand.Connection.State;
      if ((this.Adapter.UpdateCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
        this.Adapter.UpdateCommand.Connection.Open();
      try
      {
        return this.Adapter.UpdateCommand.ExecuteNonQuery();
      }
      finally
      {
        if (state == ConnectionState.Closed)
          this.Adapter.UpdateCommand.Connection.Close();
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Update, true)]
    public virtual int Update(
      int? TALEPID,
      int? ARACID,
      int? MALZEMEID,
      string MALZACIKLAMA,
      int? BIRIMID,
      Decimal? MIKTAR,
      Decimal? FIYAT,
      Decimal? TUTAR,
      int? TALEPFISID,
      int Original_ID,
      int? Original_TALEPID,
      int? Original_ARACID,
      int? Original_MALZEMEID,
      string Original_MALZACIKLAMA,
      int? Original_BIRIMID,
      Decimal? Original_MIKTAR,
      Decimal? Original_FIYAT,
      Decimal? Original_TUTAR,
      int? Original_TALEPFISID)
    {
      return this.Update(TALEPID, ARACID, MALZEMEID, MALZACIKLAMA, BIRIMID, MIKTAR, FIYAT, TUTAR, TALEPFISID, Original_ID, Original_TALEPID, Original_ARACID, Original_MALZEMEID, Original_MALZACIKLAMA, Original_BIRIMID, Original_MIKTAR, Original_FIYAT, Original_TUTAR, Original_TALEPFISID, Original_ID);
    }
  }
}
