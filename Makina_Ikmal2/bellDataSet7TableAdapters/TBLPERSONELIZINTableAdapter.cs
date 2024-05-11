// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.bellDataSet7TableAdapters.TBLPERSONELIZINTableAdapter
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
  public class TBLPERSONELIZINTableAdapter : Component
  {
    private SqlDataAdapter _adapter;
    private SqlConnection _connection;
    private SqlTransaction _transaction;
    private SqlCommand[] _commandCollection;
    private bool _clearBeforeFill;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public TBLPERSONELIZINTableAdapter() => this.ClearBeforeFill = true;

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
        DataSetTable = "TBLPERSONELIZIN",
        ColumnMappings = {
          {
            "ID",
            "ID"
          },
          {
            "PERSID",
            "PERSID"
          },
          {
            "IZINTURU",
            "IZINTURU"
          },
          {
            "IZINYILLARI",
            "IZINYILLARI"
          },
          {
            "IZINSURESI",
            "IZINSURESI"
          },
          {
            "BASLANGICTARIHI",
            "BASLANGICTARIHI"
          },
          {
            "BASLANGICSAATI",
            "BASLANGICSAATI"
          },
          {
            "BITISTARIHI",
            "BITISTARIHI"
          },
          {
            "BITISSAATI",
            "BITISSAATI"
          },
          {
            "IZINGUNSAY",
            "IZINGUNSAY"
          },
          {
            "GOREVEBASTARIH",
            "GOREVEBASTARIH"
          },
          {
            "IZINDEBULADRES",
            "IZINDEBULADRES"
          },
          {
            "ONAYTARIH",
            "ONAYTARIH"
          },
          {
            "IZINDURUM",
            "IZINDURUM"
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
            "SBMUDURID",
            "SBMUDURID"
          },
          {
            "DAIREBSKID",
            "DAIREBSKID"
          },
          {
            "INSANDAIREBSKID",
            "INSANDAIREBSKID"
          },
          {
            "GENELSEKYRDID",
            "GENELSEKYRDID"
          },
          {
            "MUDURYERINE",
            "MUDURYERINE"
          }
        }
      });
      this._adapter.DeleteCommand = new SqlCommand();
      this._adapter.DeleteCommand.Connection = this.Connection;
      this._adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[TBLPERSONELIZIN] WHERE (([ID] = @Original_ID) AND ((@IsNull_PERSID = 1 AND [PERSID] IS NULL) OR ([PERSID] = @Original_PERSID)) AND ((@IsNull_IZINTURU = 1 AND [IZINTURU] IS NULL) OR ([IZINTURU] = @Original_IZINTURU)) AND ((@IsNull_IZINYILLARI = 1 AND [IZINYILLARI] IS NULL) OR ([IZINYILLARI] = @Original_IZINYILLARI)) AND ((@IsNull_IZINSURESI = 1 AND [IZINSURESI] IS NULL) OR ([IZINSURESI] = @Original_IZINSURESI)) AND ((@IsNull_BASLANGICTARIHI = 1 AND [BASLANGICTARIHI] IS NULL) OR ([BASLANGICTARIHI] = @Original_BASLANGICTARIHI)) AND ((@IsNull_BASLANGICSAATI = 1 AND [BASLANGICSAATI] IS NULL) OR ([BASLANGICSAATI] = @Original_BASLANGICSAATI)) AND ((@IsNull_BITISTARIHI = 1 AND [BITISTARIHI] IS NULL) OR ([BITISTARIHI] = @Original_BITISTARIHI)) AND ((@IsNull_BITISSAATI = 1 AND [BITISSAATI] IS NULL) OR ([BITISSAATI] = @Original_BITISSAATI)) AND ((@IsNull_IZINGUNSAY = 1 AND [IZINGUNSAY] IS NULL) OR ([IZINGUNSAY] = @Original_IZINGUNSAY)) AND ((@IsNull_GOREVEBASTARIH = 1 AND [GOREVEBASTARIH] IS NULL) OR ([GOREVEBASTARIH] = @Original_GOREVEBASTARIH)) AND ((@IsNull_IZINDEBULADRES = 1 AND [IZINDEBULADRES] IS NULL) OR ([IZINDEBULADRES] = @Original_IZINDEBULADRES)) AND ((@IsNull_ONAYTARIH = 1 AND [ONAYTARIH] IS NULL) OR ([ONAYTARIH] = @Original_ONAYTARIH)) AND ((@IsNull_IZINDURUM = 1 AND [IZINDURUM] IS NULL) OR ([IZINDURUM] = @Original_IZINDURUM)) AND ((@IsNull_SAVEUSER = 1 AND [SAVEUSER] IS NULL) OR ([SAVEUSER] = @Original_SAVEUSER)) AND ((@IsNull_SAVEDATE = 1 AND [SAVEDATE] IS NULL) OR ([SAVEDATE] = @Original_SAVEDATE)) AND ((@IsNull_EDITUSER = 1 AND [EDITUSER] IS NULL) OR ([EDITUSER] = @Original_EDITUSER)) AND ((@IsNull_EDITDATE = 1 AND [EDITDATE] IS NULL) OR ([EDITDATE] = @Original_EDITDATE)) AND ((@IsNull_SAVEMAC = 1 AND [SAVEMAC] IS NULL) OR ([SAVEMAC] = @Original_SAVEMAC)) AND ((@IsNull_EDITMAC = 1 AND [EDITMAC] IS NULL) OR ([EDITMAC] = @Original_EDITMAC)) AND ((@IsNull_SAVEIP = 1 AND [SAVEIP] IS NULL) OR ([SAVEIP] = @Original_SAVEIP)) AND ((@IsNull_EDITIP = 1 AND [EDITIP] IS NULL) OR ([EDITIP] = @Original_EDITIP)) AND ((@IsNull_SBMUDURID = 1 AND [SBMUDURID] IS NULL) OR ([SBMUDURID] = @Original_SBMUDURID)) AND ((@IsNull_DAIREBSKID = 1 AND [DAIREBSKID] IS NULL) OR ([DAIREBSKID] = @Original_DAIREBSKID)) AND ((@IsNull_INSANDAIREBSKID = 1 AND [INSANDAIREBSKID] IS NULL) OR ([INSANDAIREBSKID] = @Original_INSANDAIREBSKID)) AND ((@IsNull_GENELSEKYRDID = 1 AND [GENELSEKYRDID] IS NULL) OR ([GENELSEKYRDID] = @Original_GENELSEKYRDID)) AND ((@IsNull_MUDURYERINE = 1 AND [MUDURYERINE] IS NULL) OR ([MUDURYERINE] = @Original_MUDURYERINE)))";
      this._adapter.DeleteCommand.CommandType = CommandType.Text;
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_PERSID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PERSID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_PERSID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PERSID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_IZINTURU", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINTURU", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_IZINTURU", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINTURU", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_IZINYILLARI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINYILLARI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_IZINYILLARI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINYILLARI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_IZINSURESI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINSURESI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_IZINSURESI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINSURESI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_BASLANGICTARIHI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BASLANGICTARIHI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_BASLANGICTARIHI", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BASLANGICTARIHI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_BASLANGICSAATI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BASLANGICSAATI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_BASLANGICSAATI", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BASLANGICSAATI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_BITISTARIHI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BITISTARIHI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_BITISTARIHI", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BITISTARIHI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_BITISSAATI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BITISSAATI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_BITISSAATI", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BITISSAATI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_IZINGUNSAY", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINGUNSAY", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_IZINGUNSAY", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINGUNSAY", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_GOREVEBASTARIH", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOREVEBASTARIH", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_GOREVEBASTARIH", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOREVEBASTARIH", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_IZINDEBULADRES", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINDEBULADRES", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_IZINDEBULADRES", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINDEBULADRES", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ONAYTARIH", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ONAYTARIH", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ONAYTARIH", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ONAYTARIH", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_IZINDURUM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINDURUM", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_IZINDURUM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINDURUM", DataRowVersion.Original, false, (object) null, "", "", ""));
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
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SBMUDURID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SBMUDURID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SBMUDURID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SBMUDURID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_DAIREBSKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DAIREBSKID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_DAIREBSKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DAIREBSKID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_INSANDAIREBSKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "INSANDAIREBSKID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_INSANDAIREBSKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "INSANDAIREBSKID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_GENELSEKYRDID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GENELSEKYRDID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_GENELSEKYRDID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GENELSEKYRDID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_MUDURYERINE", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MUDURYERINE", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_MUDURYERINE", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MUDURYERINE", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.InsertCommand = new SqlCommand();
      this._adapter.InsertCommand.Connection = this.Connection;
      this._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[TBLPERSONELIZIN] ([PERSID], [IZINTURU], [IZINYILLARI], [IZINSURESI], [BASLANGICTARIHI], [BASLANGICSAATI], [BITISTARIHI], [BITISSAATI], [IZINGUNSAY], [GOREVEBASTARIH], [IZINDEBULADRES], [ONAYTARIH], [IZINDURUM], [SAVEUSER], [SAVEDATE], [EDITUSER], [EDITDATE], [SAVEMAC], [EDITMAC], [SAVEIP], [EDITIP], [SBMUDURID], [DAIREBSKID], [INSANDAIREBSKID], [GENELSEKYRDID], [MUDURYERINE]) VALUES (@PERSID, @IZINTURU, @IZINYILLARI, @IZINSURESI, @BASLANGICTARIHI, @BASLANGICSAATI, @BITISTARIHI, @BITISSAATI, @IZINGUNSAY, @GOREVEBASTARIH, @IZINDEBULADRES, @ONAYTARIH, @IZINDURUM, @SAVEUSER, @SAVEDATE, @EDITUSER, @EDITDATE, @SAVEMAC, @EDITMAC, @SAVEIP, @EDITIP, @SBMUDURID, @DAIREBSKID, @INSANDAIREBSKID, @GENELSEKYRDID, @MUDURYERINE);\r\nSELECT ID, PERSID, IZINTURU, IZINYILLARI, IZINSURESI, BASLANGICTARIHI, BASLANGICSAATI, BITISTARIHI, BITISSAATI, IZINGUNSAY, GOREVEBASTARIH, IZINDEBULADRES, ONAYTARIH, IZINDURUM, SAVEUSER, SAVEDATE, EDITUSER, EDITDATE, SAVEMAC, EDITMAC, SAVEIP, EDITIP, SBMUDURID, DAIREBSKID, INSANDAIREBSKID, GENELSEKYRDID, MUDURYERINE FROM TBLPERSONELIZIN WHERE (ID = SCOPE_IDENTITY())";
      this._adapter.InsertCommand.CommandType = CommandType.Text;
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@PERSID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PERSID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@IZINTURU", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINTURU", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@IZINYILLARI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINYILLARI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@IZINSURESI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINSURESI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@BASLANGICTARIHI", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BASLANGICTARIHI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@BASLANGICSAATI", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BASLANGICSAATI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@BITISTARIHI", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BITISTARIHI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@BITISSAATI", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BITISSAATI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@IZINGUNSAY", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINGUNSAY", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@GOREVEBASTARIH", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOREVEBASTARIH", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@IZINDEBULADRES", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINDEBULADRES", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ONAYTARIH", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ONAYTARIH", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@IZINDURUM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINDURUM", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SAVEUSER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEUSER", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SAVEDATE", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEDATE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@EDITUSER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITUSER", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@EDITDATE", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITDATE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SAVEMAC", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEMAC", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@EDITMAC", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITMAC", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SAVEIP", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEIP", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@EDITIP", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITIP", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SBMUDURID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SBMUDURID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@DAIREBSKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DAIREBSKID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@INSANDAIREBSKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "INSANDAIREBSKID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@GENELSEKYRDID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GENELSEKYRDID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@MUDURYERINE", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MUDURYERINE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand = new SqlCommand();
      this._adapter.UpdateCommand.Connection = this.Connection;
      this._adapter.UpdateCommand.CommandText = "UPDATE [dbo].[TBLPERSONELIZIN] SET [PERSID] = @PERSID, [IZINTURU] = @IZINTURU, [IZINYILLARI] = @IZINYILLARI, [IZINSURESI] = @IZINSURESI, [BASLANGICTARIHI] = @BASLANGICTARIHI, [BASLANGICSAATI] = @BASLANGICSAATI, [BITISTARIHI] = @BITISTARIHI, [BITISSAATI] = @BITISSAATI, [IZINGUNSAY] = @IZINGUNSAY, [GOREVEBASTARIH] = @GOREVEBASTARIH, [IZINDEBULADRES] = @IZINDEBULADRES, [ONAYTARIH] = @ONAYTARIH, [IZINDURUM] = @IZINDURUM, [SAVEUSER] = @SAVEUSER, [SAVEDATE] = @SAVEDATE, [EDITUSER] = @EDITUSER, [EDITDATE] = @EDITDATE, [SAVEMAC] = @SAVEMAC, [EDITMAC] = @EDITMAC, [SAVEIP] = @SAVEIP, [EDITIP] = @EDITIP, [SBMUDURID] = @SBMUDURID, [DAIREBSKID] = @DAIREBSKID, [INSANDAIREBSKID] = @INSANDAIREBSKID, [GENELSEKYRDID] = @GENELSEKYRDID, [MUDURYERINE] = @MUDURYERINE WHERE (([ID] = @Original_ID) AND ((@IsNull_PERSID = 1 AND [PERSID] IS NULL) OR ([PERSID] = @Original_PERSID)) AND ((@IsNull_IZINTURU = 1 AND [IZINTURU] IS NULL) OR ([IZINTURU] = @Original_IZINTURU)) AND ((@IsNull_IZINYILLARI = 1 AND [IZINYILLARI] IS NULL) OR ([IZINYILLARI] = @Original_IZINYILLARI)) AND ((@IsNull_IZINSURESI = 1 AND [IZINSURESI] IS NULL) OR ([IZINSURESI] = @Original_IZINSURESI)) AND ((@IsNull_BASLANGICTARIHI = 1 AND [BASLANGICTARIHI] IS NULL) OR ([BASLANGICTARIHI] = @Original_BASLANGICTARIHI)) AND ((@IsNull_BASLANGICSAATI = 1 AND [BASLANGICSAATI] IS NULL) OR ([BASLANGICSAATI] = @Original_BASLANGICSAATI)) AND ((@IsNull_BITISTARIHI = 1 AND [BITISTARIHI] IS NULL) OR ([BITISTARIHI] = @Original_BITISTARIHI)) AND ((@IsNull_BITISSAATI = 1 AND [BITISSAATI] IS NULL) OR ([BITISSAATI] = @Original_BITISSAATI)) AND ((@IsNull_IZINGUNSAY = 1 AND [IZINGUNSAY] IS NULL) OR ([IZINGUNSAY] = @Original_IZINGUNSAY)) AND ((@IsNull_GOREVEBASTARIH = 1 AND [GOREVEBASTARIH] IS NULL) OR ([GOREVEBASTARIH] = @Original_GOREVEBASTARIH)) AND ((@IsNull_IZINDEBULADRES = 1 AND [IZINDEBULADRES] IS NULL) OR ([IZINDEBULADRES] = @Original_IZINDEBULADRES)) AND ((@IsNull_ONAYTARIH = 1 AND [ONAYTARIH] IS NULL) OR ([ONAYTARIH] = @Original_ONAYTARIH)) AND ((@IsNull_IZINDURUM = 1 AND [IZINDURUM] IS NULL) OR ([IZINDURUM] = @Original_IZINDURUM)) AND ((@IsNull_SAVEUSER = 1 AND [SAVEUSER] IS NULL) OR ([SAVEUSER] = @Original_SAVEUSER)) AND ((@IsNull_SAVEDATE = 1 AND [SAVEDATE] IS NULL) OR ([SAVEDATE] = @Original_SAVEDATE)) AND ((@IsNull_EDITUSER = 1 AND [EDITUSER] IS NULL) OR ([EDITUSER] = @Original_EDITUSER)) AND ((@IsNull_EDITDATE = 1 AND [EDITDATE] IS NULL) OR ([EDITDATE] = @Original_EDITDATE)) AND ((@IsNull_SAVEMAC = 1 AND [SAVEMAC] IS NULL) OR ([SAVEMAC] = @Original_SAVEMAC)) AND ((@IsNull_EDITMAC = 1 AND [EDITMAC] IS NULL) OR ([EDITMAC] = @Original_EDITMAC)) AND ((@IsNull_SAVEIP = 1 AND [SAVEIP] IS NULL) OR ([SAVEIP] = @Original_SAVEIP)) AND ((@IsNull_EDITIP = 1 AND [EDITIP] IS NULL) OR ([EDITIP] = @Original_EDITIP)) AND ((@IsNull_SBMUDURID = 1 AND [SBMUDURID] IS NULL) OR ([SBMUDURID] = @Original_SBMUDURID)) AND ((@IsNull_DAIREBSKID = 1 AND [DAIREBSKID] IS NULL) OR ([DAIREBSKID] = @Original_DAIREBSKID)) AND ((@IsNull_INSANDAIREBSKID = 1 AND [INSANDAIREBSKID] IS NULL) OR ([INSANDAIREBSKID] = @Original_INSANDAIREBSKID)) AND ((@IsNull_GENELSEKYRDID = 1 AND [GENELSEKYRDID] IS NULL) OR ([GENELSEKYRDID] = @Original_GENELSEKYRDID)) AND ((@IsNull_MUDURYERINE = 1 AND [MUDURYERINE] IS NULL) OR ([MUDURYERINE] = @Original_MUDURYERINE)));\r\nSELECT ID, PERSID, IZINTURU, IZINYILLARI, IZINSURESI, BASLANGICTARIHI, BASLANGICSAATI, BITISTARIHI, BITISSAATI, IZINGUNSAY, GOREVEBASTARIH, IZINDEBULADRES, ONAYTARIH, IZINDURUM, SAVEUSER, SAVEDATE, EDITUSER, EDITDATE, SAVEMAC, EDITMAC, SAVEIP, EDITIP, SBMUDURID, DAIREBSKID, INSANDAIREBSKID, GENELSEKYRDID, MUDURYERINE FROM TBLPERSONELIZIN WHERE (ID = @ID)";
      this._adapter.UpdateCommand.CommandType = CommandType.Text;
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@PERSID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PERSID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IZINTURU", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINTURU", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IZINYILLARI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINYILLARI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IZINSURESI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINSURESI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@BASLANGICTARIHI", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BASLANGICTARIHI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@BASLANGICSAATI", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BASLANGICSAATI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@BITISTARIHI", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BITISTARIHI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@BITISSAATI", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BITISSAATI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IZINGUNSAY", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINGUNSAY", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@GOREVEBASTARIH", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOREVEBASTARIH", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IZINDEBULADRES", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINDEBULADRES", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ONAYTARIH", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ONAYTARIH", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IZINDURUM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINDURUM", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SAVEUSER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEUSER", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SAVEDATE", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEDATE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EDITUSER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITUSER", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EDITDATE", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITDATE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SAVEMAC", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEMAC", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EDITMAC", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITMAC", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SAVEIP", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEIP", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EDITIP", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITIP", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SBMUDURID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SBMUDURID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@DAIREBSKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DAIREBSKID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@INSANDAIREBSKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "INSANDAIREBSKID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@GENELSEKYRDID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GENELSEKYRDID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MUDURYERINE", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MUDURYERINE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_PERSID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PERSID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_PERSID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PERSID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_IZINTURU", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINTURU", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_IZINTURU", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINTURU", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_IZINYILLARI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINYILLARI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_IZINYILLARI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINYILLARI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_IZINSURESI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINSURESI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_IZINSURESI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINSURESI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_BASLANGICTARIHI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BASLANGICTARIHI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_BASLANGICTARIHI", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BASLANGICTARIHI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_BASLANGICSAATI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BASLANGICSAATI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_BASLANGICSAATI", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BASLANGICSAATI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_BITISTARIHI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BITISTARIHI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_BITISTARIHI", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BITISTARIHI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_BITISSAATI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BITISSAATI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_BITISSAATI", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BITISSAATI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_IZINGUNSAY", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINGUNSAY", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_IZINGUNSAY", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINGUNSAY", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_GOREVEBASTARIH", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOREVEBASTARIH", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_GOREVEBASTARIH", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOREVEBASTARIH", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_IZINDEBULADRES", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINDEBULADRES", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_IZINDEBULADRES", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINDEBULADRES", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ONAYTARIH", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ONAYTARIH", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ONAYTARIH", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ONAYTARIH", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_IZINDURUM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINDURUM", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_IZINDURUM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IZINDURUM", DataRowVersion.Original, false, (object) null, "", "", ""));
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
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SBMUDURID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SBMUDURID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SBMUDURID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SBMUDURID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_DAIREBSKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DAIREBSKID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_DAIREBSKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DAIREBSKID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_INSANDAIREBSKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "INSANDAIREBSKID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_INSANDAIREBSKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "INSANDAIREBSKID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_GENELSEKYRDID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GENELSEKYRDID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_GENELSEKYRDID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GENELSEKYRDID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_MUDURYERINE", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MUDURYERINE", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_MUDURYERINE", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MUDURYERINE", DataRowVersion.Original, false, (object) null, "", "", ""));
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
      this._commandCollection[0].CommandText = "SELECT ID, PERSID, IZINTURU, IZINYILLARI, IZINSURESI, BASLANGICTARIHI, BASLANGICSAATI, BITISTARIHI, BITISSAATI, IZINGUNSAY, GOREVEBASTARIH, IZINDEBULADRES, ONAYTARIH, IZINDURUM, SAVEUSER, SAVEDATE, EDITUSER, EDITDATE, SAVEMAC, EDITMAC, SAVEIP, EDITIP, SBMUDURID, DAIREBSKID, INSANDAIREBSKID, GENELSEKYRDID, MUDURYERINE FROM dbo.TBLPERSONELIZIN";
      this._commandCollection[0].CommandType = CommandType.Text;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    public virtual int Fill(bellDataSet7.TBLPERSONELIZINDataTable dataTable)
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
    public virtual bellDataSet7.TBLPERSONELIZINDataTable GetData()
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      bellDataSet7.TBLPERSONELIZINDataTable data = new bellDataSet7.TBLPERSONELIZINDataTable();
      this.Adapter.Fill((DataTable) data);
      return data;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(bellDataSet7.TBLPERSONELIZINDataTable dataTable) => this.Adapter.Update((DataTable) dataTable);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(bellDataSet7 dataSet) => this.Adapter.Update((DataSet) dataSet, "TBLPERSONELIZIN");

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
      int? Original_PERSID,
      string Original_IZINTURU,
      string Original_IZINYILLARI,
      string Original_IZINSURESI,
      DateTime? Original_BASLANGICTARIHI,
      DateTime? Original_BASLANGICSAATI,
      DateTime? Original_BITISTARIHI,
      DateTime? Original_BITISSAATI,
      string Original_IZINGUNSAY,
      DateTime? Original_GOREVEBASTARIH,
      string Original_IZINDEBULADRES,
      DateTime? Original_ONAYTARIH,
      string Original_IZINDURUM,
      string Original_SAVEUSER,
      DateTime? Original_SAVEDATE,
      string Original_EDITUSER,
      DateTime? Original_EDITDATE,
      string Original_SAVEMAC,
      string Original_EDITMAC,
      string Original_SAVEIP,
      string Original_EDITIP,
      int? Original_SBMUDURID,
      int? Original_DAIREBSKID,
      int? Original_INSANDAIREBSKID,
      int? Original_GENELSEKYRDID,
      int? Original_MUDURYERINE)
    {
      this.Adapter.DeleteCommand.Parameters[0].Value = (object) Original_ID;
      if (Original_PERSID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[1].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[2].Value = (object) Original_PERSID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[1].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[2].Value = (object) DBNull.Value;
      }
      if (Original_IZINTURU == null)
      {
        this.Adapter.DeleteCommand.Parameters[3].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[4].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[3].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[4].Value = (object) Original_IZINTURU;
      }
      if (Original_IZINYILLARI == null)
      {
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[6].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[6].Value = (object) Original_IZINYILLARI;
      }
      if (Original_IZINSURESI == null)
      {
        this.Adapter.DeleteCommand.Parameters[7].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[8].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[7].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[8].Value = (object) Original_IZINSURESI;
      }
      if (Original_BASLANGICTARIHI.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) Original_BASLANGICTARIHI.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) DBNull.Value;
      }
      if (Original_BASLANGICSAATI.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[11].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[12].Value = (object) Original_BASLANGICSAATI.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[11].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[12].Value = (object) DBNull.Value;
      }
      if (Original_BITISTARIHI.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[13].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[14].Value = (object) Original_BITISTARIHI.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[13].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[14].Value = (object) DBNull.Value;
      }
      if (Original_BITISSAATI.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[15].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[16].Value = (object) Original_BITISSAATI.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[15].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[16].Value = (object) DBNull.Value;
      }
      if (Original_IZINGUNSAY == null)
      {
        this.Adapter.DeleteCommand.Parameters[17].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[18].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[17].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[18].Value = (object) Original_IZINGUNSAY;
      }
      if (Original_GOREVEBASTARIH.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[19].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[20].Value = (object) Original_GOREVEBASTARIH.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[19].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[20].Value = (object) DBNull.Value;
      }
      if (Original_IZINDEBULADRES == null)
      {
        this.Adapter.DeleteCommand.Parameters[21].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[22].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[21].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[22].Value = (object) Original_IZINDEBULADRES;
      }
      if (Original_ONAYTARIH.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[23].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[24].Value = (object) Original_ONAYTARIH.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[23].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[24].Value = (object) DBNull.Value;
      }
      if (Original_IZINDURUM == null)
      {
        this.Adapter.DeleteCommand.Parameters[25].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[26].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[25].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[26].Value = (object) Original_IZINDURUM;
      }
      if (Original_SAVEUSER == null)
      {
        this.Adapter.DeleteCommand.Parameters[27].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[28].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[27].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[28].Value = (object) Original_SAVEUSER;
      }
      if (Original_SAVEDATE.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[29].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[30].Value = (object) Original_SAVEDATE.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[29].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[30].Value = (object) DBNull.Value;
      }
      if (Original_EDITUSER == null)
      {
        this.Adapter.DeleteCommand.Parameters[31].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[32].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[31].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[32].Value = (object) Original_EDITUSER;
      }
      if (Original_EDITDATE.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[33].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[34].Value = (object) Original_EDITDATE.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[33].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[34].Value = (object) DBNull.Value;
      }
      if (Original_SAVEMAC == null)
      {
        this.Adapter.DeleteCommand.Parameters[35].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[36].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[35].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[36].Value = (object) Original_SAVEMAC;
      }
      if (Original_EDITMAC == null)
      {
        this.Adapter.DeleteCommand.Parameters[37].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[38].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[37].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[38].Value = (object) Original_EDITMAC;
      }
      if (Original_SAVEIP == null)
      {
        this.Adapter.DeleteCommand.Parameters[39].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[40].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[39].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[40].Value = (object) Original_SAVEIP;
      }
      if (Original_EDITIP == null)
      {
        this.Adapter.DeleteCommand.Parameters[41].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[42].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[41].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[42].Value = (object) Original_EDITIP;
      }
      if (Original_SBMUDURID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[43].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[44].Value = (object) Original_SBMUDURID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[43].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[44].Value = (object) DBNull.Value;
      }
      if (Original_DAIREBSKID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[45].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[46].Value = (object) Original_DAIREBSKID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[45].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[46].Value = (object) DBNull.Value;
      }
      if (Original_INSANDAIREBSKID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[47].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[48].Value = (object) Original_INSANDAIREBSKID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[47].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[48].Value = (object) DBNull.Value;
      }
      if (Original_GENELSEKYRDID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[49].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[50].Value = (object) Original_GENELSEKYRDID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[49].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[50].Value = (object) DBNull.Value;
      }
      if (Original_MUDURYERINE.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[51].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[52].Value = (object) Original_MUDURYERINE.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[51].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[52].Value = (object) DBNull.Value;
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
      int? PERSID,
      string IZINTURU,
      string IZINYILLARI,
      string IZINSURESI,
      DateTime? BASLANGICTARIHI,
      DateTime? BASLANGICSAATI,
      DateTime? BITISTARIHI,
      DateTime? BITISSAATI,
      string IZINGUNSAY,
      DateTime? GOREVEBASTARIH,
      string IZINDEBULADRES,
      DateTime? ONAYTARIH,
      string IZINDURUM,
      string SAVEUSER,
      DateTime? SAVEDATE,
      string EDITUSER,
      DateTime? EDITDATE,
      string SAVEMAC,
      string EDITMAC,
      string SAVEIP,
      string EDITIP,
      int? SBMUDURID,
      int? DAIREBSKID,
      int? INSANDAIREBSKID,
      int? GENELSEKYRDID,
      int? MUDURYERINE)
    {
      if (PERSID.HasValue)
        this.Adapter.InsertCommand.Parameters[0].Value = (object) PERSID.Value;
      else
        this.Adapter.InsertCommand.Parameters[0].Value = (object) DBNull.Value;
      if (IZINTURU == null)
        this.Adapter.InsertCommand.Parameters[1].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[1].Value = (object) IZINTURU;
      if (IZINYILLARI == null)
        this.Adapter.InsertCommand.Parameters[2].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[2].Value = (object) IZINYILLARI;
      if (IZINSURESI == null)
        this.Adapter.InsertCommand.Parameters[3].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[3].Value = (object) IZINSURESI;
      if (BASLANGICTARIHI.HasValue)
        this.Adapter.InsertCommand.Parameters[4].Value = (object) BASLANGICTARIHI.Value;
      else
        this.Adapter.InsertCommand.Parameters[4].Value = (object) DBNull.Value;
      if (BASLANGICSAATI.HasValue)
        this.Adapter.InsertCommand.Parameters[5].Value = (object) BASLANGICSAATI.Value;
      else
        this.Adapter.InsertCommand.Parameters[5].Value = (object) DBNull.Value;
      if (BITISTARIHI.HasValue)
        this.Adapter.InsertCommand.Parameters[6].Value = (object) BITISTARIHI.Value;
      else
        this.Adapter.InsertCommand.Parameters[6].Value = (object) DBNull.Value;
      if (BITISSAATI.HasValue)
        this.Adapter.InsertCommand.Parameters[7].Value = (object) BITISSAATI.Value;
      else
        this.Adapter.InsertCommand.Parameters[7].Value = (object) DBNull.Value;
      if (IZINGUNSAY == null)
        this.Adapter.InsertCommand.Parameters[8].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[8].Value = (object) IZINGUNSAY;
      if (GOREVEBASTARIH.HasValue)
        this.Adapter.InsertCommand.Parameters[9].Value = (object) GOREVEBASTARIH.Value;
      else
        this.Adapter.InsertCommand.Parameters[9].Value = (object) DBNull.Value;
      if (IZINDEBULADRES == null)
        this.Adapter.InsertCommand.Parameters[10].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[10].Value = (object) IZINDEBULADRES;
      if (ONAYTARIH.HasValue)
        this.Adapter.InsertCommand.Parameters[11].Value = (object) ONAYTARIH.Value;
      else
        this.Adapter.InsertCommand.Parameters[11].Value = (object) DBNull.Value;
      if (IZINDURUM == null)
        this.Adapter.InsertCommand.Parameters[12].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[12].Value = (object) IZINDURUM;
      if (SAVEUSER == null)
        this.Adapter.InsertCommand.Parameters[13].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[13].Value = (object) SAVEUSER;
      if (SAVEDATE.HasValue)
        this.Adapter.InsertCommand.Parameters[14].Value = (object) SAVEDATE.Value;
      else
        this.Adapter.InsertCommand.Parameters[14].Value = (object) DBNull.Value;
      if (EDITUSER == null)
        this.Adapter.InsertCommand.Parameters[15].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[15].Value = (object) EDITUSER;
      if (EDITDATE.HasValue)
        this.Adapter.InsertCommand.Parameters[16].Value = (object) EDITDATE.Value;
      else
        this.Adapter.InsertCommand.Parameters[16].Value = (object) DBNull.Value;
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
      if (SBMUDURID.HasValue)
        this.Adapter.InsertCommand.Parameters[21].Value = (object) SBMUDURID.Value;
      else
        this.Adapter.InsertCommand.Parameters[21].Value = (object) DBNull.Value;
      if (DAIREBSKID.HasValue)
        this.Adapter.InsertCommand.Parameters[22].Value = (object) DAIREBSKID.Value;
      else
        this.Adapter.InsertCommand.Parameters[22].Value = (object) DBNull.Value;
      if (INSANDAIREBSKID.HasValue)
        this.Adapter.InsertCommand.Parameters[23].Value = (object) INSANDAIREBSKID.Value;
      else
        this.Adapter.InsertCommand.Parameters[23].Value = (object) DBNull.Value;
      if (GENELSEKYRDID.HasValue)
        this.Adapter.InsertCommand.Parameters[24].Value = (object) GENELSEKYRDID.Value;
      else
        this.Adapter.InsertCommand.Parameters[24].Value = (object) DBNull.Value;
      if (MUDURYERINE.HasValue)
        this.Adapter.InsertCommand.Parameters[25].Value = (object) MUDURYERINE.Value;
      else
        this.Adapter.InsertCommand.Parameters[25].Value = (object) DBNull.Value;
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
      int? PERSID,
      string IZINTURU,
      string IZINYILLARI,
      string IZINSURESI,
      DateTime? BASLANGICTARIHI,
      DateTime? BASLANGICSAATI,
      DateTime? BITISTARIHI,
      DateTime? BITISSAATI,
      string IZINGUNSAY,
      DateTime? GOREVEBASTARIH,
      string IZINDEBULADRES,
      DateTime? ONAYTARIH,
      string IZINDURUM,
      string SAVEUSER,
      DateTime? SAVEDATE,
      string EDITUSER,
      DateTime? EDITDATE,
      string SAVEMAC,
      string EDITMAC,
      string SAVEIP,
      string EDITIP,
      int? SBMUDURID,
      int? DAIREBSKID,
      int? INSANDAIREBSKID,
      int? GENELSEKYRDID,
      int? MUDURYERINE,
      int Original_ID,
      int? Original_PERSID,
      string Original_IZINTURU,
      string Original_IZINYILLARI,
      string Original_IZINSURESI,
      DateTime? Original_BASLANGICTARIHI,
      DateTime? Original_BASLANGICSAATI,
      DateTime? Original_BITISTARIHI,
      DateTime? Original_BITISSAATI,
      string Original_IZINGUNSAY,
      DateTime? Original_GOREVEBASTARIH,
      string Original_IZINDEBULADRES,
      DateTime? Original_ONAYTARIH,
      string Original_IZINDURUM,
      string Original_SAVEUSER,
      DateTime? Original_SAVEDATE,
      string Original_EDITUSER,
      DateTime? Original_EDITDATE,
      string Original_SAVEMAC,
      string Original_EDITMAC,
      string Original_SAVEIP,
      string Original_EDITIP,
      int? Original_SBMUDURID,
      int? Original_DAIREBSKID,
      int? Original_INSANDAIREBSKID,
      int? Original_GENELSEKYRDID,
      int? Original_MUDURYERINE,
      int ID)
    {
      if (PERSID.HasValue)
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) PERSID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) DBNull.Value;
      if (IZINTURU == null)
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) IZINTURU;
      if (IZINYILLARI == null)
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) IZINYILLARI;
      if (IZINSURESI == null)
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) IZINSURESI;
      if (BASLANGICTARIHI.HasValue)
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) BASLANGICTARIHI.Value;
      else
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) DBNull.Value;
      if (BASLANGICSAATI.HasValue)
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) BASLANGICSAATI.Value;
      else
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) DBNull.Value;
      if (BITISTARIHI.HasValue)
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) BITISTARIHI.Value;
      else
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) DBNull.Value;
      if (BITISSAATI.HasValue)
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) BITISSAATI.Value;
      else
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) DBNull.Value;
      if (IZINGUNSAY == null)
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) IZINGUNSAY;
      if (GOREVEBASTARIH.HasValue)
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) GOREVEBASTARIH.Value;
      else
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) DBNull.Value;
      if (IZINDEBULADRES == null)
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) IZINDEBULADRES;
      if (ONAYTARIH.HasValue)
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) ONAYTARIH.Value;
      else
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) DBNull.Value;
      if (IZINDURUM == null)
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) IZINDURUM;
      if (SAVEUSER == null)
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) SAVEUSER;
      if (SAVEDATE.HasValue)
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) SAVEDATE.Value;
      else
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) DBNull.Value;
      if (EDITUSER == null)
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) EDITUSER;
      if (EDITDATE.HasValue)
        this.Adapter.UpdateCommand.Parameters[16].Value = (object) EDITDATE.Value;
      else
        this.Adapter.UpdateCommand.Parameters[16].Value = (object) DBNull.Value;
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
      if (SBMUDURID.HasValue)
        this.Adapter.UpdateCommand.Parameters[21].Value = (object) SBMUDURID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[21].Value = (object) DBNull.Value;
      if (DAIREBSKID.HasValue)
        this.Adapter.UpdateCommand.Parameters[22].Value = (object) DAIREBSKID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[22].Value = (object) DBNull.Value;
      if (INSANDAIREBSKID.HasValue)
        this.Adapter.UpdateCommand.Parameters[23].Value = (object) INSANDAIREBSKID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[23].Value = (object) DBNull.Value;
      if (GENELSEKYRDID.HasValue)
        this.Adapter.UpdateCommand.Parameters[24].Value = (object) GENELSEKYRDID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[24].Value = (object) DBNull.Value;
      if (MUDURYERINE.HasValue)
        this.Adapter.UpdateCommand.Parameters[25].Value = (object) MUDURYERINE.Value;
      else
        this.Adapter.UpdateCommand.Parameters[25].Value = (object) DBNull.Value;
      this.Adapter.UpdateCommand.Parameters[26].Value = (object) Original_ID;
      if (Original_PERSID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[27].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[28].Value = (object) Original_PERSID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[27].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[28].Value = (object) DBNull.Value;
      }
      if (Original_IZINTURU == null)
      {
        this.Adapter.UpdateCommand.Parameters[29].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[30].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[29].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[30].Value = (object) Original_IZINTURU;
      }
      if (Original_IZINYILLARI == null)
      {
        this.Adapter.UpdateCommand.Parameters[31].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[32].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[31].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[32].Value = (object) Original_IZINYILLARI;
      }
      if (Original_IZINSURESI == null)
      {
        this.Adapter.UpdateCommand.Parameters[33].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[34].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[33].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[34].Value = (object) Original_IZINSURESI;
      }
      if (Original_BASLANGICTARIHI.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[35].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[36].Value = (object) Original_BASLANGICTARIHI.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[35].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[36].Value = (object) DBNull.Value;
      }
      if (Original_BASLANGICSAATI.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[37].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[38].Value = (object) Original_BASLANGICSAATI.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[37].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[38].Value = (object) DBNull.Value;
      }
      if (Original_BITISTARIHI.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[39].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[40].Value = (object) Original_BITISTARIHI.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[39].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[40].Value = (object) DBNull.Value;
      }
      if (Original_BITISSAATI.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[41].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[42].Value = (object) Original_BITISSAATI.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[41].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[42].Value = (object) DBNull.Value;
      }
      if (Original_IZINGUNSAY == null)
      {
        this.Adapter.UpdateCommand.Parameters[43].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[44].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[43].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[44].Value = (object) Original_IZINGUNSAY;
      }
      if (Original_GOREVEBASTARIH.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[45].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[46].Value = (object) Original_GOREVEBASTARIH.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[45].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[46].Value = (object) DBNull.Value;
      }
      if (Original_IZINDEBULADRES == null)
      {
        this.Adapter.UpdateCommand.Parameters[47].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[48].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[47].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[48].Value = (object) Original_IZINDEBULADRES;
      }
      if (Original_ONAYTARIH.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[49].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[50].Value = (object) Original_ONAYTARIH.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[49].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[50].Value = (object) DBNull.Value;
      }
      if (Original_IZINDURUM == null)
      {
        this.Adapter.UpdateCommand.Parameters[51].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[52].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[51].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[52].Value = (object) Original_IZINDURUM;
      }
      if (Original_SAVEUSER == null)
      {
        this.Adapter.UpdateCommand.Parameters[53].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[54].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[53].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[54].Value = (object) Original_SAVEUSER;
      }
      if (Original_SAVEDATE.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[55].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[56].Value = (object) Original_SAVEDATE.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[55].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[56].Value = (object) DBNull.Value;
      }
      if (Original_EDITUSER == null)
      {
        this.Adapter.UpdateCommand.Parameters[57].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[58].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[57].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[58].Value = (object) Original_EDITUSER;
      }
      if (Original_EDITDATE.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[59].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[60].Value = (object) Original_EDITDATE.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[59].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[60].Value = (object) DBNull.Value;
      }
      if (Original_SAVEMAC == null)
      {
        this.Adapter.UpdateCommand.Parameters[61].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[62].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[61].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[62].Value = (object) Original_SAVEMAC;
      }
      if (Original_EDITMAC == null)
      {
        this.Adapter.UpdateCommand.Parameters[63].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[64].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[63].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[64].Value = (object) Original_EDITMAC;
      }
      if (Original_SAVEIP == null)
      {
        this.Adapter.UpdateCommand.Parameters[65].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[66].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[65].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[66].Value = (object) Original_SAVEIP;
      }
      if (Original_EDITIP == null)
      {
        this.Adapter.UpdateCommand.Parameters[67].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[68].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[67].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[68].Value = (object) Original_EDITIP;
      }
      if (Original_SBMUDURID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[69].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[70].Value = (object) Original_SBMUDURID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[69].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[70].Value = (object) DBNull.Value;
      }
      if (Original_DAIREBSKID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[71].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[72].Value = (object) Original_DAIREBSKID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[71].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[72].Value = (object) DBNull.Value;
      }
      if (Original_INSANDAIREBSKID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[73].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[74].Value = (object) Original_INSANDAIREBSKID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[73].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[74].Value = (object) DBNull.Value;
      }
      if (Original_GENELSEKYRDID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[75].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[76].Value = (object) Original_GENELSEKYRDID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[75].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[76].Value = (object) DBNull.Value;
      }
      if (Original_MUDURYERINE.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[77].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[78].Value = (object) Original_MUDURYERINE.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[77].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[78].Value = (object) DBNull.Value;
      }
      this.Adapter.UpdateCommand.Parameters[79].Value = (object) ID;
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
      int? PERSID,
      string IZINTURU,
      string IZINYILLARI,
      string IZINSURESI,
      DateTime? BASLANGICTARIHI,
      DateTime? BASLANGICSAATI,
      DateTime? BITISTARIHI,
      DateTime? BITISSAATI,
      string IZINGUNSAY,
      DateTime? GOREVEBASTARIH,
      string IZINDEBULADRES,
      DateTime? ONAYTARIH,
      string IZINDURUM,
      string SAVEUSER,
      DateTime? SAVEDATE,
      string EDITUSER,
      DateTime? EDITDATE,
      string SAVEMAC,
      string EDITMAC,
      string SAVEIP,
      string EDITIP,
      int? SBMUDURID,
      int? DAIREBSKID,
      int? INSANDAIREBSKID,
      int? GENELSEKYRDID,
      int? MUDURYERINE,
      int Original_ID,
      int? Original_PERSID,
      string Original_IZINTURU,
      string Original_IZINYILLARI,
      string Original_IZINSURESI,
      DateTime? Original_BASLANGICTARIHI,
      DateTime? Original_BASLANGICSAATI,
      DateTime? Original_BITISTARIHI,
      DateTime? Original_BITISSAATI,
      string Original_IZINGUNSAY,
      DateTime? Original_GOREVEBASTARIH,
      string Original_IZINDEBULADRES,
      DateTime? Original_ONAYTARIH,
      string Original_IZINDURUM,
      string Original_SAVEUSER,
      DateTime? Original_SAVEDATE,
      string Original_EDITUSER,
      DateTime? Original_EDITDATE,
      string Original_SAVEMAC,
      string Original_EDITMAC,
      string Original_SAVEIP,
      string Original_EDITIP,
      int? Original_SBMUDURID,
      int? Original_DAIREBSKID,
      int? Original_INSANDAIREBSKID,
      int? Original_GENELSEKYRDID,
      int? Original_MUDURYERINE)
    {
      return this.Update(PERSID, IZINTURU, IZINYILLARI, IZINSURESI, BASLANGICTARIHI, BASLANGICSAATI, BITISTARIHI, BITISSAATI, IZINGUNSAY, GOREVEBASTARIH, IZINDEBULADRES, ONAYTARIH, IZINDURUM, SAVEUSER, SAVEDATE, EDITUSER, EDITDATE, SAVEMAC, EDITMAC, SAVEIP, EDITIP, SBMUDURID, DAIREBSKID, INSANDAIREBSKID, GENELSEKYRDID, MUDURYERINE, Original_ID, Original_PERSID, Original_IZINTURU, Original_IZINYILLARI, Original_IZINSURESI, Original_BASLANGICTARIHI, Original_BASLANGICSAATI, Original_BITISTARIHI, Original_BITISSAATI, Original_IZINGUNSAY, Original_GOREVEBASTARIH, Original_IZINDEBULADRES, Original_ONAYTARIH, Original_IZINDURUM, Original_SAVEUSER, Original_SAVEDATE, Original_EDITUSER, Original_EDITDATE, Original_SAVEMAC, Original_EDITMAC, Original_SAVEIP, Original_EDITIP, Original_SBMUDURID, Original_DAIREBSKID, Original_INSANDAIREBSKID, Original_GENELSEKYRDID, Original_MUDURYERINE, Original_ID);
    }
  }
}
