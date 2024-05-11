// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.bellDataSet1TableAdapters.TBLISEMRITableAdapter
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
  public class TBLISEMRITableAdapter : Component
  {
    private SqlDataAdapter _adapter;
    private SqlConnection _connection;
    private SqlTransaction _transaction;
    private SqlCommand[] _commandCollection;
    private bool _clearBeforeFill;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public TBLISEMRITableAdapter() => this.ClearBeforeFill = true;

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
        DataSetTable = "TBLISEMRI",
        ColumnMappings = {
          {
            "ID",
            "ID"
          },
          {
            "KOD",
            "KOD"
          },
          {
            "ATOLYEID",
            "ATOLYEID"
          },
          {
            "ARACID",
            "ARACID"
          },
          {
            "GIRISTARIH",
            "GIRISTARIH"
          },
          {
            "GIRISSAAT",
            "GIRISSAAT"
          },
          {
            "CIKISTARIH",
            "CIKISTARIH"
          },
          {
            "CIKISSAAT",
            "CIKISSAAT"
          },
          {
            "ARIZANEDENIID",
            "ARIZANEDENIID"
          },
          {
            "BILDIRILENARIZA",
            "BILDIRILENARIZA"
          },
          {
            "ISEMRIDURUMID",
            "ISEMRIDURUMID"
          },
          {
            "BAKIMYERIID",
            "BAKIMYERIID"
          },
          {
            "BAKIMYERACKLM",
            "BAKIMYERACKLM"
          },
          {
            "ARACIGETIREN",
            "ARACIGETIREN"
          },
          {
            "BAKIMKMSI",
            "BAKIMKMSI"
          },
          {
            "SONRAKIBKMKM",
            "SONRAKIBKMKM"
          },
          {
            "SONRAKIBKMTRH",
            "SONRAKIBKMTRH"
          },
          {
            "BAKIMSAATI",
            "BAKIMSAATI"
          },
          {
            "SONRAKIBKMSAAT",
            "SONRAKIBKMSAAT"
          },
          {
            "ISEMRISIRANO",
            "ISEMRISIRANO"
          },
          {
            "YAPILANBAKIMOZETI",
            "YAPILANBAKIMOZETI"
          },
          {
            "IMZAATOLYESEFID",
            "IMZAATOLYESEFID"
          },
          {
            "ISBITIMORANI",
            "ISBITIMORANI"
          },
          {
            "SAVEUSER",
            "SAVEUSER"
          },
          {
            "SAVEDATE",
            "SAVEDATE"
          },
          {
            "EDITUSER",
            "EDITUSER"
          },
          {
            "EDITDATE",
            "EDITDATE"
          },
          {
            "SAVEMAC",
            "SAVEMAC"
          },
          {
            "EDITMAC",
            "EDITMAC"
          },
          {
            "SAVEIP",
            "SAVEIP"
          },
          {
            "EDITIP",
            "EDITIP"
          },
          {
            "BAKIMTURUID",
            "BAKIMTURUID"
          },
          {
            "BAKIMDERECESIID",
            "BAKIMDERECESIID"
          }
        }
      });
      this._adapter.DeleteCommand = new SqlCommand();
      this._adapter.DeleteCommand.Connection = this.Connection;
      this._adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[TBLISEMRI] WHERE (([ID] = @Original_ID) AND ((@IsNull_KOD = 1 AND [KOD] IS NULL) OR ([KOD] = @Original_KOD)) AND ((@IsNull_ATOLYEID = 1 AND [ATOLYEID] IS NULL) OR ([ATOLYEID] = @Original_ATOLYEID)) AND ((@IsNull_ARACID = 1 AND [ARACID] IS NULL) OR ([ARACID] = @Original_ARACID)) AND ((@IsNull_GIRISTARIH = 1 AND [GIRISTARIH] IS NULL) OR ([GIRISTARIH] = @Original_GIRISTARIH)) AND ((@IsNull_GIRISSAAT = 1 AND [GIRISSAAT] IS NULL) OR ([GIRISSAAT] = @Original_GIRISSAAT)) AND ((@IsNull_CIKISTARIH = 1 AND [CIKISTARIH] IS NULL) OR ([CIKISTARIH] = @Original_CIKISTARIH)) AND ((@IsNull_CIKISSAAT = 1 AND [CIKISSAAT] IS NULL) OR ([CIKISSAAT] = @Original_CIKISSAAT)) AND ((@IsNull_ARIZANEDENIID = 1 AND [ARIZANEDENIID] IS NULL) OR ([ARIZANEDENIID] = @Original_ARIZANEDENIID)) AND ((@IsNull_ISEMRIDURUMID = 1 AND [ISEMRIDURUMID] IS NULL) OR ([ISEMRIDURUMID] = @Original_ISEMRIDURUMID)) AND ((@IsNull_BAKIMYERIID = 1 AND [BAKIMYERIID] IS NULL) OR ([BAKIMYERIID] = @Original_BAKIMYERIID)) AND ((@IsNull_BAKIMYERACKLM = 1 AND [BAKIMYERACKLM] IS NULL) OR ([BAKIMYERACKLM] = @Original_BAKIMYERACKLM)) AND ((@IsNull_ARACIGETIREN = 1 AND [ARACIGETIREN] IS NULL) OR ([ARACIGETIREN] = @Original_ARACIGETIREN)) AND ((@IsNull_BAKIMKMSI = 1 AND [BAKIMKMSI] IS NULL) OR ([BAKIMKMSI] = @Original_BAKIMKMSI)) AND ((@IsNull_SONRAKIBKMKM = 1 AND [SONRAKIBKMKM] IS NULL) OR ([SONRAKIBKMKM] = @Original_SONRAKIBKMKM)) AND ((@IsNull_SONRAKIBKMTRH = 1 AND [SONRAKIBKMTRH] IS NULL) OR ([SONRAKIBKMTRH] = @Original_SONRAKIBKMTRH)) AND ((@IsNull_BAKIMSAATI = 1 AND [BAKIMSAATI] IS NULL) OR ([BAKIMSAATI] = @Original_BAKIMSAATI)) AND ((@IsNull_SONRAKIBKMSAAT = 1 AND [SONRAKIBKMSAAT] IS NULL) OR ([SONRAKIBKMSAAT] = @Original_SONRAKIBKMSAAT)) AND ((@IsNull_ISEMRISIRANO = 1 AND [ISEMRISIRANO] IS NULL) OR ([ISEMRISIRANO] = @Original_ISEMRISIRANO)) AND ((@IsNull_IMZAATOLYESEFID = 1 AND [IMZAATOLYESEFID] IS NULL) OR ([IMZAATOLYESEFID] = @Original_IMZAATOLYESEFID)) AND ((@IsNull_ISBITIMORANI = 1 AND [ISBITIMORANI] IS NULL) OR ([ISBITIMORANI] = @Original_ISBITIMORANI)) AND ((@IsNull_SAVEUSER = 1 AND [SAVEUSER] IS NULL) OR ([SAVEUSER] = @Original_SAVEUSER)) AND ((@IsNull_SAVEDATE = 1 AND [SAVEDATE] IS NULL) OR ([SAVEDATE] = @Original_SAVEDATE)) AND ((@IsNull_EDITUSER = 1 AND [EDITUSER] IS NULL) OR ([EDITUSER] = @Original_EDITUSER)) AND ((@IsNull_EDITDATE = 1 AND [EDITDATE] IS NULL) OR ([EDITDATE] = @Original_EDITDATE)) AND ((@IsNull_SAVEMAC = 1 AND [SAVEMAC] IS NULL) OR ([SAVEMAC] = @Original_SAVEMAC)) AND ((@IsNull_EDITMAC = 1 AND [EDITMAC] IS NULL) OR ([EDITMAC] = @Original_EDITMAC)) AND ((@IsNull_SAVEIP = 1 AND [SAVEIP] IS NULL) OR ([SAVEIP] = @Original_SAVEIP)) AND ((@IsNull_EDITIP = 1 AND [EDITIP] IS NULL) OR ([EDITIP] = @Original_EDITIP)) AND ((@IsNull_BAKIMTURUID = 1 AND [BAKIMTURUID] IS NULL) OR ([BAKIMTURUID] = @Original_BAKIMTURUID)) AND ((@IsNull_BAKIMDERECESIID = 1 AND [BAKIMDERECESIID] IS NULL) OR ([BAKIMDERECESIID] = @Original_BAKIMDERECESIID)))";
      this._adapter.DeleteCommand.CommandType = CommandType.Text;
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_KOD", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_KOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ATOLYEID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ATOLYEID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ATOLYEID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ATOLYEID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ARACID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ARACID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_GIRISTARIH", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GIRISTARIH", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_GIRISTARIH", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GIRISTARIH", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_GIRISSAAT", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GIRISSAAT", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_GIRISSAAT", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GIRISSAAT", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_CIKISTARIH", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISTARIH", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_CIKISTARIH", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISTARIH", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_CIKISSAAT", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISSAAT", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_CIKISSAAT", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISSAAT", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ARIZANEDENIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARIZANEDENIID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ARIZANEDENIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARIZANEDENIID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ISEMRIDURUMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISEMRIDURUMID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ISEMRIDURUMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISEMRIDURUMID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_BAKIMYERIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAKIMYERIID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_BAKIMYERIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAKIMYERIID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_BAKIMYERACKLM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAKIMYERACKLM", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_BAKIMYERACKLM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAKIMYERACKLM", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ARACIGETIREN", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACIGETIREN", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ARACIGETIREN", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACIGETIREN", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_BAKIMKMSI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAKIMKMSI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_BAKIMKMSI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAKIMKMSI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SONRAKIBKMKM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SONRAKIBKMKM", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SONRAKIBKMKM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SONRAKIBKMKM", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SONRAKIBKMTRH", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SONRAKIBKMTRH", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SONRAKIBKMTRH", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SONRAKIBKMTRH", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_BAKIMSAATI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAKIMSAATI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_BAKIMSAATI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAKIMSAATI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SONRAKIBKMSAAT", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SONRAKIBKMSAAT", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SONRAKIBKMSAAT", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SONRAKIBKMSAAT", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ISEMRISIRANO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISEMRISIRANO", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ISEMRISIRANO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISEMRISIRANO", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_IMZAATOLYESEFID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IMZAATOLYESEFID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_IMZAATOLYESEFID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IMZAATOLYESEFID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ISBITIMORANI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISBITIMORANI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ISBITIMORANI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISBITIMORANI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SAVEUSER", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEUSER", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SAVEUSER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEUSER", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SAVEDATE", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEDATE", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SAVEDATE", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEDATE", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_EDITUSER", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITUSER", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_EDITUSER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITUSER", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_EDITDATE", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITDATE", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_EDITDATE", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITDATE", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SAVEMAC", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEMAC", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SAVEMAC", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEMAC", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_EDITMAC", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITMAC", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_EDITMAC", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITMAC", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SAVEIP", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEIP", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SAVEIP", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEIP", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_EDITIP", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITIP", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_EDITIP", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITIP", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_BAKIMTURUID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAKIMTURUID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_BAKIMTURUID", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAKIMTURUID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_BAKIMDERECESIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAKIMDERECESIID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_BAKIMDERECESIID", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAKIMDERECESIID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.InsertCommand = new SqlCommand();
      this._adapter.InsertCommand.Connection = this.Connection;
      this._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[TBLISEMRI] ([KOD], [ATOLYEID], [ARACID], [GIRISTARIH], [GIRISSAAT], [CIKISTARIH], [CIKISSAAT], [ARIZANEDENIID], [BILDIRILENARIZA], [ISEMRIDURUMID], [BAKIMYERIID], [BAKIMYERACKLM], [ARACIGETIREN], [BAKIMKMSI], [SONRAKIBKMKM], [SONRAKIBKMTRH], [BAKIMSAATI], [SONRAKIBKMSAAT], [ISEMRISIRANO], [YAPILANBAKIMOZETI], [IMZAATOLYESEFID], [ISBITIMORANI], [SAVEUSER], [SAVEDATE], [EDITUSER], [EDITDATE], [SAVEMAC], [EDITMAC], [SAVEIP], [EDITIP], [BAKIMTURUID], [BAKIMDERECESIID]) VALUES (@KOD, @ATOLYEID, @ARACID, @GIRISTARIH, @GIRISSAAT, @CIKISTARIH, @CIKISSAAT, @ARIZANEDENIID, @BILDIRILENARIZA, @ISEMRIDURUMID, @BAKIMYERIID, @BAKIMYERACKLM, @ARACIGETIREN, @BAKIMKMSI, @SONRAKIBKMKM, @SONRAKIBKMTRH, @BAKIMSAATI, @SONRAKIBKMSAAT, @ISEMRISIRANO, @YAPILANBAKIMOZETI, @IMZAATOLYESEFID, @ISBITIMORANI, @SAVEUSER, @SAVEDATE, @EDITUSER, @EDITDATE, @SAVEMAC, @EDITMAC, @SAVEIP, @EDITIP, @BAKIMTURUID, @BAKIMDERECESIID);\r\nSELECT ID, KOD, ATOLYEID, ARACID, GIRISTARIH, GIRISSAAT, CIKISTARIH, CIKISSAAT, ARIZANEDENIID, BILDIRILENARIZA, ISEMRIDURUMID, BAKIMYERIID, BAKIMYERACKLM, ARACIGETIREN, BAKIMKMSI, SONRAKIBKMKM, SONRAKIBKMTRH, BAKIMSAATI, SONRAKIBKMSAAT, ISEMRISIRANO, YAPILANBAKIMOZETI, IMZAATOLYESEFID, ISBITIMORANI, SAVEUSER, SAVEDATE, EDITUSER, EDITDATE, SAVEMAC, EDITMAC, SAVEIP, EDITIP, BAKIMTURUID, BAKIMDERECESIID FROM TBLISEMRI WHERE (ID = SCOPE_IDENTITY())";
      this._adapter.InsertCommand.CommandType = CommandType.Text;
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@KOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ATOLYEID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ATOLYEID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ARACID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@GIRISTARIH", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GIRISTARIH", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@GIRISSAAT", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GIRISSAAT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@CIKISTARIH", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISTARIH", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@CIKISSAAT", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISSAAT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ARIZANEDENIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARIZANEDENIID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@BILDIRILENARIZA", SqlDbType.Text, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BILDIRILENARIZA", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ISEMRIDURUMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISEMRIDURUMID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@BAKIMYERIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAKIMYERIID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@BAKIMYERACKLM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAKIMYERACKLM", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ARACIGETIREN", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACIGETIREN", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@BAKIMKMSI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAKIMKMSI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SONRAKIBKMKM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SONRAKIBKMKM", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SONRAKIBKMTRH", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SONRAKIBKMTRH", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@BAKIMSAATI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAKIMSAATI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SONRAKIBKMSAAT", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SONRAKIBKMSAAT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ISEMRISIRANO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISEMRISIRANO", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@YAPILANBAKIMOZETI", SqlDbType.Text, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YAPILANBAKIMOZETI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@IMZAATOLYESEFID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IMZAATOLYESEFID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ISBITIMORANI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISBITIMORANI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SAVEUSER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEUSER", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SAVEDATE", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEDATE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@EDITUSER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITUSER", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@EDITDATE", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITDATE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SAVEMAC", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEMAC", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@EDITMAC", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITMAC", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SAVEIP", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEIP", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@EDITIP", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITIP", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@BAKIMTURUID", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAKIMTURUID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@BAKIMDERECESIID", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAKIMDERECESIID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand = new SqlCommand();
      this._adapter.UpdateCommand.Connection = this.Connection;
      this._adapter.UpdateCommand.CommandText = "UPDATE [dbo].[TBLISEMRI] SET [KOD] = @KOD, [ATOLYEID] = @ATOLYEID, [ARACID] = @ARACID, [GIRISTARIH] = @GIRISTARIH, [GIRISSAAT] = @GIRISSAAT, [CIKISTARIH] = @CIKISTARIH, [CIKISSAAT] = @CIKISSAAT, [ARIZANEDENIID] = @ARIZANEDENIID, [BILDIRILENARIZA] = @BILDIRILENARIZA, [ISEMRIDURUMID] = @ISEMRIDURUMID, [BAKIMYERIID] = @BAKIMYERIID, [BAKIMYERACKLM] = @BAKIMYERACKLM, [ARACIGETIREN] = @ARACIGETIREN, [BAKIMKMSI] = @BAKIMKMSI, [SONRAKIBKMKM] = @SONRAKIBKMKM, [SONRAKIBKMTRH] = @SONRAKIBKMTRH, [BAKIMSAATI] = @BAKIMSAATI, [SONRAKIBKMSAAT] = @SONRAKIBKMSAAT, [ISEMRISIRANO] = @ISEMRISIRANO, [YAPILANBAKIMOZETI] = @YAPILANBAKIMOZETI, [IMZAATOLYESEFID] = @IMZAATOLYESEFID, [ISBITIMORANI] = @ISBITIMORANI, [SAVEUSER] = @SAVEUSER, [SAVEDATE] = @SAVEDATE, [EDITUSER] = @EDITUSER, [EDITDATE] = @EDITDATE, [SAVEMAC] = @SAVEMAC, [EDITMAC] = @EDITMAC, [SAVEIP] = @SAVEIP, [EDITIP] = @EDITIP, [BAKIMTURUID] = @BAKIMTURUID, [BAKIMDERECESIID] = @BAKIMDERECESIID WHERE (([ID] = @Original_ID) AND ((@IsNull_KOD = 1 AND [KOD] IS NULL) OR ([KOD] = @Original_KOD)) AND ((@IsNull_ATOLYEID = 1 AND [ATOLYEID] IS NULL) OR ([ATOLYEID] = @Original_ATOLYEID)) AND ((@IsNull_ARACID = 1 AND [ARACID] IS NULL) OR ([ARACID] = @Original_ARACID)) AND ((@IsNull_GIRISTARIH = 1 AND [GIRISTARIH] IS NULL) OR ([GIRISTARIH] = @Original_GIRISTARIH)) AND ((@IsNull_GIRISSAAT = 1 AND [GIRISSAAT] IS NULL) OR ([GIRISSAAT] = @Original_GIRISSAAT)) AND ((@IsNull_CIKISTARIH = 1 AND [CIKISTARIH] IS NULL) OR ([CIKISTARIH] = @Original_CIKISTARIH)) AND ((@IsNull_CIKISSAAT = 1 AND [CIKISSAAT] IS NULL) OR ([CIKISSAAT] = @Original_CIKISSAAT)) AND ((@IsNull_ARIZANEDENIID = 1 AND [ARIZANEDENIID] IS NULL) OR ([ARIZANEDENIID] = @Original_ARIZANEDENIID)) AND ((@IsNull_ISEMRIDURUMID = 1 AND [ISEMRIDURUMID] IS NULL) OR ([ISEMRIDURUMID] = @Original_ISEMRIDURUMID)) AND ((@IsNull_BAKIMYERIID = 1 AND [BAKIMYERIID] IS NULL) OR ([BAKIMYERIID] = @Original_BAKIMYERIID)) AND ((@IsNull_BAKIMYERACKLM = 1 AND [BAKIMYERACKLM] IS NULL) OR ([BAKIMYERACKLM] = @Original_BAKIMYERACKLM)) AND ((@IsNull_ARACIGETIREN = 1 AND [ARACIGETIREN] IS NULL) OR ([ARACIGETIREN] = @Original_ARACIGETIREN)) AND ((@IsNull_BAKIMKMSI = 1 AND [BAKIMKMSI] IS NULL) OR ([BAKIMKMSI] = @Original_BAKIMKMSI)) AND ((@IsNull_SONRAKIBKMKM = 1 AND [SONRAKIBKMKM] IS NULL) OR ([SONRAKIBKMKM] = @Original_SONRAKIBKMKM)) AND ((@IsNull_SONRAKIBKMTRH = 1 AND [SONRAKIBKMTRH] IS NULL) OR ([SONRAKIBKMTRH] = @Original_SONRAKIBKMTRH)) AND ((@IsNull_BAKIMSAATI = 1 AND [BAKIMSAATI] IS NULL) OR ([BAKIMSAATI] = @Original_BAKIMSAATI)) AND ((@IsNull_SONRAKIBKMSAAT = 1 AND [SONRAKIBKMSAAT] IS NULL) OR ([SONRAKIBKMSAAT] = @Original_SONRAKIBKMSAAT)) AND ((@IsNull_ISEMRISIRANO = 1 AND [ISEMRISIRANO] IS NULL) OR ([ISEMRISIRANO] = @Original_ISEMRISIRANO)) AND ((@IsNull_IMZAATOLYESEFID = 1 AND [IMZAATOLYESEFID] IS NULL) OR ([IMZAATOLYESEFID] = @Original_IMZAATOLYESEFID)) AND ((@IsNull_ISBITIMORANI = 1 AND [ISBITIMORANI] IS NULL) OR ([ISBITIMORANI] = @Original_ISBITIMORANI)) AND ((@IsNull_SAVEUSER = 1 AND [SAVEUSER] IS NULL) OR ([SAVEUSER] = @Original_SAVEUSER)) AND ((@IsNull_SAVEDATE = 1 AND [SAVEDATE] IS NULL) OR ([SAVEDATE] = @Original_SAVEDATE)) AND ((@IsNull_EDITUSER = 1 AND [EDITUSER] IS NULL) OR ([EDITUSER] = @Original_EDITUSER)) AND ((@IsNull_EDITDATE = 1 AND [EDITDATE] IS NULL) OR ([EDITDATE] = @Original_EDITDATE)) AND ((@IsNull_SAVEMAC = 1 AND [SAVEMAC] IS NULL) OR ([SAVEMAC] = @Original_SAVEMAC)) AND ((@IsNull_EDITMAC = 1 AND [EDITMAC] IS NULL) OR ([EDITMAC] = @Original_EDITMAC)) AND ((@IsNull_SAVEIP = 1 AND [SAVEIP] IS NULL) OR ([SAVEIP] = @Original_SAVEIP)) AND ((@IsNull_EDITIP = 1 AND [EDITIP] IS NULL) OR ([EDITIP] = @Original_EDITIP)) AND ((@IsNull_BAKIMTURUID = 1 AND [BAKIMTURUID] IS NULL) OR ([BAKIMTURUID] = @Original_BAKIMTURUID)) AND ((@IsNull_BAKIMDERECESIID = 1 AND [BAKIMDERECESIID] IS NULL) OR ([BAKIMDERECESIID] = @Original_BAKIMDERECESIID)));\r\nSELECT ID, KOD, ATOLYEID, ARACID, GIRISTARIH, GIRISSAAT, CIKISTARIH, CIKISSAAT, ARIZANEDENIID, BILDIRILENARIZA, ISEMRIDURUMID, BAKIMYERIID, BAKIMYERACKLM, ARACIGETIREN, BAKIMKMSI, SONRAKIBKMKM, SONRAKIBKMTRH, BAKIMSAATI, SONRAKIBKMSAAT, ISEMRISIRANO, YAPILANBAKIMOZETI, IMZAATOLYESEFID, ISBITIMORANI, SAVEUSER, SAVEDATE, EDITUSER, EDITDATE, SAVEMAC, EDITMAC, SAVEIP, EDITIP, BAKIMTURUID, BAKIMDERECESIID FROM TBLISEMRI WHERE (ID = @ID)";
      this._adapter.UpdateCommand.CommandType = CommandType.Text;
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@KOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ATOLYEID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ATOLYEID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ARACID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@GIRISTARIH", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GIRISTARIH", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@GIRISSAAT", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GIRISSAAT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@CIKISTARIH", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISTARIH", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@CIKISSAAT", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISSAAT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ARIZANEDENIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARIZANEDENIID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@BILDIRILENARIZA", SqlDbType.Text, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BILDIRILENARIZA", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ISEMRIDURUMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISEMRIDURUMID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@BAKIMYERIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAKIMYERIID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@BAKIMYERACKLM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAKIMYERACKLM", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ARACIGETIREN", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACIGETIREN", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@BAKIMKMSI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAKIMKMSI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SONRAKIBKMKM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SONRAKIBKMKM", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SONRAKIBKMTRH", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SONRAKIBKMTRH", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@BAKIMSAATI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAKIMSAATI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SONRAKIBKMSAAT", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SONRAKIBKMSAAT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ISEMRISIRANO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISEMRISIRANO", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@YAPILANBAKIMOZETI", SqlDbType.Text, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YAPILANBAKIMOZETI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IMZAATOLYESEFID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IMZAATOLYESEFID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ISBITIMORANI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISBITIMORANI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SAVEUSER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEUSER", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SAVEDATE", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEDATE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EDITUSER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITUSER", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EDITDATE", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITDATE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SAVEMAC", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEMAC", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EDITMAC", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITMAC", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SAVEIP", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEIP", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EDITIP", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITIP", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@BAKIMTURUID", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAKIMTURUID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@BAKIMDERECESIID", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAKIMDERECESIID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_KOD", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_KOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ATOLYEID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ATOLYEID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ATOLYEID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ATOLYEID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ARACID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ARACID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_GIRISTARIH", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GIRISTARIH", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_GIRISTARIH", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GIRISTARIH", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_GIRISSAAT", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GIRISSAAT", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_GIRISSAAT", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GIRISSAAT", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_CIKISTARIH", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISTARIH", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_CIKISTARIH", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISTARIH", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_CIKISSAAT", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISSAAT", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_CIKISSAAT", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISSAAT", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ARIZANEDENIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARIZANEDENIID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ARIZANEDENIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARIZANEDENIID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ISEMRIDURUMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISEMRIDURUMID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ISEMRIDURUMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISEMRIDURUMID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_BAKIMYERIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAKIMYERIID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_BAKIMYERIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAKIMYERIID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_BAKIMYERACKLM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAKIMYERACKLM", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_BAKIMYERACKLM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAKIMYERACKLM", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ARACIGETIREN", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACIGETIREN", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ARACIGETIREN", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACIGETIREN", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_BAKIMKMSI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAKIMKMSI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_BAKIMKMSI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAKIMKMSI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SONRAKIBKMKM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SONRAKIBKMKM", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SONRAKIBKMKM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SONRAKIBKMKM", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SONRAKIBKMTRH", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SONRAKIBKMTRH", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SONRAKIBKMTRH", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SONRAKIBKMTRH", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_BAKIMSAATI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAKIMSAATI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_BAKIMSAATI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAKIMSAATI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SONRAKIBKMSAAT", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SONRAKIBKMSAAT", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SONRAKIBKMSAAT", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SONRAKIBKMSAAT", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ISEMRISIRANO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISEMRISIRANO", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ISEMRISIRANO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISEMRISIRANO", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_IMZAATOLYESEFID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IMZAATOLYESEFID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_IMZAATOLYESEFID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IMZAATOLYESEFID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ISBITIMORANI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISBITIMORANI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ISBITIMORANI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISBITIMORANI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SAVEUSER", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEUSER", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SAVEUSER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEUSER", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SAVEDATE", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEDATE", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SAVEDATE", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEDATE", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_EDITUSER", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITUSER", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_EDITUSER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITUSER", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_EDITDATE", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITDATE", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_EDITDATE", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITDATE", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SAVEMAC", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEMAC", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SAVEMAC", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEMAC", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_EDITMAC", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITMAC", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_EDITMAC", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITMAC", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SAVEIP", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEIP", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SAVEIP", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEIP", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_EDITIP", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITIP", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_EDITIP", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITIP", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_BAKIMTURUID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAKIMTURUID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_BAKIMTURUID", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAKIMTURUID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_BAKIMDERECESIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAKIMDERECESIID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_BAKIMDERECESIID", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAKIMDERECESIID", DataRowVersion.Original, false, (object) null, "", "", ""));
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
      this._commandCollection[0].CommandText = "SELECT ID, KOD, ATOLYEID, ARACID, GIRISTARIH, GIRISSAAT, CIKISTARIH, CIKISSAAT, ARIZANEDENIID, BILDIRILENARIZA, ISEMRIDURUMID, BAKIMYERIID, BAKIMYERACKLM, ARACIGETIREN, BAKIMKMSI, SONRAKIBKMKM, SONRAKIBKMTRH, BAKIMSAATI, SONRAKIBKMSAAT, ISEMRISIRANO, YAPILANBAKIMOZETI, IMZAATOLYESEFID, ISBITIMORANI, SAVEUSER, SAVEDATE, EDITUSER, EDITDATE, SAVEMAC, EDITMAC, SAVEIP, EDITIP, BAKIMTURUID, BAKIMDERECESIID FROM dbo.TBLISEMRI";
      this._commandCollection[0].CommandType = CommandType.Text;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    public virtual int Fill(bellDataSet1.TBLISEMRIDataTable dataTable)
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
    public virtual bellDataSet1.TBLISEMRIDataTable GetData()
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      bellDataSet1.TBLISEMRIDataTable data = new bellDataSet1.TBLISEMRIDataTable();
      this.Adapter.Fill((DataTable) data);
      return data;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(bellDataSet1.TBLISEMRIDataTable dataTable) => this.Adapter.Update((DataTable) dataTable);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(bellDataSet1 dataSet) => this.Adapter.Update((DataSet) dataSet, "TBLISEMRI");

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
      string Original_KOD,
      int? Original_ATOLYEID,
      int? Original_ARACID,
      DateTime? Original_GIRISTARIH,
      DateTime? Original_GIRISSAAT,
      DateTime? Original_CIKISTARIH,
      DateTime? Original_CIKISSAAT,
      int? Original_ARIZANEDENIID,
      int? Original_ISEMRIDURUMID,
      int? Original_BAKIMYERIID,
      string Original_BAKIMYERACKLM,
      string Original_ARACIGETIREN,
      string Original_BAKIMKMSI,
      string Original_SONRAKIBKMKM,
      string Original_SONRAKIBKMTRH,
      string Original_BAKIMSAATI,
      string Original_SONRAKIBKMSAAT,
      int? Original_ISEMRISIRANO,
      int? Original_IMZAATOLYESEFID,
      string Original_ISBITIMORANI,
      string Original_SAVEUSER,
      DateTime? Original_SAVEDATE,
      string Original_EDITUSER,
      DateTime? Original_EDITDATE,
      string Original_SAVEMAC,
      string Original_EDITMAC,
      string Original_SAVEIP,
      string Original_EDITIP,
      string Original_BAKIMTURUID,
      string Original_BAKIMDERECESIID)
    {
      this.Adapter.DeleteCommand.Parameters[0].Value = (object) Original_ID;
      if (Original_KOD == null)
      {
        this.Adapter.DeleteCommand.Parameters[1].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[2].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[1].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[2].Value = (object) Original_KOD;
      }
      if (Original_ATOLYEID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[3].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[4].Value = (object) Original_ATOLYEID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[3].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[4].Value = (object) DBNull.Value;
      }
      if (Original_ARACID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[6].Value = (object) Original_ARACID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[6].Value = (object) DBNull.Value;
      }
      if (Original_GIRISTARIH.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[7].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[8].Value = (object) Original_GIRISTARIH.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[7].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[8].Value = (object) DBNull.Value;
      }
      if (Original_GIRISSAAT.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) Original_GIRISSAAT.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) DBNull.Value;
      }
      if (Original_CIKISTARIH.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[11].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[12].Value = (object) Original_CIKISTARIH.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[11].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[12].Value = (object) DBNull.Value;
      }
      if (Original_CIKISSAAT.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[13].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[14].Value = (object) Original_CIKISSAAT.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[13].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[14].Value = (object) DBNull.Value;
      }
      if (Original_ARIZANEDENIID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[15].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[16].Value = (object) Original_ARIZANEDENIID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[15].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[16].Value = (object) DBNull.Value;
      }
      if (Original_ISEMRIDURUMID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[17].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[18].Value = (object) Original_ISEMRIDURUMID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[17].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[18].Value = (object) DBNull.Value;
      }
      if (Original_BAKIMYERIID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[19].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[20].Value = (object) Original_BAKIMYERIID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[19].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[20].Value = (object) DBNull.Value;
      }
      if (Original_BAKIMYERACKLM == null)
      {
        this.Adapter.DeleteCommand.Parameters[21].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[22].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[21].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[22].Value = (object) Original_BAKIMYERACKLM;
      }
      if (Original_ARACIGETIREN == null)
      {
        this.Adapter.DeleteCommand.Parameters[23].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[24].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[23].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[24].Value = (object) Original_ARACIGETIREN;
      }
      if (Original_BAKIMKMSI == null)
      {
        this.Adapter.DeleteCommand.Parameters[25].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[26].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[25].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[26].Value = (object) Original_BAKIMKMSI;
      }
      if (Original_SONRAKIBKMKM == null)
      {
        this.Adapter.DeleteCommand.Parameters[27].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[28].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[27].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[28].Value = (object) Original_SONRAKIBKMKM;
      }
      if (Original_SONRAKIBKMTRH == null)
      {
        this.Adapter.DeleteCommand.Parameters[29].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[30].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[29].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[30].Value = (object) Original_SONRAKIBKMTRH;
      }
      if (Original_BAKIMSAATI == null)
      {
        this.Adapter.DeleteCommand.Parameters[31].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[32].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[31].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[32].Value = (object) Original_BAKIMSAATI;
      }
      if (Original_SONRAKIBKMSAAT == null)
      {
        this.Adapter.DeleteCommand.Parameters[33].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[34].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[33].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[34].Value = (object) Original_SONRAKIBKMSAAT;
      }
      if (Original_ISEMRISIRANO.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[35].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[36].Value = (object) Original_ISEMRISIRANO.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[35].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[36].Value = (object) DBNull.Value;
      }
      if (Original_IMZAATOLYESEFID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[37].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[38].Value = (object) Original_IMZAATOLYESEFID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[37].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[38].Value = (object) DBNull.Value;
      }
      if (Original_ISBITIMORANI == null)
      {
        this.Adapter.DeleteCommand.Parameters[39].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[40].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[39].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[40].Value = (object) Original_ISBITIMORANI;
      }
      if (Original_SAVEUSER == null)
      {
        this.Adapter.DeleteCommand.Parameters[41].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[42].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[41].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[42].Value = (object) Original_SAVEUSER;
      }
      if (Original_SAVEDATE.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[43].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[44].Value = (object) Original_SAVEDATE.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[43].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[44].Value = (object) DBNull.Value;
      }
      if (Original_EDITUSER == null)
      {
        this.Adapter.DeleteCommand.Parameters[45].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[46].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[45].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[46].Value = (object) Original_EDITUSER;
      }
      if (Original_EDITDATE.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[47].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[48].Value = (object) Original_EDITDATE.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[47].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[48].Value = (object) DBNull.Value;
      }
      if (Original_SAVEMAC == null)
      {
        this.Adapter.DeleteCommand.Parameters[49].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[50].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[49].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[50].Value = (object) Original_SAVEMAC;
      }
      if (Original_EDITMAC == null)
      {
        this.Adapter.DeleteCommand.Parameters[51].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[52].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[51].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[52].Value = (object) Original_EDITMAC;
      }
      if (Original_SAVEIP == null)
      {
        this.Adapter.DeleteCommand.Parameters[53].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[54].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[53].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[54].Value = (object) Original_SAVEIP;
      }
      if (Original_EDITIP == null)
      {
        this.Adapter.DeleteCommand.Parameters[55].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[56].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[55].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[56].Value = (object) Original_EDITIP;
      }
      if (Original_BAKIMTURUID == null)
      {
        this.Adapter.DeleteCommand.Parameters[57].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[58].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[57].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[58].Value = (object) Original_BAKIMTURUID;
      }
      if (Original_BAKIMDERECESIID == null)
      {
        this.Adapter.DeleteCommand.Parameters[59].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[60].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[59].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[60].Value = (object) Original_BAKIMDERECESIID;
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
      string KOD,
      int? ATOLYEID,
      int? ARACID,
      DateTime? GIRISTARIH,
      DateTime? GIRISSAAT,
      DateTime? CIKISTARIH,
      DateTime? CIKISSAAT,
      int? ARIZANEDENIID,
      string BILDIRILENARIZA,
      int? ISEMRIDURUMID,
      int? BAKIMYERIID,
      string BAKIMYERACKLM,
      string ARACIGETIREN,
      string BAKIMKMSI,
      string SONRAKIBKMKM,
      string SONRAKIBKMTRH,
      string BAKIMSAATI,
      string SONRAKIBKMSAAT,
      int? ISEMRISIRANO,
      string YAPILANBAKIMOZETI,
      int? IMZAATOLYESEFID,
      string ISBITIMORANI,
      string SAVEUSER,
      DateTime? SAVEDATE,
      string EDITUSER,
      DateTime? EDITDATE,
      string SAVEMAC,
      string EDITMAC,
      string SAVEIP,
      string EDITIP,
      string BAKIMTURUID,
      string BAKIMDERECESIID)
    {
      if (KOD == null)
        this.Adapter.InsertCommand.Parameters[0].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[0].Value = (object) KOD;
      if (ATOLYEID.HasValue)
        this.Adapter.InsertCommand.Parameters[1].Value = (object) ATOLYEID.Value;
      else
        this.Adapter.InsertCommand.Parameters[1].Value = (object) DBNull.Value;
      if (ARACID.HasValue)
        this.Adapter.InsertCommand.Parameters[2].Value = (object) ARACID.Value;
      else
        this.Adapter.InsertCommand.Parameters[2].Value = (object) DBNull.Value;
      if (GIRISTARIH.HasValue)
        this.Adapter.InsertCommand.Parameters[3].Value = (object) GIRISTARIH.Value;
      else
        this.Adapter.InsertCommand.Parameters[3].Value = (object) DBNull.Value;
      if (GIRISSAAT.HasValue)
        this.Adapter.InsertCommand.Parameters[4].Value = (object) GIRISSAAT.Value;
      else
        this.Adapter.InsertCommand.Parameters[4].Value = (object) DBNull.Value;
      if (CIKISTARIH.HasValue)
        this.Adapter.InsertCommand.Parameters[5].Value = (object) CIKISTARIH.Value;
      else
        this.Adapter.InsertCommand.Parameters[5].Value = (object) DBNull.Value;
      if (CIKISSAAT.HasValue)
        this.Adapter.InsertCommand.Parameters[6].Value = (object) CIKISSAAT.Value;
      else
        this.Adapter.InsertCommand.Parameters[6].Value = (object) DBNull.Value;
      if (ARIZANEDENIID.HasValue)
        this.Adapter.InsertCommand.Parameters[7].Value = (object) ARIZANEDENIID.Value;
      else
        this.Adapter.InsertCommand.Parameters[7].Value = (object) DBNull.Value;
      if (BILDIRILENARIZA == null)
        this.Adapter.InsertCommand.Parameters[8].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[8].Value = (object) BILDIRILENARIZA;
      if (ISEMRIDURUMID.HasValue)
        this.Adapter.InsertCommand.Parameters[9].Value = (object) ISEMRIDURUMID.Value;
      else
        this.Adapter.InsertCommand.Parameters[9].Value = (object) DBNull.Value;
      if (BAKIMYERIID.HasValue)
        this.Adapter.InsertCommand.Parameters[10].Value = (object) BAKIMYERIID.Value;
      else
        this.Adapter.InsertCommand.Parameters[10].Value = (object) DBNull.Value;
      if (BAKIMYERACKLM == null)
        this.Adapter.InsertCommand.Parameters[11].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[11].Value = (object) BAKIMYERACKLM;
      if (ARACIGETIREN == null)
        this.Adapter.InsertCommand.Parameters[12].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[12].Value = (object) ARACIGETIREN;
      if (BAKIMKMSI == null)
        this.Adapter.InsertCommand.Parameters[13].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[13].Value = (object) BAKIMKMSI;
      if (SONRAKIBKMKM == null)
        this.Adapter.InsertCommand.Parameters[14].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[14].Value = (object) SONRAKIBKMKM;
      if (SONRAKIBKMTRH == null)
        this.Adapter.InsertCommand.Parameters[15].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[15].Value = (object) SONRAKIBKMTRH;
      if (BAKIMSAATI == null)
        this.Adapter.InsertCommand.Parameters[16].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[16].Value = (object) BAKIMSAATI;
      if (SONRAKIBKMSAAT == null)
        this.Adapter.InsertCommand.Parameters[17].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[17].Value = (object) SONRAKIBKMSAAT;
      if (ISEMRISIRANO.HasValue)
        this.Adapter.InsertCommand.Parameters[18].Value = (object) ISEMRISIRANO.Value;
      else
        this.Adapter.InsertCommand.Parameters[18].Value = (object) DBNull.Value;
      if (YAPILANBAKIMOZETI == null)
        this.Adapter.InsertCommand.Parameters[19].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[19].Value = (object) YAPILANBAKIMOZETI;
      if (IMZAATOLYESEFID.HasValue)
        this.Adapter.InsertCommand.Parameters[20].Value = (object) IMZAATOLYESEFID.Value;
      else
        this.Adapter.InsertCommand.Parameters[20].Value = (object) DBNull.Value;
      if (ISBITIMORANI == null)
        this.Adapter.InsertCommand.Parameters[21].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[21].Value = (object) ISBITIMORANI;
      if (SAVEUSER == null)
        this.Adapter.InsertCommand.Parameters[22].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[22].Value = (object) SAVEUSER;
      if (SAVEDATE.HasValue)
        this.Adapter.InsertCommand.Parameters[23].Value = (object) SAVEDATE.Value;
      else
        this.Adapter.InsertCommand.Parameters[23].Value = (object) DBNull.Value;
      if (EDITUSER == null)
        this.Adapter.InsertCommand.Parameters[24].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[24].Value = (object) EDITUSER;
      if (EDITDATE.HasValue)
        this.Adapter.InsertCommand.Parameters[25].Value = (object) EDITDATE.Value;
      else
        this.Adapter.InsertCommand.Parameters[25].Value = (object) DBNull.Value;
      if (SAVEMAC == null)
        this.Adapter.InsertCommand.Parameters[26].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[26].Value = (object) SAVEMAC;
      if (EDITMAC == null)
        this.Adapter.InsertCommand.Parameters[27].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[27].Value = (object) EDITMAC;
      if (SAVEIP == null)
        this.Adapter.InsertCommand.Parameters[28].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[28].Value = (object) SAVEIP;
      if (EDITIP == null)
        this.Adapter.InsertCommand.Parameters[29].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[29].Value = (object) EDITIP;
      if (BAKIMTURUID == null)
        this.Adapter.InsertCommand.Parameters[30].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[30].Value = (object) BAKIMTURUID;
      if (BAKIMDERECESIID == null)
        this.Adapter.InsertCommand.Parameters[31].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[31].Value = (object) BAKIMDERECESIID;
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
      string KOD,
      int? ATOLYEID,
      int? ARACID,
      DateTime? GIRISTARIH,
      DateTime? GIRISSAAT,
      DateTime? CIKISTARIH,
      DateTime? CIKISSAAT,
      int? ARIZANEDENIID,
      string BILDIRILENARIZA,
      int? ISEMRIDURUMID,
      int? BAKIMYERIID,
      string BAKIMYERACKLM,
      string ARACIGETIREN,
      string BAKIMKMSI,
      string SONRAKIBKMKM,
      string SONRAKIBKMTRH,
      string BAKIMSAATI,
      string SONRAKIBKMSAAT,
      int? ISEMRISIRANO,
      string YAPILANBAKIMOZETI,
      int? IMZAATOLYESEFID,
      string ISBITIMORANI,
      string SAVEUSER,
      DateTime? SAVEDATE,
      string EDITUSER,
      DateTime? EDITDATE,
      string SAVEMAC,
      string EDITMAC,
      string SAVEIP,
      string EDITIP,
      string BAKIMTURUID,
      string BAKIMDERECESIID,
      int Original_ID,
      string Original_KOD,
      int? Original_ATOLYEID,
      int? Original_ARACID,
      DateTime? Original_GIRISTARIH,
      DateTime? Original_GIRISSAAT,
      DateTime? Original_CIKISTARIH,
      DateTime? Original_CIKISSAAT,
      int? Original_ARIZANEDENIID,
      int? Original_ISEMRIDURUMID,
      int? Original_BAKIMYERIID,
      string Original_BAKIMYERACKLM,
      string Original_ARACIGETIREN,
      string Original_BAKIMKMSI,
      string Original_SONRAKIBKMKM,
      string Original_SONRAKIBKMTRH,
      string Original_BAKIMSAATI,
      string Original_SONRAKIBKMSAAT,
      int? Original_ISEMRISIRANO,
      int? Original_IMZAATOLYESEFID,
      string Original_ISBITIMORANI,
      string Original_SAVEUSER,
      DateTime? Original_SAVEDATE,
      string Original_EDITUSER,
      DateTime? Original_EDITDATE,
      string Original_SAVEMAC,
      string Original_EDITMAC,
      string Original_SAVEIP,
      string Original_EDITIP,
      string Original_BAKIMTURUID,
      string Original_BAKIMDERECESIID,
      int ID)
    {
      if (KOD == null)
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) KOD;
      if (ATOLYEID.HasValue)
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) ATOLYEID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) DBNull.Value;
      if (ARACID.HasValue)
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) ARACID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) DBNull.Value;
      if (GIRISTARIH.HasValue)
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) GIRISTARIH.Value;
      else
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) DBNull.Value;
      if (GIRISSAAT.HasValue)
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) GIRISSAAT.Value;
      else
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) DBNull.Value;
      if (CIKISTARIH.HasValue)
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) CIKISTARIH.Value;
      else
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) DBNull.Value;
      if (CIKISSAAT.HasValue)
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) CIKISSAAT.Value;
      else
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) DBNull.Value;
      if (ARIZANEDENIID.HasValue)
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) ARIZANEDENIID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) DBNull.Value;
      if (BILDIRILENARIZA == null)
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) BILDIRILENARIZA;
      if (ISEMRIDURUMID.HasValue)
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) ISEMRIDURUMID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) DBNull.Value;
      if (BAKIMYERIID.HasValue)
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) BAKIMYERIID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) DBNull.Value;
      if (BAKIMYERACKLM == null)
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) BAKIMYERACKLM;
      if (ARACIGETIREN == null)
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) ARACIGETIREN;
      if (BAKIMKMSI == null)
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) BAKIMKMSI;
      if (SONRAKIBKMKM == null)
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) SONRAKIBKMKM;
      if (SONRAKIBKMTRH == null)
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) SONRAKIBKMTRH;
      if (BAKIMSAATI == null)
        this.Adapter.UpdateCommand.Parameters[16].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[16].Value = (object) BAKIMSAATI;
      if (SONRAKIBKMSAAT == null)
        this.Adapter.UpdateCommand.Parameters[17].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[17].Value = (object) SONRAKIBKMSAAT;
      if (ISEMRISIRANO.HasValue)
        this.Adapter.UpdateCommand.Parameters[18].Value = (object) ISEMRISIRANO.Value;
      else
        this.Adapter.UpdateCommand.Parameters[18].Value = (object) DBNull.Value;
      if (YAPILANBAKIMOZETI == null)
        this.Adapter.UpdateCommand.Parameters[19].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[19].Value = (object) YAPILANBAKIMOZETI;
      if (IMZAATOLYESEFID.HasValue)
        this.Adapter.UpdateCommand.Parameters[20].Value = (object) IMZAATOLYESEFID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[20].Value = (object) DBNull.Value;
      if (ISBITIMORANI == null)
        this.Adapter.UpdateCommand.Parameters[21].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[21].Value = (object) ISBITIMORANI;
      if (SAVEUSER == null)
        this.Adapter.UpdateCommand.Parameters[22].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[22].Value = (object) SAVEUSER;
      if (SAVEDATE.HasValue)
        this.Adapter.UpdateCommand.Parameters[23].Value = (object) SAVEDATE.Value;
      else
        this.Adapter.UpdateCommand.Parameters[23].Value = (object) DBNull.Value;
      if (EDITUSER == null)
        this.Adapter.UpdateCommand.Parameters[24].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[24].Value = (object) EDITUSER;
      if (EDITDATE.HasValue)
        this.Adapter.UpdateCommand.Parameters[25].Value = (object) EDITDATE.Value;
      else
        this.Adapter.UpdateCommand.Parameters[25].Value = (object) DBNull.Value;
      if (SAVEMAC == null)
        this.Adapter.UpdateCommand.Parameters[26].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[26].Value = (object) SAVEMAC;
      if (EDITMAC == null)
        this.Adapter.UpdateCommand.Parameters[27].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[27].Value = (object) EDITMAC;
      if (SAVEIP == null)
        this.Adapter.UpdateCommand.Parameters[28].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[28].Value = (object) SAVEIP;
      if (EDITIP == null)
        this.Adapter.UpdateCommand.Parameters[29].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[29].Value = (object) EDITIP;
      if (BAKIMTURUID == null)
        this.Adapter.UpdateCommand.Parameters[30].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[30].Value = (object) BAKIMTURUID;
      if (BAKIMDERECESIID == null)
        this.Adapter.UpdateCommand.Parameters[31].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[31].Value = (object) BAKIMDERECESIID;
      this.Adapter.UpdateCommand.Parameters[32].Value = (object) Original_ID;
      if (Original_KOD == null)
      {
        this.Adapter.UpdateCommand.Parameters[33].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[34].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[33].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[34].Value = (object) Original_KOD;
      }
      if (Original_ATOLYEID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[35].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[36].Value = (object) Original_ATOLYEID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[35].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[36].Value = (object) DBNull.Value;
      }
      if (Original_ARACID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[37].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[38].Value = (object) Original_ARACID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[37].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[38].Value = (object) DBNull.Value;
      }
      if (Original_GIRISTARIH.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[39].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[40].Value = (object) Original_GIRISTARIH.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[39].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[40].Value = (object) DBNull.Value;
      }
      if (Original_GIRISSAAT.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[41].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[42].Value = (object) Original_GIRISSAAT.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[41].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[42].Value = (object) DBNull.Value;
      }
      if (Original_CIKISTARIH.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[43].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[44].Value = (object) Original_CIKISTARIH.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[43].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[44].Value = (object) DBNull.Value;
      }
      if (Original_CIKISSAAT.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[45].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[46].Value = (object) Original_CIKISSAAT.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[45].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[46].Value = (object) DBNull.Value;
      }
      if (Original_ARIZANEDENIID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[47].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[48].Value = (object) Original_ARIZANEDENIID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[47].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[48].Value = (object) DBNull.Value;
      }
      if (Original_ISEMRIDURUMID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[49].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[50].Value = (object) Original_ISEMRIDURUMID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[49].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[50].Value = (object) DBNull.Value;
      }
      if (Original_BAKIMYERIID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[51].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[52].Value = (object) Original_BAKIMYERIID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[51].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[52].Value = (object) DBNull.Value;
      }
      if (Original_BAKIMYERACKLM == null)
      {
        this.Adapter.UpdateCommand.Parameters[53].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[54].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[53].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[54].Value = (object) Original_BAKIMYERACKLM;
      }
      if (Original_ARACIGETIREN == null)
      {
        this.Adapter.UpdateCommand.Parameters[55].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[56].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[55].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[56].Value = (object) Original_ARACIGETIREN;
      }
      if (Original_BAKIMKMSI == null)
      {
        this.Adapter.UpdateCommand.Parameters[57].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[58].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[57].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[58].Value = (object) Original_BAKIMKMSI;
      }
      if (Original_SONRAKIBKMKM == null)
      {
        this.Adapter.UpdateCommand.Parameters[59].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[60].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[59].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[60].Value = (object) Original_SONRAKIBKMKM;
      }
      if (Original_SONRAKIBKMTRH == null)
      {
        this.Adapter.UpdateCommand.Parameters[61].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[62].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[61].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[62].Value = (object) Original_SONRAKIBKMTRH;
      }
      if (Original_BAKIMSAATI == null)
      {
        this.Adapter.UpdateCommand.Parameters[63].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[64].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[63].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[64].Value = (object) Original_BAKIMSAATI;
      }
      if (Original_SONRAKIBKMSAAT == null)
      {
        this.Adapter.UpdateCommand.Parameters[65].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[66].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[65].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[66].Value = (object) Original_SONRAKIBKMSAAT;
      }
      if (Original_ISEMRISIRANO.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[67].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[68].Value = (object) Original_ISEMRISIRANO.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[67].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[68].Value = (object) DBNull.Value;
      }
      if (Original_IMZAATOLYESEFID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[69].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[70].Value = (object) Original_IMZAATOLYESEFID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[69].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[70].Value = (object) DBNull.Value;
      }
      if (Original_ISBITIMORANI == null)
      {
        this.Adapter.UpdateCommand.Parameters[71].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[72].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[71].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[72].Value = (object) Original_ISBITIMORANI;
      }
      if (Original_SAVEUSER == null)
      {
        this.Adapter.UpdateCommand.Parameters[73].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[74].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[73].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[74].Value = (object) Original_SAVEUSER;
      }
      if (Original_SAVEDATE.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[75].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[76].Value = (object) Original_SAVEDATE.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[75].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[76].Value = (object) DBNull.Value;
      }
      if (Original_EDITUSER == null)
      {
        this.Adapter.UpdateCommand.Parameters[77].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[78].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[77].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[78].Value = (object) Original_EDITUSER;
      }
      if (Original_EDITDATE.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[79].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[80].Value = (object) Original_EDITDATE.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[79].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[80].Value = (object) DBNull.Value;
      }
      if (Original_SAVEMAC == null)
      {
        this.Adapter.UpdateCommand.Parameters[81].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[82].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[81].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[82].Value = (object) Original_SAVEMAC;
      }
      if (Original_EDITMAC == null)
      {
        this.Adapter.UpdateCommand.Parameters[83].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[84].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[83].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[84].Value = (object) Original_EDITMAC;
      }
      if (Original_SAVEIP == null)
      {
        this.Adapter.UpdateCommand.Parameters[85].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[86].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[85].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[86].Value = (object) Original_SAVEIP;
      }
      if (Original_EDITIP == null)
      {
        this.Adapter.UpdateCommand.Parameters[87].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[88].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[87].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[88].Value = (object) Original_EDITIP;
      }
      if (Original_BAKIMTURUID == null)
      {
        this.Adapter.UpdateCommand.Parameters[89].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[90].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[89].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[90].Value = (object) Original_BAKIMTURUID;
      }
      if (Original_BAKIMDERECESIID == null)
      {
        this.Adapter.UpdateCommand.Parameters[91].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[92].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[91].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[92].Value = (object) Original_BAKIMDERECESIID;
      }
      this.Adapter.UpdateCommand.Parameters[93].Value = (object) ID;
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
      string KOD,
      int? ATOLYEID,
      int? ARACID,
      DateTime? GIRISTARIH,
      DateTime? GIRISSAAT,
      DateTime? CIKISTARIH,
      DateTime? CIKISSAAT,
      int? ARIZANEDENIID,
      string BILDIRILENARIZA,
      int? ISEMRIDURUMID,
      int? BAKIMYERIID,
      string BAKIMYERACKLM,
      string ARACIGETIREN,
      string BAKIMKMSI,
      string SONRAKIBKMKM,
      string SONRAKIBKMTRH,
      string BAKIMSAATI,
      string SONRAKIBKMSAAT,
      int? ISEMRISIRANO,
      string YAPILANBAKIMOZETI,
      int? IMZAATOLYESEFID,
      string ISBITIMORANI,
      string SAVEUSER,
      DateTime? SAVEDATE,
      string EDITUSER,
      DateTime? EDITDATE,
      string SAVEMAC,
      string EDITMAC,
      string SAVEIP,
      string EDITIP,
      string BAKIMTURUID,
      string BAKIMDERECESIID,
      int Original_ID,
      string Original_KOD,
      int? Original_ATOLYEID,
      int? Original_ARACID,
      DateTime? Original_GIRISTARIH,
      DateTime? Original_GIRISSAAT,
      DateTime? Original_CIKISTARIH,
      DateTime? Original_CIKISSAAT,
      int? Original_ARIZANEDENIID,
      int? Original_ISEMRIDURUMID,
      int? Original_BAKIMYERIID,
      string Original_BAKIMYERACKLM,
      string Original_ARACIGETIREN,
      string Original_BAKIMKMSI,
      string Original_SONRAKIBKMKM,
      string Original_SONRAKIBKMTRH,
      string Original_BAKIMSAATI,
      string Original_SONRAKIBKMSAAT,
      int? Original_ISEMRISIRANO,
      int? Original_IMZAATOLYESEFID,
      string Original_ISBITIMORANI,
      string Original_SAVEUSER,
      DateTime? Original_SAVEDATE,
      string Original_EDITUSER,
      DateTime? Original_EDITDATE,
      string Original_SAVEMAC,
      string Original_EDITMAC,
      string Original_SAVEIP,
      string Original_EDITIP,
      string Original_BAKIMTURUID,
      string Original_BAKIMDERECESIID)
    {
      return this.Update(KOD, ATOLYEID, ARACID, GIRISTARIH, GIRISSAAT, CIKISTARIH, CIKISSAAT, ARIZANEDENIID, BILDIRILENARIZA, ISEMRIDURUMID, BAKIMYERIID, BAKIMYERACKLM, ARACIGETIREN, BAKIMKMSI, SONRAKIBKMKM, SONRAKIBKMTRH, BAKIMSAATI, SONRAKIBKMSAAT, ISEMRISIRANO, YAPILANBAKIMOZETI, IMZAATOLYESEFID, ISBITIMORANI, SAVEUSER, SAVEDATE, EDITUSER, EDITDATE, SAVEMAC, EDITMAC, SAVEIP, EDITIP, BAKIMTURUID, BAKIMDERECESIID, Original_ID, Original_KOD, Original_ATOLYEID, Original_ARACID, Original_GIRISTARIH, Original_GIRISSAAT, Original_CIKISTARIH, Original_CIKISSAAT, Original_ARIZANEDENIID, Original_ISEMRIDURUMID, Original_BAKIMYERIID, Original_BAKIMYERACKLM, Original_ARACIGETIREN, Original_BAKIMKMSI, Original_SONRAKIBKMKM, Original_SONRAKIBKMTRH, Original_BAKIMSAATI, Original_SONRAKIBKMSAAT, Original_ISEMRISIRANO, Original_IMZAATOLYESEFID, Original_ISBITIMORANI, Original_SAVEUSER, Original_SAVEDATE, Original_EDITUSER, Original_EDITDATE, Original_SAVEMAC, Original_EDITMAC, Original_SAVEIP, Original_EDITIP, Original_BAKIMTURUID, Original_BAKIMDERECESIID, Original_ID);
    }
  }
}
