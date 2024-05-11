// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Model.AracMuayeneTakipTableAdapters.TBLARACLARTableAdapter
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

namespace Makina_Ikmal.Model.AracMuayeneTakipTableAdapters
{
  [DesignerCategory("code")]
  [ToolboxItem(true)]
  [DataObject(true)]
  [Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [HelpKeyword("vs.data.TableAdapter")]
  public class TBLARACLARTableAdapter : Component
  {
    private SqlDataAdapter _adapter;
    private SqlConnection _connection;
    private SqlTransaction _transaction;
    private SqlCommand[] _commandCollection;
    private bool _clearBeforeFill;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public TBLARACLARTableAdapter() => this.ClearBeforeFill = true;

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
        DataSetTable = "TBLARACLAR",
        ColumnMappings = {
          {
            "Expr1",
            "Expr1"
          },
          {
            "Plaka",
            "Plaka"
          },
          {
            "Açıklama",
            "Açıklama"
          },
          {
            "Tahsis Plaka",
            "Tahsis Plaka"
          },
          {
            "Marka",
            "Marka"
          },
          {
            "Model",
            "Model"
          },
          {
            "Rengi",
            "Rengi"
          },
          {
            "Birim",
            "Birim"
          },
          {
            "Müdürlük",
            "Müdürlük"
          },
          {
            "Muayene Tarihi",
            "Muayene Tarihi1"
          },
          {
            "ARACDURUMID",
            "ARACDURUMID"
          },
          {
            "ARACTIPIID",
            "ARACTIPIID"
          },
          {
            "Kalan Gun",
            "Kalan Gun"
          },
          {
            "ARACGRUBUID",
            "ARACGRUBUID"
          },
          {
            "Egzoz Tarihi",
            "Egzoz Tarihi"
          },
          {
            "Egzoz Kalan Gun",
            "Egzoz Kalan Gun"
          },
          {
            "ID",
            "ID"
          }
        }
      });
      this._adapter.DeleteCommand = new SqlCommand();
      this._adapter.DeleteCommand.Connection = this.Connection;
      this._adapter.DeleteCommand.CommandText = "DELETE FROM [TBLARACLAR] WHERE (([ID] = @Original_ID) AND ((@IsNull_Egzoz_Tarihi = 1 AND [EGZOZKONTROL] IS NULL) OR ([EGZOZKONTROL] = @Original_Egzoz_Tarihi)) AND ((@IsNull_Muayene_Tarihi = 1 AND [MUAYENEGECSUR] IS NULL) OR ([MUAYENEGECSUR] = @Original_Muayene_Tarihi)) AND ((@IsNull_Plaka = 1 AND [Plaka] IS NULL) OR ([Plaka] = @Original_Plaka)) AND ((@IsNull_Açıklama = 1 AND [ARACACIKLAMA] IS NULL) OR ([ARACACIKLAMA] = @Original_Açıklama)) AND ((@IsNull_Tahsis_Plaka = 1 AND [TAHSPLAKA] IS NULL) OR ([TAHSPLAKA] = @Original_Tahsis_Plaka)) AND ((@IsNull_Marka = 1 AND [MARKAID] IS NULL) OR ([MARKAID] = @Original_Marka)) AND ((@IsNull_Model = 1 AND [Model] IS NULL) OR ([Model] = @Original_Model)) AND ((@IsNull_Rengi = 1 AND [RENGI] IS NULL) OR ([RENGI] = @Original_Rengi)) AND ((@IsNull_Birim = 1 AND [BELDBIRIMID] IS NULL) OR ([BELDBIRIMID] = @Original_Birim)) AND ((@IsNull_Müdürlük = 1 AND [BELDMUDURLUKID] IS NULL) OR ([BELDMUDURLUKID] = @Original_Müdürlük)) AND ((@IsNull_ARACDURUMID = 1 AND [ARACDURUMID] IS NULL) OR ([ARACDURUMID] = @Original_ARACDURUMID)) AND ((@IsNull_ARACTIPIID = 1 AND [ARACTIPIID] IS NULL) OR ([ARACTIPIID] = @Original_ARACTIPIID)) AND ((@IsNull_ARACGRUBUID = 1 AND [ARACGRUBUID] IS NULL) OR ([ARACGRUBUID] = @Original_ARACGRUBUID)))";
      this._adapter.DeleteCommand.CommandType = CommandType.Text;
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Egzoz_Tarihi", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Egzoz Tarihi", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Egzoz_Tarihi", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Egzoz Tarihi", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Muayene_Tarihi", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Muayene Tarihi", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Muayene_Tarihi", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Muayene Tarihi", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Plaka", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Plaka", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Plaka", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Plaka", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Açıklama", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Açıklama", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Açıklama", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Açıklama", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Tahsis_Plaka", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Tahsis Plaka", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Tahsis_Plaka", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Tahsis Plaka", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Marka", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Marka", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Marka", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Marka", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Model", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Model", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Model", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Model", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Rengi", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Rengi", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Rengi", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Rengi", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Birim", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Birim", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Birim", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Birim", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Müdürlük", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Müdürlük", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Müdürlük", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Müdürlük", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ARACDURUMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACDURUMID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ARACDURUMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACDURUMID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ARACTIPIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACTIPIID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ARACTIPIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACTIPIID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ARACGRUBUID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACGRUBUID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ARACGRUBUID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACGRUBUID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.InsertCommand = new SqlCommand();
      this._adapter.InsertCommand.Connection = this.Connection;
      this._adapter.InsertCommand.CommandText = "INSERT INTO [TBLARACLAR] ([EGZOZKONTROL], [MUAYENEGECSUR], [Plaka], [ARACACIKLAMA], [TAHSPLAKA], [MARKAID], [Model], [RENGI], [BELDBIRIMID], [BELDMUDURLUKID], [ARACDURUMID], [ARACTIPIID], [ARACGRUBUID]) VALUES (@Egzoz_Tarihi, @Muayene_Tarihi, @Plaka, @Açıklama, @Tahsis_Plaka, @Marka, @Model, @Rengi, @Birim, @Müdürlük, @ARACDURUMID, @ARACTIPIID, @ARACGRUBUID);\r\nSELECT ID, CASE WHEN IsDate(MUAYENEGECSUR) = 1 THEN CONVERT (DateTime , MUAYENEGECSUR , 102) ELSE NULL END AS Expr1, DATEDIFF(day, GETDATE(), MUAYENEGECSUR) AS [Kalan Gun], EGZOZKONTROL AS [Egzoz Tarihi], DATEDIFF(day, GETDATE(), EGZOZKONTROL) AS [Egzoz Kalan Gun], MUAYENEGECSUR AS [Muayene Tarihi], PLAKA AS Plaka, ARACACIKLAMA AS Açıklama, TAHSPLAKA AS [Tahsis Plaka], MARKAID AS Marka, MODEL AS Model, RENGI AS Rengi, BELDBIRIMID AS Birim, BELDMUDURLUKID AS Müdürlük, ARACDURUMID, ARACTIPIID, ARACGRUBUID FROM TBLARACLAR WHERE (ID = SCOPE_IDENTITY()) ORDER BY Expr1";
      this._adapter.InsertCommand.CommandType = CommandType.Text;
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Egzoz_Tarihi", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Egzoz Tarihi", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Muayene_Tarihi", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Muayene Tarihi", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Plaka", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Plaka", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Açıklama", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Açıklama", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Tahsis_Plaka", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Tahsis Plaka", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Marka", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Marka", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Model", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Model", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Rengi", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Rengi", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Birim", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Birim", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Müdürlük", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Müdürlük", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ARACDURUMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACDURUMID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ARACTIPIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACTIPIID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ARACGRUBUID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACGRUBUID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand = new SqlCommand();
      this._adapter.UpdateCommand.Connection = this.Connection;
      this._adapter.UpdateCommand.CommandText = "UPDATE [TBLARACLAR] SET [EGZOZKONTROL] = @Egzoz_Tarihi, [MUAYENEGECSUR] = @Muayene_Tarihi, [Plaka] = @Plaka, [ARACACIKLAMA] = @Açıklama, [TAHSPLAKA] = @Tahsis_Plaka, [MARKAID] = @Marka, [Model] = @Model, [RENGI] = @Rengi, [BELDBIRIMID] = @Birim, [BELDMUDURLUKID] = @Müdürlük, [ARACDURUMID] = @ARACDURUMID, [ARACTIPIID] = @ARACTIPIID, [ARACGRUBUID] = @ARACGRUBUID WHERE (([ID] = @Original_ID) AND ((@IsNull_Egzoz_Tarihi = 1 AND [EGZOZKONTROL] IS NULL) OR ([EGZOZKONTROL] = @Original_Egzoz_Tarihi)) AND ((@IsNull_Muayene_Tarihi = 1 AND [MUAYENEGECSUR] IS NULL) OR ([MUAYENEGECSUR] = @Original_Muayene_Tarihi)) AND ((@IsNull_Plaka = 1 AND [Plaka] IS NULL) OR ([Plaka] = @Original_Plaka)) AND ((@IsNull_Açıklama = 1 AND [ARACACIKLAMA] IS NULL) OR ([ARACACIKLAMA] = @Original_Açıklama)) AND ((@IsNull_Tahsis_Plaka = 1 AND [TAHSPLAKA] IS NULL) OR ([TAHSPLAKA] = @Original_Tahsis_Plaka)) AND ((@IsNull_Marka = 1 AND [MARKAID] IS NULL) OR ([MARKAID] = @Original_Marka)) AND ((@IsNull_Model = 1 AND [Model] IS NULL) OR ([Model] = @Original_Model)) AND ((@IsNull_Rengi = 1 AND [RENGI] IS NULL) OR ([RENGI] = @Original_Rengi)) AND ((@IsNull_Birim = 1 AND [BELDBIRIMID] IS NULL) OR ([BELDBIRIMID] = @Original_Birim)) AND ((@IsNull_Müdürlük = 1 AND [BELDMUDURLUKID] IS NULL) OR ([BELDMUDURLUKID] = @Original_Müdürlük)) AND ((@IsNull_ARACDURUMID = 1 AND [ARACDURUMID] IS NULL) OR ([ARACDURUMID] = @Original_ARACDURUMID)) AND ((@IsNull_ARACTIPIID = 1 AND [ARACTIPIID] IS NULL) OR ([ARACTIPIID] = @Original_ARACTIPIID)) AND ((@IsNull_ARACGRUBUID = 1 AND [ARACGRUBUID] IS NULL) OR ([ARACGRUBUID] = @Original_ARACGRUBUID)));\r\nSELECT ID, CASE WHEN IsDate(MUAYENEGECSUR) = 1 THEN CONVERT (DateTime , MUAYENEGECSUR , 102) ELSE NULL END AS Expr1, DATEDIFF(day, GETDATE(), MUAYENEGECSUR) AS [Kalan Gun], EGZOZKONTROL AS [Egzoz Tarihi], DATEDIFF(day, GETDATE(), EGZOZKONTROL) AS [Egzoz Kalan Gun], MUAYENEGECSUR AS [Muayene Tarihi], PLAKA AS Plaka, ARACACIKLAMA AS Açıklama, TAHSPLAKA AS [Tahsis Plaka], MARKAID AS Marka, MODEL AS Model, RENGI AS Rengi, BELDBIRIMID AS Birim, BELDMUDURLUKID AS Müdürlük, ARACDURUMID, ARACTIPIID, ARACGRUBUID FROM TBLARACLAR WHERE (ID = @ID) ORDER BY Expr1";
      this._adapter.UpdateCommand.CommandType = CommandType.Text;
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Egzoz_Tarihi", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Egzoz Tarihi", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Muayene_Tarihi", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Muayene Tarihi", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Plaka", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Plaka", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Açıklama", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Açıklama", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Tahsis_Plaka", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Tahsis Plaka", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Marka", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Marka", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Model", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Model", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Rengi", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Rengi", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Birim", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Birim", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Müdürlük", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Müdürlük", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ARACDURUMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACDURUMID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ARACTIPIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACTIPIID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ARACGRUBUID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACGRUBUID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Egzoz_Tarihi", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Egzoz Tarihi", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Egzoz_Tarihi", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Egzoz Tarihi", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Muayene_Tarihi", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Muayene Tarihi", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Muayene_Tarihi", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Muayene Tarihi", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Plaka", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Plaka", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Plaka", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Plaka", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Açıklama", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Açıklama", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Açıklama", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Açıklama", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Tahsis_Plaka", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Tahsis Plaka", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Tahsis_Plaka", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Tahsis Plaka", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Marka", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Marka", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Marka", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Marka", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Model", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Model", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Model", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Model", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Rengi", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Rengi", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Rengi", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Rengi", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Birim", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Birim", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Birim", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Birim", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Müdürlük", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Müdürlük", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Müdürlük", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Müdürlük", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ARACDURUMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACDURUMID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ARACDURUMID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACDURUMID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ARACTIPIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACTIPIID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ARACTIPIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACTIPIID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ARACGRUBUID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACGRUBUID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ARACGRUBUID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACGRUBUID", DataRowVersion.Original, false, (object) null, "", "", ""));
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
      this._commandCollection[0].CommandText = "SELECT        ID, CASE WHEN IsDate(MUAYENEGECSUR) = 1 THEN CONVERT(DateTime, MUAYENEGECSUR, 102) ELSE NULL END AS Expr1, DATEDIFF(day, GETDATE(), MUAYENEGECSUR) AS [Kalan Gun], \r\n                         EGZOZKONTROL AS [Egzoz Tarihi], DATEDIFF(day, GETDATE(), EGZOZKONTROL) AS [Egzoz Kalan Gun], MUAYENEGECSUR AS [Muayene Tarihi], PLAKA AS Plaka, ARACACIKLAMA AS Açıklama, TAHSPLAKA AS [Tahsis Plaka], \r\n                         MARKAID AS Marka, MODEL AS Model, RENGI AS Rengi, BELDBIRIMID AS Birim, BELDMUDURLUKID AS Müdürlük, ARACDURUMID, ARACTIPIID, ARACGRUBUID\r\nFROM            TBLARACLAR\r\nWHERE        (ARACDURUMID = 1 OR\r\n                         ARACDURUMID = 3) AND (ARACTIPIID = 1) AND (ARACGRUBUID <> 110)\r\nORDER BY Expr1";
      this._commandCollection[0].CommandType = CommandType.Text;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    public virtual int Fill(AracMuayeneTakip.TBLARACLARDataTable dataTable)
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
    public virtual AracMuayeneTakip.TBLARACLARDataTable GetData()
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      AracMuayeneTakip.TBLARACLARDataTable data = new AracMuayeneTakip.TBLARACLARDataTable();
      this.Adapter.Fill((DataTable) data);
      return data;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(AracMuayeneTakip.TBLARACLARDataTable dataTable) => this.Adapter.Update((DataTable) dataTable);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(AracMuayeneTakip dataSet) => this.Adapter.Update((DataSet) dataSet, "TBLARACLAR");

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
      DateTime Original_Egzoz_Tarihi,
      DateTime Original_Muayene_Tarihi,
      string Original_Plaka,
      string Original_Açıklama,
      string Original_Tahsis_Plaka,
      int Original_Marka,
      string Original_Model,
      string Original_Rengi,
      int Original_Birim,
      int Original_Müdürlük,
      int? Original_ARACDURUMID,
      int? Original_ARACTIPIID,
      int? Original_ARACGRUBUID)
    {
      this.Adapter.DeleteCommand.Parameters[0].Value = (object) Original_ID;
      this.Adapter.DeleteCommand.Parameters[1].Value = (object) 0;
      this.Adapter.DeleteCommand.Parameters[2].Value = (object) Original_Egzoz_Tarihi;
      this.Adapter.DeleteCommand.Parameters[3].Value = (object) 0;
      this.Adapter.DeleteCommand.Parameters[4].Value = (object) Original_Muayene_Tarihi;
      if (Original_Plaka == null)
        throw new ArgumentNullException(nameof (Original_Plaka));
      this.Adapter.DeleteCommand.Parameters[5].Value = (object) 0;
      this.Adapter.DeleteCommand.Parameters[6].Value = (object) Original_Plaka;
      if (Original_Açıklama == null)
        throw new ArgumentNullException(nameof (Original_Açıklama));
      this.Adapter.DeleteCommand.Parameters[7].Value = (object) 0;
      this.Adapter.DeleteCommand.Parameters[8].Value = (object) Original_Açıklama;
      if (Original_Tahsis_Plaka == null)
        throw new ArgumentNullException(nameof (Original_Tahsis_Plaka));
      this.Adapter.DeleteCommand.Parameters[9].Value = (object) 0;
      this.Adapter.DeleteCommand.Parameters[10].Value = (object) Original_Tahsis_Plaka;
      this.Adapter.DeleteCommand.Parameters[11].Value = (object) 0;
      this.Adapter.DeleteCommand.Parameters[12].Value = (object) Original_Marka;
      if (Original_Model == null)
        throw new ArgumentNullException(nameof (Original_Model));
      this.Adapter.DeleteCommand.Parameters[13].Value = (object) 0;
      this.Adapter.DeleteCommand.Parameters[14].Value = (object) Original_Model;
      if (Original_Rengi == null)
        throw new ArgumentNullException(nameof (Original_Rengi));
      this.Adapter.DeleteCommand.Parameters[15].Value = (object) 0;
      this.Adapter.DeleteCommand.Parameters[16].Value = (object) Original_Rengi;
      this.Adapter.DeleteCommand.Parameters[17].Value = (object) 0;
      this.Adapter.DeleteCommand.Parameters[18].Value = (object) Original_Birim;
      this.Adapter.DeleteCommand.Parameters[19].Value = (object) 0;
      this.Adapter.DeleteCommand.Parameters[20].Value = (object) Original_Müdürlük;
      if (Original_ARACDURUMID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[21].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[22].Value = (object) Original_ARACDURUMID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[21].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[22].Value = (object) DBNull.Value;
      }
      if (Original_ARACTIPIID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[23].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[24].Value = (object) Original_ARACTIPIID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[23].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[24].Value = (object) DBNull.Value;
      }
      if (Original_ARACGRUBUID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[25].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[26].Value = (object) Original_ARACGRUBUID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[25].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[26].Value = (object) DBNull.Value;
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
      DateTime Egzoz_Tarihi,
      DateTime Muayene_Tarihi,
      string Plaka,
      string Açıklama,
      string Tahsis_Plaka,
      int Marka,
      string Model,
      string Rengi,
      int Birim,
      int Müdürlük,
      int? ARACDURUMID,
      int? ARACTIPIID,
      int? ARACGRUBUID)
    {
      this.Adapter.InsertCommand.Parameters[0].Value = (object) Egzoz_Tarihi;
      this.Adapter.InsertCommand.Parameters[1].Value = (object) Muayene_Tarihi;
      this.Adapter.InsertCommand.Parameters[2].Value = Plaka != null ? (object) Plaka : throw new ArgumentNullException(nameof (Plaka));
      this.Adapter.InsertCommand.Parameters[3].Value = Açıklama != null ? (object) Açıklama : throw new ArgumentNullException(nameof (Açıklama));
      this.Adapter.InsertCommand.Parameters[4].Value = Tahsis_Plaka != null ? (object) Tahsis_Plaka : throw new ArgumentNullException(nameof (Tahsis_Plaka));
      this.Adapter.InsertCommand.Parameters[5].Value = (object) Marka;
      this.Adapter.InsertCommand.Parameters[6].Value = Model != null ? (object) Model : throw new ArgumentNullException(nameof (Model));
      this.Adapter.InsertCommand.Parameters[7].Value = Rengi != null ? (object) Rengi : throw new ArgumentNullException(nameof (Rengi));
      this.Adapter.InsertCommand.Parameters[8].Value = (object) Birim;
      this.Adapter.InsertCommand.Parameters[9].Value = (object) Müdürlük;
      if (ARACDURUMID.HasValue)
        this.Adapter.InsertCommand.Parameters[10].Value = (object) ARACDURUMID.Value;
      else
        this.Adapter.InsertCommand.Parameters[10].Value = (object) DBNull.Value;
      if (ARACTIPIID.HasValue)
        this.Adapter.InsertCommand.Parameters[11].Value = (object) ARACTIPIID.Value;
      else
        this.Adapter.InsertCommand.Parameters[11].Value = (object) DBNull.Value;
      if (ARACGRUBUID.HasValue)
        this.Adapter.InsertCommand.Parameters[12].Value = (object) ARACGRUBUID.Value;
      else
        this.Adapter.InsertCommand.Parameters[12].Value = (object) DBNull.Value;
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
      DateTime Egzoz_Tarihi,
      DateTime Muayene_Tarihi,
      string Plaka,
      string Açıklama,
      string Tahsis_Plaka,
      int Marka,
      string Model,
      string Rengi,
      int Birim,
      int Müdürlük,
      int? ARACDURUMID,
      int? ARACTIPIID,
      int? ARACGRUBUID,
      int Original_ID,
      DateTime Original_Egzoz_Tarihi,
      DateTime Original_Muayene_Tarihi,
      string Original_Plaka,
      string Original_Açıklama,
      string Original_Tahsis_Plaka,
      int Original_Marka,
      string Original_Model,
      string Original_Rengi,
      int Original_Birim,
      int Original_Müdürlük,
      int? Original_ARACDURUMID,
      int? Original_ARACTIPIID,
      int? Original_ARACGRUBUID,
      int ID)
    {
      this.Adapter.UpdateCommand.Parameters[0].Value = (object) Egzoz_Tarihi;
      this.Adapter.UpdateCommand.Parameters[1].Value = (object) Muayene_Tarihi;
      this.Adapter.UpdateCommand.Parameters[2].Value = Plaka != null ? (object) Plaka : throw new ArgumentNullException(nameof (Plaka));
      this.Adapter.UpdateCommand.Parameters[3].Value = Açıklama != null ? (object) Açıklama : throw new ArgumentNullException(nameof (Açıklama));
      this.Adapter.UpdateCommand.Parameters[4].Value = Tahsis_Plaka != null ? (object) Tahsis_Plaka : throw new ArgumentNullException(nameof (Tahsis_Plaka));
      this.Adapter.UpdateCommand.Parameters[5].Value = (object) Marka;
      this.Adapter.UpdateCommand.Parameters[6].Value = Model != null ? (object) Model : throw new ArgumentNullException(nameof (Model));
      this.Adapter.UpdateCommand.Parameters[7].Value = Rengi != null ? (object) Rengi : throw new ArgumentNullException(nameof (Rengi));
      this.Adapter.UpdateCommand.Parameters[8].Value = (object) Birim;
      this.Adapter.UpdateCommand.Parameters[9].Value = (object) Müdürlük;
      if (ARACDURUMID.HasValue)
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) ARACDURUMID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) DBNull.Value;
      if (ARACTIPIID.HasValue)
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) ARACTIPIID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) DBNull.Value;
      if (ARACGRUBUID.HasValue)
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) ARACGRUBUID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) DBNull.Value;
      this.Adapter.UpdateCommand.Parameters[13].Value = (object) Original_ID;
      this.Adapter.UpdateCommand.Parameters[14].Value = (object) 0;
      this.Adapter.UpdateCommand.Parameters[15].Value = (object) Original_Egzoz_Tarihi;
      this.Adapter.UpdateCommand.Parameters[16].Value = (object) 0;
      this.Adapter.UpdateCommand.Parameters[17].Value = (object) Original_Muayene_Tarihi;
      if (Original_Plaka == null)
        throw new ArgumentNullException(nameof (Original_Plaka));
      this.Adapter.UpdateCommand.Parameters[18].Value = (object) 0;
      this.Adapter.UpdateCommand.Parameters[19].Value = (object) Original_Plaka;
      if (Original_Açıklama == null)
        throw new ArgumentNullException(nameof (Original_Açıklama));
      this.Adapter.UpdateCommand.Parameters[20].Value = (object) 0;
      this.Adapter.UpdateCommand.Parameters[21].Value = (object) Original_Açıklama;
      if (Original_Tahsis_Plaka == null)
        throw new ArgumentNullException(nameof (Original_Tahsis_Plaka));
      this.Adapter.UpdateCommand.Parameters[22].Value = (object) 0;
      this.Adapter.UpdateCommand.Parameters[23].Value = (object) Original_Tahsis_Plaka;
      this.Adapter.UpdateCommand.Parameters[24].Value = (object) 0;
      this.Adapter.UpdateCommand.Parameters[25].Value = (object) Original_Marka;
      if (Original_Model == null)
        throw new ArgumentNullException(nameof (Original_Model));
      this.Adapter.UpdateCommand.Parameters[26].Value = (object) 0;
      this.Adapter.UpdateCommand.Parameters[27].Value = (object) Original_Model;
      if (Original_Rengi == null)
        throw new ArgumentNullException(nameof (Original_Rengi));
      this.Adapter.UpdateCommand.Parameters[28].Value = (object) 0;
      this.Adapter.UpdateCommand.Parameters[29].Value = (object) Original_Rengi;
      this.Adapter.UpdateCommand.Parameters[30].Value = (object) 0;
      this.Adapter.UpdateCommand.Parameters[31].Value = (object) Original_Birim;
      this.Adapter.UpdateCommand.Parameters[32].Value = (object) 0;
      this.Adapter.UpdateCommand.Parameters[33].Value = (object) Original_Müdürlük;
      if (Original_ARACDURUMID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[34].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[35].Value = (object) Original_ARACDURUMID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[34].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[35].Value = (object) DBNull.Value;
      }
      if (Original_ARACTIPIID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[36].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[37].Value = (object) Original_ARACTIPIID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[36].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[37].Value = (object) DBNull.Value;
      }
      if (Original_ARACGRUBUID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[38].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[39].Value = (object) Original_ARACGRUBUID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[38].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[39].Value = (object) DBNull.Value;
      }
      this.Adapter.UpdateCommand.Parameters[40].Value = (object) ID;
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
      DateTime Egzoz_Tarihi,
      DateTime Muayene_Tarihi,
      string Plaka,
      string Açıklama,
      string Tahsis_Plaka,
      int Marka,
      string Model,
      string Rengi,
      int Birim,
      int Müdürlük,
      int? ARACDURUMID,
      int? ARACTIPIID,
      int? ARACGRUBUID,
      int Original_ID,
      DateTime Original_Egzoz_Tarihi,
      DateTime Original_Muayene_Tarihi,
      string Original_Plaka,
      string Original_Açıklama,
      string Original_Tahsis_Plaka,
      int Original_Marka,
      string Original_Model,
      string Original_Rengi,
      int Original_Birim,
      int Original_Müdürlük,
      int? Original_ARACDURUMID,
      int? Original_ARACTIPIID,
      int? Original_ARACGRUBUID)
    {
      return this.Update(Egzoz_Tarihi, Muayene_Tarihi, Plaka, Açıklama, Tahsis_Plaka, Marka, Model, Rengi, Birim, Müdürlük, ARACDURUMID, ARACTIPIID, ARACGRUBUID, Original_ID, Original_Egzoz_Tarihi, Original_Muayene_Tarihi, Original_Plaka, Original_Açıklama, Original_Tahsis_Plaka, Original_Marka, Original_Model, Original_Rengi, Original_Birim, Original_Müdürlük, Original_ARACDURUMID, Original_ARACTIPIID, Original_ARACGRUBUID, Original_ID);
    }
  }
}
