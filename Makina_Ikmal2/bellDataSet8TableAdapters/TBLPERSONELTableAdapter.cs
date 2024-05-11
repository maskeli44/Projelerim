// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.bellDataSet8TableAdapters.TBLPERSONELTableAdapter
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
  public class TBLPERSONELTableAdapter : Component
  {
    private SqlDataAdapter _adapter;
    private SqlConnection _connection;
    private SqlTransaction _transaction;
    private SqlCommand[] _commandCollection;
    private bool _clearBeforeFill;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public TBLPERSONELTableAdapter() => this.ClearBeforeFill = true;

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
        DataSetTable = "TBLPERSONEL",
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
            "TCKIMLIKNO",
            "TCKIMLIKNO"
          },
          {
            "SICILNO",
            "SICILNO"
          },
          {
            "ADI",
            "ADI"
          },
          {
            "SOYADI",
            "SOYADI"
          },
          {
            "ADISOYADI",
            "ADISOYADI"
          },
          {
            "UNVANID",
            "UNVANID"
          },
          {
            "GOREVUNVANID",
            "GOREVUNVANID"
          },
          {
            "EGITIMID",
            "EGITIMID"
          },
          {
            "PERSISTIHDAMIID",
            "PERSISTIHDAMIID"
          },
          {
            "EHLIYETID",
            "EHLIYETID"
          },
          {
            "EHLVERTARIH",
            "EHLVERTARIH"
          },
          {
            "BELDBIRIMIID",
            "BELDBIRIMIID"
          },
          {
            "BELDMUDURLUKID",
            "BELDMUDURLUKID"
          },
          {
            "GOREVYERI",
            "GOREVYERI"
          },
          {
            "KANGRUPID",
            "KANGRUPID"
          },
          {
            "YETKILIIMZAID",
            "YETKILIIMZAID"
          },
          {
            "IKMADRES",
            "IKMADRES"
          },
          {
            "ARACID",
            "ARACID"
          },
          {
            "CEPTELEFON",
            "CEPTELEFON"
          },
          {
            "CEPTELEFON2",
            "CEPTELEFON2"
          },
          {
            "COCUKKIZ",
            "COCUKKIZ"
          },
          {
            "COCUKERKEK",
            "COCUKERKEK"
          },
          {
            "COCUKTOPLAM",
            "COCUKTOPLAM"
          },
          {
            "SIRANO",
            "SIRANO"
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
            "PERSDURUMID",
            "PERSDURUMID"
          },
          {
            "IZINTOPLAMI",
            "IZINTOPLAMI"
          },
          {
            "KULLANILANIZIN",
            "KULLANILANIZIN"
          },
          {
            "KALANIZIN",
            "KALANIZIN"
          },
          {
            "ISEGIRISTARIHI",
            "ISEGIRISTARIHI"
          },
          {
            "DOGUMTARIHI",
            "DOGUMTARIHI"
          },
          {
            "PARAFTANIM",
            "PARAFTANIM"
          },
          {
            "RESIM",
            "RESIM"
          },
          {
            "RESIMPER",
            "RESIMPER"
          }
        }
      });
      this._adapter.DeleteCommand = new SqlCommand();
      this._adapter.DeleteCommand.Connection = this.Connection;
      this._adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[TBLPERSONEL] WHERE (([ID] = @Original_ID) AND ((@IsNull_KOD = 1 AND [KOD] IS NULL) OR ([KOD] = @Original_KOD)) AND ((@IsNull_TCKIMLIKNO = 1 AND [TCKIMLIKNO] IS NULL) OR ([TCKIMLIKNO] = @Original_TCKIMLIKNO)) AND ((@IsNull_SICILNO = 1 AND [SICILNO] IS NULL) OR ([SICILNO] = @Original_SICILNO)) AND ((@IsNull_ADI = 1 AND [ADI] IS NULL) OR ([ADI] = @Original_ADI)) AND ((@IsNull_SOYADI = 1 AND [SOYADI] IS NULL) OR ([SOYADI] = @Original_SOYADI)) AND ((@IsNull_ADISOYADI = 1 AND [ADISOYADI] IS NULL) OR ([ADISOYADI] = @Original_ADISOYADI)) AND ((@IsNull_UNVANID = 1 AND [UNVANID] IS NULL) OR ([UNVANID] = @Original_UNVANID)) AND ((@IsNull_GOREVUNVANID = 1 AND [GOREVUNVANID] IS NULL) OR ([GOREVUNVANID] = @Original_GOREVUNVANID)) AND ((@IsNull_EGITIMID = 1 AND [EGITIMID] IS NULL) OR ([EGITIMID] = @Original_EGITIMID)) AND ((@IsNull_PERSISTIHDAMIID = 1 AND [PERSISTIHDAMIID] IS NULL) OR ([PERSISTIHDAMIID] = @Original_PERSISTIHDAMIID)) AND ((@IsNull_EHLIYETID = 1 AND [EHLIYETID] IS NULL) OR ([EHLIYETID] = @Original_EHLIYETID)) AND ((@IsNull_EHLVERTARIH = 1 AND [EHLVERTARIH] IS NULL) OR ([EHLVERTARIH] = @Original_EHLVERTARIH)) AND ((@IsNull_BELDBIRIMIID = 1 AND [BELDBIRIMIID] IS NULL) OR ([BELDBIRIMIID] = @Original_BELDBIRIMIID)) AND ((@IsNull_BELDMUDURLUKID = 1 AND [BELDMUDURLUKID] IS NULL) OR ([BELDMUDURLUKID] = @Original_BELDMUDURLUKID)) AND ((@IsNull_GOREVYERI = 1 AND [GOREVYERI] IS NULL) OR ([GOREVYERI] = @Original_GOREVYERI)) AND ((@IsNull_KANGRUPID = 1 AND [KANGRUPID] IS NULL) OR ([KANGRUPID] = @Original_KANGRUPID)) AND ((@IsNull_YETKILIIMZAID = 1 AND [YETKILIIMZAID] IS NULL) OR ([YETKILIIMZAID] = @Original_YETKILIIMZAID)) AND ((@IsNull_IKMADRES = 1 AND [IKMADRES] IS NULL) OR ([IKMADRES] = @Original_IKMADRES)) AND ((@IsNull_ARACID = 1 AND [ARACID] IS NULL) OR ([ARACID] = @Original_ARACID)) AND ((@IsNull_CEPTELEFON = 1 AND [CEPTELEFON] IS NULL) OR ([CEPTELEFON] = @Original_CEPTELEFON)) AND ((@IsNull_CEPTELEFON2 = 1 AND [CEPTELEFON2] IS NULL) OR ([CEPTELEFON2] = @Original_CEPTELEFON2)) AND ((@IsNull_COCUKKIZ = 1 AND [COCUKKIZ] IS NULL) OR ([COCUKKIZ] = @Original_COCUKKIZ)) AND ((@IsNull_COCUKERKEK = 1 AND [COCUKERKEK] IS NULL) OR ([COCUKERKEK] = @Original_COCUKERKEK)) AND ((@IsNull_COCUKTOPLAM = 1 AND [COCUKTOPLAM] IS NULL) OR ([COCUKTOPLAM] = @Original_COCUKTOPLAM)) AND ((@IsNull_SIRANO = 1 AND [SIRANO] IS NULL) OR ([SIRANO] = @Original_SIRANO)) AND ((@IsNull_SAVEUSER = 1 AND [SAVEUSER] IS NULL) OR ([SAVEUSER] = @Original_SAVEUSER)) AND ((@IsNull_SAVEDATE = 1 AND [SAVEDATE] IS NULL) OR ([SAVEDATE] = @Original_SAVEDATE)) AND ((@IsNull_EDITUSER = 1 AND [EDITUSER] IS NULL) OR ([EDITUSER] = @Original_EDITUSER)) AND ((@IsNull_EDITDATE = 1 AND [EDITDATE] IS NULL) OR ([EDITDATE] = @Original_EDITDATE)) AND ((@IsNull_SAVEMAC = 1 AND [SAVEMAC] IS NULL) OR ([SAVEMAC] = @Original_SAVEMAC)) AND ((@IsNull_EDITMAC = 1 AND [EDITMAC] IS NULL) OR ([EDITMAC] = @Original_EDITMAC)) AND ((@IsNull_SAVEIP = 1 AND [SAVEIP] IS NULL) OR ([SAVEIP] = @Original_SAVEIP)) AND ((@IsNull_EDITIP = 1 AND [EDITIP] IS NULL) OR ([EDITIP] = @Original_EDITIP)) AND ((@IsNull_PERSDURUMID = 1 AND [PERSDURUMID] IS NULL) OR ([PERSDURUMID] = @Original_PERSDURUMID)) AND ((@IsNull_IZINTOPLAMI = 1 AND [IZINTOPLAMI] IS NULL) OR ([IZINTOPLAMI] = @Original_IZINTOPLAMI)) AND ((@IsNull_KULLANILANIZIN = 1 AND [KULLANILANIZIN] IS NULL) OR ([KULLANILANIZIN] = @Original_KULLANILANIZIN)) AND ((@IsNull_KALANIZIN = 1 AND [KALANIZIN] IS NULL) OR ([KALANIZIN] = @Original_KALANIZIN)) AND ((@IsNull_ISEGIRISTARIHI = 1 AND [ISEGIRISTARIHI] IS NULL) OR ([ISEGIRISTARIHI] = @Original_ISEGIRISTARIHI)) AND ((@IsNull_DOGUMTARIHI = 1 AND [DOGUMTARIHI] IS NULL) OR ([DOGUMTARIHI] = @Original_DOGUMTARIHI)) AND ((@IsNull_PARAFTANIM = 1 AND [PARAFTANIM] IS NULL) OR ([PARAFTANIM] = @Original_PARAFTANIM)) AND ((@IsNull_RESIM = 1 AND [RESIM] IS NULL) OR ([RESIM] = @Original_RESIM)))";
      this._adapter.DeleteCommand.CommandType = CommandType.Text;
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_KOD", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_KOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TCKIMLIKNO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TCKIMLIKNO", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TCKIMLIKNO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TCKIMLIKNO", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SICILNO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SICILNO", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SICILNO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SICILNO", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ADI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ADI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ADI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SOYADI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SOYADI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SOYADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SOYADI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ADISOYADI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ADISOYADI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ADISOYADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ADISOYADI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_UNVANID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "UNVANID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_UNVANID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "UNVANID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_GOREVUNVANID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOREVUNVANID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_GOREVUNVANID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOREVUNVANID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_EGITIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EGITIMID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_EGITIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EGITIMID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_PERSISTIHDAMIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PERSISTIHDAMIID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_PERSISTIHDAMIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PERSISTIHDAMIID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_EHLIYETID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EHLIYETID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_EHLIYETID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EHLIYETID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_EHLVERTARIH", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EHLVERTARIH", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_EHLVERTARIH", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EHLVERTARIH", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_BELDBIRIMIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELDBIRIMIID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_BELDBIRIMIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELDBIRIMIID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_BELDMUDURLUKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELDMUDURLUKID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_BELDMUDURLUKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELDMUDURLUKID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_GOREVYERI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOREVYERI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_GOREVYERI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOREVYERI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_KANGRUPID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KANGRUPID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_KANGRUPID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KANGRUPID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_YETKILIIMZAID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YETKILIIMZAID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_YETKILIIMZAID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YETKILIIMZAID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_IKMADRES", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IKMADRES", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_IKMADRES", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IKMADRES", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ARACID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ARACID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_CEPTELEFON", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CEPTELEFON", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_CEPTELEFON", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CEPTELEFON", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_CEPTELEFON2", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CEPTELEFON2", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_CEPTELEFON2", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CEPTELEFON2", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_COCUKKIZ", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "COCUKKIZ", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_COCUKKIZ", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "COCUKKIZ", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_COCUKERKEK", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "COCUKERKEK", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_COCUKERKEK", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "COCUKERKEK", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_COCUKTOPLAM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "COCUKTOPLAM", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_COCUKTOPLAM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "COCUKTOPLAM", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SIRANO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SIRANO", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SIRANO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SIRANO", DataRowVersion.Original, false, (object) null, "", "", ""));
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
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_PERSDURUMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PERSDURUMID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_PERSDURUMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PERSDURUMID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_IZINTOPLAMI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINTOPLAMI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_IZINTOPLAMI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINTOPLAMI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_KULLANILANIZIN", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KULLANILANIZIN", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_KULLANILANIZIN", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KULLANILANIZIN", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_KALANIZIN", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KALANIZIN", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_KALANIZIN", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KALANIZIN", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ISEGIRISTARIHI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISEGIRISTARIHI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ISEGIRISTARIHI", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISEGIRISTARIHI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_DOGUMTARIHI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DOGUMTARIHI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_DOGUMTARIHI", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DOGUMTARIHI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_PARAFTANIM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PARAFTANIM", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_PARAFTANIM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PARAFTANIM", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_RESIM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RESIM", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_RESIM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RESIM", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.InsertCommand = new SqlCommand();
      this._adapter.InsertCommand.Connection = this.Connection;
      this._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[TBLPERSONEL] ([KOD], [TCKIMLIKNO], [SICILNO], [ADI], [SOYADI], [ADISOYADI], [UNVANID], [GOREVUNVANID], [EGITIMID], [PERSISTIHDAMIID], [EHLIYETID], [EHLVERTARIH], [BELDBIRIMIID], [BELDMUDURLUKID], [GOREVYERI], [KANGRUPID], [YETKILIIMZAID], [IKMADRES], [ARACID], [CEPTELEFON], [CEPTELEFON2], [COCUKKIZ], [COCUKERKEK], [COCUKTOPLAM], [SIRANO], [SAVEUSER], [SAVEDATE], [EDITUSER], [EDITDATE], [SAVEMAC], [EDITMAC], [SAVEIP], [EDITIP], [PERSDURUMID], [IZINTOPLAMI], [KULLANILANIZIN], [KALANIZIN], [ISEGIRISTARIHI], [DOGUMTARIHI], [PARAFTANIM], [RESIM], [RESIMPER]) VALUES (@KOD, @TCKIMLIKNO, @SICILNO, @ADI, @SOYADI, @ADISOYADI, @UNVANID, @GOREVUNVANID, @EGITIMID, @PERSISTIHDAMIID, @EHLIYETID, @EHLVERTARIH, @BELDBIRIMIID, @BELDMUDURLUKID, @GOREVYERI, @KANGRUPID, @YETKILIIMZAID, @IKMADRES, @ARACID, @CEPTELEFON, @CEPTELEFON2, @COCUKKIZ, @COCUKERKEK, @COCUKTOPLAM, @SIRANO, @SAVEUSER, @SAVEDATE, @EDITUSER, @EDITDATE, @SAVEMAC, @EDITMAC, @SAVEIP, @EDITIP, @PERSDURUMID, @IZINTOPLAMI, @KULLANILANIZIN, @KALANIZIN, @ISEGIRISTARIHI, @DOGUMTARIHI, @PARAFTANIM, @RESIM, @RESIMPER);\r\nSELECT ID, KOD, TCKIMLIKNO, SICILNO, ADI, SOYADI, ADISOYADI, UNVANID, GOREVUNVANID, EGITIMID, PERSISTIHDAMIID, EHLIYETID, EHLVERTARIH, BELDBIRIMIID, BELDMUDURLUKID, GOREVYERI, KANGRUPID, YETKILIIMZAID, IKMADRES, ARACID, CEPTELEFON, CEPTELEFON2, COCUKKIZ, COCUKERKEK, COCUKTOPLAM, SIRANO, SAVEUSER, SAVEDATE, EDITUSER, EDITDATE, SAVEMAC, EDITMAC, SAVEIP, EDITIP, PERSDURUMID, IZINTOPLAMI, KULLANILANIZIN, KALANIZIN, ISEGIRISTARIHI, DOGUMTARIHI, PARAFTANIM, RESIM, RESIMPER FROM TBLPERSONEL WHERE (ID = SCOPE_IDENTITY())";
      this._adapter.InsertCommand.CommandType = CommandType.Text;
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@KOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@TCKIMLIKNO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TCKIMLIKNO", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SICILNO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SICILNO", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ADI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SOYADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SOYADI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ADISOYADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ADISOYADI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@UNVANID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "UNVANID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@GOREVUNVANID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOREVUNVANID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@EGITIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EGITIMID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@PERSISTIHDAMIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PERSISTIHDAMIID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@EHLIYETID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EHLIYETID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@EHLVERTARIH", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EHLVERTARIH", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@BELDBIRIMIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELDBIRIMIID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@BELDMUDURLUKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELDMUDURLUKID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@GOREVYERI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOREVYERI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@KANGRUPID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KANGRUPID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@YETKILIIMZAID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YETKILIIMZAID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@IKMADRES", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IKMADRES", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ARACID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@CEPTELEFON", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CEPTELEFON", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@CEPTELEFON2", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CEPTELEFON2", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@COCUKKIZ", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "COCUKKIZ", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@COCUKERKEK", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "COCUKERKEK", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@COCUKTOPLAM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "COCUKTOPLAM", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SIRANO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SIRANO", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SAVEUSER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEUSER", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SAVEDATE", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEDATE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@EDITUSER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITUSER", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@EDITDATE", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITDATE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SAVEMAC", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEMAC", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@EDITMAC", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITMAC", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SAVEIP", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEIP", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@EDITIP", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITIP", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@PERSDURUMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PERSDURUMID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@IZINTOPLAMI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINTOPLAMI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@KULLANILANIZIN", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KULLANILANIZIN", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@KALANIZIN", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KALANIZIN", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ISEGIRISTARIHI", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISEGIRISTARIHI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@DOGUMTARIHI", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DOGUMTARIHI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@PARAFTANIM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PARAFTANIM", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@RESIM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RESIM", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@RESIMPER", SqlDbType.Image, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RESIMPER", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand = new SqlCommand();
      this._adapter.UpdateCommand.Connection = this.Connection;
      this._adapter.UpdateCommand.CommandText = "UPDATE [dbo].[TBLPERSONEL] SET [KOD] = @KOD, [TCKIMLIKNO] = @TCKIMLIKNO, [SICILNO] = @SICILNO, [ADI] = @ADI, [SOYADI] = @SOYADI, [ADISOYADI] = @ADISOYADI, [UNVANID] = @UNVANID, [GOREVUNVANID] = @GOREVUNVANID, [EGITIMID] = @EGITIMID, [PERSISTIHDAMIID] = @PERSISTIHDAMIID, [EHLIYETID] = @EHLIYETID, [EHLVERTARIH] = @EHLVERTARIH, [BELDBIRIMIID] = @BELDBIRIMIID, [BELDMUDURLUKID] = @BELDMUDURLUKID, [GOREVYERI] = @GOREVYERI, [KANGRUPID] = @KANGRUPID, [YETKILIIMZAID] = @YETKILIIMZAID, [IKMADRES] = @IKMADRES, [ARACID] = @ARACID, [CEPTELEFON] = @CEPTELEFON, [CEPTELEFON2] = @CEPTELEFON2, [COCUKKIZ] = @COCUKKIZ, [COCUKERKEK] = @COCUKERKEK, [COCUKTOPLAM] = @COCUKTOPLAM, [SIRANO] = @SIRANO, [SAVEUSER] = @SAVEUSER, [SAVEDATE] = @SAVEDATE, [EDITUSER] = @EDITUSER, [EDITDATE] = @EDITDATE, [SAVEMAC] = @SAVEMAC, [EDITMAC] = @EDITMAC, [SAVEIP] = @SAVEIP, [EDITIP] = @EDITIP, [PERSDURUMID] = @PERSDURUMID, [IZINTOPLAMI] = @IZINTOPLAMI, [KULLANILANIZIN] = @KULLANILANIZIN, [KALANIZIN] = @KALANIZIN, [ISEGIRISTARIHI] = @ISEGIRISTARIHI, [DOGUMTARIHI] = @DOGUMTARIHI, [PARAFTANIM] = @PARAFTANIM, [RESIM] = @RESIM, [RESIMPER] = @RESIMPER WHERE (([ID] = @Original_ID) AND ((@IsNull_KOD = 1 AND [KOD] IS NULL) OR ([KOD] = @Original_KOD)) AND ((@IsNull_TCKIMLIKNO = 1 AND [TCKIMLIKNO] IS NULL) OR ([TCKIMLIKNO] = @Original_TCKIMLIKNO)) AND ((@IsNull_SICILNO = 1 AND [SICILNO] IS NULL) OR ([SICILNO] = @Original_SICILNO)) AND ((@IsNull_ADI = 1 AND [ADI] IS NULL) OR ([ADI] = @Original_ADI)) AND ((@IsNull_SOYADI = 1 AND [SOYADI] IS NULL) OR ([SOYADI] = @Original_SOYADI)) AND ((@IsNull_ADISOYADI = 1 AND [ADISOYADI] IS NULL) OR ([ADISOYADI] = @Original_ADISOYADI)) AND ((@IsNull_UNVANID = 1 AND [UNVANID] IS NULL) OR ([UNVANID] = @Original_UNVANID)) AND ((@IsNull_GOREVUNVANID = 1 AND [GOREVUNVANID] IS NULL) OR ([GOREVUNVANID] = @Original_GOREVUNVANID)) AND ((@IsNull_EGITIMID = 1 AND [EGITIMID] IS NULL) OR ([EGITIMID] = @Original_EGITIMID)) AND ((@IsNull_PERSISTIHDAMIID = 1 AND [PERSISTIHDAMIID] IS NULL) OR ([PERSISTIHDAMIID] = @Original_PERSISTIHDAMIID)) AND ((@IsNull_EHLIYETID = 1 AND [EHLIYETID] IS NULL) OR ([EHLIYETID] = @Original_EHLIYETID)) AND ((@IsNull_EHLVERTARIH = 1 AND [EHLVERTARIH] IS NULL) OR ([EHLVERTARIH] = @Original_EHLVERTARIH)) AND ((@IsNull_BELDBIRIMIID = 1 AND [BELDBIRIMIID] IS NULL) OR ([BELDBIRIMIID] = @Original_BELDBIRIMIID)) AND ((@IsNull_BELDMUDURLUKID = 1 AND [BELDMUDURLUKID] IS NULL) OR ([BELDMUDURLUKID] = @Original_BELDMUDURLUKID)) AND ((@IsNull_GOREVYERI = 1 AND [GOREVYERI] IS NULL) OR ([GOREVYERI] = @Original_GOREVYERI)) AND ((@IsNull_KANGRUPID = 1 AND [KANGRUPID] IS NULL) OR ([KANGRUPID] = @Original_KANGRUPID)) AND ((@IsNull_YETKILIIMZAID = 1 AND [YETKILIIMZAID] IS NULL) OR ([YETKILIIMZAID] = @Original_YETKILIIMZAID)) AND ((@IsNull_IKMADRES = 1 AND [IKMADRES] IS NULL) OR ([IKMADRES] = @Original_IKMADRES)) AND ((@IsNull_ARACID = 1 AND [ARACID] IS NULL) OR ([ARACID] = @Original_ARACID)) AND ((@IsNull_CEPTELEFON = 1 AND [CEPTELEFON] IS NULL) OR ([CEPTELEFON] = @Original_CEPTELEFON)) AND ((@IsNull_CEPTELEFON2 = 1 AND [CEPTELEFON2] IS NULL) OR ([CEPTELEFON2] = @Original_CEPTELEFON2)) AND ((@IsNull_COCUKKIZ = 1 AND [COCUKKIZ] IS NULL) OR ([COCUKKIZ] = @Original_COCUKKIZ)) AND ((@IsNull_COCUKERKEK = 1 AND [COCUKERKEK] IS NULL) OR ([COCUKERKEK] = @Original_COCUKERKEK)) AND ((@IsNull_COCUKTOPLAM = 1 AND [COCUKTOPLAM] IS NULL) OR ([COCUKTOPLAM] = @Original_COCUKTOPLAM)) AND ((@IsNull_SIRANO = 1 AND [SIRANO] IS NULL) OR ([SIRANO] = @Original_SIRANO)) AND ((@IsNull_SAVEUSER = 1 AND [SAVEUSER] IS NULL) OR ([SAVEUSER] = @Original_SAVEUSER)) AND ((@IsNull_SAVEDATE = 1 AND [SAVEDATE] IS NULL) OR ([SAVEDATE] = @Original_SAVEDATE)) AND ((@IsNull_EDITUSER = 1 AND [EDITUSER] IS NULL) OR ([EDITUSER] = @Original_EDITUSER)) AND ((@IsNull_EDITDATE = 1 AND [EDITDATE] IS NULL) OR ([EDITDATE] = @Original_EDITDATE)) AND ((@IsNull_SAVEMAC = 1 AND [SAVEMAC] IS NULL) OR ([SAVEMAC] = @Original_SAVEMAC)) AND ((@IsNull_EDITMAC = 1 AND [EDITMAC] IS NULL) OR ([EDITMAC] = @Original_EDITMAC)) AND ((@IsNull_SAVEIP = 1 AND [SAVEIP] IS NULL) OR ([SAVEIP] = @Original_SAVEIP)) AND ((@IsNull_EDITIP = 1 AND [EDITIP] IS NULL) OR ([EDITIP] = @Original_EDITIP)) AND ((@IsNull_PERSDURUMID = 1 AND [PERSDURUMID] IS NULL) OR ([PERSDURUMID] = @Original_PERSDURUMID)) AND ((@IsNull_IZINTOPLAMI = 1 AND [IZINTOPLAMI] IS NULL) OR ([IZINTOPLAMI] = @Original_IZINTOPLAMI)) AND ((@IsNull_KULLANILANIZIN = 1 AND [KULLANILANIZIN] IS NULL) OR ([KULLANILANIZIN] = @Original_KULLANILANIZIN)) AND ((@IsNull_KALANIZIN = 1 AND [KALANIZIN] IS NULL) OR ([KALANIZIN] = @Original_KALANIZIN)) AND ((@IsNull_ISEGIRISTARIHI = 1 AND [ISEGIRISTARIHI] IS NULL) OR ([ISEGIRISTARIHI] = @Original_ISEGIRISTARIHI)) AND ((@IsNull_DOGUMTARIHI = 1 AND [DOGUMTARIHI] IS NULL) OR ([DOGUMTARIHI] = @Original_DOGUMTARIHI)) AND ((@IsNull_PARAFTANIM = 1 AND [PARAFTANIM] IS NULL) OR ([PARAFTANIM] = @Original_PARAFTANIM)) AND ((@IsNull_RESIM = 1 AND [RESIM] IS NULL) OR ([RESIM] = @Original_RESIM)));\r\nSELECT ID, KOD, TCKIMLIKNO, SICILNO, ADI, SOYADI, ADISOYADI, UNVANID, GOREVUNVANID, EGITIMID, PERSISTIHDAMIID, EHLIYETID, EHLVERTARIH, BELDBIRIMIID, BELDMUDURLUKID, GOREVYERI, KANGRUPID, YETKILIIMZAID, IKMADRES, ARACID, CEPTELEFON, CEPTELEFON2, COCUKKIZ, COCUKERKEK, COCUKTOPLAM, SIRANO, SAVEUSER, SAVEDATE, EDITUSER, EDITDATE, SAVEMAC, EDITMAC, SAVEIP, EDITIP, PERSDURUMID, IZINTOPLAMI, KULLANILANIZIN, KALANIZIN, ISEGIRISTARIHI, DOGUMTARIHI, PARAFTANIM, RESIM, RESIMPER FROM TBLPERSONEL WHERE (ID = @ID)";
      this._adapter.UpdateCommand.CommandType = CommandType.Text;
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@KOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TCKIMLIKNO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TCKIMLIKNO", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SICILNO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SICILNO", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ADI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SOYADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SOYADI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ADISOYADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ADISOYADI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@UNVANID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "UNVANID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@GOREVUNVANID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOREVUNVANID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EGITIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EGITIMID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@PERSISTIHDAMIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PERSISTIHDAMIID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EHLIYETID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EHLIYETID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EHLVERTARIH", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EHLVERTARIH", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@BELDBIRIMIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELDBIRIMIID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@BELDMUDURLUKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELDMUDURLUKID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@GOREVYERI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOREVYERI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@KANGRUPID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KANGRUPID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@YETKILIIMZAID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YETKILIIMZAID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IKMADRES", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IKMADRES", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ARACID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@CEPTELEFON", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CEPTELEFON", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@CEPTELEFON2", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CEPTELEFON2", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@COCUKKIZ", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "COCUKKIZ", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@COCUKERKEK", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "COCUKERKEK", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@COCUKTOPLAM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "COCUKTOPLAM", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SIRANO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SIRANO", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SAVEUSER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEUSER", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SAVEDATE", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEDATE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EDITUSER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITUSER", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EDITDATE", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITDATE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SAVEMAC", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEMAC", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EDITMAC", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITMAC", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SAVEIP", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEIP", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EDITIP", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITIP", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@PERSDURUMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PERSDURUMID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IZINTOPLAMI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINTOPLAMI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@KULLANILANIZIN", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KULLANILANIZIN", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@KALANIZIN", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KALANIZIN", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ISEGIRISTARIHI", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISEGIRISTARIHI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@DOGUMTARIHI", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DOGUMTARIHI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@PARAFTANIM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PARAFTANIM", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@RESIM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RESIM", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@RESIMPER", SqlDbType.Image, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RESIMPER", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_KOD", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_KOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TCKIMLIKNO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TCKIMLIKNO", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TCKIMLIKNO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TCKIMLIKNO", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SICILNO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SICILNO", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SICILNO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SICILNO", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ADI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ADI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ADI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SOYADI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SOYADI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SOYADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SOYADI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ADISOYADI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ADISOYADI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ADISOYADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ADISOYADI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_UNVANID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "UNVANID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_UNVANID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "UNVANID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_GOREVUNVANID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOREVUNVANID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_GOREVUNVANID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOREVUNVANID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_EGITIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EGITIMID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_EGITIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EGITIMID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_PERSISTIHDAMIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PERSISTIHDAMIID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_PERSISTIHDAMIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PERSISTIHDAMIID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_EHLIYETID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EHLIYETID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_EHLIYETID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EHLIYETID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_EHLVERTARIH", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EHLVERTARIH", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_EHLVERTARIH", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EHLVERTARIH", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_BELDBIRIMIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELDBIRIMIID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_BELDBIRIMIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELDBIRIMIID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_BELDMUDURLUKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELDMUDURLUKID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_BELDMUDURLUKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELDMUDURLUKID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_GOREVYERI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOREVYERI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_GOREVYERI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOREVYERI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_KANGRUPID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KANGRUPID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_KANGRUPID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KANGRUPID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_YETKILIIMZAID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YETKILIIMZAID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_YETKILIIMZAID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YETKILIIMZAID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_IKMADRES", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IKMADRES", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_IKMADRES", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IKMADRES", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ARACID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ARACID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_CEPTELEFON", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CEPTELEFON", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_CEPTELEFON", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CEPTELEFON", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_CEPTELEFON2", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CEPTELEFON2", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_CEPTELEFON2", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CEPTELEFON2", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_COCUKKIZ", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "COCUKKIZ", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_COCUKKIZ", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "COCUKKIZ", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_COCUKERKEK", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "COCUKERKEK", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_COCUKERKEK", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "COCUKERKEK", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_COCUKTOPLAM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "COCUKTOPLAM", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_COCUKTOPLAM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "COCUKTOPLAM", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SIRANO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SIRANO", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SIRANO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SIRANO", DataRowVersion.Original, false, (object) null, "", "", ""));
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
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_PERSDURUMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PERSDURUMID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_PERSDURUMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PERSDURUMID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_IZINTOPLAMI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINTOPLAMI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_IZINTOPLAMI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINTOPLAMI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_KULLANILANIZIN", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KULLANILANIZIN", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_KULLANILANIZIN", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KULLANILANIZIN", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_KALANIZIN", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KALANIZIN", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_KALANIZIN", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KALANIZIN", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ISEGIRISTARIHI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISEGIRISTARIHI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ISEGIRISTARIHI", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISEGIRISTARIHI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_DOGUMTARIHI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DOGUMTARIHI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_DOGUMTARIHI", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DOGUMTARIHI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_PARAFTANIM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PARAFTANIM", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_PARAFTANIM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PARAFTANIM", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_RESIM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RESIM", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_RESIM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RESIM", DataRowVersion.Original, false, (object) null, "", "", ""));
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
      this._commandCollection[0].CommandText = "SELECT ID, KOD, TCKIMLIKNO, SICILNO, ADI, SOYADI, ADISOYADI, UNVANID, GOREVUNVANID, EGITIMID, PERSISTIHDAMIID, EHLIYETID, EHLVERTARIH, BELDBIRIMIID, BELDMUDURLUKID, GOREVYERI, KANGRUPID, YETKILIIMZAID, IKMADRES, ARACID, CEPTELEFON, CEPTELEFON2, COCUKKIZ, COCUKERKEK, COCUKTOPLAM, SIRANO, SAVEUSER, SAVEDATE, EDITUSER, EDITDATE, SAVEMAC, EDITMAC, SAVEIP, EDITIP, PERSDURUMID, IZINTOPLAMI, KULLANILANIZIN, KALANIZIN, ISEGIRISTARIHI, DOGUMTARIHI, PARAFTANIM, RESIM, RESIMPER FROM dbo.TBLPERSONEL";
      this._commandCollection[0].CommandType = CommandType.Text;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    public virtual int Fill(bellDataSet8.TBLPERSONELDataTable dataTable)
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
    public virtual bellDataSet8.TBLPERSONELDataTable GetData()
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      bellDataSet8.TBLPERSONELDataTable data = new bellDataSet8.TBLPERSONELDataTable();
      this.Adapter.Fill((DataTable) data);
      return data;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(bellDataSet8.TBLPERSONELDataTable dataTable) => this.Adapter.Update((DataTable) dataTable);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(bellDataSet8 dataSet) => this.Adapter.Update((DataSet) dataSet, "TBLPERSONEL");

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
      string Original_TCKIMLIKNO,
      string Original_SICILNO,
      string Original_ADI,
      string Original_SOYADI,
      string Original_ADISOYADI,
      int? Original_UNVANID,
      int? Original_GOREVUNVANID,
      int? Original_EGITIMID,
      int? Original_PERSISTIHDAMIID,
      int? Original_EHLIYETID,
      string Original_EHLVERTARIH,
      int? Original_BELDBIRIMIID,
      int? Original_BELDMUDURLUKID,
      string Original_GOREVYERI,
      int? Original_KANGRUPID,
      int? Original_YETKILIIMZAID,
      string Original_IKMADRES,
      int? Original_ARACID,
      string Original_CEPTELEFON,
      string Original_CEPTELEFON2,
      int? Original_COCUKKIZ,
      int? Original_COCUKERKEK,
      int? Original_COCUKTOPLAM,
      string Original_SIRANO,
      string Original_SAVEUSER,
      DateTime? Original_SAVEDATE,
      string Original_EDITUSER,
      DateTime? Original_EDITDATE,
      string Original_SAVEMAC,
      string Original_EDITMAC,
      string Original_SAVEIP,
      string Original_EDITIP,
      int? Original_PERSDURUMID,
      int? Original_IZINTOPLAMI,
      int? Original_KULLANILANIZIN,
      int? Original_KALANIZIN,
      DateTime? Original_ISEGIRISTARIHI,
      DateTime? Original_DOGUMTARIHI,
      string Original_PARAFTANIM,
      string Original_RESIM)
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
      if (Original_TCKIMLIKNO == null)
      {
        this.Adapter.DeleteCommand.Parameters[3].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[4].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[3].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[4].Value = (object) Original_TCKIMLIKNO;
      }
      if (Original_SICILNO == null)
      {
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[6].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[6].Value = (object) Original_SICILNO;
      }
      if (Original_ADI == null)
      {
        this.Adapter.DeleteCommand.Parameters[7].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[8].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[7].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[8].Value = (object) Original_ADI;
      }
      if (Original_SOYADI == null)
      {
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) Original_SOYADI;
      }
      if (Original_ADISOYADI == null)
      {
        this.Adapter.DeleteCommand.Parameters[11].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[12].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[11].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[12].Value = (object) Original_ADISOYADI;
      }
      if (Original_UNVANID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[13].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[14].Value = (object) Original_UNVANID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[13].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[14].Value = (object) DBNull.Value;
      }
      if (Original_GOREVUNVANID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[15].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[16].Value = (object) Original_GOREVUNVANID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[15].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[16].Value = (object) DBNull.Value;
      }
      if (Original_EGITIMID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[17].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[18].Value = (object) Original_EGITIMID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[17].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[18].Value = (object) DBNull.Value;
      }
      if (Original_PERSISTIHDAMIID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[19].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[20].Value = (object) Original_PERSISTIHDAMIID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[19].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[20].Value = (object) DBNull.Value;
      }
      if (Original_EHLIYETID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[21].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[22].Value = (object) Original_EHLIYETID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[21].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[22].Value = (object) DBNull.Value;
      }
      if (Original_EHLVERTARIH == null)
      {
        this.Adapter.DeleteCommand.Parameters[23].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[24].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[23].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[24].Value = (object) Original_EHLVERTARIH;
      }
      if (Original_BELDBIRIMIID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[25].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[26].Value = (object) Original_BELDBIRIMIID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[25].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[26].Value = (object) DBNull.Value;
      }
      if (Original_BELDMUDURLUKID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[27].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[28].Value = (object) Original_BELDMUDURLUKID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[27].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[28].Value = (object) DBNull.Value;
      }
      if (Original_GOREVYERI == null)
      {
        this.Adapter.DeleteCommand.Parameters[29].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[30].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[29].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[30].Value = (object) Original_GOREVYERI;
      }
      if (Original_KANGRUPID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[31].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[32].Value = (object) Original_KANGRUPID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[31].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[32].Value = (object) DBNull.Value;
      }
      if (Original_YETKILIIMZAID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[33].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[34].Value = (object) Original_YETKILIIMZAID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[33].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[34].Value = (object) DBNull.Value;
      }
      if (Original_IKMADRES == null)
      {
        this.Adapter.DeleteCommand.Parameters[35].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[36].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[35].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[36].Value = (object) Original_IKMADRES;
      }
      if (Original_ARACID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[37].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[38].Value = (object) Original_ARACID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[37].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[38].Value = (object) DBNull.Value;
      }
      if (Original_CEPTELEFON == null)
      {
        this.Adapter.DeleteCommand.Parameters[39].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[40].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[39].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[40].Value = (object) Original_CEPTELEFON;
      }
      if (Original_CEPTELEFON2 == null)
      {
        this.Adapter.DeleteCommand.Parameters[41].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[42].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[41].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[42].Value = (object) Original_CEPTELEFON2;
      }
      if (Original_COCUKKIZ.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[43].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[44].Value = (object) Original_COCUKKIZ.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[43].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[44].Value = (object) DBNull.Value;
      }
      if (Original_COCUKERKEK.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[45].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[46].Value = (object) Original_COCUKERKEK.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[45].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[46].Value = (object) DBNull.Value;
      }
      if (Original_COCUKTOPLAM.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[47].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[48].Value = (object) Original_COCUKTOPLAM.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[47].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[48].Value = (object) DBNull.Value;
      }
      if (Original_SIRANO == null)
      {
        this.Adapter.DeleteCommand.Parameters[49].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[50].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[49].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[50].Value = (object) Original_SIRANO;
      }
      if (Original_SAVEUSER == null)
      {
        this.Adapter.DeleteCommand.Parameters[51].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[52].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[51].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[52].Value = (object) Original_SAVEUSER;
      }
      if (Original_SAVEDATE.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[53].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[54].Value = (object) Original_SAVEDATE.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[53].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[54].Value = (object) DBNull.Value;
      }
      if (Original_EDITUSER == null)
      {
        this.Adapter.DeleteCommand.Parameters[55].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[56].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[55].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[56].Value = (object) Original_EDITUSER;
      }
      if (Original_EDITDATE.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[57].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[58].Value = (object) Original_EDITDATE.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[57].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[58].Value = (object) DBNull.Value;
      }
      if (Original_SAVEMAC == null)
      {
        this.Adapter.DeleteCommand.Parameters[59].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[60].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[59].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[60].Value = (object) Original_SAVEMAC;
      }
      if (Original_EDITMAC == null)
      {
        this.Adapter.DeleteCommand.Parameters[61].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[62].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[61].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[62].Value = (object) Original_EDITMAC;
      }
      if (Original_SAVEIP == null)
      {
        this.Adapter.DeleteCommand.Parameters[63].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[64].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[63].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[64].Value = (object) Original_SAVEIP;
      }
      if (Original_EDITIP == null)
      {
        this.Adapter.DeleteCommand.Parameters[65].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[66].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[65].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[66].Value = (object) Original_EDITIP;
      }
      if (Original_PERSDURUMID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[67].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[68].Value = (object) Original_PERSDURUMID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[67].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[68].Value = (object) DBNull.Value;
      }
      if (Original_IZINTOPLAMI.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[69].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[70].Value = (object) Original_IZINTOPLAMI.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[69].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[70].Value = (object) DBNull.Value;
      }
      if (Original_KULLANILANIZIN.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[71].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[72].Value = (object) Original_KULLANILANIZIN.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[71].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[72].Value = (object) DBNull.Value;
      }
      if (Original_KALANIZIN.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[73].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[74].Value = (object) Original_KALANIZIN.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[73].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[74].Value = (object) DBNull.Value;
      }
      if (Original_ISEGIRISTARIHI.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[75].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[76].Value = (object) Original_ISEGIRISTARIHI.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[75].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[76].Value = (object) DBNull.Value;
      }
      if (Original_DOGUMTARIHI.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[77].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[78].Value = (object) Original_DOGUMTARIHI.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[77].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[78].Value = (object) DBNull.Value;
      }
      if (Original_PARAFTANIM == null)
      {
        this.Adapter.DeleteCommand.Parameters[79].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[80].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[79].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[80].Value = (object) Original_PARAFTANIM;
      }
      if (Original_RESIM == null)
      {
        this.Adapter.DeleteCommand.Parameters[81].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[82].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[81].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[82].Value = (object) Original_RESIM;
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
      string TCKIMLIKNO,
      string SICILNO,
      string ADI,
      string SOYADI,
      string ADISOYADI,
      int? UNVANID,
      int? GOREVUNVANID,
      int? EGITIMID,
      int? PERSISTIHDAMIID,
      int? EHLIYETID,
      string EHLVERTARIH,
      int? BELDBIRIMIID,
      int? BELDMUDURLUKID,
      string GOREVYERI,
      int? KANGRUPID,
      int? YETKILIIMZAID,
      string IKMADRES,
      int? ARACID,
      string CEPTELEFON,
      string CEPTELEFON2,
      int? COCUKKIZ,
      int? COCUKERKEK,
      int? COCUKTOPLAM,
      string SIRANO,
      string SAVEUSER,
      DateTime? SAVEDATE,
      string EDITUSER,
      DateTime? EDITDATE,
      string SAVEMAC,
      string EDITMAC,
      string SAVEIP,
      string EDITIP,
      int? PERSDURUMID,
      int? IZINTOPLAMI,
      int? KULLANILANIZIN,
      int? KALANIZIN,
      DateTime? ISEGIRISTARIHI,
      DateTime? DOGUMTARIHI,
      string PARAFTANIM,
      string RESIM,
      byte[] RESIMPER)
    {
      if (KOD == null)
        this.Adapter.InsertCommand.Parameters[0].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[0].Value = (object) KOD;
      if (TCKIMLIKNO == null)
        this.Adapter.InsertCommand.Parameters[1].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[1].Value = (object) TCKIMLIKNO;
      if (SICILNO == null)
        this.Adapter.InsertCommand.Parameters[2].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[2].Value = (object) SICILNO;
      if (ADI == null)
        this.Adapter.InsertCommand.Parameters[3].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[3].Value = (object) ADI;
      if (SOYADI == null)
        this.Adapter.InsertCommand.Parameters[4].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[4].Value = (object) SOYADI;
      if (ADISOYADI == null)
        this.Adapter.InsertCommand.Parameters[5].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[5].Value = (object) ADISOYADI;
      if (UNVANID.HasValue)
        this.Adapter.InsertCommand.Parameters[6].Value = (object) UNVANID.Value;
      else
        this.Adapter.InsertCommand.Parameters[6].Value = (object) DBNull.Value;
      if (GOREVUNVANID.HasValue)
        this.Adapter.InsertCommand.Parameters[7].Value = (object) GOREVUNVANID.Value;
      else
        this.Adapter.InsertCommand.Parameters[7].Value = (object) DBNull.Value;
      if (EGITIMID.HasValue)
        this.Adapter.InsertCommand.Parameters[8].Value = (object) EGITIMID.Value;
      else
        this.Adapter.InsertCommand.Parameters[8].Value = (object) DBNull.Value;
      if (PERSISTIHDAMIID.HasValue)
        this.Adapter.InsertCommand.Parameters[9].Value = (object) PERSISTIHDAMIID.Value;
      else
        this.Adapter.InsertCommand.Parameters[9].Value = (object) DBNull.Value;
      if (EHLIYETID.HasValue)
        this.Adapter.InsertCommand.Parameters[10].Value = (object) EHLIYETID.Value;
      else
        this.Adapter.InsertCommand.Parameters[10].Value = (object) DBNull.Value;
      if (EHLVERTARIH == null)
        this.Adapter.InsertCommand.Parameters[11].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[11].Value = (object) EHLVERTARIH;
      if (BELDBIRIMIID.HasValue)
        this.Adapter.InsertCommand.Parameters[12].Value = (object) BELDBIRIMIID.Value;
      else
        this.Adapter.InsertCommand.Parameters[12].Value = (object) DBNull.Value;
      if (BELDMUDURLUKID.HasValue)
        this.Adapter.InsertCommand.Parameters[13].Value = (object) BELDMUDURLUKID.Value;
      else
        this.Adapter.InsertCommand.Parameters[13].Value = (object) DBNull.Value;
      if (GOREVYERI == null)
        this.Adapter.InsertCommand.Parameters[14].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[14].Value = (object) GOREVYERI;
      if (KANGRUPID.HasValue)
        this.Adapter.InsertCommand.Parameters[15].Value = (object) KANGRUPID.Value;
      else
        this.Adapter.InsertCommand.Parameters[15].Value = (object) DBNull.Value;
      if (YETKILIIMZAID.HasValue)
        this.Adapter.InsertCommand.Parameters[16].Value = (object) YETKILIIMZAID.Value;
      else
        this.Adapter.InsertCommand.Parameters[16].Value = (object) DBNull.Value;
      if (IKMADRES == null)
        this.Adapter.InsertCommand.Parameters[17].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[17].Value = (object) IKMADRES;
      if (ARACID.HasValue)
        this.Adapter.InsertCommand.Parameters[18].Value = (object) ARACID.Value;
      else
        this.Adapter.InsertCommand.Parameters[18].Value = (object) DBNull.Value;
      if (CEPTELEFON == null)
        this.Adapter.InsertCommand.Parameters[19].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[19].Value = (object) CEPTELEFON;
      if (CEPTELEFON2 == null)
        this.Adapter.InsertCommand.Parameters[20].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[20].Value = (object) CEPTELEFON2;
      if (COCUKKIZ.HasValue)
        this.Adapter.InsertCommand.Parameters[21].Value = (object) COCUKKIZ.Value;
      else
        this.Adapter.InsertCommand.Parameters[21].Value = (object) DBNull.Value;
      if (COCUKERKEK.HasValue)
        this.Adapter.InsertCommand.Parameters[22].Value = (object) COCUKERKEK.Value;
      else
        this.Adapter.InsertCommand.Parameters[22].Value = (object) DBNull.Value;
      if (COCUKTOPLAM.HasValue)
        this.Adapter.InsertCommand.Parameters[23].Value = (object) COCUKTOPLAM.Value;
      else
        this.Adapter.InsertCommand.Parameters[23].Value = (object) DBNull.Value;
      if (SIRANO == null)
        this.Adapter.InsertCommand.Parameters[24].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[24].Value = (object) SIRANO;
      if (SAVEUSER == null)
        this.Adapter.InsertCommand.Parameters[25].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[25].Value = (object) SAVEUSER;
      if (SAVEDATE.HasValue)
        this.Adapter.InsertCommand.Parameters[26].Value = (object) SAVEDATE.Value;
      else
        this.Adapter.InsertCommand.Parameters[26].Value = (object) DBNull.Value;
      if (EDITUSER == null)
        this.Adapter.InsertCommand.Parameters[27].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[27].Value = (object) EDITUSER;
      if (EDITDATE.HasValue)
        this.Adapter.InsertCommand.Parameters[28].Value = (object) EDITDATE.Value;
      else
        this.Adapter.InsertCommand.Parameters[28].Value = (object) DBNull.Value;
      if (SAVEMAC == null)
        this.Adapter.InsertCommand.Parameters[29].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[29].Value = (object) SAVEMAC;
      if (EDITMAC == null)
        this.Adapter.InsertCommand.Parameters[30].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[30].Value = (object) EDITMAC;
      if (SAVEIP == null)
        this.Adapter.InsertCommand.Parameters[31].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[31].Value = (object) SAVEIP;
      if (EDITIP == null)
        this.Adapter.InsertCommand.Parameters[32].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[32].Value = (object) EDITIP;
      if (PERSDURUMID.HasValue)
        this.Adapter.InsertCommand.Parameters[33].Value = (object) PERSDURUMID.Value;
      else
        this.Adapter.InsertCommand.Parameters[33].Value = (object) DBNull.Value;
      if (IZINTOPLAMI.HasValue)
        this.Adapter.InsertCommand.Parameters[34].Value = (object) IZINTOPLAMI.Value;
      else
        this.Adapter.InsertCommand.Parameters[34].Value = (object) DBNull.Value;
      if (KULLANILANIZIN.HasValue)
        this.Adapter.InsertCommand.Parameters[35].Value = (object) KULLANILANIZIN.Value;
      else
        this.Adapter.InsertCommand.Parameters[35].Value = (object) DBNull.Value;
      if (KALANIZIN.HasValue)
        this.Adapter.InsertCommand.Parameters[36].Value = (object) KALANIZIN.Value;
      else
        this.Adapter.InsertCommand.Parameters[36].Value = (object) DBNull.Value;
      if (ISEGIRISTARIHI.HasValue)
        this.Adapter.InsertCommand.Parameters[37].Value = (object) ISEGIRISTARIHI.Value;
      else
        this.Adapter.InsertCommand.Parameters[37].Value = (object) DBNull.Value;
      if (DOGUMTARIHI.HasValue)
        this.Adapter.InsertCommand.Parameters[38].Value = (object) DOGUMTARIHI.Value;
      else
        this.Adapter.InsertCommand.Parameters[38].Value = (object) DBNull.Value;
      if (PARAFTANIM == null)
        this.Adapter.InsertCommand.Parameters[39].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[39].Value = (object) PARAFTANIM;
      if (RESIM == null)
        this.Adapter.InsertCommand.Parameters[40].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[40].Value = (object) RESIM;
      if (RESIMPER == null)
        this.Adapter.InsertCommand.Parameters[41].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[41].Value = (object) RESIMPER;
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
      string TCKIMLIKNO,
      string SICILNO,
      string ADI,
      string SOYADI,
      string ADISOYADI,
      int? UNVANID,
      int? GOREVUNVANID,
      int? EGITIMID,
      int? PERSISTIHDAMIID,
      int? EHLIYETID,
      string EHLVERTARIH,
      int? BELDBIRIMIID,
      int? BELDMUDURLUKID,
      string GOREVYERI,
      int? KANGRUPID,
      int? YETKILIIMZAID,
      string IKMADRES,
      int? ARACID,
      string CEPTELEFON,
      string CEPTELEFON2,
      int? COCUKKIZ,
      int? COCUKERKEK,
      int? COCUKTOPLAM,
      string SIRANO,
      string SAVEUSER,
      DateTime? SAVEDATE,
      string EDITUSER,
      DateTime? EDITDATE,
      string SAVEMAC,
      string EDITMAC,
      string SAVEIP,
      string EDITIP,
      int? PERSDURUMID,
      int? IZINTOPLAMI,
      int? KULLANILANIZIN,
      int? KALANIZIN,
      DateTime? ISEGIRISTARIHI,
      DateTime? DOGUMTARIHI,
      string PARAFTANIM,
      string RESIM,
      byte[] RESIMPER,
      int Original_ID,
      string Original_KOD,
      string Original_TCKIMLIKNO,
      string Original_SICILNO,
      string Original_ADI,
      string Original_SOYADI,
      string Original_ADISOYADI,
      int? Original_UNVANID,
      int? Original_GOREVUNVANID,
      int? Original_EGITIMID,
      int? Original_PERSISTIHDAMIID,
      int? Original_EHLIYETID,
      string Original_EHLVERTARIH,
      int? Original_BELDBIRIMIID,
      int? Original_BELDMUDURLUKID,
      string Original_GOREVYERI,
      int? Original_KANGRUPID,
      int? Original_YETKILIIMZAID,
      string Original_IKMADRES,
      int? Original_ARACID,
      string Original_CEPTELEFON,
      string Original_CEPTELEFON2,
      int? Original_COCUKKIZ,
      int? Original_COCUKERKEK,
      int? Original_COCUKTOPLAM,
      string Original_SIRANO,
      string Original_SAVEUSER,
      DateTime? Original_SAVEDATE,
      string Original_EDITUSER,
      DateTime? Original_EDITDATE,
      string Original_SAVEMAC,
      string Original_EDITMAC,
      string Original_SAVEIP,
      string Original_EDITIP,
      int? Original_PERSDURUMID,
      int? Original_IZINTOPLAMI,
      int? Original_KULLANILANIZIN,
      int? Original_KALANIZIN,
      DateTime? Original_ISEGIRISTARIHI,
      DateTime? Original_DOGUMTARIHI,
      string Original_PARAFTANIM,
      string Original_RESIM,
      int ID)
    {
      if (KOD == null)
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) KOD;
      if (TCKIMLIKNO == null)
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) TCKIMLIKNO;
      if (SICILNO == null)
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) SICILNO;
      if (ADI == null)
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) ADI;
      if (SOYADI == null)
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) SOYADI;
      if (ADISOYADI == null)
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) ADISOYADI;
      if (UNVANID.HasValue)
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) UNVANID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) DBNull.Value;
      if (GOREVUNVANID.HasValue)
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) GOREVUNVANID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) DBNull.Value;
      if (EGITIMID.HasValue)
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) EGITIMID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) DBNull.Value;
      if (PERSISTIHDAMIID.HasValue)
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) PERSISTIHDAMIID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) DBNull.Value;
      if (EHLIYETID.HasValue)
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) EHLIYETID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) DBNull.Value;
      if (EHLVERTARIH == null)
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) EHLVERTARIH;
      if (BELDBIRIMIID.HasValue)
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) BELDBIRIMIID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) DBNull.Value;
      if (BELDMUDURLUKID.HasValue)
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) BELDMUDURLUKID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) DBNull.Value;
      if (GOREVYERI == null)
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) GOREVYERI;
      if (KANGRUPID.HasValue)
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) KANGRUPID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) DBNull.Value;
      if (YETKILIIMZAID.HasValue)
        this.Adapter.UpdateCommand.Parameters[16].Value = (object) YETKILIIMZAID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[16].Value = (object) DBNull.Value;
      if (IKMADRES == null)
        this.Adapter.UpdateCommand.Parameters[17].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[17].Value = (object) IKMADRES;
      if (ARACID.HasValue)
        this.Adapter.UpdateCommand.Parameters[18].Value = (object) ARACID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[18].Value = (object) DBNull.Value;
      if (CEPTELEFON == null)
        this.Adapter.UpdateCommand.Parameters[19].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[19].Value = (object) CEPTELEFON;
      if (CEPTELEFON2 == null)
        this.Adapter.UpdateCommand.Parameters[20].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[20].Value = (object) CEPTELEFON2;
      if (COCUKKIZ.HasValue)
        this.Adapter.UpdateCommand.Parameters[21].Value = (object) COCUKKIZ.Value;
      else
        this.Adapter.UpdateCommand.Parameters[21].Value = (object) DBNull.Value;
      if (COCUKERKEK.HasValue)
        this.Adapter.UpdateCommand.Parameters[22].Value = (object) COCUKERKEK.Value;
      else
        this.Adapter.UpdateCommand.Parameters[22].Value = (object) DBNull.Value;
      if (COCUKTOPLAM.HasValue)
        this.Adapter.UpdateCommand.Parameters[23].Value = (object) COCUKTOPLAM.Value;
      else
        this.Adapter.UpdateCommand.Parameters[23].Value = (object) DBNull.Value;
      if (SIRANO == null)
        this.Adapter.UpdateCommand.Parameters[24].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[24].Value = (object) SIRANO;
      if (SAVEUSER == null)
        this.Adapter.UpdateCommand.Parameters[25].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[25].Value = (object) SAVEUSER;
      if (SAVEDATE.HasValue)
        this.Adapter.UpdateCommand.Parameters[26].Value = (object) SAVEDATE.Value;
      else
        this.Adapter.UpdateCommand.Parameters[26].Value = (object) DBNull.Value;
      if (EDITUSER == null)
        this.Adapter.UpdateCommand.Parameters[27].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[27].Value = (object) EDITUSER;
      if (EDITDATE.HasValue)
        this.Adapter.UpdateCommand.Parameters[28].Value = (object) EDITDATE.Value;
      else
        this.Adapter.UpdateCommand.Parameters[28].Value = (object) DBNull.Value;
      if (SAVEMAC == null)
        this.Adapter.UpdateCommand.Parameters[29].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[29].Value = (object) SAVEMAC;
      if (EDITMAC == null)
        this.Adapter.UpdateCommand.Parameters[30].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[30].Value = (object) EDITMAC;
      if (SAVEIP == null)
        this.Adapter.UpdateCommand.Parameters[31].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[31].Value = (object) SAVEIP;
      if (EDITIP == null)
        this.Adapter.UpdateCommand.Parameters[32].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[32].Value = (object) EDITIP;
      if (PERSDURUMID.HasValue)
        this.Adapter.UpdateCommand.Parameters[33].Value = (object) PERSDURUMID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[33].Value = (object) DBNull.Value;
      if (IZINTOPLAMI.HasValue)
        this.Adapter.UpdateCommand.Parameters[34].Value = (object) IZINTOPLAMI.Value;
      else
        this.Adapter.UpdateCommand.Parameters[34].Value = (object) DBNull.Value;
      if (KULLANILANIZIN.HasValue)
        this.Adapter.UpdateCommand.Parameters[35].Value = (object) KULLANILANIZIN.Value;
      else
        this.Adapter.UpdateCommand.Parameters[35].Value = (object) DBNull.Value;
      if (KALANIZIN.HasValue)
        this.Adapter.UpdateCommand.Parameters[36].Value = (object) KALANIZIN.Value;
      else
        this.Adapter.UpdateCommand.Parameters[36].Value = (object) DBNull.Value;
      if (ISEGIRISTARIHI.HasValue)
        this.Adapter.UpdateCommand.Parameters[37].Value = (object) ISEGIRISTARIHI.Value;
      else
        this.Adapter.UpdateCommand.Parameters[37].Value = (object) DBNull.Value;
      if (DOGUMTARIHI.HasValue)
        this.Adapter.UpdateCommand.Parameters[38].Value = (object) DOGUMTARIHI.Value;
      else
        this.Adapter.UpdateCommand.Parameters[38].Value = (object) DBNull.Value;
      if (PARAFTANIM == null)
        this.Adapter.UpdateCommand.Parameters[39].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[39].Value = (object) PARAFTANIM;
      if (RESIM == null)
        this.Adapter.UpdateCommand.Parameters[40].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[40].Value = (object) RESIM;
      if (RESIMPER == null)
        this.Adapter.UpdateCommand.Parameters[41].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[41].Value = (object) RESIMPER;
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
      if (Original_TCKIMLIKNO == null)
      {
        this.Adapter.UpdateCommand.Parameters[45].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[46].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[45].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[46].Value = (object) Original_TCKIMLIKNO;
      }
      if (Original_SICILNO == null)
      {
        this.Adapter.UpdateCommand.Parameters[47].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[48].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[47].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[48].Value = (object) Original_SICILNO;
      }
      if (Original_ADI == null)
      {
        this.Adapter.UpdateCommand.Parameters[49].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[50].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[49].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[50].Value = (object) Original_ADI;
      }
      if (Original_SOYADI == null)
      {
        this.Adapter.UpdateCommand.Parameters[51].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[52].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[51].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[52].Value = (object) Original_SOYADI;
      }
      if (Original_ADISOYADI == null)
      {
        this.Adapter.UpdateCommand.Parameters[53].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[54].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[53].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[54].Value = (object) Original_ADISOYADI;
      }
      if (Original_UNVANID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[55].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[56].Value = (object) Original_UNVANID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[55].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[56].Value = (object) DBNull.Value;
      }
      if (Original_GOREVUNVANID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[57].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[58].Value = (object) Original_GOREVUNVANID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[57].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[58].Value = (object) DBNull.Value;
      }
      if (Original_EGITIMID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[59].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[60].Value = (object) Original_EGITIMID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[59].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[60].Value = (object) DBNull.Value;
      }
      if (Original_PERSISTIHDAMIID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[61].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[62].Value = (object) Original_PERSISTIHDAMIID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[61].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[62].Value = (object) DBNull.Value;
      }
      if (Original_EHLIYETID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[63].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[64].Value = (object) Original_EHLIYETID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[63].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[64].Value = (object) DBNull.Value;
      }
      if (Original_EHLVERTARIH == null)
      {
        this.Adapter.UpdateCommand.Parameters[65].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[66].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[65].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[66].Value = (object) Original_EHLVERTARIH;
      }
      if (Original_BELDBIRIMIID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[67].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[68].Value = (object) Original_BELDBIRIMIID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[67].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[68].Value = (object) DBNull.Value;
      }
      if (Original_BELDMUDURLUKID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[69].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[70].Value = (object) Original_BELDMUDURLUKID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[69].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[70].Value = (object) DBNull.Value;
      }
      if (Original_GOREVYERI == null)
      {
        this.Adapter.UpdateCommand.Parameters[71].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[72].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[71].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[72].Value = (object) Original_GOREVYERI;
      }
      if (Original_KANGRUPID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[73].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[74].Value = (object) Original_KANGRUPID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[73].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[74].Value = (object) DBNull.Value;
      }
      if (Original_YETKILIIMZAID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[75].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[76].Value = (object) Original_YETKILIIMZAID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[75].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[76].Value = (object) DBNull.Value;
      }
      if (Original_IKMADRES == null)
      {
        this.Adapter.UpdateCommand.Parameters[77].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[78].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[77].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[78].Value = (object) Original_IKMADRES;
      }
      if (Original_ARACID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[79].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[80].Value = (object) Original_ARACID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[79].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[80].Value = (object) DBNull.Value;
      }
      if (Original_CEPTELEFON == null)
      {
        this.Adapter.UpdateCommand.Parameters[81].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[82].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[81].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[82].Value = (object) Original_CEPTELEFON;
      }
      if (Original_CEPTELEFON2 == null)
      {
        this.Adapter.UpdateCommand.Parameters[83].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[84].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[83].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[84].Value = (object) Original_CEPTELEFON2;
      }
      if (Original_COCUKKIZ.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[85].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[86].Value = (object) Original_COCUKKIZ.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[85].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[86].Value = (object) DBNull.Value;
      }
      if (Original_COCUKERKEK.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[87].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[88].Value = (object) Original_COCUKERKEK.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[87].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[88].Value = (object) DBNull.Value;
      }
      if (Original_COCUKTOPLAM.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[89].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[90].Value = (object) Original_COCUKTOPLAM.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[89].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[90].Value = (object) DBNull.Value;
      }
      if (Original_SIRANO == null)
      {
        this.Adapter.UpdateCommand.Parameters[91].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[92].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[91].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[92].Value = (object) Original_SIRANO;
      }
      if (Original_SAVEUSER == null)
      {
        this.Adapter.UpdateCommand.Parameters[93].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[94].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[93].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[94].Value = (object) Original_SAVEUSER;
      }
      if (Original_SAVEDATE.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[95].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[96].Value = (object) Original_SAVEDATE.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[95].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[96].Value = (object) DBNull.Value;
      }
      if (Original_EDITUSER == null)
      {
        this.Adapter.UpdateCommand.Parameters[97].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[98].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[97].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[98].Value = (object) Original_EDITUSER;
      }
      if (Original_EDITDATE.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[99].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[100].Value = (object) Original_EDITDATE.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[99].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[100].Value = (object) DBNull.Value;
      }
      if (Original_SAVEMAC == null)
      {
        this.Adapter.UpdateCommand.Parameters[101].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[102].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[101].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[102].Value = (object) Original_SAVEMAC;
      }
      if (Original_EDITMAC == null)
      {
        this.Adapter.UpdateCommand.Parameters[103].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[104].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[103].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[104].Value = (object) Original_EDITMAC;
      }
      if (Original_SAVEIP == null)
      {
        this.Adapter.UpdateCommand.Parameters[105].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[106].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[105].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[106].Value = (object) Original_SAVEIP;
      }
      if (Original_EDITIP == null)
      {
        this.Adapter.UpdateCommand.Parameters[107].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[108].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[107].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[108].Value = (object) Original_EDITIP;
      }
      if (Original_PERSDURUMID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[109].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[110].Value = (object) Original_PERSDURUMID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[109].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[110].Value = (object) DBNull.Value;
      }
      if (Original_IZINTOPLAMI.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[111].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[112].Value = (object) Original_IZINTOPLAMI.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[111].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[112].Value = (object) DBNull.Value;
      }
      if (Original_KULLANILANIZIN.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[113].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[114].Value = (object) Original_KULLANILANIZIN.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[113].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[114].Value = (object) DBNull.Value;
      }
      if (Original_KALANIZIN.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[115].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[116].Value = (object) Original_KALANIZIN.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[115].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[116].Value = (object) DBNull.Value;
      }
      if (Original_ISEGIRISTARIHI.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[117].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[118].Value = (object) Original_ISEGIRISTARIHI.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[117].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[118].Value = (object) DBNull.Value;
      }
      if (Original_DOGUMTARIHI.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[119].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[120].Value = (object) Original_DOGUMTARIHI.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[119].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[120].Value = (object) DBNull.Value;
      }
      if (Original_PARAFTANIM == null)
      {
        this.Adapter.UpdateCommand.Parameters[121].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[122].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[121].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[122].Value = (object) Original_PARAFTANIM;
      }
      if (Original_RESIM == null)
      {
        this.Adapter.UpdateCommand.Parameters[123].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[124].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[123].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[124].Value = (object) Original_RESIM;
      }
      this.Adapter.UpdateCommand.Parameters[125].Value = (object) ID;
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
      string TCKIMLIKNO,
      string SICILNO,
      string ADI,
      string SOYADI,
      string ADISOYADI,
      int? UNVANID,
      int? GOREVUNVANID,
      int? EGITIMID,
      int? PERSISTIHDAMIID,
      int? EHLIYETID,
      string EHLVERTARIH,
      int? BELDBIRIMIID,
      int? BELDMUDURLUKID,
      string GOREVYERI,
      int? KANGRUPID,
      int? YETKILIIMZAID,
      string IKMADRES,
      int? ARACID,
      string CEPTELEFON,
      string CEPTELEFON2,
      int? COCUKKIZ,
      int? COCUKERKEK,
      int? COCUKTOPLAM,
      string SIRANO,
      string SAVEUSER,
      DateTime? SAVEDATE,
      string EDITUSER,
      DateTime? EDITDATE,
      string SAVEMAC,
      string EDITMAC,
      string SAVEIP,
      string EDITIP,
      int? PERSDURUMID,
      int? IZINTOPLAMI,
      int? KULLANILANIZIN,
      int? KALANIZIN,
      DateTime? ISEGIRISTARIHI,
      DateTime? DOGUMTARIHI,
      string PARAFTANIM,
      string RESIM,
      byte[] RESIMPER,
      int Original_ID,
      string Original_KOD,
      string Original_TCKIMLIKNO,
      string Original_SICILNO,
      string Original_ADI,
      string Original_SOYADI,
      string Original_ADISOYADI,
      int? Original_UNVANID,
      int? Original_GOREVUNVANID,
      int? Original_EGITIMID,
      int? Original_PERSISTIHDAMIID,
      int? Original_EHLIYETID,
      string Original_EHLVERTARIH,
      int? Original_BELDBIRIMIID,
      int? Original_BELDMUDURLUKID,
      string Original_GOREVYERI,
      int? Original_KANGRUPID,
      int? Original_YETKILIIMZAID,
      string Original_IKMADRES,
      int? Original_ARACID,
      string Original_CEPTELEFON,
      string Original_CEPTELEFON2,
      int? Original_COCUKKIZ,
      int? Original_COCUKERKEK,
      int? Original_COCUKTOPLAM,
      string Original_SIRANO,
      string Original_SAVEUSER,
      DateTime? Original_SAVEDATE,
      string Original_EDITUSER,
      DateTime? Original_EDITDATE,
      string Original_SAVEMAC,
      string Original_EDITMAC,
      string Original_SAVEIP,
      string Original_EDITIP,
      int? Original_PERSDURUMID,
      int? Original_IZINTOPLAMI,
      int? Original_KULLANILANIZIN,
      int? Original_KALANIZIN,
      DateTime? Original_ISEGIRISTARIHI,
      DateTime? Original_DOGUMTARIHI,
      string Original_PARAFTANIM,
      string Original_RESIM)
    {
      return this.Update(KOD, TCKIMLIKNO, SICILNO, ADI, SOYADI, ADISOYADI, UNVANID, GOREVUNVANID, EGITIMID, PERSISTIHDAMIID, EHLIYETID, EHLVERTARIH, BELDBIRIMIID, BELDMUDURLUKID, GOREVYERI, KANGRUPID, YETKILIIMZAID, IKMADRES, ARACID, CEPTELEFON, CEPTELEFON2, COCUKKIZ, COCUKERKEK, COCUKTOPLAM, SIRANO, SAVEUSER, SAVEDATE, EDITUSER, EDITDATE, SAVEMAC, EDITMAC, SAVEIP, EDITIP, PERSDURUMID, IZINTOPLAMI, KULLANILANIZIN, KALANIZIN, ISEGIRISTARIHI, DOGUMTARIHI, PARAFTANIM, RESIM, RESIMPER, Original_ID, Original_KOD, Original_TCKIMLIKNO, Original_SICILNO, Original_ADI, Original_SOYADI, Original_ADISOYADI, Original_UNVANID, Original_GOREVUNVANID, Original_EGITIMID, Original_PERSISTIHDAMIID, Original_EHLIYETID, Original_EHLVERTARIH, Original_BELDBIRIMIID, Original_BELDMUDURLUKID, Original_GOREVYERI, Original_KANGRUPID, Original_YETKILIIMZAID, Original_IKMADRES, Original_ARACID, Original_CEPTELEFON, Original_CEPTELEFON2, Original_COCUKKIZ, Original_COCUKERKEK, Original_COCUKTOPLAM, Original_SIRANO, Original_SAVEUSER, Original_SAVEDATE, Original_EDITUSER, Original_EDITDATE, Original_SAVEMAC, Original_EDITMAC, Original_SAVEIP, Original_EDITIP, Original_PERSDURUMID, Original_IZINTOPLAMI, Original_KULLANILANIZIN, Original_KALANIZIN, Original_ISEGIRISTARIHI, Original_DOGUMTARIHI, Original_PARAFTANIM, Original_RESIM, Original_ID);
    }
  }
}
