// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.makina_ikmal_2022DataSet1TableAdapters.TBLFORMKULLANICITableAdapter
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

namespace Makina_Ikmal.makina_ikmal_2022DataSet1TableAdapters
{
  [DesignerCategory("code")]
  [ToolboxItem(true)]
  [DataObject(true)]
  [Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [HelpKeyword("vs.data.TableAdapter")]
  public class TBLFORMKULLANICITableAdapter : Component
  {
    private SqlDataAdapter _adapter;
    private SqlConnection _connection;
    private SqlTransaction _transaction;
    private SqlCommand[] _commandCollection;
    private bool _clearBeforeFill;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public TBLFORMKULLANICITableAdapter() => this.ClearBeforeFill = true;

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
        DataSetTable = "TBLFORMKULLANICI",
        ColumnMappings = {
          {
            "ID",
            "ID"
          },
          {
            "KULLANICIID",
            "KULLANICIID"
          },
          {
            "KOMUTADI",
            "KOMUTADI"
          },
          {
            "SALTOKUNUR",
            "SALTOKUNUR"
          },
          {
            "KAYIT",
            "KAYIT"
          },
          {
            "SİL",
            "SİL"
          },
          {
            "GUNCELLEME",
            "GUNCELLEME"
          },
          {
            "LISTELEME",
            "LISTELEME"
          },
          {
            "KOMUTID",
            "KOMUTID"
          }
        }
      });
      this._adapter.DeleteCommand = new SqlCommand();
      this._adapter.DeleteCommand.Connection = this.Connection;
      this._adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[TBLFORMKULLANICI] WHERE (([ID] = @Original_ID) AND ((@IsNull_KULLANICIID = 1 AND [KULLANICIID] IS NULL) OR ([KULLANICIID] = @Original_KULLANICIID)) AND ((@IsNull_KOMUTADI = 1 AND [KOMUTADI] IS NULL) OR ([KOMUTADI] = @Original_KOMUTADI)) AND ((@IsNull_SALTOKUNUR = 1 AND [SALTOKUNUR] IS NULL) OR ([SALTOKUNUR] = @Original_SALTOKUNUR)) AND ((@IsNull_KAYIT = 1 AND [KAYIT] IS NULL) OR ([KAYIT] = @Original_KAYIT)) AND ((@IsNull_SİL = 1 AND [SİL] IS NULL) OR ([SİL] = @Original_SİL)) AND ((@IsNull_GUNCELLEME = 1 AND [GUNCELLEME] IS NULL) OR ([GUNCELLEME] = @Original_GUNCELLEME)) AND ((@IsNull_LISTELEME = 1 AND [LISTELEME] IS NULL) OR ([LISTELEME] = @Original_LISTELEME)) AND ((@IsNull_KOMUTID = 1 AND [KOMUTID] IS NULL) OR ([KOMUTID] = @Original_KOMUTID)))";
      this._adapter.DeleteCommand.CommandType = CommandType.Text;
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_KULLANICIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KULLANICIID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_KULLANICIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KULLANICIID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_KOMUTADI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOMUTADI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_KOMUTADI", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOMUTADI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SALTOKUNUR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SALTOKUNUR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SALTOKUNUR", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SALTOKUNUR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_KAYIT", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KAYIT", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_KAYIT", SqlDbType.Bit, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KAYIT", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SİL", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SİL", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SİL", SqlDbType.Bit, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SİL", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_GUNCELLEME", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GUNCELLEME", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_GUNCELLEME", SqlDbType.Bit, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GUNCELLEME", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_LISTELEME", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "LISTELEME", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_LISTELEME", SqlDbType.Bit, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "LISTELEME", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_KOMUTID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOMUTID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_KOMUTID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOMUTID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.InsertCommand = new SqlCommand();
      this._adapter.InsertCommand.Connection = this.Connection;
      this._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[TBLFORMKULLANICI] ([KULLANICIID], [KOMUTADI], [SALTOKUNUR], [KAYIT], [SİL], [GUNCELLEME], [LISTELEME], [KOMUTID]) VALUES (@KULLANICIID, @KOMUTADI, @SALTOKUNUR, @KAYIT, @SİL, @GUNCELLEME, @LISTELEME, @KOMUTID);\r\nSELECT ID, KULLANICIID, KOMUTADI, SALTOKUNUR, KAYIT, SİL, GUNCELLEME, LISTELEME, KOMUTID FROM TBLFORMKULLANICI WHERE (ID = SCOPE_IDENTITY())";
      this._adapter.InsertCommand.CommandType = CommandType.Text;
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@KULLANICIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KULLANICIID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@KOMUTADI", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOMUTADI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SALTOKUNUR", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SALTOKUNUR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@KAYIT", SqlDbType.Bit, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KAYIT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@SİL", SqlDbType.Bit, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SİL", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@GUNCELLEME", SqlDbType.Bit, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GUNCELLEME", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@LISTELEME", SqlDbType.Bit, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "LISTELEME", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@KOMUTID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOMUTID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand = new SqlCommand();
      this._adapter.UpdateCommand.Connection = this.Connection;
      this._adapter.UpdateCommand.CommandText = "UPDATE [dbo].[TBLFORMKULLANICI] SET [KULLANICIID] = @KULLANICIID, [KOMUTADI] = @KOMUTADI, [SALTOKUNUR] = @SALTOKUNUR, [KAYIT] = @KAYIT, [SİL] = @SİL, [GUNCELLEME] = @GUNCELLEME, [LISTELEME] = @LISTELEME, [KOMUTID] = @KOMUTID WHERE (([ID] = @Original_ID) AND ((@IsNull_KULLANICIID = 1 AND [KULLANICIID] IS NULL) OR ([KULLANICIID] = @Original_KULLANICIID)) AND ((@IsNull_KOMUTADI = 1 AND [KOMUTADI] IS NULL) OR ([KOMUTADI] = @Original_KOMUTADI)) AND ((@IsNull_SALTOKUNUR = 1 AND [SALTOKUNUR] IS NULL) OR ([SALTOKUNUR] = @Original_SALTOKUNUR)) AND ((@IsNull_KAYIT = 1 AND [KAYIT] IS NULL) OR ([KAYIT] = @Original_KAYIT)) AND ((@IsNull_SİL = 1 AND [SİL] IS NULL) OR ([SİL] = @Original_SİL)) AND ((@IsNull_GUNCELLEME = 1 AND [GUNCELLEME] IS NULL) OR ([GUNCELLEME] = @Original_GUNCELLEME)) AND ((@IsNull_LISTELEME = 1 AND [LISTELEME] IS NULL) OR ([LISTELEME] = @Original_LISTELEME)) AND ((@IsNull_KOMUTID = 1 AND [KOMUTID] IS NULL) OR ([KOMUTID] = @Original_KOMUTID)));\r\nSELECT ID, KULLANICIID, KOMUTADI, SALTOKUNUR, KAYIT, SİL, GUNCELLEME, LISTELEME, KOMUTID FROM TBLFORMKULLANICI WHERE (ID = @ID)";
      this._adapter.UpdateCommand.CommandType = CommandType.Text;
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@KULLANICIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KULLANICIID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@KOMUTADI", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOMUTADI", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SALTOKUNUR", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SALTOKUNUR", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@KAYIT", SqlDbType.Bit, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KAYIT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SİL", SqlDbType.Bit, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SİL", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@GUNCELLEME", SqlDbType.Bit, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GUNCELLEME", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@LISTELEME", SqlDbType.Bit, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "LISTELEME", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@KOMUTID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOMUTID", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_KULLANICIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KULLANICIID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_KULLANICIID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KULLANICIID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_KOMUTADI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOMUTADI", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_KOMUTADI", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOMUTADI", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SALTOKUNUR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SALTOKUNUR", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SALTOKUNUR", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SALTOKUNUR", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_KAYIT", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KAYIT", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_KAYIT", SqlDbType.Bit, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KAYIT", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SİL", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SİL", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SİL", SqlDbType.Bit, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SİL", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_GUNCELLEME", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GUNCELLEME", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_GUNCELLEME", SqlDbType.Bit, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GUNCELLEME", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_LISTELEME", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "LISTELEME", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_LISTELEME", SqlDbType.Bit, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "LISTELEME", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_KOMUTID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOMUTID", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_KOMUTID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KOMUTID", DataRowVersion.Original, false, (object) null, "", "", ""));
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
      this._commandCollection[0].CommandText = "SELECT ID, KULLANICIID, KOMUTADI, SALTOKUNUR, KAYIT, SİL, GUNCELLEME, LISTELEME, KOMUTID FROM dbo.TBLFORMKULLANICI";
      this._commandCollection[0].CommandType = CommandType.Text;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    public virtual int Fill(
      makina_ikmal_2022DataSet1.TBLFORMKULLANICIDataTable dataTable)
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
    public virtual makina_ikmal_2022DataSet1.TBLFORMKULLANICIDataTable GetData()
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      makina_ikmal_2022DataSet1.TBLFORMKULLANICIDataTable data = new makina_ikmal_2022DataSet1.TBLFORMKULLANICIDataTable();
      this.Adapter.Fill((DataTable) data);
      return data;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(
      makina_ikmal_2022DataSet1.TBLFORMKULLANICIDataTable dataTable)
    {
      return this.Adapter.Update((DataTable) dataTable);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(makina_ikmal_2022DataSet1 dataSet) => this.Adapter.Update((DataSet) dataSet, "TBLFORMKULLANICI");

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
      int? Original_KULLANICIID,
      string Original_KOMUTADI,
      string Original_SALTOKUNUR,
      bool? Original_KAYIT,
      bool? Original_SİL,
      bool? Original_GUNCELLEME,
      bool? Original_LISTELEME,
      int? Original_KOMUTID)
    {
      this.Adapter.DeleteCommand.Parameters[0].Value = (object) Original_ID;
      if (Original_KULLANICIID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[1].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[2].Value = (object) Original_KULLANICIID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[1].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[2].Value = (object) DBNull.Value;
      }
      if (Original_KOMUTADI == null)
      {
        this.Adapter.DeleteCommand.Parameters[3].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[4].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[3].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[4].Value = (object) Original_KOMUTADI;
      }
      if (Original_SALTOKUNUR == null)
      {
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[6].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[6].Value = (object) Original_SALTOKUNUR;
      }
      if (Original_KAYIT.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[7].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[8].Value = (object) Original_KAYIT.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[7].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[8].Value = (object) DBNull.Value;
      }
      if (Original_SİL.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) Original_SİL.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) DBNull.Value;
      }
      if (Original_GUNCELLEME.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[11].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[12].Value = (object) Original_GUNCELLEME.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[11].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[12].Value = (object) DBNull.Value;
      }
      if (Original_LISTELEME.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[13].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[14].Value = (object) Original_LISTELEME.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[13].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[14].Value = (object) DBNull.Value;
      }
      if (Original_KOMUTID.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[15].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[16].Value = (object) Original_KOMUTID.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[15].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[16].Value = (object) DBNull.Value;
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
      int? KULLANICIID,
      string KOMUTADI,
      string SALTOKUNUR,
      bool? KAYIT,
      bool? SİL,
      bool? GUNCELLEME,
      bool? LISTELEME,
      int? KOMUTID)
    {
      if (KULLANICIID.HasValue)
        this.Adapter.InsertCommand.Parameters[0].Value = (object) KULLANICIID.Value;
      else
        this.Adapter.InsertCommand.Parameters[0].Value = (object) DBNull.Value;
      if (KOMUTADI == null)
        this.Adapter.InsertCommand.Parameters[1].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[1].Value = (object) KOMUTADI;
      if (SALTOKUNUR == null)
        this.Adapter.InsertCommand.Parameters[2].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[2].Value = (object) SALTOKUNUR;
      if (KAYIT.HasValue)
        this.Adapter.InsertCommand.Parameters[3].Value = (object) KAYIT.Value;
      else
        this.Adapter.InsertCommand.Parameters[3].Value = (object) DBNull.Value;
      if (SİL.HasValue)
        this.Adapter.InsertCommand.Parameters[4].Value = (object) SİL.Value;
      else
        this.Adapter.InsertCommand.Parameters[4].Value = (object) DBNull.Value;
      if (GUNCELLEME.HasValue)
        this.Adapter.InsertCommand.Parameters[5].Value = (object) GUNCELLEME.Value;
      else
        this.Adapter.InsertCommand.Parameters[5].Value = (object) DBNull.Value;
      if (LISTELEME.HasValue)
        this.Adapter.InsertCommand.Parameters[6].Value = (object) LISTELEME.Value;
      else
        this.Adapter.InsertCommand.Parameters[6].Value = (object) DBNull.Value;
      if (KOMUTID.HasValue)
        this.Adapter.InsertCommand.Parameters[7].Value = (object) KOMUTID.Value;
      else
        this.Adapter.InsertCommand.Parameters[7].Value = (object) DBNull.Value;
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
      int? KULLANICIID,
      string KOMUTADI,
      string SALTOKUNUR,
      bool? KAYIT,
      bool? SİL,
      bool? GUNCELLEME,
      bool? LISTELEME,
      int? KOMUTID,
      int Original_ID,
      int? Original_KULLANICIID,
      string Original_KOMUTADI,
      string Original_SALTOKUNUR,
      bool? Original_KAYIT,
      bool? Original_SİL,
      bool? Original_GUNCELLEME,
      bool? Original_LISTELEME,
      int? Original_KOMUTID,
      int ID)
    {
      if (KULLANICIID.HasValue)
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) KULLANICIID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) DBNull.Value;
      if (KOMUTADI == null)
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) KOMUTADI;
      if (SALTOKUNUR == null)
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) SALTOKUNUR;
      if (KAYIT.HasValue)
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) KAYIT.Value;
      else
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) DBNull.Value;
      if (SİL.HasValue)
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) SİL.Value;
      else
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) DBNull.Value;
      if (GUNCELLEME.HasValue)
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) GUNCELLEME.Value;
      else
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) DBNull.Value;
      if (LISTELEME.HasValue)
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) LISTELEME.Value;
      else
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) DBNull.Value;
      if (KOMUTID.HasValue)
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) KOMUTID.Value;
      else
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) DBNull.Value;
      this.Adapter.UpdateCommand.Parameters[8].Value = (object) Original_ID;
      if (Original_KULLANICIID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) Original_KULLANICIID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) DBNull.Value;
      }
      if (Original_KOMUTADI == null)
      {
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) Original_KOMUTADI;
      }
      if (Original_SALTOKUNUR == null)
      {
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) Original_SALTOKUNUR;
      }
      if (Original_KAYIT.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[16].Value = (object) Original_KAYIT.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[16].Value = (object) DBNull.Value;
      }
      if (Original_SİL.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[17].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[18].Value = (object) Original_SİL.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[17].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[18].Value = (object) DBNull.Value;
      }
      if (Original_GUNCELLEME.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[19].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[20].Value = (object) Original_GUNCELLEME.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[19].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[20].Value = (object) DBNull.Value;
      }
      if (Original_LISTELEME.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[21].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[22].Value = (object) Original_LISTELEME.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[21].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[22].Value = (object) DBNull.Value;
      }
      if (Original_KOMUTID.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[23].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[24].Value = (object) Original_KOMUTID.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[23].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[24].Value = (object) DBNull.Value;
      }
      this.Adapter.UpdateCommand.Parameters[25].Value = (object) ID;
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
      int? KULLANICIID,
      string KOMUTADI,
      string SALTOKUNUR,
      bool? KAYIT,
      bool? SİL,
      bool? GUNCELLEME,
      bool? LISTELEME,
      int? KOMUTID,
      int Original_ID,
      int? Original_KULLANICIID,
      string Original_KOMUTADI,
      string Original_SALTOKUNUR,
      bool? Original_KAYIT,
      bool? Original_SİL,
      bool? Original_GUNCELLEME,
      bool? Original_LISTELEME,
      int? Original_KOMUTID)
    {
      return this.Update(KULLANICIID, KOMUTADI, SALTOKUNUR, KAYIT, SİL, GUNCELLEME, LISTELEME, KOMUTID, Original_ID, Original_KULLANICIID, Original_KOMUTADI, Original_SALTOKUNUR, Original_KAYIT, Original_SİL, Original_GUNCELLEME, Original_LISTELEME, Original_KOMUTID, Original_ID);
    }
  }
}
