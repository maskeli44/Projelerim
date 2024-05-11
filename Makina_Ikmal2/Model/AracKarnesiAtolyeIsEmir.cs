// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Model.AracKarnesiAtolyeIsEmir
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
  [XmlRoot("AracKarnesiAtolyeIsEmir")]
  [HelpKeyword("vs.data.DataSet")]
  [Serializable]
  public class AracKarnesiAtolyeIsEmir : DataSet
  {
    private AracKarnesiAtolyeIsEmir.TBLISEMRIDataTable tableTBLISEMRI;
    private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public AracKarnesiAtolyeIsEmir()
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
    protected AracKarnesiAtolyeIsEmir(SerializationInfo info, StreamingContext context)
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
          if (dataSet.Tables[nameof (TBLISEMRI)] != null)
            base.Tables.Add((DataTable) new AracKarnesiAtolyeIsEmir.TBLISEMRIDataTable(dataSet.Tables[nameof (TBLISEMRI)]));
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
    public AracKarnesiAtolyeIsEmir.TBLISEMRIDataTable TBLISEMRI => this.tableTBLISEMRI;

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
      AracKarnesiAtolyeIsEmir karnesiAtolyeIsEmir = (AracKarnesiAtolyeIsEmir) base.Clone();
      karnesiAtolyeIsEmir.InitVars();
      karnesiAtolyeIsEmir.SchemaSerializationMode = this.SchemaSerializationMode;
      return (DataSet) karnesiAtolyeIsEmir;
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
        if (dataSet.Tables["TBLISEMRI"] != null)
          base.Tables.Add((DataTable) new AracKarnesiAtolyeIsEmir.TBLISEMRIDataTable(dataSet.Tables["TBLISEMRI"]));
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
      this.tableTBLISEMRI = (AracKarnesiAtolyeIsEmir.TBLISEMRIDataTable) base.Tables["TBLISEMRI"];
      if (!initTable || this.tableTBLISEMRI == null)
        return;
      this.tableTBLISEMRI.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.DataSetName = nameof (AracKarnesiAtolyeIsEmir);
      this.Prefix = "";
      this.Namespace = "http://tempuri.org/AracKarnesiAtolyeIsEmir.xsd";
      this.EnforceConstraints = true;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tableTBLISEMRI = new AracKarnesiAtolyeIsEmir.TBLISEMRIDataTable();
      base.Tables.Add((DataTable) this.tableTBLISEMRI);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private bool ShouldSerializeTBLISEMRI() => false;

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
      AracKarnesiAtolyeIsEmir karnesiAtolyeIsEmir = new AracKarnesiAtolyeIsEmir();
      XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
      {
        Namespace = karnesiAtolyeIsEmir.Namespace
      });
      typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = karnesiAtolyeIsEmir.GetSchemaSerializable();
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
    public delegate void TBLISEMRIRowChangeEventHandler(
      object sender,
      AracKarnesiAtolyeIsEmir.TBLISEMRIRowChangeEvent e);

    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class TBLISEMRIDataTable : TypedTableBase<AracKarnesiAtolyeIsEmir.TBLISEMRIRow>
    {
      private DataColumn columnArıza_Nedeni;
      private DataColumn columnGIRISTARIH;
      private DataColumn columnCIKISTARIH;
      private DataColumn columnBILDIRILENARIZA;
      private DataColumn columnBakım_Yeri;
      private DataColumn columnBAKIMKMSI;
      private DataColumn columnSONRAKIBKMKM;
      private DataColumn columnSONRAKIBKMTRH;
      private DataColumn columnBAKIMSAATI;
      private DataColumn columnSONRAKIBKMSAAT;
      private DataColumn columnYAPILANBAKIMOZETI;
      private DataColumn columnARACID;
      private DataColumn columnİş_Emri_Kod;
      private DataColumn columnIsEmriID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public TBLISEMRIDataTable()
      {
        this.TableName = "TBLISEMRI";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal TBLISEMRIDataTable(DataTable table)
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
      protected TBLISEMRIDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn Arıza_NedeniColumn => this.columnArıza_Nedeni;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn GIRISTARIHColumn => this.columnGIRISTARIH;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn CIKISTARIHColumn => this.columnCIKISTARIH;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BILDIRILENARIZAColumn => this.columnBILDIRILENARIZA;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn Bakım_YeriColumn => this.columnBakım_Yeri;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BAKIMKMSIColumn => this.columnBAKIMKMSI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn SONRAKIBKMKMColumn => this.columnSONRAKIBKMKM;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn SONRAKIBKMTRHColumn => this.columnSONRAKIBKMTRH;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BAKIMSAATIColumn => this.columnBAKIMSAATI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn SONRAKIBKMSAATColumn => this.columnSONRAKIBKMSAAT;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn YAPILANBAKIMOZETIColumn => this.columnYAPILANBAKIMOZETI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ARACIDColumn => this.columnARACID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn İş_Emri_KodColumn => this.columnİş_Emri_Kod;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn IsEmriIDColumn => this.columnIsEmriID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AracKarnesiAtolyeIsEmir.TBLISEMRIRow this[int index] => (AracKarnesiAtolyeIsEmir.TBLISEMRIRow) this.Rows[index];

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event AracKarnesiAtolyeIsEmir.TBLISEMRIRowChangeEventHandler TBLISEMRIRowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event AracKarnesiAtolyeIsEmir.TBLISEMRIRowChangeEventHandler TBLISEMRIRowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event AracKarnesiAtolyeIsEmir.TBLISEMRIRowChangeEventHandler TBLISEMRIRowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event AracKarnesiAtolyeIsEmir.TBLISEMRIRowChangeEventHandler TBLISEMRIRowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void AddTBLISEMRIRow(AracKarnesiAtolyeIsEmir.TBLISEMRIRow row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AracKarnesiAtolyeIsEmir.TBLISEMRIRow AddTBLISEMRIRow(
        int Arıza_Nedeni,
        DateTime GIRISTARIH,
        DateTime CIKISTARIH,
        string BILDIRILENARIZA,
        int Bakım_Yeri,
        string BAKIMKMSI,
        string SONRAKIBKMKM,
        string SONRAKIBKMTRH,
        string BAKIMSAATI,
        string SONRAKIBKMSAAT,
        string YAPILANBAKIMOZETI,
        int ARACID,
        string İş_Emri_Kod)
      {
        AracKarnesiAtolyeIsEmir.TBLISEMRIRow row = (AracKarnesiAtolyeIsEmir.TBLISEMRIRow) this.NewRow();
        object[] objArray = new object[14]
        {
          (object) Arıza_Nedeni,
          (object) GIRISTARIH,
          (object) CIKISTARIH,
          (object) BILDIRILENARIZA,
          (object) Bakım_Yeri,
          (object) BAKIMKMSI,
          (object) SONRAKIBKMKM,
          (object) SONRAKIBKMTRH,
          (object) BAKIMSAATI,
          (object) SONRAKIBKMSAAT,
          (object) YAPILANBAKIMOZETI,
          (object) ARACID,
          (object) İş_Emri_Kod,
          null
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AracKarnesiAtolyeIsEmir.TBLISEMRIRow FindByIsEmriID(int IsEmriID) => (AracKarnesiAtolyeIsEmir.TBLISEMRIRow) this.Rows.Find(new object[1]
      {
        (object) IsEmriID
      });

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public override DataTable Clone()
      {
        AracKarnesiAtolyeIsEmir.TBLISEMRIDataTable tblisemriDataTable = (AracKarnesiAtolyeIsEmir.TBLISEMRIDataTable) base.Clone();
        tblisemriDataTable.InitVars();
        return (DataTable) tblisemriDataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataTable CreateInstance() => (DataTable) new AracKarnesiAtolyeIsEmir.TBLISEMRIDataTable();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal void InitVars()
      {
        this.columnArıza_Nedeni = this.Columns["Arıza Nedeni"];
        this.columnGIRISTARIH = this.Columns["GIRISTARIH"];
        this.columnCIKISTARIH = this.Columns["CIKISTARIH"];
        this.columnBILDIRILENARIZA = this.Columns["BILDIRILENARIZA"];
        this.columnBakım_Yeri = this.Columns["Bakım Yeri"];
        this.columnBAKIMKMSI = this.Columns["BAKIMKMSI"];
        this.columnSONRAKIBKMKM = this.Columns["SONRAKIBKMKM"];
        this.columnSONRAKIBKMTRH = this.Columns["SONRAKIBKMTRH"];
        this.columnBAKIMSAATI = this.Columns["BAKIMSAATI"];
        this.columnSONRAKIBKMSAAT = this.Columns["SONRAKIBKMSAAT"];
        this.columnYAPILANBAKIMOZETI = this.Columns["YAPILANBAKIMOZETI"];
        this.columnARACID = this.Columns["ARACID"];
        this.columnİş_Emri_Kod = this.Columns["İş Emri Kod"];
        this.columnIsEmriID = this.Columns["IsEmriID"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      private void InitClass()
      {
        this.columnArıza_Nedeni = new DataColumn("Arıza Nedeni", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnArıza_Nedeni);
        this.columnGIRISTARIH = new DataColumn("GIRISTARIH", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGIRISTARIH);
        this.columnCIKISTARIH = new DataColumn("CIKISTARIH", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCIKISTARIH);
        this.columnBILDIRILENARIZA = new DataColumn("BILDIRILENARIZA", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBILDIRILENARIZA);
        this.columnBakım_Yeri = new DataColumn("Bakım Yeri", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBakım_Yeri);
        this.columnBAKIMKMSI = new DataColumn("BAKIMKMSI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBAKIMKMSI);
        this.columnSONRAKIBKMKM = new DataColumn("SONRAKIBKMKM", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSONRAKIBKMKM);
        this.columnSONRAKIBKMTRH = new DataColumn("SONRAKIBKMTRH", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSONRAKIBKMTRH);
        this.columnBAKIMSAATI = new DataColumn("BAKIMSAATI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBAKIMSAATI);
        this.columnSONRAKIBKMSAAT = new DataColumn("SONRAKIBKMSAAT", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSONRAKIBKMSAAT);
        this.columnYAPILANBAKIMOZETI = new DataColumn("YAPILANBAKIMOZETI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnYAPILANBAKIMOZETI);
        this.columnARACID = new DataColumn("ARACID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnARACID);
        this.columnİş_Emri_Kod = new DataColumn("İş Emri Kod", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnİş_Emri_Kod);
        this.columnIsEmriID = new DataColumn("IsEmriID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnIsEmriID);
        this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
        {
          this.columnIsEmriID
        }, true));
        this.columnBILDIRILENARIZA.MaxLength = int.MaxValue;
        this.columnBAKIMKMSI.MaxLength = 50;
        this.columnSONRAKIBKMKM.MaxLength = 50;
        this.columnSONRAKIBKMTRH.MaxLength = 50;
        this.columnBAKIMSAATI.MaxLength = 50;
        this.columnSONRAKIBKMSAAT.MaxLength = 50;
        this.columnYAPILANBAKIMOZETI.MaxLength = int.MaxValue;
        this.columnİş_Emri_Kod.MaxLength = 50;
        this.columnIsEmriID.AutoIncrement = true;
        this.columnIsEmriID.AutoIncrementSeed = -1L;
        this.columnIsEmriID.AutoIncrementStep = -1L;
        this.columnIsEmriID.AllowDBNull = false;
        this.columnIsEmriID.ReadOnly = true;
        this.columnIsEmriID.Unique = true;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AracKarnesiAtolyeIsEmir.TBLISEMRIRow NewTBLISEMRIRow() => (AracKarnesiAtolyeIsEmir.TBLISEMRIRow) this.NewRow();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new AracKarnesiAtolyeIsEmir.TBLISEMRIRow(builder);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override Type GetRowType() => typeof (AracKarnesiAtolyeIsEmir.TBLISEMRIRow);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.TBLISEMRIRowChanged == null)
          return;
        this.TBLISEMRIRowChanged((object) this, new AracKarnesiAtolyeIsEmir.TBLISEMRIRowChangeEvent((AracKarnesiAtolyeIsEmir.TBLISEMRIRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.TBLISEMRIRowChanging == null)
          return;
        this.TBLISEMRIRowChanging((object) this, new AracKarnesiAtolyeIsEmir.TBLISEMRIRowChangeEvent((AracKarnesiAtolyeIsEmir.TBLISEMRIRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.TBLISEMRIRowDeleted == null)
          return;
        this.TBLISEMRIRowDeleted((object) this, new AracKarnesiAtolyeIsEmir.TBLISEMRIRowChangeEvent((AracKarnesiAtolyeIsEmir.TBLISEMRIRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.TBLISEMRIRowDeleting == null)
          return;
        this.TBLISEMRIRowDeleting((object) this, new AracKarnesiAtolyeIsEmir.TBLISEMRIRowChangeEvent((AracKarnesiAtolyeIsEmir.TBLISEMRIRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void RemoveTBLISEMRIRow(AracKarnesiAtolyeIsEmir.TBLISEMRIRow row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        AracKarnesiAtolyeIsEmir karnesiAtolyeIsEmir = new AracKarnesiAtolyeIsEmir();
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
          FixedValue = karnesiAtolyeIsEmir.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (TBLISEMRIDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = karnesiAtolyeIsEmir.GetSchemaSerializable();
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

    public class TBLISEMRIRow : DataRow
    {
      private AracKarnesiAtolyeIsEmir.TBLISEMRIDataTable tableTBLISEMRI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal TBLISEMRIRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableTBLISEMRI = (AracKarnesiAtolyeIsEmir.TBLISEMRIDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int Arıza_Nedeni
      {
        get
        {
          try
          {
            return (int) this[this.tableTBLISEMRI.Arıza_NedeniColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLISEMRI' tablosundaki 'Arıza Nedeni' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLISEMRI.Arıza_NedeniColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DateTime GIRISTARIH
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableTBLISEMRI.GIRISTARIHColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLISEMRI' tablosundaki 'GIRISTARIH' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLISEMRI.GIRISTARIHColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DateTime CIKISTARIH
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableTBLISEMRI.CIKISTARIHColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLISEMRI' tablosundaki 'CIKISTARIH' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLISEMRI.CIKISTARIHColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BILDIRILENARIZA
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLISEMRI.BILDIRILENARIZAColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLISEMRI' tablosundaki 'BILDIRILENARIZA' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLISEMRI.BILDIRILENARIZAColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int Bakım_Yeri
      {
        get
        {
          try
          {
            return (int) this[this.tableTBLISEMRI.Bakım_YeriColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLISEMRI' tablosundaki 'Bakım Yeri' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLISEMRI.Bakım_YeriColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BAKIMKMSI
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLISEMRI.BAKIMKMSIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLISEMRI' tablosundaki 'BAKIMKMSI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLISEMRI.BAKIMKMSIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string SONRAKIBKMKM
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLISEMRI.SONRAKIBKMKMColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLISEMRI' tablosundaki 'SONRAKIBKMKM' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLISEMRI.SONRAKIBKMKMColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string SONRAKIBKMTRH
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLISEMRI.SONRAKIBKMTRHColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLISEMRI' tablosundaki 'SONRAKIBKMTRH' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLISEMRI.SONRAKIBKMTRHColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BAKIMSAATI
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLISEMRI.BAKIMSAATIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLISEMRI' tablosundaki 'BAKIMSAATI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLISEMRI.BAKIMSAATIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string SONRAKIBKMSAAT
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLISEMRI.SONRAKIBKMSAATColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLISEMRI' tablosundaki 'SONRAKIBKMSAAT' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLISEMRI.SONRAKIBKMSAATColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string YAPILANBAKIMOZETI
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLISEMRI.YAPILANBAKIMOZETIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLISEMRI' tablosundaki 'YAPILANBAKIMOZETI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLISEMRI.YAPILANBAKIMOZETIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ARACID
      {
        get
        {
          try
          {
            return (int) this[this.tableTBLISEMRI.ARACIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLISEMRI' tablosundaki 'ARACID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLISEMRI.ARACIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string İş_Emri_Kod
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLISEMRI.İş_Emri_KodColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLISEMRI' tablosundaki 'İş Emri Kod' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLISEMRI.İş_Emri_KodColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int IsEmriID
      {
        get => (int) this[this.tableTBLISEMRI.IsEmriIDColumn];
        set => this[this.tableTBLISEMRI.IsEmriIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsArıza_NedeniNull() => this.IsNull(this.tableTBLISEMRI.Arıza_NedeniColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetArıza_NedeniNull() => this[this.tableTBLISEMRI.Arıza_NedeniColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsGIRISTARIHNull() => this.IsNull(this.tableTBLISEMRI.GIRISTARIHColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetGIRISTARIHNull() => this[this.tableTBLISEMRI.GIRISTARIHColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsCIKISTARIHNull() => this.IsNull(this.tableTBLISEMRI.CIKISTARIHColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetCIKISTARIHNull() => this[this.tableTBLISEMRI.CIKISTARIHColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBILDIRILENARIZANull() => this.IsNull(this.tableTBLISEMRI.BILDIRILENARIZAColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBILDIRILENARIZANull() => this[this.tableTBLISEMRI.BILDIRILENARIZAColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBakım_YeriNull() => this.IsNull(this.tableTBLISEMRI.Bakım_YeriColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBakım_YeriNull() => this[this.tableTBLISEMRI.Bakım_YeriColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBAKIMKMSINull() => this.IsNull(this.tableTBLISEMRI.BAKIMKMSIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBAKIMKMSINull() => this[this.tableTBLISEMRI.BAKIMKMSIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsSONRAKIBKMKMNull() => this.IsNull(this.tableTBLISEMRI.SONRAKIBKMKMColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetSONRAKIBKMKMNull() => this[this.tableTBLISEMRI.SONRAKIBKMKMColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsSONRAKIBKMTRHNull() => this.IsNull(this.tableTBLISEMRI.SONRAKIBKMTRHColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetSONRAKIBKMTRHNull() => this[this.tableTBLISEMRI.SONRAKIBKMTRHColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBAKIMSAATINull() => this.IsNull(this.tableTBLISEMRI.BAKIMSAATIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBAKIMSAATINull() => this[this.tableTBLISEMRI.BAKIMSAATIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsSONRAKIBKMSAATNull() => this.IsNull(this.tableTBLISEMRI.SONRAKIBKMSAATColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetSONRAKIBKMSAATNull() => this[this.tableTBLISEMRI.SONRAKIBKMSAATColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsYAPILANBAKIMOZETINull() => this.IsNull(this.tableTBLISEMRI.YAPILANBAKIMOZETIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetYAPILANBAKIMOZETINull() => this[this.tableTBLISEMRI.YAPILANBAKIMOZETIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsARACIDNull() => this.IsNull(this.tableTBLISEMRI.ARACIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetARACIDNull() => this[this.tableTBLISEMRI.ARACIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool Isİş_Emri_KodNull() => this.IsNull(this.tableTBLISEMRI.İş_Emri_KodColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void Setİş_Emri_KodNull() => this[this.tableTBLISEMRI.İş_Emri_KodColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public class TBLISEMRIRowChangeEvent : EventArgs
    {
      private AracKarnesiAtolyeIsEmir.TBLISEMRIRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public TBLISEMRIRowChangeEvent(AracKarnesiAtolyeIsEmir.TBLISEMRIRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AracKarnesiAtolyeIsEmir.TBLISEMRIRow Row => this.eventRow;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataRowAction Action => this.eventAction;
    }
  }
}
