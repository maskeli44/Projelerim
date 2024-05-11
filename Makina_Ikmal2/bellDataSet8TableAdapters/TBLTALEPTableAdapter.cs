// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.bellDataSet8TableAdapters.TBLTALEPTableAdapter
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
  public class TBLTALEPTableAdapter : Component
  {
    private SqlDataAdapter _adapter;
    private SqlConnection _connection;
    private SqlTransaction _transaction;
    private SqlCommand[] _commandCollection;
    private bool _clearBeforeFill;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public TBLTALEPTableAdapter() => this.ClearBeforeFill = true;

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
        DataSetTable = "TBLTALEP",
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
            "BELGESAYI",
            "BELGESAYI"
          },
          {
            "BELGEKONU",
            "BELGEKONU"
          },
          {
            "BELGETARIH",
            "BELGETARIH"
          },
          {
            "ISINADI",
            "ISINADI"
          },
          {
            "ISINTURUMIKTARI",
            "ISINTURUMIKTARI"
          },
          {
            "ISINYAPYERI",
            "ISINYAPYERI"
          },
          {
            "BUTCETERTIBI",
            "BUTCETERTIBI"
          },
          {
            "IHALEUSULU",
            "IHALEUSULU"
          },
          {
            "YAKLASIKMALIYET",
            "YAKLASIKMALIYET"
          },
          {
            "KULLODENEKTUTAR",
            "KULLODENEKTUTAR"
          },
          {
            "ATOLYESEFID",
            "ATOLYESEFID"
          },
          {
            "DEPOYETKILIID",
            "DEPOYETKILIID"
          },
          {
            "SORUMLUID",
            "SORUMLUID"
          },
          {
            "MUDURID",
            "MUDURID"
          },
          {
            "DAIREBSKID",
            "DAIREBSKID"
          },
          {
            "GENELSEKYRDID",
            "GENELSEKYRDID"
          },
          {
            "GENELSEKRETERID",
            "GENELSEKRETERID"
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
            "BILGINOTU",
            "BILGINOTU"
          },
          {
            "TEKLIFID",
            "TEKLIFID"
          }
        }
      });
      this._adapter.DeleteCommand = new SqlCommand();
      this._adapter.DeleteCommand.Connection = this.Connection;
      this._adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[TBLTALEP] WHERE (([ID] = @Original_ID) AND ((@IsNull_KOD = 1 AND [KOD] IS NULL) OR ([KOD] = @Original_KOD)) AND ((@IsNull_TARIH = 1 AND [TARIH] IS NULL) OR ([TARIH] = @Original_TARIH)) AND ((@IsNull_SAAT = 1 AND [SAAT] IS NULL) OR ([SAAT] = @Original_SAAT)) AND ((@IsNull_BELGESAYI = 1 AND [BELGESAYI] IS NULL) OR ([BELGESAYI] = @Original_BELGESAYI)) AND ((@IsNull_BELGEKONU = 1 AND [BELGEKONU] IS NULL) OR ([BELGEKONU] = @Original_BELGEKONU)) AND ((@IsNull_BELGETARIH = 1 AND [BELGETARIH] IS NULL) OR ([BELGETARIH] = @Original_BELGETARIH)) AND ((@IsNull_ISINADI = 1 AND [ISINADI] IS NULL) OR ([ISINADI] = @Original_ISINADI)) AND ((@IsNull_ISINTURUMIKTARI = 1 AND [ISINTURUMIKTARI] IS NULL) OR ([ISINTURUMIKTARI] = @Original_ISINTURUMIKTARI)) AND ((@IsNull_ISINYAPYERI = 1 AND [ISINYAPYERI] IS NULL) OR ([ISINYAPYERI] = @Original_ISINYAPYERI)) AND ((@IsNull_BUTCETERTIBI = 1 AND [BUTCETERTIBI] IS NULL) OR ([BUTCETERTIBI] = @Original_BUTCETERTIBI)) AND ((@IsNull_IHALEUSULU = 1 AND [IHALEUSULU] IS NULL) OR ([IHALEUSULU] = @Original_IHALEUSULU)) AND ((@IsNull_YAKLASIKMALIYET = 1 AND [YAKLASIKMALIYET] IS NULL) OR ([YAKLASIKMALIYET] = @Original_YAKLASIKMALIYET)) AND ((@IsNull_KULLODENEKTUTAR = 1 AND [KULLODENEKTUTAR] IS NULL) OR ([KULLODENEKTUTAR] = @Original_KULLODENEKTUTAR)) AND ((@IsNull_ATOLYESEFID = 1 AND [ATOLYESEFID] IS NULL) OR ([ATOLYESEFID] = @Original_ATOLYESEFID)) AND ((@IsNull_DEPOYETKILIID = 1 AND [DEPOYETKILIID] IS NULL) OR ([DEPOYETKILIID] = @Original_DEPOYETKILIID)) AND ((@IsNull_SORUMLUID = 1 AND [SORUMLUID] IS NULL) OR ([SORUMLUID] = @Original_SORUMLUID)) AND ((@IsNull_MUDURID = 1 AND [MUDURID] IS NULL) OR ([MUDURID] = @Original_MUDURID)) AND ((@IsNull_DAIREBSKID = 1 AND [DAIREBSKID] IS NULL) OR ([DAIREBSKID] = @Original_DAIREBSKID)) AND ((@IsNull_GENELSEKYRDID = 1 AND [GENELSEKYRDID] IS NULL) OR ([GENELSEKYRDID] = @Original_GENELSEKYRDID)) AND ((@IsNull_GENELSEKRETERID = 1 AND [GENELSEKRETERID] IS NULL) OR ([GENELSEKRETERID] = @Original_GENELSEKRETERID)) AND ((@IsNull_SAVEUSER = 1 AND [SAVEUSER] IS NULL) OR ([SAVEUSER] = @Original_SAVEUSER)) AND ((@IsNull_SAVEDATE = 1 AND [SAVEDATE] IS NULL) OR ([SAVEDATE] = @Original_SAVEDATE)) AND ((@IsNull_EDITUSER = 1 AND [EDITUSER] IS NULL) OR ([EDITUSER] = @Original_EDITUSER)) AND ((@IsNull_EDITDATE = 1 AND [EDITDATE] IS NULL) OR ([EDITDATE] = @Original_EDITDATE)) AND ((@IsNull_SAVEMAC = 1 AND [SAVEMAC] IS NULL) OR ([SAVEMAC] = @Original_SAVEMAC)) AND ((@IsNull_EDITMAC = 1 AND [EDITMAC] IS NULL) OR ([EDITMAC] = @Original_EDITMAC)) AND ((@IsNull_SAVEIP = 1 AND [SAVEIP] IS NULL) OR ([SAVEIP] = @Original_SAVEIP)) AND ((@IsNull_EDITIP = 1 AND [EDITIP] IS NULL) OR ([EDITIP] = @Original_EDITIP)) AND ((@IsNull_BILGINOTU = 1 AND [BILGINOTU] IS NULL) OR ([BILGINOTU] = @Original_BILGINOTU)) AND ((@IsNull_TEKLIFID = 1 AND [TEKLIFID] IS NULL) OR ([TEKLIFID] = @Original_TEKLIFID)))";
      this._adapter.DeleteCommand.CommandType = CommandType.Text;
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_KOD", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_KOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TARIH", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TARIH", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TARIH", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TARIH", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SAAT", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAAT", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SAAT", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAAT", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_BELGESAYI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELGESAYI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_BELGESAYI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELGESAYI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_BELGEKONU", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELGEKONU", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_BELGEKONU", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELGEKONU", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_BELGETARIH", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELGETARIH", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_BELGETARIH", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELGETARIH", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ISINADI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISINADI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ISINADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISINADI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ISINTURUMIKTARI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISINTURUMIKTARI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ISINTURUMIKTARI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISINTURUMIKTARI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ISINYAPYERI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISINYAPYERI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ISINYAPYERI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISINYAPYERI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_BUTCETERTIBI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BUTCETERTIBI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_BUTCETERTIBI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BUTCETERTIBI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_IHALEUSULU", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IHALEUSULU", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_IHALEUSULU", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IHALEUSULU", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_YAKLASIKMALIYET", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YAKLASIKMALIYET", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_YAKLASIKMALIYET", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YAKLASIKMALIYET", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_KULLODENEKTUTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KULLODENEKTUTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_KULLODENEKTUTAR", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KULLODENEKTUTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ATOLYESEFID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ATOLYESEFID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ATOLYESEFID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ATOLYESEFID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_DEPOYETKILIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DEPOYETKILIID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_DEPOYETKILIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DEPOYETKILIID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SORUMLUID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SORUMLUID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SORUMLUID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SORUMLUID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_MUDURID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MUDURID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_MUDURID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MUDURID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_DAIREBSKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DAIREBSKID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_DAIREBSKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DAIREBSKID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_GENELSEKYRDID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GENELSEKYRDID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_GENELSEKYRDID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GENELSEKYRDID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_GENELSEKRETERID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GENELSEKRETERID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_GENELSEKRETERID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GENELSEKRETERID", DataRowVersion.Original, false, (object) null, "", "", ""));
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
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_BILGINOTU", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BILGINOTU", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_BILGINOTU", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BILGINOTU", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TEKLIFID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TEKLIFID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TEKLIFID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TEKLIFID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.InsertCommand = new SqlCommand();
      this._adapter.InsertCommand.Connection = this.Connection;
      this._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[TBLTALEP] ([KOD], [TARIH], [SAAT], [BELGESAYI], [BELGEKONU], [BELGETARIH], [ISINADI], [ISINTURUMIKTARI], [ISINYAPYERI], [BUTCETERTIBI], [IHALEUSULU], [YAKLASIKMALIYET], [KULLODENEKTUTAR], [ATOLYESEFID], [DEPOYETKILIID], [SORUMLUID], [MUDURID], [DAIREBSKID], [GENELSEKYRDID], [GENELSEKRETERID], [SAVEUSER], [SAVEDATE], [EDITUSER], [EDITDATE], [SAVEMAC], [EDITMAC], [SAVEIP], [EDITIP], [BILGINOTU], [TEKLIFID]) VALUES (@KOD, @TARIH, @SAAT, @BELGESAYI, @BELGEKONU, @BELGETARIH, @ISINADI, @ISINTURUMIKTARI, @ISINYAPYERI, @BUTCETERTIBI, @IHALEUSULU, @YAKLASIKMALIYET, @KULLODENEKTUTAR, @ATOLYESEFID, @DEPOYETKILIID, @SORUMLUID, @MUDURID, @DAIREBSKID, @GENELSEKYRDID, @GENELSEKRETERID, @SAVEUSER, @SAVEDATE, @EDITUSER, @EDITDATE, @SAVEMAC, @EDITMAC, @SAVEIP, @EDITIP, @BILGINOTU, @TEKLIFID);\r\nSELECT ID, KOD, TARIH, SAAT, BELGESAYI, BELGEKONU, BELGETARIH, ISINADI, ISINTURUMIKTARI, ISINYAPYERI, BUTCETERTIBI, IHALEUSULU, YAKLASIKMALIYET, KULLODENEKTUTAR, ATOLYESEFID, DEPOYETKILIID, SORUMLUID, MUDURID, DAIREBSKID, GENELSEKYRDID, GENELSEKRETERID, SAVEUSER, SAVEDATE, EDITUSER, EDITDATE, SAVEMAC, EDITMAC, SAVEIP, EDITIP, BILGINOTU, TEKLIFID FROM TBLTALEP WHERE (ID = SCOPE_IDENTITY())";
      this._adapter.InsertCommand.CommandType = CommandType.Text;
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@KOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@TARIH", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TARIH", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SAAT", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAAT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@BELGESAYI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELGESAYI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@BELGEKONU", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELGEKONU", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@BELGETARIH", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELGETARIH", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ISINADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISINADI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ISINTURUMIKTARI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISINTURUMIKTARI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ISINYAPYERI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISINYAPYERI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@BUTCETERTIBI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BUTCETERTIBI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@IHALEUSULU", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IHALEUSULU", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@YAKLASIKMALIYET", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YAKLASIKMALIYET", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@KULLODENEKTUTAR", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KULLODENEKTUTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ATOLYESEFID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ATOLYESEFID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@DEPOYETKILIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DEPOYETKILIID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SORUMLUID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SORUMLUID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@MUDURID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MUDURID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@DAIREBSKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DAIREBSKID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@GENELSEKYRDID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GENELSEKYRDID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@GENELSEKRETERID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GENELSEKRETERID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SAVEUSER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEUSER", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SAVEDATE", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEDATE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@EDITUSER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITUSER", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@EDITDATE", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITDATE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SAVEMAC", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEMAC", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@EDITMAC", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITMAC", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SAVEIP", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEIP", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@EDITIP", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITIP", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@BILGINOTU", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BILGINOTU", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@TEKLIFID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TEKLIFID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand = new SqlCommand();
      this._adapter.UpdateCommand.Connection = this.Connection;
      this._adapter.UpdateCommand.CommandText = "UPDATE [dbo].[TBLTALEP] SET [KOD] = @KOD, [TARIH] = @TARIH, [SAAT] = @SAAT, [BELGESAYI] = @BELGESAYI, [BELGEKONU] = @BELGEKONU, [BELGETARIH] = @BELGETARIH, [ISINADI] = @ISINADI, [ISINTURUMIKTARI] = @ISINTURUMIKTARI, [ISINYAPYERI] = @ISINYAPYERI, [BUTCETERTIBI] = @BUTCETERTIBI, [IHALEUSULU] = @IHALEUSULU, [YAKLASIKMALIYET] = @YAKLASIKMALIYET, [KULLODENEKTUTAR] = @KULLODENEKTUTAR, [ATOLYESEFID] = @ATOLYESEFID, [DEPOYETKILIID] = @DEPOYETKILIID, [SORUMLUID] = @SORUMLUID, [MUDURID] = @MUDURID, [DAIREBSKID] = @DAIREBSKID, [GENELSEKYRDID] = @GENELSEKYRDID, [GENELSEKRETERID] = @GENELSEKRETERID, [SAVEUSER] = @SAVEUSER, [SAVEDATE] = @SAVEDATE, [EDITUSER] = @EDITUSER, [EDITDATE] = @EDITDATE, [SAVEMAC] = @SAVEMAC, [EDITMAC] = @EDITMAC, [SAVEIP] = @SAVEIP, [EDITIP] = @EDITIP, [BILGINOTU] = @BILGINOTU, [TEKLIFID] = @TEKLIFID WHERE (([ID] = @Original_ID) AND ((@IsNull_KOD = 1 AND [KOD] IS NULL) OR ([KOD] = @Original_KOD)) AND ((@IsNull_TARIH = 1 AND [TARIH] IS NULL) OR ([TARIH] = @Original_TARIH)) AND ((@IsNull_SAAT = 1 AND [SAAT] IS NULL) OR ([SAAT] = @Original_SAAT)) AND ((@IsNull_BELGESAYI = 1 AND [BELGESAYI] IS NULL) OR ([BELGESAYI] = @Original_BELGESAYI)) AND ((@IsNull_BELGEKONU = 1 AND [BELGEKONU] IS NULL) OR ([BELGEKONU] = @Original_BELGEKONU)) AND ((@IsNull_BELGETARIH = 1 AND [BELGETARIH] IS NULL) OR ([BELGETARIH] = @Original_BELGETARIH)) AND ((@IsNull_ISINADI = 1 AND [ISINADI] IS NULL) OR ([ISINADI] = @Original_ISINADI)) AND ((@IsNull_ISINTURUMIKTARI = 1 AND [ISINTURUMIKTARI] IS NULL) OR ([ISINTURUMIKTARI] = @Original_ISINTURUMIKTARI)) AND ((@IsNull_ISINYAPYERI = 1 AND [ISINYAPYERI] IS NULL) OR ([ISINYAPYERI] = @Original_ISINYAPYERI)) AND ((@IsNull_BUTCETERTIBI = 1 AND [BUTCETERTIBI] IS NULL) OR ([BUTCETERTIBI] = @Original_BUTCETERTIBI)) AND ((@IsNull_IHALEUSULU = 1 AND [IHALEUSULU] IS NULL) OR ([IHALEUSULU] = @Original_IHALEUSULU)) AND ((@IsNull_YAKLASIKMALIYET = 1 AND [YAKLASIKMALIYET] IS NULL) OR ([YAKLASIKMALIYET] = @Original_YAKLASIKMALIYET)) AND ((@IsNull_KULLODENEKTUTAR = 1 AND [KULLODENEKTUTAR] IS NULL) OR ([KULLODENEKTUTAR] = @Original_KULLODENEKTUTAR)) AND ((@IsNull_ATOLYESEFID = 1 AND [ATOLYESEFID] IS NULL) OR ([ATOLYESEFID] = @Original_ATOLYESEFID)) AND ((@IsNull_DEPOYETKILIID = 1 AND [DEPOYETKILIID] IS NULL) OR ([DEPOYETKILIID] = @Original_DEPOYETKILIID)) AND ((@IsNull_SORUMLUID = 1 AND [SORUMLUID] IS NULL) OR ([SORUMLUID] = @Original_SORUMLUID)) AND ((@IsNull_MUDURID = 1 AND [MUDURID] IS NULL) OR ([MUDURID] = @Original_MUDURID)) AND ((@IsNull_DAIREBSKID = 1 AND [DAIREBSKID] IS NULL) OR ([DAIREBSKID] = @Original_DAIREBSKID)) AND ((@IsNull_GENELSEKYRDID = 1 AND [GENELSEKYRDID] IS NULL) OR ([GENELSEKYRDID] = @Original_GENELSEKYRDID)) AND ((@IsNull_GENELSEKRETERID = 1 AND [GENELSEKRETERID] IS NULL) OR ([GENELSEKRETERID] = @Original_GENELSEKRETERID)) AND ((@IsNull_SAVEUSER = 1 AND [SAVEUSER] IS NULL) OR ([SAVEUSER] = @Original_SAVEUSER)) AND ((@IsNull_SAVEDATE = 1 AND [SAVEDATE] IS NULL) OR ([SAVEDATE] = @Original_SAVEDATE)) AND ((@IsNull_EDITUSER = 1 AND [EDITUSER] IS NULL) OR ([EDITUSER] = @Original_EDITUSER)) AND ((@IsNull_EDITDATE = 1 AND [EDITDATE] IS NULL) OR ([EDITDATE] = @Original_EDITDATE)) AND ((@IsNull_SAVEMAC = 1 AND [SAVEMAC] IS NULL) OR ([SAVEMAC] = @Original_SAVEMAC)) AND ((@IsNull_EDITMAC = 1 AND [EDITMAC] IS NULL) OR ([EDITMAC] = @Original_EDITMAC)) AND ((@IsNull_SAVEIP = 1 AND [SAVEIP] IS NULL) OR ([SAVEIP] = @Original_SAVEIP)) AND ((@IsNull_EDITIP = 1 AND [EDITIP] IS NULL) OR ([EDITIP] = @Original_EDITIP)) AND ((@IsNull_BILGINOTU = 1 AND [BILGINOTU] IS NULL) OR ([BILGINOTU] = @Original_BILGINOTU)) AND ((@IsNull_TEKLIFID = 1 AND [TEKLIFID] IS NULL) OR ([TEKLIFID] = @Original_TEKLIFID)));\r\nSELECT ID, KOD, TARIH, SAAT, BELGESAYI, BELGEKONU, BELGETARIH, ISINADI, ISINTURUMIKTARI, ISINYAPYERI, BUTCETERTIBI, IHALEUSULU, YAKLASIKMALIYET, KULLODENEKTUTAR, ATOLYESEFID, DEPOYETKILIID, SORUMLUID, MUDURID, DAIREBSKID, GENELSEKYRDID, GENELSEKRETERID, SAVEUSER, SAVEDATE, EDITUSER, EDITDATE, SAVEMAC, EDITMAC, SAVEIP, EDITIP, BILGINOTU, TEKLIFID FROM TBLTALEP WHERE (ID = @ID)";
      this._adapter.UpdateCommand.CommandType = CommandType.Text;
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@KOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TARIH", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TARIH", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SAAT", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAAT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@BELGESAYI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELGESAYI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@BELGEKONU", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELGEKONU", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@BELGETARIH", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELGETARIH", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ISINADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISINADI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ISINTURUMIKTARI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISINTURUMIKTARI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ISINYAPYERI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISINYAPYERI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@BUTCETERTIBI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BUTCETERTIBI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IHALEUSULU", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IHALEUSULU", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@YAKLASIKMALIYET", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YAKLASIKMALIYET", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@KULLODENEKTUTAR", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KULLODENEKTUTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ATOLYESEFID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ATOLYESEFID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@DEPOYETKILIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DEPOYETKILIID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SORUMLUID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SORUMLUID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MUDURID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MUDURID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@DAIREBSKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DAIREBSKID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@GENELSEKYRDID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GENELSEKYRDID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@GENELSEKRETERID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GENELSEKRETERID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SAVEUSER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEUSER", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SAVEDATE", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEDATE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EDITUSER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITUSER", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EDITDATE", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITDATE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SAVEMAC", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEMAC", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EDITMAC", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITMAC", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SAVEIP", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEIP", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EDITIP", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITIP", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@BILGINOTU", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BILGINOTU", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TEKLIFID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TEKLIFID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_KOD", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_KOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TARIH", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TARIH", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TARIH", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TARIH", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SAAT", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAAT", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SAAT", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAAT", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_BELGESAYI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELGESAYI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_BELGESAYI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELGESAYI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_BELGEKONU", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELGEKONU", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_BELGEKONU", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELGEKONU", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_BELGETARIH", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELGETARIH", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_BELGETARIH", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BELGETARIH", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ISINADI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISINADI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ISINADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISINADI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ISINTURUMIKTARI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISINTURUMIKTARI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ISINTURUMIKTARI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISINTURUMIKTARI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ISINYAPYERI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISINYAPYERI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ISINYAPYERI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISINYAPYERI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_BUTCETERTIBI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BUTCETERTIBI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_BUTCETERTIBI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BUTCETERTIBI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_IHALEUSULU", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IHALEUSULU", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_IHALEUSULU", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IHALEUSULU", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_YAKLASIKMALIYET", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YAKLASIKMALIYET", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_YAKLASIKMALIYET", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YAKLASIKMALIYET", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_KULLODENEKTUTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KULLODENEKTUTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_KULLODENEKTUTAR", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KULLODENEKTUTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ATOLYESEFID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ATOLYESEFID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ATOLYESEFID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ATOLYESEFID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_DEPOYETKILIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DEPOYETKILIID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_DEPOYETKILIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DEPOYETKILIID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SORUMLUID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SORUMLUID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SORUMLUID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SORUMLUID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_MUDURID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MUDURID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_MUDURID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MUDURID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_DAIREBSKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DAIREBSKID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_DAIREBSKID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DAIREBSKID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_GENELSEKYRDID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GENELSEKYRDID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_GENELSEKYRDID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GENELSEKYRDID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_GENELSEKRETERID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GENELSEKRETERID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_GENELSEKRETERID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GENELSEKRETERID", DataRowVersion.Original, false, (object) null, "", "", ""));
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
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_BILGINOTU", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BILGINOTU", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_BILGINOTU", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BILGINOTU", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TEKLIFID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TEKLIFID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TEKLIFID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TEKLIFID", DataRowVersion.Original, false, (object) null, "", "", ""));
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
      this._commandCollection[0].CommandText = "SELECT ID, KOD, TARIH, SAAT, BELGESAYI, BELGEKONU, BELGETARIH, ISINADI, ISINTURUMIKTARI, ISINYAPYERI, BUTCETERTIBI, IHALEUSULU, YAKLASIKMALIYET, KULLODENEKTUTAR, ATOLYESEFID, DEPOYETKILIID, SORUMLUID, MUDURID, DAIREBSKID, GENELSEKYRDID, GENELSEKRETERID, SAVEUSER, SAVEDATE, EDITUSER, EDITDATE, SAVEMAC, EDITMAC, SAVEIP, EDITIP, BILGINOTU, TEKLIFID FROM dbo.TBLTALEP";
      this._commandCollection[0].CommandType = CommandType.Text;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    public virtual int Fill(bellDataSet8.TBLTALEPDataTable dataTable)
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
    public virtual bellDataSet8.TBLTALEPDataTable GetData()
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      bellDataSet8.TBLTALEPDataTable data = new bellDataSet8.TBLTALEPDataTable();
      this.Adapter.Fill((DataTable) data);
      return data;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(bellDataSet8.TBLTALEPDataTable dataTable) => this.Adapter.Update((DataTable) dataTable);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(bellDataSet8 dataSet) => this.Adapter.Update((DataSet) dataSet, "TBLTALEP");

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
      string Original_BELGESAYI,
      string Original_BELGEKONU,
      DateTime? Original_BELGETARIH,
      string Original_ISINADI,
      string Original_ISINTURUMIKTARI,
      string Original_ISINYAPYERI,
      string Original_BUTCETERTIBI,
      string Original_IHALEUSULU,
      string Original_YAKLASIKMALIYET,
      string Original_KULLODENEKTUTAR,
      int? Original_ATOLYESEFID,
      int? Original_DEPOYETKILIID,
      int? Original_SORUMLUID,
      int? Original_MUDURID,
      int? Original_DAIREBSKID,
      int? Original_GENELSEKYRDID,
      int? Original_GENELSEKRETERID,
      string Original_SAVEUSER,
      DateTime? Original_SAVEDATE,
      string Original_EDITUSER,
      DateTime? Original_EDITDATE,
      string Original_SAVEMAC,
      string Original_EDITMAC,
      string Original_SAVEIP,
      string Original_EDITIP,
      string Original_BILGINOTU,
      int? Original_TEKLIFID)
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
      if (Original_BELGESAYI == null)
      {
        this.Adapter.DeleteCommand.Parameters[7].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[8].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[7].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[8].Value = (object) Original_BELGESAYI;
      }
      if (Original_BELGEKONU == null)
      {
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) Original_BELGEKONU;
      }
      if (Original_BELGETARIH.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[11].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[12].Value = (object) Original_BELGETARIH.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[11].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[12].Value = (object) DBNull.Value;
      }
      if (Original_ISINADI == null)
      {
        this.Adapter.DeleteCommand.Parameters[13].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[14].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[13].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[14].Value = (object) Original_ISINADI;
      }
      if (Original_ISINTURUMIKTARI == null)
      {
        this.Adapter.DeleteCommand.Parameters[15].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[16].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[15].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[16].Value = (object) Original_ISINTURUMIKTARI;
      }
      if (Original_ISINYAPYERI == null)
      {
        this.Adapter.DeleteCommand.Parameters[17].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[18].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[17].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[18].Value = (object) Original_ISINYAPYERI;
      }
      if (Original_BUTCETERTIBI == null)
      {
        this.Adapter.DeleteCommand.Parameters[19].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[20].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[19].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[20].Value = (object) Original_BUTCETERTIBI;
      }
      if (Original_IHALEUSULU == null)
      {
        this.Adapter.DeleteCommand.Parameters[21].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[22].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[21].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[22].Value = (object) Original_IHALEUSULU;
      }
      if (Original_YAKLASIKMALIYET == null)
      {
        this.Adapter.DeleteCommand.Parameters[23].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[24].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[23].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[24].Value = (object) Original_YAKLASIKMALIYET;
      }
      if (Original_KULLODENEKTUTAR == null)
      {
        this.Adapter.DeleteCommand.Parameters[25].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[26].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[25].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[26].Value = (object) Original_KULLODENEKTUTAR;
      }
      if (Original_ATOLYESEFID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[27].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[28].Value = (object) Original_ATOLYESEFID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[27].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[28].Value = (object) DBNull.Value;
      }
      if (Original_DEPOYETKILIID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[29].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[30].Value = (object) Original_DEPOYETKILIID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[29].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[30].Value = (object) DBNull.Value;
      }
      if (Original_SORUMLUID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[31].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[32].Value = (object) Original_SORUMLUID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[31].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[32].Value = (object) DBNull.Value;
      }
      if (Original_MUDURID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[33].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[34].Value = (object) Original_MUDURID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[33].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[34].Value = (object) DBNull.Value;
      }
      if (Original_DAIREBSKID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[35].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[36].Value = (object) Original_DAIREBSKID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[35].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[36].Value = (object) DBNull.Value;
      }
      if (Original_GENELSEKYRDID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[37].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[38].Value = (object) Original_GENELSEKYRDID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[37].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[38].Value = (object) DBNull.Value;
      }
      if (Original_GENELSEKRETERID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[39].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[40].Value = (object) Original_GENELSEKRETERID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[39].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[40].Value = (object) DBNull.Value;
      }
      if (Original_SAVEUSER == null)
      {
        this.Adapter.DeleteCommand.Parameters[41].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[42].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[41].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[42].Value = (object) Original_SAVEUSER;
      }
      if (Original_SAVEDATE.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[43].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[44].Value = (object) Original_SAVEDATE.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[43].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[44].Value = (object) DBNull.Value;
      }
      if (Original_EDITUSER == null)
      {
        this.Adapter.DeleteCommand.Parameters[45].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[46].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[45].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[46].Value = (object) Original_EDITUSER;
      }
      if (Original_EDITDATE.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[47].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[48].Value = (object) Original_EDITDATE.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[47].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[48].Value = (object) DBNull.Value;
      }
      if (Original_SAVEMAC == null)
      {
        this.Adapter.DeleteCommand.Parameters[49].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[50].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[49].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[50].Value = (object) Original_SAVEMAC;
      }
      if (Original_EDITMAC == null)
      {
        this.Adapter.DeleteCommand.Parameters[51].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[52].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[51].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[52].Value = (object) Original_EDITMAC;
      }
      if (Original_SAVEIP == null)
      {
        this.Adapter.DeleteCommand.Parameters[53].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[54].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[53].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[54].Value = (object) Original_SAVEIP;
      }
      if (Original_EDITIP == null)
      {
        this.Adapter.DeleteCommand.Parameters[55].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[56].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[55].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[56].Value = (object) Original_EDITIP;
      }
      if (Original_BILGINOTU == null)
      {
        this.Adapter.DeleteCommand.Parameters[57].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[58].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[57].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[58].Value = (object) Original_BILGINOTU;
      }
      if (Original_TEKLIFID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[59].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[60].Value = (object) Original_TEKLIFID.Value;
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
      DateTime? TARIH,
      DateTime? SAAT,
      string BELGESAYI,
      string BELGEKONU,
      DateTime? BELGETARIH,
      string ISINADI,
      string ISINTURUMIKTARI,
      string ISINYAPYERI,
      string BUTCETERTIBI,
      string IHALEUSULU,
      string YAKLASIKMALIYET,
      string KULLODENEKTUTAR,
      int? ATOLYESEFID,
      int? DEPOYETKILIID,
      int? SORUMLUID,
      int? MUDURID,
      int? DAIREBSKID,
      int? GENELSEKYRDID,
      int? GENELSEKRETERID,
      string SAVEUSER,
      DateTime? SAVEDATE,
      string EDITUSER,
      DateTime? EDITDATE,
      string SAVEMAC,
      string EDITMAC,
      string SAVEIP,
      string EDITIP,
      string BILGINOTU,
      int? TEKLIFID)
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
      if (BELGESAYI == null)
        this.Adapter.InsertCommand.Parameters[3].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[3].Value = (object) BELGESAYI;
      if (BELGEKONU == null)
        this.Adapter.InsertCommand.Parameters[4].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[4].Value = (object) BELGEKONU;
      if (BELGETARIH.HasValue)
        this.Adapter.InsertCommand.Parameters[5].Value = (object) BELGETARIH.Value;
      else
        this.Adapter.InsertCommand.Parameters[5].Value = (object) DBNull.Value;
      if (ISINADI == null)
        this.Adapter.InsertCommand.Parameters[6].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[6].Value = (object) ISINADI;
      if (ISINTURUMIKTARI == null)
        this.Adapter.InsertCommand.Parameters[7].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[7].Value = (object) ISINTURUMIKTARI;
      if (ISINYAPYERI == null)
        this.Adapter.InsertCommand.Parameters[8].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[8].Value = (object) ISINYAPYERI;
      if (BUTCETERTIBI == null)
        this.Adapter.InsertCommand.Parameters[9].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[9].Value = (object) BUTCETERTIBI;
      if (IHALEUSULU == null)
        this.Adapter.InsertCommand.Parameters[10].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[10].Value = (object) IHALEUSULU;
      if (YAKLASIKMALIYET == null)
        this.Adapter.InsertCommand.Parameters[11].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[11].Value = (object) YAKLASIKMALIYET;
      if (KULLODENEKTUTAR == null)
        this.Adapter.InsertCommand.Parameters[12].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[12].Value = (object) KULLODENEKTUTAR;
      if (ATOLYESEFID.HasValue)
        this.Adapter.InsertCommand.Parameters[13].Value = (object) ATOLYESEFID.Value;
      else
        this.Adapter.InsertCommand.Parameters[13].Value = (object) DBNull.Value;
      if (DEPOYETKILIID.HasValue)
        this.Adapter.InsertCommand.Parameters[14].Value = (object) DEPOYETKILIID.Value;
      else
        this.Adapter.InsertCommand.Parameters[14].Value = (object) DBNull.Value;
      if (SORUMLUID.HasValue)
        this.Adapter.InsertCommand.Parameters[15].Value = (object) SORUMLUID.Value;
      else
        this.Adapter.InsertCommand.Parameters[15].Value = (object) DBNull.Value;
      if (MUDURID.HasValue)
        this.Adapter.InsertCommand.Parameters[16].Value = (object) MUDURID.Value;
      else
        this.Adapter.InsertCommand.Parameters[16].Value = (object) DBNull.Value;
      if (DAIREBSKID.HasValue)
        this.Adapter.InsertCommand.Parameters[17].Value = (object) DAIREBSKID.Value;
      else
        this.Adapter.InsertCommand.Parameters[17].Value = (object) DBNull.Value;
      if (GENELSEKYRDID.HasValue)
        this.Adapter.InsertCommand.Parameters[18].Value = (object) GENELSEKYRDID.Value;
      else
        this.Adapter.InsertCommand.Parameters[18].Value = (object) DBNull.Value;
      if (GENELSEKRETERID.HasValue)
        this.Adapter.InsertCommand.Parameters[19].Value = (object) GENELSEKRETERID.Value;
      else
        this.Adapter.InsertCommand.Parameters[19].Value = (object) DBNull.Value;
      if (SAVEUSER == null)
        this.Adapter.InsertCommand.Parameters[20].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[20].Value = (object) SAVEUSER;
      if (SAVEDATE.HasValue)
        this.Adapter.InsertCommand.Parameters[21].Value = (object) SAVEDATE.Value;
      else
        this.Adapter.InsertCommand.Parameters[21].Value = (object) DBNull.Value;
      if (EDITUSER == null)
        this.Adapter.InsertCommand.Parameters[22].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[22].Value = (object) EDITUSER;
      if (EDITDATE.HasValue)
        this.Adapter.InsertCommand.Parameters[23].Value = (object) EDITDATE.Value;
      else
        this.Adapter.InsertCommand.Parameters[23].Value = (object) DBNull.Value;
      if (SAVEMAC == null)
        this.Adapter.InsertCommand.Parameters[24].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[24].Value = (object) SAVEMAC;
      if (EDITMAC == null)
        this.Adapter.InsertCommand.Parameters[25].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[25].Value = (object) EDITMAC;
      if (SAVEIP == null)
        this.Adapter.InsertCommand.Parameters[26].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[26].Value = (object) SAVEIP;
      if (EDITIP == null)
        this.Adapter.InsertCommand.Parameters[27].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[27].Value = (object) EDITIP;
      if (BILGINOTU == null)
        this.Adapter.InsertCommand.Parameters[28].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[28].Value = (object) BILGINOTU;
      if (TEKLIFID.HasValue)
        this.Adapter.InsertCommand.Parameters[29].Value = (object) TEKLIFID.Value;
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
      DateTime? TARIH,
      DateTime? SAAT,
      string BELGESAYI,
      string BELGEKONU,
      DateTime? BELGETARIH,
      string ISINADI,
      string ISINTURUMIKTARI,
      string ISINYAPYERI,
      string BUTCETERTIBI,
      string IHALEUSULU,
      string YAKLASIKMALIYET,
      string KULLODENEKTUTAR,
      int? ATOLYESEFID,
      int? DEPOYETKILIID,
      int? SORUMLUID,
      int? MUDURID,
      int? DAIREBSKID,
      int? GENELSEKYRDID,
      int? GENELSEKRETERID,
      string SAVEUSER,
      DateTime? SAVEDATE,
      string EDITUSER,
      DateTime? EDITDATE,
      string SAVEMAC,
      string EDITMAC,
      string SAVEIP,
      string EDITIP,
      string BILGINOTU,
      int? TEKLIFID,
      int Original_ID,
      string Original_KOD,
      DateTime? Original_TARIH,
      DateTime? Original_SAAT,
      string Original_BELGESAYI,
      string Original_BELGEKONU,
      DateTime? Original_BELGETARIH,
      string Original_ISINADI,
      string Original_ISINTURUMIKTARI,
      string Original_ISINYAPYERI,
      string Original_BUTCETERTIBI,
      string Original_IHALEUSULU,
      string Original_YAKLASIKMALIYET,
      string Original_KULLODENEKTUTAR,
      int? Original_ATOLYESEFID,
      int? Original_DEPOYETKILIID,
      int? Original_SORUMLUID,
      int? Original_MUDURID,
      int? Original_DAIREBSKID,
      int? Original_GENELSEKYRDID,
      int? Original_GENELSEKRETERID,
      string Original_SAVEUSER,
      DateTime? Original_SAVEDATE,
      string Original_EDITUSER,
      DateTime? Original_EDITDATE,
      string Original_SAVEMAC,
      string Original_EDITMAC,
      string Original_SAVEIP,
      string Original_EDITIP,
      string Original_BILGINOTU,
      int? Original_TEKLIFID,
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
      if (BELGESAYI == null)
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) BELGESAYI;
      if (BELGEKONU == null)
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) BELGEKONU;
      if (BELGETARIH.HasValue)
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) BELGETARIH.Value;
      else
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) DBNull.Value;
      if (ISINADI == null)
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) ISINADI;
      if (ISINTURUMIKTARI == null)
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) ISINTURUMIKTARI;
      if (ISINYAPYERI == null)
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) ISINYAPYERI;
      if (BUTCETERTIBI == null)
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) BUTCETERTIBI;
      if (IHALEUSULU == null)
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) IHALEUSULU;
      if (YAKLASIKMALIYET == null)
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) YAKLASIKMALIYET;
      if (KULLODENEKTUTAR == null)
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) KULLODENEKTUTAR;
      if (ATOLYESEFID.HasValue)
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) ATOLYESEFID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) DBNull.Value;
      if (DEPOYETKILIID.HasValue)
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) DEPOYETKILIID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) DBNull.Value;
      if (SORUMLUID.HasValue)
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) SORUMLUID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) DBNull.Value;
      if (MUDURID.HasValue)
        this.Adapter.UpdateCommand.Parameters[16].Value = (object) MUDURID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[16].Value = (object) DBNull.Value;
      if (DAIREBSKID.HasValue)
        this.Adapter.UpdateCommand.Parameters[17].Value = (object) DAIREBSKID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[17].Value = (object) DBNull.Value;
      if (GENELSEKYRDID.HasValue)
        this.Adapter.UpdateCommand.Parameters[18].Value = (object) GENELSEKYRDID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[18].Value = (object) DBNull.Value;
      if (GENELSEKRETERID.HasValue)
        this.Adapter.UpdateCommand.Parameters[19].Value = (object) GENELSEKRETERID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[19].Value = (object) DBNull.Value;
      if (SAVEUSER == null)
        this.Adapter.UpdateCommand.Parameters[20].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[20].Value = (object) SAVEUSER;
      if (SAVEDATE.HasValue)
        this.Adapter.UpdateCommand.Parameters[21].Value = (object) SAVEDATE.Value;
      else
        this.Adapter.UpdateCommand.Parameters[21].Value = (object) DBNull.Value;
      if (EDITUSER == null)
        this.Adapter.UpdateCommand.Parameters[22].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[22].Value = (object) EDITUSER;
      if (EDITDATE.HasValue)
        this.Adapter.UpdateCommand.Parameters[23].Value = (object) EDITDATE.Value;
      else
        this.Adapter.UpdateCommand.Parameters[23].Value = (object) DBNull.Value;
      if (SAVEMAC == null)
        this.Adapter.UpdateCommand.Parameters[24].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[24].Value = (object) SAVEMAC;
      if (EDITMAC == null)
        this.Adapter.UpdateCommand.Parameters[25].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[25].Value = (object) EDITMAC;
      if (SAVEIP == null)
        this.Adapter.UpdateCommand.Parameters[26].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[26].Value = (object) SAVEIP;
      if (EDITIP == null)
        this.Adapter.UpdateCommand.Parameters[27].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[27].Value = (object) EDITIP;
      if (BILGINOTU == null)
        this.Adapter.UpdateCommand.Parameters[28].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[28].Value = (object) BILGINOTU;
      if (TEKLIFID.HasValue)
        this.Adapter.UpdateCommand.Parameters[29].Value = (object) TEKLIFID.Value;
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
      if (Original_TARIH.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[33].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[34].Value = (object) Original_TARIH.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[33].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[34].Value = (object) DBNull.Value;
      }
      if (Original_SAAT.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[35].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[36].Value = (object) Original_SAAT.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[35].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[36].Value = (object) DBNull.Value;
      }
      if (Original_BELGESAYI == null)
      {
        this.Adapter.UpdateCommand.Parameters[37].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[38].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[37].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[38].Value = (object) Original_BELGESAYI;
      }
      if (Original_BELGEKONU == null)
      {
        this.Adapter.UpdateCommand.Parameters[39].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[40].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[39].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[40].Value = (object) Original_BELGEKONU;
      }
      if (Original_BELGETARIH.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[41].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[42].Value = (object) Original_BELGETARIH.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[41].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[42].Value = (object) DBNull.Value;
      }
      if (Original_ISINADI == null)
      {
        this.Adapter.UpdateCommand.Parameters[43].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[44].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[43].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[44].Value = (object) Original_ISINADI;
      }
      if (Original_ISINTURUMIKTARI == null)
      {
        this.Adapter.UpdateCommand.Parameters[45].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[46].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[45].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[46].Value = (object) Original_ISINTURUMIKTARI;
      }
      if (Original_ISINYAPYERI == null)
      {
        this.Adapter.UpdateCommand.Parameters[47].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[48].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[47].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[48].Value = (object) Original_ISINYAPYERI;
      }
      if (Original_BUTCETERTIBI == null)
      {
        this.Adapter.UpdateCommand.Parameters[49].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[50].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[49].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[50].Value = (object) Original_BUTCETERTIBI;
      }
      if (Original_IHALEUSULU == null)
      {
        this.Adapter.UpdateCommand.Parameters[51].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[52].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[51].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[52].Value = (object) Original_IHALEUSULU;
      }
      if (Original_YAKLASIKMALIYET == null)
      {
        this.Adapter.UpdateCommand.Parameters[53].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[54].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[53].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[54].Value = (object) Original_YAKLASIKMALIYET;
      }
      if (Original_KULLODENEKTUTAR == null)
      {
        this.Adapter.UpdateCommand.Parameters[55].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[56].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[55].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[56].Value = (object) Original_KULLODENEKTUTAR;
      }
      if (Original_ATOLYESEFID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[57].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[58].Value = (object) Original_ATOLYESEFID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[57].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[58].Value = (object) DBNull.Value;
      }
      if (Original_DEPOYETKILIID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[59].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[60].Value = (object) Original_DEPOYETKILIID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[59].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[60].Value = (object) DBNull.Value;
      }
      if (Original_SORUMLUID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[61].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[62].Value = (object) Original_SORUMLUID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[61].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[62].Value = (object) DBNull.Value;
      }
      if (Original_MUDURID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[63].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[64].Value = (object) Original_MUDURID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[63].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[64].Value = (object) DBNull.Value;
      }
      if (Original_DAIREBSKID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[65].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[66].Value = (object) Original_DAIREBSKID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[65].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[66].Value = (object) DBNull.Value;
      }
      if (Original_GENELSEKYRDID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[67].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[68].Value = (object) Original_GENELSEKYRDID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[67].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[68].Value = (object) DBNull.Value;
      }
      if (Original_GENELSEKRETERID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[69].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[70].Value = (object) Original_GENELSEKRETERID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[69].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[70].Value = (object) DBNull.Value;
      }
      if (Original_SAVEUSER == null)
      {
        this.Adapter.UpdateCommand.Parameters[71].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[72].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[71].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[72].Value = (object) Original_SAVEUSER;
      }
      if (Original_SAVEDATE.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[73].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[74].Value = (object) Original_SAVEDATE.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[73].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[74].Value = (object) DBNull.Value;
      }
      if (Original_EDITUSER == null)
      {
        this.Adapter.UpdateCommand.Parameters[75].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[76].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[75].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[76].Value = (object) Original_EDITUSER;
      }
      if (Original_EDITDATE.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[77].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[78].Value = (object) Original_EDITDATE.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[77].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[78].Value = (object) DBNull.Value;
      }
      if (Original_SAVEMAC == null)
      {
        this.Adapter.UpdateCommand.Parameters[79].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[80].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[79].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[80].Value = (object) Original_SAVEMAC;
      }
      if (Original_EDITMAC == null)
      {
        this.Adapter.UpdateCommand.Parameters[81].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[82].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[81].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[82].Value = (object) Original_EDITMAC;
      }
      if (Original_SAVEIP == null)
      {
        this.Adapter.UpdateCommand.Parameters[83].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[84].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[83].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[84].Value = (object) Original_SAVEIP;
      }
      if (Original_EDITIP == null)
      {
        this.Adapter.UpdateCommand.Parameters[85].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[86].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[85].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[86].Value = (object) Original_EDITIP;
      }
      if (Original_BILGINOTU == null)
      {
        this.Adapter.UpdateCommand.Parameters[87].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[88].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[87].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[88].Value = (object) Original_BILGINOTU;
      }
      if (Original_TEKLIFID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[89].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[90].Value = (object) Original_TEKLIFID.Value;
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
      DateTime? TARIH,
      DateTime? SAAT,
      string BELGESAYI,
      string BELGEKONU,
      DateTime? BELGETARIH,
      string ISINADI,
      string ISINTURUMIKTARI,
      string ISINYAPYERI,
      string BUTCETERTIBI,
      string IHALEUSULU,
      string YAKLASIKMALIYET,
      string KULLODENEKTUTAR,
      int? ATOLYESEFID,
      int? DEPOYETKILIID,
      int? SORUMLUID,
      int? MUDURID,
      int? DAIREBSKID,
      int? GENELSEKYRDID,
      int? GENELSEKRETERID,
      string SAVEUSER,
      DateTime? SAVEDATE,
      string EDITUSER,
      DateTime? EDITDATE,
      string SAVEMAC,
      string EDITMAC,
      string SAVEIP,
      string EDITIP,
      string BILGINOTU,
      int? TEKLIFID,
      int Original_ID,
      string Original_KOD,
      DateTime? Original_TARIH,
      DateTime? Original_SAAT,
      string Original_BELGESAYI,
      string Original_BELGEKONU,
      DateTime? Original_BELGETARIH,
      string Original_ISINADI,
      string Original_ISINTURUMIKTARI,
      string Original_ISINYAPYERI,
      string Original_BUTCETERTIBI,
      string Original_IHALEUSULU,
      string Original_YAKLASIKMALIYET,
      string Original_KULLODENEKTUTAR,
      int? Original_ATOLYESEFID,
      int? Original_DEPOYETKILIID,
      int? Original_SORUMLUID,
      int? Original_MUDURID,
      int? Original_DAIREBSKID,
      int? Original_GENELSEKYRDID,
      int? Original_GENELSEKRETERID,
      string Original_SAVEUSER,
      DateTime? Original_SAVEDATE,
      string Original_EDITUSER,
      DateTime? Original_EDITDATE,
      string Original_SAVEMAC,
      string Original_EDITMAC,
      string Original_SAVEIP,
      string Original_EDITIP,
      string Original_BILGINOTU,
      int? Original_TEKLIFID)
    {
      return this.Update(KOD, TARIH, SAAT, BELGESAYI, BELGEKONU, BELGETARIH, ISINADI, ISINTURUMIKTARI, ISINYAPYERI, BUTCETERTIBI, IHALEUSULU, YAKLASIKMALIYET, KULLODENEKTUTAR, ATOLYESEFID, DEPOYETKILIID, SORUMLUID, MUDURID, DAIREBSKID, GENELSEKYRDID, GENELSEKRETERID, SAVEUSER, SAVEDATE, EDITUSER, EDITDATE, SAVEMAC, EDITMAC, SAVEIP, EDITIP, BILGINOTU, TEKLIFID, Original_ID, Original_KOD, Original_TARIH, Original_SAAT, Original_BELGESAYI, Original_BELGEKONU, Original_BELGETARIH, Original_ISINADI, Original_ISINTURUMIKTARI, Original_ISINYAPYERI, Original_BUTCETERTIBI, Original_IHALEUSULU, Original_YAKLASIKMALIYET, Original_KULLODENEKTUTAR, Original_ATOLYESEFID, Original_DEPOYETKILIID, Original_SORUMLUID, Original_MUDURID, Original_DAIREBSKID, Original_GENELSEKYRDID, Original_GENELSEKRETERID, Original_SAVEUSER, Original_SAVEDATE, Original_EDITUSER, Original_EDITDATE, Original_SAVEMAC, Original_EDITMAC, Original_SAVEIP, Original_EDITIP, Original_BILGINOTU, Original_TEKLIFID, Original_ID);
    }
  }
}
