// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.bellDataSet7TableAdapters.FAALIYETTableAdapter
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
  public class FAALIYETTableAdapter : Component
  {
    private SqlDataAdapter _adapter;
    private SqlConnection _connection;
    private SqlTransaction _transaction;
    private SqlCommand[] _commandCollection;
    private bool _clearBeforeFill;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public FAALIYETTableAdapter() => this.ClearBeforeFill = true;

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
        DataSetTable = "FAALIYET",
        ColumnMappings = {
          {
            "ID",
            "ID"
          },
          {
            "TARIH",
            "TARIH"
          },
          {
            "YILI",
            "YILI"
          },
          {
            "ARACBAKIMATOLYE",
            "ARACBAKIMATOLYE"
          },
          {
            "ARACBAKIMARAZI",
            "ARACBAKIMARAZI"
          },
          {
            "ARACBAKIMDIS",
            "ARACBAKIMDIS"
          },
          {
            "YAGBAKIM",
            "YAGBAKIM"
          },
          {
            "ZORUNLUTRFKSIGORTA",
            "ZORUNLUTRFKSIGORTA"
          },
          {
            "MUAYENE",
            "MUAYENE"
          },
          {
            "BAIKRESMI",
            "BAIKRESMI"
          },
          {
            "BAIKHIZMET",
            "BAIKHIZMET"
          },
          {
            "YAKITMOTORIN",
            "YAKITMOTORIN"
          },
          {
            "YAKITBENZIN",
            "YAKITBENZIN"
          },
          {
            "RESMIKIRALIKMOTORIN",
            "RESMIKIRALIKMOTORIN"
          },
          {
            "RESMIKIRALIKBENZIN",
            "RESMIKIRALIKBENZIN"
          },
          {
            "SUBEMUDURU",
            "SUBEMUDURU"
          },
          {
            "AYI",
            "AYI"
          }
        }
      });
      this._adapter.DeleteCommand = new SqlCommand();
      this._adapter.DeleteCommand.Connection = this.Connection;
      this._adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[FAALIYET] WHERE (([ID] = @Original_ID) AND ((@IsNull_TARIH = 1 AND [TARIH] IS NULL) OR ([TARIH] = @Original_TARIH)) AND ((@IsNull_YILI = 1 AND [YILI] IS NULL) OR ([YILI] = @Original_YILI)) AND ((@IsNull_ARACBAKIMATOLYE = 1 AND [ARACBAKIMATOLYE] IS NULL) OR ([ARACBAKIMATOLYE] = @Original_ARACBAKIMATOLYE)) AND ((@IsNull_ARACBAKIMARAZI = 1 AND [ARACBAKIMARAZI] IS NULL) OR ([ARACBAKIMARAZI] = @Original_ARACBAKIMARAZI)) AND ((@IsNull_ARACBAKIMDIS = 1 AND [ARACBAKIMDIS] IS NULL) OR ([ARACBAKIMDIS] = @Original_ARACBAKIMDIS)) AND ((@IsNull_YAGBAKIM = 1 AND [YAGBAKIM] IS NULL) OR ([YAGBAKIM] = @Original_YAGBAKIM)) AND ((@IsNull_ZORUNLUTRFKSIGORTA = 1 AND [ZORUNLUTRFKSIGORTA] IS NULL) OR ([ZORUNLUTRFKSIGORTA] = @Original_ZORUNLUTRFKSIGORTA)) AND ((@IsNull_MUAYENE = 1 AND [MUAYENE] IS NULL) OR ([MUAYENE] = @Original_MUAYENE)) AND ((@IsNull_BAIKRESMI = 1 AND [BAIKRESMI] IS NULL) OR ([BAIKRESMI] = @Original_BAIKRESMI)) AND ((@IsNull_BAIKHIZMET = 1 AND [BAIKHIZMET] IS NULL) OR ([BAIKHIZMET] = @Original_BAIKHIZMET)) AND ((@IsNull_YAKITMOTORIN = 1 AND [YAKITMOTORIN] IS NULL) OR ([YAKITMOTORIN] = @Original_YAKITMOTORIN)) AND ((@IsNull_YAKITBENZIN = 1 AND [YAKITBENZIN] IS NULL) OR ([YAKITBENZIN] = @Original_YAKITBENZIN)) AND ((@IsNull_RESMIKIRALIKMOTORIN = 1 AND [RESMIKIRALIKMOTORIN] IS NULL) OR ([RESMIKIRALIKMOTORIN] = @Original_RESMIKIRALIKMOTORIN)) AND ((@IsNull_RESMIKIRALIKBENZIN = 1 AND [RESMIKIRALIKBENZIN] IS NULL) OR ([RESMIKIRALIKBENZIN] = @Original_RESMIKIRALIKBENZIN)) AND ((@IsNull_SUBEMUDURU = 1 AND [SUBEMUDURU] IS NULL) OR ([SUBEMUDURU] = @Original_SUBEMUDURU)) AND ((@IsNull_AYI = 1 AND [AYI] IS NULL) OR ([AYI] = @Original_AYI)))";
      this._adapter.DeleteCommand.CommandType = CommandType.Text;
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TARIH", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TARIH", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TARIH", SqlDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TARIH", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_YILI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YILI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_YILI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YILI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ARACBAKIMATOLYE", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACBAKIMATOLYE", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ARACBAKIMATOLYE", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACBAKIMATOLYE", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ARACBAKIMARAZI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACBAKIMARAZI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ARACBAKIMARAZI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACBAKIMARAZI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ARACBAKIMDIS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACBAKIMDIS", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ARACBAKIMDIS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACBAKIMDIS", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_YAGBAKIM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YAGBAKIM", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_YAGBAKIM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YAGBAKIM", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ZORUNLUTRFKSIGORTA", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ZORUNLUTRFKSIGORTA", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ZORUNLUTRFKSIGORTA", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ZORUNLUTRFKSIGORTA", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_MUAYENE", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MUAYENE", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_MUAYENE", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MUAYENE", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_BAIKRESMI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAIKRESMI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_BAIKRESMI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAIKRESMI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_BAIKHIZMET", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAIKHIZMET", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_BAIKHIZMET", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAIKHIZMET", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_YAKITMOTORIN", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YAKITMOTORIN", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_YAKITMOTORIN", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "YAKITMOTORIN", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_YAKITBENZIN", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YAKITBENZIN", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_YAKITBENZIN", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "YAKITBENZIN", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_RESMIKIRALIKMOTORIN", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RESMIKIRALIKMOTORIN", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_RESMIKIRALIKMOTORIN", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "RESMIKIRALIKMOTORIN", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_RESMIKIRALIKBENZIN", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RESMIKIRALIKBENZIN", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_RESMIKIRALIKBENZIN", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "RESMIKIRALIKBENZIN", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SUBEMUDURU", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SUBEMUDURU", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SUBEMUDURU", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SUBEMUDURU", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_AYI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AYI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_AYI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AYI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.InsertCommand = new SqlCommand();
      this._adapter.InsertCommand.Connection = this.Connection;
      this._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[FAALIYET] ([TARIH], [YILI], [ARACBAKIMATOLYE], [ARACBAKIMARAZI], [ARACBAKIMDIS], [YAGBAKIM], [ZORUNLUTRFKSIGORTA], [MUAYENE], [BAIKRESMI], [BAIKHIZMET], [YAKITMOTORIN], [YAKITBENZIN], [RESMIKIRALIKMOTORIN], [RESMIKIRALIKBENZIN], [SUBEMUDURU], [AYI]) VALUES (@TARIH, @YILI, @ARACBAKIMATOLYE, @ARACBAKIMARAZI, @ARACBAKIMDIS, @YAGBAKIM, @ZORUNLUTRFKSIGORTA, @MUAYENE, @BAIKRESMI, @BAIKHIZMET, @YAKITMOTORIN, @YAKITBENZIN, @RESMIKIRALIKMOTORIN, @RESMIKIRALIKBENZIN, @SUBEMUDURU, @AYI);\r\nSELECT ID, TARIH, YILI, ARACBAKIMATOLYE, ARACBAKIMARAZI, ARACBAKIMDIS, YAGBAKIM, ZORUNLUTRFKSIGORTA, MUAYENE, BAIKRESMI, BAIKHIZMET, YAKITMOTORIN, YAKITBENZIN, RESMIKIRALIKMOTORIN, RESMIKIRALIKBENZIN, SUBEMUDURU, AYI FROM FAALIYET WHERE (ID = SCOPE_IDENTITY())";
      this._adapter.InsertCommand.CommandType = CommandType.Text;
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@TARIH", SqlDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TARIH", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@YILI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YILI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ARACBAKIMATOLYE", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACBAKIMATOLYE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ARACBAKIMARAZI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACBAKIMARAZI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ARACBAKIMDIS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACBAKIMDIS", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@YAGBAKIM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YAGBAKIM", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ZORUNLUTRFKSIGORTA", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ZORUNLUTRFKSIGORTA", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@MUAYENE", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MUAYENE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@BAIKRESMI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAIKRESMI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@BAIKHIZMET", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAIKHIZMET", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@YAKITMOTORIN", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "YAKITMOTORIN", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@YAKITBENZIN", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "YAKITBENZIN", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@RESMIKIRALIKMOTORIN", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "RESMIKIRALIKMOTORIN", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@RESMIKIRALIKBENZIN", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "RESMIKIRALIKBENZIN", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SUBEMUDURU", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SUBEMUDURU", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@AYI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AYI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand = new SqlCommand();
      this._adapter.UpdateCommand.Connection = this.Connection;
      this._adapter.UpdateCommand.CommandText = "UPDATE [dbo].[FAALIYET] SET [TARIH] = @TARIH, [YILI] = @YILI, [ARACBAKIMATOLYE] = @ARACBAKIMATOLYE, [ARACBAKIMARAZI] = @ARACBAKIMARAZI, [ARACBAKIMDIS] = @ARACBAKIMDIS, [YAGBAKIM] = @YAGBAKIM, [ZORUNLUTRFKSIGORTA] = @ZORUNLUTRFKSIGORTA, [MUAYENE] = @MUAYENE, [BAIKRESMI] = @BAIKRESMI, [BAIKHIZMET] = @BAIKHIZMET, [YAKITMOTORIN] = @YAKITMOTORIN, [YAKITBENZIN] = @YAKITBENZIN, [RESMIKIRALIKMOTORIN] = @RESMIKIRALIKMOTORIN, [RESMIKIRALIKBENZIN] = @RESMIKIRALIKBENZIN, [SUBEMUDURU] = @SUBEMUDURU, [AYI] = @AYI WHERE (([ID] = @Original_ID) AND ((@IsNull_TARIH = 1 AND [TARIH] IS NULL) OR ([TARIH] = @Original_TARIH)) AND ((@IsNull_YILI = 1 AND [YILI] IS NULL) OR ([YILI] = @Original_YILI)) AND ((@IsNull_ARACBAKIMATOLYE = 1 AND [ARACBAKIMATOLYE] IS NULL) OR ([ARACBAKIMATOLYE] = @Original_ARACBAKIMATOLYE)) AND ((@IsNull_ARACBAKIMARAZI = 1 AND [ARACBAKIMARAZI] IS NULL) OR ([ARACBAKIMARAZI] = @Original_ARACBAKIMARAZI)) AND ((@IsNull_ARACBAKIMDIS = 1 AND [ARACBAKIMDIS] IS NULL) OR ([ARACBAKIMDIS] = @Original_ARACBAKIMDIS)) AND ((@IsNull_YAGBAKIM = 1 AND [YAGBAKIM] IS NULL) OR ([YAGBAKIM] = @Original_YAGBAKIM)) AND ((@IsNull_ZORUNLUTRFKSIGORTA = 1 AND [ZORUNLUTRFKSIGORTA] IS NULL) OR ([ZORUNLUTRFKSIGORTA] = @Original_ZORUNLUTRFKSIGORTA)) AND ((@IsNull_MUAYENE = 1 AND [MUAYENE] IS NULL) OR ([MUAYENE] = @Original_MUAYENE)) AND ((@IsNull_BAIKRESMI = 1 AND [BAIKRESMI] IS NULL) OR ([BAIKRESMI] = @Original_BAIKRESMI)) AND ((@IsNull_BAIKHIZMET = 1 AND [BAIKHIZMET] IS NULL) OR ([BAIKHIZMET] = @Original_BAIKHIZMET)) AND ((@IsNull_YAKITMOTORIN = 1 AND [YAKITMOTORIN] IS NULL) OR ([YAKITMOTORIN] = @Original_YAKITMOTORIN)) AND ((@IsNull_YAKITBENZIN = 1 AND [YAKITBENZIN] IS NULL) OR ([YAKITBENZIN] = @Original_YAKITBENZIN)) AND ((@IsNull_RESMIKIRALIKMOTORIN = 1 AND [RESMIKIRALIKMOTORIN] IS NULL) OR ([RESMIKIRALIKMOTORIN] = @Original_RESMIKIRALIKMOTORIN)) AND ((@IsNull_RESMIKIRALIKBENZIN = 1 AND [RESMIKIRALIKBENZIN] IS NULL) OR ([RESMIKIRALIKBENZIN] = @Original_RESMIKIRALIKBENZIN)) AND ((@IsNull_SUBEMUDURU = 1 AND [SUBEMUDURU] IS NULL) OR ([SUBEMUDURU] = @Original_SUBEMUDURU)) AND ((@IsNull_AYI = 1 AND [AYI] IS NULL) OR ([AYI] = @Original_AYI)));\r\nSELECT ID, TARIH, YILI, ARACBAKIMATOLYE, ARACBAKIMARAZI, ARACBAKIMDIS, YAGBAKIM, ZORUNLUTRFKSIGORTA, MUAYENE, BAIKRESMI, BAIKHIZMET, YAKITMOTORIN, YAKITBENZIN, RESMIKIRALIKMOTORIN, RESMIKIRALIKBENZIN, SUBEMUDURU, AYI FROM FAALIYET WHERE (ID = @ID)";
      this._adapter.UpdateCommand.CommandType = CommandType.Text;
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TARIH", SqlDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TARIH", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@YILI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YILI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ARACBAKIMATOLYE", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACBAKIMATOLYE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ARACBAKIMARAZI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACBAKIMARAZI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ARACBAKIMDIS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACBAKIMDIS", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@YAGBAKIM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YAGBAKIM", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ZORUNLUTRFKSIGORTA", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ZORUNLUTRFKSIGORTA", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MUAYENE", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MUAYENE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@BAIKRESMI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAIKRESMI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@BAIKHIZMET", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAIKHIZMET", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@YAKITMOTORIN", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "YAKITMOTORIN", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@YAKITBENZIN", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "YAKITBENZIN", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@RESMIKIRALIKMOTORIN", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "RESMIKIRALIKMOTORIN", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@RESMIKIRALIKBENZIN", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "RESMIKIRALIKBENZIN", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SUBEMUDURU", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SUBEMUDURU", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@AYI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AYI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TARIH", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TARIH", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TARIH", SqlDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TARIH", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_YILI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YILI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_YILI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YILI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ARACBAKIMATOLYE", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACBAKIMATOLYE", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ARACBAKIMATOLYE", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACBAKIMATOLYE", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ARACBAKIMARAZI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACBAKIMARAZI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ARACBAKIMARAZI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACBAKIMARAZI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ARACBAKIMDIS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACBAKIMDIS", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ARACBAKIMDIS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACBAKIMDIS", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_YAGBAKIM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YAGBAKIM", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_YAGBAKIM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YAGBAKIM", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ZORUNLUTRFKSIGORTA", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ZORUNLUTRFKSIGORTA", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ZORUNLUTRFKSIGORTA", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ZORUNLUTRFKSIGORTA", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_MUAYENE", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MUAYENE", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_MUAYENE", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MUAYENE", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_BAIKRESMI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAIKRESMI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_BAIKRESMI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAIKRESMI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_BAIKHIZMET", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAIKHIZMET", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_BAIKHIZMET", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BAIKHIZMET", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_YAKITMOTORIN", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YAKITMOTORIN", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_YAKITMOTORIN", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "YAKITMOTORIN", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_YAKITBENZIN", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YAKITBENZIN", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_YAKITBENZIN", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "YAKITBENZIN", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_RESMIKIRALIKMOTORIN", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RESMIKIRALIKMOTORIN", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_RESMIKIRALIKMOTORIN", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "RESMIKIRALIKMOTORIN", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_RESMIKIRALIKBENZIN", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RESMIKIRALIKBENZIN", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_RESMIKIRALIKBENZIN", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "RESMIKIRALIKBENZIN", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SUBEMUDURU", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SUBEMUDURU", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SUBEMUDURU", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SUBEMUDURU", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_AYI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AYI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_AYI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AYI", DataRowVersion.Original, false, (object) null, "", "", ""));
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
      this._commandCollection[0].CommandText = "SELECT ID, TARIH, YILI, ARACBAKIMATOLYE, ARACBAKIMARAZI, ARACBAKIMDIS, YAGBAKIM, ZORUNLUTRFKSIGORTA, MUAYENE, BAIKRESMI, BAIKHIZMET, YAKITMOTORIN, YAKITBENZIN, RESMIKIRALIKMOTORIN, RESMIKIRALIKBENZIN, SUBEMUDURU, AYI FROM dbo.FAALIYET";
      this._commandCollection[0].CommandType = CommandType.Text;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    public virtual int Fill(bellDataSet7.FAALIYETDataTable dataTable)
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
    public virtual bellDataSet7.FAALIYETDataTable GetData()
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      bellDataSet7.FAALIYETDataTable data = new bellDataSet7.FAALIYETDataTable();
      this.Adapter.Fill((DataTable) data);
      return data;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(bellDataSet7.FAALIYETDataTable dataTable) => this.Adapter.Update((DataTable) dataTable);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(bellDataSet7 dataSet) => this.Adapter.Update((DataSet) dataSet, "FAALIYET");

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
      DateTime? Original_TARIH,
      string Original_YILI,
      int? Original_ARACBAKIMATOLYE,
      int? Original_ARACBAKIMARAZI,
      int? Original_ARACBAKIMDIS,
      int? Original_YAGBAKIM,
      int? Original_ZORUNLUTRFKSIGORTA,
      int? Original_MUAYENE,
      int? Original_BAIKRESMI,
      int? Original_BAIKHIZMET,
      Decimal? Original_YAKITMOTORIN,
      Decimal? Original_YAKITBENZIN,
      Decimal? Original_RESMIKIRALIKMOTORIN,
      Decimal? Original_RESMIKIRALIKBENZIN,
      int? Original_SUBEMUDURU,
      string Original_AYI)
    {
      this.Adapter.DeleteCommand.Parameters[0].Value = (object) Original_ID;
      if (Original_TARIH.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[1].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[2].Value = (object) Original_TARIH.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[1].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[2].Value = (object) DBNull.Value;
      }
      if (Original_YILI == null)
      {
        this.Adapter.DeleteCommand.Parameters[3].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[4].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[3].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[4].Value = (object) Original_YILI;
      }
      if (Original_ARACBAKIMATOLYE.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[6].Value = (object) Original_ARACBAKIMATOLYE.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[6].Value = (object) DBNull.Value;
      }
      if (Original_ARACBAKIMARAZI.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[7].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[8].Value = (object) Original_ARACBAKIMARAZI.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[7].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[8].Value = (object) DBNull.Value;
      }
      if (Original_ARACBAKIMDIS.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) Original_ARACBAKIMDIS.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) DBNull.Value;
      }
      if (Original_YAGBAKIM.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[11].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[12].Value = (object) Original_YAGBAKIM.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[11].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[12].Value = (object) DBNull.Value;
      }
      if (Original_ZORUNLUTRFKSIGORTA.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[13].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[14].Value = (object) Original_ZORUNLUTRFKSIGORTA.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[13].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[14].Value = (object) DBNull.Value;
      }
      if (Original_MUAYENE.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[15].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[16].Value = (object) Original_MUAYENE.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[15].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[16].Value = (object) DBNull.Value;
      }
      if (Original_BAIKRESMI.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[17].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[18].Value = (object) Original_BAIKRESMI.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[17].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[18].Value = (object) DBNull.Value;
      }
      if (Original_BAIKHIZMET.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[19].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[20].Value = (object) Original_BAIKHIZMET.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[19].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[20].Value = (object) DBNull.Value;
      }
      if (Original_YAKITMOTORIN.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[21].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[22].Value = (object) Original_YAKITMOTORIN.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[21].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[22].Value = (object) DBNull.Value;
      }
      if (Original_YAKITBENZIN.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[23].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[24].Value = (object) Original_YAKITBENZIN.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[23].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[24].Value = (object) DBNull.Value;
      }
      if (Original_RESMIKIRALIKMOTORIN.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[25].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[26].Value = (object) Original_RESMIKIRALIKMOTORIN.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[25].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[26].Value = (object) DBNull.Value;
      }
      if (Original_RESMIKIRALIKBENZIN.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[27].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[28].Value = (object) Original_RESMIKIRALIKBENZIN.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[27].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[28].Value = (object) DBNull.Value;
      }
      if (Original_SUBEMUDURU.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[29].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[30].Value = (object) Original_SUBEMUDURU.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[29].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[30].Value = (object) DBNull.Value;
      }
      if (Original_AYI == null)
      {
        this.Adapter.DeleteCommand.Parameters[31].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[32].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[31].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[32].Value = (object) Original_AYI;
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
      DateTime? TARIH,
      string YILI,
      int? ARACBAKIMATOLYE,
      int? ARACBAKIMARAZI,
      int? ARACBAKIMDIS,
      int? YAGBAKIM,
      int? ZORUNLUTRFKSIGORTA,
      int? MUAYENE,
      int? BAIKRESMI,
      int? BAIKHIZMET,
      Decimal? YAKITMOTORIN,
      Decimal? YAKITBENZIN,
      Decimal? RESMIKIRALIKMOTORIN,
      Decimal? RESMIKIRALIKBENZIN,
      int? SUBEMUDURU,
      string AYI)
    {
      if (TARIH.HasValue)
        this.Adapter.InsertCommand.Parameters[0].Value = (object) TARIH.Value;
      else
        this.Adapter.InsertCommand.Parameters[0].Value = (object) DBNull.Value;
      if (YILI == null)
        this.Adapter.InsertCommand.Parameters[1].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[1].Value = (object) YILI;
      if (ARACBAKIMATOLYE.HasValue)
        this.Adapter.InsertCommand.Parameters[2].Value = (object) ARACBAKIMATOLYE.Value;
      else
        this.Adapter.InsertCommand.Parameters[2].Value = (object) DBNull.Value;
      if (ARACBAKIMARAZI.HasValue)
        this.Adapter.InsertCommand.Parameters[3].Value = (object) ARACBAKIMARAZI.Value;
      else
        this.Adapter.InsertCommand.Parameters[3].Value = (object) DBNull.Value;
      if (ARACBAKIMDIS.HasValue)
        this.Adapter.InsertCommand.Parameters[4].Value = (object) ARACBAKIMDIS.Value;
      else
        this.Adapter.InsertCommand.Parameters[4].Value = (object) DBNull.Value;
      if (YAGBAKIM.HasValue)
        this.Adapter.InsertCommand.Parameters[5].Value = (object) YAGBAKIM.Value;
      else
        this.Adapter.InsertCommand.Parameters[5].Value = (object) DBNull.Value;
      if (ZORUNLUTRFKSIGORTA.HasValue)
        this.Adapter.InsertCommand.Parameters[6].Value = (object) ZORUNLUTRFKSIGORTA.Value;
      else
        this.Adapter.InsertCommand.Parameters[6].Value = (object) DBNull.Value;
      if (MUAYENE.HasValue)
        this.Adapter.InsertCommand.Parameters[7].Value = (object) MUAYENE.Value;
      else
        this.Adapter.InsertCommand.Parameters[7].Value = (object) DBNull.Value;
      if (BAIKRESMI.HasValue)
        this.Adapter.InsertCommand.Parameters[8].Value = (object) BAIKRESMI.Value;
      else
        this.Adapter.InsertCommand.Parameters[8].Value = (object) DBNull.Value;
      if (BAIKHIZMET.HasValue)
        this.Adapter.InsertCommand.Parameters[9].Value = (object) BAIKHIZMET.Value;
      else
        this.Adapter.InsertCommand.Parameters[9].Value = (object) DBNull.Value;
      if (YAKITMOTORIN.HasValue)
        this.Adapter.InsertCommand.Parameters[10].Value = (object) YAKITMOTORIN.Value;
      else
        this.Adapter.InsertCommand.Parameters[10].Value = (object) DBNull.Value;
      if (YAKITBENZIN.HasValue)
        this.Adapter.InsertCommand.Parameters[11].Value = (object) YAKITBENZIN.Value;
      else
        this.Adapter.InsertCommand.Parameters[11].Value = (object) DBNull.Value;
      if (RESMIKIRALIKMOTORIN.HasValue)
        this.Adapter.InsertCommand.Parameters[12].Value = (object) RESMIKIRALIKMOTORIN.Value;
      else
        this.Adapter.InsertCommand.Parameters[12].Value = (object) DBNull.Value;
      if (RESMIKIRALIKBENZIN.HasValue)
        this.Adapter.InsertCommand.Parameters[13].Value = (object) RESMIKIRALIKBENZIN.Value;
      else
        this.Adapter.InsertCommand.Parameters[13].Value = (object) DBNull.Value;
      if (SUBEMUDURU.HasValue)
        this.Adapter.InsertCommand.Parameters[14].Value = (object) SUBEMUDURU.Value;
      else
        this.Adapter.InsertCommand.Parameters[14].Value = (object) DBNull.Value;
      if (AYI == null)
        this.Adapter.InsertCommand.Parameters[15].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[15].Value = (object) AYI;
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
      DateTime? TARIH,
      string YILI,
      int? ARACBAKIMATOLYE,
      int? ARACBAKIMARAZI,
      int? ARACBAKIMDIS,
      int? YAGBAKIM,
      int? ZORUNLUTRFKSIGORTA,
      int? MUAYENE,
      int? BAIKRESMI,
      int? BAIKHIZMET,
      Decimal? YAKITMOTORIN,
      Decimal? YAKITBENZIN,
      Decimal? RESMIKIRALIKMOTORIN,
      Decimal? RESMIKIRALIKBENZIN,
      int? SUBEMUDURU,
      string AYI,
      int Original_ID,
      DateTime? Original_TARIH,
      string Original_YILI,
      int? Original_ARACBAKIMATOLYE,
      int? Original_ARACBAKIMARAZI,
      int? Original_ARACBAKIMDIS,
      int? Original_YAGBAKIM,
      int? Original_ZORUNLUTRFKSIGORTA,
      int? Original_MUAYENE,
      int? Original_BAIKRESMI,
      int? Original_BAIKHIZMET,
      Decimal? Original_YAKITMOTORIN,
      Decimal? Original_YAKITBENZIN,
      Decimal? Original_RESMIKIRALIKMOTORIN,
      Decimal? Original_RESMIKIRALIKBENZIN,
      int? Original_SUBEMUDURU,
      string Original_AYI,
      int ID)
    {
      if (TARIH.HasValue)
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) TARIH.Value;
      else
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) DBNull.Value;
      if (YILI == null)
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) YILI;
      if (ARACBAKIMATOLYE.HasValue)
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) ARACBAKIMATOLYE.Value;
      else
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) DBNull.Value;
      if (ARACBAKIMARAZI.HasValue)
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) ARACBAKIMARAZI.Value;
      else
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) DBNull.Value;
      if (ARACBAKIMDIS.HasValue)
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) ARACBAKIMDIS.Value;
      else
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) DBNull.Value;
      if (YAGBAKIM.HasValue)
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) YAGBAKIM.Value;
      else
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) DBNull.Value;
      if (ZORUNLUTRFKSIGORTA.HasValue)
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) ZORUNLUTRFKSIGORTA.Value;
      else
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) DBNull.Value;
      if (MUAYENE.HasValue)
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) MUAYENE.Value;
      else
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) DBNull.Value;
      if (BAIKRESMI.HasValue)
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) BAIKRESMI.Value;
      else
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) DBNull.Value;
      if (BAIKHIZMET.HasValue)
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) BAIKHIZMET.Value;
      else
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) DBNull.Value;
      if (YAKITMOTORIN.HasValue)
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) YAKITMOTORIN.Value;
      else
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) DBNull.Value;
      if (YAKITBENZIN.HasValue)
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) YAKITBENZIN.Value;
      else
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) DBNull.Value;
      if (RESMIKIRALIKMOTORIN.HasValue)
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) RESMIKIRALIKMOTORIN.Value;
      else
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) DBNull.Value;
      if (RESMIKIRALIKBENZIN.HasValue)
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) RESMIKIRALIKBENZIN.Value;
      else
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) DBNull.Value;
      if (SUBEMUDURU.HasValue)
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) SUBEMUDURU.Value;
      else
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) DBNull.Value;
      if (AYI == null)
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) AYI;
      this.Adapter.UpdateCommand.Parameters[16].Value = (object) Original_ID;
      if (Original_TARIH.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[17].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[18].Value = (object) Original_TARIH.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[17].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[18].Value = (object) DBNull.Value;
      }
      if (Original_YILI == null)
      {
        this.Adapter.UpdateCommand.Parameters[19].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[20].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[19].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[20].Value = (object) Original_YILI;
      }
      if (Original_ARACBAKIMATOLYE.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[21].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[22].Value = (object) Original_ARACBAKIMATOLYE.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[21].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[22].Value = (object) DBNull.Value;
      }
      if (Original_ARACBAKIMARAZI.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[23].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[24].Value = (object) Original_ARACBAKIMARAZI.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[23].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[24].Value = (object) DBNull.Value;
      }
      if (Original_ARACBAKIMDIS.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[25].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[26].Value = (object) Original_ARACBAKIMDIS.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[25].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[26].Value = (object) DBNull.Value;
      }
      if (Original_YAGBAKIM.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[27].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[28].Value = (object) Original_YAGBAKIM.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[27].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[28].Value = (object) DBNull.Value;
      }
      if (Original_ZORUNLUTRFKSIGORTA.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[29].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[30].Value = (object) Original_ZORUNLUTRFKSIGORTA.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[29].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[30].Value = (object) DBNull.Value;
      }
      if (Original_MUAYENE.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[31].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[32].Value = (object) Original_MUAYENE.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[31].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[32].Value = (object) DBNull.Value;
      }
      if (Original_BAIKRESMI.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[33].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[34].Value = (object) Original_BAIKRESMI.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[33].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[34].Value = (object) DBNull.Value;
      }
      if (Original_BAIKHIZMET.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[35].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[36].Value = (object) Original_BAIKHIZMET.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[35].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[36].Value = (object) DBNull.Value;
      }
      if (Original_YAKITMOTORIN.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[37].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[38].Value = (object) Original_YAKITMOTORIN.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[37].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[38].Value = (object) DBNull.Value;
      }
      if (Original_YAKITBENZIN.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[39].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[40].Value = (object) Original_YAKITBENZIN.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[39].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[40].Value = (object) DBNull.Value;
      }
      if (Original_RESMIKIRALIKMOTORIN.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[41].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[42].Value = (object) Original_RESMIKIRALIKMOTORIN.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[41].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[42].Value = (object) DBNull.Value;
      }
      if (Original_RESMIKIRALIKBENZIN.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[43].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[44].Value = (object) Original_RESMIKIRALIKBENZIN.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[43].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[44].Value = (object) DBNull.Value;
      }
      if (Original_SUBEMUDURU.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[45].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[46].Value = (object) Original_SUBEMUDURU.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[45].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[46].Value = (object) DBNull.Value;
      }
      if (Original_AYI == null)
      {
        this.Adapter.UpdateCommand.Parameters[47].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[48].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[47].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[48].Value = (object) Original_AYI;
      }
      this.Adapter.UpdateCommand.Parameters[49].Value = (object) ID;
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
      DateTime? TARIH,
      string YILI,
      int? ARACBAKIMATOLYE,
      int? ARACBAKIMARAZI,
      int? ARACBAKIMDIS,
      int? YAGBAKIM,
      int? ZORUNLUTRFKSIGORTA,
      int? MUAYENE,
      int? BAIKRESMI,
      int? BAIKHIZMET,
      Decimal? YAKITMOTORIN,
      Decimal? YAKITBENZIN,
      Decimal? RESMIKIRALIKMOTORIN,
      Decimal? RESMIKIRALIKBENZIN,
      int? SUBEMUDURU,
      string AYI,
      int Original_ID,
      DateTime? Original_TARIH,
      string Original_YILI,
      int? Original_ARACBAKIMATOLYE,
      int? Original_ARACBAKIMARAZI,
      int? Original_ARACBAKIMDIS,
      int? Original_YAGBAKIM,
      int? Original_ZORUNLUTRFKSIGORTA,
      int? Original_MUAYENE,
      int? Original_BAIKRESMI,
      int? Original_BAIKHIZMET,
      Decimal? Original_YAKITMOTORIN,
      Decimal? Original_YAKITBENZIN,
      Decimal? Original_RESMIKIRALIKMOTORIN,
      Decimal? Original_RESMIKIRALIKBENZIN,
      int? Original_SUBEMUDURU,
      string Original_AYI)
    {
      return this.Update(TARIH, YILI, ARACBAKIMATOLYE, ARACBAKIMARAZI, ARACBAKIMDIS, YAGBAKIM, ZORUNLUTRFKSIGORTA, MUAYENE, BAIKRESMI, BAIKHIZMET, YAKITMOTORIN, YAKITBENZIN, RESMIKIRALIKMOTORIN, RESMIKIRALIKBENZIN, SUBEMUDURU, AYI, Original_ID, Original_TARIH, Original_YILI, Original_ARACBAKIMATOLYE, Original_ARACBAKIMARAZI, Original_ARACBAKIMDIS, Original_YAGBAKIM, Original_ZORUNLUTRFKSIGORTA, Original_MUAYENE, Original_BAIKRESMI, Original_BAIKHIZMET, Original_YAKITMOTORIN, Original_YAKITBENZIN, Original_RESMIKIRALIKMOTORIN, Original_RESMIKIRALIKBENZIN, Original_SUBEMUDURU, Original_AYI, Original_ID);
    }
  }
}
