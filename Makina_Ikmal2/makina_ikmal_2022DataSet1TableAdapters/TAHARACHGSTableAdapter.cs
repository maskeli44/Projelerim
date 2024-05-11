// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.makina_ikmal_2022DataSet1TableAdapters.TAHARACHGSTableAdapter
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

namespace Makina_Ikmal.makina_ikmal_2022DataSet1TableAdapters
{
  [DesignerCategory("code")]
  [ToolboxItem(true)]
  [DataObject(true)]
  [Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [HelpKeyword("vs.data.TableAdapter")]
  public class TAHARACHGSTableAdapter : Component
  {
    private SqlDataAdapter _adapter;
    private SqlConnection _connection;
    private SqlTransaction _transaction;
    private SqlCommand[] _commandCollection;
    private bool _clearBeforeFill;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public TAHARACHGSTableAdapter() => this.ClearBeforeFill = true;

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
        DataSetTable = "TAHARACHGS",
        ColumnMappings = {
          {
            "ID",
            "ID"
          },
          {
            "ARACID",
            "ARACID"
          },
          {
            "HGSTARIH",
            "HGSTARIH"
          },
          {
            "HGSETIKETNO",
            "HGSETIKETNO"
          },
          {
            "GUNCELARAC",
            "GUNCELARAC"
          },
          {
            "GUNCELTARIH",
            "GUNCELTARIH"
          },
          {
            "IPTALTARIH",
            "IPTALTARIH"
          },
          {
            "ILGILINOT",
            "ILGILINOT"
          }
        }
      });
      this._adapter.DeleteCommand = new SqlCommand();
      this._adapter.DeleteCommand.Connection = this.Connection;
      this._adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[TAHARACHGS] WHERE (([ID] = @Original_ID) AND ((@IsNull_ARACID = 1 AND [ARACID] IS NULL) OR ([ARACID] = @Original_ARACID)) AND ((@IsNull_HGSTARIH = 1 AND [HGSTARIH] IS NULL) OR ([HGSTARIH] = @Original_HGSTARIH)) AND ((@IsNull_HGSETIKETNO = 1 AND [HGSETIKETNO] IS NULL) OR ([HGSETIKETNO] = @Original_HGSETIKETNO)) AND ((@IsNull_GUNCELARAC = 1 AND [GUNCELARAC] IS NULL) OR ([GUNCELARAC] = @Original_GUNCELARAC)) AND ((@IsNull_GUNCELTARIH = 1 AND [GUNCELTARIH] IS NULL) OR ([GUNCELTARIH] = @Original_GUNCELTARIH)) AND ((@IsNull_IPTALTARIH = 1 AND [IPTALTARIH] IS NULL) OR ([IPTALTARIH] = @Original_IPTALTARIH)) AND ((@IsNull_ILGILINOT = 1 AND [ILGILINOT] IS NULL) OR ([ILGILINOT] = @Original_ILGILINOT)))";
      this._adapter.DeleteCommand.CommandType = CommandType.Text;
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ARACID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ARACID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_HGSTARIH", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "HGSTARIH", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_HGSTARIH", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "HGSTARIH", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_HGSETIKETNO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "HGSETIKETNO", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_HGSETIKETNO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "HGSETIKETNO", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_GUNCELARAC", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GUNCELARAC", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_GUNCELARAC", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GUNCELARAC", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_GUNCELTARIH", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GUNCELTARIH", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_GUNCELTARIH", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GUNCELTARIH", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_IPTALTARIH", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IPTALTARIH", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_IPTALTARIH", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IPTALTARIH", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ILGILINOT", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ILGILINOT", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ILGILINOT", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ILGILINOT", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.InsertCommand = new SqlCommand();
      this._adapter.InsertCommand.Connection = this.Connection;
      this._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[TAHARACHGS] ([ARACID], [HGSTARIH], [HGSETIKETNO], [GUNCELARAC], [GUNCELTARIH], [IPTALTARIH], [ILGILINOT]) VALUES (@ARACID, @HGSTARIH, @HGSETIKETNO, @GUNCELARAC, @GUNCELTARIH, @IPTALTARIH, @ILGILINOT);\r\nSELECT ID, ARACID, HGSTARIH, HGSETIKETNO, GUNCELARAC, GUNCELTARIH, IPTALTARIH, ILGILINOT FROM TAHARACHGS WHERE (ID = SCOPE_IDENTITY())";
      this._adapter.InsertCommand.CommandType = CommandType.Text;
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ARACID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@HGSTARIH", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "HGSTARIH", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@HGSETIKETNO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "HGSETIKETNO", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@GUNCELARAC", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GUNCELARAC", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@GUNCELTARIH", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GUNCELTARIH", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@IPTALTARIH", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IPTALTARIH", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ILGILINOT", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ILGILINOT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand = new SqlCommand();
      this._adapter.UpdateCommand.Connection = this.Connection;
      this._adapter.UpdateCommand.CommandText = "UPDATE [dbo].[TAHARACHGS] SET [ARACID] = @ARACID, [HGSTARIH] = @HGSTARIH, [HGSETIKETNO] = @HGSETIKETNO, [GUNCELARAC] = @GUNCELARAC, [GUNCELTARIH] = @GUNCELTARIH, [IPTALTARIH] = @IPTALTARIH, [ILGILINOT] = @ILGILINOT WHERE (([ID] = @Original_ID) AND ((@IsNull_ARACID = 1 AND [ARACID] IS NULL) OR ([ARACID] = @Original_ARACID)) AND ((@IsNull_HGSTARIH = 1 AND [HGSTARIH] IS NULL) OR ([HGSTARIH] = @Original_HGSTARIH)) AND ((@IsNull_HGSETIKETNO = 1 AND [HGSETIKETNO] IS NULL) OR ([HGSETIKETNO] = @Original_HGSETIKETNO)) AND ((@IsNull_GUNCELARAC = 1 AND [GUNCELARAC] IS NULL) OR ([GUNCELARAC] = @Original_GUNCELARAC)) AND ((@IsNull_GUNCELTARIH = 1 AND [GUNCELTARIH] IS NULL) OR ([GUNCELTARIH] = @Original_GUNCELTARIH)) AND ((@IsNull_IPTALTARIH = 1 AND [IPTALTARIH] IS NULL) OR ([IPTALTARIH] = @Original_IPTALTARIH)) AND ((@IsNull_ILGILINOT = 1 AND [ILGILINOT] IS NULL) OR ([ILGILINOT] = @Original_ILGILINOT)));\r\nSELECT ID, ARACID, HGSTARIH, HGSETIKETNO, GUNCELARAC, GUNCELTARIH, IPTALTARIH, ILGILINOT FROM TAHARACHGS WHERE (ID = @ID)";
      this._adapter.UpdateCommand.CommandType = CommandType.Text;
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ARACID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@HGSTARIH", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "HGSTARIH", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@HGSETIKETNO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "HGSETIKETNO", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@GUNCELARAC", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GUNCELARAC", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@GUNCELTARIH", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GUNCELTARIH", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IPTALTARIH", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IPTALTARIH", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ILGILINOT", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ILGILINOT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ARACID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ARACID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_HGSTARIH", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "HGSTARIH", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_HGSTARIH", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "HGSTARIH", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_HGSETIKETNO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "HGSETIKETNO", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_HGSETIKETNO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "HGSETIKETNO", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_GUNCELARAC", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GUNCELARAC", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_GUNCELARAC", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GUNCELARAC", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_GUNCELTARIH", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GUNCELTARIH", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_GUNCELTARIH", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GUNCELTARIH", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_IPTALTARIH", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IPTALTARIH", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_IPTALTARIH", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IPTALTARIH", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ILGILINOT", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ILGILINOT", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ILGILINOT", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ILGILINOT", DataRowVersion.Original, false, (object) null, "", "", ""));
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
      this._commandCollection[0].CommandText = "SELECT ID, ARACID, HGSTARIH, HGSETIKETNO, GUNCELARAC, GUNCELTARIH, IPTALTARIH, ILGILINOT FROM dbo.TAHARACHGS";
      this._commandCollection[0].CommandType = CommandType.Text;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    public virtual int Fill(
      makina_ikmal_2022DataSet1.TAHARACHGSDataTable dataTable)
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
    public virtual makina_ikmal_2022DataSet1.TAHARACHGSDataTable GetData()
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      makina_ikmal_2022DataSet1.TAHARACHGSDataTable data = new makina_ikmal_2022DataSet1.TAHARACHGSDataTable();
      this.Adapter.Fill((DataTable) data);
      return data;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(
      makina_ikmal_2022DataSet1.TAHARACHGSDataTable dataTable)
    {
      return this.Adapter.Update((DataTable) dataTable);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(makina_ikmal_2022DataSet1 dataSet) => this.Adapter.Update((DataSet) dataSet, "TAHARACHGS");

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
      int? Original_ARACID,
      DateTime? Original_HGSTARIH,
      string Original_HGSETIKETNO,
      string Original_GUNCELARAC,
      DateTime? Original_GUNCELTARIH,
      DateTime? Original_IPTALTARIH,
      string Original_ILGILINOT)
    {
      this.Adapter.DeleteCommand.Parameters[0].Value = (object) Original_ID;
      if (Original_ARACID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[1].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[2].Value = (object) Original_ARACID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[1].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[2].Value = (object) DBNull.Value;
      }
      if (Original_HGSTARIH.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[3].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[4].Value = (object) Original_HGSTARIH.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[3].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[4].Value = (object) DBNull.Value;
      }
      if (Original_HGSETIKETNO == null)
      {
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[6].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[6].Value = (object) Original_HGSETIKETNO;
      }
      if (Original_GUNCELARAC == null)
      {
        this.Adapter.DeleteCommand.Parameters[7].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[8].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[7].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[8].Value = (object) Original_GUNCELARAC;
      }
      if (Original_GUNCELTARIH.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) Original_GUNCELTARIH.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) DBNull.Value;
      }
      if (Original_IPTALTARIH.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[11].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[12].Value = (object) Original_IPTALTARIH.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[11].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[12].Value = (object) DBNull.Value;
      }
      if (Original_ILGILINOT == null)
      {
        this.Adapter.DeleteCommand.Parameters[13].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[14].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[13].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[14].Value = (object) Original_ILGILINOT;
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
      int? ARACID,
      DateTime? HGSTARIH,
      string HGSETIKETNO,
      string GUNCELARAC,
      DateTime? GUNCELTARIH,
      DateTime? IPTALTARIH,
      string ILGILINOT)
    {
      if (ARACID.HasValue)
        this.Adapter.InsertCommand.Parameters[0].Value = (object) ARACID.Value;
      else
        this.Adapter.InsertCommand.Parameters[0].Value = (object) DBNull.Value;
      if (HGSTARIH.HasValue)
        this.Adapter.InsertCommand.Parameters[1].Value = (object) HGSTARIH.Value;
      else
        this.Adapter.InsertCommand.Parameters[1].Value = (object) DBNull.Value;
      if (HGSETIKETNO == null)
        this.Adapter.InsertCommand.Parameters[2].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[2].Value = (object) HGSETIKETNO;
      if (GUNCELARAC == null)
        this.Adapter.InsertCommand.Parameters[3].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[3].Value = (object) GUNCELARAC;
      if (GUNCELTARIH.HasValue)
        this.Adapter.InsertCommand.Parameters[4].Value = (object) GUNCELTARIH.Value;
      else
        this.Adapter.InsertCommand.Parameters[4].Value = (object) DBNull.Value;
      if (IPTALTARIH.HasValue)
        this.Adapter.InsertCommand.Parameters[5].Value = (object) IPTALTARIH.Value;
      else
        this.Adapter.InsertCommand.Parameters[5].Value = (object) DBNull.Value;
      if (ILGILINOT == null)
        this.Adapter.InsertCommand.Parameters[6].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[6].Value = (object) ILGILINOT;
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
      int? ARACID,
      DateTime? HGSTARIH,
      string HGSETIKETNO,
      string GUNCELARAC,
      DateTime? GUNCELTARIH,
      DateTime? IPTALTARIH,
      string ILGILINOT,
      int Original_ID,
      int? Original_ARACID,
      DateTime? Original_HGSTARIH,
      string Original_HGSETIKETNO,
      string Original_GUNCELARAC,
      DateTime? Original_GUNCELTARIH,
      DateTime? Original_IPTALTARIH,
      string Original_ILGILINOT,
      int ID)
    {
      if (ARACID.HasValue)
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) ARACID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) DBNull.Value;
      if (HGSTARIH.HasValue)
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) HGSTARIH.Value;
      else
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) DBNull.Value;
      if (HGSETIKETNO == null)
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) HGSETIKETNO;
      if (GUNCELARAC == null)
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) GUNCELARAC;
      if (GUNCELTARIH.HasValue)
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) GUNCELTARIH.Value;
      else
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) DBNull.Value;
      if (IPTALTARIH.HasValue)
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) IPTALTARIH.Value;
      else
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) DBNull.Value;
      if (ILGILINOT == null)
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) ILGILINOT;
      this.Adapter.UpdateCommand.Parameters[7].Value = (object) Original_ID;
      if (Original_ARACID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) Original_ARACID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) DBNull.Value;
      }
      if (Original_HGSTARIH.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) Original_HGSTARIH.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) DBNull.Value;
      }
      if (Original_HGSETIKETNO == null)
      {
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) Original_HGSETIKETNO;
      }
      if (Original_GUNCELARAC == null)
      {
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) Original_GUNCELARAC;
      }
      if (Original_GUNCELTARIH.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[16].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[17].Value = (object) Original_GUNCELTARIH.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[16].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[17].Value = (object) DBNull.Value;
      }
      if (Original_IPTALTARIH.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[18].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[19].Value = (object) Original_IPTALTARIH.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[18].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[19].Value = (object) DBNull.Value;
      }
      if (Original_ILGILINOT == null)
      {
        this.Adapter.UpdateCommand.Parameters[20].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[21].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[20].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[21].Value = (object) Original_ILGILINOT;
      }
      this.Adapter.UpdateCommand.Parameters[22].Value = (object) ID;
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
      int? ARACID,
      DateTime? HGSTARIH,
      string HGSETIKETNO,
      string GUNCELARAC,
      DateTime? GUNCELTARIH,
      DateTime? IPTALTARIH,
      string ILGILINOT,
      int Original_ID,
      int? Original_ARACID,
      DateTime? Original_HGSTARIH,
      string Original_HGSETIKETNO,
      string Original_GUNCELARAC,
      DateTime? Original_GUNCELTARIH,
      DateTime? Original_IPTALTARIH,
      string Original_ILGILINOT)
    {
      return this.Update(ARACID, HGSTARIH, HGSETIKETNO, GUNCELARAC, GUNCELTARIH, IPTALTARIH, ILGILINOT, Original_ID, Original_ARACID, Original_HGSTARIH, Original_HGSETIKETNO, Original_GUNCELARAC, Original_GUNCELTARIH, Original_IPTALTARIH, Original_ILGILINOT, Original_ID);
    }
  }
}
