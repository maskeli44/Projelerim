// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Model.izinListesiTableAdapters.DataTable2TableAdapter
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using Makina_Ikmal.Properties;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Makina_Ikmal.Model.izinListesiTableAdapters
{
  [DesignerCategory("code")]
  [ToolboxItem(true)]
  [DataObject(true)]
  [Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [HelpKeyword("vs.data.TableAdapter")]
  public class DataTable2TableAdapter : Component
  {
    private SqlDataAdapter _adapter;
    private SqlConnection _connection;
    private SqlTransaction _transaction;
    private SqlCommand[] _commandCollection;
    private bool _clearBeforeFill;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataTable2TableAdapter() => this.ClearBeforeFill = true;

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
        DataSetTable = "DataTable2",
        ColumnMappings = {
          {
            "ID",
            "ID"
          },
          {
            "ADISOYADI",
            "ADISOYADI"
          },
          {
            "IZINTURU",
            "IZINTURU"
          },
          {
            "IZINYILLARI",
            "IZINYILLARI"
          },
          {
            "IZINSURESI",
            "IZINSURESI"
          },
          {
            "BASLANGICTARIHI",
            "BASLANGICTARIHI"
          },
          {
            "BASLANGICSAATI",
            "BASLANGICSAATI"
          },
          {
            "BITISTARIHI",
            "BITISTARIHI"
          },
          {
            "BITISSAATI",
            "BITISSAATI"
          },
          {
            "IZINGUNSAY",
            "IZINGUNSAY"
          },
          {
            "GOREVEBASTARIH",
            "GOREVEBASTARIH"
          },
          {
            "IZINDEBULADRES",
            "IZINDEBULADRES"
          },
          {
            "ONAYTARIH",
            "ONAYTARIH"
          },
          {
            "IZINDURUM",
            "IZINDURUM"
          },
          {
            "GOREVYERI",
            "GOREVYERI"
          },
          {
            "UNVAN",
            "UNVAN"
          },
          {
            "KURUMGOREV",
            "KURUMGOREV"
          },
          {
            "BELDBIRIMADI",
            "BELDBIRIMADI"
          },
          {
            "Expr1",
            "Expr1"
          },
          {
            "Expr2",
            "Expr2"
          },
          {
            "Expr3",
            "Expr3"
          },
          {
            "TBLPERSONEL.RESIM2",
            "TBLPERSONEL_RESIM2"
          }
        }
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitConnection()
    {
      this._connection = new SqlConnection();
      this._connection.ConnectionString = Settings.Default.belediyeConnectionString;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitCommandCollection()
    {
      this._commandCollection = new SqlCommand[1];
      this._commandCollection[0] = new SqlCommand();
      this._commandCollection[0].Connection = this.Connection;
      this._commandCollection[0].CommandText = "SELECT DISTINCT \r\n                  TBLPERSONELIZIN.ID, CAST(TBLPERSONEL.RESIM2 AS VARBINARY(8000)) AS [TBLPERSONEL.RESIM2], TBLPERSONEL.ADISOYADI, TBLPERSONELIZIN.IZINTURU, TBLPERSONELIZIN.IZINYILLARI, TBLPERSONELIZIN.IZINSURESI, \r\n                  TBLPERSONELIZIN.BASLANGICTARIHI, TBLPERSONELIZIN.BASLANGICSAATI, TBLPERSONELIZIN.BITISTARIHI, TBLPERSONELIZIN.BITISSAATI, TBLPERSONELIZIN.IZINGUNSAY, TBLPERSONELIZIN.GOREVEBASTARIH, \r\n                  TBLPERSONELIZIN.IZINDEBULADRES, TBLPERSONELIZIN.ONAYTARIH, TBLPERSONELIZIN.IZINDURUM, TBLPERSONEL.GOREVYERI, TBLPERSUNVAN.UNVAN, TBLPERSKURUMGOREV.KURUMGOREV, \r\n                  TBLBELDBIRIMLER.BELDBIRIMADI, TBLPERSONEL_2.ADISOYADI AS Expr1, TBLPERSONEL_3.ADISOYADI AS Expr2, TBLPERSONEL_1.ADISOYADI AS Expr3\r\nFROM     TBLPERSONELIZIN INNER JOIN\r\n                  TBLPERSONEL ON TBLPERSONELIZIN.PERSID = TBLPERSONEL.ID INNER JOIN\r\n                  TBLBELDBIRIMLER ON TBLPERSONEL.BELDBIRIMIID = TBLBELDBIRIMLER.ID LEFT OUTER JOIN\r\n                  TBLPERSONEL AS TBLPERSONEL_2 ON TBLPERSONELIZIN.DAIREBSKID = TBLPERSONEL_2.ID LEFT OUTER JOIN\r\n                  TBLPERSONEL AS TBLPERSONEL_3 ON TBLPERSONELIZIN.INSANDAIREBSKID = TBLPERSONEL_3.ID LEFT OUTER JOIN\r\n                  TBLPERSONEL AS TBLPERSONEL_1 ON TBLPERSONELIZIN.GENELSEKYRDID = TBLPERSONEL_1.ID LEFT OUTER JOIN\r\n                  TBLPERSKURUMGOREV ON TBLPERSONEL.GOREVUNVANID = TBLPERSKURUMGOREV.ID LEFT OUTER JOIN\r\n                  TBLPERSUNVAN ON TBLPERSONEL.UNVANID = TBLPERSUNVAN.ID\r\nORDER BY TBLPERSONELIZIN.ID DESC";
      this._commandCollection[0].CommandType = CommandType.Text;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    public virtual int Fill(izinListesi.DataTable2DataTable dataTable)
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
    public virtual izinListesi.DataTable2DataTable GetData()
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      izinListesi.DataTable2DataTable data = new izinListesi.DataTable2DataTable();
      this.Adapter.Fill((DataTable) data);
      return data;
    }
  }
}
