// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Model.ModelSatinAlma.TalepHareketi
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

namespace Makina_Ikmal.Model.ModelSatinAlma
{
  [DesignerCategory("code")]
  [ToolboxItem(true)]
  [XmlSchemaProvider("GetTypedDataSetSchema")]
  [XmlRoot("TalepHareketi")]
  [HelpKeyword("vs.data.DataSet")]
  [Serializable]
  public class TalepHareketi : DataSet
  {
    private TalepHareketi.TalepHareketleriDataTable tableTalepHareketleri;
    private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public TalepHareketi()
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
    protected TalepHareketi(SerializationInfo info, StreamingContext context)
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
          if (dataSet.Tables[nameof (TalepHareketleri)] != null)
            base.Tables.Add((DataTable) new TalepHareketi.TalepHareketleriDataTable(dataSet.Tables[nameof (TalepHareketleri)]));
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
    public TalepHareketi.TalepHareketleriDataTable TalepHareketleri => this.tableTalepHareketleri;

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
      TalepHareketi talepHareketi = (TalepHareketi) base.Clone();
      talepHareketi.InitVars();
      talepHareketi.SchemaSerializationMode = this.SchemaSerializationMode;
      return (DataSet) talepHareketi;
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
        if (dataSet.Tables["TalepHareketleri"] != null)
          base.Tables.Add((DataTable) new TalepHareketi.TalepHareketleriDataTable(dataSet.Tables["TalepHareketleri"]));
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
      this.tableTalepHareketleri = (TalepHareketi.TalepHareketleriDataTable) base.Tables["TalepHareketleri"];
      if (!initTable || this.tableTalepHareketleri == null)
        return;
      this.tableTalepHareketleri.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.DataSetName = nameof (TalepHareketi);
      this.Prefix = "";
      this.Namespace = "http://tempuri.org/TalepHareketi.xsd";
      this.EnforceConstraints = true;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tableTalepHareketleri = new TalepHareketi.TalepHareketleriDataTable();
      base.Tables.Add((DataTable) this.tableTalepHareketleri);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private bool ShouldSerializeTalepHareketleri() => false;

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
      TalepHareketi talepHareketi = new TalepHareketi();
      XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
      {
        Namespace = talepHareketi.Namespace
      });
      typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = talepHareketi.GetSchemaSerializable();
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
    public delegate void TalepHareketleriRowChangeEventHandler(
      object sender,
      TalepHareketi.TalepHareketleriRowChangeEvent e);

    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class TalepHareketleriDataTable : TypedTableBase<TalepHareketi.TalepHareketleriRow>
    {
      private DataColumn columnKOD;
      private DataColumn columnTARIH;
      private DataColumn columnBELGESAYI;
      private DataColumn columnBELGEKONU;
      private DataColumn columnPLAKA;
      private DataColumn columnARACACIKLAMA;
      private DataColumn columnMALZEMEADI;
      private DataColumn columnMalzeme_Kodu;
      private DataColumn columnBIRIMADI;
      private DataColumn columnBOLUMADI;
      private DataColumn columnSORUMLUID;
      private DataColumn columnMALZEMEGRUP;
      private DataColumn columnMIKTAR;
      private DataColumn columnŞube_Müdürü;
      private DataColumn columnŞube_Müdürü_Ünvanı;
      private DataColumn columnTALEPKAYITID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public TalepHareketleriDataTable()
      {
        this.TableName = "TalepHareketleri";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal TalepHareketleriDataTable(DataTable table)
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
      protected TalepHareketleriDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn KODColumn => this.columnKOD;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn TARIHColumn => this.columnTARIH;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BELGESAYIColumn => this.columnBELGESAYI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BELGEKONUColumn => this.columnBELGEKONU;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn PLAKAColumn => this.columnPLAKA;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ARACACIKLAMAColumn => this.columnARACACIKLAMA;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MALZEMEADIColumn => this.columnMALZEMEADI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn Malzeme_KoduColumn => this.columnMalzeme_Kodu;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BIRIMADIColumn => this.columnBIRIMADI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BOLUMADIColumn => this.columnBOLUMADI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn SORUMLUIDColumn => this.columnSORUMLUID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MALZEMEGRUPColumn => this.columnMALZEMEGRUP;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MIKTARColumn => this.columnMIKTAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn Şube_MüdürüColumn => this.columnŞube_Müdürü;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn Şube_Müdürü_ÜnvanıColumn => this.columnŞube_Müdürü_Ünvanı;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn TALEPKAYITIDColumn => this.columnTALEPKAYITID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public TalepHareketi.TalepHareketleriRow this[int index] => (TalepHareketi.TalepHareketleriRow) this.Rows[index];

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event TalepHareketi.TalepHareketleriRowChangeEventHandler TalepHareketleriRowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event TalepHareketi.TalepHareketleriRowChangeEventHandler TalepHareketleriRowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event TalepHareketi.TalepHareketleriRowChangeEventHandler TalepHareketleriRowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event TalepHareketi.TalepHareketleriRowChangeEventHandler TalepHareketleriRowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void AddTalepHareketleriRow(TalepHareketi.TalepHareketleriRow row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public TalepHareketi.TalepHareketleriRow AddTalepHareketleriRow(
        string KOD,
        DateTime TARIH,
        string BELGESAYI,
        string BELGEKONU,
        string PLAKA,
        string ARACACIKLAMA,
        string MALZEMEADI,
        string Malzeme_Kodu,
        string BIRIMADI,
        string BOLUMADI,
        int SORUMLUID,
        string MALZEMEGRUP,
        Decimal MIKTAR,
        string Şube_Müdürü,
        string Şube_Müdürü_Ünvanı,
        int TALEPKAYITID)
      {
        TalepHareketi.TalepHareketleriRow row = (TalepHareketi.TalepHareketleriRow) this.NewRow();
        object[] objArray = new object[16]
        {
          (object) KOD,
          (object) TARIH,
          (object) BELGESAYI,
          (object) BELGEKONU,
          (object) PLAKA,
          (object) ARACACIKLAMA,
          (object) MALZEMEADI,
          (object) Malzeme_Kodu,
          (object) BIRIMADI,
          (object) BOLUMADI,
          (object) SORUMLUID,
          (object) MALZEMEGRUP,
          (object) MIKTAR,
          (object) Şube_Müdürü,
          (object) Şube_Müdürü_Ünvanı,
          (object) TALEPKAYITID
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public override DataTable Clone()
      {
        TalepHareketi.TalepHareketleriDataTable hareketleriDataTable = (TalepHareketi.TalepHareketleriDataTable) base.Clone();
        hareketleriDataTable.InitVars();
        return (DataTable) hareketleriDataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataTable CreateInstance() => (DataTable) new TalepHareketi.TalepHareketleriDataTable();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal void InitVars()
      {
        this.columnKOD = this.Columns["KOD"];
        this.columnTARIH = this.Columns["TARIH"];
        this.columnBELGESAYI = this.Columns["BELGESAYI"];
        this.columnBELGEKONU = this.Columns["BELGEKONU"];
        this.columnPLAKA = this.Columns["PLAKA"];
        this.columnARACACIKLAMA = this.Columns["ARACACIKLAMA"];
        this.columnMALZEMEADI = this.Columns["MALZEMEADI"];
        this.columnMalzeme_Kodu = this.Columns["Malzeme Kodu"];
        this.columnBIRIMADI = this.Columns["BIRIMADI"];
        this.columnBOLUMADI = this.Columns["BOLUMADI"];
        this.columnSORUMLUID = this.Columns["SORUMLUID"];
        this.columnMALZEMEGRUP = this.Columns["MALZEMEGRUP"];
        this.columnMIKTAR = this.Columns["MIKTAR"];
        this.columnŞube_Müdürü = this.Columns["Şube Müdürü"];
        this.columnŞube_Müdürü_Ünvanı = this.Columns["Şube Müdürü Ünvanı"];
        this.columnTALEPKAYITID = this.Columns["TALEPKAYITID"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      private void InitClass()
      {
        this.columnKOD = new DataColumn("KOD", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnKOD);
        this.columnTARIH = new DataColumn("TARIH", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTARIH);
        this.columnBELGESAYI = new DataColumn("BELGESAYI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBELGESAYI);
        this.columnBELGEKONU = new DataColumn("BELGEKONU", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBELGEKONU);
        this.columnPLAKA = new DataColumn("PLAKA", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnPLAKA);
        this.columnARACACIKLAMA = new DataColumn("ARACACIKLAMA", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnARACACIKLAMA);
        this.columnMALZEMEADI = new DataColumn("MALZEMEADI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMALZEMEADI);
        this.columnMalzeme_Kodu = new DataColumn("Malzeme Kodu", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMalzeme_Kodu);
        this.columnBIRIMADI = new DataColumn("BIRIMADI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBIRIMADI);
        this.columnBOLUMADI = new DataColumn("BOLUMADI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBOLUMADI);
        this.columnSORUMLUID = new DataColumn("SORUMLUID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSORUMLUID);
        this.columnMALZEMEGRUP = new DataColumn("MALZEMEGRUP", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMALZEMEGRUP);
        this.columnMIKTAR = new DataColumn("MIKTAR", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMIKTAR);
        this.columnŞube_Müdürü = new DataColumn("Şube Müdürü", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnŞube_Müdürü);
        this.columnŞube_Müdürü_Ünvanı = new DataColumn("Şube Müdürü Ünvanı", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnŞube_Müdürü_Ünvanı);
        this.columnTALEPKAYITID = new DataColumn("TALEPKAYITID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTALEPKAYITID);
        this.columnKOD.MaxLength = 50;
        this.columnBELGESAYI.MaxLength = 50;
        this.columnBELGEKONU.MaxLength = 50;
        this.columnPLAKA.MaxLength = 50;
        this.columnARACACIKLAMA.MaxLength = 150;
        this.columnMALZEMEADI.MaxLength = 80;
        this.columnMalzeme_Kodu.MaxLength = 50;
        this.columnBIRIMADI.MaxLength = 50;
        this.columnBOLUMADI.MaxLength = 50;
        this.columnMALZEMEGRUP.MaxLength = 50;
        this.columnŞube_Müdürü.MaxLength = 80;
        this.columnŞube_Müdürü_Ünvanı.MaxLength = 50;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public TalepHareketi.TalepHareketleriRow NewTalepHareketleriRow() => (TalepHareketi.TalepHareketleriRow) this.NewRow();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new TalepHareketi.TalepHareketleriRow(builder);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override Type GetRowType() => typeof (TalepHareketi.TalepHareketleriRow);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.TalepHareketleriRowChanged == null)
          return;
        this.TalepHareketleriRowChanged((object) this, new TalepHareketi.TalepHareketleriRowChangeEvent((TalepHareketi.TalepHareketleriRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.TalepHareketleriRowChanging == null)
          return;
        this.TalepHareketleriRowChanging((object) this, new TalepHareketi.TalepHareketleriRowChangeEvent((TalepHareketi.TalepHareketleriRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.TalepHareketleriRowDeleted == null)
          return;
        this.TalepHareketleriRowDeleted((object) this, new TalepHareketi.TalepHareketleriRowChangeEvent((TalepHareketi.TalepHareketleriRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.TalepHareketleriRowDeleting == null)
          return;
        this.TalepHareketleriRowDeleting((object) this, new TalepHareketi.TalepHareketleriRowChangeEvent((TalepHareketi.TalepHareketleriRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void RemoveTalepHareketleriRow(TalepHareketi.TalepHareketleriRow row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        TalepHareketi talepHareketi = new TalepHareketi();
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
          FixedValue = talepHareketi.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (TalepHareketleriDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = talepHareketi.GetSchemaSerializable();
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

    public class TalepHareketleriRow : DataRow
    {
      private TalepHareketi.TalepHareketleriDataTable tableTalepHareketleri;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal TalepHareketleriRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableTalepHareketleri = (TalepHareketi.TalepHareketleriDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string KOD
      {
        get
        {
          try
          {
            return (string) this[this.tableTalepHareketleri.KODColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TalepHareketleri' tablosundaki 'KOD' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTalepHareketleri.KODColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DateTime TARIH
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableTalepHareketleri.TARIHColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TalepHareketleri' tablosundaki 'TARIH' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTalepHareketleri.TARIHColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BELGESAYI
      {
        get
        {
          try
          {
            return (string) this[this.tableTalepHareketleri.BELGESAYIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TalepHareketleri' tablosundaki 'BELGESAYI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTalepHareketleri.BELGESAYIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BELGEKONU
      {
        get
        {
          try
          {
            return (string) this[this.tableTalepHareketleri.BELGEKONUColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TalepHareketleri' tablosundaki 'BELGEKONU' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTalepHareketleri.BELGEKONUColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string PLAKA
      {
        get
        {
          try
          {
            return (string) this[this.tableTalepHareketleri.PLAKAColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TalepHareketleri' tablosundaki 'PLAKA' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTalepHareketleri.PLAKAColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string ARACACIKLAMA
      {
        get
        {
          try
          {
            return (string) this[this.tableTalepHareketleri.ARACACIKLAMAColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TalepHareketleri' tablosundaki 'ARACACIKLAMA' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTalepHareketleri.ARACACIKLAMAColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string MALZEMEADI
      {
        get
        {
          try
          {
            return (string) this[this.tableTalepHareketleri.MALZEMEADIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TalepHareketleri' tablosundaki 'MALZEMEADI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTalepHareketleri.MALZEMEADIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string Malzeme_Kodu
      {
        get
        {
          try
          {
            return (string) this[this.tableTalepHareketleri.Malzeme_KoduColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TalepHareketleri' tablosundaki 'Malzeme Kodu' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTalepHareketleri.Malzeme_KoduColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BIRIMADI
      {
        get
        {
          try
          {
            return (string) this[this.tableTalepHareketleri.BIRIMADIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TalepHareketleri' tablosundaki 'BIRIMADI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTalepHareketleri.BIRIMADIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BOLUMADI
      {
        get
        {
          try
          {
            return (string) this[this.tableTalepHareketleri.BOLUMADIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TalepHareketleri' tablosundaki 'BOLUMADI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTalepHareketleri.BOLUMADIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int SORUMLUID
      {
        get
        {
          try
          {
            return (int) this[this.tableTalepHareketleri.SORUMLUIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TalepHareketleri' tablosundaki 'SORUMLUID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTalepHareketleri.SORUMLUIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string MALZEMEGRUP
      {
        get
        {
          try
          {
            return (string) this[this.tableTalepHareketleri.MALZEMEGRUPColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TalepHareketleri' tablosundaki 'MALZEMEGRUP' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTalepHareketleri.MALZEMEGRUPColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Decimal MIKTAR
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableTalepHareketleri.MIKTARColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TalepHareketleri' tablosundaki 'MIKTAR' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTalepHareketleri.MIKTARColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string Şube_Müdürü
      {
        get
        {
          try
          {
            return (string) this[this.tableTalepHareketleri.Şube_MüdürüColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TalepHareketleri' tablosundaki 'Şube Müdürü' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTalepHareketleri.Şube_MüdürüColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string Şube_Müdürü_Ünvanı
      {
        get
        {
          try
          {
            return (string) this[this.tableTalepHareketleri.Şube_Müdürü_ÜnvanıColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TalepHareketleri' tablosundaki 'Şube Müdürü Ünvanı' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTalepHareketleri.Şube_Müdürü_ÜnvanıColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int TALEPKAYITID
      {
        get
        {
          try
          {
            return (int) this[this.tableTalepHareketleri.TALEPKAYITIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TalepHareketleri' tablosundaki 'TALEPKAYITID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTalepHareketleri.TALEPKAYITIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsKODNull() => this.IsNull(this.tableTalepHareketleri.KODColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetKODNull() => this[this.tableTalepHareketleri.KODColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsTARIHNull() => this.IsNull(this.tableTalepHareketleri.TARIHColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetTARIHNull() => this[this.tableTalepHareketleri.TARIHColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBELGESAYINull() => this.IsNull(this.tableTalepHareketleri.BELGESAYIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBELGESAYINull() => this[this.tableTalepHareketleri.BELGESAYIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBELGEKONUNull() => this.IsNull(this.tableTalepHareketleri.BELGEKONUColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBELGEKONUNull() => this[this.tableTalepHareketleri.BELGEKONUColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsPLAKANull() => this.IsNull(this.tableTalepHareketleri.PLAKAColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetPLAKANull() => this[this.tableTalepHareketleri.PLAKAColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsARACACIKLAMANull() => this.IsNull(this.tableTalepHareketleri.ARACACIKLAMAColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetARACACIKLAMANull() => this[this.tableTalepHareketleri.ARACACIKLAMAColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMALZEMEADINull() => this.IsNull(this.tableTalepHareketleri.MALZEMEADIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMALZEMEADINull() => this[this.tableTalepHareketleri.MALZEMEADIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMalzeme_KoduNull() => this.IsNull(this.tableTalepHareketleri.Malzeme_KoduColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMalzeme_KoduNull() => this[this.tableTalepHareketleri.Malzeme_KoduColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBIRIMADINull() => this.IsNull(this.tableTalepHareketleri.BIRIMADIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBIRIMADINull() => this[this.tableTalepHareketleri.BIRIMADIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBOLUMADINull() => this.IsNull(this.tableTalepHareketleri.BOLUMADIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBOLUMADINull() => this[this.tableTalepHareketleri.BOLUMADIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsSORUMLUIDNull() => this.IsNull(this.tableTalepHareketleri.SORUMLUIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetSORUMLUIDNull() => this[this.tableTalepHareketleri.SORUMLUIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMALZEMEGRUPNull() => this.IsNull(this.tableTalepHareketleri.MALZEMEGRUPColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMALZEMEGRUPNull() => this[this.tableTalepHareketleri.MALZEMEGRUPColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMIKTARNull() => this.IsNull(this.tableTalepHareketleri.MIKTARColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMIKTARNull() => this[this.tableTalepHareketleri.MIKTARColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsŞube_MüdürüNull() => this.IsNull(this.tableTalepHareketleri.Şube_MüdürüColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetŞube_MüdürüNull() => this[this.tableTalepHareketleri.Şube_MüdürüColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsŞube_Müdürü_ÜnvanıNull() => this.IsNull(this.tableTalepHareketleri.Şube_Müdürü_ÜnvanıColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetŞube_Müdürü_ÜnvanıNull() => this[this.tableTalepHareketleri.Şube_Müdürü_ÜnvanıColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsTALEPKAYITIDNull() => this.IsNull(this.tableTalepHareketleri.TALEPKAYITIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetTALEPKAYITIDNull() => this[this.tableTalepHareketleri.TALEPKAYITIDColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public class TalepHareketleriRowChangeEvent : EventArgs
    {
      private TalepHareketi.TalepHareketleriRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public TalepHareketleriRowChangeEvent(
        TalepHareketi.TalepHareketleriRow row,
        DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public TalepHareketi.TalepHareketleriRow Row => this.eventRow;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataRowAction Action => this.eventAction;
    }
  }
}
