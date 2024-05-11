// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.bellDataSet7TableAdapters.TBLYETKILIMZATableAdapter
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
  public class TBLYETKILIMZATableAdapter : Component
  {
    private SqlDataAdapter _adapter;
    private SqlConnection _connection;
    private SqlTransaction _transaction;
    private SqlCommand[] _commandCollection;
    private bool _clearBeforeFill;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public TBLYETKILIMZATableAdapter() => this.ClearBeforeFill = true;

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
        DataSetTable = "TBLYETKILIMZA",
        ColumnMappings = {
          {
            "ID",
            "ID"
          },
          {
            "BELBSKNID",
            "BELBSKNID"
          },
          {
            "GENELSKRTRID",
            "GENELSKRTRID"
          },
          {
            "GENELSKRTRYRDMCID",
            "GENELSKRTRYRDMCID"
          },
          {
            "DAIREBSKNID",
            "DAIREBSKNID"
          },
          {
            "SUBEMDRID",
            "SUBEMDRID"
          },
          {
            "ATOLYESEFID",
            "ATOLYESEFID"
          },
          {
            "DEPOYETKILID",
            "DEPOYETKILID"
          },
          {
            "TKLFSORUMLUID",
            "TKLFSORUMLUID"
          },
          {
            "PYSARSTRMAUYE1ID",
            "PYSARSTRMAUYE1ID"
          },
          {
            "PYSARSTRMAUYE2ID",
            "PYSARSTRMAUYE2ID"
          },
          {
            "PYSARSTRMABSKNID",
            "PYSARSTRMABSKNID"
          },
          {
            "KABULKOMUYE1ID",
            "KABULKOMUYE1ID"
          },
          {
            "KABULKOMUYE2ID",
            "KABULKOMUYE2ID"
          },
          {
            "KABULKOMBASKANID",
            "KABULKOMBASKANID"
          },
          {
            "YAGSORUMLUSU",
            "YAGSORUMLUSU"
          }
        }
      });
      this._adapter.DeleteCommand = new SqlCommand();
      this._adapter.DeleteCommand.Connection = this.Connection;
      this._adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[TBLYETKILIMZA] WHERE (([ID] = @Original_ID) AND ((@IsNull_BELBSKNID = 1 AND [BELBSKNID] IS NULL) OR ([BELBSKNID] = @Original_BELBSKNID)) AND ((@IsNull_GENELSKRTRID = 1 AND [GENELSKRTRID] IS NULL) OR ([GENELSKRTRID] = @Original_GENELSKRTRID)) AND ((@IsNull_GENELSKRTRYRDMCID = 1 AND [GENELSKRTRYRDMCID] IS NULL) OR ([GENELSKRTRYRDMCID] = @Original_GENELSKRTRYRDMCID)) AND ((@IsNull_DAIREBSKNID = 1 AND [DAIREBSKNID] IS NULL) OR ([DAIREBSKNID] = @Original_DAIREBSKNID)) AND ((@IsNull_SUBEMDRID = 1 AND [SUBEMDRID] IS NULL) OR ([SUBEMDRID] = @Original_SUBEMDRID)) AND ((@IsNull_ATOLYESEFID = 1 AND [ATOLYESEFID] IS NULL) OR ([ATOLYESEFID] = @Original_ATOLYESEFID)) AND ((@IsNull_DEPOYETKILID = 1 AND [DEPOYETKILID] IS NULL) OR ([DEPOYETKILID] = @Original_DEPOYETKILID)) AND ((@IsNull_TKLFSORUMLUID = 1 AND [TKLFSORUMLUID] IS NULL) OR ([TKLFSORUMLUID] = @Original_TKLFSORUMLUID)) AND ((@IsNull_PYSARSTRMAUYE1ID = 1 AND [PYSARSTRMAUYE1ID] IS NULL) OR ([PYSARSTRMAUYE1ID] = @Original_PYSARSTRMAUYE1ID)) AND ((@IsNull_PYSARSTRMAUYE2ID = 1 AND [PYSARSTRMAUYE2ID] IS NULL) OR ([PYSARSTRMAUYE2ID] = @Original_PYSARSTRMAUYE2ID)) AND ((@IsNull_PYSARSTRMABSKNID = 1 AND [PYSARSTRMABSKNID] IS NULL) OR ([PYSARSTRMABSKNID] = @Original_PYSARSTRMABSKNID)) AND ((@IsNull_KABULKOMUYE1ID = 1 AND [KABULKOMUYE1ID] IS NULL) OR ([KABULKOMUYE1ID] = @Original_KABULKOMUYE1ID)) AND ((@IsNull_KABULKOMUYE2ID = 1 AND [KABULKOMUYE2ID] IS NULL) OR ([KABULKOMUYE2ID] = @Original_KABULKOMUYE2ID)) AND ((@IsNull_KABULKOMBASKANID = 1 AND [KABULKOMBASKANID] IS NULL) OR ([KABULKOMBASKANID] = @Original_KABULKOMBASKANID)) AND ((@IsNull_YAGSORUMLUSU = 1 AND [YAGSORUMLUSU] IS NULL) OR ([YAGSORUMLUSU] = @Original_YAGSORUMLUSU)))";
      this._adapter.DeleteCommand.CommandType = CommandType.Text;
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_BELBSKNID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELBSKNID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_BELBSKNID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELBSKNID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_GENELSKRTRID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GENELSKRTRID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_GENELSKRTRID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GENELSKRTRID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_GENELSKRTRYRDMCID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GENELSKRTRYRDMCID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_GENELSKRTRYRDMCID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GENELSKRTRYRDMCID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_DAIREBSKNID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DAIREBSKNID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_DAIREBSKNID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DAIREBSKNID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SUBEMDRID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SUBEMDRID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SUBEMDRID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SUBEMDRID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ATOLYESEFID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ATOLYESEFID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ATOLYESEFID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ATOLYESEFID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_DEPOYETKILID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DEPOYETKILID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_DEPOYETKILID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DEPOYETKILID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TKLFSORUMLUID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TKLFSORUMLUID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TKLFSORUMLUID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TKLFSORUMLUID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_PYSARSTRMAUYE1ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PYSARSTRMAUYE1ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_PYSARSTRMAUYE1ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PYSARSTRMAUYE1ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_PYSARSTRMAUYE2ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PYSARSTRMAUYE2ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_PYSARSTRMAUYE2ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PYSARSTRMAUYE2ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_PYSARSTRMABSKNID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PYSARSTRMABSKNID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_PYSARSTRMABSKNID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PYSARSTRMABSKNID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_KABULKOMUYE1ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KABULKOMUYE1ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_KABULKOMUYE1ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KABULKOMUYE1ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_KABULKOMUYE2ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KABULKOMUYE2ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_KABULKOMUYE2ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KABULKOMUYE2ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_KABULKOMBASKANID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KABULKOMBASKANID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_KABULKOMBASKANID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KABULKOMBASKANID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_YAGSORUMLUSU", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YAGSORUMLUSU", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_YAGSORUMLUSU", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YAGSORUMLUSU", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.InsertCommand = new SqlCommand();
      this._adapter.InsertCommand.Connection = this.Connection;
      this._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[TBLYETKILIMZA] ([BELBSKNID], [GENELSKRTRID], [GENELSKRTRYRDMCID], [DAIREBSKNID], [SUBEMDRID], [ATOLYESEFID], [DEPOYETKILID], [TKLFSORUMLUID], [PYSARSTRMAUYE1ID], [PYSARSTRMAUYE2ID], [PYSARSTRMABSKNID], [KABULKOMUYE1ID], [KABULKOMUYE2ID], [KABULKOMBASKANID], [YAGSORUMLUSU]) VALUES (@BELBSKNID, @GENELSKRTRID, @GENELSKRTRYRDMCID, @DAIREBSKNID, @SUBEMDRID, @ATOLYESEFID, @DEPOYETKILID, @TKLFSORUMLUID, @PYSARSTRMAUYE1ID, @PYSARSTRMAUYE2ID, @PYSARSTRMABSKNID, @KABULKOMUYE1ID, @KABULKOMUYE2ID, @KABULKOMBASKANID, @YAGSORUMLUSU);\r\nSELECT ID, BELBSKNID, GENELSKRTRID, GENELSKRTRYRDMCID, DAIREBSKNID, SUBEMDRID, ATOLYESEFID, DEPOYETKILID, TKLFSORUMLUID, PYSARSTRMAUYE1ID, PYSARSTRMAUYE2ID, PYSARSTRMABSKNID, KABULKOMUYE1ID, KABULKOMUYE2ID, KABULKOMBASKANID, YAGSORUMLUSU FROM TBLYETKILIMZA WHERE (ID = SCOPE_IDENTITY())";
      this._adapter.InsertCommand.CommandType = CommandType.Text;
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@BELBSKNID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELBSKNID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@GENELSKRTRID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GENELSKRTRID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@GENELSKRTRYRDMCID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GENELSKRTRYRDMCID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@DAIREBSKNID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DAIREBSKNID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SUBEMDRID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SUBEMDRID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ATOLYESEFID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ATOLYESEFID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@DEPOYETKILID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DEPOYETKILID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@TKLFSORUMLUID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TKLFSORUMLUID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@PYSARSTRMAUYE1ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PYSARSTRMAUYE1ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@PYSARSTRMAUYE2ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PYSARSTRMAUYE2ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@PYSARSTRMABSKNID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PYSARSTRMABSKNID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@KABULKOMUYE1ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KABULKOMUYE1ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@KABULKOMUYE2ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KABULKOMUYE2ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@KABULKOMBASKANID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KABULKOMBASKANID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@YAGSORUMLUSU", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YAGSORUMLUSU", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand = new SqlCommand();
      this._adapter.UpdateCommand.Connection = this.Connection;
      this._adapter.UpdateCommand.CommandText = "UPDATE [dbo].[TBLYETKILIMZA] SET [BELBSKNID] = @BELBSKNID, [GENELSKRTRID] = @GENELSKRTRID, [GENELSKRTRYRDMCID] = @GENELSKRTRYRDMCID, [DAIREBSKNID] = @DAIREBSKNID, [SUBEMDRID] = @SUBEMDRID, [ATOLYESEFID] = @ATOLYESEFID, [DEPOYETKILID] = @DEPOYETKILID, [TKLFSORUMLUID] = @TKLFSORUMLUID, [PYSARSTRMAUYE1ID] = @PYSARSTRMAUYE1ID, [PYSARSTRMAUYE2ID] = @PYSARSTRMAUYE2ID, [PYSARSTRMABSKNID] = @PYSARSTRMABSKNID, [KABULKOMUYE1ID] = @KABULKOMUYE1ID, [KABULKOMUYE2ID] = @KABULKOMUYE2ID, [KABULKOMBASKANID] = @KABULKOMBASKANID, [YAGSORUMLUSU] = @YAGSORUMLUSU WHERE (([ID] = @Original_ID) AND ((@IsNull_BELBSKNID = 1 AND [BELBSKNID] IS NULL) OR ([BELBSKNID] = @Original_BELBSKNID)) AND ((@IsNull_GENELSKRTRID = 1 AND [GENELSKRTRID] IS NULL) OR ([GENELSKRTRID] = @Original_GENELSKRTRID)) AND ((@IsNull_GENELSKRTRYRDMCID = 1 AND [GENELSKRTRYRDMCID] IS NULL) OR ([GENELSKRTRYRDMCID] = @Original_GENELSKRTRYRDMCID)) AND ((@IsNull_DAIREBSKNID = 1 AND [DAIREBSKNID] IS NULL) OR ([DAIREBSKNID] = @Original_DAIREBSKNID)) AND ((@IsNull_SUBEMDRID = 1 AND [SUBEMDRID] IS NULL) OR ([SUBEMDRID] = @Original_SUBEMDRID)) AND ((@IsNull_ATOLYESEFID = 1 AND [ATOLYESEFID] IS NULL) OR ([ATOLYESEFID] = @Original_ATOLYESEFID)) AND ((@IsNull_DEPOYETKILID = 1 AND [DEPOYETKILID] IS NULL) OR ([DEPOYETKILID] = @Original_DEPOYETKILID)) AND ((@IsNull_TKLFSORUMLUID = 1 AND [TKLFSORUMLUID] IS NULL) OR ([TKLFSORUMLUID] = @Original_TKLFSORUMLUID)) AND ((@IsNull_PYSARSTRMAUYE1ID = 1 AND [PYSARSTRMAUYE1ID] IS NULL) OR ([PYSARSTRMAUYE1ID] = @Original_PYSARSTRMAUYE1ID)) AND ((@IsNull_PYSARSTRMAUYE2ID = 1 AND [PYSARSTRMAUYE2ID] IS NULL) OR ([PYSARSTRMAUYE2ID] = @Original_PYSARSTRMAUYE2ID)) AND ((@IsNull_PYSARSTRMABSKNID = 1 AND [PYSARSTRMABSKNID] IS NULL) OR ([PYSARSTRMABSKNID] = @Original_PYSARSTRMABSKNID)) AND ((@IsNull_KABULKOMUYE1ID = 1 AND [KABULKOMUYE1ID] IS NULL) OR ([KABULKOMUYE1ID] = @Original_KABULKOMUYE1ID)) AND ((@IsNull_KABULKOMUYE2ID = 1 AND [KABULKOMUYE2ID] IS NULL) OR ([KABULKOMUYE2ID] = @Original_KABULKOMUYE2ID)) AND ((@IsNull_KABULKOMBASKANID = 1 AND [KABULKOMBASKANID] IS NULL) OR ([KABULKOMBASKANID] = @Original_KABULKOMBASKANID)) AND ((@IsNull_YAGSORUMLUSU = 1 AND [YAGSORUMLUSU] IS NULL) OR ([YAGSORUMLUSU] = @Original_YAGSORUMLUSU)));\r\nSELECT ID, BELBSKNID, GENELSKRTRID, GENELSKRTRYRDMCID, DAIREBSKNID, SUBEMDRID, ATOLYESEFID, DEPOYETKILID, TKLFSORUMLUID, PYSARSTRMAUYE1ID, PYSARSTRMAUYE2ID, PYSARSTRMABSKNID, KABULKOMUYE1ID, KABULKOMUYE2ID, KABULKOMBASKANID, YAGSORUMLUSU FROM TBLYETKILIMZA WHERE (ID = @ID)";
      this._adapter.UpdateCommand.CommandType = CommandType.Text;
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@BELBSKNID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELBSKNID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@GENELSKRTRID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GENELSKRTRID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@GENELSKRTRYRDMCID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GENELSKRTRYRDMCID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@DAIREBSKNID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DAIREBSKNID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SUBEMDRID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SUBEMDRID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ATOLYESEFID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ATOLYESEFID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@DEPOYETKILID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DEPOYETKILID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TKLFSORUMLUID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TKLFSORUMLUID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@PYSARSTRMAUYE1ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PYSARSTRMAUYE1ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@PYSARSTRMAUYE2ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PYSARSTRMAUYE2ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@PYSARSTRMABSKNID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PYSARSTRMABSKNID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@KABULKOMUYE1ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KABULKOMUYE1ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@KABULKOMUYE2ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KABULKOMUYE2ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@KABULKOMBASKANID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KABULKOMBASKANID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@YAGSORUMLUSU", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YAGSORUMLUSU", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_BELBSKNID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELBSKNID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_BELBSKNID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELBSKNID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_GENELSKRTRID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GENELSKRTRID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_GENELSKRTRID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GENELSKRTRID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_GENELSKRTRYRDMCID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GENELSKRTRYRDMCID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_GENELSKRTRYRDMCID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GENELSKRTRYRDMCID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_DAIREBSKNID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DAIREBSKNID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_DAIREBSKNID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DAIREBSKNID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SUBEMDRID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SUBEMDRID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SUBEMDRID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SUBEMDRID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ATOLYESEFID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ATOLYESEFID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ATOLYESEFID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ATOLYESEFID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_DEPOYETKILID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DEPOYETKILID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_DEPOYETKILID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DEPOYETKILID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TKLFSORUMLUID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TKLFSORUMLUID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TKLFSORUMLUID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TKLFSORUMLUID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_PYSARSTRMAUYE1ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PYSARSTRMAUYE1ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_PYSARSTRMAUYE1ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PYSARSTRMAUYE1ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_PYSARSTRMAUYE2ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PYSARSTRMAUYE2ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_PYSARSTRMAUYE2ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PYSARSTRMAUYE2ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_PYSARSTRMABSKNID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PYSARSTRMABSKNID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_PYSARSTRMABSKNID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PYSARSTRMABSKNID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_KABULKOMUYE1ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KABULKOMUYE1ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_KABULKOMUYE1ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KABULKOMUYE1ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_KABULKOMUYE2ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KABULKOMUYE2ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_KABULKOMUYE2ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KABULKOMUYE2ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_KABULKOMBASKANID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KABULKOMBASKANID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_KABULKOMBASKANID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KABULKOMBASKANID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_YAGSORUMLUSU", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YAGSORUMLUSU", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_YAGSORUMLUSU", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YAGSORUMLUSU", DataRowVersion.Original, false, (object) null, "", "", ""));
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
      this._commandCollection[0].CommandText = "SELECT ID, BELBSKNID, GENELSKRTRID, GENELSKRTRYRDMCID, DAIREBSKNID, SUBEMDRID, ATOLYESEFID, DEPOYETKILID, TKLFSORUMLUID, PYSARSTRMAUYE1ID, PYSARSTRMAUYE2ID, PYSARSTRMABSKNID, KABULKOMUYE1ID, KABULKOMUYE2ID, KABULKOMBASKANID, YAGSORUMLUSU FROM dbo.TBLYETKILIMZA";
      this._commandCollection[0].CommandType = CommandType.Text;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    public virtual int Fill(bellDataSet7.TBLYETKILIMZADataTable dataTable)
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
    public virtual bellDataSet7.TBLYETKILIMZADataTable GetData()
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      bellDataSet7.TBLYETKILIMZADataTable data = new bellDataSet7.TBLYETKILIMZADataTable();
      this.Adapter.Fill((DataTable) data);
      return data;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(bellDataSet7.TBLYETKILIMZADataTable dataTable) => this.Adapter.Update((DataTable) dataTable);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(bellDataSet7 dataSet) => this.Adapter.Update((DataSet) dataSet, "TBLYETKILIMZA");

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
      int? Original_BELBSKNID,
      int? Original_GENELSKRTRID,
      int? Original_GENELSKRTRYRDMCID,
      int? Original_DAIREBSKNID,
      int? Original_SUBEMDRID,
      int? Original_ATOLYESEFID,
      int? Original_DEPOYETKILID,
      int? Original_TKLFSORUMLUID,
      int? Original_PYSARSTRMAUYE1ID,
      int? Original_PYSARSTRMAUYE2ID,
      int? Original_PYSARSTRMABSKNID,
      int? Original_KABULKOMUYE1ID,
      int? Original_KABULKOMUYE2ID,
      int? Original_KABULKOMBASKANID,
      int? Original_YAGSORUMLUSU)
    {
      this.Adapter.DeleteCommand.Parameters[0].Value = (object) Original_ID;
      if (Original_BELBSKNID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[1].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[2].Value = (object) Original_BELBSKNID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[1].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[2].Value = (object) DBNull.Value;
      }
      if (Original_GENELSKRTRID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[3].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[4].Value = (object) Original_GENELSKRTRID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[3].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[4].Value = (object) DBNull.Value;
      }
      if (Original_GENELSKRTRYRDMCID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[6].Value = (object) Original_GENELSKRTRYRDMCID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[6].Value = (object) DBNull.Value;
      }
      if (Original_DAIREBSKNID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[7].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[8].Value = (object) Original_DAIREBSKNID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[7].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[8].Value = (object) DBNull.Value;
      }
      if (Original_SUBEMDRID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) Original_SUBEMDRID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) DBNull.Value;
      }
      if (Original_ATOLYESEFID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[11].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[12].Value = (object) Original_ATOLYESEFID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[11].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[12].Value = (object) DBNull.Value;
      }
      if (Original_DEPOYETKILID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[13].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[14].Value = (object) Original_DEPOYETKILID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[13].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[14].Value = (object) DBNull.Value;
      }
      if (Original_TKLFSORUMLUID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[15].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[16].Value = (object) Original_TKLFSORUMLUID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[15].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[16].Value = (object) DBNull.Value;
      }
      if (Original_PYSARSTRMAUYE1ID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[17].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[18].Value = (object) Original_PYSARSTRMAUYE1ID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[17].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[18].Value = (object) DBNull.Value;
      }
      if (Original_PYSARSTRMAUYE2ID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[19].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[20].Value = (object) Original_PYSARSTRMAUYE2ID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[19].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[20].Value = (object) DBNull.Value;
      }
      if (Original_PYSARSTRMABSKNID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[21].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[22].Value = (object) Original_PYSARSTRMABSKNID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[21].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[22].Value = (object) DBNull.Value;
      }
      if (Original_KABULKOMUYE1ID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[23].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[24].Value = (object) Original_KABULKOMUYE1ID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[23].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[24].Value = (object) DBNull.Value;
      }
      if (Original_KABULKOMUYE2ID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[25].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[26].Value = (object) Original_KABULKOMUYE2ID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[25].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[26].Value = (object) DBNull.Value;
      }
      if (Original_KABULKOMBASKANID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[27].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[28].Value = (object) Original_KABULKOMBASKANID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[27].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[28].Value = (object) DBNull.Value;
      }
      if (Original_YAGSORUMLUSU.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[29].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[30].Value = (object) Original_YAGSORUMLUSU.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[29].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[30].Value = (object) DBNull.Value;
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
      int? BELBSKNID,
      int? GENELSKRTRID,
      int? GENELSKRTRYRDMCID,
      int? DAIREBSKNID,
      int? SUBEMDRID,
      int? ATOLYESEFID,
      int? DEPOYETKILID,
      int? TKLFSORUMLUID,
      int? PYSARSTRMAUYE1ID,
      int? PYSARSTRMAUYE2ID,
      int? PYSARSTRMABSKNID,
      int? KABULKOMUYE1ID,
      int? KABULKOMUYE2ID,
      int? KABULKOMBASKANID,
      int? YAGSORUMLUSU)
    {
      if (BELBSKNID.HasValue)
        this.Adapter.InsertCommand.Parameters[0].Value = (object) BELBSKNID.Value;
      else
        this.Adapter.InsertCommand.Parameters[0].Value = (object) DBNull.Value;
      if (GENELSKRTRID.HasValue)
        this.Adapter.InsertCommand.Parameters[1].Value = (object) GENELSKRTRID.Value;
      else
        this.Adapter.InsertCommand.Parameters[1].Value = (object) DBNull.Value;
      if (GENELSKRTRYRDMCID.HasValue)
        this.Adapter.InsertCommand.Parameters[2].Value = (object) GENELSKRTRYRDMCID.Value;
      else
        this.Adapter.InsertCommand.Parameters[2].Value = (object) DBNull.Value;
      if (DAIREBSKNID.HasValue)
        this.Adapter.InsertCommand.Parameters[3].Value = (object) DAIREBSKNID.Value;
      else
        this.Adapter.InsertCommand.Parameters[3].Value = (object) DBNull.Value;
      if (SUBEMDRID.HasValue)
        this.Adapter.InsertCommand.Parameters[4].Value = (object) SUBEMDRID.Value;
      else
        this.Adapter.InsertCommand.Parameters[4].Value = (object) DBNull.Value;
      if (ATOLYESEFID.HasValue)
        this.Adapter.InsertCommand.Parameters[5].Value = (object) ATOLYESEFID.Value;
      else
        this.Adapter.InsertCommand.Parameters[5].Value = (object) DBNull.Value;
      if (DEPOYETKILID.HasValue)
        this.Adapter.InsertCommand.Parameters[6].Value = (object) DEPOYETKILID.Value;
      else
        this.Adapter.InsertCommand.Parameters[6].Value = (object) DBNull.Value;
      if (TKLFSORUMLUID.HasValue)
        this.Adapter.InsertCommand.Parameters[7].Value = (object) TKLFSORUMLUID.Value;
      else
        this.Adapter.InsertCommand.Parameters[7].Value = (object) DBNull.Value;
      if (PYSARSTRMAUYE1ID.HasValue)
        this.Adapter.InsertCommand.Parameters[8].Value = (object) PYSARSTRMAUYE1ID.Value;
      else
        this.Adapter.InsertCommand.Parameters[8].Value = (object) DBNull.Value;
      if (PYSARSTRMAUYE2ID.HasValue)
        this.Adapter.InsertCommand.Parameters[9].Value = (object) PYSARSTRMAUYE2ID.Value;
      else
        this.Adapter.InsertCommand.Parameters[9].Value = (object) DBNull.Value;
      if (PYSARSTRMABSKNID.HasValue)
        this.Adapter.InsertCommand.Parameters[10].Value = (object) PYSARSTRMABSKNID.Value;
      else
        this.Adapter.InsertCommand.Parameters[10].Value = (object) DBNull.Value;
      if (KABULKOMUYE1ID.HasValue)
        this.Adapter.InsertCommand.Parameters[11].Value = (object) KABULKOMUYE1ID.Value;
      else
        this.Adapter.InsertCommand.Parameters[11].Value = (object) DBNull.Value;
      if (KABULKOMUYE2ID.HasValue)
        this.Adapter.InsertCommand.Parameters[12].Value = (object) KABULKOMUYE2ID.Value;
      else
        this.Adapter.InsertCommand.Parameters[12].Value = (object) DBNull.Value;
      if (KABULKOMBASKANID.HasValue)
        this.Adapter.InsertCommand.Parameters[13].Value = (object) KABULKOMBASKANID.Value;
      else
        this.Adapter.InsertCommand.Parameters[13].Value = (object) DBNull.Value;
      if (YAGSORUMLUSU.HasValue)
        this.Adapter.InsertCommand.Parameters[14].Value = (object) YAGSORUMLUSU.Value;
      else
        this.Adapter.InsertCommand.Parameters[14].Value = (object) DBNull.Value;
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
      int? BELBSKNID,
      int? GENELSKRTRID,
      int? GENELSKRTRYRDMCID,
      int? DAIREBSKNID,
      int? SUBEMDRID,
      int? ATOLYESEFID,
      int? DEPOYETKILID,
      int? TKLFSORUMLUID,
      int? PYSARSTRMAUYE1ID,
      int? PYSARSTRMAUYE2ID,
      int? PYSARSTRMABSKNID,
      int? KABULKOMUYE1ID,
      int? KABULKOMUYE2ID,
      int? KABULKOMBASKANID,
      int? YAGSORUMLUSU,
      int Original_ID,
      int? Original_BELBSKNID,
      int? Original_GENELSKRTRID,
      int? Original_GENELSKRTRYRDMCID,
      int? Original_DAIREBSKNID,
      int? Original_SUBEMDRID,
      int? Original_ATOLYESEFID,
      int? Original_DEPOYETKILID,
      int? Original_TKLFSORUMLUID,
      int? Original_PYSARSTRMAUYE1ID,
      int? Original_PYSARSTRMAUYE2ID,
      int? Original_PYSARSTRMABSKNID,
      int? Original_KABULKOMUYE1ID,
      int? Original_KABULKOMUYE2ID,
      int? Original_KABULKOMBASKANID,
      int? Original_YAGSORUMLUSU,
      int ID)
    {
      if (BELBSKNID.HasValue)
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) BELBSKNID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) DBNull.Value;
      if (GENELSKRTRID.HasValue)
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) GENELSKRTRID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) DBNull.Value;
      if (GENELSKRTRYRDMCID.HasValue)
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) GENELSKRTRYRDMCID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) DBNull.Value;
      if (DAIREBSKNID.HasValue)
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) DAIREBSKNID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) DBNull.Value;
      if (SUBEMDRID.HasValue)
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) SUBEMDRID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) DBNull.Value;
      if (ATOLYESEFID.HasValue)
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) ATOLYESEFID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) DBNull.Value;
      if (DEPOYETKILID.HasValue)
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) DEPOYETKILID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) DBNull.Value;
      if (TKLFSORUMLUID.HasValue)
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) TKLFSORUMLUID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) DBNull.Value;
      if (PYSARSTRMAUYE1ID.HasValue)
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) PYSARSTRMAUYE1ID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) DBNull.Value;
      if (PYSARSTRMAUYE2ID.HasValue)
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) PYSARSTRMAUYE2ID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) DBNull.Value;
      if (PYSARSTRMABSKNID.HasValue)
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) PYSARSTRMABSKNID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) DBNull.Value;
      if (KABULKOMUYE1ID.HasValue)
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) KABULKOMUYE1ID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) DBNull.Value;
      if (KABULKOMUYE2ID.HasValue)
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) KABULKOMUYE2ID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) DBNull.Value;
      if (KABULKOMBASKANID.HasValue)
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) KABULKOMBASKANID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) DBNull.Value;
      if (YAGSORUMLUSU.HasValue)
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) YAGSORUMLUSU.Value;
      else
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) DBNull.Value;
      this.Adapter.UpdateCommand.Parameters[15].Value = (object) Original_ID;
      if (Original_BELBSKNID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[16].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[17].Value = (object) Original_BELBSKNID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[16].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[17].Value = (object) DBNull.Value;
      }
      if (Original_GENELSKRTRID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[18].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[19].Value = (object) Original_GENELSKRTRID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[18].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[19].Value = (object) DBNull.Value;
      }
      if (Original_GENELSKRTRYRDMCID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[20].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[21].Value = (object) Original_GENELSKRTRYRDMCID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[20].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[21].Value = (object) DBNull.Value;
      }
      if (Original_DAIREBSKNID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[22].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[23].Value = (object) Original_DAIREBSKNID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[22].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[23].Value = (object) DBNull.Value;
      }
      if (Original_SUBEMDRID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[24].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[25].Value = (object) Original_SUBEMDRID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[24].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[25].Value = (object) DBNull.Value;
      }
      if (Original_ATOLYESEFID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[26].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[27].Value = (object) Original_ATOLYESEFID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[26].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[27].Value = (object) DBNull.Value;
      }
      if (Original_DEPOYETKILID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[28].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[29].Value = (object) Original_DEPOYETKILID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[28].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[29].Value = (object) DBNull.Value;
      }
      if (Original_TKLFSORUMLUID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[30].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[31].Value = (object) Original_TKLFSORUMLUID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[30].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[31].Value = (object) DBNull.Value;
      }
      if (Original_PYSARSTRMAUYE1ID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[32].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[33].Value = (object) Original_PYSARSTRMAUYE1ID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[32].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[33].Value = (object) DBNull.Value;
      }
      if (Original_PYSARSTRMAUYE2ID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[34].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[35].Value = (object) Original_PYSARSTRMAUYE2ID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[34].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[35].Value = (object) DBNull.Value;
      }
      if (Original_PYSARSTRMABSKNID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[36].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[37].Value = (object) Original_PYSARSTRMABSKNID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[36].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[37].Value = (object) DBNull.Value;
      }
      if (Original_KABULKOMUYE1ID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[38].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[39].Value = (object) Original_KABULKOMUYE1ID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[38].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[39].Value = (object) DBNull.Value;
      }
      if (Original_KABULKOMUYE2ID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[40].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[41].Value = (object) Original_KABULKOMUYE2ID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[40].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[41].Value = (object) DBNull.Value;
      }
      if (Original_KABULKOMBASKANID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[42].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[43].Value = (object) Original_KABULKOMBASKANID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[42].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[43].Value = (object) DBNull.Value;
      }
      if (Original_YAGSORUMLUSU.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[44].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[45].Value = (object) Original_YAGSORUMLUSU.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[44].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[45].Value = (object) DBNull.Value;
      }
      this.Adapter.UpdateCommand.Parameters[46].Value = (object) ID;
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
      int? BELBSKNID,
      int? GENELSKRTRID,
      int? GENELSKRTRYRDMCID,
      int? DAIREBSKNID,
      int? SUBEMDRID,
      int? ATOLYESEFID,
      int? DEPOYETKILID,
      int? TKLFSORUMLUID,
      int? PYSARSTRMAUYE1ID,
      int? PYSARSTRMAUYE2ID,
      int? PYSARSTRMABSKNID,
      int? KABULKOMUYE1ID,
      int? KABULKOMUYE2ID,
      int? KABULKOMBASKANID,
      int? YAGSORUMLUSU,
      int Original_ID,
      int? Original_BELBSKNID,
      int? Original_GENELSKRTRID,
      int? Original_GENELSKRTRYRDMCID,
      int? Original_DAIREBSKNID,
      int? Original_SUBEMDRID,
      int? Original_ATOLYESEFID,
      int? Original_DEPOYETKILID,
      int? Original_TKLFSORUMLUID,
      int? Original_PYSARSTRMAUYE1ID,
      int? Original_PYSARSTRMAUYE2ID,
      int? Original_PYSARSTRMABSKNID,
      int? Original_KABULKOMUYE1ID,
      int? Original_KABULKOMUYE2ID,
      int? Original_KABULKOMBASKANID,
      int? Original_YAGSORUMLUSU)
    {
      return this.Update(BELBSKNID, GENELSKRTRID, GENELSKRTRYRDMCID, DAIREBSKNID, SUBEMDRID, ATOLYESEFID, DEPOYETKILID, TKLFSORUMLUID, PYSARSTRMAUYE1ID, PYSARSTRMAUYE2ID, PYSARSTRMABSKNID, KABULKOMUYE1ID, KABULKOMUYE2ID, KABULKOMBASKANID, YAGSORUMLUSU, Original_ID, Original_BELBSKNID, Original_GENELSKRTRID, Original_GENELSKRTRYRDMCID, Original_DAIREBSKNID, Original_SUBEMDRID, Original_ATOLYESEFID, Original_DEPOYETKILID, Original_TKLFSORUMLUID, Original_PYSARSTRMAUYE1ID, Original_PYSARSTRMAUYE2ID, Original_PYSARSTRMABSKNID, Original_KABULKOMUYE1ID, Original_KABULKOMUYE2ID, Original_KABULKOMBASKANID, Original_YAGSORUMLUSU, Original_ID);
    }
  }
}
