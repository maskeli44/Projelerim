// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.bellDataSet7TableAdapters.TBLDEPOFISTableAdapter
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
  public class TBLDEPOFISTableAdapter : Component
  {
    private SqlDataAdapter _adapter;
    private SqlConnection _connection;
    private SqlTransaction _transaction;
    private SqlCommand[] _commandCollection;
    private bool _clearBeforeFill;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public TBLDEPOFISTableAdapter() => this.ClearBeforeFill = true;

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
        DataSetTable = "TBLDEPOFIS",
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
            "ISEMRIID",
            "ISEMRIID"
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
            "FISNO",
            "FISNO"
          },
          {
            "ALANUSTAID",
            "ALANUSTAID"
          },
          {
            "FIRMAID",
            "FIRMAID"
          },
          {
            "ISLEMTIPIID",
            "ISLEMTIPIID"
          },
          {
            "TOPTUTAR",
            "TOPTUTAR"
          },
          {
            "TOPKDVTUTAR",
            "TOPKDVTUTAR"
          },
          {
            "FISTUTAR",
            "FISTUTAR"
          },
          {
            "GCKOD",
            "GCKOD"
          },
          {
            "TRANSFERID",
            "TRANSFERID"
          },
          {
            "TRANSDEPOGCID",
            "TRANSDEPOGCID"
          },
          {
            "IMZADEPOYETKILIID",
            "IMZADEPOYETKILIID"
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
            "TALEPFISID",
            "TALEPFISID"
          },
          {
            "GIRISICIKISYAPID",
            "GIRISICIKISYAPID"
          }
        }
      });
      this._adapter.DeleteCommand = new SqlCommand();
      this._adapter.DeleteCommand.Connection = this.Connection;
      this._adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[TBLDEPOFIS] WHERE (([ID] = @Original_ID) AND ((@IsNull_KOD = 1 AND [KOD] IS NULL) OR ([KOD] = @Original_KOD)) AND ((@IsNull_ISEMRIID = 1 AND [ISEMRIID] IS NULL) OR ([ISEMRIID] = @Original_ISEMRIID)) AND ((@IsNull_TARIH = 1 AND [TARIH] IS NULL) OR ([TARIH] = @Original_TARIH)) AND ((@IsNull_SAAT = 1 AND [SAAT] IS NULL) OR ([SAAT] = @Original_SAAT)) AND ((@IsNull_FISNO = 1 AND [FISNO] IS NULL) OR ([FISNO] = @Original_FISNO)) AND ((@IsNull_ALANUSTAID = 1 AND [ALANUSTAID] IS NULL) OR ([ALANUSTAID] = @Original_ALANUSTAID)) AND ((@IsNull_FIRMAID = 1 AND [FIRMAID] IS NULL) OR ([FIRMAID] = @Original_FIRMAID)) AND ((@IsNull_ISLEMTIPIID = 1 AND [ISLEMTIPIID] IS NULL) OR ([ISLEMTIPIID] = @Original_ISLEMTIPIID)) AND ((@IsNull_TOPTUTAR = 1 AND [TOPTUTAR] IS NULL) OR ([TOPTUTAR] = @Original_TOPTUTAR)) AND ((@IsNull_TOPKDVTUTAR = 1 AND [TOPKDVTUTAR] IS NULL) OR ([TOPKDVTUTAR] = @Original_TOPKDVTUTAR)) AND ((@IsNull_FISTUTAR = 1 AND [FISTUTAR] IS NULL) OR ([FISTUTAR] = @Original_FISTUTAR)) AND ((@IsNull_GCKOD = 1 AND [GCKOD] IS NULL) OR ([GCKOD] = @Original_GCKOD)) AND ((@IsNull_TRANSFERID = 1 AND [TRANSFERID] IS NULL) OR ([TRANSFERID] = @Original_TRANSFERID)) AND ((@IsNull_TRANSDEPOGCID = 1 AND [TRANSDEPOGCID] IS NULL) OR ([TRANSDEPOGCID] = @Original_TRANSDEPOGCID)) AND ((@IsNull_IMZADEPOYETKILIID = 1 AND [IMZADEPOYETKILIID] IS NULL) OR ([IMZADEPOYETKILIID] = @Original_IMZADEPOYETKILIID)) AND ((@IsNull_SAVEUSER = 1 AND [SAVEUSER] IS NULL) OR ([SAVEUSER] = @Original_SAVEUSER)) AND ((@IsNull_SAVEDATE = 1 AND [SAVEDATE] IS NULL) OR ([SAVEDATE] = @Original_SAVEDATE)) AND ((@IsNull_EDITUSER = 1 AND [EDITUSER] IS NULL) OR ([EDITUSER] = @Original_EDITUSER)) AND ((@IsNull_EDITDATE = 1 AND [EDITDATE] IS NULL) OR ([EDITDATE] = @Original_EDITDATE)) AND ((@IsNull_SAVEMAC = 1 AND [SAVEMAC] IS NULL) OR ([SAVEMAC] = @Original_SAVEMAC)) AND ((@IsNull_EDITMAC = 1 AND [EDITMAC] IS NULL) OR ([EDITMAC] = @Original_EDITMAC)) AND ((@IsNull_SAVEIP = 1 AND [SAVEIP] IS NULL) OR ([SAVEIP] = @Original_SAVEIP)) AND ((@IsNull_EDITIP = 1 AND [EDITIP] IS NULL) OR ([EDITIP] = @Original_EDITIP)) AND ((@IsNull_TALEPFISID = 1 AND [TALEPFISID] IS NULL) OR ([TALEPFISID] = @Original_TALEPFISID)) AND ((@IsNull_GIRISICIKISYAPID = 1 AND [GIRISICIKISYAPID] IS NULL) OR ([GIRISICIKISYAPID] = @Original_GIRISICIKISYAPID)))";
      this._adapter.DeleteCommand.CommandType = CommandType.Text;
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_KOD", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_KOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ISEMRIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISEMRIID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ISEMRIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISEMRIID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TARIH", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TARIH", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TARIH", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TARIH", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SAAT", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAAT", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SAAT", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAAT", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_FISNO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FISNO", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_FISNO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FISNO", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ALANUSTAID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ALANUSTAID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ALANUSTAID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ALANUSTAID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_FIRMAID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMAID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_FIRMAID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMAID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ISLEMTIPIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISLEMTIPIID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ISLEMTIPIID", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISLEMTIPIID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TOPTUTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TOPTUTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TOPTUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "TOPTUTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TOPKDVTUTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TOPKDVTUTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TOPKDVTUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "TOPKDVTUTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_FISTUTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FISTUTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_FISTUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "FISTUTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_GCKOD", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GCKOD", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_GCKOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GCKOD", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TRANSFERID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TRANSFERID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TRANSFERID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TRANSFERID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TRANSDEPOGCID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TRANSDEPOGCID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TRANSDEPOGCID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TRANSDEPOGCID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_IMZADEPOYETKILIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IMZADEPOYETKILIID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_IMZADEPOYETKILIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IMZADEPOYETKILIID", DataRowVersion.Original, false, (object) null, "", "", ""));
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
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TALEPFISID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TALEPFISID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TALEPFISID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TALEPFISID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_GIRISICIKISYAPID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GIRISICIKISYAPID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_GIRISICIKISYAPID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GIRISICIKISYAPID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.InsertCommand = new SqlCommand();
      this._adapter.InsertCommand.Connection = this.Connection;
      this._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[TBLDEPOFIS] ([KOD], [ISEMRIID], [TARIH], [SAAT], [FISNO], [ALANUSTAID], [FIRMAID], [ISLEMTIPIID], [TOPTUTAR], [TOPKDVTUTAR], [FISTUTAR], [GCKOD], [TRANSFERID], [TRANSDEPOGCID], [IMZADEPOYETKILIID], [SAVEUSER], [SAVEDATE], [EDITUSER], [EDITDATE], [SAVEMAC], [EDITMAC], [SAVEIP], [EDITIP], [TALEPFISID], [GIRISICIKISYAPID]) VALUES (@KOD, @ISEMRIID, @TARIH, @SAAT, @FISNO, @ALANUSTAID, @FIRMAID, @ISLEMTIPIID, @TOPTUTAR, @TOPKDVTUTAR, @FISTUTAR, @GCKOD, @TRANSFERID, @TRANSDEPOGCID, @IMZADEPOYETKILIID, @SAVEUSER, @SAVEDATE, @EDITUSER, @EDITDATE, @SAVEMAC, @EDITMAC, @SAVEIP, @EDITIP, @TALEPFISID, @GIRISICIKISYAPID);\r\nSELECT ID, KOD, ISEMRIID, TARIH, SAAT, FISNO, ALANUSTAID, FIRMAID, ISLEMTIPIID, TOPTUTAR, TOPKDVTUTAR, FISTUTAR, GCKOD, TRANSFERID, TRANSDEPOGCID, IMZADEPOYETKILIID, SAVEUSER, SAVEDATE, EDITUSER, EDITDATE, SAVEMAC, EDITMAC, SAVEIP, EDITIP, TALEPFISID, GIRISICIKISYAPID FROM TBLDEPOFIS WHERE (ID = SCOPE_IDENTITY())";
      this._adapter.InsertCommand.CommandType = CommandType.Text;
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@KOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ISEMRIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISEMRIID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@TARIH", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TARIH", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SAAT", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAAT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@FISNO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FISNO", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ALANUSTAID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ALANUSTAID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@FIRMAID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMAID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ISLEMTIPIID", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISLEMTIPIID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@TOPTUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "TOPTUTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@TOPKDVTUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "TOPKDVTUTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@FISTUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "FISTUTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@GCKOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GCKOD", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@TRANSFERID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TRANSFERID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@TRANSDEPOGCID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TRANSDEPOGCID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@IMZADEPOYETKILIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IMZADEPOYETKILIID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SAVEUSER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEUSER", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SAVEDATE", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEDATE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@EDITUSER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITUSER", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@EDITDATE", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITDATE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SAVEMAC", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEMAC", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@EDITMAC", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITMAC", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SAVEIP", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEIP", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@EDITIP", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITIP", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@TALEPFISID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TALEPFISID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@GIRISICIKISYAPID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GIRISICIKISYAPID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand = new SqlCommand();
      this._adapter.UpdateCommand.Connection = this.Connection;
      this._adapter.UpdateCommand.CommandText = "UPDATE [dbo].[TBLDEPOFIS] SET [KOD] = @KOD, [ISEMRIID] = @ISEMRIID, [TARIH] = @TARIH, [SAAT] = @SAAT, [FISNO] = @FISNO, [ALANUSTAID] = @ALANUSTAID, [FIRMAID] = @FIRMAID, [ISLEMTIPIID] = @ISLEMTIPIID, [TOPTUTAR] = @TOPTUTAR, [TOPKDVTUTAR] = @TOPKDVTUTAR, [FISTUTAR] = @FISTUTAR, [GCKOD] = @GCKOD, [TRANSFERID] = @TRANSFERID, [TRANSDEPOGCID] = @TRANSDEPOGCID, [IMZADEPOYETKILIID] = @IMZADEPOYETKILIID, [SAVEUSER] = @SAVEUSER, [SAVEDATE] = @SAVEDATE, [EDITUSER] = @EDITUSER, [EDITDATE] = @EDITDATE, [SAVEMAC] = @SAVEMAC, [EDITMAC] = @EDITMAC, [SAVEIP] = @SAVEIP, [EDITIP] = @EDITIP, [TALEPFISID] = @TALEPFISID, [GIRISICIKISYAPID] = @GIRISICIKISYAPID WHERE (([ID] = @Original_ID) AND ((@IsNull_KOD = 1 AND [KOD] IS NULL) OR ([KOD] = @Original_KOD)) AND ((@IsNull_ISEMRIID = 1 AND [ISEMRIID] IS NULL) OR ([ISEMRIID] = @Original_ISEMRIID)) AND ((@IsNull_TARIH = 1 AND [TARIH] IS NULL) OR ([TARIH] = @Original_TARIH)) AND ((@IsNull_SAAT = 1 AND [SAAT] IS NULL) OR ([SAAT] = @Original_SAAT)) AND ((@IsNull_FISNO = 1 AND [FISNO] IS NULL) OR ([FISNO] = @Original_FISNO)) AND ((@IsNull_ALANUSTAID = 1 AND [ALANUSTAID] IS NULL) OR ([ALANUSTAID] = @Original_ALANUSTAID)) AND ((@IsNull_FIRMAID = 1 AND [FIRMAID] IS NULL) OR ([FIRMAID] = @Original_FIRMAID)) AND ((@IsNull_ISLEMTIPIID = 1 AND [ISLEMTIPIID] IS NULL) OR ([ISLEMTIPIID] = @Original_ISLEMTIPIID)) AND ((@IsNull_TOPTUTAR = 1 AND [TOPTUTAR] IS NULL) OR ([TOPTUTAR] = @Original_TOPTUTAR)) AND ((@IsNull_TOPKDVTUTAR = 1 AND [TOPKDVTUTAR] IS NULL) OR ([TOPKDVTUTAR] = @Original_TOPKDVTUTAR)) AND ((@IsNull_FISTUTAR = 1 AND [FISTUTAR] IS NULL) OR ([FISTUTAR] = @Original_FISTUTAR)) AND ((@IsNull_GCKOD = 1 AND [GCKOD] IS NULL) OR ([GCKOD] = @Original_GCKOD)) AND ((@IsNull_TRANSFERID = 1 AND [TRANSFERID] IS NULL) OR ([TRANSFERID] = @Original_TRANSFERID)) AND ((@IsNull_TRANSDEPOGCID = 1 AND [TRANSDEPOGCID] IS NULL) OR ([TRANSDEPOGCID] = @Original_TRANSDEPOGCID)) AND ((@IsNull_IMZADEPOYETKILIID = 1 AND [IMZADEPOYETKILIID] IS NULL) OR ([IMZADEPOYETKILIID] = @Original_IMZADEPOYETKILIID)) AND ((@IsNull_SAVEUSER = 1 AND [SAVEUSER] IS NULL) OR ([SAVEUSER] = @Original_SAVEUSER)) AND ((@IsNull_SAVEDATE = 1 AND [SAVEDATE] IS NULL) OR ([SAVEDATE] = @Original_SAVEDATE)) AND ((@IsNull_EDITUSER = 1 AND [EDITUSER] IS NULL) OR ([EDITUSER] = @Original_EDITUSER)) AND ((@IsNull_EDITDATE = 1 AND [EDITDATE] IS NULL) OR ([EDITDATE] = @Original_EDITDATE)) AND ((@IsNull_SAVEMAC = 1 AND [SAVEMAC] IS NULL) OR ([SAVEMAC] = @Original_SAVEMAC)) AND ((@IsNull_EDITMAC = 1 AND [EDITMAC] IS NULL) OR ([EDITMAC] = @Original_EDITMAC)) AND ((@IsNull_SAVEIP = 1 AND [SAVEIP] IS NULL) OR ([SAVEIP] = @Original_SAVEIP)) AND ((@IsNull_EDITIP = 1 AND [EDITIP] IS NULL) OR ([EDITIP] = @Original_EDITIP)) AND ((@IsNull_TALEPFISID = 1 AND [TALEPFISID] IS NULL) OR ([TALEPFISID] = @Original_TALEPFISID)) AND ((@IsNull_GIRISICIKISYAPID = 1 AND [GIRISICIKISYAPID] IS NULL) OR ([GIRISICIKISYAPID] = @Original_GIRISICIKISYAPID)));\r\nSELECT ID, KOD, ISEMRIID, TARIH, SAAT, FISNO, ALANUSTAID, FIRMAID, ISLEMTIPIID, TOPTUTAR, TOPKDVTUTAR, FISTUTAR, GCKOD, TRANSFERID, TRANSDEPOGCID, IMZADEPOYETKILIID, SAVEUSER, SAVEDATE, EDITUSER, EDITDATE, SAVEMAC, EDITMAC, SAVEIP, EDITIP, TALEPFISID, GIRISICIKISYAPID FROM TBLDEPOFIS WHERE (ID = @ID)";
      this._adapter.UpdateCommand.CommandType = CommandType.Text;
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@KOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ISEMRIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISEMRIID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TARIH", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TARIH", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SAAT", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAAT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@FISNO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FISNO", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ALANUSTAID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ALANUSTAID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@FIRMAID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMAID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ISLEMTIPIID", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISLEMTIPIID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TOPTUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "TOPTUTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TOPKDVTUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "TOPKDVTUTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@FISTUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "FISTUTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@GCKOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GCKOD", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TRANSFERID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TRANSFERID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TRANSDEPOGCID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TRANSDEPOGCID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IMZADEPOYETKILIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IMZADEPOYETKILIID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SAVEUSER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEUSER", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SAVEDATE", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEDATE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EDITUSER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITUSER", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EDITDATE", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITDATE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SAVEMAC", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEMAC", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EDITMAC", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITMAC", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SAVEIP", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEIP", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EDITIP", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITIP", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TALEPFISID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TALEPFISID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@GIRISICIKISYAPID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GIRISICIKISYAPID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_KOD", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_KOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ISEMRIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISEMRIID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ISEMRIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISEMRIID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TARIH", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TARIH", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TARIH", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TARIH", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SAAT", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAAT", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SAAT", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAAT", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_FISNO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FISNO", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_FISNO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FISNO", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ALANUSTAID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ALANUSTAID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ALANUSTAID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ALANUSTAID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_FIRMAID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMAID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_FIRMAID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMAID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ISLEMTIPIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISLEMTIPIID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ISLEMTIPIID", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISLEMTIPIID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TOPTUTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TOPTUTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TOPTUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "TOPTUTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TOPKDVTUTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TOPKDVTUTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TOPKDVTUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "TOPKDVTUTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_FISTUTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FISTUTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_FISTUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "FISTUTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_GCKOD", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GCKOD", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_GCKOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GCKOD", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TRANSFERID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TRANSFERID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TRANSFERID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TRANSFERID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TRANSDEPOGCID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TRANSDEPOGCID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TRANSDEPOGCID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TRANSDEPOGCID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_IMZADEPOYETKILIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IMZADEPOYETKILIID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_IMZADEPOYETKILIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IMZADEPOYETKILIID", DataRowVersion.Original, false, (object) null, "", "", ""));
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
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TALEPFISID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TALEPFISID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TALEPFISID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TALEPFISID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_GIRISICIKISYAPID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GIRISICIKISYAPID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_GIRISICIKISYAPID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GIRISICIKISYAPID", DataRowVersion.Original, false, (object) null, "", "", ""));
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
      this._commandCollection[0].CommandText = "SELECT ID, KOD, ISEMRIID, TARIH, SAAT, FISNO, ALANUSTAID, FIRMAID, ISLEMTIPIID, TOPTUTAR, TOPKDVTUTAR, FISTUTAR, GCKOD, TRANSFERID, TRANSDEPOGCID, IMZADEPOYETKILIID, SAVEUSER, SAVEDATE, EDITUSER, EDITDATE, SAVEMAC, EDITMAC, SAVEIP, EDITIP, TALEPFISID, GIRISICIKISYAPID FROM dbo.TBLDEPOFIS";
      this._commandCollection[0].CommandType = CommandType.Text;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    public virtual int Fill(bellDataSet7.TBLDEPOFISDataTable dataTable)
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
    public virtual bellDataSet7.TBLDEPOFISDataTable GetData()
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      bellDataSet7.TBLDEPOFISDataTable data = new bellDataSet7.TBLDEPOFISDataTable();
      this.Adapter.Fill((DataTable) data);
      return data;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(bellDataSet7.TBLDEPOFISDataTable dataTable) => this.Adapter.Update((DataTable) dataTable);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(bellDataSet7 dataSet) => this.Adapter.Update((DataSet) dataSet, "TBLDEPOFIS");

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
      int? Original_ISEMRIID,
      DateTime? Original_TARIH,
      DateTime? Original_SAAT,
      string Original_FISNO,
      int? Original_ALANUSTAID,
      int? Original_FIRMAID,
      string Original_ISLEMTIPIID,
      Decimal? Original_TOPTUTAR,
      Decimal? Original_TOPKDVTUTAR,
      Decimal? Original_FISTUTAR,
      string Original_GCKOD,
      int? Original_TRANSFERID,
      int? Original_TRANSDEPOGCID,
      int? Original_IMZADEPOYETKILIID,
      string Original_SAVEUSER,
      DateTime? Original_SAVEDATE,
      string Original_EDITUSER,
      DateTime? Original_EDITDATE,
      string Original_SAVEMAC,
      string Original_EDITMAC,
      string Original_SAVEIP,
      string Original_EDITIP,
      int? Original_TALEPFISID,
      int? Original_GIRISICIKISYAPID)
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
      if (Original_ISEMRIID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[3].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[4].Value = (object) Original_ISEMRIID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[3].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[4].Value = (object) DBNull.Value;
      }
      if (Original_TARIH.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[6].Value = (object) Original_TARIH.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[6].Value = (object) DBNull.Value;
      }
      if (Original_SAAT.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[7].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[8].Value = (object) Original_SAAT.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[7].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[8].Value = (object) DBNull.Value;
      }
      if (Original_FISNO == null)
      {
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) Original_FISNO;
      }
      if (Original_ALANUSTAID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[11].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[12].Value = (object) Original_ALANUSTAID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[11].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[12].Value = (object) DBNull.Value;
      }
      if (Original_FIRMAID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[13].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[14].Value = (object) Original_FIRMAID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[13].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[14].Value = (object) DBNull.Value;
      }
      if (Original_ISLEMTIPIID == null)
      {
        this.Adapter.DeleteCommand.Parameters[15].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[16].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[15].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[16].Value = (object) Original_ISLEMTIPIID;
      }
      if (Original_TOPTUTAR.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[17].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[18].Value = (object) Original_TOPTUTAR.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[17].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[18].Value = (object) DBNull.Value;
      }
      if (Original_TOPKDVTUTAR.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[19].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[20].Value = (object) Original_TOPKDVTUTAR.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[19].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[20].Value = (object) DBNull.Value;
      }
      if (Original_FISTUTAR.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[21].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[22].Value = (object) Original_FISTUTAR.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[21].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[22].Value = (object) DBNull.Value;
      }
      if (Original_GCKOD == null)
      {
        this.Adapter.DeleteCommand.Parameters[23].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[24].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[23].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[24].Value = (object) Original_GCKOD;
      }
      if (Original_TRANSFERID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[25].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[26].Value = (object) Original_TRANSFERID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[25].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[26].Value = (object) DBNull.Value;
      }
      if (Original_TRANSDEPOGCID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[27].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[28].Value = (object) Original_TRANSDEPOGCID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[27].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[28].Value = (object) DBNull.Value;
      }
      if (Original_IMZADEPOYETKILIID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[29].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[30].Value = (object) Original_IMZADEPOYETKILIID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[29].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[30].Value = (object) DBNull.Value;
      }
      if (Original_SAVEUSER == null)
      {
        this.Adapter.DeleteCommand.Parameters[31].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[32].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[31].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[32].Value = (object) Original_SAVEUSER;
      }
      if (Original_SAVEDATE.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[33].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[34].Value = (object) Original_SAVEDATE.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[33].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[34].Value = (object) DBNull.Value;
      }
      if (Original_EDITUSER == null)
      {
        this.Adapter.DeleteCommand.Parameters[35].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[36].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[35].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[36].Value = (object) Original_EDITUSER;
      }
      if (Original_EDITDATE.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[37].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[38].Value = (object) Original_EDITDATE.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[37].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[38].Value = (object) DBNull.Value;
      }
      if (Original_SAVEMAC == null)
      {
        this.Adapter.DeleteCommand.Parameters[39].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[40].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[39].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[40].Value = (object) Original_SAVEMAC;
      }
      if (Original_EDITMAC == null)
      {
        this.Adapter.DeleteCommand.Parameters[41].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[42].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[41].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[42].Value = (object) Original_EDITMAC;
      }
      if (Original_SAVEIP == null)
      {
        this.Adapter.DeleteCommand.Parameters[43].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[44].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[43].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[44].Value = (object) Original_SAVEIP;
      }
      if (Original_EDITIP == null)
      {
        this.Adapter.DeleteCommand.Parameters[45].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[46].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[45].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[46].Value = (object) Original_EDITIP;
      }
      if (Original_TALEPFISID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[47].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[48].Value = (object) Original_TALEPFISID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[47].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[48].Value = (object) DBNull.Value;
      }
      if (Original_GIRISICIKISYAPID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[49].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[50].Value = (object) Original_GIRISICIKISYAPID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[49].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[50].Value = (object) DBNull.Value;
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
      int? ISEMRIID,
      DateTime? TARIH,
      DateTime? SAAT,
      string FISNO,
      int? ALANUSTAID,
      int? FIRMAID,
      string ISLEMTIPIID,
      Decimal? TOPTUTAR,
      Decimal? TOPKDVTUTAR,
      Decimal? FISTUTAR,
      string GCKOD,
      int? TRANSFERID,
      int? TRANSDEPOGCID,
      int? IMZADEPOYETKILIID,
      string SAVEUSER,
      DateTime? SAVEDATE,
      string EDITUSER,
      DateTime? EDITDATE,
      string SAVEMAC,
      string EDITMAC,
      string SAVEIP,
      string EDITIP,
      int? TALEPFISID,
      int? GIRISICIKISYAPID)
    {
      if (KOD == null)
        this.Adapter.InsertCommand.Parameters[0].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[0].Value = (object) KOD;
      if (ISEMRIID.HasValue)
        this.Adapter.InsertCommand.Parameters[1].Value = (object) ISEMRIID.Value;
      else
        this.Adapter.InsertCommand.Parameters[1].Value = (object) DBNull.Value;
      if (TARIH.HasValue)
        this.Adapter.InsertCommand.Parameters[2].Value = (object) TARIH.Value;
      else
        this.Adapter.InsertCommand.Parameters[2].Value = (object) DBNull.Value;
      if (SAAT.HasValue)
        this.Adapter.InsertCommand.Parameters[3].Value = (object) SAAT.Value;
      else
        this.Adapter.InsertCommand.Parameters[3].Value = (object) DBNull.Value;
      if (FISNO == null)
        this.Adapter.InsertCommand.Parameters[4].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[4].Value = (object) FISNO;
      if (ALANUSTAID.HasValue)
        this.Adapter.InsertCommand.Parameters[5].Value = (object) ALANUSTAID.Value;
      else
        this.Adapter.InsertCommand.Parameters[5].Value = (object) DBNull.Value;
      if (FIRMAID.HasValue)
        this.Adapter.InsertCommand.Parameters[6].Value = (object) FIRMAID.Value;
      else
        this.Adapter.InsertCommand.Parameters[6].Value = (object) DBNull.Value;
      if (ISLEMTIPIID == null)
        this.Adapter.InsertCommand.Parameters[7].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[7].Value = (object) ISLEMTIPIID;
      if (TOPTUTAR.HasValue)
        this.Adapter.InsertCommand.Parameters[8].Value = (object) TOPTUTAR.Value;
      else
        this.Adapter.InsertCommand.Parameters[8].Value = (object) DBNull.Value;
      if (TOPKDVTUTAR.HasValue)
        this.Adapter.InsertCommand.Parameters[9].Value = (object) TOPKDVTUTAR.Value;
      else
        this.Adapter.InsertCommand.Parameters[9].Value = (object) DBNull.Value;
      if (FISTUTAR.HasValue)
        this.Adapter.InsertCommand.Parameters[10].Value = (object) FISTUTAR.Value;
      else
        this.Adapter.InsertCommand.Parameters[10].Value = (object) DBNull.Value;
      if (GCKOD == null)
        this.Adapter.InsertCommand.Parameters[11].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[11].Value = (object) GCKOD;
      if (TRANSFERID.HasValue)
        this.Adapter.InsertCommand.Parameters[12].Value = (object) TRANSFERID.Value;
      else
        this.Adapter.InsertCommand.Parameters[12].Value = (object) DBNull.Value;
      if (TRANSDEPOGCID.HasValue)
        this.Adapter.InsertCommand.Parameters[13].Value = (object) TRANSDEPOGCID.Value;
      else
        this.Adapter.InsertCommand.Parameters[13].Value = (object) DBNull.Value;
      if (IMZADEPOYETKILIID.HasValue)
        this.Adapter.InsertCommand.Parameters[14].Value = (object) IMZADEPOYETKILIID.Value;
      else
        this.Adapter.InsertCommand.Parameters[14].Value = (object) DBNull.Value;
      if (SAVEUSER == null)
        this.Adapter.InsertCommand.Parameters[15].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[15].Value = (object) SAVEUSER;
      if (SAVEDATE.HasValue)
        this.Adapter.InsertCommand.Parameters[16].Value = (object) SAVEDATE.Value;
      else
        this.Adapter.InsertCommand.Parameters[16].Value = (object) DBNull.Value;
      if (EDITUSER == null)
        this.Adapter.InsertCommand.Parameters[17].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[17].Value = (object) EDITUSER;
      if (EDITDATE.HasValue)
        this.Adapter.InsertCommand.Parameters[18].Value = (object) EDITDATE.Value;
      else
        this.Adapter.InsertCommand.Parameters[18].Value = (object) DBNull.Value;
      if (SAVEMAC == null)
        this.Adapter.InsertCommand.Parameters[19].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[19].Value = (object) SAVEMAC;
      if (EDITMAC == null)
        this.Adapter.InsertCommand.Parameters[20].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[20].Value = (object) EDITMAC;
      if (SAVEIP == null)
        this.Adapter.InsertCommand.Parameters[21].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[21].Value = (object) SAVEIP;
      if (EDITIP == null)
        this.Adapter.InsertCommand.Parameters[22].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[22].Value = (object) EDITIP;
      if (TALEPFISID.HasValue)
        this.Adapter.InsertCommand.Parameters[23].Value = (object) TALEPFISID.Value;
      else
        this.Adapter.InsertCommand.Parameters[23].Value = (object) DBNull.Value;
      if (GIRISICIKISYAPID.HasValue)
        this.Adapter.InsertCommand.Parameters[24].Value = (object) GIRISICIKISYAPID.Value;
      else
        this.Adapter.InsertCommand.Parameters[24].Value = (object) DBNull.Value;
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
      int? ISEMRIID,
      DateTime? TARIH,
      DateTime? SAAT,
      string FISNO,
      int? ALANUSTAID,
      int? FIRMAID,
      string ISLEMTIPIID,
      Decimal? TOPTUTAR,
      Decimal? TOPKDVTUTAR,
      Decimal? FISTUTAR,
      string GCKOD,
      int? TRANSFERID,
      int? TRANSDEPOGCID,
      int? IMZADEPOYETKILIID,
      string SAVEUSER,
      DateTime? SAVEDATE,
      string EDITUSER,
      DateTime? EDITDATE,
      string SAVEMAC,
      string EDITMAC,
      string SAVEIP,
      string EDITIP,
      int? TALEPFISID,
      int? GIRISICIKISYAPID,
      int Original_ID,
      string Original_KOD,
      int? Original_ISEMRIID,
      DateTime? Original_TARIH,
      DateTime? Original_SAAT,
      string Original_FISNO,
      int? Original_ALANUSTAID,
      int? Original_FIRMAID,
      string Original_ISLEMTIPIID,
      Decimal? Original_TOPTUTAR,
      Decimal? Original_TOPKDVTUTAR,
      Decimal? Original_FISTUTAR,
      string Original_GCKOD,
      int? Original_TRANSFERID,
      int? Original_TRANSDEPOGCID,
      int? Original_IMZADEPOYETKILIID,
      string Original_SAVEUSER,
      DateTime? Original_SAVEDATE,
      string Original_EDITUSER,
      DateTime? Original_EDITDATE,
      string Original_SAVEMAC,
      string Original_EDITMAC,
      string Original_SAVEIP,
      string Original_EDITIP,
      int? Original_TALEPFISID,
      int? Original_GIRISICIKISYAPID,
      int ID)
    {
      if (KOD == null)
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) KOD;
      if (ISEMRIID.HasValue)
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) ISEMRIID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) DBNull.Value;
      if (TARIH.HasValue)
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) TARIH.Value;
      else
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) DBNull.Value;
      if (SAAT.HasValue)
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) SAAT.Value;
      else
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) DBNull.Value;
      if (FISNO == null)
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) FISNO;
      if (ALANUSTAID.HasValue)
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) ALANUSTAID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) DBNull.Value;
      if (FIRMAID.HasValue)
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) FIRMAID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) DBNull.Value;
      if (ISLEMTIPIID == null)
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) ISLEMTIPIID;
      if (TOPTUTAR.HasValue)
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) TOPTUTAR.Value;
      else
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) DBNull.Value;
      if (TOPKDVTUTAR.HasValue)
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) TOPKDVTUTAR.Value;
      else
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) DBNull.Value;
      if (FISTUTAR.HasValue)
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) FISTUTAR.Value;
      else
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) DBNull.Value;
      if (GCKOD == null)
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) GCKOD;
      if (TRANSFERID.HasValue)
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) TRANSFERID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) DBNull.Value;
      if (TRANSDEPOGCID.HasValue)
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) TRANSDEPOGCID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) DBNull.Value;
      if (IMZADEPOYETKILIID.HasValue)
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) IMZADEPOYETKILIID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) DBNull.Value;
      if (SAVEUSER == null)
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) SAVEUSER;
      if (SAVEDATE.HasValue)
        this.Adapter.UpdateCommand.Parameters[16].Value = (object) SAVEDATE.Value;
      else
        this.Adapter.UpdateCommand.Parameters[16].Value = (object) DBNull.Value;
      if (EDITUSER == null)
        this.Adapter.UpdateCommand.Parameters[17].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[17].Value = (object) EDITUSER;
      if (EDITDATE.HasValue)
        this.Adapter.UpdateCommand.Parameters[18].Value = (object) EDITDATE.Value;
      else
        this.Adapter.UpdateCommand.Parameters[18].Value = (object) DBNull.Value;
      if (SAVEMAC == null)
        this.Adapter.UpdateCommand.Parameters[19].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[19].Value = (object) SAVEMAC;
      if (EDITMAC == null)
        this.Adapter.UpdateCommand.Parameters[20].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[20].Value = (object) EDITMAC;
      if (SAVEIP == null)
        this.Adapter.UpdateCommand.Parameters[21].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[21].Value = (object) SAVEIP;
      if (EDITIP == null)
        this.Adapter.UpdateCommand.Parameters[22].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[22].Value = (object) EDITIP;
      if (TALEPFISID.HasValue)
        this.Adapter.UpdateCommand.Parameters[23].Value = (object) TALEPFISID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[23].Value = (object) DBNull.Value;
      if (GIRISICIKISYAPID.HasValue)
        this.Adapter.UpdateCommand.Parameters[24].Value = (object) GIRISICIKISYAPID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[24].Value = (object) DBNull.Value;
      this.Adapter.UpdateCommand.Parameters[25].Value = (object) Original_ID;
      if (Original_KOD == null)
      {
        this.Adapter.UpdateCommand.Parameters[26].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[27].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[26].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[27].Value = (object) Original_KOD;
      }
      if (Original_ISEMRIID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[28].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[29].Value = (object) Original_ISEMRIID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[28].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[29].Value = (object) DBNull.Value;
      }
      if (Original_TARIH.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[30].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[31].Value = (object) Original_TARIH.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[30].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[31].Value = (object) DBNull.Value;
      }
      if (Original_SAAT.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[32].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[33].Value = (object) Original_SAAT.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[32].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[33].Value = (object) DBNull.Value;
      }
      if (Original_FISNO == null)
      {
        this.Adapter.UpdateCommand.Parameters[34].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[35].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[34].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[35].Value = (object) Original_FISNO;
      }
      if (Original_ALANUSTAID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[36].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[37].Value = (object) Original_ALANUSTAID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[36].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[37].Value = (object) DBNull.Value;
      }
      if (Original_FIRMAID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[38].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[39].Value = (object) Original_FIRMAID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[38].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[39].Value = (object) DBNull.Value;
      }
      if (Original_ISLEMTIPIID == null)
      {
        this.Adapter.UpdateCommand.Parameters[40].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[41].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[40].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[41].Value = (object) Original_ISLEMTIPIID;
      }
      if (Original_TOPTUTAR.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[42].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[43].Value = (object) Original_TOPTUTAR.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[42].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[43].Value = (object) DBNull.Value;
      }
      if (Original_TOPKDVTUTAR.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[44].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[45].Value = (object) Original_TOPKDVTUTAR.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[44].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[45].Value = (object) DBNull.Value;
      }
      if (Original_FISTUTAR.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[46].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[47].Value = (object) Original_FISTUTAR.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[46].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[47].Value = (object) DBNull.Value;
      }
      if (Original_GCKOD == null)
      {
        this.Adapter.UpdateCommand.Parameters[48].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[49].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[48].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[49].Value = (object) Original_GCKOD;
      }
      if (Original_TRANSFERID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[50].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[51].Value = (object) Original_TRANSFERID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[50].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[51].Value = (object) DBNull.Value;
      }
      if (Original_TRANSDEPOGCID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[52].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[53].Value = (object) Original_TRANSDEPOGCID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[52].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[53].Value = (object) DBNull.Value;
      }
      if (Original_IMZADEPOYETKILIID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[54].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[55].Value = (object) Original_IMZADEPOYETKILIID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[54].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[55].Value = (object) DBNull.Value;
      }
      if (Original_SAVEUSER == null)
      {
        this.Adapter.UpdateCommand.Parameters[56].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[57].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[56].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[57].Value = (object) Original_SAVEUSER;
      }
      if (Original_SAVEDATE.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[58].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[59].Value = (object) Original_SAVEDATE.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[58].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[59].Value = (object) DBNull.Value;
      }
      if (Original_EDITUSER == null)
      {
        this.Adapter.UpdateCommand.Parameters[60].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[61].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[60].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[61].Value = (object) Original_EDITUSER;
      }
      if (Original_EDITDATE.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[62].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[63].Value = (object) Original_EDITDATE.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[62].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[63].Value = (object) DBNull.Value;
      }
      if (Original_SAVEMAC == null)
      {
        this.Adapter.UpdateCommand.Parameters[64].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[65].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[64].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[65].Value = (object) Original_SAVEMAC;
      }
      if (Original_EDITMAC == null)
      {
        this.Adapter.UpdateCommand.Parameters[66].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[67].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[66].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[67].Value = (object) Original_EDITMAC;
      }
      if (Original_SAVEIP == null)
      {
        this.Adapter.UpdateCommand.Parameters[68].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[69].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[68].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[69].Value = (object) Original_SAVEIP;
      }
      if (Original_EDITIP == null)
      {
        this.Adapter.UpdateCommand.Parameters[70].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[71].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[70].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[71].Value = (object) Original_EDITIP;
      }
      if (Original_TALEPFISID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[72].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[73].Value = (object) Original_TALEPFISID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[72].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[73].Value = (object) DBNull.Value;
      }
      if (Original_GIRISICIKISYAPID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[74].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[75].Value = (object) Original_GIRISICIKISYAPID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[74].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[75].Value = (object) DBNull.Value;
      }
      this.Adapter.UpdateCommand.Parameters[76].Value = (object) ID;
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
      int? ISEMRIID,
      DateTime? TARIH,
      DateTime? SAAT,
      string FISNO,
      int? ALANUSTAID,
      int? FIRMAID,
      string ISLEMTIPIID,
      Decimal? TOPTUTAR,
      Decimal? TOPKDVTUTAR,
      Decimal? FISTUTAR,
      string GCKOD,
      int? TRANSFERID,
      int? TRANSDEPOGCID,
      int? IMZADEPOYETKILIID,
      string SAVEUSER,
      DateTime? SAVEDATE,
      string EDITUSER,
      DateTime? EDITDATE,
      string SAVEMAC,
      string EDITMAC,
      string SAVEIP,
      string EDITIP,
      int? TALEPFISID,
      int? GIRISICIKISYAPID,
      int Original_ID,
      string Original_KOD,
      int? Original_ISEMRIID,
      DateTime? Original_TARIH,
      DateTime? Original_SAAT,
      string Original_FISNO,
      int? Original_ALANUSTAID,
      int? Original_FIRMAID,
      string Original_ISLEMTIPIID,
      Decimal? Original_TOPTUTAR,
      Decimal? Original_TOPKDVTUTAR,
      Decimal? Original_FISTUTAR,
      string Original_GCKOD,
      int? Original_TRANSFERID,
      int? Original_TRANSDEPOGCID,
      int? Original_IMZADEPOYETKILIID,
      string Original_SAVEUSER,
      DateTime? Original_SAVEDATE,
      string Original_EDITUSER,
      DateTime? Original_EDITDATE,
      string Original_SAVEMAC,
      string Original_EDITMAC,
      string Original_SAVEIP,
      string Original_EDITIP,
      int? Original_TALEPFISID,
      int? Original_GIRISICIKISYAPID)
    {
      return this.Update(KOD, ISEMRIID, TARIH, SAAT, FISNO, ALANUSTAID, FIRMAID, ISLEMTIPIID, TOPTUTAR, TOPKDVTUTAR, FISTUTAR, GCKOD, TRANSFERID, TRANSDEPOGCID, IMZADEPOYETKILIID, SAVEUSER, SAVEDATE, EDITUSER, EDITDATE, SAVEMAC, EDITMAC, SAVEIP, EDITIP, TALEPFISID, GIRISICIKISYAPID, Original_ID, Original_KOD, Original_ISEMRIID, Original_TARIH, Original_SAAT, Original_FISNO, Original_ALANUSTAID, Original_FIRMAID, Original_ISLEMTIPIID, Original_TOPTUTAR, Original_TOPKDVTUTAR, Original_FISTUTAR, Original_GCKOD, Original_TRANSFERID, Original_TRANSDEPOGCID, Original_IMZADEPOYETKILIID, Original_SAVEUSER, Original_SAVEDATE, Original_EDITUSER, Original_EDITDATE, Original_SAVEMAC, Original_EDITMAC, Original_SAVEIP, Original_EDITIP, Original_TALEPFISID, Original_GIRISICIKISYAPID, Original_ID);
    }
  }
}
