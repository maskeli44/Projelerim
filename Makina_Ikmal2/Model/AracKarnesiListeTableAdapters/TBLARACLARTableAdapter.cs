// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Model.AracKarnesiListeTableAdapters.TBLARACLARTableAdapter
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

namespace Makina_Ikmal.Model.AracKarnesiListeTableAdapters
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
            "Birim Adı",
            "Birim Adı"
          },
          {
            "PLAKA",
            "PLAKA"
          },
          {
            "ARACACIKLAMA",
            "ARACACIKLAMA"
          },
          {
            "Ana Grup",
            "Ana Grup"
          },
          {
            "Alt Grup",
            "Alt Grup"
          },
          {
            "B. Sayısı",
            "B_ Sayısı"
          },
          {
            "ID",
            "ID"
          },
          {
            "RESIMON",
            "RESIMON"
          },
          {
            "RESİMARKA",
            "RESİMARKA"
          }
        }
      });
      this._adapter.DeleteCommand = new SqlCommand();
      this._adapter.DeleteCommand.Connection = this.Connection;
      this._adapter.DeleteCommand.CommandText = "DELETE FROM [TBLARACLAR] WHERE (((@IsNull_Birim_Adı = 1 AND [BELDBIRIMID] IS NULL) OR ([BELDBIRIMID] = @Original_Birim_Adı)) AND ((@IsNull_PLAKA = 1 AND [PLAKA] IS NULL) OR ([PLAKA] = @Original_PLAKA)) AND ((@IsNull_ARACACIKLAMA = 1 AND [ARACACIKLAMA] IS NULL) OR ([ARACACIKLAMA] = @Original_ARACACIKLAMA)) AND ((@IsNull_Ana_Grup = 1 AND [ARACGRUBUID] IS NULL) OR ([ARACGRUBUID] = @Original_Ana_Grup)) AND ((@IsNull_Alt_Grup = 1 AND [ARACGRUBU2ID] IS NULL) OR ([ARACGRUBU2ID] = @Original_Alt_Grup)) AND ((@p3 = 1 AND [SIRANO] IS NULL) OR ([SIRANO] = @p2)) AND ([ID] = @Original_ID))";
      this._adapter.DeleteCommand.CommandType = CommandType.Text;
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Birim_Adı", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Birim Adı", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Birim_Adı", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Birim Adı", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_PLAKA", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PLAKA", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_PLAKA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PLAKA", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ARACACIKLAMA", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACACIKLAMA", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ARACACIKLAMA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACACIKLAMA", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Ana_Grup", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Ana Grup", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Ana_Grup", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Ana Grup", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Alt_Grup", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Alt Grup", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Alt_Grup", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Alt Grup", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@p3", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "B. Sayısı", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@p2", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "B. Sayısı", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.InsertCommand = new SqlCommand();
      this._adapter.InsertCommand.Connection = this.Connection;
      this._adapter.InsertCommand.CommandText = "INSERT INTO [TBLARACLAR] ([BELDBIRIMID], [PLAKA], [ARACACIKLAMA], [ARACGRUBUID], [ARACGRUBU2ID], [SIRANO], [RESIMON], [RESİMARKA]) VALUES (@Birim_Adı, @PLAKA, @ARACACIKLAMA, @Ana_Grup, @Alt_Grup, @p1, @RESIMON, @RESİMARKA);\r\nSELECT BELDBIRIMID AS [Birim Adı], PLAKA, ARACACIKLAMA, ARACGRUBUID AS [Ana Grup], ARACGRUBU2ID AS [Alt Grup], SIRANO AS [B. Sayısı], ID, RESIMON, RESİMARKA FROM TBLARACLAR WHERE (ID = SCOPE_IDENTITY())";
      this._adapter.InsertCommand.CommandType = CommandType.Text;
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Birim_Adı", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Birim Adı", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@PLAKA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PLAKA", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ARACACIKLAMA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACACIKLAMA", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Ana_Grup", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Ana Grup", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Alt_Grup", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Alt Grup", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@p1", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "B. Sayısı", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@RESIMON", SqlDbType.Image, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RESIMON", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@RESİMARKA", SqlDbType.Image, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RESİMARKA", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand = new SqlCommand();
      this._adapter.UpdateCommand.Connection = this.Connection;
      this._adapter.UpdateCommand.CommandText = "UPDATE [TBLARACLAR] SET [BELDBIRIMID] = @Birim_Adı, [PLAKA] = @PLAKA, [ARACACIKLAMA] = @ARACACIKLAMA, [ARACGRUBUID] = @Ana_Grup, [ARACGRUBU2ID] = @Alt_Grup, [SIRANO] = @p1, [RESIMON] = @RESIMON, [RESİMARKA] = @RESİMARKA WHERE (((@IsNull_Birim_Adı = 1 AND [BELDBIRIMID] IS NULL) OR ([BELDBIRIMID] = @Original_Birim_Adı)) AND ((@IsNull_PLAKA = 1 AND [PLAKA] IS NULL) OR ([PLAKA] = @Original_PLAKA)) AND ((@IsNull_ARACACIKLAMA = 1 AND [ARACACIKLAMA] IS NULL) OR ([ARACACIKLAMA] = @Original_ARACACIKLAMA)) AND ((@IsNull_Ana_Grup = 1 AND [ARACGRUBUID] IS NULL) OR ([ARACGRUBUID] = @Original_Ana_Grup)) AND ((@IsNull_Alt_Grup = 1 AND [ARACGRUBU2ID] IS NULL) OR ([ARACGRUBU2ID] = @Original_Alt_Grup)) AND ((@p3 = 1 AND [SIRANO] IS NULL) OR ([SIRANO] = @p2)) AND ([ID] = @Original_ID));\r\nSELECT BELDBIRIMID AS [Birim Adı], PLAKA, ARACACIKLAMA, ARACGRUBUID AS [Ana Grup], ARACGRUBU2ID AS [Alt Grup], SIRANO AS [B. Sayısı], ID, RESIMON, RESİMARKA FROM TBLARACLAR WHERE (ID = @ID)";
      this._adapter.UpdateCommand.CommandType = CommandType.Text;
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Birim_Adı", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Birim Adı", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@PLAKA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PLAKA", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ARACACIKLAMA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACACIKLAMA", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Ana_Grup", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Ana Grup", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Alt_Grup", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Alt Grup", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@p1", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "B. Sayısı", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@RESIMON", SqlDbType.Image, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RESIMON", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@RESİMARKA", SqlDbType.Image, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RESİMARKA", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Birim_Adı", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Birim Adı", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Birim_Adı", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Birim Adı", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_PLAKA", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PLAKA", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_PLAKA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PLAKA", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ARACACIKLAMA", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACACIKLAMA", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ARACACIKLAMA", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ARACACIKLAMA", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Ana_Grup", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Ana Grup", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Ana_Grup", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Ana Grup", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Alt_Grup", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Alt Grup", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Alt_Grup", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Alt Grup", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@p3", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "B. Sayısı", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@p2", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "B. Sayısı", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
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
      this._commandCollection[0].CommandText = "SELECT        BELDBIRIMID AS [Birim Adı], PLAKA, ARACACIKLAMA, ARACGRUBUID AS [Ana Grup], ARACGRUBU2ID AS [Alt Grup], SIRANO AS [B. Sayısı], ID, RESIMON, RESİMARKA\r\nFROM            TBLARACLAR";
      this._commandCollection[0].CommandType = CommandType.Text;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    public virtual int Fill(AracKarnesiListe.TBLARACLARDataTable dataTable)
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
    public virtual AracKarnesiListe.TBLARACLARDataTable GetData()
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      AracKarnesiListe.TBLARACLARDataTable data = new AracKarnesiListe.TBLARACLARDataTable();
      this.Adapter.Fill((DataTable) data);
      return data;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(AracKarnesiListe.TBLARACLARDataTable dataTable) => this.Adapter.Update((DataTable) dataTable);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(AracKarnesiListe dataSet) => this.Adapter.Update((DataSet) dataSet, "TBLARACLAR");

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
      int Original_Birim_Adı,
      string Original_PLAKA,
      string Original_ARACACIKLAMA,
      int Original_Ana_Grup,
      int Original_Alt_Grup,
      string p2,
      int Original_ID)
    {
      this.Adapter.DeleteCommand.Parameters[0].Value = (object) 0;
      this.Adapter.DeleteCommand.Parameters[1].Value = (object) Original_Birim_Adı;
      if (Original_PLAKA == null)
      {
        this.Adapter.DeleteCommand.Parameters[2].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[3].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[2].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[3].Value = (object) Original_PLAKA;
      }
      if (Original_ARACACIKLAMA == null)
      {
        this.Adapter.DeleteCommand.Parameters[4].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[4].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) Original_ARACACIKLAMA;
      }
      this.Adapter.DeleteCommand.Parameters[6].Value = (object) 0;
      this.Adapter.DeleteCommand.Parameters[7].Value = (object) Original_Ana_Grup;
      this.Adapter.DeleteCommand.Parameters[8].Value = (object) 0;
      this.Adapter.DeleteCommand.Parameters[9].Value = (object) Original_Alt_Grup;
      if (p2 == null)
        throw new ArgumentNullException(nameof (p2));
      this.Adapter.DeleteCommand.Parameters[10].Value = (object) 0;
      this.Adapter.DeleteCommand.Parameters[11].Value = (object) p2;
      this.Adapter.DeleteCommand.Parameters[12].Value = (object) Original_ID;
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
      int Birim_Adı,
      string PLAKA,
      string ARACACIKLAMA,
      int Ana_Grup,
      int Alt_Grup,
      string p1,
      byte[] RESIMON,
      byte[] RESİMARKA)
    {
      this.Adapter.InsertCommand.Parameters[0].Value = (object) Birim_Adı;
      if (PLAKA == null)
        this.Adapter.InsertCommand.Parameters[1].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[1].Value = (object) PLAKA;
      if (ARACACIKLAMA == null)
        this.Adapter.InsertCommand.Parameters[2].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[2].Value = (object) ARACACIKLAMA;
      this.Adapter.InsertCommand.Parameters[3].Value = (object) Ana_Grup;
      this.Adapter.InsertCommand.Parameters[4].Value = (object) Alt_Grup;
      this.Adapter.InsertCommand.Parameters[5].Value = p1 != null ? (object) p1 : throw new ArgumentNullException(nameof (p1));
      if (RESIMON == null)
        this.Adapter.InsertCommand.Parameters[6].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[6].Value = (object) RESIMON;
      if (RESİMARKA == null)
        this.Adapter.InsertCommand.Parameters[7].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[7].Value = (object) RESİMARKA;
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
      int Birim_Adı,
      string PLAKA,
      string ARACACIKLAMA,
      int Ana_Grup,
      int Alt_Grup,
      string p1,
      byte[] RESIMON,
      byte[] RESİMARKA,
      int Original_Birim_Adı,
      string Original_PLAKA,
      string Original_ARACACIKLAMA,
      int Original_Ana_Grup,
      int Original_Alt_Grup,
      string p2,
      int Original_ID,
      int ID)
    {
      this.Adapter.UpdateCommand.Parameters[0].Value = (object) Birim_Adı;
      if (PLAKA == null)
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) PLAKA;
      if (ARACACIKLAMA == null)
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) ARACACIKLAMA;
      this.Adapter.UpdateCommand.Parameters[3].Value = (object) Ana_Grup;
      this.Adapter.UpdateCommand.Parameters[4].Value = (object) Alt_Grup;
      this.Adapter.UpdateCommand.Parameters[5].Value = p1 != null ? (object) p1 : throw new ArgumentNullException(nameof (p1));
      if (RESIMON == null)
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) RESIMON;
      if (RESİMARKA == null)
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) RESİMARKA;
      this.Adapter.UpdateCommand.Parameters[8].Value = (object) 0;
      this.Adapter.UpdateCommand.Parameters[9].Value = (object) Original_Birim_Adı;
      if (Original_PLAKA == null)
      {
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) Original_PLAKA;
      }
      if (Original_ARACACIKLAMA == null)
      {
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) Original_ARACACIKLAMA;
      }
      this.Adapter.UpdateCommand.Parameters[14].Value = (object) 0;
      this.Adapter.UpdateCommand.Parameters[15].Value = (object) Original_Ana_Grup;
      this.Adapter.UpdateCommand.Parameters[16].Value = (object) 0;
      this.Adapter.UpdateCommand.Parameters[17].Value = (object) Original_Alt_Grup;
      if (p2 == null)
        throw new ArgumentNullException(nameof (p2));
      this.Adapter.UpdateCommand.Parameters[18].Value = (object) 0;
      this.Adapter.UpdateCommand.Parameters[19].Value = (object) p2;
      this.Adapter.UpdateCommand.Parameters[20].Value = (object) Original_ID;
      this.Adapter.UpdateCommand.Parameters[21].Value = (object) ID;
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
      int Birim_Adı,
      string PLAKA,
      string ARACACIKLAMA,
      int Ana_Grup,
      int Alt_Grup,
      string p1,
      byte[] RESIMON,
      byte[] RESİMARKA,
      int Original_Birim_Adı,
      string Original_PLAKA,
      string Original_ARACACIKLAMA,
      int Original_Ana_Grup,
      int Original_Alt_Grup,
      string p2,
      int Original_ID)
    {
      return this.Update(Birim_Adı, PLAKA, ARACACIKLAMA, Ana_Grup, Alt_Grup, p1, RESIMON, RESİMARKA, Original_Birim_Adı, Original_PLAKA, Original_ARACACIKLAMA, Original_Ana_Grup, Original_Alt_Grup, p2, Original_ID, Original_ID);
    }
  }
}
