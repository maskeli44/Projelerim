// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.bellDataSet7TableAdapters.TBLLOGTableAdapter
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

namespace Makina_Ikmal.bellDataSet7TableAdapters
{
  [DesignerCategory("code")]
  [ToolboxItem(true)]
  [DataObject(true)]
  [Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [HelpKeyword("vs.data.TableAdapter")]
  public class TBLLOGTableAdapter : Component
  {
    private SqlDataAdapter _adapter;
    private SqlConnection _connection;
    private SqlTransaction _transaction;
    private SqlCommand[] _commandCollection;
    private bool _clearBeforeFill;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public TBLLOGTableAdapter() => this.ClearBeforeFill = true;

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
        DataSetTable = "TBLLOG",
        ColumnMappings = {
          {
            "ID",
            "ID"
          },
          {
            "ISLEMSAYFASI",
            "ISLEMSAYFASI"
          },
          {
            "ISLEMTURU",
            "ISLEMTURU"
          },
          {
            "ISLEMINID",
            "ISLEMINID"
          },
          {
            "TARIH",
            "TARIH"
          },
          {
            "SAAT",
            "SAAT"
          },
          {
            "KULLANICIADI",
            "KULLANICIADI"
          },
          {
            "KULLANICIID",
            "KULLANICIID"
          },
          {
            "IP",
            "IP"
          },
          {
            "MAC",
            "MAC"
          }
        }
      });
      this._adapter.DeleteCommand = new SqlCommand();
      this._adapter.DeleteCommand.Connection = this.Connection;
      this._adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[TBLLOG] WHERE (([ID] = @Original_ID) AND ((@IsNull_ISLEMSAYFASI = 1 AND [ISLEMSAYFASI] IS NULL) OR ([ISLEMSAYFASI] = @Original_ISLEMSAYFASI)) AND ((@IsNull_ISLEMTURU = 1 AND [ISLEMTURU] IS NULL) OR ([ISLEMTURU] = @Original_ISLEMTURU)) AND ((@IsNull_ISLEMINID = 1 AND [ISLEMINID] IS NULL) OR ([ISLEMINID] = @Original_ISLEMINID)) AND ((@IsNull_TARIH = 1 AND [TARIH] IS NULL) OR ([TARIH] = @Original_TARIH)) AND ((@IsNull_SAAT = 1 AND [SAAT] IS NULL) OR ([SAAT] = @Original_SAAT)) AND ((@IsNull_KULLANICIADI = 1 AND [KULLANICIADI] IS NULL) OR ([KULLANICIADI] = @Original_KULLANICIADI)) AND ((@IsNull_KULLANICIID = 1 AND [KULLANICIID] IS NULL) OR ([KULLANICIID] = @Original_KULLANICIID)) AND ((@IsNull_IP = 1 AND [IP] IS NULL) OR ([IP] = @Original_IP)) AND ((@IsNull_MAC = 1 AND [MAC] IS NULL) OR ([MAC] = @Original_MAC)))";
      this._adapter.DeleteCommand.CommandType = CommandType.Text;
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ISLEMSAYFASI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISLEMSAYFASI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ISLEMSAYFASI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISLEMSAYFASI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ISLEMTURU", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISLEMTURU", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ISLEMTURU", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISLEMTURU", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ISLEMINID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISLEMINID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ISLEMINID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISLEMINID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TARIH", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TARIH", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TARIH", SqlDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TARIH", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SAAT", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAAT", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SAAT", SqlDbType.Time, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAAT", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_KULLANICIADI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KULLANICIADI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_KULLANICIADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KULLANICIADI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_KULLANICIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KULLANICIID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_KULLANICIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KULLANICIID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_IP", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IP", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_IP", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IP", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_MAC", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MAC", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_MAC", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MAC", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.InsertCommand = new SqlCommand();
      this._adapter.InsertCommand.Connection = this.Connection;
      this._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[TBLLOG] ([ISLEMSAYFASI], [ISLEMTURU], [ISLEMINID], [TARIH], [SAAT], [KULLANICIADI], [KULLANICIID], [IP], [MAC]) VALUES (@ISLEMSAYFASI, @ISLEMTURU, @ISLEMINID, @TARIH, @SAAT, @KULLANICIADI, @KULLANICIID, @IP, @MAC);\r\nSELECT ID, ISLEMSAYFASI, ISLEMTURU, ISLEMINID, TARIH, SAAT, KULLANICIADI, KULLANICIID, IP, MAC FROM TBLLOG WHERE (ID = SCOPE_IDENTITY())";
      this._adapter.InsertCommand.CommandType = CommandType.Text;
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ISLEMSAYFASI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISLEMSAYFASI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ISLEMTURU", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISLEMTURU", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ISLEMINID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISLEMINID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@TARIH", SqlDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TARIH", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SAAT", SqlDbType.Time, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAAT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@KULLANICIADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KULLANICIADI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@KULLANICIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KULLANICIID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@IP", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IP", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@MAC", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MAC", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand = new SqlCommand();
      this._adapter.UpdateCommand.Connection = this.Connection;
      this._adapter.UpdateCommand.CommandText = "UPDATE [dbo].[TBLLOG] SET [ISLEMSAYFASI] = @ISLEMSAYFASI, [ISLEMTURU] = @ISLEMTURU, [ISLEMINID] = @ISLEMINID, [TARIH] = @TARIH, [SAAT] = @SAAT, [KULLANICIADI] = @KULLANICIADI, [KULLANICIID] = @KULLANICIID, [IP] = @IP, [MAC] = @MAC WHERE (([ID] = @Original_ID) AND ((@IsNull_ISLEMSAYFASI = 1 AND [ISLEMSAYFASI] IS NULL) OR ([ISLEMSAYFASI] = @Original_ISLEMSAYFASI)) AND ((@IsNull_ISLEMTURU = 1 AND [ISLEMTURU] IS NULL) OR ([ISLEMTURU] = @Original_ISLEMTURU)) AND ((@IsNull_ISLEMINID = 1 AND [ISLEMINID] IS NULL) OR ([ISLEMINID] = @Original_ISLEMINID)) AND ((@IsNull_TARIH = 1 AND [TARIH] IS NULL) OR ([TARIH] = @Original_TARIH)) AND ((@IsNull_SAAT = 1 AND [SAAT] IS NULL) OR ([SAAT] = @Original_SAAT)) AND ((@IsNull_KULLANICIADI = 1 AND [KULLANICIADI] IS NULL) OR ([KULLANICIADI] = @Original_KULLANICIADI)) AND ((@IsNull_KULLANICIID = 1 AND [KULLANICIID] IS NULL) OR ([KULLANICIID] = @Original_KULLANICIID)) AND ((@IsNull_IP = 1 AND [IP] IS NULL) OR ([IP] = @Original_IP)) AND ((@IsNull_MAC = 1 AND [MAC] IS NULL) OR ([MAC] = @Original_MAC)));\r\nSELECT ID, ISLEMSAYFASI, ISLEMTURU, ISLEMINID, TARIH, SAAT, KULLANICIADI, KULLANICIID, IP, MAC FROM TBLLOG WHERE (ID = @ID)";
      this._adapter.UpdateCommand.CommandType = CommandType.Text;
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ISLEMSAYFASI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISLEMSAYFASI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ISLEMTURU", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISLEMTURU", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ISLEMINID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISLEMINID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TARIH", SqlDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TARIH", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SAAT", SqlDbType.Time, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAAT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@KULLANICIADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KULLANICIADI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@KULLANICIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KULLANICIID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IP", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IP", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MAC", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MAC", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ISLEMSAYFASI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISLEMSAYFASI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ISLEMSAYFASI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISLEMSAYFASI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ISLEMTURU", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISLEMTURU", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ISLEMTURU", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISLEMTURU", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ISLEMINID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISLEMINID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ISLEMINID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISLEMINID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TARIH", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TARIH", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TARIH", SqlDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TARIH", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SAAT", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAAT", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SAAT", SqlDbType.Time, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAAT", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_KULLANICIADI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KULLANICIADI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_KULLANICIADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KULLANICIADI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_KULLANICIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KULLANICIID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_KULLANICIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KULLANICIID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_IP", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IP", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_IP", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IP", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_MAC", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MAC", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_MAC", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MAC", DataRowVersion.Original, false, (object) null, "", "", ""));
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
      this._commandCollection[0].CommandText = "SELECT ID, ISLEMSAYFASI, ISLEMTURU, ISLEMINID, TARIH, SAAT, KULLANICIADI, KULLANICIID, IP, MAC FROM dbo.TBLLOG";
      this._commandCollection[0].CommandType = CommandType.Text;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    public virtual int Fill(bellDataSet7.TBLLOGDataTable dataTable)
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
    public virtual bellDataSet7.TBLLOGDataTable GetData()
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      bellDataSet7.TBLLOGDataTable data = new bellDataSet7.TBLLOGDataTable();
      this.Adapter.Fill((DataTable) data);
      return data;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(bellDataSet7.TBLLOGDataTable dataTable) => this.Adapter.Update((DataTable) dataTable);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(bellDataSet7 dataSet) => this.Adapter.Update((DataSet) dataSet, "TBLLOG");

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
      string Original_ISLEMSAYFASI,
      string Original_ISLEMTURU,
      int? Original_ISLEMINID,
      DateTime? Original_TARIH,
      TimeSpan? Original_SAAT,
      string Original_KULLANICIADI,
      int? Original_KULLANICIID,
      string Original_IP,
      string Original_MAC)
    {
      this.Adapter.DeleteCommand.Parameters[0].Value = (object) Original_ID;
      if (Original_ISLEMSAYFASI == null)
      {
        this.Adapter.DeleteCommand.Parameters[1].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[2].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[1].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[2].Value = (object) Original_ISLEMSAYFASI;
      }
      if (Original_ISLEMTURU == null)
      {
        this.Adapter.DeleteCommand.Parameters[3].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[4].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[3].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[4].Value = (object) Original_ISLEMTURU;
      }
      if (Original_ISLEMINID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[6].Value = (object) Original_ISLEMINID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[6].Value = (object) DBNull.Value;
      }
      if (Original_TARIH.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[7].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[8].Value = (object) Original_TARIH.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[7].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[8].Value = (object) DBNull.Value;
      }
      if (Original_SAAT.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) Original_SAAT.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) DBNull.Value;
      }
      if (Original_KULLANICIADI == null)
      {
        this.Adapter.DeleteCommand.Parameters[11].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[12].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[11].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[12].Value = (object) Original_KULLANICIADI;
      }
      if (Original_KULLANICIID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[13].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[14].Value = (object) Original_KULLANICIID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[13].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[14].Value = (object) DBNull.Value;
      }
      if (Original_IP == null)
      {
        this.Adapter.DeleteCommand.Parameters[15].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[16].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[15].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[16].Value = (object) Original_IP;
      }
      if (Original_MAC == null)
      {
        this.Adapter.DeleteCommand.Parameters[17].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[18].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[17].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[18].Value = (object) Original_MAC;
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
      string ISLEMSAYFASI,
      string ISLEMTURU,
      int? ISLEMINID,
      DateTime? TARIH,
      TimeSpan? SAAT,
      string KULLANICIADI,
      int? KULLANICIID,
      string IP,
      string MAC)
    {
      if (ISLEMSAYFASI == null)
        this.Adapter.InsertCommand.Parameters[0].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[0].Value = (object) ISLEMSAYFASI;
      if (ISLEMTURU == null)
        this.Adapter.InsertCommand.Parameters[1].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[1].Value = (object) ISLEMTURU;
      if (ISLEMINID.HasValue)
        this.Adapter.InsertCommand.Parameters[2].Value = (object) ISLEMINID.Value;
      else
        this.Adapter.InsertCommand.Parameters[2].Value = (object) DBNull.Value;
      if (TARIH.HasValue)
        this.Adapter.InsertCommand.Parameters[3].Value = (object) TARIH.Value;
      else
        this.Adapter.InsertCommand.Parameters[3].Value = (object) DBNull.Value;
      if (SAAT.HasValue)
        this.Adapter.InsertCommand.Parameters[4].Value = (object) SAAT.Value;
      else
        this.Adapter.InsertCommand.Parameters[4].Value = (object) DBNull.Value;
      if (KULLANICIADI == null)
        this.Adapter.InsertCommand.Parameters[5].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[5].Value = (object) KULLANICIADI;
      if (KULLANICIID.HasValue)
        this.Adapter.InsertCommand.Parameters[6].Value = (object) KULLANICIID.Value;
      else
        this.Adapter.InsertCommand.Parameters[6].Value = (object) DBNull.Value;
      if (IP == null)
        this.Adapter.InsertCommand.Parameters[7].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[7].Value = (object) IP;
      if (MAC == null)
        this.Adapter.InsertCommand.Parameters[8].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[8].Value = (object) MAC;
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
      string ISLEMSAYFASI,
      string ISLEMTURU,
      int? ISLEMINID,
      DateTime? TARIH,
      TimeSpan? SAAT,
      string KULLANICIADI,
      int? KULLANICIID,
      string IP,
      string MAC,
      int Original_ID,
      string Original_ISLEMSAYFASI,
      string Original_ISLEMTURU,
      int? Original_ISLEMINID,
      DateTime? Original_TARIH,
      TimeSpan? Original_SAAT,
      string Original_KULLANICIADI,
      int? Original_KULLANICIID,
      string Original_IP,
      string Original_MAC,
      int ID)
    {
      if (ISLEMSAYFASI == null)
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) ISLEMSAYFASI;
      if (ISLEMTURU == null)
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) ISLEMTURU;
      if (ISLEMINID.HasValue)
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) ISLEMINID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) DBNull.Value;
      if (TARIH.HasValue)
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) TARIH.Value;
      else
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) DBNull.Value;
      if (SAAT.HasValue)
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) SAAT.Value;
      else
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) DBNull.Value;
      if (KULLANICIADI == null)
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) KULLANICIADI;
      if (KULLANICIID.HasValue)
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) KULLANICIID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) DBNull.Value;
      if (IP == null)
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) IP;
      if (MAC == null)
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) MAC;
      this.Adapter.UpdateCommand.Parameters[9].Value = (object) Original_ID;
      if (Original_ISLEMSAYFASI == null)
      {
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) Original_ISLEMSAYFASI;
      }
      if (Original_ISLEMTURU == null)
      {
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) Original_ISLEMTURU;
      }
      if (Original_ISLEMINID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) Original_ISLEMINID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) DBNull.Value;
      }
      if (Original_TARIH.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[16].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[17].Value = (object) Original_TARIH.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[16].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[17].Value = (object) DBNull.Value;
      }
      if (Original_SAAT.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[18].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[19].Value = (object) Original_SAAT.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[18].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[19].Value = (object) DBNull.Value;
      }
      if (Original_KULLANICIADI == null)
      {
        this.Adapter.UpdateCommand.Parameters[20].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[21].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[20].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[21].Value = (object) Original_KULLANICIADI;
      }
      if (Original_KULLANICIID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[22].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[23].Value = (object) Original_KULLANICIID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[22].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[23].Value = (object) DBNull.Value;
      }
      if (Original_IP == null)
      {
        this.Adapter.UpdateCommand.Parameters[24].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[25].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[24].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[25].Value = (object) Original_IP;
      }
      if (Original_MAC == null)
      {
        this.Adapter.UpdateCommand.Parameters[26].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[27].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[26].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[27].Value = (object) Original_MAC;
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
      string ISLEMSAYFASI,
      string ISLEMTURU,
      int? ISLEMINID,
      DateTime? TARIH,
      TimeSpan? SAAT,
      string KULLANICIADI,
      int? KULLANICIID,
      string IP,
      string MAC,
      int Original_ID,
      string Original_ISLEMSAYFASI,
      string Original_ISLEMTURU,
      int? Original_ISLEMINID,
      DateTime? Original_TARIH,
      TimeSpan? Original_SAAT,
      string Original_KULLANICIADI,
      int? Original_KULLANICIID,
      string Original_IP,
      string Original_MAC)
    {
      return this.Update(ISLEMSAYFASI, ISLEMTURU, ISLEMINID, TARIH, SAAT, KULLANICIADI, KULLANICIID, IP, MAC, Original_ID, Original_ISLEMSAYFASI, Original_ISLEMTURU, Original_ISLEMINID, Original_TARIH, Original_SAAT, Original_KULLANICIADI, Original_KULLANICIID, Original_IP, Original_MAC, Original_ID);
    }
  }
}
