// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Model.AtolyeListesi
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
  [XmlRoot("AtolyeListesi")]
  [HelpKeyword("vs.data.DataSet")]
  [Serializable]
  public class AtolyeListesi : DataSet
  {
    private AtolyeListesi.TBLISEMRIDataTable tableTBLISEMRI;
    private AtolyeListesi.atolyeSarfDataTable tableatolyeSarf;
    private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public AtolyeListesi()
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
    protected AtolyeListesi(SerializationInfo info, StreamingContext context)
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
            base.Tables.Add((DataTable) new AtolyeListesi.TBLISEMRIDataTable(dataSet.Tables[nameof (TBLISEMRI)]));
          if (dataSet.Tables[nameof (atolyeSarf)] != null)
            base.Tables.Add((DataTable) new AtolyeListesi.atolyeSarfDataTable(dataSet.Tables[nameof (atolyeSarf)]));
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
    public AtolyeListesi.TBLISEMRIDataTable TBLISEMRI => this.tableTBLISEMRI;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public AtolyeListesi.atolyeSarfDataTable atolyeSarf => this.tableatolyeSarf;

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
      AtolyeListesi atolyeListesi = (AtolyeListesi) base.Clone();
      atolyeListesi.InitVars();
      atolyeListesi.SchemaSerializationMode = this.SchemaSerializationMode;
      return (DataSet) atolyeListesi;
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
          base.Tables.Add((DataTable) new AtolyeListesi.TBLISEMRIDataTable(dataSet.Tables["TBLISEMRI"]));
        if (dataSet.Tables["atolyeSarf"] != null)
          base.Tables.Add((DataTable) new AtolyeListesi.atolyeSarfDataTable(dataSet.Tables["atolyeSarf"]));
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
      this.tableTBLISEMRI = (AtolyeListesi.TBLISEMRIDataTable) base.Tables["TBLISEMRI"];
      if (initTable && this.tableTBLISEMRI != null)
        this.tableTBLISEMRI.InitVars();
      this.tableatolyeSarf = (AtolyeListesi.atolyeSarfDataTable) base.Tables["atolyeSarf"];
      if (!initTable || this.tableatolyeSarf == null)
        return;
      this.tableatolyeSarf.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.DataSetName = nameof (AtolyeListesi);
      this.Prefix = "";
      this.Namespace = "http://tempuri.org/AtolyeListesi.xsd";
      this.EnforceConstraints = true;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tableTBLISEMRI = new AtolyeListesi.TBLISEMRIDataTable();
      base.Tables.Add((DataTable) this.tableTBLISEMRI);
      this.tableatolyeSarf = new AtolyeListesi.atolyeSarfDataTable();
      base.Tables.Add((DataTable) this.tableatolyeSarf);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private bool ShouldSerializeTBLISEMRI() => false;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private bool ShouldSerializeatolyeSarf() => false;

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
      AtolyeListesi atolyeListesi = new AtolyeListesi();
      XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
      {
        Namespace = atolyeListesi.Namespace
      });
      typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = atolyeListesi.GetSchemaSerializable();
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
      AtolyeListesi.TBLISEMRIRowChangeEvent e);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public delegate void atolyeSarfRowChangeEventHandler(
      object sender,
      AtolyeListesi.atolyeSarfRowChangeEvent e);

    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class TBLISEMRIDataTable : TypedTableBase<AtolyeListesi.TBLISEMRIRow>
    {
      private DataColumn columnID;
      private DataColumn columnKOD;
      private DataColumn columnATOLYEID;
      private DataColumn columnARACID;
      private DataColumn columnGIRISTARIH;
      private DataColumn columnGIRISSAAT;
      private DataColumn columnCIKISTARIH;
      private DataColumn columnCIKISSAAT;
      private DataColumn columnARIZANEDENIID;
      private DataColumn columnBILDIRILENARIZA;
      private DataColumn columnISEMRIDURUMID;
      private DataColumn columnBAKIMYERIID;
      private DataColumn columnARACIGETIREN;
      private DataColumn columnBAKIMKMSI;
      private DataColumn columnSONRAKIBKMKM;
      private DataColumn columnSONRAKIBKMTRH;
      private DataColumn columnBAKIMSAATI;
      private DataColumn columnSONRAKIBKMSAAT;
      private DataColumn columnISEMRISIRANO;
      private DataColumn columnIMZAATOLYESEFID;
      private DataColumn columnISBITIMORANI;
      private DataColumn columnBAKIMTURUID;
      private DataColumn columnBAKIMDERECESIID;
      private DataColumn columnYIL;
      private DataColumn columnARACACIKLAMA;

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
      public DataColumn IDColumn => this.columnID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn KODColumn => this.columnKOD;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ATOLYEIDColumn => this.columnATOLYEID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ARACIDColumn => this.columnARACID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn GIRISTARIHColumn => this.columnGIRISTARIH;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn GIRISSAATColumn => this.columnGIRISSAAT;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn CIKISTARIHColumn => this.columnCIKISTARIH;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn CIKISSAATColumn => this.columnCIKISSAAT;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ARIZANEDENIIDColumn => this.columnARIZANEDENIID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BILDIRILENARIZAColumn => this.columnBILDIRILENARIZA;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ISEMRIDURUMIDColumn => this.columnISEMRIDURUMID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BAKIMYERIIDColumn => this.columnBAKIMYERIID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ARACIGETIRENColumn => this.columnARACIGETIREN;

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
      public DataColumn ISEMRISIRANOColumn => this.columnISEMRISIRANO;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn IMZAATOLYESEFIDColumn => this.columnIMZAATOLYESEFID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ISBITIMORANIColumn => this.columnISBITIMORANI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BAKIMTURUIDColumn => this.columnBAKIMTURUID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BAKIMDERECESIIDColumn => this.columnBAKIMDERECESIID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn YILColumn => this.columnYIL;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ARACACIKLAMAColumn => this.columnARACACIKLAMA;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AtolyeListesi.TBLISEMRIRow this[int index] => (AtolyeListesi.TBLISEMRIRow) this.Rows[index];

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event AtolyeListesi.TBLISEMRIRowChangeEventHandler TBLISEMRIRowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event AtolyeListesi.TBLISEMRIRowChangeEventHandler TBLISEMRIRowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event AtolyeListesi.TBLISEMRIRowChangeEventHandler TBLISEMRIRowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event AtolyeListesi.TBLISEMRIRowChangeEventHandler TBLISEMRIRowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void AddTBLISEMRIRow(AtolyeListesi.TBLISEMRIRow row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AtolyeListesi.TBLISEMRIRow AddTBLISEMRIRow(
        string KOD,
        int ATOLYEID,
        int ARACID,
        DateTime GIRISTARIH,
        DateTime GIRISSAAT,
        DateTime CIKISTARIH,
        DateTime CIKISSAAT,
        int ARIZANEDENIID,
        string BILDIRILENARIZA,
        int ISEMRIDURUMID,
        int BAKIMYERIID,
        string ARACIGETIREN,
        string BAKIMKMSI,
        string SONRAKIBKMKM,
        string SONRAKIBKMTRH,
        string BAKIMSAATI,
        string SONRAKIBKMSAAT,
        int ISEMRISIRANO,
        int IMZAATOLYESEFID,
        string ISBITIMORANI,
        string BAKIMTURUID,
        string BAKIMDERECESIID,
        int YIL,
        string ARACACIKLAMA)
      {
        AtolyeListesi.TBLISEMRIRow row = (AtolyeListesi.TBLISEMRIRow) this.NewRow();
        object[] objArray = new object[25]
        {
          null,
          (object) KOD,
          (object) ATOLYEID,
          (object) ARACID,
          (object) GIRISTARIH,
          (object) GIRISSAAT,
          (object) CIKISTARIH,
          (object) CIKISSAAT,
          (object) ARIZANEDENIID,
          (object) BILDIRILENARIZA,
          (object) ISEMRIDURUMID,
          (object) BAKIMYERIID,
          (object) ARACIGETIREN,
          (object) BAKIMKMSI,
          (object) SONRAKIBKMKM,
          (object) SONRAKIBKMTRH,
          (object) BAKIMSAATI,
          (object) SONRAKIBKMSAAT,
          (object) ISEMRISIRANO,
          (object) IMZAATOLYESEFID,
          (object) ISBITIMORANI,
          (object) BAKIMTURUID,
          (object) BAKIMDERECESIID,
          (object) YIL,
          (object) ARACACIKLAMA
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AtolyeListesi.TBLISEMRIRow FindByID(int ID) => (AtolyeListesi.TBLISEMRIRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public override DataTable Clone()
      {
        AtolyeListesi.TBLISEMRIDataTable tblisemriDataTable = (AtolyeListesi.TBLISEMRIDataTable) base.Clone();
        tblisemriDataTable.InitVars();
        return (DataTable) tblisemriDataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataTable CreateInstance() => (DataTable) new AtolyeListesi.TBLISEMRIDataTable();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal void InitVars()
      {
        this.columnID = this.Columns["ID"];
        this.columnKOD = this.Columns["KOD"];
        this.columnATOLYEID = this.Columns["ATOLYEID"];
        this.columnARACID = this.Columns["ARACID"];
        this.columnGIRISTARIH = this.Columns["GIRISTARIH"];
        this.columnGIRISSAAT = this.Columns["GIRISSAAT"];
        this.columnCIKISTARIH = this.Columns["CIKISTARIH"];
        this.columnCIKISSAAT = this.Columns["CIKISSAAT"];
        this.columnARIZANEDENIID = this.Columns["ARIZANEDENIID"];
        this.columnBILDIRILENARIZA = this.Columns["BILDIRILENARIZA"];
        this.columnISEMRIDURUMID = this.Columns["ISEMRIDURUMID"];
        this.columnBAKIMYERIID = this.Columns["BAKIMYERIID"];
        this.columnARACIGETIREN = this.Columns["ARACIGETIREN"];
        this.columnBAKIMKMSI = this.Columns["BAKIMKMSI"];
        this.columnSONRAKIBKMKM = this.Columns["SONRAKIBKMKM"];
        this.columnSONRAKIBKMTRH = this.Columns["SONRAKIBKMTRH"];
        this.columnBAKIMSAATI = this.Columns["BAKIMSAATI"];
        this.columnSONRAKIBKMSAAT = this.Columns["SONRAKIBKMSAAT"];
        this.columnISEMRISIRANO = this.Columns["ISEMRISIRANO"];
        this.columnIMZAATOLYESEFID = this.Columns["IMZAATOLYESEFID"];
        this.columnISBITIMORANI = this.Columns["ISBITIMORANI"];
        this.columnBAKIMTURUID = this.Columns["BAKIMTURUID"];
        this.columnBAKIMDERECESIID = this.Columns["BAKIMDERECESIID"];
        this.columnYIL = this.Columns["YIL"];
        this.columnARACACIKLAMA = this.Columns["ARACACIKLAMA"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      private void InitClass()
      {
        this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnID);
        this.columnKOD = new DataColumn("KOD", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnKOD);
        this.columnATOLYEID = new DataColumn("ATOLYEID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnATOLYEID);
        this.columnARACID = new DataColumn("ARACID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnARACID);
        this.columnGIRISTARIH = new DataColumn("GIRISTARIH", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGIRISTARIH);
        this.columnGIRISSAAT = new DataColumn("GIRISSAAT", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGIRISSAAT);
        this.columnCIKISTARIH = new DataColumn("CIKISTARIH", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCIKISTARIH);
        this.columnCIKISSAAT = new DataColumn("CIKISSAAT", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCIKISSAAT);
        this.columnARIZANEDENIID = new DataColumn("ARIZANEDENIID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnARIZANEDENIID);
        this.columnBILDIRILENARIZA = new DataColumn("BILDIRILENARIZA", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBILDIRILENARIZA);
        this.columnISEMRIDURUMID = new DataColumn("ISEMRIDURUMID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnISEMRIDURUMID);
        this.columnBAKIMYERIID = new DataColumn("BAKIMYERIID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBAKIMYERIID);
        this.columnARACIGETIREN = new DataColumn("ARACIGETIREN", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnARACIGETIREN);
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
        this.columnISEMRISIRANO = new DataColumn("ISEMRISIRANO", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnISEMRISIRANO);
        this.columnIMZAATOLYESEFID = new DataColumn("IMZAATOLYESEFID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnIMZAATOLYESEFID);
        this.columnISBITIMORANI = new DataColumn("ISBITIMORANI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnISBITIMORANI);
        this.columnBAKIMTURUID = new DataColumn("BAKIMTURUID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBAKIMTURUID);
        this.columnBAKIMDERECESIID = new DataColumn("BAKIMDERECESIID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBAKIMDERECESIID);
        this.columnYIL = new DataColumn("YIL", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnYIL);
        this.columnARACACIKLAMA = new DataColumn("ARACACIKLAMA", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnARACACIKLAMA);
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
        this.columnBILDIRILENARIZA.MaxLength = 150;
        this.columnARACIGETIREN.MaxLength = 50;
        this.columnBAKIMKMSI.MaxLength = 50;
        this.columnSONRAKIBKMKM.MaxLength = 50;
        this.columnSONRAKIBKMTRH.MaxLength = 50;
        this.columnBAKIMSAATI.MaxLength = 50;
        this.columnSONRAKIBKMSAAT.MaxLength = 50;
        this.columnISBITIMORANI.MaxLength = 50;
        this.columnBAKIMTURUID.MaxLength = 50;
        this.columnBAKIMDERECESIID.MaxLength = 50;
        this.columnYIL.ReadOnly = true;
        this.columnARACACIKLAMA.MaxLength = 150;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AtolyeListesi.TBLISEMRIRow NewTBLISEMRIRow() => (AtolyeListesi.TBLISEMRIRow) this.NewRow();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new AtolyeListesi.TBLISEMRIRow(builder);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override Type GetRowType() => typeof (AtolyeListesi.TBLISEMRIRow);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.TBLISEMRIRowChanged == null)
          return;
        this.TBLISEMRIRowChanged((object) this, new AtolyeListesi.TBLISEMRIRowChangeEvent((AtolyeListesi.TBLISEMRIRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.TBLISEMRIRowChanging == null)
          return;
        this.TBLISEMRIRowChanging((object) this, new AtolyeListesi.TBLISEMRIRowChangeEvent((AtolyeListesi.TBLISEMRIRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.TBLISEMRIRowDeleted == null)
          return;
        this.TBLISEMRIRowDeleted((object) this, new AtolyeListesi.TBLISEMRIRowChangeEvent((AtolyeListesi.TBLISEMRIRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.TBLISEMRIRowDeleting == null)
          return;
        this.TBLISEMRIRowDeleting((object) this, new AtolyeListesi.TBLISEMRIRowChangeEvent((AtolyeListesi.TBLISEMRIRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void RemoveTBLISEMRIRow(AtolyeListesi.TBLISEMRIRow row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        AtolyeListesi atolyeListesi = new AtolyeListesi();
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
          FixedValue = atolyeListesi.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (TBLISEMRIDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = atolyeListesi.GetSchemaSerializable();
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
    public class atolyeSarfDataTable : TypedTableBase<AtolyeListesi.atolyeSarfRow>
    {
      private DataColumn columnID;
      private DataColumn columnKOD;
      private DataColumn columnATOLYEID;
      private DataColumn columnGIRISTARIH;
      private DataColumn columnGIRISSAAT;
      private DataColumn columnCIKISTARIH;
      private DataColumn columnCIKISSAAT;
      private DataColumn columnARIZANEDENIID;
      private DataColumn columnBILDIRILENARIZA;
      private DataColumn columnISEMRIDURUMID;
      private DataColumn columnBAKIMYERIID;
      private DataColumn columnBAKIMYERACKLM;
      private DataColumn columnARACIGETIREN;
      private DataColumn columnBAKIMKMSI;
      private DataColumn columnSONRAKIBKMKM;
      private DataColumn columnSONRAKIBKMTRH;
      private DataColumn columnBAKIMSAATI;
      private DataColumn columnSONRAKIBKMSAAT;
      private DataColumn columnISEMRISIRANO;
      private DataColumn columnYAPILANBAKIMOZETI;
      private DataColumn columnIMZAATOLYESEFID;
      private DataColumn columnISBITIMORANI;
      private DataColumn columnBAKIMTURUID;
      private DataColumn columnBAKIMDERECESIID;
      private DataColumn columnYIL;
      private DataColumn columnARACID;
      private DataColumn columnARACACIKLAMA;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public atolyeSarfDataTable()
      {
        this.TableName = "atolyeSarf";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal atolyeSarfDataTable(DataTable table)
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
      protected atolyeSarfDataTable(SerializationInfo info, StreamingContext context)
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
      public DataColumn ATOLYEIDColumn => this.columnATOLYEID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn GIRISTARIHColumn => this.columnGIRISTARIH;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn GIRISSAATColumn => this.columnGIRISSAAT;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn CIKISTARIHColumn => this.columnCIKISTARIH;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn CIKISSAATColumn => this.columnCIKISSAAT;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ARIZANEDENIIDColumn => this.columnARIZANEDENIID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BILDIRILENARIZAColumn => this.columnBILDIRILENARIZA;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ISEMRIDURUMIDColumn => this.columnISEMRIDURUMID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BAKIMYERIIDColumn => this.columnBAKIMYERIID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BAKIMYERACKLMColumn => this.columnBAKIMYERACKLM;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ARACIGETIRENColumn => this.columnARACIGETIREN;

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
      public DataColumn ISEMRISIRANOColumn => this.columnISEMRISIRANO;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn YAPILANBAKIMOZETIColumn => this.columnYAPILANBAKIMOZETI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn IMZAATOLYESEFIDColumn => this.columnIMZAATOLYESEFID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ISBITIMORANIColumn => this.columnISBITIMORANI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BAKIMTURUIDColumn => this.columnBAKIMTURUID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BAKIMDERECESIIDColumn => this.columnBAKIMDERECESIID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn YILColumn => this.columnYIL;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ARACIDColumn => this.columnARACID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ARACACIKLAMAColumn => this.columnARACACIKLAMA;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AtolyeListesi.atolyeSarfRow this[int index] => (AtolyeListesi.atolyeSarfRow) this.Rows[index];

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event AtolyeListesi.atolyeSarfRowChangeEventHandler atolyeSarfRowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event AtolyeListesi.atolyeSarfRowChangeEventHandler atolyeSarfRowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event AtolyeListesi.atolyeSarfRowChangeEventHandler atolyeSarfRowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event AtolyeListesi.atolyeSarfRowChangeEventHandler atolyeSarfRowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void AddatolyeSarfRow(AtolyeListesi.atolyeSarfRow row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AtolyeListesi.atolyeSarfRow AddatolyeSarfRow(
        string KOD,
        int ATOLYEID,
        DateTime GIRISTARIH,
        DateTime GIRISSAAT,
        DateTime CIKISTARIH,
        DateTime CIKISSAAT,
        int ARIZANEDENIID,
        string BILDIRILENARIZA,
        int ISEMRIDURUMID,
        int BAKIMYERIID,
        string BAKIMYERACKLM,
        string ARACIGETIREN,
        string BAKIMKMSI,
        string SONRAKIBKMKM,
        string SONRAKIBKMTRH,
        string BAKIMSAATI,
        string SONRAKIBKMSAAT,
        int ISEMRISIRANO,
        string YAPILANBAKIMOZETI,
        int IMZAATOLYESEFID,
        string ISBITIMORANI,
        string BAKIMTURUID,
        string BAKIMDERECESIID,
        int YIL,
        int ARACID,
        string ARACACIKLAMA)
      {
        AtolyeListesi.atolyeSarfRow row = (AtolyeListesi.atolyeSarfRow) this.NewRow();
        object[] objArray = new object[27]
        {
          null,
          (object) KOD,
          (object) ATOLYEID,
          (object) GIRISTARIH,
          (object) GIRISSAAT,
          (object) CIKISTARIH,
          (object) CIKISSAAT,
          (object) ARIZANEDENIID,
          (object) BILDIRILENARIZA,
          (object) ISEMRIDURUMID,
          (object) BAKIMYERIID,
          (object) BAKIMYERACKLM,
          (object) ARACIGETIREN,
          (object) BAKIMKMSI,
          (object) SONRAKIBKMKM,
          (object) SONRAKIBKMTRH,
          (object) BAKIMSAATI,
          (object) SONRAKIBKMSAAT,
          (object) ISEMRISIRANO,
          (object) YAPILANBAKIMOZETI,
          (object) IMZAATOLYESEFID,
          (object) ISBITIMORANI,
          (object) BAKIMTURUID,
          (object) BAKIMDERECESIID,
          (object) YIL,
          (object) ARACID,
          (object) ARACACIKLAMA
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AtolyeListesi.atolyeSarfRow FindByID(int ID) => (AtolyeListesi.atolyeSarfRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public override DataTable Clone()
      {
        AtolyeListesi.atolyeSarfDataTable atolyeSarfDataTable = (AtolyeListesi.atolyeSarfDataTable) base.Clone();
        atolyeSarfDataTable.InitVars();
        return (DataTable) atolyeSarfDataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataTable CreateInstance() => (DataTable) new AtolyeListesi.atolyeSarfDataTable();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal void InitVars()
      {
        this.columnID = this.Columns["ID"];
        this.columnKOD = this.Columns["KOD"];
        this.columnATOLYEID = this.Columns["ATOLYEID"];
        this.columnGIRISTARIH = this.Columns["GIRISTARIH"];
        this.columnGIRISSAAT = this.Columns["GIRISSAAT"];
        this.columnCIKISTARIH = this.Columns["CIKISTARIH"];
        this.columnCIKISSAAT = this.Columns["CIKISSAAT"];
        this.columnARIZANEDENIID = this.Columns["ARIZANEDENIID"];
        this.columnBILDIRILENARIZA = this.Columns["BILDIRILENARIZA"];
        this.columnISEMRIDURUMID = this.Columns["ISEMRIDURUMID"];
        this.columnBAKIMYERIID = this.Columns["BAKIMYERIID"];
        this.columnBAKIMYERACKLM = this.Columns["BAKIMYERACKLM"];
        this.columnARACIGETIREN = this.Columns["ARACIGETIREN"];
        this.columnBAKIMKMSI = this.Columns["BAKIMKMSI"];
        this.columnSONRAKIBKMKM = this.Columns["SONRAKIBKMKM"];
        this.columnSONRAKIBKMTRH = this.Columns["SONRAKIBKMTRH"];
        this.columnBAKIMSAATI = this.Columns["BAKIMSAATI"];
        this.columnSONRAKIBKMSAAT = this.Columns["SONRAKIBKMSAAT"];
        this.columnISEMRISIRANO = this.Columns["ISEMRISIRANO"];
        this.columnYAPILANBAKIMOZETI = this.Columns["YAPILANBAKIMOZETI"];
        this.columnIMZAATOLYESEFID = this.Columns["IMZAATOLYESEFID"];
        this.columnISBITIMORANI = this.Columns["ISBITIMORANI"];
        this.columnBAKIMTURUID = this.Columns["BAKIMTURUID"];
        this.columnBAKIMDERECESIID = this.Columns["BAKIMDERECESIID"];
        this.columnYIL = this.Columns["YIL"];
        this.columnARACID = this.Columns["ARACID"];
        this.columnARACACIKLAMA = this.Columns["ARACACIKLAMA"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      private void InitClass()
      {
        this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnID);
        this.columnKOD = new DataColumn("KOD", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnKOD);
        this.columnATOLYEID = new DataColumn("ATOLYEID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnATOLYEID);
        this.columnGIRISTARIH = new DataColumn("GIRISTARIH", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGIRISTARIH);
        this.columnGIRISSAAT = new DataColumn("GIRISSAAT", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGIRISSAAT);
        this.columnCIKISTARIH = new DataColumn("CIKISTARIH", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCIKISTARIH);
        this.columnCIKISSAAT = new DataColumn("CIKISSAAT", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCIKISSAAT);
        this.columnARIZANEDENIID = new DataColumn("ARIZANEDENIID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnARIZANEDENIID);
        this.columnBILDIRILENARIZA = new DataColumn("BILDIRILENARIZA", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBILDIRILENARIZA);
        this.columnISEMRIDURUMID = new DataColumn("ISEMRIDURUMID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnISEMRIDURUMID);
        this.columnBAKIMYERIID = new DataColumn("BAKIMYERIID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBAKIMYERIID);
        this.columnBAKIMYERACKLM = new DataColumn("BAKIMYERACKLM", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBAKIMYERACKLM);
        this.columnARACIGETIREN = new DataColumn("ARACIGETIREN", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnARACIGETIREN);
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
        this.columnISEMRISIRANO = new DataColumn("ISEMRISIRANO", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnISEMRISIRANO);
        this.columnYAPILANBAKIMOZETI = new DataColumn("YAPILANBAKIMOZETI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnYAPILANBAKIMOZETI);
        this.columnIMZAATOLYESEFID = new DataColumn("IMZAATOLYESEFID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnIMZAATOLYESEFID);
        this.columnISBITIMORANI = new DataColumn("ISBITIMORANI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnISBITIMORANI);
        this.columnBAKIMTURUID = new DataColumn("BAKIMTURUID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBAKIMTURUID);
        this.columnBAKIMDERECESIID = new DataColumn("BAKIMDERECESIID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBAKIMDERECESIID);
        this.columnYIL = new DataColumn("YIL", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnYIL);
        this.columnARACID = new DataColumn("ARACID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnARACID);
        this.columnARACACIKLAMA = new DataColumn("ARACACIKLAMA", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnARACACIKLAMA);
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
        this.columnBILDIRILENARIZA.MaxLength = int.MaxValue;
        this.columnBAKIMYERACKLM.MaxLength = 50;
        this.columnARACIGETIREN.MaxLength = 50;
        this.columnBAKIMKMSI.MaxLength = 50;
        this.columnSONRAKIBKMKM.MaxLength = 50;
        this.columnSONRAKIBKMTRH.MaxLength = 50;
        this.columnBAKIMSAATI.MaxLength = 50;
        this.columnSONRAKIBKMSAAT.MaxLength = 50;
        this.columnYAPILANBAKIMOZETI.MaxLength = int.MaxValue;
        this.columnISBITIMORANI.MaxLength = 50;
        this.columnBAKIMTURUID.MaxLength = 50;
        this.columnBAKIMDERECESIID.MaxLength = 50;
        this.columnYIL.ReadOnly = true;
        this.columnARACACIKLAMA.MaxLength = 150;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AtolyeListesi.atolyeSarfRow NewatolyeSarfRow() => (AtolyeListesi.atolyeSarfRow) this.NewRow();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new AtolyeListesi.atolyeSarfRow(builder);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override Type GetRowType() => typeof (AtolyeListesi.atolyeSarfRow);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.atolyeSarfRowChanged == null)
          return;
        this.atolyeSarfRowChanged((object) this, new AtolyeListesi.atolyeSarfRowChangeEvent((AtolyeListesi.atolyeSarfRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.atolyeSarfRowChanging == null)
          return;
        this.atolyeSarfRowChanging((object) this, new AtolyeListesi.atolyeSarfRowChangeEvent((AtolyeListesi.atolyeSarfRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.atolyeSarfRowDeleted == null)
          return;
        this.atolyeSarfRowDeleted((object) this, new AtolyeListesi.atolyeSarfRowChangeEvent((AtolyeListesi.atolyeSarfRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.atolyeSarfRowDeleting == null)
          return;
        this.atolyeSarfRowDeleting((object) this, new AtolyeListesi.atolyeSarfRowChangeEvent((AtolyeListesi.atolyeSarfRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void RemoveatolyeSarfRow(AtolyeListesi.atolyeSarfRow row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        AtolyeListesi atolyeListesi = new AtolyeListesi();
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
          FixedValue = atolyeListesi.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (atolyeSarfDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = atolyeListesi.GetSchemaSerializable();
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
      private AtolyeListesi.TBLISEMRIDataTable tableTBLISEMRI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal TBLISEMRIRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableTBLISEMRI = (AtolyeListesi.TBLISEMRIDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ID
      {
        get => (int) this[this.tableTBLISEMRI.IDColumn];
        set => this[this.tableTBLISEMRI.IDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string KOD
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLISEMRI.KODColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLISEMRI' tablosundaki 'KOD' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLISEMRI.KODColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ATOLYEID
      {
        get
        {
          try
          {
            return (int) this[this.tableTBLISEMRI.ATOLYEIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLISEMRI' tablosundaki 'ATOLYEID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLISEMRI.ATOLYEIDColumn] = (object) value;
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
      public DateTime GIRISSAAT
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableTBLISEMRI.GIRISSAATColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLISEMRI' tablosundaki 'GIRISSAAT' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLISEMRI.GIRISSAATColumn] = (object) value;
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
      public DateTime CIKISSAAT
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableTBLISEMRI.CIKISSAATColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLISEMRI' tablosundaki 'CIKISSAAT' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLISEMRI.CIKISSAATColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ARIZANEDENIID
      {
        get
        {
          try
          {
            return (int) this[this.tableTBLISEMRI.ARIZANEDENIIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLISEMRI' tablosundaki 'ARIZANEDENIID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLISEMRI.ARIZANEDENIIDColumn] = (object) value;
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
      public int ISEMRIDURUMID
      {
        get
        {
          try
          {
            return (int) this[this.tableTBLISEMRI.ISEMRIDURUMIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLISEMRI' tablosundaki 'ISEMRIDURUMID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLISEMRI.ISEMRIDURUMIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int BAKIMYERIID
      {
        get
        {
          try
          {
            return (int) this[this.tableTBLISEMRI.BAKIMYERIIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLISEMRI' tablosundaki 'BAKIMYERIID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLISEMRI.BAKIMYERIIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string ARACIGETIREN
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLISEMRI.ARACIGETIRENColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLISEMRI' tablosundaki 'ARACIGETIREN' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLISEMRI.ARACIGETIRENColumn] = (object) value;
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
      public int ISEMRISIRANO
      {
        get
        {
          try
          {
            return (int) this[this.tableTBLISEMRI.ISEMRISIRANOColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLISEMRI' tablosundaki 'ISEMRISIRANO' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLISEMRI.ISEMRISIRANOColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int IMZAATOLYESEFID
      {
        get
        {
          try
          {
            return (int) this[this.tableTBLISEMRI.IMZAATOLYESEFIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLISEMRI' tablosundaki 'IMZAATOLYESEFID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLISEMRI.IMZAATOLYESEFIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string ISBITIMORANI
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLISEMRI.ISBITIMORANIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLISEMRI' tablosundaki 'ISBITIMORANI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLISEMRI.ISBITIMORANIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BAKIMTURUID
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLISEMRI.BAKIMTURUIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLISEMRI' tablosundaki 'BAKIMTURUID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLISEMRI.BAKIMTURUIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BAKIMDERECESIID
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLISEMRI.BAKIMDERECESIIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLISEMRI' tablosundaki 'BAKIMDERECESIID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLISEMRI.BAKIMDERECESIIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int YIL
      {
        get
        {
          try
          {
            return (int) this[this.tableTBLISEMRI.YILColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLISEMRI' tablosundaki 'YIL' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLISEMRI.YILColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string ARACACIKLAMA
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLISEMRI.ARACACIKLAMAColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLISEMRI' tablosundaki 'ARACACIKLAMA' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLISEMRI.ARACACIKLAMAColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsKODNull() => this.IsNull(this.tableTBLISEMRI.KODColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetKODNull() => this[this.tableTBLISEMRI.KODColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsATOLYEIDNull() => this.IsNull(this.tableTBLISEMRI.ATOLYEIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetATOLYEIDNull() => this[this.tableTBLISEMRI.ATOLYEIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsARACIDNull() => this.IsNull(this.tableTBLISEMRI.ARACIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetARACIDNull() => this[this.tableTBLISEMRI.ARACIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsGIRISTARIHNull() => this.IsNull(this.tableTBLISEMRI.GIRISTARIHColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetGIRISTARIHNull() => this[this.tableTBLISEMRI.GIRISTARIHColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsGIRISSAATNull() => this.IsNull(this.tableTBLISEMRI.GIRISSAATColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetGIRISSAATNull() => this[this.tableTBLISEMRI.GIRISSAATColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsCIKISTARIHNull() => this.IsNull(this.tableTBLISEMRI.CIKISTARIHColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetCIKISTARIHNull() => this[this.tableTBLISEMRI.CIKISTARIHColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsCIKISSAATNull() => this.IsNull(this.tableTBLISEMRI.CIKISSAATColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetCIKISSAATNull() => this[this.tableTBLISEMRI.CIKISSAATColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsARIZANEDENIIDNull() => this.IsNull(this.tableTBLISEMRI.ARIZANEDENIIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetARIZANEDENIIDNull() => this[this.tableTBLISEMRI.ARIZANEDENIIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBILDIRILENARIZANull() => this.IsNull(this.tableTBLISEMRI.BILDIRILENARIZAColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBILDIRILENARIZANull() => this[this.tableTBLISEMRI.BILDIRILENARIZAColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsISEMRIDURUMIDNull() => this.IsNull(this.tableTBLISEMRI.ISEMRIDURUMIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetISEMRIDURUMIDNull() => this[this.tableTBLISEMRI.ISEMRIDURUMIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBAKIMYERIIDNull() => this.IsNull(this.tableTBLISEMRI.BAKIMYERIIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBAKIMYERIIDNull() => this[this.tableTBLISEMRI.BAKIMYERIIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsARACIGETIRENNull() => this.IsNull(this.tableTBLISEMRI.ARACIGETIRENColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetARACIGETIRENNull() => this[this.tableTBLISEMRI.ARACIGETIRENColumn] = Convert.DBNull;

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
      public bool IsISEMRISIRANONull() => this.IsNull(this.tableTBLISEMRI.ISEMRISIRANOColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetISEMRISIRANONull() => this[this.tableTBLISEMRI.ISEMRISIRANOColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsIMZAATOLYESEFIDNull() => this.IsNull(this.tableTBLISEMRI.IMZAATOLYESEFIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetIMZAATOLYESEFIDNull() => this[this.tableTBLISEMRI.IMZAATOLYESEFIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsISBITIMORANINull() => this.IsNull(this.tableTBLISEMRI.ISBITIMORANIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetISBITIMORANINull() => this[this.tableTBLISEMRI.ISBITIMORANIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBAKIMTURUIDNull() => this.IsNull(this.tableTBLISEMRI.BAKIMTURUIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBAKIMTURUIDNull() => this[this.tableTBLISEMRI.BAKIMTURUIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBAKIMDERECESIIDNull() => this.IsNull(this.tableTBLISEMRI.BAKIMDERECESIIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBAKIMDERECESIIDNull() => this[this.tableTBLISEMRI.BAKIMDERECESIIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsYILNull() => this.IsNull(this.tableTBLISEMRI.YILColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetYILNull() => this[this.tableTBLISEMRI.YILColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsARACACIKLAMANull() => this.IsNull(this.tableTBLISEMRI.ARACACIKLAMAColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetARACACIKLAMANull() => this[this.tableTBLISEMRI.ARACACIKLAMAColumn] = Convert.DBNull;
    }

    public class atolyeSarfRow : DataRow
    {
      private AtolyeListesi.atolyeSarfDataTable tableatolyeSarf;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal atolyeSarfRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableatolyeSarf = (AtolyeListesi.atolyeSarfDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ID
      {
        get => (int) this[this.tableatolyeSarf.IDColumn];
        set => this[this.tableatolyeSarf.IDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string KOD
      {
        get
        {
          try
          {
            return (string) this[this.tableatolyeSarf.KODColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'atolyeSarf' tablosundaki 'KOD' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableatolyeSarf.KODColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ATOLYEID
      {
        get
        {
          try
          {
            return (int) this[this.tableatolyeSarf.ATOLYEIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'atolyeSarf' tablosundaki 'ATOLYEID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableatolyeSarf.ATOLYEIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DateTime GIRISTARIH
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableatolyeSarf.GIRISTARIHColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'atolyeSarf' tablosundaki 'GIRISTARIH' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableatolyeSarf.GIRISTARIHColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DateTime GIRISSAAT
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableatolyeSarf.GIRISSAATColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'atolyeSarf' tablosundaki 'GIRISSAAT' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableatolyeSarf.GIRISSAATColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DateTime CIKISTARIH
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableatolyeSarf.CIKISTARIHColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'atolyeSarf' tablosundaki 'CIKISTARIH' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableatolyeSarf.CIKISTARIHColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DateTime CIKISSAAT
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableatolyeSarf.CIKISSAATColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'atolyeSarf' tablosundaki 'CIKISSAAT' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableatolyeSarf.CIKISSAATColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ARIZANEDENIID
      {
        get
        {
          try
          {
            return (int) this[this.tableatolyeSarf.ARIZANEDENIIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'atolyeSarf' tablosundaki 'ARIZANEDENIID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableatolyeSarf.ARIZANEDENIIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BILDIRILENARIZA
      {
        get
        {
          try
          {
            return (string) this[this.tableatolyeSarf.BILDIRILENARIZAColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'atolyeSarf' tablosundaki 'BILDIRILENARIZA' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableatolyeSarf.BILDIRILENARIZAColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ISEMRIDURUMID
      {
        get
        {
          try
          {
            return (int) this[this.tableatolyeSarf.ISEMRIDURUMIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'atolyeSarf' tablosundaki 'ISEMRIDURUMID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableatolyeSarf.ISEMRIDURUMIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int BAKIMYERIID
      {
        get
        {
          try
          {
            return (int) this[this.tableatolyeSarf.BAKIMYERIIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'atolyeSarf' tablosundaki 'BAKIMYERIID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableatolyeSarf.BAKIMYERIIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BAKIMYERACKLM
      {
        get
        {
          try
          {
            return (string) this[this.tableatolyeSarf.BAKIMYERACKLMColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'atolyeSarf' tablosundaki 'BAKIMYERACKLM' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableatolyeSarf.BAKIMYERACKLMColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string ARACIGETIREN
      {
        get
        {
          try
          {
            return (string) this[this.tableatolyeSarf.ARACIGETIRENColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'atolyeSarf' tablosundaki 'ARACIGETIREN' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableatolyeSarf.ARACIGETIRENColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BAKIMKMSI
      {
        get
        {
          try
          {
            return (string) this[this.tableatolyeSarf.BAKIMKMSIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'atolyeSarf' tablosundaki 'BAKIMKMSI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableatolyeSarf.BAKIMKMSIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string SONRAKIBKMKM
      {
        get
        {
          try
          {
            return (string) this[this.tableatolyeSarf.SONRAKIBKMKMColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'atolyeSarf' tablosundaki 'SONRAKIBKMKM' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableatolyeSarf.SONRAKIBKMKMColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string SONRAKIBKMTRH
      {
        get
        {
          try
          {
            return (string) this[this.tableatolyeSarf.SONRAKIBKMTRHColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'atolyeSarf' tablosundaki 'SONRAKIBKMTRH' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableatolyeSarf.SONRAKIBKMTRHColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BAKIMSAATI
      {
        get
        {
          try
          {
            return (string) this[this.tableatolyeSarf.BAKIMSAATIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'atolyeSarf' tablosundaki 'BAKIMSAATI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableatolyeSarf.BAKIMSAATIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string SONRAKIBKMSAAT
      {
        get
        {
          try
          {
            return (string) this[this.tableatolyeSarf.SONRAKIBKMSAATColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'atolyeSarf' tablosundaki 'SONRAKIBKMSAAT' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableatolyeSarf.SONRAKIBKMSAATColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ISEMRISIRANO
      {
        get
        {
          try
          {
            return (int) this[this.tableatolyeSarf.ISEMRISIRANOColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'atolyeSarf' tablosundaki 'ISEMRISIRANO' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableatolyeSarf.ISEMRISIRANOColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string YAPILANBAKIMOZETI
      {
        get
        {
          try
          {
            return (string) this[this.tableatolyeSarf.YAPILANBAKIMOZETIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'atolyeSarf' tablosundaki 'YAPILANBAKIMOZETI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableatolyeSarf.YAPILANBAKIMOZETIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int IMZAATOLYESEFID
      {
        get
        {
          try
          {
            return (int) this[this.tableatolyeSarf.IMZAATOLYESEFIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'atolyeSarf' tablosundaki 'IMZAATOLYESEFID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableatolyeSarf.IMZAATOLYESEFIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string ISBITIMORANI
      {
        get
        {
          try
          {
            return (string) this[this.tableatolyeSarf.ISBITIMORANIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'atolyeSarf' tablosundaki 'ISBITIMORANI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableatolyeSarf.ISBITIMORANIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BAKIMTURUID
      {
        get
        {
          try
          {
            return (string) this[this.tableatolyeSarf.BAKIMTURUIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'atolyeSarf' tablosundaki 'BAKIMTURUID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableatolyeSarf.BAKIMTURUIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BAKIMDERECESIID
      {
        get
        {
          try
          {
            return (string) this[this.tableatolyeSarf.BAKIMDERECESIIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'atolyeSarf' tablosundaki 'BAKIMDERECESIID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableatolyeSarf.BAKIMDERECESIIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int YIL
      {
        get
        {
          try
          {
            return (int) this[this.tableatolyeSarf.YILColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'atolyeSarf' tablosundaki 'YIL' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableatolyeSarf.YILColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ARACID
      {
        get
        {
          try
          {
            return (int) this[this.tableatolyeSarf.ARACIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'atolyeSarf' tablosundaki 'ARACID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableatolyeSarf.ARACIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string ARACACIKLAMA
      {
        get
        {
          try
          {
            return (string) this[this.tableatolyeSarf.ARACACIKLAMAColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'atolyeSarf' tablosundaki 'ARACACIKLAMA' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableatolyeSarf.ARACACIKLAMAColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsKODNull() => this.IsNull(this.tableatolyeSarf.KODColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetKODNull() => this[this.tableatolyeSarf.KODColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsATOLYEIDNull() => this.IsNull(this.tableatolyeSarf.ATOLYEIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetATOLYEIDNull() => this[this.tableatolyeSarf.ATOLYEIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsGIRISTARIHNull() => this.IsNull(this.tableatolyeSarf.GIRISTARIHColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetGIRISTARIHNull() => this[this.tableatolyeSarf.GIRISTARIHColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsGIRISSAATNull() => this.IsNull(this.tableatolyeSarf.GIRISSAATColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetGIRISSAATNull() => this[this.tableatolyeSarf.GIRISSAATColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsCIKISTARIHNull() => this.IsNull(this.tableatolyeSarf.CIKISTARIHColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetCIKISTARIHNull() => this[this.tableatolyeSarf.CIKISTARIHColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsCIKISSAATNull() => this.IsNull(this.tableatolyeSarf.CIKISSAATColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetCIKISSAATNull() => this[this.tableatolyeSarf.CIKISSAATColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsARIZANEDENIIDNull() => this.IsNull(this.tableatolyeSarf.ARIZANEDENIIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetARIZANEDENIIDNull() => this[this.tableatolyeSarf.ARIZANEDENIIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBILDIRILENARIZANull() => this.IsNull(this.tableatolyeSarf.BILDIRILENARIZAColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBILDIRILENARIZANull() => this[this.tableatolyeSarf.BILDIRILENARIZAColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsISEMRIDURUMIDNull() => this.IsNull(this.tableatolyeSarf.ISEMRIDURUMIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetISEMRIDURUMIDNull() => this[this.tableatolyeSarf.ISEMRIDURUMIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBAKIMYERIIDNull() => this.IsNull(this.tableatolyeSarf.BAKIMYERIIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBAKIMYERIIDNull() => this[this.tableatolyeSarf.BAKIMYERIIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBAKIMYERACKLMNull() => this.IsNull(this.tableatolyeSarf.BAKIMYERACKLMColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBAKIMYERACKLMNull() => this[this.tableatolyeSarf.BAKIMYERACKLMColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsARACIGETIRENNull() => this.IsNull(this.tableatolyeSarf.ARACIGETIRENColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetARACIGETIRENNull() => this[this.tableatolyeSarf.ARACIGETIRENColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBAKIMKMSINull() => this.IsNull(this.tableatolyeSarf.BAKIMKMSIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBAKIMKMSINull() => this[this.tableatolyeSarf.BAKIMKMSIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsSONRAKIBKMKMNull() => this.IsNull(this.tableatolyeSarf.SONRAKIBKMKMColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetSONRAKIBKMKMNull() => this[this.tableatolyeSarf.SONRAKIBKMKMColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsSONRAKIBKMTRHNull() => this.IsNull(this.tableatolyeSarf.SONRAKIBKMTRHColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetSONRAKIBKMTRHNull() => this[this.tableatolyeSarf.SONRAKIBKMTRHColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBAKIMSAATINull() => this.IsNull(this.tableatolyeSarf.BAKIMSAATIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBAKIMSAATINull() => this[this.tableatolyeSarf.BAKIMSAATIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsSONRAKIBKMSAATNull() => this.IsNull(this.tableatolyeSarf.SONRAKIBKMSAATColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetSONRAKIBKMSAATNull() => this[this.tableatolyeSarf.SONRAKIBKMSAATColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsISEMRISIRANONull() => this.IsNull(this.tableatolyeSarf.ISEMRISIRANOColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetISEMRISIRANONull() => this[this.tableatolyeSarf.ISEMRISIRANOColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsYAPILANBAKIMOZETINull() => this.IsNull(this.tableatolyeSarf.YAPILANBAKIMOZETIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetYAPILANBAKIMOZETINull() => this[this.tableatolyeSarf.YAPILANBAKIMOZETIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsIMZAATOLYESEFIDNull() => this.IsNull(this.tableatolyeSarf.IMZAATOLYESEFIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetIMZAATOLYESEFIDNull() => this[this.tableatolyeSarf.IMZAATOLYESEFIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsISBITIMORANINull() => this.IsNull(this.tableatolyeSarf.ISBITIMORANIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetISBITIMORANINull() => this[this.tableatolyeSarf.ISBITIMORANIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBAKIMTURUIDNull() => this.IsNull(this.tableatolyeSarf.BAKIMTURUIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBAKIMTURUIDNull() => this[this.tableatolyeSarf.BAKIMTURUIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBAKIMDERECESIIDNull() => this.IsNull(this.tableatolyeSarf.BAKIMDERECESIIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBAKIMDERECESIIDNull() => this[this.tableatolyeSarf.BAKIMDERECESIIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsYILNull() => this.IsNull(this.tableatolyeSarf.YILColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetYILNull() => this[this.tableatolyeSarf.YILColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsARACIDNull() => this.IsNull(this.tableatolyeSarf.ARACIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetARACIDNull() => this[this.tableatolyeSarf.ARACIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsARACACIKLAMANull() => this.IsNull(this.tableatolyeSarf.ARACACIKLAMAColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetARACACIKLAMANull() => this[this.tableatolyeSarf.ARACACIKLAMAColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public class TBLISEMRIRowChangeEvent : EventArgs
    {
      private AtolyeListesi.TBLISEMRIRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public TBLISEMRIRowChangeEvent(AtolyeListesi.TBLISEMRIRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AtolyeListesi.TBLISEMRIRow Row => this.eventRow;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public class atolyeSarfRowChangeEvent : EventArgs
    {
      private AtolyeListesi.atolyeSarfRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public atolyeSarfRowChangeEvent(AtolyeListesi.atolyeSarfRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AtolyeListesi.atolyeSarfRow Row => this.eventRow;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataRowAction Action => this.eventAction;
    }
  }
}
