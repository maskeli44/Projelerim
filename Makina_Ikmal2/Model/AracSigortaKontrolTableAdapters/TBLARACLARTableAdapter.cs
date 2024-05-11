// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Model.AracSigortaKontrolTableAdapters.TBLARACLARTableAdapter
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

namespace Makina_Ikmal.Model.AracSigortaKontrolTableAdapters
{
  [DesignerCategory("code")]
  [ToolboxItem(true)]
  [DataObject(true)]
  [Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [HelpKeyword("vs.data.TableAdapter")]
  public class TBLARACLARTableAdapter : Component
  {
    private SqlDataAdapter _adapter;
    private SqlConnection _connection;
    private SqlTransaction _transaction;
    private SqlCommand[] _commandCollection;
    private bool _clearBeforeFill;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public TBLARACLARTableAdapter() => this.ClearBeforeFill = true;

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
        DataSetTable = "TBLARACLAR",
        ColumnMappings = {
          {
            "Plaka",
            "Plaka"
          },
          {
            "Marka",
            "Marka"
          },
          {
            "Model",
            "Model"
          },
          {
            "Cinsi",
            "Cinsi"
          },
          {
            "Tipi",
            "Tipi"
          },
          {
            "Rengi",
            "Rengi"
          },
          {
            "Birim",
            "Birim"
          },
          {
            "ARACDURUMID",
            "ARACDURUMID"
          },
          {
            "ARACTIPIID",
            "ARACTIPIID"
          },
          {
            "ARACGRUBUID",
            "ARACGRUBUID"
          },
          {
            "TRAFIKSGORTA2",
            "TRAFIKSGORTA2"
          },
          {
            "Expr2",
            "Expr2"
          },
          {
            "aracID",
            "aracID"
          },
          {
            "kalanGun",
            "kalanGun"
          },
          {
            "Aciklama",
            "Aciklama"
          },
          {
            "verildigiIlce",
            "verildigiIlce"
          },
          {
            "tahsisPlaka",
            "tahsisPlaka"
          },
          {
            "ticariAdi",
            "ticariAdi"
          },
          {
            "mudurlık",
            "mudurlık"
          },
          {
            "belgoNo",
            "belgoNo"
          },
          {
            "motorNo",
            "motorNo"
          },
          {
            "saseNo",
            "saseNo"
          }
        }
      });
      this._adapter.DeleteCommand = new SqlCommand();
      this._adapter.DeleteCommand.Connection = this.Connection;
      this._adapter.DeleteCommand.CommandText = "DELETE FROM [TBLARACLAR] WHERE (([ID] = @Original_aracID) AND ((@IsNull_TRAFIKSGORTA2 = 1 AND [TRAFIKSGORTA2] IS NULL) OR ([TRAFIKSGORTA2] = @Original_TRAFIKSGORTA2)) AND ((@IsNull_Plaka = 1 AND [Plaka] IS NULL) OR ([Plaka] = @Original_Plaka)) AND ((@IsNull_Aciklama = 1 AND [ARACACIKLAMA] IS NULL) OR ([ARACACIKLAMA] = @Original_Aciklama)) AND ((@IsNull_verildigiIlce = 1 AND [VERILDIGIILILCE] IS NULL) OR ([VERILDIGIILILCE] = @Original_verildigiIlce)) AND ((@IsNull_tahsisPlaka = 1 AND [TAHSPLAKA] IS NULL) OR ([TAHSPLAKA] = @Original_tahsisPlaka)) AND ((@IsNull_Marka = 1 AND [MARKAID] IS NULL) OR ([MARKAID] = @Original_Marka)) AND ((@IsNull_Model = 1 AND [Model] IS NULL) OR ([Model] = @Original_Model)) AND ((@IsNull_Cinsi = 1 AND [CINSI] IS NULL) OR ([CINSI] = @Original_Cinsi)) AND ((@IsNull_ticariAdi = 1 AND [TICARIADI] IS NULL) OR ([TICARIADI] = @Original_ticariAdi)) AND ((@IsNull_Tipi = 1 AND [TIPI] IS NULL) OR ([TIPI] = @Original_Tipi)) AND ((@IsNull_Rengi = 1 AND [RENGI] IS NULL) OR ([RENGI] = @Original_Rengi)) AND ((@IsNull_Birim = 1 AND [BELDBIRIMID] IS NULL) OR ([BELDBIRIMID] = @Original_Birim)) AND ((@IsNull_mudurlık = 1 AND [BELDMUDURLUKID] IS NULL) OR ([BELDMUDURLUKID] = @Original_mudurlık)) AND ((@IsNull_ARACDURUMID = 1 AND [ARACDURUMID] IS NULL) OR ([ARACDURUMID] = @Original_ARACDURUMID)) AND ((@IsNull_ARACTIPIID = 1 AND [ARACTIPIID] IS NULL) OR ([ARACTIPIID] = @Original_ARACTIPIID)) AND ((@IsNull_ARACGRUBUID = 1 AND [ARACGRUBUID] IS NULL) OR ([ARACGRUBUID] = @Original_ARACGRUBUID)) AND ((@IsNull_Expr2 = 1 AND [TRAFIKSGORTA2] IS NULL) OR ([TRAFIKSGORTA2] = @Original_Expr2)) AND ((@IsNull_belgoNo = 1 AND [BELGESERINO] IS NULL) OR ([BELGESERINO] = @Original_belgoNo)) AND ((@IsNull_motorNo = 1 AND [motorNo] IS NULL) OR ([motorNo] = @Original_motorNo)) AND ((@IsNull_saseNo = 1 AND [saseNo] IS NULL) OR ([saseNo] = @Original_saseNo)))";
      this._adapter.DeleteCommand.CommandType = CommandType.Text;
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_aracID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "aracID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TRAFIKSGORTA2", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TRAFIKSGORTA2", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TRAFIKSGORTA2", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TRAFIKSGORTA2", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Plaka", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Plaka", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Plaka", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Plaka", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Aciklama", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Aciklama", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Aciklama", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Aciklama", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_verildigiIlce", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "verildigiIlce", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_verildigiIlce", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "verildigiIlce", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_tahsisPlaka", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "tahsisPlaka", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_tahsisPlaka", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "tahsisPlaka", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Marka", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Marka", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Marka", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Marka", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Model", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Model", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Model", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Model", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Cinsi", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Cinsi", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Cinsi", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Cinsi", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ticariAdi", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ticariAdi", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ticariAdi", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ticariAdi", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Tipi", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Tipi", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Tipi", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Tipi", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Rengi", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Rengi", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Rengi", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Rengi", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Birim", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Birim", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Birim", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Birim", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_mudurlık", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "mudurlık", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_mudurlık", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "mudurlık", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ARACDURUMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACDURUMID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ARACDURUMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACDURUMID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ARACTIPIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACTIPIID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ARACTIPIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACTIPIID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ARACGRUBUID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACGRUBUID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ARACGRUBUID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACGRUBUID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Expr2", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Expr2", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Expr2", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Expr2", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_belgoNo", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "belgoNo", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_belgoNo", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "belgoNo", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_motorNo", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "motorNo", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_motorNo", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "motorNo", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_saseNo", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "saseNo", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_saseNo", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "saseNo", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.InsertCommand = new SqlCommand();
      this._adapter.InsertCommand.Connection = this.Connection;
      this._adapter.InsertCommand.CommandText = "INSERT INTO [TBLARACLAR] ([TRAFIKSGORTA2], [Plaka], [ARACACIKLAMA], [VERILDIGIILILCE], [TAHSPLAKA], [MARKAID], [Model], [CINSI], [TICARIADI], [TIPI], [RENGI], [BELDBIRIMID], [BELDMUDURLUKID], [ARACDURUMID], [ARACTIPIID], [ARACGRUBUID], [TRAFIKSGORTA2], [BELGESERINO], [motorNo], [saseNo]) VALUES (@TRAFIKSGORTA2, @Plaka, @Aciklama, @verildigiIlce, @tahsisPlaka, @Marka, @Model, @Cinsi, @ticariAdi, @Tipi, @Rengi, @Birim, @mudurlık, @ARACDURUMID, @ARACTIPIID, @ARACGRUBUID, @Expr2, @belgoNo, @motorNo, @saseNo);\r\nSELECT ID AS aracID, DATEDIFF(day, GETDATE(), CASE WHEN IsDate(TRAFIKSGORTA2) = 1 THEN CONVERT (DateTime , TRAFIKSGORTA2 , 101) ELSE NULL END) AS kalanGun, TRAFIKSGORTA2, PLAKA AS Plaka, ARACACIKLAMA AS Aciklama, VERILDIGIILILCE AS verildigiIlce, TAHSPLAKA AS tahsisPlaka, MARKAID AS Marka, MODEL AS Model, CINSI AS Cinsi, TICARIADI AS ticariAdi, TIPI AS Tipi, RENGI AS Rengi, BELDBIRIMID AS Birim, BELDMUDURLUKID AS mudurlık, ARACDURUMID, ARACTIPIID, ARACGRUBUID, TRAFIKSGORTA2 AS Expr2, BELGESERINO AS belgoNo, MOTORNO AS motorNo, SASENO AS saseNo FROM TBLARACLAR WHERE (ID = SCOPE_IDENTITY())";
      this._adapter.InsertCommand.CommandType = CommandType.Text;
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@TRAFIKSGORTA2", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TRAFIKSGORTA2", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Plaka", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Plaka", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Aciklama", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Aciklama", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@verildigiIlce", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "verildigiIlce", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@tahsisPlaka", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "tahsisPlaka", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Marka", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Marka", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Model", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Model", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Cinsi", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Cinsi", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ticariAdi", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ticariAdi", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Tipi", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Tipi", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Rengi", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Rengi", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Birim", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Birim", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@mudurlık", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "mudurlık", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ARACDURUMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACDURUMID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ARACTIPIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACTIPIID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ARACGRUBUID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACGRUBUID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Expr2", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Expr2", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@belgoNo", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "belgoNo", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@motorNo", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "motorNo", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@saseNo", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "saseNo", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand = new SqlCommand();
      this._adapter.UpdateCommand.Connection = this.Connection;
      this._adapter.UpdateCommand.CommandText = "UPDATE [TBLARACLAR] SET [TRAFIKSGORTA2] = @TRAFIKSGORTA2, [Plaka] = @Plaka, [ARACACIKLAMA] = @Aciklama, [VERILDIGIILILCE] = @verildigiIlce, [TAHSPLAKA] = @tahsisPlaka, [MARKAID] = @Marka, [Model] = @Model, [CINSI] = @Cinsi, [TICARIADI] = @ticariAdi, [TIPI] = @Tipi, [RENGI] = @Rengi, [BELDBIRIMID] = @Birim, [BELDMUDURLUKID] = @mudurlık, [ARACDURUMID] = @ARACDURUMID, [ARACTIPIID] = @ARACTIPIID, [ARACGRUBUID] = @ARACGRUBUID, [TRAFIKSGORTA2] = @Expr2, [BELGESERINO] = @belgoNo, [motorNo] = @motorNo, [saseNo] = @saseNo WHERE (([ID] = @Original_aracID) AND ((@IsNull_TRAFIKSGORTA2 = 1 AND [TRAFIKSGORTA2] IS NULL) OR ([TRAFIKSGORTA2] = @Original_TRAFIKSGORTA2)) AND ((@IsNull_Plaka = 1 AND [Plaka] IS NULL) OR ([Plaka] = @Original_Plaka)) AND ((@IsNull_Aciklama = 1 AND [ARACACIKLAMA] IS NULL) OR ([ARACACIKLAMA] = @Original_Aciklama)) AND ((@IsNull_verildigiIlce = 1 AND [VERILDIGIILILCE] IS NULL) OR ([VERILDIGIILILCE] = @Original_verildigiIlce)) AND ((@IsNull_tahsisPlaka = 1 AND [TAHSPLAKA] IS NULL) OR ([TAHSPLAKA] = @Original_tahsisPlaka)) AND ((@IsNull_Marka = 1 AND [MARKAID] IS NULL) OR ([MARKAID] = @Original_Marka)) AND ((@IsNull_Model = 1 AND [Model] IS NULL) OR ([Model] = @Original_Model)) AND ((@IsNull_Cinsi = 1 AND [CINSI] IS NULL) OR ([CINSI] = @Original_Cinsi)) AND ((@IsNull_ticariAdi = 1 AND [TICARIADI] IS NULL) OR ([TICARIADI] = @Original_ticariAdi)) AND ((@IsNull_Tipi = 1 AND [TIPI] IS NULL) OR ([TIPI] = @Original_Tipi)) AND ((@IsNull_Rengi = 1 AND [RENGI] IS NULL) OR ([RENGI] = @Original_Rengi)) AND ((@IsNull_Birim = 1 AND [BELDBIRIMID] IS NULL) OR ([BELDBIRIMID] = @Original_Birim)) AND ((@IsNull_mudurlık = 1 AND [BELDMUDURLUKID] IS NULL) OR ([BELDMUDURLUKID] = @Original_mudurlık)) AND ((@IsNull_ARACDURUMID = 1 AND [ARACDURUMID] IS NULL) OR ([ARACDURUMID] = @Original_ARACDURUMID)) AND ((@IsNull_ARACTIPIID = 1 AND [ARACTIPIID] IS NULL) OR ([ARACTIPIID] = @Original_ARACTIPIID)) AND ((@IsNull_ARACGRUBUID = 1 AND [ARACGRUBUID] IS NULL) OR ([ARACGRUBUID] = @Original_ARACGRUBUID)) AND ((@IsNull_Expr2 = 1 AND [TRAFIKSGORTA2] IS NULL) OR ([TRAFIKSGORTA2] = @Original_Expr2)) AND ((@IsNull_belgoNo = 1 AND [BELGESERINO] IS NULL) OR ([BELGESERINO] = @Original_belgoNo)) AND ((@IsNull_motorNo = 1 AND [motorNo] IS NULL) OR ([motorNo] = @Original_motorNo)) AND ((@IsNull_saseNo = 1 AND [saseNo] IS NULL) OR ([saseNo] = @Original_saseNo)));\r\nSELECT ID AS aracID, DATEDIFF(day, GETDATE(), CASE WHEN IsDate(TRAFIKSGORTA2) = 1 THEN CONVERT (DateTime , TRAFIKSGORTA2 , 101) ELSE NULL END) AS kalanGun, TRAFIKSGORTA2, PLAKA AS Plaka, ARACACIKLAMA AS Aciklama, VERILDIGIILILCE AS verildigiIlce, TAHSPLAKA AS tahsisPlaka, MARKAID AS Marka, MODEL AS Model, CINSI AS Cinsi, TICARIADI AS ticariAdi, TIPI AS Tipi, RENGI AS Rengi, BELDBIRIMID AS Birim, BELDMUDURLUKID AS mudurlık, ARACDURUMID, ARACTIPIID, ARACGRUBUID, TRAFIKSGORTA2 AS Expr2, BELGESERINO AS belgoNo, MOTORNO AS motorNo, SASENO AS saseNo FROM TBLARACLAR WHERE (ID = @ID)";
      this._adapter.UpdateCommand.CommandType = CommandType.Text;
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TRAFIKSGORTA2", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TRAFIKSGORTA2", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Plaka", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Plaka", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Aciklama", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Aciklama", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@verildigiIlce", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "verildigiIlce", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@tahsisPlaka", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "tahsisPlaka", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Marka", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Marka", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Model", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Model", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Cinsi", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Cinsi", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ticariAdi", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ticariAdi", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Tipi", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Tipi", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Rengi", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Rengi", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Birim", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Birim", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@mudurlık", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "mudurlık", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ARACDURUMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACDURUMID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ARACTIPIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACTIPIID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ARACGRUBUID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACGRUBUID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Expr2", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Expr2", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@belgoNo", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "belgoNo", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@motorNo", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "motorNo", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@saseNo", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "saseNo", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_aracID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "aracID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TRAFIKSGORTA2", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TRAFIKSGORTA2", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TRAFIKSGORTA2", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TRAFIKSGORTA2", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Plaka", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Plaka", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Plaka", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Plaka", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Aciklama", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Aciklama", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Aciklama", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Aciklama", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_verildigiIlce", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "verildigiIlce", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_verildigiIlce", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "verildigiIlce", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_tahsisPlaka", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "tahsisPlaka", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_tahsisPlaka", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "tahsisPlaka", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Marka", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Marka", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Marka", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Marka", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Model", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Model", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Model", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Model", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Cinsi", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Cinsi", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Cinsi", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Cinsi", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ticariAdi", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ticariAdi", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ticariAdi", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ticariAdi", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Tipi", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Tipi", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Tipi", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Tipi", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Rengi", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Rengi", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Rengi", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Rengi", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Birim", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Birim", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Birim", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Birim", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_mudurlık", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "mudurlık", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_mudurlık", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "mudurlık", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ARACDURUMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACDURUMID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ARACDURUMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACDURUMID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ARACTIPIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACTIPIID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ARACTIPIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACTIPIID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ARACGRUBUID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACGRUBUID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ARACGRUBUID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACGRUBUID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Expr2", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Expr2", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Expr2", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Expr2", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_belgoNo", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "belgoNo", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_belgoNo", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "belgoNo", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_motorNo", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "motorNo", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_motorNo", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "motorNo", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_saseNo", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "saseNo", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_saseNo", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "saseNo", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, (byte) 0, (byte) 0, "aracID", DataRowVersion.Current, false, (object) null, "", "", ""));
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
      this._commandCollection[0].CommandText = "SELECT        ID AS aracID, DATEDIFF(day, GETDATE(), CASE WHEN IsDate(TRAFIKSGORTA2) = 1 THEN CONVERT(DateTime, TRAFIKSGORTA2, 101) ELSE NULL END) AS kalanGun, TRAFIKSGORTA2, PLAKA AS Plaka, \r\n                         ARACACIKLAMA AS Aciklama, VERILDIGIILILCE AS verildigiIlce, TAHSPLAKA AS tahsisPlaka, MARKAID AS Marka, MODEL AS Model, CINSI AS Cinsi, TICARIADI AS ticariAdi, TIPI AS Tipi, RENGI AS Rengi, BELDBIRIMID AS Birim, \r\n                         BELDMUDURLUKID AS mudurlık, ARACDURUMID, ARACTIPIID, ARACGRUBUID, TRAFIKSGORTA2 AS Expr2, BELGESERINO AS belgoNo, MOTORNO AS motorNo, SASENO AS saseNo\r\nFROM            TBLARACLAR\r\nWHERE        (ARACDURUMID = 1 OR\r\n                         ARACDURUMID = 3) AND (ARACTIPIID = 1) AND (ARACGRUBUID <> 111)";
      this._commandCollection[0].CommandType = CommandType.Text;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    public virtual int Fill(AracSigortaKontrol.TBLARACLARDataTable dataTable)
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
    public virtual AracSigortaKontrol.TBLARACLARDataTable GetData()
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      AracSigortaKontrol.TBLARACLARDataTable data = new AracSigortaKontrol.TBLARACLARDataTable();
      this.Adapter.Fill((DataTable) data);
      return data;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(AracSigortaKontrol.TBLARACLARDataTable dataTable) => this.Adapter.Update((DataTable) dataTable);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(AracSigortaKontrol dataSet) => this.Adapter.Update((DataSet) dataSet, "TBLARACLAR");

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
      int Original_aracID,
      DateTime? Original_TRAFIKSGORTA2,
      string Original_Plaka,
      string Original_Aciklama,
      string Original_verildigiIlce,
      string Original_tahsisPlaka,
      int Original_Marka,
      string Original_Model,
      string Original_Cinsi,
      string Original_ticariAdi,
      string Original_Tipi,
      string Original_Rengi,
      int Original_Birim,
      int Original_mudurlık,
      int? Original_ARACDURUMID,
      int? Original_ARACTIPIID,
      int? Original_ARACGRUBUID,
      DateTime Original_Expr2,
      string Original_belgoNo,
      string Original_motorNo,
      string Original_saseNo)
    {
      this.Adapter.DeleteCommand.Parameters[0].Value = (object) Original_aracID;
      if (Original_TRAFIKSGORTA2.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[1].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[2].Value = (object) Original_TRAFIKSGORTA2.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[1].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[2].Value = (object) DBNull.Value;
      }
      if (Original_Plaka == null)
        throw new ArgumentNullException(nameof (Original_Plaka));
      this.Adapter.DeleteCommand.Parameters[3].Value = (object) 0;
      this.Adapter.DeleteCommand.Parameters[4].Value = (object) Original_Plaka;
      if (Original_Aciklama == null)
        throw new ArgumentNullException(nameof (Original_Aciklama));
      this.Adapter.DeleteCommand.Parameters[5].Value = (object) 0;
      this.Adapter.DeleteCommand.Parameters[6].Value = (object) Original_Aciklama;
      if (Original_verildigiIlce == null)
        throw new ArgumentNullException(nameof (Original_verildigiIlce));
      this.Adapter.DeleteCommand.Parameters[7].Value = (object) 0;
      this.Adapter.DeleteCommand.Parameters[8].Value = (object) Original_verildigiIlce;
      if (Original_tahsisPlaka == null)
        throw new ArgumentNullException(nameof (Original_tahsisPlaka));
      this.Adapter.DeleteCommand.Parameters[9].Value = (object) 0;
      this.Adapter.DeleteCommand.Parameters[10].Value = (object) Original_tahsisPlaka;
      this.Adapter.DeleteCommand.Parameters[11].Value = (object) 0;
      this.Adapter.DeleteCommand.Parameters[12].Value = (object) Original_Marka;
      if (Original_Model == null)
        throw new ArgumentNullException(nameof (Original_Model));
      this.Adapter.DeleteCommand.Parameters[13].Value = (object) 0;
      this.Adapter.DeleteCommand.Parameters[14].Value = (object) Original_Model;
      if (Original_Cinsi == null)
        throw new ArgumentNullException(nameof (Original_Cinsi));
      this.Adapter.DeleteCommand.Parameters[15].Value = (object) 0;
      this.Adapter.DeleteCommand.Parameters[16].Value = (object) Original_Cinsi;
      if (Original_ticariAdi == null)
        throw new ArgumentNullException(nameof (Original_ticariAdi));
      this.Adapter.DeleteCommand.Parameters[17].Value = (object) 0;
      this.Adapter.DeleteCommand.Parameters[18].Value = (object) Original_ticariAdi;
      if (Original_Tipi == null)
        throw new ArgumentNullException(nameof (Original_Tipi));
      this.Adapter.DeleteCommand.Parameters[19].Value = (object) 0;
      this.Adapter.DeleteCommand.Parameters[20].Value = (object) Original_Tipi;
      if (Original_Rengi == null)
        throw new ArgumentNullException(nameof (Original_Rengi));
      this.Adapter.DeleteCommand.Parameters[21].Value = (object) 0;
      this.Adapter.DeleteCommand.Parameters[22].Value = (object) Original_Rengi;
      this.Adapter.DeleteCommand.Parameters[23].Value = (object) 0;
      this.Adapter.DeleteCommand.Parameters[24].Value = (object) Original_Birim;
      this.Adapter.DeleteCommand.Parameters[25].Value = (object) 0;
      this.Adapter.DeleteCommand.Parameters[26].Value = (object) Original_mudurlık;
      if (Original_ARACDURUMID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[27].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[28].Value = (object) Original_ARACDURUMID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[27].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[28].Value = (object) DBNull.Value;
      }
      if (Original_ARACTIPIID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[29].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[30].Value = (object) Original_ARACTIPIID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[29].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[30].Value = (object) DBNull.Value;
      }
      if (Original_ARACGRUBUID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[31].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[32].Value = (object) Original_ARACGRUBUID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[31].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[32].Value = (object) DBNull.Value;
      }
      this.Adapter.DeleteCommand.Parameters[33].Value = (object) 0;
      this.Adapter.DeleteCommand.Parameters[34].Value = (object) Original_Expr2;
      if (Original_belgoNo == null)
        throw new ArgumentNullException(nameof (Original_belgoNo));
      this.Adapter.DeleteCommand.Parameters[35].Value = (object) 0;
      this.Adapter.DeleteCommand.Parameters[36].Value = (object) Original_belgoNo;
      if (Original_motorNo == null)
        throw new ArgumentNullException(nameof (Original_motorNo));
      this.Adapter.DeleteCommand.Parameters[37].Value = (object) 0;
      this.Adapter.DeleteCommand.Parameters[38].Value = (object) Original_motorNo;
      if (Original_saseNo == null)
        throw new ArgumentNullException(nameof (Original_saseNo));
      this.Adapter.DeleteCommand.Parameters[39].Value = (object) 0;
      this.Adapter.DeleteCommand.Parameters[40].Value = (object) Original_saseNo;
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
      DateTime? TRAFIKSGORTA2,
      string Plaka,
      string Aciklama,
      string verildigiIlce,
      string tahsisPlaka,
      int Marka,
      string Model,
      string Cinsi,
      string ticariAdi,
      string Tipi,
      string Rengi,
      int Birim,
      int mudurlık,
      int? ARACDURUMID,
      int? ARACTIPIID,
      int? ARACGRUBUID,
      DateTime Expr2,
      string belgoNo,
      string motorNo,
      string saseNo)
    {
      if (TRAFIKSGORTA2.HasValue)
        this.Adapter.InsertCommand.Parameters[0].Value = (object) TRAFIKSGORTA2.Value;
      else
        this.Adapter.InsertCommand.Parameters[0].Value = (object) DBNull.Value;
      this.Adapter.InsertCommand.Parameters[1].Value = Plaka != null ? (object) Plaka : throw new ArgumentNullException(nameof (Plaka));
      this.Adapter.InsertCommand.Parameters[2].Value = Aciklama != null ? (object) Aciklama : throw new ArgumentNullException(nameof (Aciklama));
      this.Adapter.InsertCommand.Parameters[3].Value = verildigiIlce != null ? (object) verildigiIlce : throw new ArgumentNullException(nameof (verildigiIlce));
      this.Adapter.InsertCommand.Parameters[4].Value = tahsisPlaka != null ? (object) tahsisPlaka : throw new ArgumentNullException(nameof (tahsisPlaka));
      this.Adapter.InsertCommand.Parameters[5].Value = (object) Marka;
      this.Adapter.InsertCommand.Parameters[6].Value = Model != null ? (object) Model : throw new ArgumentNullException(nameof (Model));
      this.Adapter.InsertCommand.Parameters[7].Value = Cinsi != null ? (object) Cinsi : throw new ArgumentNullException(nameof (Cinsi));
      this.Adapter.InsertCommand.Parameters[8].Value = ticariAdi != null ? (object) ticariAdi : throw new ArgumentNullException(nameof (ticariAdi));
      this.Adapter.InsertCommand.Parameters[9].Value = Tipi != null ? (object) Tipi : throw new ArgumentNullException(nameof (Tipi));
      this.Adapter.InsertCommand.Parameters[10].Value = Rengi != null ? (object) Rengi : throw new ArgumentNullException(nameof (Rengi));
      this.Adapter.InsertCommand.Parameters[11].Value = (object) Birim;
      this.Adapter.InsertCommand.Parameters[12].Value = (object) mudurlık;
      if (ARACDURUMID.HasValue)
        this.Adapter.InsertCommand.Parameters[13].Value = (object) ARACDURUMID.Value;
      else
        this.Adapter.InsertCommand.Parameters[13].Value = (object) DBNull.Value;
      if (ARACTIPIID.HasValue)
        this.Adapter.InsertCommand.Parameters[14].Value = (object) ARACTIPIID.Value;
      else
        this.Adapter.InsertCommand.Parameters[14].Value = (object) DBNull.Value;
      if (ARACGRUBUID.HasValue)
        this.Adapter.InsertCommand.Parameters[15].Value = (object) ARACGRUBUID.Value;
      else
        this.Adapter.InsertCommand.Parameters[15].Value = (object) DBNull.Value;
      this.Adapter.InsertCommand.Parameters[16].Value = (object) Expr2;
      this.Adapter.InsertCommand.Parameters[17].Value = belgoNo != null ? (object) belgoNo : throw new ArgumentNullException(nameof (belgoNo));
      this.Adapter.InsertCommand.Parameters[18].Value = motorNo != null ? (object) motorNo : throw new ArgumentNullException(nameof (motorNo));
      this.Adapter.InsertCommand.Parameters[19].Value = saseNo != null ? (object) saseNo : throw new ArgumentNullException(nameof (saseNo));
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
      DateTime? TRAFIKSGORTA2,
      string Plaka,
      string Aciklama,
      string verildigiIlce,
      string tahsisPlaka,
      int Marka,
      string Model,
      string Cinsi,
      string ticariAdi,
      string Tipi,
      string Rengi,
      int Birim,
      int mudurlık,
      int? ARACDURUMID,
      int? ARACTIPIID,
      int? ARACGRUBUID,
      DateTime Expr2,
      string belgoNo,
      string motorNo,
      string saseNo,
      int Original_aracID,
      DateTime? Original_TRAFIKSGORTA2,
      string Original_Plaka,
      string Original_Aciklama,
      string Original_verildigiIlce,
      string Original_tahsisPlaka,
      int Original_Marka,
      string Original_Model,
      string Original_Cinsi,
      string Original_ticariAdi,
      string Original_Tipi,
      string Original_Rengi,
      int Original_Birim,
      int Original_mudurlık,
      int? Original_ARACDURUMID,
      int? Original_ARACTIPIID,
      int? Original_ARACGRUBUID,
      DateTime Original_Expr2,
      string Original_belgoNo,
      string Original_motorNo,
      string Original_saseNo,
      int ID)
    {
      if (TRAFIKSGORTA2.HasValue)
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) TRAFIKSGORTA2.Value;
      else
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) DBNull.Value;
      this.Adapter.UpdateCommand.Parameters[1].Value = Plaka != null ? (object) Plaka : throw new ArgumentNullException(nameof (Plaka));
      this.Adapter.UpdateCommand.Parameters[2].Value = Aciklama != null ? (object) Aciklama : throw new ArgumentNullException(nameof (Aciklama));
      this.Adapter.UpdateCommand.Parameters[3].Value = verildigiIlce != null ? (object) verildigiIlce : throw new ArgumentNullException(nameof (verildigiIlce));
      this.Adapter.UpdateCommand.Parameters[4].Value = tahsisPlaka != null ? (object) tahsisPlaka : throw new ArgumentNullException(nameof (tahsisPlaka));
      this.Adapter.UpdateCommand.Parameters[5].Value = (object) Marka;
      this.Adapter.UpdateCommand.Parameters[6].Value = Model != null ? (object) Model : throw new ArgumentNullException(nameof (Model));
      this.Adapter.UpdateCommand.Parameters[7].Value = Cinsi != null ? (object) Cinsi : throw new ArgumentNullException(nameof (Cinsi));
      this.Adapter.UpdateCommand.Parameters[8].Value = ticariAdi != null ? (object) ticariAdi : throw new ArgumentNullException(nameof (ticariAdi));
      this.Adapter.UpdateCommand.Parameters[9].Value = Tipi != null ? (object) Tipi : throw new ArgumentNullException(nameof (Tipi));
      this.Adapter.UpdateCommand.Parameters[10].Value = Rengi != null ? (object) Rengi : throw new ArgumentNullException(nameof (Rengi));
      this.Adapter.UpdateCommand.Parameters[11].Value = (object) Birim;
      this.Adapter.UpdateCommand.Parameters[12].Value = (object) mudurlık;
      if (ARACDURUMID.HasValue)
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) ARACDURUMID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) DBNull.Value;
      if (ARACTIPIID.HasValue)
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) ARACTIPIID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) DBNull.Value;
      if (ARACGRUBUID.HasValue)
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) ARACGRUBUID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) DBNull.Value;
      this.Adapter.UpdateCommand.Parameters[16].Value = (object) Expr2;
      this.Adapter.UpdateCommand.Parameters[17].Value = belgoNo != null ? (object) belgoNo : throw new ArgumentNullException(nameof (belgoNo));
      this.Adapter.UpdateCommand.Parameters[18].Value = motorNo != null ? (object) motorNo : throw new ArgumentNullException(nameof (motorNo));
      this.Adapter.UpdateCommand.Parameters[19].Value = saseNo != null ? (object) saseNo : throw new ArgumentNullException(nameof (saseNo));
      this.Adapter.UpdateCommand.Parameters[20].Value = (object) Original_aracID;
      if (Original_TRAFIKSGORTA2.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[21].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[22].Value = (object) Original_TRAFIKSGORTA2.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[21].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[22].Value = (object) DBNull.Value;
      }
      if (Original_Plaka == null)
        throw new ArgumentNullException(nameof (Original_Plaka));
      this.Adapter.UpdateCommand.Parameters[23].Value = (object) 0;
      this.Adapter.UpdateCommand.Parameters[24].Value = (object) Original_Plaka;
      if (Original_Aciklama == null)
        throw new ArgumentNullException(nameof (Original_Aciklama));
      this.Adapter.UpdateCommand.Parameters[25].Value = (object) 0;
      this.Adapter.UpdateCommand.Parameters[26].Value = (object) Original_Aciklama;
      if (Original_verildigiIlce == null)
        throw new ArgumentNullException(nameof (Original_verildigiIlce));
      this.Adapter.UpdateCommand.Parameters[27].Value = (object) 0;
      this.Adapter.UpdateCommand.Parameters[28].Value = (object) Original_verildigiIlce;
      if (Original_tahsisPlaka == null)
        throw new ArgumentNullException(nameof (Original_tahsisPlaka));
      this.Adapter.UpdateCommand.Parameters[29].Value = (object) 0;
      this.Adapter.UpdateCommand.Parameters[30].Value = (object) Original_tahsisPlaka;
      this.Adapter.UpdateCommand.Parameters[31].Value = (object) 0;
      this.Adapter.UpdateCommand.Parameters[32].Value = (object) Original_Marka;
      if (Original_Model == null)
        throw new ArgumentNullException(nameof (Original_Model));
      this.Adapter.UpdateCommand.Parameters[33].Value = (object) 0;
      this.Adapter.UpdateCommand.Parameters[34].Value = (object) Original_Model;
      if (Original_Cinsi == null)
        throw new ArgumentNullException(nameof (Original_Cinsi));
      this.Adapter.UpdateCommand.Parameters[35].Value = (object) 0;
      this.Adapter.UpdateCommand.Parameters[36].Value = (object) Original_Cinsi;
      if (Original_ticariAdi == null)
        throw new ArgumentNullException(nameof (Original_ticariAdi));
      this.Adapter.UpdateCommand.Parameters[37].Value = (object) 0;
      this.Adapter.UpdateCommand.Parameters[38].Value = (object) Original_ticariAdi;
      if (Original_Tipi == null)
        throw new ArgumentNullException(nameof (Original_Tipi));
      this.Adapter.UpdateCommand.Parameters[39].Value = (object) 0;
      this.Adapter.UpdateCommand.Parameters[40].Value = (object) Original_Tipi;
      if (Original_Rengi == null)
        throw new ArgumentNullException(nameof (Original_Rengi));
      this.Adapter.UpdateCommand.Parameters[41].Value = (object) 0;
      this.Adapter.UpdateCommand.Parameters[42].Value = (object) Original_Rengi;
      this.Adapter.UpdateCommand.Parameters[43].Value = (object) 0;
      this.Adapter.UpdateCommand.Parameters[44].Value = (object) Original_Birim;
      this.Adapter.UpdateCommand.Parameters[45].Value = (object) 0;
      this.Adapter.UpdateCommand.Parameters[46].Value = (object) Original_mudurlık;
      if (Original_ARACDURUMID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[47].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[48].Value = (object) Original_ARACDURUMID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[47].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[48].Value = (object) DBNull.Value;
      }
      if (Original_ARACTIPIID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[49].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[50].Value = (object) Original_ARACTIPIID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[49].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[50].Value = (object) DBNull.Value;
      }
      if (Original_ARACGRUBUID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[51].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[52].Value = (object) Original_ARACGRUBUID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[51].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[52].Value = (object) DBNull.Value;
      }
      this.Adapter.UpdateCommand.Parameters[53].Value = (object) 0;
      this.Adapter.UpdateCommand.Parameters[54].Value = (object) Original_Expr2;
      if (Original_belgoNo == null)
        throw new ArgumentNullException(nameof (Original_belgoNo));
      this.Adapter.UpdateCommand.Parameters[55].Value = (object) 0;
      this.Adapter.UpdateCommand.Parameters[56].Value = (object) Original_belgoNo;
      if (Original_motorNo == null)
        throw new ArgumentNullException(nameof (Original_motorNo));
      this.Adapter.UpdateCommand.Parameters[57].Value = (object) 0;
      this.Adapter.UpdateCommand.Parameters[58].Value = (object) Original_motorNo;
      if (Original_saseNo == null)
        throw new ArgumentNullException(nameof (Original_saseNo));
      this.Adapter.UpdateCommand.Parameters[59].Value = (object) 0;
      this.Adapter.UpdateCommand.Parameters[60].Value = (object) Original_saseNo;
      this.Adapter.UpdateCommand.Parameters[61].Value = (object) ID;
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
      DateTime? TRAFIKSGORTA2,
      string Plaka,
      string Aciklama,
      string verildigiIlce,
      string tahsisPlaka,
      int Marka,
      string Model,
      string Cinsi,
      string ticariAdi,
      string Tipi,
      string Rengi,
      int Birim,
      int mudurlık,
      int? ARACDURUMID,
      int? ARACTIPIID,
      int? ARACGRUBUID,
      DateTime Expr2,
      string belgoNo,
      string motorNo,
      string saseNo,
      int Original_aracID,
      DateTime? Original_TRAFIKSGORTA2,
      string Original_Plaka,
      string Original_Aciklama,
      string Original_verildigiIlce,
      string Original_tahsisPlaka,
      int Original_Marka,
      string Original_Model,
      string Original_Cinsi,
      string Original_ticariAdi,
      string Original_Tipi,
      string Original_Rengi,
      int Original_Birim,
      int Original_mudurlık,
      int? Original_ARACDURUMID,
      int? Original_ARACTIPIID,
      int? Original_ARACGRUBUID,
      DateTime Original_Expr2,
      string Original_belgoNo,
      string Original_motorNo,
      string Original_saseNo)
    {
      return this.Update(TRAFIKSGORTA2, Plaka, Aciklama, verildigiIlce, tahsisPlaka, Marka, Model, Cinsi, ticariAdi, Tipi, Rengi, Birim, mudurlık, ARACDURUMID, ARACTIPIID, ARACGRUBUID, Expr2, belgoNo, motorNo, saseNo, Original_aracID, Original_TRAFIKSGORTA2, Original_Plaka, Original_Aciklama, Original_verildigiIlce, Original_tahsisPlaka, Original_Marka, Original_Model, Original_Cinsi, Original_ticariAdi, Original_Tipi, Original_Rengi, Original_Birim, Original_mudurlık, Original_ARACDURUMID, Original_ARACTIPIID, Original_ARACGRUBUID, Original_Expr2, Original_belgoNo, Original_motorNo, Original_saseNo, Original_aracID);
    }
  }
}
