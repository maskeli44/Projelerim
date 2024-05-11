// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Model.AracKarnesiListe
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
  [XmlRoot("AracKarnesiListe")]
  [HelpKeyword("vs.data.DataSet")]
  [Serializable]
  public class AracKarnesiListe : DataSet
  {
    private AracKarnesiListe.TBLARACLARDataTable tableTBLARACLAR;
    private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public AracKarnesiListe()
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
    protected AracKarnesiListe(SerializationInfo info, StreamingContext context)
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
            base.Tables.Add((DataTable) new AracKarnesiListe.TBLARACLARDataTable(dataSet.Tables[nameof (TBLARACLAR)]));
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
    public AracKarnesiListe.TBLARACLARDataTable TBLARACLAR => this.tableTBLARACLAR;

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
      AracKarnesiListe aracKarnesiListe = (AracKarnesiListe) base.Clone();
      aracKarnesiListe.InitVars();
      aracKarnesiListe.SchemaSerializationMode = this.SchemaSerializationMode;
      return (DataSet) aracKarnesiListe;
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
          base.Tables.Add((DataTable) new AracKarnesiListe.TBLARACLARDataTable(dataSet.Tables["TBLARACLAR"]));
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
      this.tableTBLARACLAR = (AracKarnesiListe.TBLARACLARDataTable) base.Tables["TBLARACLAR"];
      if (!initTable || this.tableTBLARACLAR == null)
        return;
      this.tableTBLARACLAR.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.DataSetName = nameof (AracKarnesiListe);
      this.Prefix = "";
      this.Namespace = "http://tempuri.org/AracKarnesiListe.xsd";
      this.EnforceConstraints = true;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tableTBLARACLAR = new AracKarnesiListe.TBLARACLARDataTable();
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
      AracKarnesiListe aracKarnesiListe = new AracKarnesiListe();
      XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
      {
        Namespace = aracKarnesiListe.Namespace
      });
      typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = aracKarnesiListe.GetSchemaSerializable();
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
      AracKarnesiListe.TBLARACLARRowChangeEvent e);

    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class TBLARACLARDataTable : TypedTableBase<AracKarnesiListe.TBLARACLARRow>
    {
      private DataColumn columnBirim_Adı;
      private DataColumn columnPLAKA;
      private DataColumn columnARACACIKLAMA;
      private DataColumn columnAna_Grup;
      private DataColumn columnAlt_Grup;
      private DataColumn columnB__Sayısı;
      private DataColumn columnID;
      private DataColumn columnRESIMON;
      private DataColumn columnRESİMARKA;

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
      public DataColumn Birim_AdıColumn => this.columnBirim_Adı;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn PLAKAColumn => this.columnPLAKA;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ARACACIKLAMAColumn => this.columnARACACIKLAMA;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn Ana_GrupColumn => this.columnAna_Grup;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn Alt_GrupColumn => this.columnAlt_Grup;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn B__SayısıColumn => this.columnB__Sayısı;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn IDColumn => this.columnID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn RESIMONColumn => this.columnRESIMON;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn RESİMARKAColumn => this.columnRESİMARKA;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AracKarnesiListe.TBLARACLARRow this[int index] => (AracKarnesiListe.TBLARACLARRow) this.Rows[index];

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event AracKarnesiListe.TBLARACLARRowChangeEventHandler TBLARACLARRowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event AracKarnesiListe.TBLARACLARRowChangeEventHandler TBLARACLARRowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event AracKarnesiListe.TBLARACLARRowChangeEventHandler TBLARACLARRowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event AracKarnesiListe.TBLARACLARRowChangeEventHandler TBLARACLARRowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void AddTBLARACLARRow(AracKarnesiListe.TBLARACLARRow row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AracKarnesiListe.TBLARACLARRow AddTBLARACLARRow(
        int Birim_Adı,
        string PLAKA,
        string ARACACIKLAMA,
        int Ana_Grup,
        int Alt_Grup,
        string B__Sayısı,
        byte[] RESIMON,
        byte[] RESİMARKA)
      {
        AracKarnesiListe.TBLARACLARRow row = (AracKarnesiListe.TBLARACLARRow) this.NewRow();
        object[] objArray = new object[9]
        {
          (object) Birim_Adı,
          (object) PLAKA,
          (object) ARACACIKLAMA,
          (object) Ana_Grup,
          (object) Alt_Grup,
          (object) B__Sayısı,
          null,
          (object) RESIMON,
          (object) RESİMARKA
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AracKarnesiListe.TBLARACLARRow FindByID(int ID) => (AracKarnesiListe.TBLARACLARRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public override DataTable Clone()
      {
        AracKarnesiListe.TBLARACLARDataTable tblaraclarDataTable = (AracKarnesiListe.TBLARACLARDataTable) base.Clone();
        tblaraclarDataTable.InitVars();
        return (DataTable) tblaraclarDataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataTable CreateInstance() => (DataTable) new AracKarnesiListe.TBLARACLARDataTable();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal void InitVars()
      {
        this.columnBirim_Adı = this.Columns["Birim Adı"];
        this.columnPLAKA = this.Columns["PLAKA"];
        this.columnARACACIKLAMA = this.Columns["ARACACIKLAMA"];
        this.columnAna_Grup = this.Columns["Ana Grup"];
        this.columnAlt_Grup = this.Columns["Alt Grup"];
        this.columnB__Sayısı = this.Columns["B_ Sayısı"];
        this.columnID = this.Columns["ID"];
        this.columnRESIMON = this.Columns["RESIMON"];
        this.columnRESİMARKA = this.Columns["RESİMARKA"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      private void InitClass()
      {
        this.columnBirim_Adı = new DataColumn("Birim Adı", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBirim_Adı);
        this.columnPLAKA = new DataColumn("PLAKA", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnPLAKA);
        this.columnARACACIKLAMA = new DataColumn("ARACACIKLAMA", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnARACACIKLAMA);
        this.columnAna_Grup = new DataColumn("Ana Grup", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnAna_Grup);
        this.columnAlt_Grup = new DataColumn("Alt Grup", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnAlt_Grup);
        this.columnB__Sayısı = new DataColumn("B_ Sayısı", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnB__Sayısı);
        this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnID);
        this.columnRESIMON = new DataColumn("RESIMON", typeof (byte[]), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRESIMON);
        this.columnRESİMARKA = new DataColumn("RESİMARKA", typeof (byte[]), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRESİMARKA);
        this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
        {
          this.columnID
        }, true));
        this.columnPLAKA.MaxLength = 50;
        this.columnARACACIKLAMA.MaxLength = 150;
        this.columnB__Sayısı.Caption = "B. Sayısı";
        this.columnB__Sayısı.MaxLength = 20;
        this.columnID.AutoIncrement = true;
        this.columnID.AutoIncrementSeed = -1L;
        this.columnID.AutoIncrementStep = -1L;
        this.columnID.AllowDBNull = false;
        this.columnID.ReadOnly = true;
        this.columnID.Unique = true;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AracKarnesiListe.TBLARACLARRow NewTBLARACLARRow() => (AracKarnesiListe.TBLARACLARRow) this.NewRow();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new AracKarnesiListe.TBLARACLARRow(builder);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override Type GetRowType() => typeof (AracKarnesiListe.TBLARACLARRow);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.TBLARACLARRowChanged == null)
          return;
        this.TBLARACLARRowChanged((object) this, new AracKarnesiListe.TBLARACLARRowChangeEvent((AracKarnesiListe.TBLARACLARRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.TBLARACLARRowChanging == null)
          return;
        this.TBLARACLARRowChanging((object) this, new AracKarnesiListe.TBLARACLARRowChangeEvent((AracKarnesiListe.TBLARACLARRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.TBLARACLARRowDeleted == null)
          return;
        this.TBLARACLARRowDeleted((object) this, new AracKarnesiListe.TBLARACLARRowChangeEvent((AracKarnesiListe.TBLARACLARRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.TBLARACLARRowDeleting == null)
          return;
        this.TBLARACLARRowDeleting((object) this, new AracKarnesiListe.TBLARACLARRowChangeEvent((AracKarnesiListe.TBLARACLARRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void RemoveTBLARACLARRow(AracKarnesiListe.TBLARACLARRow row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        AracKarnesiListe aracKarnesiListe = new AracKarnesiListe();
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
          FixedValue = aracKarnesiListe.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (TBLARACLARDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = aracKarnesiListe.GetSchemaSerializable();
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
      private AracKarnesiListe.TBLARACLARDataTable tableTBLARACLAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal TBLARACLARRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableTBLARACLAR = (AracKarnesiListe.TBLARACLARDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int Birim_Adı
      {
        get
        {
          try
          {
            return (int) this[this.tableTBLARACLAR.Birim_AdıColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLARACLAR' tablosundaki 'Birim Adı' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLARACLAR.Birim_AdıColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string PLAKA
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLARACLAR.PLAKAColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLARACLAR' tablosundaki 'PLAKA' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLARACLAR.PLAKAColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string ARACACIKLAMA
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLARACLAR.ARACACIKLAMAColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLARACLAR' tablosundaki 'ARACACIKLAMA' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLARACLAR.ARACACIKLAMAColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int Ana_Grup
      {
        get
        {
          try
          {
            return (int) this[this.tableTBLARACLAR.Ana_GrupColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLARACLAR' tablosundaki 'Ana Grup' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLARACLAR.Ana_GrupColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int Alt_Grup
      {
        get
        {
          try
          {
            return (int) this[this.tableTBLARACLAR.Alt_GrupColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLARACLAR' tablosundaki 'Alt Grup' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLARACLAR.Alt_GrupColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string B__Sayısı
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLARACLAR.B__SayısıColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLARACLAR' tablosundaki 'B_ Sayısı' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLARACLAR.B__SayısıColumn] = (object) value;
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
      public byte[] RESIMON
      {
        get
        {
          try
          {
            return (byte[]) this[this.tableTBLARACLAR.RESIMONColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLARACLAR' tablosundaki 'RESIMON' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLARACLAR.RESIMONColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public byte[] RESİMARKA
      {
        get
        {
          try
          {
            return (byte[]) this[this.tableTBLARACLAR.RESİMARKAColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLARACLAR' tablosundaki 'RESİMARKA' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLARACLAR.RESİMARKAColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBirim_AdıNull() => this.IsNull(this.tableTBLARACLAR.Birim_AdıColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBirim_AdıNull() => this[this.tableTBLARACLAR.Birim_AdıColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsPLAKANull() => this.IsNull(this.tableTBLARACLAR.PLAKAColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetPLAKANull() => this[this.tableTBLARACLAR.PLAKAColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsARACACIKLAMANull() => this.IsNull(this.tableTBLARACLAR.ARACACIKLAMAColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetARACACIKLAMANull() => this[this.tableTBLARACLAR.ARACACIKLAMAColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsAna_GrupNull() => this.IsNull(this.tableTBLARACLAR.Ana_GrupColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetAna_GrupNull() => this[this.tableTBLARACLAR.Ana_GrupColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsAlt_GrupNull() => this.IsNull(this.tableTBLARACLAR.Alt_GrupColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetAlt_GrupNull() => this[this.tableTBLARACLAR.Alt_GrupColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsB__SayısıNull() => this.IsNull(this.tableTBLARACLAR.B__SayısıColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetB__SayısıNull() => this[this.tableTBLARACLAR.B__SayısıColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsRESIMONNull() => this.IsNull(this.tableTBLARACLAR.RESIMONColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetRESIMONNull() => this[this.tableTBLARACLAR.RESIMONColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsRESİMARKANull() => this.IsNull(this.tableTBLARACLAR.RESİMARKAColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetRESİMARKANull() => this[this.tableTBLARACLAR.RESİMARKAColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public class TBLARACLARRowChangeEvent : EventArgs
    {
      private AracKarnesiListe.TBLARACLARRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public TBLARACLARRowChangeEvent(AracKarnesiListe.TBLARACLARRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AracKarnesiListe.TBLARACLARRow Row => this.eventRow;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataRowAction Action => this.eventAction;
    }
  }
}
