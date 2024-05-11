// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.bellDataSet5TableAdapters.TBLTEKLIFHRKTTableAdapter
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

namespace Makina_Ikmal.bellDataSet5TableAdapters
{
  [DesignerCategory("code")]
  [ToolboxItem(true)]
  [DataObject(true)]
  [Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [HelpKeyword("vs.data.TableAdapter")]
  public class TBLTEKLIFHRKTTableAdapter : Component
  {
    private SqlDataAdapter _adapter;
    private SqlConnection _connection;
    private SqlTransaction _transaction;
    private SqlCommand[] _commandCollection;
    private bool _clearBeforeFill;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public TBLTEKLIFHRKTTableAdapter() => this.ClearBeforeFill = true;

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
        DataSetTable = "TBLTEKLIFHRKT",
        ColumnMappings = {
          {
            "ID",
            "ID"
          },
          {
            "TEKLIFID",
            "TEKLIFID"
          },
          {
            "ARACID",
            "ARACID"
          },
          {
            "MALZEMEID",
            "MALZEMEID"
          },
          {
            "MALZACIKLAMA",
            "MALZACIKLAMA"
          },
          {
            "BIRIMID",
            "BIRIMID"
          },
          {
            "MIKTAR",
            "MIKTAR"
          },
          {
            "MARKA",
            "MARKA"
          },
          {
            "BIRIMFIYAT",
            "BIRIMFIYAT"
          },
          {
            "TUTAR",
            "TUTAR"
          },
          {
            "FIRMA1ID",
            "FIRMA1ID"
          },
          {
            "F1BIRIMFIYAT",
            "F1BIRIMFIYAT"
          },
          {
            "F1TUTAR",
            "F1TUTAR"
          },
          {
            "FIRMA2ID",
            "FIRMA2ID"
          },
          {
            "F2BIRIMFIYAT",
            "F2BIRIMFIYAT"
          },
          {
            "F2TUTAR",
            "F2TUTAR"
          },
          {
            "FIRMA3ID",
            "FIRMA3ID"
          },
          {
            "F3BIRIMFIYAT",
            "F3BIRIMFIYAT"
          },
          {
            "F3TUTAR",
            "F3TUTAR"
          },
          {
            "FIRMA4ID",
            "FIRMA4ID"
          },
          {
            "F4BIRIMFIYAT",
            "F4BIRIMFIYAT"
          },
          {
            "F4TUTAR",
            "F4TUTAR"
          },
          {
            "FIRMA5ID",
            "FIRMA5ID"
          },
          {
            "F5BIRIMFIYAT",
            "F5BIRIMFIYAT"
          },
          {
            "F5TUTAR",
            "F5TUTAR"
          },
          {
            "FIRMA6ID",
            "FIRMA6ID"
          },
          {
            "F6BIRIMFIYAT",
            "F6BIRIMFIYAT"
          },
          {
            "F6TUTAR",
            "F6TUTAR"
          },
          {
            "FIRMA7ID",
            "FIRMA7ID"
          },
          {
            "F7BIRIMFIYAT",
            "F7BIRIMFIYAT"
          },
          {
            "F7TUTAR",
            "F7TUTAR"
          },
          {
            "FIRMA8ID",
            "FIRMA8ID"
          },
          {
            "F8BIRIMFIYAT",
            "F8BIRIMFIYAT"
          },
          {
            "F8TUTAR",
            "F8TUTAR"
          }
        }
      });
      this._adapter.DeleteCommand = new SqlCommand();
      this._adapter.DeleteCommand.Connection = this.Connection;
      this._adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[TBLTEKLIFHRKT] WHERE (([ID] = @Original_ID) AND ((@IsNull_TEKLIFID = 1 AND [TEKLIFID] IS NULL) OR ([TEKLIFID] = @Original_TEKLIFID)) AND ((@IsNull_ARACID = 1 AND [ARACID] IS NULL) OR ([ARACID] = @Original_ARACID)) AND ((@IsNull_MALZEMEID = 1 AND [MALZEMEID] IS NULL) OR ([MALZEMEID] = @Original_MALZEMEID)) AND ((@IsNull_MALZACIKLAMA = 1 AND [MALZACIKLAMA] IS NULL) OR ([MALZACIKLAMA] = @Original_MALZACIKLAMA)) AND ((@IsNull_BIRIMID = 1 AND [BIRIMID] IS NULL) OR ([BIRIMID] = @Original_BIRIMID)) AND ((@IsNull_MIKTAR = 1 AND [MIKTAR] IS NULL) OR ([MIKTAR] = @Original_MIKTAR)) AND ((@IsNull_MARKA = 1 AND [MARKA] IS NULL) OR ([MARKA] = @Original_MARKA)) AND ((@IsNull_BIRIMFIYAT = 1 AND [BIRIMFIYAT] IS NULL) OR ([BIRIMFIYAT] = @Original_BIRIMFIYAT)) AND ((@IsNull_TUTAR = 1 AND [TUTAR] IS NULL) OR ([TUTAR] = @Original_TUTAR)) AND ((@IsNull_FIRMA1ID = 1 AND [FIRMA1ID] IS NULL) OR ([FIRMA1ID] = @Original_FIRMA1ID)) AND ((@IsNull_F1BIRIMFIYAT = 1 AND [F1BIRIMFIYAT] IS NULL) OR ([F1BIRIMFIYAT] = @Original_F1BIRIMFIYAT)) AND ((@IsNull_F1TUTAR = 1 AND [F1TUTAR] IS NULL) OR ([F1TUTAR] = @Original_F1TUTAR)) AND ((@IsNull_FIRMA2ID = 1 AND [FIRMA2ID] IS NULL) OR ([FIRMA2ID] = @Original_FIRMA2ID)) AND ((@IsNull_F2BIRIMFIYAT = 1 AND [F2BIRIMFIYAT] IS NULL) OR ([F2BIRIMFIYAT] = @Original_F2BIRIMFIYAT)) AND ((@IsNull_F2TUTAR = 1 AND [F2TUTAR] IS NULL) OR ([F2TUTAR] = @Original_F2TUTAR)) AND ((@IsNull_FIRMA3ID = 1 AND [FIRMA3ID] IS NULL) OR ([FIRMA3ID] = @Original_FIRMA3ID)) AND ((@IsNull_F3BIRIMFIYAT = 1 AND [F3BIRIMFIYAT] IS NULL) OR ([F3BIRIMFIYAT] = @Original_F3BIRIMFIYAT)) AND ((@IsNull_F3TUTAR = 1 AND [F3TUTAR] IS NULL) OR ([F3TUTAR] = @Original_F3TUTAR)) AND ((@IsNull_FIRMA4ID = 1 AND [FIRMA4ID] IS NULL) OR ([FIRMA4ID] = @Original_FIRMA4ID)) AND ((@IsNull_F4BIRIMFIYAT = 1 AND [F4BIRIMFIYAT] IS NULL) OR ([F4BIRIMFIYAT] = @Original_F4BIRIMFIYAT)) AND ((@IsNull_F4TUTAR = 1 AND [F4TUTAR] IS NULL) OR ([F4TUTAR] = @Original_F4TUTAR)) AND ((@IsNull_FIRMA5ID = 1 AND [FIRMA5ID] IS NULL) OR ([FIRMA5ID] = @Original_FIRMA5ID)) AND ((@IsNull_F5BIRIMFIYAT = 1 AND [F5BIRIMFIYAT] IS NULL) OR ([F5BIRIMFIYAT] = @Original_F5BIRIMFIYAT)) AND ((@IsNull_F5TUTAR = 1 AND [F5TUTAR] IS NULL) OR ([F5TUTAR] = @Original_F5TUTAR)) AND ((@IsNull_FIRMA6ID = 1 AND [FIRMA6ID] IS NULL) OR ([FIRMA6ID] = @Original_FIRMA6ID)) AND ((@IsNull_F6BIRIMFIYAT = 1 AND [F6BIRIMFIYAT] IS NULL) OR ([F6BIRIMFIYAT] = @Original_F6BIRIMFIYAT)) AND ((@IsNull_F6TUTAR = 1 AND [F6TUTAR] IS NULL) OR ([F6TUTAR] = @Original_F6TUTAR)) AND ((@IsNull_FIRMA7ID = 1 AND [FIRMA7ID] IS NULL) OR ([FIRMA7ID] = @Original_FIRMA7ID)) AND ((@IsNull_F7BIRIMFIYAT = 1 AND [F7BIRIMFIYAT] IS NULL) OR ([F7BIRIMFIYAT] = @Original_F7BIRIMFIYAT)) AND ((@IsNull_F7TUTAR = 1 AND [F7TUTAR] IS NULL) OR ([F7TUTAR] = @Original_F7TUTAR)) AND ((@IsNull_FIRMA8ID = 1 AND [FIRMA8ID] IS NULL) OR ([FIRMA8ID] = @Original_FIRMA8ID)) AND ((@IsNull_F8BIRIMFIYAT = 1 AND [F8BIRIMFIYAT] IS NULL) OR ([F8BIRIMFIYAT] = @Original_F8BIRIMFIYAT)) AND ((@IsNull_F8TUTAR = 1 AND [F8TUTAR] IS NULL) OR ([F8TUTAR] = @Original_F8TUTAR)))";
      this._adapter.DeleteCommand.CommandType = CommandType.Text;
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TEKLIFID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TEKLIFID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TEKLIFID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TEKLIFID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ARACID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ARACID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_MALZEMEID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZEMEID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_MALZEMEID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZEMEID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_MALZACIKLAMA", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZACIKLAMA", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_MALZACIKLAMA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZACIKLAMA", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_BIRIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BIRIMID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_BIRIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BIRIMID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_MIKTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MIKTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_MIKTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "MIKTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_MARKA", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MARKA", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_MARKA", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "MARKA", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_BIRIMFIYAT", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BIRIMFIYAT", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_BIRIMFIYAT", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "BIRIMFIYAT", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TUTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TUTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "TUTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_FIRMA1ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA1ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_FIRMA1ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA1ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_F1BIRIMFIYAT", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "F1BIRIMFIYAT", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_F1BIRIMFIYAT", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F1BIRIMFIYAT", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_F1TUTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "F1TUTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_F1TUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F1TUTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_FIRMA2ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA2ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_FIRMA2ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA2ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_F2BIRIMFIYAT", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "F2BIRIMFIYAT", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_F2BIRIMFIYAT", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F2BIRIMFIYAT", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_F2TUTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "F2TUTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_F2TUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F2TUTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_FIRMA3ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA3ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_FIRMA3ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA3ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_F3BIRIMFIYAT", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "F3BIRIMFIYAT", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_F3BIRIMFIYAT", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F3BIRIMFIYAT", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_F3TUTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "F3TUTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_F3TUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F3TUTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_FIRMA4ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA4ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_FIRMA4ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA4ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_F4BIRIMFIYAT", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "F4BIRIMFIYAT", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_F4BIRIMFIYAT", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F4BIRIMFIYAT", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_F4TUTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "F4TUTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_F4TUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F4TUTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_FIRMA5ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA5ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_FIRMA5ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA5ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_F5BIRIMFIYAT", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "F5BIRIMFIYAT", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_F5BIRIMFIYAT", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F5BIRIMFIYAT", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_F5TUTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "F5TUTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_F5TUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F5TUTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_FIRMA6ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA6ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_FIRMA6ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA6ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_F6BIRIMFIYAT", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "F6BIRIMFIYAT", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_F6BIRIMFIYAT", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F6BIRIMFIYAT", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_F6TUTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "F6TUTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_F6TUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F6TUTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_FIRMA7ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA7ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_FIRMA7ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA7ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_F7BIRIMFIYAT", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "F7BIRIMFIYAT", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_F7BIRIMFIYAT", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F7BIRIMFIYAT", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_F7TUTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "F7TUTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_F7TUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F7TUTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_FIRMA8ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA8ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_FIRMA8ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA8ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_F8BIRIMFIYAT", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "F8BIRIMFIYAT", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_F8BIRIMFIYAT", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F8BIRIMFIYAT", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_F8TUTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "F8TUTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_F8TUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F8TUTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.InsertCommand = new SqlCommand();
      this._adapter.InsertCommand.Connection = this.Connection;
      this._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[TBLTEKLIFHRKT] ([TEKLIFID], [ARACID], [MALZEMEID], [MALZACIKLAMA], [BIRIMID], [MIKTAR], [MARKA], [BIRIMFIYAT], [TUTAR], [FIRMA1ID], [F1BIRIMFIYAT], [F1TUTAR], [FIRMA2ID], [F2BIRIMFIYAT], [F2TUTAR], [FIRMA3ID], [F3BIRIMFIYAT], [F3TUTAR], [FIRMA4ID], [F4BIRIMFIYAT], [F4TUTAR], [FIRMA5ID], [F5BIRIMFIYAT], [F5TUTAR], [FIRMA6ID], [F6BIRIMFIYAT], [F6TUTAR], [FIRMA7ID], [F7BIRIMFIYAT], [F7TUTAR], [FIRMA8ID], [F8BIRIMFIYAT], [F8TUTAR]) VALUES (@TEKLIFID, @ARACID, @MALZEMEID, @MALZACIKLAMA, @BIRIMID, @MIKTAR, @MARKA, @BIRIMFIYAT, @TUTAR, @FIRMA1ID, @F1BIRIMFIYAT, @F1TUTAR, @FIRMA2ID, @F2BIRIMFIYAT, @F2TUTAR, @FIRMA3ID, @F3BIRIMFIYAT, @F3TUTAR, @FIRMA4ID, @F4BIRIMFIYAT, @F4TUTAR, @FIRMA5ID, @F5BIRIMFIYAT, @F5TUTAR, @FIRMA6ID, @F6BIRIMFIYAT, @F6TUTAR, @FIRMA7ID, @F7BIRIMFIYAT, @F7TUTAR, @FIRMA8ID, @F8BIRIMFIYAT, @F8TUTAR);\r\nSELECT ID, TEKLIFID, ARACID, MALZEMEID, MALZACIKLAMA, BIRIMID, MIKTAR, MARKA, BIRIMFIYAT, TUTAR, FIRMA1ID, F1BIRIMFIYAT, F1TUTAR, FIRMA2ID, F2BIRIMFIYAT, F2TUTAR, FIRMA3ID, F3BIRIMFIYAT, F3TUTAR, FIRMA4ID, F4BIRIMFIYAT, F4TUTAR, FIRMA5ID, F5BIRIMFIYAT, F5TUTAR, FIRMA6ID, F6BIRIMFIYAT, F6TUTAR, FIRMA7ID, F7BIRIMFIYAT, F7TUTAR, FIRMA8ID, F8BIRIMFIYAT, F8TUTAR FROM TBLTEKLIFHRKT WHERE (ID = SCOPE_IDENTITY())";
      this._adapter.InsertCommand.CommandType = CommandType.Text;
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@TEKLIFID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TEKLIFID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ARACID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@MALZEMEID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZEMEID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@MALZACIKLAMA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZACIKLAMA", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@BIRIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BIRIMID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@MIKTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "MIKTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@MARKA", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "MARKA", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@BIRIMFIYAT", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "BIRIMFIYAT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@TUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "TUTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@FIRMA1ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA1ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@F1BIRIMFIYAT", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F1BIRIMFIYAT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@F1TUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F1TUTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@FIRMA2ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA2ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@F2BIRIMFIYAT", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F2BIRIMFIYAT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@F2TUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F2TUTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@FIRMA3ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA3ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@F3BIRIMFIYAT", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F3BIRIMFIYAT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@F3TUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F3TUTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@FIRMA4ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA4ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@F4BIRIMFIYAT", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F4BIRIMFIYAT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@F4TUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F4TUTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@FIRMA5ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA5ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@F5BIRIMFIYAT", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F5BIRIMFIYAT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@F5TUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F5TUTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@FIRMA6ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA6ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@F6BIRIMFIYAT", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F6BIRIMFIYAT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@F6TUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F6TUTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@FIRMA7ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA7ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@F7BIRIMFIYAT", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F7BIRIMFIYAT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@F7TUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F7TUTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@FIRMA8ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA8ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@F8BIRIMFIYAT", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F8BIRIMFIYAT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@F8TUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F8TUTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand = new SqlCommand();
      this._adapter.UpdateCommand.Connection = this.Connection;
      this._adapter.UpdateCommand.CommandText = "UPDATE [dbo].[TBLTEKLIFHRKT] SET [TEKLIFID] = @TEKLIFID, [ARACID] = @ARACID, [MALZEMEID] = @MALZEMEID, [MALZACIKLAMA] = @MALZACIKLAMA, [BIRIMID] = @BIRIMID, [MIKTAR] = @MIKTAR, [MARKA] = @MARKA, [BIRIMFIYAT] = @BIRIMFIYAT, [TUTAR] = @TUTAR, [FIRMA1ID] = @FIRMA1ID, [F1BIRIMFIYAT] = @F1BIRIMFIYAT, [F1TUTAR] = @F1TUTAR, [FIRMA2ID] = @FIRMA2ID, [F2BIRIMFIYAT] = @F2BIRIMFIYAT, [F2TUTAR] = @F2TUTAR, [FIRMA3ID] = @FIRMA3ID, [F3BIRIMFIYAT] = @F3BIRIMFIYAT, [F3TUTAR] = @F3TUTAR, [FIRMA4ID] = @FIRMA4ID, [F4BIRIMFIYAT] = @F4BIRIMFIYAT, [F4TUTAR] = @F4TUTAR, [FIRMA5ID] = @FIRMA5ID, [F5BIRIMFIYAT] = @F5BIRIMFIYAT, [F5TUTAR] = @F5TUTAR, [FIRMA6ID] = @FIRMA6ID, [F6BIRIMFIYAT] = @F6BIRIMFIYAT, [F6TUTAR] = @F6TUTAR, [FIRMA7ID] = @FIRMA7ID, [F7BIRIMFIYAT] = @F7BIRIMFIYAT, [F7TUTAR] = @F7TUTAR, [FIRMA8ID] = @FIRMA8ID, [F8BIRIMFIYAT] = @F8BIRIMFIYAT, [F8TUTAR] = @F8TUTAR WHERE (([ID] = @Original_ID) AND ((@IsNull_TEKLIFID = 1 AND [TEKLIFID] IS NULL) OR ([TEKLIFID] = @Original_TEKLIFID)) AND ((@IsNull_ARACID = 1 AND [ARACID] IS NULL) OR ([ARACID] = @Original_ARACID)) AND ((@IsNull_MALZEMEID = 1 AND [MALZEMEID] IS NULL) OR ([MALZEMEID] = @Original_MALZEMEID)) AND ((@IsNull_MALZACIKLAMA = 1 AND [MALZACIKLAMA] IS NULL) OR ([MALZACIKLAMA] = @Original_MALZACIKLAMA)) AND ((@IsNull_BIRIMID = 1 AND [BIRIMID] IS NULL) OR ([BIRIMID] = @Original_BIRIMID)) AND ((@IsNull_MIKTAR = 1 AND [MIKTAR] IS NULL) OR ([MIKTAR] = @Original_MIKTAR)) AND ((@IsNull_MARKA = 1 AND [MARKA] IS NULL) OR ([MARKA] = @Original_MARKA)) AND ((@IsNull_BIRIMFIYAT = 1 AND [BIRIMFIYAT] IS NULL) OR ([BIRIMFIYAT] = @Original_BIRIMFIYAT)) AND ((@IsNull_TUTAR = 1 AND [TUTAR] IS NULL) OR ([TUTAR] = @Original_TUTAR)) AND ((@IsNull_FIRMA1ID = 1 AND [FIRMA1ID] IS NULL) OR ([FIRMA1ID] = @Original_FIRMA1ID)) AND ((@IsNull_F1BIRIMFIYAT = 1 AND [F1BIRIMFIYAT] IS NULL) OR ([F1BIRIMFIYAT] = @Original_F1BIRIMFIYAT)) AND ((@IsNull_F1TUTAR = 1 AND [F1TUTAR] IS NULL) OR ([F1TUTAR] = @Original_F1TUTAR)) AND ((@IsNull_FIRMA2ID = 1 AND [FIRMA2ID] IS NULL) OR ([FIRMA2ID] = @Original_FIRMA2ID)) AND ((@IsNull_F2BIRIMFIYAT = 1 AND [F2BIRIMFIYAT] IS NULL) OR ([F2BIRIMFIYAT] = @Original_F2BIRIMFIYAT)) AND ((@IsNull_F2TUTAR = 1 AND [F2TUTAR] IS NULL) OR ([F2TUTAR] = @Original_F2TUTAR)) AND ((@IsNull_FIRMA3ID = 1 AND [FIRMA3ID] IS NULL) OR ([FIRMA3ID] = @Original_FIRMA3ID)) AND ((@IsNull_F3BIRIMFIYAT = 1 AND [F3BIRIMFIYAT] IS NULL) OR ([F3BIRIMFIYAT] = @Original_F3BIRIMFIYAT)) AND ((@IsNull_F3TUTAR = 1 AND [F3TUTAR] IS NULL) OR ([F3TUTAR] = @Original_F3TUTAR)) AND ((@IsNull_FIRMA4ID = 1 AND [FIRMA4ID] IS NULL) OR ([FIRMA4ID] = @Original_FIRMA4ID)) AND ((@IsNull_F4BIRIMFIYAT = 1 AND [F4BIRIMFIYAT] IS NULL) OR ([F4BIRIMFIYAT] = @Original_F4BIRIMFIYAT)) AND ((@IsNull_F4TUTAR = 1 AND [F4TUTAR] IS NULL) OR ([F4TUTAR] = @Original_F4TUTAR)) AND ((@IsNull_FIRMA5ID = 1 AND [FIRMA5ID] IS NULL) OR ([FIRMA5ID] = @Original_FIRMA5ID)) AND ((@IsNull_F5BIRIMFIYAT = 1 AND [F5BIRIMFIYAT] IS NULL) OR ([F5BIRIMFIYAT] = @Original_F5BIRIMFIYAT)) AND ((@IsNull_F5TUTAR = 1 AND [F5TUTAR] IS NULL) OR ([F5TUTAR] = @Original_F5TUTAR)) AND ((@IsNull_FIRMA6ID = 1 AND [FIRMA6ID] IS NULL) OR ([FIRMA6ID] = @Original_FIRMA6ID)) AND ((@IsNull_F6BIRIMFIYAT = 1 AND [F6BIRIMFIYAT] IS NULL) OR ([F6BIRIMFIYAT] = @Original_F6BIRIMFIYAT)) AND ((@IsNull_F6TUTAR = 1 AND [F6TUTAR] IS NULL) OR ([F6TUTAR] = @Original_F6TUTAR)) AND ((@IsNull_FIRMA7ID = 1 AND [FIRMA7ID] IS NULL) OR ([FIRMA7ID] = @Original_FIRMA7ID)) AND ((@IsNull_F7BIRIMFIYAT = 1 AND [F7BIRIMFIYAT] IS NULL) OR ([F7BIRIMFIYAT] = @Original_F7BIRIMFIYAT)) AND ((@IsNull_F7TUTAR = 1 AND [F7TUTAR] IS NULL) OR ([F7TUTAR] = @Original_F7TUTAR)) AND ((@IsNull_FIRMA8ID = 1 AND [FIRMA8ID] IS NULL) OR ([FIRMA8ID] = @Original_FIRMA8ID)) AND ((@IsNull_F8BIRIMFIYAT = 1 AND [F8BIRIMFIYAT] IS NULL) OR ([F8BIRIMFIYAT] = @Original_F8BIRIMFIYAT)) AND ((@IsNull_F8TUTAR = 1 AND [F8TUTAR] IS NULL) OR ([F8TUTAR] = @Original_F8TUTAR)));\r\nSELECT ID, TEKLIFID, ARACID, MALZEMEID, MALZACIKLAMA, BIRIMID, MIKTAR, MARKA, BIRIMFIYAT, TUTAR, FIRMA1ID, F1BIRIMFIYAT, F1TUTAR, FIRMA2ID, F2BIRIMFIYAT, F2TUTAR, FIRMA3ID, F3BIRIMFIYAT, F3TUTAR, FIRMA4ID, F4BIRIMFIYAT, F4TUTAR, FIRMA5ID, F5BIRIMFIYAT, F5TUTAR, FIRMA6ID, F6BIRIMFIYAT, F6TUTAR, FIRMA7ID, F7BIRIMFIYAT, F7TUTAR, FIRMA8ID, F8BIRIMFIYAT, F8TUTAR FROM TBLTEKLIFHRKT WHERE (ID = @ID)";
      this._adapter.UpdateCommand.CommandType = CommandType.Text;
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TEKLIFID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TEKLIFID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ARACID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MALZEMEID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZEMEID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MALZACIKLAMA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZACIKLAMA", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@BIRIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BIRIMID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MIKTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "MIKTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MARKA", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "MARKA", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@BIRIMFIYAT", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "BIRIMFIYAT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "TUTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@FIRMA1ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA1ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@F1BIRIMFIYAT", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F1BIRIMFIYAT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@F1TUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F1TUTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@FIRMA2ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA2ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@F2BIRIMFIYAT", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F2BIRIMFIYAT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@F2TUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F2TUTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@FIRMA3ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA3ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@F3BIRIMFIYAT", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F3BIRIMFIYAT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@F3TUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F3TUTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@FIRMA4ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA4ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@F4BIRIMFIYAT", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F4BIRIMFIYAT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@F4TUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F4TUTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@FIRMA5ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA5ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@F5BIRIMFIYAT", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F5BIRIMFIYAT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@F5TUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F5TUTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@FIRMA6ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA6ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@F6BIRIMFIYAT", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F6BIRIMFIYAT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@F6TUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F6TUTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@FIRMA7ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA7ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@F7BIRIMFIYAT", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F7BIRIMFIYAT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@F7TUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F7TUTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@FIRMA8ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA8ID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@F8BIRIMFIYAT", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F8BIRIMFIYAT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@F8TUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F8TUTAR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TEKLIFID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TEKLIFID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TEKLIFID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TEKLIFID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ARACID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ARACID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_MALZEMEID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZEMEID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_MALZEMEID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZEMEID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_MALZACIKLAMA", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZACIKLAMA", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_MALZACIKLAMA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MALZACIKLAMA", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_BIRIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BIRIMID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_BIRIMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BIRIMID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_MIKTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MIKTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_MIKTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "MIKTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_MARKA", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MARKA", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_MARKA", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "MARKA", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_BIRIMFIYAT", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BIRIMFIYAT", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_BIRIMFIYAT", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "BIRIMFIYAT", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TUTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TUTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "TUTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_FIRMA1ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA1ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_FIRMA1ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA1ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_F1BIRIMFIYAT", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "F1BIRIMFIYAT", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_F1BIRIMFIYAT", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F1BIRIMFIYAT", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_F1TUTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "F1TUTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_F1TUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F1TUTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_FIRMA2ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA2ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_FIRMA2ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA2ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_F2BIRIMFIYAT", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "F2BIRIMFIYAT", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_F2BIRIMFIYAT", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F2BIRIMFIYAT", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_F2TUTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "F2TUTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_F2TUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F2TUTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_FIRMA3ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA3ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_FIRMA3ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA3ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_F3BIRIMFIYAT", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "F3BIRIMFIYAT", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_F3BIRIMFIYAT", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F3BIRIMFIYAT", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_F3TUTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "F3TUTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_F3TUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F3TUTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_FIRMA4ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA4ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_FIRMA4ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA4ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_F4BIRIMFIYAT", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "F4BIRIMFIYAT", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_F4BIRIMFIYAT", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F4BIRIMFIYAT", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_F4TUTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "F4TUTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_F4TUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F4TUTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_FIRMA5ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA5ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_FIRMA5ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA5ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_F5BIRIMFIYAT", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "F5BIRIMFIYAT", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_F5BIRIMFIYAT", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F5BIRIMFIYAT", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_F5TUTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "F5TUTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_F5TUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F5TUTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_FIRMA6ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA6ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_FIRMA6ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA6ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_F6BIRIMFIYAT", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "F6BIRIMFIYAT", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_F6BIRIMFIYAT", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F6BIRIMFIYAT", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_F6TUTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "F6TUTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_F6TUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F6TUTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_FIRMA7ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA7ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_FIRMA7ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA7ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_F7BIRIMFIYAT", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "F7BIRIMFIYAT", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_F7BIRIMFIYAT", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F7BIRIMFIYAT", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_F7TUTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "F7TUTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_F7TUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F7TUTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_FIRMA8ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA8ID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_FIRMA8ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FIRMA8ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_F8BIRIMFIYAT", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "F8BIRIMFIYAT", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_F8BIRIMFIYAT", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F8BIRIMFIYAT", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_F8TUTAR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "F8TUTAR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_F8TUTAR", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 2, "F8TUTAR", DataRowVersion.Original, false, (object) null, "", "", ""));
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
      this._commandCollection[0].CommandText = "SELECT ID, TEKLIFID, ARACID, MALZEMEID, MALZACIKLAMA, BIRIMID, MIKTAR, MARKA, BIRIMFIYAT, TUTAR, FIRMA1ID, F1BIRIMFIYAT, F1TUTAR, FIRMA2ID, F2BIRIMFIYAT, F2TUTAR, FIRMA3ID, F3BIRIMFIYAT, F3TUTAR, FIRMA4ID, F4BIRIMFIYAT, F4TUTAR, FIRMA5ID, F5BIRIMFIYAT, F5TUTAR, FIRMA6ID, F6BIRIMFIYAT, F6TUTAR, FIRMA7ID, F7BIRIMFIYAT, F7TUTAR, FIRMA8ID, F8BIRIMFIYAT, F8TUTAR FROM dbo.TBLTEKLIFHRKT";
      this._commandCollection[0].CommandType = CommandType.Text;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    public virtual int Fill(bellDataSet5.TBLTEKLIFHRKTDataTable dataTable)
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
    public virtual bellDataSet5.TBLTEKLIFHRKTDataTable GetData()
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      bellDataSet5.TBLTEKLIFHRKTDataTable data = new bellDataSet5.TBLTEKLIFHRKTDataTable();
      this.Adapter.Fill((DataTable) data);
      return data;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(bellDataSet5.TBLTEKLIFHRKTDataTable dataTable) => this.Adapter.Update((DataTable) dataTable);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(bellDataSet5 dataSet) => this.Adapter.Update((DataSet) dataSet, "TBLTEKLIFHRKT");

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
      int? Original_TEKLIFID,
      int? Original_ARACID,
      int? Original_MALZEMEID,
      string Original_MALZACIKLAMA,
      int? Original_BIRIMID,
      Decimal? Original_MIKTAR,
      Decimal? Original_MARKA,
      Decimal? Original_BIRIMFIYAT,
      Decimal? Original_TUTAR,
      int? Original_FIRMA1ID,
      Decimal? Original_F1BIRIMFIYAT,
      Decimal? Original_F1TUTAR,
      int? Original_FIRMA2ID,
      Decimal? Original_F2BIRIMFIYAT,
      Decimal? Original_F2TUTAR,
      int? Original_FIRMA3ID,
      Decimal? Original_F3BIRIMFIYAT,
      Decimal? Original_F3TUTAR,
      int? Original_FIRMA4ID,
      Decimal? Original_F4BIRIMFIYAT,
      Decimal? Original_F4TUTAR,
      int? Original_FIRMA5ID,
      Decimal? Original_F5BIRIMFIYAT,
      Decimal? Original_F5TUTAR,
      int? Original_FIRMA6ID,
      Decimal? Original_F6BIRIMFIYAT,
      Decimal? Original_F6TUTAR,
      int? Original_FIRMA7ID,
      Decimal? Original_F7BIRIMFIYAT,
      Decimal? Original_F7TUTAR,
      int? Original_FIRMA8ID,
      Decimal? Original_F8BIRIMFIYAT,
      Decimal? Original_F8TUTAR)
    {
      this.Adapter.DeleteCommand.Parameters[0].Value = (object) Original_ID;
      if (Original_TEKLIFID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[1].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[2].Value = (object) Original_TEKLIFID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[1].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[2].Value = (object) DBNull.Value;
      }
      if (Original_ARACID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[3].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[4].Value = (object) Original_ARACID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[3].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[4].Value = (object) DBNull.Value;
      }
      if (Original_MALZEMEID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[6].Value = (object) Original_MALZEMEID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[6].Value = (object) DBNull.Value;
      }
      if (Original_MALZACIKLAMA == null)
      {
        this.Adapter.DeleteCommand.Parameters[7].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[8].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[7].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[8].Value = (object) Original_MALZACIKLAMA;
      }
      if (Original_BIRIMID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) Original_BIRIMID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) DBNull.Value;
      }
      if (Original_MIKTAR.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[11].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[12].Value = (object) Original_MIKTAR.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[11].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[12].Value = (object) DBNull.Value;
      }
      if (Original_MARKA.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[13].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[14].Value = (object) Original_MARKA.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[13].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[14].Value = (object) DBNull.Value;
      }
      if (Original_BIRIMFIYAT.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[15].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[16].Value = (object) Original_BIRIMFIYAT.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[15].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[16].Value = (object) DBNull.Value;
      }
      if (Original_TUTAR.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[17].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[18].Value = (object) Original_TUTAR.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[17].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[18].Value = (object) DBNull.Value;
      }
      if (Original_FIRMA1ID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[19].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[20].Value = (object) Original_FIRMA1ID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[19].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[20].Value = (object) DBNull.Value;
      }
      if (Original_F1BIRIMFIYAT.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[21].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[22].Value = (object) Original_F1BIRIMFIYAT.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[21].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[22].Value = (object) DBNull.Value;
      }
      if (Original_F1TUTAR.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[23].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[24].Value = (object) Original_F1TUTAR.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[23].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[24].Value = (object) DBNull.Value;
      }
      if (Original_FIRMA2ID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[25].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[26].Value = (object) Original_FIRMA2ID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[25].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[26].Value = (object) DBNull.Value;
      }
      if (Original_F2BIRIMFIYAT.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[27].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[28].Value = (object) Original_F2BIRIMFIYAT.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[27].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[28].Value = (object) DBNull.Value;
      }
      if (Original_F2TUTAR.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[29].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[30].Value = (object) Original_F2TUTAR.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[29].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[30].Value = (object) DBNull.Value;
      }
      if (Original_FIRMA3ID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[31].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[32].Value = (object) Original_FIRMA3ID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[31].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[32].Value = (object) DBNull.Value;
      }
      if (Original_F3BIRIMFIYAT.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[33].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[34].Value = (object) Original_F3BIRIMFIYAT.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[33].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[34].Value = (object) DBNull.Value;
      }
      if (Original_F3TUTAR.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[35].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[36].Value = (object) Original_F3TUTAR.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[35].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[36].Value = (object) DBNull.Value;
      }
      if (Original_FIRMA4ID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[37].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[38].Value = (object) Original_FIRMA4ID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[37].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[38].Value = (object) DBNull.Value;
      }
      if (Original_F4BIRIMFIYAT.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[39].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[40].Value = (object) Original_F4BIRIMFIYAT.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[39].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[40].Value = (object) DBNull.Value;
      }
      if (Original_F4TUTAR.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[41].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[42].Value = (object) Original_F4TUTAR.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[41].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[42].Value = (object) DBNull.Value;
      }
      if (Original_FIRMA5ID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[43].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[44].Value = (object) Original_FIRMA5ID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[43].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[44].Value = (object) DBNull.Value;
      }
      if (Original_F5BIRIMFIYAT.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[45].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[46].Value = (object) Original_F5BIRIMFIYAT.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[45].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[46].Value = (object) DBNull.Value;
      }
      if (Original_F5TUTAR.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[47].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[48].Value = (object) Original_F5TUTAR.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[47].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[48].Value = (object) DBNull.Value;
      }
      if (Original_FIRMA6ID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[49].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[50].Value = (object) Original_FIRMA6ID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[49].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[50].Value = (object) DBNull.Value;
      }
      if (Original_F6BIRIMFIYAT.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[51].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[52].Value = (object) Original_F6BIRIMFIYAT.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[51].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[52].Value = (object) DBNull.Value;
      }
      if (Original_F6TUTAR.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[53].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[54].Value = (object) Original_F6TUTAR.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[53].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[54].Value = (object) DBNull.Value;
      }
      if (Original_FIRMA7ID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[55].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[56].Value = (object) Original_FIRMA7ID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[55].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[56].Value = (object) DBNull.Value;
      }
      if (Original_F7BIRIMFIYAT.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[57].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[58].Value = (object) Original_F7BIRIMFIYAT.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[57].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[58].Value = (object) DBNull.Value;
      }
      if (Original_F7TUTAR.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[59].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[60].Value = (object) Original_F7TUTAR.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[59].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[60].Value = (object) DBNull.Value;
      }
      if (Original_FIRMA8ID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[61].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[62].Value = (object) Original_FIRMA8ID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[61].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[62].Value = (object) DBNull.Value;
      }
      if (Original_F8BIRIMFIYAT.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[63].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[64].Value = (object) Original_F8BIRIMFIYAT.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[63].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[64].Value = (object) DBNull.Value;
      }
      if (Original_F8TUTAR.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[65].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[66].Value = (object) Original_F8TUTAR.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[65].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[66].Value = (object) DBNull.Value;
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
      int? TEKLIFID,
      int? ARACID,
      int? MALZEMEID,
      string MALZACIKLAMA,
      int? BIRIMID,
      Decimal? MIKTAR,
      Decimal? MARKA,
      Decimal? BIRIMFIYAT,
      Decimal? TUTAR,
      int? FIRMA1ID,
      Decimal? F1BIRIMFIYAT,
      Decimal? F1TUTAR,
      int? FIRMA2ID,
      Decimal? F2BIRIMFIYAT,
      Decimal? F2TUTAR,
      int? FIRMA3ID,
      Decimal? F3BIRIMFIYAT,
      Decimal? F3TUTAR,
      int? FIRMA4ID,
      Decimal? F4BIRIMFIYAT,
      Decimal? F4TUTAR,
      int? FIRMA5ID,
      Decimal? F5BIRIMFIYAT,
      Decimal? F5TUTAR,
      int? FIRMA6ID,
      Decimal? F6BIRIMFIYAT,
      Decimal? F6TUTAR,
      int? FIRMA7ID,
      Decimal? F7BIRIMFIYAT,
      Decimal? F7TUTAR,
      int? FIRMA8ID,
      Decimal? F8BIRIMFIYAT,
      Decimal? F8TUTAR)
    {
      if (TEKLIFID.HasValue)
        this.Adapter.InsertCommand.Parameters[0].Value = (object) TEKLIFID.Value;
      else
        this.Adapter.InsertCommand.Parameters[0].Value = (object) DBNull.Value;
      if (ARACID.HasValue)
        this.Adapter.InsertCommand.Parameters[1].Value = (object) ARACID.Value;
      else
        this.Adapter.InsertCommand.Parameters[1].Value = (object) DBNull.Value;
      if (MALZEMEID.HasValue)
        this.Adapter.InsertCommand.Parameters[2].Value = (object) MALZEMEID.Value;
      else
        this.Adapter.InsertCommand.Parameters[2].Value = (object) DBNull.Value;
      if (MALZACIKLAMA == null)
        this.Adapter.InsertCommand.Parameters[3].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[3].Value = (object) MALZACIKLAMA;
      if (BIRIMID.HasValue)
        this.Adapter.InsertCommand.Parameters[4].Value = (object) BIRIMID.Value;
      else
        this.Adapter.InsertCommand.Parameters[4].Value = (object) DBNull.Value;
      if (MIKTAR.HasValue)
        this.Adapter.InsertCommand.Parameters[5].Value = (object) MIKTAR.Value;
      else
        this.Adapter.InsertCommand.Parameters[5].Value = (object) DBNull.Value;
      if (MARKA.HasValue)
        this.Adapter.InsertCommand.Parameters[6].Value = (object) MARKA.Value;
      else
        this.Adapter.InsertCommand.Parameters[6].Value = (object) DBNull.Value;
      if (BIRIMFIYAT.HasValue)
        this.Adapter.InsertCommand.Parameters[7].Value = (object) BIRIMFIYAT.Value;
      else
        this.Adapter.InsertCommand.Parameters[7].Value = (object) DBNull.Value;
      if (TUTAR.HasValue)
        this.Adapter.InsertCommand.Parameters[8].Value = (object) TUTAR.Value;
      else
        this.Adapter.InsertCommand.Parameters[8].Value = (object) DBNull.Value;
      if (FIRMA1ID.HasValue)
        this.Adapter.InsertCommand.Parameters[9].Value = (object) FIRMA1ID.Value;
      else
        this.Adapter.InsertCommand.Parameters[9].Value = (object) DBNull.Value;
      if (F1BIRIMFIYAT.HasValue)
        this.Adapter.InsertCommand.Parameters[10].Value = (object) F1BIRIMFIYAT.Value;
      else
        this.Adapter.InsertCommand.Parameters[10].Value = (object) DBNull.Value;
      if (F1TUTAR.HasValue)
        this.Adapter.InsertCommand.Parameters[11].Value = (object) F1TUTAR.Value;
      else
        this.Adapter.InsertCommand.Parameters[11].Value = (object) DBNull.Value;
      if (FIRMA2ID.HasValue)
        this.Adapter.InsertCommand.Parameters[12].Value = (object) FIRMA2ID.Value;
      else
        this.Adapter.InsertCommand.Parameters[12].Value = (object) DBNull.Value;
      if (F2BIRIMFIYAT.HasValue)
        this.Adapter.InsertCommand.Parameters[13].Value = (object) F2BIRIMFIYAT.Value;
      else
        this.Adapter.InsertCommand.Parameters[13].Value = (object) DBNull.Value;
      if (F2TUTAR.HasValue)
        this.Adapter.InsertCommand.Parameters[14].Value = (object) F2TUTAR.Value;
      else
        this.Adapter.InsertCommand.Parameters[14].Value = (object) DBNull.Value;
      if (FIRMA3ID.HasValue)
        this.Adapter.InsertCommand.Parameters[15].Value = (object) FIRMA3ID.Value;
      else
        this.Adapter.InsertCommand.Parameters[15].Value = (object) DBNull.Value;
      if (F3BIRIMFIYAT.HasValue)
        this.Adapter.InsertCommand.Parameters[16].Value = (object) F3BIRIMFIYAT.Value;
      else
        this.Adapter.InsertCommand.Parameters[16].Value = (object) DBNull.Value;
      if (F3TUTAR.HasValue)
        this.Adapter.InsertCommand.Parameters[17].Value = (object) F3TUTAR.Value;
      else
        this.Adapter.InsertCommand.Parameters[17].Value = (object) DBNull.Value;
      if (FIRMA4ID.HasValue)
        this.Adapter.InsertCommand.Parameters[18].Value = (object) FIRMA4ID.Value;
      else
        this.Adapter.InsertCommand.Parameters[18].Value = (object) DBNull.Value;
      if (F4BIRIMFIYAT.HasValue)
        this.Adapter.InsertCommand.Parameters[19].Value = (object) F4BIRIMFIYAT.Value;
      else
        this.Adapter.InsertCommand.Parameters[19].Value = (object) DBNull.Value;
      if (F4TUTAR.HasValue)
        this.Adapter.InsertCommand.Parameters[20].Value = (object) F4TUTAR.Value;
      else
        this.Adapter.InsertCommand.Parameters[20].Value = (object) DBNull.Value;
      if (FIRMA5ID.HasValue)
        this.Adapter.InsertCommand.Parameters[21].Value = (object) FIRMA5ID.Value;
      else
        this.Adapter.InsertCommand.Parameters[21].Value = (object) DBNull.Value;
      if (F5BIRIMFIYAT.HasValue)
        this.Adapter.InsertCommand.Parameters[22].Value = (object) F5BIRIMFIYAT.Value;
      else
        this.Adapter.InsertCommand.Parameters[22].Value = (object) DBNull.Value;
      if (F5TUTAR.HasValue)
        this.Adapter.InsertCommand.Parameters[23].Value = (object) F5TUTAR.Value;
      else
        this.Adapter.InsertCommand.Parameters[23].Value = (object) DBNull.Value;
      if (FIRMA6ID.HasValue)
        this.Adapter.InsertCommand.Parameters[24].Value = (object) FIRMA6ID.Value;
      else
        this.Adapter.InsertCommand.Parameters[24].Value = (object) DBNull.Value;
      if (F6BIRIMFIYAT.HasValue)
        this.Adapter.InsertCommand.Parameters[25].Value = (object) F6BIRIMFIYAT.Value;
      else
        this.Adapter.InsertCommand.Parameters[25].Value = (object) DBNull.Value;
      if (F6TUTAR.HasValue)
        this.Adapter.InsertCommand.Parameters[26].Value = (object) F6TUTAR.Value;
      else
        this.Adapter.InsertCommand.Parameters[26].Value = (object) DBNull.Value;
      if (FIRMA7ID.HasValue)
        this.Adapter.InsertCommand.Parameters[27].Value = (object) FIRMA7ID.Value;
      else
        this.Adapter.InsertCommand.Parameters[27].Value = (object) DBNull.Value;
      if (F7BIRIMFIYAT.HasValue)
        this.Adapter.InsertCommand.Parameters[28].Value = (object) F7BIRIMFIYAT.Value;
      else
        this.Adapter.InsertCommand.Parameters[28].Value = (object) DBNull.Value;
      if (F7TUTAR.HasValue)
        this.Adapter.InsertCommand.Parameters[29].Value = (object) F7TUTAR.Value;
      else
        this.Adapter.InsertCommand.Parameters[29].Value = (object) DBNull.Value;
      if (FIRMA8ID.HasValue)
        this.Adapter.InsertCommand.Parameters[30].Value = (object) FIRMA8ID.Value;
      else
        this.Adapter.InsertCommand.Parameters[30].Value = (object) DBNull.Value;
      if (F8BIRIMFIYAT.HasValue)
        this.Adapter.InsertCommand.Parameters[31].Value = (object) F8BIRIMFIYAT.Value;
      else
        this.Adapter.InsertCommand.Parameters[31].Value = (object) DBNull.Value;
      if (F8TUTAR.HasValue)
        this.Adapter.InsertCommand.Parameters[32].Value = (object) F8TUTAR.Value;
      else
        this.Adapter.InsertCommand.Parameters[32].Value = (object) DBNull.Value;
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
      int? TEKLIFID,
      int? ARACID,
      int? MALZEMEID,
      string MALZACIKLAMA,
      int? BIRIMID,
      Decimal? MIKTAR,
      Decimal? MARKA,
      Decimal? BIRIMFIYAT,
      Decimal? TUTAR,
      int? FIRMA1ID,
      Decimal? F1BIRIMFIYAT,
      Decimal? F1TUTAR,
      int? FIRMA2ID,
      Decimal? F2BIRIMFIYAT,
      Decimal? F2TUTAR,
      int? FIRMA3ID,
      Decimal? F3BIRIMFIYAT,
      Decimal? F3TUTAR,
      int? FIRMA4ID,
      Decimal? F4BIRIMFIYAT,
      Decimal? F4TUTAR,
      int? FIRMA5ID,
      Decimal? F5BIRIMFIYAT,
      Decimal? F5TUTAR,
      int? FIRMA6ID,
      Decimal? F6BIRIMFIYAT,
      Decimal? F6TUTAR,
      int? FIRMA7ID,
      Decimal? F7BIRIMFIYAT,
      Decimal? F7TUTAR,
      int? FIRMA8ID,
      Decimal? F8BIRIMFIYAT,
      Decimal? F8TUTAR,
      int Original_ID,
      int? Original_TEKLIFID,
      int? Original_ARACID,
      int? Original_MALZEMEID,
      string Original_MALZACIKLAMA,
      int? Original_BIRIMID,
      Decimal? Original_MIKTAR,
      Decimal? Original_MARKA,
      Decimal? Original_BIRIMFIYAT,
      Decimal? Original_TUTAR,
      int? Original_FIRMA1ID,
      Decimal? Original_F1BIRIMFIYAT,
      Decimal? Original_F1TUTAR,
      int? Original_FIRMA2ID,
      Decimal? Original_F2BIRIMFIYAT,
      Decimal? Original_F2TUTAR,
      int? Original_FIRMA3ID,
      Decimal? Original_F3BIRIMFIYAT,
      Decimal? Original_F3TUTAR,
      int? Original_FIRMA4ID,
      Decimal? Original_F4BIRIMFIYAT,
      Decimal? Original_F4TUTAR,
      int? Original_FIRMA5ID,
      Decimal? Original_F5BIRIMFIYAT,
      Decimal? Original_F5TUTAR,
      int? Original_FIRMA6ID,
      Decimal? Original_F6BIRIMFIYAT,
      Decimal? Original_F6TUTAR,
      int? Original_FIRMA7ID,
      Decimal? Original_F7BIRIMFIYAT,
      Decimal? Original_F7TUTAR,
      int? Original_FIRMA8ID,
      Decimal? Original_F8BIRIMFIYAT,
      Decimal? Original_F8TUTAR,
      int ID)
    {
      if (TEKLIFID.HasValue)
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) TEKLIFID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) DBNull.Value;
      if (ARACID.HasValue)
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) ARACID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) DBNull.Value;
      if (MALZEMEID.HasValue)
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) MALZEMEID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) DBNull.Value;
      if (MALZACIKLAMA == null)
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) MALZACIKLAMA;
      if (BIRIMID.HasValue)
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) BIRIMID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) DBNull.Value;
      if (MIKTAR.HasValue)
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) MIKTAR.Value;
      else
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) DBNull.Value;
      if (MARKA.HasValue)
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) MARKA.Value;
      else
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) DBNull.Value;
      if (BIRIMFIYAT.HasValue)
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) BIRIMFIYAT.Value;
      else
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) DBNull.Value;
      if (TUTAR.HasValue)
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) TUTAR.Value;
      else
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) DBNull.Value;
      if (FIRMA1ID.HasValue)
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) FIRMA1ID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) DBNull.Value;
      if (F1BIRIMFIYAT.HasValue)
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) F1BIRIMFIYAT.Value;
      else
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) DBNull.Value;
      if (F1TUTAR.HasValue)
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) F1TUTAR.Value;
      else
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) DBNull.Value;
      if (FIRMA2ID.HasValue)
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) FIRMA2ID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) DBNull.Value;
      if (F2BIRIMFIYAT.HasValue)
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) F2BIRIMFIYAT.Value;
      else
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) DBNull.Value;
      if (F2TUTAR.HasValue)
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) F2TUTAR.Value;
      else
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) DBNull.Value;
      if (FIRMA3ID.HasValue)
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) FIRMA3ID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) DBNull.Value;
      if (F3BIRIMFIYAT.HasValue)
        this.Adapter.UpdateCommand.Parameters[16].Value = (object) F3BIRIMFIYAT.Value;
      else
        this.Adapter.UpdateCommand.Parameters[16].Value = (object) DBNull.Value;
      if (F3TUTAR.HasValue)
        this.Adapter.UpdateCommand.Parameters[17].Value = (object) F3TUTAR.Value;
      else
        this.Adapter.UpdateCommand.Parameters[17].Value = (object) DBNull.Value;
      if (FIRMA4ID.HasValue)
        this.Adapter.UpdateCommand.Parameters[18].Value = (object) FIRMA4ID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[18].Value = (object) DBNull.Value;
      if (F4BIRIMFIYAT.HasValue)
        this.Adapter.UpdateCommand.Parameters[19].Value = (object) F4BIRIMFIYAT.Value;
      else
        this.Adapter.UpdateCommand.Parameters[19].Value = (object) DBNull.Value;
      if (F4TUTAR.HasValue)
        this.Adapter.UpdateCommand.Parameters[20].Value = (object) F4TUTAR.Value;
      else
        this.Adapter.UpdateCommand.Parameters[20].Value = (object) DBNull.Value;
      if (FIRMA5ID.HasValue)
        this.Adapter.UpdateCommand.Parameters[21].Value = (object) FIRMA5ID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[21].Value = (object) DBNull.Value;
      if (F5BIRIMFIYAT.HasValue)
        this.Adapter.UpdateCommand.Parameters[22].Value = (object) F5BIRIMFIYAT.Value;
      else
        this.Adapter.UpdateCommand.Parameters[22].Value = (object) DBNull.Value;
      if (F5TUTAR.HasValue)
        this.Adapter.UpdateCommand.Parameters[23].Value = (object) F5TUTAR.Value;
      else
        this.Adapter.UpdateCommand.Parameters[23].Value = (object) DBNull.Value;
      if (FIRMA6ID.HasValue)
        this.Adapter.UpdateCommand.Parameters[24].Value = (object) FIRMA6ID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[24].Value = (object) DBNull.Value;
      if (F6BIRIMFIYAT.HasValue)
        this.Adapter.UpdateCommand.Parameters[25].Value = (object) F6BIRIMFIYAT.Value;
      else
        this.Adapter.UpdateCommand.Parameters[25].Value = (object) DBNull.Value;
      if (F6TUTAR.HasValue)
        this.Adapter.UpdateCommand.Parameters[26].Value = (object) F6TUTAR.Value;
      else
        this.Adapter.UpdateCommand.Parameters[26].Value = (object) DBNull.Value;
      if (FIRMA7ID.HasValue)
        this.Adapter.UpdateCommand.Parameters[27].Value = (object) FIRMA7ID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[27].Value = (object) DBNull.Value;
      if (F7BIRIMFIYAT.HasValue)
        this.Adapter.UpdateCommand.Parameters[28].Value = (object) F7BIRIMFIYAT.Value;
      else
        this.Adapter.UpdateCommand.Parameters[28].Value = (object) DBNull.Value;
      if (F7TUTAR.HasValue)
        this.Adapter.UpdateCommand.Parameters[29].Value = (object) F7TUTAR.Value;
      else
        this.Adapter.UpdateCommand.Parameters[29].Value = (object) DBNull.Value;
      if (FIRMA8ID.HasValue)
        this.Adapter.UpdateCommand.Parameters[30].Value = (object) FIRMA8ID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[30].Value = (object) DBNull.Value;
      if (F8BIRIMFIYAT.HasValue)
        this.Adapter.UpdateCommand.Parameters[31].Value = (object) F8BIRIMFIYAT.Value;
      else
        this.Adapter.UpdateCommand.Parameters[31].Value = (object) DBNull.Value;
      if (F8TUTAR.HasValue)
        this.Adapter.UpdateCommand.Parameters[32].Value = (object) F8TUTAR.Value;
      else
        this.Adapter.UpdateCommand.Parameters[32].Value = (object) DBNull.Value;
      this.Adapter.UpdateCommand.Parameters[33].Value = (object) Original_ID;
      if (Original_TEKLIFID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[34].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[35].Value = (object) Original_TEKLIFID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[34].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[35].Value = (object) DBNull.Value;
      }
      if (Original_ARACID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[36].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[37].Value = (object) Original_ARACID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[36].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[37].Value = (object) DBNull.Value;
      }
      if (Original_MALZEMEID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[38].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[39].Value = (object) Original_MALZEMEID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[38].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[39].Value = (object) DBNull.Value;
      }
      if (Original_MALZACIKLAMA == null)
      {
        this.Adapter.UpdateCommand.Parameters[40].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[41].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[40].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[41].Value = (object) Original_MALZACIKLAMA;
      }
      if (Original_BIRIMID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[42].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[43].Value = (object) Original_BIRIMID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[42].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[43].Value = (object) DBNull.Value;
      }
      if (Original_MIKTAR.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[44].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[45].Value = (object) Original_MIKTAR.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[44].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[45].Value = (object) DBNull.Value;
      }
      if (Original_MARKA.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[46].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[47].Value = (object) Original_MARKA.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[46].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[47].Value = (object) DBNull.Value;
      }
      if (Original_BIRIMFIYAT.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[48].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[49].Value = (object) Original_BIRIMFIYAT.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[48].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[49].Value = (object) DBNull.Value;
      }
      if (Original_TUTAR.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[50].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[51].Value = (object) Original_TUTAR.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[50].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[51].Value = (object) DBNull.Value;
      }
      if (Original_FIRMA1ID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[52].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[53].Value = (object) Original_FIRMA1ID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[52].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[53].Value = (object) DBNull.Value;
      }
      if (Original_F1BIRIMFIYAT.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[54].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[55].Value = (object) Original_F1BIRIMFIYAT.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[54].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[55].Value = (object) DBNull.Value;
      }
      if (Original_F1TUTAR.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[56].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[57].Value = (object) Original_F1TUTAR.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[56].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[57].Value = (object) DBNull.Value;
      }
      if (Original_FIRMA2ID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[58].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[59].Value = (object) Original_FIRMA2ID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[58].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[59].Value = (object) DBNull.Value;
      }
      if (Original_F2BIRIMFIYAT.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[60].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[61].Value = (object) Original_F2BIRIMFIYAT.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[60].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[61].Value = (object) DBNull.Value;
      }
      if (Original_F2TUTAR.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[62].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[63].Value = (object) Original_F2TUTAR.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[62].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[63].Value = (object) DBNull.Value;
      }
      if (Original_FIRMA3ID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[64].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[65].Value = (object) Original_FIRMA3ID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[64].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[65].Value = (object) DBNull.Value;
      }
      if (Original_F3BIRIMFIYAT.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[66].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[67].Value = (object) Original_F3BIRIMFIYAT.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[66].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[67].Value = (object) DBNull.Value;
      }
      if (Original_F3TUTAR.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[68].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[69].Value = (object) Original_F3TUTAR.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[68].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[69].Value = (object) DBNull.Value;
      }
      if (Original_FIRMA4ID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[70].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[71].Value = (object) Original_FIRMA4ID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[70].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[71].Value = (object) DBNull.Value;
      }
      if (Original_F4BIRIMFIYAT.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[72].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[73].Value = (object) Original_F4BIRIMFIYAT.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[72].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[73].Value = (object) DBNull.Value;
      }
      if (Original_F4TUTAR.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[74].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[75].Value = (object) Original_F4TUTAR.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[74].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[75].Value = (object) DBNull.Value;
      }
      if (Original_FIRMA5ID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[76].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[77].Value = (object) Original_FIRMA5ID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[76].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[77].Value = (object) DBNull.Value;
      }
      if (Original_F5BIRIMFIYAT.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[78].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[79].Value = (object) Original_F5BIRIMFIYAT.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[78].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[79].Value = (object) DBNull.Value;
      }
      if (Original_F5TUTAR.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[80].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[81].Value = (object) Original_F5TUTAR.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[80].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[81].Value = (object) DBNull.Value;
      }
      if (Original_FIRMA6ID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[82].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[83].Value = (object) Original_FIRMA6ID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[82].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[83].Value = (object) DBNull.Value;
      }
      if (Original_F6BIRIMFIYAT.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[84].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[85].Value = (object) Original_F6BIRIMFIYAT.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[84].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[85].Value = (object) DBNull.Value;
      }
      if (Original_F6TUTAR.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[86].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[87].Value = (object) Original_F6TUTAR.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[86].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[87].Value = (object) DBNull.Value;
      }
      if (Original_FIRMA7ID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[88].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[89].Value = (object) Original_FIRMA7ID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[88].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[89].Value = (object) DBNull.Value;
      }
      if (Original_F7BIRIMFIYAT.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[90].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[91].Value = (object) Original_F7BIRIMFIYAT.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[90].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[91].Value = (object) DBNull.Value;
      }
      if (Original_F7TUTAR.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[92].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[93].Value = (object) Original_F7TUTAR.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[92].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[93].Value = (object) DBNull.Value;
      }
      if (Original_FIRMA8ID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[94].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[95].Value = (object) Original_FIRMA8ID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[94].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[95].Value = (object) DBNull.Value;
      }
      if (Original_F8BIRIMFIYAT.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[96].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[97].Value = (object) Original_F8BIRIMFIYAT.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[96].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[97].Value = (object) DBNull.Value;
      }
      if (Original_F8TUTAR.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[98].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[99].Value = (object) Original_F8TUTAR.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[98].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[99].Value = (object) DBNull.Value;
      }
      this.Adapter.UpdateCommand.Parameters[100].Value = (object) ID;
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
      int? TEKLIFID,
      int? ARACID,
      int? MALZEMEID,
      string MALZACIKLAMA,
      int? BIRIMID,
      Decimal? MIKTAR,
      Decimal? MARKA,
      Decimal? BIRIMFIYAT,
      Decimal? TUTAR,
      int? FIRMA1ID,
      Decimal? F1BIRIMFIYAT,
      Decimal? F1TUTAR,
      int? FIRMA2ID,
      Decimal? F2BIRIMFIYAT,
      Decimal? F2TUTAR,
      int? FIRMA3ID,
      Decimal? F3BIRIMFIYAT,
      Decimal? F3TUTAR,
      int? FIRMA4ID,
      Decimal? F4BIRIMFIYAT,
      Decimal? F4TUTAR,
      int? FIRMA5ID,
      Decimal? F5BIRIMFIYAT,
      Decimal? F5TUTAR,
      int? FIRMA6ID,
      Decimal? F6BIRIMFIYAT,
      Decimal? F6TUTAR,
      int? FIRMA7ID,
      Decimal? F7BIRIMFIYAT,
      Decimal? F7TUTAR,
      int? FIRMA8ID,
      Decimal? F8BIRIMFIYAT,
      Decimal? F8TUTAR,
      int Original_ID,
      int? Original_TEKLIFID,
      int? Original_ARACID,
      int? Original_MALZEMEID,
      string Original_MALZACIKLAMA,
      int? Original_BIRIMID,
      Decimal? Original_MIKTAR,
      Decimal? Original_MARKA,
      Decimal? Original_BIRIMFIYAT,
      Decimal? Original_TUTAR,
      int? Original_FIRMA1ID,
      Decimal? Original_F1BIRIMFIYAT,
      Decimal? Original_F1TUTAR,
      int? Original_FIRMA2ID,
      Decimal? Original_F2BIRIMFIYAT,
      Decimal? Original_F2TUTAR,
      int? Original_FIRMA3ID,
      Decimal? Original_F3BIRIMFIYAT,
      Decimal? Original_F3TUTAR,
      int? Original_FIRMA4ID,
      Decimal? Original_F4BIRIMFIYAT,
      Decimal? Original_F4TUTAR,
      int? Original_FIRMA5ID,
      Decimal? Original_F5BIRIMFIYAT,
      Decimal? Original_F5TUTAR,
      int? Original_FIRMA6ID,
      Decimal? Original_F6BIRIMFIYAT,
      Decimal? Original_F6TUTAR,
      int? Original_FIRMA7ID,
      Decimal? Original_F7BIRIMFIYAT,
      Decimal? Original_F7TUTAR,
      int? Original_FIRMA8ID,
      Decimal? Original_F8BIRIMFIYAT,
      Decimal? Original_F8TUTAR)
    {
      return this.Update(TEKLIFID, ARACID, MALZEMEID, MALZACIKLAMA, BIRIMID, MIKTAR, MARKA, BIRIMFIYAT, TUTAR, FIRMA1ID, F1BIRIMFIYAT, F1TUTAR, FIRMA2ID, F2BIRIMFIYAT, F2TUTAR, FIRMA3ID, F3BIRIMFIYAT, F3TUTAR, FIRMA4ID, F4BIRIMFIYAT, F4TUTAR, FIRMA5ID, F5BIRIMFIYAT, F5TUTAR, FIRMA6ID, F6BIRIMFIYAT, F6TUTAR, FIRMA7ID, F7BIRIMFIYAT, F7TUTAR, FIRMA8ID, F8BIRIMFIYAT, F8TUTAR, Original_ID, Original_TEKLIFID, Original_ARACID, Original_MALZEMEID, Original_MALZACIKLAMA, Original_BIRIMID, Original_MIKTAR, Original_MARKA, Original_BIRIMFIYAT, Original_TUTAR, Original_FIRMA1ID, Original_F1BIRIMFIYAT, Original_F1TUTAR, Original_FIRMA2ID, Original_F2BIRIMFIYAT, Original_F2TUTAR, Original_FIRMA3ID, Original_F3BIRIMFIYAT, Original_F3TUTAR, Original_FIRMA4ID, Original_F4BIRIMFIYAT, Original_F4TUTAR, Original_FIRMA5ID, Original_F5BIRIMFIYAT, Original_F5TUTAR, Original_FIRMA6ID, Original_F6BIRIMFIYAT, Original_F6TUTAR, Original_FIRMA7ID, Original_F7BIRIMFIYAT, Original_F7TUTAR, Original_FIRMA8ID, Original_F8BIRIMFIYAT, Original_F8TUTAR, Original_ID);
    }
  }
}
