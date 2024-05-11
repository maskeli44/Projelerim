// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.bellDataSet8TableAdapters.TBLYAKITKONTFORMTableAdapter
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

namespace Makina_Ikmal.bellDataSet8TableAdapters
{
  [DesignerCategory("code")]
  [ToolboxItem(true)]
  [DataObject(true)]
  [Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [HelpKeyword("vs.data.TableAdapter")]
  public class TBLYAKITKONTFORMTableAdapter : Component
  {
    private SqlDataAdapter _adapter;
    private SqlConnection _connection;
    private SqlTransaction _transaction;
    private SqlCommand[] _commandCollection;
    private bool _clearBeforeFill;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public TBLYAKITKONTFORMTableAdapter() => this.ClearBeforeFill = true;

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
        DataSetTable = "TBLYAKITKONTFORM",
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
            "PLAKA",
            "PLAKA"
          },
          {
            "EBYSTARIH",
            "EBYSTARIH"
          },
          {
            "EBYSSAYI",
            "EBYSSAYI"
          },
          {
            "GIRISZAMAN",
            "GIRISZAMAN"
          },
          {
            "CIKISZAMAN",
            "CIKISZAMAN"
          },
          {
            "BIRIMID",
            "BIRIMID"
          },
          {
            "MUDURLUKID",
            "MUDURLUKID"
          },
          {
            "SOFOROPERATOR",
            "SOFOROPERATOR"
          },
          {
            "ISTASYONPERSID",
            "ISTASYONPERSID"
          },
          {
            "ILGILIBIRIMPERSID",
            "ILGILIBIRIMPERSID"
          },
          {
            "OTOMASYONPERSID",
            "OTOMASYONPERSID"
          }
        }
      });
      this._adapter.DeleteCommand = new SqlCommand();
      this._adapter.DeleteCommand.Connection = this.Connection;
      this._adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[TBLYAKITKONTFORM] WHERE (([ID] = @Original_ID) AND ((@IsNull_KOD = 1 AND [KOD] IS NULL) OR ([KOD] = @Original_KOD)) AND ((@IsNull_PLAKA = 1 AND [PLAKA] IS NULL) OR ([PLAKA] = @Original_PLAKA)) AND ((@IsNull_EBYSTARIH = 1 AND [EBYSTARIH] IS NULL) OR ([EBYSTARIH] = @Original_EBYSTARIH)) AND ((@IsNull_EBYSSAYI = 1 AND [EBYSSAYI] IS NULL) OR ([EBYSSAYI] = @Original_EBYSSAYI)) AND ((@IsNull_GIRISZAMAN = 1 AND [GIRISZAMAN] IS NULL) OR ([GIRISZAMAN] = @Original_GIRISZAMAN)) AND ((@IsNull_CIKISZAMAN = 1 AND [CIKISZAMAN] IS NULL) OR ([CIKISZAMAN] = @Original_CIKISZAMAN)) AND ((@IsNull_BIRIMID = 1 AND [BIRIMID] IS NULL) OR ([BIRIMID] = @Original_BIRIMID)) AND ((@IsNull_MUDURLUKID = 1 AND [MUDURLUKID] IS NULL) OR ([MUDURLUKID] = @Original_MUDURLUKID)) AND ((@IsNull_SOFOROPERATOR = 1 AND [SOFOROPERATOR] IS NULL) OR ([SOFOROPERATOR] = @Original_SOFOROPERATOR)) AND ((@IsNull_ISTASYONPERSID = 1 AND [ISTASYONPERSID] IS NULL) OR ([ISTASYONPERSID] = @Original_ISTASYONPERSID)) AND ((@IsNull_ILGILIBIRIMPERSID = 1 AND [ILGILIBIRIMPERSID] IS NULL) OR ([ILGILIBIRIMPERSID] = @Original_ILGILIBIRIMPERSID)) AND ((@IsNull_OTOMASYONPERSID = 1 AND [OTOMASYONPERSID] IS NULL) OR ([OTOMASYONPERSID] = @Original_OTOMASYONPERSID)))";
      this._adapter.DeleteCommand.CommandType = CommandType.Text;
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_KOD", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_KOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_PLAKA", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PLAKA", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_PLAKA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PLAKA", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_EBYSTARIH", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EBYSTARIH", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_EBYSTARIH", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EBYSTARIH", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_EBYSSAYI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EBYSSAYI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_EBYSSAYI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EBYSSAYI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_GIRISZAMAN", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GIRISZAMAN", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_GIRISZAMAN", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GIRISZAMAN", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_CIKISZAMAN", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISZAMAN", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_CIKISZAMAN", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISZAMAN", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_BIRIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BIRIMID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_BIRIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BIRIMID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_MUDURLUKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MUDURLUKID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_MUDURLUKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MUDURLUKID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SOFOROPERATOR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SOFOROPERATOR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SOFOROPERATOR", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SOFOROPERATOR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ISTASYONPERSID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISTASYONPERSID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ISTASYONPERSID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISTASYONPERSID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ILGILIBIRIMPERSID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ILGILIBIRIMPERSID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ILGILIBIRIMPERSID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ILGILIBIRIMPERSID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_OTOMASYONPERSID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "OTOMASYONPERSID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_OTOMASYONPERSID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "OTOMASYONPERSID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.InsertCommand = new SqlCommand();
      this._adapter.InsertCommand.Connection = this.Connection;
      this._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[TBLYAKITKONTFORM] ([KOD], [PLAKA], [EBYSTARIH], [EBYSSAYI], [GIRISZAMAN], [CIKISZAMAN], [BIRIMID], [MUDURLUKID], [SOFOROPERATOR], [ISTASYONPERSID], [ILGILIBIRIMPERSID], [OTOMASYONPERSID]) VALUES (@KOD, @PLAKA, @EBYSTARIH, @EBYSSAYI, @GIRISZAMAN, @CIKISZAMAN, @BIRIMID, @MUDURLUKID, @SOFOROPERATOR, @ISTASYONPERSID, @ILGILIBIRIMPERSID, @OTOMASYONPERSID);\r\nSELECT ID, KOD, PLAKA, EBYSTARIH, EBYSSAYI, GIRISZAMAN, CIKISZAMAN, BIRIMID, MUDURLUKID, SOFOROPERATOR, ISTASYONPERSID, ILGILIBIRIMPERSID, OTOMASYONPERSID FROM TBLYAKITKONTFORM WHERE (ID = SCOPE_IDENTITY())";
      this._adapter.InsertCommand.CommandType = CommandType.Text;
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@KOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@PLAKA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PLAKA", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@EBYSTARIH", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EBYSTARIH", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@EBYSSAYI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EBYSSAYI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@GIRISZAMAN", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GIRISZAMAN", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@CIKISZAMAN", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISZAMAN", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@BIRIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BIRIMID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@MUDURLUKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MUDURLUKID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SOFOROPERATOR", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SOFOROPERATOR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ISTASYONPERSID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISTASYONPERSID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ILGILIBIRIMPERSID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ILGILIBIRIMPERSID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@OTOMASYONPERSID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "OTOMASYONPERSID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand = new SqlCommand();
      this._adapter.UpdateCommand.Connection = this.Connection;
      this._adapter.UpdateCommand.CommandText = "UPDATE [dbo].[TBLYAKITKONTFORM] SET [KOD] = @KOD, [PLAKA] = @PLAKA, [EBYSTARIH] = @EBYSTARIH, [EBYSSAYI] = @EBYSSAYI, [GIRISZAMAN] = @GIRISZAMAN, [CIKISZAMAN] = @CIKISZAMAN, [BIRIMID] = @BIRIMID, [MUDURLUKID] = @MUDURLUKID, [SOFOROPERATOR] = @SOFOROPERATOR, [ISTASYONPERSID] = @ISTASYONPERSID, [ILGILIBIRIMPERSID] = @ILGILIBIRIMPERSID, [OTOMASYONPERSID] = @OTOMASYONPERSID WHERE (([ID] = @Original_ID) AND ((@IsNull_KOD = 1 AND [KOD] IS NULL) OR ([KOD] = @Original_KOD)) AND ((@IsNull_PLAKA = 1 AND [PLAKA] IS NULL) OR ([PLAKA] = @Original_PLAKA)) AND ((@IsNull_EBYSTARIH = 1 AND [EBYSTARIH] IS NULL) OR ([EBYSTARIH] = @Original_EBYSTARIH)) AND ((@IsNull_EBYSSAYI = 1 AND [EBYSSAYI] IS NULL) OR ([EBYSSAYI] = @Original_EBYSSAYI)) AND ((@IsNull_GIRISZAMAN = 1 AND [GIRISZAMAN] IS NULL) OR ([GIRISZAMAN] = @Original_GIRISZAMAN)) AND ((@IsNull_CIKISZAMAN = 1 AND [CIKISZAMAN] IS NULL) OR ([CIKISZAMAN] = @Original_CIKISZAMAN)) AND ((@IsNull_BIRIMID = 1 AND [BIRIMID] IS NULL) OR ([BIRIMID] = @Original_BIRIMID)) AND ((@IsNull_MUDURLUKID = 1 AND [MUDURLUKID] IS NULL) OR ([MUDURLUKID] = @Original_MUDURLUKID)) AND ((@IsNull_SOFOROPERATOR = 1 AND [SOFOROPERATOR] IS NULL) OR ([SOFOROPERATOR] = @Original_SOFOROPERATOR)) AND ((@IsNull_ISTASYONPERSID = 1 AND [ISTASYONPERSID] IS NULL) OR ([ISTASYONPERSID] = @Original_ISTASYONPERSID)) AND ((@IsNull_ILGILIBIRIMPERSID = 1 AND [ILGILIBIRIMPERSID] IS NULL) OR ([ILGILIBIRIMPERSID] = @Original_ILGILIBIRIMPERSID)) AND ((@IsNull_OTOMASYONPERSID = 1 AND [OTOMASYONPERSID] IS NULL) OR ([OTOMASYONPERSID] = @Original_OTOMASYONPERSID)));\r\nSELECT ID, KOD, PLAKA, EBYSTARIH, EBYSSAYI, GIRISZAMAN, CIKISZAMAN, BIRIMID, MUDURLUKID, SOFOROPERATOR, ISTASYONPERSID, ILGILIBIRIMPERSID, OTOMASYONPERSID FROM TBLYAKITKONTFORM WHERE (ID = @ID)";
      this._adapter.UpdateCommand.CommandType = CommandType.Text;
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@KOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@PLAKA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PLAKA", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EBYSTARIH", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EBYSTARIH", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EBYSSAYI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EBYSSAYI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@GIRISZAMAN", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GIRISZAMAN", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@CIKISZAMAN", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISZAMAN", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@BIRIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BIRIMID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MUDURLUKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MUDURLUKID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SOFOROPERATOR", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SOFOROPERATOR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ISTASYONPERSID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISTASYONPERSID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ILGILIBIRIMPERSID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ILGILIBIRIMPERSID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@OTOMASYONPERSID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "OTOMASYONPERSID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_KOD", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_KOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_PLAKA", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PLAKA", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_PLAKA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PLAKA", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_EBYSTARIH", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EBYSTARIH", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_EBYSTARIH", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EBYSTARIH", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_EBYSSAYI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EBYSSAYI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_EBYSSAYI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EBYSSAYI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_GIRISZAMAN", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GIRISZAMAN", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_GIRISZAMAN", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GIRISZAMAN", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_CIKISZAMAN", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISZAMAN", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_CIKISZAMAN", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISZAMAN", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_BIRIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BIRIMID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_BIRIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BIRIMID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_MUDURLUKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MUDURLUKID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_MUDURLUKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MUDURLUKID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SOFOROPERATOR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SOFOROPERATOR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SOFOROPERATOR", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SOFOROPERATOR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ISTASYONPERSID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISTASYONPERSID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ISTASYONPERSID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISTASYONPERSID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ILGILIBIRIMPERSID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ILGILIBIRIMPERSID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ILGILIBIRIMPERSID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ILGILIBIRIMPERSID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_OTOMASYONPERSID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "OTOMASYONPERSID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_OTOMASYONPERSID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "OTOMASYONPERSID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Current, false, (object) null, "", "", ""));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitConnection()
    {
      this._connection = new SqlConnection();
      this._connection.ConnectionString = Settings.Default.bellConnectionString1;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitCommandCollection()
    {
      this._commandCollection = new SqlCommand[1];
      this._commandCollection[0] = new SqlCommand();
      this._commandCollection[0].Connection = this.Connection;
      this._commandCollection[0].CommandText = "SELECT ID, KOD, PLAKA, EBYSTARIH, EBYSSAYI, GIRISZAMAN, CIKISZAMAN, BIRIMID, MUDURLUKID, SOFOROPERATOR, ISTASYONPERSID, ILGILIBIRIMPERSID, OTOMASYONPERSID FROM dbo.TBLYAKITKONTFORM";
      this._commandCollection[0].CommandType = CommandType.Text;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    public virtual int Fill(bellDataSet8.TBLYAKITKONTFORMDataTable dataTable)
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
    public virtual bellDataSet8.TBLYAKITKONTFORMDataTable GetData()
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      bellDataSet8.TBLYAKITKONTFORMDataTable data = new bellDataSet8.TBLYAKITKONTFORMDataTable();
      this.Adapter.Fill((DataTable) data);
      return data;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(bellDataSet8.TBLYAKITKONTFORMDataTable dataTable) => this.Adapter.Update((DataTable) dataTable);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(bellDataSet8 dataSet) => this.Adapter.Update((DataSet) dataSet, "TBLYAKITKONTFORM");

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
      string Original_PLAKA,
      DateTime? Original_EBYSTARIH,
      string Original_EBYSSAYI,
      DateTime? Original_GIRISZAMAN,
      DateTime? Original_CIKISZAMAN,
      int? Original_BIRIMID,
      int? Original_MUDURLUKID,
      string Original_SOFOROPERATOR,
      int? Original_ISTASYONPERSID,
      int? Original_ILGILIBIRIMPERSID,
      int? Original_OTOMASYONPERSID)
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
      if (Original_EBYSTARIH.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[6].Value = (object) Original_EBYSTARIH.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[6].Value = (object) DBNull.Value;
      }
      if (Original_EBYSSAYI == null)
      {
        this.Adapter.DeleteCommand.Parameters[7].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[8].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[7].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[8].Value = (object) Original_EBYSSAYI;
      }
      if (Original_GIRISZAMAN.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) Original_GIRISZAMAN.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) DBNull.Value;
      }
      if (Original_CIKISZAMAN.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[11].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[12].Value = (object) Original_CIKISZAMAN.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[11].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[12].Value = (object) DBNull.Value;
      }
      if (Original_BIRIMID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[13].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[14].Value = (object) Original_BIRIMID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[13].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[14].Value = (object) DBNull.Value;
      }
      if (Original_MUDURLUKID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[15].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[16].Value = (object) Original_MUDURLUKID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[15].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[16].Value = (object) DBNull.Value;
      }
      if (Original_SOFOROPERATOR == null)
      {
        this.Adapter.DeleteCommand.Parameters[17].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[18].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[17].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[18].Value = (object) Original_SOFOROPERATOR;
      }
      if (Original_ISTASYONPERSID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[19].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[20].Value = (object) Original_ISTASYONPERSID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[19].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[20].Value = (object) DBNull.Value;
      }
      if (Original_ILGILIBIRIMPERSID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[21].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[22].Value = (object) Original_ILGILIBIRIMPERSID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[21].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[22].Value = (object) DBNull.Value;
      }
      if (Original_OTOMASYONPERSID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[23].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[24].Value = (object) Original_OTOMASYONPERSID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[23].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[24].Value = (object) DBNull.Value;
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
      string PLAKA,
      DateTime? EBYSTARIH,
      string EBYSSAYI,
      DateTime? GIRISZAMAN,
      DateTime? CIKISZAMAN,
      int? BIRIMID,
      int? MUDURLUKID,
      string SOFOROPERATOR,
      int? ISTASYONPERSID,
      int? ILGILIBIRIMPERSID,
      int? OTOMASYONPERSID)
    {
      if (KOD == null)
        this.Adapter.InsertCommand.Parameters[0].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[0].Value = (object) KOD;
      if (PLAKA == null)
        this.Adapter.InsertCommand.Parameters[1].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[1].Value = (object) PLAKA;
      if (EBYSTARIH.HasValue)
        this.Adapter.InsertCommand.Parameters[2].Value = (object) EBYSTARIH.Value;
      else
        this.Adapter.InsertCommand.Parameters[2].Value = (object) DBNull.Value;
      if (EBYSSAYI == null)
        this.Adapter.InsertCommand.Parameters[3].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[3].Value = (object) EBYSSAYI;
      if (GIRISZAMAN.HasValue)
        this.Adapter.InsertCommand.Parameters[4].Value = (object) GIRISZAMAN.Value;
      else
        this.Adapter.InsertCommand.Parameters[4].Value = (object) DBNull.Value;
      if (CIKISZAMAN.HasValue)
        this.Adapter.InsertCommand.Parameters[5].Value = (object) CIKISZAMAN.Value;
      else
        this.Adapter.InsertCommand.Parameters[5].Value = (object) DBNull.Value;
      if (BIRIMID.HasValue)
        this.Adapter.InsertCommand.Parameters[6].Value = (object) BIRIMID.Value;
      else
        this.Adapter.InsertCommand.Parameters[6].Value = (object) DBNull.Value;
      if (MUDURLUKID.HasValue)
        this.Adapter.InsertCommand.Parameters[7].Value = (object) MUDURLUKID.Value;
      else
        this.Adapter.InsertCommand.Parameters[7].Value = (object) DBNull.Value;
      if (SOFOROPERATOR == null)
        this.Adapter.InsertCommand.Parameters[8].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[8].Value = (object) SOFOROPERATOR;
      if (ISTASYONPERSID.HasValue)
        this.Adapter.InsertCommand.Parameters[9].Value = (object) ISTASYONPERSID.Value;
      else
        this.Adapter.InsertCommand.Parameters[9].Value = (object) DBNull.Value;
      if (ILGILIBIRIMPERSID.HasValue)
        this.Adapter.InsertCommand.Parameters[10].Value = (object) ILGILIBIRIMPERSID.Value;
      else
        this.Adapter.InsertCommand.Parameters[10].Value = (object) DBNull.Value;
      if (OTOMASYONPERSID.HasValue)
        this.Adapter.InsertCommand.Parameters[11].Value = (object) OTOMASYONPERSID.Value;
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
      string KOD,
      string PLAKA,
      DateTime? EBYSTARIH,
      string EBYSSAYI,
      DateTime? GIRISZAMAN,
      DateTime? CIKISZAMAN,
      int? BIRIMID,
      int? MUDURLUKID,
      string SOFOROPERATOR,
      int? ISTASYONPERSID,
      int? ILGILIBIRIMPERSID,
      int? OTOMASYONPERSID,
      int Original_ID,
      string Original_KOD,
      string Original_PLAKA,
      DateTime? Original_EBYSTARIH,
      string Original_EBYSSAYI,
      DateTime? Original_GIRISZAMAN,
      DateTime? Original_CIKISZAMAN,
      int? Original_BIRIMID,
      int? Original_MUDURLUKID,
      string Original_SOFOROPERATOR,
      int? Original_ISTASYONPERSID,
      int? Original_ILGILIBIRIMPERSID,
      int? Original_OTOMASYONPERSID,
      int ID)
    {
      if (KOD == null)
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) KOD;
      if (PLAKA == null)
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) PLAKA;
      if (EBYSTARIH.HasValue)
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) EBYSTARIH.Value;
      else
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) DBNull.Value;
      if (EBYSSAYI == null)
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) EBYSSAYI;
      if (GIRISZAMAN.HasValue)
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) GIRISZAMAN.Value;
      else
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) DBNull.Value;
      if (CIKISZAMAN.HasValue)
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) CIKISZAMAN.Value;
      else
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) DBNull.Value;
      if (BIRIMID.HasValue)
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) BIRIMID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) DBNull.Value;
      if (MUDURLUKID.HasValue)
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) MUDURLUKID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) DBNull.Value;
      if (SOFOROPERATOR == null)
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) SOFOROPERATOR;
      if (ISTASYONPERSID.HasValue)
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) ISTASYONPERSID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) DBNull.Value;
      if (ILGILIBIRIMPERSID.HasValue)
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) ILGILIBIRIMPERSID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) DBNull.Value;
      if (OTOMASYONPERSID.HasValue)
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) OTOMASYONPERSID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) DBNull.Value;
      this.Adapter.UpdateCommand.Parameters[12].Value = (object) Original_ID;
      if (Original_KOD == null)
      {
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) Original_KOD;
      }
      if (Original_PLAKA == null)
      {
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[16].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[16].Value = (object) Original_PLAKA;
      }
      if (Original_EBYSTARIH.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[17].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[18].Value = (object) Original_EBYSTARIH.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[17].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[18].Value = (object) DBNull.Value;
      }
      if (Original_EBYSSAYI == null)
      {
        this.Adapter.UpdateCommand.Parameters[19].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[20].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[19].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[20].Value = (object) Original_EBYSSAYI;
      }
      if (Original_GIRISZAMAN.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[21].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[22].Value = (object) Original_GIRISZAMAN.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[21].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[22].Value = (object) DBNull.Value;
      }
      if (Original_CIKISZAMAN.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[23].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[24].Value = (object) Original_CIKISZAMAN.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[23].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[24].Value = (object) DBNull.Value;
      }
      if (Original_BIRIMID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[25].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[26].Value = (object) Original_BIRIMID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[25].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[26].Value = (object) DBNull.Value;
      }
      if (Original_MUDURLUKID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[27].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[28].Value = (object) Original_MUDURLUKID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[27].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[28].Value = (object) DBNull.Value;
      }
      if (Original_SOFOROPERATOR == null)
      {
        this.Adapter.UpdateCommand.Parameters[29].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[30].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[29].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[30].Value = (object) Original_SOFOROPERATOR;
      }
      if (Original_ISTASYONPERSID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[31].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[32].Value = (object) Original_ISTASYONPERSID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[31].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[32].Value = (object) DBNull.Value;
      }
      if (Original_ILGILIBIRIMPERSID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[33].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[34].Value = (object) Original_ILGILIBIRIMPERSID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[33].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[34].Value = (object) DBNull.Value;
      }
      if (Original_OTOMASYONPERSID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[35].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[36].Value = (object) Original_OTOMASYONPERSID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[35].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[36].Value = (object) DBNull.Value;
      }
      this.Adapter.UpdateCommand.Parameters[37].Value = (object) ID;
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
      string PLAKA,
      DateTime? EBYSTARIH,
      string EBYSSAYI,
      DateTime? GIRISZAMAN,
      DateTime? CIKISZAMAN,
      int? BIRIMID,
      int? MUDURLUKID,
      string SOFOROPERATOR,
      int? ISTASYONPERSID,
      int? ILGILIBIRIMPERSID,
      int? OTOMASYONPERSID,
      int Original_ID,
      string Original_KOD,
      string Original_PLAKA,
      DateTime? Original_EBYSTARIH,
      string Original_EBYSSAYI,
      DateTime? Original_GIRISZAMAN,
      DateTime? Original_CIKISZAMAN,
      int? Original_BIRIMID,
      int? Original_MUDURLUKID,
      string Original_SOFOROPERATOR,
      int? Original_ISTASYONPERSID,
      int? Original_ILGILIBIRIMPERSID,
      int? Original_OTOMASYONPERSID)
    {
      return this.Update(KOD, PLAKA, EBYSTARIH, EBYSSAYI, GIRISZAMAN, CIKISZAMAN, BIRIMID, MUDURLUKID, SOFOROPERATOR, ISTASYONPERSID, ILGILIBIRIMPERSID, OTOMASYONPERSID, Original_ID, Original_KOD, Original_PLAKA, Original_EBYSTARIH, Original_EBYSSAYI, Original_GIRISZAMAN, Original_CIKISZAMAN, Original_BIRIMID, Original_MUDURLUKID, Original_SOFOROPERATOR, Original_ISTASYONPERSID, Original_ILGILIBIRIMPERSID, Original_OTOMASYONPERSID, Original_ID);
    }
  }
}
