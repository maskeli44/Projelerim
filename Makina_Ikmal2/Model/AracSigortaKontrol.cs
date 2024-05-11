// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Model.AracSigortaKontrol
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
  [XmlRoot("AracSigortaKontrol")]
  [HelpKeyword("vs.data.DataSet")]
  [Serializable]
  public class AracSigortaKontrol : DataSet
  {
    private AracSigortaKontrol.TBLARACLARDataTable tableTBLARACLAR;
    private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public AracSigortaKontrol()
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
    protected AracSigortaKontrol(SerializationInfo info, StreamingContext context)
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
          if (dataSet.Tables[nameof (TBLARACLAR)] != null)
            base.Tables.Add((DataTable) new AracSigortaKontrol.TBLARACLARDataTable(dataSet.Tables[nameof (TBLARACLAR)]));
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
    public AracSigortaKontrol.TBLARACLARDataTable TBLARACLAR => this.tableTBLARACLAR;

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
      AracSigortaKontrol aracSigortaKontrol = (AracSigortaKontrol) base.Clone();
      aracSigortaKontrol.InitVars();
      aracSigortaKontrol.SchemaSerializationMode = this.SchemaSerializationMode;
      return (DataSet) aracSigortaKontrol;
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
        if (dataSet.Tables["TBLARACLAR"] != null)
          base.Tables.Add((DataTable) new AracSigortaKontrol.TBLARACLARDataTable(dataSet.Tables["TBLARACLAR"]));
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
      this.tableTBLARACLAR = (AracSigortaKontrol.TBLARACLARDataTable) base.Tables["TBLARACLAR"];
      if (!initTable || this.tableTBLARACLAR == null)
        return;
      this.tableTBLARACLAR.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.DataSetName = nameof (AracSigortaKontrol);
      this.Prefix = "";
      this.Namespace = "http://tempuri.org/AracSigortaKontrol.xsd";
      this.EnforceConstraints = true;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tableTBLARACLAR = new AracSigortaKontrol.TBLARACLARDataTable();
      base.Tables.Add((DataTable) this.tableTBLARACLAR);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private bool ShouldSerializeTBLARACLAR() => false;

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
      AracSigortaKontrol aracSigortaKontrol = new AracSigortaKontrol();
      XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
      {
        Namespace = aracSigortaKontrol.Namespace
      });
      typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = aracSigortaKontrol.GetSchemaSerializable();
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
    public delegate void TBLARACLARRowChangeEventHandler(
      object sender,
      AracSigortaKontrol.TBLARACLARRowChangeEvent e);

    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class TBLARACLARDataTable : TypedTableBase<AracSigortaKontrol.TBLARACLARRow>
    {
      private DataColumn columnPlaka;
      private DataColumn columnMarka;
      private DataColumn columnModel;
      private DataColumn columnCinsi;
      private DataColumn columnTipi;
      private DataColumn columnRengi;
      private DataColumn columnBirim;
      private DataColumn columnARACDURUMID;
      private DataColumn columnARACTIPIID;
      private DataColumn columnARACGRUBUID;
      private DataColumn columnTRAFIKSGORTA2;
      private DataColumn columnExpr2;
      private DataColumn columnaracID;
      private DataColumn columnkalanGun;
      private DataColumn columnAciklama;
      private DataColumn columnverildigiIlce;
      private DataColumn columntahsisPlaka;
      private DataColumn columnticariAdi;
      private DataColumn columnmudurlık;
      private DataColumn columnbelgoNo;
      private DataColumn columnmotorNo;
      private DataColumn columnsaseNo;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public TBLARACLARDataTable()
      {
        this.TableName = "TBLARACLAR";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal TBLARACLARDataTable(DataTable table)
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
      protected TBLARACLARDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn PlakaColumn => this.columnPlaka;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MarkaColumn => this.columnMarka;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ModelColumn => this.columnModel;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn CinsiColumn => this.columnCinsi;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn TipiColumn => this.columnTipi;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn RengiColumn => this.columnRengi;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BirimColumn => this.columnBirim;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ARACDURUMIDColumn => this.columnARACDURUMID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ARACTIPIIDColumn => this.columnARACTIPIID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ARACGRUBUIDColumn => this.columnARACGRUBUID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn TRAFIKSGORTA2Column => this.columnTRAFIKSGORTA2;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn Expr2Column => this.columnExpr2;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn aracIDColumn => this.columnaracID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn kalanGunColumn => this.columnkalanGun;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn AciklamaColumn => this.columnAciklama;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn verildigiIlceColumn => this.columnverildigiIlce;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn tahsisPlakaColumn => this.columntahsisPlaka;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ticariAdiColumn => this.columnticariAdi;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn mudurlıkColumn => this.columnmudurlık;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn belgoNoColumn => this.columnbelgoNo;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn motorNoColumn => this.columnmotorNo;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn saseNoColumn => this.columnsaseNo;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AracSigortaKontrol.TBLARACLARRow this[int index] => (AracSigortaKontrol.TBLARACLARRow) this.Rows[index];

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event AracSigortaKontrol.TBLARACLARRowChangeEventHandler TBLARACLARRowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event AracSigortaKontrol.TBLARACLARRowChangeEventHandler TBLARACLARRowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event AracSigortaKontrol.TBLARACLARRowChangeEventHandler TBLARACLARRowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event AracSigortaKontrol.TBLARACLARRowChangeEventHandler TBLARACLARRowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void AddTBLARACLARRow(AracSigortaKontrol.TBLARACLARRow row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AracSigortaKontrol.TBLARACLARRow AddTBLARACLARRow(
        string Plaka,
        int Marka,
        string Model,
        string Cinsi,
        string Tipi,
        string Rengi,
        int Birim,
        int ARACDURUMID,
        int ARACTIPIID,
        int ARACGRUBUID,
        DateTime TRAFIKSGORTA2,
        DateTime Expr2,
        int kalanGun,
        string Aciklama,
        string verildigiIlce,
        string tahsisPlaka,
        string ticariAdi,
        int mudurlık,
        string belgoNo,
        string motorNo,
        string saseNo)
      {
        AracSigortaKontrol.TBLARACLARRow row = (AracSigortaKontrol.TBLARACLARRow) this.NewRow();
        object[] objArray = new object[22]
        {
          (object) Plaka,
          (object) Marka,
          (object) Model,
          (object) Cinsi,
          (object) Tipi,
          (object) Rengi,
          (object) Birim,
          (object) ARACDURUMID,
          (object) ARACTIPIID,
          (object) ARACGRUBUID,
          (object) TRAFIKSGORTA2,
          (object) Expr2,
          null,
          (object) kalanGun,
          (object) Aciklama,
          (object) verildigiIlce,
          (object) tahsisPlaka,
          (object) ticariAdi,
          (object) mudurlık,
          (object) belgoNo,
          (object) motorNo,
          (object) saseNo
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AracSigortaKontrol.TBLARACLARRow FindByaracID(int aracID) => (AracSigortaKontrol.TBLARACLARRow) this.Rows.Find(new object[1]
      {
        (object) aracID
      });

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public override DataTable Clone()
      {
        AracSigortaKontrol.TBLARACLARDataTable tblaraclarDataTable = (AracSigortaKontrol.TBLARACLARDataTable) base.Clone();
        tblaraclarDataTable.InitVars();
        return (DataTable) tblaraclarDataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataTable CreateInstance() => (DataTable) new AracSigortaKontrol.TBLARACLARDataTable();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal void InitVars()
      {
        this.columnPlaka = this.Columns["Plaka"];
        this.columnMarka = this.Columns["Marka"];
        this.columnModel = this.Columns["Model"];
        this.columnCinsi = this.Columns["Cinsi"];
        this.columnTipi = this.Columns["Tipi"];
        this.columnRengi = this.Columns["Rengi"];
        this.columnBirim = this.Columns["Birim"];
        this.columnARACDURUMID = this.Columns["ARACDURUMID"];
        this.columnARACTIPIID = this.Columns["ARACTIPIID"];
        this.columnARACGRUBUID = this.Columns["ARACGRUBUID"];
        this.columnTRAFIKSGORTA2 = this.Columns["TRAFIKSGORTA2"];
        this.columnExpr2 = this.Columns["Expr2"];
        this.columnaracID = this.Columns["aracID"];
        this.columnkalanGun = this.Columns["kalanGun"];
        this.columnAciklama = this.Columns["Aciklama"];
        this.columnverildigiIlce = this.Columns["verildigiIlce"];
        this.columntahsisPlaka = this.Columns["tahsisPlaka"];
        this.columnticariAdi = this.Columns["ticariAdi"];
        this.columnmudurlık = this.Columns["mudurlık"];
        this.columnbelgoNo = this.Columns["belgoNo"];
        this.columnmotorNo = this.Columns["motorNo"];
        this.columnsaseNo = this.Columns["saseNo"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      private void InitClass()
      {
        this.columnPlaka = new DataColumn("Plaka", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnPlaka);
        this.columnMarka = new DataColumn("Marka", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMarka);
        this.columnModel = new DataColumn("Model", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnModel);
        this.columnCinsi = new DataColumn("Cinsi", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCinsi);
        this.columnTipi = new DataColumn("Tipi", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTipi);
        this.columnRengi = new DataColumn("Rengi", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRengi);
        this.columnBirim = new DataColumn("Birim", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBirim);
        this.columnARACDURUMID = new DataColumn("ARACDURUMID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnARACDURUMID);
        this.columnARACTIPIID = new DataColumn("ARACTIPIID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnARACTIPIID);
        this.columnARACGRUBUID = new DataColumn("ARACGRUBUID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnARACGRUBUID);
        this.columnTRAFIKSGORTA2 = new DataColumn("TRAFIKSGORTA2", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTRAFIKSGORTA2);
        this.columnExpr2 = new DataColumn("Expr2", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnExpr2);
        this.columnaracID = new DataColumn("aracID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnaracID);
        this.columnkalanGun = new DataColumn("kalanGun", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnkalanGun);
        this.columnAciklama = new DataColumn("Aciklama", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnAciklama);
        this.columnverildigiIlce = new DataColumn("verildigiIlce", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnverildigiIlce);
        this.columntahsisPlaka = new DataColumn("tahsisPlaka", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columntahsisPlaka);
        this.columnticariAdi = new DataColumn("ticariAdi", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnticariAdi);
        this.columnmudurlık = new DataColumn("mudurlık", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnmudurlık);
        this.columnbelgoNo = new DataColumn("belgoNo", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnbelgoNo);
        this.columnmotorNo = new DataColumn("motorNo", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnmotorNo);
        this.columnsaseNo = new DataColumn("saseNo", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnsaseNo);
        this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
        {
          this.columnaracID
        }, true));
        this.columnPlaka.MaxLength = 50;
        this.columnModel.MaxLength = 50;
        this.columnCinsi.MaxLength = 50;
        this.columnTipi.MaxLength = 50;
        this.columnRengi.MaxLength = 50;
        this.columnaracID.AutoIncrement = true;
        this.columnaracID.AutoIncrementSeed = -1L;
        this.columnaracID.AutoIncrementStep = -1L;
        this.columnaracID.AllowDBNull = false;
        this.columnaracID.ReadOnly = true;
        this.columnaracID.Unique = true;
        this.columnkalanGun.ReadOnly = true;
        this.columnAciklama.MaxLength = 200;
        this.columnverildigiIlce.MaxLength = 50;
        this.columntahsisPlaka.MaxLength = 50;
        this.columnticariAdi.MaxLength = 50;
        this.columnbelgoNo.MaxLength = 50;
        this.columnmotorNo.MaxLength = 50;
        this.columnsaseNo.MaxLength = 50;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AracSigortaKontrol.TBLARACLARRow NewTBLARACLARRow() => (AracSigortaKontrol.TBLARACLARRow) this.NewRow();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new AracSigortaKontrol.TBLARACLARRow(builder);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override Type GetRowType() => typeof (AracSigortaKontrol.TBLARACLARRow);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.TBLARACLARRowChanged == null)
          return;
        this.TBLARACLARRowChanged((object) this, new AracSigortaKontrol.TBLARACLARRowChangeEvent((AracSigortaKontrol.TBLARACLARRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.TBLARACLARRowChanging == null)
          return;
        this.TBLARACLARRowChanging((object) this, new AracSigortaKontrol.TBLARACLARRowChangeEvent((AracSigortaKontrol.TBLARACLARRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.TBLARACLARRowDeleted == null)
          return;
        this.TBLARACLARRowDeleted((object) this, new AracSigortaKontrol.TBLARACLARRowChangeEvent((AracSigortaKontrol.TBLARACLARRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.TBLARACLARRowDeleting == null)
          return;
        this.TBLARACLARRowDeleting((object) this, new AracSigortaKontrol.TBLARACLARRowChangeEvent((AracSigortaKontrol.TBLARACLARRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void RemoveTBLARACLARRow(AracSigortaKontrol.TBLARACLARRow row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        AracSigortaKontrol aracSigortaKontrol = new AracSigortaKontrol();
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
          FixedValue = aracSigortaKontrol.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (TBLARACLARDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = aracSigortaKontrol.GetSchemaSerializable();
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

    public class TBLARACLARRow : DataRow
    {
      private AracSigortaKontrol.TBLARACLARDataTable tableTBLARACLAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal TBLARACLARRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableTBLARACLAR = (AracSigortaKontrol.TBLARACLARDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string Plaka
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLARACLAR.PlakaColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLARACLAR' tablosundaki 'Plaka' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLARACLAR.PlakaColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int Marka
      {
        get
        {
          try
          {
            return (int) this[this.tableTBLARACLAR.MarkaColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLARACLAR' tablosundaki 'Marka' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLARACLAR.MarkaColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string Model
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLARACLAR.ModelColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLARACLAR' tablosundaki 'Model' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLARACLAR.ModelColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string Cinsi
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLARACLAR.CinsiColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLARACLAR' tablosundaki 'Cinsi' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLARACLAR.CinsiColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string Tipi
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLARACLAR.TipiColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLARACLAR' tablosundaki 'Tipi' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLARACLAR.TipiColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string Rengi
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLARACLAR.RengiColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLARACLAR' tablosundaki 'Rengi' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLARACLAR.RengiColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int Birim
      {
        get
        {
          try
          {
            return (int) this[this.tableTBLARACLAR.BirimColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLARACLAR' tablosundaki 'Birim' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLARACLAR.BirimColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ARACDURUMID
      {
        get
        {
          try
          {
            return (int) this[this.tableTBLARACLAR.ARACDURUMIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLARACLAR' tablosundaki 'ARACDURUMID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLARACLAR.ARACDURUMIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ARACTIPIID
      {
        get
        {
          try
          {
            return (int) this[this.tableTBLARACLAR.ARACTIPIIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLARACLAR' tablosundaki 'ARACTIPIID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLARACLAR.ARACTIPIIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ARACGRUBUID
      {
        get
        {
          try
          {
            return (int) this[this.tableTBLARACLAR.ARACGRUBUIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLARACLAR' tablosundaki 'ARACGRUBUID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLARACLAR.ARACGRUBUIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DateTime TRAFIKSGORTA2
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableTBLARACLAR.TRAFIKSGORTA2Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLARACLAR' tablosundaki 'TRAFIKSGORTA2' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLARACLAR.TRAFIKSGORTA2Column] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DateTime Expr2
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableTBLARACLAR.Expr2Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLARACLAR' tablosundaki 'Expr2' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLARACLAR.Expr2Column] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int aracID
      {
        get => (int) this[this.tableTBLARACLAR.aracIDColumn];
        set => this[this.tableTBLARACLAR.aracIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int kalanGun
      {
        get
        {
          try
          {
            return (int) this[this.tableTBLARACLAR.kalanGunColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLARACLAR' tablosundaki 'kalanGun' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLARACLAR.kalanGunColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string Aciklama
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLARACLAR.AciklamaColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLARACLAR' tablosundaki 'Aciklama' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLARACLAR.AciklamaColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string verildigiIlce
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLARACLAR.verildigiIlceColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLARACLAR' tablosundaki 'verildigiIlce' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLARACLAR.verildigiIlceColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string tahsisPlaka
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLARACLAR.tahsisPlakaColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLARACLAR' tablosundaki 'tahsisPlaka' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLARACLAR.tahsisPlakaColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string ticariAdi
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLARACLAR.ticariAdiColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLARACLAR' tablosundaki 'ticariAdi' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLARACLAR.ticariAdiColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int mudurlık
      {
        get
        {
          try
          {
            return (int) this[this.tableTBLARACLAR.mudurlıkColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLARACLAR' tablosundaki 'mudurlık' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLARACLAR.mudurlıkColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string belgoNo
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLARACLAR.belgoNoColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLARACLAR' tablosundaki 'belgoNo' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLARACLAR.belgoNoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string motorNo
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLARACLAR.motorNoColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLARACLAR' tablosundaki 'motorNo' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLARACLAR.motorNoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string saseNo
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLARACLAR.saseNoColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLARACLAR' tablosundaki 'saseNo' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLARACLAR.saseNoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsPlakaNull() => this.IsNull(this.tableTBLARACLAR.PlakaColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetPlakaNull() => this[this.tableTBLARACLAR.PlakaColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMarkaNull() => this.IsNull(this.tableTBLARACLAR.MarkaColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMarkaNull() => this[this.tableTBLARACLAR.MarkaColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsModelNull() => this.IsNull(this.tableTBLARACLAR.ModelColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetModelNull() => this[this.tableTBLARACLAR.ModelColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsCinsiNull() => this.IsNull(this.tableTBLARACLAR.CinsiColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetCinsiNull() => this[this.tableTBLARACLAR.CinsiColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsTipiNull() => this.IsNull(this.tableTBLARACLAR.TipiColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetTipiNull() => this[this.tableTBLARACLAR.TipiColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsRengiNull() => this.IsNull(this.tableTBLARACLAR.RengiColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetRengiNull() => this[this.tableTBLARACLAR.RengiColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBirimNull() => this.IsNull(this.tableTBLARACLAR.BirimColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBirimNull() => this[this.tableTBLARACLAR.BirimColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsARACDURUMIDNull() => this.IsNull(this.tableTBLARACLAR.ARACDURUMIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetARACDURUMIDNull() => this[this.tableTBLARACLAR.ARACDURUMIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsARACTIPIIDNull() => this.IsNull(this.tableTBLARACLAR.ARACTIPIIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetARACTIPIIDNull() => this[this.tableTBLARACLAR.ARACTIPIIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsARACGRUBUIDNull() => this.IsNull(this.tableTBLARACLAR.ARACGRUBUIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetARACGRUBUIDNull() => this[this.tableTBLARACLAR.ARACGRUBUIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsTRAFIKSGORTA2Null() => this.IsNull(this.tableTBLARACLAR.TRAFIKSGORTA2Column);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetTRAFIKSGORTA2Null() => this[this.tableTBLARACLAR.TRAFIKSGORTA2Column] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsExpr2Null() => this.IsNull(this.tableTBLARACLAR.Expr2Column);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetExpr2Null() => this[this.tableTBLARACLAR.Expr2Column] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IskalanGunNull() => this.IsNull(this.tableTBLARACLAR.kalanGunColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetkalanGunNull() => this[this.tableTBLARACLAR.kalanGunColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsAciklamaNull() => this.IsNull(this.tableTBLARACLAR.AciklamaColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetAciklamaNull() => this[this.tableTBLARACLAR.AciklamaColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsverildigiIlceNull() => this.IsNull(this.tableTBLARACLAR.verildigiIlceColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetverildigiIlceNull() => this[this.tableTBLARACLAR.verildigiIlceColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IstahsisPlakaNull() => this.IsNull(this.tableTBLARACLAR.tahsisPlakaColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SettahsisPlakaNull() => this[this.tableTBLARACLAR.tahsisPlakaColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsticariAdiNull() => this.IsNull(this.tableTBLARACLAR.ticariAdiColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetticariAdiNull() => this[this.tableTBLARACLAR.ticariAdiColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsmudurlıkNull() => this.IsNull(this.tableTBLARACLAR.mudurlıkColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetmudurlıkNull() => this[this.tableTBLARACLAR.mudurlıkColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsbelgoNoNull() => this.IsNull(this.tableTBLARACLAR.belgoNoColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetbelgoNoNull() => this[this.tableTBLARACLAR.belgoNoColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsmotorNoNull() => this.IsNull(this.tableTBLARACLAR.motorNoColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetmotorNoNull() => this[this.tableTBLARACLAR.motorNoColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IssaseNoNull() => this.IsNull(this.tableTBLARACLAR.saseNoColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetsaseNoNull() => this[this.tableTBLARACLAR.saseNoColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public class TBLARACLARRowChangeEvent : EventArgs
    {
      private AracSigortaKontrol.TBLARACLARRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public TBLARACLARRowChangeEvent(AracSigortaKontrol.TBLARACLARRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AracSigortaKontrol.TBLARACLARRow Row => this.eventRow;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataRowAction Action => this.eventAction;
    }
  }
}
