// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Model.izinListesi
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Makina_Ikmal.Model
{
  [DesignerCategory("code")]
  [ToolboxItem(true)]
  [XmlSchemaProvider("GetTypedDataSetSchema")]
  [XmlRoot("izinListesi")]
  [HelpKeyword("vs.data.DataSet")]
  [Serializable]
  public class izinListesi : DataSet
  {
    private izinListesi.DataTable1DataTable tableDataTable1;
    private izinListesi.DataTable2DataTable tableDataTable2;
    private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public izinListesi()
    {
      this.BeginInit();
      this.InitClass();
      CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
      base.Tables.CollectionChanged += changeEventHandler;
      base.Relations.CollectionChanged += changeEventHandler;
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected izinListesi(SerializationInfo info, StreamingContext context)
      : base(info, context, false)
    {
      if (this.IsBinarySerialized(info, context))
      {
        this.InitVars(false);
        CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
        this.Tables.CollectionChanged += changeEventHandler;
        this.Relations.CollectionChanged += changeEventHandler;
      }
      else
      {
        string s = (string) info.GetValue("XmlSchema", typeof (string));
        if (this.DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
        {
          DataSet dataSet = new DataSet();
          dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
          if (dataSet.Tables[nameof (DataTable1)] != null)
            base.Tables.Add((DataTable) new izinListesi.DataTable1DataTable(dataSet.Tables[nameof (DataTable1)]));
          if (dataSet.Tables[nameof (DataTable2)] != null)
            base.Tables.Add((DataTable) new izinListesi.DataTable2DataTable(dataSet.Tables[nameof (DataTable2)]));
          this.DataSetName = dataSet.DataSetName;
          this.Prefix = dataSet.Prefix;
          this.Namespace = dataSet.Namespace;
          this.Locale = dataSet.Locale;
          this.CaseSensitive = dataSet.CaseSensitive;
          this.EnforceConstraints = dataSet.EnforceConstraints;
          this.Merge(dataSet, false, MissingSchemaAction.Add);
          this.InitVars();
        }
        else
          this.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
        this.GetSerializationData(info, context);
        CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
        base.Tables.CollectionChanged += changeEventHandler;
        this.Relations.CollectionChanged += changeEventHandler;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public izinListesi.DataTable1DataTable DataTable1 => this.tableDataTable1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public izinListesi.DataTable2DataTable DataTable2 => this.tableDataTable2;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public override SchemaSerializationMode SchemaSerializationMode
    {
      get => this._schemaSerializationMode;
      set => this._schemaSerializationMode = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new DataTableCollection Tables => base.Tables;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new DataRelationCollection Relations => base.Relations;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void InitializeDerivedDataSet()
    {
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataSet Clone()
    {
      izinListesi izinListesi = (izinListesi) base.Clone();
      izinListesi.InitVars();
      izinListesi.SchemaSerializationMode = this.SchemaSerializationMode;
      return (DataSet) izinListesi;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override bool ShouldSerializeTables() => false;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override bool ShouldSerializeRelations() => false;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void ReadXmlSerializable(XmlReader reader)
    {
      if (this.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
      {
        this.Reset();
        DataSet dataSet = new DataSet();
        int num = (int) dataSet.ReadXml(reader);
        if (dataSet.Tables["DataTable1"] != null)
          base.Tables.Add((DataTable) new izinListesi.DataTable1DataTable(dataSet.Tables["DataTable1"]));
        if (dataSet.Tables["DataTable2"] != null)
          base.Tables.Add((DataTable) new izinListesi.DataTable2DataTable(dataSet.Tables["DataTable2"]));
        this.DataSetName = dataSet.DataSetName;
        this.Prefix = dataSet.Prefix;
        this.Namespace = dataSet.Namespace;
        this.Locale = dataSet.Locale;
        this.CaseSensitive = dataSet.CaseSensitive;
        this.EnforceConstraints = dataSet.EnforceConstraints;
        this.Merge(dataSet, false, MissingSchemaAction.Add);
        this.InitVars();
      }
      else
      {
        int num = (int) this.ReadXml(reader);
        this.InitVars();
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override XmlSchema GetSchemaSerializable()
    {
      MemoryStream memoryStream = new MemoryStream();
      this.WriteXmlSchema((XmlWriter) new XmlTextWriter((Stream) memoryStream, (Encoding) null));
      memoryStream.Position = 0L;
      return XmlSchema.Read((XmlReader) new XmlTextReader((Stream) memoryStream), (ValidationEventHandler) null);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars() => this.InitVars(true);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars(bool initTable)
    {
      this.tableDataTable1 = (izinListesi.DataTable1DataTable) base.Tables["DataTable1"];
      if (initTable && this.tableDataTable1 != null)
        this.tableDataTable1.InitVars();
      this.tableDataTable2 = (izinListesi.DataTable2DataTable) base.Tables["DataTable2"];
      if (!initTable || this.tableDataTable2 == null)
        return;
      this.tableDataTable2.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.DataSetName = nameof (izinListesi);
      this.Prefix = "";
      this.Namespace = "http://tempuri.org/izinListesi.xsd";
      this.EnforceConstraints = true;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tableDataTable1 = new izinListesi.DataTable1DataTable();
      base.Tables.Add((DataTable) this.tableDataTable1);
      this.tableDataTable2 = new izinListesi.DataTable2DataTable();
      base.Tables.Add((DataTable) this.tableDataTable2);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private bool ShouldSerializeDataTable1() => false;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private bool ShouldSerializeDataTable2() => false;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void SchemaChanged(object sender, CollectionChangeEventArgs e)
    {
      if (e.Action != CollectionChangeAction.Remove)
        return;
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
    {
      izinListesi izinListesi = new izinListesi();
      XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
      {
        Namespace = izinListesi.Namespace
      });
      typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = izinListesi.GetSchemaSerializable();
      if (xs.Contains(schemaSerializable.TargetNamespace))
      {
        MemoryStream memoryStream1 = new MemoryStream();
        MemoryStream memoryStream2 = new MemoryStream();
        try
        {
          schemaSerializable.Write((Stream) memoryStream1);
          IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
          while (enumerator.MoveNext())
          {
            XmlSchema current = (XmlSchema) enumerator.Current;
            memoryStream2.SetLength(0L);
            current.Write((Stream) memoryStream2);
            if (memoryStream1.Length == memoryStream2.Length)
            {
              memoryStream1.Position = 0L;
              memoryStream2.Position = 0L;
              do
                ;
              while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
              if (memoryStream1.Position == memoryStream1.Length)
                return typedDataSetSchema;
            }
          }
        }
        finally
        {
          memoryStream1?.Close();
          memoryStream2?.Close();
        }
      }
      xs.Add(schemaSerializable);
      return typedDataSetSchema;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public delegate void DataTable1RowChangeEventHandler(
      object sender,
      izinListesi.DataTable1RowChangeEvent e);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public delegate void DataTable2RowChangeEventHandler(
      object sender,
      izinListesi.DataTable2RowChangeEvent e);

    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class DataTable1DataTable : TypedTableBase<izinListesi.DataTable1Row>
    {
      private DataColumn columnIZINTURU;
      private DataColumn columnIZINYILLARI;
      private DataColumn columnIZINSURESI;
      private DataColumn columnBASLANGICTARIHI;
      private DataColumn columnBITISTARIHI;
      private DataColumn columnIZINGUNSAY;
      private DataColumn columnGOREVEBASTARIH;
      private DataColumn columnADISOYADI;
      private DataColumn columnUNVAN;
      private DataColumn columnKURUMGOREV;
      private DataColumn columnID;
      private DataColumn columnBASLANGICSAATI;
      private DataColumn columnBITISSAATI;
      private DataColumn columnIZINDEBULADRES;
      private DataColumn columnONAYTARIH;
      private DataColumn columnIZINDURUM;
      private DataColumn columnGOREVYERI;
      private DataColumn columnBELDBIRIMADI;
      private DataColumn columnExpr1;
      private DataColumn columnExpr2;
      private DataColumn columnExpr3;
      private DataColumn columnTCKIMLIKNO;
      private DataColumn columnİSTİHDAMDURUMU;
      private DataColumn columnSICILNO;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataTable1DataTable()
      {
        this.TableName = "DataTable1";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal DataTable1DataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected DataTable1DataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn IZINTURUColumn => this.columnIZINTURU;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn IZINYILLARIColumn => this.columnIZINYILLARI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn IZINSURESIColumn => this.columnIZINSURESI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BASLANGICTARIHIColumn => this.columnBASLANGICTARIHI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BITISTARIHIColumn => this.columnBITISTARIHI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn IZINGUNSAYColumn => this.columnIZINGUNSAY;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn GOREVEBASTARIHColumn => this.columnGOREVEBASTARIH;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ADISOYADIColumn => this.columnADISOYADI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn UNVANColumn => this.columnUNVAN;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn KURUMGOREVColumn => this.columnKURUMGOREV;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn IDColumn => this.columnID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BASLANGICSAATIColumn => this.columnBASLANGICSAATI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BITISSAATIColumn => this.columnBITISSAATI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn IZINDEBULADRESColumn => this.columnIZINDEBULADRES;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ONAYTARIHColumn => this.columnONAYTARIH;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn IZINDURUMColumn => this.columnIZINDURUM;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn GOREVYERIColumn => this.columnGOREVYERI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BELDBIRIMADIColumn => this.columnBELDBIRIMADI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn Expr1Column => this.columnExpr1;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn Expr2Column => this.columnExpr2;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn Expr3Column => this.columnExpr3;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn TCKIMLIKNOColumn => this.columnTCKIMLIKNO;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn İSTİHDAMDURUMUColumn => this.columnİSTİHDAMDURUMU;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn SICILNOColumn => this.columnSICILNO;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public izinListesi.DataTable1Row this[int index] => (izinListesi.DataTable1Row) this.Rows[index];

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event izinListesi.DataTable1RowChangeEventHandler DataTable1RowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event izinListesi.DataTable1RowChangeEventHandler DataTable1RowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event izinListesi.DataTable1RowChangeEventHandler DataTable1RowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event izinListesi.DataTable1RowChangeEventHandler DataTable1RowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void AddDataTable1Row(izinListesi.DataTable1Row row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public izinListesi.DataTable1Row AddDataTable1Row(
        string IZINTURU,
        string IZINYILLARI,
        string IZINSURESI,
        string BASLANGICTARIHI,
        string BITISTARIHI,
        int IZINGUNSAY,
        string GOREVEBASTARIH,
        string ADISOYADI,
        string UNVAN,
        string KURUMGOREV,
        int ID,
        string BASLANGICSAATI,
        string BITISSAATI,
        string IZINDEBULADRES,
        string ONAYTARIH,
        string IZINDURUM,
        string GOREVYERI,
        string BELDBIRIMADI,
        string Expr1,
        string Expr2,
        string Expr3,
        string TCKIMLIKNO,
        string İSTİHDAMDURUMU,
        string SICILNO)
      {
        izinListesi.DataTable1Row row = (izinListesi.DataTable1Row) this.NewRow();
        object[] objArray = new object[24]
        {
          (object) IZINTURU,
          (object) IZINYILLARI,
          (object) IZINSURESI,
          (object) BASLANGICTARIHI,
          (object) BITISTARIHI,
          (object) IZINGUNSAY,
          (object) GOREVEBASTARIH,
          (object) ADISOYADI,
          (object) UNVAN,
          (object) KURUMGOREV,
          (object) ID,
          (object) BASLANGICSAATI,
          (object) BITISSAATI,
          (object) IZINDEBULADRES,
          (object) ONAYTARIH,
          (object) IZINDURUM,
          (object) GOREVYERI,
          (object) BELDBIRIMADI,
          (object) Expr1,
          (object) Expr2,
          (object) Expr3,
          (object) TCKIMLIKNO,
          (object) İSTİHDAMDURUMU,
          (object) SICILNO
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public override DataTable Clone()
      {
        izinListesi.DataTable1DataTable dataTable1DataTable = (izinListesi.DataTable1DataTable) base.Clone();
        dataTable1DataTable.InitVars();
        return (DataTable) dataTable1DataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataTable CreateInstance() => (DataTable) new izinListesi.DataTable1DataTable();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal void InitVars()
      {
        this.columnIZINTURU = this.Columns["IZINTURU"];
        this.columnIZINYILLARI = this.Columns["IZINYILLARI"];
        this.columnIZINSURESI = this.Columns["IZINSURESI"];
        this.columnBASLANGICTARIHI = this.Columns["BASLANGICTARIHI"];
        this.columnBITISTARIHI = this.Columns["BITISTARIHI"];
        this.columnIZINGUNSAY = this.Columns["IZINGUNSAY"];
        this.columnGOREVEBASTARIH = this.Columns["GOREVEBASTARIH"];
        this.columnADISOYADI = this.Columns["ADISOYADI"];
        this.columnUNVAN = this.Columns["UNVAN"];
        this.columnKURUMGOREV = this.Columns["KURUMGOREV"];
        this.columnID = this.Columns["ID"];
        this.columnBASLANGICSAATI = this.Columns["BASLANGICSAATI"];
        this.columnBITISSAATI = this.Columns["BITISSAATI"];
        this.columnIZINDEBULADRES = this.Columns["IZINDEBULADRES"];
        this.columnONAYTARIH = this.Columns["ONAYTARIH"];
        this.columnIZINDURUM = this.Columns["IZINDURUM"];
        this.columnGOREVYERI = this.Columns["GOREVYERI"];
        this.columnBELDBIRIMADI = this.Columns["BELDBIRIMADI"];
        this.columnExpr1 = this.Columns["Expr1"];
        this.columnExpr2 = this.Columns["Expr2"];
        this.columnExpr3 = this.Columns["Expr3"];
        this.columnTCKIMLIKNO = this.Columns["TCKIMLIKNO"];
        this.columnİSTİHDAMDURUMU = this.Columns["İSTİHDAMDURUMU"];
        this.columnSICILNO = this.Columns["SICILNO"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      private void InitClass()
      {
        this.columnIZINTURU = new DataColumn("IZINTURU", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnIZINTURU);
        this.columnIZINYILLARI = new DataColumn("IZINYILLARI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnIZINYILLARI);
        this.columnIZINSURESI = new DataColumn("IZINSURESI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnIZINSURESI);
        this.columnBASLANGICTARIHI = new DataColumn("BASLANGICTARIHI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBASLANGICTARIHI);
        this.columnBITISTARIHI = new DataColumn("BITISTARIHI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBITISTARIHI);
        this.columnIZINGUNSAY = new DataColumn("IZINGUNSAY", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnIZINGUNSAY);
        this.columnGOREVEBASTARIH = new DataColumn("GOREVEBASTARIH", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGOREVEBASTARIH);
        this.columnADISOYADI = new DataColumn("ADISOYADI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnADISOYADI);
        this.columnUNVAN = new DataColumn("UNVAN", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnUNVAN);
        this.columnKURUMGOREV = new DataColumn("KURUMGOREV", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnKURUMGOREV);
        this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnID);
        this.columnBASLANGICSAATI = new DataColumn("BASLANGICSAATI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBASLANGICSAATI);
        this.columnBITISSAATI = new DataColumn("BITISSAATI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBITISSAATI);
        this.columnIZINDEBULADRES = new DataColumn("IZINDEBULADRES", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnIZINDEBULADRES);
        this.columnONAYTARIH = new DataColumn("ONAYTARIH", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnONAYTARIH);
        this.columnIZINDURUM = new DataColumn("IZINDURUM", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnIZINDURUM);
        this.columnGOREVYERI = new DataColumn("GOREVYERI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGOREVYERI);
        this.columnBELDBIRIMADI = new DataColumn("BELDBIRIMADI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBELDBIRIMADI);
        this.columnExpr1 = new DataColumn("Expr1", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnExpr1);
        this.columnExpr2 = new DataColumn("Expr2", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnExpr2);
        this.columnExpr3 = new DataColumn("Expr3", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnExpr3);
        this.columnTCKIMLIKNO = new DataColumn("TCKIMLIKNO", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTCKIMLIKNO);
        this.columnİSTİHDAMDURUMU = new DataColumn("İSTİHDAMDURUMU", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnİSTİHDAMDURUMU);
        this.columnSICILNO = new DataColumn("SICILNO", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSICILNO);
        this.columnIZINTURU.MaxLength = 10;
        this.columnIZINYILLARI.MaxLength = 16;
        this.columnIZINSURESI.MaxLength = 50;
        this.columnBASLANGICTARIHI.MaxLength = 19;
        this.columnBITISTARIHI.MaxLength = 19;
        this.columnGOREVEBASTARIH.MaxLength = 19;
        this.columnADISOYADI.MaxLength = 50;
        this.columnUNVAN.MaxLength = 25;
        this.columnKURUMGOREV.MaxLength = 41;
        this.columnBASLANGICSAATI.MaxLength = 20;
        this.columnBITISSAATI.MaxLength = 20;
        this.columnIZINDEBULADRES.MaxLength = 72;
        this.columnONAYTARIH.MaxLength = 19;
        this.columnIZINDURUM.MaxLength = 6;
        this.columnGOREVYERI.MaxLength = 28;
        this.columnBELDBIRIMADI.MaxLength = 43;
        this.columnExpr1.MaxLength = 50;
        this.columnExpr2.MaxLength = 50;
        this.columnExpr3.MaxLength = 50;
        this.columnTCKIMLIKNO.MaxLength = 12;
        this.columnİSTİHDAMDURUMU.ReadOnly = true;
        this.columnİSTİHDAMDURUMU.MaxLength = 13;
        this.columnSICILNO.MaxLength = 13;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public izinListesi.DataTable1Row NewDataTable1Row() => (izinListesi.DataTable1Row) this.NewRow();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new izinListesi.DataTable1Row(builder);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override Type GetRowType() => typeof (izinListesi.DataTable1Row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.DataTable1RowChanged == null)
          return;
        this.DataTable1RowChanged((object) this, new izinListesi.DataTable1RowChangeEvent((izinListesi.DataTable1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.DataTable1RowChanging == null)
          return;
        this.DataTable1RowChanging((object) this, new izinListesi.DataTable1RowChangeEvent((izinListesi.DataTable1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.DataTable1RowDeleted == null)
          return;
        this.DataTable1RowDeleted((object) this, new izinListesi.DataTable1RowChangeEvent((izinListesi.DataTable1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.DataTable1RowDeleting == null)
          return;
        this.DataTable1RowDeleting((object) this, new izinListesi.DataTable1RowChangeEvent((izinListesi.DataTable1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void RemoveDataTable1Row(izinListesi.DataTable1Row row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        izinListesi izinListesi = new izinListesi();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        xmlSchemaAny1.MinOccurs = 0M;
        xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
        xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
        XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
        xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        xmlSchemaAny2.MinOccurs = 1M;
        xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "namespace",
          FixedValue = izinListesi.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (DataTable1DataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = izinListesi.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
            while (enumerator.MoveNext())
            {
              XmlSchema current = (XmlSchema) enumerator.Current;
              memoryStream2.SetLength(0L);
              current.Write((Stream) memoryStream2);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return typedTableSchema;
              }
            }
          }
          finally
          {
            memoryStream1?.Close();
            memoryStream2?.Close();
          }
        }
        xs.Add(schemaSerializable);
        return typedTableSchema;
      }
    }

    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class DataTable2DataTable : TypedTableBase<izinListesi.DataTable2Row>
    {
      private DataColumn columnID;
      private DataColumn columnADISOYADI;
      private DataColumn columnIZINTURU;
      private DataColumn columnIZINYILLARI;
      private DataColumn columnIZINSURESI;
      private DataColumn columnBASLANGICTARIHI;
      private DataColumn columnBASLANGICSAATI;
      private DataColumn columnBITISTARIHI;
      private DataColumn columnBITISSAATI;
      private DataColumn columnIZINGUNSAY;
      private DataColumn columnGOREVEBASTARIH;
      private DataColumn columnIZINDEBULADRES;
      private DataColumn columnONAYTARIH;
      private DataColumn columnIZINDURUM;
      private DataColumn columnGOREVYERI;
      private DataColumn columnUNVAN;
      private DataColumn columnKURUMGOREV;
      private DataColumn columnBELDBIRIMADI;
      private DataColumn columnExpr1;
      private DataColumn columnExpr2;
      private DataColumn columnExpr3;
      private DataColumn columnTBLPERSONEL_RESIM2;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataTable2DataTable()
      {
        this.TableName = "DataTable2";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal DataTable2DataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected DataTable2DataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn IDColumn => this.columnID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ADISOYADIColumn => this.columnADISOYADI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn IZINTURUColumn => this.columnIZINTURU;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn IZINYILLARIColumn => this.columnIZINYILLARI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn IZINSURESIColumn => this.columnIZINSURESI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BASLANGICTARIHIColumn => this.columnBASLANGICTARIHI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BASLANGICSAATIColumn => this.columnBASLANGICSAATI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BITISTARIHIColumn => this.columnBITISTARIHI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BITISSAATIColumn => this.columnBITISSAATI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn IZINGUNSAYColumn => this.columnIZINGUNSAY;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn GOREVEBASTARIHColumn => this.columnGOREVEBASTARIH;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn IZINDEBULADRESColumn => this.columnIZINDEBULADRES;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ONAYTARIHColumn => this.columnONAYTARIH;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn IZINDURUMColumn => this.columnIZINDURUM;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn GOREVYERIColumn => this.columnGOREVYERI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn UNVANColumn => this.columnUNVAN;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn KURUMGOREVColumn => this.columnKURUMGOREV;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BELDBIRIMADIColumn => this.columnBELDBIRIMADI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn Expr1Column => this.columnExpr1;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn Expr2Column => this.columnExpr2;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn Expr3Column => this.columnExpr3;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn TBLPERSONEL_RESIM2Column => this.columnTBLPERSONEL_RESIM2;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public izinListesi.DataTable2Row this[int index] => (izinListesi.DataTable2Row) this.Rows[index];

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event izinListesi.DataTable2RowChangeEventHandler DataTable2RowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event izinListesi.DataTable2RowChangeEventHandler DataTable2RowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event izinListesi.DataTable2RowChangeEventHandler DataTable2RowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event izinListesi.DataTable2RowChangeEventHandler DataTable2RowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void AddDataTable2Row(izinListesi.DataTable2Row row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public izinListesi.DataTable2Row AddDataTable2Row(
        int ID,
        string ADISOYADI,
        string IZINTURU,
        string IZINYILLARI,
        string IZINSURESI,
        string BASLANGICTARIHI,
        string BASLANGICSAATI,
        string BITISTARIHI,
        string BITISSAATI,
        int IZINGUNSAY,
        string GOREVEBASTARIH,
        string IZINDEBULADRES,
        string ONAYTARIH,
        string IZINDURUM,
        string GOREVYERI,
        string UNVAN,
        string KURUMGOREV,
        string BELDBIRIMADI,
        string Expr1,
        string Expr2,
        string Expr3,
        byte[] TBLPERSONEL_RESIM2)
      {
        izinListesi.DataTable2Row row = (izinListesi.DataTable2Row) this.NewRow();
        object[] objArray = new object[22]
        {
          (object) ID,
          (object) ADISOYADI,
          (object) IZINTURU,
          (object) IZINYILLARI,
          (object) IZINSURESI,
          (object) BASLANGICTARIHI,
          (object) BASLANGICSAATI,
          (object) BITISTARIHI,
          (object) BITISSAATI,
          (object) IZINGUNSAY,
          (object) GOREVEBASTARIH,
          (object) IZINDEBULADRES,
          (object) ONAYTARIH,
          (object) IZINDURUM,
          (object) GOREVYERI,
          (object) UNVAN,
          (object) KURUMGOREV,
          (object) BELDBIRIMADI,
          (object) Expr1,
          (object) Expr2,
          (object) Expr3,
          (object) TBLPERSONEL_RESIM2
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public override DataTable Clone()
      {
        izinListesi.DataTable2DataTable dataTable2DataTable = (izinListesi.DataTable2DataTable) base.Clone();
        dataTable2DataTable.InitVars();
        return (DataTable) dataTable2DataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataTable CreateInstance() => (DataTable) new izinListesi.DataTable2DataTable();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal void InitVars()
      {
        this.columnID = this.Columns["ID"];
        this.columnADISOYADI = this.Columns["ADISOYADI"];
        this.columnIZINTURU = this.Columns["IZINTURU"];
        this.columnIZINYILLARI = this.Columns["IZINYILLARI"];
        this.columnIZINSURESI = this.Columns["IZINSURESI"];
        this.columnBASLANGICTARIHI = this.Columns["BASLANGICTARIHI"];
        this.columnBASLANGICSAATI = this.Columns["BASLANGICSAATI"];
        this.columnBITISTARIHI = this.Columns["BITISTARIHI"];
        this.columnBITISSAATI = this.Columns["BITISSAATI"];
        this.columnIZINGUNSAY = this.Columns["IZINGUNSAY"];
        this.columnGOREVEBASTARIH = this.Columns["GOREVEBASTARIH"];
        this.columnIZINDEBULADRES = this.Columns["IZINDEBULADRES"];
        this.columnONAYTARIH = this.Columns["ONAYTARIH"];
        this.columnIZINDURUM = this.Columns["IZINDURUM"];
        this.columnGOREVYERI = this.Columns["GOREVYERI"];
        this.columnUNVAN = this.Columns["UNVAN"];
        this.columnKURUMGOREV = this.Columns["KURUMGOREV"];
        this.columnBELDBIRIMADI = this.Columns["BELDBIRIMADI"];
        this.columnExpr1 = this.Columns["Expr1"];
        this.columnExpr2 = this.Columns["Expr2"];
        this.columnExpr3 = this.Columns["Expr3"];
        this.columnTBLPERSONEL_RESIM2 = this.Columns["TBLPERSONEL_RESIM2"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      private void InitClass()
      {
        this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnID);
        this.columnADISOYADI = new DataColumn("ADISOYADI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnADISOYADI);
        this.columnIZINTURU = new DataColumn("IZINTURU", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnIZINTURU);
        this.columnIZINYILLARI = new DataColumn("IZINYILLARI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnIZINYILLARI);
        this.columnIZINSURESI = new DataColumn("IZINSURESI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnIZINSURESI);
        this.columnBASLANGICTARIHI = new DataColumn("BASLANGICTARIHI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBASLANGICTARIHI);
        this.columnBASLANGICSAATI = new DataColumn("BASLANGICSAATI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBASLANGICSAATI);
        this.columnBITISTARIHI = new DataColumn("BITISTARIHI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBITISTARIHI);
        this.columnBITISSAATI = new DataColumn("BITISSAATI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBITISSAATI);
        this.columnIZINGUNSAY = new DataColumn("IZINGUNSAY", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnIZINGUNSAY);
        this.columnGOREVEBASTARIH = new DataColumn("GOREVEBASTARIH", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGOREVEBASTARIH);
        this.columnIZINDEBULADRES = new DataColumn("IZINDEBULADRES", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnIZINDEBULADRES);
        this.columnONAYTARIH = new DataColumn("ONAYTARIH", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnONAYTARIH);
        this.columnIZINDURUM = new DataColumn("IZINDURUM", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnIZINDURUM);
        this.columnGOREVYERI = new DataColumn("GOREVYERI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGOREVYERI);
        this.columnUNVAN = new DataColumn("UNVAN", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnUNVAN);
        this.columnKURUMGOREV = new DataColumn("KURUMGOREV", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnKURUMGOREV);
        this.columnBELDBIRIMADI = new DataColumn("BELDBIRIMADI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBELDBIRIMADI);
        this.columnExpr1 = new DataColumn("Expr1", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnExpr1);
        this.columnExpr2 = new DataColumn("Expr2", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnExpr2);
        this.columnExpr3 = new DataColumn("Expr3", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnExpr3);
        this.columnTBLPERSONEL_RESIM2 = new DataColumn("TBLPERSONEL_RESIM2", typeof (byte[]), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTBLPERSONEL_RESIM2);
        this.columnADISOYADI.MaxLength = 50;
        this.columnIZINTURU.MaxLength = 10;
        this.columnIZINYILLARI.MaxLength = 16;
        this.columnIZINSURESI.MaxLength = 50;
        this.columnBASLANGICTARIHI.MaxLength = 19;
        this.columnBASLANGICSAATI.MaxLength = 20;
        this.columnBITISTARIHI.MaxLength = 19;
        this.columnBITISSAATI.MaxLength = 20;
        this.columnGOREVEBASTARIH.MaxLength = 19;
        this.columnIZINDEBULADRES.MaxLength = 72;
        this.columnONAYTARIH.MaxLength = 19;
        this.columnIZINDURUM.MaxLength = 6;
        this.columnGOREVYERI.MaxLength = 28;
        this.columnUNVAN.MaxLength = 25;
        this.columnKURUMGOREV.MaxLength = 41;
        this.columnBELDBIRIMADI.MaxLength = 43;
        this.columnExpr1.MaxLength = 50;
        this.columnExpr2.MaxLength = 50;
        this.columnExpr3.MaxLength = 50;
        this.columnTBLPERSONEL_RESIM2.ReadOnly = true;
        this.columnTBLPERSONEL_RESIM2.Caption = "TBLPERSONEL.RESIM2";
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public izinListesi.DataTable2Row NewDataTable2Row() => (izinListesi.DataTable2Row) this.NewRow();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new izinListesi.DataTable2Row(builder);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override Type GetRowType() => typeof (izinListesi.DataTable2Row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.DataTable2RowChanged == null)
          return;
        this.DataTable2RowChanged((object) this, new izinListesi.DataTable2RowChangeEvent((izinListesi.DataTable2Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.DataTable2RowChanging == null)
          return;
        this.DataTable2RowChanging((object) this, new izinListesi.DataTable2RowChangeEvent((izinListesi.DataTable2Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.DataTable2RowDeleted == null)
          return;
        this.DataTable2RowDeleted((object) this, new izinListesi.DataTable2RowChangeEvent((izinListesi.DataTable2Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.DataTable2RowDeleting == null)
          return;
        this.DataTable2RowDeleting((object) this, new izinListesi.DataTable2RowChangeEvent((izinListesi.DataTable2Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void RemoveDataTable2Row(izinListesi.DataTable2Row row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        izinListesi izinListesi = new izinListesi();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        xmlSchemaAny1.MinOccurs = 0M;
        xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
        xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
        XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
        xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        xmlSchemaAny2.MinOccurs = 1M;
        xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "namespace",
          FixedValue = izinListesi.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (DataTable2DataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = izinListesi.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
            while (enumerator.MoveNext())
            {
              XmlSchema current = (XmlSchema) enumerator.Current;
              memoryStream2.SetLength(0L);
              current.Write((Stream) memoryStream2);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return typedTableSchema;
              }
            }
          }
          finally
          {
            memoryStream1?.Close();
            memoryStream2?.Close();
          }
        }
        xs.Add(schemaSerializable);
        return typedTableSchema;
      }
    }

    public class DataTable1Row : DataRow
    {
      private izinListesi.DataTable1DataTable tableDataTable1;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal DataTable1Row(DataRowBuilder rb)
        : base(rb)
      {
        this.tableDataTable1 = (izinListesi.DataTable1DataTable) this.Table;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string IZINTURU
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.IZINTURUColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'IZINTURU' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.IZINTURUColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string IZINYILLARI
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.IZINYILLARIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'IZINYILLARI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.IZINYILLARIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string IZINSURESI
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.IZINSURESIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'IZINSURESI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.IZINSURESIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BASLANGICTARIHI
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.BASLANGICTARIHIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'BASLANGICTARIHI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.BASLANGICTARIHIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BITISTARIHI
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.BITISTARIHIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'BITISTARIHI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.BITISTARIHIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int IZINGUNSAY
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable1.IZINGUNSAYColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'IZINGUNSAY' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.IZINGUNSAYColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string GOREVEBASTARIH
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.GOREVEBASTARIHColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'GOREVEBASTARIH' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.GOREVEBASTARIHColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string ADISOYADI
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.ADISOYADIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'ADISOYADI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.ADISOYADIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string UNVAN
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.UNVANColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'UNVAN' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.UNVANColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string KURUMGOREV
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.KURUMGOREVColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'KURUMGOREV' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.KURUMGOREVColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ID
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable1.IDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'ID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.IDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BASLANGICSAATI
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.BASLANGICSAATIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'BASLANGICSAATI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.BASLANGICSAATIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BITISSAATI
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.BITISSAATIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'BITISSAATI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.BITISSAATIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string IZINDEBULADRES
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.IZINDEBULADRESColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'IZINDEBULADRES' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.IZINDEBULADRESColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string ONAYTARIH
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.ONAYTARIHColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'ONAYTARIH' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.ONAYTARIHColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string IZINDURUM
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.IZINDURUMColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'IZINDURUM' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.IZINDURUMColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string GOREVYERI
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.GOREVYERIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'GOREVYERI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.GOREVYERIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BELDBIRIMADI
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.BELDBIRIMADIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'BELDBIRIMADI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.BELDBIRIMADIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string Expr1
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.Expr1Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'Expr1' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.Expr1Column] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string Expr2
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.Expr2Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'Expr2' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.Expr2Column] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string Expr3
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.Expr3Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'Expr3' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.Expr3Column] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string TCKIMLIKNO
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.TCKIMLIKNOColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'TCKIMLIKNO' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.TCKIMLIKNOColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string İSTİHDAMDURUMU
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.İSTİHDAMDURUMUColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'İSTİHDAMDURUMU' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.İSTİHDAMDURUMUColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string SICILNO
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.SICILNOColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'SICILNO' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.SICILNOColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsIZINTURUNull() => this.IsNull(this.tableDataTable1.IZINTURUColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetIZINTURUNull() => this[this.tableDataTable1.IZINTURUColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsIZINYILLARINull() => this.IsNull(this.tableDataTable1.IZINYILLARIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetIZINYILLARINull() => this[this.tableDataTable1.IZINYILLARIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsIZINSURESINull() => this.IsNull(this.tableDataTable1.IZINSURESIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetIZINSURESINull() => this[this.tableDataTable1.IZINSURESIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBASLANGICTARIHINull() => this.IsNull(this.tableDataTable1.BASLANGICTARIHIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBASLANGICTARIHINull() => this[this.tableDataTable1.BASLANGICTARIHIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBITISTARIHINull() => this.IsNull(this.tableDataTable1.BITISTARIHIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBITISTARIHINull() => this[this.tableDataTable1.BITISTARIHIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsIZINGUNSAYNull() => this.IsNull(this.tableDataTable1.IZINGUNSAYColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetIZINGUNSAYNull() => this[this.tableDataTable1.IZINGUNSAYColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsGOREVEBASTARIHNull() => this.IsNull(this.tableDataTable1.GOREVEBASTARIHColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetGOREVEBASTARIHNull() => this[this.tableDataTable1.GOREVEBASTARIHColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsADISOYADINull() => this.IsNull(this.tableDataTable1.ADISOYADIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetADISOYADINull() => this[this.tableDataTable1.ADISOYADIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsUNVANNull() => this.IsNull(this.tableDataTable1.UNVANColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetUNVANNull() => this[this.tableDataTable1.UNVANColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsKURUMGOREVNull() => this.IsNull(this.tableDataTable1.KURUMGOREVColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetKURUMGOREVNull() => this[this.tableDataTable1.KURUMGOREVColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsIDNull() => this.IsNull(this.tableDataTable1.IDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetIDNull() => this[this.tableDataTable1.IDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBASLANGICSAATINull() => this.IsNull(this.tableDataTable1.BASLANGICSAATIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBASLANGICSAATINull() => this[this.tableDataTable1.BASLANGICSAATIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBITISSAATINull() => this.IsNull(this.tableDataTable1.BITISSAATIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBITISSAATINull() => this[this.tableDataTable1.BITISSAATIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsIZINDEBULADRESNull() => this.IsNull(this.tableDataTable1.IZINDEBULADRESColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetIZINDEBULADRESNull() => this[this.tableDataTable1.IZINDEBULADRESColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsONAYTARIHNull() => this.IsNull(this.tableDataTable1.ONAYTARIHColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetONAYTARIHNull() => this[this.tableDataTable1.ONAYTARIHColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsIZINDURUMNull() => this.IsNull(this.tableDataTable1.IZINDURUMColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetIZINDURUMNull() => this[this.tableDataTable1.IZINDURUMColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsGOREVYERINull() => this.IsNull(this.tableDataTable1.GOREVYERIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetGOREVYERINull() => this[this.tableDataTable1.GOREVYERIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBELDBIRIMADINull() => this.IsNull(this.tableDataTable1.BELDBIRIMADIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBELDBIRIMADINull() => this[this.tableDataTable1.BELDBIRIMADIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsExpr1Null() => this.IsNull(this.tableDataTable1.Expr1Column);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetExpr1Null() => this[this.tableDataTable1.Expr1Column] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsExpr2Null() => this.IsNull(this.tableDataTable1.Expr2Column);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetExpr2Null() => this[this.tableDataTable1.Expr2Column] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsExpr3Null() => this.IsNull(this.tableDataTable1.Expr3Column);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetExpr3Null() => this[this.tableDataTable1.Expr3Column] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsTCKIMLIKNONull() => this.IsNull(this.tableDataTable1.TCKIMLIKNOColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetTCKIMLIKNONull() => this[this.tableDataTable1.TCKIMLIKNOColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsİSTİHDAMDURUMUNull() => this.IsNull(this.tableDataTable1.İSTİHDAMDURUMUColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetİSTİHDAMDURUMUNull() => this[this.tableDataTable1.İSTİHDAMDURUMUColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsSICILNONull() => this.IsNull(this.tableDataTable1.SICILNOColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetSICILNONull() => this[this.tableDataTable1.SICILNOColumn] = Convert.DBNull;
    }

    public class DataTable2Row : DataRow
    {
      private izinListesi.DataTable2DataTable tableDataTable2;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal DataTable2Row(DataRowBuilder rb)
        : base(rb)
      {
        this.tableDataTable2 = (izinListesi.DataTable2DataTable) this.Table;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ID
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable2.IDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable2' tablosundaki 'ID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable2.IDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string ADISOYADI
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable2.ADISOYADIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable2' tablosundaki 'ADISOYADI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable2.ADISOYADIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string IZINTURU
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable2.IZINTURUColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable2' tablosundaki 'IZINTURU' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable2.IZINTURUColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string IZINYILLARI
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable2.IZINYILLARIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable2' tablosundaki 'IZINYILLARI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable2.IZINYILLARIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string IZINSURESI
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable2.IZINSURESIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable2' tablosundaki 'IZINSURESI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable2.IZINSURESIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BASLANGICTARIHI
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable2.BASLANGICTARIHIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable2' tablosundaki 'BASLANGICTARIHI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable2.BASLANGICTARIHIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BASLANGICSAATI
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable2.BASLANGICSAATIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable2' tablosundaki 'BASLANGICSAATI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable2.BASLANGICSAATIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BITISTARIHI
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable2.BITISTARIHIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable2' tablosundaki 'BITISTARIHI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable2.BITISTARIHIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BITISSAATI
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable2.BITISSAATIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable2' tablosundaki 'BITISSAATI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable2.BITISSAATIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int IZINGUNSAY
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable2.IZINGUNSAYColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable2' tablosundaki 'IZINGUNSAY' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable2.IZINGUNSAYColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string GOREVEBASTARIH
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable2.GOREVEBASTARIHColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable2' tablosundaki 'GOREVEBASTARIH' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable2.GOREVEBASTARIHColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string IZINDEBULADRES
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable2.IZINDEBULADRESColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable2' tablosundaki 'IZINDEBULADRES' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable2.IZINDEBULADRESColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string ONAYTARIH
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable2.ONAYTARIHColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable2' tablosundaki 'ONAYTARIH' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable2.ONAYTARIHColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string IZINDURUM
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable2.IZINDURUMColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable2' tablosundaki 'IZINDURUM' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable2.IZINDURUMColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string GOREVYERI
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable2.GOREVYERIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable2' tablosundaki 'GOREVYERI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable2.GOREVYERIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string UNVAN
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable2.UNVANColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable2' tablosundaki 'UNVAN' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable2.UNVANColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string KURUMGOREV
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable2.KURUMGOREVColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable2' tablosundaki 'KURUMGOREV' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable2.KURUMGOREVColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BELDBIRIMADI
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable2.BELDBIRIMADIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable2' tablosundaki 'BELDBIRIMADI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable2.BELDBIRIMADIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string Expr1
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable2.Expr1Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable2' tablosundaki 'Expr1' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable2.Expr1Column] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string Expr2
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable2.Expr2Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable2' tablosundaki 'Expr2' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable2.Expr2Column] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string Expr3
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable2.Expr3Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable2' tablosundaki 'Expr3' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable2.Expr3Column] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public byte[] TBLPERSONEL_RESIM2
      {
        get
        {
          try
          {
            return (byte[]) this[this.tableDataTable2.TBLPERSONEL_RESIM2Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable2' tablosundaki 'TBLPERSONEL_RESIM2' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable2.TBLPERSONEL_RESIM2Column] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsIDNull() => this.IsNull(this.tableDataTable2.IDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetIDNull() => this[this.tableDataTable2.IDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsADISOYADINull() => this.IsNull(this.tableDataTable2.ADISOYADIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetADISOYADINull() => this[this.tableDataTable2.ADISOYADIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsIZINTURUNull() => this.IsNull(this.tableDataTable2.IZINTURUColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetIZINTURUNull() => this[this.tableDataTable2.IZINTURUColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsIZINYILLARINull() => this.IsNull(this.tableDataTable2.IZINYILLARIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetIZINYILLARINull() => this[this.tableDataTable2.IZINYILLARIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsIZINSURESINull() => this.IsNull(this.tableDataTable2.IZINSURESIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetIZINSURESINull() => this[this.tableDataTable2.IZINSURESIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBASLANGICTARIHINull() => this.IsNull(this.tableDataTable2.BASLANGICTARIHIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBASLANGICTARIHINull() => this[this.tableDataTable2.BASLANGICTARIHIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBASLANGICSAATINull() => this.IsNull(this.tableDataTable2.BASLANGICSAATIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBASLANGICSAATINull() => this[this.tableDataTable2.BASLANGICSAATIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBITISTARIHINull() => this.IsNull(this.tableDataTable2.BITISTARIHIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBITISTARIHINull() => this[this.tableDataTable2.BITISTARIHIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBITISSAATINull() => this.IsNull(this.tableDataTable2.BITISSAATIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBITISSAATINull() => this[this.tableDataTable2.BITISSAATIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsIZINGUNSAYNull() => this.IsNull(this.tableDataTable2.IZINGUNSAYColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetIZINGUNSAYNull() => this[this.tableDataTable2.IZINGUNSAYColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsGOREVEBASTARIHNull() => this.IsNull(this.tableDataTable2.GOREVEBASTARIHColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetGOREVEBASTARIHNull() => this[this.tableDataTable2.GOREVEBASTARIHColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsIZINDEBULADRESNull() => this.IsNull(this.tableDataTable2.IZINDEBULADRESColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetIZINDEBULADRESNull() => this[this.tableDataTable2.IZINDEBULADRESColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsONAYTARIHNull() => this.IsNull(this.tableDataTable2.ONAYTARIHColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetONAYTARIHNull() => this[this.tableDataTable2.ONAYTARIHColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsIZINDURUMNull() => this.IsNull(this.tableDataTable2.IZINDURUMColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetIZINDURUMNull() => this[this.tableDataTable2.IZINDURUMColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsGOREVYERINull() => this.IsNull(this.tableDataTable2.GOREVYERIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetGOREVYERINull() => this[this.tableDataTable2.GOREVYERIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsUNVANNull() => this.IsNull(this.tableDataTable2.UNVANColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetUNVANNull() => this[this.tableDataTable2.UNVANColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsKURUMGOREVNull() => this.IsNull(this.tableDataTable2.KURUMGOREVColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetKURUMGOREVNull() => this[this.tableDataTable2.KURUMGOREVColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBELDBIRIMADINull() => this.IsNull(this.tableDataTable2.BELDBIRIMADIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBELDBIRIMADINull() => this[this.tableDataTable2.BELDBIRIMADIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsExpr1Null() => this.IsNull(this.tableDataTable2.Expr1Column);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetExpr1Null() => this[this.tableDataTable2.Expr1Column] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsExpr2Null() => this.IsNull(this.tableDataTable2.Expr2Column);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetExpr2Null() => this[this.tableDataTable2.Expr2Column] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsExpr3Null() => this.IsNull(this.tableDataTable2.Expr3Column);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetExpr3Null() => this[this.tableDataTable2.Expr3Column] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsTBLPERSONEL_RESIM2Null() => this.IsNull(this.tableDataTable2.TBLPERSONEL_RESIM2Column);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetTBLPERSONEL_RESIM2Null() => this[this.tableDataTable2.TBLPERSONEL_RESIM2Column] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public class DataTable1RowChangeEvent : EventArgs
    {
      private izinListesi.DataTable1Row eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataTable1RowChangeEvent(izinListesi.DataTable1Row row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public izinListesi.DataTable1Row Row => this.eventRow;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public class DataTable2RowChangeEvent : EventArgs
    {
      private izinListesi.DataTable2Row eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataTable2RowChangeEvent(izinListesi.DataTable2Row row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public izinListesi.DataTable2Row Row => this.eventRow;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataRowAction Action => this.eventAction;
    }
  }
}
