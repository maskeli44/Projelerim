// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.bellDataSet6TableAdapters.TBLARACMESTKPTableAdapter
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

namespace Makina_Ikmal.bellDataSet6TableAdapters
{
  [DesignerCategory("code")]
  [ToolboxItem(true)]
  [DataObject(true)]
  [Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [HelpKeyword("vs.data.TableAdapter")]
  public class TBLARACMESTKPTableAdapter : Component
  {
    private SqlDataAdapter _adapter;
    private SqlConnection _connection;
    private SqlTransaction _transaction;
    private SqlCommand[] _commandCollection;
    private bool _clearBeforeFill;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public TBLARACMESTKPTableAdapter() => this.ClearBeforeFill = true;

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
        DataSetTable = "TBLARACMESTKP",
        ColumnMappings = {
          {
            "ID",
            "ID"
          },
          {
            "TARIHSAAT",
            "TARIHSAAT"
          },
          {
            "PLAKA",
            "PLAKA"
          },
          {
            "MESAIICI",
            "MESAIICI"
          },
          {
            "MESAIDISI",
            "MESAIDISI"
          },
          {
            "TOPLAMKM",
            "TOPLAMKM"
          },
          {
            "CALISMASURESI",
            "CALISMASURESI"
          }
        }
      });
      this._adapter.DeleteCommand = new SqlCommand();
      this._adapter.DeleteCommand.Connection = this.Connection;
      this._adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[TBLARACMESTKP] WHERE (([ID] = @Original_ID) AND ((@IsNull_TARIHSAAT = 1 AND [TARIHSAAT] IS NULL) OR ([TARIHSAAT] = @Original_TARIHSAAT)) AND ((@IsNull_PLAKA = 1 AND [PLAKA] IS NULL) OR ([PLAKA] = @Original_PLAKA)) AND ((@IsNull_MESAIICI = 1 AND [MESAIICI] IS NULL) OR ([MESAIICI] = @Original_MESAIICI)) AND ((@IsNull_MESAIDISI = 1 AND [MESAIDISI] IS NULL) OR ([MESAIDISI] = @Original_MESAIDISI)) AND ((@IsNull_TOPLAMKM = 1 AND [TOPLAMKM] IS NULL) OR ([TOPLAMKM] = @Original_TOPLAMKM)) AND ((@IsNull_CALISMASURESI = 1 AND [CALISMASURESI] IS NULL) OR ([CALISMASURESI] = @Original_CALISMASURESI)))";
      this._adapter.DeleteCommand.CommandType = CommandType.Text;
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TARIHSAAT", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TARIHSAAT", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TARIHSAAT", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TARIHSAAT", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_PLAKA", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PLAKA", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_PLAKA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PLAKA", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_MESAIICI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MESAIICI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_MESAIICI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MESAIICI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_MESAIDISI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MESAIDISI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_MESAIDISI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MESAIDISI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TOPLAMKM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TOPLAMKM", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TOPLAMKM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TOPLAMKM", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_CALISMASURESI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CALISMASURESI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_CALISMASURESI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CALISMASURESI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.InsertCommand = new SqlCommand();
      this._adapter.InsertCommand.Connection = this.Connection;
      this._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[TBLARACMESTKP] ([TARIHSAAT], [PLAKA], [MESAIICI], [MESAIDISI], [TOPLAMKM], [CALISMASURESI]) VALUES (@TARIHSAAT, @PLAKA, @MESAIICI, @MESAIDISI, @TOPLAMKM, @CALISMASURESI);\r\nSELECT ID, TARIHSAAT, PLAKA, MESAIICI, MESAIDISI, TOPLAMKM, CALISMASURESI FROM TBLARACMESTKP WHERE (ID = SCOPE_IDENTITY())";
      this._adapter.InsertCommand.CommandType = CommandType.Text;
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@TARIHSAAT", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TARIHSAAT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@PLAKA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PLAKA", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@MESAIICI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MESAIICI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@MESAIDISI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MESAIDISI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@TOPLAMKM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TOPLAMKM", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@CALISMASURESI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CALISMASURESI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand = new SqlCommand();
      this._adapter.UpdateCommand.Connection = this.Connection;
      this._adapter.UpdateCommand.CommandText = "UPDATE [dbo].[TBLARACMESTKP] SET [TARIHSAAT] = @TARIHSAAT, [PLAKA] = @PLAKA, [MESAIICI] = @MESAIICI, [MESAIDISI] = @MESAIDISI, [TOPLAMKM] = @TOPLAMKM, [CALISMASURESI] = @CALISMASURESI WHERE (([ID] = @Original_ID) AND ((@IsNull_TARIHSAAT = 1 AND [TARIHSAAT] IS NULL) OR ([TARIHSAAT] = @Original_TARIHSAAT)) AND ((@IsNull_PLAKA = 1 AND [PLAKA] IS NULL) OR ([PLAKA] = @Original_PLAKA)) AND ((@IsNull_MESAIICI = 1 AND [MESAIICI] IS NULL) OR ([MESAIICI] = @Original_MESAIICI)) AND ((@IsNull_MESAIDISI = 1 AND [MESAIDISI] IS NULL) OR ([MESAIDISI] = @Original_MESAIDISI)) AND ((@IsNull_TOPLAMKM = 1 AND [TOPLAMKM] IS NULL) OR ([TOPLAMKM] = @Original_TOPLAMKM)) AND ((@IsNull_CALISMASURESI = 1 AND [CALISMASURESI] IS NULL) OR ([CALISMASURESI] = @Original_CALISMASURESI)));\r\nSELECT ID, TARIHSAAT, PLAKA, MESAIICI, MESAIDISI, TOPLAMKM, CALISMASURESI FROM TBLARACMESTKP WHERE (ID = @ID)";
      this._adapter.UpdateCommand.CommandType = CommandType.Text;
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TARIHSAAT", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TARIHSAAT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@PLAKA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PLAKA", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MESAIICI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MESAIICI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MESAIDISI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MESAIDISI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TOPLAMKM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TOPLAMKM", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@CALISMASURESI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CALISMASURESI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TARIHSAAT", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TARIHSAAT", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TARIHSAAT", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TARIHSAAT", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_PLAKA", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PLAKA", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_PLAKA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PLAKA", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_MESAIICI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MESAIICI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_MESAIICI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MESAIICI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_MESAIDISI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MESAIDISI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_MESAIDISI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MESAIDISI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TOPLAMKM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TOPLAMKM", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TOPLAMKM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TOPLAMKM", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_CALISMASURESI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CALISMASURESI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_CALISMASURESI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CALISMASURESI", DataRowVersion.Original, false, (object) null, "", "", ""));
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
      this._commandCollection[0].CommandText = "SELECT ID, TARIHSAAT, PLAKA, MESAIICI, MESAIDISI, TOPLAMKM, CALISMASURESI FROM dbo.TBLARACMESTKP";
      this._commandCollection[0].CommandType = CommandType.Text;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    public virtual int Fill(bellDataSet6.TBLARACMESTKPDataTable dataTable)
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
    public virtual bellDataSet6.TBLARACMESTKPDataTable GetData()
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      bellDataSet6.TBLARACMESTKPDataTable data = new bellDataSet6.TBLARACMESTKPDataTable();
      this.Adapter.Fill((DataTable) data);
      return data;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(bellDataSet6.TBLARACMESTKPDataTable dataTable) => this.Adapter.Update((DataTable) dataTable);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(bellDataSet6 dataSet) => this.Adapter.Update((DataSet) dataSet, "TBLARACMESTKP");

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
      DateTime? Original_TARIHSAAT,
      string Original_PLAKA,
      string Original_MESAIICI,
      string Original_MESAIDISI,
      string Original_TOPLAMKM,
      string Original_CALISMASURESI)
    {
      this.Adapter.DeleteCommand.Parameters[0].Value = (object) Original_ID;
      if (Original_TARIHSAAT.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[1].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[2].Value = (object) Original_TARIHSAAT.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[1].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[2].Value = (object) DBNull.Value;
      }
      if (Original_PLAKA == null)
      {
        this.Adapter.DeleteCommand.Parameters[3].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[4].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[3].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[4].Value = (object) Original_PLAKA;
      }
      if (Original_MESAIICI == null)
      {
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[6].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[6].Value = (object) Original_MESAIICI;
      }
      if (Original_MESAIDISI == null)
      {
        this.Adapter.DeleteCommand.Parameters[7].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[8].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[7].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[8].Value = (object) Original_MESAIDISI;
      }
      if (Original_TOPLAMKM == null)
      {
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) Original_TOPLAMKM;
      }
      if (Original_CALISMASURESI == null)
      {
        this.Adapter.DeleteCommand.Parameters[11].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[12].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[11].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[12].Value = (object) Original_CALISMASURESI;
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
      DateTime? TARIHSAAT,
      string PLAKA,
      string MESAIICI,
      string MESAIDISI,
      string TOPLAMKM,
      string CALISMASURESI)
    {
      if (TARIHSAAT.HasValue)
        this.Adapter.InsertCommand.Parameters[0].Value = (object) TARIHSAAT.Value;
      else
        this.Adapter.InsertCommand.Parameters[0].Value = (object) DBNull.Value;
      if (PLAKA == null)
        this.Adapter.InsertCommand.Parameters[1].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[1].Value = (object) PLAKA;
      if (MESAIICI == null)
        this.Adapter.InsertCommand.Parameters[2].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[2].Value = (object) MESAIICI;
      if (MESAIDISI == null)
        this.Adapter.InsertCommand.Parameters[3].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[3].Value = (object) MESAIDISI;
      if (TOPLAMKM == null)
        this.Adapter.InsertCommand.Parameters[4].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[4].Value = (object) TOPLAMKM;
      if (CALISMASURESI == null)
        this.Adapter.InsertCommand.Parameters[5].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[5].Value = (object) CALISMASURESI;
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
      DateTime? TARIHSAAT,
      string PLAKA,
      string MESAIICI,
      string MESAIDISI,
      string TOPLAMKM,
      string CALISMASURESI,
      int Original_ID,
      DateTime? Original_TARIHSAAT,
      string Original_PLAKA,
      string Original_MESAIICI,
      string Original_MESAIDISI,
      string Original_TOPLAMKM,
      string Original_CALISMASURESI,
      int ID)
    {
      if (TARIHSAAT.HasValue)
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) TARIHSAAT.Value;
      else
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) DBNull.Value;
      if (PLAKA == null)
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) PLAKA;
      if (MESAIICI == null)
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) MESAIICI;
      if (MESAIDISI == null)
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) MESAIDISI;
      if (TOPLAMKM == null)
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) TOPLAMKM;
      if (CALISMASURESI == null)
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) CALISMASURESI;
      this.Adapter.UpdateCommand.Parameters[6].Value = (object) Original_ID;
      if (Original_TARIHSAAT.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) Original_TARIHSAAT.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) DBNull.Value;
      }
      if (Original_PLAKA == null)
      {
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) Original_PLAKA;
      }
      if (Original_MESAIICI == null)
      {
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) Original_MESAIICI;
      }
      if (Original_MESAIDISI == null)
      {
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) Original_MESAIDISI;
      }
      if (Original_TOPLAMKM == null)
      {
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[16].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[16].Value = (object) Original_TOPLAMKM;
      }
      if (Original_CALISMASURESI == null)
      {
        this.Adapter.UpdateCommand.Parameters[17].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[18].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[17].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[18].Value = (object) Original_CALISMASURESI;
      }
      this.Adapter.UpdateCommand.Parameters[19].Value = (object) ID;
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
      DateTime? TARIHSAAT,
      string PLAKA,
      string MESAIICI,
      string MESAIDISI,
      string TOPLAMKM,
      string CALISMASURESI,
      int Original_ID,
      DateTime? Original_TARIHSAAT,
      string Original_PLAKA,
      string Original_MESAIICI,
      string Original_MESAIDISI,
      string Original_TOPLAMKM,
      string Original_CALISMASURESI)
    {
      return this.Update(TARIHSAAT, PLAKA, MESAIICI, MESAIDISI, TOPLAMKM, CALISMASURESI, Original_ID, Original_TARIHSAAT, Original_PLAKA, Original_MESAIICI, Original_MESAIDISI, Original_TOPLAMKM, Original_CALISMASURESI, Original_ID);
    }
  }
}
