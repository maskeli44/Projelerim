// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Model.MoldelAtolye.atolye_yagListesi
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

namespace Makina_Ikmal.Model.MoldelAtolye
{
  [DesignerCategory("code")]
  [ToolboxItem(true)]
  [XmlSchemaProvider("GetTypedDataSetSchema")]
  [XmlRoot("atolye_yagListesi")]
  [HelpKeyword("vs.data.DataSet")]
  [Serializable]
  public class atolye_yagListesi : DataSet
  {
    private atolye_yagListesi.sarfAtolyeDataTable tablesarfAtolye;
    private atolye_yagListesi.yagMerkeziDataTable tableyagMerkezi;
    private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public atolye_yagListesi()
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
    protected atolye_yagListesi(SerializationInfo info, StreamingContext context)
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
          if (dataSet.Tables[nameof (sarfAtolye)] != null)
            base.Tables.Add((DataTable) new atolye_yagListesi.sarfAtolyeDataTable(dataSet.Tables[nameof (sarfAtolye)]));
          if (dataSet.Tables[nameof (yagMerkezi)] != null)
            base.Tables.Add((DataTable) new atolye_yagListesi.yagMerkeziDataTable(dataSet.Tables[nameof (yagMerkezi)]));
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
    public atolye_yagListesi.sarfAtolyeDataTable sarfAtolye => this.tablesarfAtolye;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public atolye_yagListesi.yagMerkeziDataTable yagMerkezi => this.tableyagMerkezi;

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
      atolye_yagListesi atolyeYagListesi = (atolye_yagListesi) base.Clone();
      atolyeYagListesi.InitVars();
      atolyeYagListesi.SchemaSerializationMode = this.SchemaSerializationMode;
      return (DataSet) atolyeYagListesi;
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
        if (dataSet.Tables["sarfAtolye"] != null)
          base.Tables.Add((DataTable) new atolye_yagListesi.sarfAtolyeDataTable(dataSet.Tables["sarfAtolye"]));
        if (dataSet.Tables["yagMerkezi"] != null)
          base.Tables.Add((DataTable) new atolye_yagListesi.yagMerkeziDataTable(dataSet.Tables["yagMerkezi"]));
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
      this.tablesarfAtolye = (atolye_yagListesi.sarfAtolyeDataTable) base.Tables["sarfAtolye"];
      if (initTable && this.tablesarfAtolye != null)
        this.tablesarfAtolye.InitVars();
      this.tableyagMerkezi = (atolye_yagListesi.yagMerkeziDataTable) base.Tables["yagMerkezi"];
      if (!initTable || this.tableyagMerkezi == null)
        return;
      this.tableyagMerkezi.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.DataSetName = nameof (atolye_yagListesi);
      this.Prefix = "";
      this.Namespace = "http://tempuri.org/atolye_yagListesi.xsd";
      this.EnforceConstraints = true;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tablesarfAtolye = new atolye_yagListesi.sarfAtolyeDataTable();
      base.Tables.Add((DataTable) this.tablesarfAtolye);
      this.tableyagMerkezi = new atolye_yagListesi.yagMerkeziDataTable();
      base.Tables.Add((DataTable) this.tableyagMerkezi);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private bool ShouldSerializesarfAtolye() => false;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private bool ShouldSerializeyagMerkezi() => false;

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
      atolye_yagListesi atolyeYagListesi = new atolye_yagListesi();
      XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
      {
        Namespace = atolyeYagListesi.Namespace
      });
      typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = atolyeYagListesi.GetSchemaSerializable();
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
    public delegate void sarfAtolyeRowChangeEventHandler(
      object sender,
      atolye_yagListesi.sarfAtolyeRowChangeEvent e);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public delegate void yagMerkeziRowChangeEventHandler(
      object sender,
      atolye_yagListesi.yagMerkeziRowChangeEvent e);

    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class sarfAtolyeDataTable : TypedTableBase<atolye_yagListesi.sarfAtolyeRow>
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
      private DataColumn columnExpr1;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public sarfAtolyeDataTable()
      {
        this.TableName = "sarfAtolye";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal sarfAtolyeDataTable(DataTable table)
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
      protected sarfAtolyeDataTable(SerializationInfo info, StreamingContext context)
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
      public DataColumn Expr1Column => this.columnExpr1;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public atolye_yagListesi.sarfAtolyeRow this[int index] => (atolye_yagListesi.sarfAtolyeRow) this.Rows[index];

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event atolye_yagListesi.sarfAtolyeRowChangeEventHandler sarfAtolyeRowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event atolye_yagListesi.sarfAtolyeRowChangeEventHandler sarfAtolyeRowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event atolye_yagListesi.sarfAtolyeRowChangeEventHandler sarfAtolyeRowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event atolye_yagListesi.sarfAtolyeRowChangeEventHandler sarfAtolyeRowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void AddsarfAtolyeRow(atolye_yagListesi.sarfAtolyeRow row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public atolye_yagListesi.sarfAtolyeRow AddsarfAtolyeRow(
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
        DateTime SAVEDATE,
        string EDITUSER,
        DateTime EDITDATE,
        string SAVEMAC,
        string EDITMAC,
        string SAVEIP,
        string EDITIP,
        string BAKIMTURUID,
        string BAKIMDERECESIID,
        int Expr1)
      {
        atolye_yagListesi.sarfAtolyeRow row = (atolye_yagListesi.sarfAtolyeRow) this.NewRow();
        object[] objArray = new object[34]
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
          (object) Expr1
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public atolye_yagListesi.sarfAtolyeRow FindByID(int ID) => (atolye_yagListesi.sarfAtolyeRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public override DataTable Clone()
      {
        atolye_yagListesi.sarfAtolyeDataTable sarfAtolyeDataTable = (atolye_yagListesi.sarfAtolyeDataTable) base.Clone();
        sarfAtolyeDataTable.InitVars();
        return (DataTable) sarfAtolyeDataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataTable CreateInstance() => (DataTable) new atolye_yagListesi.sarfAtolyeDataTable();

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
        this.columnExpr1 = this.Columns["Expr1"];
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
        this.columnBAKIMTURUID = new DataColumn("BAKIMTURUID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBAKIMTURUID);
        this.columnBAKIMDERECESIID = new DataColumn("BAKIMDERECESIID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBAKIMDERECESIID);
        this.columnExpr1 = new DataColumn("Expr1", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnExpr1);
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
        this.columnSAVEUSER.MaxLength = 50;
        this.columnEDITUSER.MaxLength = 50;
        this.columnSAVEMAC.MaxLength = 20;
        this.columnEDITMAC.MaxLength = 20;
        this.columnSAVEIP.MaxLength = 20;
        this.columnEDITIP.MaxLength = 20;
        this.columnBAKIMTURUID.MaxLength = 50;
        this.columnBAKIMDERECESIID.MaxLength = 50;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public atolye_yagListesi.sarfAtolyeRow NewsarfAtolyeRow() => (atolye_yagListesi.sarfAtolyeRow) this.NewRow();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new atolye_yagListesi.sarfAtolyeRow(builder);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override Type GetRowType() => typeof (atolye_yagListesi.sarfAtolyeRow);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.sarfAtolyeRowChanged == null)
          return;
        this.sarfAtolyeRowChanged((object) this, new atolye_yagListesi.sarfAtolyeRowChangeEvent((atolye_yagListesi.sarfAtolyeRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.sarfAtolyeRowChanging == null)
          return;
        this.sarfAtolyeRowChanging((object) this, new atolye_yagListesi.sarfAtolyeRowChangeEvent((atolye_yagListesi.sarfAtolyeRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.sarfAtolyeRowDeleted == null)
          return;
        this.sarfAtolyeRowDeleted((object) this, new atolye_yagListesi.sarfAtolyeRowChangeEvent((atolye_yagListesi.sarfAtolyeRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.sarfAtolyeRowDeleting == null)
          return;
        this.sarfAtolyeRowDeleting((object) this, new atolye_yagListesi.sarfAtolyeRowChangeEvent((atolye_yagListesi.sarfAtolyeRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void RemovesarfAtolyeRow(atolye_yagListesi.sarfAtolyeRow row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        atolye_yagListesi atolyeYagListesi = new atolye_yagListesi();
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
          FixedValue = atolyeYagListesi.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (sarfAtolyeDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = atolyeYagListesi.GetSchemaSerializable();
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
    public class yagMerkeziDataTable : TypedTableBase<atolye_yagListesi.yagMerkeziRow>
    {
      private DataColumn columnID;
      private DataColumn columnKOD;
      private DataColumn columnATOLYEID;
      private DataColumn columnARACID;
      private DataColumn columnGIRISSAAT;
      private DataColumn columnGIRISTARIH;
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
      private DataColumn columnARACACIKLAMA;
      private DataColumn columnPLAKA;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public yagMerkeziDataTable()
      {
        this.TableName = "yagMerkezi";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal yagMerkeziDataTable(DataTable table)
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
      protected yagMerkeziDataTable(SerializationInfo info, StreamingContext context)
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
      public DataColumn GIRISSAATColumn => this.columnGIRISSAAT;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn GIRISTARIHColumn => this.columnGIRISTARIH;

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
      public DataColumn ARACACIKLAMAColumn => this.columnARACACIKLAMA;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn PLAKAColumn => this.columnPLAKA;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public atolye_yagListesi.yagMerkeziRow this[int index] => (atolye_yagListesi.yagMerkeziRow) this.Rows[index];

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event atolye_yagListesi.yagMerkeziRowChangeEventHandler yagMerkeziRowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event atolye_yagListesi.yagMerkeziRowChangeEventHandler yagMerkeziRowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event atolye_yagListesi.yagMerkeziRowChangeEventHandler yagMerkeziRowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event atolye_yagListesi.yagMerkeziRowChangeEventHandler yagMerkeziRowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void AddyagMerkeziRow(atolye_yagListesi.yagMerkeziRow row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public atolye_yagListesi.yagMerkeziRow AddyagMerkeziRow(
        string KOD,
        int ATOLYEID,
        int ARACID,
        DateTime GIRISSAAT,
        DateTime GIRISTARIH,
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
        string ARACACIKLAMA,
        string PLAKA)
      {
        atolye_yagListesi.yagMerkeziRow row = (atolye_yagListesi.yagMerkeziRow) this.NewRow();
        object[] objArray = new object[27]
        {
          null,
          (object) KOD,
          (object) ATOLYEID,
          (object) ARACID,
          (object) GIRISSAAT,
          (object) GIRISTARIH,
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
          (object) ARACACIKLAMA,
          (object) PLAKA
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public atolye_yagListesi.yagMerkeziRow FindByID(int ID) => (atolye_yagListesi.yagMerkeziRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public override DataTable Clone()
      {
        atolye_yagListesi.yagMerkeziDataTable merkeziDataTable = (atolye_yagListesi.yagMerkeziDataTable) base.Clone();
        merkeziDataTable.InitVars();
        return (DataTable) merkeziDataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataTable CreateInstance() => (DataTable) new atolye_yagListesi.yagMerkeziDataTable();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal void InitVars()
      {
        this.columnID = this.Columns["ID"];
        this.columnKOD = this.Columns["KOD"];
        this.columnATOLYEID = this.Columns["ATOLYEID"];
        this.columnARACID = this.Columns["ARACID"];
        this.columnGIRISSAAT = this.Columns["GIRISSAAT"];
        this.columnGIRISTARIH = this.Columns["GIRISTARIH"];
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
        this.columnARACACIKLAMA = this.Columns["ARACACIKLAMA"];
        this.columnPLAKA = this.Columns["PLAKA"];
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
        this.columnGIRISSAAT = new DataColumn("GIRISSAAT", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGIRISSAAT);
        this.columnGIRISTARIH = new DataColumn("GIRISTARIH", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGIRISTARIH);
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
        this.columnARACACIKLAMA = new DataColumn("ARACACIKLAMA", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnARACACIKLAMA);
        this.columnPLAKA = new DataColumn("PLAKA", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnPLAKA);
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
        this.columnARACACIKLAMA.MaxLength = 200;
        this.columnPLAKA.MaxLength = 50;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public atolye_yagListesi.yagMerkeziRow NewyagMerkeziRow() => (atolye_yagListesi.yagMerkeziRow) this.NewRow();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new atolye_yagListesi.yagMerkeziRow(builder);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override Type GetRowType() => typeof (atolye_yagListesi.yagMerkeziRow);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.yagMerkeziRowChanged == null)
          return;
        this.yagMerkeziRowChanged((object) this, new atolye_yagListesi.yagMerkeziRowChangeEvent((atolye_yagListesi.yagMerkeziRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.yagMerkeziRowChanging == null)
          return;
        this.yagMerkeziRowChanging((object) this, new atolye_yagListesi.yagMerkeziRowChangeEvent((atolye_yagListesi.yagMerkeziRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.yagMerkeziRowDeleted == null)
          return;
        this.yagMerkeziRowDeleted((object) this, new atolye_yagListesi.yagMerkeziRowChangeEvent((atolye_yagListesi.yagMerkeziRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.yagMerkeziRowDeleting == null)
          return;
        this.yagMerkeziRowDeleting((object) this, new atolye_yagListesi.yagMerkeziRowChangeEvent((atolye_yagListesi.yagMerkeziRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void RemoveyagMerkeziRow(atolye_yagListesi.yagMerkeziRow row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        atolye_yagListesi atolyeYagListesi = new atolye_yagListesi();
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
          FixedValue = atolyeYagListesi.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (yagMerkeziDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = atolyeYagListesi.GetSchemaSerializable();
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

    public class sarfAtolyeRow : DataRow
    {
      private atolye_yagListesi.sarfAtolyeDataTable tablesarfAtolye;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal sarfAtolyeRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tablesarfAtolye = (atolye_yagListesi.sarfAtolyeDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ID
      {
        get => (int) this[this.tablesarfAtolye.IDColumn];
        set => this[this.tablesarfAtolye.IDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string KOD
      {
        get
        {
          try
          {
            return (string) this[this.tablesarfAtolye.KODColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'sarfAtolye' tablosundaki 'KOD' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tablesarfAtolye.KODColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ATOLYEID
      {
        get
        {
          try
          {
            return (int) this[this.tablesarfAtolye.ATOLYEIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'sarfAtolye' tablosundaki 'ATOLYEID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tablesarfAtolye.ATOLYEIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ARACID
      {
        get
        {
          try
          {
            return (int) this[this.tablesarfAtolye.ARACIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'sarfAtolye' tablosundaki 'ARACID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tablesarfAtolye.ARACIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DateTime GIRISTARIH
      {
        get
        {
          try
          {
            return (DateTime) this[this.tablesarfAtolye.GIRISTARIHColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'sarfAtolye' tablosundaki 'GIRISTARIH' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tablesarfAtolye.GIRISTARIHColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DateTime GIRISSAAT
      {
        get
        {
          try
          {
            return (DateTime) this[this.tablesarfAtolye.GIRISSAATColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'sarfAtolye' tablosundaki 'GIRISSAAT' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tablesarfAtolye.GIRISSAATColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DateTime CIKISTARIH
      {
        get
        {
          try
          {
            return (DateTime) this[this.tablesarfAtolye.CIKISTARIHColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'sarfAtolye' tablosundaki 'CIKISTARIH' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tablesarfAtolye.CIKISTARIHColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DateTime CIKISSAAT
      {
        get
        {
          try
          {
            return (DateTime) this[this.tablesarfAtolye.CIKISSAATColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'sarfAtolye' tablosundaki 'CIKISSAAT' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tablesarfAtolye.CIKISSAATColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ARIZANEDENIID
      {
        get
        {
          try
          {
            return (int) this[this.tablesarfAtolye.ARIZANEDENIIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'sarfAtolye' tablosundaki 'ARIZANEDENIID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tablesarfAtolye.ARIZANEDENIIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BILDIRILENARIZA
      {
        get
        {
          try
          {
            return (string) this[this.tablesarfAtolye.BILDIRILENARIZAColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'sarfAtolye' tablosundaki 'BILDIRILENARIZA' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tablesarfAtolye.BILDIRILENARIZAColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ISEMRIDURUMID
      {
        get
        {
          try
          {
            return (int) this[this.tablesarfAtolye.ISEMRIDURUMIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'sarfAtolye' tablosundaki 'ISEMRIDURUMID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tablesarfAtolye.ISEMRIDURUMIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int BAKIMYERIID
      {
        get
        {
          try
          {
            return (int) this[this.tablesarfAtolye.BAKIMYERIIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'sarfAtolye' tablosundaki 'BAKIMYERIID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tablesarfAtolye.BAKIMYERIIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BAKIMYERACKLM
      {
        get
        {
          try
          {
            return (string) this[this.tablesarfAtolye.BAKIMYERACKLMColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'sarfAtolye' tablosundaki 'BAKIMYERACKLM' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tablesarfAtolye.BAKIMYERACKLMColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string ARACIGETIREN
      {
        get
        {
          try
          {
            return (string) this[this.tablesarfAtolye.ARACIGETIRENColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'sarfAtolye' tablosundaki 'ARACIGETIREN' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tablesarfAtolye.ARACIGETIRENColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BAKIMKMSI
      {
        get
        {
          try
          {
            return (string) this[this.tablesarfAtolye.BAKIMKMSIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'sarfAtolye' tablosundaki 'BAKIMKMSI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tablesarfAtolye.BAKIMKMSIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string SONRAKIBKMKM
      {
        get
        {
          try
          {
            return (string) this[this.tablesarfAtolye.SONRAKIBKMKMColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'sarfAtolye' tablosundaki 'SONRAKIBKMKM' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tablesarfAtolye.SONRAKIBKMKMColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string SONRAKIBKMTRH
      {
        get
        {
          try
          {
            return (string) this[this.tablesarfAtolye.SONRAKIBKMTRHColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'sarfAtolye' tablosundaki 'SONRAKIBKMTRH' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tablesarfAtolye.SONRAKIBKMTRHColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BAKIMSAATI
      {
        get
        {
          try
          {
            return (string) this[this.tablesarfAtolye.BAKIMSAATIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'sarfAtolye' tablosundaki 'BAKIMSAATI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tablesarfAtolye.BAKIMSAATIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string SONRAKIBKMSAAT
      {
        get
        {
          try
          {
            return (string) this[this.tablesarfAtolye.SONRAKIBKMSAATColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'sarfAtolye' tablosundaki 'SONRAKIBKMSAAT' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tablesarfAtolye.SONRAKIBKMSAATColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ISEMRISIRANO
      {
        get
        {
          try
          {
            return (int) this[this.tablesarfAtolye.ISEMRISIRANOColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'sarfAtolye' tablosundaki 'ISEMRISIRANO' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tablesarfAtolye.ISEMRISIRANOColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string YAPILANBAKIMOZETI
      {
        get
        {
          try
          {
            return (string) this[this.tablesarfAtolye.YAPILANBAKIMOZETIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'sarfAtolye' tablosundaki 'YAPILANBAKIMOZETI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tablesarfAtolye.YAPILANBAKIMOZETIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int IMZAATOLYESEFID
      {
        get
        {
          try
          {
            return (int) this[this.tablesarfAtolye.IMZAATOLYESEFIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'sarfAtolye' tablosundaki 'IMZAATOLYESEFID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tablesarfAtolye.IMZAATOLYESEFIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string ISBITIMORANI
      {
        get
        {
          try
          {
            return (string) this[this.tablesarfAtolye.ISBITIMORANIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'sarfAtolye' tablosundaki 'ISBITIMORANI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tablesarfAtolye.ISBITIMORANIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string SAVEUSER
      {
        get
        {
          try
          {
            return (string) this[this.tablesarfAtolye.SAVEUSERColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'sarfAtolye' tablosundaki 'SAVEUSER' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tablesarfAtolye.SAVEUSERColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DateTime SAVEDATE
      {
        get
        {
          try
          {
            return (DateTime) this[this.tablesarfAtolye.SAVEDATEColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'sarfAtolye' tablosundaki 'SAVEDATE' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tablesarfAtolye.SAVEDATEColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string EDITUSER
      {
        get
        {
          try
          {
            return (string) this[this.tablesarfAtolye.EDITUSERColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'sarfAtolye' tablosundaki 'EDITUSER' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tablesarfAtolye.EDITUSERColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DateTime EDITDATE
      {
        get
        {
          try
          {
            return (DateTime) this[this.tablesarfAtolye.EDITDATEColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'sarfAtolye' tablosundaki 'EDITDATE' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tablesarfAtolye.EDITDATEColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string SAVEMAC
      {
        get
        {
          try
          {
            return (string) this[this.tablesarfAtolye.SAVEMACColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'sarfAtolye' tablosundaki 'SAVEMAC' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tablesarfAtolye.SAVEMACColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string EDITMAC
      {
        get
        {
          try
          {
            return (string) this[this.tablesarfAtolye.EDITMACColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'sarfAtolye' tablosundaki 'EDITMAC' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tablesarfAtolye.EDITMACColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string SAVEIP
      {
        get
        {
          try
          {
            return (string) this[this.tablesarfAtolye.SAVEIPColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'sarfAtolye' tablosundaki 'SAVEIP' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tablesarfAtolye.SAVEIPColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string EDITIP
      {
        get
        {
          try
          {
            return (string) this[this.tablesarfAtolye.EDITIPColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'sarfAtolye' tablosundaki 'EDITIP' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tablesarfAtolye.EDITIPColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BAKIMTURUID
      {
        get
        {
          try
          {
            return (string) this[this.tablesarfAtolye.BAKIMTURUIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'sarfAtolye' tablosundaki 'BAKIMTURUID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tablesarfAtolye.BAKIMTURUIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BAKIMDERECESIID
      {
        get
        {
          try
          {
            return (string) this[this.tablesarfAtolye.BAKIMDERECESIIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'sarfAtolye' tablosundaki 'BAKIMDERECESIID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tablesarfAtolye.BAKIMDERECESIIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int Expr1
      {
        get
        {
          try
          {
            return (int) this[this.tablesarfAtolye.Expr1Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'sarfAtolye' tablosundaki 'Expr1' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tablesarfAtolye.Expr1Column] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsKODNull() => this.IsNull(this.tablesarfAtolye.KODColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetKODNull() => this[this.tablesarfAtolye.KODColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsATOLYEIDNull() => this.IsNull(this.tablesarfAtolye.ATOLYEIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetATOLYEIDNull() => this[this.tablesarfAtolye.ATOLYEIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsARACIDNull() => this.IsNull(this.tablesarfAtolye.ARACIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetARACIDNull() => this[this.tablesarfAtolye.ARACIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsGIRISTARIHNull() => this.IsNull(this.tablesarfAtolye.GIRISTARIHColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetGIRISTARIHNull() => this[this.tablesarfAtolye.GIRISTARIHColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsGIRISSAATNull() => this.IsNull(this.tablesarfAtolye.GIRISSAATColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetGIRISSAATNull() => this[this.tablesarfAtolye.GIRISSAATColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsCIKISTARIHNull() => this.IsNull(this.tablesarfAtolye.CIKISTARIHColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetCIKISTARIHNull() => this[this.tablesarfAtolye.CIKISTARIHColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsCIKISSAATNull() => this.IsNull(this.tablesarfAtolye.CIKISSAATColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetCIKISSAATNull() => this[this.tablesarfAtolye.CIKISSAATColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsARIZANEDENIIDNull() => this.IsNull(this.tablesarfAtolye.ARIZANEDENIIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetARIZANEDENIIDNull() => this[this.tablesarfAtolye.ARIZANEDENIIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBILDIRILENARIZANull() => this.IsNull(this.tablesarfAtolye.BILDIRILENARIZAColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBILDIRILENARIZANull() => this[this.tablesarfAtolye.BILDIRILENARIZAColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsISEMRIDURUMIDNull() => this.IsNull(this.tablesarfAtolye.ISEMRIDURUMIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetISEMRIDURUMIDNull() => this[this.tablesarfAtolye.ISEMRIDURUMIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBAKIMYERIIDNull() => this.IsNull(this.tablesarfAtolye.BAKIMYERIIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBAKIMYERIIDNull() => this[this.tablesarfAtolye.BAKIMYERIIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBAKIMYERACKLMNull() => this.IsNull(this.tablesarfAtolye.BAKIMYERACKLMColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBAKIMYERACKLMNull() => this[this.tablesarfAtolye.BAKIMYERACKLMColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsARACIGETIRENNull() => this.IsNull(this.tablesarfAtolye.ARACIGETIRENColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetARACIGETIRENNull() => this[this.tablesarfAtolye.ARACIGETIRENColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBAKIMKMSINull() => this.IsNull(this.tablesarfAtolye.BAKIMKMSIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBAKIMKMSINull() => this[this.tablesarfAtolye.BAKIMKMSIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsSONRAKIBKMKMNull() => this.IsNull(this.tablesarfAtolye.SONRAKIBKMKMColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetSONRAKIBKMKMNull() => this[this.tablesarfAtolye.SONRAKIBKMKMColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsSONRAKIBKMTRHNull() => this.IsNull(this.tablesarfAtolye.SONRAKIBKMTRHColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetSONRAKIBKMTRHNull() => this[this.tablesarfAtolye.SONRAKIBKMTRHColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBAKIMSAATINull() => this.IsNull(this.tablesarfAtolye.BAKIMSAATIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBAKIMSAATINull() => this[this.tablesarfAtolye.BAKIMSAATIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsSONRAKIBKMSAATNull() => this.IsNull(this.tablesarfAtolye.SONRAKIBKMSAATColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetSONRAKIBKMSAATNull() => this[this.tablesarfAtolye.SONRAKIBKMSAATColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsISEMRISIRANONull() => this.IsNull(this.tablesarfAtolye.ISEMRISIRANOColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetISEMRISIRANONull() => this[this.tablesarfAtolye.ISEMRISIRANOColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsYAPILANBAKIMOZETINull() => this.IsNull(this.tablesarfAtolye.YAPILANBAKIMOZETIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetYAPILANBAKIMOZETINull() => this[this.tablesarfAtolye.YAPILANBAKIMOZETIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsIMZAATOLYESEFIDNull() => this.IsNull(this.tablesarfAtolye.IMZAATOLYESEFIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetIMZAATOLYESEFIDNull() => this[this.tablesarfAtolye.IMZAATOLYESEFIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsISBITIMORANINull() => this.IsNull(this.tablesarfAtolye.ISBITIMORANIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetISBITIMORANINull() => this[this.tablesarfAtolye.ISBITIMORANIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsSAVEUSERNull() => this.IsNull(this.tablesarfAtolye.SAVEUSERColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetSAVEUSERNull() => this[this.tablesarfAtolye.SAVEUSERColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsSAVEDATENull() => this.IsNull(this.tablesarfAtolye.SAVEDATEColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetSAVEDATENull() => this[this.tablesarfAtolye.SAVEDATEColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsEDITUSERNull() => this.IsNull(this.tablesarfAtolye.EDITUSERColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetEDITUSERNull() => this[this.tablesarfAtolye.EDITUSERColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsEDITDATENull() => this.IsNull(this.tablesarfAtolye.EDITDATEColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetEDITDATENull() => this[this.tablesarfAtolye.EDITDATEColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsSAVEMACNull() => this.IsNull(this.tablesarfAtolye.SAVEMACColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetSAVEMACNull() => this[this.tablesarfAtolye.SAVEMACColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsEDITMACNull() => this.IsNull(this.tablesarfAtolye.EDITMACColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetEDITMACNull() => this[this.tablesarfAtolye.EDITMACColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsSAVEIPNull() => this.IsNull(this.tablesarfAtolye.SAVEIPColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetSAVEIPNull() => this[this.tablesarfAtolye.SAVEIPColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsEDITIPNull() => this.IsNull(this.tablesarfAtolye.EDITIPColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetEDITIPNull() => this[this.tablesarfAtolye.EDITIPColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBAKIMTURUIDNull() => this.IsNull(this.tablesarfAtolye.BAKIMTURUIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBAKIMTURUIDNull() => this[this.tablesarfAtolye.BAKIMTURUIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBAKIMDERECESIIDNull() => this.IsNull(this.tablesarfAtolye.BAKIMDERECESIIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBAKIMDERECESIIDNull() => this[this.tablesarfAtolye.BAKIMDERECESIIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsExpr1Null() => this.IsNull(this.tablesarfAtolye.Expr1Column);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetExpr1Null() => this[this.tablesarfAtolye.Expr1Column] = Convert.DBNull;
    }

    public class yagMerkeziRow : DataRow
    {
      private atolye_yagListesi.yagMerkeziDataTable tableyagMerkezi;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal yagMerkeziRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableyagMerkezi = (atolye_yagListesi.yagMerkeziDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ID
      {
        get => (int) this[this.tableyagMerkezi.IDColumn];
        set => this[this.tableyagMerkezi.IDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string KOD
      {
        get
        {
          try
          {
            return (string) this[this.tableyagMerkezi.KODColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'yagMerkezi' tablosundaki 'KOD' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableyagMerkezi.KODColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ATOLYEID
      {
        get
        {
          try
          {
            return (int) this[this.tableyagMerkezi.ATOLYEIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'yagMerkezi' tablosundaki 'ATOLYEID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableyagMerkezi.ATOLYEIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ARACID
      {
        get
        {
          try
          {
            return (int) this[this.tableyagMerkezi.ARACIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'yagMerkezi' tablosundaki 'ARACID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableyagMerkezi.ARACIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DateTime GIRISSAAT
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableyagMerkezi.GIRISSAATColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'yagMerkezi' tablosundaki 'GIRISSAAT' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableyagMerkezi.GIRISSAATColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DateTime GIRISTARIH
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableyagMerkezi.GIRISTARIHColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'yagMerkezi' tablosundaki 'GIRISTARIH' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableyagMerkezi.GIRISTARIHColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DateTime CIKISTARIH
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableyagMerkezi.CIKISTARIHColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'yagMerkezi' tablosundaki 'CIKISTARIH' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableyagMerkezi.CIKISTARIHColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DateTime CIKISSAAT
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableyagMerkezi.CIKISSAATColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'yagMerkezi' tablosundaki 'CIKISSAAT' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableyagMerkezi.CIKISSAATColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ARIZANEDENIID
      {
        get
        {
          try
          {
            return (int) this[this.tableyagMerkezi.ARIZANEDENIIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'yagMerkezi' tablosundaki 'ARIZANEDENIID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableyagMerkezi.ARIZANEDENIIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BILDIRILENARIZA
      {
        get
        {
          try
          {
            return (string) this[this.tableyagMerkezi.BILDIRILENARIZAColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'yagMerkezi' tablosundaki 'BILDIRILENARIZA' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableyagMerkezi.BILDIRILENARIZAColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ISEMRIDURUMID
      {
        get
        {
          try
          {
            return (int) this[this.tableyagMerkezi.ISEMRIDURUMIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'yagMerkezi' tablosundaki 'ISEMRIDURUMID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableyagMerkezi.ISEMRIDURUMIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int BAKIMYERIID
      {
        get
        {
          try
          {
            return (int) this[this.tableyagMerkezi.BAKIMYERIIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'yagMerkezi' tablosundaki 'BAKIMYERIID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableyagMerkezi.BAKIMYERIIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BAKIMYERACKLM
      {
        get
        {
          try
          {
            return (string) this[this.tableyagMerkezi.BAKIMYERACKLMColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'yagMerkezi' tablosundaki 'BAKIMYERACKLM' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableyagMerkezi.BAKIMYERACKLMColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string ARACIGETIREN
      {
        get
        {
          try
          {
            return (string) this[this.tableyagMerkezi.ARACIGETIRENColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'yagMerkezi' tablosundaki 'ARACIGETIREN' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableyagMerkezi.ARACIGETIRENColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BAKIMKMSI
      {
        get
        {
          try
          {
            return (string) this[this.tableyagMerkezi.BAKIMKMSIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'yagMerkezi' tablosundaki 'BAKIMKMSI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableyagMerkezi.BAKIMKMSIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string SONRAKIBKMKM
      {
        get
        {
          try
          {
            return (string) this[this.tableyagMerkezi.SONRAKIBKMKMColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'yagMerkezi' tablosundaki 'SONRAKIBKMKM' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableyagMerkezi.SONRAKIBKMKMColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string SONRAKIBKMTRH
      {
        get
        {
          try
          {
            return (string) this[this.tableyagMerkezi.SONRAKIBKMTRHColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'yagMerkezi' tablosundaki 'SONRAKIBKMTRH' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableyagMerkezi.SONRAKIBKMTRHColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BAKIMSAATI
      {
        get
        {
          try
          {
            return (string) this[this.tableyagMerkezi.BAKIMSAATIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'yagMerkezi' tablosundaki 'BAKIMSAATI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableyagMerkezi.BAKIMSAATIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string SONRAKIBKMSAAT
      {
        get
        {
          try
          {
            return (string) this[this.tableyagMerkezi.SONRAKIBKMSAATColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'yagMerkezi' tablosundaki 'SONRAKIBKMSAAT' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableyagMerkezi.SONRAKIBKMSAATColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ISEMRISIRANO
      {
        get
        {
          try
          {
            return (int) this[this.tableyagMerkezi.ISEMRISIRANOColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'yagMerkezi' tablosundaki 'ISEMRISIRANO' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableyagMerkezi.ISEMRISIRANOColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string YAPILANBAKIMOZETI
      {
        get
        {
          try
          {
            return (string) this[this.tableyagMerkezi.YAPILANBAKIMOZETIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'yagMerkezi' tablosundaki 'YAPILANBAKIMOZETI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableyagMerkezi.YAPILANBAKIMOZETIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int IMZAATOLYESEFID
      {
        get
        {
          try
          {
            return (int) this[this.tableyagMerkezi.IMZAATOLYESEFIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'yagMerkezi' tablosundaki 'IMZAATOLYESEFID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableyagMerkezi.IMZAATOLYESEFIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string ISBITIMORANI
      {
        get
        {
          try
          {
            return (string) this[this.tableyagMerkezi.ISBITIMORANIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'yagMerkezi' tablosundaki 'ISBITIMORANI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableyagMerkezi.ISBITIMORANIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BAKIMTURUID
      {
        get
        {
          try
          {
            return (string) this[this.tableyagMerkezi.BAKIMTURUIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'yagMerkezi' tablosundaki 'BAKIMTURUID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableyagMerkezi.BAKIMTURUIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BAKIMDERECESIID
      {
        get
        {
          try
          {
            return (string) this[this.tableyagMerkezi.BAKIMDERECESIIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'yagMerkezi' tablosundaki 'BAKIMDERECESIID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableyagMerkezi.BAKIMDERECESIIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string ARACACIKLAMA
      {
        get
        {
          try
          {
            return (string) this[this.tableyagMerkezi.ARACACIKLAMAColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'yagMerkezi' tablosundaki 'ARACACIKLAMA' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableyagMerkezi.ARACACIKLAMAColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string PLAKA
      {
        get
        {
          try
          {
            return (string) this[this.tableyagMerkezi.PLAKAColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'yagMerkezi' tablosundaki 'PLAKA' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableyagMerkezi.PLAKAColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsKODNull() => this.IsNull(this.tableyagMerkezi.KODColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetKODNull() => this[this.tableyagMerkezi.KODColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsATOLYEIDNull() => this.IsNull(this.tableyagMerkezi.ATOLYEIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetATOLYEIDNull() => this[this.tableyagMerkezi.ATOLYEIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsARACIDNull() => this.IsNull(this.tableyagMerkezi.ARACIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetARACIDNull() => this[this.tableyagMerkezi.ARACIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsGIRISSAATNull() => this.IsNull(this.tableyagMerkezi.GIRISSAATColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetGIRISSAATNull() => this[this.tableyagMerkezi.GIRISSAATColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsGIRISTARIHNull() => this.IsNull(this.tableyagMerkezi.GIRISTARIHColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetGIRISTARIHNull() => this[this.tableyagMerkezi.GIRISTARIHColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsCIKISTARIHNull() => this.IsNull(this.tableyagMerkezi.CIKISTARIHColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetCIKISTARIHNull() => this[this.tableyagMerkezi.CIKISTARIHColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsCIKISSAATNull() => this.IsNull(this.tableyagMerkezi.CIKISSAATColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetCIKISSAATNull() => this[this.tableyagMerkezi.CIKISSAATColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsARIZANEDENIIDNull() => this.IsNull(this.tableyagMerkezi.ARIZANEDENIIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetARIZANEDENIIDNull() => this[this.tableyagMerkezi.ARIZANEDENIIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBILDIRILENARIZANull() => this.IsNull(this.tableyagMerkezi.BILDIRILENARIZAColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBILDIRILENARIZANull() => this[this.tableyagMerkezi.BILDIRILENARIZAColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsISEMRIDURUMIDNull() => this.IsNull(this.tableyagMerkezi.ISEMRIDURUMIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetISEMRIDURUMIDNull() => this[this.tableyagMerkezi.ISEMRIDURUMIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBAKIMYERIIDNull() => this.IsNull(this.tableyagMerkezi.BAKIMYERIIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBAKIMYERIIDNull() => this[this.tableyagMerkezi.BAKIMYERIIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBAKIMYERACKLMNull() => this.IsNull(this.tableyagMerkezi.BAKIMYERACKLMColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBAKIMYERACKLMNull() => this[this.tableyagMerkezi.BAKIMYERACKLMColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsARACIGETIRENNull() => this.IsNull(this.tableyagMerkezi.ARACIGETIRENColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetARACIGETIRENNull() => this[this.tableyagMerkezi.ARACIGETIRENColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBAKIMKMSINull() => this.IsNull(this.tableyagMerkezi.BAKIMKMSIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBAKIMKMSINull() => this[this.tableyagMerkezi.BAKIMKMSIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsSONRAKIBKMKMNull() => this.IsNull(this.tableyagMerkezi.SONRAKIBKMKMColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetSONRAKIBKMKMNull() => this[this.tableyagMerkezi.SONRAKIBKMKMColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsSONRAKIBKMTRHNull() => this.IsNull(this.tableyagMerkezi.SONRAKIBKMTRHColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetSONRAKIBKMTRHNull() => this[this.tableyagMerkezi.SONRAKIBKMTRHColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBAKIMSAATINull() => this.IsNull(this.tableyagMerkezi.BAKIMSAATIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBAKIMSAATINull() => this[this.tableyagMerkezi.BAKIMSAATIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsSONRAKIBKMSAATNull() => this.IsNull(this.tableyagMerkezi.SONRAKIBKMSAATColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetSONRAKIBKMSAATNull() => this[this.tableyagMerkezi.SONRAKIBKMSAATColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsISEMRISIRANONull() => this.IsNull(this.tableyagMerkezi.ISEMRISIRANOColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetISEMRISIRANONull() => this[this.tableyagMerkezi.ISEMRISIRANOColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsYAPILANBAKIMOZETINull() => this.IsNull(this.tableyagMerkezi.YAPILANBAKIMOZETIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetYAPILANBAKIMOZETINull() => this[this.tableyagMerkezi.YAPILANBAKIMOZETIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsIMZAATOLYESEFIDNull() => this.IsNull(this.tableyagMerkezi.IMZAATOLYESEFIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetIMZAATOLYESEFIDNull() => this[this.tableyagMerkezi.IMZAATOLYESEFIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsISBITIMORANINull() => this.IsNull(this.tableyagMerkezi.ISBITIMORANIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetISBITIMORANINull() => this[this.tableyagMerkezi.ISBITIMORANIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBAKIMTURUIDNull() => this.IsNull(this.tableyagMerkezi.BAKIMTURUIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBAKIMTURUIDNull() => this[this.tableyagMerkezi.BAKIMTURUIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBAKIMDERECESIIDNull() => this.IsNull(this.tableyagMerkezi.BAKIMDERECESIIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBAKIMDERECESIIDNull() => this[this.tableyagMerkezi.BAKIMDERECESIIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsARACACIKLAMANull() => this.IsNull(this.tableyagMerkezi.ARACACIKLAMAColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetARACACIKLAMANull() => this[this.tableyagMerkezi.ARACACIKLAMAColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsPLAKANull() => this.IsNull(this.tableyagMerkezi.PLAKAColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetPLAKANull() => this[this.tableyagMerkezi.PLAKAColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public class sarfAtolyeRowChangeEvent : EventArgs
    {
      private atolye_yagListesi.sarfAtolyeRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public sarfAtolyeRowChangeEvent(atolye_yagListesi.sarfAtolyeRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public atolye_yagListesi.sarfAtolyeRow Row => this.eventRow;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public class yagMerkeziRowChangeEvent : EventArgs
    {
      private atolye_yagListesi.yagMerkeziRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public yagMerkeziRowChangeEvent(atolye_yagListesi.yagMerkeziRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public atolye_yagListesi.yagMerkeziRow Row => this.eventRow;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataRowAction Action => this.eventAction;
    }
  }
}
