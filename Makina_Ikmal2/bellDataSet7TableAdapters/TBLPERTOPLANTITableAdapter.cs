// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.bellDataSet7TableAdapters.TBLPERTOPLANTITableAdapter
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
  public class TBLPERTOPLANTITableAdapter : Component
  {
    private SqlDataAdapter _adapter;
    private SqlConnection _connection;
    private SqlTransaction _transaction;
    private SqlCommand[] _commandCollection;
    private bool _clearBeforeFill;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public TBLPERTOPLANTITableAdapter() => this.ClearBeforeFill = true;

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
        DataSetTable = "TBLPERTOPLANTI",
        ColumnMappings = {
          {
            "ID",
            "ID"
          },
          {
            "YAZIISLERISRMLS",
            "YAZIISLERISRMLS"
          },
          {
            "ATOLYESRMLS",
            "ATOLYESRMLS"
          },
          {
            "AMBARSRMLS",
            "AMBARSRMLS"
          },
          {
            "ISMAKINASISRMLS",
            "ISMAKINASISRMLS"
          },
          {
            "IKMALBIRIMSRMLS",
            "IKMALBIRIMSRMLS"
          },
          {
            "AKARYKTSRMLS",
            "AKARYKTSRMLS"
          },
          {
            "KAYNAKISTANYONSEF",
            "KAYNAKISTANYONSEF"
          },
          {
            "KAMYONTAMIRUSTABAS",
            "KAMYONTAMIRUSTABAS"
          },
          {
            "OTOLASTIKUSTABASI",
            "OTOLASTIKUSTABASI"
          },
          {
            "AMBARAYNIYATSRMLS",
            "AMBARAYNIYATSRMLS"
          },
          {
            "TOPLANTITARIHI",
            "TOPLANTITARIHI"
          },
          {
            "TOPLANTIYONETICISI",
            "TOPLANTIYONETICISI"
          },
          {
            "TOPLANTIKONUSU",
            "TOPLANTIKONUSU"
          },
          {
            "DAIREBASK_KODU",
            "DAIREBASK_KODU"
          },
          {
            "RAPORNO",
            "RAPORNO"
          },
          {
            "TOPLANTISURESI",
            "TOPLANTISURESI"
          },
          {
            "SONRAKITOPLANTITARIHI",
            "SONRAKITOPLANTITARIHI"
          },
          {
            "GUNDEMMADDELERI",
            "GUNDEMMADDELERI"
          },
          {
            "KARARACIKLAMASI",
            "KARARACIKLAMASI"
          },
          {
            "ELEKTRIKSRMLS",
            "ELEKTRIKSRMLS"
          }
        }
      });
      this._adapter.DeleteCommand = new SqlCommand();
      this._adapter.DeleteCommand.Connection = this.Connection;
      this._adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[TBLPERTOPLANTI] WHERE (([ID] = @Original_ID) AND ((@IsNull_YAZIISLERISRMLS = 1 AND [YAZIISLERISRMLS] IS NULL) OR ([YAZIISLERISRMLS] = @Original_YAZIISLERISRMLS)) AND ((@IsNull_ATOLYESRMLS = 1 AND [ATOLYESRMLS] IS NULL) OR ([ATOLYESRMLS] = @Original_ATOLYESRMLS)) AND ((@IsNull_AMBARSRMLS = 1 AND [AMBARSRMLS] IS NULL) OR ([AMBARSRMLS] = @Original_AMBARSRMLS)) AND ((@IsNull_ISMAKINASISRMLS = 1 AND [ISMAKINASISRMLS] IS NULL) OR ([ISMAKINASISRMLS] = @Original_ISMAKINASISRMLS)) AND ((@IsNull_IKMALBIRIMSRMLS = 1 AND [IKMALBIRIMSRMLS] IS NULL) OR ([IKMALBIRIMSRMLS] = @Original_IKMALBIRIMSRMLS)) AND ((@IsNull_AKARYKTSRMLS = 1 AND [AKARYKTSRMLS] IS NULL) OR ([AKARYKTSRMLS] = @Original_AKARYKTSRMLS)) AND ((@IsNull_KAYNAKISTANYONSEF = 1 AND [KAYNAKISTANYONSEF] IS NULL) OR ([KAYNAKISTANYONSEF] = @Original_KAYNAKISTANYONSEF)) AND ((@IsNull_KAMYONTAMIRUSTABAS = 1 AND [KAMYONTAMIRUSTABAS] IS NULL) OR ([KAMYONTAMIRUSTABAS] = @Original_KAMYONTAMIRUSTABAS)) AND ((@IsNull_OTOLASTIKUSTABASI = 1 AND [OTOLASTIKUSTABASI] IS NULL) OR ([OTOLASTIKUSTABASI] = @Original_OTOLASTIKUSTABASI)) AND ((@IsNull_AMBARAYNIYATSRMLS = 1 AND [AMBARAYNIYATSRMLS] IS NULL) OR ([AMBARAYNIYATSRMLS] = @Original_AMBARAYNIYATSRMLS)) AND ((@IsNull_TOPLANTITARIHI = 1 AND [TOPLANTITARIHI] IS NULL) OR ([TOPLANTITARIHI] = @Original_TOPLANTITARIHI)) AND ((@IsNull_TOPLANTIYONETICISI = 1 AND [TOPLANTIYONETICISI] IS NULL) OR ([TOPLANTIYONETICISI] = @Original_TOPLANTIYONETICISI)) AND ((@IsNull_TOPLANTIKONUSU = 1 AND [TOPLANTIKONUSU] IS NULL) OR ([TOPLANTIKONUSU] = @Original_TOPLANTIKONUSU)) AND ((@IsNull_DAIREBASK_KODU = 1 AND [DAIREBASK_KODU] IS NULL) OR ([DAIREBASK_KODU] = @Original_DAIREBASK_KODU)) AND ((@IsNull_RAPORNO = 1 AND [RAPORNO] IS NULL) OR ([RAPORNO] = @Original_RAPORNO)) AND ((@IsNull_TOPLANTISURESI = 1 AND [TOPLANTISURESI] IS NULL) OR ([TOPLANTISURESI] = @Original_TOPLANTISURESI)) AND ((@IsNull_SONRAKITOPLANTITARIHI = 1 AND [SONRAKITOPLANTITARIHI] IS NULL) OR ([SONRAKITOPLANTITARIHI] = @Original_SONRAKITOPLANTITARIHI)) AND ((@IsNull_GUNDEMMADDELERI = 1 AND [GUNDEMMADDELERI] IS NULL) OR ([GUNDEMMADDELERI] = @Original_GUNDEMMADDELERI)) AND ((@IsNull_KARARACIKLAMASI = 1 AND [KARARACIKLAMASI] IS NULL) OR ([KARARACIKLAMASI] = @Original_KARARACIKLAMASI)) AND ((@IsNull_ELEKTRIKSRMLS = 1 AND [ELEKTRIKSRMLS] IS NULL) OR ([ELEKTRIKSRMLS] = @Original_ELEKTRIKSRMLS)))";
      this._adapter.DeleteCommand.CommandType = CommandType.Text;
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_YAZIISLERISRMLS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YAZIISLERISRMLS", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_YAZIISLERISRMLS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YAZIISLERISRMLS", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ATOLYESRMLS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ATOLYESRMLS", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ATOLYESRMLS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ATOLYESRMLS", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_AMBARSRMLS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AMBARSRMLS", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_AMBARSRMLS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AMBARSRMLS", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ISMAKINASISRMLS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISMAKINASISRMLS", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ISMAKINASISRMLS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISMAKINASISRMLS", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_IKMALBIRIMSRMLS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IKMALBIRIMSRMLS", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_IKMALBIRIMSRMLS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IKMALBIRIMSRMLS", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_AKARYKTSRMLS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AKARYKTSRMLS", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_AKARYKTSRMLS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AKARYKTSRMLS", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_KAYNAKISTANYONSEF", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KAYNAKISTANYONSEF", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_KAYNAKISTANYONSEF", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KAYNAKISTANYONSEF", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_KAMYONTAMIRUSTABAS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KAMYONTAMIRUSTABAS", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_KAMYONTAMIRUSTABAS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KAMYONTAMIRUSTABAS", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_OTOLASTIKUSTABASI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "OTOLASTIKUSTABASI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_OTOLASTIKUSTABASI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "OTOLASTIKUSTABASI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_AMBARAYNIYATSRMLS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AMBARAYNIYATSRMLS", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_AMBARAYNIYATSRMLS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AMBARAYNIYATSRMLS", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TOPLANTITARIHI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TOPLANTITARIHI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TOPLANTITARIHI", SqlDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TOPLANTITARIHI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TOPLANTIYONETICISI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TOPLANTIYONETICISI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TOPLANTIYONETICISI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TOPLANTIYONETICISI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TOPLANTIKONUSU", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TOPLANTIKONUSU", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TOPLANTIKONUSU", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TOPLANTIKONUSU", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_DAIREBASK_KODU", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DAIREBASK_KODU", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_DAIREBASK_KODU", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DAIREBASK_KODU", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_RAPORNO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RAPORNO", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_RAPORNO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RAPORNO", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TOPLANTISURESI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TOPLANTISURESI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TOPLANTISURESI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TOPLANTISURESI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SONRAKITOPLANTITARIHI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SONRAKITOPLANTITARIHI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SONRAKITOPLANTITARIHI", SqlDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SONRAKITOPLANTITARIHI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_GUNDEMMADDELERI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GUNDEMMADDELERI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_GUNDEMMADDELERI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GUNDEMMADDELERI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_KARARACIKLAMASI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KARARACIKLAMASI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_KARARACIKLAMASI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KARARACIKLAMASI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ELEKTRIKSRMLS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ELEKTRIKSRMLS", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ELEKTRIKSRMLS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ELEKTRIKSRMLS", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.InsertCommand = new SqlCommand();
      this._adapter.InsertCommand.Connection = this.Connection;
      this._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[TBLPERTOPLANTI] ([YAZIISLERISRMLS], [ATOLYESRMLS], [AMBARSRMLS], [ISMAKINASISRMLS], [IKMALBIRIMSRMLS], [AKARYKTSRMLS], [KAYNAKISTANYONSEF], [KAMYONTAMIRUSTABAS], [OTOLASTIKUSTABASI], [AMBARAYNIYATSRMLS], [TOPLANTITARIHI], [TOPLANTIYONETICISI], [TOPLANTIKONUSU], [DAIREBASK_KODU], [RAPORNO], [TOPLANTISURESI], [SONRAKITOPLANTITARIHI], [GUNDEMMADDELERI], [KARARACIKLAMASI], [ELEKTRIKSRMLS]) VALUES (@YAZIISLERISRMLS, @ATOLYESRMLS, @AMBARSRMLS, @ISMAKINASISRMLS, @IKMALBIRIMSRMLS, @AKARYKTSRMLS, @KAYNAKISTANYONSEF, @KAMYONTAMIRUSTABAS, @OTOLASTIKUSTABASI, @AMBARAYNIYATSRMLS, @TOPLANTITARIHI, @TOPLANTIYONETICISI, @TOPLANTIKONUSU, @DAIREBASK_KODU, @RAPORNO, @TOPLANTISURESI, @SONRAKITOPLANTITARIHI, @GUNDEMMADDELERI, @KARARACIKLAMASI, @ELEKTRIKSRMLS);\r\nSELECT ID, YAZIISLERISRMLS, ATOLYESRMLS, AMBARSRMLS, ISMAKINASISRMLS, IKMALBIRIMSRMLS, AKARYKTSRMLS, KAYNAKISTANYONSEF, KAMYONTAMIRUSTABAS, OTOLASTIKUSTABASI, AMBARAYNIYATSRMLS, TOPLANTITARIHI, TOPLANTIYONETICISI, TOPLANTIKONUSU, DAIREBASK_KODU, RAPORNO, TOPLANTISURESI, SONRAKITOPLANTITARIHI, GUNDEMMADDELERI, KARARACIKLAMASI, ELEKTRIKSRMLS FROM TBLPERTOPLANTI WHERE (ID = SCOPE_IDENTITY())";
      this._adapter.InsertCommand.CommandType = CommandType.Text;
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@YAZIISLERISRMLS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YAZIISLERISRMLS", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ATOLYESRMLS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ATOLYESRMLS", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@AMBARSRMLS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AMBARSRMLS", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ISMAKINASISRMLS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISMAKINASISRMLS", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@IKMALBIRIMSRMLS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IKMALBIRIMSRMLS", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@AKARYKTSRMLS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AKARYKTSRMLS", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@KAYNAKISTANYONSEF", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KAYNAKISTANYONSEF", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@KAMYONTAMIRUSTABAS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KAMYONTAMIRUSTABAS", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@OTOLASTIKUSTABASI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "OTOLASTIKUSTABASI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@AMBARAYNIYATSRMLS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AMBARAYNIYATSRMLS", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@TOPLANTITARIHI", SqlDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TOPLANTITARIHI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@TOPLANTIYONETICISI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TOPLANTIYONETICISI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@TOPLANTIKONUSU", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TOPLANTIKONUSU", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@DAIREBASK_KODU", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DAIREBASK_KODU", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@RAPORNO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RAPORNO", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@TOPLANTISURESI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TOPLANTISURESI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SONRAKITOPLANTITARIHI", SqlDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SONRAKITOPLANTITARIHI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@GUNDEMMADDELERI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GUNDEMMADDELERI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@KARARACIKLAMASI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KARARACIKLAMASI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ELEKTRIKSRMLS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ELEKTRIKSRMLS", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand = new SqlCommand();
      this._adapter.UpdateCommand.Connection = this.Connection;
      this._adapter.UpdateCommand.CommandText = "UPDATE [dbo].[TBLPERTOPLANTI] SET [YAZIISLERISRMLS] = @YAZIISLERISRMLS, [ATOLYESRMLS] = @ATOLYESRMLS, [AMBARSRMLS] = @AMBARSRMLS, [ISMAKINASISRMLS] = @ISMAKINASISRMLS, [IKMALBIRIMSRMLS] = @IKMALBIRIMSRMLS, [AKARYKTSRMLS] = @AKARYKTSRMLS, [KAYNAKISTANYONSEF] = @KAYNAKISTANYONSEF, [KAMYONTAMIRUSTABAS] = @KAMYONTAMIRUSTABAS, [OTOLASTIKUSTABASI] = @OTOLASTIKUSTABASI, [AMBARAYNIYATSRMLS] = @AMBARAYNIYATSRMLS, [TOPLANTITARIHI] = @TOPLANTITARIHI, [TOPLANTIYONETICISI] = @TOPLANTIYONETICISI, [TOPLANTIKONUSU] = @TOPLANTIKONUSU, [DAIREBASK_KODU] = @DAIREBASK_KODU, [RAPORNO] = @RAPORNO, [TOPLANTISURESI] = @TOPLANTISURESI, [SONRAKITOPLANTITARIHI] = @SONRAKITOPLANTITARIHI, [GUNDEMMADDELERI] = @GUNDEMMADDELERI, [KARARACIKLAMASI] = @KARARACIKLAMASI, [ELEKTRIKSRMLS] = @ELEKTRIKSRMLS WHERE (([ID] = @Original_ID) AND ((@IsNull_YAZIISLERISRMLS = 1 AND [YAZIISLERISRMLS] IS NULL) OR ([YAZIISLERISRMLS] = @Original_YAZIISLERISRMLS)) AND ((@IsNull_ATOLYESRMLS = 1 AND [ATOLYESRMLS] IS NULL) OR ([ATOLYESRMLS] = @Original_ATOLYESRMLS)) AND ((@IsNull_AMBARSRMLS = 1 AND [AMBARSRMLS] IS NULL) OR ([AMBARSRMLS] = @Original_AMBARSRMLS)) AND ((@IsNull_ISMAKINASISRMLS = 1 AND [ISMAKINASISRMLS] IS NULL) OR ([ISMAKINASISRMLS] = @Original_ISMAKINASISRMLS)) AND ((@IsNull_IKMALBIRIMSRMLS = 1 AND [IKMALBIRIMSRMLS] IS NULL) OR ([IKMALBIRIMSRMLS] = @Original_IKMALBIRIMSRMLS)) AND ((@IsNull_AKARYKTSRMLS = 1 AND [AKARYKTSRMLS] IS NULL) OR ([AKARYKTSRMLS] = @Original_AKARYKTSRMLS)) AND ((@IsNull_KAYNAKISTANYONSEF = 1 AND [KAYNAKISTANYONSEF] IS NULL) OR ([KAYNAKISTANYONSEF] = @Original_KAYNAKISTANYONSEF)) AND ((@IsNull_KAMYONTAMIRUSTABAS = 1 AND [KAMYONTAMIRUSTABAS] IS NULL) OR ([KAMYONTAMIRUSTABAS] = @Original_KAMYONTAMIRUSTABAS)) AND ((@IsNull_OTOLASTIKUSTABASI = 1 AND [OTOLASTIKUSTABASI] IS NULL) OR ([OTOLASTIKUSTABASI] = @Original_OTOLASTIKUSTABASI)) AND ((@IsNull_AMBARAYNIYATSRMLS = 1 AND [AMBARAYNIYATSRMLS] IS NULL) OR ([AMBARAYNIYATSRMLS] = @Original_AMBARAYNIYATSRMLS)) AND ((@IsNull_TOPLANTITARIHI = 1 AND [TOPLANTITARIHI] IS NULL) OR ([TOPLANTITARIHI] = @Original_TOPLANTITARIHI)) AND ((@IsNull_TOPLANTIYONETICISI = 1 AND [TOPLANTIYONETICISI] IS NULL) OR ([TOPLANTIYONETICISI] = @Original_TOPLANTIYONETICISI)) AND ((@IsNull_TOPLANTIKONUSU = 1 AND [TOPLANTIKONUSU] IS NULL) OR ([TOPLANTIKONUSU] = @Original_TOPLANTIKONUSU)) AND ((@IsNull_DAIREBASK_KODU = 1 AND [DAIREBASK_KODU] IS NULL) OR ([DAIREBASK_KODU] = @Original_DAIREBASK_KODU)) AND ((@IsNull_RAPORNO = 1 AND [RAPORNO] IS NULL) OR ([RAPORNO] = @Original_RAPORNO)) AND ((@IsNull_TOPLANTISURESI = 1 AND [TOPLANTISURESI] IS NULL) OR ([TOPLANTISURESI] = @Original_TOPLANTISURESI)) AND ((@IsNull_SONRAKITOPLANTITARIHI = 1 AND [SONRAKITOPLANTITARIHI] IS NULL) OR ([SONRAKITOPLANTITARIHI] = @Original_SONRAKITOPLANTITARIHI)) AND ((@IsNull_GUNDEMMADDELERI = 1 AND [GUNDEMMADDELERI] IS NULL) OR ([GUNDEMMADDELERI] = @Original_GUNDEMMADDELERI)) AND ((@IsNull_KARARACIKLAMASI = 1 AND [KARARACIKLAMASI] IS NULL) OR ([KARARACIKLAMASI] = @Original_KARARACIKLAMASI)) AND ((@IsNull_ELEKTRIKSRMLS = 1 AND [ELEKTRIKSRMLS] IS NULL) OR ([ELEKTRIKSRMLS] = @Original_ELEKTRIKSRMLS)));\r\nSELECT ID, YAZIISLERISRMLS, ATOLYESRMLS, AMBARSRMLS, ISMAKINASISRMLS, IKMALBIRIMSRMLS, AKARYKTSRMLS, KAYNAKISTANYONSEF, KAMYONTAMIRUSTABAS, OTOLASTIKUSTABASI, AMBARAYNIYATSRMLS, TOPLANTITARIHI, TOPLANTIYONETICISI, TOPLANTIKONUSU, DAIREBASK_KODU, RAPORNO, TOPLANTISURESI, SONRAKITOPLANTITARIHI, GUNDEMMADDELERI, KARARACIKLAMASI, ELEKTRIKSRMLS FROM TBLPERTOPLANTI WHERE (ID = @ID)";
      this._adapter.UpdateCommand.CommandType = CommandType.Text;
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@YAZIISLERISRMLS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YAZIISLERISRMLS", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ATOLYESRMLS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ATOLYESRMLS", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@AMBARSRMLS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AMBARSRMLS", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ISMAKINASISRMLS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISMAKINASISRMLS", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IKMALBIRIMSRMLS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IKMALBIRIMSRMLS", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@AKARYKTSRMLS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AKARYKTSRMLS", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@KAYNAKISTANYONSEF", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KAYNAKISTANYONSEF", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@KAMYONTAMIRUSTABAS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KAMYONTAMIRUSTABAS", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@OTOLASTIKUSTABASI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "OTOLASTIKUSTABASI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@AMBARAYNIYATSRMLS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AMBARAYNIYATSRMLS", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TOPLANTITARIHI", SqlDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TOPLANTITARIHI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TOPLANTIYONETICISI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TOPLANTIYONETICISI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TOPLANTIKONUSU", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TOPLANTIKONUSU", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@DAIREBASK_KODU", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DAIREBASK_KODU", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@RAPORNO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RAPORNO", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TOPLANTISURESI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TOPLANTISURESI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SONRAKITOPLANTITARIHI", SqlDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SONRAKITOPLANTITARIHI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@GUNDEMMADDELERI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GUNDEMMADDELERI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@KARARACIKLAMASI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KARARACIKLAMASI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ELEKTRIKSRMLS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ELEKTRIKSRMLS", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_YAZIISLERISRMLS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YAZIISLERISRMLS", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_YAZIISLERISRMLS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "YAZIISLERISRMLS", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ATOLYESRMLS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ATOLYESRMLS", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ATOLYESRMLS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ATOLYESRMLS", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_AMBARSRMLS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AMBARSRMLS", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_AMBARSRMLS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AMBARSRMLS", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ISMAKINASISRMLS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISMAKINASISRMLS", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ISMAKINASISRMLS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISMAKINASISRMLS", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_IKMALBIRIMSRMLS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IKMALBIRIMSRMLS", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_IKMALBIRIMSRMLS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IKMALBIRIMSRMLS", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_AKARYKTSRMLS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AKARYKTSRMLS", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_AKARYKTSRMLS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AKARYKTSRMLS", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_KAYNAKISTANYONSEF", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KAYNAKISTANYONSEF", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_KAYNAKISTANYONSEF", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KAYNAKISTANYONSEF", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_KAMYONTAMIRUSTABAS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KAMYONTAMIRUSTABAS", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_KAMYONTAMIRUSTABAS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KAMYONTAMIRUSTABAS", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_OTOLASTIKUSTABASI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "OTOLASTIKUSTABASI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_OTOLASTIKUSTABASI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "OTOLASTIKUSTABASI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_AMBARAYNIYATSRMLS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AMBARAYNIYATSRMLS", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_AMBARAYNIYATSRMLS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AMBARAYNIYATSRMLS", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TOPLANTITARIHI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TOPLANTITARIHI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TOPLANTITARIHI", SqlDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TOPLANTITARIHI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TOPLANTIYONETICISI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TOPLANTIYONETICISI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TOPLANTIYONETICISI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TOPLANTIYONETICISI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TOPLANTIKONUSU", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TOPLANTIKONUSU", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TOPLANTIKONUSU", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TOPLANTIKONUSU", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_DAIREBASK_KODU", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DAIREBASK_KODU", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_DAIREBASK_KODU", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DAIREBASK_KODU", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_RAPORNO", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RAPORNO", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_RAPORNO", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RAPORNO", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TOPLANTISURESI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TOPLANTISURESI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TOPLANTISURESI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TOPLANTISURESI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SONRAKITOPLANTITARIHI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SONRAKITOPLANTITARIHI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SONRAKITOPLANTITARIHI", SqlDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SONRAKITOPLANTITARIHI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_GUNDEMMADDELERI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GUNDEMMADDELERI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_GUNDEMMADDELERI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GUNDEMMADDELERI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_KARARACIKLAMASI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KARARACIKLAMASI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_KARARACIKLAMASI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KARARACIKLAMASI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ELEKTRIKSRMLS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ELEKTRIKSRMLS", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ELEKTRIKSRMLS", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ELEKTRIKSRMLS", DataRowVersion.Original, false, (object) null, "", "", ""));
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
      this._commandCollection[0].CommandText = "SELECT ID, YAZIISLERISRMLS, ATOLYESRMLS, AMBARSRMLS, ISMAKINASISRMLS, IKMALBIRIMSRMLS, AKARYKTSRMLS, KAYNAKISTANYONSEF, KAMYONTAMIRUSTABAS, OTOLASTIKUSTABASI, AMBARAYNIYATSRMLS, TOPLANTITARIHI, TOPLANTIYONETICISI, TOPLANTIKONUSU, DAIREBASK_KODU, RAPORNO, TOPLANTISURESI, SONRAKITOPLANTITARIHI, GUNDEMMADDELERI, KARARACIKLAMASI, ELEKTRIKSRMLS FROM dbo.TBLPERTOPLANTI";
      this._commandCollection[0].CommandType = CommandType.Text;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    public virtual int Fill(bellDataSet7.TBLPERTOPLANTIDataTable dataTable)
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
    public virtual bellDataSet7.TBLPERTOPLANTIDataTable GetData()
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      bellDataSet7.TBLPERTOPLANTIDataTable data = new bellDataSet7.TBLPERTOPLANTIDataTable();
      this.Adapter.Fill((DataTable) data);
      return data;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(bellDataSet7.TBLPERTOPLANTIDataTable dataTable) => this.Adapter.Update((DataTable) dataTable);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(bellDataSet7 dataSet) => this.Adapter.Update((DataSet) dataSet, "TBLPERTOPLANTI");

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
      int? Original_YAZIISLERISRMLS,
      int? Original_ATOLYESRMLS,
      int? Original_AMBARSRMLS,
      int? Original_ISMAKINASISRMLS,
      int? Original_IKMALBIRIMSRMLS,
      int? Original_AKARYKTSRMLS,
      int? Original_KAYNAKISTANYONSEF,
      int? Original_KAMYONTAMIRUSTABAS,
      int? Original_OTOLASTIKUSTABASI,
      int? Original_AMBARAYNIYATSRMLS,
      DateTime? Original_TOPLANTITARIHI,
      int? Original_TOPLANTIYONETICISI,
      string Original_TOPLANTIKONUSU,
      string Original_DAIREBASK_KODU,
      string Original_RAPORNO,
      string Original_TOPLANTISURESI,
      DateTime? Original_SONRAKITOPLANTITARIHI,
      string Original_GUNDEMMADDELERI,
      string Original_KARARACIKLAMASI,
      int? Original_ELEKTRIKSRMLS)
    {
      this.Adapter.DeleteCommand.Parameters[0].Value = (object) Original_ID;
      if (Original_YAZIISLERISRMLS.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[1].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[2].Value = (object) Original_YAZIISLERISRMLS.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[1].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[2].Value = (object) DBNull.Value;
      }
      if (Original_ATOLYESRMLS.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[3].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[4].Value = (object) Original_ATOLYESRMLS.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[3].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[4].Value = (object) DBNull.Value;
      }
      if (Original_AMBARSRMLS.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[6].Value = (object) Original_AMBARSRMLS.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[6].Value = (object) DBNull.Value;
      }
      if (Original_ISMAKINASISRMLS.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[7].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[8].Value = (object) Original_ISMAKINASISRMLS.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[7].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[8].Value = (object) DBNull.Value;
      }
      if (Original_IKMALBIRIMSRMLS.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) Original_IKMALBIRIMSRMLS.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) DBNull.Value;
      }
      if (Original_AKARYKTSRMLS.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[11].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[12].Value = (object) Original_AKARYKTSRMLS.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[11].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[12].Value = (object) DBNull.Value;
      }
      if (Original_KAYNAKISTANYONSEF.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[13].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[14].Value = (object) Original_KAYNAKISTANYONSEF.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[13].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[14].Value = (object) DBNull.Value;
      }
      if (Original_KAMYONTAMIRUSTABAS.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[15].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[16].Value = (object) Original_KAMYONTAMIRUSTABAS.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[15].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[16].Value = (object) DBNull.Value;
      }
      if (Original_OTOLASTIKUSTABASI.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[17].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[18].Value = (object) Original_OTOLASTIKUSTABASI.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[17].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[18].Value = (object) DBNull.Value;
      }
      if (Original_AMBARAYNIYATSRMLS.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[19].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[20].Value = (object) Original_AMBARAYNIYATSRMLS.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[19].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[20].Value = (object) DBNull.Value;
      }
      if (Original_TOPLANTITARIHI.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[21].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[22].Value = (object) Original_TOPLANTITARIHI.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[21].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[22].Value = (object) DBNull.Value;
      }
      if (Original_TOPLANTIYONETICISI.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[23].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[24].Value = (object) Original_TOPLANTIYONETICISI.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[23].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[24].Value = (object) DBNull.Value;
      }
      if (Original_TOPLANTIKONUSU == null)
      {
        this.Adapter.DeleteCommand.Parameters[25].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[26].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[25].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[26].Value = (object) Original_TOPLANTIKONUSU;
      }
      if (Original_DAIREBASK_KODU == null)
      {
        this.Adapter.DeleteCommand.Parameters[27].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[28].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[27].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[28].Value = (object) Original_DAIREBASK_KODU;
      }
      if (Original_RAPORNO == null)
      {
        this.Adapter.DeleteCommand.Parameters[29].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[30].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[29].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[30].Value = (object) Original_RAPORNO;
      }
      if (Original_TOPLANTISURESI == null)
      {
        this.Adapter.DeleteCommand.Parameters[31].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[32].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[31].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[32].Value = (object) Original_TOPLANTISURESI;
      }
      if (Original_SONRAKITOPLANTITARIHI.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[33].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[34].Value = (object) Original_SONRAKITOPLANTITARIHI.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[33].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[34].Value = (object) DBNull.Value;
      }
      if (Original_GUNDEMMADDELERI == null)
      {
        this.Adapter.DeleteCommand.Parameters[35].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[36].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[35].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[36].Value = (object) Original_GUNDEMMADDELERI;
      }
      if (Original_KARARACIKLAMASI == null)
      {
        this.Adapter.DeleteCommand.Parameters[37].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[38].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[37].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[38].Value = (object) Original_KARARACIKLAMASI;
      }
      if (Original_ELEKTRIKSRMLS.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[39].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[40].Value = (object) Original_ELEKTRIKSRMLS.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[39].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[40].Value = (object) DBNull.Value;
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
      int? YAZIISLERISRMLS,
      int? ATOLYESRMLS,
      int? AMBARSRMLS,
      int? ISMAKINASISRMLS,
      int? IKMALBIRIMSRMLS,
      int? AKARYKTSRMLS,
      int? KAYNAKISTANYONSEF,
      int? KAMYONTAMIRUSTABAS,
      int? OTOLASTIKUSTABASI,
      int? AMBARAYNIYATSRMLS,
      DateTime? TOPLANTITARIHI,
      int? TOPLANTIYONETICISI,
      string TOPLANTIKONUSU,
      string DAIREBASK_KODU,
      string RAPORNO,
      string TOPLANTISURESI,
      DateTime? SONRAKITOPLANTITARIHI,
      string GUNDEMMADDELERI,
      string KARARACIKLAMASI,
      int? ELEKTRIKSRMLS)
    {
      if (YAZIISLERISRMLS.HasValue)
        this.Adapter.InsertCommand.Parameters[0].Value = (object) YAZIISLERISRMLS.Value;
      else
        this.Adapter.InsertCommand.Parameters[0].Value = (object) DBNull.Value;
      if (ATOLYESRMLS.HasValue)
        this.Adapter.InsertCommand.Parameters[1].Value = (object) ATOLYESRMLS.Value;
      else
        this.Adapter.InsertCommand.Parameters[1].Value = (object) DBNull.Value;
      if (AMBARSRMLS.HasValue)
        this.Adapter.InsertCommand.Parameters[2].Value = (object) AMBARSRMLS.Value;
      else
        this.Adapter.InsertCommand.Parameters[2].Value = (object) DBNull.Value;
      if (ISMAKINASISRMLS.HasValue)
        this.Adapter.InsertCommand.Parameters[3].Value = (object) ISMAKINASISRMLS.Value;
      else
        this.Adapter.InsertCommand.Parameters[3].Value = (object) DBNull.Value;
      if (IKMALBIRIMSRMLS.HasValue)
        this.Adapter.InsertCommand.Parameters[4].Value = (object) IKMALBIRIMSRMLS.Value;
      else
        this.Adapter.InsertCommand.Parameters[4].Value = (object) DBNull.Value;
      if (AKARYKTSRMLS.HasValue)
        this.Adapter.InsertCommand.Parameters[5].Value = (object) AKARYKTSRMLS.Value;
      else
        this.Adapter.InsertCommand.Parameters[5].Value = (object) DBNull.Value;
      if (KAYNAKISTANYONSEF.HasValue)
        this.Adapter.InsertCommand.Parameters[6].Value = (object) KAYNAKISTANYONSEF.Value;
      else
        this.Adapter.InsertCommand.Parameters[6].Value = (object) DBNull.Value;
      if (KAMYONTAMIRUSTABAS.HasValue)
        this.Adapter.InsertCommand.Parameters[7].Value = (object) KAMYONTAMIRUSTABAS.Value;
      else
        this.Adapter.InsertCommand.Parameters[7].Value = (object) DBNull.Value;
      if (OTOLASTIKUSTABASI.HasValue)
        this.Adapter.InsertCommand.Parameters[8].Value = (object) OTOLASTIKUSTABASI.Value;
      else
        this.Adapter.InsertCommand.Parameters[8].Value = (object) DBNull.Value;
      if (AMBARAYNIYATSRMLS.HasValue)
        this.Adapter.InsertCommand.Parameters[9].Value = (object) AMBARAYNIYATSRMLS.Value;
      else
        this.Adapter.InsertCommand.Parameters[9].Value = (object) DBNull.Value;
      if (TOPLANTITARIHI.HasValue)
        this.Adapter.InsertCommand.Parameters[10].Value = (object) TOPLANTITARIHI.Value;
      else
        this.Adapter.InsertCommand.Parameters[10].Value = (object) DBNull.Value;
      if (TOPLANTIYONETICISI.HasValue)
        this.Adapter.InsertCommand.Parameters[11].Value = (object) TOPLANTIYONETICISI.Value;
      else
        this.Adapter.InsertCommand.Parameters[11].Value = (object) DBNull.Value;
      if (TOPLANTIKONUSU == null)
        this.Adapter.InsertCommand.Parameters[12].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[12].Value = (object) TOPLANTIKONUSU;
      if (DAIREBASK_KODU == null)
        this.Adapter.InsertCommand.Parameters[13].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[13].Value = (object) DAIREBASK_KODU;
      if (RAPORNO == null)
        this.Adapter.InsertCommand.Parameters[14].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[14].Value = (object) RAPORNO;
      if (TOPLANTISURESI == null)
        this.Adapter.InsertCommand.Parameters[15].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[15].Value = (object) TOPLANTISURESI;
      if (SONRAKITOPLANTITARIHI.HasValue)
        this.Adapter.InsertCommand.Parameters[16].Value = (object) SONRAKITOPLANTITARIHI.Value;
      else
        this.Adapter.InsertCommand.Parameters[16].Value = (object) DBNull.Value;
      if (GUNDEMMADDELERI == null)
        this.Adapter.InsertCommand.Parameters[17].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[17].Value = (object) GUNDEMMADDELERI;
      if (KARARACIKLAMASI == null)
        this.Adapter.InsertCommand.Parameters[18].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[18].Value = (object) KARARACIKLAMASI;
      if (ELEKTRIKSRMLS.HasValue)
        this.Adapter.InsertCommand.Parameters[19].Value = (object) ELEKTRIKSRMLS.Value;
      else
        this.Adapter.InsertCommand.Parameters[19].Value = (object) DBNull.Value;
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
      int? YAZIISLERISRMLS,
      int? ATOLYESRMLS,
      int? AMBARSRMLS,
      int? ISMAKINASISRMLS,
      int? IKMALBIRIMSRMLS,
      int? AKARYKTSRMLS,
      int? KAYNAKISTANYONSEF,
      int? KAMYONTAMIRUSTABAS,
      int? OTOLASTIKUSTABASI,
      int? AMBARAYNIYATSRMLS,
      DateTime? TOPLANTITARIHI,
      int? TOPLANTIYONETICISI,
      string TOPLANTIKONUSU,
      string DAIREBASK_KODU,
      string RAPORNO,
      string TOPLANTISURESI,
      DateTime? SONRAKITOPLANTITARIHI,
      string GUNDEMMADDELERI,
      string KARARACIKLAMASI,
      int? ELEKTRIKSRMLS,
      int Original_ID,
      int? Original_YAZIISLERISRMLS,
      int? Original_ATOLYESRMLS,
      int? Original_AMBARSRMLS,
      int? Original_ISMAKINASISRMLS,
      int? Original_IKMALBIRIMSRMLS,
      int? Original_AKARYKTSRMLS,
      int? Original_KAYNAKISTANYONSEF,
      int? Original_KAMYONTAMIRUSTABAS,
      int? Original_OTOLASTIKUSTABASI,
      int? Original_AMBARAYNIYATSRMLS,
      DateTime? Original_TOPLANTITARIHI,
      int? Original_TOPLANTIYONETICISI,
      string Original_TOPLANTIKONUSU,
      string Original_DAIREBASK_KODU,
      string Original_RAPORNO,
      string Original_TOPLANTISURESI,
      DateTime? Original_SONRAKITOPLANTITARIHI,
      string Original_GUNDEMMADDELERI,
      string Original_KARARACIKLAMASI,
      int? Original_ELEKTRIKSRMLS,
      int ID)
    {
      if (YAZIISLERISRMLS.HasValue)
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) YAZIISLERISRMLS.Value;
      else
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) DBNull.Value;
      if (ATOLYESRMLS.HasValue)
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) ATOLYESRMLS.Value;
      else
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) DBNull.Value;
      if (AMBARSRMLS.HasValue)
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) AMBARSRMLS.Value;
      else
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) DBNull.Value;
      if (ISMAKINASISRMLS.HasValue)
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) ISMAKINASISRMLS.Value;
      else
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) DBNull.Value;
      if (IKMALBIRIMSRMLS.HasValue)
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) IKMALBIRIMSRMLS.Value;
      else
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) DBNull.Value;
      if (AKARYKTSRMLS.HasValue)
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) AKARYKTSRMLS.Value;
      else
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) DBNull.Value;
      if (KAYNAKISTANYONSEF.HasValue)
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) KAYNAKISTANYONSEF.Value;
      else
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) DBNull.Value;
      if (KAMYONTAMIRUSTABAS.HasValue)
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) KAMYONTAMIRUSTABAS.Value;
      else
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) DBNull.Value;
      if (OTOLASTIKUSTABASI.HasValue)
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) OTOLASTIKUSTABASI.Value;
      else
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) DBNull.Value;
      if (AMBARAYNIYATSRMLS.HasValue)
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) AMBARAYNIYATSRMLS.Value;
      else
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) DBNull.Value;
      if (TOPLANTITARIHI.HasValue)
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) TOPLANTITARIHI.Value;
      else
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) DBNull.Value;
      if (TOPLANTIYONETICISI.HasValue)
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) TOPLANTIYONETICISI.Value;
      else
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) DBNull.Value;
      if (TOPLANTIKONUSU == null)
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) TOPLANTIKONUSU;
      if (DAIREBASK_KODU == null)
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) DAIREBASK_KODU;
      if (RAPORNO == null)
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) RAPORNO;
      if (TOPLANTISURESI == null)
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) TOPLANTISURESI;
      if (SONRAKITOPLANTITARIHI.HasValue)
        this.Adapter.UpdateCommand.Parameters[16].Value = (object) SONRAKITOPLANTITARIHI.Value;
      else
        this.Adapter.UpdateCommand.Parameters[16].Value = (object) DBNull.Value;
      if (GUNDEMMADDELERI == null)
        this.Adapter.UpdateCommand.Parameters[17].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[17].Value = (object) GUNDEMMADDELERI;
      if (KARARACIKLAMASI == null)
        this.Adapter.UpdateCommand.Parameters[18].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[18].Value = (object) KARARACIKLAMASI;
      if (ELEKTRIKSRMLS.HasValue)
        this.Adapter.UpdateCommand.Parameters[19].Value = (object) ELEKTRIKSRMLS.Value;
      else
        this.Adapter.UpdateCommand.Parameters[19].Value = (object) DBNull.Value;
      this.Adapter.UpdateCommand.Parameters[20].Value = (object) Original_ID;
      if (Original_YAZIISLERISRMLS.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[21].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[22].Value = (object) Original_YAZIISLERISRMLS.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[21].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[22].Value = (object) DBNull.Value;
      }
      if (Original_ATOLYESRMLS.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[23].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[24].Value = (object) Original_ATOLYESRMLS.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[23].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[24].Value = (object) DBNull.Value;
      }
      if (Original_AMBARSRMLS.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[25].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[26].Value = (object) Original_AMBARSRMLS.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[25].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[26].Value = (object) DBNull.Value;
      }
      if (Original_ISMAKINASISRMLS.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[27].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[28].Value = (object) Original_ISMAKINASISRMLS.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[27].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[28].Value = (object) DBNull.Value;
      }
      if (Original_IKMALBIRIMSRMLS.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[29].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[30].Value = (object) Original_IKMALBIRIMSRMLS.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[29].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[30].Value = (object) DBNull.Value;
      }
      if (Original_AKARYKTSRMLS.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[31].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[32].Value = (object) Original_AKARYKTSRMLS.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[31].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[32].Value = (object) DBNull.Value;
      }
      if (Original_KAYNAKISTANYONSEF.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[33].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[34].Value = (object) Original_KAYNAKISTANYONSEF.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[33].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[34].Value = (object) DBNull.Value;
      }
      if (Original_KAMYONTAMIRUSTABAS.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[35].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[36].Value = (object) Original_KAMYONTAMIRUSTABAS.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[35].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[36].Value = (object) DBNull.Value;
      }
      if (Original_OTOLASTIKUSTABASI.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[37].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[38].Value = (object) Original_OTOLASTIKUSTABASI.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[37].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[38].Value = (object) DBNull.Value;
      }
      if (Original_AMBARAYNIYATSRMLS.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[39].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[40].Value = (object) Original_AMBARAYNIYATSRMLS.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[39].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[40].Value = (object) DBNull.Value;
      }
      if (Original_TOPLANTITARIHI.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[41].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[42].Value = (object) Original_TOPLANTITARIHI.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[41].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[42].Value = (object) DBNull.Value;
      }
      if (Original_TOPLANTIYONETICISI.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[43].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[44].Value = (object) Original_TOPLANTIYONETICISI.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[43].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[44].Value = (object) DBNull.Value;
      }
      if (Original_TOPLANTIKONUSU == null)
      {
        this.Adapter.UpdateCommand.Parameters[45].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[46].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[45].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[46].Value = (object) Original_TOPLANTIKONUSU;
      }
      if (Original_DAIREBASK_KODU == null)
      {
        this.Adapter.UpdateCommand.Parameters[47].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[48].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[47].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[48].Value = (object) Original_DAIREBASK_KODU;
      }
      if (Original_RAPORNO == null)
      {
        this.Adapter.UpdateCommand.Parameters[49].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[50].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[49].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[50].Value = (object) Original_RAPORNO;
      }
      if (Original_TOPLANTISURESI == null)
      {
        this.Adapter.UpdateCommand.Parameters[51].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[52].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[51].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[52].Value = (object) Original_TOPLANTISURESI;
      }
      if (Original_SONRAKITOPLANTITARIHI.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[53].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[54].Value = (object) Original_SONRAKITOPLANTITARIHI.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[53].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[54].Value = (object) DBNull.Value;
      }
      if (Original_GUNDEMMADDELERI == null)
      {
        this.Adapter.UpdateCommand.Parameters[55].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[56].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[55].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[56].Value = (object) Original_GUNDEMMADDELERI;
      }
      if (Original_KARARACIKLAMASI == null)
      {
        this.Adapter.UpdateCommand.Parameters[57].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[58].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[57].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[58].Value = (object) Original_KARARACIKLAMASI;
      }
      if (Original_ELEKTRIKSRMLS.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[59].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[60].Value = (object) Original_ELEKTRIKSRMLS.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[59].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[60].Value = (object) DBNull.Value;
      }
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
      int? YAZIISLERISRMLS,
      int? ATOLYESRMLS,
      int? AMBARSRMLS,
      int? ISMAKINASISRMLS,
      int? IKMALBIRIMSRMLS,
      int? AKARYKTSRMLS,
      int? KAYNAKISTANYONSEF,
      int? KAMYONTAMIRUSTABAS,
      int? OTOLASTIKUSTABASI,
      int? AMBARAYNIYATSRMLS,
      DateTime? TOPLANTITARIHI,
      int? TOPLANTIYONETICISI,
      string TOPLANTIKONUSU,
      string DAIREBASK_KODU,
      string RAPORNO,
      string TOPLANTISURESI,
      DateTime? SONRAKITOPLANTITARIHI,
      string GUNDEMMADDELERI,
      string KARARACIKLAMASI,
      int? ELEKTRIKSRMLS,
      int Original_ID,
      int? Original_YAZIISLERISRMLS,
      int? Original_ATOLYESRMLS,
      int? Original_AMBARSRMLS,
      int? Original_ISMAKINASISRMLS,
      int? Original_IKMALBIRIMSRMLS,
      int? Original_AKARYKTSRMLS,
      int? Original_KAYNAKISTANYONSEF,
      int? Original_KAMYONTAMIRUSTABAS,
      int? Original_OTOLASTIKUSTABASI,
      int? Original_AMBARAYNIYATSRMLS,
      DateTime? Original_TOPLANTITARIHI,
      int? Original_TOPLANTIYONETICISI,
      string Original_TOPLANTIKONUSU,
      string Original_DAIREBASK_KODU,
      string Original_RAPORNO,
      string Original_TOPLANTISURESI,
      DateTime? Original_SONRAKITOPLANTITARIHI,
      string Original_GUNDEMMADDELERI,
      string Original_KARARACIKLAMASI,
      int? Original_ELEKTRIKSRMLS)
    {
      return this.Update(YAZIISLERISRMLS, ATOLYESRMLS, AMBARSRMLS, ISMAKINASISRMLS, IKMALBIRIMSRMLS, AKARYKTSRMLS, KAYNAKISTANYONSEF, KAMYONTAMIRUSTABAS, OTOLASTIKUSTABASI, AMBARAYNIYATSRMLS, TOPLANTITARIHI, TOPLANTIYONETICISI, TOPLANTIKONUSU, DAIREBASK_KODU, RAPORNO, TOPLANTISURESI, SONRAKITOPLANTITARIHI, GUNDEMMADDELERI, KARARACIKLAMASI, ELEKTRIKSRMLS, Original_ID, Original_YAZIISLERISRMLS, Original_ATOLYESRMLS, Original_AMBARSRMLS, Original_ISMAKINASISRMLS, Original_IKMALBIRIMSRMLS, Original_AKARYKTSRMLS, Original_KAYNAKISTANYONSEF, Original_KAMYONTAMIRUSTABAS, Original_OTOLASTIKUSTABASI, Original_AMBARAYNIYATSRMLS, Original_TOPLANTITARIHI, Original_TOPLANTIYONETICISI, Original_TOPLANTIKONUSU, Original_DAIREBASK_KODU, Original_RAPORNO, Original_TOPLANTISURESI, Original_SONRAKITOPLANTITARIHI, Original_GUNDEMMADDELERI, Original_KARARACIKLAMASI, Original_ELEKTRIKSRMLS, Original_ID);
    }
  }
}
