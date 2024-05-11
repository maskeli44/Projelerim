// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.bellDataSet5TableAdapters.TBLTEKLIFTableAdapter
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
  public class TBLTEKLIFTableAdapter : Component
  {
    private SqlDataAdapter _adapter;
    private SqlConnection _connection;
    private SqlTransaction _transaction;
    private SqlCommand[] _commandCollection;
    private bool _clearBeforeFill;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public TBLTEKLIFTableAdapter() => this.ClearBeforeFill = true;

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
        DataSetTable = "TBLTEKLIF",
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
            "TARIH",
            "TARIH"
          },
          {
            "SAAT",
            "SAAT"
          },
          {
            "TEKLIFKONUSU",
            "TEKLIFKONUSU"
          },
          {
            "KAZANANFIRMAID",
            "KAZANANFIRMAID"
          },
          {
            "FATURATARIHI",
            "FATURATARIHI"
          },
          {
            "FATURANO",
            "FATURANO"
          },
          {
            "FATURATUTAR",
            "FATURATUTAR"
          },
          {
            "KDVTUTAR",
            "KDVTUTAR"
          },
          {
            "TOPLAMTUTAR",
            "TOPLAMTUTAR"
          },
          {
            "FATTUTARYAZIYLA",
            "FATTUTARYAZIYLA"
          },
          {
            "SAKARARTARIHI",
            "SAKARARTARIHI"
          },
          {
            "SAKARARNO",
            "SAKARARNO"
          },
          {
            "IMZABIRIMAMIRIID",
            "IMZABIRIMAMIRIID"
          },
          {
            "IMZAMUDURID",
            "IMZAMUDURID"
          },
          {
            "DAIREBSKID",
            "DAIREBSKID"
          },
          {
            "OLURILGISI",
            "OLURILGISI"
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
            "FIRMA1ID",
            "FIRMA1ID"
          },
          {
            "FIRMA2ID",
            "FIRMA2ID"
          },
          {
            "FIRMA3ID",
            "FIRMA3ID"
          },
          {
            "FIRMA4ID",
            "FIRMA4ID"
          },
          {
            "FIRMA5ID",
            "FIRMA5ID"
          },
          {
            "FIRMA6ID",
            "FIRMA6ID"
          },
          {
            "FIRMA7ID",
            "FIRMA7ID"
          },
          {
            "FIRMA8ID",
            "FIRMA8ID"
          },
          {
            "TALEPID",
            "TALEPID"
          },
          {
            "KOMUYE1ID",
            "KOMUYE1ID"
          },
          {
            "KOMUYE2ID",
            "KOMUYE2ID"
          },
          {
            "KOMBSKID",
            "KOMBSKID"
          },
          {
            "AITOLDBIRIM",
            "AITOLDBIRIM"
          },
          {
            "KESINLESTIR",
            "KESINLESTIR"
          },
          {
            "PIYASAUYE1ID",
            "PIYASAUYE1ID"
          },
          {
            "PIYASAUYE2ID",
            "PIYASAUYE2ID"
          },
          {
            "PIYASABSKID",
            "PIYASABSKID"
          }
        }
      });
      this._adapter.DeleteCommand = new SqlCommand();
      this._adapter.DeleteCommand.Connection = this.Connection;
      this._adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[TBLTEKLIF] WHERE (([ID] = @Original_ID) AND ((@IsNull_KOD = 1 AND [KOD] IS NULL) OR ([KOD] = @Original_KOD)) AND ((@IsNull_TARIH = 1 AND [TARIH] IS NULL) OR ([TARIH] = @Original_TARIH)) AND ((@IsNull_SAAT = 1 AND [SAAT] IS NULL) OR ([SAAT] = @Original_SAAT)) AND ((@IsNull_TEKLIFKONUSU = 1 AND [TEKLIFKONUSU] IS NULL) OR ([TEKLIFKONUSU] = @Original_TEKLIFKONUSU)) AND ((@IsNull_KAZANANFIRMAID = 1 AND [KAZANANFIRMAID] IS NULL) OR ([KAZANANFIRMAID] = @Original_KAZANANFIRMAID)) AND ((@IsNull_FATURATARIHI = 1 AND [FATURATARIHI] IS NULL) OR ([FATURATARIHI] = @Original_FATURATARIHI)) AND ((@IsNull_FATURANO = 1 AND [FATURANO] IS NULL) OR ([FATURANO] = @Original_FATURANO)) AND ((@IsNull_FATURATUTAR = 1 AND [FATURATUTAR] IS NULL) OR ([FATURATUTAR] = @Original_FATURATUTAR)) AND ((@IsNull_KDVTUTAR = 1 AND [KDVTUTAR] IS NULL) OR ([KDVTUTAR] = @Original_KDVTUTAR)) AND ((@IsNull_TOPLAMTUTAR = 1 AND [TOPLAMTUTAR] IS NULL) OR ([TOPLAMTUTAR] = @Original_TOPLAMTUTAR)) AND ((@IsNull_FATTUTARYAZIYLA = 1 AND [FATTUTARYAZIYLA] IS NULL) OR ([FATTUTARYAZIYLA] = @Original_FATTUTARYAZIYLA)) AND ((@IsNull_SAKARARTARIHI = 1 AND [SAKARARTARIHI] IS NULL) OR ([SAKARARTARIHI] = @Original_SAKARARTARIHI)) AND ((@IsNull_SAKARARNO = 1 AND [SAKARARNO] IS NULL) OR ([SAKARARNO] = @Original_SAKARARNO)) AND ((@IsNull_IMZABIRIMAMIRIID = 1 AND [IMZABIRIMAMIRIID] IS NULL) OR ([IMZABIRIMAMIRIID] = @Original_IMZABIRIMAMIRIID)) AND ((@IsNull_IMZAMUDURID = 1 AND [IMZAMUDURID] IS NULL) OR ([IMZAMUDURID] = @Original_IMZAMUDURID)) AND ((@IsNull_DAIREBSKID = 1 AND [DAIREBSKID] IS NULL) OR ([DAIREBSKID] = @Original_DAIREBSKID)) AND ((@IsNull_OLURILGISI = 1 AND [OLURILGISI] IS NULL) OR ([OLURILGISI] = @Original_OLURILGISI)) AND ((@IsNull_SAVEUSER = 1 AND [SAVEUSER] IS NULL) OR ([SAVEUSER] = @Original_SAVEUSER)) AND ((@IsNull_SAVEDATE = 1 AND [SAVEDATE] IS NULL) OR ([SAVEDATE] = @Original_SAVEDATE)) AND ((@IsNull_EDITUSER = 1 AND [EDITUSER] IS NULL) OR ([EDITUSER] = @Original_EDITUSER)) AND ((@IsNull_EDITDATE = 1 AND [EDITDATE] IS NULL) OR ([EDITDATE] = @Original_EDITDATE)) AND ((@IsNull_SAVEMAC = 1 AND [SAVEMAC] IS NULL) OR ([SAVEMAC] = @Original_SAVEMAC)) AND ((@IsNull_EDITMAC = 1 AND [EDITMAC] IS NULL) OR ([EDITMAC] = @Original_EDITMAC)) AND ((@IsNull_SAVEIP = 1 AND [SAVEIP] IS NULL) OR ([SAVEIP] = @Original_SAVEIP)) AND ((@IsNull_EDITIP = 1 AND [EDITIP] IS NULL) OR ([EDITIP] = @Original_EDITIP)) AND ((@IsNull_FIRMA1ID = 1 AND [FIRMA1ID] IS NULL) OR ([FIRMA1ID] = @Original_FIRMA1ID)) AND ((@IsNull_FIRMA2ID = 1 AND [FIRMA2ID] IS NULL) OR ([FIRMA2ID] = @Original_FIRMA2ID)) AND ((@IsNull_FIRMA3ID = 1 AND [FIRMA3ID] IS NULL) OR ([FIRMA3ID] = @Original_FIRMA3ID)) AND ((@IsNull_FIRMA4ID = 1 AND [FIRMA4ID] IS NULL) OR ([FIRMA4ID] = @Original_FIRMA4ID)) AND ((@IsNull_FIRMA5ID = 1 AND [FIRMA5ID] IS NULL) OR ([FIRMA5ID] = @Original_FIRMA5ID)) AND ((@IsNull_FIRMA6ID = 1 AND [FIRMA6ID] IS NULL) OR ([FIRMA6ID] = @Original_FIRMA6ID)) AND ((@IsNull_FIRMA7ID = 1 AND [FIRMA7ID] IS NULL) OR ([FIRMA7ID] = @Original_FIRMA7ID)) AND ((@IsNull_FIRMA8ID = 1 AND [FIRMA8ID] IS NULL) OR ([FIRMA8ID] = @Original_FIRMA8ID)) AND ((@IsNull_TALEPID = 1 AND [TALEPID] IS NULL) OR ([TALEPID] = @Original_TALEPID)) AND ((@IsNull_KOMUYE1ID = 1 AND [KOMUYE1ID] IS NULL) OR ([KOMUYE1ID] = @Original_KOMUYE1ID)) AND ((@IsNull_KOMUYE2ID = 1 AND [KOMUYE2ID] IS NULL) OR ([KOMUYE2ID] = @Original_KOMUYE2ID)) AND ((@IsNull_KOMBSKID = 1 AND [KOMBSKID] IS NULL) OR ([KOMBSKID] = @Original_KOMBSKID)) AND ((@IsNull_AITOLDBIRIM = 1 AND [AITOLDBIRIM] IS NULL) OR ([AITOLDBIRIM] = @Original_AITOLDBIRIM)) AND ((@IsNull_KESINLESTIR = 1 AND [KESINLESTIR] IS NULL) OR ([KESINLESTIR] = @Original_KESINLESTIR)) AND ((@IsNull_PIYASAUYE1ID = 1 AND [PIYASAUYE1ID] IS NULL) OR ([PIYASAUYE1ID] = @Original_PIYASAUYE1ID)) AND ((@IsNull_PIYASAUYE2ID = 1 AND [PIYASAUYE2ID] IS NULL) OR ([PIYASAUYE2ID] = @Original_PIYASAUYE2ID)) AND ((@IsNull_PIYASABSKID = 1 AND [PIYASABSKID] IS NULL) OR ([PIYASABSKID] = @Original_PIYASABSKID)))";
      this._adapter.DeleteCommand.CommandType = CommandType.Text;
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_KOD", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_KOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TARIH", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TARIH", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TARIH", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TARIH", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SAAT", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAAT", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SAAT", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAAT", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TEKLIFKONUSU", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TEKLIFKONUSU", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TEKLIFKONUSU", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TEKLIFKONUSU", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_KAZANANFIRMAID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KAZANANFIRMAID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_KAZANANFIRMAID", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KAZANANFIRMAID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_FATURATARIHI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FATURATARIHI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_FATURATARIHI", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FATURATARIHI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_FATURANO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FATURANO", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_FATURANO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FATURANO", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_FATURATUTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FATURATUTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_FATURATUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "FATURATUTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_KDVTUTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KDVTUTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_KDVTUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "KDVTUTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TOPLAMTUTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TOPLAMTUTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TOPLAMTUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "TOPLAMTUTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_FATTUTARYAZIYLA", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FATTUTARYAZIYLA", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_FATTUTARYAZIYLA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FATTUTARYAZIYLA", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SAKARARTARIHI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAKARARTARIHI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SAKARARTARIHI", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAKARARTARIHI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SAKARARNO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAKARARNO", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SAKARARNO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAKARARNO", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_IMZABIRIMAMIRIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IMZABIRIMAMIRIID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_IMZABIRIMAMIRIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IMZABIRIMAMIRIID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_IMZAMUDURID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IMZAMUDURID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_IMZAMUDURID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IMZAMUDURID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_DAIREBSKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DAIREBSKID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_DAIREBSKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DAIREBSKID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_OLURILGISI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "OLURILGISI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_OLURILGISI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "OLURILGISI", DataRowVersion.Original, false, (object) null, "", "", ""));
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
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_FIRMA1ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA1ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_FIRMA1ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA1ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_FIRMA2ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA2ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_FIRMA2ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA2ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_FIRMA3ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA3ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_FIRMA3ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA3ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_FIRMA4ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA4ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_FIRMA4ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA4ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_FIRMA5ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA5ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_FIRMA5ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA5ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_FIRMA6ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA6ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_FIRMA6ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA6ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_FIRMA7ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA7ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_FIRMA7ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA7ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_FIRMA8ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA8ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_FIRMA8ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA8ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TALEPID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TALEPID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TALEPID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TALEPID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_KOMUYE1ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOMUYE1ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_KOMUYE1ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOMUYE1ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_KOMUYE2ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOMUYE2ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_KOMUYE2ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOMUYE2ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_KOMBSKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOMBSKID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_KOMBSKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOMBSKID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_AITOLDBIRIM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AITOLDBIRIM", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_AITOLDBIRIM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AITOLDBIRIM", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_KESINLESTIR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KESINLESTIR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_KESINLESTIR", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KESINLESTIR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_PIYASAUYE1ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PIYASAUYE1ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_PIYASAUYE1ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PIYASAUYE1ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_PIYASAUYE2ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PIYASAUYE2ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_PIYASAUYE2ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PIYASAUYE2ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_PIYASABSKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PIYASABSKID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_PIYASABSKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PIYASABSKID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.InsertCommand = new SqlCommand();
      this._adapter.InsertCommand.Connection = this.Connection;
      this._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[TBLTEKLIF] ([KOD], [TARIH], [SAAT], [TEKLIFKONUSU], [KAZANANFIRMAID], [FATURATARIHI], [FATURANO], [FATURATUTAR], [KDVTUTAR], [TOPLAMTUTAR], [FATTUTARYAZIYLA], [SAKARARTARIHI], [SAKARARNO], [IMZABIRIMAMIRIID], [IMZAMUDURID], [DAIREBSKID], [OLURILGISI], [SAVEUSER], [SAVEDATE], [EDITUSER], [EDITDATE], [SAVEMAC], [EDITMAC], [SAVEIP], [EDITIP], [FIRMA1ID], [FIRMA2ID], [FIRMA3ID], [FIRMA4ID], [FIRMA5ID], [FIRMA6ID], [FIRMA7ID], [FIRMA8ID], [TALEPID], [KOMUYE1ID], [KOMUYE2ID], [KOMBSKID], [AITOLDBIRIM], [KESINLESTIR], [PIYASAUYE1ID], [PIYASAUYE2ID], [PIYASABSKID]) VALUES (@KOD, @TARIH, @SAAT, @TEKLIFKONUSU, @KAZANANFIRMAID, @FATURATARIHI, @FATURANO, @FATURATUTAR, @KDVTUTAR, @TOPLAMTUTAR, @FATTUTARYAZIYLA, @SAKARARTARIHI, @SAKARARNO, @IMZABIRIMAMIRIID, @IMZAMUDURID, @DAIREBSKID, @OLURILGISI, @SAVEUSER, @SAVEDATE, @EDITUSER, @EDITDATE, @SAVEMAC, @EDITMAC, @SAVEIP, @EDITIP, @FIRMA1ID, @FIRMA2ID, @FIRMA3ID, @FIRMA4ID, @FIRMA5ID, @FIRMA6ID, @FIRMA7ID, @FIRMA8ID, @TALEPID, @KOMUYE1ID, @KOMUYE2ID, @KOMBSKID, @AITOLDBIRIM, @KESINLESTIR, @PIYASAUYE1ID, @PIYASAUYE2ID, @PIYASABSKID);\r\nSELECT ID, KOD, TARIH, SAAT, TEKLIFKONUSU, KAZANANFIRMAID, FATURATARIHI, FATURANO, FATURATUTAR, KDVTUTAR, TOPLAMTUTAR, FATTUTARYAZIYLA, SAKARARTARIHI, SAKARARNO, IMZABIRIMAMIRIID, IMZAMUDURID, DAIREBSKID, OLURILGISI, SAVEUSER, SAVEDATE, EDITUSER, EDITDATE, SAVEMAC, EDITMAC, SAVEIP, EDITIP, FIRMA1ID, FIRMA2ID, FIRMA3ID, FIRMA4ID, FIRMA5ID, FIRMA6ID, FIRMA7ID, FIRMA8ID, TALEPID, KOMUYE1ID, KOMUYE2ID, KOMBSKID, AITOLDBIRIM, KESINLESTIR, PIYASAUYE1ID, PIYASAUYE2ID, PIYASABSKID FROM TBLTEKLIF WHERE (ID = SCOPE_IDENTITY())";
      this._adapter.InsertCommand.CommandType = CommandType.Text;
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@KOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@TARIH", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TARIH", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SAAT", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAAT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@TEKLIFKONUSU", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TEKLIFKONUSU", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@KAZANANFIRMAID", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KAZANANFIRMAID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@FATURATARIHI", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FATURATARIHI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@FATURANO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FATURANO", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@FATURATUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "FATURATUTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@KDVTUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "KDVTUTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@TOPLAMTUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "TOPLAMTUTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@FATTUTARYAZIYLA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FATTUTARYAZIYLA", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SAKARARTARIHI", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAKARARTARIHI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SAKARARNO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAKARARNO", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@IMZABIRIMAMIRIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IMZABIRIMAMIRIID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@IMZAMUDURID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IMZAMUDURID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@DAIREBSKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DAIREBSKID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@OLURILGISI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "OLURILGISI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SAVEUSER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEUSER", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SAVEDATE", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEDATE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@EDITUSER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITUSER", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@EDITDATE", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITDATE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SAVEMAC", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEMAC", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@EDITMAC", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITMAC", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SAVEIP", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEIP", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@EDITIP", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITIP", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@FIRMA1ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA1ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@FIRMA2ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA2ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@FIRMA3ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA3ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@FIRMA4ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA4ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@FIRMA5ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA5ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@FIRMA6ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA6ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@FIRMA7ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA7ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@FIRMA8ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA8ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@TALEPID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TALEPID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@KOMUYE1ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOMUYE1ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@KOMUYE2ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOMUYE2ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@KOMBSKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOMBSKID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@AITOLDBIRIM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AITOLDBIRIM", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@KESINLESTIR", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KESINLESTIR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@PIYASAUYE1ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PIYASAUYE1ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@PIYASAUYE2ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PIYASAUYE2ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@PIYASABSKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PIYASABSKID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand = new SqlCommand();
      this._adapter.UpdateCommand.Connection = this.Connection;
      this._adapter.UpdateCommand.CommandText = "UPDATE [dbo].[TBLTEKLIF] SET [KOD] = @KOD, [TARIH] = @TARIH, [SAAT] = @SAAT, [TEKLIFKONUSU] = @TEKLIFKONUSU, [KAZANANFIRMAID] = @KAZANANFIRMAID, [FATURATARIHI] = @FATURATARIHI, [FATURANO] = @FATURANO, [FATURATUTAR] = @FATURATUTAR, [KDVTUTAR] = @KDVTUTAR, [TOPLAMTUTAR] = @TOPLAMTUTAR, [FATTUTARYAZIYLA] = @FATTUTARYAZIYLA, [SAKARARTARIHI] = @SAKARARTARIHI, [SAKARARNO] = @SAKARARNO, [IMZABIRIMAMIRIID] = @IMZABIRIMAMIRIID, [IMZAMUDURID] = @IMZAMUDURID, [DAIREBSKID] = @DAIREBSKID, [OLURILGISI] = @OLURILGISI, [SAVEUSER] = @SAVEUSER, [SAVEDATE] = @SAVEDATE, [EDITUSER] = @EDITUSER, [EDITDATE] = @EDITDATE, [SAVEMAC] = @SAVEMAC, [EDITMAC] = @EDITMAC, [SAVEIP] = @SAVEIP, [EDITIP] = @EDITIP, [FIRMA1ID] = @FIRMA1ID, [FIRMA2ID] = @FIRMA2ID, [FIRMA3ID] = @FIRMA3ID, [FIRMA4ID] = @FIRMA4ID, [FIRMA5ID] = @FIRMA5ID, [FIRMA6ID] = @FIRMA6ID, [FIRMA7ID] = @FIRMA7ID, [FIRMA8ID] = @FIRMA8ID, [TALEPID] = @TALEPID, [KOMUYE1ID] = @KOMUYE1ID, [KOMUYE2ID] = @KOMUYE2ID, [KOMBSKID] = @KOMBSKID, [AITOLDBIRIM] = @AITOLDBIRIM, [KESINLESTIR] = @KESINLESTIR, [PIYASAUYE1ID] = @PIYASAUYE1ID, [PIYASAUYE2ID] = @PIYASAUYE2ID, [PIYASABSKID] = @PIYASABSKID WHERE (([ID] = @Original_ID) AND ((@IsNull_KOD = 1 AND [KOD] IS NULL) OR ([KOD] = @Original_KOD)) AND ((@IsNull_TARIH = 1 AND [TARIH] IS NULL) OR ([TARIH] = @Original_TARIH)) AND ((@IsNull_SAAT = 1 AND [SAAT] IS NULL) OR ([SAAT] = @Original_SAAT)) AND ((@IsNull_TEKLIFKONUSU = 1 AND [TEKLIFKONUSU] IS NULL) OR ([TEKLIFKONUSU] = @Original_TEKLIFKONUSU)) AND ((@IsNull_KAZANANFIRMAID = 1 AND [KAZANANFIRMAID] IS NULL) OR ([KAZANANFIRMAID] = @Original_KAZANANFIRMAID)) AND ((@IsNull_FATURATARIHI = 1 AND [FATURATARIHI] IS NULL) OR ([FATURATARIHI] = @Original_FATURATARIHI)) AND ((@IsNull_FATURANO = 1 AND [FATURANO] IS NULL) OR ([FATURANO] = @Original_FATURANO)) AND ((@IsNull_FATURATUTAR = 1 AND [FATURATUTAR] IS NULL) OR ([FATURATUTAR] = @Original_FATURATUTAR)) AND ((@IsNull_KDVTUTAR = 1 AND [KDVTUTAR] IS NULL) OR ([KDVTUTAR] = @Original_KDVTUTAR)) AND ((@IsNull_TOPLAMTUTAR = 1 AND [TOPLAMTUTAR] IS NULL) OR ([TOPLAMTUTAR] = @Original_TOPLAMTUTAR)) AND ((@IsNull_FATTUTARYAZIYLA = 1 AND [FATTUTARYAZIYLA] IS NULL) OR ([FATTUTARYAZIYLA] = @Original_FATTUTARYAZIYLA)) AND ((@IsNull_SAKARARTARIHI = 1 AND [SAKARARTARIHI] IS NULL) OR ([SAKARARTARIHI] = @Original_SAKARARTARIHI)) AND ((@IsNull_SAKARARNO = 1 AND [SAKARARNO] IS NULL) OR ([SAKARARNO] = @Original_SAKARARNO)) AND ((@IsNull_IMZABIRIMAMIRIID = 1 AND [IMZABIRIMAMIRIID] IS NULL) OR ([IMZABIRIMAMIRIID] = @Original_IMZABIRIMAMIRIID)) AND ((@IsNull_IMZAMUDURID = 1 AND [IMZAMUDURID] IS NULL) OR ([IMZAMUDURID] = @Original_IMZAMUDURID)) AND ((@IsNull_DAIREBSKID = 1 AND [DAIREBSKID] IS NULL) OR ([DAIREBSKID] = @Original_DAIREBSKID)) AND ((@IsNull_OLURILGISI = 1 AND [OLURILGISI] IS NULL) OR ([OLURILGISI] = @Original_OLURILGISI)) AND ((@IsNull_SAVEUSER = 1 AND [SAVEUSER] IS NULL) OR ([SAVEUSER] = @Original_SAVEUSER)) AND ((@IsNull_SAVEDATE = 1 AND [SAVEDATE] IS NULL) OR ([SAVEDATE] = @Original_SAVEDATE)) AND ((@IsNull_EDITUSER = 1 AND [EDITUSER] IS NULL) OR ([EDITUSER] = @Original_EDITUSER)) AND ((@IsNull_EDITDATE = 1 AND [EDITDATE] IS NULL) OR ([EDITDATE] = @Original_EDITDATE)) AND ((@IsNull_SAVEMAC = 1 AND [SAVEMAC] IS NULL) OR ([SAVEMAC] = @Original_SAVEMAC)) AND ((@IsNull_EDITMAC = 1 AND [EDITMAC] IS NULL) OR ([EDITMAC] = @Original_EDITMAC)) AND ((@IsNull_SAVEIP = 1 AND [SAVEIP] IS NULL) OR ([SAVEIP] = @Original_SAVEIP)) AND ((@IsNull_EDITIP = 1 AND [EDITIP] IS NULL) OR ([EDITIP] = @Original_EDITIP)) AND ((@IsNull_FIRMA1ID = 1 AND [FIRMA1ID] IS NULL) OR ([FIRMA1ID] = @Original_FIRMA1ID)) AND ((@IsNull_FIRMA2ID = 1 AND [FIRMA2ID] IS NULL) OR ([FIRMA2ID] = @Original_FIRMA2ID)) AND ((@IsNull_FIRMA3ID = 1 AND [FIRMA3ID] IS NULL) OR ([FIRMA3ID] = @Original_FIRMA3ID)) AND ((@IsNull_FIRMA4ID = 1 AND [FIRMA4ID] IS NULL) OR ([FIRMA4ID] = @Original_FIRMA4ID)) AND ((@IsNull_FIRMA5ID = 1 AND [FIRMA5ID] IS NULL) OR ([FIRMA5ID] = @Original_FIRMA5ID)) AND ((@IsNull_FIRMA6ID = 1 AND [FIRMA6ID] IS NULL) OR ([FIRMA6ID] = @Original_FIRMA6ID)) AND ((@IsNull_FIRMA7ID = 1 AND [FIRMA7ID] IS NULL) OR ([FIRMA7ID] = @Original_FIRMA7ID)) AND ((@IsNull_FIRMA8ID = 1 AND [FIRMA8ID] IS NULL) OR ([FIRMA8ID] = @Original_FIRMA8ID)) AND ((@IsNull_TALEPID = 1 AND [TALEPID] IS NULL) OR ([TALEPID] = @Original_TALEPID)) AND ((@IsNull_KOMUYE1ID = 1 AND [KOMUYE1ID] IS NULL) OR ([KOMUYE1ID] = @Original_KOMUYE1ID)) AND ((@IsNull_KOMUYE2ID = 1 AND [KOMUYE2ID] IS NULL) OR ([KOMUYE2ID] = @Original_KOMUYE2ID)) AND ((@IsNull_KOMBSKID = 1 AND [KOMBSKID] IS NULL) OR ([KOMBSKID] = @Original_KOMBSKID)) AND ((@IsNull_AITOLDBIRIM = 1 AND [AITOLDBIRIM] IS NULL) OR ([AITOLDBIRIM] = @Original_AITOLDBIRIM)) AND ((@IsNull_KESINLESTIR = 1 AND [KESINLESTIR] IS NULL) OR ([KESINLESTIR] = @Original_KESINLESTIR)) AND ((@IsNull_PIYASAUYE1ID = 1 AND [PIYASAUYE1ID] IS NULL) OR ([PIYASAUYE1ID] = @Original_PIYASAUYE1ID)) AND ((@IsNull_PIYASAUYE2ID = 1 AND [PIYASAUYE2ID] IS NULL) OR ([PIYASAUYE2ID] = @Original_PIYASAUYE2ID)) AND ((@IsNull_PIYASABSKID = 1 AND [PIYASABSKID] IS NULL) OR ([PIYASABSKID] = @Original_PIYASABSKID)));\r\nSELECT ID, KOD, TARIH, SAAT, TEKLIFKONUSU, KAZANANFIRMAID, FATURATARIHI, FATURANO, FATURATUTAR, KDVTUTAR, TOPLAMTUTAR, FATTUTARYAZIYLA, SAKARARTARIHI, SAKARARNO, IMZABIRIMAMIRIID, IMZAMUDURID, DAIREBSKID, OLURILGISI, SAVEUSER, SAVEDATE, EDITUSER, EDITDATE, SAVEMAC, EDITMAC, SAVEIP, EDITIP, FIRMA1ID, FIRMA2ID, FIRMA3ID, FIRMA4ID, FIRMA5ID, FIRMA6ID, FIRMA7ID, FIRMA8ID, TALEPID, KOMUYE1ID, KOMUYE2ID, KOMBSKID, AITOLDBIRIM, KESINLESTIR, PIYASAUYE1ID, PIYASAUYE2ID, PIYASABSKID FROM TBLTEKLIF WHERE (ID = @ID)";
      this._adapter.UpdateCommand.CommandType = CommandType.Text;
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@KOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TARIH", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TARIH", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SAAT", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAAT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TEKLIFKONUSU", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TEKLIFKONUSU", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@KAZANANFIRMAID", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KAZANANFIRMAID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@FATURATARIHI", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FATURATARIHI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@FATURANO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FATURANO", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@FATURATUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "FATURATUTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@KDVTUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "KDVTUTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TOPLAMTUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "TOPLAMTUTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@FATTUTARYAZIYLA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FATTUTARYAZIYLA", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SAKARARTARIHI", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAKARARTARIHI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SAKARARNO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAKARARNO", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IMZABIRIMAMIRIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IMZABIRIMAMIRIID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IMZAMUDURID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IMZAMUDURID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@DAIREBSKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DAIREBSKID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@OLURILGISI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "OLURILGISI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SAVEUSER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEUSER", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SAVEDATE", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEDATE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EDITUSER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITUSER", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EDITDATE", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITDATE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SAVEMAC", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEMAC", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EDITMAC", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITMAC", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SAVEIP", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEIP", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EDITIP", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITIP", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@FIRMA1ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA1ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@FIRMA2ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA2ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@FIRMA3ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA3ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@FIRMA4ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA4ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@FIRMA5ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA5ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@FIRMA6ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA6ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@FIRMA7ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA7ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@FIRMA8ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA8ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TALEPID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TALEPID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@KOMUYE1ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOMUYE1ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@KOMUYE2ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOMUYE2ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@KOMBSKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOMBSKID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@AITOLDBIRIM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AITOLDBIRIM", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@KESINLESTIR", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KESINLESTIR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@PIYASAUYE1ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PIYASAUYE1ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@PIYASAUYE2ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PIYASAUYE2ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@PIYASABSKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PIYASABSKID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_KOD", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_KOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TARIH", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TARIH", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TARIH", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TARIH", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SAAT", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAAT", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SAAT", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAAT", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TEKLIFKONUSU", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TEKLIFKONUSU", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TEKLIFKONUSU", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TEKLIFKONUSU", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_KAZANANFIRMAID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KAZANANFIRMAID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_KAZANANFIRMAID", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KAZANANFIRMAID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_FATURATARIHI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FATURATARIHI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_FATURATARIHI", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FATURATARIHI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_FATURANO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FATURANO", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_FATURANO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FATURANO", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_FATURATUTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FATURATUTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_FATURATUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "FATURATUTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_KDVTUTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KDVTUTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_KDVTUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "KDVTUTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TOPLAMTUTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TOPLAMTUTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TOPLAMTUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "TOPLAMTUTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_FATTUTARYAZIYLA", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FATTUTARYAZIYLA", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_FATTUTARYAZIYLA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FATTUTARYAZIYLA", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SAKARARTARIHI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAKARARTARIHI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SAKARARTARIHI", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAKARARTARIHI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SAKARARNO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAKARARNO", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SAKARARNO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAKARARNO", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_IMZABIRIMAMIRIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IMZABIRIMAMIRIID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_IMZABIRIMAMIRIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IMZABIRIMAMIRIID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_IMZAMUDURID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IMZAMUDURID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_IMZAMUDURID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IMZAMUDURID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_DAIREBSKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DAIREBSKID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_DAIREBSKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DAIREBSKID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_OLURILGISI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "OLURILGISI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_OLURILGISI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "OLURILGISI", DataRowVersion.Original, false, (object) null, "", "", ""));
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
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_FIRMA1ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA1ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_FIRMA1ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA1ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_FIRMA2ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA2ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_FIRMA2ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA2ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_FIRMA3ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA3ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_FIRMA3ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA3ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_FIRMA4ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA4ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_FIRMA4ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA4ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_FIRMA5ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA5ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_FIRMA5ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA5ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_FIRMA6ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA6ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_FIRMA6ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA6ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_FIRMA7ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA7ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_FIRMA7ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA7ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_FIRMA8ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA8ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_FIRMA8ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA8ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TALEPID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TALEPID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TALEPID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TALEPID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_KOMUYE1ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOMUYE1ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_KOMUYE1ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOMUYE1ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_KOMUYE2ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOMUYE2ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_KOMUYE2ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOMUYE2ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_KOMBSKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOMBSKID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_KOMBSKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOMBSKID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_AITOLDBIRIM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AITOLDBIRIM", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_AITOLDBIRIM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AITOLDBIRIM", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_KESINLESTIR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KESINLESTIR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_KESINLESTIR", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KESINLESTIR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_PIYASAUYE1ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PIYASAUYE1ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_PIYASAUYE1ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PIYASAUYE1ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_PIYASAUYE2ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PIYASAUYE2ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_PIYASAUYE2ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PIYASAUYE2ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_PIYASABSKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PIYASABSKID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_PIYASABSKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PIYASABSKID", DataRowVersion.Original, false, (object) null, "", "", ""));
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
      this._commandCollection[0].CommandText = "SELECT ID, KOD, TARIH, SAAT, TEKLIFKONUSU, KAZANANFIRMAID, FATURATARIHI, FATURANO, FATURATUTAR, KDVTUTAR, TOPLAMTUTAR, FATTUTARYAZIYLA, SAKARARTARIHI, SAKARARNO, IMZABIRIMAMIRIID, IMZAMUDURID, DAIREBSKID, OLURILGISI, SAVEUSER, SAVEDATE, EDITUSER, EDITDATE, SAVEMAC, EDITMAC, SAVEIP, EDITIP, FIRMA1ID, FIRMA2ID, FIRMA3ID, FIRMA4ID, FIRMA5ID, FIRMA6ID, FIRMA7ID, FIRMA8ID, TALEPID, KOMUYE1ID, KOMUYE2ID, KOMBSKID, AITOLDBIRIM, KESINLESTIR, PIYASAUYE1ID, PIYASAUYE2ID, PIYASABSKID FROM dbo.TBLTEKLIF";
      this._commandCollection[0].CommandType = CommandType.Text;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    public virtual int Fill(bellDataSet5.TBLTEKLIFDataTable dataTable)
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
    public virtual bellDataSet5.TBLTEKLIFDataTable GetData()
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      bellDataSet5.TBLTEKLIFDataTable data = new bellDataSet5.TBLTEKLIFDataTable();
      this.Adapter.Fill((DataTable) data);
      return data;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(bellDataSet5.TBLTEKLIFDataTable dataTable) => this.Adapter.Update((DataTable) dataTable);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(bellDataSet5 dataSet) => this.Adapter.Update((DataSet) dataSet, "TBLTEKLIF");

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
      DateTime? Original_TARIH,
      DateTime? Original_SAAT,
      string Original_TEKLIFKONUSU,
      string Original_KAZANANFIRMAID,
      DateTime? Original_FATURATARIHI,
      string Original_FATURANO,
      Decimal? Original_FATURATUTAR,
      Decimal? Original_KDVTUTAR,
      Decimal? Original_TOPLAMTUTAR,
      string Original_FATTUTARYAZIYLA,
      DateTime? Original_SAKARARTARIHI,
      int? Original_SAKARARNO,
      int? Original_IMZABIRIMAMIRIID,
      int? Original_IMZAMUDURID,
      int? Original_DAIREBSKID,
      string Original_OLURILGISI,
      string Original_SAVEUSER,
      DateTime? Original_SAVEDATE,
      string Original_EDITUSER,
      DateTime? Original_EDITDATE,
      string Original_SAVEMAC,
      string Original_EDITMAC,
      string Original_SAVEIP,
      string Original_EDITIP,
      int? Original_FIRMA1ID,
      int? Original_FIRMA2ID,
      int? Original_FIRMA3ID,
      int? Original_FIRMA4ID,
      int? Original_FIRMA5ID,
      int? Original_FIRMA6ID,
      int? Original_FIRMA7ID,
      int? Original_FIRMA8ID,
      int? Original_TALEPID,
      int? Original_KOMUYE1ID,
      int? Original_KOMUYE2ID,
      int? Original_KOMBSKID,
      int? Original_AITOLDBIRIM,
      string Original_KESINLESTIR,
      int? Original_PIYASAUYE1ID,
      int? Original_PIYASAUYE2ID,
      int? Original_PIYASABSKID)
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
      if (Original_TARIH.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[3].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[4].Value = (object) Original_TARIH.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[3].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[4].Value = (object) DBNull.Value;
      }
      if (Original_SAAT.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[6].Value = (object) Original_SAAT.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[6].Value = (object) DBNull.Value;
      }
      if (Original_TEKLIFKONUSU == null)
      {
        this.Adapter.DeleteCommand.Parameters[7].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[8].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[7].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[8].Value = (object) Original_TEKLIFKONUSU;
      }
      if (Original_KAZANANFIRMAID == null)
      {
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) Original_KAZANANFIRMAID;
      }
      if (Original_FATURATARIHI.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[11].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[12].Value = (object) Original_FATURATARIHI.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[11].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[12].Value = (object) DBNull.Value;
      }
      if (Original_FATURANO == null)
      {
        this.Adapter.DeleteCommand.Parameters[13].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[14].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[13].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[14].Value = (object) Original_FATURANO;
      }
      if (Original_FATURATUTAR.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[15].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[16].Value = (object) Original_FATURATUTAR.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[15].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[16].Value = (object) DBNull.Value;
      }
      if (Original_KDVTUTAR.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[17].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[18].Value = (object) Original_KDVTUTAR.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[17].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[18].Value = (object) DBNull.Value;
      }
      if (Original_TOPLAMTUTAR.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[19].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[20].Value = (object) Original_TOPLAMTUTAR.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[19].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[20].Value = (object) DBNull.Value;
      }
      if (Original_FATTUTARYAZIYLA == null)
      {
        this.Adapter.DeleteCommand.Parameters[21].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[22].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[21].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[22].Value = (object) Original_FATTUTARYAZIYLA;
      }
      if (Original_SAKARARTARIHI.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[23].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[24].Value = (object) Original_SAKARARTARIHI.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[23].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[24].Value = (object) DBNull.Value;
      }
      if (Original_SAKARARNO.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[25].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[26].Value = (object) Original_SAKARARNO.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[25].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[26].Value = (object) DBNull.Value;
      }
      if (Original_IMZABIRIMAMIRIID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[27].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[28].Value = (object) Original_IMZABIRIMAMIRIID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[27].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[28].Value = (object) DBNull.Value;
      }
      if (Original_IMZAMUDURID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[29].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[30].Value = (object) Original_IMZAMUDURID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[29].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[30].Value = (object) DBNull.Value;
      }
      if (Original_DAIREBSKID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[31].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[32].Value = (object) Original_DAIREBSKID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[31].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[32].Value = (object) DBNull.Value;
      }
      if (Original_OLURILGISI == null)
      {
        this.Adapter.DeleteCommand.Parameters[33].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[34].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[33].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[34].Value = (object) Original_OLURILGISI;
      }
      if (Original_SAVEUSER == null)
      {
        this.Adapter.DeleteCommand.Parameters[35].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[36].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[35].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[36].Value = (object) Original_SAVEUSER;
      }
      if (Original_SAVEDATE.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[37].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[38].Value = (object) Original_SAVEDATE.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[37].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[38].Value = (object) DBNull.Value;
      }
      if (Original_EDITUSER == null)
      {
        this.Adapter.DeleteCommand.Parameters[39].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[40].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[39].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[40].Value = (object) Original_EDITUSER;
      }
      if (Original_EDITDATE.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[41].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[42].Value = (object) Original_EDITDATE.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[41].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[42].Value = (object) DBNull.Value;
      }
      if (Original_SAVEMAC == null)
      {
        this.Adapter.DeleteCommand.Parameters[43].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[44].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[43].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[44].Value = (object) Original_SAVEMAC;
      }
      if (Original_EDITMAC == null)
      {
        this.Adapter.DeleteCommand.Parameters[45].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[46].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[45].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[46].Value = (object) Original_EDITMAC;
      }
      if (Original_SAVEIP == null)
      {
        this.Adapter.DeleteCommand.Parameters[47].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[48].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[47].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[48].Value = (object) Original_SAVEIP;
      }
      if (Original_EDITIP == null)
      {
        this.Adapter.DeleteCommand.Parameters[49].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[50].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[49].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[50].Value = (object) Original_EDITIP;
      }
      if (Original_FIRMA1ID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[51].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[52].Value = (object) Original_FIRMA1ID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[51].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[52].Value = (object) DBNull.Value;
      }
      if (Original_FIRMA2ID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[53].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[54].Value = (object) Original_FIRMA2ID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[53].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[54].Value = (object) DBNull.Value;
      }
      if (Original_FIRMA3ID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[55].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[56].Value = (object) Original_FIRMA3ID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[55].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[56].Value = (object) DBNull.Value;
      }
      if (Original_FIRMA4ID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[57].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[58].Value = (object) Original_FIRMA4ID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[57].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[58].Value = (object) DBNull.Value;
      }
      if (Original_FIRMA5ID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[59].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[60].Value = (object) Original_FIRMA5ID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[59].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[60].Value = (object) DBNull.Value;
      }
      if (Original_FIRMA6ID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[61].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[62].Value = (object) Original_FIRMA6ID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[61].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[62].Value = (object) DBNull.Value;
      }
      if (Original_FIRMA7ID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[63].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[64].Value = (object) Original_FIRMA7ID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[63].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[64].Value = (object) DBNull.Value;
      }
      if (Original_FIRMA8ID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[65].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[66].Value = (object) Original_FIRMA8ID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[65].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[66].Value = (object) DBNull.Value;
      }
      if (Original_TALEPID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[67].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[68].Value = (object) Original_TALEPID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[67].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[68].Value = (object) DBNull.Value;
      }
      if (Original_KOMUYE1ID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[69].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[70].Value = (object) Original_KOMUYE1ID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[69].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[70].Value = (object) DBNull.Value;
      }
      if (Original_KOMUYE2ID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[71].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[72].Value = (object) Original_KOMUYE2ID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[71].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[72].Value = (object) DBNull.Value;
      }
      if (Original_KOMBSKID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[73].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[74].Value = (object) Original_KOMBSKID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[73].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[74].Value = (object) DBNull.Value;
      }
      if (Original_AITOLDBIRIM.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[75].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[76].Value = (object) Original_AITOLDBIRIM.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[75].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[76].Value = (object) DBNull.Value;
      }
      if (Original_KESINLESTIR == null)
      {
        this.Adapter.DeleteCommand.Parameters[77].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[78].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[77].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[78].Value = (object) Original_KESINLESTIR;
      }
      if (Original_PIYASAUYE1ID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[79].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[80].Value = (object) Original_PIYASAUYE1ID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[79].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[80].Value = (object) DBNull.Value;
      }
      if (Original_PIYASAUYE2ID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[81].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[82].Value = (object) Original_PIYASAUYE2ID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[81].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[82].Value = (object) DBNull.Value;
      }
      if (Original_PIYASABSKID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[83].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[84].Value = (object) Original_PIYASABSKID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[83].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[84].Value = (object) DBNull.Value;
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
      DateTime? TARIH,
      DateTime? SAAT,
      string TEKLIFKONUSU,
      string KAZANANFIRMAID,
      DateTime? FATURATARIHI,
      string FATURANO,
      Decimal? FATURATUTAR,
      Decimal? KDVTUTAR,
      Decimal? TOPLAMTUTAR,
      string FATTUTARYAZIYLA,
      DateTime? SAKARARTARIHI,
      int? SAKARARNO,
      int? IMZABIRIMAMIRIID,
      int? IMZAMUDURID,
      int? DAIREBSKID,
      string OLURILGISI,
      string SAVEUSER,
      DateTime? SAVEDATE,
      string EDITUSER,
      DateTime? EDITDATE,
      string SAVEMAC,
      string EDITMAC,
      string SAVEIP,
      string EDITIP,
      int? FIRMA1ID,
      int? FIRMA2ID,
      int? FIRMA3ID,
      int? FIRMA4ID,
      int? FIRMA5ID,
      int? FIRMA6ID,
      int? FIRMA7ID,
      int? FIRMA8ID,
      int? TALEPID,
      int? KOMUYE1ID,
      int? KOMUYE2ID,
      int? KOMBSKID,
      int? AITOLDBIRIM,
      string KESINLESTIR,
      int? PIYASAUYE1ID,
      int? PIYASAUYE2ID,
      int? PIYASABSKID)
    {
      if (KOD == null)
        this.Adapter.InsertCommand.Parameters[0].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[0].Value = (object) KOD;
      if (TARIH.HasValue)
        this.Adapter.InsertCommand.Parameters[1].Value = (object) TARIH.Value;
      else
        this.Adapter.InsertCommand.Parameters[1].Value = (object) DBNull.Value;
      if (SAAT.HasValue)
        this.Adapter.InsertCommand.Parameters[2].Value = (object) SAAT.Value;
      else
        this.Adapter.InsertCommand.Parameters[2].Value = (object) DBNull.Value;
      if (TEKLIFKONUSU == null)
        this.Adapter.InsertCommand.Parameters[3].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[3].Value = (object) TEKLIFKONUSU;
      if (KAZANANFIRMAID == null)
        this.Adapter.InsertCommand.Parameters[4].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[4].Value = (object) KAZANANFIRMAID;
      if (FATURATARIHI.HasValue)
        this.Adapter.InsertCommand.Parameters[5].Value = (object) FATURATARIHI.Value;
      else
        this.Adapter.InsertCommand.Parameters[5].Value = (object) DBNull.Value;
      if (FATURANO == null)
        this.Adapter.InsertCommand.Parameters[6].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[6].Value = (object) FATURANO;
      if (FATURATUTAR.HasValue)
        this.Adapter.InsertCommand.Parameters[7].Value = (object) FATURATUTAR.Value;
      else
        this.Adapter.InsertCommand.Parameters[7].Value = (object) DBNull.Value;
      if (KDVTUTAR.HasValue)
        this.Adapter.InsertCommand.Parameters[8].Value = (object) KDVTUTAR.Value;
      else
        this.Adapter.InsertCommand.Parameters[8].Value = (object) DBNull.Value;
      if (TOPLAMTUTAR.HasValue)
        this.Adapter.InsertCommand.Parameters[9].Value = (object) TOPLAMTUTAR.Value;
      else
        this.Adapter.InsertCommand.Parameters[9].Value = (object) DBNull.Value;
      if (FATTUTARYAZIYLA == null)
        this.Adapter.InsertCommand.Parameters[10].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[10].Value = (object) FATTUTARYAZIYLA;
      if (SAKARARTARIHI.HasValue)
        this.Adapter.InsertCommand.Parameters[11].Value = (object) SAKARARTARIHI.Value;
      else
        this.Adapter.InsertCommand.Parameters[11].Value = (object) DBNull.Value;
      if (SAKARARNO.HasValue)
        this.Adapter.InsertCommand.Parameters[12].Value = (object) SAKARARNO.Value;
      else
        this.Adapter.InsertCommand.Parameters[12].Value = (object) DBNull.Value;
      if (IMZABIRIMAMIRIID.HasValue)
        this.Adapter.InsertCommand.Parameters[13].Value = (object) IMZABIRIMAMIRIID.Value;
      else
        this.Adapter.InsertCommand.Parameters[13].Value = (object) DBNull.Value;
      if (IMZAMUDURID.HasValue)
        this.Adapter.InsertCommand.Parameters[14].Value = (object) IMZAMUDURID.Value;
      else
        this.Adapter.InsertCommand.Parameters[14].Value = (object) DBNull.Value;
      if (DAIREBSKID.HasValue)
        this.Adapter.InsertCommand.Parameters[15].Value = (object) DAIREBSKID.Value;
      else
        this.Adapter.InsertCommand.Parameters[15].Value = (object) DBNull.Value;
      if (OLURILGISI == null)
        this.Adapter.InsertCommand.Parameters[16].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[16].Value = (object) OLURILGISI;
      if (SAVEUSER == null)
        this.Adapter.InsertCommand.Parameters[17].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[17].Value = (object) SAVEUSER;
      if (SAVEDATE.HasValue)
        this.Adapter.InsertCommand.Parameters[18].Value = (object) SAVEDATE.Value;
      else
        this.Adapter.InsertCommand.Parameters[18].Value = (object) DBNull.Value;
      if (EDITUSER == null)
        this.Adapter.InsertCommand.Parameters[19].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[19].Value = (object) EDITUSER;
      if (EDITDATE.HasValue)
        this.Adapter.InsertCommand.Parameters[20].Value = (object) EDITDATE.Value;
      else
        this.Adapter.InsertCommand.Parameters[20].Value = (object) DBNull.Value;
      if (SAVEMAC == null)
        this.Adapter.InsertCommand.Parameters[21].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[21].Value = (object) SAVEMAC;
      if (EDITMAC == null)
        this.Adapter.InsertCommand.Parameters[22].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[22].Value = (object) EDITMAC;
      if (SAVEIP == null)
        this.Adapter.InsertCommand.Parameters[23].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[23].Value = (object) SAVEIP;
      if (EDITIP == null)
        this.Adapter.InsertCommand.Parameters[24].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[24].Value = (object) EDITIP;
      if (FIRMA1ID.HasValue)
        this.Adapter.InsertCommand.Parameters[25].Value = (object) FIRMA1ID.Value;
      else
        this.Adapter.InsertCommand.Parameters[25].Value = (object) DBNull.Value;
      if (FIRMA2ID.HasValue)
        this.Adapter.InsertCommand.Parameters[26].Value = (object) FIRMA2ID.Value;
      else
        this.Adapter.InsertCommand.Parameters[26].Value = (object) DBNull.Value;
      if (FIRMA3ID.HasValue)
        this.Adapter.InsertCommand.Parameters[27].Value = (object) FIRMA3ID.Value;
      else
        this.Adapter.InsertCommand.Parameters[27].Value = (object) DBNull.Value;
      if (FIRMA4ID.HasValue)
        this.Adapter.InsertCommand.Parameters[28].Value = (object) FIRMA4ID.Value;
      else
        this.Adapter.InsertCommand.Parameters[28].Value = (object) DBNull.Value;
      if (FIRMA5ID.HasValue)
        this.Adapter.InsertCommand.Parameters[29].Value = (object) FIRMA5ID.Value;
      else
        this.Adapter.InsertCommand.Parameters[29].Value = (object) DBNull.Value;
      if (FIRMA6ID.HasValue)
        this.Adapter.InsertCommand.Parameters[30].Value = (object) FIRMA6ID.Value;
      else
        this.Adapter.InsertCommand.Parameters[30].Value = (object) DBNull.Value;
      if (FIRMA7ID.HasValue)
        this.Adapter.InsertCommand.Parameters[31].Value = (object) FIRMA7ID.Value;
      else
        this.Adapter.InsertCommand.Parameters[31].Value = (object) DBNull.Value;
      if (FIRMA8ID.HasValue)
        this.Adapter.InsertCommand.Parameters[32].Value = (object) FIRMA8ID.Value;
      else
        this.Adapter.InsertCommand.Parameters[32].Value = (object) DBNull.Value;
      if (TALEPID.HasValue)
        this.Adapter.InsertCommand.Parameters[33].Value = (object) TALEPID.Value;
      else
        this.Adapter.InsertCommand.Parameters[33].Value = (object) DBNull.Value;
      if (KOMUYE1ID.HasValue)
        this.Adapter.InsertCommand.Parameters[34].Value = (object) KOMUYE1ID.Value;
      else
        this.Adapter.InsertCommand.Parameters[34].Value = (object) DBNull.Value;
      if (KOMUYE2ID.HasValue)
        this.Adapter.InsertCommand.Parameters[35].Value = (object) KOMUYE2ID.Value;
      else
        this.Adapter.InsertCommand.Parameters[35].Value = (object) DBNull.Value;
      if (KOMBSKID.HasValue)
        this.Adapter.InsertCommand.Parameters[36].Value = (object) KOMBSKID.Value;
      else
        this.Adapter.InsertCommand.Parameters[36].Value = (object) DBNull.Value;
      if (AITOLDBIRIM.HasValue)
        this.Adapter.InsertCommand.Parameters[37].Value = (object) AITOLDBIRIM.Value;
      else
        this.Adapter.InsertCommand.Parameters[37].Value = (object) DBNull.Value;
      if (KESINLESTIR == null)
        this.Adapter.InsertCommand.Parameters[38].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[38].Value = (object) KESINLESTIR;
      if (PIYASAUYE1ID.HasValue)
        this.Adapter.InsertCommand.Parameters[39].Value = (object) PIYASAUYE1ID.Value;
      else
        this.Adapter.InsertCommand.Parameters[39].Value = (object) DBNull.Value;
      if (PIYASAUYE2ID.HasValue)
        this.Adapter.InsertCommand.Parameters[40].Value = (object) PIYASAUYE2ID.Value;
      else
        this.Adapter.InsertCommand.Parameters[40].Value = (object) DBNull.Value;
      if (PIYASABSKID.HasValue)
        this.Adapter.InsertCommand.Parameters[41].Value = (object) PIYASABSKID.Value;
      else
        this.Adapter.InsertCommand.Parameters[41].Value = (object) DBNull.Value;
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
      DateTime? TARIH,
      DateTime? SAAT,
      string TEKLIFKONUSU,
      string KAZANANFIRMAID,
      DateTime? FATURATARIHI,
      string FATURANO,
      Decimal? FATURATUTAR,
      Decimal? KDVTUTAR,
      Decimal? TOPLAMTUTAR,
      string FATTUTARYAZIYLA,
      DateTime? SAKARARTARIHI,
      int? SAKARARNO,
      int? IMZABIRIMAMIRIID,
      int? IMZAMUDURID,
      int? DAIREBSKID,
      string OLURILGISI,
      string SAVEUSER,
      DateTime? SAVEDATE,
      string EDITUSER,
      DateTime? EDITDATE,
      string SAVEMAC,
      string EDITMAC,
      string SAVEIP,
      string EDITIP,
      int? FIRMA1ID,
      int? FIRMA2ID,
      int? FIRMA3ID,
      int? FIRMA4ID,
      int? FIRMA5ID,
      int? FIRMA6ID,
      int? FIRMA7ID,
      int? FIRMA8ID,
      int? TALEPID,
      int? KOMUYE1ID,
      int? KOMUYE2ID,
      int? KOMBSKID,
      int? AITOLDBIRIM,
      string KESINLESTIR,
      int? PIYASAUYE1ID,
      int? PIYASAUYE2ID,
      int? PIYASABSKID,
      int Original_ID,
      string Original_KOD,
      DateTime? Original_TARIH,
      DateTime? Original_SAAT,
      string Original_TEKLIFKONUSU,
      string Original_KAZANANFIRMAID,
      DateTime? Original_FATURATARIHI,
      string Original_FATURANO,
      Decimal? Original_FATURATUTAR,
      Decimal? Original_KDVTUTAR,
      Decimal? Original_TOPLAMTUTAR,
      string Original_FATTUTARYAZIYLA,
      DateTime? Original_SAKARARTARIHI,
      int? Original_SAKARARNO,
      int? Original_IMZABIRIMAMIRIID,
      int? Original_IMZAMUDURID,
      int? Original_DAIREBSKID,
      string Original_OLURILGISI,
      string Original_SAVEUSER,
      DateTime? Original_SAVEDATE,
      string Original_EDITUSER,
      DateTime? Original_EDITDATE,
      string Original_SAVEMAC,
      string Original_EDITMAC,
      string Original_SAVEIP,
      string Original_EDITIP,
      int? Original_FIRMA1ID,
      int? Original_FIRMA2ID,
      int? Original_FIRMA3ID,
      int? Original_FIRMA4ID,
      int? Original_FIRMA5ID,
      int? Original_FIRMA6ID,
      int? Original_FIRMA7ID,
      int? Original_FIRMA8ID,
      int? Original_TALEPID,
      int? Original_KOMUYE1ID,
      int? Original_KOMUYE2ID,
      int? Original_KOMBSKID,
      int? Original_AITOLDBIRIM,
      string Original_KESINLESTIR,
      int? Original_PIYASAUYE1ID,
      int? Original_PIYASAUYE2ID,
      int? Original_PIYASABSKID,
      int ID)
    {
      if (KOD == null)
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) KOD;
      if (TARIH.HasValue)
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) TARIH.Value;
      else
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) DBNull.Value;
      if (SAAT.HasValue)
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) SAAT.Value;
      else
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) DBNull.Value;
      if (TEKLIFKONUSU == null)
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) TEKLIFKONUSU;
      if (KAZANANFIRMAID == null)
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) KAZANANFIRMAID;
      if (FATURATARIHI.HasValue)
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) FATURATARIHI.Value;
      else
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) DBNull.Value;
      if (FATURANO == null)
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) FATURANO;
      if (FATURATUTAR.HasValue)
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) FATURATUTAR.Value;
      else
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) DBNull.Value;
      if (KDVTUTAR.HasValue)
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) KDVTUTAR.Value;
      else
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) DBNull.Value;
      if (TOPLAMTUTAR.HasValue)
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) TOPLAMTUTAR.Value;
      else
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) DBNull.Value;
      if (FATTUTARYAZIYLA == null)
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) FATTUTARYAZIYLA;
      if (SAKARARTARIHI.HasValue)
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) SAKARARTARIHI.Value;
      else
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) DBNull.Value;
      if (SAKARARNO.HasValue)
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) SAKARARNO.Value;
      else
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) DBNull.Value;
      if (IMZABIRIMAMIRIID.HasValue)
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) IMZABIRIMAMIRIID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) DBNull.Value;
      if (IMZAMUDURID.HasValue)
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) IMZAMUDURID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) DBNull.Value;
      if (DAIREBSKID.HasValue)
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) DAIREBSKID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) DBNull.Value;
      if (OLURILGISI == null)
        this.Adapter.UpdateCommand.Parameters[16].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[16].Value = (object) OLURILGISI;
      if (SAVEUSER == null)
        this.Adapter.UpdateCommand.Parameters[17].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[17].Value = (object) SAVEUSER;
      if (SAVEDATE.HasValue)
        this.Adapter.UpdateCommand.Parameters[18].Value = (object) SAVEDATE.Value;
      else
        this.Adapter.UpdateCommand.Parameters[18].Value = (object) DBNull.Value;
      if (EDITUSER == null)
        this.Adapter.UpdateCommand.Parameters[19].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[19].Value = (object) EDITUSER;
      if (EDITDATE.HasValue)
        this.Adapter.UpdateCommand.Parameters[20].Value = (object) EDITDATE.Value;
      else
        this.Adapter.UpdateCommand.Parameters[20].Value = (object) DBNull.Value;
      if (SAVEMAC == null)
        this.Adapter.UpdateCommand.Parameters[21].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[21].Value = (object) SAVEMAC;
      if (EDITMAC == null)
        this.Adapter.UpdateCommand.Parameters[22].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[22].Value = (object) EDITMAC;
      if (SAVEIP == null)
        this.Adapter.UpdateCommand.Parameters[23].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[23].Value = (object) SAVEIP;
      if (EDITIP == null)
        this.Adapter.UpdateCommand.Parameters[24].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[24].Value = (object) EDITIP;
      if (FIRMA1ID.HasValue)
        this.Adapter.UpdateCommand.Parameters[25].Value = (object) FIRMA1ID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[25].Value = (object) DBNull.Value;
      if (FIRMA2ID.HasValue)
        this.Adapter.UpdateCommand.Parameters[26].Value = (object) FIRMA2ID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[26].Value = (object) DBNull.Value;
      if (FIRMA3ID.HasValue)
        this.Adapter.UpdateCommand.Parameters[27].Value = (object) FIRMA3ID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[27].Value = (object) DBNull.Value;
      if (FIRMA4ID.HasValue)
        this.Adapter.UpdateCommand.Parameters[28].Value = (object) FIRMA4ID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[28].Value = (object) DBNull.Value;
      if (FIRMA5ID.HasValue)
        this.Adapter.UpdateCommand.Parameters[29].Value = (object) FIRMA5ID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[29].Value = (object) DBNull.Value;
      if (FIRMA6ID.HasValue)
        this.Adapter.UpdateCommand.Parameters[30].Value = (object) FIRMA6ID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[30].Value = (object) DBNull.Value;
      if (FIRMA7ID.HasValue)
        this.Adapter.UpdateCommand.Parameters[31].Value = (object) FIRMA7ID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[31].Value = (object) DBNull.Value;
      if (FIRMA8ID.HasValue)
        this.Adapter.UpdateCommand.Parameters[32].Value = (object) FIRMA8ID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[32].Value = (object) DBNull.Value;
      if (TALEPID.HasValue)
        this.Adapter.UpdateCommand.Parameters[33].Value = (object) TALEPID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[33].Value = (object) DBNull.Value;
      if (KOMUYE1ID.HasValue)
        this.Adapter.UpdateCommand.Parameters[34].Value = (object) KOMUYE1ID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[34].Value = (object) DBNull.Value;
      if (KOMUYE2ID.HasValue)
        this.Adapter.UpdateCommand.Parameters[35].Value = (object) KOMUYE2ID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[35].Value = (object) DBNull.Value;
      if (KOMBSKID.HasValue)
        this.Adapter.UpdateCommand.Parameters[36].Value = (object) KOMBSKID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[36].Value = (object) DBNull.Value;
      if (AITOLDBIRIM.HasValue)
        this.Adapter.UpdateCommand.Parameters[37].Value = (object) AITOLDBIRIM.Value;
      else
        this.Adapter.UpdateCommand.Parameters[37].Value = (object) DBNull.Value;
      if (KESINLESTIR == null)
        this.Adapter.UpdateCommand.Parameters[38].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[38].Value = (object) KESINLESTIR;
      if (PIYASAUYE1ID.HasValue)
        this.Adapter.UpdateCommand.Parameters[39].Value = (object) PIYASAUYE1ID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[39].Value = (object) DBNull.Value;
      if (PIYASAUYE2ID.HasValue)
        this.Adapter.UpdateCommand.Parameters[40].Value = (object) PIYASAUYE2ID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[40].Value = (object) DBNull.Value;
      if (PIYASABSKID.HasValue)
        this.Adapter.UpdateCommand.Parameters[41].Value = (object) PIYASABSKID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[41].Value = (object) DBNull.Value;
      this.Adapter.UpdateCommand.Parameters[42].Value = (object) Original_ID;
      if (Original_KOD == null)
      {
        this.Adapter.UpdateCommand.Parameters[43].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[44].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[43].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[44].Value = (object) Original_KOD;
      }
      if (Original_TARIH.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[45].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[46].Value = (object) Original_TARIH.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[45].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[46].Value = (object) DBNull.Value;
      }
      if (Original_SAAT.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[47].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[48].Value = (object) Original_SAAT.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[47].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[48].Value = (object) DBNull.Value;
      }
      if (Original_TEKLIFKONUSU == null)
      {
        this.Adapter.UpdateCommand.Parameters[49].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[50].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[49].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[50].Value = (object) Original_TEKLIFKONUSU;
      }
      if (Original_KAZANANFIRMAID == null)
      {
        this.Adapter.UpdateCommand.Parameters[51].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[52].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[51].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[52].Value = (object) Original_KAZANANFIRMAID;
      }
      if (Original_FATURATARIHI.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[53].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[54].Value = (object) Original_FATURATARIHI.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[53].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[54].Value = (object) DBNull.Value;
      }
      if (Original_FATURANO == null)
      {
        this.Adapter.UpdateCommand.Parameters[55].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[56].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[55].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[56].Value = (object) Original_FATURANO;
      }
      if (Original_FATURATUTAR.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[57].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[58].Value = (object) Original_FATURATUTAR.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[57].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[58].Value = (object) DBNull.Value;
      }
      if (Original_KDVTUTAR.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[59].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[60].Value = (object) Original_KDVTUTAR.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[59].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[60].Value = (object) DBNull.Value;
      }
      if (Original_TOPLAMTUTAR.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[61].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[62].Value = (object) Original_TOPLAMTUTAR.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[61].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[62].Value = (object) DBNull.Value;
      }
      if (Original_FATTUTARYAZIYLA == null)
      {
        this.Adapter.UpdateCommand.Parameters[63].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[64].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[63].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[64].Value = (object) Original_FATTUTARYAZIYLA;
      }
      if (Original_SAKARARTARIHI.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[65].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[66].Value = (object) Original_SAKARARTARIHI.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[65].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[66].Value = (object) DBNull.Value;
      }
      if (Original_SAKARARNO.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[67].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[68].Value = (object) Original_SAKARARNO.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[67].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[68].Value = (object) DBNull.Value;
      }
      if (Original_IMZABIRIMAMIRIID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[69].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[70].Value = (object) Original_IMZABIRIMAMIRIID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[69].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[70].Value = (object) DBNull.Value;
      }
      if (Original_IMZAMUDURID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[71].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[72].Value = (object) Original_IMZAMUDURID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[71].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[72].Value = (object) DBNull.Value;
      }
      if (Original_DAIREBSKID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[73].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[74].Value = (object) Original_DAIREBSKID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[73].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[74].Value = (object) DBNull.Value;
      }
      if (Original_OLURILGISI == null)
      {
        this.Adapter.UpdateCommand.Parameters[75].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[76].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[75].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[76].Value = (object) Original_OLURILGISI;
      }
      if (Original_SAVEUSER == null)
      {
        this.Adapter.UpdateCommand.Parameters[77].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[78].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[77].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[78].Value = (object) Original_SAVEUSER;
      }
      if (Original_SAVEDATE.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[79].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[80].Value = (object) Original_SAVEDATE.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[79].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[80].Value = (object) DBNull.Value;
      }
      if (Original_EDITUSER == null)
      {
        this.Adapter.UpdateCommand.Parameters[81].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[82].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[81].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[82].Value = (object) Original_EDITUSER;
      }
      if (Original_EDITDATE.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[83].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[84].Value = (object) Original_EDITDATE.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[83].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[84].Value = (object) DBNull.Value;
      }
      if (Original_SAVEMAC == null)
      {
        this.Adapter.UpdateCommand.Parameters[85].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[86].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[85].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[86].Value = (object) Original_SAVEMAC;
      }
      if (Original_EDITMAC == null)
      {
        this.Adapter.UpdateCommand.Parameters[87].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[88].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[87].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[88].Value = (object) Original_EDITMAC;
      }
      if (Original_SAVEIP == null)
      {
        this.Adapter.UpdateCommand.Parameters[89].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[90].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[89].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[90].Value = (object) Original_SAVEIP;
      }
      if (Original_EDITIP == null)
      {
        this.Adapter.UpdateCommand.Parameters[91].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[92].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[91].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[92].Value = (object) Original_EDITIP;
      }
      if (Original_FIRMA1ID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[93].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[94].Value = (object) Original_FIRMA1ID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[93].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[94].Value = (object) DBNull.Value;
      }
      if (Original_FIRMA2ID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[95].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[96].Value = (object) Original_FIRMA2ID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[95].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[96].Value = (object) DBNull.Value;
      }
      if (Original_FIRMA3ID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[97].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[98].Value = (object) Original_FIRMA3ID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[97].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[98].Value = (object) DBNull.Value;
      }
      if (Original_FIRMA4ID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[99].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[100].Value = (object) Original_FIRMA4ID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[99].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[100].Value = (object) DBNull.Value;
      }
      if (Original_FIRMA5ID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[101].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[102].Value = (object) Original_FIRMA5ID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[101].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[102].Value = (object) DBNull.Value;
      }
      if (Original_FIRMA6ID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[103].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[104].Value = (object) Original_FIRMA6ID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[103].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[104].Value = (object) DBNull.Value;
      }
      if (Original_FIRMA7ID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[105].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[106].Value = (object) Original_FIRMA7ID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[105].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[106].Value = (object) DBNull.Value;
      }
      if (Original_FIRMA8ID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[107].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[108].Value = (object) Original_FIRMA8ID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[107].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[108].Value = (object) DBNull.Value;
      }
      if (Original_TALEPID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[109].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[110].Value = (object) Original_TALEPID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[109].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[110].Value = (object) DBNull.Value;
      }
      if (Original_KOMUYE1ID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[111].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[112].Value = (object) Original_KOMUYE1ID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[111].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[112].Value = (object) DBNull.Value;
      }
      if (Original_KOMUYE2ID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[113].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[114].Value = (object) Original_KOMUYE2ID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[113].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[114].Value = (object) DBNull.Value;
      }
      if (Original_KOMBSKID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[115].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[116].Value = (object) Original_KOMBSKID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[115].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[116].Value = (object) DBNull.Value;
      }
      if (Original_AITOLDBIRIM.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[117].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[118].Value = (object) Original_AITOLDBIRIM.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[117].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[118].Value = (object) DBNull.Value;
      }
      if (Original_KESINLESTIR == null)
      {
        this.Adapter.UpdateCommand.Parameters[119].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[120].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[119].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[120].Value = (object) Original_KESINLESTIR;
      }
      if (Original_PIYASAUYE1ID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[121].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[122].Value = (object) Original_PIYASAUYE1ID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[121].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[122].Value = (object) DBNull.Value;
      }
      if (Original_PIYASAUYE2ID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[123].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[124].Value = (object) Original_PIYASAUYE2ID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[123].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[124].Value = (object) DBNull.Value;
      }
      if (Original_PIYASABSKID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[125].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[126].Value = (object) Original_PIYASABSKID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[125].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[126].Value = (object) DBNull.Value;
      }
      this.Adapter.UpdateCommand.Parameters[(int) sbyte.MaxValue].Value = (object) ID;
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
      DateTime? TARIH,
      DateTime? SAAT,
      string TEKLIFKONUSU,
      string KAZANANFIRMAID,
      DateTime? FATURATARIHI,
      string FATURANO,
      Decimal? FATURATUTAR,
      Decimal? KDVTUTAR,
      Decimal? TOPLAMTUTAR,
      string FATTUTARYAZIYLA,
      DateTime? SAKARARTARIHI,
      int? SAKARARNO,
      int? IMZABIRIMAMIRIID,
      int? IMZAMUDURID,
      int? DAIREBSKID,
      string OLURILGISI,
      string SAVEUSER,
      DateTime? SAVEDATE,
      string EDITUSER,
      DateTime? EDITDATE,
      string SAVEMAC,
      string EDITMAC,
      string SAVEIP,
      string EDITIP,
      int? FIRMA1ID,
      int? FIRMA2ID,
      int? FIRMA3ID,
      int? FIRMA4ID,
      int? FIRMA5ID,
      int? FIRMA6ID,
      int? FIRMA7ID,
      int? FIRMA8ID,
      int? TALEPID,
      int? KOMUYE1ID,
      int? KOMUYE2ID,
      int? KOMBSKID,
      int? AITOLDBIRIM,
      string KESINLESTIR,
      int? PIYASAUYE1ID,
      int? PIYASAUYE2ID,
      int? PIYASABSKID,
      int Original_ID,
      string Original_KOD,
      DateTime? Original_TARIH,
      DateTime? Original_SAAT,
      string Original_TEKLIFKONUSU,
      string Original_KAZANANFIRMAID,
      DateTime? Original_FATURATARIHI,
      string Original_FATURANO,
      Decimal? Original_FATURATUTAR,
      Decimal? Original_KDVTUTAR,
      Decimal? Original_TOPLAMTUTAR,
      string Original_FATTUTARYAZIYLA,
      DateTime? Original_SAKARARTARIHI,
      int? Original_SAKARARNO,
      int? Original_IMZABIRIMAMIRIID,
      int? Original_IMZAMUDURID,
      int? Original_DAIREBSKID,
      string Original_OLURILGISI,
      string Original_SAVEUSER,
      DateTime? Original_SAVEDATE,
      string Original_EDITUSER,
      DateTime? Original_EDITDATE,
      string Original_SAVEMAC,
      string Original_EDITMAC,
      string Original_SAVEIP,
      string Original_EDITIP,
      int? Original_FIRMA1ID,
      int? Original_FIRMA2ID,
      int? Original_FIRMA3ID,
      int? Original_FIRMA4ID,
      int? Original_FIRMA5ID,
      int? Original_FIRMA6ID,
      int? Original_FIRMA7ID,
      int? Original_FIRMA8ID,
      int? Original_TALEPID,
      int? Original_KOMUYE1ID,
      int? Original_KOMUYE2ID,
      int? Original_KOMBSKID,
      int? Original_AITOLDBIRIM,
      string Original_KESINLESTIR,
      int? Original_PIYASAUYE1ID,
      int? Original_PIYASAUYE2ID,
      int? Original_PIYASABSKID)
    {
      return this.Update(KOD, TARIH, SAAT, TEKLIFKONUSU, KAZANANFIRMAID, FATURATARIHI, FATURANO, FATURATUTAR, KDVTUTAR, TOPLAMTUTAR, FATTUTARYAZIYLA, SAKARARTARIHI, SAKARARNO, IMZABIRIMAMIRIID, IMZAMUDURID, DAIREBSKID, OLURILGISI, SAVEUSER, SAVEDATE, EDITUSER, EDITDATE, SAVEMAC, EDITMAC, SAVEIP, EDITIP, FIRMA1ID, FIRMA2ID, FIRMA3ID, FIRMA4ID, FIRMA5ID, FIRMA6ID, FIRMA7ID, FIRMA8ID, TALEPID, KOMUYE1ID, KOMUYE2ID, KOMBSKID, AITOLDBIRIM, KESINLESTIR, PIYASAUYE1ID, PIYASAUYE2ID, PIYASABSKID, Original_ID, Original_KOD, Original_TARIH, Original_SAAT, Original_TEKLIFKONUSU, Original_KAZANANFIRMAID, Original_FATURATARIHI, Original_FATURANO, Original_FATURATUTAR, Original_KDVTUTAR, Original_TOPLAMTUTAR, Original_FATTUTARYAZIYLA, Original_SAKARARTARIHI, Original_SAKARARNO, Original_IMZABIRIMAMIRIID, Original_IMZAMUDURID, Original_DAIREBSKID, Original_OLURILGISI, Original_SAVEUSER, Original_SAVEDATE, Original_EDITUSER, Original_EDITDATE, Original_SAVEMAC, Original_EDITMAC, Original_SAVEIP, Original_EDITIP, Original_FIRMA1ID, Original_FIRMA2ID, Original_FIRMA3ID, Original_FIRMA4ID, Original_FIRMA5ID, Original_FIRMA6ID, Original_FIRMA7ID, Original_FIRMA8ID, Original_TALEPID, Original_KOMUYE1ID, Original_KOMUYE2ID, Original_KOMBSKID, Original_AITOLDBIRIM, Original_KESINLESTIR, Original_PIYASAUYE1ID, Original_PIYASAUYE2ID, Original_PIYASABSKID, Original_ID);
    }
  }
}
