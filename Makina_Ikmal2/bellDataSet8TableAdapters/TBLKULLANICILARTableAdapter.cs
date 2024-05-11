// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.bellDataSet8TableAdapters.TBLKULLANICILARTableAdapter
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
  public class TBLKULLANICILARTableAdapter : Component
  {
    private SqlDataAdapter _adapter;
    private SqlConnection _connection;
    private SqlTransaction _transaction;
    private SqlCommand[] _commandCollection;
    private bool _clearBeforeFill;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public TBLKULLANICILARTableAdapter() => this.ClearBeforeFill = true;

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
        DataSetTable = "TBLKULLANICILAR",
        ColumnMappings = {
          {
            "ID",
            "ID"
          },
          {
            "SIRANO",
            "SIRANO"
          },
          {
            "TURU",
            "TURU"
          },
          {
            "KULLANICIADI",
            "KULLANICIADI"
          },
          {
            "UNVANI",
            "UNVANI"
          },
          {
            "GOREVYERI",
            "GOREVYERI"
          },
          {
            "SIFRE",
            "SIFRE"
          },
          {
            "SIFRETEKRAR",
            "SIFRETEKRAR"
          },
          {
            "EKLE",
            "EKLE"
          },
          {
            "DUZENLE",
            "DUZENLE"
          },
          {
            "SIL",
            "SIL"
          },
          {
            "OKUMA",
            "OKUMA"
          },
          {
            "BELDBIRIMID",
            "BELDBIRIMID"
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
            "IDX",
            "IDX"
          },
          {
            "ADISOYADI",
            "ADISOYADI"
          },
          {
            "PERSONELID",
            "PERSONELID"
          }
        }
      });
      this._adapter.DeleteCommand = new SqlCommand();
      this._adapter.DeleteCommand.Connection = this.Connection;
      this._adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[TBLKULLANICILAR] WHERE (((@IsNull_ID = 1 AND [ID] IS NULL) OR ([ID] = @Original_ID)) AND ((@IsNull_SIRANO = 1 AND [SIRANO] IS NULL) OR ([SIRANO] = @Original_SIRANO)) AND ((@IsNull_TURU = 1 AND [TURU] IS NULL) OR ([TURU] = @Original_TURU)) AND ((@IsNull_KULLANICIADI = 1 AND [KULLANICIADI] IS NULL) OR ([KULLANICIADI] = @Original_KULLANICIADI)) AND ((@IsNull_UNVANI = 1 AND [UNVANI] IS NULL) OR ([UNVANI] = @Original_UNVANI)) AND ((@IsNull_GOREVYERI = 1 AND [GOREVYERI] IS NULL) OR ([GOREVYERI] = @Original_GOREVYERI)) AND ((@IsNull_SIFRE = 1 AND [SIFRE] IS NULL) OR ([SIFRE] = @Original_SIFRE)) AND ((@IsNull_SIFRETEKRAR = 1 AND [SIFRETEKRAR] IS NULL) OR ([SIFRETEKRAR] = @Original_SIFRETEKRAR)) AND ((@IsNull_EKLE = 1 AND [EKLE] IS NULL) OR ([EKLE] = @Original_EKLE)) AND ((@IsNull_DUZENLE = 1 AND [DUZENLE] IS NULL) OR ([DUZENLE] = @Original_DUZENLE)) AND ((@IsNull_SIL = 1 AND [SIL] IS NULL) OR ([SIL] = @Original_SIL)) AND ((@IsNull_OKUMA = 1 AND [OKUMA] IS NULL) OR ([OKUMA] = @Original_OKUMA)) AND ((@IsNull_BELDBIRIMID = 1 AND [BELDBIRIMID] IS NULL) OR ([BELDBIRIMID] = @Original_BELDBIRIMID)) AND ((@IsNull_SAVEUSER = 1 AND [SAVEUSER] IS NULL) OR ([SAVEUSER] = @Original_SAVEUSER)) AND ((@IsNull_SAVEDATE = 1 AND [SAVEDATE] IS NULL) OR ([SAVEDATE] = @Original_SAVEDATE)) AND ((@IsNull_EDITUSER = 1 AND [EDITUSER] IS NULL) OR ([EDITUSER] = @Original_EDITUSER)) AND ((@IsNull_EDITDATE = 1 AND [EDITDATE] IS NULL) OR ([EDITDATE] = @Original_EDITDATE)) AND ((@IsNull_SAVEMAC = 1 AND [SAVEMAC] IS NULL) OR ([SAVEMAC] = @Original_SAVEMAC)) AND ((@IsNull_EDITMAC = 1 AND [EDITMAC] IS NULL) OR ([EDITMAC] = @Original_EDITMAC)) AND ((@IsNull_SAVEIP = 1 AND [SAVEIP] IS NULL) OR ([SAVEIP] = @Original_SAVEIP)) AND ((@IsNull_EDITIP = 1 AND [EDITIP] IS NULL) OR ([EDITIP] = @Original_EDITIP)) AND ([IDX] = @Original_IDX) AND ((@IsNull_ADISOYADI = 1 AND [ADISOYADI] IS NULL) OR ([ADISOYADI] = @Original_ADISOYADI)) AND ((@IsNull_PERSONELID = 1 AND [PERSONELID] IS NULL) OR ([PERSONELID] = @Original_PERSONELID)))";
      this._adapter.DeleteCommand.CommandType = CommandType.Text;
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SIRANO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SIRANO", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SIRANO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SIRANO", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TURU", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TURU", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TURU", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TURU", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_KULLANICIADI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KULLANICIADI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_KULLANICIADI", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KULLANICIADI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_UNVANI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "UNVANI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_UNVANI", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "UNVANI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_GOREVYERI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOREVYERI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_GOREVYERI", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOREVYERI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SIFRE", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SIFRE", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SIFRE", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SIFRE", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SIFRETEKRAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SIFRETEKRAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SIFRETEKRAR", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SIFRETEKRAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_EKLE", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EKLE", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_EKLE", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EKLE", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_DUZENLE", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DUZENLE", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_DUZENLE", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DUZENLE", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SIL", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SIL", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SIL", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SIL", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_OKUMA", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "OKUMA", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_OKUMA", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "OKUMA", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_BELDBIRIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELDBIRIMID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_BELDBIRIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELDBIRIMID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SAVEUSER", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEUSER", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SAVEUSER", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEUSER", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SAVEDATE", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEDATE", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SAVEDATE", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEDATE", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_EDITUSER", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITUSER", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_EDITUSER", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITUSER", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_EDITDATE", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITDATE", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_EDITDATE", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITDATE", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SAVEMAC", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEMAC", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SAVEMAC", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEMAC", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_EDITMAC", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITMAC", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_EDITMAC", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITMAC", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SAVEIP", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEIP", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SAVEIP", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEIP", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_EDITIP", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITIP", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_EDITIP", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITIP", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_IDX", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IDX", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ADISOYADI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ADISOYADI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ADISOYADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ADISOYADI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_PERSONELID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PERSONELID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_PERSONELID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PERSONELID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.InsertCommand = new SqlCommand();
      this._adapter.InsertCommand.Connection = this.Connection;
      this._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[TBLKULLANICILAR] ([ID], [SIRANO], [TURU], [KULLANICIADI], [UNVANI], [GOREVYERI], [SIFRE], [SIFRETEKRAR], [EKLE], [DUZENLE], [SIL], [OKUMA], [BELDBIRIMID], [SAVEUSER], [SAVEDATE], [EDITUSER], [EDITDATE], [SAVEMAC], [EDITMAC], [SAVEIP], [EDITIP], [ADISOYADI], [PERSONELID]) VALUES (@ID, @SIRANO, @TURU, @KULLANICIADI, @UNVANI, @GOREVYERI, @SIFRE, @SIFRETEKRAR, @EKLE, @DUZENLE, @SIL, @OKUMA, @BELDBIRIMID, @SAVEUSER, @SAVEDATE, @EDITUSER, @EDITDATE, @SAVEMAC, @EDITMAC, @SAVEIP, @EDITIP, @ADISOYADI, @PERSONELID);\r\nSELECT ID, SIRANO, TURU, KULLANICIADI, UNVANI, GOREVYERI, SIFRE, SIFRETEKRAR, EKLE, DUZENLE, SIL, OKUMA, BELDBIRIMID, SAVEUSER, SAVEDATE, EDITUSER, EDITDATE, SAVEMAC, EDITMAC, SAVEIP, EDITIP, IDX, ADISOYADI, PERSONELID FROM TBLKULLANICILAR WHERE (IDX = SCOPE_IDENTITY())";
      this._adapter.InsertCommand.CommandType = CommandType.Text;
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SIRANO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SIRANO", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@TURU", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TURU", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@KULLANICIADI", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KULLANICIADI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@UNVANI", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "UNVANI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@GOREVYERI", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOREVYERI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SIFRE", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SIFRE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SIFRETEKRAR", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SIFRETEKRAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@EKLE", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EKLE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@DUZENLE", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DUZENLE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SIL", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SIL", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@OKUMA", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "OKUMA", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@BELDBIRIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELDBIRIMID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SAVEUSER", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEUSER", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SAVEDATE", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEDATE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@EDITUSER", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITUSER", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@EDITDATE", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITDATE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SAVEMAC", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEMAC", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@EDITMAC", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITMAC", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SAVEIP", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEIP", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@EDITIP", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITIP", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ADISOYADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ADISOYADI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@PERSONELID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PERSONELID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand = new SqlCommand();
      this._adapter.UpdateCommand.Connection = this.Connection;
      this._adapter.UpdateCommand.CommandText = "UPDATE [dbo].[TBLKULLANICILAR] SET [ID] = @ID, [SIRANO] = @SIRANO, [TURU] = @TURU, [KULLANICIADI] = @KULLANICIADI, [UNVANI] = @UNVANI, [GOREVYERI] = @GOREVYERI, [SIFRE] = @SIFRE, [SIFRETEKRAR] = @SIFRETEKRAR, [EKLE] = @EKLE, [DUZENLE] = @DUZENLE, [SIL] = @SIL, [OKUMA] = @OKUMA, [BELDBIRIMID] = @BELDBIRIMID, [SAVEUSER] = @SAVEUSER, [SAVEDATE] = @SAVEDATE, [EDITUSER] = @EDITUSER, [EDITDATE] = @EDITDATE, [SAVEMAC] = @SAVEMAC, [EDITMAC] = @EDITMAC, [SAVEIP] = @SAVEIP, [EDITIP] = @EDITIP, [ADISOYADI] = @ADISOYADI, [PERSONELID] = @PERSONELID WHERE (((@IsNull_ID = 1 AND [ID] IS NULL) OR ([ID] = @Original_ID)) AND ((@IsNull_SIRANO = 1 AND [SIRANO] IS NULL) OR ([SIRANO] = @Original_SIRANO)) AND ((@IsNull_TURU = 1 AND [TURU] IS NULL) OR ([TURU] = @Original_TURU)) AND ((@IsNull_KULLANICIADI = 1 AND [KULLANICIADI] IS NULL) OR ([KULLANICIADI] = @Original_KULLANICIADI)) AND ((@IsNull_UNVANI = 1 AND [UNVANI] IS NULL) OR ([UNVANI] = @Original_UNVANI)) AND ((@IsNull_GOREVYERI = 1 AND [GOREVYERI] IS NULL) OR ([GOREVYERI] = @Original_GOREVYERI)) AND ((@IsNull_SIFRE = 1 AND [SIFRE] IS NULL) OR ([SIFRE] = @Original_SIFRE)) AND ((@IsNull_SIFRETEKRAR = 1 AND [SIFRETEKRAR] IS NULL) OR ([SIFRETEKRAR] = @Original_SIFRETEKRAR)) AND ((@IsNull_EKLE = 1 AND [EKLE] IS NULL) OR ([EKLE] = @Original_EKLE)) AND ((@IsNull_DUZENLE = 1 AND [DUZENLE] IS NULL) OR ([DUZENLE] = @Original_DUZENLE)) AND ((@IsNull_SIL = 1 AND [SIL] IS NULL) OR ([SIL] = @Original_SIL)) AND ((@IsNull_OKUMA = 1 AND [OKUMA] IS NULL) OR ([OKUMA] = @Original_OKUMA)) AND ((@IsNull_BELDBIRIMID = 1 AND [BELDBIRIMID] IS NULL) OR ([BELDBIRIMID] = @Original_BELDBIRIMID)) AND ((@IsNull_SAVEUSER = 1 AND [SAVEUSER] IS NULL) OR ([SAVEUSER] = @Original_SAVEUSER)) AND ((@IsNull_SAVEDATE = 1 AND [SAVEDATE] IS NULL) OR ([SAVEDATE] = @Original_SAVEDATE)) AND ((@IsNull_EDITUSER = 1 AND [EDITUSER] IS NULL) OR ([EDITUSER] = @Original_EDITUSER)) AND ((@IsNull_EDITDATE = 1 AND [EDITDATE] IS NULL) OR ([EDITDATE] = @Original_EDITDATE)) AND ((@IsNull_SAVEMAC = 1 AND [SAVEMAC] IS NULL) OR ([SAVEMAC] = @Original_SAVEMAC)) AND ((@IsNull_EDITMAC = 1 AND [EDITMAC] IS NULL) OR ([EDITMAC] = @Original_EDITMAC)) AND ((@IsNull_SAVEIP = 1 AND [SAVEIP] IS NULL) OR ([SAVEIP] = @Original_SAVEIP)) AND ((@IsNull_EDITIP = 1 AND [EDITIP] IS NULL) OR ([EDITIP] = @Original_EDITIP)) AND ([IDX] = @Original_IDX) AND ((@IsNull_ADISOYADI = 1 AND [ADISOYADI] IS NULL) OR ([ADISOYADI] = @Original_ADISOYADI)) AND ((@IsNull_PERSONELID = 1 AND [PERSONELID] IS NULL) OR ([PERSONELID] = @Original_PERSONELID)));\r\nSELECT ID, SIRANO, TURU, KULLANICIADI, UNVANI, GOREVYERI, SIFRE, SIFRETEKRAR, EKLE, DUZENLE, SIL, OKUMA, BELDBIRIMID, SAVEUSER, SAVEDATE, EDITUSER, EDITDATE, SAVEMAC, EDITMAC, SAVEIP, EDITIP, IDX, ADISOYADI, PERSONELID FROM TBLKULLANICILAR WHERE (IDX = @IDX)";
      this._adapter.UpdateCommand.CommandType = CommandType.Text;
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SIRANO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SIRANO", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TURU", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TURU", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@KULLANICIADI", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KULLANICIADI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@UNVANI", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "UNVANI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@GOREVYERI", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOREVYERI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SIFRE", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SIFRE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SIFRETEKRAR", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SIFRETEKRAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EKLE", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EKLE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@DUZENLE", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DUZENLE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SIL", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SIL", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@OKUMA", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "OKUMA", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@BELDBIRIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELDBIRIMID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SAVEUSER", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEUSER", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SAVEDATE", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEDATE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EDITUSER", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITUSER", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EDITDATE", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITDATE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SAVEMAC", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEMAC", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EDITMAC", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITMAC", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SAVEIP", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEIP", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EDITIP", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITIP", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ADISOYADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ADISOYADI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@PERSONELID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PERSONELID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SIRANO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SIRANO", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SIRANO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SIRANO", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TURU", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TURU", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TURU", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TURU", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_KULLANICIADI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KULLANICIADI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_KULLANICIADI", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KULLANICIADI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_UNVANI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "UNVANI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_UNVANI", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "UNVANI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_GOREVYERI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOREVYERI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_GOREVYERI", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOREVYERI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SIFRE", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SIFRE", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SIFRE", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SIFRE", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SIFRETEKRAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SIFRETEKRAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SIFRETEKRAR", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SIFRETEKRAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_EKLE", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EKLE", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_EKLE", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EKLE", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_DUZENLE", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DUZENLE", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_DUZENLE", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DUZENLE", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SIL", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SIL", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SIL", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SIL", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_OKUMA", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "OKUMA", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_OKUMA", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "OKUMA", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_BELDBIRIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELDBIRIMID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_BELDBIRIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELDBIRIMID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SAVEUSER", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEUSER", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SAVEUSER", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEUSER", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SAVEDATE", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEDATE", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SAVEDATE", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEDATE", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_EDITUSER", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITUSER", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_EDITUSER", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITUSER", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_EDITDATE", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITDATE", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_EDITDATE", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITDATE", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SAVEMAC", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEMAC", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SAVEMAC", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEMAC", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_EDITMAC", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITMAC", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_EDITMAC", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITMAC", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SAVEIP", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEIP", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SAVEIP", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEIP", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_EDITIP", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITIP", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_EDITIP", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITIP", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_IDX", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IDX", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ADISOYADI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ADISOYADI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ADISOYADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ADISOYADI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_PERSONELID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PERSONELID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_PERSONELID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PERSONELID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IDX", SqlDbType.Int, 4, ParameterDirection.Input, (byte) 0, (byte) 0, "IDX", DataRowVersion.Current, false, (object) null, "", "", ""));
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
      this._commandCollection[0].CommandText = "SELECT ID, SIRANO, TURU, KULLANICIADI, UNVANI, GOREVYERI, SIFRE, SIFRETEKRAR, EKLE, DUZENLE, SIL, OKUMA, BELDBIRIMID, SAVEUSER, SAVEDATE, EDITUSER, EDITDATE, SAVEMAC, EDITMAC, SAVEIP, EDITIP, IDX, ADISOYADI, PERSONELID FROM dbo.TBLKULLANICILAR";
      this._commandCollection[0].CommandType = CommandType.Text;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    public virtual int Fill(bellDataSet8.TBLKULLANICILARDataTable dataTable)
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
    public virtual bellDataSet8.TBLKULLANICILARDataTable GetData()
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      bellDataSet8.TBLKULLANICILARDataTable data = new bellDataSet8.TBLKULLANICILARDataTable();
      this.Adapter.Fill((DataTable) data);
      return data;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(bellDataSet8.TBLKULLANICILARDataTable dataTable) => this.Adapter.Update((DataTable) dataTable);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(bellDataSet8 dataSet) => this.Adapter.Update((DataSet) dataSet, "TBLKULLANICILAR");

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
      int? Original_ID,
      int? Original_SIRANO,
      string Original_TURU,
      string Original_KULLANICIADI,
      string Original_UNVANI,
      string Original_GOREVYERI,
      string Original_SIFRE,
      string Original_SIFRETEKRAR,
      int? Original_EKLE,
      int? Original_DUZENLE,
      int? Original_SIL,
      int? Original_OKUMA,
      int? Original_BELDBIRIMID,
      string Original_SAVEUSER,
      string Original_SAVEDATE,
      string Original_EDITUSER,
      string Original_EDITDATE,
      string Original_SAVEMAC,
      string Original_EDITMAC,
      string Original_SAVEIP,
      string Original_EDITIP,
      int Original_IDX,
      string Original_ADISOYADI,
      int? Original_PERSONELID)
    {
      if (Original_ID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[0].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[1].Value = (object) Original_ID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[0].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[1].Value = (object) DBNull.Value;
      }
      if (Original_SIRANO.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[2].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[3].Value = (object) Original_SIRANO.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[2].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[3].Value = (object) DBNull.Value;
      }
      if (Original_TURU == null)
      {
        this.Adapter.DeleteCommand.Parameters[4].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[4].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) Original_TURU;
      }
      if (Original_KULLANICIADI == null)
      {
        this.Adapter.DeleteCommand.Parameters[6].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[7].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[6].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[7].Value = (object) Original_KULLANICIADI;
      }
      if (Original_UNVANI == null)
      {
        this.Adapter.DeleteCommand.Parameters[8].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[8].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) Original_UNVANI;
      }
      if (Original_GOREVYERI == null)
      {
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[11].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[11].Value = (object) Original_GOREVYERI;
      }
      if (Original_SIFRE == null)
      {
        this.Adapter.DeleteCommand.Parameters[12].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[13].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[12].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[13].Value = (object) Original_SIFRE;
      }
      if (Original_SIFRETEKRAR == null)
      {
        this.Adapter.DeleteCommand.Parameters[14].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[15].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[14].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[15].Value = (object) Original_SIFRETEKRAR;
      }
      if (Original_EKLE.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[16].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[17].Value = (object) Original_EKLE.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[16].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[17].Value = (object) DBNull.Value;
      }
      if (Original_DUZENLE.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[18].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[19].Value = (object) Original_DUZENLE.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[18].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[19].Value = (object) DBNull.Value;
      }
      if (Original_SIL.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[20].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[21].Value = (object) Original_SIL.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[20].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[21].Value = (object) DBNull.Value;
      }
      if (Original_OKUMA.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[22].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[23].Value = (object) Original_OKUMA.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[22].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[23].Value = (object) DBNull.Value;
      }
      if (Original_BELDBIRIMID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[24].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[25].Value = (object) Original_BELDBIRIMID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[24].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[25].Value = (object) DBNull.Value;
      }
      if (Original_SAVEUSER == null)
      {
        this.Adapter.DeleteCommand.Parameters[26].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[27].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[26].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[27].Value = (object) Original_SAVEUSER;
      }
      if (Original_SAVEDATE == null)
      {
        this.Adapter.DeleteCommand.Parameters[28].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[29].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[28].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[29].Value = (object) Original_SAVEDATE;
      }
      if (Original_EDITUSER == null)
      {
        this.Adapter.DeleteCommand.Parameters[30].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[31].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[30].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[31].Value = (object) Original_EDITUSER;
      }
      if (Original_EDITDATE == null)
      {
        this.Adapter.DeleteCommand.Parameters[32].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[33].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[32].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[33].Value = (object) Original_EDITDATE;
      }
      if (Original_SAVEMAC == null)
      {
        this.Adapter.DeleteCommand.Parameters[34].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[35].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[34].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[35].Value = (object) Original_SAVEMAC;
      }
      if (Original_EDITMAC == null)
      {
        this.Adapter.DeleteCommand.Parameters[36].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[37].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[36].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[37].Value = (object) Original_EDITMAC;
      }
      if (Original_SAVEIP == null)
      {
        this.Adapter.DeleteCommand.Parameters[38].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[39].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[38].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[39].Value = (object) Original_SAVEIP;
      }
      if (Original_EDITIP == null)
      {
        this.Adapter.DeleteCommand.Parameters[40].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[41].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[40].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[41].Value = (object) Original_EDITIP;
      }
      this.Adapter.DeleteCommand.Parameters[42].Value = (object) Original_IDX;
      if (Original_ADISOYADI == null)
      {
        this.Adapter.DeleteCommand.Parameters[43].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[44].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[43].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[44].Value = (object) Original_ADISOYADI;
      }
      if (Original_PERSONELID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[45].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[46].Value = (object) Original_PERSONELID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[45].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[46].Value = (object) DBNull.Value;
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
      int? ID,
      int? SIRANO,
      string TURU,
      string KULLANICIADI,
      string UNVANI,
      string GOREVYERI,
      string SIFRE,
      string SIFRETEKRAR,
      int? EKLE,
      int? DUZENLE,
      int? SIL,
      int? OKUMA,
      int? BELDBIRIMID,
      string SAVEUSER,
      string SAVEDATE,
      string EDITUSER,
      string EDITDATE,
      string SAVEMAC,
      string EDITMAC,
      string SAVEIP,
      string EDITIP,
      string ADISOYADI,
      int? PERSONELID)
    {
      if (ID.HasValue)
        this.Adapter.InsertCommand.Parameters[0].Value = (object) ID.Value;
      else
        this.Adapter.InsertCommand.Parameters[0].Value = (object) DBNull.Value;
      if (SIRANO.HasValue)
        this.Adapter.InsertCommand.Parameters[1].Value = (object) SIRANO.Value;
      else
        this.Adapter.InsertCommand.Parameters[1].Value = (object) DBNull.Value;
      if (TURU == null)
        this.Adapter.InsertCommand.Parameters[2].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[2].Value = (object) TURU;
      if (KULLANICIADI == null)
        this.Adapter.InsertCommand.Parameters[3].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[3].Value = (object) KULLANICIADI;
      if (UNVANI == null)
        this.Adapter.InsertCommand.Parameters[4].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[4].Value = (object) UNVANI;
      if (GOREVYERI == null)
        this.Adapter.InsertCommand.Parameters[5].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[5].Value = (object) GOREVYERI;
      if (SIFRE == null)
        this.Adapter.InsertCommand.Parameters[6].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[6].Value = (object) SIFRE;
      if (SIFRETEKRAR == null)
        this.Adapter.InsertCommand.Parameters[7].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[7].Value = (object) SIFRETEKRAR;
      if (EKLE.HasValue)
        this.Adapter.InsertCommand.Parameters[8].Value = (object) EKLE.Value;
      else
        this.Adapter.InsertCommand.Parameters[8].Value = (object) DBNull.Value;
      if (DUZENLE.HasValue)
        this.Adapter.InsertCommand.Parameters[9].Value = (object) DUZENLE.Value;
      else
        this.Adapter.InsertCommand.Parameters[9].Value = (object) DBNull.Value;
      if (SIL.HasValue)
        this.Adapter.InsertCommand.Parameters[10].Value = (object) SIL.Value;
      else
        this.Adapter.InsertCommand.Parameters[10].Value = (object) DBNull.Value;
      if (OKUMA.HasValue)
        this.Adapter.InsertCommand.Parameters[11].Value = (object) OKUMA.Value;
      else
        this.Adapter.InsertCommand.Parameters[11].Value = (object) DBNull.Value;
      if (BELDBIRIMID.HasValue)
        this.Adapter.InsertCommand.Parameters[12].Value = (object) BELDBIRIMID.Value;
      else
        this.Adapter.InsertCommand.Parameters[12].Value = (object) DBNull.Value;
      if (SAVEUSER == null)
        this.Adapter.InsertCommand.Parameters[13].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[13].Value = (object) SAVEUSER;
      if (SAVEDATE == null)
        this.Adapter.InsertCommand.Parameters[14].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[14].Value = (object) SAVEDATE;
      if (EDITUSER == null)
        this.Adapter.InsertCommand.Parameters[15].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[15].Value = (object) EDITUSER;
      if (EDITDATE == null)
        this.Adapter.InsertCommand.Parameters[16].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[16].Value = (object) EDITDATE;
      if (SAVEMAC == null)
        this.Adapter.InsertCommand.Parameters[17].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[17].Value = (object) SAVEMAC;
      if (EDITMAC == null)
        this.Adapter.InsertCommand.Parameters[18].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[18].Value = (object) EDITMAC;
      if (SAVEIP == null)
        this.Adapter.InsertCommand.Parameters[19].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[19].Value = (object) SAVEIP;
      if (EDITIP == null)
        this.Adapter.InsertCommand.Parameters[20].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[20].Value = (object) EDITIP;
      if (ADISOYADI == null)
        this.Adapter.InsertCommand.Parameters[21].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[21].Value = (object) ADISOYADI;
      if (PERSONELID.HasValue)
        this.Adapter.InsertCommand.Parameters[22].Value = (object) PERSONELID.Value;
      else
        this.Adapter.InsertCommand.Parameters[22].Value = (object) DBNull.Value;
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
      int? ID,
      int? SIRANO,
      string TURU,
      string KULLANICIADI,
      string UNVANI,
      string GOREVYERI,
      string SIFRE,
      string SIFRETEKRAR,
      int? EKLE,
      int? DUZENLE,
      int? SIL,
      int? OKUMA,
      int? BELDBIRIMID,
      string SAVEUSER,
      string SAVEDATE,
      string EDITUSER,
      string EDITDATE,
      string SAVEMAC,
      string EDITMAC,
      string SAVEIP,
      string EDITIP,
      string ADISOYADI,
      int? PERSONELID,
      int? Original_ID,
      int? Original_SIRANO,
      string Original_TURU,
      string Original_KULLANICIADI,
      string Original_UNVANI,
      string Original_GOREVYERI,
      string Original_SIFRE,
      string Original_SIFRETEKRAR,
      int? Original_EKLE,
      int? Original_DUZENLE,
      int? Original_SIL,
      int? Original_OKUMA,
      int? Original_BELDBIRIMID,
      string Original_SAVEUSER,
      string Original_SAVEDATE,
      string Original_EDITUSER,
      string Original_EDITDATE,
      string Original_SAVEMAC,
      string Original_EDITMAC,
      string Original_SAVEIP,
      string Original_EDITIP,
      int Original_IDX,
      string Original_ADISOYADI,
      int? Original_PERSONELID,
      int IDX)
    {
      if (ID.HasValue)
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) ID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) DBNull.Value;
      if (SIRANO.HasValue)
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) SIRANO.Value;
      else
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) DBNull.Value;
      if (TURU == null)
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) TURU;
      if (KULLANICIADI == null)
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) KULLANICIADI;
      if (UNVANI == null)
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) UNVANI;
      if (GOREVYERI == null)
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) GOREVYERI;
      if (SIFRE == null)
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) SIFRE;
      if (SIFRETEKRAR == null)
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) SIFRETEKRAR;
      if (EKLE.HasValue)
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) EKLE.Value;
      else
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) DBNull.Value;
      if (DUZENLE.HasValue)
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) DUZENLE.Value;
      else
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) DBNull.Value;
      if (SIL.HasValue)
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) SIL.Value;
      else
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) DBNull.Value;
      if (OKUMA.HasValue)
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) OKUMA.Value;
      else
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) DBNull.Value;
      if (BELDBIRIMID.HasValue)
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) BELDBIRIMID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) DBNull.Value;
      if (SAVEUSER == null)
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) SAVEUSER;
      if (SAVEDATE == null)
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) SAVEDATE;
      if (EDITUSER == null)
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) EDITUSER;
      if (EDITDATE == null)
        this.Adapter.UpdateCommand.Parameters[16].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[16].Value = (object) EDITDATE;
      if (SAVEMAC == null)
        this.Adapter.UpdateCommand.Parameters[17].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[17].Value = (object) SAVEMAC;
      if (EDITMAC == null)
        this.Adapter.UpdateCommand.Parameters[18].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[18].Value = (object) EDITMAC;
      if (SAVEIP == null)
        this.Adapter.UpdateCommand.Parameters[19].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[19].Value = (object) SAVEIP;
      if (EDITIP == null)
        this.Adapter.UpdateCommand.Parameters[20].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[20].Value = (object) EDITIP;
      if (ADISOYADI == null)
        this.Adapter.UpdateCommand.Parameters[21].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[21].Value = (object) ADISOYADI;
      if (PERSONELID.HasValue)
        this.Adapter.UpdateCommand.Parameters[22].Value = (object) PERSONELID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[22].Value = (object) DBNull.Value;
      if (Original_ID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[23].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[24].Value = (object) Original_ID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[23].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[24].Value = (object) DBNull.Value;
      }
      if (Original_SIRANO.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[25].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[26].Value = (object) Original_SIRANO.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[25].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[26].Value = (object) DBNull.Value;
      }
      if (Original_TURU == null)
      {
        this.Adapter.UpdateCommand.Parameters[27].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[28].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[27].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[28].Value = (object) Original_TURU;
      }
      if (Original_KULLANICIADI == null)
      {
        this.Adapter.UpdateCommand.Parameters[29].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[30].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[29].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[30].Value = (object) Original_KULLANICIADI;
      }
      if (Original_UNVANI == null)
      {
        this.Adapter.UpdateCommand.Parameters[31].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[32].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[31].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[32].Value = (object) Original_UNVANI;
      }
      if (Original_GOREVYERI == null)
      {
        this.Adapter.UpdateCommand.Parameters[33].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[34].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[33].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[34].Value = (object) Original_GOREVYERI;
      }
      if (Original_SIFRE == null)
      {
        this.Adapter.UpdateCommand.Parameters[35].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[36].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[35].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[36].Value = (object) Original_SIFRE;
      }
      if (Original_SIFRETEKRAR == null)
      {
        this.Adapter.UpdateCommand.Parameters[37].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[38].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[37].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[38].Value = (object) Original_SIFRETEKRAR;
      }
      if (Original_EKLE.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[39].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[40].Value = (object) Original_EKLE.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[39].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[40].Value = (object) DBNull.Value;
      }
      if (Original_DUZENLE.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[41].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[42].Value = (object) Original_DUZENLE.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[41].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[42].Value = (object) DBNull.Value;
      }
      if (Original_SIL.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[43].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[44].Value = (object) Original_SIL.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[43].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[44].Value = (object) DBNull.Value;
      }
      if (Original_OKUMA.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[45].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[46].Value = (object) Original_OKUMA.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[45].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[46].Value = (object) DBNull.Value;
      }
      if (Original_BELDBIRIMID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[47].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[48].Value = (object) Original_BELDBIRIMID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[47].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[48].Value = (object) DBNull.Value;
      }
      if (Original_SAVEUSER == null)
      {
        this.Adapter.UpdateCommand.Parameters[49].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[50].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[49].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[50].Value = (object) Original_SAVEUSER;
      }
      if (Original_SAVEDATE == null)
      {
        this.Adapter.UpdateCommand.Parameters[51].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[52].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[51].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[52].Value = (object) Original_SAVEDATE;
      }
      if (Original_EDITUSER == null)
      {
        this.Adapter.UpdateCommand.Parameters[53].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[54].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[53].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[54].Value = (object) Original_EDITUSER;
      }
      if (Original_EDITDATE == null)
      {
        this.Adapter.UpdateCommand.Parameters[55].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[56].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[55].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[56].Value = (object) Original_EDITDATE;
      }
      if (Original_SAVEMAC == null)
      {
        this.Adapter.UpdateCommand.Parameters[57].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[58].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[57].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[58].Value = (object) Original_SAVEMAC;
      }
      if (Original_EDITMAC == null)
      {
        this.Adapter.UpdateCommand.Parameters[59].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[60].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[59].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[60].Value = (object) Original_EDITMAC;
      }
      if (Original_SAVEIP == null)
      {
        this.Adapter.UpdateCommand.Parameters[61].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[62].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[61].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[62].Value = (object) Original_SAVEIP;
      }
      if (Original_EDITIP == null)
      {
        this.Adapter.UpdateCommand.Parameters[63].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[64].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[63].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[64].Value = (object) Original_EDITIP;
      }
      this.Adapter.UpdateCommand.Parameters[65].Value = (object) Original_IDX;
      if (Original_ADISOYADI == null)
      {
        this.Adapter.UpdateCommand.Parameters[66].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[67].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[66].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[67].Value = (object) Original_ADISOYADI;
      }
      if (Original_PERSONELID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[68].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[69].Value = (object) Original_PERSONELID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[68].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[69].Value = (object) DBNull.Value;
      }
      this.Adapter.UpdateCommand.Parameters[70].Value = (object) IDX;
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
      int? ID,
      int? SIRANO,
      string TURU,
      string KULLANICIADI,
      string UNVANI,
      string GOREVYERI,
      string SIFRE,
      string SIFRETEKRAR,
      int? EKLE,
      int? DUZENLE,
      int? SIL,
      int? OKUMA,
      int? BELDBIRIMID,
      string SAVEUSER,
      string SAVEDATE,
      string EDITUSER,
      string EDITDATE,
      string SAVEMAC,
      string EDITMAC,
      string SAVEIP,
      string EDITIP,
      string ADISOYADI,
      int? PERSONELID,
      int? Original_ID,
      int? Original_SIRANO,
      string Original_TURU,
      string Original_KULLANICIADI,
      string Original_UNVANI,
      string Original_GOREVYERI,
      string Original_SIFRE,
      string Original_SIFRETEKRAR,
      int? Original_EKLE,
      int? Original_DUZENLE,
      int? Original_SIL,
      int? Original_OKUMA,
      int? Original_BELDBIRIMID,
      string Original_SAVEUSER,
      string Original_SAVEDATE,
      string Original_EDITUSER,
      string Original_EDITDATE,
      string Original_SAVEMAC,
      string Original_EDITMAC,
      string Original_SAVEIP,
      string Original_EDITIP,
      int Original_IDX,
      string Original_ADISOYADI,
      int? Original_PERSONELID)
    {
      return this.Update(ID, SIRANO, TURU, KULLANICIADI, UNVANI, GOREVYERI, SIFRE, SIFRETEKRAR, EKLE, DUZENLE, SIL, OKUMA, BELDBIRIMID, SAVEUSER, SAVEDATE, EDITUSER, EDITDATE, SAVEMAC, EDITMAC, SAVEIP, EDITIP, ADISOYADI, PERSONELID, Original_ID, Original_SIRANO, Original_TURU, Original_KULLANICIADI, Original_UNVANI, Original_GOREVYERI, Original_SIFRE, Original_SIFRETEKRAR, Original_EKLE, Original_DUZENLE, Original_SIL, Original_OKUMA, Original_BELDBIRIMID, Original_SAVEUSER, Original_SAVEDATE, Original_EDITUSER, Original_EDITDATE, Original_SAVEMAC, Original_EDITMAC, Original_SAVEIP, Original_EDITIP, Original_IDX, Original_ADISOYADI, Original_PERSONELID, Original_IDX);
    }
  }
}
