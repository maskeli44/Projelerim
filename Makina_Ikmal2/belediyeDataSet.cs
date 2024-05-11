// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.belediyeDataSet
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

namespace Makina_Ikmal
{
  [DesignerCategory("code")]
  [ToolboxItem(true)]
  [XmlSchemaProvider("GetTypedDataSetSchema")]
  [XmlRoot("belediyeDataSet")]
  [HelpKeyword("vs.data.DataSet")]
  [Serializable]
  public class belediyeDataSet : DataSet
  {
    private belediyeDataSet.TBLISEMRIDataTable tableTBLISEMRI;
    private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public belediyeDataSet()
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
    protected belediyeDataSet(SerializationInfo info, StreamingContext context)
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
            base.Tables.Add((DataTable) new belediyeDataSet.TBLISEMRIDataTable(dataSet.Tables[nameof (TBLISEMRI)]));
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
    public belediyeDataSet.TBLISEMRIDataTable TBLISEMRI => this.tableTBLISEMRI;

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
      belediyeDataSet belediyeDataSet = (belediyeDataSet) base.Clone();
      belediyeDataSet.InitVars();
      belediyeDataSet.SchemaSerializationMode = this.SchemaSerializationMode;
      return (DataSet) belediyeDataSet;
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
          base.Tables.Add((DataTable) new belediyeDataSet.TBLISEMRIDataTable(dataSet.Tables["TBLISEMRI"]));
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
      this.tableTBLISEMRI = (belediyeDataSet.TBLISEMRIDataTable) base.Tables["TBLISEMRI"];
      if (!initTable || this.tableTBLISEMRI == null)
        return;
      this.tableTBLISEMRI.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.DataSetName = nameof (belediyeDataSet);
      this.Prefix = "";
      this.Namespace = "http://tempuri.org/belediyeDataSet.xsd";
      this.EnforceConstraints = true;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tableTBLISEMRI = new belediyeDataSet.TBLISEMRIDataTable();
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
      belediyeDataSet belediyeDataSet = new belediyeDataSet();
      XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
      {
        Namespace = belediyeDataSet.Namespace
      });
      typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = belediyeDataSet.GetSchemaSerializable();
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
      belediyeDataSet.TBLISEMRIRowChangeEvent e);

    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class TBLISEMRIDataTable : TypedTableBase<belediyeDataSet.TBLISEMRIRow>
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
      private DataColumn columnSAVEUSER;
      private DataColumn columnSAVEDATE;
      private DataColumn columnEDITUSER;
      private DataColumn columnEDITDATE;
      private DataColumn columnSAVEMAC;
      private DataColumn columnEDITMAC;
      private DataColumn columnSAVEIP;
      private DataColumn columnEDITIP;
      private DataColumn columnBAKIMTURUID;
      private DataColumn columnBAKIMDERECESIID;
      private DataColumn columnIDX;

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
      public DataColumn BAKIMTURUIDColumn => this.columnBAKIMTURUID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BAKIMDERECESIIDColumn => this.columnBAKIMDERECESIID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn IDXColumn => this.columnIDX;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public belediyeDataSet.TBLISEMRIRow this[int index] => (belediyeDataSet.TBLISEMRIRow) this.Rows[index];

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event belediyeDataSet.TBLISEMRIRowChangeEventHandler TBLISEMRIRowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event belediyeDataSet.TBLISEMRIRowChangeEventHandler TBLISEMRIRowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event belediyeDataSet.TBLISEMRIRowChangeEventHandler TBLISEMRIRowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event belediyeDataSet.TBLISEMRIRowChangeEventHandler TBLISEMRIRowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void AddTBLISEMRIRow(belediyeDataSet.TBLISEMRIRow row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public belediyeDataSet.TBLISEMRIRow AddTBLISEMRIRow(
        int ID,
        string KOD,
        string ATOLYEID,
        string ARACID,
        string GIRISTARIH,
        string GIRISSAAT,
        string CIKISTARIH,
        string CIKISSAAT,
        string ARIZANEDENIID,
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
        string SAVEUSER,
        string SAVEDATE,
        string EDITUSER,
        string EDITDATE,
        string SAVEMAC,
        string EDITMAC,
        string SAVEIP,
        string EDITIP,
        string BAKIMTURUID,
        string BAKIMDERECESIID)
      {
        belediyeDataSet.TBLISEMRIRow row = (belediyeDataSet.TBLISEMRIRow) this.NewRow();
        object[] objArray = new object[34]
        {
          (object) ID,
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
          (object) SAVEUSER,
          (object) SAVEDATE,
          (object) EDITUSER,
          (object) EDITDATE,
          (object) SAVEMAC,
          (object) EDITMAC,
          (object) SAVEIP,
          (object) EDITIP,
          (object) BAKIMTURUID,
          (object) BAKIMDERECESIID,
          null
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public belediyeDataSet.TBLISEMRIRow FindByIDX(int IDX) => (belediyeDataSet.TBLISEMRIRow) this.Rows.Find(new object[1]
      {
        (object) IDX
      });

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public override DataTable Clone()
      {
        belediyeDataSet.TBLISEMRIDataTable tblisemriDataTable = (belediyeDataSet.TBLISEMRIDataTable) base.Clone();
        tblisemriDataTable.InitVars();
        return (DataTable) tblisemriDataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataTable CreateInstance() => (DataTable) new belediyeDataSet.TBLISEMRIDataTable();

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
        this.columnSAVEUSER = this.Columns["SAVEUSER"];
        this.columnSAVEDATE = this.Columns["SAVEDATE"];
        this.columnEDITUSER = this.Columns["EDITUSER"];
        this.columnEDITDATE = this.Columns["EDITDATE"];
        this.columnSAVEMAC = this.Columns["SAVEMAC"];
        this.columnEDITMAC = this.Columns["EDITMAC"];
        this.columnSAVEIP = this.Columns["SAVEIP"];
        this.columnEDITIP = this.Columns["EDITIP"];
        this.columnBAKIMTURUID = this.Columns["BAKIMTURUID"];
        this.columnBAKIMDERECESIID = this.Columns["BAKIMDERECESIID"];
        this.columnIDX = this.Columns["IDX"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      private void InitClass()
      {
        this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnID);
        this.columnKOD = new DataColumn("KOD", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnKOD);
        this.columnATOLYEID = new DataColumn("ATOLYEID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnATOLYEID);
        this.columnARACID = new DataColumn("ARACID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnARACID);
        this.columnGIRISTARIH = new DataColumn("GIRISTARIH", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGIRISTARIH);
        this.columnGIRISSAAT = new DataColumn("GIRISSAAT", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGIRISSAAT);
        this.columnCIKISTARIH = new DataColumn("CIKISTARIH", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCIKISTARIH);
        this.columnCIKISSAAT = new DataColumn("CIKISSAAT", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCIKISSAAT);
        this.columnARIZANEDENIID = new DataColumn("ARIZANEDENIID", typeof (string), (string) null, MappingType.Element);
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
        this.columnSAVEUSER = new DataColumn("SAVEUSER", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSAVEUSER);
        this.columnSAVEDATE = new DataColumn("SAVEDATE", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSAVEDATE);
        this.columnEDITUSER = new DataColumn("EDITUSER", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnEDITUSER);
        this.columnEDITDATE = new DataColumn("EDITDATE", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnEDITDATE);
        this.columnSAVEMAC = new DataColumn("SAVEMAC", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSAVEMAC);
        this.columnEDITMAC = new DataColumn("EDITMAC", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnEDITMAC);
        this.columnSAVEIP = new DataColumn("SAVEIP", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSAVEIP);
        this.columnEDITIP = new DataColumn("EDITIP", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnEDITIP);
        this.columnBAKIMTURUID = new DataColumn("BAKIMTURUID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBAKIMTURUID);
        this.columnBAKIMDERECESIID = new DataColumn("BAKIMDERECESIID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBAKIMDERECESIID);
        this.columnIDX = new DataColumn("IDX", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnIDX);
        this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
        {
          this.columnIDX
        }, true));
        this.columnKOD.MaxLength = 8;
        this.columnATOLYEID.MaxLength = 2;
        this.columnARACID.MaxLength = 4;
        this.columnGIRISTARIH.MaxLength = 19;
        this.columnGIRISSAAT.MaxLength = 16;
        this.columnCIKISTARIH.MaxLength = 19;
        this.columnCIKISSAAT.MaxLength = 16;
        this.columnARIZANEDENIID.MaxLength = 1;
        this.columnBILDIRILENARIZA.MaxLength = 100;
        this.columnBAKIMYERACKLM.MaxLength = 27;
        this.columnARACIGETIREN.MaxLength = 26;
        this.columnBAKIMKMSI.MaxLength = 8;
        this.columnSONRAKIBKMKM.MaxLength = 7;
        this.columnSONRAKIBKMTRH.MaxLength = 20;
        this.columnBAKIMSAATI.MaxLength = 20;
        this.columnSONRAKIBKMSAAT.MaxLength = 20;
        this.columnYAPILANBAKIMOZETI.MaxLength = 100;
        this.columnISBITIMORANI.MaxLength = 3;
        this.columnSAVEUSER.MaxLength = 15;
        this.columnSAVEDATE.MaxLength = 19;
        this.columnEDITUSER.MaxLength = 15;
        this.columnEDITDATE.MaxLength = 19;
        this.columnSAVEMAC.MaxLength = 20;
        this.columnEDITMAC.MaxLength = 20;
        this.columnSAVEIP.MaxLength = 20;
        this.columnEDITIP.MaxLength = 20;
        this.columnBAKIMTURUID.MaxLength = 1;
        this.columnBAKIMDERECESIID.MaxLength = 1;
        this.columnIDX.AutoIncrement = true;
        this.columnIDX.AutoIncrementSeed = -1L;
        this.columnIDX.AutoIncrementStep = -1L;
        this.columnIDX.AllowDBNull = false;
        this.columnIDX.ReadOnly = true;
        this.columnIDX.Unique = true;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public belediyeDataSet.TBLISEMRIRow NewTBLISEMRIRow() => (belediyeDataSet.TBLISEMRIRow) this.NewRow();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new belediyeDataSet.TBLISEMRIRow(builder);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override Type GetRowType() => typeof (belediyeDataSet.TBLISEMRIRow);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.TBLISEMRIRowChanged == null)
          return;
        this.TBLISEMRIRowChanged((object) this, new belediyeDataSet.TBLISEMRIRowChangeEvent((belediyeDataSet.TBLISEMRIRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.TBLISEMRIRowChanging == null)
          return;
        this.TBLISEMRIRowChanging((object) this, new belediyeDataSet.TBLISEMRIRowChangeEvent((belediyeDataSet.TBLISEMRIRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.TBLISEMRIRowDeleted == null)
          return;
        this.TBLISEMRIRowDeleted((object) this, new belediyeDataSet.TBLISEMRIRowChangeEvent((belediyeDataSet.TBLISEMRIRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.TBLISEMRIRowDeleting == null)
          return;
        this.TBLISEMRIRowDeleting((object) this, new belediyeDataSet.TBLISEMRIRowChangeEvent((belediyeDataSet.TBLISEMRIRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void RemoveTBLISEMRIRow(belediyeDataSet.TBLISEMRIRow row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        belediyeDataSet belediyeDataSet = new belediyeDataSet();
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
          FixedValue = belediyeDataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (TBLISEMRIDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = belediyeDataSet.GetSchemaSerializable();
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
      private belediyeDataSet.TBLISEMRIDataTable tableTBLISEMRI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal TBLISEMRIRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableTBLISEMRI = (belediyeDataSet.TBLISEMRIDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ID
      {
        get
        {
          try
          {
            return (int) this[this.tableTBLISEMRI.IDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLISEMRI' tablosundaki 'ID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
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
      public string ATOLYEID
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLISEMRI.ATOLYEIDColumn];
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
      public string ARACID
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLISEMRI.ARACIDColumn];
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
      public string GIRISTARIH
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLISEMRI.GIRISTARIHColumn];
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
      public string GIRISSAAT
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLISEMRI.GIRISSAATColumn];
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
      public string CIKISTARIH
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLISEMRI.CIKISTARIHColumn];
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
      public string CIKISSAAT
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLISEMRI.CIKISSAATColumn];
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
      public string ARIZANEDENIID
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLISEMRI.ARIZANEDENIIDColumn];
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
      public string BAKIMYERACKLM
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLISEMRI.BAKIMYERACKLMColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLISEMRI' tablosundaki 'BAKIMYERACKLM' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLISEMRI.BAKIMYERACKLMColumn] = (object) value;
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
      public string SAVEUSER
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLISEMRI.SAVEUSERColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLISEMRI' tablosundaki 'SAVEUSER' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLISEMRI.SAVEUSERColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string SAVEDATE
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLISEMRI.SAVEDATEColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLISEMRI' tablosundaki 'SAVEDATE' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLISEMRI.SAVEDATEColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string EDITUSER
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLISEMRI.EDITUSERColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLISEMRI' tablosundaki 'EDITUSER' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLISEMRI.EDITUSERColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string EDITDATE
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLISEMRI.EDITDATEColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLISEMRI' tablosundaki 'EDITDATE' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLISEMRI.EDITDATEColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string SAVEMAC
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLISEMRI.SAVEMACColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLISEMRI' tablosundaki 'SAVEMAC' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLISEMRI.SAVEMACColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string EDITMAC
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLISEMRI.EDITMACColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLISEMRI' tablosundaki 'EDITMAC' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLISEMRI.EDITMACColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string SAVEIP
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLISEMRI.SAVEIPColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLISEMRI' tablosundaki 'SAVEIP' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLISEMRI.SAVEIPColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string EDITIP
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLISEMRI.EDITIPColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLISEMRI' tablosundaki 'EDITIP' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLISEMRI.EDITIPColumn] = (object) value;
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
      public int IDX
      {
        get => (int) this[this.tableTBLISEMRI.IDXColumn];
        set => this[this.tableTBLISEMRI.IDXColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsIDNull() => this.IsNull(this.tableTBLISEMRI.IDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetIDNull() => this[this.tableTBLISEMRI.IDColumn] = Convert.DBNull;

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
      public bool IsBAKIMYERACKLMNull() => this.IsNull(this.tableTBLISEMRI.BAKIMYERACKLMColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBAKIMYERACKLMNull() => this[this.tableTBLISEMRI.BAKIMYERACKLMColumn] = Convert.DBNull;

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
      public bool IsYAPILANBAKIMOZETINull() => this.IsNull(this.tableTBLISEMRI.YAPILANBAKIMOZETIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetYAPILANBAKIMOZETINull() => this[this.tableTBLISEMRI.YAPILANBAKIMOZETIColumn] = Convert.DBNull;

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
      public bool IsSAVEUSERNull() => this.IsNull(this.tableTBLISEMRI.SAVEUSERColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetSAVEUSERNull() => this[this.tableTBLISEMRI.SAVEUSERColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsSAVEDATENull() => this.IsNull(this.tableTBLISEMRI.SAVEDATEColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetSAVEDATENull() => this[this.tableTBLISEMRI.SAVEDATEColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsEDITUSERNull() => this.IsNull(this.tableTBLISEMRI.EDITUSERColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetEDITUSERNull() => this[this.tableTBLISEMRI.EDITUSERColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsEDITDATENull() => this.IsNull(this.tableTBLISEMRI.EDITDATEColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetEDITDATENull() => this[this.tableTBLISEMRI.EDITDATEColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsSAVEMACNull() => this.IsNull(this.tableTBLISEMRI.SAVEMACColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetSAVEMACNull() => this[this.tableTBLISEMRI.SAVEMACColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsEDITMACNull() => this.IsNull(this.tableTBLISEMRI.EDITMACColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetEDITMACNull() => this[this.tableTBLISEMRI.EDITMACColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsSAVEIPNull() => this.IsNull(this.tableTBLISEMRI.SAVEIPColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetSAVEIPNull() => this[this.tableTBLISEMRI.SAVEIPColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsEDITIPNull() => this.IsNull(this.tableTBLISEMRI.EDITIPColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetEDITIPNull() => this[this.tableTBLISEMRI.EDITIPColumn] = Convert.DBNull;

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
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public class TBLISEMRIRowChangeEvent : EventArgs
    {
      private belediyeDataSet.TBLISEMRIRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public TBLISEMRIRowChangeEvent(belediyeDataSet.TBLISEMRIRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public belediyeDataSet.TBLISEMRIRow Row => this.eventRow;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataRowAction Action => this.eventAction;
    }
  }
}
