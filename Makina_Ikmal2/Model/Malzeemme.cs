// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Model.Malzeemme
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
  [XmlRoot("Malzeemme")]
  [HelpKeyword("vs.data.DataSet")]
  [Serializable]
  public class Malzeemme : DataSet
  {
    private Malzeemme.TBLMALZEMELERDataTable tableTBLMALZEMELER;
    private Malzeemme.TBLFILITREDataTable tableTBLFILITRE;
    private Malzeemme.TBLYAGDataTable tableTBLYAG;
    private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Malzeemme()
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
    protected Malzeemme(SerializationInfo info, StreamingContext context)
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
          if (dataSet.Tables[nameof (TBLMALZEMELER)] != null)
            base.Tables.Add((DataTable) new Malzeemme.TBLMALZEMELERDataTable(dataSet.Tables[nameof (TBLMALZEMELER)]));
          if (dataSet.Tables[nameof (TBLFILITRE)] != null)
            base.Tables.Add((DataTable) new Malzeemme.TBLFILITREDataTable(dataSet.Tables[nameof (TBLFILITRE)]));
          if (dataSet.Tables[nameof (TBLYAG)] != null)
            base.Tables.Add((DataTable) new Malzeemme.TBLYAGDataTable(dataSet.Tables[nameof (TBLYAG)]));
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
    public Malzeemme.TBLMALZEMELERDataTable TBLMALZEMELER => this.tableTBLMALZEMELER;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public Malzeemme.TBLFILITREDataTable TBLFILITRE => this.tableTBLFILITRE;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public Malzeemme.TBLYAGDataTable TBLYAG => this.tableTBLYAG;

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
      Malzeemme malzeemme = (Malzeemme) base.Clone();
      malzeemme.InitVars();
      malzeemme.SchemaSerializationMode = this.SchemaSerializationMode;
      return (DataSet) malzeemme;
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
        if (dataSet.Tables["TBLMALZEMELER"] != null)
          base.Tables.Add((DataTable) new Malzeemme.TBLMALZEMELERDataTable(dataSet.Tables["TBLMALZEMELER"]));
        if (dataSet.Tables["TBLFILITRE"] != null)
          base.Tables.Add((DataTable) new Malzeemme.TBLFILITREDataTable(dataSet.Tables["TBLFILITRE"]));
        if (dataSet.Tables["TBLYAG"] != null)
          base.Tables.Add((DataTable) new Malzeemme.TBLYAGDataTable(dataSet.Tables["TBLYAG"]));
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
      this.tableTBLMALZEMELER = (Malzeemme.TBLMALZEMELERDataTable) base.Tables["TBLMALZEMELER"];
      if (initTable && this.tableTBLMALZEMELER != null)
        this.tableTBLMALZEMELER.InitVars();
      this.tableTBLFILITRE = (Malzeemme.TBLFILITREDataTable) base.Tables["TBLFILITRE"];
      if (initTable && this.tableTBLFILITRE != null)
        this.tableTBLFILITRE.InitVars();
      this.tableTBLYAG = (Malzeemme.TBLYAGDataTable) base.Tables["TBLYAG"];
      if (!initTable || this.tableTBLYAG == null)
        return;
      this.tableTBLYAG.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.DataSetName = nameof (Malzeemme);
      this.Prefix = "";
      this.Namespace = "http://tempuri.org/Malzeemme.xsd";
      this.EnforceConstraints = true;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tableTBLMALZEMELER = new Malzeemme.TBLMALZEMELERDataTable();
      base.Tables.Add((DataTable) this.tableTBLMALZEMELER);
      this.tableTBLFILITRE = new Malzeemme.TBLFILITREDataTable();
      base.Tables.Add((DataTable) this.tableTBLFILITRE);
      this.tableTBLYAG = new Malzeemme.TBLYAGDataTable();
      base.Tables.Add((DataTable) this.tableTBLYAG);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private bool ShouldSerializeTBLMALZEMELER() => false;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private bool ShouldSerializeTBLFILITRE() => false;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private bool ShouldSerializeTBLYAG() => false;

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
      Malzeemme malzeemme = new Malzeemme();
      XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
      {
        Namespace = malzeemme.Namespace
      });
      typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = malzeemme.GetSchemaSerializable();
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
    public delegate void TBLMALZEMELERRowChangeEventHandler(
      object sender,
      Malzeemme.TBLMALZEMELERRowChangeEvent e);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public delegate void TBLFILITRERowChangeEventHandler(
      object sender,
      Malzeemme.TBLFILITRERowChangeEvent e);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public delegate void TBLYAGRowChangeEventHandler(
      object sender,
      Malzeemme.TBLYAGRowChangeEvent e);

    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class TBLMALZEMELERDataTable : TypedTableBase<Malzeemme.TBLMALZEMELERRow>
    {
      private DataColumn columnID;
      private DataColumn columnKOD;
      private DataColumn columnUFKOD;
      private DataColumn columnOEMKOD;
      private DataColumn columnMALZEMEADI;
      private DataColumn columnDIGERADI;
      private DataColumn columnKULLANIMYERI;
      private DataColumn columnBIRIMID;
      private DataColumn columnGRUPID;
      private DataColumn columnGRUPID2;
      private DataColumn columnKDVID;
      private DataColumn columnBOLUMID;
      private DataColumn columnRAFNO;
      private DataColumn columnGOZNO;
      private DataColumn columnBARKOD;
      private DataColumn columnTARIHKONTROL;
      private DataColumn columnSERINOKONTROL;
      private DataColumn columnKMKONTROL;
      private DataColumn columnMALZEMEFOTO;
      private DataColumn columnKAYITTIPIID;
      private DataColumn columnSAVEUSER;
      private DataColumn columnSAVEDATE;
      private DataColumn columnEDITUSER;
      private DataColumn columnEDITDATE;
      private DataColumn columnSAVEMAC;
      private DataColumn columnEDITMAC;
      private DataColumn columnSAVEIP;
      private DataColumn columnEDITIP;
      private DataColumn columnGIRIS;
      private DataColumn columnCIKIS;
      private DataColumn columnKALAN;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public TBLMALZEMELERDataTable()
      {
        this.TableName = "TBLMALZEMELER";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal TBLMALZEMELERDataTable(DataTable table)
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
      protected TBLMALZEMELERDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn IDColumn => this.columnID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn KODColumn => this.columnKOD;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn UFKODColumn => this.columnUFKOD;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn OEMKODColumn => this.columnOEMKOD;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MALZEMEADIColumn => this.columnMALZEMEADI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn DIGERADIColumn => this.columnDIGERADI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn KULLANIMYERIColumn => this.columnKULLANIMYERI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BIRIMIDColumn => this.columnBIRIMID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn GRUPIDColumn => this.columnGRUPID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn GRUPID2Column => this.columnGRUPID2;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn KDVIDColumn => this.columnKDVID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BOLUMIDColumn => this.columnBOLUMID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn RAFNOColumn => this.columnRAFNO;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn GOZNOColumn => this.columnGOZNO;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BARKODColumn => this.columnBARKOD;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn TARIHKONTROLColumn => this.columnTARIHKONTROL;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn SERINOKONTROLColumn => this.columnSERINOKONTROL;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn KMKONTROLColumn => this.columnKMKONTROL;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MALZEMEFOTOColumn => this.columnMALZEMEFOTO;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn KAYITTIPIIDColumn => this.columnKAYITTIPIID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn SAVEUSERColumn => this.columnSAVEUSER;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn SAVEDATEColumn => this.columnSAVEDATE;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn EDITUSERColumn => this.columnEDITUSER;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn EDITDATEColumn => this.columnEDITDATE;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn SAVEMACColumn => this.columnSAVEMAC;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn EDITMACColumn => this.columnEDITMAC;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn SAVEIPColumn => this.columnSAVEIP;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn EDITIPColumn => this.columnEDITIP;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn GIRISColumn => this.columnGIRIS;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn CIKISColumn => this.columnCIKIS;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn KALANColumn => this.columnKALAN;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Malzeemme.TBLMALZEMELERRow this[int index] => (Malzeemme.TBLMALZEMELERRow) this.Rows[index];

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event Malzeemme.TBLMALZEMELERRowChangeEventHandler TBLMALZEMELERRowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event Malzeemme.TBLMALZEMELERRowChangeEventHandler TBLMALZEMELERRowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event Malzeemme.TBLMALZEMELERRowChangeEventHandler TBLMALZEMELERRowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event Malzeemme.TBLMALZEMELERRowChangeEventHandler TBLMALZEMELERRowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void AddTBLMALZEMELERRow(Malzeemme.TBLMALZEMELERRow row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Malzeemme.TBLMALZEMELERRow AddTBLMALZEMELERRow(
        string KOD,
        string UFKOD,
        string OEMKOD,
        string MALZEMEADI,
        string DIGERADI,
        string KULLANIMYERI,
        int BIRIMID,
        int GRUPID,
        int GRUPID2,
        int KDVID,
        int BOLUMID,
        string RAFNO,
        string GOZNO,
        string BARKOD,
        string TARIHKONTROL,
        string SERINOKONTROL,
        string KMKONTROL,
        string MALZEMEFOTO,
        int KAYITTIPIID,
        string SAVEUSER,
        DateTime SAVEDATE,
        string EDITUSER,
        DateTime EDITDATE,
        string SAVEMAC,
        string EDITMAC,
        string SAVEIP,
        string EDITIP,
        string GIRIS,
        string CIKIS,
        string KALAN)
      {
        Malzeemme.TBLMALZEMELERRow row = (Malzeemme.TBLMALZEMELERRow) this.NewRow();
        object[] objArray = new object[31]
        {
          null,
          (object) KOD,
          (object) UFKOD,
          (object) OEMKOD,
          (object) MALZEMEADI,
          (object) DIGERADI,
          (object) KULLANIMYERI,
          (object) BIRIMID,
          (object) GRUPID,
          (object) GRUPID2,
          (object) KDVID,
          (object) BOLUMID,
          (object) RAFNO,
          (object) GOZNO,
          (object) BARKOD,
          (object) TARIHKONTROL,
          (object) SERINOKONTROL,
          (object) KMKONTROL,
          (object) MALZEMEFOTO,
          (object) KAYITTIPIID,
          (object) SAVEUSER,
          (object) SAVEDATE,
          (object) EDITUSER,
          (object) EDITDATE,
          (object) SAVEMAC,
          (object) EDITMAC,
          (object) SAVEIP,
          (object) EDITIP,
          (object) GIRIS,
          (object) CIKIS,
          (object) KALAN
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Malzeemme.TBLMALZEMELERRow FindByID(int ID) => (Malzeemme.TBLMALZEMELERRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public override DataTable Clone()
      {
        Malzeemme.TBLMALZEMELERDataTable tblmalzemelerDataTable = (Malzeemme.TBLMALZEMELERDataTable) base.Clone();
        tblmalzemelerDataTable.InitVars();
        return (DataTable) tblmalzemelerDataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataTable CreateInstance() => (DataTable) new Malzeemme.TBLMALZEMELERDataTable();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal void InitVars()
      {
        this.columnID = this.Columns["ID"];
        this.columnKOD = this.Columns["KOD"];
        this.columnUFKOD = this.Columns["UFKOD"];
        this.columnOEMKOD = this.Columns["OEMKOD"];
        this.columnMALZEMEADI = this.Columns["MALZEMEADI"];
        this.columnDIGERADI = this.Columns["DIGERADI"];
        this.columnKULLANIMYERI = this.Columns["KULLANIMYERI"];
        this.columnBIRIMID = this.Columns["BIRIMID"];
        this.columnGRUPID = this.Columns["GRUPID"];
        this.columnGRUPID2 = this.Columns["GRUPID2"];
        this.columnKDVID = this.Columns["KDVID"];
        this.columnBOLUMID = this.Columns["BOLUMID"];
        this.columnRAFNO = this.Columns["RAFNO"];
        this.columnGOZNO = this.Columns["GOZNO"];
        this.columnBARKOD = this.Columns["BARKOD"];
        this.columnTARIHKONTROL = this.Columns["TARIHKONTROL"];
        this.columnSERINOKONTROL = this.Columns["SERINOKONTROL"];
        this.columnKMKONTROL = this.Columns["KMKONTROL"];
        this.columnMALZEMEFOTO = this.Columns["MALZEMEFOTO"];
        this.columnKAYITTIPIID = this.Columns["KAYITTIPIID"];
        this.columnSAVEUSER = this.Columns["SAVEUSER"];
        this.columnSAVEDATE = this.Columns["SAVEDATE"];
        this.columnEDITUSER = this.Columns["EDITUSER"];
        this.columnEDITDATE = this.Columns["EDITDATE"];
        this.columnSAVEMAC = this.Columns["SAVEMAC"];
        this.columnEDITMAC = this.Columns["EDITMAC"];
        this.columnSAVEIP = this.Columns["SAVEIP"];
        this.columnEDITIP = this.Columns["EDITIP"];
        this.columnGIRIS = this.Columns["GIRIS"];
        this.columnCIKIS = this.Columns["CIKIS"];
        this.columnKALAN = this.Columns["KALAN"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      private void InitClass()
      {
        this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnID);
        this.columnKOD = new DataColumn("KOD", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnKOD);
        this.columnUFKOD = new DataColumn("UFKOD", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnUFKOD);
        this.columnOEMKOD = new DataColumn("OEMKOD", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnOEMKOD);
        this.columnMALZEMEADI = new DataColumn("MALZEMEADI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMALZEMEADI);
        this.columnDIGERADI = new DataColumn("DIGERADI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDIGERADI);
        this.columnKULLANIMYERI = new DataColumn("KULLANIMYERI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnKULLANIMYERI);
        this.columnBIRIMID = new DataColumn("BIRIMID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBIRIMID);
        this.columnGRUPID = new DataColumn("GRUPID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGRUPID);
        this.columnGRUPID2 = new DataColumn("GRUPID2", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGRUPID2);
        this.columnKDVID = new DataColumn("KDVID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnKDVID);
        this.columnBOLUMID = new DataColumn("BOLUMID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBOLUMID);
        this.columnRAFNO = new DataColumn("RAFNO", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRAFNO);
        this.columnGOZNO = new DataColumn("GOZNO", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGOZNO);
        this.columnBARKOD = new DataColumn("BARKOD", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBARKOD);
        this.columnTARIHKONTROL = new DataColumn("TARIHKONTROL", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTARIHKONTROL);
        this.columnSERINOKONTROL = new DataColumn("SERINOKONTROL", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSERINOKONTROL);
        this.columnKMKONTROL = new DataColumn("KMKONTROL", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnKMKONTROL);
        this.columnMALZEMEFOTO = new DataColumn("MALZEMEFOTO", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMALZEMEFOTO);
        this.columnKAYITTIPIID = new DataColumn("KAYITTIPIID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnKAYITTIPIID);
        this.columnSAVEUSER = new DataColumn("SAVEUSER", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSAVEUSER);
        this.columnSAVEDATE = new DataColumn("SAVEDATE", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSAVEDATE);
        this.columnEDITUSER = new DataColumn("EDITUSER", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnEDITUSER);
        this.columnEDITDATE = new DataColumn("EDITDATE", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnEDITDATE);
        this.columnSAVEMAC = new DataColumn("SAVEMAC", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSAVEMAC);
        this.columnEDITMAC = new DataColumn("EDITMAC", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnEDITMAC);
        this.columnSAVEIP = new DataColumn("SAVEIP", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSAVEIP);
        this.columnEDITIP = new DataColumn("EDITIP", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnEDITIP);
        this.columnGIRIS = new DataColumn("GIRIS", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGIRIS);
        this.columnCIKIS = new DataColumn("CIKIS", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCIKIS);
        this.columnKALAN = new DataColumn("KALAN", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnKALAN);
        this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
        {
          this.columnID
        }, true));
        this.columnID.AutoIncrement = true;
        this.columnID.AutoIncrementSeed = -1L;
        this.columnID.AutoIncrementStep = -1L;
        this.columnID.AllowDBNull = false;
        this.columnID.ReadOnly = true;
        this.columnID.Unique = true;
        this.columnKOD.MaxLength = 50;
        this.columnUFKOD.MaxLength = 50;
        this.columnOEMKOD.MaxLength = 50;
        this.columnMALZEMEADI.MaxLength = 80;
        this.columnDIGERADI.MaxLength = 50;
        this.columnKULLANIMYERI.MaxLength = 150;
        this.columnRAFNO.MaxLength = 50;
        this.columnGOZNO.MaxLength = 50;
        this.columnBARKOD.MaxLength = 50;
        this.columnTARIHKONTROL.MaxLength = 50;
        this.columnSERINOKONTROL.MaxLength = 50;
        this.columnKMKONTROL.MaxLength = 50;
        this.columnMALZEMEFOTO.MaxLength = 50;
        this.columnSAVEUSER.MaxLength = 50;
        this.columnEDITUSER.MaxLength = 50;
        this.columnSAVEMAC.MaxLength = 20;
        this.columnEDITMAC.MaxLength = 20;
        this.columnSAVEIP.MaxLength = 20;
        this.columnEDITIP.MaxLength = 20;
        this.columnGIRIS.MaxLength = 50;
        this.columnCIKIS.MaxLength = 50;
        this.columnKALAN.MaxLength = 50;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Malzeemme.TBLMALZEMELERRow NewTBLMALZEMELERRow() => (Malzeemme.TBLMALZEMELERRow) this.NewRow();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new Malzeemme.TBLMALZEMELERRow(builder);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override Type GetRowType() => typeof (Malzeemme.TBLMALZEMELERRow);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.TBLMALZEMELERRowChanged == null)
          return;
        this.TBLMALZEMELERRowChanged((object) this, new Malzeemme.TBLMALZEMELERRowChangeEvent((Malzeemme.TBLMALZEMELERRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.TBLMALZEMELERRowChanging == null)
          return;
        this.TBLMALZEMELERRowChanging((object) this, new Malzeemme.TBLMALZEMELERRowChangeEvent((Malzeemme.TBLMALZEMELERRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.TBLMALZEMELERRowDeleted == null)
          return;
        this.TBLMALZEMELERRowDeleted((object) this, new Malzeemme.TBLMALZEMELERRowChangeEvent((Malzeemme.TBLMALZEMELERRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.TBLMALZEMELERRowDeleting == null)
          return;
        this.TBLMALZEMELERRowDeleting((object) this, new Malzeemme.TBLMALZEMELERRowChangeEvent((Malzeemme.TBLMALZEMELERRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void RemoveTBLMALZEMELERRow(Malzeemme.TBLMALZEMELERRow row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        Malzeemme malzeemme = new Malzeemme();
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
          FixedValue = malzeemme.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (TBLMALZEMELERDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = malzeemme.GetSchemaSerializable();
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
    public class TBLFILITREDataTable : TypedTableBase<Malzeemme.TBLFILITRERow>
    {
      private DataColumn columnID;
      private DataColumn columnKOD;
      private DataColumn columnUFKOD;
      private DataColumn columnOEMKOD;
      private DataColumn columnMALZEMEADI;
      private DataColumn columnDIGERADI;
      private DataColumn columnKULLANIMYERI;
      private DataColumn columnBIRIMID;
      private DataColumn columnGRUPID;
      private DataColumn columnGRUPID2;
      private DataColumn columnKDVID;
      private DataColumn columnBOLUMID;
      private DataColumn columnRAFNO;
      private DataColumn columnGOZNO;
      private DataColumn columnBARKOD;
      private DataColumn columnTARIHKONTROL;
      private DataColumn columnSERINOKONTROL;
      private DataColumn columnKMKONTROL;
      private DataColumn columnMALZEMEFOTO;
      private DataColumn columnKAYITTIPIID;
      private DataColumn columnSAVEUSER;
      private DataColumn columnSAVEDATE;
      private DataColumn columnEDITUSER;
      private DataColumn columnEDITDATE;
      private DataColumn columnSAVEMAC;
      private DataColumn columnEDITMAC;
      private DataColumn columnSAVEIP;
      private DataColumn columnEDITIP;
      private DataColumn columnGIRIS;
      private DataColumn columnCIKIS;
      private DataColumn columnKALAN;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public TBLFILITREDataTable()
      {
        this.TableName = "TBLFILITRE";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal TBLFILITREDataTable(DataTable table)
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
      protected TBLFILITREDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn IDColumn => this.columnID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn KODColumn => this.columnKOD;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn UFKODColumn => this.columnUFKOD;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn OEMKODColumn => this.columnOEMKOD;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MALZEMEADIColumn => this.columnMALZEMEADI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn DIGERADIColumn => this.columnDIGERADI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn KULLANIMYERIColumn => this.columnKULLANIMYERI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BIRIMIDColumn => this.columnBIRIMID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn GRUPIDColumn => this.columnGRUPID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn GRUPID2Column => this.columnGRUPID2;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn KDVIDColumn => this.columnKDVID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BOLUMIDColumn => this.columnBOLUMID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn RAFNOColumn => this.columnRAFNO;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn GOZNOColumn => this.columnGOZNO;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BARKODColumn => this.columnBARKOD;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn TARIHKONTROLColumn => this.columnTARIHKONTROL;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn SERINOKONTROLColumn => this.columnSERINOKONTROL;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn KMKONTROLColumn => this.columnKMKONTROL;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MALZEMEFOTOColumn => this.columnMALZEMEFOTO;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn KAYITTIPIIDColumn => this.columnKAYITTIPIID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn SAVEUSERColumn => this.columnSAVEUSER;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn SAVEDATEColumn => this.columnSAVEDATE;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn EDITUSERColumn => this.columnEDITUSER;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn EDITDATEColumn => this.columnEDITDATE;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn SAVEMACColumn => this.columnSAVEMAC;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn EDITMACColumn => this.columnEDITMAC;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn SAVEIPColumn => this.columnSAVEIP;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn EDITIPColumn => this.columnEDITIP;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn GIRISColumn => this.columnGIRIS;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn CIKISColumn => this.columnCIKIS;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn KALANColumn => this.columnKALAN;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Malzeemme.TBLFILITRERow this[int index] => (Malzeemme.TBLFILITRERow) this.Rows[index];

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event Malzeemme.TBLFILITRERowChangeEventHandler TBLFILITRERowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event Malzeemme.TBLFILITRERowChangeEventHandler TBLFILITRERowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event Malzeemme.TBLFILITRERowChangeEventHandler TBLFILITRERowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event Malzeemme.TBLFILITRERowChangeEventHandler TBLFILITRERowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void AddTBLFILITRERow(Malzeemme.TBLFILITRERow row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Malzeemme.TBLFILITRERow AddTBLFILITRERow(
        string KOD,
        string UFKOD,
        string OEMKOD,
        string MALZEMEADI,
        string DIGERADI,
        string KULLANIMYERI,
        int BIRIMID,
        int GRUPID,
        int GRUPID2,
        int KDVID,
        int BOLUMID,
        string RAFNO,
        string GOZNO,
        string BARKOD,
        string TARIHKONTROL,
        string SERINOKONTROL,
        string KMKONTROL,
        string MALZEMEFOTO,
        int KAYITTIPIID,
        string SAVEUSER,
        DateTime SAVEDATE,
        string EDITUSER,
        DateTime EDITDATE,
        string SAVEMAC,
        string EDITMAC,
        string SAVEIP,
        string EDITIP,
        string GIRIS,
        string CIKIS,
        string KALAN)
      {
        Malzeemme.TBLFILITRERow row = (Malzeemme.TBLFILITRERow) this.NewRow();
        object[] objArray = new object[31]
        {
          null,
          (object) KOD,
          (object) UFKOD,
          (object) OEMKOD,
          (object) MALZEMEADI,
          (object) DIGERADI,
          (object) KULLANIMYERI,
          (object) BIRIMID,
          (object) GRUPID,
          (object) GRUPID2,
          (object) KDVID,
          (object) BOLUMID,
          (object) RAFNO,
          (object) GOZNO,
          (object) BARKOD,
          (object) TARIHKONTROL,
          (object) SERINOKONTROL,
          (object) KMKONTROL,
          (object) MALZEMEFOTO,
          (object) KAYITTIPIID,
          (object) SAVEUSER,
          (object) SAVEDATE,
          (object) EDITUSER,
          (object) EDITDATE,
          (object) SAVEMAC,
          (object) EDITMAC,
          (object) SAVEIP,
          (object) EDITIP,
          (object) GIRIS,
          (object) CIKIS,
          (object) KALAN
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Malzeemme.TBLFILITRERow FindByID(int ID) => (Malzeemme.TBLFILITRERow) this.Rows.Find(new object[1]
      {
        (object) ID
      });

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public override DataTable Clone()
      {
        Malzeemme.TBLFILITREDataTable tblfilitreDataTable = (Malzeemme.TBLFILITREDataTable) base.Clone();
        tblfilitreDataTable.InitVars();
        return (DataTable) tblfilitreDataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataTable CreateInstance() => (DataTable) new Malzeemme.TBLFILITREDataTable();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal void InitVars()
      {
        this.columnID = this.Columns["ID"];
        this.columnKOD = this.Columns["KOD"];
        this.columnUFKOD = this.Columns["UFKOD"];
        this.columnOEMKOD = this.Columns["OEMKOD"];
        this.columnMALZEMEADI = this.Columns["MALZEMEADI"];
        this.columnDIGERADI = this.Columns["DIGERADI"];
        this.columnKULLANIMYERI = this.Columns["KULLANIMYERI"];
        this.columnBIRIMID = this.Columns["BIRIMID"];
        this.columnGRUPID = this.Columns["GRUPID"];
        this.columnGRUPID2 = this.Columns["GRUPID2"];
        this.columnKDVID = this.Columns["KDVID"];
        this.columnBOLUMID = this.Columns["BOLUMID"];
        this.columnRAFNO = this.Columns["RAFNO"];
        this.columnGOZNO = this.Columns["GOZNO"];
        this.columnBARKOD = this.Columns["BARKOD"];
        this.columnTARIHKONTROL = this.Columns["TARIHKONTROL"];
        this.columnSERINOKONTROL = this.Columns["SERINOKONTROL"];
        this.columnKMKONTROL = this.Columns["KMKONTROL"];
        this.columnMALZEMEFOTO = this.Columns["MALZEMEFOTO"];
        this.columnKAYITTIPIID = this.Columns["KAYITTIPIID"];
        this.columnSAVEUSER = this.Columns["SAVEUSER"];
        this.columnSAVEDATE = this.Columns["SAVEDATE"];
        this.columnEDITUSER = this.Columns["EDITUSER"];
        this.columnEDITDATE = this.Columns["EDITDATE"];
        this.columnSAVEMAC = this.Columns["SAVEMAC"];
        this.columnEDITMAC = this.Columns["EDITMAC"];
        this.columnSAVEIP = this.Columns["SAVEIP"];
        this.columnEDITIP = this.Columns["EDITIP"];
        this.columnGIRIS = this.Columns["GIRIS"];
        this.columnCIKIS = this.Columns["CIKIS"];
        this.columnKALAN = this.Columns["KALAN"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      private void InitClass()
      {
        this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnID);
        this.columnKOD = new DataColumn("KOD", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnKOD);
        this.columnUFKOD = new DataColumn("UFKOD", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnUFKOD);
        this.columnOEMKOD = new DataColumn("OEMKOD", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnOEMKOD);
        this.columnMALZEMEADI = new DataColumn("MALZEMEADI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMALZEMEADI);
        this.columnDIGERADI = new DataColumn("DIGERADI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDIGERADI);
        this.columnKULLANIMYERI = new DataColumn("KULLANIMYERI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnKULLANIMYERI);
        this.columnBIRIMID = new DataColumn("BIRIMID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBIRIMID);
        this.columnGRUPID = new DataColumn("GRUPID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGRUPID);
        this.columnGRUPID2 = new DataColumn("GRUPID2", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGRUPID2);
        this.columnKDVID = new DataColumn("KDVID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnKDVID);
        this.columnBOLUMID = new DataColumn("BOLUMID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBOLUMID);
        this.columnRAFNO = new DataColumn("RAFNO", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRAFNO);
        this.columnGOZNO = new DataColumn("GOZNO", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGOZNO);
        this.columnBARKOD = new DataColumn("BARKOD", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBARKOD);
        this.columnTARIHKONTROL = new DataColumn("TARIHKONTROL", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTARIHKONTROL);
        this.columnSERINOKONTROL = new DataColumn("SERINOKONTROL", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSERINOKONTROL);
        this.columnKMKONTROL = new DataColumn("KMKONTROL", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnKMKONTROL);
        this.columnMALZEMEFOTO = new DataColumn("MALZEMEFOTO", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMALZEMEFOTO);
        this.columnKAYITTIPIID = new DataColumn("KAYITTIPIID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnKAYITTIPIID);
        this.columnSAVEUSER = new DataColumn("SAVEUSER", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSAVEUSER);
        this.columnSAVEDATE = new DataColumn("SAVEDATE", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSAVEDATE);
        this.columnEDITUSER = new DataColumn("EDITUSER", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnEDITUSER);
        this.columnEDITDATE = new DataColumn("EDITDATE", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnEDITDATE);
        this.columnSAVEMAC = new DataColumn("SAVEMAC", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSAVEMAC);
        this.columnEDITMAC = new DataColumn("EDITMAC", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnEDITMAC);
        this.columnSAVEIP = new DataColumn("SAVEIP", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSAVEIP);
        this.columnEDITIP = new DataColumn("EDITIP", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnEDITIP);
        this.columnGIRIS = new DataColumn("GIRIS", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGIRIS);
        this.columnCIKIS = new DataColumn("CIKIS", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCIKIS);
        this.columnKALAN = new DataColumn("KALAN", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnKALAN);
        this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
        {
          this.columnID
        }, true));
        this.columnID.AutoIncrement = true;
        this.columnID.AutoIncrementSeed = -1L;
        this.columnID.AutoIncrementStep = -1L;
        this.columnID.AllowDBNull = false;
        this.columnID.ReadOnly = true;
        this.columnID.Unique = true;
        this.columnKOD.MaxLength = 50;
        this.columnUFKOD.MaxLength = 50;
        this.columnOEMKOD.MaxLength = 50;
        this.columnMALZEMEADI.MaxLength = 80;
        this.columnDIGERADI.MaxLength = 50;
        this.columnKULLANIMYERI.MaxLength = 150;
        this.columnRAFNO.MaxLength = 50;
        this.columnGOZNO.MaxLength = 50;
        this.columnBARKOD.MaxLength = 50;
        this.columnTARIHKONTROL.MaxLength = 50;
        this.columnSERINOKONTROL.MaxLength = 50;
        this.columnKMKONTROL.MaxLength = 50;
        this.columnMALZEMEFOTO.MaxLength = 50;
        this.columnSAVEUSER.MaxLength = 50;
        this.columnEDITUSER.MaxLength = 50;
        this.columnSAVEMAC.MaxLength = 20;
        this.columnEDITMAC.MaxLength = 20;
        this.columnSAVEIP.MaxLength = 20;
        this.columnEDITIP.MaxLength = 20;
        this.columnGIRIS.MaxLength = 50;
        this.columnCIKIS.MaxLength = 50;
        this.columnKALAN.MaxLength = 50;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Malzeemme.TBLFILITRERow NewTBLFILITRERow() => (Malzeemme.TBLFILITRERow) this.NewRow();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new Malzeemme.TBLFILITRERow(builder);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override Type GetRowType() => typeof (Malzeemme.TBLFILITRERow);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.TBLFILITRERowChanged == null)
          return;
        this.TBLFILITRERowChanged((object) this, new Malzeemme.TBLFILITRERowChangeEvent((Malzeemme.TBLFILITRERow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.TBLFILITRERowChanging == null)
          return;
        this.TBLFILITRERowChanging((object) this, new Malzeemme.TBLFILITRERowChangeEvent((Malzeemme.TBLFILITRERow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.TBLFILITRERowDeleted == null)
          return;
        this.TBLFILITRERowDeleted((object) this, new Malzeemme.TBLFILITRERowChangeEvent((Malzeemme.TBLFILITRERow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.TBLFILITRERowDeleting == null)
          return;
        this.TBLFILITRERowDeleting((object) this, new Malzeemme.TBLFILITRERowChangeEvent((Malzeemme.TBLFILITRERow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void RemoveTBLFILITRERow(Malzeemme.TBLFILITRERow row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        Malzeemme malzeemme = new Malzeemme();
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
          FixedValue = malzeemme.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (TBLFILITREDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = malzeemme.GetSchemaSerializable();
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
    public class TBLYAGDataTable : TypedTableBase<Malzeemme.TBLYAGRow>
    {
      private DataColumn columnID;
      private DataColumn columnKOD;
      private DataColumn columnUFKOD;
      private DataColumn columnOEMKOD;
      private DataColumn columnMALZEMEADI;
      private DataColumn columnDIGERADI;
      private DataColumn columnKULLANIMYERI;
      private DataColumn columnBIRIMID;
      private DataColumn columnGRUPID;
      private DataColumn columnGRUPID2;
      private DataColumn columnKDVID;
      private DataColumn columnBOLUMID;
      private DataColumn columnRAFNO;
      private DataColumn columnGOZNO;
      private DataColumn columnBARKOD;
      private DataColumn columnTARIHKONTROL;
      private DataColumn columnSERINOKONTROL;
      private DataColumn columnKMKONTROL;
      private DataColumn columnMALZEMEFOTO;
      private DataColumn columnKAYITTIPIID;
      private DataColumn columnSAVEUSER;
      private DataColumn columnSAVEDATE;
      private DataColumn columnEDITUSER;
      private DataColumn columnEDITDATE;
      private DataColumn columnSAVEMAC;
      private DataColumn columnEDITMAC;
      private DataColumn columnSAVEIP;
      private DataColumn columnEDITIP;
      private DataColumn columnGIRIS;
      private DataColumn columnCIKIS;
      private DataColumn columnKALAN;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public TBLYAGDataTable()
      {
        this.TableName = "TBLYAG";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal TBLYAGDataTable(DataTable table)
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
      protected TBLYAGDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn IDColumn => this.columnID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn KODColumn => this.columnKOD;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn UFKODColumn => this.columnUFKOD;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn OEMKODColumn => this.columnOEMKOD;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MALZEMEADIColumn => this.columnMALZEMEADI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn DIGERADIColumn => this.columnDIGERADI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn KULLANIMYERIColumn => this.columnKULLANIMYERI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BIRIMIDColumn => this.columnBIRIMID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn GRUPIDColumn => this.columnGRUPID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn GRUPID2Column => this.columnGRUPID2;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn KDVIDColumn => this.columnKDVID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BOLUMIDColumn => this.columnBOLUMID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn RAFNOColumn => this.columnRAFNO;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn GOZNOColumn => this.columnGOZNO;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BARKODColumn => this.columnBARKOD;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn TARIHKONTROLColumn => this.columnTARIHKONTROL;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn SERINOKONTROLColumn => this.columnSERINOKONTROL;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn KMKONTROLColumn => this.columnKMKONTROL;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MALZEMEFOTOColumn => this.columnMALZEMEFOTO;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn KAYITTIPIIDColumn => this.columnKAYITTIPIID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn SAVEUSERColumn => this.columnSAVEUSER;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn SAVEDATEColumn => this.columnSAVEDATE;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn EDITUSERColumn => this.columnEDITUSER;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn EDITDATEColumn => this.columnEDITDATE;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn SAVEMACColumn => this.columnSAVEMAC;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn EDITMACColumn => this.columnEDITMAC;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn SAVEIPColumn => this.columnSAVEIP;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn EDITIPColumn => this.columnEDITIP;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn GIRISColumn => this.columnGIRIS;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn CIKISColumn => this.columnCIKIS;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn KALANColumn => this.columnKALAN;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Malzeemme.TBLYAGRow this[int index] => (Malzeemme.TBLYAGRow) this.Rows[index];

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event Malzeemme.TBLYAGRowChangeEventHandler TBLYAGRowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event Malzeemme.TBLYAGRowChangeEventHandler TBLYAGRowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event Malzeemme.TBLYAGRowChangeEventHandler TBLYAGRowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event Malzeemme.TBLYAGRowChangeEventHandler TBLYAGRowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void AddTBLYAGRow(Malzeemme.TBLYAGRow row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Malzeemme.TBLYAGRow AddTBLYAGRow(
        string KOD,
        string UFKOD,
        string OEMKOD,
        string MALZEMEADI,
        string DIGERADI,
        string KULLANIMYERI,
        int BIRIMID,
        int GRUPID,
        int GRUPID2,
        int KDVID,
        int BOLUMID,
        string RAFNO,
        string GOZNO,
        string BARKOD,
        string TARIHKONTROL,
        string SERINOKONTROL,
        string KMKONTROL,
        string MALZEMEFOTO,
        int KAYITTIPIID,
        string SAVEUSER,
        DateTime SAVEDATE,
        string EDITUSER,
        DateTime EDITDATE,
        string SAVEMAC,
        string EDITMAC,
        string SAVEIP,
        string EDITIP,
        string GIRIS,
        string CIKIS,
        string KALAN)
      {
        Malzeemme.TBLYAGRow row = (Malzeemme.TBLYAGRow) this.NewRow();
        object[] objArray = new object[31]
        {
          null,
          (object) KOD,
          (object) UFKOD,
          (object) OEMKOD,
          (object) MALZEMEADI,
          (object) DIGERADI,
          (object) KULLANIMYERI,
          (object) BIRIMID,
          (object) GRUPID,
          (object) GRUPID2,
          (object) KDVID,
          (object) BOLUMID,
          (object) RAFNO,
          (object) GOZNO,
          (object) BARKOD,
          (object) TARIHKONTROL,
          (object) SERINOKONTROL,
          (object) KMKONTROL,
          (object) MALZEMEFOTO,
          (object) KAYITTIPIID,
          (object) SAVEUSER,
          (object) SAVEDATE,
          (object) EDITUSER,
          (object) EDITDATE,
          (object) SAVEMAC,
          (object) EDITMAC,
          (object) SAVEIP,
          (object) EDITIP,
          (object) GIRIS,
          (object) CIKIS,
          (object) KALAN
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Malzeemme.TBLYAGRow FindByID(int ID) => (Malzeemme.TBLYAGRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public override DataTable Clone()
      {
        Malzeemme.TBLYAGDataTable tblyagDataTable = (Malzeemme.TBLYAGDataTable) base.Clone();
        tblyagDataTable.InitVars();
        return (DataTable) tblyagDataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataTable CreateInstance() => (DataTable) new Malzeemme.TBLYAGDataTable();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal void InitVars()
      {
        this.columnID = this.Columns["ID"];
        this.columnKOD = this.Columns["KOD"];
        this.columnUFKOD = this.Columns["UFKOD"];
        this.columnOEMKOD = this.Columns["OEMKOD"];
        this.columnMALZEMEADI = this.Columns["MALZEMEADI"];
        this.columnDIGERADI = this.Columns["DIGERADI"];
        this.columnKULLANIMYERI = this.Columns["KULLANIMYERI"];
        this.columnBIRIMID = this.Columns["BIRIMID"];
        this.columnGRUPID = this.Columns["GRUPID"];
        this.columnGRUPID2 = this.Columns["GRUPID2"];
        this.columnKDVID = this.Columns["KDVID"];
        this.columnBOLUMID = this.Columns["BOLUMID"];
        this.columnRAFNO = this.Columns["RAFNO"];
        this.columnGOZNO = this.Columns["GOZNO"];
        this.columnBARKOD = this.Columns["BARKOD"];
        this.columnTARIHKONTROL = this.Columns["TARIHKONTROL"];
        this.columnSERINOKONTROL = this.Columns["SERINOKONTROL"];
        this.columnKMKONTROL = this.Columns["KMKONTROL"];
        this.columnMALZEMEFOTO = this.Columns["MALZEMEFOTO"];
        this.columnKAYITTIPIID = this.Columns["KAYITTIPIID"];
        this.columnSAVEUSER = this.Columns["SAVEUSER"];
        this.columnSAVEDATE = this.Columns["SAVEDATE"];
        this.columnEDITUSER = this.Columns["EDITUSER"];
        this.columnEDITDATE = this.Columns["EDITDATE"];
        this.columnSAVEMAC = this.Columns["SAVEMAC"];
        this.columnEDITMAC = this.Columns["EDITMAC"];
        this.columnSAVEIP = this.Columns["SAVEIP"];
        this.columnEDITIP = this.Columns["EDITIP"];
        this.columnGIRIS = this.Columns["GIRIS"];
        this.columnCIKIS = this.Columns["CIKIS"];
        this.columnKALAN = this.Columns["KALAN"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      private void InitClass()
      {
        this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnID);
        this.columnKOD = new DataColumn("KOD", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnKOD);
        this.columnUFKOD = new DataColumn("UFKOD", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnUFKOD);
        this.columnOEMKOD = new DataColumn("OEMKOD", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnOEMKOD);
        this.columnMALZEMEADI = new DataColumn("MALZEMEADI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMALZEMEADI);
        this.columnDIGERADI = new DataColumn("DIGERADI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDIGERADI);
        this.columnKULLANIMYERI = new DataColumn("KULLANIMYERI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnKULLANIMYERI);
        this.columnBIRIMID = new DataColumn("BIRIMID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBIRIMID);
        this.columnGRUPID = new DataColumn("GRUPID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGRUPID);
        this.columnGRUPID2 = new DataColumn("GRUPID2", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGRUPID2);
        this.columnKDVID = new DataColumn("KDVID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnKDVID);
        this.columnBOLUMID = new DataColumn("BOLUMID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBOLUMID);
        this.columnRAFNO = new DataColumn("RAFNO", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRAFNO);
        this.columnGOZNO = new DataColumn("GOZNO", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGOZNO);
        this.columnBARKOD = new DataColumn("BARKOD", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBARKOD);
        this.columnTARIHKONTROL = new DataColumn("TARIHKONTROL", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTARIHKONTROL);
        this.columnSERINOKONTROL = new DataColumn("SERINOKONTROL", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSERINOKONTROL);
        this.columnKMKONTROL = new DataColumn("KMKONTROL", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnKMKONTROL);
        this.columnMALZEMEFOTO = new DataColumn("MALZEMEFOTO", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMALZEMEFOTO);
        this.columnKAYITTIPIID = new DataColumn("KAYITTIPIID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnKAYITTIPIID);
        this.columnSAVEUSER = new DataColumn("SAVEUSER", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSAVEUSER);
        this.columnSAVEDATE = new DataColumn("SAVEDATE", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSAVEDATE);
        this.columnEDITUSER = new DataColumn("EDITUSER", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnEDITUSER);
        this.columnEDITDATE = new DataColumn("EDITDATE", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnEDITDATE);
        this.columnSAVEMAC = new DataColumn("SAVEMAC", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSAVEMAC);
        this.columnEDITMAC = new DataColumn("EDITMAC", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnEDITMAC);
        this.columnSAVEIP = new DataColumn("SAVEIP", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSAVEIP);
        this.columnEDITIP = new DataColumn("EDITIP", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnEDITIP);
        this.columnGIRIS = new DataColumn("GIRIS", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGIRIS);
        this.columnCIKIS = new DataColumn("CIKIS", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCIKIS);
        this.columnKALAN = new DataColumn("KALAN", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnKALAN);
        this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
        {
          this.columnID
        }, true));
        this.columnID.AutoIncrement = true;
        this.columnID.AutoIncrementSeed = -1L;
        this.columnID.AutoIncrementStep = -1L;
        this.columnID.AllowDBNull = false;
        this.columnID.ReadOnly = true;
        this.columnID.Unique = true;
        this.columnKOD.MaxLength = 50;
        this.columnUFKOD.MaxLength = 50;
        this.columnOEMKOD.MaxLength = 50;
        this.columnMALZEMEADI.MaxLength = 80;
        this.columnDIGERADI.MaxLength = 50;
        this.columnKULLANIMYERI.MaxLength = 150;
        this.columnRAFNO.MaxLength = 50;
        this.columnGOZNO.MaxLength = 50;
        this.columnBARKOD.MaxLength = 50;
        this.columnTARIHKONTROL.MaxLength = 50;
        this.columnSERINOKONTROL.MaxLength = 50;
        this.columnKMKONTROL.MaxLength = 50;
        this.columnMALZEMEFOTO.MaxLength = 50;
        this.columnSAVEUSER.MaxLength = 50;
        this.columnEDITUSER.MaxLength = 50;
        this.columnSAVEMAC.MaxLength = 20;
        this.columnEDITMAC.MaxLength = 20;
        this.columnSAVEIP.MaxLength = 20;
        this.columnEDITIP.MaxLength = 20;
        this.columnGIRIS.MaxLength = 50;
        this.columnCIKIS.MaxLength = 50;
        this.columnKALAN.MaxLength = 50;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Malzeemme.TBLYAGRow NewTBLYAGRow() => (Malzeemme.TBLYAGRow) this.NewRow();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new Malzeemme.TBLYAGRow(builder);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override Type GetRowType() => typeof (Malzeemme.TBLYAGRow);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.TBLYAGRowChanged == null)
          return;
        this.TBLYAGRowChanged((object) this, new Malzeemme.TBLYAGRowChangeEvent((Malzeemme.TBLYAGRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.TBLYAGRowChanging == null)
          return;
        this.TBLYAGRowChanging((object) this, new Malzeemme.TBLYAGRowChangeEvent((Malzeemme.TBLYAGRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.TBLYAGRowDeleted == null)
          return;
        this.TBLYAGRowDeleted((object) this, new Malzeemme.TBLYAGRowChangeEvent((Malzeemme.TBLYAGRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.TBLYAGRowDeleting == null)
          return;
        this.TBLYAGRowDeleting((object) this, new Malzeemme.TBLYAGRowChangeEvent((Malzeemme.TBLYAGRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void RemoveTBLYAGRow(Malzeemme.TBLYAGRow row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        Malzeemme malzeemme = new Malzeemme();
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
          FixedValue = malzeemme.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (TBLYAGDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = malzeemme.GetSchemaSerializable();
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

    public class TBLMALZEMELERRow : DataRow
    {
      private Malzeemme.TBLMALZEMELERDataTable tableTBLMALZEMELER;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal TBLMALZEMELERRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableTBLMALZEMELER = (Malzeemme.TBLMALZEMELERDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ID
      {
        get => (int) this[this.tableTBLMALZEMELER.IDColumn];
        set => this[this.tableTBLMALZEMELER.IDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string KOD
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLMALZEMELER.KODColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLMALZEMELER' tablosundaki 'KOD' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLMALZEMELER.KODColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string UFKOD
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLMALZEMELER.UFKODColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLMALZEMELER' tablosundaki 'UFKOD' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLMALZEMELER.UFKODColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string OEMKOD
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLMALZEMELER.OEMKODColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLMALZEMELER' tablosundaki 'OEMKOD' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLMALZEMELER.OEMKODColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string MALZEMEADI
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLMALZEMELER.MALZEMEADIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLMALZEMELER' tablosundaki 'MALZEMEADI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLMALZEMELER.MALZEMEADIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string DIGERADI
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLMALZEMELER.DIGERADIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLMALZEMELER' tablosundaki 'DIGERADI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLMALZEMELER.DIGERADIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string KULLANIMYERI
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLMALZEMELER.KULLANIMYERIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLMALZEMELER' tablosundaki 'KULLANIMYERI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLMALZEMELER.KULLANIMYERIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int BIRIMID
      {
        get
        {
          try
          {
            return (int) this[this.tableTBLMALZEMELER.BIRIMIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLMALZEMELER' tablosundaki 'BIRIMID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLMALZEMELER.BIRIMIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int GRUPID
      {
        get
        {
          try
          {
            return (int) this[this.tableTBLMALZEMELER.GRUPIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLMALZEMELER' tablosundaki 'GRUPID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLMALZEMELER.GRUPIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int GRUPID2
      {
        get
        {
          try
          {
            return (int) this[this.tableTBLMALZEMELER.GRUPID2Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLMALZEMELER' tablosundaki 'GRUPID2' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLMALZEMELER.GRUPID2Column] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int KDVID
      {
        get
        {
          try
          {
            return (int) this[this.tableTBLMALZEMELER.KDVIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLMALZEMELER' tablosundaki 'KDVID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLMALZEMELER.KDVIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int BOLUMID
      {
        get
        {
          try
          {
            return (int) this[this.tableTBLMALZEMELER.BOLUMIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLMALZEMELER' tablosundaki 'BOLUMID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLMALZEMELER.BOLUMIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string RAFNO
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLMALZEMELER.RAFNOColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLMALZEMELER' tablosundaki 'RAFNO' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLMALZEMELER.RAFNOColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string GOZNO
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLMALZEMELER.GOZNOColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLMALZEMELER' tablosundaki 'GOZNO' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLMALZEMELER.GOZNOColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BARKOD
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLMALZEMELER.BARKODColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLMALZEMELER' tablosundaki 'BARKOD' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLMALZEMELER.BARKODColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string TARIHKONTROL
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLMALZEMELER.TARIHKONTROLColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLMALZEMELER' tablosundaki 'TARIHKONTROL' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLMALZEMELER.TARIHKONTROLColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string SERINOKONTROL
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLMALZEMELER.SERINOKONTROLColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLMALZEMELER' tablosundaki 'SERINOKONTROL' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLMALZEMELER.SERINOKONTROLColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string KMKONTROL
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLMALZEMELER.KMKONTROLColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLMALZEMELER' tablosundaki 'KMKONTROL' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLMALZEMELER.KMKONTROLColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string MALZEMEFOTO
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLMALZEMELER.MALZEMEFOTOColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLMALZEMELER' tablosundaki 'MALZEMEFOTO' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLMALZEMELER.MALZEMEFOTOColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int KAYITTIPIID
      {
        get
        {
          try
          {
            return (int) this[this.tableTBLMALZEMELER.KAYITTIPIIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLMALZEMELER' tablosundaki 'KAYITTIPIID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLMALZEMELER.KAYITTIPIIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string SAVEUSER
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLMALZEMELER.SAVEUSERColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLMALZEMELER' tablosundaki 'SAVEUSER' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLMALZEMELER.SAVEUSERColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DateTime SAVEDATE
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableTBLMALZEMELER.SAVEDATEColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLMALZEMELER' tablosundaki 'SAVEDATE' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLMALZEMELER.SAVEDATEColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string EDITUSER
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLMALZEMELER.EDITUSERColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLMALZEMELER' tablosundaki 'EDITUSER' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLMALZEMELER.EDITUSERColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DateTime EDITDATE
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableTBLMALZEMELER.EDITDATEColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLMALZEMELER' tablosundaki 'EDITDATE' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLMALZEMELER.EDITDATEColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string SAVEMAC
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLMALZEMELER.SAVEMACColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLMALZEMELER' tablosundaki 'SAVEMAC' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLMALZEMELER.SAVEMACColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string EDITMAC
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLMALZEMELER.EDITMACColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLMALZEMELER' tablosundaki 'EDITMAC' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLMALZEMELER.EDITMACColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string SAVEIP
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLMALZEMELER.SAVEIPColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLMALZEMELER' tablosundaki 'SAVEIP' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLMALZEMELER.SAVEIPColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string EDITIP
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLMALZEMELER.EDITIPColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLMALZEMELER' tablosundaki 'EDITIP' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLMALZEMELER.EDITIPColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string GIRIS
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLMALZEMELER.GIRISColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLMALZEMELER' tablosundaki 'GIRIS' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLMALZEMELER.GIRISColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string CIKIS
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLMALZEMELER.CIKISColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLMALZEMELER' tablosundaki 'CIKIS' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLMALZEMELER.CIKISColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string KALAN
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLMALZEMELER.KALANColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLMALZEMELER' tablosundaki 'KALAN' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLMALZEMELER.KALANColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsKODNull() => this.IsNull(this.tableTBLMALZEMELER.KODColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetKODNull() => this[this.tableTBLMALZEMELER.KODColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsUFKODNull() => this.IsNull(this.tableTBLMALZEMELER.UFKODColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetUFKODNull() => this[this.tableTBLMALZEMELER.UFKODColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsOEMKODNull() => this.IsNull(this.tableTBLMALZEMELER.OEMKODColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetOEMKODNull() => this[this.tableTBLMALZEMELER.OEMKODColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMALZEMEADINull() => this.IsNull(this.tableTBLMALZEMELER.MALZEMEADIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMALZEMEADINull() => this[this.tableTBLMALZEMELER.MALZEMEADIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsDIGERADINull() => this.IsNull(this.tableTBLMALZEMELER.DIGERADIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetDIGERADINull() => this[this.tableTBLMALZEMELER.DIGERADIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsKULLANIMYERINull() => this.IsNull(this.tableTBLMALZEMELER.KULLANIMYERIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetKULLANIMYERINull() => this[this.tableTBLMALZEMELER.KULLANIMYERIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBIRIMIDNull() => this.IsNull(this.tableTBLMALZEMELER.BIRIMIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBIRIMIDNull() => this[this.tableTBLMALZEMELER.BIRIMIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsGRUPIDNull() => this.IsNull(this.tableTBLMALZEMELER.GRUPIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetGRUPIDNull() => this[this.tableTBLMALZEMELER.GRUPIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsGRUPID2Null() => this.IsNull(this.tableTBLMALZEMELER.GRUPID2Column);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetGRUPID2Null() => this[this.tableTBLMALZEMELER.GRUPID2Column] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsKDVIDNull() => this.IsNull(this.tableTBLMALZEMELER.KDVIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetKDVIDNull() => this[this.tableTBLMALZEMELER.KDVIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBOLUMIDNull() => this.IsNull(this.tableTBLMALZEMELER.BOLUMIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBOLUMIDNull() => this[this.tableTBLMALZEMELER.BOLUMIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsRAFNONull() => this.IsNull(this.tableTBLMALZEMELER.RAFNOColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetRAFNONull() => this[this.tableTBLMALZEMELER.RAFNOColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsGOZNONull() => this.IsNull(this.tableTBLMALZEMELER.GOZNOColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetGOZNONull() => this[this.tableTBLMALZEMELER.GOZNOColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBARKODNull() => this.IsNull(this.tableTBLMALZEMELER.BARKODColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBARKODNull() => this[this.tableTBLMALZEMELER.BARKODColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsTARIHKONTROLNull() => this.IsNull(this.tableTBLMALZEMELER.TARIHKONTROLColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetTARIHKONTROLNull() => this[this.tableTBLMALZEMELER.TARIHKONTROLColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsSERINOKONTROLNull() => this.IsNull(this.tableTBLMALZEMELER.SERINOKONTROLColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetSERINOKONTROLNull() => this[this.tableTBLMALZEMELER.SERINOKONTROLColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsKMKONTROLNull() => this.IsNull(this.tableTBLMALZEMELER.KMKONTROLColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetKMKONTROLNull() => this[this.tableTBLMALZEMELER.KMKONTROLColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMALZEMEFOTONull() => this.IsNull(this.tableTBLMALZEMELER.MALZEMEFOTOColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMALZEMEFOTONull() => this[this.tableTBLMALZEMELER.MALZEMEFOTOColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsKAYITTIPIIDNull() => this.IsNull(this.tableTBLMALZEMELER.KAYITTIPIIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetKAYITTIPIIDNull() => this[this.tableTBLMALZEMELER.KAYITTIPIIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsSAVEUSERNull() => this.IsNull(this.tableTBLMALZEMELER.SAVEUSERColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetSAVEUSERNull() => this[this.tableTBLMALZEMELER.SAVEUSERColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsSAVEDATENull() => this.IsNull(this.tableTBLMALZEMELER.SAVEDATEColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetSAVEDATENull() => this[this.tableTBLMALZEMELER.SAVEDATEColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsEDITUSERNull() => this.IsNull(this.tableTBLMALZEMELER.EDITUSERColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetEDITUSERNull() => this[this.tableTBLMALZEMELER.EDITUSERColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsEDITDATENull() => this.IsNull(this.tableTBLMALZEMELER.EDITDATEColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetEDITDATENull() => this[this.tableTBLMALZEMELER.EDITDATEColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsSAVEMACNull() => this.IsNull(this.tableTBLMALZEMELER.SAVEMACColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetSAVEMACNull() => this[this.tableTBLMALZEMELER.SAVEMACColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsEDITMACNull() => this.IsNull(this.tableTBLMALZEMELER.EDITMACColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetEDITMACNull() => this[this.tableTBLMALZEMELER.EDITMACColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsSAVEIPNull() => this.IsNull(this.tableTBLMALZEMELER.SAVEIPColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetSAVEIPNull() => this[this.tableTBLMALZEMELER.SAVEIPColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsEDITIPNull() => this.IsNull(this.tableTBLMALZEMELER.EDITIPColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetEDITIPNull() => this[this.tableTBLMALZEMELER.EDITIPColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsGIRISNull() => this.IsNull(this.tableTBLMALZEMELER.GIRISColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetGIRISNull() => this[this.tableTBLMALZEMELER.GIRISColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsCIKISNull() => this.IsNull(this.tableTBLMALZEMELER.CIKISColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetCIKISNull() => this[this.tableTBLMALZEMELER.CIKISColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsKALANNull() => this.IsNull(this.tableTBLMALZEMELER.KALANColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetKALANNull() => this[this.tableTBLMALZEMELER.KALANColumn] = Convert.DBNull;
    }

    public class TBLFILITRERow : DataRow
    {
      private Malzeemme.TBLFILITREDataTable tableTBLFILITRE;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal TBLFILITRERow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableTBLFILITRE = (Malzeemme.TBLFILITREDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ID
      {
        get => (int) this[this.tableTBLFILITRE.IDColumn];
        set => this[this.tableTBLFILITRE.IDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string KOD
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLFILITRE.KODColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLFILITRE' tablosundaki 'KOD' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLFILITRE.KODColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string UFKOD
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLFILITRE.UFKODColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLFILITRE' tablosundaki 'UFKOD' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLFILITRE.UFKODColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string OEMKOD
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLFILITRE.OEMKODColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLFILITRE' tablosundaki 'OEMKOD' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLFILITRE.OEMKODColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string MALZEMEADI
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLFILITRE.MALZEMEADIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLFILITRE' tablosundaki 'MALZEMEADI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLFILITRE.MALZEMEADIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string DIGERADI
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLFILITRE.DIGERADIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLFILITRE' tablosundaki 'DIGERADI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLFILITRE.DIGERADIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string KULLANIMYERI
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLFILITRE.KULLANIMYERIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLFILITRE' tablosundaki 'KULLANIMYERI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLFILITRE.KULLANIMYERIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int BIRIMID
      {
        get
        {
          try
          {
            return (int) this[this.tableTBLFILITRE.BIRIMIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLFILITRE' tablosundaki 'BIRIMID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLFILITRE.BIRIMIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int GRUPID
      {
        get
        {
          try
          {
            return (int) this[this.tableTBLFILITRE.GRUPIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLFILITRE' tablosundaki 'GRUPID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLFILITRE.GRUPIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int GRUPID2
      {
        get
        {
          try
          {
            return (int) this[this.tableTBLFILITRE.GRUPID2Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLFILITRE' tablosundaki 'GRUPID2' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLFILITRE.GRUPID2Column] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int KDVID
      {
        get
        {
          try
          {
            return (int) this[this.tableTBLFILITRE.KDVIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLFILITRE' tablosundaki 'KDVID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLFILITRE.KDVIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int BOLUMID
      {
        get
        {
          try
          {
            return (int) this[this.tableTBLFILITRE.BOLUMIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLFILITRE' tablosundaki 'BOLUMID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLFILITRE.BOLUMIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string RAFNO
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLFILITRE.RAFNOColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLFILITRE' tablosundaki 'RAFNO' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLFILITRE.RAFNOColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string GOZNO
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLFILITRE.GOZNOColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLFILITRE' tablosundaki 'GOZNO' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLFILITRE.GOZNOColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BARKOD
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLFILITRE.BARKODColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLFILITRE' tablosundaki 'BARKOD' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLFILITRE.BARKODColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string TARIHKONTROL
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLFILITRE.TARIHKONTROLColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLFILITRE' tablosundaki 'TARIHKONTROL' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLFILITRE.TARIHKONTROLColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string SERINOKONTROL
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLFILITRE.SERINOKONTROLColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLFILITRE' tablosundaki 'SERINOKONTROL' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLFILITRE.SERINOKONTROLColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string KMKONTROL
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLFILITRE.KMKONTROLColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLFILITRE' tablosundaki 'KMKONTROL' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLFILITRE.KMKONTROLColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string MALZEMEFOTO
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLFILITRE.MALZEMEFOTOColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLFILITRE' tablosundaki 'MALZEMEFOTO' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLFILITRE.MALZEMEFOTOColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int KAYITTIPIID
      {
        get
        {
          try
          {
            return (int) this[this.tableTBLFILITRE.KAYITTIPIIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLFILITRE' tablosundaki 'KAYITTIPIID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLFILITRE.KAYITTIPIIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string SAVEUSER
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLFILITRE.SAVEUSERColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLFILITRE' tablosundaki 'SAVEUSER' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLFILITRE.SAVEUSERColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DateTime SAVEDATE
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableTBLFILITRE.SAVEDATEColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLFILITRE' tablosundaki 'SAVEDATE' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLFILITRE.SAVEDATEColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string EDITUSER
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLFILITRE.EDITUSERColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLFILITRE' tablosundaki 'EDITUSER' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLFILITRE.EDITUSERColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DateTime EDITDATE
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableTBLFILITRE.EDITDATEColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLFILITRE' tablosundaki 'EDITDATE' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLFILITRE.EDITDATEColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string SAVEMAC
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLFILITRE.SAVEMACColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLFILITRE' tablosundaki 'SAVEMAC' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLFILITRE.SAVEMACColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string EDITMAC
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLFILITRE.EDITMACColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLFILITRE' tablosundaki 'EDITMAC' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLFILITRE.EDITMACColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string SAVEIP
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLFILITRE.SAVEIPColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLFILITRE' tablosundaki 'SAVEIP' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLFILITRE.SAVEIPColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string EDITIP
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLFILITRE.EDITIPColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLFILITRE' tablosundaki 'EDITIP' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLFILITRE.EDITIPColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string GIRIS
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLFILITRE.GIRISColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLFILITRE' tablosundaki 'GIRIS' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLFILITRE.GIRISColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string CIKIS
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLFILITRE.CIKISColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLFILITRE' tablosundaki 'CIKIS' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLFILITRE.CIKISColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string KALAN
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLFILITRE.KALANColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLFILITRE' tablosundaki 'KALAN' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLFILITRE.KALANColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsKODNull() => this.IsNull(this.tableTBLFILITRE.KODColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetKODNull() => this[this.tableTBLFILITRE.KODColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsUFKODNull() => this.IsNull(this.tableTBLFILITRE.UFKODColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetUFKODNull() => this[this.tableTBLFILITRE.UFKODColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsOEMKODNull() => this.IsNull(this.tableTBLFILITRE.OEMKODColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetOEMKODNull() => this[this.tableTBLFILITRE.OEMKODColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMALZEMEADINull() => this.IsNull(this.tableTBLFILITRE.MALZEMEADIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMALZEMEADINull() => this[this.tableTBLFILITRE.MALZEMEADIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsDIGERADINull() => this.IsNull(this.tableTBLFILITRE.DIGERADIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetDIGERADINull() => this[this.tableTBLFILITRE.DIGERADIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsKULLANIMYERINull() => this.IsNull(this.tableTBLFILITRE.KULLANIMYERIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetKULLANIMYERINull() => this[this.tableTBLFILITRE.KULLANIMYERIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBIRIMIDNull() => this.IsNull(this.tableTBLFILITRE.BIRIMIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBIRIMIDNull() => this[this.tableTBLFILITRE.BIRIMIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsGRUPIDNull() => this.IsNull(this.tableTBLFILITRE.GRUPIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetGRUPIDNull() => this[this.tableTBLFILITRE.GRUPIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsGRUPID2Null() => this.IsNull(this.tableTBLFILITRE.GRUPID2Column);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetGRUPID2Null() => this[this.tableTBLFILITRE.GRUPID2Column] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsKDVIDNull() => this.IsNull(this.tableTBLFILITRE.KDVIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetKDVIDNull() => this[this.tableTBLFILITRE.KDVIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBOLUMIDNull() => this.IsNull(this.tableTBLFILITRE.BOLUMIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBOLUMIDNull() => this[this.tableTBLFILITRE.BOLUMIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsRAFNONull() => this.IsNull(this.tableTBLFILITRE.RAFNOColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetRAFNONull() => this[this.tableTBLFILITRE.RAFNOColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsGOZNONull() => this.IsNull(this.tableTBLFILITRE.GOZNOColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetGOZNONull() => this[this.tableTBLFILITRE.GOZNOColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBARKODNull() => this.IsNull(this.tableTBLFILITRE.BARKODColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBARKODNull() => this[this.tableTBLFILITRE.BARKODColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsTARIHKONTROLNull() => this.IsNull(this.tableTBLFILITRE.TARIHKONTROLColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetTARIHKONTROLNull() => this[this.tableTBLFILITRE.TARIHKONTROLColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsSERINOKONTROLNull() => this.IsNull(this.tableTBLFILITRE.SERINOKONTROLColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetSERINOKONTROLNull() => this[this.tableTBLFILITRE.SERINOKONTROLColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsKMKONTROLNull() => this.IsNull(this.tableTBLFILITRE.KMKONTROLColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetKMKONTROLNull() => this[this.tableTBLFILITRE.KMKONTROLColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMALZEMEFOTONull() => this.IsNull(this.tableTBLFILITRE.MALZEMEFOTOColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMALZEMEFOTONull() => this[this.tableTBLFILITRE.MALZEMEFOTOColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsKAYITTIPIIDNull() => this.IsNull(this.tableTBLFILITRE.KAYITTIPIIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetKAYITTIPIIDNull() => this[this.tableTBLFILITRE.KAYITTIPIIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsSAVEUSERNull() => this.IsNull(this.tableTBLFILITRE.SAVEUSERColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetSAVEUSERNull() => this[this.tableTBLFILITRE.SAVEUSERColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsSAVEDATENull() => this.IsNull(this.tableTBLFILITRE.SAVEDATEColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetSAVEDATENull() => this[this.tableTBLFILITRE.SAVEDATEColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsEDITUSERNull() => this.IsNull(this.tableTBLFILITRE.EDITUSERColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetEDITUSERNull() => this[this.tableTBLFILITRE.EDITUSERColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsEDITDATENull() => this.IsNull(this.tableTBLFILITRE.EDITDATEColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetEDITDATENull() => this[this.tableTBLFILITRE.EDITDATEColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsSAVEMACNull() => this.IsNull(this.tableTBLFILITRE.SAVEMACColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetSAVEMACNull() => this[this.tableTBLFILITRE.SAVEMACColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsEDITMACNull() => this.IsNull(this.tableTBLFILITRE.EDITMACColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetEDITMACNull() => this[this.tableTBLFILITRE.EDITMACColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsSAVEIPNull() => this.IsNull(this.tableTBLFILITRE.SAVEIPColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetSAVEIPNull() => this[this.tableTBLFILITRE.SAVEIPColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsEDITIPNull() => this.IsNull(this.tableTBLFILITRE.EDITIPColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetEDITIPNull() => this[this.tableTBLFILITRE.EDITIPColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsGIRISNull() => this.IsNull(this.tableTBLFILITRE.GIRISColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetGIRISNull() => this[this.tableTBLFILITRE.GIRISColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsCIKISNull() => this.IsNull(this.tableTBLFILITRE.CIKISColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetCIKISNull() => this[this.tableTBLFILITRE.CIKISColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsKALANNull() => this.IsNull(this.tableTBLFILITRE.KALANColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetKALANNull() => this[this.tableTBLFILITRE.KALANColumn] = Convert.DBNull;
    }

    public class TBLYAGRow : DataRow
    {
      private Malzeemme.TBLYAGDataTable tableTBLYAG;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal TBLYAGRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableTBLYAG = (Malzeemme.TBLYAGDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ID
      {
        get => (int) this[this.tableTBLYAG.IDColumn];
        set => this[this.tableTBLYAG.IDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string KOD
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLYAG.KODColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLYAG' tablosundaki 'KOD' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLYAG.KODColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string UFKOD
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLYAG.UFKODColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLYAG' tablosundaki 'UFKOD' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLYAG.UFKODColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string OEMKOD
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLYAG.OEMKODColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLYAG' tablosundaki 'OEMKOD' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLYAG.OEMKODColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string MALZEMEADI
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLYAG.MALZEMEADIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLYAG' tablosundaki 'MALZEMEADI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLYAG.MALZEMEADIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string DIGERADI
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLYAG.DIGERADIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLYAG' tablosundaki 'DIGERADI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLYAG.DIGERADIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string KULLANIMYERI
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLYAG.KULLANIMYERIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLYAG' tablosundaki 'KULLANIMYERI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLYAG.KULLANIMYERIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int BIRIMID
      {
        get
        {
          try
          {
            return (int) this[this.tableTBLYAG.BIRIMIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLYAG' tablosundaki 'BIRIMID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLYAG.BIRIMIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int GRUPID
      {
        get
        {
          try
          {
            return (int) this[this.tableTBLYAG.GRUPIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLYAG' tablosundaki 'GRUPID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLYAG.GRUPIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int GRUPID2
      {
        get
        {
          try
          {
            return (int) this[this.tableTBLYAG.GRUPID2Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLYAG' tablosundaki 'GRUPID2' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLYAG.GRUPID2Column] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int KDVID
      {
        get
        {
          try
          {
            return (int) this[this.tableTBLYAG.KDVIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLYAG' tablosundaki 'KDVID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLYAG.KDVIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int BOLUMID
      {
        get
        {
          try
          {
            return (int) this[this.tableTBLYAG.BOLUMIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLYAG' tablosundaki 'BOLUMID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLYAG.BOLUMIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string RAFNO
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLYAG.RAFNOColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLYAG' tablosundaki 'RAFNO' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLYAG.RAFNOColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string GOZNO
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLYAG.GOZNOColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLYAG' tablosundaki 'GOZNO' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLYAG.GOZNOColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BARKOD
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLYAG.BARKODColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLYAG' tablosundaki 'BARKOD' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLYAG.BARKODColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string TARIHKONTROL
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLYAG.TARIHKONTROLColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLYAG' tablosundaki 'TARIHKONTROL' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLYAG.TARIHKONTROLColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string SERINOKONTROL
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLYAG.SERINOKONTROLColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLYAG' tablosundaki 'SERINOKONTROL' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLYAG.SERINOKONTROLColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string KMKONTROL
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLYAG.KMKONTROLColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLYAG' tablosundaki 'KMKONTROL' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLYAG.KMKONTROLColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string MALZEMEFOTO
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLYAG.MALZEMEFOTOColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLYAG' tablosundaki 'MALZEMEFOTO' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLYAG.MALZEMEFOTOColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int KAYITTIPIID
      {
        get
        {
          try
          {
            return (int) this[this.tableTBLYAG.KAYITTIPIIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLYAG' tablosundaki 'KAYITTIPIID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLYAG.KAYITTIPIIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string SAVEUSER
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLYAG.SAVEUSERColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLYAG' tablosundaki 'SAVEUSER' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLYAG.SAVEUSERColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DateTime SAVEDATE
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableTBLYAG.SAVEDATEColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLYAG' tablosundaki 'SAVEDATE' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLYAG.SAVEDATEColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string EDITUSER
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLYAG.EDITUSERColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLYAG' tablosundaki 'EDITUSER' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLYAG.EDITUSERColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DateTime EDITDATE
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableTBLYAG.EDITDATEColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLYAG' tablosundaki 'EDITDATE' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLYAG.EDITDATEColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string SAVEMAC
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLYAG.SAVEMACColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLYAG' tablosundaki 'SAVEMAC' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLYAG.SAVEMACColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string EDITMAC
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLYAG.EDITMACColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLYAG' tablosundaki 'EDITMAC' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLYAG.EDITMACColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string SAVEIP
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLYAG.SAVEIPColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLYAG' tablosundaki 'SAVEIP' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLYAG.SAVEIPColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string EDITIP
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLYAG.EDITIPColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLYAG' tablosundaki 'EDITIP' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLYAG.EDITIPColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string GIRIS
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLYAG.GIRISColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLYAG' tablosundaki 'GIRIS' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLYAG.GIRISColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string CIKIS
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLYAG.CIKISColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLYAG' tablosundaki 'CIKIS' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLYAG.CIKISColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string KALAN
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLYAG.KALANColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLYAG' tablosundaki 'KALAN' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLYAG.KALANColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsKODNull() => this.IsNull(this.tableTBLYAG.KODColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetKODNull() => this[this.tableTBLYAG.KODColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsUFKODNull() => this.IsNull(this.tableTBLYAG.UFKODColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetUFKODNull() => this[this.tableTBLYAG.UFKODColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsOEMKODNull() => this.IsNull(this.tableTBLYAG.OEMKODColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetOEMKODNull() => this[this.tableTBLYAG.OEMKODColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMALZEMEADINull() => this.IsNull(this.tableTBLYAG.MALZEMEADIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMALZEMEADINull() => this[this.tableTBLYAG.MALZEMEADIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsDIGERADINull() => this.IsNull(this.tableTBLYAG.DIGERADIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetDIGERADINull() => this[this.tableTBLYAG.DIGERADIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsKULLANIMYERINull() => this.IsNull(this.tableTBLYAG.KULLANIMYERIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetKULLANIMYERINull() => this[this.tableTBLYAG.KULLANIMYERIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBIRIMIDNull() => this.IsNull(this.tableTBLYAG.BIRIMIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBIRIMIDNull() => this[this.tableTBLYAG.BIRIMIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsGRUPIDNull() => this.IsNull(this.tableTBLYAG.GRUPIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetGRUPIDNull() => this[this.tableTBLYAG.GRUPIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsGRUPID2Null() => this.IsNull(this.tableTBLYAG.GRUPID2Column);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetGRUPID2Null() => this[this.tableTBLYAG.GRUPID2Column] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsKDVIDNull() => this.IsNull(this.tableTBLYAG.KDVIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetKDVIDNull() => this[this.tableTBLYAG.KDVIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBOLUMIDNull() => this.IsNull(this.tableTBLYAG.BOLUMIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBOLUMIDNull() => this[this.tableTBLYAG.BOLUMIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsRAFNONull() => this.IsNull(this.tableTBLYAG.RAFNOColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetRAFNONull() => this[this.tableTBLYAG.RAFNOColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsGOZNONull() => this.IsNull(this.tableTBLYAG.GOZNOColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetGOZNONull() => this[this.tableTBLYAG.GOZNOColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBARKODNull() => this.IsNull(this.tableTBLYAG.BARKODColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBARKODNull() => this[this.tableTBLYAG.BARKODColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsTARIHKONTROLNull() => this.IsNull(this.tableTBLYAG.TARIHKONTROLColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetTARIHKONTROLNull() => this[this.tableTBLYAG.TARIHKONTROLColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsSERINOKONTROLNull() => this.IsNull(this.tableTBLYAG.SERINOKONTROLColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetSERINOKONTROLNull() => this[this.tableTBLYAG.SERINOKONTROLColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsKMKONTROLNull() => this.IsNull(this.tableTBLYAG.KMKONTROLColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetKMKONTROLNull() => this[this.tableTBLYAG.KMKONTROLColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMALZEMEFOTONull() => this.IsNull(this.tableTBLYAG.MALZEMEFOTOColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMALZEMEFOTONull() => this[this.tableTBLYAG.MALZEMEFOTOColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsKAYITTIPIIDNull() => this.IsNull(this.tableTBLYAG.KAYITTIPIIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetKAYITTIPIIDNull() => this[this.tableTBLYAG.KAYITTIPIIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsSAVEUSERNull() => this.IsNull(this.tableTBLYAG.SAVEUSERColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetSAVEUSERNull() => this[this.tableTBLYAG.SAVEUSERColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsSAVEDATENull() => this.IsNull(this.tableTBLYAG.SAVEDATEColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetSAVEDATENull() => this[this.tableTBLYAG.SAVEDATEColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsEDITUSERNull() => this.IsNull(this.tableTBLYAG.EDITUSERColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetEDITUSERNull() => this[this.tableTBLYAG.EDITUSERColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsEDITDATENull() => this.IsNull(this.tableTBLYAG.EDITDATEColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetEDITDATENull() => this[this.tableTBLYAG.EDITDATEColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsSAVEMACNull() => this.IsNull(this.tableTBLYAG.SAVEMACColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetSAVEMACNull() => this[this.tableTBLYAG.SAVEMACColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsEDITMACNull() => this.IsNull(this.tableTBLYAG.EDITMACColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetEDITMACNull() => this[this.tableTBLYAG.EDITMACColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsSAVEIPNull() => this.IsNull(this.tableTBLYAG.SAVEIPColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetSAVEIPNull() => this[this.tableTBLYAG.SAVEIPColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsEDITIPNull() => this.IsNull(this.tableTBLYAG.EDITIPColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetEDITIPNull() => this[this.tableTBLYAG.EDITIPColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsGIRISNull() => this.IsNull(this.tableTBLYAG.GIRISColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetGIRISNull() => this[this.tableTBLYAG.GIRISColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsCIKISNull() => this.IsNull(this.tableTBLYAG.CIKISColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetCIKISNull() => this[this.tableTBLYAG.CIKISColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsKALANNull() => this.IsNull(this.tableTBLYAG.KALANColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetKALANNull() => this[this.tableTBLYAG.KALANColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public class TBLMALZEMELERRowChangeEvent : EventArgs
    {
      private Malzeemme.TBLMALZEMELERRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public TBLMALZEMELERRowChangeEvent(Malzeemme.TBLMALZEMELERRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Malzeemme.TBLMALZEMELERRow Row => this.eventRow;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public class TBLFILITRERowChangeEvent : EventArgs
    {
      private Malzeemme.TBLFILITRERow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public TBLFILITRERowChangeEvent(Malzeemme.TBLFILITRERow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Malzeemme.TBLFILITRERow Row => this.eventRow;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public class TBLYAGRowChangeEvent : EventArgs
    {
      private Malzeemme.TBLYAGRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public TBLYAGRowChangeEvent(Malzeemme.TBLYAGRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Malzeemme.TBLYAGRow Row => this.eventRow;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataRowAction Action => this.eventAction;
    }
  }
}
