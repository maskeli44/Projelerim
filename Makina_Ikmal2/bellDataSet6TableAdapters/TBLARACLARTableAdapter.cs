// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.bellDataSet6TableAdapters.TBLARACLARTableAdapter
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

namespace Makina_Ikmal.bellDataSet6TableAdapters
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
            "ID",
            "ID"
          },
          {
            "KOD",
            "KOD"
          },
          {
            "VERILDIGIILILCE",
            "VERILDIGIILILCE"
          },
          {
            "PLAKA",
            "PLAKA"
          },
          {
            "ARACACIKLAMA",
            "ARACACIKLAMA"
          },
          {
            "TAHSPLAKA",
            "TAHSPLAKA"
          },
          {
            "TAHSPLKTARIH",
            "TAHSPLKTARIH"
          },
          {
            "ESKIPLAKA",
            "ESKIPLAKA"
          },
          {
            "TESCILSIRANO",
            "TESCILSIRANO"
          },
          {
            "ILKTESCILTARIHI",
            "ILKTESCILTARIHI"
          },
          {
            "TESCILTARIHI",
            "TESCILTARIHI"
          },
          {
            "MARKAID",
            "MARKAID"
          },
          {
            "MODEL",
            "MODEL"
          },
          {
            "CINSI",
            "CINSI"
          },
          {
            "TICARIADI",
            "TICARIADI"
          },
          {
            "TIPI",
            "TIPI"
          },
          {
            "RENGI",
            "RENGI"
          },
          {
            "MOTORNO",
            "MOTORNO"
          },
          {
            "SASENO",
            "SASENO"
          },
          {
            "SILINDIRHACMI",
            "SILINDIRHACMI"
          },
          {
            "MOTORGUCU",
            "MOTORGUCU"
          },
          {
            "BEYGIRGUCU",
            "BEYGIRGUCU"
          },
          {
            "TEKERLEKADEDI",
            "TEKERLEKADEDI"
          },
          {
            "YURUYENAKSAMI",
            "YURUYENAKSAMI"
          },
          {
            "LASTIKEBADI",
            "LASTIKEBADI"
          },
          {
            "DIGEROZELLIKLER",
            "DIGEROZELLIKLER"
          },
          {
            "MUAYENEGECSUR",
            "MUAYENEGECSUR"
          },
          {
            "TRAFIKSGORTA",
            "TRAFIKSGORTA"
          },
          {
            "KASKO",
            "KASKO"
          },
          {
            "BELGESERINO",
            "BELGESERINO"
          },
          {
            "ARACFIRMAID",
            "ARACFIRMAID"
          },
          {
            "BELDBIRIMID",
            "BELDBIRIMID"
          },
          {
            "BELDMUDURLUKID",
            "BELDMUDURLUKID"
          },
          {
            "TAHSISEDILENID",
            "TAHSISEDILENID"
          },
          {
            "ARACKULPERSID",
            "ARACKULPERSID"
          },
          {
            "ARACGRUBUID",
            "ARACGRUBUID"
          },
          {
            "ARACGRUBU2ID",
            "ARACGRUBU2ID"
          },
          {
            "YAKITID",
            "YAKITID"
          },
          {
            "YKTYAKMATURU",
            "YKTYAKMATURU"
          },
          {
            "STDYKYAKIT",
            "STDYKYAKIT"
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
            "TKPVARYOK",
            "TKPVARYOK"
          },
          {
            "YEDEKANAHTAR",
            "YEDEKANAHTAR"
          },
          {
            "YEDEKANHTRACKLM",
            "YEDEKANHTRACKLM"
          },
          {
            "GOREVBITIMTARIH",
            "GOREVBITIMTARIH"
          },
          {
            "GOREVDURUM",
            "GOREVDURUM"
          },
          {
            "ILGILINOT",
            "ILGILINOT"
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
            "ARACRESIM1",
            "ARACRESIM1"
          },
          {
            "ARACRESIM2",
            "ARACRESIM2"
          },
          {
            "TAKIPVARYOKID",
            "TAKIPVARYOKID"
          },
          {
            "SIRANO",
            "SIRANO"
          },
          {
            "GUNCELDEGERI",
            "GUNCELDEGERI"
          },
          {
            "YENIDEGERI",
            "YENIDEGERI"
          },
          {
            "PARABIRIMI",
            "PARABIRIMI"
          },
          {
            "GENELBAKIMKM",
            "GENELBAKIMKM"
          },
          {
            "MOTORYAGKM",
            "MOTORYAGKM"
          },
          {
            "SANZIMANYAGKM",
            "SANZIMANYAGKM"
          },
          {
            "DIFERANSIYELYAGKM",
            "DIFERANSIYELYAGKM"
          },
          {
            "HIDROLIKYAGKM",
            "HIDROLIKYAGKM"
          },
          {
            "RESIMON",
            "RESIMON"
          },
          {
            "RESIMARKA",
            "RESIMARKA"
          },
          {
            "YENIDEGERTARIH",
            "YENIDEGERTARIH"
          },
          {
            "HGSVARYOK",
            "HGSVARYOK"
          }
        }
      });
      this._adapter.DeleteCommand = new SqlCommand();
      this._adapter.DeleteCommand.Connection = this.Connection;
      this._adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[TBLARACLAR] WHERE (([ID] = @Original_ID) AND ((@IsNull_KOD = 1 AND [KOD] IS NULL) OR ([KOD] = @Original_KOD)) AND ((@IsNull_VERILDIGIILILCE = 1 AND [VERILDIGIILILCE] IS NULL) OR ([VERILDIGIILILCE] = @Original_VERILDIGIILILCE)) AND ((@IsNull_PLAKA = 1 AND [PLAKA] IS NULL) OR ([PLAKA] = @Original_PLAKA)) AND ((@IsNull_ARACACIKLAMA = 1 AND [ARACACIKLAMA] IS NULL) OR ([ARACACIKLAMA] = @Original_ARACACIKLAMA)) AND ((@IsNull_TAHSPLAKA = 1 AND [TAHSPLAKA] IS NULL) OR ([TAHSPLAKA] = @Original_TAHSPLAKA)) AND ((@IsNull_TAHSPLKTARIH = 1 AND [TAHSPLKTARIH] IS NULL) OR ([TAHSPLKTARIH] = @Original_TAHSPLKTARIH)) AND ((@IsNull_ESKIPLAKA = 1 AND [ESKIPLAKA] IS NULL) OR ([ESKIPLAKA] = @Original_ESKIPLAKA)) AND ((@IsNull_TESCILSIRANO = 1 AND [TESCILSIRANO] IS NULL) OR ([TESCILSIRANO] = @Original_TESCILSIRANO)) AND ((@IsNull_ILKTESCILTARIHI = 1 AND [ILKTESCILTARIHI] IS NULL) OR ([ILKTESCILTARIHI] = @Original_ILKTESCILTARIHI)) AND ((@IsNull_TESCILTARIHI = 1 AND [TESCILTARIHI] IS NULL) OR ([TESCILTARIHI] = @Original_TESCILTARIHI)) AND ((@IsNull_MARKAID = 1 AND [MARKAID] IS NULL) OR ([MARKAID] = @Original_MARKAID)) AND ((@IsNull_MODEL = 1 AND [MODEL] IS NULL) OR ([MODEL] = @Original_MODEL)) AND ((@IsNull_CINSI = 1 AND [CINSI] IS NULL) OR ([CINSI] = @Original_CINSI)) AND ((@IsNull_TICARIADI = 1 AND [TICARIADI] IS NULL) OR ([TICARIADI] = @Original_TICARIADI)) AND ((@IsNull_TIPI = 1 AND [TIPI] IS NULL) OR ([TIPI] = @Original_TIPI)) AND ((@IsNull_RENGI = 1 AND [RENGI] IS NULL) OR ([RENGI] = @Original_RENGI)) AND ((@IsNull_MOTORNO = 1 AND [MOTORNO] IS NULL) OR ([MOTORNO] = @Original_MOTORNO)) AND ((@IsNull_SASENO = 1 AND [SASENO] IS NULL) OR ([SASENO] = @Original_SASENO)) AND ((@IsNull_SILINDIRHACMI = 1 AND [SILINDIRHACMI] IS NULL) OR ([SILINDIRHACMI] = @Original_SILINDIRHACMI)) AND ((@IsNull_MOTORGUCU = 1 AND [MOTORGUCU] IS NULL) OR ([MOTORGUCU] = @Original_MOTORGUCU)) AND ((@IsNull_BEYGIRGUCU = 1 AND [BEYGIRGUCU] IS NULL) OR ([BEYGIRGUCU] = @Original_BEYGIRGUCU)) AND ((@IsNull_TEKERLEKADEDI = 1 AND [TEKERLEKADEDI] IS NULL) OR ([TEKERLEKADEDI] = @Original_TEKERLEKADEDI)) AND ((@IsNull_YURUYENAKSAMI = 1 AND [YURUYENAKSAMI] IS NULL) OR ([YURUYENAKSAMI] = @Original_YURUYENAKSAMI)) AND ((@IsNull_LASTIKEBADI = 1 AND [LASTIKEBADI] IS NULL) OR ([LASTIKEBADI] = @Original_LASTIKEBADI)) AND ((@IsNull_DIGEROZELLIKLER = 1 AND [DIGEROZELLIKLER] IS NULL) OR ([DIGEROZELLIKLER] = @Original_DIGEROZELLIKLER)) AND ((@IsNull_MUAYENEGECSUR = 1 AND [MUAYENEGECSUR] IS NULL) OR ([MUAYENEGECSUR] = @Original_MUAYENEGECSUR)) AND ((@IsNull_TRAFIKSGORTA = 1 AND [TRAFIKSGORTA] IS NULL) OR ([TRAFIKSGORTA] = @Original_TRAFIKSGORTA)) AND ((@IsNull_KASKO = 1 AND [KASKO] IS NULL) OR ([KASKO] = @Original_KASKO)) AND ((@IsNull_BELGESERINO = 1 AND [BELGESERINO] IS NULL) OR ([BELGESERINO] = @Original_BELGESERINO)) AND ((@IsNull_ARACFIRMAID = 1 AND [ARACFIRMAID] IS NULL) OR ([ARACFIRMAID] = @Original_ARACFIRMAID)) AND ((@IsNull_BELDBIRIMID = 1 AND [BELDBIRIMID] IS NULL) OR ([BELDBIRIMID] = @Original_BELDBIRIMID)) AND ((@IsNull_BELDMUDURLUKID = 1 AND [BELDMUDURLUKID] IS NULL) OR ([BELDMUDURLUKID] = @Original_BELDMUDURLUKID)) AND ((@IsNull_TAHSISEDILENID = 1 AND [TAHSISEDILENID] IS NULL) OR ([TAHSISEDILENID] = @Original_TAHSISEDILENID)) AND ((@IsNull_ARACKULPERSID = 1 AND [ARACKULPERSID] IS NULL) OR ([ARACKULPERSID] = @Original_ARACKULPERSID)) AND ((@IsNull_ARACGRUBUID = 1 AND [ARACGRUBUID] IS NULL) OR ([ARACGRUBUID] = @Original_ARACGRUBUID)) AND ((@IsNull_ARACGRUBU2ID = 1 AND [ARACGRUBU2ID] IS NULL) OR ([ARACGRUBU2ID] = @Original_ARACGRUBU2ID)) AND ((@IsNull_YAKITID = 1 AND [YAKITID] IS NULL) OR ([YAKITID] = @Original_YAKITID)) AND ((@IsNull_YKTYAKMATURU = 1 AND [YKTYAKMATURU] IS NULL) OR ([YKTYAKMATURU] = @Original_YKTYAKMATURU)) AND ((@IsNull_STDYKYAKIT = 1 AND [STDYKYAKIT] IS NULL) OR ([STDYKYAKIT] = @Original_STDYKYAKIT)) AND ((@IsNull_ARACDURUMID = 1 AND [ARACDURUMID] IS NULL) OR ([ARACDURUMID] = @Original_ARACDURUMID)) AND ((@IsNull_ARACTIPIID = 1 AND [ARACTIPIID] IS NULL) OR ([ARACTIPIID] = @Original_ARACTIPIID)) AND ((@IsNull_TKPVARYOK = 1 AND [TKPVARYOK] IS NULL) OR ([TKPVARYOK] = @Original_TKPVARYOK)) AND ((@IsNull_YEDEKANAHTAR = 1 AND [YEDEKANAHTAR] IS NULL) OR ([YEDEKANAHTAR] = @Original_YEDEKANAHTAR)) AND ((@IsNull_YEDEKANHTRACKLM = 1 AND [YEDEKANHTRACKLM] IS NULL) OR ([YEDEKANHTRACKLM] = @Original_YEDEKANHTRACKLM)) AND ((@IsNull_GOREVBITIMTARIH = 1 AND [GOREVBITIMTARIH] IS NULL) OR ([GOREVBITIMTARIH] = @Original_GOREVBITIMTARIH)) AND ((@IsNull_GOREVDURUM = 1 AND [GOREVDURUM] IS NULL) OR ([GOREVDURUM] = @Original_GOREVDURUM)) AND ((@IsNull_ILGILINOT = 1 AND [ILGILINOT] IS NULL) OR ([ILGILINOT] = @Original_ILGILINOT)) AND ((@IsNull_SAVEUSER = 1 AND [SAVEUSER] IS NULL) OR ([SAVEUSER] = @Original_SAVEUSER)) AND ((@IsNull_SAVEDATE = 1 AND [SAVEDATE] IS NULL) OR ([SAVEDATE] = @Original_SAVEDATE)) AND ((@IsNull_EDITUSER = 1 AND [EDITUSER] IS NULL) OR ([EDITUSER] = @Original_EDITUSER)) AND ((@IsNull_EDITDATE = 1 AND [EDITDATE] IS NULL) OR ([EDITDATE] = @Original_EDITDATE)) AND ((@IsNull_SAVEMAC = 1 AND [SAVEMAC] IS NULL) OR ([SAVEMAC] = @Original_SAVEMAC)) AND ((@IsNull_EDITMAC = 1 AND [EDITMAC] IS NULL) OR ([EDITMAC] = @Original_EDITMAC)) AND ((@IsNull_SAVEIP = 1 AND [SAVEIP] IS NULL) OR ([SAVEIP] = @Original_SAVEIP)) AND ((@IsNull_EDITIP = 1 AND [EDITIP] IS NULL) OR ([EDITIP] = @Original_EDITIP)) AND ((@IsNull_ARACRESIM1 = 1 AND [ARACRESIM1] IS NULL) OR ([ARACRESIM1] = @Original_ARACRESIM1)) AND ((@IsNull_ARACRESIM2 = 1 AND [ARACRESIM2] IS NULL) OR ([ARACRESIM2] = @Original_ARACRESIM2)) AND ((@IsNull_TAKIPVARYOKID = 1 AND [TAKIPVARYOKID] IS NULL) OR ([TAKIPVARYOKID] = @Original_TAKIPVARYOKID)) AND ((@IsNull_SIRANO = 1 AND [SIRANO] IS NULL) OR ([SIRANO] = @Original_SIRANO)) AND ((@IsNull_GUNCELDEGERI = 1 AND [GUNCELDEGERI] IS NULL) OR ([GUNCELDEGERI] = @Original_GUNCELDEGERI)) AND ((@IsNull_YENIDEGERI = 1 AND [YENIDEGERI] IS NULL) OR ([YENIDEGERI] = @Original_YENIDEGERI)) AND ((@IsNull_PARABIRIMI = 1 AND [PARABIRIMI] IS NULL) OR ([PARABIRIMI] = @Original_PARABIRIMI)) AND ((@IsNull_GENELBAKIMKM = 1 AND [GENELBAKIMKM] IS NULL) OR ([GENELBAKIMKM] = @Original_GENELBAKIMKM)) AND ((@IsNull_MOTORYAGKM = 1 AND [MOTORYAGKM] IS NULL) OR ([MOTORYAGKM] = @Original_MOTORYAGKM)) AND ((@IsNull_SANZIMANYAGKM = 1 AND [SANZIMANYAGKM] IS NULL) OR ([SANZIMANYAGKM] = @Original_SANZIMANYAGKM)) AND ((@IsNull_DIFERANSIYELYAGKM = 1 AND [DIFERANSIYELYAGKM] IS NULL) OR ([DIFERANSIYELYAGKM] = @Original_DIFERANSIYELYAGKM)) AND ((@IsNull_HIDROLIKYAGKM = 1 AND [HIDROLIKYAGKM] IS NULL) OR ([HIDROLIKYAGKM] = @Original_HIDROLIKYAGKM)) AND ((@IsNull_YENIDEGERTARIH = 1 AND [YENIDEGERTARIH] IS NULL) OR ([YENIDEGERTARIH] = @Original_YENIDEGERTARIH)) AND ((@IsNull_HGSVARYOK = 1 AND [HGSVARYOK] IS NULL) OR ([HGSVARYOK] = @Original_HGSVARYOK)))";
      this._adapter.DeleteCommand.CommandType = CommandType.Text;
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_KOD", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_KOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_VERILDIGIILILCE", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "VERILDIGIILILCE", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_VERILDIGIILILCE", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "VERILDIGIILILCE", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_PLAKA", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PLAKA", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_PLAKA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PLAKA", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ARACACIKLAMA", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACACIKLAMA", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ARACACIKLAMA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACACIKLAMA", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TAHSPLAKA", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TAHSPLAKA", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TAHSPLAKA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TAHSPLAKA", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TAHSPLKTARIH", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TAHSPLKTARIH", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TAHSPLKTARIH", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TAHSPLKTARIH", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ESKIPLAKA", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ESKIPLAKA", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ESKIPLAKA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ESKIPLAKA", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TESCILSIRANO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TESCILSIRANO", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TESCILSIRANO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TESCILSIRANO", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ILKTESCILTARIHI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ILKTESCILTARIHI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ILKTESCILTARIHI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ILKTESCILTARIHI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TESCILTARIHI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TESCILTARIHI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TESCILTARIHI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TESCILTARIHI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_MARKAID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MARKAID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_MARKAID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MARKAID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_MODEL", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MODEL", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_MODEL", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MODEL", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_CINSI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CINSI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_CINSI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CINSI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TICARIADI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TICARIADI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TICARIADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TICARIADI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TIPI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TIPI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TIPI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TIPI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_RENGI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RENGI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_RENGI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RENGI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_MOTORNO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MOTORNO", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_MOTORNO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MOTORNO", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SASENO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SASENO", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SASENO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SASENO", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SILINDIRHACMI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SILINDIRHACMI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SILINDIRHACMI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SILINDIRHACMI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_MOTORGUCU", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MOTORGUCU", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_MOTORGUCU", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MOTORGUCU", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_BEYGIRGUCU", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BEYGIRGUCU", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_BEYGIRGUCU", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BEYGIRGUCU", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TEKERLEKADEDI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TEKERLEKADEDI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TEKERLEKADEDI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TEKERLEKADEDI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_YURUYENAKSAMI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YURUYENAKSAMI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_YURUYENAKSAMI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YURUYENAKSAMI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_LASTIKEBADI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "LASTIKEBADI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_LASTIKEBADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "LASTIKEBADI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_DIGEROZELLIKLER", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DIGEROZELLIKLER", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_DIGEROZELLIKLER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DIGEROZELLIKLER", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_MUAYENEGECSUR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MUAYENEGECSUR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_MUAYENEGECSUR", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MUAYENEGECSUR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TRAFIKSGORTA", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TRAFIKSGORTA", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TRAFIKSGORTA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TRAFIKSGORTA", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_KASKO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KASKO", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_KASKO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KASKO", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_BELGESERINO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELGESERINO", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_BELGESERINO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELGESERINO", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ARACFIRMAID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACFIRMAID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ARACFIRMAID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACFIRMAID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_BELDBIRIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELDBIRIMID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_BELDBIRIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELDBIRIMID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_BELDMUDURLUKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELDMUDURLUKID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_BELDMUDURLUKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELDMUDURLUKID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TAHSISEDILENID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TAHSISEDILENID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TAHSISEDILENID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TAHSISEDILENID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ARACKULPERSID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACKULPERSID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ARACKULPERSID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACKULPERSID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ARACGRUBUID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACGRUBUID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ARACGRUBUID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACGRUBUID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ARACGRUBU2ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACGRUBU2ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ARACGRUBU2ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACGRUBU2ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_YAKITID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YAKITID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_YAKITID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YAKITID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_YKTYAKMATURU", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YKTYAKMATURU", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_YKTYAKMATURU", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YKTYAKMATURU", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_STDYKYAKIT", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "STDYKYAKIT", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_STDYKYAKIT", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "STDYKYAKIT", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ARACDURUMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACDURUMID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ARACDURUMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACDURUMID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ARACTIPIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACTIPIID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ARACTIPIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACTIPIID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TKPVARYOK", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TKPVARYOK", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TKPVARYOK", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TKPVARYOK", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_YEDEKANAHTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YEDEKANAHTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_YEDEKANAHTAR", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YEDEKANAHTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_YEDEKANHTRACKLM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YEDEKANHTRACKLM", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_YEDEKANHTRACKLM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YEDEKANHTRACKLM", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_GOREVBITIMTARIH", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOREVBITIMTARIH", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_GOREVBITIMTARIH", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOREVBITIMTARIH", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_GOREVDURUM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOREVDURUM", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_GOREVDURUM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOREVDURUM", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ILGILINOT", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ILGILINOT", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ILGILINOT", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ILGILINOT", DataRowVersion.Original, false, (object) null, "", "", ""));
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
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ARACRESIM1", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACRESIM1", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ARACRESIM1", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACRESIM1", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ARACRESIM2", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACRESIM2", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ARACRESIM2", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACRESIM2", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TAKIPVARYOKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TAKIPVARYOKID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TAKIPVARYOKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TAKIPVARYOKID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SIRANO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SIRANO", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SIRANO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SIRANO", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_GUNCELDEGERI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GUNCELDEGERI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_GUNCELDEGERI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GUNCELDEGERI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_YENIDEGERI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YENIDEGERI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_YENIDEGERI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YENIDEGERI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_PARABIRIMI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PARABIRIMI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_PARABIRIMI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PARABIRIMI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_GENELBAKIMKM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GENELBAKIMKM", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_GENELBAKIMKM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GENELBAKIMKM", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_MOTORYAGKM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MOTORYAGKM", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_MOTORYAGKM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MOTORYAGKM", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SANZIMANYAGKM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SANZIMANYAGKM", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SANZIMANYAGKM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SANZIMANYAGKM", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_DIFERANSIYELYAGKM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DIFERANSIYELYAGKM", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_DIFERANSIYELYAGKM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DIFERANSIYELYAGKM", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_HIDROLIKYAGKM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "HIDROLIKYAGKM", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_HIDROLIKYAGKM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "HIDROLIKYAGKM", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_YENIDEGERTARIH", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YENIDEGERTARIH", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_YENIDEGERTARIH", SqlDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YENIDEGERTARIH", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_HGSVARYOK", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "HGSVARYOK", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_HGSVARYOK", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "HGSVARYOK", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.InsertCommand = new SqlCommand();
      this._adapter.InsertCommand.Connection = this.Connection;
      this._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[TBLARACLAR] ([KOD], [VERILDIGIILILCE], [PLAKA], [ARACACIKLAMA], [TAHSPLAKA], [TAHSPLKTARIH], [ESKIPLAKA], [TESCILSIRANO], [ILKTESCILTARIHI], [TESCILTARIHI], [MARKAID], [MODEL], [CINSI], [TICARIADI], [TIPI], [RENGI], [MOTORNO], [SASENO], [SILINDIRHACMI], [MOTORGUCU], [BEYGIRGUCU], [TEKERLEKADEDI], [YURUYENAKSAMI], [LASTIKEBADI], [DIGEROZELLIKLER], [MUAYENEGECSUR], [TRAFIKSGORTA], [KASKO], [BELGESERINO], [ARACFIRMAID], [BELDBIRIMID], [BELDMUDURLUKID], [TAHSISEDILENID], [ARACKULPERSID], [ARACGRUBUID], [ARACGRUBU2ID], [YAKITID], [YKTYAKMATURU], [STDYKYAKIT], [ARACDURUMID], [ARACTIPIID], [TKPVARYOK], [YEDEKANAHTAR], [YEDEKANHTRACKLM], [GOREVBITIMTARIH], [GOREVDURUM], [ILGILINOT], [SAVEUSER], [SAVEDATE], [EDITUSER], [EDITDATE], [SAVEMAC], [EDITMAC], [SAVEIP], [EDITIP], [ARACRESIM1], [ARACRESIM2], [TAKIPVARYOKID], [SIRANO], [GUNCELDEGERI], [YENIDEGERI], [PARABIRIMI], [GENELBAKIMKM], [MOTORYAGKM], [SANZIMANYAGKM], [DIFERANSIYELYAGKM], [HIDROLIKYAGKM], [RESIMON], [RESIMARKA], [YENIDEGERTARIH], [HGSVARYOK]) VALUES (@KOD, @VERILDIGIILILCE, @PLAKA, @ARACACIKLAMA, @TAHSPLAKA, @TAHSPLKTARIH, @ESKIPLAKA, @TESCILSIRANO, @ILKTESCILTARIHI, @TESCILTARIHI, @MARKAID, @MODEL, @CINSI, @TICARIADI, @TIPI, @RENGI, @MOTORNO, @SASENO, @SILINDIRHACMI, @MOTORGUCU, @BEYGIRGUCU, @TEKERLEKADEDI, @YURUYENAKSAMI, @LASTIKEBADI, @DIGEROZELLIKLER, @MUAYENEGECSUR, @TRAFIKSGORTA, @KASKO, @BELGESERINO, @ARACFIRMAID, @BELDBIRIMID, @BELDMUDURLUKID, @TAHSISEDILENID, @ARACKULPERSID, @ARACGRUBUID, @ARACGRUBU2ID, @YAKITID, @YKTYAKMATURU, @STDYKYAKIT, @ARACDURUMID, @ARACTIPIID, @TKPVARYOK, @YEDEKANAHTAR, @YEDEKANHTRACKLM, @GOREVBITIMTARIH, @GOREVDURUM, @ILGILINOT, @SAVEUSER, @SAVEDATE, @EDITUSER, @EDITDATE, @SAVEMAC, @EDITMAC, @SAVEIP, @EDITIP, @ARACRESIM1, @ARACRESIM2, @TAKIPVARYOKID, @SIRANO, @GUNCELDEGERI, @YENIDEGERI, @PARABIRIMI, @GENELBAKIMKM, @MOTORYAGKM, @SANZIMANYAGKM, @DIFERANSIYELYAGKM, @HIDROLIKYAGKM, @RESIMON, @RESIMARKA, @YENIDEGERTARIH, @HGSVARYOK);\r\nSELECT ID, KOD, VERILDIGIILILCE, PLAKA, ARACACIKLAMA, TAHSPLAKA, TAHSPLKTARIH, ESKIPLAKA, TESCILSIRANO, ILKTESCILTARIHI, TESCILTARIHI, MARKAID, MODEL, CINSI, TICARIADI, TIPI, RENGI, MOTORNO, SASENO, SILINDIRHACMI, MOTORGUCU, BEYGIRGUCU, TEKERLEKADEDI, YURUYENAKSAMI, LASTIKEBADI, DIGEROZELLIKLER, MUAYENEGECSUR, TRAFIKSGORTA, KASKO, BELGESERINO, ARACFIRMAID, BELDBIRIMID, BELDMUDURLUKID, TAHSISEDILENID, ARACKULPERSID, ARACGRUBUID, ARACGRUBU2ID, YAKITID, YKTYAKMATURU, STDYKYAKIT, ARACDURUMID, ARACTIPIID, TKPVARYOK, YEDEKANAHTAR, YEDEKANHTRACKLM, GOREVBITIMTARIH, GOREVDURUM, ILGILINOT, SAVEUSER, SAVEDATE, EDITUSER, EDITDATE, SAVEMAC, EDITMAC, SAVEIP, EDITIP, ARACRESIM1, ARACRESIM2, TAKIPVARYOKID, SIRANO, GUNCELDEGERI, YENIDEGERI, PARABIRIMI, GENELBAKIMKM, MOTORYAGKM, SANZIMANYAGKM, DIFERANSIYELYAGKM, HIDROLIKYAGKM, RESIMON, RESIMARKA, YENIDEGERTARIH, HGSVARYOK FROM TBLARACLAR WHERE (ID = SCOPE_IDENTITY())";
      this._adapter.InsertCommand.CommandType = CommandType.Text;
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@KOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@VERILDIGIILILCE", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "VERILDIGIILILCE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@PLAKA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PLAKA", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ARACACIKLAMA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACACIKLAMA", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@TAHSPLAKA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TAHSPLAKA", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@TAHSPLKTARIH", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TAHSPLKTARIH", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ESKIPLAKA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ESKIPLAKA", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@TESCILSIRANO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TESCILSIRANO", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ILKTESCILTARIHI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ILKTESCILTARIHI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@TESCILTARIHI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TESCILTARIHI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@MARKAID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MARKAID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@MODEL", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MODEL", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@CINSI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CINSI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@TICARIADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TICARIADI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@TIPI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TIPI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@RENGI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RENGI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@MOTORNO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MOTORNO", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SASENO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SASENO", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SILINDIRHACMI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SILINDIRHACMI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@MOTORGUCU", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MOTORGUCU", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@BEYGIRGUCU", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BEYGIRGUCU", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@TEKERLEKADEDI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TEKERLEKADEDI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@YURUYENAKSAMI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YURUYENAKSAMI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@LASTIKEBADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "LASTIKEBADI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@DIGEROZELLIKLER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DIGEROZELLIKLER", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@MUAYENEGECSUR", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MUAYENEGECSUR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@TRAFIKSGORTA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TRAFIKSGORTA", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@KASKO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KASKO", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@BELGESERINO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELGESERINO", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ARACFIRMAID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACFIRMAID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@BELDBIRIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELDBIRIMID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@BELDMUDURLUKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELDMUDURLUKID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@TAHSISEDILENID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TAHSISEDILENID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ARACKULPERSID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACKULPERSID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ARACGRUBUID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACGRUBUID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ARACGRUBU2ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACGRUBU2ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@YAKITID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YAKITID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@YKTYAKMATURU", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YKTYAKMATURU", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@STDYKYAKIT", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "STDYKYAKIT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ARACDURUMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACDURUMID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ARACTIPIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACTIPIID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@TKPVARYOK", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TKPVARYOK", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@YEDEKANAHTAR", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YEDEKANAHTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@YEDEKANHTRACKLM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YEDEKANHTRACKLM", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@GOREVBITIMTARIH", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOREVBITIMTARIH", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@GOREVDURUM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOREVDURUM", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ILGILINOT", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ILGILINOT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SAVEUSER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEUSER", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SAVEDATE", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEDATE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@EDITUSER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITUSER", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@EDITDATE", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITDATE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SAVEMAC", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEMAC", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@EDITMAC", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITMAC", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SAVEIP", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEIP", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@EDITIP", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITIP", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ARACRESIM1", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACRESIM1", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ARACRESIM2", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACRESIM2", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@TAKIPVARYOKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TAKIPVARYOKID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SIRANO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SIRANO", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@GUNCELDEGERI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GUNCELDEGERI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@YENIDEGERI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YENIDEGERI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@PARABIRIMI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PARABIRIMI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@GENELBAKIMKM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GENELBAKIMKM", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@MOTORYAGKM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MOTORYAGKM", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SANZIMANYAGKM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SANZIMANYAGKM", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@DIFERANSIYELYAGKM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DIFERANSIYELYAGKM", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@HIDROLIKYAGKM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "HIDROLIKYAGKM", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@RESIMON", SqlDbType.Image, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RESIMON", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@RESIMARKA", SqlDbType.Image, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RESIMARKA", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@YENIDEGERTARIH", SqlDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YENIDEGERTARIH", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@HGSVARYOK", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "HGSVARYOK", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand = new SqlCommand();
      this._adapter.UpdateCommand.Connection = this.Connection;
      this._adapter.UpdateCommand.CommandText = "UPDATE [dbo].[TBLARACLAR] SET [KOD] = @KOD, [VERILDIGIILILCE] = @VERILDIGIILILCE, [PLAKA] = @PLAKA, [ARACACIKLAMA] = @ARACACIKLAMA, [TAHSPLAKA] = @TAHSPLAKA, [TAHSPLKTARIH] = @TAHSPLKTARIH, [ESKIPLAKA] = @ESKIPLAKA, [TESCILSIRANO] = @TESCILSIRANO, [ILKTESCILTARIHI] = @ILKTESCILTARIHI, [TESCILTARIHI] = @TESCILTARIHI, [MARKAID] = @MARKAID, [MODEL] = @MODEL, [CINSI] = @CINSI, [TICARIADI] = @TICARIADI, [TIPI] = @TIPI, [RENGI] = @RENGI, [MOTORNO] = @MOTORNO, [SASENO] = @SASENO, [SILINDIRHACMI] = @SILINDIRHACMI, [MOTORGUCU] = @MOTORGUCU, [BEYGIRGUCU] = @BEYGIRGUCU, [TEKERLEKADEDI] = @TEKERLEKADEDI, [YURUYENAKSAMI] = @YURUYENAKSAMI, [LASTIKEBADI] = @LASTIKEBADI, [DIGEROZELLIKLER] = @DIGEROZELLIKLER, [MUAYENEGECSUR] = @MUAYENEGECSUR, [TRAFIKSGORTA] = @TRAFIKSGORTA, [KASKO] = @KASKO, [BELGESERINO] = @BELGESERINO, [ARACFIRMAID] = @ARACFIRMAID, [BELDBIRIMID] = @BELDBIRIMID, [BELDMUDURLUKID] = @BELDMUDURLUKID, [TAHSISEDILENID] = @TAHSISEDILENID, [ARACKULPERSID] = @ARACKULPERSID, [ARACGRUBUID] = @ARACGRUBUID, [ARACGRUBU2ID] = @ARACGRUBU2ID, [YAKITID] = @YAKITID, [YKTYAKMATURU] = @YKTYAKMATURU, [STDYKYAKIT] = @STDYKYAKIT, [ARACDURUMID] = @ARACDURUMID, [ARACTIPIID] = @ARACTIPIID, [TKPVARYOK] = @TKPVARYOK, [YEDEKANAHTAR] = @YEDEKANAHTAR, [YEDEKANHTRACKLM] = @YEDEKANHTRACKLM, [GOREVBITIMTARIH] = @GOREVBITIMTARIH, [GOREVDURUM] = @GOREVDURUM, [ILGILINOT] = @ILGILINOT, [SAVEUSER] = @SAVEUSER, [SAVEDATE] = @SAVEDATE, [EDITUSER] = @EDITUSER, [EDITDATE] = @EDITDATE, [SAVEMAC] = @SAVEMAC, [EDITMAC] = @EDITMAC, [SAVEIP] = @SAVEIP, [EDITIP] = @EDITIP, [ARACRESIM1] = @ARACRESIM1, [ARACRESIM2] = @ARACRESIM2, [TAKIPVARYOKID] = @TAKIPVARYOKID, [SIRANO] = @SIRANO, [GUNCELDEGERI] = @GUNCELDEGERI, [YENIDEGERI] = @YENIDEGERI, [PARABIRIMI] = @PARABIRIMI, [GENELBAKIMKM] = @GENELBAKIMKM, [MOTORYAGKM] = @MOTORYAGKM, [SANZIMANYAGKM] = @SANZIMANYAGKM, [DIFERANSIYELYAGKM] = @DIFERANSIYELYAGKM, [HIDROLIKYAGKM] = @HIDROLIKYAGKM, [RESIMON] = @RESIMON, [RESIMARKA] = @RESIMARKA, [YENIDEGERTARIH] = @YENIDEGERTARIH, [HGSVARYOK] = @HGSVARYOK WHERE (([ID] = @Original_ID) AND ((@IsNull_KOD = 1 AND [KOD] IS NULL) OR ([KOD] = @Original_KOD)) AND ((@IsNull_VERILDIGIILILCE = 1 AND [VERILDIGIILILCE] IS NULL) OR ([VERILDIGIILILCE] = @Original_VERILDIGIILILCE)) AND ((@IsNull_PLAKA = 1 AND [PLAKA] IS NULL) OR ([PLAKA] = @Original_PLAKA)) AND ((@IsNull_ARACACIKLAMA = 1 AND [ARACACIKLAMA] IS NULL) OR ([ARACACIKLAMA] = @Original_ARACACIKLAMA)) AND ((@IsNull_TAHSPLAKA = 1 AND [TAHSPLAKA] IS NULL) OR ([TAHSPLAKA] = @Original_TAHSPLAKA)) AND ((@IsNull_TAHSPLKTARIH = 1 AND [TAHSPLKTARIH] IS NULL) OR ([TAHSPLKTARIH] = @Original_TAHSPLKTARIH)) AND ((@IsNull_ESKIPLAKA = 1 AND [ESKIPLAKA] IS NULL) OR ([ESKIPLAKA] = @Original_ESKIPLAKA)) AND ((@IsNull_TESCILSIRANO = 1 AND [TESCILSIRANO] IS NULL) OR ([TESCILSIRANO] = @Original_TESCILSIRANO)) AND ((@IsNull_ILKTESCILTARIHI = 1 AND [ILKTESCILTARIHI] IS NULL) OR ([ILKTESCILTARIHI] = @Original_ILKTESCILTARIHI)) AND ((@IsNull_TESCILTARIHI = 1 AND [TESCILTARIHI] IS NULL) OR ([TESCILTARIHI] = @Original_TESCILTARIHI)) AND ((@IsNull_MARKAID = 1 AND [MARKAID] IS NULL) OR ([MARKAID] = @Original_MARKAID)) AND ((@IsNull_MODEL = 1 AND [MODEL] IS NULL) OR ([MODEL] = @Original_MODEL)) AND ((@IsNull_CINSI = 1 AND [CINSI] IS NULL) OR ([CINSI] = @Original_CINSI)) AND ((@IsNull_TICARIADI = 1 AND [TICARIADI] IS NULL) OR ([TICARIADI] = @Original_TICARIADI)) AND ((@IsNull_TIPI = 1 AND [TIPI] IS NULL) OR ([TIPI] = @Original_TIPI)) AND ((@IsNull_RENGI = 1 AND [RENGI] IS NULL) OR ([RENGI] = @Original_RENGI)) AND ((@IsNull_MOTORNO = 1 AND [MOTORNO] IS NULL) OR ([MOTORNO] = @Original_MOTORNO)) AND ((@IsNull_SASENO = 1 AND [SASENO] IS NULL) OR ([SASENO] = @Original_SASENO)) AND ((@IsNull_SILINDIRHACMI = 1 AND [SILINDIRHACMI] IS NULL) OR ([SILINDIRHACMI] = @Original_SILINDIRHACMI)) AND ((@IsNull_MOTORGUCU = 1 AND [MOTORGUCU] IS NULL) OR ([MOTORGUCU] = @Original_MOTORGUCU)) AND ((@IsNull_BEYGIRGUCU = 1 AND [BEYGIRGUCU] IS NULL) OR ([BEYGIRGUCU] = @Original_BEYGIRGUCU)) AND ((@IsNull_TEKERLEKADEDI = 1 AND [TEKERLEKADEDI] IS NULL) OR ([TEKERLEKADEDI] = @Original_TEKERLEKADEDI)) AND ((@IsNull_YURUYENAKSAMI = 1 AND [YURUYENAKSAMI] IS NULL) OR ([YURUYENAKSAMI] = @Original_YURUYENAKSAMI)) AND ((@IsNull_LASTIKEBADI = 1 AND [LASTIKEBADI] IS NULL) OR ([LASTIKEBADI] = @Original_LASTIKEBADI)) AND ((@IsNull_DIGEROZELLIKLER = 1 AND [DIGEROZELLIKLER] IS NULL) OR ([DIGEROZELLIKLER] = @Original_DIGEROZELLIKLER)) AND ((@IsNull_MUAYENEGECSUR = 1 AND [MUAYENEGECSUR] IS NULL) OR ([MUAYENEGECSUR] = @Original_MUAYENEGECSUR)) AND ((@IsNull_TRAFIKSGORTA = 1 AND [TRAFIKSGORTA] IS NULL) OR ([TRAFIKSGORTA] = @Original_TRAFIKSGORTA)) AND ((@IsNull_KASKO = 1 AND [KASKO] IS NULL) OR ([KASKO] = @Original_KASKO)) AND ((@IsNull_BELGESERINO = 1 AND [BELGESERINO] IS NULL) OR ([BELGESERINO] = @Original_BELGESERINO)) AND ((@IsNull_ARACFIRMAID = 1 AND [ARACFIRMAID] IS NULL) OR ([ARACFIRMAID] = @Original_ARACFIRMAID)) AND ((@IsNull_BELDBIRIMID = 1 AND [BELDBIRIMID] IS NULL) OR ([BELDBIRIMID] = @Original_BELDBIRIMID)) AND ((@IsNull_BELDMUDURLUKID = 1 AND [BELDMUDURLUKID] IS NULL) OR ([BELDMUDURLUKID] = @Original_BELDMUDURLUKID)) AND ((@IsNull_TAHSISEDILENID = 1 AND [TAHSISEDILENID] IS NULL) OR ([TAHSISEDILENID] = @Original_TAHSISEDILENID)) AND ((@IsNull_ARACKULPERSID = 1 AND [ARACKULPERSID] IS NULL) OR ([ARACKULPERSID] = @Original_ARACKULPERSID)) AND ((@IsNull_ARACGRUBUID = 1 AND [ARACGRUBUID] IS NULL) OR ([ARACGRUBUID] = @Original_ARACGRUBUID)) AND ((@IsNull_ARACGRUBU2ID = 1 AND [ARACGRUBU2ID] IS NULL) OR ([ARACGRUBU2ID] = @Original_ARACGRUBU2ID)) AND ((@IsNull_YAKITID = 1 AND [YAKITID] IS NULL) OR ([YAKITID] = @Original_YAKITID)) AND ((@IsNull_YKTYAKMATURU = 1 AND [YKTYAKMATURU] IS NULL) OR ([YKTYAKMATURU] = @Original_YKTYAKMATURU)) AND ((@IsNull_STDYKYAKIT = 1 AND [STDYKYAKIT] IS NULL) OR ([STDYKYAKIT] = @Original_STDYKYAKIT)) AND ((@IsNull_ARACDURUMID = 1 AND [ARACDURUMID] IS NULL) OR ([ARACDURUMID] = @Original_ARACDURUMID)) AND ((@IsNull_ARACTIPIID = 1 AND [ARACTIPIID] IS NULL) OR ([ARACTIPIID] = @Original_ARACTIPIID)) AND ((@IsNull_TKPVARYOK = 1 AND [TKPVARYOK] IS NULL) OR ([TKPVARYOK] = @Original_TKPVARYOK)) AND ((@IsNull_YEDEKANAHTAR = 1 AND [YEDEKANAHTAR] IS NULL) OR ([YEDEKANAHTAR] = @Original_YEDEKANAHTAR)) AND ((@IsNull_YEDEKANHTRACKLM = 1 AND [YEDEKANHTRACKLM] IS NULL) OR ([YEDEKANHTRACKLM] = @Original_YEDEKANHTRACKLM)) AND ((@IsNull_GOREVBITIMTARIH = 1 AND [GOREVBITIMTARIH] IS NULL) OR ([GOREVBITIMTARIH] = @Original_GOREVBITIMTARIH)) AND ((@IsNull_GOREVDURUM = 1 AND [GOREVDURUM] IS NULL) OR ([GOREVDURUM] = @Original_GOREVDURUM)) AND ((@IsNull_ILGILINOT = 1 AND [ILGILINOT] IS NULL) OR ([ILGILINOT] = @Original_ILGILINOT)) AND ((@IsNull_SAVEUSER = 1 AND [SAVEUSER] IS NULL) OR ([SAVEUSER] = @Original_SAVEUSER)) AND ((@IsNull_SAVEDATE = 1 AND [SAVEDATE] IS NULL) OR ([SAVEDATE] = @Original_SAVEDATE)) AND ((@IsNull_EDITUSER = 1 AND [EDITUSER] IS NULL) OR ([EDITUSER] = @Original_EDITUSER)) AND ((@IsNull_EDITDATE = 1 AND [EDITDATE] IS NULL) OR ([EDITDATE] = @Original_EDITDATE)) AND ((@IsNull_SAVEMAC = 1 AND [SAVEMAC] IS NULL) OR ([SAVEMAC] = @Original_SAVEMAC)) AND ((@IsNull_EDITMAC = 1 AND [EDITMAC] IS NULL) OR ([EDITMAC] = @Original_EDITMAC)) AND ((@IsNull_SAVEIP = 1 AND [SAVEIP] IS NULL) OR ([SAVEIP] = @Original_SAVEIP)) AND ((@IsNull_EDITIP = 1 AND [EDITIP] IS NULL) OR ([EDITIP] = @Original_EDITIP)) AND ((@IsNull_ARACRESIM1 = 1 AND [ARACRESIM1] IS NULL) OR ([ARACRESIM1] = @Original_ARACRESIM1)) AND ((@IsNull_ARACRESIM2 = 1 AND [ARACRESIM2] IS NULL) OR ([ARACRESIM2] = @Original_ARACRESIM2)) AND ((@IsNull_TAKIPVARYOKID = 1 AND [TAKIPVARYOKID] IS NULL) OR ([TAKIPVARYOKID] = @Original_TAKIPVARYOKID)) AND ((@IsNull_SIRANO = 1 AND [SIRANO] IS NULL) OR ([SIRANO] = @Original_SIRANO)) AND ((@IsNull_GUNCELDEGERI = 1 AND [GUNCELDEGERI] IS NULL) OR ([GUNCELDEGERI] = @Original_GUNCELDEGERI)) AND ((@IsNull_YENIDEGERI = 1 AND [YENIDEGERI] IS NULL) OR ([YENIDEGERI] = @Original_YENIDEGERI)) AND ((@IsNull_PARABIRIMI = 1 AND [PARABIRIMI] IS NULL) OR ([PARABIRIMI] = @Original_PARABIRIMI)) AND ((@IsNull_GENELBAKIMKM = 1 AND [GENELBAKIMKM] IS NULL) OR ([GENELBAKIMKM] = @Original_GENELBAKIMKM)) AND ((@IsNull_MOTORYAGKM = 1 AND [MOTORYAGKM] IS NULL) OR ([MOTORYAGKM] = @Original_MOTORYAGKM)) AND ((@IsNull_SANZIMANYAGKM = 1 AND [SANZIMANYAGKM] IS NULL) OR ([SANZIMANYAGKM] = @Original_SANZIMANYAGKM)) AND ((@IsNull_DIFERANSIYELYAGKM = 1 AND [DIFERANSIYELYAGKM] IS NULL) OR ([DIFERANSIYELYAGKM] = @Original_DIFERANSIYELYAGKM)) AND ((@IsNull_HIDROLIKYAGKM = 1 AND [HIDROLIKYAGKM] IS NULL) OR ([HIDROLIKYAGKM] = @Original_HIDROLIKYAGKM)) AND ((@IsNull_YENIDEGERTARIH = 1 AND [YENIDEGERTARIH] IS NULL) OR ([YENIDEGERTARIH] = @Original_YENIDEGERTARIH)) AND ((@IsNull_HGSVARYOK = 1 AND [HGSVARYOK] IS NULL) OR ([HGSVARYOK] = @Original_HGSVARYOK)));\r\nSELECT ID, KOD, VERILDIGIILILCE, PLAKA, ARACACIKLAMA, TAHSPLAKA, TAHSPLKTARIH, ESKIPLAKA, TESCILSIRANO, ILKTESCILTARIHI, TESCILTARIHI, MARKAID, MODEL, CINSI, TICARIADI, TIPI, RENGI, MOTORNO, SASENO, SILINDIRHACMI, MOTORGUCU, BEYGIRGUCU, TEKERLEKADEDI, YURUYENAKSAMI, LASTIKEBADI, DIGEROZELLIKLER, MUAYENEGECSUR, TRAFIKSGORTA, KASKO, BELGESERINO, ARACFIRMAID, BELDBIRIMID, BELDMUDURLUKID, TAHSISEDILENID, ARACKULPERSID, ARACGRUBUID, ARACGRUBU2ID, YAKITID, YKTYAKMATURU, STDYKYAKIT, ARACDURUMID, ARACTIPIID, TKPVARYOK, YEDEKANAHTAR, YEDEKANHTRACKLM, GOREVBITIMTARIH, GOREVDURUM, ILGILINOT, SAVEUSER, SAVEDATE, EDITUSER, EDITDATE, SAVEMAC, EDITMAC, SAVEIP, EDITIP, ARACRESIM1, ARACRESIM2, TAKIPVARYOKID, SIRANO, GUNCELDEGERI, YENIDEGERI, PARABIRIMI, GENELBAKIMKM, MOTORYAGKM, SANZIMANYAGKM, DIFERANSIYELYAGKM, HIDROLIKYAGKM, RESIMON, RESIMARKA, YENIDEGERTARIH, HGSVARYOK FROM TBLARACLAR WHERE (ID = @ID)";
      this._adapter.UpdateCommand.CommandType = CommandType.Text;
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@KOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@VERILDIGIILILCE", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "VERILDIGIILILCE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@PLAKA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PLAKA", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ARACACIKLAMA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACACIKLAMA", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TAHSPLAKA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TAHSPLAKA", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TAHSPLKTARIH", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TAHSPLKTARIH", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ESKIPLAKA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ESKIPLAKA", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TESCILSIRANO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TESCILSIRANO", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ILKTESCILTARIHI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ILKTESCILTARIHI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TESCILTARIHI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TESCILTARIHI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MARKAID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MARKAID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MODEL", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MODEL", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@CINSI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CINSI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TICARIADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TICARIADI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TIPI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TIPI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@RENGI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RENGI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MOTORNO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MOTORNO", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SASENO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SASENO", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SILINDIRHACMI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SILINDIRHACMI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MOTORGUCU", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MOTORGUCU", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@BEYGIRGUCU", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BEYGIRGUCU", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TEKERLEKADEDI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TEKERLEKADEDI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@YURUYENAKSAMI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YURUYENAKSAMI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@LASTIKEBADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "LASTIKEBADI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@DIGEROZELLIKLER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DIGEROZELLIKLER", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MUAYENEGECSUR", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MUAYENEGECSUR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TRAFIKSGORTA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TRAFIKSGORTA", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@KASKO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KASKO", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@BELGESERINO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELGESERINO", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ARACFIRMAID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACFIRMAID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@BELDBIRIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELDBIRIMID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@BELDMUDURLUKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELDMUDURLUKID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TAHSISEDILENID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TAHSISEDILENID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ARACKULPERSID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACKULPERSID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ARACGRUBUID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACGRUBUID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ARACGRUBU2ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACGRUBU2ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@YAKITID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YAKITID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@YKTYAKMATURU", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YKTYAKMATURU", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@STDYKYAKIT", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "STDYKYAKIT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ARACDURUMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACDURUMID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ARACTIPIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACTIPIID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TKPVARYOK", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TKPVARYOK", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@YEDEKANAHTAR", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YEDEKANAHTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@YEDEKANHTRACKLM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YEDEKANHTRACKLM", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@GOREVBITIMTARIH", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOREVBITIMTARIH", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@GOREVDURUM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOREVDURUM", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ILGILINOT", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ILGILINOT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SAVEUSER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEUSER", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SAVEDATE", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEDATE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EDITUSER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITUSER", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EDITDATE", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITDATE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SAVEMAC", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEMAC", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EDITMAC", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITMAC", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SAVEIP", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEIP", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EDITIP", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITIP", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ARACRESIM1", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACRESIM1", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ARACRESIM2", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACRESIM2", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TAKIPVARYOKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TAKIPVARYOKID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SIRANO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SIRANO", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@GUNCELDEGERI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GUNCELDEGERI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@YENIDEGERI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YENIDEGERI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@PARABIRIMI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PARABIRIMI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@GENELBAKIMKM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GENELBAKIMKM", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MOTORYAGKM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MOTORYAGKM", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SANZIMANYAGKM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SANZIMANYAGKM", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@DIFERANSIYELYAGKM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DIFERANSIYELYAGKM", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@HIDROLIKYAGKM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "HIDROLIKYAGKM", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@RESIMON", SqlDbType.Image, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RESIMON", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@RESIMARKA", SqlDbType.Image, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RESIMARKA", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@YENIDEGERTARIH", SqlDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YENIDEGERTARIH", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@HGSVARYOK", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "HGSVARYOK", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_KOD", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_KOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_VERILDIGIILILCE", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "VERILDIGIILILCE", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_VERILDIGIILILCE", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "VERILDIGIILILCE", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_PLAKA", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PLAKA", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_PLAKA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PLAKA", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ARACACIKLAMA", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACACIKLAMA", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ARACACIKLAMA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACACIKLAMA", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TAHSPLAKA", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TAHSPLAKA", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TAHSPLAKA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TAHSPLAKA", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TAHSPLKTARIH", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TAHSPLKTARIH", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TAHSPLKTARIH", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TAHSPLKTARIH", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ESKIPLAKA", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ESKIPLAKA", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ESKIPLAKA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ESKIPLAKA", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TESCILSIRANO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TESCILSIRANO", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TESCILSIRANO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TESCILSIRANO", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ILKTESCILTARIHI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ILKTESCILTARIHI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ILKTESCILTARIHI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ILKTESCILTARIHI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TESCILTARIHI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TESCILTARIHI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TESCILTARIHI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TESCILTARIHI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_MARKAID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MARKAID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_MARKAID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MARKAID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_MODEL", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MODEL", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_MODEL", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MODEL", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_CINSI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CINSI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_CINSI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CINSI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TICARIADI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TICARIADI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TICARIADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TICARIADI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TIPI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TIPI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TIPI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TIPI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_RENGI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RENGI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_RENGI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RENGI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_MOTORNO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MOTORNO", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_MOTORNO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MOTORNO", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SASENO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SASENO", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SASENO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SASENO", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SILINDIRHACMI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SILINDIRHACMI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SILINDIRHACMI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SILINDIRHACMI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_MOTORGUCU", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MOTORGUCU", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_MOTORGUCU", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MOTORGUCU", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_BEYGIRGUCU", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BEYGIRGUCU", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_BEYGIRGUCU", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BEYGIRGUCU", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TEKERLEKADEDI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TEKERLEKADEDI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TEKERLEKADEDI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TEKERLEKADEDI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_YURUYENAKSAMI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YURUYENAKSAMI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_YURUYENAKSAMI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YURUYENAKSAMI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_LASTIKEBADI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "LASTIKEBADI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_LASTIKEBADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "LASTIKEBADI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_DIGEROZELLIKLER", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DIGEROZELLIKLER", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_DIGEROZELLIKLER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DIGEROZELLIKLER", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_MUAYENEGECSUR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MUAYENEGECSUR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_MUAYENEGECSUR", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MUAYENEGECSUR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TRAFIKSGORTA", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TRAFIKSGORTA", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TRAFIKSGORTA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TRAFIKSGORTA", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_KASKO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KASKO", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_KASKO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KASKO", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_BELGESERINO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELGESERINO", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_BELGESERINO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELGESERINO", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ARACFIRMAID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACFIRMAID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ARACFIRMAID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACFIRMAID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_BELDBIRIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELDBIRIMID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_BELDBIRIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELDBIRIMID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_BELDMUDURLUKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELDMUDURLUKID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_BELDMUDURLUKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELDMUDURLUKID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TAHSISEDILENID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TAHSISEDILENID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TAHSISEDILENID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TAHSISEDILENID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ARACKULPERSID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACKULPERSID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ARACKULPERSID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACKULPERSID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ARACGRUBUID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACGRUBUID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ARACGRUBUID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACGRUBUID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ARACGRUBU2ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACGRUBU2ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ARACGRUBU2ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACGRUBU2ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_YAKITID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YAKITID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_YAKITID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YAKITID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_YKTYAKMATURU", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YKTYAKMATURU", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_YKTYAKMATURU", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YKTYAKMATURU", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_STDYKYAKIT", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "STDYKYAKIT", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_STDYKYAKIT", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "STDYKYAKIT", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ARACDURUMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACDURUMID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ARACDURUMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACDURUMID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ARACTIPIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACTIPIID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ARACTIPIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACTIPIID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TKPVARYOK", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TKPVARYOK", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TKPVARYOK", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TKPVARYOK", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_YEDEKANAHTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YEDEKANAHTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_YEDEKANAHTAR", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YEDEKANAHTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_YEDEKANHTRACKLM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YEDEKANHTRACKLM", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_YEDEKANHTRACKLM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YEDEKANHTRACKLM", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_GOREVBITIMTARIH", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOREVBITIMTARIH", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_GOREVBITIMTARIH", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOREVBITIMTARIH", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_GOREVDURUM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOREVDURUM", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_GOREVDURUM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOREVDURUM", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ILGILINOT", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ILGILINOT", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ILGILINOT", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ILGILINOT", DataRowVersion.Original, false, (object) null, "", "", ""));
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
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ARACRESIM1", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACRESIM1", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ARACRESIM1", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACRESIM1", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ARACRESIM2", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACRESIM2", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ARACRESIM2", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACRESIM2", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TAKIPVARYOKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TAKIPVARYOKID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TAKIPVARYOKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TAKIPVARYOKID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SIRANO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SIRANO", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SIRANO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SIRANO", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_GUNCELDEGERI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GUNCELDEGERI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_GUNCELDEGERI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GUNCELDEGERI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_YENIDEGERI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YENIDEGERI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_YENIDEGERI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YENIDEGERI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_PARABIRIMI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PARABIRIMI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_PARABIRIMI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PARABIRIMI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_GENELBAKIMKM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GENELBAKIMKM", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_GENELBAKIMKM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GENELBAKIMKM", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_MOTORYAGKM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MOTORYAGKM", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_MOTORYAGKM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MOTORYAGKM", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SANZIMANYAGKM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SANZIMANYAGKM", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SANZIMANYAGKM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SANZIMANYAGKM", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_DIFERANSIYELYAGKM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DIFERANSIYELYAGKM", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_DIFERANSIYELYAGKM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DIFERANSIYELYAGKM", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_HIDROLIKYAGKM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "HIDROLIKYAGKM", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_HIDROLIKYAGKM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "HIDROLIKYAGKM", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_YENIDEGERTARIH", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YENIDEGERTARIH", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_YENIDEGERTARIH", SqlDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YENIDEGERTARIH", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_HGSVARYOK", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "HGSVARYOK", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_HGSVARYOK", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "HGSVARYOK", DataRowVersion.Original, false, (object) null, "", "", ""));
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
      this._commandCollection[0].CommandText = "SELECT ID, KOD, VERILDIGIILILCE, PLAKA, ARACACIKLAMA, TAHSPLAKA, TAHSPLKTARIH, ESKIPLAKA, TESCILSIRANO, ILKTESCILTARIHI, TESCILTARIHI, MARKAID, MODEL, CINSI, TICARIADI, TIPI, RENGI, MOTORNO, SASENO, SILINDIRHACMI, MOTORGUCU, BEYGIRGUCU, TEKERLEKADEDI, YURUYENAKSAMI, LASTIKEBADI, DIGEROZELLIKLER, MUAYENEGECSUR, TRAFIKSGORTA, KASKO, BELGESERINO, ARACFIRMAID, BELDBIRIMID, BELDMUDURLUKID, TAHSISEDILENID, ARACKULPERSID, ARACGRUBUID, ARACGRUBU2ID, YAKITID, YKTYAKMATURU, STDYKYAKIT, ARACDURUMID, ARACTIPIID, TKPVARYOK, YEDEKANAHTAR, YEDEKANHTRACKLM, GOREVBITIMTARIH, GOREVDURUM, ILGILINOT, SAVEUSER, SAVEDATE, EDITUSER, EDITDATE, SAVEMAC, EDITMAC, SAVEIP, EDITIP, ARACRESIM1, ARACRESIM2, TAKIPVARYOKID, SIRANO, GUNCELDEGERI, YENIDEGERI, PARABIRIMI, GENELBAKIMKM, MOTORYAGKM, SANZIMANYAGKM, DIFERANSIYELYAGKM, HIDROLIKYAGKM, RESIMON, RESIMARKA, YENIDEGERTARIH, HGSVARYOK FROM dbo.TBLARACLAR";
      this._commandCollection[0].CommandType = CommandType.Text;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    public virtual int Fill(bellDataSet6.TBLARACLARDataTable dataTable)
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
    public virtual bellDataSet6.TBLARACLARDataTable GetData()
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      bellDataSet6.TBLARACLARDataTable data = new bellDataSet6.TBLARACLARDataTable();
      this.Adapter.Fill((DataTable) data);
      return data;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(bellDataSet6.TBLARACLARDataTable dataTable) => this.Adapter.Update((DataTable) dataTable);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(bellDataSet6 dataSet) => this.Adapter.Update((DataSet) dataSet, "TBLARACLAR");

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
      string Original_VERILDIGIILILCE,
      string Original_PLAKA,
      string Original_ARACACIKLAMA,
      string Original_TAHSPLAKA,
      string Original_TAHSPLKTARIH,
      string Original_ESKIPLAKA,
      string Original_TESCILSIRANO,
      string Original_ILKTESCILTARIHI,
      string Original_TESCILTARIHI,
      int? Original_MARKAID,
      string Original_MODEL,
      string Original_CINSI,
      string Original_TICARIADI,
      string Original_TIPI,
      string Original_RENGI,
      string Original_MOTORNO,
      string Original_SASENO,
      string Original_SILINDIRHACMI,
      string Original_MOTORGUCU,
      string Original_BEYGIRGUCU,
      string Original_TEKERLEKADEDI,
      string Original_YURUYENAKSAMI,
      string Original_LASTIKEBADI,
      string Original_DIGEROZELLIKLER,
      DateTime? Original_MUAYENEGECSUR,
      string Original_TRAFIKSGORTA,
      string Original_KASKO,
      string Original_BELGESERINO,
      int? Original_ARACFIRMAID,
      int? Original_BELDBIRIMID,
      int? Original_BELDMUDURLUKID,
      int? Original_TAHSISEDILENID,
      int? Original_ARACKULPERSID,
      int? Original_ARACGRUBUID,
      int? Original_ARACGRUBU2ID,
      int? Original_YAKITID,
      string Original_YKTYAKMATURU,
      string Original_STDYKYAKIT,
      int? Original_ARACDURUMID,
      int? Original_ARACTIPIID,
      string Original_TKPVARYOK,
      string Original_YEDEKANAHTAR,
      string Original_YEDEKANHTRACKLM,
      DateTime? Original_GOREVBITIMTARIH,
      string Original_GOREVDURUM,
      string Original_ILGILINOT,
      string Original_SAVEUSER,
      DateTime? Original_SAVEDATE,
      string Original_EDITUSER,
      DateTime? Original_EDITDATE,
      string Original_SAVEMAC,
      string Original_EDITMAC,
      string Original_SAVEIP,
      string Original_EDITIP,
      string Original_ARACRESIM1,
      string Original_ARACRESIM2,
      int? Original_TAKIPVARYOKID,
      string Original_SIRANO,
      string Original_GUNCELDEGERI,
      string Original_YENIDEGERI,
      string Original_PARABIRIMI,
      string Original_GENELBAKIMKM,
      string Original_MOTORYAGKM,
      string Original_SANZIMANYAGKM,
      string Original_DIFERANSIYELYAGKM,
      string Original_HIDROLIKYAGKM,
      DateTime? Original_YENIDEGERTARIH,
      int? Original_HGSVARYOK)
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
      if (Original_VERILDIGIILILCE == null)
      {
        this.Adapter.DeleteCommand.Parameters[3].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[4].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[3].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[4].Value = (object) Original_VERILDIGIILILCE;
      }
      if (Original_PLAKA == null)
      {
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[6].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[6].Value = (object) Original_PLAKA;
      }
      if (Original_ARACACIKLAMA == null)
      {
        this.Adapter.DeleteCommand.Parameters[7].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[8].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[7].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[8].Value = (object) Original_ARACACIKLAMA;
      }
      if (Original_TAHSPLAKA == null)
      {
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) Original_TAHSPLAKA;
      }
      if (Original_TAHSPLKTARIH == null)
      {
        this.Adapter.DeleteCommand.Parameters[11].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[12].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[11].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[12].Value = (object) Original_TAHSPLKTARIH;
      }
      if (Original_ESKIPLAKA == null)
      {
        this.Adapter.DeleteCommand.Parameters[13].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[14].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[13].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[14].Value = (object) Original_ESKIPLAKA;
      }
      if (Original_TESCILSIRANO == null)
      {
        this.Adapter.DeleteCommand.Parameters[15].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[16].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[15].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[16].Value = (object) Original_TESCILSIRANO;
      }
      if (Original_ILKTESCILTARIHI == null)
      {
        this.Adapter.DeleteCommand.Parameters[17].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[18].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[17].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[18].Value = (object) Original_ILKTESCILTARIHI;
      }
      if (Original_TESCILTARIHI == null)
      {
        this.Adapter.DeleteCommand.Parameters[19].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[20].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[19].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[20].Value = (object) Original_TESCILTARIHI;
      }
      if (Original_MARKAID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[21].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[22].Value = (object) Original_MARKAID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[21].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[22].Value = (object) DBNull.Value;
      }
      if (Original_MODEL == null)
      {
        this.Adapter.DeleteCommand.Parameters[23].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[24].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[23].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[24].Value = (object) Original_MODEL;
      }
      if (Original_CINSI == null)
      {
        this.Adapter.DeleteCommand.Parameters[25].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[26].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[25].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[26].Value = (object) Original_CINSI;
      }
      if (Original_TICARIADI == null)
      {
        this.Adapter.DeleteCommand.Parameters[27].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[28].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[27].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[28].Value = (object) Original_TICARIADI;
      }
      if (Original_TIPI == null)
      {
        this.Adapter.DeleteCommand.Parameters[29].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[30].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[29].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[30].Value = (object) Original_TIPI;
      }
      if (Original_RENGI == null)
      {
        this.Adapter.DeleteCommand.Parameters[31].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[32].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[31].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[32].Value = (object) Original_RENGI;
      }
      if (Original_MOTORNO == null)
      {
        this.Adapter.DeleteCommand.Parameters[33].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[34].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[33].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[34].Value = (object) Original_MOTORNO;
      }
      if (Original_SASENO == null)
      {
        this.Adapter.DeleteCommand.Parameters[35].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[36].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[35].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[36].Value = (object) Original_SASENO;
      }
      if (Original_SILINDIRHACMI == null)
      {
        this.Adapter.DeleteCommand.Parameters[37].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[38].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[37].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[38].Value = (object) Original_SILINDIRHACMI;
      }
      if (Original_MOTORGUCU == null)
      {
        this.Adapter.DeleteCommand.Parameters[39].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[40].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[39].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[40].Value = (object) Original_MOTORGUCU;
      }
      if (Original_BEYGIRGUCU == null)
      {
        this.Adapter.DeleteCommand.Parameters[41].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[42].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[41].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[42].Value = (object) Original_BEYGIRGUCU;
      }
      if (Original_TEKERLEKADEDI == null)
      {
        this.Adapter.DeleteCommand.Parameters[43].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[44].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[43].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[44].Value = (object) Original_TEKERLEKADEDI;
      }
      if (Original_YURUYENAKSAMI == null)
      {
        this.Adapter.DeleteCommand.Parameters[45].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[46].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[45].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[46].Value = (object) Original_YURUYENAKSAMI;
      }
      if (Original_LASTIKEBADI == null)
      {
        this.Adapter.DeleteCommand.Parameters[47].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[48].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[47].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[48].Value = (object) Original_LASTIKEBADI;
      }
      if (Original_DIGEROZELLIKLER == null)
      {
        this.Adapter.DeleteCommand.Parameters[49].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[50].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[49].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[50].Value = (object) Original_DIGEROZELLIKLER;
      }
      if (Original_MUAYENEGECSUR.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[51].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[52].Value = (object) Original_MUAYENEGECSUR.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[51].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[52].Value = (object) DBNull.Value;
      }
      if (Original_TRAFIKSGORTA == null)
      {
        this.Adapter.DeleteCommand.Parameters[53].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[54].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[53].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[54].Value = (object) Original_TRAFIKSGORTA;
      }
      if (Original_KASKO == null)
      {
        this.Adapter.DeleteCommand.Parameters[55].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[56].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[55].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[56].Value = (object) Original_KASKO;
      }
      if (Original_BELGESERINO == null)
      {
        this.Adapter.DeleteCommand.Parameters[57].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[58].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[57].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[58].Value = (object) Original_BELGESERINO;
      }
      if (Original_ARACFIRMAID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[59].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[60].Value = (object) Original_ARACFIRMAID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[59].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[60].Value = (object) DBNull.Value;
      }
      if (Original_BELDBIRIMID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[61].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[62].Value = (object) Original_BELDBIRIMID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[61].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[62].Value = (object) DBNull.Value;
      }
      if (Original_BELDMUDURLUKID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[63].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[64].Value = (object) Original_BELDMUDURLUKID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[63].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[64].Value = (object) DBNull.Value;
      }
      if (Original_TAHSISEDILENID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[65].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[66].Value = (object) Original_TAHSISEDILENID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[65].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[66].Value = (object) DBNull.Value;
      }
      if (Original_ARACKULPERSID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[67].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[68].Value = (object) Original_ARACKULPERSID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[67].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[68].Value = (object) DBNull.Value;
      }
      if (Original_ARACGRUBUID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[69].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[70].Value = (object) Original_ARACGRUBUID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[69].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[70].Value = (object) DBNull.Value;
      }
      if (Original_ARACGRUBU2ID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[71].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[72].Value = (object) Original_ARACGRUBU2ID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[71].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[72].Value = (object) DBNull.Value;
      }
      if (Original_YAKITID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[73].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[74].Value = (object) Original_YAKITID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[73].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[74].Value = (object) DBNull.Value;
      }
      if (Original_YKTYAKMATURU == null)
      {
        this.Adapter.DeleteCommand.Parameters[75].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[76].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[75].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[76].Value = (object) Original_YKTYAKMATURU;
      }
      if (Original_STDYKYAKIT == null)
      {
        this.Adapter.DeleteCommand.Parameters[77].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[78].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[77].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[78].Value = (object) Original_STDYKYAKIT;
      }
      if (Original_ARACDURUMID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[79].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[80].Value = (object) Original_ARACDURUMID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[79].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[80].Value = (object) DBNull.Value;
      }
      if (Original_ARACTIPIID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[81].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[82].Value = (object) Original_ARACTIPIID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[81].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[82].Value = (object) DBNull.Value;
      }
      if (Original_TKPVARYOK == null)
      {
        this.Adapter.DeleteCommand.Parameters[83].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[84].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[83].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[84].Value = (object) Original_TKPVARYOK;
      }
      if (Original_YEDEKANAHTAR == null)
      {
        this.Adapter.DeleteCommand.Parameters[85].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[86].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[85].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[86].Value = (object) Original_YEDEKANAHTAR;
      }
      if (Original_YEDEKANHTRACKLM == null)
      {
        this.Adapter.DeleteCommand.Parameters[87].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[88].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[87].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[88].Value = (object) Original_YEDEKANHTRACKLM;
      }
      if (Original_GOREVBITIMTARIH.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[89].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[90].Value = (object) Original_GOREVBITIMTARIH.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[89].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[90].Value = (object) DBNull.Value;
      }
      if (Original_GOREVDURUM == null)
      {
        this.Adapter.DeleteCommand.Parameters[91].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[92].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[91].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[92].Value = (object) Original_GOREVDURUM;
      }
      if (Original_ILGILINOT == null)
      {
        this.Adapter.DeleteCommand.Parameters[93].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[94].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[93].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[94].Value = (object) Original_ILGILINOT;
      }
      if (Original_SAVEUSER == null)
      {
        this.Adapter.DeleteCommand.Parameters[95].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[96].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[95].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[96].Value = (object) Original_SAVEUSER;
      }
      if (Original_SAVEDATE.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[97].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[98].Value = (object) Original_SAVEDATE.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[97].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[98].Value = (object) DBNull.Value;
      }
      if (Original_EDITUSER == null)
      {
        this.Adapter.DeleteCommand.Parameters[99].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[100].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[99].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[100].Value = (object) Original_EDITUSER;
      }
      if (Original_EDITDATE.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[101].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[102].Value = (object) Original_EDITDATE.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[101].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[102].Value = (object) DBNull.Value;
      }
      if (Original_SAVEMAC == null)
      {
        this.Adapter.DeleteCommand.Parameters[103].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[104].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[103].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[104].Value = (object) Original_SAVEMAC;
      }
      if (Original_EDITMAC == null)
      {
        this.Adapter.DeleteCommand.Parameters[105].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[106].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[105].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[106].Value = (object) Original_EDITMAC;
      }
      if (Original_SAVEIP == null)
      {
        this.Adapter.DeleteCommand.Parameters[107].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[108].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[107].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[108].Value = (object) Original_SAVEIP;
      }
      if (Original_EDITIP == null)
      {
        this.Adapter.DeleteCommand.Parameters[109].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[110].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[109].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[110].Value = (object) Original_EDITIP;
      }
      if (Original_ARACRESIM1 == null)
      {
        this.Adapter.DeleteCommand.Parameters[111].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[112].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[111].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[112].Value = (object) Original_ARACRESIM1;
      }
      if (Original_ARACRESIM2 == null)
      {
        this.Adapter.DeleteCommand.Parameters[113].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[114].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[113].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[114].Value = (object) Original_ARACRESIM2;
      }
      if (Original_TAKIPVARYOKID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[115].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[116].Value = (object) Original_TAKIPVARYOKID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[115].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[116].Value = (object) DBNull.Value;
      }
      if (Original_SIRANO == null)
      {
        this.Adapter.DeleteCommand.Parameters[117].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[118].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[117].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[118].Value = (object) Original_SIRANO;
      }
      if (Original_GUNCELDEGERI == null)
      {
        this.Adapter.DeleteCommand.Parameters[119].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[120].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[119].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[120].Value = (object) Original_GUNCELDEGERI;
      }
      if (Original_YENIDEGERI == null)
      {
        this.Adapter.DeleteCommand.Parameters[121].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[122].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[121].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[122].Value = (object) Original_YENIDEGERI;
      }
      if (Original_PARABIRIMI == null)
      {
        this.Adapter.DeleteCommand.Parameters[123].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[124].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[123].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[124].Value = (object) Original_PARABIRIMI;
      }
      if (Original_GENELBAKIMKM == null)
      {
        this.Adapter.DeleteCommand.Parameters[125].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[126].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[125].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[126].Value = (object) Original_GENELBAKIMKM;
      }
      if (Original_MOTORYAGKM == null)
      {
        this.Adapter.DeleteCommand.Parameters[(int) sbyte.MaxValue].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[128].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[(int) sbyte.MaxValue].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[128].Value = (object) Original_MOTORYAGKM;
      }
      if (Original_SANZIMANYAGKM == null)
      {
        this.Adapter.DeleteCommand.Parameters[129].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[130].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[129].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[130].Value = (object) Original_SANZIMANYAGKM;
      }
      if (Original_DIFERANSIYELYAGKM == null)
      {
        this.Adapter.DeleteCommand.Parameters[131].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[132].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[131].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[132].Value = (object) Original_DIFERANSIYELYAGKM;
      }
      if (Original_HIDROLIKYAGKM == null)
      {
        this.Adapter.DeleteCommand.Parameters[133].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[134].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[133].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[134].Value = (object) Original_HIDROLIKYAGKM;
      }
      if (Original_YENIDEGERTARIH.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[135].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[136].Value = (object) Original_YENIDEGERTARIH.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[135].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[136].Value = (object) DBNull.Value;
      }
      if (Original_HGSVARYOK.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[137].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[138].Value = (object) Original_HGSVARYOK.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[137].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[138].Value = (object) DBNull.Value;
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
      string VERILDIGIILILCE,
      string PLAKA,
      string ARACACIKLAMA,
      string TAHSPLAKA,
      string TAHSPLKTARIH,
      string ESKIPLAKA,
      string TESCILSIRANO,
      string ILKTESCILTARIHI,
      string TESCILTARIHI,
      int? MARKAID,
      string MODEL,
      string CINSI,
      string TICARIADI,
      string TIPI,
      string RENGI,
      string MOTORNO,
      string SASENO,
      string SILINDIRHACMI,
      string MOTORGUCU,
      string BEYGIRGUCU,
      string TEKERLEKADEDI,
      string YURUYENAKSAMI,
      string LASTIKEBADI,
      string DIGEROZELLIKLER,
      DateTime? MUAYENEGECSUR,
      string TRAFIKSGORTA,
      string KASKO,
      string BELGESERINO,
      int? ARACFIRMAID,
      int? BELDBIRIMID,
      int? BELDMUDURLUKID,
      int? TAHSISEDILENID,
      int? ARACKULPERSID,
      int? ARACGRUBUID,
      int? ARACGRUBU2ID,
      int? YAKITID,
      string YKTYAKMATURU,
      string STDYKYAKIT,
      int? ARACDURUMID,
      int? ARACTIPIID,
      string TKPVARYOK,
      string YEDEKANAHTAR,
      string YEDEKANHTRACKLM,
      DateTime? GOREVBITIMTARIH,
      string GOREVDURUM,
      string ILGILINOT,
      string SAVEUSER,
      DateTime? SAVEDATE,
      string EDITUSER,
      DateTime? EDITDATE,
      string SAVEMAC,
      string EDITMAC,
      string SAVEIP,
      string EDITIP,
      string ARACRESIM1,
      string ARACRESIM2,
      int? TAKIPVARYOKID,
      string SIRANO,
      string GUNCELDEGERI,
      string YENIDEGERI,
      string PARABIRIMI,
      string GENELBAKIMKM,
      string MOTORYAGKM,
      string SANZIMANYAGKM,
      string DIFERANSIYELYAGKM,
      string HIDROLIKYAGKM,
      byte[] RESIMON,
      byte[] RESIMARKA,
      DateTime? YENIDEGERTARIH,
      int? HGSVARYOK)
    {
      if (KOD == null)
        this.Adapter.InsertCommand.Parameters[0].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[0].Value = (object) KOD;
      if (VERILDIGIILILCE == null)
        this.Adapter.InsertCommand.Parameters[1].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[1].Value = (object) VERILDIGIILILCE;
      if (PLAKA == null)
        this.Adapter.InsertCommand.Parameters[2].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[2].Value = (object) PLAKA;
      if (ARACACIKLAMA == null)
        this.Adapter.InsertCommand.Parameters[3].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[3].Value = (object) ARACACIKLAMA;
      if (TAHSPLAKA == null)
        this.Adapter.InsertCommand.Parameters[4].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[4].Value = (object) TAHSPLAKA;
      if (TAHSPLKTARIH == null)
        this.Adapter.InsertCommand.Parameters[5].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[5].Value = (object) TAHSPLKTARIH;
      if (ESKIPLAKA == null)
        this.Adapter.InsertCommand.Parameters[6].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[6].Value = (object) ESKIPLAKA;
      if (TESCILSIRANO == null)
        this.Adapter.InsertCommand.Parameters[7].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[7].Value = (object) TESCILSIRANO;
      if (ILKTESCILTARIHI == null)
        this.Adapter.InsertCommand.Parameters[8].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[8].Value = (object) ILKTESCILTARIHI;
      if (TESCILTARIHI == null)
        this.Adapter.InsertCommand.Parameters[9].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[9].Value = (object) TESCILTARIHI;
      if (MARKAID.HasValue)
        this.Adapter.InsertCommand.Parameters[10].Value = (object) MARKAID.Value;
      else
        this.Adapter.InsertCommand.Parameters[10].Value = (object) DBNull.Value;
      if (MODEL == null)
        this.Adapter.InsertCommand.Parameters[11].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[11].Value = (object) MODEL;
      if (CINSI == null)
        this.Adapter.InsertCommand.Parameters[12].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[12].Value = (object) CINSI;
      if (TICARIADI == null)
        this.Adapter.InsertCommand.Parameters[13].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[13].Value = (object) TICARIADI;
      if (TIPI == null)
        this.Adapter.InsertCommand.Parameters[14].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[14].Value = (object) TIPI;
      if (RENGI == null)
        this.Adapter.InsertCommand.Parameters[15].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[15].Value = (object) RENGI;
      if (MOTORNO == null)
        this.Adapter.InsertCommand.Parameters[16].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[16].Value = (object) MOTORNO;
      if (SASENO == null)
        this.Adapter.InsertCommand.Parameters[17].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[17].Value = (object) SASENO;
      if (SILINDIRHACMI == null)
        this.Adapter.InsertCommand.Parameters[18].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[18].Value = (object) SILINDIRHACMI;
      if (MOTORGUCU == null)
        this.Adapter.InsertCommand.Parameters[19].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[19].Value = (object) MOTORGUCU;
      if (BEYGIRGUCU == null)
        this.Adapter.InsertCommand.Parameters[20].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[20].Value = (object) BEYGIRGUCU;
      if (TEKERLEKADEDI == null)
        this.Adapter.InsertCommand.Parameters[21].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[21].Value = (object) TEKERLEKADEDI;
      if (YURUYENAKSAMI == null)
        this.Adapter.InsertCommand.Parameters[22].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[22].Value = (object) YURUYENAKSAMI;
      if (LASTIKEBADI == null)
        this.Adapter.InsertCommand.Parameters[23].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[23].Value = (object) LASTIKEBADI;
      if (DIGEROZELLIKLER == null)
        this.Adapter.InsertCommand.Parameters[24].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[24].Value = (object) DIGEROZELLIKLER;
      if (MUAYENEGECSUR.HasValue)
        this.Adapter.InsertCommand.Parameters[25].Value = (object) MUAYENEGECSUR.Value;
      else
        this.Adapter.InsertCommand.Parameters[25].Value = (object) DBNull.Value;
      if (TRAFIKSGORTA == null)
        this.Adapter.InsertCommand.Parameters[26].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[26].Value = (object) TRAFIKSGORTA;
      if (KASKO == null)
        this.Adapter.InsertCommand.Parameters[27].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[27].Value = (object) KASKO;
      if (BELGESERINO == null)
        this.Adapter.InsertCommand.Parameters[28].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[28].Value = (object) BELGESERINO;
      if (ARACFIRMAID.HasValue)
        this.Adapter.InsertCommand.Parameters[29].Value = (object) ARACFIRMAID.Value;
      else
        this.Adapter.InsertCommand.Parameters[29].Value = (object) DBNull.Value;
      if (BELDBIRIMID.HasValue)
        this.Adapter.InsertCommand.Parameters[30].Value = (object) BELDBIRIMID.Value;
      else
        this.Adapter.InsertCommand.Parameters[30].Value = (object) DBNull.Value;
      if (BELDMUDURLUKID.HasValue)
        this.Adapter.InsertCommand.Parameters[31].Value = (object) BELDMUDURLUKID.Value;
      else
        this.Adapter.InsertCommand.Parameters[31].Value = (object) DBNull.Value;
      if (TAHSISEDILENID.HasValue)
        this.Adapter.InsertCommand.Parameters[32].Value = (object) TAHSISEDILENID.Value;
      else
        this.Adapter.InsertCommand.Parameters[32].Value = (object) DBNull.Value;
      if (ARACKULPERSID.HasValue)
        this.Adapter.InsertCommand.Parameters[33].Value = (object) ARACKULPERSID.Value;
      else
        this.Adapter.InsertCommand.Parameters[33].Value = (object) DBNull.Value;
      if (ARACGRUBUID.HasValue)
        this.Adapter.InsertCommand.Parameters[34].Value = (object) ARACGRUBUID.Value;
      else
        this.Adapter.InsertCommand.Parameters[34].Value = (object) DBNull.Value;
      if (ARACGRUBU2ID.HasValue)
        this.Adapter.InsertCommand.Parameters[35].Value = (object) ARACGRUBU2ID.Value;
      else
        this.Adapter.InsertCommand.Parameters[35].Value = (object) DBNull.Value;
      if (YAKITID.HasValue)
        this.Adapter.InsertCommand.Parameters[36].Value = (object) YAKITID.Value;
      else
        this.Adapter.InsertCommand.Parameters[36].Value = (object) DBNull.Value;
      if (YKTYAKMATURU == null)
        this.Adapter.InsertCommand.Parameters[37].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[37].Value = (object) YKTYAKMATURU;
      if (STDYKYAKIT == null)
        this.Adapter.InsertCommand.Parameters[38].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[38].Value = (object) STDYKYAKIT;
      if (ARACDURUMID.HasValue)
        this.Adapter.InsertCommand.Parameters[39].Value = (object) ARACDURUMID.Value;
      else
        this.Adapter.InsertCommand.Parameters[39].Value = (object) DBNull.Value;
      if (ARACTIPIID.HasValue)
        this.Adapter.InsertCommand.Parameters[40].Value = (object) ARACTIPIID.Value;
      else
        this.Adapter.InsertCommand.Parameters[40].Value = (object) DBNull.Value;
      if (TKPVARYOK == null)
        this.Adapter.InsertCommand.Parameters[41].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[41].Value = (object) TKPVARYOK;
      if (YEDEKANAHTAR == null)
        this.Adapter.InsertCommand.Parameters[42].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[42].Value = (object) YEDEKANAHTAR;
      if (YEDEKANHTRACKLM == null)
        this.Adapter.InsertCommand.Parameters[43].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[43].Value = (object) YEDEKANHTRACKLM;
      if (GOREVBITIMTARIH.HasValue)
        this.Adapter.InsertCommand.Parameters[44].Value = (object) GOREVBITIMTARIH.Value;
      else
        this.Adapter.InsertCommand.Parameters[44].Value = (object) DBNull.Value;
      if (GOREVDURUM == null)
        this.Adapter.InsertCommand.Parameters[45].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[45].Value = (object) GOREVDURUM;
      if (ILGILINOT == null)
        this.Adapter.InsertCommand.Parameters[46].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[46].Value = (object) ILGILINOT;
      if (SAVEUSER == null)
        this.Adapter.InsertCommand.Parameters[47].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[47].Value = (object) SAVEUSER;
      if (SAVEDATE.HasValue)
        this.Adapter.InsertCommand.Parameters[48].Value = (object) SAVEDATE.Value;
      else
        this.Adapter.InsertCommand.Parameters[48].Value = (object) DBNull.Value;
      if (EDITUSER == null)
        this.Adapter.InsertCommand.Parameters[49].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[49].Value = (object) EDITUSER;
      if (EDITDATE.HasValue)
        this.Adapter.InsertCommand.Parameters[50].Value = (object) EDITDATE.Value;
      else
        this.Adapter.InsertCommand.Parameters[50].Value = (object) DBNull.Value;
      if (SAVEMAC == null)
        this.Adapter.InsertCommand.Parameters[51].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[51].Value = (object) SAVEMAC;
      if (EDITMAC == null)
        this.Adapter.InsertCommand.Parameters[52].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[52].Value = (object) EDITMAC;
      if (SAVEIP == null)
        this.Adapter.InsertCommand.Parameters[53].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[53].Value = (object) SAVEIP;
      if (EDITIP == null)
        this.Adapter.InsertCommand.Parameters[54].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[54].Value = (object) EDITIP;
      if (ARACRESIM1 == null)
        this.Adapter.InsertCommand.Parameters[55].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[55].Value = (object) ARACRESIM1;
      if (ARACRESIM2 == null)
        this.Adapter.InsertCommand.Parameters[56].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[56].Value = (object) ARACRESIM2;
      if (TAKIPVARYOKID.HasValue)
        this.Adapter.InsertCommand.Parameters[57].Value = (object) TAKIPVARYOKID.Value;
      else
        this.Adapter.InsertCommand.Parameters[57].Value = (object) DBNull.Value;
      if (SIRANO == null)
        this.Adapter.InsertCommand.Parameters[58].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[58].Value = (object) SIRANO;
      if (GUNCELDEGERI == null)
        this.Adapter.InsertCommand.Parameters[59].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[59].Value = (object) GUNCELDEGERI;
      if (YENIDEGERI == null)
        this.Adapter.InsertCommand.Parameters[60].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[60].Value = (object) YENIDEGERI;
      if (PARABIRIMI == null)
        this.Adapter.InsertCommand.Parameters[61].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[61].Value = (object) PARABIRIMI;
      if (GENELBAKIMKM == null)
        this.Adapter.InsertCommand.Parameters[62].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[62].Value = (object) GENELBAKIMKM;
      if (MOTORYAGKM == null)
        this.Adapter.InsertCommand.Parameters[63].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[63].Value = (object) MOTORYAGKM;
      if (SANZIMANYAGKM == null)
        this.Adapter.InsertCommand.Parameters[64].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[64].Value = (object) SANZIMANYAGKM;
      if (DIFERANSIYELYAGKM == null)
        this.Adapter.InsertCommand.Parameters[65].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[65].Value = (object) DIFERANSIYELYAGKM;
      if (HIDROLIKYAGKM == null)
        this.Adapter.InsertCommand.Parameters[66].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[66].Value = (object) HIDROLIKYAGKM;
      if (RESIMON == null)
        this.Adapter.InsertCommand.Parameters[67].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[67].Value = (object) RESIMON;
      if (RESIMARKA == null)
        this.Adapter.InsertCommand.Parameters[68].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[68].Value = (object) RESIMARKA;
      if (YENIDEGERTARIH.HasValue)
        this.Adapter.InsertCommand.Parameters[69].Value = (object) YENIDEGERTARIH.Value;
      else
        this.Adapter.InsertCommand.Parameters[69].Value = (object) DBNull.Value;
      if (HGSVARYOK.HasValue)
        this.Adapter.InsertCommand.Parameters[70].Value = (object) HGSVARYOK.Value;
      else
        this.Adapter.InsertCommand.Parameters[70].Value = (object) DBNull.Value;
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
      string VERILDIGIILILCE,
      string PLAKA,
      string ARACACIKLAMA,
      string TAHSPLAKA,
      string TAHSPLKTARIH,
      string ESKIPLAKA,
      string TESCILSIRANO,
      string ILKTESCILTARIHI,
      string TESCILTARIHI,
      int? MARKAID,
      string MODEL,
      string CINSI,
      string TICARIADI,
      string TIPI,
      string RENGI,
      string MOTORNO,
      string SASENO,
      string SILINDIRHACMI,
      string MOTORGUCU,
      string BEYGIRGUCU,
      string TEKERLEKADEDI,
      string YURUYENAKSAMI,
      string LASTIKEBADI,
      string DIGEROZELLIKLER,
      DateTime? MUAYENEGECSUR,
      string TRAFIKSGORTA,
      string KASKO,
      string BELGESERINO,
      int? ARACFIRMAID,
      int? BELDBIRIMID,
      int? BELDMUDURLUKID,
      int? TAHSISEDILENID,
      int? ARACKULPERSID,
      int? ARACGRUBUID,
      int? ARACGRUBU2ID,
      int? YAKITID,
      string YKTYAKMATURU,
      string STDYKYAKIT,
      int? ARACDURUMID,
      int? ARACTIPIID,
      string TKPVARYOK,
      string YEDEKANAHTAR,
      string YEDEKANHTRACKLM,
      DateTime? GOREVBITIMTARIH,
      string GOREVDURUM,
      string ILGILINOT,
      string SAVEUSER,
      DateTime? SAVEDATE,
      string EDITUSER,
      DateTime? EDITDATE,
      string SAVEMAC,
      string EDITMAC,
      string SAVEIP,
      string EDITIP,
      string ARACRESIM1,
      string ARACRESIM2,
      int? TAKIPVARYOKID,
      string SIRANO,
      string GUNCELDEGERI,
      string YENIDEGERI,
      string PARABIRIMI,
      string GENELBAKIMKM,
      string MOTORYAGKM,
      string SANZIMANYAGKM,
      string DIFERANSIYELYAGKM,
      string HIDROLIKYAGKM,
      byte[] RESIMON,
      byte[] RESIMARKA,
      DateTime? YENIDEGERTARIH,
      int? HGSVARYOK,
      int Original_ID,
      string Original_KOD,
      string Original_VERILDIGIILILCE,
      string Original_PLAKA,
      string Original_ARACACIKLAMA,
      string Original_TAHSPLAKA,
      string Original_TAHSPLKTARIH,
      string Original_ESKIPLAKA,
      string Original_TESCILSIRANO,
      string Original_ILKTESCILTARIHI,
      string Original_TESCILTARIHI,
      int? Original_MARKAID,
      string Original_MODEL,
      string Original_CINSI,
      string Original_TICARIADI,
      string Original_TIPI,
      string Original_RENGI,
      string Original_MOTORNO,
      string Original_SASENO,
      string Original_SILINDIRHACMI,
      string Original_MOTORGUCU,
      string Original_BEYGIRGUCU,
      string Original_TEKERLEKADEDI,
      string Original_YURUYENAKSAMI,
      string Original_LASTIKEBADI,
      string Original_DIGEROZELLIKLER,
      DateTime? Original_MUAYENEGECSUR,
      string Original_TRAFIKSGORTA,
      string Original_KASKO,
      string Original_BELGESERINO,
      int? Original_ARACFIRMAID,
      int? Original_BELDBIRIMID,
      int? Original_BELDMUDURLUKID,
      int? Original_TAHSISEDILENID,
      int? Original_ARACKULPERSID,
      int? Original_ARACGRUBUID,
      int? Original_ARACGRUBU2ID,
      int? Original_YAKITID,
      string Original_YKTYAKMATURU,
      string Original_STDYKYAKIT,
      int? Original_ARACDURUMID,
      int? Original_ARACTIPIID,
      string Original_TKPVARYOK,
      string Original_YEDEKANAHTAR,
      string Original_YEDEKANHTRACKLM,
      DateTime? Original_GOREVBITIMTARIH,
      string Original_GOREVDURUM,
      string Original_ILGILINOT,
      string Original_SAVEUSER,
      DateTime? Original_SAVEDATE,
      string Original_EDITUSER,
      DateTime? Original_EDITDATE,
      string Original_SAVEMAC,
      string Original_EDITMAC,
      string Original_SAVEIP,
      string Original_EDITIP,
      string Original_ARACRESIM1,
      string Original_ARACRESIM2,
      int? Original_TAKIPVARYOKID,
      string Original_SIRANO,
      string Original_GUNCELDEGERI,
      string Original_YENIDEGERI,
      string Original_PARABIRIMI,
      string Original_GENELBAKIMKM,
      string Original_MOTORYAGKM,
      string Original_SANZIMANYAGKM,
      string Original_DIFERANSIYELYAGKM,
      string Original_HIDROLIKYAGKM,
      DateTime? Original_YENIDEGERTARIH,
      int? Original_HGSVARYOK,
      int ID)
    {
      if (KOD == null)
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) KOD;
      if (VERILDIGIILILCE == null)
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) VERILDIGIILILCE;
      if (PLAKA == null)
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) PLAKA;
      if (ARACACIKLAMA == null)
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) ARACACIKLAMA;
      if (TAHSPLAKA == null)
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) TAHSPLAKA;
      if (TAHSPLKTARIH == null)
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) TAHSPLKTARIH;
      if (ESKIPLAKA == null)
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) ESKIPLAKA;
      if (TESCILSIRANO == null)
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) TESCILSIRANO;
      if (ILKTESCILTARIHI == null)
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) ILKTESCILTARIHI;
      if (TESCILTARIHI == null)
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) TESCILTARIHI;
      if (MARKAID.HasValue)
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) MARKAID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) DBNull.Value;
      if (MODEL == null)
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) MODEL;
      if (CINSI == null)
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) CINSI;
      if (TICARIADI == null)
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) TICARIADI;
      if (TIPI == null)
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) TIPI;
      if (RENGI == null)
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) RENGI;
      if (MOTORNO == null)
        this.Adapter.UpdateCommand.Parameters[16].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[16].Value = (object) MOTORNO;
      if (SASENO == null)
        this.Adapter.UpdateCommand.Parameters[17].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[17].Value = (object) SASENO;
      if (SILINDIRHACMI == null)
        this.Adapter.UpdateCommand.Parameters[18].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[18].Value = (object) SILINDIRHACMI;
      if (MOTORGUCU == null)
        this.Adapter.UpdateCommand.Parameters[19].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[19].Value = (object) MOTORGUCU;
      if (BEYGIRGUCU == null)
        this.Adapter.UpdateCommand.Parameters[20].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[20].Value = (object) BEYGIRGUCU;
      if (TEKERLEKADEDI == null)
        this.Adapter.UpdateCommand.Parameters[21].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[21].Value = (object) TEKERLEKADEDI;
      if (YURUYENAKSAMI == null)
        this.Adapter.UpdateCommand.Parameters[22].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[22].Value = (object) YURUYENAKSAMI;
      if (LASTIKEBADI == null)
        this.Adapter.UpdateCommand.Parameters[23].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[23].Value = (object) LASTIKEBADI;
      if (DIGEROZELLIKLER == null)
        this.Adapter.UpdateCommand.Parameters[24].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[24].Value = (object) DIGEROZELLIKLER;
      if (MUAYENEGECSUR.HasValue)
        this.Adapter.UpdateCommand.Parameters[25].Value = (object) MUAYENEGECSUR.Value;
      else
        this.Adapter.UpdateCommand.Parameters[25].Value = (object) DBNull.Value;
      if (TRAFIKSGORTA == null)
        this.Adapter.UpdateCommand.Parameters[26].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[26].Value = (object) TRAFIKSGORTA;
      if (KASKO == null)
        this.Adapter.UpdateCommand.Parameters[27].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[27].Value = (object) KASKO;
      if (BELGESERINO == null)
        this.Adapter.UpdateCommand.Parameters[28].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[28].Value = (object) BELGESERINO;
      if (ARACFIRMAID.HasValue)
        this.Adapter.UpdateCommand.Parameters[29].Value = (object) ARACFIRMAID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[29].Value = (object) DBNull.Value;
      if (BELDBIRIMID.HasValue)
        this.Adapter.UpdateCommand.Parameters[30].Value = (object) BELDBIRIMID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[30].Value = (object) DBNull.Value;
      if (BELDMUDURLUKID.HasValue)
        this.Adapter.UpdateCommand.Parameters[31].Value = (object) BELDMUDURLUKID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[31].Value = (object) DBNull.Value;
      if (TAHSISEDILENID.HasValue)
        this.Adapter.UpdateCommand.Parameters[32].Value = (object) TAHSISEDILENID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[32].Value = (object) DBNull.Value;
      if (ARACKULPERSID.HasValue)
        this.Adapter.UpdateCommand.Parameters[33].Value = (object) ARACKULPERSID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[33].Value = (object) DBNull.Value;
      if (ARACGRUBUID.HasValue)
        this.Adapter.UpdateCommand.Parameters[34].Value = (object) ARACGRUBUID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[34].Value = (object) DBNull.Value;
      if (ARACGRUBU2ID.HasValue)
        this.Adapter.UpdateCommand.Parameters[35].Value = (object) ARACGRUBU2ID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[35].Value = (object) DBNull.Value;
      if (YAKITID.HasValue)
        this.Adapter.UpdateCommand.Parameters[36].Value = (object) YAKITID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[36].Value = (object) DBNull.Value;
      if (YKTYAKMATURU == null)
        this.Adapter.UpdateCommand.Parameters[37].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[37].Value = (object) YKTYAKMATURU;
      if (STDYKYAKIT == null)
        this.Adapter.UpdateCommand.Parameters[38].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[38].Value = (object) STDYKYAKIT;
      if (ARACDURUMID.HasValue)
        this.Adapter.UpdateCommand.Parameters[39].Value = (object) ARACDURUMID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[39].Value = (object) DBNull.Value;
      if (ARACTIPIID.HasValue)
        this.Adapter.UpdateCommand.Parameters[40].Value = (object) ARACTIPIID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[40].Value = (object) DBNull.Value;
      if (TKPVARYOK == null)
        this.Adapter.UpdateCommand.Parameters[41].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[41].Value = (object) TKPVARYOK;
      if (YEDEKANAHTAR == null)
        this.Adapter.UpdateCommand.Parameters[42].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[42].Value = (object) YEDEKANAHTAR;
      if (YEDEKANHTRACKLM == null)
        this.Adapter.UpdateCommand.Parameters[43].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[43].Value = (object) YEDEKANHTRACKLM;
      if (GOREVBITIMTARIH.HasValue)
        this.Adapter.UpdateCommand.Parameters[44].Value = (object) GOREVBITIMTARIH.Value;
      else
        this.Adapter.UpdateCommand.Parameters[44].Value = (object) DBNull.Value;
      if (GOREVDURUM == null)
        this.Adapter.UpdateCommand.Parameters[45].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[45].Value = (object) GOREVDURUM;
      if (ILGILINOT == null)
        this.Adapter.UpdateCommand.Parameters[46].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[46].Value = (object) ILGILINOT;
      if (SAVEUSER == null)
        this.Adapter.UpdateCommand.Parameters[47].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[47].Value = (object) SAVEUSER;
      if (SAVEDATE.HasValue)
        this.Adapter.UpdateCommand.Parameters[48].Value = (object) SAVEDATE.Value;
      else
        this.Adapter.UpdateCommand.Parameters[48].Value = (object) DBNull.Value;
      if (EDITUSER == null)
        this.Adapter.UpdateCommand.Parameters[49].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[49].Value = (object) EDITUSER;
      if (EDITDATE.HasValue)
        this.Adapter.UpdateCommand.Parameters[50].Value = (object) EDITDATE.Value;
      else
        this.Adapter.UpdateCommand.Parameters[50].Value = (object) DBNull.Value;
      if (SAVEMAC == null)
        this.Adapter.UpdateCommand.Parameters[51].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[51].Value = (object) SAVEMAC;
      if (EDITMAC == null)
        this.Adapter.UpdateCommand.Parameters[52].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[52].Value = (object) EDITMAC;
      if (SAVEIP == null)
        this.Adapter.UpdateCommand.Parameters[53].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[53].Value = (object) SAVEIP;
      if (EDITIP == null)
        this.Adapter.UpdateCommand.Parameters[54].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[54].Value = (object) EDITIP;
      if (ARACRESIM1 == null)
        this.Adapter.UpdateCommand.Parameters[55].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[55].Value = (object) ARACRESIM1;
      if (ARACRESIM2 == null)
        this.Adapter.UpdateCommand.Parameters[56].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[56].Value = (object) ARACRESIM2;
      if (TAKIPVARYOKID.HasValue)
        this.Adapter.UpdateCommand.Parameters[57].Value = (object) TAKIPVARYOKID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[57].Value = (object) DBNull.Value;
      if (SIRANO == null)
        this.Adapter.UpdateCommand.Parameters[58].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[58].Value = (object) SIRANO;
      if (GUNCELDEGERI == null)
        this.Adapter.UpdateCommand.Parameters[59].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[59].Value = (object) GUNCELDEGERI;
      if (YENIDEGERI == null)
        this.Adapter.UpdateCommand.Parameters[60].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[60].Value = (object) YENIDEGERI;
      if (PARABIRIMI == null)
        this.Adapter.UpdateCommand.Parameters[61].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[61].Value = (object) PARABIRIMI;
      if (GENELBAKIMKM == null)
        this.Adapter.UpdateCommand.Parameters[62].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[62].Value = (object) GENELBAKIMKM;
      if (MOTORYAGKM == null)
        this.Adapter.UpdateCommand.Parameters[63].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[63].Value = (object) MOTORYAGKM;
      if (SANZIMANYAGKM == null)
        this.Adapter.UpdateCommand.Parameters[64].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[64].Value = (object) SANZIMANYAGKM;
      if (DIFERANSIYELYAGKM == null)
        this.Adapter.UpdateCommand.Parameters[65].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[65].Value = (object) DIFERANSIYELYAGKM;
      if (HIDROLIKYAGKM == null)
        this.Adapter.UpdateCommand.Parameters[66].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[66].Value = (object) HIDROLIKYAGKM;
      if (RESIMON == null)
        this.Adapter.UpdateCommand.Parameters[67].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[67].Value = (object) RESIMON;
      if (RESIMARKA == null)
        this.Adapter.UpdateCommand.Parameters[68].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[68].Value = (object) RESIMARKA;
      if (YENIDEGERTARIH.HasValue)
        this.Adapter.UpdateCommand.Parameters[69].Value = (object) YENIDEGERTARIH.Value;
      else
        this.Adapter.UpdateCommand.Parameters[69].Value = (object) DBNull.Value;
      if (HGSVARYOK.HasValue)
        this.Adapter.UpdateCommand.Parameters[70].Value = (object) HGSVARYOK.Value;
      else
        this.Adapter.UpdateCommand.Parameters[70].Value = (object) DBNull.Value;
      this.Adapter.UpdateCommand.Parameters[71].Value = (object) Original_ID;
      if (Original_KOD == null)
      {
        this.Adapter.UpdateCommand.Parameters[72].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[73].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[72].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[73].Value = (object) Original_KOD;
      }
      if (Original_VERILDIGIILILCE == null)
      {
        this.Adapter.UpdateCommand.Parameters[74].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[75].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[74].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[75].Value = (object) Original_VERILDIGIILILCE;
      }
      if (Original_PLAKA == null)
      {
        this.Adapter.UpdateCommand.Parameters[76].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[77].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[76].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[77].Value = (object) Original_PLAKA;
      }
      if (Original_ARACACIKLAMA == null)
      {
        this.Adapter.UpdateCommand.Parameters[78].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[79].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[78].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[79].Value = (object) Original_ARACACIKLAMA;
      }
      if (Original_TAHSPLAKA == null)
      {
        this.Adapter.UpdateCommand.Parameters[80].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[81].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[80].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[81].Value = (object) Original_TAHSPLAKA;
      }
      if (Original_TAHSPLKTARIH == null)
      {
        this.Adapter.UpdateCommand.Parameters[82].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[83].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[82].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[83].Value = (object) Original_TAHSPLKTARIH;
      }
      if (Original_ESKIPLAKA == null)
      {
        this.Adapter.UpdateCommand.Parameters[84].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[85].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[84].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[85].Value = (object) Original_ESKIPLAKA;
      }
      if (Original_TESCILSIRANO == null)
      {
        this.Adapter.UpdateCommand.Parameters[86].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[87].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[86].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[87].Value = (object) Original_TESCILSIRANO;
      }
      if (Original_ILKTESCILTARIHI == null)
      {
        this.Adapter.UpdateCommand.Parameters[88].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[89].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[88].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[89].Value = (object) Original_ILKTESCILTARIHI;
      }
      if (Original_TESCILTARIHI == null)
      {
        this.Adapter.UpdateCommand.Parameters[90].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[91].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[90].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[91].Value = (object) Original_TESCILTARIHI;
      }
      if (Original_MARKAID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[92].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[93].Value = (object) Original_MARKAID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[92].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[93].Value = (object) DBNull.Value;
      }
      if (Original_MODEL == null)
      {
        this.Adapter.UpdateCommand.Parameters[94].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[95].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[94].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[95].Value = (object) Original_MODEL;
      }
      if (Original_CINSI == null)
      {
        this.Adapter.UpdateCommand.Parameters[96].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[97].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[96].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[97].Value = (object) Original_CINSI;
      }
      if (Original_TICARIADI == null)
      {
        this.Adapter.UpdateCommand.Parameters[98].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[99].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[98].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[99].Value = (object) Original_TICARIADI;
      }
      if (Original_TIPI == null)
      {
        this.Adapter.UpdateCommand.Parameters[100].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[101].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[100].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[101].Value = (object) Original_TIPI;
      }
      if (Original_RENGI == null)
      {
        this.Adapter.UpdateCommand.Parameters[102].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[103].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[102].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[103].Value = (object) Original_RENGI;
      }
      if (Original_MOTORNO == null)
      {
        this.Adapter.UpdateCommand.Parameters[104].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[105].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[104].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[105].Value = (object) Original_MOTORNO;
      }
      if (Original_SASENO == null)
      {
        this.Adapter.UpdateCommand.Parameters[106].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[107].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[106].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[107].Value = (object) Original_SASENO;
      }
      if (Original_SILINDIRHACMI == null)
      {
        this.Adapter.UpdateCommand.Parameters[108].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[109].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[108].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[109].Value = (object) Original_SILINDIRHACMI;
      }
      if (Original_MOTORGUCU == null)
      {
        this.Adapter.UpdateCommand.Parameters[110].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[111].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[110].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[111].Value = (object) Original_MOTORGUCU;
      }
      if (Original_BEYGIRGUCU == null)
      {
        this.Adapter.UpdateCommand.Parameters[112].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[113].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[112].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[113].Value = (object) Original_BEYGIRGUCU;
      }
      if (Original_TEKERLEKADEDI == null)
      {
        this.Adapter.UpdateCommand.Parameters[114].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[115].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[114].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[115].Value = (object) Original_TEKERLEKADEDI;
      }
      if (Original_YURUYENAKSAMI == null)
      {
        this.Adapter.UpdateCommand.Parameters[116].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[117].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[116].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[117].Value = (object) Original_YURUYENAKSAMI;
      }
      if (Original_LASTIKEBADI == null)
      {
        this.Adapter.UpdateCommand.Parameters[118].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[119].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[118].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[119].Value = (object) Original_LASTIKEBADI;
      }
      if (Original_DIGEROZELLIKLER == null)
      {
        this.Adapter.UpdateCommand.Parameters[120].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[121].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[120].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[121].Value = (object) Original_DIGEROZELLIKLER;
      }
      if (Original_MUAYENEGECSUR.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[122].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[123].Value = (object) Original_MUAYENEGECSUR.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[122].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[123].Value = (object) DBNull.Value;
      }
      if (Original_TRAFIKSGORTA == null)
      {
        this.Adapter.UpdateCommand.Parameters[124].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[125].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[124].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[125].Value = (object) Original_TRAFIKSGORTA;
      }
      if (Original_KASKO == null)
      {
        this.Adapter.UpdateCommand.Parameters[126].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[(int) sbyte.MaxValue].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[126].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[(int) sbyte.MaxValue].Value = (object) Original_KASKO;
      }
      if (Original_BELGESERINO == null)
      {
        this.Adapter.UpdateCommand.Parameters[128].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[129].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[128].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[129].Value = (object) Original_BELGESERINO;
      }
      if (Original_ARACFIRMAID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[130].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[131].Value = (object) Original_ARACFIRMAID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[130].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[131].Value = (object) DBNull.Value;
      }
      if (Original_BELDBIRIMID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[132].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[133].Value = (object) Original_BELDBIRIMID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[132].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[133].Value = (object) DBNull.Value;
      }
      if (Original_BELDMUDURLUKID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[134].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[135].Value = (object) Original_BELDMUDURLUKID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[134].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[135].Value = (object) DBNull.Value;
      }
      if (Original_TAHSISEDILENID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[136].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[137].Value = (object) Original_TAHSISEDILENID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[136].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[137].Value = (object) DBNull.Value;
      }
      if (Original_ARACKULPERSID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[138].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[139].Value = (object) Original_ARACKULPERSID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[138].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[139].Value = (object) DBNull.Value;
      }
      if (Original_ARACGRUBUID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[140].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[141].Value = (object) Original_ARACGRUBUID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[140].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[141].Value = (object) DBNull.Value;
      }
      if (Original_ARACGRUBU2ID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[142].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[143].Value = (object) Original_ARACGRUBU2ID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[142].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[143].Value = (object) DBNull.Value;
      }
      if (Original_YAKITID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[144].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[145].Value = (object) Original_YAKITID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[144].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[145].Value = (object) DBNull.Value;
      }
      if (Original_YKTYAKMATURU == null)
      {
        this.Adapter.UpdateCommand.Parameters[146].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[147].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[146].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[147].Value = (object) Original_YKTYAKMATURU;
      }
      if (Original_STDYKYAKIT == null)
      {
        this.Adapter.UpdateCommand.Parameters[148].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[149].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[148].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[149].Value = (object) Original_STDYKYAKIT;
      }
      if (Original_ARACDURUMID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[150].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[151].Value = (object) Original_ARACDURUMID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[150].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[151].Value = (object) DBNull.Value;
      }
      if (Original_ARACTIPIID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[152].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[153].Value = (object) Original_ARACTIPIID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[152].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[153].Value = (object) DBNull.Value;
      }
      if (Original_TKPVARYOK == null)
      {
        this.Adapter.UpdateCommand.Parameters[154].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[155].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[154].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[155].Value = (object) Original_TKPVARYOK;
      }
      if (Original_YEDEKANAHTAR == null)
      {
        this.Adapter.UpdateCommand.Parameters[156].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[157].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[156].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[157].Value = (object) Original_YEDEKANAHTAR;
      }
      if (Original_YEDEKANHTRACKLM == null)
      {
        this.Adapter.UpdateCommand.Parameters[158].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[159].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[158].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[159].Value = (object) Original_YEDEKANHTRACKLM;
      }
      if (Original_GOREVBITIMTARIH.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[160].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[161].Value = (object) Original_GOREVBITIMTARIH.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[160].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[161].Value = (object) DBNull.Value;
      }
      if (Original_GOREVDURUM == null)
      {
        this.Adapter.UpdateCommand.Parameters[162].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[163].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[162].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[163].Value = (object) Original_GOREVDURUM;
      }
      if (Original_ILGILINOT == null)
      {
        this.Adapter.UpdateCommand.Parameters[164].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[165].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[164].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[165].Value = (object) Original_ILGILINOT;
      }
      if (Original_SAVEUSER == null)
      {
        this.Adapter.UpdateCommand.Parameters[166].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[167].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[166].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[167].Value = (object) Original_SAVEUSER;
      }
      if (Original_SAVEDATE.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[168].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[169].Value = (object) Original_SAVEDATE.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[168].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[169].Value = (object) DBNull.Value;
      }
      if (Original_EDITUSER == null)
      {
        this.Adapter.UpdateCommand.Parameters[170].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[171].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[170].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[171].Value = (object) Original_EDITUSER;
      }
      if (Original_EDITDATE.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[172].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[173].Value = (object) Original_EDITDATE.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[172].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[173].Value = (object) DBNull.Value;
      }
      if (Original_SAVEMAC == null)
      {
        this.Adapter.UpdateCommand.Parameters[174].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[175].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[174].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[175].Value = (object) Original_SAVEMAC;
      }
      if (Original_EDITMAC == null)
      {
        this.Adapter.UpdateCommand.Parameters[176].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[177].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[176].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[177].Value = (object) Original_EDITMAC;
      }
      if (Original_SAVEIP == null)
      {
        this.Adapter.UpdateCommand.Parameters[178].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[179].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[178].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[179].Value = (object) Original_SAVEIP;
      }
      if (Original_EDITIP == null)
      {
        this.Adapter.UpdateCommand.Parameters[180].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[181].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[180].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[181].Value = (object) Original_EDITIP;
      }
      if (Original_ARACRESIM1 == null)
      {
        this.Adapter.UpdateCommand.Parameters[182].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[183].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[182].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[183].Value = (object) Original_ARACRESIM1;
      }
      if (Original_ARACRESIM2 == null)
      {
        this.Adapter.UpdateCommand.Parameters[184].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[185].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[184].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[185].Value = (object) Original_ARACRESIM2;
      }
      if (Original_TAKIPVARYOKID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[186].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[187].Value = (object) Original_TAKIPVARYOKID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[186].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[187].Value = (object) DBNull.Value;
      }
      if (Original_SIRANO == null)
      {
        this.Adapter.UpdateCommand.Parameters[188].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[189].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[188].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[189].Value = (object) Original_SIRANO;
      }
      if (Original_GUNCELDEGERI == null)
      {
        this.Adapter.UpdateCommand.Parameters[190].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[191].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[190].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[191].Value = (object) Original_GUNCELDEGERI;
      }
      if (Original_YENIDEGERI == null)
      {
        this.Adapter.UpdateCommand.Parameters[192].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[193].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[192].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[193].Value = (object) Original_YENIDEGERI;
      }
      if (Original_PARABIRIMI == null)
      {
        this.Adapter.UpdateCommand.Parameters[194].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[195].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[194].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[195].Value = (object) Original_PARABIRIMI;
      }
      if (Original_GENELBAKIMKM == null)
      {
        this.Adapter.UpdateCommand.Parameters[196].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[197].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[196].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[197].Value = (object) Original_GENELBAKIMKM;
      }
      if (Original_MOTORYAGKM == null)
      {
        this.Adapter.UpdateCommand.Parameters[198].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[199].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[198].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[199].Value = (object) Original_MOTORYAGKM;
      }
      if (Original_SANZIMANYAGKM == null)
      {
        this.Adapter.UpdateCommand.Parameters[200].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[201].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[200].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[201].Value = (object) Original_SANZIMANYAGKM;
      }
      if (Original_DIFERANSIYELYAGKM == null)
      {
        this.Adapter.UpdateCommand.Parameters[202].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[203].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[202].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[203].Value = (object) Original_DIFERANSIYELYAGKM;
      }
      if (Original_HIDROLIKYAGKM == null)
      {
        this.Adapter.UpdateCommand.Parameters[204].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[205].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[204].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[205].Value = (object) Original_HIDROLIKYAGKM;
      }
      if (Original_YENIDEGERTARIH.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[206].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[207].Value = (object) Original_YENIDEGERTARIH.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[206].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[207].Value = (object) DBNull.Value;
      }
      if (Original_HGSVARYOK.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[208].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[209].Value = (object) Original_HGSVARYOK.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[208].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[209].Value = (object) DBNull.Value;
      }
      this.Adapter.UpdateCommand.Parameters[210].Value = (object) ID;
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
      string VERILDIGIILILCE,
      string PLAKA,
      string ARACACIKLAMA,
      string TAHSPLAKA,
      string TAHSPLKTARIH,
      string ESKIPLAKA,
      string TESCILSIRANO,
      string ILKTESCILTARIHI,
      string TESCILTARIHI,
      int? MARKAID,
      string MODEL,
      string CINSI,
      string TICARIADI,
      string TIPI,
      string RENGI,
      string MOTORNO,
      string SASENO,
      string SILINDIRHACMI,
      string MOTORGUCU,
      string BEYGIRGUCU,
      string TEKERLEKADEDI,
      string YURUYENAKSAMI,
      string LASTIKEBADI,
      string DIGEROZELLIKLER,
      DateTime? MUAYENEGECSUR,
      string TRAFIKSGORTA,
      string KASKO,
      string BELGESERINO,
      int? ARACFIRMAID,
      int? BELDBIRIMID,
      int? BELDMUDURLUKID,
      int? TAHSISEDILENID,
      int? ARACKULPERSID,
      int? ARACGRUBUID,
      int? ARACGRUBU2ID,
      int? YAKITID,
      string YKTYAKMATURU,
      string STDYKYAKIT,
      int? ARACDURUMID,
      int? ARACTIPIID,
      string TKPVARYOK,
      string YEDEKANAHTAR,
      string YEDEKANHTRACKLM,
      DateTime? GOREVBITIMTARIH,
      string GOREVDURUM,
      string ILGILINOT,
      string SAVEUSER,
      DateTime? SAVEDATE,
      string EDITUSER,
      DateTime? EDITDATE,
      string SAVEMAC,
      string EDITMAC,
      string SAVEIP,
      string EDITIP,
      string ARACRESIM1,
      string ARACRESIM2,
      int? TAKIPVARYOKID,
      string SIRANO,
      string GUNCELDEGERI,
      string YENIDEGERI,
      string PARABIRIMI,
      string GENELBAKIMKM,
      string MOTORYAGKM,
      string SANZIMANYAGKM,
      string DIFERANSIYELYAGKM,
      string HIDROLIKYAGKM,
      byte[] RESIMON,
      byte[] RESIMARKA,
      DateTime? YENIDEGERTARIH,
      int? HGSVARYOK,
      int Original_ID,
      string Original_KOD,
      string Original_VERILDIGIILILCE,
      string Original_PLAKA,
      string Original_ARACACIKLAMA,
      string Original_TAHSPLAKA,
      string Original_TAHSPLKTARIH,
      string Original_ESKIPLAKA,
      string Original_TESCILSIRANO,
      string Original_ILKTESCILTARIHI,
      string Original_TESCILTARIHI,
      int? Original_MARKAID,
      string Original_MODEL,
      string Original_CINSI,
      string Original_TICARIADI,
      string Original_TIPI,
      string Original_RENGI,
      string Original_MOTORNO,
      string Original_SASENO,
      string Original_SILINDIRHACMI,
      string Original_MOTORGUCU,
      string Original_BEYGIRGUCU,
      string Original_TEKERLEKADEDI,
      string Original_YURUYENAKSAMI,
      string Original_LASTIKEBADI,
      string Original_DIGEROZELLIKLER,
      DateTime? Original_MUAYENEGECSUR,
      string Original_TRAFIKSGORTA,
      string Original_KASKO,
      string Original_BELGESERINO,
      int? Original_ARACFIRMAID,
      int? Original_BELDBIRIMID,
      int? Original_BELDMUDURLUKID,
      int? Original_TAHSISEDILENID,
      int? Original_ARACKULPERSID,
      int? Original_ARACGRUBUID,
      int? Original_ARACGRUBU2ID,
      int? Original_YAKITID,
      string Original_YKTYAKMATURU,
      string Original_STDYKYAKIT,
      int? Original_ARACDURUMID,
      int? Original_ARACTIPIID,
      string Original_TKPVARYOK,
      string Original_YEDEKANAHTAR,
      string Original_YEDEKANHTRACKLM,
      DateTime? Original_GOREVBITIMTARIH,
      string Original_GOREVDURUM,
      string Original_ILGILINOT,
      string Original_SAVEUSER,
      DateTime? Original_SAVEDATE,
      string Original_EDITUSER,
      DateTime? Original_EDITDATE,
      string Original_SAVEMAC,
      string Original_EDITMAC,
      string Original_SAVEIP,
      string Original_EDITIP,
      string Original_ARACRESIM1,
      string Original_ARACRESIM2,
      int? Original_TAKIPVARYOKID,
      string Original_SIRANO,
      string Original_GUNCELDEGERI,
      string Original_YENIDEGERI,
      string Original_PARABIRIMI,
      string Original_GENELBAKIMKM,
      string Original_MOTORYAGKM,
      string Original_SANZIMANYAGKM,
      string Original_DIFERANSIYELYAGKM,
      string Original_HIDROLIKYAGKM,
      DateTime? Original_YENIDEGERTARIH,
      int? Original_HGSVARYOK)
    {
      return this.Update(KOD, VERILDIGIILILCE, PLAKA, ARACACIKLAMA, TAHSPLAKA, TAHSPLKTARIH, ESKIPLAKA, TESCILSIRANO, ILKTESCILTARIHI, TESCILTARIHI, MARKAID, MODEL, CINSI, TICARIADI, TIPI, RENGI, MOTORNO, SASENO, SILINDIRHACMI, MOTORGUCU, BEYGIRGUCU, TEKERLEKADEDI, YURUYENAKSAMI, LASTIKEBADI, DIGEROZELLIKLER, MUAYENEGECSUR, TRAFIKSGORTA, KASKO, BELGESERINO, ARACFIRMAID, BELDBIRIMID, BELDMUDURLUKID, TAHSISEDILENID, ARACKULPERSID, ARACGRUBUID, ARACGRUBU2ID, YAKITID, YKTYAKMATURU, STDYKYAKIT, ARACDURUMID, ARACTIPIID, TKPVARYOK, YEDEKANAHTAR, YEDEKANHTRACKLM, GOREVBITIMTARIH, GOREVDURUM, ILGILINOT, SAVEUSER, SAVEDATE, EDITUSER, EDITDATE, SAVEMAC, EDITMAC, SAVEIP, EDITIP, ARACRESIM1, ARACRESIM2, TAKIPVARYOKID, SIRANO, GUNCELDEGERI, YENIDEGERI, PARABIRIMI, GENELBAKIMKM, MOTORYAGKM, SANZIMANYAGKM, DIFERANSIYELYAGKM, HIDROLIKYAGKM, RESIMON, RESIMARKA, YENIDEGERTARIH, HGSVARYOK, Original_ID, Original_KOD, Original_VERILDIGIILILCE, Original_PLAKA, Original_ARACACIKLAMA, Original_TAHSPLAKA, Original_TAHSPLKTARIH, Original_ESKIPLAKA, Original_TESCILSIRANO, Original_ILKTESCILTARIHI, Original_TESCILTARIHI, Original_MARKAID, Original_MODEL, Original_CINSI, Original_TICARIADI, Original_TIPI, Original_RENGI, Original_MOTORNO, Original_SASENO, Original_SILINDIRHACMI, Original_MOTORGUCU, Original_BEYGIRGUCU, Original_TEKERLEKADEDI, Original_YURUYENAKSAMI, Original_LASTIKEBADI, Original_DIGEROZELLIKLER, Original_MUAYENEGECSUR, Original_TRAFIKSGORTA, Original_KASKO, Original_BELGESERINO, Original_ARACFIRMAID, Original_BELDBIRIMID, Original_BELDMUDURLUKID, Original_TAHSISEDILENID, Original_ARACKULPERSID, Original_ARACGRUBUID, Original_ARACGRUBU2ID, Original_YAKITID, Original_YKTYAKMATURU, Original_STDYKYAKIT, Original_ARACDURUMID, Original_ARACTIPIID, Original_TKPVARYOK, Original_YEDEKANAHTAR, Original_YEDEKANHTRACKLM, Original_GOREVBITIMTARIH, Original_GOREVDURUM, Original_ILGILINOT, Original_SAVEUSER, Original_SAVEDATE, Original_EDITUSER, Original_EDITDATE, Original_SAVEMAC, Original_EDITMAC, Original_SAVEIP, Original_EDITIP, Original_ARACRESIM1, Original_ARACRESIM2, Original_TAKIPVARYOKID, Original_SIRANO, Original_GUNCELDEGERI, Original_YENIDEGERI, Original_PARABIRIMI, Original_GENELBAKIMKM, Original_MOTORYAGKM, Original_SANZIMANYAGKM, Original_DIFERANSIYELYAGKM, Original_HIDROLIKYAGKM, Original_YENIDEGERTARIH, Original_HGSVARYOK, Original_ID);
    }
  }
}
