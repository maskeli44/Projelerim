// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.bellDataSet7TableAdapters.TBLTASITGOREVTableAdapter
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
  public class TBLTASITGOREVTableAdapter : Component
  {
    private SqlDataAdapter _adapter;
    private SqlConnection _connection;
    private SqlTransaction _transaction;
    private SqlCommand[] _commandCollection;
    private bool _clearBeforeFill;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public TBLTASITGOREVTableAdapter() => this.ClearBeforeFill = true;

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
        DataSetTable = "TBLTASITGOREV",
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
            "PLAKAID",
            "PLAKAID"
          },
          {
            "SOFORID",
            "SOFORID"
          },
          {
            "BIRIMID",
            "BIRIMID"
          },
          {
            "KURUM",
            "KURUM"
          },
          {
            "GOREVTURU",
            "GOREVTURU"
          },
          {
            "GIDILECEKYER",
            "GIDILECEKYER"
          },
          {
            "CIKISZAMANI",
            "CIKISZAMANI"
          },
          {
            "CIKISTARIH",
            "CIKISTARIH"
          },
          {
            "CIKISSAAT",
            "CIKISSAAT"
          },
          {
            "CIKISKM",
            "CIKISKM"
          },
          {
            "DONUSZAMANI",
            "DONUSZAMANI"
          },
          {
            "DONUSTARIH",
            "DONUSTARIH"
          },
          {
            "DONUSSAAT",
            "DONUSSAAT"
          },
          {
            "DONUSKM",
            "DONUSKM"
          },
          {
            "MESAIBITISSAATI",
            "MESAIBITISSAATI"
          },
          {
            "GUNUNADI",
            "GUNUNADI"
          },
          {
            "MESAIMIKTARI",
            "MESAIMIKTARI"
          },
          {
            "MUDURID",
            "MUDURID"
          },
          {
            "MUDONAYZAMAN",
            "MUDONAYZAMAN"
          },
          {
            "BIRIMAMIRIID",
            "BIRIMAMIRIID"
          },
          {
            "GOREVGRUPID",
            "GOREVGRUPID"
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
      this._adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[TBLTASITGOREV] WHERE (([ID] = @Original_ID) AND ((@IsNull_KOD = 1 AND [KOD] IS NULL) OR ([KOD] = @Original_KOD)) AND ((@IsNull_PLAKAID = 1 AND [PLAKAID] IS NULL) OR ([PLAKAID] = @Original_PLAKAID)) AND ((@IsNull_SOFORID = 1 AND [SOFORID] IS NULL) OR ([SOFORID] = @Original_SOFORID)) AND ((@IsNull_BIRIMID = 1 AND [BIRIMID] IS NULL) OR ([BIRIMID] = @Original_BIRIMID)) AND ((@IsNull_KURUM = 1 AND [KURUM] IS NULL) OR ([KURUM] = @Original_KURUM)) AND ((@IsNull_GOREVTURU = 1 AND [GOREVTURU] IS NULL) OR ([GOREVTURU] = @Original_GOREVTURU)) AND ((@IsNull_GIDILECEKYER = 1 AND [GIDILECEKYER] IS NULL) OR ([GIDILECEKYER] = @Original_GIDILECEKYER)) AND ((@IsNull_CIKISZAMANI = 1 AND [CIKISZAMANI] IS NULL) OR ([CIKISZAMANI] = @Original_CIKISZAMANI)) AND ((@IsNull_CIKISTARIH = 1 AND [CIKISTARIH] IS NULL) OR ([CIKISTARIH] = @Original_CIKISTARIH)) AND ((@IsNull_CIKISSAAT = 1 AND [CIKISSAAT] IS NULL) OR ([CIKISSAAT] = @Original_CIKISSAAT)) AND ((@IsNull_CIKISKM = 1 AND [CIKISKM] IS NULL) OR ([CIKISKM] = @Original_CIKISKM)) AND ((@IsNull_DONUSZAMANI = 1 AND [DONUSZAMANI] IS NULL) OR ([DONUSZAMANI] = @Original_DONUSZAMANI)) AND ((@IsNull_DONUSTARIH = 1 AND [DONUSTARIH] IS NULL) OR ([DONUSTARIH] = @Original_DONUSTARIH)) AND ((@IsNull_DONUSSAAT = 1 AND [DONUSSAAT] IS NULL) OR ([DONUSSAAT] = @Original_DONUSSAAT)) AND ((@IsNull_DONUSKM = 1 AND [DONUSKM] IS NULL) OR ([DONUSKM] = @Original_DONUSKM)) AND ((@IsNull_MESAIBITISSAATI = 1 AND [MESAIBITISSAATI] IS NULL) OR ([MESAIBITISSAATI] = @Original_MESAIBITISSAATI)) AND ((@IsNull_GUNUNADI = 1 AND [GUNUNADI] IS NULL) OR ([GUNUNADI] = @Original_GUNUNADI)) AND ((@IsNull_MESAIMIKTARI = 1 AND [MESAIMIKTARI] IS NULL) OR ([MESAIMIKTARI] = @Original_MESAIMIKTARI)) AND ((@IsNull_MUDURID = 1 AND [MUDURID] IS NULL) OR ([MUDURID] = @Original_MUDURID)) AND ((@IsNull_MUDONAYZAMAN = 1 AND [MUDONAYZAMAN] IS NULL) OR ([MUDONAYZAMAN] = @Original_MUDONAYZAMAN)) AND ((@IsNull_BIRIMAMIRIID = 1 AND [BIRIMAMIRIID] IS NULL) OR ([BIRIMAMIRIID] = @Original_BIRIMAMIRIID)) AND ((@IsNull_GOREVGRUPID = 1 AND [GOREVGRUPID] IS NULL) OR ([GOREVGRUPID] = @Original_GOREVGRUPID)) AND ((@IsNull_SAVEUSER = 1 AND [SAVEUSER] IS NULL) OR ([SAVEUSER] = @Original_SAVEUSER)) AND ((@IsNull_SAVEDATE = 1 AND [SAVEDATE] IS NULL) OR ([SAVEDATE] = @Original_SAVEDATE)) AND ((@IsNull_EDITUSER = 1 AND [EDITUSER] IS NULL) OR ([EDITUSER] = @Original_EDITUSER)) AND ((@IsNull_EDITDATE = 1 AND [EDITDATE] IS NULL) OR ([EDITDATE] = @Original_EDITDATE)) AND ((@IsNull_SAVEMAC = 1 AND [SAVEMAC] IS NULL) OR ([SAVEMAC] = @Original_SAVEMAC)) AND ((@IsNull_EDITMAC = 1 AND [EDITMAC] IS NULL) OR ([EDITMAC] = @Original_EDITMAC)) AND ((@IsNull_SAVEIP = 1 AND [SAVEIP] IS NULL) OR ([SAVEIP] = @Original_SAVEIP)) AND ((@IsNull_EDITIP = 1 AND [EDITIP] IS NULL) OR ([EDITIP] = @Original_EDITIP)))";
      this._adapter.DeleteCommand.CommandType = CommandType.Text;
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_KOD", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_KOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_PLAKAID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PLAKAID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_PLAKAID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PLAKAID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SOFORID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SOFORID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SOFORID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SOFORID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_BIRIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BIRIMID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_BIRIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BIRIMID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_KURUM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KURUM", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_KURUM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KURUM", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_GOREVTURU", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOREVTURU", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_GOREVTURU", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOREVTURU", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_GIDILECEKYER", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GIDILECEKYER", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_GIDILECEKYER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GIDILECEKYER", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_CIKISZAMANI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISZAMANI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_CIKISZAMANI", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISZAMANI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_CIKISTARIH", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISTARIH", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_CIKISTARIH", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISTARIH", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_CIKISSAAT", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISSAAT", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_CIKISSAAT", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISSAAT", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_CIKISKM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISKM", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_CIKISKM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISKM", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_DONUSZAMANI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DONUSZAMANI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_DONUSZAMANI", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DONUSZAMANI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_DONUSTARIH", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DONUSTARIH", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_DONUSTARIH", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DONUSTARIH", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_DONUSSAAT", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DONUSSAAT", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_DONUSSAAT", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DONUSSAAT", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_DONUSKM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DONUSKM", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_DONUSKM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DONUSKM", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_MESAIBITISSAATI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MESAIBITISSAATI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_MESAIBITISSAATI", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MESAIBITISSAATI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_GUNUNADI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GUNUNADI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_GUNUNADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GUNUNADI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_MESAIMIKTARI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MESAIMIKTARI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_MESAIMIKTARI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MESAIMIKTARI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_MUDURID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MUDURID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_MUDURID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MUDURID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_MUDONAYZAMAN", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MUDONAYZAMAN", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_MUDONAYZAMAN", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MUDONAYZAMAN", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_BIRIMAMIRIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BIRIMAMIRIID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_BIRIMAMIRIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BIRIMAMIRIID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_GOREVGRUPID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOREVGRUPID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_GOREVGRUPID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOREVGRUPID", DataRowVersion.Original, false, (object) null, "", "", ""));
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
      this._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[TBLTASITGOREV] ([KOD], [PLAKAID], [SOFORID], [BIRIMID], [KURUM], [GOREVTURU], [GIDILECEKYER], [CIKISZAMANI], [CIKISTARIH], [CIKISSAAT], [CIKISKM], [DONUSZAMANI], [DONUSTARIH], [DONUSSAAT], [DONUSKM], [MESAIBITISSAATI], [GUNUNADI], [MESAIMIKTARI], [MUDURID], [MUDONAYZAMAN], [BIRIMAMIRIID], [GOREVGRUPID], [SAVEUSER], [SAVEDATE], [EDITUSER], [EDITDATE], [SAVEMAC], [EDITMAC], [SAVEIP], [EDITIP]) VALUES (@KOD, @PLAKAID, @SOFORID, @BIRIMID, @KURUM, @GOREVTURU, @GIDILECEKYER, @CIKISZAMANI, @CIKISTARIH, @CIKISSAAT, @CIKISKM, @DONUSZAMANI, @DONUSTARIH, @DONUSSAAT, @DONUSKM, @MESAIBITISSAATI, @GUNUNADI, @MESAIMIKTARI, @MUDURID, @MUDONAYZAMAN, @BIRIMAMIRIID, @GOREVGRUPID, @SAVEUSER, @SAVEDATE, @EDITUSER, @EDITDATE, @SAVEMAC, @EDITMAC, @SAVEIP, @EDITIP);\r\nSELECT ID, KOD, PLAKAID, SOFORID, BIRIMID, KURUM, GOREVTURU, GIDILECEKYER, CIKISZAMANI, CIKISTARIH, CIKISSAAT, CIKISKM, DONUSZAMANI, DONUSTARIH, DONUSSAAT, DONUSKM, MESAIBITISSAATI, GUNUNADI, MESAIMIKTARI, MUDURID, MUDONAYZAMAN, BIRIMAMIRIID, GOREVGRUPID, SAVEUSER, SAVEDATE, EDITUSER, EDITDATE, SAVEMAC, EDITMAC, SAVEIP, EDITIP FROM TBLTASITGOREV WHERE (ID = SCOPE_IDENTITY())";
      this._adapter.InsertCommand.CommandType = CommandType.Text;
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@KOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@PLAKAID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PLAKAID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SOFORID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SOFORID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@BIRIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BIRIMID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@KURUM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KURUM", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@GOREVTURU", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOREVTURU", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@GIDILECEKYER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GIDILECEKYER", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@CIKISZAMANI", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISZAMANI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@CIKISTARIH", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISTARIH", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@CIKISSAAT", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISSAAT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@CIKISKM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISKM", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@DONUSZAMANI", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DONUSZAMANI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@DONUSTARIH", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DONUSTARIH", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@DONUSSAAT", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DONUSSAAT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@DONUSKM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DONUSKM", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@MESAIBITISSAATI", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MESAIBITISSAATI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@GUNUNADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GUNUNADI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@MESAIMIKTARI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MESAIMIKTARI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@MUDURID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MUDURID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@MUDONAYZAMAN", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MUDONAYZAMAN", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@BIRIMAMIRIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BIRIMAMIRIID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@GOREVGRUPID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOREVGRUPID", DataRowVersion.Current, false, (object) null, "", "", ""));
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
      this._adapter.UpdateCommand.CommandText = "UPDATE [dbo].[TBLTASITGOREV] SET [KOD] = @KOD, [PLAKAID] = @PLAKAID, [SOFORID] = @SOFORID, [BIRIMID] = @BIRIMID, [KURUM] = @KURUM, [GOREVTURU] = @GOREVTURU, [GIDILECEKYER] = @GIDILECEKYER, [CIKISZAMANI] = @CIKISZAMANI, [CIKISTARIH] = @CIKISTARIH, [CIKISSAAT] = @CIKISSAAT, [CIKISKM] = @CIKISKM, [DONUSZAMANI] = @DONUSZAMANI, [DONUSTARIH] = @DONUSTARIH, [DONUSSAAT] = @DONUSSAAT, [DONUSKM] = @DONUSKM, [MESAIBITISSAATI] = @MESAIBITISSAATI, [GUNUNADI] = @GUNUNADI, [MESAIMIKTARI] = @MESAIMIKTARI, [MUDURID] = @MUDURID, [MUDONAYZAMAN] = @MUDONAYZAMAN, [BIRIMAMIRIID] = @BIRIMAMIRIID, [GOREVGRUPID] = @GOREVGRUPID, [SAVEUSER] = @SAVEUSER, [SAVEDATE] = @SAVEDATE, [EDITUSER] = @EDITUSER, [EDITDATE] = @EDITDATE, [SAVEMAC] = @SAVEMAC, [EDITMAC] = @EDITMAC, [SAVEIP] = @SAVEIP, [EDITIP] = @EDITIP WHERE (([ID] = @Original_ID) AND ((@IsNull_KOD = 1 AND [KOD] IS NULL) OR ([KOD] = @Original_KOD)) AND ((@IsNull_PLAKAID = 1 AND [PLAKAID] IS NULL) OR ([PLAKAID] = @Original_PLAKAID)) AND ((@IsNull_SOFORID = 1 AND [SOFORID] IS NULL) OR ([SOFORID] = @Original_SOFORID)) AND ((@IsNull_BIRIMID = 1 AND [BIRIMID] IS NULL) OR ([BIRIMID] = @Original_BIRIMID)) AND ((@IsNull_KURUM = 1 AND [KURUM] IS NULL) OR ([KURUM] = @Original_KURUM)) AND ((@IsNull_GOREVTURU = 1 AND [GOREVTURU] IS NULL) OR ([GOREVTURU] = @Original_GOREVTURU)) AND ((@IsNull_GIDILECEKYER = 1 AND [GIDILECEKYER] IS NULL) OR ([GIDILECEKYER] = @Original_GIDILECEKYER)) AND ((@IsNull_CIKISZAMANI = 1 AND [CIKISZAMANI] IS NULL) OR ([CIKISZAMANI] = @Original_CIKISZAMANI)) AND ((@IsNull_CIKISTARIH = 1 AND [CIKISTARIH] IS NULL) OR ([CIKISTARIH] = @Original_CIKISTARIH)) AND ((@IsNull_CIKISSAAT = 1 AND [CIKISSAAT] IS NULL) OR ([CIKISSAAT] = @Original_CIKISSAAT)) AND ((@IsNull_CIKISKM = 1 AND [CIKISKM] IS NULL) OR ([CIKISKM] = @Original_CIKISKM)) AND ((@IsNull_DONUSZAMANI = 1 AND [DONUSZAMANI] IS NULL) OR ([DONUSZAMANI] = @Original_DONUSZAMANI)) AND ((@IsNull_DONUSTARIH = 1 AND [DONUSTARIH] IS NULL) OR ([DONUSTARIH] = @Original_DONUSTARIH)) AND ((@IsNull_DONUSSAAT = 1 AND [DONUSSAAT] IS NULL) OR ([DONUSSAAT] = @Original_DONUSSAAT)) AND ((@IsNull_DONUSKM = 1 AND [DONUSKM] IS NULL) OR ([DONUSKM] = @Original_DONUSKM)) AND ((@IsNull_MESAIBITISSAATI = 1 AND [MESAIBITISSAATI] IS NULL) OR ([MESAIBITISSAATI] = @Original_MESAIBITISSAATI)) AND ((@IsNull_GUNUNADI = 1 AND [GUNUNADI] IS NULL) OR ([GUNUNADI] = @Original_GUNUNADI)) AND ((@IsNull_MESAIMIKTARI = 1 AND [MESAIMIKTARI] IS NULL) OR ([MESAIMIKTARI] = @Original_MESAIMIKTARI)) AND ((@IsNull_MUDURID = 1 AND [MUDURID] IS NULL) OR ([MUDURID] = @Original_MUDURID)) AND ((@IsNull_MUDONAYZAMAN = 1 AND [MUDONAYZAMAN] IS NULL) OR ([MUDONAYZAMAN] = @Original_MUDONAYZAMAN)) AND ((@IsNull_BIRIMAMIRIID = 1 AND [BIRIMAMIRIID] IS NULL) OR ([BIRIMAMIRIID] = @Original_BIRIMAMIRIID)) AND ((@IsNull_GOREVGRUPID = 1 AND [GOREVGRUPID] IS NULL) OR ([GOREVGRUPID] = @Original_GOREVGRUPID)) AND ((@IsNull_SAVEUSER = 1 AND [SAVEUSER] IS NULL) OR ([SAVEUSER] = @Original_SAVEUSER)) AND ((@IsNull_SAVEDATE = 1 AND [SAVEDATE] IS NULL) OR ([SAVEDATE] = @Original_SAVEDATE)) AND ((@IsNull_EDITUSER = 1 AND [EDITUSER] IS NULL) OR ([EDITUSER] = @Original_EDITUSER)) AND ((@IsNull_EDITDATE = 1 AND [EDITDATE] IS NULL) OR ([EDITDATE] = @Original_EDITDATE)) AND ((@IsNull_SAVEMAC = 1 AND [SAVEMAC] IS NULL) OR ([SAVEMAC] = @Original_SAVEMAC)) AND ((@IsNull_EDITMAC = 1 AND [EDITMAC] IS NULL) OR ([EDITMAC] = @Original_EDITMAC)) AND ((@IsNull_SAVEIP = 1 AND [SAVEIP] IS NULL) OR ([SAVEIP] = @Original_SAVEIP)) AND ((@IsNull_EDITIP = 1 AND [EDITIP] IS NULL) OR ([EDITIP] = @Original_EDITIP)));\r\nSELECT ID, KOD, PLAKAID, SOFORID, BIRIMID, KURUM, GOREVTURU, GIDILECEKYER, CIKISZAMANI, CIKISTARIH, CIKISSAAT, CIKISKM, DONUSZAMANI, DONUSTARIH, DONUSSAAT, DONUSKM, MESAIBITISSAATI, GUNUNADI, MESAIMIKTARI, MUDURID, MUDONAYZAMAN, BIRIMAMIRIID, GOREVGRUPID, SAVEUSER, SAVEDATE, EDITUSER, EDITDATE, SAVEMAC, EDITMAC, SAVEIP, EDITIP FROM TBLTASITGOREV WHERE (ID = @ID)";
      this._adapter.UpdateCommand.CommandType = CommandType.Text;
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@KOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@PLAKAID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PLAKAID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SOFORID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SOFORID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@BIRIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BIRIMID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@KURUM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KURUM", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@GOREVTURU", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOREVTURU", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@GIDILECEKYER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GIDILECEKYER", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@CIKISZAMANI", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISZAMANI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@CIKISTARIH", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISTARIH", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@CIKISSAAT", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISSAAT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@CIKISKM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISKM", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@DONUSZAMANI", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DONUSZAMANI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@DONUSTARIH", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DONUSTARIH", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@DONUSSAAT", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DONUSSAAT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@DONUSKM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DONUSKM", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MESAIBITISSAATI", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MESAIBITISSAATI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@GUNUNADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GUNUNADI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MESAIMIKTARI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MESAIMIKTARI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MUDURID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MUDURID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MUDONAYZAMAN", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MUDONAYZAMAN", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@BIRIMAMIRIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BIRIMAMIRIID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@GOREVGRUPID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOREVGRUPID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SAVEUSER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEUSER", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SAVEDATE", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEDATE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EDITUSER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITUSER", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EDITDATE", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITDATE", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SAVEMAC", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEMAC", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EDITMAC", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITMAC", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SAVEIP", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SAVEIP", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EDITIP", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EDITIP", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_KOD", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_KOD", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOD", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_PLAKAID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PLAKAID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_PLAKAID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PLAKAID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SOFORID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SOFORID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SOFORID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SOFORID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_BIRIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BIRIMID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_BIRIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BIRIMID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_KURUM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KURUM", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_KURUM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KURUM", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_GOREVTURU", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOREVTURU", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_GOREVTURU", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOREVTURU", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_GIDILECEKYER", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GIDILECEKYER", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_GIDILECEKYER", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GIDILECEKYER", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_CIKISZAMANI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISZAMANI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_CIKISZAMANI", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISZAMANI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_CIKISTARIH", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISTARIH", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_CIKISTARIH", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISTARIH", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_CIKISSAAT", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISSAAT", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_CIKISSAAT", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISSAAT", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_CIKISKM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISKM", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_CIKISKM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CIKISKM", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_DONUSZAMANI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DONUSZAMANI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_DONUSZAMANI", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DONUSZAMANI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_DONUSTARIH", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DONUSTARIH", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_DONUSTARIH", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DONUSTARIH", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_DONUSSAAT", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DONUSSAAT", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_DONUSSAAT", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DONUSSAAT", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_DONUSKM", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DONUSKM", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_DONUSKM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DONUSKM", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_MESAIBITISSAATI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MESAIBITISSAATI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_MESAIBITISSAATI", SqlDbType.DateTime2, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MESAIBITISSAATI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_GUNUNADI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GUNUNADI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_GUNUNADI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GUNUNADI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_MESAIMIKTARI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MESAIMIKTARI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_MESAIMIKTARI", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MESAIMIKTARI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_MUDURID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MUDURID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_MUDURID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MUDURID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_MUDONAYZAMAN", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MUDONAYZAMAN", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_MUDONAYZAMAN", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MUDONAYZAMAN", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_BIRIMAMIRIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BIRIMAMIRIID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_BIRIMAMIRIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BIRIMAMIRIID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_GOREVGRUPID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOREVGRUPID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_GOREVGRUPID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GOREVGRUPID", DataRowVersion.Original, false, (object) null, "", "", ""));
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
      this._commandCollection[0].CommandText = "SELECT ID, KOD, PLAKAID, SOFORID, BIRIMID, KURUM, GOREVTURU, GIDILECEKYER, CIKISZAMANI, CIKISTARIH, CIKISSAAT, CIKISKM, DONUSZAMANI, DONUSTARIH, DONUSSAAT, DONUSKM, MESAIBITISSAATI, GUNUNADI, MESAIMIKTARI, MUDURID, MUDONAYZAMAN, BIRIMAMIRIID, GOREVGRUPID, SAVEUSER, SAVEDATE, EDITUSER, EDITDATE, SAVEMAC, EDITMAC, SAVEIP, EDITIP FROM dbo.TBLTASITGOREV";
      this._commandCollection[0].CommandType = CommandType.Text;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    public virtual int Fill(bellDataSet7.TBLTASITGOREVDataTable dataTable)
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
    public virtual bellDataSet7.TBLTASITGOREVDataTable GetData()
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      bellDataSet7.TBLTASITGOREVDataTable data = new bellDataSet7.TBLTASITGOREVDataTable();
      this.Adapter.Fill((DataTable) data);
      return data;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(bellDataSet7.TBLTASITGOREVDataTable dataTable) => this.Adapter.Update((DataTable) dataTable);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(bellDataSet7 dataSet) => this.Adapter.Update((DataSet) dataSet, "TBLTASITGOREV");

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
      int? Original_PLAKAID,
      int? Original_SOFORID,
      int? Original_BIRIMID,
      string Original_KURUM,
      string Original_GOREVTURU,
      string Original_GIDILECEKYER,
      DateTime? Original_CIKISZAMANI,
      DateTime? Original_CIKISTARIH,
      DateTime? Original_CIKISSAAT,
      string Original_CIKISKM,
      DateTime? Original_DONUSZAMANI,
      DateTime? Original_DONUSTARIH,
      DateTime? Original_DONUSSAAT,
      string Original_DONUSKM,
      DateTime? Original_MESAIBITISSAATI,
      string Original_GUNUNADI,
      string Original_MESAIMIKTARI,
      int? Original_MUDURID,
      string Original_MUDONAYZAMAN,
      int? Original_BIRIMAMIRIID,
      int? Original_GOREVGRUPID,
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
      if (Original_PLAKAID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[3].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[4].Value = (object) Original_PLAKAID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[3].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[4].Value = (object) DBNull.Value;
      }
      if (Original_SOFORID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[6].Value = (object) Original_SOFORID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[6].Value = (object) DBNull.Value;
      }
      if (Original_BIRIMID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[7].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[8].Value = (object) Original_BIRIMID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[7].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[8].Value = (object) DBNull.Value;
      }
      if (Original_KURUM == null)
      {
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) Original_KURUM;
      }
      if (Original_GOREVTURU == null)
      {
        this.Adapter.DeleteCommand.Parameters[11].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[12].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[11].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[12].Value = (object) Original_GOREVTURU;
      }
      if (Original_GIDILECEKYER == null)
      {
        this.Adapter.DeleteCommand.Parameters[13].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[14].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[13].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[14].Value = (object) Original_GIDILECEKYER;
      }
      if (Original_CIKISZAMANI.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[15].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[16].Value = (object) Original_CIKISZAMANI.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[15].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[16].Value = (object) DBNull.Value;
      }
      if (Original_CIKISTARIH.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[17].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[18].Value = (object) Original_CIKISTARIH.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[17].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[18].Value = (object) DBNull.Value;
      }
      if (Original_CIKISSAAT.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[19].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[20].Value = (object) Original_CIKISSAAT.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[19].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[20].Value = (object) DBNull.Value;
      }
      if (Original_CIKISKM == null)
      {
        this.Adapter.DeleteCommand.Parameters[21].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[22].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[21].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[22].Value = (object) Original_CIKISKM;
      }
      if (Original_DONUSZAMANI.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[23].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[24].Value = (object) Original_DONUSZAMANI.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[23].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[24].Value = (object) DBNull.Value;
      }
      if (Original_DONUSTARIH.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[25].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[26].Value = (object) Original_DONUSTARIH.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[25].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[26].Value = (object) DBNull.Value;
      }
      if (Original_DONUSSAAT.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[27].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[28].Value = (object) Original_DONUSSAAT.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[27].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[28].Value = (object) DBNull.Value;
      }
      if (Original_DONUSKM == null)
      {
        this.Adapter.DeleteCommand.Parameters[29].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[30].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[29].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[30].Value = (object) Original_DONUSKM;
      }
      if (Original_MESAIBITISSAATI.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[31].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[32].Value = (object) Original_MESAIBITISSAATI.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[31].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[32].Value = (object) DBNull.Value;
      }
      if (Original_GUNUNADI == null)
      {
        this.Adapter.DeleteCommand.Parameters[33].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[34].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[33].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[34].Value = (object) Original_GUNUNADI;
      }
      if (Original_MESAIMIKTARI == null)
      {
        this.Adapter.DeleteCommand.Parameters[35].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[36].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[35].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[36].Value = (object) Original_MESAIMIKTARI;
      }
      if (Original_MUDURID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[37].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[38].Value = (object) Original_MUDURID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[37].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[38].Value = (object) DBNull.Value;
      }
      if (Original_MUDONAYZAMAN == null)
      {
        this.Adapter.DeleteCommand.Parameters[39].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[40].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[39].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[40].Value = (object) Original_MUDONAYZAMAN;
      }
      if (Original_BIRIMAMIRIID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[41].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[42].Value = (object) Original_BIRIMAMIRIID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[41].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[42].Value = (object) DBNull.Value;
      }
      if (Original_GOREVGRUPID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[43].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[44].Value = (object) Original_GOREVGRUPID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[43].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[44].Value = (object) DBNull.Value;
      }
      if (Original_SAVEUSER == null)
      {
        this.Adapter.DeleteCommand.Parameters[45].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[46].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[45].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[46].Value = (object) Original_SAVEUSER;
      }
      if (Original_SAVEDATE.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[47].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[48].Value = (object) Original_SAVEDATE.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[47].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[48].Value = (object) DBNull.Value;
      }
      if (Original_EDITUSER == null)
      {
        this.Adapter.DeleteCommand.Parameters[49].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[50].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[49].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[50].Value = (object) Original_EDITUSER;
      }
      if (Original_EDITDATE.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[51].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[52].Value = (object) Original_EDITDATE.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[51].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[52].Value = (object) DBNull.Value;
      }
      if (Original_SAVEMAC == null)
      {
        this.Adapter.DeleteCommand.Parameters[53].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[54].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[53].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[54].Value = (object) Original_SAVEMAC;
      }
      if (Original_EDITMAC == null)
      {
        this.Adapter.DeleteCommand.Parameters[55].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[56].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[55].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[56].Value = (object) Original_EDITMAC;
      }
      if (Original_SAVEIP == null)
      {
        this.Adapter.DeleteCommand.Parameters[57].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[58].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[57].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[58].Value = (object) Original_SAVEIP;
      }
      if (Original_EDITIP == null)
      {
        this.Adapter.DeleteCommand.Parameters[59].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[60].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[59].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[60].Value = (object) Original_EDITIP;
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
      int? PLAKAID,
      int? SOFORID,
      int? BIRIMID,
      string KURUM,
      string GOREVTURU,
      string GIDILECEKYER,
      DateTime? CIKISZAMANI,
      DateTime? CIKISTARIH,
      DateTime? CIKISSAAT,
      string CIKISKM,
      DateTime? DONUSZAMANI,
      DateTime? DONUSTARIH,
      DateTime? DONUSSAAT,
      string DONUSKM,
      DateTime? MESAIBITISSAATI,
      string GUNUNADI,
      string MESAIMIKTARI,
      int? MUDURID,
      string MUDONAYZAMAN,
      int? BIRIMAMIRIID,
      int? GOREVGRUPID,
      string SAVEUSER,
      DateTime? SAVEDATE,
      string EDITUSER,
      DateTime? EDITDATE,
      string SAVEMAC,
      string EDITMAC,
      string SAVEIP,
      string EDITIP)
    {
      if (KOD == null)
        this.Adapter.InsertCommand.Parameters[0].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[0].Value = (object) KOD;
      if (PLAKAID.HasValue)
        this.Adapter.InsertCommand.Parameters[1].Value = (object) PLAKAID.Value;
      else
        this.Adapter.InsertCommand.Parameters[1].Value = (object) DBNull.Value;
      if (SOFORID.HasValue)
        this.Adapter.InsertCommand.Parameters[2].Value = (object) SOFORID.Value;
      else
        this.Adapter.InsertCommand.Parameters[2].Value = (object) DBNull.Value;
      if (BIRIMID.HasValue)
        this.Adapter.InsertCommand.Parameters[3].Value = (object) BIRIMID.Value;
      else
        this.Adapter.InsertCommand.Parameters[3].Value = (object) DBNull.Value;
      if (KURUM == null)
        this.Adapter.InsertCommand.Parameters[4].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[4].Value = (object) KURUM;
      if (GOREVTURU == null)
        this.Adapter.InsertCommand.Parameters[5].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[5].Value = (object) GOREVTURU;
      if (GIDILECEKYER == null)
        this.Adapter.InsertCommand.Parameters[6].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[6].Value = (object) GIDILECEKYER;
      if (CIKISZAMANI.HasValue)
        this.Adapter.InsertCommand.Parameters[7].Value = (object) CIKISZAMANI.Value;
      else
        this.Adapter.InsertCommand.Parameters[7].Value = (object) DBNull.Value;
      if (CIKISTARIH.HasValue)
        this.Adapter.InsertCommand.Parameters[8].Value = (object) CIKISTARIH.Value;
      else
        this.Adapter.InsertCommand.Parameters[8].Value = (object) DBNull.Value;
      if (CIKISSAAT.HasValue)
        this.Adapter.InsertCommand.Parameters[9].Value = (object) CIKISSAAT.Value;
      else
        this.Adapter.InsertCommand.Parameters[9].Value = (object) DBNull.Value;
      if (CIKISKM == null)
        this.Adapter.InsertCommand.Parameters[10].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[10].Value = (object) CIKISKM;
      if (DONUSZAMANI.HasValue)
        this.Adapter.InsertCommand.Parameters[11].Value = (object) DONUSZAMANI.Value;
      else
        this.Adapter.InsertCommand.Parameters[11].Value = (object) DBNull.Value;
      if (DONUSTARIH.HasValue)
        this.Adapter.InsertCommand.Parameters[12].Value = (object) DONUSTARIH.Value;
      else
        this.Adapter.InsertCommand.Parameters[12].Value = (object) DBNull.Value;
      if (DONUSSAAT.HasValue)
        this.Adapter.InsertCommand.Parameters[13].Value = (object) DONUSSAAT.Value;
      else
        this.Adapter.InsertCommand.Parameters[13].Value = (object) DBNull.Value;
      if (DONUSKM == null)
        this.Adapter.InsertCommand.Parameters[14].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[14].Value = (object) DONUSKM;
      if (MESAIBITISSAATI.HasValue)
        this.Adapter.InsertCommand.Parameters[15].Value = (object) MESAIBITISSAATI.Value;
      else
        this.Adapter.InsertCommand.Parameters[15].Value = (object) DBNull.Value;
      if (GUNUNADI == null)
        this.Adapter.InsertCommand.Parameters[16].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[16].Value = (object) GUNUNADI;
      if (MESAIMIKTARI == null)
        this.Adapter.InsertCommand.Parameters[17].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[17].Value = (object) MESAIMIKTARI;
      if (MUDURID.HasValue)
        this.Adapter.InsertCommand.Parameters[18].Value = (object) MUDURID.Value;
      else
        this.Adapter.InsertCommand.Parameters[18].Value = (object) DBNull.Value;
      if (MUDONAYZAMAN == null)
        this.Adapter.InsertCommand.Parameters[19].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[19].Value = (object) MUDONAYZAMAN;
      if (BIRIMAMIRIID.HasValue)
        this.Adapter.InsertCommand.Parameters[20].Value = (object) BIRIMAMIRIID.Value;
      else
        this.Adapter.InsertCommand.Parameters[20].Value = (object) DBNull.Value;
      if (GOREVGRUPID.HasValue)
        this.Adapter.InsertCommand.Parameters[21].Value = (object) GOREVGRUPID.Value;
      else
        this.Adapter.InsertCommand.Parameters[21].Value = (object) DBNull.Value;
      if (SAVEUSER == null)
        this.Adapter.InsertCommand.Parameters[22].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[22].Value = (object) SAVEUSER;
      if (SAVEDATE.HasValue)
        this.Adapter.InsertCommand.Parameters[23].Value = (object) SAVEDATE.Value;
      else
        this.Adapter.InsertCommand.Parameters[23].Value = (object) DBNull.Value;
      if (EDITUSER == null)
        this.Adapter.InsertCommand.Parameters[24].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[24].Value = (object) EDITUSER;
      if (EDITDATE.HasValue)
        this.Adapter.InsertCommand.Parameters[25].Value = (object) EDITDATE.Value;
      else
        this.Adapter.InsertCommand.Parameters[25].Value = (object) DBNull.Value;
      if (SAVEMAC == null)
        this.Adapter.InsertCommand.Parameters[26].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[26].Value = (object) SAVEMAC;
      if (EDITMAC == null)
        this.Adapter.InsertCommand.Parameters[27].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[27].Value = (object) EDITMAC;
      if (SAVEIP == null)
        this.Adapter.InsertCommand.Parameters[28].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[28].Value = (object) SAVEIP;
      if (EDITIP == null)
        this.Adapter.InsertCommand.Parameters[29].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[29].Value = (object) EDITIP;
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
      int? PLAKAID,
      int? SOFORID,
      int? BIRIMID,
      string KURUM,
      string GOREVTURU,
      string GIDILECEKYER,
      DateTime? CIKISZAMANI,
      DateTime? CIKISTARIH,
      DateTime? CIKISSAAT,
      string CIKISKM,
      DateTime? DONUSZAMANI,
      DateTime? DONUSTARIH,
      DateTime? DONUSSAAT,
      string DONUSKM,
      DateTime? MESAIBITISSAATI,
      string GUNUNADI,
      string MESAIMIKTARI,
      int? MUDURID,
      string MUDONAYZAMAN,
      int? BIRIMAMIRIID,
      int? GOREVGRUPID,
      string SAVEUSER,
      DateTime? SAVEDATE,
      string EDITUSER,
      DateTime? EDITDATE,
      string SAVEMAC,
      string EDITMAC,
      string SAVEIP,
      string EDITIP,
      int Original_ID,
      string Original_KOD,
      int? Original_PLAKAID,
      int? Original_SOFORID,
      int? Original_BIRIMID,
      string Original_KURUM,
      string Original_GOREVTURU,
      string Original_GIDILECEKYER,
      DateTime? Original_CIKISZAMANI,
      DateTime? Original_CIKISTARIH,
      DateTime? Original_CIKISSAAT,
      string Original_CIKISKM,
      DateTime? Original_DONUSZAMANI,
      DateTime? Original_DONUSTARIH,
      DateTime? Original_DONUSSAAT,
      string Original_DONUSKM,
      DateTime? Original_MESAIBITISSAATI,
      string Original_GUNUNADI,
      string Original_MESAIMIKTARI,
      int? Original_MUDURID,
      string Original_MUDONAYZAMAN,
      int? Original_BIRIMAMIRIID,
      int? Original_GOREVGRUPID,
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
      if (KOD == null)
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) KOD;
      if (PLAKAID.HasValue)
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) PLAKAID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) DBNull.Value;
      if (SOFORID.HasValue)
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) SOFORID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) DBNull.Value;
      if (BIRIMID.HasValue)
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) BIRIMID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) DBNull.Value;
      if (KURUM == null)
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) KURUM;
      if (GOREVTURU == null)
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) GOREVTURU;
      if (GIDILECEKYER == null)
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) GIDILECEKYER;
      if (CIKISZAMANI.HasValue)
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) CIKISZAMANI.Value;
      else
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) DBNull.Value;
      if (CIKISTARIH.HasValue)
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) CIKISTARIH.Value;
      else
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) DBNull.Value;
      if (CIKISSAAT.HasValue)
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) CIKISSAAT.Value;
      else
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) DBNull.Value;
      if (CIKISKM == null)
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) CIKISKM;
      if (DONUSZAMANI.HasValue)
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) DONUSZAMANI.Value;
      else
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) DBNull.Value;
      if (DONUSTARIH.HasValue)
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) DONUSTARIH.Value;
      else
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) DBNull.Value;
      if (DONUSSAAT.HasValue)
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) DONUSSAAT.Value;
      else
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) DBNull.Value;
      if (DONUSKM == null)
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) DONUSKM;
      if (MESAIBITISSAATI.HasValue)
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) MESAIBITISSAATI.Value;
      else
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) DBNull.Value;
      if (GUNUNADI == null)
        this.Adapter.UpdateCommand.Parameters[16].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[16].Value = (object) GUNUNADI;
      if (MESAIMIKTARI == null)
        this.Adapter.UpdateCommand.Parameters[17].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[17].Value = (object) MESAIMIKTARI;
      if (MUDURID.HasValue)
        this.Adapter.UpdateCommand.Parameters[18].Value = (object) MUDURID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[18].Value = (object) DBNull.Value;
      if (MUDONAYZAMAN == null)
        this.Adapter.UpdateCommand.Parameters[19].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[19].Value = (object) MUDONAYZAMAN;
      if (BIRIMAMIRIID.HasValue)
        this.Adapter.UpdateCommand.Parameters[20].Value = (object) BIRIMAMIRIID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[20].Value = (object) DBNull.Value;
      if (GOREVGRUPID.HasValue)
        this.Adapter.UpdateCommand.Parameters[21].Value = (object) GOREVGRUPID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[21].Value = (object) DBNull.Value;
      if (SAVEUSER == null)
        this.Adapter.UpdateCommand.Parameters[22].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[22].Value = (object) SAVEUSER;
      if (SAVEDATE.HasValue)
        this.Adapter.UpdateCommand.Parameters[23].Value = (object) SAVEDATE.Value;
      else
        this.Adapter.UpdateCommand.Parameters[23].Value = (object) DBNull.Value;
      if (EDITUSER == null)
        this.Adapter.UpdateCommand.Parameters[24].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[24].Value = (object) EDITUSER;
      if (EDITDATE.HasValue)
        this.Adapter.UpdateCommand.Parameters[25].Value = (object) EDITDATE.Value;
      else
        this.Adapter.UpdateCommand.Parameters[25].Value = (object) DBNull.Value;
      if (SAVEMAC == null)
        this.Adapter.UpdateCommand.Parameters[26].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[26].Value = (object) SAVEMAC;
      if (EDITMAC == null)
        this.Adapter.UpdateCommand.Parameters[27].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[27].Value = (object) EDITMAC;
      if (SAVEIP == null)
        this.Adapter.UpdateCommand.Parameters[28].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[28].Value = (object) SAVEIP;
      if (EDITIP == null)
        this.Adapter.UpdateCommand.Parameters[29].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[29].Value = (object) EDITIP;
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
      if (Original_PLAKAID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[33].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[34].Value = (object) Original_PLAKAID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[33].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[34].Value = (object) DBNull.Value;
      }
      if (Original_SOFORID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[35].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[36].Value = (object) Original_SOFORID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[35].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[36].Value = (object) DBNull.Value;
      }
      if (Original_BIRIMID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[37].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[38].Value = (object) Original_BIRIMID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[37].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[38].Value = (object) DBNull.Value;
      }
      if (Original_KURUM == null)
      {
        this.Adapter.UpdateCommand.Parameters[39].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[40].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[39].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[40].Value = (object) Original_KURUM;
      }
      if (Original_GOREVTURU == null)
      {
        this.Adapter.UpdateCommand.Parameters[41].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[42].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[41].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[42].Value = (object) Original_GOREVTURU;
      }
      if (Original_GIDILECEKYER == null)
      {
        this.Adapter.UpdateCommand.Parameters[43].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[44].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[43].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[44].Value = (object) Original_GIDILECEKYER;
      }
      if (Original_CIKISZAMANI.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[45].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[46].Value = (object) Original_CIKISZAMANI.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[45].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[46].Value = (object) DBNull.Value;
      }
      if (Original_CIKISTARIH.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[47].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[48].Value = (object) Original_CIKISTARIH.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[47].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[48].Value = (object) DBNull.Value;
      }
      if (Original_CIKISSAAT.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[49].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[50].Value = (object) Original_CIKISSAAT.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[49].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[50].Value = (object) DBNull.Value;
      }
      if (Original_CIKISKM == null)
      {
        this.Adapter.UpdateCommand.Parameters[51].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[52].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[51].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[52].Value = (object) Original_CIKISKM;
      }
      if (Original_DONUSZAMANI.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[53].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[54].Value = (object) Original_DONUSZAMANI.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[53].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[54].Value = (object) DBNull.Value;
      }
      if (Original_DONUSTARIH.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[55].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[56].Value = (object) Original_DONUSTARIH.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[55].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[56].Value = (object) DBNull.Value;
      }
      if (Original_DONUSSAAT.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[57].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[58].Value = (object) Original_DONUSSAAT.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[57].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[58].Value = (object) DBNull.Value;
      }
      if (Original_DONUSKM == null)
      {
        this.Adapter.UpdateCommand.Parameters[59].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[60].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[59].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[60].Value = (object) Original_DONUSKM;
      }
      if (Original_MESAIBITISSAATI.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[61].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[62].Value = (object) Original_MESAIBITISSAATI.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[61].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[62].Value = (object) DBNull.Value;
      }
      if (Original_GUNUNADI == null)
      {
        this.Adapter.UpdateCommand.Parameters[63].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[64].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[63].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[64].Value = (object) Original_GUNUNADI;
      }
      if (Original_MESAIMIKTARI == null)
      {
        this.Adapter.UpdateCommand.Parameters[65].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[66].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[65].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[66].Value = (object) Original_MESAIMIKTARI;
      }
      if (Original_MUDURID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[67].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[68].Value = (object) Original_MUDURID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[67].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[68].Value = (object) DBNull.Value;
      }
      if (Original_MUDONAYZAMAN == null)
      {
        this.Adapter.UpdateCommand.Parameters[69].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[70].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[69].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[70].Value = (object) Original_MUDONAYZAMAN;
      }
      if (Original_BIRIMAMIRIID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[71].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[72].Value = (object) Original_BIRIMAMIRIID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[71].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[72].Value = (object) DBNull.Value;
      }
      if (Original_GOREVGRUPID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[73].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[74].Value = (object) Original_GOREVGRUPID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[73].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[74].Value = (object) DBNull.Value;
      }
      if (Original_SAVEUSER == null)
      {
        this.Adapter.UpdateCommand.Parameters[75].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[76].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[75].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[76].Value = (object) Original_SAVEUSER;
      }
      if (Original_SAVEDATE.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[77].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[78].Value = (object) Original_SAVEDATE.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[77].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[78].Value = (object) DBNull.Value;
      }
      if (Original_EDITUSER == null)
      {
        this.Adapter.UpdateCommand.Parameters[79].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[80].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[79].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[80].Value = (object) Original_EDITUSER;
      }
      if (Original_EDITDATE.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[81].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[82].Value = (object) Original_EDITDATE.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[81].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[82].Value = (object) DBNull.Value;
      }
      if (Original_SAVEMAC == null)
      {
        this.Adapter.UpdateCommand.Parameters[83].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[84].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[83].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[84].Value = (object) Original_SAVEMAC;
      }
      if (Original_EDITMAC == null)
      {
        this.Adapter.UpdateCommand.Parameters[85].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[86].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[85].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[86].Value = (object) Original_EDITMAC;
      }
      if (Original_SAVEIP == null)
      {
        this.Adapter.UpdateCommand.Parameters[87].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[88].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[87].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[88].Value = (object) Original_SAVEIP;
      }
      if (Original_EDITIP == null)
      {
        this.Adapter.UpdateCommand.Parameters[89].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[90].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[89].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[90].Value = (object) Original_EDITIP;
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
      int? PLAKAID,
      int? SOFORID,
      int? BIRIMID,
      string KURUM,
      string GOREVTURU,
      string GIDILECEKYER,
      DateTime? CIKISZAMANI,
      DateTime? CIKISTARIH,
      DateTime? CIKISSAAT,
      string CIKISKM,
      DateTime? DONUSZAMANI,
      DateTime? DONUSTARIH,
      DateTime? DONUSSAAT,
      string DONUSKM,
      DateTime? MESAIBITISSAATI,
      string GUNUNADI,
      string MESAIMIKTARI,
      int? MUDURID,
      string MUDONAYZAMAN,
      int? BIRIMAMIRIID,
      int? GOREVGRUPID,
      string SAVEUSER,
      DateTime? SAVEDATE,
      string EDITUSER,
      DateTime? EDITDATE,
      string SAVEMAC,
      string EDITMAC,
      string SAVEIP,
      string EDITIP,
      int Original_ID,
      string Original_KOD,
      int? Original_PLAKAID,
      int? Original_SOFORID,
      int? Original_BIRIMID,
      string Original_KURUM,
      string Original_GOREVTURU,
      string Original_GIDILECEKYER,
      DateTime? Original_CIKISZAMANI,
      DateTime? Original_CIKISTARIH,
      DateTime? Original_CIKISSAAT,
      string Original_CIKISKM,
      DateTime? Original_DONUSZAMANI,
      DateTime? Original_DONUSTARIH,
      DateTime? Original_DONUSSAAT,
      string Original_DONUSKM,
      DateTime? Original_MESAIBITISSAATI,
      string Original_GUNUNADI,
      string Original_MESAIMIKTARI,
      int? Original_MUDURID,
      string Original_MUDONAYZAMAN,
      int? Original_BIRIMAMIRIID,
      int? Original_GOREVGRUPID,
      string Original_SAVEUSER,
      DateTime? Original_SAVEDATE,
      string Original_EDITUSER,
      DateTime? Original_EDITDATE,
      string Original_SAVEMAC,
      string Original_EDITMAC,
      string Original_SAVEIP,
      string Original_EDITIP)
    {
      return this.Update(KOD, PLAKAID, SOFORID, BIRIMID, KURUM, GOREVTURU, GIDILECEKYER, CIKISZAMANI, CIKISTARIH, CIKISSAAT, CIKISKM, DONUSZAMANI, DONUSTARIH, DONUSSAAT, DONUSKM, MESAIBITISSAATI, GUNUNADI, MESAIMIKTARI, MUDURID, MUDONAYZAMAN, BIRIMAMIRIID, GOREVGRUPID, SAVEUSER, SAVEDATE, EDITUSER, EDITDATE, SAVEMAC, EDITMAC, SAVEIP, EDITIP, Original_ID, Original_KOD, Original_PLAKAID, Original_SOFORID, Original_BIRIMID, Original_KURUM, Original_GOREVTURU, Original_GIDILECEKYER, Original_CIKISZAMANI, Original_CIKISTARIH, Original_CIKISSAAT, Original_CIKISKM, Original_DONUSZAMANI, Original_DONUSTARIH, Original_DONUSSAAT, Original_DONUSKM, Original_MESAIBITISSAATI, Original_GUNUNADI, Original_MESAIMIKTARI, Original_MUDURID, Original_MUDONAYZAMAN, Original_BIRIMAMIRIID, Original_GOREVGRUPID, Original_SAVEUSER, Original_SAVEDATE, Original_EDITUSER, Original_EDITDATE, Original_SAVEMAC, Original_EDITMAC, Original_SAVEIP, Original_EDITIP, Original_ID);
    }
  }
}
