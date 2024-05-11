// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.bellDataSet5TableAdapters.TBLPERSIZINDURUMTableAdapter
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

namespace Makina_Ikmal.bellDataSet5TableAdapters
{
  [DesignerCategory("code")]
  [ToolboxItem(true)]
  [DataObject(true)]
  [Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [HelpKeyword("vs.data.TableAdapter")]
  public class TBLPERSIZINDURUMTableAdapter : Component
  {
    private SqlDataAdapter _adapter;
    private SqlConnection _connection;
    private SqlTransaction _transaction;
    private SqlCommand[] _commandCollection;
    private bool _clearBeforeFill;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public TBLPERSIZINDURUMTableAdapter() => this.ClearBeforeFill = true;

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
        DataSetTable = "TBLPERSIZINDURUM",
        ColumnMappings = {
          {
            "ID",
            "ID"
          },
          {
            "PERSONELID",
            "PERSONELID"
          },
          {
            "PERSONELIZINID",
            "PERSONELIZINID"
          },
          {
            "IZINYILI",
            "IZINYILI"
          },
          {
            "IZINHAKKI",
            "IZINHAKKI"
          },
          {
            "KULLANILANIZIN",
            "KULLANILANIZIN"
          }
        }
      });
      this._adapter.DeleteCommand = new SqlCommand();
      this._adapter.DeleteCommand.Connection = this.Connection;
      this._adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[TBLPERSIZINDURUM] WHERE (([ID] = @Original_ID) AND ((@IsNull_PERSONELID = 1 AND [PERSONELID] IS NULL) OR ([PERSONELID] = @Original_PERSONELID)) AND ((@IsNull_PERSONELIZINID = 1 AND [PERSONELIZINID] IS NULL) OR ([PERSONELIZINID] = @Original_PERSONELIZINID)) AND ((@IsNull_IZINYILI = 1 AND [IZINYILI] IS NULL) OR ([IZINYILI] = @Original_IZINYILI)) AND ((@IsNull_IZINHAKKI = 1 AND [IZINHAKKI] IS NULL) OR ([IZINHAKKI] = @Original_IZINHAKKI)) AND ((@IsNull_KULLANILANIZIN = 1 AND [KULLANILANIZIN] IS NULL) OR ([KULLANILANIZIN] = @Original_KULLANILANIZIN)))";
      this._adapter.DeleteCommand.CommandType = CommandType.Text;
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_PERSONELID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PERSONELID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_PERSONELID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PERSONELID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_PERSONELIZINID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PERSONELIZINID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_PERSONELIZINID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PERSONELIZINID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_IZINYILI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINYILI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_IZINYILI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINYILI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_IZINHAKKI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINHAKKI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_IZINHAKKI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINHAKKI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_KULLANILANIZIN", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KULLANILANIZIN", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_KULLANILANIZIN", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KULLANILANIZIN", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.InsertCommand = new SqlCommand();
      this._adapter.InsertCommand.Connection = this.Connection;
      this._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[TBLPERSIZINDURUM] ([PERSONELID], [PERSONELIZINID], [IZINYILI], [IZINHAKKI], [KULLANILANIZIN]) VALUES (@PERSONELID, @PERSONELIZINID, @IZINYILI, @IZINHAKKI, @KULLANILANIZIN);\r\nSELECT ID, PERSONELID, PERSONELIZINID, IZINYILI, IZINHAKKI, KULLANILANIZIN FROM TBLPERSIZINDURUM WHERE (ID = SCOPE_IDENTITY())";
      this._adapter.InsertCommand.CommandType = CommandType.Text;
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@PERSONELID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PERSONELID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@PERSONELIZINID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PERSONELIZINID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@IZINYILI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINYILI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@IZINHAKKI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINHAKKI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@KULLANILANIZIN", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KULLANILANIZIN", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand = new SqlCommand();
      this._adapter.UpdateCommand.Connection = this.Connection;
      this._adapter.UpdateCommand.CommandText = "UPDATE [dbo].[TBLPERSIZINDURUM] SET [PERSONELID] = @PERSONELID, [PERSONELIZINID] = @PERSONELIZINID, [IZINYILI] = @IZINYILI, [IZINHAKKI] = @IZINHAKKI, [KULLANILANIZIN] = @KULLANILANIZIN WHERE (([ID] = @Original_ID) AND ((@IsNull_PERSONELID = 1 AND [PERSONELID] IS NULL) OR ([PERSONELID] = @Original_PERSONELID)) AND ((@IsNull_PERSONELIZINID = 1 AND [PERSONELIZINID] IS NULL) OR ([PERSONELIZINID] = @Original_PERSONELIZINID)) AND ((@IsNull_IZINYILI = 1 AND [IZINYILI] IS NULL) OR ([IZINYILI] = @Original_IZINYILI)) AND ((@IsNull_IZINHAKKI = 1 AND [IZINHAKKI] IS NULL) OR ([IZINHAKKI] = @Original_IZINHAKKI)) AND ((@IsNull_KULLANILANIZIN = 1 AND [KULLANILANIZIN] IS NULL) OR ([KULLANILANIZIN] = @Original_KULLANILANIZIN)));\r\nSELECT ID, PERSONELID, PERSONELIZINID, IZINYILI, IZINHAKKI, KULLANILANIZIN FROM TBLPERSIZINDURUM WHERE (ID = @ID)";
      this._adapter.UpdateCommand.CommandType = CommandType.Text;
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@PERSONELID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PERSONELID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@PERSONELIZINID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PERSONELIZINID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IZINYILI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINYILI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IZINHAKKI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINHAKKI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@KULLANILANIZIN", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KULLANILANIZIN", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_PERSONELID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PERSONELID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_PERSONELID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PERSONELID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_PERSONELIZINID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PERSONELIZINID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_PERSONELIZINID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PERSONELIZINID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_IZINYILI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINYILI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_IZINYILI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINYILI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_IZINHAKKI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINHAKKI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_IZINHAKKI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINHAKKI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_KULLANILANIZIN", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KULLANILANIZIN", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_KULLANILANIZIN", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KULLANILANIZIN", DataRowVersion.Original, false, (object) null, "", "", ""));
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
      this._commandCollection[0].CommandText = "SELECT ID, PERSONELID, PERSONELIZINID, IZINYILI, IZINHAKKI, KULLANILANIZIN FROM dbo.TBLPERSIZINDURUM";
      this._commandCollection[0].CommandType = CommandType.Text;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    public virtual int Fill(bellDataSet5.TBLPERSIZINDURUMDataTable dataTable)
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
    public virtual bellDataSet5.TBLPERSIZINDURUMDataTable GetData()
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      bellDataSet5.TBLPERSIZINDURUMDataTable data = new bellDataSet5.TBLPERSIZINDURUMDataTable();
      this.Adapter.Fill((DataTable) data);
      return data;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(bellDataSet5.TBLPERSIZINDURUMDataTable dataTable) => this.Adapter.Update((DataTable) dataTable);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(bellDataSet5 dataSet) => this.Adapter.Update((DataSet) dataSet, "TBLPERSIZINDURUM");

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
      int? Original_PERSONELID,
      int? Original_PERSONELIZINID,
      int? Original_IZINYILI,
      int? Original_IZINHAKKI,
      int? Original_KULLANILANIZIN)
    {
      this.Adapter.DeleteCommand.Parameters[0].Value = (object) Original_ID;
      if (Original_PERSONELID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[1].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[2].Value = (object) Original_PERSONELID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[1].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[2].Value = (object) DBNull.Value;
      }
      if (Original_PERSONELIZINID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[3].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[4].Value = (object) Original_PERSONELIZINID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[3].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[4].Value = (object) DBNull.Value;
      }
      if (Original_IZINYILI.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[6].Value = (object) Original_IZINYILI.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[6].Value = (object) DBNull.Value;
      }
      if (Original_IZINHAKKI.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[7].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[8].Value = (object) Original_IZINHAKKI.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[7].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[8].Value = (object) DBNull.Value;
      }
      if (Original_KULLANILANIZIN.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) Original_KULLANILANIZIN.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) DBNull.Value;
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
      int? PERSONELID,
      int? PERSONELIZINID,
      int? IZINYILI,
      int? IZINHAKKI,
      int? KULLANILANIZIN)
    {
      if (PERSONELID.HasValue)
        this.Adapter.InsertCommand.Parameters[0].Value = (object) PERSONELID.Value;
      else
        this.Adapter.InsertCommand.Parameters[0].Value = (object) DBNull.Value;
      if (PERSONELIZINID.HasValue)
        this.Adapter.InsertCommand.Parameters[1].Value = (object) PERSONELIZINID.Value;
      else
        this.Adapter.InsertCommand.Parameters[1].Value = (object) DBNull.Value;
      if (IZINYILI.HasValue)
        this.Adapter.InsertCommand.Parameters[2].Value = (object) IZINYILI.Value;
      else
        this.Adapter.InsertCommand.Parameters[2].Value = (object) DBNull.Value;
      if (IZINHAKKI.HasValue)
        this.Adapter.InsertCommand.Parameters[3].Value = (object) IZINHAKKI.Value;
      else
        this.Adapter.InsertCommand.Parameters[3].Value = (object) DBNull.Value;
      if (KULLANILANIZIN.HasValue)
        this.Adapter.InsertCommand.Parameters[4].Value = (object) KULLANILANIZIN.Value;
      else
        this.Adapter.InsertCommand.Parameters[4].Value = (object) DBNull.Value;
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
      int? PERSONELID,
      int? PERSONELIZINID,
      int? IZINYILI,
      int? IZINHAKKI,
      int? KULLANILANIZIN,
      int Original_ID,
      int? Original_PERSONELID,
      int? Original_PERSONELIZINID,
      int? Original_IZINYILI,
      int? Original_IZINHAKKI,
      int? Original_KULLANILANIZIN,
      int ID)
    {
      if (PERSONELID.HasValue)
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) PERSONELID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) DBNull.Value;
      if (PERSONELIZINID.HasValue)
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) PERSONELIZINID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) DBNull.Value;
      if (IZINYILI.HasValue)
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) IZINYILI.Value;
      else
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) DBNull.Value;
      if (IZINHAKKI.HasValue)
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) IZINHAKKI.Value;
      else
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) DBNull.Value;
      if (KULLANILANIZIN.HasValue)
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) KULLANILANIZIN.Value;
      else
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) DBNull.Value;
      this.Adapter.UpdateCommand.Parameters[5].Value = (object) Original_ID;
      if (Original_PERSONELID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) Original_PERSONELID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) DBNull.Value;
      }
      if (Original_PERSONELIZINID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) Original_PERSONELIZINID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) DBNull.Value;
      }
      if (Original_IZINYILI.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) Original_IZINYILI.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) DBNull.Value;
      }
      if (Original_IZINHAKKI.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) Original_IZINHAKKI.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) DBNull.Value;
      }
      if (Original_KULLANILANIZIN.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) Original_KULLANILANIZIN.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) DBNull.Value;
      }
      this.Adapter.UpdateCommand.Parameters[16].Value = (object) ID;
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
      int? PERSONELID,
      int? PERSONELIZINID,
      int? IZINYILI,
      int? IZINHAKKI,
      int? KULLANILANIZIN,
      int Original_ID,
      int? Original_PERSONELID,
      int? Original_PERSONELIZINID,
      int? Original_IZINYILI,
      int? Original_IZINHAKKI,
      int? Original_KULLANILANIZIN)
    {
      return this.Update(PERSONELID, PERSONELIZINID, IZINYILI, IZINHAKKI, KULLANILANIZIN, Original_ID, Original_PERSONELID, Original_PERSONELIZINID, Original_IZINYILI, Original_IZINHAKKI, Original_KULLANILANIZIN, Original_ID);
    }
  }
}
