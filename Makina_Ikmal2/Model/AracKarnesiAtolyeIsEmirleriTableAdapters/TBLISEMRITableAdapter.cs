// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Model.AracKarnesiAtolyeIsEmirleriTableAdapters.TBLISEMRITableAdapter
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

namespace Makina_Ikmal.Model.AracKarnesiAtolyeIsEmirleriTableAdapters
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
            "Arıza Nedeni",
            "Arıza Nedeni"
          },
          {
            "GIRISTARIH",
            "GIRISTARIH"
          },
          {
            "CIKISTARIH",
            "CIKISTARIH"
          },
          {
            "BILDIRILENARIZA",
            "BILDIRILENARIZA"
          },
          {
            "Bakım Yeri",
            "Bakım Yeri"
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
            "YAPILANBAKIMOZETI",
            "YAPILANBAKIMOZETI"
          },
          {
            "ARACID",
            "ARACID"
          }
        }
      });
      this._adapter.DeleteCommand = new SqlCommand();
      this._adapter.DeleteCommand.Connection = this.Connection;
      this._adapter.DeleteCommand.CommandText = "DELETE FROM [TBLISEMRI] WHERE (([ID] = @Original_ID) AND ((@IsNull_Arıza_Nedeni = 1 AND [ARIZANEDENIID] IS NULL) OR ([ARIZANEDENIID] = @Original_Arıza_Nedeni)) AND ((@IsNull_GIRISTARIH = 1 AND [GIRISTARIH] IS NULL) OR ([GIRISTARIH] = @Original_GIRISTARIH)) AND ((@IsNull_CIKISTARIH = 1 AND [CIKISTARIH] IS NULL) OR ([CIKISTARIH] = @Original_CIKISTARIH)) AND ((@IsNull_Bakım_Yeri = 1 AND [BAKIMYERIID] IS NULL) OR ([BAKIMYERIID] = @Original_Bakım_Yeri)) AND ((@IsNull_BAKIMKMSI = 1 AND [BAKIMKMSI] IS NULL) OR ([BAKIMKMSI] = @Original_BAKIMKMSI)) AND ((@IsNull_SONRAKIBKMKM = 1 AND [SONRAKIBKMKM] IS NULL) OR ([SONRAKIBKMKM] = @Original_SONRAKIBKMKM)) AND ((@IsNull_SONRAKIBKMTRH = 1 AND [SONRAKIBKMTRH] IS NULL) OR ([SONRAKIBKMTRH] = @Original_SONRAKIBKMTRH)) AND ((@IsNull_BAKIMSAATI = 1 AND [BAKIMSAATI] IS NULL) OR ([BAKIMSAATI] = @Original_BAKIMSAATI)) AND ((@IsNull_SONRAKIBKMSAAT = 1 AND [SONRAKIBKMSAAT] IS NULL) OR ([SONRAKIBKMSAAT] = @Original_SONRAKIBKMSAAT)) AND ((@IsNull_ARACID = 1 AND [ARACID] IS NULL) OR ([ARACID] = @Original_ARACID)))";
      this._adapter.DeleteCommand.CommandType = CommandType.Text;
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Arıza_Nedeni", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Arıza Nedeni", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Arıza_Nedeni", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Arıza Nedeni", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_GIRISTARIH", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GIRISTARIH", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_GIRISTARIH", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GIRISTARIH", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_CIKISTARIH", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISTARIH", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_CIKISTARIH", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISTARIH", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Bakım_Yeri", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Bakım Yeri", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Bakım_Yeri", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Bakım Yeri", DataRowVersion.Original, false, (object) null, "", "", ""));
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
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ARACID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ARACID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.InsertCommand = new SqlCommand();
      this._adapter.InsertCommand.Connection = this.Connection;
      this._adapter.InsertCommand.CommandText = "INSERT INTO [TBLISEMRI] ([ARIZANEDENIID], [GIRISTARIH], [CIKISTARIH], [BILDIRILENARIZA], [BAKIMYERIID], [BAKIMKMSI], [SONRAKIBKMKM], [SONRAKIBKMTRH], [BAKIMSAATI], [SONRAKIBKMSAAT], [YAPILANBAKIMOZETI], [ARACID]) VALUES (@Arıza_Nedeni, @GIRISTARIH, @CIKISTARIH, @BILDIRILENARIZA, @Bakım_Yeri, @BAKIMKMSI, @SONRAKIBKMKM, @SONRAKIBKMTRH, @BAKIMSAATI, @SONRAKIBKMSAAT, @YAPILANBAKIMOZETI, @ARACID);\r\nSELECT ID, ARIZANEDENIID AS [Arıza Nedeni], GIRISTARIH, CIKISTARIH, BILDIRILENARIZA, BAKIMYERIID AS [Bakım Yeri], BAKIMKMSI, SONRAKIBKMKM, SONRAKIBKMTRH, BAKIMSAATI, SONRAKIBKMSAAT, YAPILANBAKIMOZETI, ARACID FROM TBLISEMRI WHERE (ID = SCOPE_IDENTITY())";
      this._adapter.InsertCommand.CommandType = CommandType.Text;
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Arıza_Nedeni", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Arıza Nedeni", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@GIRISTARIH", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GIRISTARIH", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@CIKISTARIH", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISTARIH", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@BILDIRILENARIZA", SqlDbType.Text, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BILDIRILENARIZA", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Bakım_Yeri", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Bakım Yeri", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@BAKIMKMSI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAKIMKMSI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SONRAKIBKMKM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SONRAKIBKMKM", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SONRAKIBKMTRH", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SONRAKIBKMTRH", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@BAKIMSAATI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAKIMSAATI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SONRAKIBKMSAAT", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SONRAKIBKMSAAT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@YAPILANBAKIMOZETI", SqlDbType.Text, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YAPILANBAKIMOZETI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ARACID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand = new SqlCommand();
      this._adapter.UpdateCommand.Connection = this.Connection;
      this._adapter.UpdateCommand.CommandText = "UPDATE [TBLISEMRI] SET [ARIZANEDENIID] = @Arıza_Nedeni, [GIRISTARIH] = @GIRISTARIH, [CIKISTARIH] = @CIKISTARIH, [BILDIRILENARIZA] = @BILDIRILENARIZA, [BAKIMYERIID] = @Bakım_Yeri, [BAKIMKMSI] = @BAKIMKMSI, [SONRAKIBKMKM] = @SONRAKIBKMKM, [SONRAKIBKMTRH] = @SONRAKIBKMTRH, [BAKIMSAATI] = @BAKIMSAATI, [SONRAKIBKMSAAT] = @SONRAKIBKMSAAT, [YAPILANBAKIMOZETI] = @YAPILANBAKIMOZETI, [ARACID] = @ARACID WHERE (([ID] = @Original_ID) AND ((@IsNull_Arıza_Nedeni = 1 AND [ARIZANEDENIID] IS NULL) OR ([ARIZANEDENIID] = @Original_Arıza_Nedeni)) AND ((@IsNull_GIRISTARIH = 1 AND [GIRISTARIH] IS NULL) OR ([GIRISTARIH] = @Original_GIRISTARIH)) AND ((@IsNull_CIKISTARIH = 1 AND [CIKISTARIH] IS NULL) OR ([CIKISTARIH] = @Original_CIKISTARIH)) AND ((@IsNull_Bakım_Yeri = 1 AND [BAKIMYERIID] IS NULL) OR ([BAKIMYERIID] = @Original_Bakım_Yeri)) AND ((@IsNull_BAKIMKMSI = 1 AND [BAKIMKMSI] IS NULL) OR ([BAKIMKMSI] = @Original_BAKIMKMSI)) AND ((@IsNull_SONRAKIBKMKM = 1 AND [SONRAKIBKMKM] IS NULL) OR ([SONRAKIBKMKM] = @Original_SONRAKIBKMKM)) AND ((@IsNull_SONRAKIBKMTRH = 1 AND [SONRAKIBKMTRH] IS NULL) OR ([SONRAKIBKMTRH] = @Original_SONRAKIBKMTRH)) AND ((@IsNull_BAKIMSAATI = 1 AND [BAKIMSAATI] IS NULL) OR ([BAKIMSAATI] = @Original_BAKIMSAATI)) AND ((@IsNull_SONRAKIBKMSAAT = 1 AND [SONRAKIBKMSAAT] IS NULL) OR ([SONRAKIBKMSAAT] = @Original_SONRAKIBKMSAAT)) AND ((@IsNull_ARACID = 1 AND [ARACID] IS NULL) OR ([ARACID] = @Original_ARACID)));\r\nSELECT ID, ARIZANEDENIID AS [Arıza Nedeni], GIRISTARIH, CIKISTARIH, BILDIRILENARIZA, BAKIMYERIID AS [Bakım Yeri], BAKIMKMSI, SONRAKIBKMKM, SONRAKIBKMTRH, BAKIMSAATI, SONRAKIBKMSAAT, YAPILANBAKIMOZETI, ARACID FROM TBLISEMRI WHERE (ID = @ID)";
      this._adapter.UpdateCommand.CommandType = CommandType.Text;
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Arıza_Nedeni", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Arıza Nedeni", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@GIRISTARIH", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GIRISTARIH", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@CIKISTARIH", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISTARIH", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@BILDIRILENARIZA", SqlDbType.Text, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BILDIRILENARIZA", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Bakım_Yeri", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Bakım Yeri", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@BAKIMKMSI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAKIMKMSI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SONRAKIBKMKM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SONRAKIBKMKM", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SONRAKIBKMTRH", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SONRAKIBKMTRH", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@BAKIMSAATI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAKIMSAATI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SONRAKIBKMSAAT", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SONRAKIBKMSAAT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@YAPILANBAKIMOZETI", SqlDbType.Text, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YAPILANBAKIMOZETI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ARACID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Arıza_Nedeni", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Arıza Nedeni", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Arıza_Nedeni", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Arıza Nedeni", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_GIRISTARIH", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GIRISTARIH", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_GIRISTARIH", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GIRISTARIH", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_CIKISTARIH", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISTARIH", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_CIKISTARIH", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISTARIH", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Bakım_Yeri", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Bakım Yeri", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Bakım_Yeri", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Bakım Yeri", DataRowVersion.Original, false, (object) null, "", "", ""));
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
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ARACID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ARACID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACID", DataRowVersion.Original, false, (object) null, "", "", ""));
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
      this._commandCollection[0].CommandText = "SELECT ID, ARIZANEDENIID AS [Arıza Nedeni], GIRISTARIH, CIKISTARIH, BILDIRILENARIZA, BAKIMYERIID AS [Bakım Yeri], BAKIMKMSI, SONRAKIBKMKM, SONRAKIBKMTRH, BAKIMSAATI, SONRAKIBKMSAAT, YAPILANBAKIMOZETI, \r\n                  ARACID\r\nFROM     TBLISEMRI\r\nWHERE  (ARACID = @aracid)";
      this._commandCollection[0].CommandType = CommandType.Text;
      this._commandCollection[0].Parameters.Add(new SqlParameter("@aracid", SqlDbType.Int, 4, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACID", DataRowVersion.Current, false, (object) null, "", "", ""));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    public virtual int Fill(
      AracKarnesiAtolyeIsEmirleri.TBLISEMRIDataTable dataTable,
      int? aracid)
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      if (aracid.HasValue)
        this.Adapter.SelectCommand.Parameters[0].Value = (object) aracid.Value;
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
    public virtual AracKarnesiAtolyeIsEmirleri.TBLISEMRIDataTable GetData(int? aracid)
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      if (aracid.HasValue)
        this.Adapter.SelectCommand.Parameters[0].Value = (object) aracid.Value;
      else
        this.Adapter.SelectCommand.Parameters[0].Value = (object) DBNull.Value;
      AracKarnesiAtolyeIsEmirleri.TBLISEMRIDataTable data = new AracKarnesiAtolyeIsEmirleri.TBLISEMRIDataTable();
      this.Adapter.Fill((DataTable) data);
      return data;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(
      AracKarnesiAtolyeIsEmirleri.TBLISEMRIDataTable dataTable)
    {
      return this.Adapter.Update((DataTable) dataTable);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(AracKarnesiAtolyeIsEmirleri dataSet) => this.Adapter.Update((DataSet) dataSet, "TBLISEMRI");

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
      int Original_Arıza_Nedeni,
      DateTime? Original_GIRISTARIH,
      DateTime? Original_CIKISTARIH,
      int Original_Bakım_Yeri,
      string Original_BAKIMKMSI,
      string Original_SONRAKIBKMKM,
      string Original_SONRAKIBKMTRH,
      string Original_BAKIMSAATI,
      string Original_SONRAKIBKMSAAT,
      int? Original_ARACID)
    {
      this.Adapter.DeleteCommand.Parameters[0].Value = (object) Original_ID;
      this.Adapter.DeleteCommand.Parameters[1].Value = (object) 0;
      this.Adapter.DeleteCommand.Parameters[2].Value = (object) Original_Arıza_Nedeni;
      if (Original_GIRISTARIH.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[3].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[4].Value = (object) Original_GIRISTARIH.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[3].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[4].Value = (object) DBNull.Value;
      }
      if (Original_CIKISTARIH.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[6].Value = (object) Original_CIKISTARIH.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[6].Value = (object) DBNull.Value;
      }
      this.Adapter.DeleteCommand.Parameters[7].Value = (object) 0;
      this.Adapter.DeleteCommand.Parameters[8].Value = (object) Original_Bakım_Yeri;
      if (Original_BAKIMKMSI == null)
      {
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) Original_BAKIMKMSI;
      }
      if (Original_SONRAKIBKMKM == null)
      {
        this.Adapter.DeleteCommand.Parameters[11].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[12].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[11].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[12].Value = (object) Original_SONRAKIBKMKM;
      }
      if (Original_SONRAKIBKMTRH == null)
      {
        this.Adapter.DeleteCommand.Parameters[13].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[14].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[13].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[14].Value = (object) Original_SONRAKIBKMTRH;
      }
      if (Original_BAKIMSAATI == null)
      {
        this.Adapter.DeleteCommand.Parameters[15].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[16].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[15].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[16].Value = (object) Original_BAKIMSAATI;
      }
      if (Original_SONRAKIBKMSAAT == null)
      {
        this.Adapter.DeleteCommand.Parameters[17].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[18].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[17].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[18].Value = (object) Original_SONRAKIBKMSAAT;
      }
      if (Original_ARACID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[19].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[20].Value = (object) Original_ARACID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[19].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[20].Value = (object) DBNull.Value;
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
      int Arıza_Nedeni,
      DateTime? GIRISTARIH,
      DateTime? CIKISTARIH,
      string BILDIRILENARIZA,
      int Bakım_Yeri,
      string BAKIMKMSI,
      string SONRAKIBKMKM,
      string SONRAKIBKMTRH,
      string BAKIMSAATI,
      string SONRAKIBKMSAAT,
      string YAPILANBAKIMOZETI,
      int? ARACID)
    {
      this.Adapter.InsertCommand.Parameters[0].Value = (object) Arıza_Nedeni;
      if (GIRISTARIH.HasValue)
        this.Adapter.InsertCommand.Parameters[1].Value = (object) GIRISTARIH.Value;
      else
        this.Adapter.InsertCommand.Parameters[1].Value = (object) DBNull.Value;
      if (CIKISTARIH.HasValue)
        this.Adapter.InsertCommand.Parameters[2].Value = (object) CIKISTARIH.Value;
      else
        this.Adapter.InsertCommand.Parameters[2].Value = (object) DBNull.Value;
      if (BILDIRILENARIZA == null)
        this.Adapter.InsertCommand.Parameters[3].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[3].Value = (object) BILDIRILENARIZA;
      this.Adapter.InsertCommand.Parameters[4].Value = (object) Bakım_Yeri;
      if (BAKIMKMSI == null)
        this.Adapter.InsertCommand.Parameters[5].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[5].Value = (object) BAKIMKMSI;
      if (SONRAKIBKMKM == null)
        this.Adapter.InsertCommand.Parameters[6].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[6].Value = (object) SONRAKIBKMKM;
      if (SONRAKIBKMTRH == null)
        this.Adapter.InsertCommand.Parameters[7].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[7].Value = (object) SONRAKIBKMTRH;
      if (BAKIMSAATI == null)
        this.Adapter.InsertCommand.Parameters[8].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[8].Value = (object) BAKIMSAATI;
      if (SONRAKIBKMSAAT == null)
        this.Adapter.InsertCommand.Parameters[9].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[9].Value = (object) SONRAKIBKMSAAT;
      if (YAPILANBAKIMOZETI == null)
        this.Adapter.InsertCommand.Parameters[10].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[10].Value = (object) YAPILANBAKIMOZETI;
      if (ARACID.HasValue)
        this.Adapter.InsertCommand.Parameters[11].Value = (object) ARACID.Value;
      else
        this.Adapter.InsertCommand.Parameters[11].Value = (object) DBNull.Value;
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
      int Arıza_Nedeni,
      DateTime? GIRISTARIH,
      DateTime? CIKISTARIH,
      string BILDIRILENARIZA,
      int Bakım_Yeri,
      string BAKIMKMSI,
      string SONRAKIBKMKM,
      string SONRAKIBKMTRH,
      string BAKIMSAATI,
      string SONRAKIBKMSAAT,
      string YAPILANBAKIMOZETI,
      int? ARACID,
      int Original_ID,
      int Original_Arıza_Nedeni,
      DateTime? Original_GIRISTARIH,
      DateTime? Original_CIKISTARIH,
      int Original_Bakım_Yeri,
      string Original_BAKIMKMSI,
      string Original_SONRAKIBKMKM,
      string Original_SONRAKIBKMTRH,
      string Original_BAKIMSAATI,
      string Original_SONRAKIBKMSAAT,
      int? Original_ARACID,
      int ID)
    {
      this.Adapter.UpdateCommand.Parameters[0].Value = (object) Arıza_Nedeni;
      if (GIRISTARIH.HasValue)
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) GIRISTARIH.Value;
      else
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) DBNull.Value;
      if (CIKISTARIH.HasValue)
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) CIKISTARIH.Value;
      else
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) DBNull.Value;
      if (BILDIRILENARIZA == null)
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) BILDIRILENARIZA;
      this.Adapter.UpdateCommand.Parameters[4].Value = (object) Bakım_Yeri;
      if (BAKIMKMSI == null)
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) BAKIMKMSI;
      if (SONRAKIBKMKM == null)
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) SONRAKIBKMKM;
      if (SONRAKIBKMTRH == null)
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) SONRAKIBKMTRH;
      if (BAKIMSAATI == null)
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) BAKIMSAATI;
      if (SONRAKIBKMSAAT == null)
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) SONRAKIBKMSAAT;
      if (YAPILANBAKIMOZETI == null)
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) YAPILANBAKIMOZETI;
      if (ARACID.HasValue)
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) ARACID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) DBNull.Value;
      this.Adapter.UpdateCommand.Parameters[12].Value = (object) Original_ID;
      this.Adapter.UpdateCommand.Parameters[13].Value = (object) 0;
      this.Adapter.UpdateCommand.Parameters[14].Value = (object) Original_Arıza_Nedeni;
      if (Original_GIRISTARIH.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[16].Value = (object) Original_GIRISTARIH.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[16].Value = (object) DBNull.Value;
      }
      if (Original_CIKISTARIH.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[17].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[18].Value = (object) Original_CIKISTARIH.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[17].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[18].Value = (object) DBNull.Value;
      }
      this.Adapter.UpdateCommand.Parameters[19].Value = (object) 0;
      this.Adapter.UpdateCommand.Parameters[20].Value = (object) Original_Bakım_Yeri;
      if (Original_BAKIMKMSI == null)
      {
        this.Adapter.UpdateCommand.Parameters[21].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[22].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[21].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[22].Value = (object) Original_BAKIMKMSI;
      }
      if (Original_SONRAKIBKMKM == null)
      {
        this.Adapter.UpdateCommand.Parameters[23].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[24].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[23].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[24].Value = (object) Original_SONRAKIBKMKM;
      }
      if (Original_SONRAKIBKMTRH == null)
      {
        this.Adapter.UpdateCommand.Parameters[25].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[26].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[25].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[26].Value = (object) Original_SONRAKIBKMTRH;
      }
      if (Original_BAKIMSAATI == null)
      {
        this.Adapter.UpdateCommand.Parameters[27].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[28].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[27].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[28].Value = (object) Original_BAKIMSAATI;
      }
      if (Original_SONRAKIBKMSAAT == null)
      {
        this.Adapter.UpdateCommand.Parameters[29].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[30].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[29].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[30].Value = (object) Original_SONRAKIBKMSAAT;
      }
      if (Original_ARACID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[31].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[32].Value = (object) Original_ARACID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[31].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[32].Value = (object) DBNull.Value;
      }
      this.Adapter.UpdateCommand.Parameters[33].Value = (object) ID;
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
      int Arıza_Nedeni,
      DateTime? GIRISTARIH,
      DateTime? CIKISTARIH,
      string BILDIRILENARIZA,
      int Bakım_Yeri,
      string BAKIMKMSI,
      string SONRAKIBKMKM,
      string SONRAKIBKMTRH,
      string BAKIMSAATI,
      string SONRAKIBKMSAAT,
      string YAPILANBAKIMOZETI,
      int? ARACID,
      int Original_ID,
      int Original_Arıza_Nedeni,
      DateTime? Original_GIRISTARIH,
      DateTime? Original_CIKISTARIH,
      int Original_Bakım_Yeri,
      string Original_BAKIMKMSI,
      string Original_SONRAKIBKMKM,
      string Original_SONRAKIBKMTRH,
      string Original_BAKIMSAATI,
      string Original_SONRAKIBKMSAAT,
      int? Original_ARACID)
    {
      return this.Update(Arıza_Nedeni, GIRISTARIH, CIKISTARIH, BILDIRILENARIZA, Bakım_Yeri, BAKIMKMSI, SONRAKIBKMKM, SONRAKIBKMTRH, BAKIMSAATI, SONRAKIBKMSAAT, YAPILANBAKIMOZETI, ARACID, Original_ID, Original_Arıza_Nedeni, Original_GIRISTARIH, Original_CIKISTARIH, Original_Bakım_Yeri, Original_BAKIMKMSI, Original_SONRAKIBKMKM, Original_SONRAKIBKMTRH, Original_BAKIMSAATI, Original_SONRAKIBKMSAAT, Original_ARACID, Original_ID);
    }
  }
}
