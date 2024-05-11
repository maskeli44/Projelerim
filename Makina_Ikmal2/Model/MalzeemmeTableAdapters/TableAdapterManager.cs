// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Model.MalzeemmeTableAdapters.TableAdapterManager
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Makina_Ikmal.Model.MalzeemmeTableAdapters
{
  [DesignerCategory("code")]
  [ToolboxItem(true)]
  [Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [HelpKeyword("vs.data.TableAdapterManager")]
  public class TableAdapterManager : Component
  {
    private TableAdapterManager.UpdateOrderOption _updateOrder;
    private TBLMALZEMELERTableAdapter _tBLMALZEMELERTableAdapter;
    private TBLFILITRETableAdapter _tBLFILITRETableAdapter;
    private TBLYAGTableAdapter _tBLYAGTableAdapter;
    private bool _backupDataSetBeforeUpdate;
    private IDbConnection _connection;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public TableAdapterManager.UpdateOrderOption UpdateOrder
    {
      get => this._updateOrder;
      set => this._updateOrder = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLMALZEMELERTableAdapter TBLMALZEMELERTableAdapter
    {
      get => this._tBLMALZEMELERTableAdapter;
      set => this._tBLMALZEMELERTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLFILITRETableAdapter TBLFILITRETableAdapter
    {
      get => this._tBLFILITRETableAdapter;
      set => this._tBLFILITRETableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLYAGTableAdapter TBLYAGTableAdapter
    {
      get => this._tBLYAGTableAdapter;
      set => this._tBLYAGTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool BackupDataSetBeforeUpdate
    {
      get => this._backupDataSetBeforeUpdate;
      set => this._backupDataSetBeforeUpdate = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public IDbConnection Connection
    {
      get
      {
        if (this._connection != null)
          return this._connection;
        if (this._tBLMALZEMELERTableAdapter != null && this._tBLMALZEMELERTableAdapter.Connection != null)
          return (IDbConnection) this._tBLMALZEMELERTableAdapter.Connection;
        if (this._tBLFILITRETableAdapter != null && this._tBLFILITRETableAdapter.Connection != null)
          return (IDbConnection) this._tBLFILITRETableAdapter.Connection;
        return this._tBLYAGTableAdapter != null && this._tBLYAGTableAdapter.Connection != null ? (IDbConnection) this._tBLYAGTableAdapter.Connection : (IDbConnection) null;
      }
      set => this._connection = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int TableAdapterInstanceCount
    {
      get
      {
        int adapterInstanceCount = 0;
        if (this._tBLMALZEMELERTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLFILITRETableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLYAGTableAdapter != null)
          ++adapterInstanceCount;
        return adapterInstanceCount;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private int UpdateUpdatedRows(
      Malzeemme dataSet,
      List<DataRow> allChangedRows,
      List<DataRow> allAddedRows)
    {
      int num = 0;
      if (this._tBLMALZEMELERTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLMALZEMELER.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLMALZEMELERTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLFILITRETableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLFILITRE.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLFILITRETableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLYAGTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLYAG.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLYAGTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      return num;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private int UpdateInsertedRows(Malzeemme dataSet, List<DataRow> allAddedRows)
    {
      int num = 0;
      if (this._tBLMALZEMELERTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLMALZEMELER.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLMALZEMELERTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLFILITRETableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLFILITRE.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLFILITRETableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLYAGTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLYAG.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLYAGTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      return num;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private int UpdateDeletedRows(Malzeemme dataSet, List<DataRow> allChangedRows)
    {
      int num = 0;
      if (this._tBLYAGTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLYAG.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLYAGTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLFILITRETableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLFILITRE.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLFILITRETableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLMALZEMELERTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLMALZEMELER.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLMALZEMELERTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      return num;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private DataRow[] GetRealUpdatedRows(DataRow[] updatedRows, List<DataRow> allAddedRows)
    {
      if (updatedRows == null || updatedRows.Length < 1 || allAddedRows == null || allAddedRows.Count < 1)
        return updatedRows;
      List<DataRow> dataRowList = new List<DataRow>();
      for (int index = 0; index < updatedRows.Length; ++index)
      {
        DataRow updatedRow = updatedRows[index];
        if (!allAddedRows.Contains(updatedRow))
          dataRowList.Add(updatedRow);
      }
      return dataRowList.ToArray();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public virtual int UpdateAll(Malzeemme dataSet)
    {
      if (dataSet == null)
        throw new ArgumentNullException(nameof (dataSet));
      if (!dataSet.HasChanges())
        return 0;
      if (this._tBLMALZEMELERTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLMALZEMELERTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLFILITRETableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLFILITRETableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLYAGTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLYAGTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      IDbConnection connection = this.Connection;
      if (connection == null)
        throw new ApplicationException("TableAdapterManager bağlantı bilgisi içermiyor. TableAdapterManager TableAdapter özelliklerinin her birini geçerli bir TableAdapter örneğine ayarlayın.");
      bool flag = false;
      if ((connection.State & ConnectionState.Broken) == ConnectionState.Broken)
        connection.Close();
      if (connection.State == ConnectionState.Closed)
      {
        connection.Open();
        flag = true;
      }
      IDbTransaction dbTransaction = connection.BeginTransaction();
      if (dbTransaction == null)
        throw new ApplicationException("İşlem başlatılamıyor. Geçerli veri bağlantısı işlemleri desteklemiyor veya geçerli durum işlemin başlatılmasına izin vermiyor.");
      List<DataRow> allChangedRows = new List<DataRow>();
      List<DataRow> allAddedRows = new List<DataRow>();
      List<DataAdapter> dataAdapterList = new List<DataAdapter>();
      Dictionary<object, IDbConnection> dictionary = new Dictionary<object, IDbConnection>();
      int num = 0;
      DataSet dataSet1 = (DataSet) null;
      if (this.BackupDataSetBeforeUpdate)
      {
        dataSet1 = new DataSet();
        dataSet1.Merge((DataSet) dataSet);
      }
      try
      {
        if (this._tBLMALZEMELERTableAdapter != null)
        {
          dictionary.Add((object) this._tBLMALZEMELERTableAdapter, (IDbConnection) this._tBLMALZEMELERTableAdapter.Connection);
          this._tBLMALZEMELERTableAdapter.Connection = (SqlConnection) connection;
          this._tBLMALZEMELERTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLMALZEMELERTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLMALZEMELERTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLMALZEMELERTableAdapter.Adapter);
          }
        }
        if (this._tBLFILITRETableAdapter != null)
        {
          dictionary.Add((object) this._tBLFILITRETableAdapter, (IDbConnection) this._tBLFILITRETableAdapter.Connection);
          this._tBLFILITRETableAdapter.Connection = (SqlConnection) connection;
          this._tBLFILITRETableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLFILITRETableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLFILITRETableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLFILITRETableAdapter.Adapter);
          }
        }
        if (this._tBLYAGTableAdapter != null)
        {
          dictionary.Add((object) this._tBLYAGTableAdapter, (IDbConnection) this._tBLYAGTableAdapter.Connection);
          this._tBLYAGTableAdapter.Connection = (SqlConnection) connection;
          this._tBLYAGTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLYAGTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLYAGTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLYAGTableAdapter.Adapter);
          }
        }
        if (this.UpdateOrder == TableAdapterManager.UpdateOrderOption.UpdateInsertDelete)
        {
          num += this.UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows);
          num += this.UpdateInsertedRows(dataSet, allAddedRows);
        }
        else
        {
          num += this.UpdateInsertedRows(dataSet, allAddedRows);
          num += this.UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows);
        }
        num += this.UpdateDeletedRows(dataSet, allChangedRows);
        dbTransaction.Commit();
        if (0 < allAddedRows.Count)
        {
          DataRow[] array = new DataRow[allAddedRows.Count];
          allAddedRows.CopyTo(array);
          for (int index = 0; index < array.Length; ++index)
            array[index].AcceptChanges();
        }
        if (0 < allChangedRows.Count)
        {
          DataRow[] array = new DataRow[allChangedRows.Count];
          allChangedRows.CopyTo(array);
          for (int index = 0; index < array.Length; ++index)
            array[index].AcceptChanges();
        }
      }
      catch (Exception ex)
      {
        dbTransaction.Rollback();
        if (this.BackupDataSetBeforeUpdate)
        {
          Debug.Assert(dataSet1 != null);
          dataSet.Clear();
          dataSet.Merge(dataSet1);
        }
        else if (0 < allAddedRows.Count)
        {
          DataRow[] array = new DataRow[allAddedRows.Count];
          allAddedRows.CopyTo(array);
          for (int index = 0; index < array.Length; ++index)
          {
            DataRow dataRow = array[index];
            dataRow.AcceptChanges();
            dataRow.SetAdded();
          }
        }
        throw ex;
      }
      finally
      {
        if (flag)
          connection.Close();
        if (this._tBLMALZEMELERTableAdapter != null)
        {
          this._tBLMALZEMELERTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLMALZEMELERTableAdapter];
          this._tBLMALZEMELERTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLFILITRETableAdapter != null)
        {
          this._tBLFILITRETableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLFILITRETableAdapter];
          this._tBLFILITRETableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLYAGTableAdapter != null)
        {
          this._tBLYAGTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLYAGTableAdapter];
          this._tBLYAGTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (0 < dataAdapterList.Count)
        {
          DataAdapter[] array = new DataAdapter[dataAdapterList.Count];
          dataAdapterList.CopyTo(array);
          for (int index = 0; index < array.Length; ++index)
            array[index].AcceptChangesDuringUpdate = true;
        }
      }
      return num;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected virtual void SortSelfReferenceRows(
      DataRow[] rows,
      DataRelation relation,
      bool childFirst)
    {
      Array.Sort<DataRow>(rows, (IComparer<DataRow>) new TableAdapterManager.SelfReferenceComparer(relation, childFirst));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected virtual bool MatchTableAdapterConnection(IDbConnection inputConnection) => this._connection != null || this.Connection == null || inputConnection == null || string.Equals(this.Connection.ConnectionString, inputConnection.ConnectionString, StringComparison.Ordinal);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public enum UpdateOrderOption
    {
      InsertUpdateDelete,
      UpdateInsertDelete,
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private class SelfReferenceComparer : IComparer<DataRow>
    {
      private DataRelation _relation;
      private int _childFirst;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal SelfReferenceComparer(DataRelation relation, bool childFirst)
      {
        this._relation = relation;
        if (childFirst)
          this._childFirst = -1;
        else
          this._childFirst = 1;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      private DataRow GetRoot(DataRow row, out int distance)
      {
        Debug.Assert(row != null);
        DataRow root = row;
        distance = 0;
        IDictionary<DataRow, DataRow> dictionary = (IDictionary<DataRow, DataRow>) new Dictionary<DataRow, DataRow>();
        dictionary[row] = row;
        for (DataRow parentRow = row.GetParentRow(this._relation, DataRowVersion.Default); parentRow != null && !dictionary.ContainsKey(parentRow); parentRow = parentRow.GetParentRow(this._relation, DataRowVersion.Default))
        {
          ++distance;
          root = parentRow;
          dictionary[parentRow] = parentRow;
        }
        if (distance == 0)
        {
          dictionary.Clear();
          dictionary[row] = row;
          for (DataRow parentRow = row.GetParentRow(this._relation, DataRowVersion.Original); parentRow != null && !dictionary.ContainsKey(parentRow); parentRow = parentRow.GetParentRow(this._relation, DataRowVersion.Original))
          {
            ++distance;
            root = parentRow;
            dictionary[parentRow] = parentRow;
          }
        }
        return root;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int Compare(DataRow row1, DataRow row2)
      {
        if (row1 == row2)
          return 0;
        if (row1 == null)
          return -1;
        if (row2 == null)
          return 1;
        int distance1 = 0;
        DataRow root1 = this.GetRoot(row1, out distance1);
        int distance2 = 0;
        DataRow root2 = this.GetRoot(row2, out distance2);
        if (root1 == root2)
          return this._childFirst * distance1.CompareTo(distance2);
        Debug.Assert(root1.Table != null && root2.Table != null);
        return root1.Table.Rows.IndexOf(root1) < root2.Table.Rows.IndexOf(root2) ? -1 : 1;
      }
    }
  }
}
