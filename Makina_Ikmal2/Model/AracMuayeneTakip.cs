// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Model.AracMuayeneTakip
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
  [XmlRoot("AracMuayeneTakip")]
  [HelpKeyword("vs.data.DataSet")]
  [Serializable]
  public class AracMuayeneTakip : DataSet
  {
    private AracMuayeneTakip.TBLARACLARDataTable tableTBLARACLAR;
    private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public AracMuayeneTakip()
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
    protected AracMuayeneTakip(SerializationInfo info, StreamingContext context)
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
            base.Tables.Add((DataTable) new AracMuayeneTakip.TBLARACLARDataTable(dataSet.Tables[nameof (TBLARACLAR)]));
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
    public AracMuayeneTakip.TBLARACLARDataTable TBLARACLAR => this.tableTBLARACLAR;

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
      AracMuayeneTakip aracMuayeneTakip = (AracMuayeneTakip) base.Clone();
      aracMuayeneTakip.InitVars();
      aracMuayeneTakip.SchemaSerializationMode = this.SchemaSerializationMode;
      return (DataSet) aracMuayeneTakip;
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
          base.Tables.Add((DataTable) new AracMuayeneTakip.TBLARACLARDataTable(dataSet.Tables["TBLARACLAR"]));
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
      this.tableTBLARACLAR = (AracMuayeneTakip.TBLARACLARDataTable) base.Tables["TBLARACLAR"];
      if (!initTable || this.tableTBLARACLAR == null)
        return;
      this.tableTBLARACLAR.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.DataSetName = nameof (AracMuayeneTakip);
      this.Prefix = "";
      this.Namespace = "http://tempuri.org/AracMuayeneTakip.xsd";
      this.EnforceConstraints = true;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tableTBLARACLAR = new AracMuayeneTakip.TBLARACLARDataTable();
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
      AracMuayeneTakip aracMuayeneTakip = new AracMuayeneTakip();
      XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
      {
        Namespace = aracMuayeneTakip.Namespace
      });
      typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = aracMuayeneTakip.GetSchemaSerializable();
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
      AracMuayeneTakip.TBLARACLARRowChangeEvent e);

    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class TBLARACLARDataTable : TypedTableBase<AracMuayeneTakip.TBLARACLARRow>
    {
      private DataColumn columnExpr1;
      private DataColumn columnMuayene_Tarihi;
      private DataColumn columnPlaka;
      private DataColumn columnAçıklama;
      private DataColumn columnTahsis_Plaka;
      private DataColumn columnMarka;
      private DataColumn columnModel;
      private DataColumn columnRengi;
      private DataColumn columnBirim;
      private DataColumn columnMüdürlük;
      private DataColumn columnMuayene_Tarihi1;
      private DataColumn columnARACDURUMID;
      private DataColumn columnARACTIPIID;
      private DataColumn columnKalan_Gun;
      private DataColumn columnARACGRUBUID;
      private DataColumn columnEgzoz_Tarihi;
      private DataColumn columnEgzoz_Kalan_Gun;
      private DataColumn columnID;

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
      public DataColumn Expr1Column => this.columnExpr1;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn Muayene_TarihiColumn => this.columnMuayene_Tarihi;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn PlakaColumn => this.columnPlaka;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn AçıklamaColumn => this.columnAçıklama;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn Tahsis_PlakaColumn => this.columnTahsis_Plaka;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MarkaColumn => this.columnMarka;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ModelColumn => this.columnModel;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn RengiColumn => this.columnRengi;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BirimColumn => this.columnBirim;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MüdürlükColumn => this.columnMüdürlük;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn Muayene_Tarihi1Column => this.columnMuayene_Tarihi1;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ARACDURUMIDColumn => this.columnARACDURUMID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ARACTIPIIDColumn => this.columnARACTIPIID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn Kalan_GunColumn => this.columnKalan_Gun;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ARACGRUBUIDColumn => this.columnARACGRUBUID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn Egzoz_TarihiColumn => this.columnEgzoz_Tarihi;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn Egzoz_Kalan_GunColumn => this.columnEgzoz_Kalan_Gun;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn IDColumn => this.columnID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AracMuayeneTakip.TBLARACLARRow this[int index] => (AracMuayeneTakip.TBLARACLARRow) this.Rows[index];

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event AracMuayeneTakip.TBLARACLARRowChangeEventHandler TBLARACLARRowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event AracMuayeneTakip.TBLARACLARRowChangeEventHandler TBLARACLARRowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event AracMuayeneTakip.TBLARACLARRowChangeEventHandler TBLARACLARRowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event AracMuayeneTakip.TBLARACLARRowChangeEventHandler TBLARACLARRowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void AddTBLARACLARRow(AracMuayeneTakip.TBLARACLARRow row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AracMuayeneTakip.TBLARACLARRow AddTBLARACLARRow(
        DateTime Expr1,
        string Muayene_Tarihi,
        string Plaka,
        string Açıklama,
        string Tahsis_Plaka,
        int Marka,
        string Model,
        string Rengi,
        int Birim,
        int Müdürlük,
        DateTime Muayene_Tarihi1,
        int ARACDURUMID,
        int ARACTIPIID,
        int Kalan_Gun,
        int ARACGRUBUID,
        DateTime Egzoz_Tarihi,
        int Egzoz_Kalan_Gun)
      {
        AracMuayeneTakip.TBLARACLARRow row = (AracMuayeneTakip.TBLARACLARRow) this.NewRow();
        object[] objArray = new object[18]
        {
          (object) Expr1,
          (object) Muayene_Tarihi,
          (object) Plaka,
          (object) Açıklama,
          (object) Tahsis_Plaka,
          (object) Marka,
          (object) Model,
          (object) Rengi,
          (object) Birim,
          (object) Müdürlük,
          (object) Muayene_Tarihi1,
          (object) ARACDURUMID,
          (object) ARACTIPIID,
          (object) Kalan_Gun,
          (object) ARACGRUBUID,
          (object) Egzoz_Tarihi,
          (object) Egzoz_Kalan_Gun,
          null
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AracMuayeneTakip.TBLARACLARRow FindByID(int ID) => (AracMuayeneTakip.TBLARACLARRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public override DataTable Clone()
      {
        AracMuayeneTakip.TBLARACLARDataTable tblaraclarDataTable = (AracMuayeneTakip.TBLARACLARDataTable) base.Clone();
        tblaraclarDataTable.InitVars();
        return (DataTable) tblaraclarDataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataTable CreateInstance() => (DataTable) new AracMuayeneTakip.TBLARACLARDataTable();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal void InitVars()
      {
        this.columnExpr1 = this.Columns["Expr1"];
        this.columnMuayene_Tarihi = this.Columns["Muayene Tarihi"];
        this.columnPlaka = this.Columns["Plaka"];
        this.columnAçıklama = this.Columns["Açıklama"];
        this.columnTahsis_Plaka = this.Columns["Tahsis Plaka"];
        this.columnMarka = this.Columns["Marka"];
        this.columnModel = this.Columns["Model"];
        this.columnRengi = this.Columns["Rengi"];
        this.columnBirim = this.Columns["Birim"];
        this.columnMüdürlük = this.Columns["Müdürlük"];
        this.columnMuayene_Tarihi1 = this.Columns["Muayene Tarihi1"];
        this.columnARACDURUMID = this.Columns["ARACDURUMID"];
        this.columnARACTIPIID = this.Columns["ARACTIPIID"];
        this.columnKalan_Gun = this.Columns["Kalan Gun"];
        this.columnARACGRUBUID = this.Columns["ARACGRUBUID"];
        this.columnEgzoz_Tarihi = this.Columns["Egzoz Tarihi"];
        this.columnEgzoz_Kalan_Gun = this.Columns["Egzoz Kalan Gun"];
        this.columnID = this.Columns["ID"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      private void InitClass()
      {
        this.columnExpr1 = new DataColumn("Expr1", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnExpr1);
        this.columnMuayene_Tarihi = new DataColumn("Muayene Tarihi", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMuayene_Tarihi);
        this.columnPlaka = new DataColumn("Plaka", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnPlaka);
        this.columnAçıklama = new DataColumn("Açıklama", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnAçıklama);
        this.columnTahsis_Plaka = new DataColumn("Tahsis Plaka", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTahsis_Plaka);
        this.columnMarka = new DataColumn("Marka", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMarka);
        this.columnModel = new DataColumn("Model", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnModel);
        this.columnRengi = new DataColumn("Rengi", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRengi);
        this.columnBirim = new DataColumn("Birim", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBirim);
        this.columnMüdürlük = new DataColumn("Müdürlük", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMüdürlük);
        this.columnMuayene_Tarihi1 = new DataColumn("Muayene Tarihi1", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMuayene_Tarihi1);
        this.columnARACDURUMID = new DataColumn("ARACDURUMID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnARACDURUMID);
        this.columnARACTIPIID = new DataColumn("ARACTIPIID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnARACTIPIID);
        this.columnKalan_Gun = new DataColumn("Kalan Gun", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnKalan_Gun);
        this.columnARACGRUBUID = new DataColumn("ARACGRUBUID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnARACGRUBUID);
        this.columnEgzoz_Tarihi = new DataColumn("Egzoz Tarihi", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnEgzoz_Tarihi);
        this.columnEgzoz_Kalan_Gun = new DataColumn("Egzoz Kalan Gun", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnEgzoz_Kalan_Gun);
        this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnID);
        this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
        {
          this.columnID
        }, true));
        this.columnExpr1.ReadOnly = true;
        this.columnMuayene_Tarihi.MaxLength = 50;
        this.columnPlaka.MaxLength = 50;
        this.columnAçıklama.MaxLength = 150;
        this.columnTahsis_Plaka.MaxLength = 50;
        this.columnModel.MaxLength = 50;
        this.columnRengi.MaxLength = 50;
        this.columnMuayene_Tarihi1.Caption = "Muayene Tarihi";
        this.columnKalan_Gun.ReadOnly = true;
        this.columnEgzoz_Kalan_Gun.ReadOnly = true;
        this.columnID.AutoIncrement = true;
        this.columnID.AutoIncrementSeed = -1L;
        this.columnID.AutoIncrementStep = -1L;
        this.columnID.AllowDBNull = false;
        this.columnID.ReadOnly = true;
        this.columnID.Unique = true;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AracMuayeneTakip.TBLARACLARRow NewTBLARACLARRow() => (AracMuayeneTakip.TBLARACLARRow) this.NewRow();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new AracMuayeneTakip.TBLARACLARRow(builder);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override Type GetRowType() => typeof (AracMuayeneTakip.TBLARACLARRow);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.TBLARACLARRowChanged == null)
          return;
        this.TBLARACLARRowChanged((object) this, new AracMuayeneTakip.TBLARACLARRowChangeEvent((AracMuayeneTakip.TBLARACLARRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.TBLARACLARRowChanging == null)
          return;
        this.TBLARACLARRowChanging((object) this, new AracMuayeneTakip.TBLARACLARRowChangeEvent((AracMuayeneTakip.TBLARACLARRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.TBLARACLARRowDeleted == null)
          return;
        this.TBLARACLARRowDeleted((object) this, new AracMuayeneTakip.TBLARACLARRowChangeEvent((AracMuayeneTakip.TBLARACLARRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.TBLARACLARRowDeleting == null)
          return;
        this.TBLARACLARRowDeleting((object) this, new AracMuayeneTakip.TBLARACLARRowChangeEvent((AracMuayeneTakip.TBLARACLARRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void RemoveTBLARACLARRow(AracMuayeneTakip.TBLARACLARRow row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        AracMuayeneTakip aracMuayeneTakip = new AracMuayeneTakip();
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
          FixedValue = aracMuayeneTakip.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (TBLARACLARDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = aracMuayeneTakip.GetSchemaSerializable();
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
      private AracMuayeneTakip.TBLARACLARDataTable tableTBLARACLAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal TBLARACLARRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableTBLARACLAR = (AracMuayeneTakip.TBLARACLARDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DateTime Expr1
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableTBLARACLAR.Expr1Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLARACLAR' tablosundaki 'Expr1' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLARACLAR.Expr1Column] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string Muayene_Tarihi
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLARACLAR.Muayene_TarihiColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLARACLAR' tablosundaki 'Muayene Tarihi' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLARACLAR.Muayene_TarihiColumn] = (object) value;
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
      public string Açıklama
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLARACLAR.AçıklamaColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLARACLAR' tablosundaki 'Açıklama' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLARACLAR.AçıklamaColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string Tahsis_Plaka
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLARACLAR.Tahsis_PlakaColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLARACLAR' tablosundaki 'Tahsis Plaka' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLARACLAR.Tahsis_PlakaColumn] = (object) value;
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
      public int Müdürlük
      {
        get
        {
          try
          {
            return (int) this[this.tableTBLARACLAR.MüdürlükColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLARACLAR' tablosundaki 'Müdürlük' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLARACLAR.MüdürlükColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DateTime Muayene_Tarihi1
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableTBLARACLAR.Muayene_Tarihi1Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLARACLAR' tablosundaki 'Muayene Tarihi1' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLARACLAR.Muayene_Tarihi1Column] = (object) value;
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
      public int Kalan_Gun
      {
        get
        {
          try
          {
            return (int) this[this.tableTBLARACLAR.Kalan_GunColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLARACLAR' tablosundaki 'Kalan Gun' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLARACLAR.Kalan_GunColumn] = (object) value;
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
      public DateTime Egzoz_Tarihi
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableTBLARACLAR.Egzoz_TarihiColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLARACLAR' tablosundaki 'Egzoz Tarihi' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLARACLAR.Egzoz_TarihiColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int Egzoz_Kalan_Gun
      {
        get
        {
          try
          {
            return (int) this[this.tableTBLARACLAR.Egzoz_Kalan_GunColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLARACLAR' tablosundaki 'Egzoz Kalan Gun' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLARACLAR.Egzoz_Kalan_GunColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ID
      {
        get => (int) this[this.tableTBLARACLAR.IDColumn];
        set => this[this.tableTBLARACLAR.IDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsExpr1Null() => this.IsNull(this.tableTBLARACLAR.Expr1Column);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetExpr1Null() => this[this.tableTBLARACLAR.Expr1Column] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMuayene_TarihiNull() => this.IsNull(this.tableTBLARACLAR.Muayene_TarihiColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMuayene_TarihiNull() => this[this.tableTBLARACLAR.Muayene_TarihiColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsPlakaNull() => this.IsNull(this.tableTBLARACLAR.PlakaColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetPlakaNull() => this[this.tableTBLARACLAR.PlakaColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsAçıklamaNull() => this.IsNull(this.tableTBLARACLAR.AçıklamaColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetAçıklamaNull() => this[this.tableTBLARACLAR.AçıklamaColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsTahsis_PlakaNull() => this.IsNull(this.tableTBLARACLAR.Tahsis_PlakaColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetTahsis_PlakaNull() => this[this.tableTBLARACLAR.Tahsis_PlakaColumn] = Convert.DBNull;

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
      public bool IsMüdürlükNull() => this.IsNull(this.tableTBLARACLAR.MüdürlükColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMüdürlükNull() => this[this.tableTBLARACLAR.MüdürlükColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMuayene_Tarihi1Null() => this.IsNull(this.tableTBLARACLAR.Muayene_Tarihi1Column);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMuayene_Tarihi1Null() => this[this.tableTBLARACLAR.Muayene_Tarihi1Column] = Convert.DBNull;

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
      public bool IsKalan_GunNull() => this.IsNull(this.tableTBLARACLAR.Kalan_GunColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetKalan_GunNull() => this[this.tableTBLARACLAR.Kalan_GunColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsARACGRUBUIDNull() => this.IsNull(this.tableTBLARACLAR.ARACGRUBUIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetARACGRUBUIDNull() => this[this.tableTBLARACLAR.ARACGRUBUIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsEgzoz_TarihiNull() => this.IsNull(this.tableTBLARACLAR.Egzoz_TarihiColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetEgzoz_TarihiNull() => this[this.tableTBLARACLAR.Egzoz_TarihiColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsEgzoz_Kalan_GunNull() => this.IsNull(this.tableTBLARACLAR.Egzoz_Kalan_GunColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetEgzoz_Kalan_GunNull() => this[this.tableTBLARACLAR.Egzoz_Kalan_GunColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public class TBLARACLARRowChangeEvent : EventArgs
    {
      private AracMuayeneTakip.TBLARACLARRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public TBLARACLARRowChangeEvent(AracMuayeneTakip.TBLARACLARRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AracMuayeneTakip.TBLARACLARRow Row => this.eventRow;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataRowAction Action => this.eventAction;
    }
  }
}
