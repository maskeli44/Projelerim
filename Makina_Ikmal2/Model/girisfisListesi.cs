// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Model.girisfisListesi
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
  [XmlRoot("girisfisListesi")]
  [HelpKeyword("vs.data.DataSet")]
  [Serializable]
  public class girisfisListesi : DataSet
  {
    private girisfisListesi.DataTable1DataTable tableDataTable1;
    private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public girisfisListesi()
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
    protected girisfisListesi(SerializationInfo info, StreamingContext context)
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
            base.Tables.Add((DataTable) new girisfisListesi.DataTable1DataTable(dataSet.Tables[nameof (DataTable1)]));
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
    public girisfisListesi.DataTable1DataTable DataTable1 => this.tableDataTable1;

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
      girisfisListesi girisfisListesi = (girisfisListesi) base.Clone();
      girisfisListesi.InitVars();
      girisfisListesi.SchemaSerializationMode = this.SchemaSerializationMode;
      return (DataSet) girisfisListesi;
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
          base.Tables.Add((DataTable) new girisfisListesi.DataTable1DataTable(dataSet.Tables["DataTable1"]));
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
      this.tableDataTable1 = (girisfisListesi.DataTable1DataTable) base.Tables["DataTable1"];
      if (!initTable || this.tableDataTable1 == null)
        return;
      this.tableDataTable1.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.DataSetName = nameof (girisfisListesi);
      this.Prefix = "";
      this.Namespace = "http://tempuri.org/girisfisListesi.xsd";
      this.EnforceConstraints = true;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tableDataTable1 = new girisfisListesi.DataTable1DataTable();
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
      girisfisListesi girisfisListesi = new girisfisListesi();
      XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
      {
        Namespace = girisfisListesi.Namespace
      });
      typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = girisfisListesi.GetSchemaSerializable();
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
      girisfisListesi.DataTable1RowChangeEvent e);

    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class DataTable1DataTable : TypedTableBase<girisfisListesi.DataTable1Row>
    {
      private DataColumn columnKOD;
      private DataColumn columnİs_Emir_Kodu;
      private DataColumn columnTARIH;
      private DataColumn columnALANUSTAID;
      private DataColumn columnFIRMAID;
      private DataColumn columnISLEMTIPIID;
      private DataColumn columnTOPTUTAR;
      private DataColumn columnFISTUTAR;
      private DataColumn columnARACACIKLAMA;
      private DataColumn columnPLAKA;
      private DataColumn columnTOPKDVTUTAR;
      private DataColumn columnGiriş_Fisi;
      private DataColumn columnIMZADEPOYETKILIID;
      private DataColumn columnALANUSTAID1;
      private DataColumn columnFIRMAID1;
      private DataColumn columnTOPTUTAR1;
      private DataColumn columnFISTUTAR1;
      private DataColumn columnTOPKDVTUTAR1;
      private DataColumn columnIMZADEPOYETKILIID1;
      private DataColumn columnID;

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
      public DataColumn KODColumn => this.columnKOD;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn İs_Emir_KoduColumn => this.columnİs_Emir_Kodu;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn TARIHColumn => this.columnTARIH;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ALANUSTAIDColumn => this.columnALANUSTAID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn FIRMAIDColumn => this.columnFIRMAID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ISLEMTIPIIDColumn => this.columnISLEMTIPIID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn TOPTUTARColumn => this.columnTOPTUTAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn FISTUTARColumn => this.columnFISTUTAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ARACACIKLAMAColumn => this.columnARACACIKLAMA;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn PLAKAColumn => this.columnPLAKA;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn TOPKDVTUTARColumn => this.columnTOPKDVTUTAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn Giriş_FisiColumn => this.columnGiriş_Fisi;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn IMZADEPOYETKILIIDColumn => this.columnIMZADEPOYETKILIID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ALANUSTAID1Column => this.columnALANUSTAID1;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn FIRMAID1Column => this.columnFIRMAID1;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn TOPTUTAR1Column => this.columnTOPTUTAR1;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn FISTUTAR1Column => this.columnFISTUTAR1;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn TOPKDVTUTAR1Column => this.columnTOPKDVTUTAR1;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn IMZADEPOYETKILIID1Column => this.columnIMZADEPOYETKILIID1;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn IDColumn => this.columnID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public girisfisListesi.DataTable1Row this[int index] => (girisfisListesi.DataTable1Row) this.Rows[index];

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event girisfisListesi.DataTable1RowChangeEventHandler DataTable1RowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event girisfisListesi.DataTable1RowChangeEventHandler DataTable1RowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event girisfisListesi.DataTable1RowChangeEventHandler DataTable1RowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event girisfisListesi.DataTable1RowChangeEventHandler DataTable1RowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void AddDataTable1Row(girisfisListesi.DataTable1Row row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public girisfisListesi.DataTable1Row AddDataTable1Row(
        string KOD,
        string İs_Emir_Kodu,
        DateTime TARIH,
        string ALANUSTAID,
        string FIRMAID,
        string ISLEMTIPIID,
        string TOPTUTAR,
        string FISTUTAR,
        string ARACACIKLAMA,
        string PLAKA,
        string TOPKDVTUTAR,
        string Giriş_Fisi,
        string IMZADEPOYETKILIID,
        int ALANUSTAID1,
        int FIRMAID1,
        double TOPTUTAR1,
        double FISTUTAR1,
        double TOPKDVTUTAR1,
        int IMZADEPOYETKILIID1)
      {
        girisfisListesi.DataTable1Row row = (girisfisListesi.DataTable1Row) this.NewRow();
        object[] objArray = new object[20]
        {
          (object) KOD,
          (object) İs_Emir_Kodu,
          (object) TARIH,
          (object) ALANUSTAID,
          (object) FIRMAID,
          (object) ISLEMTIPIID,
          (object) TOPTUTAR,
          (object) FISTUTAR,
          (object) ARACACIKLAMA,
          (object) PLAKA,
          (object) TOPKDVTUTAR,
          (object) Giriş_Fisi,
          (object) IMZADEPOYETKILIID,
          (object) ALANUSTAID1,
          (object) FIRMAID1,
          (object) TOPTUTAR1,
          (object) FISTUTAR1,
          (object) TOPKDVTUTAR1,
          (object) IMZADEPOYETKILIID1,
          null
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public girisfisListesi.DataTable1Row FindByID(int ID) => (girisfisListesi.DataTable1Row) this.Rows.Find(new object[1]
      {
        (object) ID
      });

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public override DataTable Clone()
      {
        girisfisListesi.DataTable1DataTable dataTable1DataTable = (girisfisListesi.DataTable1DataTable) base.Clone();
        dataTable1DataTable.InitVars();
        return (DataTable) dataTable1DataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataTable CreateInstance() => (DataTable) new girisfisListesi.DataTable1DataTable();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal void InitVars()
      {
        this.columnKOD = this.Columns["KOD"];
        this.columnİs_Emir_Kodu = this.Columns["İs Emir Kodu"];
        this.columnTARIH = this.Columns["TARIH"];
        this.columnALANUSTAID = this.Columns["ALANUSTAID"];
        this.columnFIRMAID = this.Columns["FIRMAID"];
        this.columnISLEMTIPIID = this.Columns["ISLEMTIPIID"];
        this.columnTOPTUTAR = this.Columns["TOPTUTAR"];
        this.columnFISTUTAR = this.Columns["FISTUTAR"];
        this.columnARACACIKLAMA = this.Columns["ARACACIKLAMA"];
        this.columnPLAKA = this.Columns["PLAKA"];
        this.columnTOPKDVTUTAR = this.Columns["TOPKDVTUTAR"];
        this.columnGiriş_Fisi = this.Columns["Giriş Fisi"];
        this.columnIMZADEPOYETKILIID = this.Columns["IMZADEPOYETKILIID"];
        this.columnALANUSTAID1 = this.Columns["ALANUSTAID1"];
        this.columnFIRMAID1 = this.Columns["FIRMAID1"];
        this.columnTOPTUTAR1 = this.Columns["TOPTUTAR1"];
        this.columnFISTUTAR1 = this.Columns["FISTUTAR1"];
        this.columnTOPKDVTUTAR1 = this.Columns["TOPKDVTUTAR1"];
        this.columnIMZADEPOYETKILIID1 = this.Columns["IMZADEPOYETKILIID1"];
        this.columnID = this.Columns["ID"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      private void InitClass()
      {
        this.columnKOD = new DataColumn("KOD", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnKOD);
        this.columnİs_Emir_Kodu = new DataColumn("İs Emir Kodu", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnİs_Emir_Kodu);
        this.columnTARIH = new DataColumn("TARIH", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTARIH);
        this.columnALANUSTAID = new DataColumn("ALANUSTAID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnALANUSTAID);
        this.columnFIRMAID = new DataColumn("FIRMAID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnFIRMAID);
        this.columnISLEMTIPIID = new DataColumn("ISLEMTIPIID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnISLEMTIPIID);
        this.columnTOPTUTAR = new DataColumn("TOPTUTAR", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTOPTUTAR);
        this.columnFISTUTAR = new DataColumn("FISTUTAR", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnFISTUTAR);
        this.columnARACACIKLAMA = new DataColumn("ARACACIKLAMA", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnARACACIKLAMA);
        this.columnPLAKA = new DataColumn("PLAKA", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnPLAKA);
        this.columnTOPKDVTUTAR = new DataColumn("TOPKDVTUTAR", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTOPKDVTUTAR);
        this.columnGiriş_Fisi = new DataColumn("Giriş Fisi", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGiriş_Fisi);
        this.columnIMZADEPOYETKILIID = new DataColumn("IMZADEPOYETKILIID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnIMZADEPOYETKILIID);
        this.columnALANUSTAID1 = new DataColumn("ALANUSTAID1", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnALANUSTAID1);
        this.columnFIRMAID1 = new DataColumn("FIRMAID1", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnFIRMAID1);
        this.columnTOPTUTAR1 = new DataColumn("TOPTUTAR1", typeof (double), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTOPTUTAR1);
        this.columnFISTUTAR1 = new DataColumn("FISTUTAR1", typeof (double), (string) null, MappingType.Element);
        this.Columns.Add(this.columnFISTUTAR1);
        this.columnTOPKDVTUTAR1 = new DataColumn("TOPKDVTUTAR1", typeof (double), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTOPKDVTUTAR1);
        this.columnIMZADEPOYETKILIID1 = new DataColumn("IMZADEPOYETKILIID1", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnIMZADEPOYETKILIID1);
        this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnID);
        this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
        {
          this.columnID
        }, true));
        this.columnKOD.MaxLength = 50;
        this.columnİs_Emir_Kodu.MaxLength = 50;
        this.columnALANUSTAID.MaxLength = 50;
        this.columnFIRMAID.MaxLength = 50;
        this.columnISLEMTIPIID.MaxLength = 50;
        this.columnTOPTUTAR.MaxLength = 50;
        this.columnFISTUTAR.MaxLength = 50;
        this.columnARACACIKLAMA.MaxLength = 150;
        this.columnPLAKA.MaxLength = 50;
        this.columnTOPKDVTUTAR.MaxLength = 50;
        this.columnGiriş_Fisi.MaxLength = 50;
        this.columnIMZADEPOYETKILIID.MaxLength = 50;
        this.columnALANUSTAID1.Caption = "ALANUSTAID";
        this.columnFIRMAID1.Caption = "FIRMAID";
        this.columnTOPTUTAR1.Caption = "TOPTUTAR";
        this.columnFISTUTAR1.Caption = "FISTUTAR";
        this.columnTOPKDVTUTAR1.Caption = "TOPKDVTUTAR";
        this.columnIMZADEPOYETKILIID1.Caption = "IMZADEPOYETKILIID";
        this.columnID.AutoIncrement = true;
        this.columnID.AutoIncrementSeed = -1L;
        this.columnID.AutoIncrementStep = -1L;
        this.columnID.AllowDBNull = false;
        this.columnID.ReadOnly = true;
        this.columnID.Unique = true;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public girisfisListesi.DataTable1Row NewDataTable1Row() => (girisfisListesi.DataTable1Row) this.NewRow();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new girisfisListesi.DataTable1Row(builder);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override Type GetRowType() => typeof (girisfisListesi.DataTable1Row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.DataTable1RowChanged == null)
          return;
        this.DataTable1RowChanged((object) this, new girisfisListesi.DataTable1RowChangeEvent((girisfisListesi.DataTable1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.DataTable1RowChanging == null)
          return;
        this.DataTable1RowChanging((object) this, new girisfisListesi.DataTable1RowChangeEvent((girisfisListesi.DataTable1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.DataTable1RowDeleted == null)
          return;
        this.DataTable1RowDeleted((object) this, new girisfisListesi.DataTable1RowChangeEvent((girisfisListesi.DataTable1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.DataTable1RowDeleting == null)
          return;
        this.DataTable1RowDeleting((object) this, new girisfisListesi.DataTable1RowChangeEvent((girisfisListesi.DataTable1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void RemoveDataTable1Row(girisfisListesi.DataTable1Row row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        girisfisListesi girisfisListesi = new girisfisListesi();
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
          FixedValue = girisfisListesi.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (DataTable1DataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = girisfisListesi.GetSchemaSerializable();
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
      private girisfisListesi.DataTable1DataTable tableDataTable1;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal DataTable1Row(DataRowBuilder rb)
        : base(rb)
      {
        this.tableDataTable1 = (girisfisListesi.DataTable1DataTable) this.Table;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string KOD
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.KODColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'KOD' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.KODColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string İs_Emir_Kodu
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.İs_Emir_KoduColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'İs Emir Kodu' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.İs_Emir_KoduColumn] = (object) value;
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
            throw new StrongTypingException("'DataTable1' tablosundaki 'TARIH' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.TARIHColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string ALANUSTAID
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.ALANUSTAIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'ALANUSTAID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.ALANUSTAIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string FIRMAID
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.FIRMAIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'FIRMAID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.FIRMAIDColumn] = (object) value;
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
            throw new StrongTypingException("'DataTable1' tablosundaki 'ISLEMTIPIID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.ISLEMTIPIIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string TOPTUTAR
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.TOPTUTARColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'TOPTUTAR' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.TOPTUTARColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string FISTUTAR
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.FISTUTARColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'FISTUTAR' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.FISTUTARColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string ARACACIKLAMA
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.ARACACIKLAMAColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'ARACACIKLAMA' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.ARACACIKLAMAColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string PLAKA
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.PLAKAColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'PLAKA' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.PLAKAColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string TOPKDVTUTAR
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.TOPKDVTUTARColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'TOPKDVTUTAR' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.TOPKDVTUTARColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string Giriş_Fisi
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.Giriş_FisiColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'Giriş Fisi' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.Giriş_FisiColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string IMZADEPOYETKILIID
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.IMZADEPOYETKILIIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'IMZADEPOYETKILIID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.IMZADEPOYETKILIIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ALANUSTAID1
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable1.ALANUSTAID1Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'ALANUSTAID1' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.ALANUSTAID1Column] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int FIRMAID1
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable1.FIRMAID1Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'FIRMAID1' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.FIRMAID1Column] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public double TOPTUTAR1
      {
        get
        {
          try
          {
            return (double) this[this.tableDataTable1.TOPTUTAR1Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'TOPTUTAR1' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.TOPTUTAR1Column] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public double FISTUTAR1
      {
        get
        {
          try
          {
            return (double) this[this.tableDataTable1.FISTUTAR1Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'FISTUTAR1' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.FISTUTAR1Column] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public double TOPKDVTUTAR1
      {
        get
        {
          try
          {
            return (double) this[this.tableDataTable1.TOPKDVTUTAR1Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'TOPKDVTUTAR1' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.TOPKDVTUTAR1Column] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int IMZADEPOYETKILIID1
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable1.IMZADEPOYETKILIID1Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'IMZADEPOYETKILIID1' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.IMZADEPOYETKILIID1Column] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ID
      {
        get => (int) this[this.tableDataTable1.IDColumn];
        set => this[this.tableDataTable1.IDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsKODNull() => this.IsNull(this.tableDataTable1.KODColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetKODNull() => this[this.tableDataTable1.KODColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool Isİs_Emir_KoduNull() => this.IsNull(this.tableDataTable1.İs_Emir_KoduColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void Setİs_Emir_KoduNull() => this[this.tableDataTable1.İs_Emir_KoduColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsTARIHNull() => this.IsNull(this.tableDataTable1.TARIHColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetTARIHNull() => this[this.tableDataTable1.TARIHColumn] = Convert.DBNull;

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

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsISLEMTIPIIDNull() => this.IsNull(this.tableDataTable1.ISLEMTIPIIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetISLEMTIPIIDNull() => this[this.tableDataTable1.ISLEMTIPIIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsTOPTUTARNull() => this.IsNull(this.tableDataTable1.TOPTUTARColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetTOPTUTARNull() => this[this.tableDataTable1.TOPTUTARColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsFISTUTARNull() => this.IsNull(this.tableDataTable1.FISTUTARColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetFISTUTARNull() => this[this.tableDataTable1.FISTUTARColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsARACACIKLAMANull() => this.IsNull(this.tableDataTable1.ARACACIKLAMAColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetARACACIKLAMANull() => this[this.tableDataTable1.ARACACIKLAMAColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsPLAKANull() => this.IsNull(this.tableDataTable1.PLAKAColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetPLAKANull() => this[this.tableDataTable1.PLAKAColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsTOPKDVTUTARNull() => this.IsNull(this.tableDataTable1.TOPKDVTUTARColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetTOPKDVTUTARNull() => this[this.tableDataTable1.TOPKDVTUTARColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsGiriş_FisiNull() => this.IsNull(this.tableDataTable1.Giriş_FisiColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetGiriş_FisiNull() => this[this.tableDataTable1.Giriş_FisiColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsIMZADEPOYETKILIIDNull() => this.IsNull(this.tableDataTable1.IMZADEPOYETKILIIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetIMZADEPOYETKILIIDNull() => this[this.tableDataTable1.IMZADEPOYETKILIIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsALANUSTAID1Null() => this.IsNull(this.tableDataTable1.ALANUSTAID1Column);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetALANUSTAID1Null() => this[this.tableDataTable1.ALANUSTAID1Column] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsFIRMAID1Null() => this.IsNull(this.tableDataTable1.FIRMAID1Column);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetFIRMAID1Null() => this[this.tableDataTable1.FIRMAID1Column] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsTOPTUTAR1Null() => this.IsNull(this.tableDataTable1.TOPTUTAR1Column);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetTOPTUTAR1Null() => this[this.tableDataTable1.TOPTUTAR1Column] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsFISTUTAR1Null() => this.IsNull(this.tableDataTable1.FISTUTAR1Column);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetFISTUTAR1Null() => this[this.tableDataTable1.FISTUTAR1Column] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsTOPKDVTUTAR1Null() => this.IsNull(this.tableDataTable1.TOPKDVTUTAR1Column);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetTOPKDVTUTAR1Null() => this[this.tableDataTable1.TOPKDVTUTAR1Column] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsIMZADEPOYETKILIID1Null() => this.IsNull(this.tableDataTable1.IMZADEPOYETKILIID1Column);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetIMZADEPOYETKILIID1Null() => this[this.tableDataTable1.IMZADEPOYETKILIID1Column] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public class DataTable1RowChangeEvent : EventArgs
    {
      private girisfisListesi.DataTable1Row eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataTable1RowChangeEvent(girisfisListesi.DataTable1Row row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public girisfisListesi.DataTable1Row Row => this.eventRow;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataRowAction Action => this.eventAction;
    }
  }
}
