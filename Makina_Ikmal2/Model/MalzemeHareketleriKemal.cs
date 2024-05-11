// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Model.MalzemeHareketleriKemal
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
  [XmlRoot("MalzemeHareketleriKemal")]
  [HelpKeyword("vs.data.DataSet")]
  [Serializable]
  public class MalzemeHareketleriKemal : DataSet
  {
    private MalzemeHareketleriKemal.DataTable1DataTable tableDataTable1;
    private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public MalzemeHareketleriKemal()
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
    protected MalzemeHareketleriKemal(SerializationInfo info, StreamingContext context)
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
            base.Tables.Add((DataTable) new MalzemeHareketleriKemal.DataTable1DataTable(dataSet.Tables[nameof (DataTable1)]));
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
    public MalzemeHareketleriKemal.DataTable1DataTable DataTable1 => this.tableDataTable1;

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
      MalzemeHareketleriKemal hareketleriKemal = (MalzemeHareketleriKemal) base.Clone();
      hareketleriKemal.InitVars();
      hareketleriKemal.SchemaSerializationMode = this.SchemaSerializationMode;
      return (DataSet) hareketleriKemal;
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
          base.Tables.Add((DataTable) new MalzemeHareketleriKemal.DataTable1DataTable(dataSet.Tables["DataTable1"]));
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
      this.tableDataTable1 = (MalzemeHareketleriKemal.DataTable1DataTable) base.Tables["DataTable1"];
      if (!initTable || this.tableDataTable1 == null)
        return;
      this.tableDataTable1.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.DataSetName = nameof (MalzemeHareketleriKemal);
      this.Prefix = "";
      this.Namespace = "http://tempuri.org/MalzemeHareketleriKemal.xsd";
      this.EnforceConstraints = true;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tableDataTable1 = new MalzemeHareketleriKemal.DataTable1DataTable();
      base.Tables.Add((DataTable) this.tableDataTable1);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private bool ShouldSerializeDataTable1() => false;

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
      MalzemeHareketleriKemal hareketleriKemal = new MalzemeHareketleriKemal();
      XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
      {
        Namespace = hareketleriKemal.Namespace
      });
      typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = hareketleriKemal.GetSchemaSerializable();
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
      MalzemeHareketleriKemal.DataTable1RowChangeEvent e);

    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class DataTable1DataTable : TypedTableBase<MalzemeHareketleriKemal.DataTable1Row>
    {
      private DataColumn columnMalzeme_Marka;
      private DataColumn columnBelediye_Birim;
      private DataColumn columnFiş_Kod;
      private DataColumn columnTARIH;
      private DataColumn columnISLEMTIPIID;
      private DataColumn columnİşlem_Yeri;
      private DataColumn columnMalzeme_Adı;
      private DataColumn columnGIRISMIKTAR;
      private DataColumn columnCIKISMIKTAR;
      private DataColumn columnFIYAT;
      private DataColumn columnGIRISTUTAR;
      private DataColumn columnCIKISTUTAR;
      private DataColumn columnKDVORAN;
      private DataColumn columnKDVTUTAR;
      private DataColumn columnSATIRTUTAR;
      private DataColumn columnMALZSERINO;
      private DataColumn columnMALZURTTARIH;
      private DataColumn columnDEGISIMKMSI;
      private DataColumn columnSONRAKIDEGKM;
      private DataColumn columnDepo_Adı;
      private DataColumn columnALANUSTAID;
      private DataColumn columnFIRMAID;

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
      public DataColumn Malzeme_MarkaColumn => this.columnMalzeme_Marka;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn Belediye_BirimColumn => this.columnBelediye_Birim;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn Fiş_KodColumn => this.columnFiş_Kod;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn TARIHColumn => this.columnTARIH;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ISLEMTIPIIDColumn => this.columnISLEMTIPIID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn İşlem_YeriColumn => this.columnİşlem_Yeri;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn Malzeme_AdıColumn => this.columnMalzeme_Adı;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn GIRISMIKTARColumn => this.columnGIRISMIKTAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn CIKISMIKTARColumn => this.columnCIKISMIKTAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn FIYATColumn => this.columnFIYAT;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn GIRISTUTARColumn => this.columnGIRISTUTAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn CIKISTUTARColumn => this.columnCIKISTUTAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn KDVORANColumn => this.columnKDVORAN;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn KDVTUTARColumn => this.columnKDVTUTAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn SATIRTUTARColumn => this.columnSATIRTUTAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MALZSERINOColumn => this.columnMALZSERINO;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MALZURTTARIHColumn => this.columnMALZURTTARIH;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn DEGISIMKMSIColumn => this.columnDEGISIMKMSI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn SONRAKIDEGKMColumn => this.columnSONRAKIDEGKM;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn Depo_AdıColumn => this.columnDepo_Adı;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ALANUSTAIDColumn => this.columnALANUSTAID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn FIRMAIDColumn => this.columnFIRMAID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public MalzemeHareketleriKemal.DataTable1Row this[int index] => (MalzemeHareketleriKemal.DataTable1Row) this.Rows[index];

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event MalzemeHareketleriKemal.DataTable1RowChangeEventHandler DataTable1RowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event MalzemeHareketleriKemal.DataTable1RowChangeEventHandler DataTable1RowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event MalzemeHareketleriKemal.DataTable1RowChangeEventHandler DataTable1RowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event MalzemeHareketleriKemal.DataTable1RowChangeEventHandler DataTable1RowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void AddDataTable1Row(MalzemeHareketleriKemal.DataTable1Row row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public MalzemeHareketleriKemal.DataTable1Row AddDataTable1Row(
        int Malzeme_Marka,
        int Belediye_Birim,
        string Fiş_Kod,
        DateTime TARIH,
        string ISLEMTIPIID,
        int İşlem_Yeri,
        int Malzeme_Adı,
        string GIRISMIKTAR,
        string CIKISMIKTAR,
        Decimal FIYAT,
        Decimal GIRISTUTAR,
        Decimal CIKISTUTAR,
        string KDVORAN,
        Decimal KDVTUTAR,
        string SATIRTUTAR,
        string MALZSERINO,
        string MALZURTTARIH,
        string DEGISIMKMSI,
        string SONRAKIDEGKM,
        int Depo_Adı,
        int ALANUSTAID,
        int FIRMAID)
      {
        MalzemeHareketleriKemal.DataTable1Row row = (MalzemeHareketleriKemal.DataTable1Row) this.NewRow();
        object[] objArray = new object[22]
        {
          (object) Malzeme_Marka,
          (object) Belediye_Birim,
          (object) Fiş_Kod,
          (object) TARIH,
          (object) ISLEMTIPIID,
          (object) İşlem_Yeri,
          (object) Malzeme_Adı,
          (object) GIRISMIKTAR,
          (object) CIKISMIKTAR,
          (object) FIYAT,
          (object) GIRISTUTAR,
          (object) CIKISTUTAR,
          (object) KDVORAN,
          (object) KDVTUTAR,
          (object) SATIRTUTAR,
          (object) MALZSERINO,
          (object) MALZURTTARIH,
          (object) DEGISIMKMSI,
          (object) SONRAKIDEGKM,
          (object) Depo_Adı,
          (object) ALANUSTAID,
          (object) FIRMAID
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public override DataTable Clone()
      {
        MalzemeHareketleriKemal.DataTable1DataTable dataTable1DataTable = (MalzemeHareketleriKemal.DataTable1DataTable) base.Clone();
        dataTable1DataTable.InitVars();
        return (DataTable) dataTable1DataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataTable CreateInstance() => (DataTable) new MalzemeHareketleriKemal.DataTable1DataTable();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal void InitVars()
      {
        this.columnMalzeme_Marka = this.Columns["Malzeme Marka"];
        this.columnBelediye_Birim = this.Columns["Belediye Birim"];
        this.columnFiş_Kod = this.Columns["Fiş Kod"];
        this.columnTARIH = this.Columns["TARIH"];
        this.columnISLEMTIPIID = this.Columns["ISLEMTIPIID"];
        this.columnİşlem_Yeri = this.Columns["İşlem Yeri"];
        this.columnMalzeme_Adı = this.Columns["Malzeme Adı"];
        this.columnGIRISMIKTAR = this.Columns["GIRISMIKTAR"];
        this.columnCIKISMIKTAR = this.Columns["CIKISMIKTAR"];
        this.columnFIYAT = this.Columns["FIYAT"];
        this.columnGIRISTUTAR = this.Columns["GIRISTUTAR"];
        this.columnCIKISTUTAR = this.Columns["CIKISTUTAR"];
        this.columnKDVORAN = this.Columns["KDVORAN"];
        this.columnKDVTUTAR = this.Columns["KDVTUTAR"];
        this.columnSATIRTUTAR = this.Columns["SATIRTUTAR"];
        this.columnMALZSERINO = this.Columns["MALZSERINO"];
        this.columnMALZURTTARIH = this.Columns["MALZURTTARIH"];
        this.columnDEGISIMKMSI = this.Columns["DEGISIMKMSI"];
        this.columnSONRAKIDEGKM = this.Columns["SONRAKIDEGKM"];
        this.columnDepo_Adı = this.Columns["Depo Adı"];
        this.columnALANUSTAID = this.Columns["ALANUSTAID"];
        this.columnFIRMAID = this.Columns["FIRMAID"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      private void InitClass()
      {
        this.columnMalzeme_Marka = new DataColumn("Malzeme Marka", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMalzeme_Marka);
        this.columnBelediye_Birim = new DataColumn("Belediye Birim", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBelediye_Birim);
        this.columnFiş_Kod = new DataColumn("Fiş Kod", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnFiş_Kod);
        this.columnTARIH = new DataColumn("TARIH", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTARIH);
        this.columnISLEMTIPIID = new DataColumn("ISLEMTIPIID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnISLEMTIPIID);
        this.columnİşlem_Yeri = new DataColumn("İşlem Yeri", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnİşlem_Yeri);
        this.columnMalzeme_Adı = new DataColumn("Malzeme Adı", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMalzeme_Adı);
        this.columnGIRISMIKTAR = new DataColumn("GIRISMIKTAR", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGIRISMIKTAR);
        this.columnCIKISMIKTAR = new DataColumn("CIKISMIKTAR", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCIKISMIKTAR);
        this.columnFIYAT = new DataColumn("FIYAT", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnFIYAT);
        this.columnGIRISTUTAR = new DataColumn("GIRISTUTAR", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGIRISTUTAR);
        this.columnCIKISTUTAR = new DataColumn("CIKISTUTAR", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCIKISTUTAR);
        this.columnKDVORAN = new DataColumn("KDVORAN", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnKDVORAN);
        this.columnKDVTUTAR = new DataColumn("KDVTUTAR", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnKDVTUTAR);
        this.columnSATIRTUTAR = new DataColumn("SATIRTUTAR", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSATIRTUTAR);
        this.columnMALZSERINO = new DataColumn("MALZSERINO", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMALZSERINO);
        this.columnMALZURTTARIH = new DataColumn("MALZURTTARIH", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMALZURTTARIH);
        this.columnDEGISIMKMSI = new DataColumn("DEGISIMKMSI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDEGISIMKMSI);
        this.columnSONRAKIDEGKM = new DataColumn("SONRAKIDEGKM", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSONRAKIDEGKM);
        this.columnDepo_Adı = new DataColumn("Depo Adı", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDepo_Adı);
        this.columnALANUSTAID = new DataColumn("ALANUSTAID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnALANUSTAID);
        this.columnFIRMAID = new DataColumn("FIRMAID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnFIRMAID);
        this.columnFiş_Kod.MaxLength = 50;
        this.columnISLEMTIPIID.MaxLength = 50;
        this.columnGIRISMIKTAR.MaxLength = 50;
        this.columnCIKISMIKTAR.MaxLength = 50;
        this.columnKDVORAN.MaxLength = 50;
        this.columnSATIRTUTAR.MaxLength = 50;
        this.columnMALZSERINO.MaxLength = 50;
        this.columnMALZURTTARIH.MaxLength = 50;
        this.columnDEGISIMKMSI.MaxLength = 50;
        this.columnSONRAKIDEGKM.MaxLength = 50;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public MalzemeHareketleriKemal.DataTable1Row NewDataTable1Row() => (MalzemeHareketleriKemal.DataTable1Row) this.NewRow();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new MalzemeHareketleriKemal.DataTable1Row(builder);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override Type GetRowType() => typeof (MalzemeHareketleriKemal.DataTable1Row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.DataTable1RowChanged == null)
          return;
        this.DataTable1RowChanged((object) this, new MalzemeHareketleriKemal.DataTable1RowChangeEvent((MalzemeHareketleriKemal.DataTable1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.DataTable1RowChanging == null)
          return;
        this.DataTable1RowChanging((object) this, new MalzemeHareketleriKemal.DataTable1RowChangeEvent((MalzemeHareketleriKemal.DataTable1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.DataTable1RowDeleted == null)
          return;
        this.DataTable1RowDeleted((object) this, new MalzemeHareketleriKemal.DataTable1RowChangeEvent((MalzemeHareketleriKemal.DataTable1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.DataTable1RowDeleting == null)
          return;
        this.DataTable1RowDeleting((object) this, new MalzemeHareketleriKemal.DataTable1RowChangeEvent((MalzemeHareketleriKemal.DataTable1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void RemoveDataTable1Row(MalzemeHareketleriKemal.DataTable1Row row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        MalzemeHareketleriKemal hareketleriKemal = new MalzemeHareketleriKemal();
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
          FixedValue = hareketleriKemal.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (DataTable1DataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = hareketleriKemal.GetSchemaSerializable();
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
      private MalzemeHareketleriKemal.DataTable1DataTable tableDataTable1;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal DataTable1Row(DataRowBuilder rb)
        : base(rb)
      {
        this.tableDataTable1 = (MalzemeHareketleriKemal.DataTable1DataTable) this.Table;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int Malzeme_Marka
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable1.Malzeme_MarkaColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Malzeme Marka' in table 'DataTable1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.Malzeme_MarkaColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int Belediye_Birim
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable1.Belediye_BirimColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Belediye Birim' in table 'DataTable1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.Belediye_BirimColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string Fiş_Kod
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.Fiş_KodColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Fiş Kod' in table 'DataTable1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.Fiş_KodColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DateTime TARIH
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableDataTable1.TARIHColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'TARIH' in table 'DataTable1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.TARIHColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string ISLEMTIPIID
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.ISLEMTIPIIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'ISLEMTIPIID' in table 'DataTable1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.ISLEMTIPIIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int İşlem_Yeri
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable1.İşlem_YeriColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'İşlem Yeri' in table 'DataTable1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.İşlem_YeriColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int Malzeme_Adı
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable1.Malzeme_AdıColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Malzeme Adı' in table 'DataTable1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.Malzeme_AdıColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string GIRISMIKTAR
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.GIRISMIKTARColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'GIRISMIKTAR' in table 'DataTable1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.GIRISMIKTARColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string CIKISMIKTAR
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.CIKISMIKTARColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'CIKISMIKTAR' in table 'DataTable1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.CIKISMIKTARColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Decimal FIYAT
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableDataTable1.FIYATColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'FIYAT' in table 'DataTable1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.FIYATColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Decimal GIRISTUTAR
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableDataTable1.GIRISTUTARColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'GIRISTUTAR' in table 'DataTable1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.GIRISTUTARColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Decimal CIKISTUTAR
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableDataTable1.CIKISTUTARColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'CIKISTUTAR' in table 'DataTable1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.CIKISTUTARColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string KDVORAN
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.KDVORANColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'KDVORAN' in table 'DataTable1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.KDVORANColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Decimal KDVTUTAR
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableDataTable1.KDVTUTARColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'KDVTUTAR' in table 'DataTable1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.KDVTUTARColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string SATIRTUTAR
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.SATIRTUTARColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'SATIRTUTAR' in table 'DataTable1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.SATIRTUTARColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string MALZSERINO
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.MALZSERINOColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'MALZSERINO' in table 'DataTable1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.MALZSERINOColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string MALZURTTARIH
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.MALZURTTARIHColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'MALZURTTARIH' in table 'DataTable1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.MALZURTTARIHColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string DEGISIMKMSI
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.DEGISIMKMSIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'DEGISIMKMSI' in table 'DataTable1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.DEGISIMKMSIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string SONRAKIDEGKM
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.SONRAKIDEGKMColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'SONRAKIDEGKM' in table 'DataTable1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.SONRAKIDEGKMColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int Depo_Adı
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable1.Depo_AdıColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Depo Adı' in table 'DataTable1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.Depo_AdıColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ALANUSTAID
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable1.ALANUSTAIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'ALANUSTAID' in table 'DataTable1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.ALANUSTAIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int FIRMAID
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable1.FIRMAIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'FIRMAID' in table 'DataTable1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.FIRMAIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMalzeme_MarkaNull() => this.IsNull(this.tableDataTable1.Malzeme_MarkaColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMalzeme_MarkaNull() => this[this.tableDataTable1.Malzeme_MarkaColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBelediye_BirimNull() => this.IsNull(this.tableDataTable1.Belediye_BirimColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBelediye_BirimNull() => this[this.tableDataTable1.Belediye_BirimColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsFiş_KodNull() => this.IsNull(this.tableDataTable1.Fiş_KodColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetFiş_KodNull() => this[this.tableDataTable1.Fiş_KodColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsTARIHNull() => this.IsNull(this.tableDataTable1.TARIHColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetTARIHNull() => this[this.tableDataTable1.TARIHColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsISLEMTIPIIDNull() => this.IsNull(this.tableDataTable1.ISLEMTIPIIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetISLEMTIPIIDNull() => this[this.tableDataTable1.ISLEMTIPIIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool Isİşlem_YeriNull() => this.IsNull(this.tableDataTable1.İşlem_YeriColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void Setİşlem_YeriNull() => this[this.tableDataTable1.İşlem_YeriColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMalzeme_AdıNull() => this.IsNull(this.tableDataTable1.Malzeme_AdıColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMalzeme_AdıNull() => this[this.tableDataTable1.Malzeme_AdıColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsGIRISMIKTARNull() => this.IsNull(this.tableDataTable1.GIRISMIKTARColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetGIRISMIKTARNull() => this[this.tableDataTable1.GIRISMIKTARColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsCIKISMIKTARNull() => this.IsNull(this.tableDataTable1.CIKISMIKTARColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetCIKISMIKTARNull() => this[this.tableDataTable1.CIKISMIKTARColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsFIYATNull() => this.IsNull(this.tableDataTable1.FIYATColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetFIYATNull() => this[this.tableDataTable1.FIYATColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsGIRISTUTARNull() => this.IsNull(this.tableDataTable1.GIRISTUTARColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetGIRISTUTARNull() => this[this.tableDataTable1.GIRISTUTARColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsCIKISTUTARNull() => this.IsNull(this.tableDataTable1.CIKISTUTARColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetCIKISTUTARNull() => this[this.tableDataTable1.CIKISTUTARColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsKDVORANNull() => this.IsNull(this.tableDataTable1.KDVORANColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetKDVORANNull() => this[this.tableDataTable1.KDVORANColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsKDVTUTARNull() => this.IsNull(this.tableDataTable1.KDVTUTARColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetKDVTUTARNull() => this[this.tableDataTable1.KDVTUTARColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsSATIRTUTARNull() => this.IsNull(this.tableDataTable1.SATIRTUTARColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetSATIRTUTARNull() => this[this.tableDataTable1.SATIRTUTARColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMALZSERINONull() => this.IsNull(this.tableDataTable1.MALZSERINOColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMALZSERINONull() => this[this.tableDataTable1.MALZSERINOColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMALZURTTARIHNull() => this.IsNull(this.tableDataTable1.MALZURTTARIHColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMALZURTTARIHNull() => this[this.tableDataTable1.MALZURTTARIHColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsDEGISIMKMSINull() => this.IsNull(this.tableDataTable1.DEGISIMKMSIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetDEGISIMKMSINull() => this[this.tableDataTable1.DEGISIMKMSIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsSONRAKIDEGKMNull() => this.IsNull(this.tableDataTable1.SONRAKIDEGKMColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetSONRAKIDEGKMNull() => this[this.tableDataTable1.SONRAKIDEGKMColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsDepo_AdıNull() => this.IsNull(this.tableDataTable1.Depo_AdıColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetDepo_AdıNull() => this[this.tableDataTable1.Depo_AdıColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsALANUSTAIDNull() => this.IsNull(this.tableDataTable1.ALANUSTAIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetALANUSTAIDNull() => this[this.tableDataTable1.ALANUSTAIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsFIRMAIDNull() => this.IsNull(this.tableDataTable1.FIRMAIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetFIRMAIDNull() => this[this.tableDataTable1.FIRMAIDColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public class DataTable1RowChangeEvent : EventArgs
    {
      private MalzemeHareketleriKemal.DataTable1Row eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataTable1RowChangeEvent(
        MalzemeHareketleriKemal.DataTable1Row row,
        DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public MalzemeHareketleriKemal.DataTable1Row Row => this.eventRow;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataRowAction Action => this.eventAction;
    }
  }
}
