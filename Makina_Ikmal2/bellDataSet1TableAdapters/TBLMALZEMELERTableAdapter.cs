// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.bellDataSet1TableAdapters.TBLMALZEMELERTableAdapter
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

namespace Makina_Ikmal.bellDataSet1TableAdapters
{
  [DesignerCategory("code")]
  [ToolboxItem(true)]
  [DataObject(true)]
  [Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [HelpKeyword("vs.data.TableAdapter")]
  public class TBLMALZEMELERTableAdapter : Component
  {
    private SqlDataAdapter _adapter;
    private SqlConnection _connection;
    private SqlTransaction _transaction;
    private SqlCommand[] _commandCollection;
    private bool _clearBeforeFill;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public TBLMALZEMELERTableAdapter() => this.ClearBeforeFill = true;

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
        DataSetTable = "TBLMALZEMELER",
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
            "UFKOD",
            "UFKOD"
          },
          {
            "OEMKOD",
            "OEMKOD"
          },
          {
            "MALZEMEADI",
            "MALZEMEADI"
          },
          {
            "DIGERADI",
            "DIGERADI"
          },
          {
            "KULLANIMYERI",
            "KULLANIMYERI"
          },
          {
            "BIRIMID",
            "BIRIMID"
          },
          {
            "GRUPID",
            "GRUPID"
          },
          {
            "GRUPID2",
            "GRUPID2"
          },
          {
            "KDVID",
            "KDVID"
          },
          {
            "BOLUMID",
            "BOLUMID"
          },
          {
            "RAFNO",
            "RAFNO"
          },
          {
            "GOZNO",
            "GOZNO"
          },
          {
            "BARKOD",
            "BARKOD"
          },
          {
            "TARIHKONTROL",
            "TARIHKONTROL"
          },
          {
            "SERINOKONTROL",
            "SERINOKONTROL"
          },
          {
            "KMKONTROL",
            "KMKONTROL"
          },
          {
            "MALZEMEFOTO",
            "MALZEMEFOTO"
          },
          {
            "KAYITTIPIID",
            "KAYITTIPIID"
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
            "GIRIS",
            "GIRIS"
          },
          {
            "CIKIS",
            "CIKIS"
          },
          {
            "KALAN",
            "KALAN"
          }
        }
      });
      this._adapter.DeleteCommand = new SqlCommand();
      this._adapter.DeleteCommand.Connection = this.Connection;
      this._adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[TBLMALZEMELER] WHERE (([ID] = @Original_ID) AND ((@IsNull_KOD = 1 AND [KOD] IS NULL) OR ([KOD] = @Original_KOD)) AND ((@IsNull_UFKOD = 1 AND [UFKOD] IS NULL) OR ([UFKOD] = @Original_UFKOD)) AND ((@IsNull_OEMKOD = 1 AND [OEMKOD] IS NULL) OR ([OEMKOD] = @Original_OEMKOD)) AND ((@IsNull_MALZEMEADI = 1 AND [MALZEMEADI] IS NULL) OR ([MALZEMEADI] = @Original_MALZEMEADI)) AND ((@IsNull_DIGERADI = 1 AND [DIGERADI] IS NULL) OR ([DIGERADI] = @Original_DIGERADI)) AND ((@IsNull_KULLANIMYERI = 1 AND [KULLANIMYERI] IS NULL) OR ([KULLANIMYERI] = @Original_KULLANIMYERI)) AND ((@IsNull_BIRIMID = 1 AND [BIRIMID] IS NULL) OR ([BIRIMID] = @Original_BIRIMID)) AND ((@IsNull_GRUPID = 1 AND [GRUPID] IS NULL) OR ([GRUPID] = @Original_GRUPID)) AND ((@IsNull_GRUPID2 = 1 AND [GRUPID2] IS NULL) OR ([GRUPID2] = @Original_GRUPID2)) AND ((@IsNull_KDVID = 1 AND [KDVID] IS NULL) OR ([KDVID] = @Original_KDVID)) AND ((@IsNull_BOLUMID = 1 AND [BOLUMID] IS NULL) OR ([BOLUMID] = @Original_BOLUMID)) AND ((@IsNull_RAFNO = 1 AND [RAFNO] IS NULL) OR ([RAFNO] = @Original_RAFNO)) AND ((@IsNull_GOZNO = 1 AND [GOZNO] IS NULL) OR ([GOZNO] = @Original_GOZNO)) AND ((@IsNull_BARKOD = 1 AND [BARKOD] IS NULL) OR ([BARKOD] = @Original_BARKOD)) AND ((@IsNull_TARIHKONTROL = 1 AND [TARIHKONTROL] IS NULL) OR ([TARIHKONTROL] = @Original_TARIHKONTROL)) AND ((@IsNull_SERINOKONTROL = 1 AND [SERINOKONTROL] IS NULL) OR ([SERINOKONTROL] = @Original_SERINOKONTROL)) AND ((@IsNull_KMKONTROL = 1 AND [KMKONTROL] IS NULL) OR ([KMKONTROL] = @Original_KMKONTROL)) AND ((@IsNull_MALZEMEFOTO = 1 AND [MALZEMEFOTO] IS NULL) OR ([MALZEMEFOTO] = @Original_MALZEMEFOTO)) AND ((@IsNull_KAYITTIPIID = 1 AND [KAYITTIPIID] IS NULL) OR ([KAYITTIPIID] = @Original_KAYITTIPIID)) AND ((@IsNull_SAVEUSER = 1 AND [SAVEUSER] IS NULL) OR ([SAVEUSER] = @Original_SAVEUSER)) AND ((@IsNull_SAVEDATE = 1 AND [SAVEDATE] IS NULL) OR ([SAVEDATE] = @Original_SAVEDATE)) AND ((@IsNull_EDITUSER = 1 AND [EDITUSER] IS NULL) OR ([EDITUSER] = @Original_EDITUSER)) AND ((@IsNull_EDITDATE = 1 AND [EDITDATE] IS NULL) OR ([EDITDATE] = @Original_EDITDATE)) AND ((@IsNull_SAVEMAC = 1 AND [SAVEMAC] IS NULL) OR ([SAVEMAC] = @Original_SAVEMAC)) AND ((@IsNull_EDITMAC = 1 AND [EDITMAC] IS NULL) OR ([EDITMAC] = @Original_EDITMAC)) AND ((@IsNull_SAVEIP = 1 AND [SAVEIP] IS NULL) OR ([SAVEIP] = @Original_SAVEIP)) AND ((@IsNull_EDITIP = 1 AND [EDITIP] IS NULL) OR ([EDITIP] = @Original_EDITIP)) AND ((@IsNull_GIRIS = 1 AND [GIRIS] IS NULL) OR ([GIRIS] = @Original_GIRIS)) AND ((@IsNull_CIKIS = 1 AND [CIKIS] IS NULL) OR ([CIKIS] = @Original_CIKIS)) AND ((@IsNull_KALAN = 1 AND [KALAN] IS NULL) OR ([KALAN] = @Original_KALAN)))";
      this._adapter.DeleteCommand.CommandType = CommandType.Text;
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_KOD", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_KOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_UFKOD", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "UFKOD", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_UFKOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "UFKOD", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_OEMKOD", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "OEMKOD", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_OEMKOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "OEMKOD", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_MALZEMEADI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZEMEADI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_MALZEMEADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZEMEADI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_DIGERADI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DIGERADI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_DIGERADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DIGERADI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_KULLANIMYERI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KULLANIMYERI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_KULLANIMYERI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KULLANIMYERI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_BIRIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BIRIMID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_BIRIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BIRIMID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_GRUPID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GRUPID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_GRUPID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GRUPID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_GRUPID2", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GRUPID2", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_GRUPID2", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GRUPID2", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_KDVID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KDVID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_KDVID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KDVID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_BOLUMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BOLUMID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_BOLUMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BOLUMID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_RAFNO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RAFNO", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_RAFNO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RAFNO", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_GOZNO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOZNO", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_GOZNO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOZNO", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_BARKOD", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BARKOD", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_BARKOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BARKOD", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TARIHKONTROL", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TARIHKONTROL", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TARIHKONTROL", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TARIHKONTROL", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SERINOKONTROL", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SERINOKONTROL", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SERINOKONTROL", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SERINOKONTROL", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_KMKONTROL", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KMKONTROL", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_KMKONTROL", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KMKONTROL", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_MALZEMEFOTO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZEMEFOTO", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_MALZEMEFOTO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZEMEFOTO", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_KAYITTIPIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KAYITTIPIID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_KAYITTIPIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KAYITTIPIID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SAVEUSER", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEUSER", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SAVEUSER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEUSER", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SAVEDATE", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEDATE", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SAVEDATE", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEDATE", DataRowVersion.Original, false, (object) null, "", "", ""));
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
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_GIRIS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GIRIS", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_GIRIS", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "GIRIS", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_CIKIS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKIS", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_CIKIS", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "CIKIS", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_KALAN", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KALAN", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_KALAN", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "KALAN", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.InsertCommand = new SqlCommand();
      this._adapter.InsertCommand.Connection = this.Connection;
      this._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[TBLMALZEMELER] ([KOD], [UFKOD], [OEMKOD], [MALZEMEADI], [DIGERADI], [KULLANIMYERI], [BIRIMID], [GRUPID], [GRUPID2], [KDVID], [BOLUMID], [RAFNO], [GOZNO], [BARKOD], [TARIHKONTROL], [SERINOKONTROL], [KMKONTROL], [MALZEMEFOTO], [KAYITTIPIID], [SAVEUSER], [SAVEDATE], [EDITUSER], [EDITDATE], [SAVEMAC], [EDITMAC], [SAVEIP], [EDITIP], [GIRIS], [CIKIS], [KALAN]) VALUES (@KOD, @UFKOD, @OEMKOD, @MALZEMEADI, @DIGERADI, @KULLANIMYERI, @BIRIMID, @GRUPID, @GRUPID2, @KDVID, @BOLUMID, @RAFNO, @GOZNO, @BARKOD, @TARIHKONTROL, @SERINOKONTROL, @KMKONTROL, @MALZEMEFOTO, @KAYITTIPIID, @SAVEUSER, @SAVEDATE, @EDITUSER, @EDITDATE, @SAVEMAC, @EDITMAC, @SAVEIP, @EDITIP, @GIRIS, @CIKIS, @KALAN);\r\nSELECT ID, KOD, UFKOD, OEMKOD, MALZEMEADI, DIGERADI, KULLANIMYERI, BIRIMID, GRUPID, GRUPID2, KDVID, BOLUMID, RAFNO, GOZNO, BARKOD, TARIHKONTROL, SERINOKONTROL, KMKONTROL, MALZEMEFOTO, KAYITTIPIID, SAVEUSER, SAVEDATE, EDITUSER, EDITDATE, SAVEMAC, EDITMAC, SAVEIP, EDITIP, GIRIS, CIKIS, KALAN FROM TBLMALZEMELER WHERE (ID = SCOPE_IDENTITY())";
      this._adapter.InsertCommand.CommandType = CommandType.Text;
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@KOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@UFKOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "UFKOD", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@OEMKOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "OEMKOD", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@MALZEMEADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZEMEADI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@DIGERADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DIGERADI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@KULLANIMYERI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KULLANIMYERI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@BIRIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BIRIMID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@GRUPID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GRUPID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@GRUPID2", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GRUPID2", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@KDVID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KDVID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@BOLUMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BOLUMID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@RAFNO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RAFNO", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@GOZNO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOZNO", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@BARKOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BARKOD", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@TARIHKONTROL", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TARIHKONTROL", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SERINOKONTROL", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SERINOKONTROL", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@KMKONTROL", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KMKONTROL", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@MALZEMEFOTO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZEMEFOTO", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@KAYITTIPIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KAYITTIPIID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SAVEUSER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEUSER", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SAVEDATE", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEDATE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@EDITUSER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITUSER", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@EDITDATE", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITDATE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SAVEMAC", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEMAC", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@EDITMAC", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITMAC", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SAVEIP", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEIP", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@EDITIP", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITIP", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@GIRIS", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "GIRIS", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@CIKIS", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "CIKIS", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@KALAN", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "KALAN", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand = new SqlCommand();
      this._adapter.UpdateCommand.Connection = this.Connection;
      this._adapter.UpdateCommand.CommandText = "UPDATE [dbo].[TBLMALZEMELER] SET [KOD] = @KOD, [UFKOD] = @UFKOD, [OEMKOD] = @OEMKOD, [MALZEMEADI] = @MALZEMEADI, [DIGERADI] = @DIGERADI, [KULLANIMYERI] = @KULLANIMYERI, [BIRIMID] = @BIRIMID, [GRUPID] = @GRUPID, [GRUPID2] = @GRUPID2, [KDVID] = @KDVID, [BOLUMID] = @BOLUMID, [RAFNO] = @RAFNO, [GOZNO] = @GOZNO, [BARKOD] = @BARKOD, [TARIHKONTROL] = @TARIHKONTROL, [SERINOKONTROL] = @SERINOKONTROL, [KMKONTROL] = @KMKONTROL, [MALZEMEFOTO] = @MALZEMEFOTO, [KAYITTIPIID] = @KAYITTIPIID, [SAVEUSER] = @SAVEUSER, [SAVEDATE] = @SAVEDATE, [EDITUSER] = @EDITUSER, [EDITDATE] = @EDITDATE, [SAVEMAC] = @SAVEMAC, [EDITMAC] = @EDITMAC, [SAVEIP] = @SAVEIP, [EDITIP] = @EDITIP, [GIRIS] = @GIRIS, [CIKIS] = @CIKIS, [KALAN] = @KALAN WHERE (([ID] = @Original_ID) AND ((@IsNull_KOD = 1 AND [KOD] IS NULL) OR ([KOD] = @Original_KOD)) AND ((@IsNull_UFKOD = 1 AND [UFKOD] IS NULL) OR ([UFKOD] = @Original_UFKOD)) AND ((@IsNull_OEMKOD = 1 AND [OEMKOD] IS NULL) OR ([OEMKOD] = @Original_OEMKOD)) AND ((@IsNull_MALZEMEADI = 1 AND [MALZEMEADI] IS NULL) OR ([MALZEMEADI] = @Original_MALZEMEADI)) AND ((@IsNull_DIGERADI = 1 AND [DIGERADI] IS NULL) OR ([DIGERADI] = @Original_DIGERADI)) AND ((@IsNull_KULLANIMYERI = 1 AND [KULLANIMYERI] IS NULL) OR ([KULLANIMYERI] = @Original_KULLANIMYERI)) AND ((@IsNull_BIRIMID = 1 AND [BIRIMID] IS NULL) OR ([BIRIMID] = @Original_BIRIMID)) AND ((@IsNull_GRUPID = 1 AND [GRUPID] IS NULL) OR ([GRUPID] = @Original_GRUPID)) AND ((@IsNull_GRUPID2 = 1 AND [GRUPID2] IS NULL) OR ([GRUPID2] = @Original_GRUPID2)) AND ((@IsNull_KDVID = 1 AND [KDVID] IS NULL) OR ([KDVID] = @Original_KDVID)) AND ((@IsNull_BOLUMID = 1 AND [BOLUMID] IS NULL) OR ([BOLUMID] = @Original_BOLUMID)) AND ((@IsNull_RAFNO = 1 AND [RAFNO] IS NULL) OR ([RAFNO] = @Original_RAFNO)) AND ((@IsNull_GOZNO = 1 AND [GOZNO] IS NULL) OR ([GOZNO] = @Original_GOZNO)) AND ((@IsNull_BARKOD = 1 AND [BARKOD] IS NULL) OR ([BARKOD] = @Original_BARKOD)) AND ((@IsNull_TARIHKONTROL = 1 AND [TARIHKONTROL] IS NULL) OR ([TARIHKONTROL] = @Original_TARIHKONTROL)) AND ((@IsNull_SERINOKONTROL = 1 AND [SERINOKONTROL] IS NULL) OR ([SERINOKONTROL] = @Original_SERINOKONTROL)) AND ((@IsNull_KMKONTROL = 1 AND [KMKONTROL] IS NULL) OR ([KMKONTROL] = @Original_KMKONTROL)) AND ((@IsNull_MALZEMEFOTO = 1 AND [MALZEMEFOTO] IS NULL) OR ([MALZEMEFOTO] = @Original_MALZEMEFOTO)) AND ((@IsNull_KAYITTIPIID = 1 AND [KAYITTIPIID] IS NULL) OR ([KAYITTIPIID] = @Original_KAYITTIPIID)) AND ((@IsNull_SAVEUSER = 1 AND [SAVEUSER] IS NULL) OR ([SAVEUSER] = @Original_SAVEUSER)) AND ((@IsNull_SAVEDATE = 1 AND [SAVEDATE] IS NULL) OR ([SAVEDATE] = @Original_SAVEDATE)) AND ((@IsNull_EDITUSER = 1 AND [EDITUSER] IS NULL) OR ([EDITUSER] = @Original_EDITUSER)) AND ((@IsNull_EDITDATE = 1 AND [EDITDATE] IS NULL) OR ([EDITDATE] = @Original_EDITDATE)) AND ((@IsNull_SAVEMAC = 1 AND [SAVEMAC] IS NULL) OR ([SAVEMAC] = @Original_SAVEMAC)) AND ((@IsNull_EDITMAC = 1 AND [EDITMAC] IS NULL) OR ([EDITMAC] = @Original_EDITMAC)) AND ((@IsNull_SAVEIP = 1 AND [SAVEIP] IS NULL) OR ([SAVEIP] = @Original_SAVEIP)) AND ((@IsNull_EDITIP = 1 AND [EDITIP] IS NULL) OR ([EDITIP] = @Original_EDITIP)) AND ((@IsNull_GIRIS = 1 AND [GIRIS] IS NULL) OR ([GIRIS] = @Original_GIRIS)) AND ((@IsNull_CIKIS = 1 AND [CIKIS] IS NULL) OR ([CIKIS] = @Original_CIKIS)) AND ((@IsNull_KALAN = 1 AND [KALAN] IS NULL) OR ([KALAN] = @Original_KALAN)));\r\nSELECT ID, KOD, UFKOD, OEMKOD, MALZEMEADI, DIGERADI, KULLANIMYERI, BIRIMID, GRUPID, GRUPID2, KDVID, BOLUMID, RAFNO, GOZNO, BARKOD, TARIHKONTROL, SERINOKONTROL, KMKONTROL, MALZEMEFOTO, KAYITTIPIID, SAVEUSER, SAVEDATE, EDITUSER, EDITDATE, SAVEMAC, EDITMAC, SAVEIP, EDITIP, GIRIS, CIKIS, KALAN FROM TBLMALZEMELER WHERE (ID = @ID)";
      this._adapter.UpdateCommand.CommandType = CommandType.Text;
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@KOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@UFKOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "UFKOD", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@OEMKOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "OEMKOD", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MALZEMEADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZEMEADI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@DIGERADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DIGERADI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@KULLANIMYERI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KULLANIMYERI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@BIRIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BIRIMID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@GRUPID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GRUPID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@GRUPID2", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GRUPID2", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@KDVID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KDVID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@BOLUMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BOLUMID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@RAFNO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RAFNO", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@GOZNO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOZNO", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@BARKOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BARKOD", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TARIHKONTROL", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TARIHKONTROL", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SERINOKONTROL", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SERINOKONTROL", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@KMKONTROL", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KMKONTROL", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MALZEMEFOTO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZEMEFOTO", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@KAYITTIPIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KAYITTIPIID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SAVEUSER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEUSER", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SAVEDATE", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEDATE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EDITUSER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITUSER", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EDITDATE", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITDATE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SAVEMAC", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEMAC", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EDITMAC", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITMAC", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SAVEIP", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEIP", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EDITIP", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITIP", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@GIRIS", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "GIRIS", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@CIKIS", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "CIKIS", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@KALAN", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "KALAN", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_KOD", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_KOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_UFKOD", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "UFKOD", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_UFKOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "UFKOD", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_OEMKOD", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "OEMKOD", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_OEMKOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "OEMKOD", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_MALZEMEADI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZEMEADI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_MALZEMEADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZEMEADI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_DIGERADI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DIGERADI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_DIGERADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DIGERADI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_KULLANIMYERI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KULLANIMYERI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_KULLANIMYERI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KULLANIMYERI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_BIRIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BIRIMID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_BIRIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BIRIMID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_GRUPID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GRUPID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_GRUPID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GRUPID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_GRUPID2", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GRUPID2", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_GRUPID2", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GRUPID2", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_KDVID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KDVID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_KDVID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KDVID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_BOLUMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BOLUMID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_BOLUMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BOLUMID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_RAFNO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RAFNO", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_RAFNO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RAFNO", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_GOZNO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOZNO", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_GOZNO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOZNO", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_BARKOD", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BARKOD", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_BARKOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BARKOD", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TARIHKONTROL", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TARIHKONTROL", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TARIHKONTROL", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TARIHKONTROL", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SERINOKONTROL", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SERINOKONTROL", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SERINOKONTROL", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SERINOKONTROL", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_KMKONTROL", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KMKONTROL", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_KMKONTROL", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KMKONTROL", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_MALZEMEFOTO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZEMEFOTO", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_MALZEMEFOTO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZEMEFOTO", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_KAYITTIPIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KAYITTIPIID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_KAYITTIPIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KAYITTIPIID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SAVEUSER", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEUSER", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SAVEUSER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEUSER", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SAVEDATE", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEDATE", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SAVEDATE", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEDATE", DataRowVersion.Original, false, (object) null, "", "", ""));
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
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_GIRIS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GIRIS", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_GIRIS", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "GIRIS", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_CIKIS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKIS", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_CIKIS", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "CIKIS", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_KALAN", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KALAN", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_KALAN", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "KALAN", DataRowVersion.Original, false, (object) null, "", "", ""));
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
      this._commandCollection[0].CommandText = "SELECT ID, KOD, UFKOD, OEMKOD, MALZEMEADI, DIGERADI, KULLANIMYERI, BIRIMID, GRUPID, GRUPID2, KDVID, BOLUMID, RAFNO, GOZNO, BARKOD, TARIHKONTROL, SERINOKONTROL, KMKONTROL, MALZEMEFOTO, KAYITTIPIID, SAVEUSER, SAVEDATE, EDITUSER, EDITDATE, SAVEMAC, EDITMAC, SAVEIP, EDITIP, GIRIS, CIKIS, KALAN FROM dbo.TBLMALZEMELER";
      this._commandCollection[0].CommandType = CommandType.Text;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    public virtual int Fill(bellDataSet1.TBLMALZEMELERDataTable dataTable)
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
    public virtual bellDataSet1.TBLMALZEMELERDataTable GetData()
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      bellDataSet1.TBLMALZEMELERDataTable data = new bellDataSet1.TBLMALZEMELERDataTable();
      this.Adapter.Fill((DataTable) data);
      return data;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(bellDataSet1.TBLMALZEMELERDataTable dataTable) => this.Adapter.Update((DataTable) dataTable);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(bellDataSet1 dataSet) => this.Adapter.Update((DataSet) dataSet, "TBLMALZEMELER");

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
      string Original_UFKOD,
      string Original_OEMKOD,
      string Original_MALZEMEADI,
      string Original_DIGERADI,
      string Original_KULLANIMYERI,
      int? Original_BIRIMID,
      int? Original_GRUPID,
      int? Original_GRUPID2,
      int? Original_KDVID,
      int? Original_BOLUMID,
      string Original_RAFNO,
      string Original_GOZNO,
      string Original_BARKOD,
      string Original_TARIHKONTROL,
      string Original_SERINOKONTROL,
      string Original_KMKONTROL,
      string Original_MALZEMEFOTO,
      int? Original_KAYITTIPIID,
      string Original_SAVEUSER,
      string Original_SAVEDATE,
      string Original_EDITUSER,
      DateTime? Original_EDITDATE,
      string Original_SAVEMAC,
      string Original_EDITMAC,
      string Original_SAVEIP,
      string Original_EDITIP,
      Decimal? Original_GIRIS,
      Decimal? Original_CIKIS,
      Decimal? Original_KALAN)
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
      if (Original_UFKOD == null)
      {
        this.Adapter.DeleteCommand.Parameters[3].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[4].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[3].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[4].Value = (object) Original_UFKOD;
      }
      if (Original_OEMKOD == null)
      {
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[6].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[6].Value = (object) Original_OEMKOD;
      }
      if (Original_MALZEMEADI == null)
      {
        this.Adapter.DeleteCommand.Parameters[7].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[8].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[7].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[8].Value = (object) Original_MALZEMEADI;
      }
      if (Original_DIGERADI == null)
      {
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) Original_DIGERADI;
      }
      if (Original_KULLANIMYERI == null)
      {
        this.Adapter.DeleteCommand.Parameters[11].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[12].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[11].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[12].Value = (object) Original_KULLANIMYERI;
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
      if (Original_GRUPID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[15].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[16].Value = (object) Original_GRUPID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[15].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[16].Value = (object) DBNull.Value;
      }
      if (Original_GRUPID2.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[17].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[18].Value = (object) Original_GRUPID2.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[17].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[18].Value = (object) DBNull.Value;
      }
      if (Original_KDVID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[19].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[20].Value = (object) Original_KDVID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[19].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[20].Value = (object) DBNull.Value;
      }
      if (Original_BOLUMID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[21].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[22].Value = (object) Original_BOLUMID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[21].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[22].Value = (object) DBNull.Value;
      }
      if (Original_RAFNO == null)
      {
        this.Adapter.DeleteCommand.Parameters[23].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[24].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[23].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[24].Value = (object) Original_RAFNO;
      }
      if (Original_GOZNO == null)
      {
        this.Adapter.DeleteCommand.Parameters[25].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[26].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[25].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[26].Value = (object) Original_GOZNO;
      }
      if (Original_BARKOD == null)
      {
        this.Adapter.DeleteCommand.Parameters[27].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[28].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[27].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[28].Value = (object) Original_BARKOD;
      }
      if (Original_TARIHKONTROL == null)
      {
        this.Adapter.DeleteCommand.Parameters[29].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[30].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[29].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[30].Value = (object) Original_TARIHKONTROL;
      }
      if (Original_SERINOKONTROL == null)
      {
        this.Adapter.DeleteCommand.Parameters[31].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[32].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[31].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[32].Value = (object) Original_SERINOKONTROL;
      }
      if (Original_KMKONTROL == null)
      {
        this.Adapter.DeleteCommand.Parameters[33].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[34].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[33].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[34].Value = (object) Original_KMKONTROL;
      }
      if (Original_MALZEMEFOTO == null)
      {
        this.Adapter.DeleteCommand.Parameters[35].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[36].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[35].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[36].Value = (object) Original_MALZEMEFOTO;
      }
      if (Original_KAYITTIPIID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[37].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[38].Value = (object) Original_KAYITTIPIID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[37].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[38].Value = (object) DBNull.Value;
      }
      if (Original_SAVEUSER == null)
      {
        this.Adapter.DeleteCommand.Parameters[39].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[40].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[39].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[40].Value = (object) Original_SAVEUSER;
      }
      if (Original_SAVEDATE == null)
      {
        this.Adapter.DeleteCommand.Parameters[41].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[42].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[41].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[42].Value = (object) Original_SAVEDATE;
      }
      if (Original_EDITUSER == null)
      {
        this.Adapter.DeleteCommand.Parameters[43].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[44].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[43].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[44].Value = (object) Original_EDITUSER;
      }
      if (Original_EDITDATE.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[45].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[46].Value = (object) Original_EDITDATE.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[45].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[46].Value = (object) DBNull.Value;
      }
      if (Original_SAVEMAC == null)
      {
        this.Adapter.DeleteCommand.Parameters[47].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[48].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[47].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[48].Value = (object) Original_SAVEMAC;
      }
      if (Original_EDITMAC == null)
      {
        this.Adapter.DeleteCommand.Parameters[49].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[50].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[49].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[50].Value = (object) Original_EDITMAC;
      }
      if (Original_SAVEIP == null)
      {
        this.Adapter.DeleteCommand.Parameters[51].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[52].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[51].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[52].Value = (object) Original_SAVEIP;
      }
      if (Original_EDITIP == null)
      {
        this.Adapter.DeleteCommand.Parameters[53].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[54].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[53].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[54].Value = (object) Original_EDITIP;
      }
      if (Original_GIRIS.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[55].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[56].Value = (object) Original_GIRIS.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[55].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[56].Value = (object) DBNull.Value;
      }
      if (Original_CIKIS.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[57].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[58].Value = (object) Original_CIKIS.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[57].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[58].Value = (object) DBNull.Value;
      }
      if (Original_KALAN.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[59].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[60].Value = (object) Original_KALAN.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[59].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[60].Value = (object) DBNull.Value;
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
      string UFKOD,
      string OEMKOD,
      string MALZEMEADI,
      string DIGERADI,
      string KULLANIMYERI,
      int? BIRIMID,
      int? GRUPID,
      int? GRUPID2,
      int? KDVID,
      int? BOLUMID,
      string RAFNO,
      string GOZNO,
      string BARKOD,
      string TARIHKONTROL,
      string SERINOKONTROL,
      string KMKONTROL,
      string MALZEMEFOTO,
      int? KAYITTIPIID,
      string SAVEUSER,
      string SAVEDATE,
      string EDITUSER,
      DateTime? EDITDATE,
      string SAVEMAC,
      string EDITMAC,
      string SAVEIP,
      string EDITIP,
      Decimal? GIRIS,
      Decimal? CIKIS,
      Decimal? KALAN)
    {
      if (KOD == null)
        this.Adapter.InsertCommand.Parameters[0].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[0].Value = (object) KOD;
      if (UFKOD == null)
        this.Adapter.InsertCommand.Parameters[1].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[1].Value = (object) UFKOD;
      if (OEMKOD == null)
        this.Adapter.InsertCommand.Parameters[2].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[2].Value = (object) OEMKOD;
      if (MALZEMEADI == null)
        this.Adapter.InsertCommand.Parameters[3].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[3].Value = (object) MALZEMEADI;
      if (DIGERADI == null)
        this.Adapter.InsertCommand.Parameters[4].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[4].Value = (object) DIGERADI;
      if (KULLANIMYERI == null)
        this.Adapter.InsertCommand.Parameters[5].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[5].Value = (object) KULLANIMYERI;
      if (BIRIMID.HasValue)
        this.Adapter.InsertCommand.Parameters[6].Value = (object) BIRIMID.Value;
      else
        this.Adapter.InsertCommand.Parameters[6].Value = (object) DBNull.Value;
      if (GRUPID.HasValue)
        this.Adapter.InsertCommand.Parameters[7].Value = (object) GRUPID.Value;
      else
        this.Adapter.InsertCommand.Parameters[7].Value = (object) DBNull.Value;
      if (GRUPID2.HasValue)
        this.Adapter.InsertCommand.Parameters[8].Value = (object) GRUPID2.Value;
      else
        this.Adapter.InsertCommand.Parameters[8].Value = (object) DBNull.Value;
      if (KDVID.HasValue)
        this.Adapter.InsertCommand.Parameters[9].Value = (object) KDVID.Value;
      else
        this.Adapter.InsertCommand.Parameters[9].Value = (object) DBNull.Value;
      if (BOLUMID.HasValue)
        this.Adapter.InsertCommand.Parameters[10].Value = (object) BOLUMID.Value;
      else
        this.Adapter.InsertCommand.Parameters[10].Value = (object) DBNull.Value;
      if (RAFNO == null)
        this.Adapter.InsertCommand.Parameters[11].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[11].Value = (object) RAFNO;
      if (GOZNO == null)
        this.Adapter.InsertCommand.Parameters[12].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[12].Value = (object) GOZNO;
      if (BARKOD == null)
        this.Adapter.InsertCommand.Parameters[13].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[13].Value = (object) BARKOD;
      if (TARIHKONTROL == null)
        this.Adapter.InsertCommand.Parameters[14].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[14].Value = (object) TARIHKONTROL;
      if (SERINOKONTROL == null)
        this.Adapter.InsertCommand.Parameters[15].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[15].Value = (object) SERINOKONTROL;
      if (KMKONTROL == null)
        this.Adapter.InsertCommand.Parameters[16].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[16].Value = (object) KMKONTROL;
      if (MALZEMEFOTO == null)
        this.Adapter.InsertCommand.Parameters[17].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[17].Value = (object) MALZEMEFOTO;
      if (KAYITTIPIID.HasValue)
        this.Adapter.InsertCommand.Parameters[18].Value = (object) KAYITTIPIID.Value;
      else
        this.Adapter.InsertCommand.Parameters[18].Value = (object) DBNull.Value;
      if (SAVEUSER == null)
        this.Adapter.InsertCommand.Parameters[19].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[19].Value = (object) SAVEUSER;
      if (SAVEDATE == null)
        this.Adapter.InsertCommand.Parameters[20].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[20].Value = (object) SAVEDATE;
      if (EDITUSER == null)
        this.Adapter.InsertCommand.Parameters[21].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[21].Value = (object) EDITUSER;
      if (EDITDATE.HasValue)
        this.Adapter.InsertCommand.Parameters[22].Value = (object) EDITDATE.Value;
      else
        this.Adapter.InsertCommand.Parameters[22].Value = (object) DBNull.Value;
      if (SAVEMAC == null)
        this.Adapter.InsertCommand.Parameters[23].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[23].Value = (object) SAVEMAC;
      if (EDITMAC == null)
        this.Adapter.InsertCommand.Parameters[24].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[24].Value = (object) EDITMAC;
      if (SAVEIP == null)
        this.Adapter.InsertCommand.Parameters[25].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[25].Value = (object) SAVEIP;
      if (EDITIP == null)
        this.Adapter.InsertCommand.Parameters[26].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[26].Value = (object) EDITIP;
      if (GIRIS.HasValue)
        this.Adapter.InsertCommand.Parameters[27].Value = (object) GIRIS.Value;
      else
        this.Adapter.InsertCommand.Parameters[27].Value = (object) DBNull.Value;
      if (CIKIS.HasValue)
        this.Adapter.InsertCommand.Parameters[28].Value = (object) CIKIS.Value;
      else
        this.Adapter.InsertCommand.Parameters[28].Value = (object) DBNull.Value;
      if (KALAN.HasValue)
        this.Adapter.InsertCommand.Parameters[29].Value = (object) KALAN.Value;
      else
        this.Adapter.InsertCommand.Parameters[29].Value = (object) DBNull.Value;
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
      string UFKOD,
      string OEMKOD,
      string MALZEMEADI,
      string DIGERADI,
      string KULLANIMYERI,
      int? BIRIMID,
      int? GRUPID,
      int? GRUPID2,
      int? KDVID,
      int? BOLUMID,
      string RAFNO,
      string GOZNO,
      string BARKOD,
      string TARIHKONTROL,
      string SERINOKONTROL,
      string KMKONTROL,
      string MALZEMEFOTO,
      int? KAYITTIPIID,
      string SAVEUSER,
      string SAVEDATE,
      string EDITUSER,
      DateTime? EDITDATE,
      string SAVEMAC,
      string EDITMAC,
      string SAVEIP,
      string EDITIP,
      Decimal? GIRIS,
      Decimal? CIKIS,
      Decimal? KALAN,
      int Original_ID,
      string Original_KOD,
      string Original_UFKOD,
      string Original_OEMKOD,
      string Original_MALZEMEADI,
      string Original_DIGERADI,
      string Original_KULLANIMYERI,
      int? Original_BIRIMID,
      int? Original_GRUPID,
      int? Original_GRUPID2,
      int? Original_KDVID,
      int? Original_BOLUMID,
      string Original_RAFNO,
      string Original_GOZNO,
      string Original_BARKOD,
      string Original_TARIHKONTROL,
      string Original_SERINOKONTROL,
      string Original_KMKONTROL,
      string Original_MALZEMEFOTO,
      int? Original_KAYITTIPIID,
      string Original_SAVEUSER,
      string Original_SAVEDATE,
      string Original_EDITUSER,
      DateTime? Original_EDITDATE,
      string Original_SAVEMAC,
      string Original_EDITMAC,
      string Original_SAVEIP,
      string Original_EDITIP,
      Decimal? Original_GIRIS,
      Decimal? Original_CIKIS,
      Decimal? Original_KALAN,
      int ID)
    {
      if (KOD == null)
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) KOD;
      if (UFKOD == null)
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) UFKOD;
      if (OEMKOD == null)
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) OEMKOD;
      if (MALZEMEADI == null)
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) MALZEMEADI;
      if (DIGERADI == null)
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) DIGERADI;
      if (KULLANIMYERI == null)
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) KULLANIMYERI;
      if (BIRIMID.HasValue)
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) BIRIMID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) DBNull.Value;
      if (GRUPID.HasValue)
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) GRUPID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) DBNull.Value;
      if (GRUPID2.HasValue)
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) GRUPID2.Value;
      else
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) DBNull.Value;
      if (KDVID.HasValue)
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) KDVID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) DBNull.Value;
      if (BOLUMID.HasValue)
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) BOLUMID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) DBNull.Value;
      if (RAFNO == null)
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) RAFNO;
      if (GOZNO == null)
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) GOZNO;
      if (BARKOD == null)
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) BARKOD;
      if (TARIHKONTROL == null)
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) TARIHKONTROL;
      if (SERINOKONTROL == null)
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) SERINOKONTROL;
      if (KMKONTROL == null)
        this.Adapter.UpdateCommand.Parameters[16].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[16].Value = (object) KMKONTROL;
      if (MALZEMEFOTO == null)
        this.Adapter.UpdateCommand.Parameters[17].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[17].Value = (object) MALZEMEFOTO;
      if (KAYITTIPIID.HasValue)
        this.Adapter.UpdateCommand.Parameters[18].Value = (object) KAYITTIPIID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[18].Value = (object) DBNull.Value;
      if (SAVEUSER == null)
        this.Adapter.UpdateCommand.Parameters[19].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[19].Value = (object) SAVEUSER;
      if (SAVEDATE == null)
        this.Adapter.UpdateCommand.Parameters[20].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[20].Value = (object) SAVEDATE;
      if (EDITUSER == null)
        this.Adapter.UpdateCommand.Parameters[21].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[21].Value = (object) EDITUSER;
      if (EDITDATE.HasValue)
        this.Adapter.UpdateCommand.Parameters[22].Value = (object) EDITDATE.Value;
      else
        this.Adapter.UpdateCommand.Parameters[22].Value = (object) DBNull.Value;
      if (SAVEMAC == null)
        this.Adapter.UpdateCommand.Parameters[23].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[23].Value = (object) SAVEMAC;
      if (EDITMAC == null)
        this.Adapter.UpdateCommand.Parameters[24].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[24].Value = (object) EDITMAC;
      if (SAVEIP == null)
        this.Adapter.UpdateCommand.Parameters[25].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[25].Value = (object) SAVEIP;
      if (EDITIP == null)
        this.Adapter.UpdateCommand.Parameters[26].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[26].Value = (object) EDITIP;
      if (GIRIS.HasValue)
        this.Adapter.UpdateCommand.Parameters[27].Value = (object) GIRIS.Value;
      else
        this.Adapter.UpdateCommand.Parameters[27].Value = (object) DBNull.Value;
      if (CIKIS.HasValue)
        this.Adapter.UpdateCommand.Parameters[28].Value = (object) CIKIS.Value;
      else
        this.Adapter.UpdateCommand.Parameters[28].Value = (object) DBNull.Value;
      if (KALAN.HasValue)
        this.Adapter.UpdateCommand.Parameters[29].Value = (object) KALAN.Value;
      else
        this.Adapter.UpdateCommand.Parameters[29].Value = (object) DBNull.Value;
      this.Adapter.UpdateCommand.Parameters[30].Value = (object) Original_ID;
      if (Original_KOD == null)
      {
        this.Adapter.UpdateCommand.Parameters[31].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[32].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[31].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[32].Value = (object) Original_KOD;
      }
      if (Original_UFKOD == null)
      {
        this.Adapter.UpdateCommand.Parameters[33].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[34].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[33].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[34].Value = (object) Original_UFKOD;
      }
      if (Original_OEMKOD == null)
      {
        this.Adapter.UpdateCommand.Parameters[35].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[36].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[35].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[36].Value = (object) Original_OEMKOD;
      }
      if (Original_MALZEMEADI == null)
      {
        this.Adapter.UpdateCommand.Parameters[37].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[38].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[37].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[38].Value = (object) Original_MALZEMEADI;
      }
      if (Original_DIGERADI == null)
      {
        this.Adapter.UpdateCommand.Parameters[39].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[40].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[39].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[40].Value = (object) Original_DIGERADI;
      }
      if (Original_KULLANIMYERI == null)
      {
        this.Adapter.UpdateCommand.Parameters[41].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[42].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[41].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[42].Value = (object) Original_KULLANIMYERI;
      }
      if (Original_BIRIMID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[43].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[44].Value = (object) Original_BIRIMID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[43].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[44].Value = (object) DBNull.Value;
      }
      if (Original_GRUPID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[45].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[46].Value = (object) Original_GRUPID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[45].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[46].Value = (object) DBNull.Value;
      }
      if (Original_GRUPID2.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[47].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[48].Value = (object) Original_GRUPID2.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[47].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[48].Value = (object) DBNull.Value;
      }
      if (Original_KDVID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[49].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[50].Value = (object) Original_KDVID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[49].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[50].Value = (object) DBNull.Value;
      }
      if (Original_BOLUMID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[51].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[52].Value = (object) Original_BOLUMID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[51].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[52].Value = (object) DBNull.Value;
      }
      if (Original_RAFNO == null)
      {
        this.Adapter.UpdateCommand.Parameters[53].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[54].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[53].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[54].Value = (object) Original_RAFNO;
      }
      if (Original_GOZNO == null)
      {
        this.Adapter.UpdateCommand.Parameters[55].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[56].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[55].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[56].Value = (object) Original_GOZNO;
      }
      if (Original_BARKOD == null)
      {
        this.Adapter.UpdateCommand.Parameters[57].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[58].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[57].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[58].Value = (object) Original_BARKOD;
      }
      if (Original_TARIHKONTROL == null)
      {
        this.Adapter.UpdateCommand.Parameters[59].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[60].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[59].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[60].Value = (object) Original_TARIHKONTROL;
      }
      if (Original_SERINOKONTROL == null)
      {
        this.Adapter.UpdateCommand.Parameters[61].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[62].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[61].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[62].Value = (object) Original_SERINOKONTROL;
      }
      if (Original_KMKONTROL == null)
      {
        this.Adapter.UpdateCommand.Parameters[63].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[64].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[63].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[64].Value = (object) Original_KMKONTROL;
      }
      if (Original_MALZEMEFOTO == null)
      {
        this.Adapter.UpdateCommand.Parameters[65].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[66].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[65].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[66].Value = (object) Original_MALZEMEFOTO;
      }
      if (Original_KAYITTIPIID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[67].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[68].Value = (object) Original_KAYITTIPIID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[67].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[68].Value = (object) DBNull.Value;
      }
      if (Original_SAVEUSER == null)
      {
        this.Adapter.UpdateCommand.Parameters[69].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[70].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[69].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[70].Value = (object) Original_SAVEUSER;
      }
      if (Original_SAVEDATE == null)
      {
        this.Adapter.UpdateCommand.Parameters[71].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[72].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[71].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[72].Value = (object) Original_SAVEDATE;
      }
      if (Original_EDITUSER == null)
      {
        this.Adapter.UpdateCommand.Parameters[73].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[74].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[73].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[74].Value = (object) Original_EDITUSER;
      }
      if (Original_EDITDATE.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[75].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[76].Value = (object) Original_EDITDATE.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[75].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[76].Value = (object) DBNull.Value;
      }
      if (Original_SAVEMAC == null)
      {
        this.Adapter.UpdateCommand.Parameters[77].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[78].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[77].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[78].Value = (object) Original_SAVEMAC;
      }
      if (Original_EDITMAC == null)
      {
        this.Adapter.UpdateCommand.Parameters[79].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[80].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[79].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[80].Value = (object) Original_EDITMAC;
      }
      if (Original_SAVEIP == null)
      {
        this.Adapter.UpdateCommand.Parameters[81].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[82].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[81].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[82].Value = (object) Original_SAVEIP;
      }
      if (Original_EDITIP == null)
      {
        this.Adapter.UpdateCommand.Parameters[83].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[84].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[83].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[84].Value = (object) Original_EDITIP;
      }
      if (Original_GIRIS.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[85].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[86].Value = (object) Original_GIRIS.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[85].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[86].Value = (object) DBNull.Value;
      }
      if (Original_CIKIS.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[87].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[88].Value = (object) Original_CIKIS.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[87].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[88].Value = (object) DBNull.Value;
      }
      if (Original_KALAN.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[89].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[90].Value = (object) Original_KALAN.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[89].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[90].Value = (object) DBNull.Value;
      }
      this.Adapter.UpdateCommand.Parameters[91].Value = (object) ID;
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
      string UFKOD,
      string OEMKOD,
      string MALZEMEADI,
      string DIGERADI,
      string KULLANIMYERI,
      int? BIRIMID,
      int? GRUPID,
      int? GRUPID2,
      int? KDVID,
      int? BOLUMID,
      string RAFNO,
      string GOZNO,
      string BARKOD,
      string TARIHKONTROL,
      string SERINOKONTROL,
      string KMKONTROL,
      string MALZEMEFOTO,
      int? KAYITTIPIID,
      string SAVEUSER,
      string SAVEDATE,
      string EDITUSER,
      DateTime? EDITDATE,
      string SAVEMAC,
      string EDITMAC,
      string SAVEIP,
      string EDITIP,
      Decimal? GIRIS,
      Decimal? CIKIS,
      Decimal? KALAN,
      int Original_ID,
      string Original_KOD,
      string Original_UFKOD,
      string Original_OEMKOD,
      string Original_MALZEMEADI,
      string Original_DIGERADI,
      string Original_KULLANIMYERI,
      int? Original_BIRIMID,
      int? Original_GRUPID,
      int? Original_GRUPID2,
      int? Original_KDVID,
      int? Original_BOLUMID,
      string Original_RAFNO,
      string Original_GOZNO,
      string Original_BARKOD,
      string Original_TARIHKONTROL,
      string Original_SERINOKONTROL,
      string Original_KMKONTROL,
      string Original_MALZEMEFOTO,
      int? Original_KAYITTIPIID,
      string Original_SAVEUSER,
      string Original_SAVEDATE,
      string Original_EDITUSER,
      DateTime? Original_EDITDATE,
      string Original_SAVEMAC,
      string Original_EDITMAC,
      string Original_SAVEIP,
      string Original_EDITIP,
      Decimal? Original_GIRIS,
      Decimal? Original_CIKIS,
      Decimal? Original_KALAN)
    {
      return this.Update(KOD, UFKOD, OEMKOD, MALZEMEADI, DIGERADI, KULLANIMYERI, BIRIMID, GRUPID, GRUPID2, KDVID, BOLUMID, RAFNO, GOZNO, BARKOD, TARIHKONTROL, SERINOKONTROL, KMKONTROL, MALZEMEFOTO, KAYITTIPIID, SAVEUSER, SAVEDATE, EDITUSER, EDITDATE, SAVEMAC, EDITMAC, SAVEIP, EDITIP, GIRIS, CIKIS, KALAN, Original_ID, Original_KOD, Original_UFKOD, Original_OEMKOD, Original_MALZEMEADI, Original_DIGERADI, Original_KULLANIMYERI, Original_BIRIMID, Original_GRUPID, Original_GRUPID2, Original_KDVID, Original_BOLUMID, Original_RAFNO, Original_GOZNO, Original_BARKOD, Original_TARIHKONTROL, Original_SERINOKONTROL, Original_KMKONTROL, Original_MALZEMEFOTO, Original_KAYITTIPIID, Original_SAVEUSER, Original_SAVEDATE, Original_EDITUSER, Original_EDITDATE, Original_SAVEMAC, Original_EDITMAC, Original_SAVEIP, Original_EDITIP, Original_GIRIS, Original_CIKIS, Original_KALAN, Original_ID);
    }
  }
}
