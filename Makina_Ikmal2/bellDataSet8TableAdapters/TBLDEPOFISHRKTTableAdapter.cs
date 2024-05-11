// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.bellDataSet8TableAdapters.TBLDEPOFISHRKTTableAdapter
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
  public class TBLDEPOFISHRKTTableAdapter : Component
  {
    private SqlDataAdapter _adapter;
    private SqlConnection _connection;
    private SqlTransaction _transaction;
    private SqlCommand[] _commandCollection;
    private bool _clearBeforeFill;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public TBLDEPOFISHRKTTableAdapter() => this.ClearBeforeFill = true;

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
        DataSetTable = "TBLDEPOFISHRKT",
        ColumnMappings = {
          {
            "ID",
            "ID"
          },
          {
            "DEPOFISID",
            "DEPOFISID"
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
            "GIRISMIKTAR",
            "GIRISMIKTAR"
          },
          {
            "CIKISMIKTAR",
            "CIKISMIKTAR"
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
            "GIRISTUTAR",
            "GIRISTUTAR"
          },
          {
            "CIKISTUTAR",
            "CIKISTUTAR"
          },
          {
            "KDVORAN",
            "KDVORAN"
          },
          {
            "KDVTUTAR",
            "KDVTUTAR"
          },
          {
            "SATIRTUTAR",
            "SATIRTUTAR"
          },
          {
            "GCKOD",
            "GCKOD"
          },
          {
            "DEPOID",
            "DEPOID"
          },
          {
            "MALZMARKAID",
            "MALZMARKAID"
          },
          {
            "MALZSERINO",
            "MALZSERINO"
          },
          {
            "MALZURTTARIH",
            "MALZURTTARIH"
          },
          {
            "DEGISIMKMSI",
            "DEGISIMKMSI"
          },
          {
            "SONRAKIDEGKM",
            "SONRAKIDEGKM"
          }
        }
      });
      this._adapter.DeleteCommand = new SqlCommand();
      this._adapter.DeleteCommand.Connection = this.Connection;
      this._adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[TBLDEPOFISHRKT] WHERE (([ID] = @Original_ID) AND ((@IsNull_DEPOFISID = 1 AND [DEPOFISID] IS NULL) OR ([DEPOFISID] = @Original_DEPOFISID)) AND ((@IsNull_MALZEMEID = 1 AND [MALZEMEID] IS NULL) OR ([MALZEMEID] = @Original_MALZEMEID)) AND ((@IsNull_MALZACIKLAMA = 1 AND [MALZACIKLAMA] IS NULL) OR ([MALZACIKLAMA] = @Original_MALZACIKLAMA)) AND ((@IsNull_BIRIMID = 1 AND [BIRIMID] IS NULL) OR ([BIRIMID] = @Original_BIRIMID)) AND ((@IsNull_MIKTAR = 1 AND [MIKTAR] IS NULL) OR ([MIKTAR] = @Original_MIKTAR)) AND ((@IsNull_GIRISMIKTAR = 1 AND [GIRISMIKTAR] IS NULL) OR ([GIRISMIKTAR] = @Original_GIRISMIKTAR)) AND ((@IsNull_CIKISMIKTAR = 1 AND [CIKISMIKTAR] IS NULL) OR ([CIKISMIKTAR] = @Original_CIKISMIKTAR)) AND ((@IsNull_FIYAT = 1 AND [FIYAT] IS NULL) OR ([FIYAT] = @Original_FIYAT)) AND ((@IsNull_TUTAR = 1 AND [TUTAR] IS NULL) OR ([TUTAR] = @Original_TUTAR)) AND ((@IsNull_GIRISTUTAR = 1 AND [GIRISTUTAR] IS NULL) OR ([GIRISTUTAR] = @Original_GIRISTUTAR)) AND ((@IsNull_CIKISTUTAR = 1 AND [CIKISTUTAR] IS NULL) OR ([CIKISTUTAR] = @Original_CIKISTUTAR)) AND ((@IsNull_KDVORAN = 1 AND [KDVORAN] IS NULL) OR ([KDVORAN] = @Original_KDVORAN)) AND ((@IsNull_KDVTUTAR = 1 AND [KDVTUTAR] IS NULL) OR ([KDVTUTAR] = @Original_KDVTUTAR)) AND ((@IsNull_SATIRTUTAR = 1 AND [SATIRTUTAR] IS NULL) OR ([SATIRTUTAR] = @Original_SATIRTUTAR)) AND ((@IsNull_GCKOD = 1 AND [GCKOD] IS NULL) OR ([GCKOD] = @Original_GCKOD)) AND ((@IsNull_DEPOID = 1 AND [DEPOID] IS NULL) OR ([DEPOID] = @Original_DEPOID)) AND ((@IsNull_MALZMARKAID = 1 AND [MALZMARKAID] IS NULL) OR ([MALZMARKAID] = @Original_MALZMARKAID)) AND ((@IsNull_MALZSERINO = 1 AND [MALZSERINO] IS NULL) OR ([MALZSERINO] = @Original_MALZSERINO)) AND ((@IsNull_MALZURTTARIH = 1 AND [MALZURTTARIH] IS NULL) OR ([MALZURTTARIH] = @Original_MALZURTTARIH)) AND ((@IsNull_DEGISIMKMSI = 1 AND [DEGISIMKMSI] IS NULL) OR ([DEGISIMKMSI] = @Original_DEGISIMKMSI)) AND ((@IsNull_SONRAKIDEGKM = 1 AND [SONRAKIDEGKM] IS NULL) OR ([SONRAKIDEGKM] = @Original_SONRAKIDEGKM)))";
      this._adapter.DeleteCommand.CommandType = CommandType.Text;
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_DEPOFISID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DEPOFISID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_DEPOFISID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DEPOFISID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_MALZEMEID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZEMEID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_MALZEMEID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZEMEID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_MALZACIKLAMA", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZACIKLAMA", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_MALZACIKLAMA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZACIKLAMA", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_BIRIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BIRIMID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_BIRIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BIRIMID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_MIKTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MIKTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_MIKTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "MIKTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_GIRISMIKTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GIRISMIKTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_GIRISMIKTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "GIRISMIKTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_CIKISMIKTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISMIKTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_CIKISMIKTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "CIKISMIKTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_FIYAT", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIYAT", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_FIYAT", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "FIYAT", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TUTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TUTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "TUTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_GIRISTUTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GIRISTUTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_GIRISTUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "GIRISTUTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_CIKISTUTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISTUTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_CIKISTUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "CIKISTUTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_KDVORAN", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KDVORAN", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_KDVORAN", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "KDVORAN", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_KDVTUTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KDVTUTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_KDVTUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "KDVTUTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SATIRTUTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SATIRTUTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SATIRTUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "SATIRTUTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_GCKOD", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GCKOD", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_GCKOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GCKOD", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_DEPOID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DEPOID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_DEPOID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DEPOID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_MALZMARKAID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZMARKAID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_MALZMARKAID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZMARKAID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_MALZSERINO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZSERINO", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_MALZSERINO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZSERINO", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_MALZURTTARIH", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZURTTARIH", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_MALZURTTARIH", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZURTTARIH", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_DEGISIMKMSI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DEGISIMKMSI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_DEGISIMKMSI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DEGISIMKMSI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SONRAKIDEGKM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SONRAKIDEGKM", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SONRAKIDEGKM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SONRAKIDEGKM", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.InsertCommand = new SqlCommand();
      this._adapter.InsertCommand.Connection = this.Connection;
      this._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[TBLDEPOFISHRKT] ([DEPOFISID], [MALZEMEID], [MALZACIKLAMA], [BIRIMID], [MIKTAR], [GIRISMIKTAR], [CIKISMIKTAR], [FIYAT], [TUTAR], [GIRISTUTAR], [CIKISTUTAR], [KDVORAN], [KDVTUTAR], [SATIRTUTAR], [GCKOD], [DEPOID], [MALZMARKAID], [MALZSERINO], [MALZURTTARIH], [DEGISIMKMSI], [SONRAKIDEGKM]) VALUES (@DEPOFISID, @MALZEMEID, @MALZACIKLAMA, @BIRIMID, @MIKTAR, @GIRISMIKTAR, @CIKISMIKTAR, @FIYAT, @TUTAR, @GIRISTUTAR, @CIKISTUTAR, @KDVORAN, @KDVTUTAR, @SATIRTUTAR, @GCKOD, @DEPOID, @MALZMARKAID, @MALZSERINO, @MALZURTTARIH, @DEGISIMKMSI, @SONRAKIDEGKM);\r\nSELECT ID, DEPOFISID, MALZEMEID, MALZACIKLAMA, BIRIMID, MIKTAR, GIRISMIKTAR, CIKISMIKTAR, FIYAT, TUTAR, GIRISTUTAR, CIKISTUTAR, KDVORAN, KDVTUTAR, SATIRTUTAR, GCKOD, DEPOID, MALZMARKAID, MALZSERINO, MALZURTTARIH, DEGISIMKMSI, SONRAKIDEGKM FROM TBLDEPOFISHRKT WHERE (ID = SCOPE_IDENTITY())";
      this._adapter.InsertCommand.CommandType = CommandType.Text;
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@DEPOFISID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DEPOFISID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@MALZEMEID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZEMEID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@MALZACIKLAMA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZACIKLAMA", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@BIRIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BIRIMID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@MIKTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "MIKTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@GIRISMIKTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "GIRISMIKTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@CIKISMIKTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "CIKISMIKTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@FIYAT", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "FIYAT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@TUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "TUTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@GIRISTUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "GIRISTUTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@CIKISTUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "CIKISTUTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@KDVORAN", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "KDVORAN", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@KDVTUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "KDVTUTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SATIRTUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "SATIRTUTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@GCKOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GCKOD", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@DEPOID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DEPOID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@MALZMARKAID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZMARKAID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@MALZSERINO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZSERINO", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@MALZURTTARIH", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZURTTARIH", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@DEGISIMKMSI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DEGISIMKMSI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SONRAKIDEGKM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SONRAKIDEGKM", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand = new SqlCommand();
      this._adapter.UpdateCommand.Connection = this.Connection;
      this._adapter.UpdateCommand.CommandText = "UPDATE [dbo].[TBLDEPOFISHRKT] SET [DEPOFISID] = @DEPOFISID, [MALZEMEID] = @MALZEMEID, [MALZACIKLAMA] = @MALZACIKLAMA, [BIRIMID] = @BIRIMID, [MIKTAR] = @MIKTAR, [GIRISMIKTAR] = @GIRISMIKTAR, [CIKISMIKTAR] = @CIKISMIKTAR, [FIYAT] = @FIYAT, [TUTAR] = @TUTAR, [GIRISTUTAR] = @GIRISTUTAR, [CIKISTUTAR] = @CIKISTUTAR, [KDVORAN] = @KDVORAN, [KDVTUTAR] = @KDVTUTAR, [SATIRTUTAR] = @SATIRTUTAR, [GCKOD] = @GCKOD, [DEPOID] = @DEPOID, [MALZMARKAID] = @MALZMARKAID, [MALZSERINO] = @MALZSERINO, [MALZURTTARIH] = @MALZURTTARIH, [DEGISIMKMSI] = @DEGISIMKMSI, [SONRAKIDEGKM] = @SONRAKIDEGKM WHERE (([ID] = @Original_ID) AND ((@IsNull_DEPOFISID = 1 AND [DEPOFISID] IS NULL) OR ([DEPOFISID] = @Original_DEPOFISID)) AND ((@IsNull_MALZEMEID = 1 AND [MALZEMEID] IS NULL) OR ([MALZEMEID] = @Original_MALZEMEID)) AND ((@IsNull_MALZACIKLAMA = 1 AND [MALZACIKLAMA] IS NULL) OR ([MALZACIKLAMA] = @Original_MALZACIKLAMA)) AND ((@IsNull_BIRIMID = 1 AND [BIRIMID] IS NULL) OR ([BIRIMID] = @Original_BIRIMID)) AND ((@IsNull_MIKTAR = 1 AND [MIKTAR] IS NULL) OR ([MIKTAR] = @Original_MIKTAR)) AND ((@IsNull_GIRISMIKTAR = 1 AND [GIRISMIKTAR] IS NULL) OR ([GIRISMIKTAR] = @Original_GIRISMIKTAR)) AND ((@IsNull_CIKISMIKTAR = 1 AND [CIKISMIKTAR] IS NULL) OR ([CIKISMIKTAR] = @Original_CIKISMIKTAR)) AND ((@IsNull_FIYAT = 1 AND [FIYAT] IS NULL) OR ([FIYAT] = @Original_FIYAT)) AND ((@IsNull_TUTAR = 1 AND [TUTAR] IS NULL) OR ([TUTAR] = @Original_TUTAR)) AND ((@IsNull_GIRISTUTAR = 1 AND [GIRISTUTAR] IS NULL) OR ([GIRISTUTAR] = @Original_GIRISTUTAR)) AND ((@IsNull_CIKISTUTAR = 1 AND [CIKISTUTAR] IS NULL) OR ([CIKISTUTAR] = @Original_CIKISTUTAR)) AND ((@IsNull_KDVORAN = 1 AND [KDVORAN] IS NULL) OR ([KDVORAN] = @Original_KDVORAN)) AND ((@IsNull_KDVTUTAR = 1 AND [KDVTUTAR] IS NULL) OR ([KDVTUTAR] = @Original_KDVTUTAR)) AND ((@IsNull_SATIRTUTAR = 1 AND [SATIRTUTAR] IS NULL) OR ([SATIRTUTAR] = @Original_SATIRTUTAR)) AND ((@IsNull_GCKOD = 1 AND [GCKOD] IS NULL) OR ([GCKOD] = @Original_GCKOD)) AND ((@IsNull_DEPOID = 1 AND [DEPOID] IS NULL) OR ([DEPOID] = @Original_DEPOID)) AND ((@IsNull_MALZMARKAID = 1 AND [MALZMARKAID] IS NULL) OR ([MALZMARKAID] = @Original_MALZMARKAID)) AND ((@IsNull_MALZSERINO = 1 AND [MALZSERINO] IS NULL) OR ([MALZSERINO] = @Original_MALZSERINO)) AND ((@IsNull_MALZURTTARIH = 1 AND [MALZURTTARIH] IS NULL) OR ([MALZURTTARIH] = @Original_MALZURTTARIH)) AND ((@IsNull_DEGISIMKMSI = 1 AND [DEGISIMKMSI] IS NULL) OR ([DEGISIMKMSI] = @Original_DEGISIMKMSI)) AND ((@IsNull_SONRAKIDEGKM = 1 AND [SONRAKIDEGKM] IS NULL) OR ([SONRAKIDEGKM] = @Original_SONRAKIDEGKM)));\r\nSELECT ID, DEPOFISID, MALZEMEID, MALZACIKLAMA, BIRIMID, MIKTAR, GIRISMIKTAR, CIKISMIKTAR, FIYAT, TUTAR, GIRISTUTAR, CIKISTUTAR, KDVORAN, KDVTUTAR, SATIRTUTAR, GCKOD, DEPOID, MALZMARKAID, MALZSERINO, MALZURTTARIH, DEGISIMKMSI, SONRAKIDEGKM FROM TBLDEPOFISHRKT WHERE (ID = @ID)";
      this._adapter.UpdateCommand.CommandType = CommandType.Text;
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@DEPOFISID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DEPOFISID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MALZEMEID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZEMEID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MALZACIKLAMA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZACIKLAMA", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@BIRIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BIRIMID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MIKTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "MIKTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@GIRISMIKTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "GIRISMIKTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@CIKISMIKTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "CIKISMIKTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@FIYAT", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "FIYAT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "TUTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@GIRISTUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "GIRISTUTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@CIKISTUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "CIKISTUTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@KDVORAN", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "KDVORAN", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@KDVTUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "KDVTUTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SATIRTUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "SATIRTUTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@GCKOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GCKOD", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@DEPOID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DEPOID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MALZMARKAID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZMARKAID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MALZSERINO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZSERINO", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MALZURTTARIH", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZURTTARIH", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@DEGISIMKMSI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DEGISIMKMSI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SONRAKIDEGKM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SONRAKIDEGKM", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_DEPOFISID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DEPOFISID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_DEPOFISID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DEPOFISID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_MALZEMEID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZEMEID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_MALZEMEID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZEMEID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_MALZACIKLAMA", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZACIKLAMA", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_MALZACIKLAMA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZACIKLAMA", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_BIRIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BIRIMID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_BIRIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BIRIMID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_MIKTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MIKTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_MIKTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "MIKTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_GIRISMIKTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GIRISMIKTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_GIRISMIKTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "GIRISMIKTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_CIKISMIKTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISMIKTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_CIKISMIKTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "CIKISMIKTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_FIYAT", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIYAT", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_FIYAT", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "FIYAT", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TUTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TUTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "TUTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_GIRISTUTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GIRISTUTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_GIRISTUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "GIRISTUTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_CIKISTUTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISTUTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_CIKISTUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "CIKISTUTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_KDVORAN", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KDVORAN", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_KDVORAN", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "KDVORAN", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_KDVTUTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KDVTUTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_KDVTUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "KDVTUTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SATIRTUTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SATIRTUTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SATIRTUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "SATIRTUTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_GCKOD", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GCKOD", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_GCKOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GCKOD", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_DEPOID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DEPOID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_DEPOID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DEPOID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_MALZMARKAID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZMARKAID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_MALZMARKAID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZMARKAID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_MALZSERINO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZSERINO", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_MALZSERINO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZSERINO", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_MALZURTTARIH", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZURTTARIH", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_MALZURTTARIH", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZURTTARIH", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_DEGISIMKMSI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DEGISIMKMSI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_DEGISIMKMSI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DEGISIMKMSI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SONRAKIDEGKM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SONRAKIDEGKM", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SONRAKIDEGKM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SONRAKIDEGKM", DataRowVersion.Original, false, (object) null, "", "", ""));
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
      this._commandCollection[0].CommandText = "SELECT ID, DEPOFISID, MALZEMEID, MALZACIKLAMA, BIRIMID, MIKTAR, GIRISMIKTAR, CIKISMIKTAR, FIYAT, TUTAR, GIRISTUTAR, CIKISTUTAR, KDVORAN, KDVTUTAR, SATIRTUTAR, GCKOD, DEPOID, MALZMARKAID, MALZSERINO, MALZURTTARIH, DEGISIMKMSI, SONRAKIDEGKM FROM dbo.TBLDEPOFISHRKT";
      this._commandCollection[0].CommandType = CommandType.Text;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    public virtual int Fill(bellDataSet8.TBLDEPOFISHRKTDataTable dataTable)
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
    public virtual bellDataSet8.TBLDEPOFISHRKTDataTable GetData()
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      bellDataSet8.TBLDEPOFISHRKTDataTable data = new bellDataSet8.TBLDEPOFISHRKTDataTable();
      this.Adapter.Fill((DataTable) data);
      return data;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(bellDataSet8.TBLDEPOFISHRKTDataTable dataTable) => this.Adapter.Update((DataTable) dataTable);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(bellDataSet8 dataSet) => this.Adapter.Update((DataSet) dataSet, "TBLDEPOFISHRKT");

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
      int? Original_DEPOFISID,
      int? Original_MALZEMEID,
      string Original_MALZACIKLAMA,
      int? Original_BIRIMID,
      Decimal? Original_MIKTAR,
      Decimal? Original_GIRISMIKTAR,
      Decimal? Original_CIKISMIKTAR,
      Decimal? Original_FIYAT,
      Decimal? Original_TUTAR,
      Decimal? Original_GIRISTUTAR,
      Decimal? Original_CIKISTUTAR,
      Decimal? Original_KDVORAN,
      Decimal? Original_KDVTUTAR,
      Decimal? Original_SATIRTUTAR,
      string Original_GCKOD,
      int? Original_DEPOID,
      int? Original_MALZMARKAID,
      string Original_MALZSERINO,
      string Original_MALZURTTARIH,
      string Original_DEGISIMKMSI,
      string Original_SONRAKIDEGKM)
    {
      this.Adapter.DeleteCommand.Parameters[0].Value = (object) Original_ID;
      if (Original_DEPOFISID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[1].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[2].Value = (object) Original_DEPOFISID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[1].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[2].Value = (object) DBNull.Value;
      }
      if (Original_MALZEMEID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[3].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[4].Value = (object) Original_MALZEMEID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[3].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[4].Value = (object) DBNull.Value;
      }
      if (Original_MALZACIKLAMA == null)
      {
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[6].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[6].Value = (object) Original_MALZACIKLAMA;
      }
      if (Original_BIRIMID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[7].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[8].Value = (object) Original_BIRIMID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[7].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[8].Value = (object) DBNull.Value;
      }
      if (Original_MIKTAR.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) Original_MIKTAR.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) DBNull.Value;
      }
      if (Original_GIRISMIKTAR.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[11].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[12].Value = (object) Original_GIRISMIKTAR.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[11].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[12].Value = (object) DBNull.Value;
      }
      if (Original_CIKISMIKTAR.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[13].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[14].Value = (object) Original_CIKISMIKTAR.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[13].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[14].Value = (object) DBNull.Value;
      }
      if (Original_FIYAT.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[15].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[16].Value = (object) Original_FIYAT.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[15].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[16].Value = (object) DBNull.Value;
      }
      if (Original_TUTAR.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[17].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[18].Value = (object) Original_TUTAR.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[17].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[18].Value = (object) DBNull.Value;
      }
      if (Original_GIRISTUTAR.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[19].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[20].Value = (object) Original_GIRISTUTAR.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[19].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[20].Value = (object) DBNull.Value;
      }
      if (Original_CIKISTUTAR.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[21].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[22].Value = (object) Original_CIKISTUTAR.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[21].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[22].Value = (object) DBNull.Value;
      }
      if (Original_KDVORAN.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[23].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[24].Value = (object) Original_KDVORAN.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[23].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[24].Value = (object) DBNull.Value;
      }
      if (Original_KDVTUTAR.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[25].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[26].Value = (object) Original_KDVTUTAR.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[25].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[26].Value = (object) DBNull.Value;
      }
      if (Original_SATIRTUTAR.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[27].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[28].Value = (object) Original_SATIRTUTAR.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[27].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[28].Value = (object) DBNull.Value;
      }
      if (Original_GCKOD == null)
      {
        this.Adapter.DeleteCommand.Parameters[29].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[30].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[29].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[30].Value = (object) Original_GCKOD;
      }
      if (Original_DEPOID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[31].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[32].Value = (object) Original_DEPOID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[31].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[32].Value = (object) DBNull.Value;
      }
      if (Original_MALZMARKAID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[33].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[34].Value = (object) Original_MALZMARKAID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[33].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[34].Value = (object) DBNull.Value;
      }
      if (Original_MALZSERINO == null)
      {
        this.Adapter.DeleteCommand.Parameters[35].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[36].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[35].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[36].Value = (object) Original_MALZSERINO;
      }
      if (Original_MALZURTTARIH == null)
      {
        this.Adapter.DeleteCommand.Parameters[37].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[38].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[37].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[38].Value = (object) Original_MALZURTTARIH;
      }
      if (Original_DEGISIMKMSI == null)
      {
        this.Adapter.DeleteCommand.Parameters[39].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[40].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[39].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[40].Value = (object) Original_DEGISIMKMSI;
      }
      if (Original_SONRAKIDEGKM == null)
      {
        this.Adapter.DeleteCommand.Parameters[41].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[42].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[41].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[42].Value = (object) Original_SONRAKIDEGKM;
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
      int? DEPOFISID,
      int? MALZEMEID,
      string MALZACIKLAMA,
      int? BIRIMID,
      Decimal? MIKTAR,
      Decimal? GIRISMIKTAR,
      Decimal? CIKISMIKTAR,
      Decimal? FIYAT,
      Decimal? TUTAR,
      Decimal? GIRISTUTAR,
      Decimal? CIKISTUTAR,
      Decimal? KDVORAN,
      Decimal? KDVTUTAR,
      Decimal? SATIRTUTAR,
      string GCKOD,
      int? DEPOID,
      int? MALZMARKAID,
      string MALZSERINO,
      string MALZURTTARIH,
      string DEGISIMKMSI,
      string SONRAKIDEGKM)
    {
      if (DEPOFISID.HasValue)
        this.Adapter.InsertCommand.Parameters[0].Value = (object) DEPOFISID.Value;
      else
        this.Adapter.InsertCommand.Parameters[0].Value = (object) DBNull.Value;
      if (MALZEMEID.HasValue)
        this.Adapter.InsertCommand.Parameters[1].Value = (object) MALZEMEID.Value;
      else
        this.Adapter.InsertCommand.Parameters[1].Value = (object) DBNull.Value;
      if (MALZACIKLAMA == null)
        this.Adapter.InsertCommand.Parameters[2].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[2].Value = (object) MALZACIKLAMA;
      if (BIRIMID.HasValue)
        this.Adapter.InsertCommand.Parameters[3].Value = (object) BIRIMID.Value;
      else
        this.Adapter.InsertCommand.Parameters[3].Value = (object) DBNull.Value;
      if (MIKTAR.HasValue)
        this.Adapter.InsertCommand.Parameters[4].Value = (object) MIKTAR.Value;
      else
        this.Adapter.InsertCommand.Parameters[4].Value = (object) DBNull.Value;
      if (GIRISMIKTAR.HasValue)
        this.Adapter.InsertCommand.Parameters[5].Value = (object) GIRISMIKTAR.Value;
      else
        this.Adapter.InsertCommand.Parameters[5].Value = (object) DBNull.Value;
      if (CIKISMIKTAR.HasValue)
        this.Adapter.InsertCommand.Parameters[6].Value = (object) CIKISMIKTAR.Value;
      else
        this.Adapter.InsertCommand.Parameters[6].Value = (object) DBNull.Value;
      if (FIYAT.HasValue)
        this.Adapter.InsertCommand.Parameters[7].Value = (object) FIYAT.Value;
      else
        this.Adapter.InsertCommand.Parameters[7].Value = (object) DBNull.Value;
      if (TUTAR.HasValue)
        this.Adapter.InsertCommand.Parameters[8].Value = (object) TUTAR.Value;
      else
        this.Adapter.InsertCommand.Parameters[8].Value = (object) DBNull.Value;
      if (GIRISTUTAR.HasValue)
        this.Adapter.InsertCommand.Parameters[9].Value = (object) GIRISTUTAR.Value;
      else
        this.Adapter.InsertCommand.Parameters[9].Value = (object) DBNull.Value;
      if (CIKISTUTAR.HasValue)
        this.Adapter.InsertCommand.Parameters[10].Value = (object) CIKISTUTAR.Value;
      else
        this.Adapter.InsertCommand.Parameters[10].Value = (object) DBNull.Value;
      if (KDVORAN.HasValue)
        this.Adapter.InsertCommand.Parameters[11].Value = (object) KDVORAN.Value;
      else
        this.Adapter.InsertCommand.Parameters[11].Value = (object) DBNull.Value;
      if (KDVTUTAR.HasValue)
        this.Adapter.InsertCommand.Parameters[12].Value = (object) KDVTUTAR.Value;
      else
        this.Adapter.InsertCommand.Parameters[12].Value = (object) DBNull.Value;
      if (SATIRTUTAR.HasValue)
        this.Adapter.InsertCommand.Parameters[13].Value = (object) SATIRTUTAR.Value;
      else
        this.Adapter.InsertCommand.Parameters[13].Value = (object) DBNull.Value;
      if (GCKOD == null)
        this.Adapter.InsertCommand.Parameters[14].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[14].Value = (object) GCKOD;
      if (DEPOID.HasValue)
        this.Adapter.InsertCommand.Parameters[15].Value = (object) DEPOID.Value;
      else
        this.Adapter.InsertCommand.Parameters[15].Value = (object) DBNull.Value;
      if (MALZMARKAID.HasValue)
        this.Adapter.InsertCommand.Parameters[16].Value = (object) MALZMARKAID.Value;
      else
        this.Adapter.InsertCommand.Parameters[16].Value = (object) DBNull.Value;
      if (MALZSERINO == null)
        this.Adapter.InsertCommand.Parameters[17].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[17].Value = (object) MALZSERINO;
      if (MALZURTTARIH == null)
        this.Adapter.InsertCommand.Parameters[18].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[18].Value = (object) MALZURTTARIH;
      if (DEGISIMKMSI == null)
        this.Adapter.InsertCommand.Parameters[19].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[19].Value = (object) DEGISIMKMSI;
      if (SONRAKIDEGKM == null)
        this.Adapter.InsertCommand.Parameters[20].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[20].Value = (object) SONRAKIDEGKM;
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
      int? DEPOFISID,
      int? MALZEMEID,
      string MALZACIKLAMA,
      int? BIRIMID,
      Decimal? MIKTAR,
      Decimal? GIRISMIKTAR,
      Decimal? CIKISMIKTAR,
      Decimal? FIYAT,
      Decimal? TUTAR,
      Decimal? GIRISTUTAR,
      Decimal? CIKISTUTAR,
      Decimal? KDVORAN,
      Decimal? KDVTUTAR,
      Decimal? SATIRTUTAR,
      string GCKOD,
      int? DEPOID,
      int? MALZMARKAID,
      string MALZSERINO,
      string MALZURTTARIH,
      string DEGISIMKMSI,
      string SONRAKIDEGKM,
      int Original_ID,
      int? Original_DEPOFISID,
      int? Original_MALZEMEID,
      string Original_MALZACIKLAMA,
      int? Original_BIRIMID,
      Decimal? Original_MIKTAR,
      Decimal? Original_GIRISMIKTAR,
      Decimal? Original_CIKISMIKTAR,
      Decimal? Original_FIYAT,
      Decimal? Original_TUTAR,
      Decimal? Original_GIRISTUTAR,
      Decimal? Original_CIKISTUTAR,
      Decimal? Original_KDVORAN,
      Decimal? Original_KDVTUTAR,
      Decimal? Original_SATIRTUTAR,
      string Original_GCKOD,
      int? Original_DEPOID,
      int? Original_MALZMARKAID,
      string Original_MALZSERINO,
      string Original_MALZURTTARIH,
      string Original_DEGISIMKMSI,
      string Original_SONRAKIDEGKM,
      int ID)
    {
      if (DEPOFISID.HasValue)
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) DEPOFISID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) DBNull.Value;
      if (MALZEMEID.HasValue)
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) MALZEMEID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) DBNull.Value;
      if (MALZACIKLAMA == null)
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) MALZACIKLAMA;
      if (BIRIMID.HasValue)
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) BIRIMID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) DBNull.Value;
      if (MIKTAR.HasValue)
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) MIKTAR.Value;
      else
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) DBNull.Value;
      if (GIRISMIKTAR.HasValue)
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) GIRISMIKTAR.Value;
      else
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) DBNull.Value;
      if (CIKISMIKTAR.HasValue)
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) CIKISMIKTAR.Value;
      else
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) DBNull.Value;
      if (FIYAT.HasValue)
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) FIYAT.Value;
      else
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) DBNull.Value;
      if (TUTAR.HasValue)
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) TUTAR.Value;
      else
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) DBNull.Value;
      if (GIRISTUTAR.HasValue)
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) GIRISTUTAR.Value;
      else
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) DBNull.Value;
      if (CIKISTUTAR.HasValue)
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) CIKISTUTAR.Value;
      else
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) DBNull.Value;
      if (KDVORAN.HasValue)
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) KDVORAN.Value;
      else
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) DBNull.Value;
      if (KDVTUTAR.HasValue)
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) KDVTUTAR.Value;
      else
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) DBNull.Value;
      if (SATIRTUTAR.HasValue)
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) SATIRTUTAR.Value;
      else
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) DBNull.Value;
      if (GCKOD == null)
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) GCKOD;
      if (DEPOID.HasValue)
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) DEPOID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) DBNull.Value;
      if (MALZMARKAID.HasValue)
        this.Adapter.UpdateCommand.Parameters[16].Value = (object) MALZMARKAID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[16].Value = (object) DBNull.Value;
      if (MALZSERINO == null)
        this.Adapter.UpdateCommand.Parameters[17].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[17].Value = (object) MALZSERINO;
      if (MALZURTTARIH == null)
        this.Adapter.UpdateCommand.Parameters[18].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[18].Value = (object) MALZURTTARIH;
      if (DEGISIMKMSI == null)
        this.Adapter.UpdateCommand.Parameters[19].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[19].Value = (object) DEGISIMKMSI;
      if (SONRAKIDEGKM == null)
        this.Adapter.UpdateCommand.Parameters[20].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[20].Value = (object) SONRAKIDEGKM;
      this.Adapter.UpdateCommand.Parameters[21].Value = (object) Original_ID;
      if (Original_DEPOFISID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[22].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[23].Value = (object) Original_DEPOFISID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[22].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[23].Value = (object) DBNull.Value;
      }
      if (Original_MALZEMEID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[24].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[25].Value = (object) Original_MALZEMEID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[24].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[25].Value = (object) DBNull.Value;
      }
      if (Original_MALZACIKLAMA == null)
      {
        this.Adapter.UpdateCommand.Parameters[26].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[27].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[26].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[27].Value = (object) Original_MALZACIKLAMA;
      }
      if (Original_BIRIMID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[28].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[29].Value = (object) Original_BIRIMID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[28].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[29].Value = (object) DBNull.Value;
      }
      if (Original_MIKTAR.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[30].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[31].Value = (object) Original_MIKTAR.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[30].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[31].Value = (object) DBNull.Value;
      }
      if (Original_GIRISMIKTAR.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[32].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[33].Value = (object) Original_GIRISMIKTAR.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[32].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[33].Value = (object) DBNull.Value;
      }
      if (Original_CIKISMIKTAR.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[34].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[35].Value = (object) Original_CIKISMIKTAR.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[34].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[35].Value = (object) DBNull.Value;
      }
      if (Original_FIYAT.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[36].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[37].Value = (object) Original_FIYAT.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[36].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[37].Value = (object) DBNull.Value;
      }
      if (Original_TUTAR.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[38].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[39].Value = (object) Original_TUTAR.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[38].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[39].Value = (object) DBNull.Value;
      }
      if (Original_GIRISTUTAR.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[40].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[41].Value = (object) Original_GIRISTUTAR.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[40].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[41].Value = (object) DBNull.Value;
      }
      if (Original_CIKISTUTAR.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[42].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[43].Value = (object) Original_CIKISTUTAR.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[42].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[43].Value = (object) DBNull.Value;
      }
      if (Original_KDVORAN.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[44].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[45].Value = (object) Original_KDVORAN.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[44].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[45].Value = (object) DBNull.Value;
      }
      if (Original_KDVTUTAR.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[46].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[47].Value = (object) Original_KDVTUTAR.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[46].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[47].Value = (object) DBNull.Value;
      }
      if (Original_SATIRTUTAR.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[48].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[49].Value = (object) Original_SATIRTUTAR.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[48].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[49].Value = (object) DBNull.Value;
      }
      if (Original_GCKOD == null)
      {
        this.Adapter.UpdateCommand.Parameters[50].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[51].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[50].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[51].Value = (object) Original_GCKOD;
      }
      if (Original_DEPOID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[52].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[53].Value = (object) Original_DEPOID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[52].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[53].Value = (object) DBNull.Value;
      }
      if (Original_MALZMARKAID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[54].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[55].Value = (object) Original_MALZMARKAID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[54].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[55].Value = (object) DBNull.Value;
      }
      if (Original_MALZSERINO == null)
      {
        this.Adapter.UpdateCommand.Parameters[56].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[57].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[56].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[57].Value = (object) Original_MALZSERINO;
      }
      if (Original_MALZURTTARIH == null)
      {
        this.Adapter.UpdateCommand.Parameters[58].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[59].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[58].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[59].Value = (object) Original_MALZURTTARIH;
      }
      if (Original_DEGISIMKMSI == null)
      {
        this.Adapter.UpdateCommand.Parameters[60].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[61].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[60].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[61].Value = (object) Original_DEGISIMKMSI;
      }
      if (Original_SONRAKIDEGKM == null)
      {
        this.Adapter.UpdateCommand.Parameters[62].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[63].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[62].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[63].Value = (object) Original_SONRAKIDEGKM;
      }
      this.Adapter.UpdateCommand.Parameters[64].Value = (object) ID;
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
      int? DEPOFISID,
      int? MALZEMEID,
      string MALZACIKLAMA,
      int? BIRIMID,
      Decimal? MIKTAR,
      Decimal? GIRISMIKTAR,
      Decimal? CIKISMIKTAR,
      Decimal? FIYAT,
      Decimal? TUTAR,
      Decimal? GIRISTUTAR,
      Decimal? CIKISTUTAR,
      Decimal? KDVORAN,
      Decimal? KDVTUTAR,
      Decimal? SATIRTUTAR,
      string GCKOD,
      int? DEPOID,
      int? MALZMARKAID,
      string MALZSERINO,
      string MALZURTTARIH,
      string DEGISIMKMSI,
      string SONRAKIDEGKM,
      int Original_ID,
      int? Original_DEPOFISID,
      int? Original_MALZEMEID,
      string Original_MALZACIKLAMA,
      int? Original_BIRIMID,
      Decimal? Original_MIKTAR,
      Decimal? Original_GIRISMIKTAR,
      Decimal? Original_CIKISMIKTAR,
      Decimal? Original_FIYAT,
      Decimal? Original_TUTAR,
      Decimal? Original_GIRISTUTAR,
      Decimal? Original_CIKISTUTAR,
      Decimal? Original_KDVORAN,
      Decimal? Original_KDVTUTAR,
      Decimal? Original_SATIRTUTAR,
      string Original_GCKOD,
      int? Original_DEPOID,
      int? Original_MALZMARKAID,
      string Original_MALZSERINO,
      string Original_MALZURTTARIH,
      string Original_DEGISIMKMSI,
      string Original_SONRAKIDEGKM)
    {
      return this.Update(DEPOFISID, MALZEMEID, MALZACIKLAMA, BIRIMID, MIKTAR, GIRISMIKTAR, CIKISMIKTAR, FIYAT, TUTAR, GIRISTUTAR, CIKISTUTAR, KDVORAN, KDVTUTAR, SATIRTUTAR, GCKOD, DEPOID, MALZMARKAID, MALZSERINO, MALZURTTARIH, DEGISIMKMSI, SONRAKIDEGKM, Original_ID, Original_DEPOFISID, Original_MALZEMEID, Original_MALZACIKLAMA, Original_BIRIMID, Original_MIKTAR, Original_GIRISMIKTAR, Original_CIKISMIKTAR, Original_FIYAT, Original_TUTAR, Original_GIRISTUTAR, Original_CIKISTUTAR, Original_KDVORAN, Original_KDVTUTAR, Original_SATIRTUTAR, Original_GCKOD, Original_DEPOID, Original_MALZMARKAID, Original_MALZSERINO, Original_MALZURTTARIH, Original_DEGISIMKMSI, Original_SONRAKIDEGKM, Original_ID);
    }
  }
}
