// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Model.Insankaynaklari
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
  [XmlRoot("Insankaynaklari")]
  [HelpKeyword("vs.data.DataSet")]
  [Serializable]
  public class Insankaynaklari : DataSet
  {
    private Insankaynaklari.TBLPERSONELDataTable tableTBLPERSONEL;
    private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Insankaynaklari()
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
    protected Insankaynaklari(SerializationInfo info, StreamingContext context)
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
          if (dataSet.Tables[nameof (TBLPERSONEL)] != null)
            base.Tables.Add((DataTable) new Insankaynaklari.TBLPERSONELDataTable(dataSet.Tables[nameof (TBLPERSONEL)]));
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
    public Insankaynaklari.TBLPERSONELDataTable TBLPERSONEL => this.tableTBLPERSONEL;

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
      Insankaynaklari insankaynaklari = (Insankaynaklari) base.Clone();
      insankaynaklari.InitVars();
      insankaynaklari.SchemaSerializationMode = this.SchemaSerializationMode;
      return (DataSet) insankaynaklari;
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
        if (dataSet.Tables["TBLPERSONEL"] != null)
          base.Tables.Add((DataTable) new Insankaynaklari.TBLPERSONELDataTable(dataSet.Tables["TBLPERSONEL"]));
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
      this.tableTBLPERSONEL = (Insankaynaklari.TBLPERSONELDataTable) base.Tables["TBLPERSONEL"];
      if (!initTable || this.tableTBLPERSONEL == null)
        return;
      this.tableTBLPERSONEL.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.DataSetName = nameof (Insankaynaklari);
      this.Prefix = "";
      this.Namespace = "http://tempuri.org/Insankaynaklari.xsd";
      this.EnforceConstraints = true;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tableTBLPERSONEL = new Insankaynaklari.TBLPERSONELDataTable();
      base.Tables.Add((DataTable) this.tableTBLPERSONEL);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private bool ShouldSerializeTBLPERSONEL() => false;

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
      Insankaynaklari insankaynaklari = new Insankaynaklari();
      XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
      {
        Namespace = insankaynaklari.Namespace
      });
      typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = insankaynaklari.GetSchemaSerializable();
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
    public delegate void TBLPERSONELRowChangeEventHandler(
      object sender,
      Insankaynaklari.TBLPERSONELRowChangeEvent e);

    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class TBLPERSONELDataTable : TypedTableBase<Insankaynaklari.TBLPERSONELRow>
    {
      private DataColumn columnTCKIMLIKNO;
      private DataColumn columnADISOYADI;
      private DataColumn columnCEPTELEFON;
      private DataColumn columnSIRANO;
      private DataColumn columnID;
      private DataColumn columnTBLPERSONEL_RESIM2;
      private DataColumn columnDurum;
      private DataColumn columnEGITIMDURUM;
      private DataColumn columnUNVAN;
      private DataColumn columnGOREVYERI;
      private DataColumn columnPLAKA;
      private DataColumn columnDOGUMTARIHI;
      private DataColumn columnISEGIRISTARIHI;
      private DataColumn columnKURUMGOREV;
      private DataColumn columnDurum1;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public TBLPERSONELDataTable()
      {
        this.TableName = "TBLPERSONEL";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal TBLPERSONELDataTable(DataTable table)
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
      protected TBLPERSONELDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn TCKIMLIKNOColumn => this.columnTCKIMLIKNO;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ADISOYADIColumn => this.columnADISOYADI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn CEPTELEFONColumn => this.columnCEPTELEFON;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn SIRANOColumn => this.columnSIRANO;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn IDColumn => this.columnID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn TBLPERSONEL_RESIM2Column => this.columnTBLPERSONEL_RESIM2;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn DurumColumn => this.columnDurum;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn EGITIMDURUMColumn => this.columnEGITIMDURUM;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn UNVANColumn => this.columnUNVAN;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn GOREVYERIColumn => this.columnGOREVYERI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn PLAKAColumn => this.columnPLAKA;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn DOGUMTARIHIColumn => this.columnDOGUMTARIHI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ISEGIRISTARIHIColumn => this.columnISEGIRISTARIHI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn KURUMGOREVColumn => this.columnKURUMGOREV;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn Durum1Column => this.columnDurum1;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Insankaynaklari.TBLPERSONELRow this[int index] => (Insankaynaklari.TBLPERSONELRow) this.Rows[index];

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event Insankaynaklari.TBLPERSONELRowChangeEventHandler TBLPERSONELRowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event Insankaynaklari.TBLPERSONELRowChangeEventHandler TBLPERSONELRowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event Insankaynaklari.TBLPERSONELRowChangeEventHandler TBLPERSONELRowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event Insankaynaklari.TBLPERSONELRowChangeEventHandler TBLPERSONELRowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void AddTBLPERSONELRow(Insankaynaklari.TBLPERSONELRow row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Insankaynaklari.TBLPERSONELRow AddTBLPERSONELRow(
        string TCKIMLIKNO,
        string ADISOYADI,
        string CEPTELEFON,
        string SIRANO,
        int ID,
        byte[] TBLPERSONEL_RESIM2,
        string Durum,
        string EGITIMDURUM,
        string UNVAN,
        string GOREVYERI,
        string PLAKA,
        string DOGUMTARIHI,
        string ISEGIRISTARIHI,
        string KURUMGOREV,
        string Durum1)
      {
        Insankaynaklari.TBLPERSONELRow row = (Insankaynaklari.TBLPERSONELRow) this.NewRow();
        object[] objArray = new object[15]
        {
          (object) TCKIMLIKNO,
          (object) ADISOYADI,
          (object) CEPTELEFON,
          (object) SIRANO,
          (object) ID,
          (object) TBLPERSONEL_RESIM2,
          (object) Durum,
          (object) EGITIMDURUM,
          (object) UNVAN,
          (object) GOREVYERI,
          (object) PLAKA,
          (object) DOGUMTARIHI,
          (object) ISEGIRISTARIHI,
          (object) KURUMGOREV,
          (object) Durum1
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public override DataTable Clone()
      {
        Insankaynaklari.TBLPERSONELDataTable tblpersonelDataTable = (Insankaynaklari.TBLPERSONELDataTable) base.Clone();
        tblpersonelDataTable.InitVars();
        return (DataTable) tblpersonelDataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataTable CreateInstance() => (DataTable) new Insankaynaklari.TBLPERSONELDataTable();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal void InitVars()
      {
        this.columnTCKIMLIKNO = this.Columns["TCKIMLIKNO"];
        this.columnADISOYADI = this.Columns["ADISOYADI"];
        this.columnCEPTELEFON = this.Columns["CEPTELEFON"];
        this.columnSIRANO = this.Columns["SIRANO"];
        this.columnID = this.Columns["ID"];
        this.columnTBLPERSONEL_RESIM2 = this.Columns["TBLPERSONEL_RESIM2"];
        this.columnDurum = this.Columns["Durum"];
        this.columnEGITIMDURUM = this.Columns["EGITIMDURUM"];
        this.columnUNVAN = this.Columns["UNVAN"];
        this.columnGOREVYERI = this.Columns["GOREVYERI"];
        this.columnPLAKA = this.Columns["PLAKA"];
        this.columnDOGUMTARIHI = this.Columns["DOGUMTARIHI"];
        this.columnISEGIRISTARIHI = this.Columns["ISEGIRISTARIHI"];
        this.columnKURUMGOREV = this.Columns["KURUMGOREV"];
        this.columnDurum1 = this.Columns["Durum1"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      private void InitClass()
      {
        this.columnTCKIMLIKNO = new DataColumn("TCKIMLIKNO", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTCKIMLIKNO);
        this.columnADISOYADI = new DataColumn("ADISOYADI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnADISOYADI);
        this.columnCEPTELEFON = new DataColumn("CEPTELEFON", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCEPTELEFON);
        this.columnSIRANO = new DataColumn("SIRANO", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSIRANO);
        this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnID);
        this.columnTBLPERSONEL_RESIM2 = new DataColumn("TBLPERSONEL_RESIM2", typeof (byte[]), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTBLPERSONEL_RESIM2);
        this.columnDurum = new DataColumn("Durum", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDurum);
        this.columnEGITIMDURUM = new DataColumn("EGITIMDURUM", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnEGITIMDURUM);
        this.columnUNVAN = new DataColumn("UNVAN", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnUNVAN);
        this.columnGOREVYERI = new DataColumn("GOREVYERI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGOREVYERI);
        this.columnPLAKA = new DataColumn("PLAKA", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnPLAKA);
        this.columnDOGUMTARIHI = new DataColumn("DOGUMTARIHI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDOGUMTARIHI);
        this.columnISEGIRISTARIHI = new DataColumn("ISEGIRISTARIHI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnISEGIRISTARIHI);
        this.columnKURUMGOREV = new DataColumn("KURUMGOREV", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnKURUMGOREV);
        this.columnDurum1 = new DataColumn("Durum1", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDurum1);
        this.columnTCKIMLIKNO.MaxLength = 12;
        this.columnADISOYADI.MaxLength = 50;
        this.columnCEPTELEFON.MaxLength = 16;
        this.columnSIRANO.MaxLength = 20;
        this.columnTBLPERSONEL_RESIM2.ReadOnly = true;
        this.columnTBLPERSONEL_RESIM2.Caption = "TBLPERSONEL.RESIM2";
        this.columnDurum.ReadOnly = true;
        this.columnDurum.MaxLength = 13;
        this.columnEGITIMDURUM.MaxLength = 21;
        this.columnUNVAN.MaxLength = 25;
        this.columnGOREVYERI.MaxLength = 28;
        this.columnPLAKA.MaxLength = 16;
        this.columnDOGUMTARIHI.MaxLength = 19;
        this.columnISEGIRISTARIHI.MaxLength = 19;
        this.columnKURUMGOREV.MaxLength = 41;
        this.columnDurum1.ReadOnly = true;
        this.columnDurum1.MaxLength = 13;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Insankaynaklari.TBLPERSONELRow NewTBLPERSONELRow() => (Insankaynaklari.TBLPERSONELRow) this.NewRow();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new Insankaynaklari.TBLPERSONELRow(builder);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override Type GetRowType() => typeof (Insankaynaklari.TBLPERSONELRow);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.TBLPERSONELRowChanged == null)
          return;
        this.TBLPERSONELRowChanged((object) this, new Insankaynaklari.TBLPERSONELRowChangeEvent((Insankaynaklari.TBLPERSONELRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.TBLPERSONELRowChanging == null)
          return;
        this.TBLPERSONELRowChanging((object) this, new Insankaynaklari.TBLPERSONELRowChangeEvent((Insankaynaklari.TBLPERSONELRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.TBLPERSONELRowDeleted == null)
          return;
        this.TBLPERSONELRowDeleted((object) this, new Insankaynaklari.TBLPERSONELRowChangeEvent((Insankaynaklari.TBLPERSONELRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.TBLPERSONELRowDeleting == null)
          return;
        this.TBLPERSONELRowDeleting((object) this, new Insankaynaklari.TBLPERSONELRowChangeEvent((Insankaynaklari.TBLPERSONELRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void RemoveTBLPERSONELRow(Insankaynaklari.TBLPERSONELRow row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        Insankaynaklari insankaynaklari = new Insankaynaklari();
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
          FixedValue = insankaynaklari.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (TBLPERSONELDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = insankaynaklari.GetSchemaSerializable();
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

    public class TBLPERSONELRow : DataRow
    {
      private Insankaynaklari.TBLPERSONELDataTable tableTBLPERSONEL;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal TBLPERSONELRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableTBLPERSONEL = (Insankaynaklari.TBLPERSONELDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string TCKIMLIKNO
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLPERSONEL.TCKIMLIKNOColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLPERSONEL' tablosundaki 'TCKIMLIKNO' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLPERSONEL.TCKIMLIKNOColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string ADISOYADI
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLPERSONEL.ADISOYADIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLPERSONEL' tablosundaki 'ADISOYADI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLPERSONEL.ADISOYADIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string CEPTELEFON
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLPERSONEL.CEPTELEFONColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLPERSONEL' tablosundaki 'CEPTELEFON' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLPERSONEL.CEPTELEFONColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string SIRANO
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLPERSONEL.SIRANOColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLPERSONEL' tablosundaki 'SIRANO' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLPERSONEL.SIRANOColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ID
      {
        get
        {
          try
          {
            return (int) this[this.tableTBLPERSONEL.IDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLPERSONEL' tablosundaki 'ID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLPERSONEL.IDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public byte[] TBLPERSONEL_RESIM2
      {
        get
        {
          try
          {
            return (byte[]) this[this.tableTBLPERSONEL.TBLPERSONEL_RESIM2Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLPERSONEL' tablosundaki 'TBLPERSONEL_RESIM2' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLPERSONEL.TBLPERSONEL_RESIM2Column] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string Durum
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLPERSONEL.DurumColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLPERSONEL' tablosundaki 'Durum' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLPERSONEL.DurumColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string EGITIMDURUM
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLPERSONEL.EGITIMDURUMColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLPERSONEL' tablosundaki 'EGITIMDURUM' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLPERSONEL.EGITIMDURUMColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string UNVAN
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLPERSONEL.UNVANColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLPERSONEL' tablosundaki 'UNVAN' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLPERSONEL.UNVANColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string GOREVYERI
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLPERSONEL.GOREVYERIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLPERSONEL' tablosundaki 'GOREVYERI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLPERSONEL.GOREVYERIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string PLAKA
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLPERSONEL.PLAKAColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLPERSONEL' tablosundaki 'PLAKA' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLPERSONEL.PLAKAColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string DOGUMTARIHI
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLPERSONEL.DOGUMTARIHIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLPERSONEL' tablosundaki 'DOGUMTARIHI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLPERSONEL.DOGUMTARIHIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string ISEGIRISTARIHI
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLPERSONEL.ISEGIRISTARIHIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLPERSONEL' tablosundaki 'ISEGIRISTARIHI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLPERSONEL.ISEGIRISTARIHIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string KURUMGOREV
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLPERSONEL.KURUMGOREVColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLPERSONEL' tablosundaki 'KURUMGOREV' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLPERSONEL.KURUMGOREVColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string Durum1
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLPERSONEL.Durum1Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLPERSONEL' tablosundaki 'Durum1' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLPERSONEL.Durum1Column] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsTCKIMLIKNONull() => this.IsNull(this.tableTBLPERSONEL.TCKIMLIKNOColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetTCKIMLIKNONull() => this[this.tableTBLPERSONEL.TCKIMLIKNOColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsADISOYADINull() => this.IsNull(this.tableTBLPERSONEL.ADISOYADIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetADISOYADINull() => this[this.tableTBLPERSONEL.ADISOYADIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsCEPTELEFONNull() => this.IsNull(this.tableTBLPERSONEL.CEPTELEFONColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetCEPTELEFONNull() => this[this.tableTBLPERSONEL.CEPTELEFONColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsSIRANONull() => this.IsNull(this.tableTBLPERSONEL.SIRANOColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetSIRANONull() => this[this.tableTBLPERSONEL.SIRANOColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsIDNull() => this.IsNull(this.tableTBLPERSONEL.IDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetIDNull() => this[this.tableTBLPERSONEL.IDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsTBLPERSONEL_RESIM2Null() => this.IsNull(this.tableTBLPERSONEL.TBLPERSONEL_RESIM2Column);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetTBLPERSONEL_RESIM2Null() => this[this.tableTBLPERSONEL.TBLPERSONEL_RESIM2Column] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsDurumNull() => this.IsNull(this.tableTBLPERSONEL.DurumColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetDurumNull() => this[this.tableTBLPERSONEL.DurumColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsEGITIMDURUMNull() => this.IsNull(this.tableTBLPERSONEL.EGITIMDURUMColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetEGITIMDURUMNull() => this[this.tableTBLPERSONEL.EGITIMDURUMColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsUNVANNull() => this.IsNull(this.tableTBLPERSONEL.UNVANColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetUNVANNull() => this[this.tableTBLPERSONEL.UNVANColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsGOREVYERINull() => this.IsNull(this.tableTBLPERSONEL.GOREVYERIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetGOREVYERINull() => this[this.tableTBLPERSONEL.GOREVYERIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsPLAKANull() => this.IsNull(this.tableTBLPERSONEL.PLAKAColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetPLAKANull() => this[this.tableTBLPERSONEL.PLAKAColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsDOGUMTARIHINull() => this.IsNull(this.tableTBLPERSONEL.DOGUMTARIHIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetDOGUMTARIHINull() => this[this.tableTBLPERSONEL.DOGUMTARIHIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsISEGIRISTARIHINull() => this.IsNull(this.tableTBLPERSONEL.ISEGIRISTARIHIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetISEGIRISTARIHINull() => this[this.tableTBLPERSONEL.ISEGIRISTARIHIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsKURUMGOREVNull() => this.IsNull(this.tableTBLPERSONEL.KURUMGOREVColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetKURUMGOREVNull() => this[this.tableTBLPERSONEL.KURUMGOREVColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsDurum1Null() => this.IsNull(this.tableTBLPERSONEL.Durum1Column);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetDurum1Null() => this[this.tableTBLPERSONEL.Durum1Column] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public class TBLPERSONELRowChangeEvent : EventArgs
    {
      private Insankaynaklari.TBLPERSONELRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public TBLPERSONELRowChangeEvent(Insankaynaklari.TBLPERSONELRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Insankaynaklari.TBLPERSONELRow Row => this.eventRow;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataRowAction Action => this.eventAction;
    }
  }
}
