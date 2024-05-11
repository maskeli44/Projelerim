// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.bellDataSet6TableAdapters.TBLIHALELERTableAdapter
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
  public class TBLIHALELERTableAdapter : Component
  {
    private SqlDataAdapter _adapter;
    private SqlConnection _connection;
    private SqlTransaction _transaction;
    private SqlCommand[] _commandCollection;
    private bool _clearBeforeFill;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public TBLIHALELERTableAdapter() => this.ClearBeforeFill = true;

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
        DataSetTable = "TBLIHALELER",
        ColumnMappings = {
          {
            "ID",
            "ID"
          },
          {
            "IHALEKAYITNO",
            "IHALEKAYITNO"
          },
          {
            "IDARENINADI",
            "IDARENINADI"
          },
          {
            "YUKLENICIADI",
            "YUKLENICIADI"
          },
          {
            "ISINTANIMI",
            "ISINTANIMI"
          },
          {
            "SOZLESMETARIHI",
            "SOZLESMETARIHI"
          },
          {
            "SOZLESMEBEDELI",
            "SOZLESMEBEDELI"
          },
          {
            "ISINSURESI",
            "ISINSURESI"
          },
          {
            "ISBITISTARIHI",
            "ISBITISTARIHI"
          },
          {
            "IHALEDURUM",
            "IHALEDURUM"
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
          }
        }
      });
      this._adapter.DeleteCommand = new SqlCommand();
      this._adapter.DeleteCommand.Connection = this.Connection;
      this._adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[TBLIHALELER] WHERE (([ID] = @Original_ID) AND ((@IsNull_IHALEKAYITNO = 1 AND [IHALEKAYITNO] IS NULL) OR ([IHALEKAYITNO] = @Original_IHALEKAYITNO)) AND ((@IsNull_IDARENINADI = 1 AND [IDARENINADI] IS NULL) OR ([IDARENINADI] = @Original_IDARENINADI)) AND ((@IsNull_YUKLENICIADI = 1 AND [YUKLENICIADI] IS NULL) OR ([YUKLENICIADI] = @Original_YUKLENICIADI)) AND ((@IsNull_ISINTANIMI = 1 AND [ISINTANIMI] IS NULL) OR ([ISINTANIMI] = @Original_ISINTANIMI)) AND ((@IsNull_SOZLESMETARIHI = 1 AND [SOZLESMETARIHI] IS NULL) OR ([SOZLESMETARIHI] = @Original_SOZLESMETARIHI)) AND ((@IsNull_SOZLESMEBEDELI = 1 AND [SOZLESMEBEDELI] IS NULL) OR ([SOZLESMEBEDELI] = @Original_SOZLESMEBEDELI)) AND ((@IsNull_ISINSURESI = 1 AND [ISINSURESI] IS NULL) OR ([ISINSURESI] = @Original_ISINSURESI)) AND ((@IsNull_ISBITISTARIHI = 1 AND [ISBITISTARIHI] IS NULL) OR ([ISBITISTARIHI] = @Original_ISBITISTARIHI)) AND ((@IsNull_IHALEDURUM = 1 AND [IHALEDURUM] IS NULL) OR ([IHALEDURUM] = @Original_IHALEDURUM)) AND ((@IsNull_SAVEUSER = 1 AND [SAVEUSER] IS NULL) OR ([SAVEUSER] = @Original_SAVEUSER)) AND ((@IsNull_SAVEDATE = 1 AND [SAVEDATE] IS NULL) OR ([SAVEDATE] = @Original_SAVEDATE)) AND ((@IsNull_EDITUSER = 1 AND [EDITUSER] IS NULL) OR ([EDITUSER] = @Original_EDITUSER)) AND ((@IsNull_EDITDATE = 1 AND [EDITDATE] IS NULL) OR ([EDITDATE] = @Original_EDITDATE)) AND ((@IsNull_SAVEMAC = 1 AND [SAVEMAC] IS NULL) OR ([SAVEMAC] = @Original_SAVEMAC)) AND ((@IsNull_EDITMAC = 1 AND [EDITMAC] IS NULL) OR ([EDITMAC] = @Original_EDITMAC)) AND ((@IsNull_SAVEIP = 1 AND [SAVEIP] IS NULL) OR ([SAVEIP] = @Original_SAVEIP)) AND ((@IsNull_EDITIP = 1 AND [EDITIP] IS NULL) OR ([EDITIP] = @Original_EDITIP)))";
      this._adapter.DeleteCommand.CommandType = CommandType.Text;
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_IHALEKAYITNO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IHALEKAYITNO", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_IHALEKAYITNO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IHALEKAYITNO", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_IDARENINADI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IDARENINADI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_IDARENINADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IDARENINADI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_YUKLENICIADI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YUKLENICIADI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_YUKLENICIADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YUKLENICIADI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ISINTANIMI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISINTANIMI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ISINTANIMI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISINTANIMI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SOZLESMETARIHI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SOZLESMETARIHI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SOZLESMETARIHI", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SOZLESMETARIHI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SOZLESMEBEDELI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SOZLESMEBEDELI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SOZLESMEBEDELI", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "SOZLESMEBEDELI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ISINSURESI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISINSURESI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ISINSURESI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISINSURESI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ISBITISTARIHI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISBITISTARIHI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ISBITISTARIHI", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISBITISTARIHI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_IHALEDURUM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IHALEDURUM", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_IHALEDURUM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IHALEDURUM", DataRowVersion.Original, false, (object) null, "", "", ""));
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
      this._adapter.InsertCommand = new SqlCommand();
      this._adapter.InsertCommand.Connection = this.Connection;
      this._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[TBLIHALELER] ([IHALEKAYITNO], [IDARENINADI], [YUKLENICIADI], [ISINTANIMI], [SOZLESMETARIHI], [SOZLESMEBEDELI], [ISINSURESI], [ISBITISTARIHI], [IHALEDURUM], [SAVEUSER], [SAVEDATE], [EDITUSER], [EDITDATE], [SAVEMAC], [EDITMAC], [SAVEIP], [EDITIP]) VALUES (@IHALEKAYITNO, @IDARENINADI, @YUKLENICIADI, @ISINTANIMI, @SOZLESMETARIHI, @SOZLESMEBEDELI, @ISINSURESI, @ISBITISTARIHI, @IHALEDURUM, @SAVEUSER, @SAVEDATE, @EDITUSER, @EDITDATE, @SAVEMAC, @EDITMAC, @SAVEIP, @EDITIP);\r\nSELECT ID, IHALEKAYITNO, IDARENINADI, YUKLENICIADI, ISINTANIMI, SOZLESMETARIHI, SOZLESMEBEDELI, ISINSURESI, ISBITISTARIHI, IHALEDURUM, SAVEUSER, SAVEDATE, EDITUSER, EDITDATE, SAVEMAC, EDITMAC, SAVEIP, EDITIP FROM TBLIHALELER WHERE (ID = SCOPE_IDENTITY())";
      this._adapter.InsertCommand.CommandType = CommandType.Text;
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@IHALEKAYITNO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IHALEKAYITNO", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@IDARENINADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IDARENINADI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@YUKLENICIADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YUKLENICIADI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ISINTANIMI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISINTANIMI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SOZLESMETARIHI", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SOZLESMETARIHI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SOZLESMEBEDELI", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "SOZLESMEBEDELI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ISINSURESI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISINSURESI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ISBITISTARIHI", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISBITISTARIHI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@IHALEDURUM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IHALEDURUM", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SAVEUSER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEUSER", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SAVEDATE", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEDATE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@EDITUSER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITUSER", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@EDITDATE", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITDATE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SAVEMAC", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEMAC", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@EDITMAC", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITMAC", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SAVEIP", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEIP", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@EDITIP", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITIP", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand = new SqlCommand();
      this._adapter.UpdateCommand.Connection = this.Connection;
      this._adapter.UpdateCommand.CommandText = "UPDATE [dbo].[TBLIHALELER] SET [IHALEKAYITNO] = @IHALEKAYITNO, [IDARENINADI] = @IDARENINADI, [YUKLENICIADI] = @YUKLENICIADI, [ISINTANIMI] = @ISINTANIMI, [SOZLESMETARIHI] = @SOZLESMETARIHI, [SOZLESMEBEDELI] = @SOZLESMEBEDELI, [ISINSURESI] = @ISINSURESI, [ISBITISTARIHI] = @ISBITISTARIHI, [IHALEDURUM] = @IHALEDURUM, [SAVEUSER] = @SAVEUSER, [SAVEDATE] = @SAVEDATE, [EDITUSER] = @EDITUSER, [EDITDATE] = @EDITDATE, [SAVEMAC] = @SAVEMAC, [EDITMAC] = @EDITMAC, [SAVEIP] = @SAVEIP, [EDITIP] = @EDITIP WHERE (([ID] = @Original_ID) AND ((@IsNull_IHALEKAYITNO = 1 AND [IHALEKAYITNO] IS NULL) OR ([IHALEKAYITNO] = @Original_IHALEKAYITNO)) AND ((@IsNull_IDARENINADI = 1 AND [IDARENINADI] IS NULL) OR ([IDARENINADI] = @Original_IDARENINADI)) AND ((@IsNull_YUKLENICIADI = 1 AND [YUKLENICIADI] IS NULL) OR ([YUKLENICIADI] = @Original_YUKLENICIADI)) AND ((@IsNull_ISINTANIMI = 1 AND [ISINTANIMI] IS NULL) OR ([ISINTANIMI] = @Original_ISINTANIMI)) AND ((@IsNull_SOZLESMETARIHI = 1 AND [SOZLESMETARIHI] IS NULL) OR ([SOZLESMETARIHI] = @Original_SOZLESMETARIHI)) AND ((@IsNull_SOZLESMEBEDELI = 1 AND [SOZLESMEBEDELI] IS NULL) OR ([SOZLESMEBEDELI] = @Original_SOZLESMEBEDELI)) AND ((@IsNull_ISINSURESI = 1 AND [ISINSURESI] IS NULL) OR ([ISINSURESI] = @Original_ISINSURESI)) AND ((@IsNull_ISBITISTARIHI = 1 AND [ISBITISTARIHI] IS NULL) OR ([ISBITISTARIHI] = @Original_ISBITISTARIHI)) AND ((@IsNull_IHALEDURUM = 1 AND [IHALEDURUM] IS NULL) OR ([IHALEDURUM] = @Original_IHALEDURUM)) AND ((@IsNull_SAVEUSER = 1 AND [SAVEUSER] IS NULL) OR ([SAVEUSER] = @Original_SAVEUSER)) AND ((@IsNull_SAVEDATE = 1 AND [SAVEDATE] IS NULL) OR ([SAVEDATE] = @Original_SAVEDATE)) AND ((@IsNull_EDITUSER = 1 AND [EDITUSER] IS NULL) OR ([EDITUSER] = @Original_EDITUSER)) AND ((@IsNull_EDITDATE = 1 AND [EDITDATE] IS NULL) OR ([EDITDATE] = @Original_EDITDATE)) AND ((@IsNull_SAVEMAC = 1 AND [SAVEMAC] IS NULL) OR ([SAVEMAC] = @Original_SAVEMAC)) AND ((@IsNull_EDITMAC = 1 AND [EDITMAC] IS NULL) OR ([EDITMAC] = @Original_EDITMAC)) AND ((@IsNull_SAVEIP = 1 AND [SAVEIP] IS NULL) OR ([SAVEIP] = @Original_SAVEIP)) AND ((@IsNull_EDITIP = 1 AND [EDITIP] IS NULL) OR ([EDITIP] = @Original_EDITIP)));\r\nSELECT ID, IHALEKAYITNO, IDARENINADI, YUKLENICIADI, ISINTANIMI, SOZLESMETARIHI, SOZLESMEBEDELI, ISINSURESI, ISBITISTARIHI, IHALEDURUM, SAVEUSER, SAVEDATE, EDITUSER, EDITDATE, SAVEMAC, EDITMAC, SAVEIP, EDITIP FROM TBLIHALELER WHERE (ID = @ID)";
      this._adapter.UpdateCommand.CommandType = CommandType.Text;
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IHALEKAYITNO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IHALEKAYITNO", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IDARENINADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IDARENINADI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@YUKLENICIADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YUKLENICIADI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ISINTANIMI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISINTANIMI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SOZLESMETARIHI", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SOZLESMETARIHI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SOZLESMEBEDELI", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "SOZLESMEBEDELI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ISINSURESI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISINSURESI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ISBITISTARIHI", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISBITISTARIHI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IHALEDURUM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IHALEDURUM", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SAVEUSER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEUSER", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SAVEDATE", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEDATE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EDITUSER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITUSER", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EDITDATE", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITDATE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SAVEMAC", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEMAC", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EDITMAC", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITMAC", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SAVEIP", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEIP", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EDITIP", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITIP", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_IHALEKAYITNO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IHALEKAYITNO", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_IHALEKAYITNO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IHALEKAYITNO", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_IDARENINADI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IDARENINADI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_IDARENINADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IDARENINADI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_YUKLENICIADI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YUKLENICIADI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_YUKLENICIADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YUKLENICIADI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ISINTANIMI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISINTANIMI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ISINTANIMI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISINTANIMI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SOZLESMETARIHI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SOZLESMETARIHI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SOZLESMETARIHI", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SOZLESMETARIHI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SOZLESMEBEDELI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SOZLESMEBEDELI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SOZLESMEBEDELI", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "SOZLESMEBEDELI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ISINSURESI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISINSURESI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ISINSURESI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISINSURESI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ISBITISTARIHI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISBITISTARIHI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ISBITISTARIHI", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISBITISTARIHI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_IHALEDURUM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IHALEDURUM", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_IHALEDURUM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IHALEDURUM", DataRowVersion.Original, false, (object) null, "", "", ""));
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
      this._commandCollection[0].CommandText = "SELECT ID, IHALEKAYITNO, IDARENINADI, YUKLENICIADI, ISINTANIMI, SOZLESMETARIHI, SOZLESMEBEDELI, ISINSURESI, ISBITISTARIHI, IHALEDURUM, SAVEUSER, SAVEDATE, EDITUSER, EDITDATE, SAVEMAC, EDITMAC, SAVEIP, EDITIP FROM dbo.TBLIHALELER";
      this._commandCollection[0].CommandType = CommandType.Text;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    public virtual int Fill(bellDataSet6.TBLIHALELERDataTable dataTable)
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
    public virtual bellDataSet6.TBLIHALELERDataTable GetData()
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      bellDataSet6.TBLIHALELERDataTable data = new bellDataSet6.TBLIHALELERDataTable();
      this.Adapter.Fill((DataTable) data);
      return data;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(bellDataSet6.TBLIHALELERDataTable dataTable) => this.Adapter.Update((DataTable) dataTable);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(bellDataSet6 dataSet) => this.Adapter.Update((DataSet) dataSet, "TBLIHALELER");

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
      string Original_IHALEKAYITNO,
      string Original_IDARENINADI,
      string Original_YUKLENICIADI,
      string Original_ISINTANIMI,
      DateTime? Original_SOZLESMETARIHI,
      Decimal? Original_SOZLESMEBEDELI,
      string Original_ISINSURESI,
      DateTime? Original_ISBITISTARIHI,
      string Original_IHALEDURUM,
      string Original_SAVEUSER,
      DateTime? Original_SAVEDATE,
      string Original_EDITUSER,
      DateTime? Original_EDITDATE,
      string Original_SAVEMAC,
      string Original_EDITMAC,
      string Original_SAVEIP,
      string Original_EDITIP)
    {
      this.Adapter.DeleteCommand.Parameters[0].Value = (object) Original_ID;
      if (Original_IHALEKAYITNO == null)
      {
        this.Adapter.DeleteCommand.Parameters[1].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[2].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[1].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[2].Value = (object) Original_IHALEKAYITNO;
      }
      if (Original_IDARENINADI == null)
      {
        this.Adapter.DeleteCommand.Parameters[3].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[4].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[3].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[4].Value = (object) Original_IDARENINADI;
      }
      if (Original_YUKLENICIADI == null)
      {
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[6].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[6].Value = (object) Original_YUKLENICIADI;
      }
      if (Original_ISINTANIMI == null)
      {
        this.Adapter.DeleteCommand.Parameters[7].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[8].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[7].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[8].Value = (object) Original_ISINTANIMI;
      }
      if (Original_SOZLESMETARIHI.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) Original_SOZLESMETARIHI.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) DBNull.Value;
      }
      if (Original_SOZLESMEBEDELI.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[11].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[12].Value = (object) Original_SOZLESMEBEDELI.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[11].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[12].Value = (object) DBNull.Value;
      }
      if (Original_ISINSURESI == null)
      {
        this.Adapter.DeleteCommand.Parameters[13].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[14].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[13].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[14].Value = (object) Original_ISINSURESI;
      }
      if (Original_ISBITISTARIHI.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[15].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[16].Value = (object) Original_ISBITISTARIHI.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[15].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[16].Value = (object) DBNull.Value;
      }
      if (Original_IHALEDURUM == null)
      {
        this.Adapter.DeleteCommand.Parameters[17].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[18].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[17].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[18].Value = (object) Original_IHALEDURUM;
      }
      if (Original_SAVEUSER == null)
      {
        this.Adapter.DeleteCommand.Parameters[19].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[20].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[19].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[20].Value = (object) Original_SAVEUSER;
      }
      if (Original_SAVEDATE.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[21].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[22].Value = (object) Original_SAVEDATE.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[21].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[22].Value = (object) DBNull.Value;
      }
      if (Original_EDITUSER == null)
      {
        this.Adapter.DeleteCommand.Parameters[23].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[24].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[23].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[24].Value = (object) Original_EDITUSER;
      }
      if (Original_EDITDATE.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[25].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[26].Value = (object) Original_EDITDATE.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[25].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[26].Value = (object) DBNull.Value;
      }
      if (Original_SAVEMAC == null)
      {
        this.Adapter.DeleteCommand.Parameters[27].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[28].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[27].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[28].Value = (object) Original_SAVEMAC;
      }
      if (Original_EDITMAC == null)
      {
        this.Adapter.DeleteCommand.Parameters[29].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[30].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[29].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[30].Value = (object) Original_EDITMAC;
      }
      if (Original_SAVEIP == null)
      {
        this.Adapter.DeleteCommand.Parameters[31].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[32].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[31].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[32].Value = (object) Original_SAVEIP;
      }
      if (Original_EDITIP == null)
      {
        this.Adapter.DeleteCommand.Parameters[33].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[34].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[33].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[34].Value = (object) Original_EDITIP;
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
      string IHALEKAYITNO,
      string IDARENINADI,
      string YUKLENICIADI,
      string ISINTANIMI,
      DateTime? SOZLESMETARIHI,
      Decimal? SOZLESMEBEDELI,
      string ISINSURESI,
      DateTime? ISBITISTARIHI,
      string IHALEDURUM,
      string SAVEUSER,
      DateTime? SAVEDATE,
      string EDITUSER,
      DateTime? EDITDATE,
      string SAVEMAC,
      string EDITMAC,
      string SAVEIP,
      string EDITIP)
    {
      if (IHALEKAYITNO == null)
        this.Adapter.InsertCommand.Parameters[0].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[0].Value = (object) IHALEKAYITNO;
      if (IDARENINADI == null)
        this.Adapter.InsertCommand.Parameters[1].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[1].Value = (object) IDARENINADI;
      if (YUKLENICIADI == null)
        this.Adapter.InsertCommand.Parameters[2].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[2].Value = (object) YUKLENICIADI;
      if (ISINTANIMI == null)
        this.Adapter.InsertCommand.Parameters[3].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[3].Value = (object) ISINTANIMI;
      if (SOZLESMETARIHI.HasValue)
        this.Adapter.InsertCommand.Parameters[4].Value = (object) SOZLESMETARIHI.Value;
      else
        this.Adapter.InsertCommand.Parameters[4].Value = (object) DBNull.Value;
      if (SOZLESMEBEDELI.HasValue)
        this.Adapter.InsertCommand.Parameters[5].Value = (object) SOZLESMEBEDELI.Value;
      else
        this.Adapter.InsertCommand.Parameters[5].Value = (object) DBNull.Value;
      if (ISINSURESI == null)
        this.Adapter.InsertCommand.Parameters[6].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[6].Value = (object) ISINSURESI;
      if (ISBITISTARIHI.HasValue)
        this.Adapter.InsertCommand.Parameters[7].Value = (object) ISBITISTARIHI.Value;
      else
        this.Adapter.InsertCommand.Parameters[7].Value = (object) DBNull.Value;
      if (IHALEDURUM == null)
        this.Adapter.InsertCommand.Parameters[8].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[8].Value = (object) IHALEDURUM;
      if (SAVEUSER == null)
        this.Adapter.InsertCommand.Parameters[9].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[9].Value = (object) SAVEUSER;
      if (SAVEDATE.HasValue)
        this.Adapter.InsertCommand.Parameters[10].Value = (object) SAVEDATE.Value;
      else
        this.Adapter.InsertCommand.Parameters[10].Value = (object) DBNull.Value;
      if (EDITUSER == null)
        this.Adapter.InsertCommand.Parameters[11].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[11].Value = (object) EDITUSER;
      if (EDITDATE.HasValue)
        this.Adapter.InsertCommand.Parameters[12].Value = (object) EDITDATE.Value;
      else
        this.Adapter.InsertCommand.Parameters[12].Value = (object) DBNull.Value;
      if (SAVEMAC == null)
        this.Adapter.InsertCommand.Parameters[13].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[13].Value = (object) SAVEMAC;
      if (EDITMAC == null)
        this.Adapter.InsertCommand.Parameters[14].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[14].Value = (object) EDITMAC;
      if (SAVEIP == null)
        this.Adapter.InsertCommand.Parameters[15].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[15].Value = (object) SAVEIP;
      if (EDITIP == null)
        this.Adapter.InsertCommand.Parameters[16].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[16].Value = (object) EDITIP;
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
      string IHALEKAYITNO,
      string IDARENINADI,
      string YUKLENICIADI,
      string ISINTANIMI,
      DateTime? SOZLESMETARIHI,
      Decimal? SOZLESMEBEDELI,
      string ISINSURESI,
      DateTime? ISBITISTARIHI,
      string IHALEDURUM,
      string SAVEUSER,
      DateTime? SAVEDATE,
      string EDITUSER,
      DateTime? EDITDATE,
      string SAVEMAC,
      string EDITMAC,
      string SAVEIP,
      string EDITIP,
      int Original_ID,
      string Original_IHALEKAYITNO,
      string Original_IDARENINADI,
      string Original_YUKLENICIADI,
      string Original_ISINTANIMI,
      DateTime? Original_SOZLESMETARIHI,
      Decimal? Original_SOZLESMEBEDELI,
      string Original_ISINSURESI,
      DateTime? Original_ISBITISTARIHI,
      string Original_IHALEDURUM,
      string Original_SAVEUSER,
      DateTime? Original_SAVEDATE,
      string Original_EDITUSER,
      DateTime? Original_EDITDATE,
      string Original_SAVEMAC,
      string Original_EDITMAC,
      string Original_SAVEIP,
      string Original_EDITIP,
      int ID)
    {
      if (IHALEKAYITNO == null)
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) IHALEKAYITNO;
      if (IDARENINADI == null)
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) IDARENINADI;
      if (YUKLENICIADI == null)
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) YUKLENICIADI;
      if (ISINTANIMI == null)
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) ISINTANIMI;
      if (SOZLESMETARIHI.HasValue)
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) SOZLESMETARIHI.Value;
      else
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) DBNull.Value;
      if (SOZLESMEBEDELI.HasValue)
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) SOZLESMEBEDELI.Value;
      else
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) DBNull.Value;
      if (ISINSURESI == null)
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) ISINSURESI;
      if (ISBITISTARIHI.HasValue)
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) ISBITISTARIHI.Value;
      else
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) DBNull.Value;
      if (IHALEDURUM == null)
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) IHALEDURUM;
      if (SAVEUSER == null)
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) SAVEUSER;
      if (SAVEDATE.HasValue)
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) SAVEDATE.Value;
      else
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) DBNull.Value;
      if (EDITUSER == null)
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) EDITUSER;
      if (EDITDATE.HasValue)
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) EDITDATE.Value;
      else
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) DBNull.Value;
      if (SAVEMAC == null)
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) SAVEMAC;
      if (EDITMAC == null)
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) EDITMAC;
      if (SAVEIP == null)
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) SAVEIP;
      if (EDITIP == null)
        this.Adapter.UpdateCommand.Parameters[16].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[16].Value = (object) EDITIP;
      this.Adapter.UpdateCommand.Parameters[17].Value = (object) Original_ID;
      if (Original_IHALEKAYITNO == null)
      {
        this.Adapter.UpdateCommand.Parameters[18].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[19].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[18].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[19].Value = (object) Original_IHALEKAYITNO;
      }
      if (Original_IDARENINADI == null)
      {
        this.Adapter.UpdateCommand.Parameters[20].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[21].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[20].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[21].Value = (object) Original_IDARENINADI;
      }
      if (Original_YUKLENICIADI == null)
      {
        this.Adapter.UpdateCommand.Parameters[22].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[23].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[22].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[23].Value = (object) Original_YUKLENICIADI;
      }
      if (Original_ISINTANIMI == null)
      {
        this.Adapter.UpdateCommand.Parameters[24].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[25].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[24].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[25].Value = (object) Original_ISINTANIMI;
      }
      if (Original_SOZLESMETARIHI.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[26].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[27].Value = (object) Original_SOZLESMETARIHI.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[26].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[27].Value = (object) DBNull.Value;
      }
      if (Original_SOZLESMEBEDELI.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[28].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[29].Value = (object) Original_SOZLESMEBEDELI.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[28].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[29].Value = (object) DBNull.Value;
      }
      if (Original_ISINSURESI == null)
      {
        this.Adapter.UpdateCommand.Parameters[30].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[31].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[30].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[31].Value = (object) Original_ISINSURESI;
      }
      if (Original_ISBITISTARIHI.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[32].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[33].Value = (object) Original_ISBITISTARIHI.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[32].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[33].Value = (object) DBNull.Value;
      }
      if (Original_IHALEDURUM == null)
      {
        this.Adapter.UpdateCommand.Parameters[34].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[35].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[34].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[35].Value = (object) Original_IHALEDURUM;
      }
      if (Original_SAVEUSER == null)
      {
        this.Adapter.UpdateCommand.Parameters[36].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[37].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[36].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[37].Value = (object) Original_SAVEUSER;
      }
      if (Original_SAVEDATE.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[38].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[39].Value = (object) Original_SAVEDATE.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[38].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[39].Value = (object) DBNull.Value;
      }
      if (Original_EDITUSER == null)
      {
        this.Adapter.UpdateCommand.Parameters[40].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[41].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[40].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[41].Value = (object) Original_EDITUSER;
      }
      if (Original_EDITDATE.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[42].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[43].Value = (object) Original_EDITDATE.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[42].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[43].Value = (object) DBNull.Value;
      }
      if (Original_SAVEMAC == null)
      {
        this.Adapter.UpdateCommand.Parameters[44].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[45].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[44].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[45].Value = (object) Original_SAVEMAC;
      }
      if (Original_EDITMAC == null)
      {
        this.Adapter.UpdateCommand.Parameters[46].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[47].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[46].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[47].Value = (object) Original_EDITMAC;
      }
      if (Original_SAVEIP == null)
      {
        this.Adapter.UpdateCommand.Parameters[48].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[49].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[48].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[49].Value = (object) Original_SAVEIP;
      }
      if (Original_EDITIP == null)
      {
        this.Adapter.UpdateCommand.Parameters[50].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[51].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[50].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[51].Value = (object) Original_EDITIP;
      }
      this.Adapter.UpdateCommand.Parameters[52].Value = (object) ID;
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
      string IHALEKAYITNO,
      string IDARENINADI,
      string YUKLENICIADI,
      string ISINTANIMI,
      DateTime? SOZLESMETARIHI,
      Decimal? SOZLESMEBEDELI,
      string ISINSURESI,
      DateTime? ISBITISTARIHI,
      string IHALEDURUM,
      string SAVEUSER,
      DateTime? SAVEDATE,
      string EDITUSER,
      DateTime? EDITDATE,
      string SAVEMAC,
      string EDITMAC,
      string SAVEIP,
      string EDITIP,
      int Original_ID,
      string Original_IHALEKAYITNO,
      string Original_IDARENINADI,
      string Original_YUKLENICIADI,
      string Original_ISINTANIMI,
      DateTime? Original_SOZLESMETARIHI,
      Decimal? Original_SOZLESMEBEDELI,
      string Original_ISINSURESI,
      DateTime? Original_ISBITISTARIHI,
      string Original_IHALEDURUM,
      string Original_SAVEUSER,
      DateTime? Original_SAVEDATE,
      string Original_EDITUSER,
      DateTime? Original_EDITDATE,
      string Original_SAVEMAC,
      string Original_EDITMAC,
      string Original_SAVEIP,
      string Original_EDITIP)
    {
      return this.Update(IHALEKAYITNO, IDARENINADI, YUKLENICIADI, ISINTANIMI, SOZLESMETARIHI, SOZLESMEBEDELI, ISINSURESI, ISBITISTARIHI, IHALEDURUM, SAVEUSER, SAVEDATE, EDITUSER, EDITDATE, SAVEMAC, EDITMAC, SAVEIP, EDITIP, Original_ID, Original_IHALEKAYITNO, Original_IDARENINADI, Original_YUKLENICIADI, Original_ISINTANIMI, Original_SOZLESMETARIHI, Original_SOZLESMEBEDELI, Original_ISINSURESI, Original_ISBITISTARIHI, Original_IHALEDURUM, Original_SAVEUSER, Original_SAVEDATE, Original_EDITUSER, Original_EDITDATE, Original_SAVEMAC, Original_EDITMAC, Original_SAVEIP, Original_EDITIP, Original_ID);
    }
  }
}
