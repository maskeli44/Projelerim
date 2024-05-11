// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Model.teklifHrktCek
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
  [XmlRoot("teklifHrktCek")]
  [HelpKeyword("vs.data.DataSet")]
  [Serializable]
  public class teklifHrktCek : DataSet
  {
    private teklifHrktCek.TeklifHrktCekDataTable tableTeklifHrktCek;
    private teklifHrktCek.TeklifToplamlariDataTable tableTeklifToplamlari;
    private teklifHrktCek.AylaraGoreCekDataTable tableAylaraGoreCek;
    private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public teklifHrktCek()
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
    protected teklifHrktCek(SerializationInfo info, StreamingContext context)
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
          if (dataSet.Tables[nameof (TeklifHrktCek)] != null)
            base.Tables.Add((DataTable) new teklifHrktCek.TeklifHrktCekDataTable(dataSet.Tables[nameof (TeklifHrktCek)]));
          if (dataSet.Tables[nameof (TeklifToplamlari)] != null)
            base.Tables.Add((DataTable) new teklifHrktCek.TeklifToplamlariDataTable(dataSet.Tables[nameof (TeklifToplamlari)]));
          if (dataSet.Tables[nameof (AylaraGoreCek)] != null)
            base.Tables.Add((DataTable) new teklifHrktCek.AylaraGoreCekDataTable(dataSet.Tables[nameof (AylaraGoreCek)]));
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
    public teklifHrktCek.TeklifHrktCekDataTable TeklifHrktCek => this.tableTeklifHrktCek;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public teklifHrktCek.TeklifToplamlariDataTable TeklifToplamlari => this.tableTeklifToplamlari;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public teklifHrktCek.AylaraGoreCekDataTable AylaraGoreCek => this.tableAylaraGoreCek;

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
      teklifHrktCek teklifHrktCek = (teklifHrktCek) base.Clone();
      teklifHrktCek.InitVars();
      teklifHrktCek.SchemaSerializationMode = this.SchemaSerializationMode;
      return (DataSet) teklifHrktCek;
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
        if (dataSet.Tables["TeklifHrktCek"] != null)
          base.Tables.Add((DataTable) new teklifHrktCek.TeklifHrktCekDataTable(dataSet.Tables["TeklifHrktCek"]));
        if (dataSet.Tables["TeklifToplamlari"] != null)
          base.Tables.Add((DataTable) new teklifHrktCek.TeklifToplamlariDataTable(dataSet.Tables["TeklifToplamlari"]));
        if (dataSet.Tables["AylaraGoreCek"] != null)
          base.Tables.Add((DataTable) new teklifHrktCek.AylaraGoreCekDataTable(dataSet.Tables["AylaraGoreCek"]));
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
      this.tableTeklifHrktCek = (teklifHrktCek.TeklifHrktCekDataTable) base.Tables["TeklifHrktCek"];
      if (initTable && this.tableTeklifHrktCek != null)
        this.tableTeklifHrktCek.InitVars();
      this.tableTeklifToplamlari = (teklifHrktCek.TeklifToplamlariDataTable) base.Tables["TeklifToplamlari"];
      if (initTable && this.tableTeklifToplamlari != null)
        this.tableTeklifToplamlari.InitVars();
      this.tableAylaraGoreCek = (teklifHrktCek.AylaraGoreCekDataTable) base.Tables["AylaraGoreCek"];
      if (!initTable || this.tableAylaraGoreCek == null)
        return;
      this.tableAylaraGoreCek.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.DataSetName = nameof (teklifHrktCek);
      this.Prefix = "";
      this.Namespace = "http://tempuri.org/teklifHrktCek.xsd";
      this.EnforceConstraints = true;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tableTeklifHrktCek = new teklifHrktCek.TeklifHrktCekDataTable();
      base.Tables.Add((DataTable) this.tableTeklifHrktCek);
      this.tableTeklifToplamlari = new teklifHrktCek.TeklifToplamlariDataTable();
      base.Tables.Add((DataTable) this.tableTeklifToplamlari);
      this.tableAylaraGoreCek = new teklifHrktCek.AylaraGoreCekDataTable();
      base.Tables.Add((DataTable) this.tableAylaraGoreCek);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private bool ShouldSerializeTeklifHrktCek() => false;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private bool ShouldSerializeTeklifToplamlari() => false;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private bool ShouldSerializeAylaraGoreCek() => false;

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
      teklifHrktCek teklifHrktCek = new teklifHrktCek();
      XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
      {
        Namespace = teklifHrktCek.Namespace
      });
      typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = teklifHrktCek.GetSchemaSerializable();
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
    public delegate void TeklifHrktCekRowChangeEventHandler(
      object sender,
      teklifHrktCek.TeklifHrktCekRowChangeEvent e);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public delegate void TeklifToplamlariRowChangeEventHandler(
      object sender,
      teklifHrktCek.TeklifToplamlariRowChangeEvent e);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public delegate void AylaraGoreCekRowChangeEventHandler(
      object sender,
      teklifHrktCek.AylaraGoreCekRowChangeEvent e);

    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class TeklifHrktCekDataTable : TypedTableBase<teklifHrktCek.TeklifHrktCekRow>
    {
      private DataColumn columnID;
      private DataColumn columnMIKTAR;
      private DataColumn columnMARKA;
      private DataColumn columnBIRIMADI;
      private DataColumn columnPLAKA;
      private DataColumn columnARACACIKLAMA;
      private DataColumn columnF1BIRIMFIYAT;
      private DataColumn columnF1TUTAR;
      private DataColumn columnFIRMAADI;
      private DataColumn columnMALZEMEADI;
      private DataColumn columnTEKLIFKONUSU;
      private DataColumn columnTARIH;
      private DataColumn columnMIKTAR1;
      private DataColumn columnMARKA1;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public TeklifHrktCekDataTable()
      {
        this.TableName = "TeklifHrktCek";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal TeklifHrktCekDataTable(DataTable table)
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
      protected TeklifHrktCekDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn IDColumn => this.columnID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MIKTARColumn => this.columnMIKTAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MARKAColumn => this.columnMARKA;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BIRIMADIColumn => this.columnBIRIMADI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn PLAKAColumn => this.columnPLAKA;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ARACACIKLAMAColumn => this.columnARACACIKLAMA;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn F1BIRIMFIYATColumn => this.columnF1BIRIMFIYAT;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn F1TUTARColumn => this.columnF1TUTAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn FIRMAADIColumn => this.columnFIRMAADI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MALZEMEADIColumn => this.columnMALZEMEADI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn TEKLIFKONUSUColumn => this.columnTEKLIFKONUSU;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn TARIHColumn => this.columnTARIH;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MIKTAR1Column => this.columnMIKTAR1;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MARKA1Column => this.columnMARKA1;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public teklifHrktCek.TeklifHrktCekRow this[int index] => (teklifHrktCek.TeklifHrktCekRow) this.Rows[index];

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event teklifHrktCek.TeklifHrktCekRowChangeEventHandler TeklifHrktCekRowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event teklifHrktCek.TeklifHrktCekRowChangeEventHandler TeklifHrktCekRowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event teklifHrktCek.TeklifHrktCekRowChangeEventHandler TeklifHrktCekRowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event teklifHrktCek.TeklifHrktCekRowChangeEventHandler TeklifHrktCekRowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void AddTeklifHrktCekRow(teklifHrktCek.TeklifHrktCekRow row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public teklifHrktCek.TeklifHrktCekRow AddTeklifHrktCekRow(
        string MIKTAR,
        int MARKA,
        string BIRIMADI,
        string PLAKA,
        string ARACACIKLAMA,
        Decimal F1BIRIMFIYAT,
        Decimal F1TUTAR,
        string FIRMAADI,
        string MALZEMEADI,
        string TEKLIFKONUSU,
        DateTime TARIH,
        Decimal MIKTAR1,
        Decimal MARKA1)
      {
        teklifHrktCek.TeklifHrktCekRow row = (teklifHrktCek.TeklifHrktCekRow) this.NewRow();
        object[] objArray = new object[14]
        {
          null,
          (object) MIKTAR,
          (object) MARKA,
          (object) BIRIMADI,
          (object) PLAKA,
          (object) ARACACIKLAMA,
          (object) F1BIRIMFIYAT,
          (object) F1TUTAR,
          (object) FIRMAADI,
          (object) MALZEMEADI,
          (object) TEKLIFKONUSU,
          (object) TARIH,
          (object) MIKTAR1,
          (object) MARKA1
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public teklifHrktCek.TeklifHrktCekRow FindByID(int ID) => (teklifHrktCek.TeklifHrktCekRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public override DataTable Clone()
      {
        teklifHrktCek.TeklifHrktCekDataTable hrktCekDataTable = (teklifHrktCek.TeklifHrktCekDataTable) base.Clone();
        hrktCekDataTable.InitVars();
        return (DataTable) hrktCekDataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataTable CreateInstance() => (DataTable) new teklifHrktCek.TeklifHrktCekDataTable();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal void InitVars()
      {
        this.columnID = this.Columns["ID"];
        this.columnMIKTAR = this.Columns["MIKTAR"];
        this.columnMARKA = this.Columns["MARKA"];
        this.columnBIRIMADI = this.Columns["BIRIMADI"];
        this.columnPLAKA = this.Columns["PLAKA"];
        this.columnARACACIKLAMA = this.Columns["ARACACIKLAMA"];
        this.columnF1BIRIMFIYAT = this.Columns["F1BIRIMFIYAT"];
        this.columnF1TUTAR = this.Columns["F1TUTAR"];
        this.columnFIRMAADI = this.Columns["FIRMAADI"];
        this.columnMALZEMEADI = this.Columns["MALZEMEADI"];
        this.columnTEKLIFKONUSU = this.Columns["TEKLIFKONUSU"];
        this.columnTARIH = this.Columns["TARIH"];
        this.columnMIKTAR1 = this.Columns["MIKTAR1"];
        this.columnMARKA1 = this.Columns["MARKA1"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      private void InitClass()
      {
        this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnID);
        this.columnMIKTAR = new DataColumn("MIKTAR", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMIKTAR);
        this.columnMARKA = new DataColumn("MARKA", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMARKA);
        this.columnBIRIMADI = new DataColumn("BIRIMADI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBIRIMADI);
        this.columnPLAKA = new DataColumn("PLAKA", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnPLAKA);
        this.columnARACACIKLAMA = new DataColumn("ARACACIKLAMA", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnARACACIKLAMA);
        this.columnF1BIRIMFIYAT = new DataColumn("F1BIRIMFIYAT", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnF1BIRIMFIYAT);
        this.columnF1TUTAR = new DataColumn("F1TUTAR", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnF1TUTAR);
        this.columnFIRMAADI = new DataColumn("FIRMAADI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnFIRMAADI);
        this.columnMALZEMEADI = new DataColumn("MALZEMEADI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMALZEMEADI);
        this.columnTEKLIFKONUSU = new DataColumn("TEKLIFKONUSU", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTEKLIFKONUSU);
        this.columnTARIH = new DataColumn("TARIH", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTARIH);
        this.columnMIKTAR1 = new DataColumn("MIKTAR1", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMIKTAR1);
        this.columnMARKA1 = new DataColumn("MARKA1", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMARKA1);
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
        this.columnMIKTAR.MaxLength = 50;
        this.columnBIRIMADI.MaxLength = 50;
        this.columnPLAKA.MaxLength = 50;
        this.columnARACACIKLAMA.MaxLength = 150;
        this.columnFIRMAADI.MaxLength = 50;
        this.columnMALZEMEADI.MaxLength = 80;
        this.columnTEKLIFKONUSU.MaxLength = 50;
        this.columnMIKTAR1.Caption = "MIKTAR";
        this.columnMARKA1.Caption = "MARKA";
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public teklifHrktCek.TeklifHrktCekRow NewTeklifHrktCekRow() => (teklifHrktCek.TeklifHrktCekRow) this.NewRow();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new teklifHrktCek.TeklifHrktCekRow(builder);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override Type GetRowType() => typeof (teklifHrktCek.TeklifHrktCekRow);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.TeklifHrktCekRowChanged == null)
          return;
        this.TeklifHrktCekRowChanged((object) this, new teklifHrktCek.TeklifHrktCekRowChangeEvent((teklifHrktCek.TeklifHrktCekRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.TeklifHrktCekRowChanging == null)
          return;
        this.TeklifHrktCekRowChanging((object) this, new teklifHrktCek.TeklifHrktCekRowChangeEvent((teklifHrktCek.TeklifHrktCekRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.TeklifHrktCekRowDeleted == null)
          return;
        this.TeklifHrktCekRowDeleted((object) this, new teklifHrktCek.TeklifHrktCekRowChangeEvent((teklifHrktCek.TeklifHrktCekRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.TeklifHrktCekRowDeleting == null)
          return;
        this.TeklifHrktCekRowDeleting((object) this, new teklifHrktCek.TeklifHrktCekRowChangeEvent((teklifHrktCek.TeklifHrktCekRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void RemoveTeklifHrktCekRow(teklifHrktCek.TeklifHrktCekRow row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        teklifHrktCek teklifHrktCek = new teklifHrktCek();
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
          FixedValue = teklifHrktCek.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (TeklifHrktCekDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = teklifHrktCek.GetSchemaSerializable();
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
    public class TeklifToplamlariDataTable : TypedTableBase<teklifHrktCek.TeklifToplamlariRow>
    {
      private DataColumn columnBIRIMADI;
      private DataColumn columnMALZEMEADI;
      private DataColumn columnMALZEMEGRUP;
      private DataColumn columnBOLUMADI;
      private DataColumn columnSum_MIKTAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public TeklifToplamlariDataTable()
      {
        this.TableName = "TeklifToplamlari";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal TeklifToplamlariDataTable(DataTable table)
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
      protected TeklifToplamlariDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BIRIMADIColumn => this.columnBIRIMADI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MALZEMEADIColumn => this.columnMALZEMEADI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MALZEMEGRUPColumn => this.columnMALZEMEGRUP;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BOLUMADIColumn => this.columnBOLUMADI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn Sum_MIKTARColumn => this.columnSum_MIKTAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public teklifHrktCek.TeklifToplamlariRow this[int index] => (teklifHrktCek.TeklifToplamlariRow) this.Rows[index];

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event teklifHrktCek.TeklifToplamlariRowChangeEventHandler TeklifToplamlariRowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event teklifHrktCek.TeklifToplamlariRowChangeEventHandler TeklifToplamlariRowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event teklifHrktCek.TeklifToplamlariRowChangeEventHandler TeklifToplamlariRowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event teklifHrktCek.TeklifToplamlariRowChangeEventHandler TeklifToplamlariRowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void AddTeklifToplamlariRow(teklifHrktCek.TeklifToplamlariRow row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public teklifHrktCek.TeklifToplamlariRow AddTeklifToplamlariRow(
        string BIRIMADI,
        string MALZEMEADI,
        string MALZEMEGRUP,
        string BOLUMADI,
        Decimal Sum_MIKTAR)
      {
        teklifHrktCek.TeklifToplamlariRow row = (teklifHrktCek.TeklifToplamlariRow) this.NewRow();
        object[] objArray = new object[5]
        {
          (object) BIRIMADI,
          (object) MALZEMEADI,
          (object) MALZEMEGRUP,
          (object) BOLUMADI,
          (object) Sum_MIKTAR
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public override DataTable Clone()
      {
        teklifHrktCek.TeklifToplamlariDataTable toplamlariDataTable = (teklifHrktCek.TeklifToplamlariDataTable) base.Clone();
        toplamlariDataTable.InitVars();
        return (DataTable) toplamlariDataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataTable CreateInstance() => (DataTable) new teklifHrktCek.TeklifToplamlariDataTable();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal void InitVars()
      {
        this.columnBIRIMADI = this.Columns["BIRIMADI"];
        this.columnMALZEMEADI = this.Columns["MALZEMEADI"];
        this.columnMALZEMEGRUP = this.Columns["MALZEMEGRUP"];
        this.columnBOLUMADI = this.Columns["BOLUMADI"];
        this.columnSum_MIKTAR = this.Columns["Sum_MIKTAR"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      private void InitClass()
      {
        this.columnBIRIMADI = new DataColumn("BIRIMADI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBIRIMADI);
        this.columnMALZEMEADI = new DataColumn("MALZEMEADI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMALZEMEADI);
        this.columnMALZEMEGRUP = new DataColumn("MALZEMEGRUP", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMALZEMEGRUP);
        this.columnBOLUMADI = new DataColumn("BOLUMADI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBOLUMADI);
        this.columnSum_MIKTAR = new DataColumn("Sum_MIKTAR", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSum_MIKTAR);
        this.columnBIRIMADI.MaxLength = 50;
        this.columnMALZEMEADI.MaxLength = 80;
        this.columnMALZEMEGRUP.MaxLength = 50;
        this.columnBOLUMADI.MaxLength = 50;
        this.columnSum_MIKTAR.ReadOnly = true;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public teklifHrktCek.TeklifToplamlariRow NewTeklifToplamlariRow() => (teklifHrktCek.TeklifToplamlariRow) this.NewRow();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new teklifHrktCek.TeklifToplamlariRow(builder);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override Type GetRowType() => typeof (teklifHrktCek.TeklifToplamlariRow);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.TeklifToplamlariRowChanged == null)
          return;
        this.TeklifToplamlariRowChanged((object) this, new teklifHrktCek.TeklifToplamlariRowChangeEvent((teklifHrktCek.TeklifToplamlariRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.TeklifToplamlariRowChanging == null)
          return;
        this.TeklifToplamlariRowChanging((object) this, new teklifHrktCek.TeklifToplamlariRowChangeEvent((teklifHrktCek.TeklifToplamlariRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.TeklifToplamlariRowDeleted == null)
          return;
        this.TeklifToplamlariRowDeleted((object) this, new teklifHrktCek.TeklifToplamlariRowChangeEvent((teklifHrktCek.TeklifToplamlariRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.TeklifToplamlariRowDeleting == null)
          return;
        this.TeklifToplamlariRowDeleting((object) this, new teklifHrktCek.TeklifToplamlariRowChangeEvent((teklifHrktCek.TeklifToplamlariRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void RemoveTeklifToplamlariRow(teklifHrktCek.TeklifToplamlariRow row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        teklifHrktCek teklifHrktCek = new teklifHrktCek();
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
          FixedValue = teklifHrktCek.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (TeklifToplamlariDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = teklifHrktCek.GetSchemaSerializable();
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
    public class AylaraGoreCekDataTable : TypedTableBase<teklifHrktCek.AylaraGoreCekRow>
    {
      private DataColumn columnID;
      private DataColumn columnPLAKA;
      private DataColumn columnFATURATARIHI;
      private DataColumn columnTUTAR;
      private DataColumn columnay;
      private DataColumn columnyıl;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AylaraGoreCekDataTable()
      {
        this.TableName = "AylaraGoreCek";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal AylaraGoreCekDataTable(DataTable table)
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
      protected AylaraGoreCekDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn IDColumn => this.columnID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn PLAKAColumn => this.columnPLAKA;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn FATURATARIHIColumn => this.columnFATURATARIHI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn TUTARColumn => this.columnTUTAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ayColumn => this.columnay;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn yılColumn => this.columnyıl;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public teklifHrktCek.AylaraGoreCekRow this[int index] => (teklifHrktCek.AylaraGoreCekRow) this.Rows[index];

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event teklifHrktCek.AylaraGoreCekRowChangeEventHandler AylaraGoreCekRowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event teklifHrktCek.AylaraGoreCekRowChangeEventHandler AylaraGoreCekRowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event teklifHrktCek.AylaraGoreCekRowChangeEventHandler AylaraGoreCekRowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event teklifHrktCek.AylaraGoreCekRowChangeEventHandler AylaraGoreCekRowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void AddAylaraGoreCekRow(teklifHrktCek.AylaraGoreCekRow row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public teklifHrktCek.AylaraGoreCekRow AddAylaraGoreCekRow(
        string PLAKA,
        DateTime FATURATARIHI,
        Decimal TUTAR,
        string ay,
        string yıl)
      {
        teklifHrktCek.AylaraGoreCekRow row = (teklifHrktCek.AylaraGoreCekRow) this.NewRow();
        object[] objArray = new object[6]
        {
          null,
          (object) PLAKA,
          (object) FATURATARIHI,
          (object) TUTAR,
          (object) ay,
          (object) yıl
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public teklifHrktCek.AylaraGoreCekRow FindByID(int ID) => (teklifHrktCek.AylaraGoreCekRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public override DataTable Clone()
      {
        teklifHrktCek.AylaraGoreCekDataTable goreCekDataTable = (teklifHrktCek.AylaraGoreCekDataTable) base.Clone();
        goreCekDataTable.InitVars();
        return (DataTable) goreCekDataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataTable CreateInstance() => (DataTable) new teklifHrktCek.AylaraGoreCekDataTable();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal void InitVars()
      {
        this.columnID = this.Columns["ID"];
        this.columnPLAKA = this.Columns["PLAKA"];
        this.columnFATURATARIHI = this.Columns["FATURATARIHI"];
        this.columnTUTAR = this.Columns["TUTAR"];
        this.columnay = this.Columns["ay"];
        this.columnyıl = this.Columns["yıl"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      private void InitClass()
      {
        this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnID);
        this.columnPLAKA = new DataColumn("PLAKA", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnPLAKA);
        this.columnFATURATARIHI = new DataColumn("FATURATARIHI", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnFATURATARIHI);
        this.columnTUTAR = new DataColumn("TUTAR", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTUTAR);
        this.columnay = new DataColumn("ay", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnay);
        this.columnyıl = new DataColumn("yıl", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnyıl);
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
        this.columnPLAKA.MaxLength = 50;
        this.columnay.ReadOnly = true;
        this.columnay.MaxLength = 30;
        this.columnyıl.ReadOnly = true;
        this.columnyıl.MaxLength = 30;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public teklifHrktCek.AylaraGoreCekRow NewAylaraGoreCekRow() => (teklifHrktCek.AylaraGoreCekRow) this.NewRow();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new teklifHrktCek.AylaraGoreCekRow(builder);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override Type GetRowType() => typeof (teklifHrktCek.AylaraGoreCekRow);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.AylaraGoreCekRowChanged == null)
          return;
        this.AylaraGoreCekRowChanged((object) this, new teklifHrktCek.AylaraGoreCekRowChangeEvent((teklifHrktCek.AylaraGoreCekRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.AylaraGoreCekRowChanging == null)
          return;
        this.AylaraGoreCekRowChanging((object) this, new teklifHrktCek.AylaraGoreCekRowChangeEvent((teklifHrktCek.AylaraGoreCekRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.AylaraGoreCekRowDeleted == null)
          return;
        this.AylaraGoreCekRowDeleted((object) this, new teklifHrktCek.AylaraGoreCekRowChangeEvent((teklifHrktCek.AylaraGoreCekRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.AylaraGoreCekRowDeleting == null)
          return;
        this.AylaraGoreCekRowDeleting((object) this, new teklifHrktCek.AylaraGoreCekRowChangeEvent((teklifHrktCek.AylaraGoreCekRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void RemoveAylaraGoreCekRow(teklifHrktCek.AylaraGoreCekRow row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        teklifHrktCek teklifHrktCek = new teklifHrktCek();
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
          FixedValue = teklifHrktCek.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (AylaraGoreCekDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = teklifHrktCek.GetSchemaSerializable();
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

    public class TeklifHrktCekRow : DataRow
    {
      private teklifHrktCek.TeklifHrktCekDataTable tableTeklifHrktCek;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal TeklifHrktCekRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableTeklifHrktCek = (teklifHrktCek.TeklifHrktCekDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ID
      {
        get => (int) this[this.tableTeklifHrktCek.IDColumn];
        set => this[this.tableTeklifHrktCek.IDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string MIKTAR
      {
        get
        {
          try
          {
            return (string) this[this.tableTeklifHrktCek.MIKTARColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TeklifHrktCek' tablosundaki 'MIKTAR' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTeklifHrktCek.MIKTARColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int MARKA
      {
        get
        {
          try
          {
            return (int) this[this.tableTeklifHrktCek.MARKAColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TeklifHrktCek' tablosundaki 'MARKA' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTeklifHrktCek.MARKAColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BIRIMADI
      {
        get
        {
          try
          {
            return (string) this[this.tableTeklifHrktCek.BIRIMADIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TeklifHrktCek' tablosundaki 'BIRIMADI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTeklifHrktCek.BIRIMADIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string PLAKA
      {
        get
        {
          try
          {
            return (string) this[this.tableTeklifHrktCek.PLAKAColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TeklifHrktCek' tablosundaki 'PLAKA' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTeklifHrktCek.PLAKAColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string ARACACIKLAMA
      {
        get
        {
          try
          {
            return (string) this[this.tableTeklifHrktCek.ARACACIKLAMAColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TeklifHrktCek' tablosundaki 'ARACACIKLAMA' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTeklifHrktCek.ARACACIKLAMAColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Decimal F1BIRIMFIYAT
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableTeklifHrktCek.F1BIRIMFIYATColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TeklifHrktCek' tablosundaki 'F1BIRIMFIYAT' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTeklifHrktCek.F1BIRIMFIYATColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Decimal F1TUTAR
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableTeklifHrktCek.F1TUTARColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TeklifHrktCek' tablosundaki 'F1TUTAR' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTeklifHrktCek.F1TUTARColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string FIRMAADI
      {
        get
        {
          try
          {
            return (string) this[this.tableTeklifHrktCek.FIRMAADIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TeklifHrktCek' tablosundaki 'FIRMAADI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTeklifHrktCek.FIRMAADIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string MALZEMEADI
      {
        get
        {
          try
          {
            return (string) this[this.tableTeklifHrktCek.MALZEMEADIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TeklifHrktCek' tablosundaki 'MALZEMEADI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTeklifHrktCek.MALZEMEADIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string TEKLIFKONUSU
      {
        get
        {
          try
          {
            return (string) this[this.tableTeklifHrktCek.TEKLIFKONUSUColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TeklifHrktCek' tablosundaki 'TEKLIFKONUSU' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTeklifHrktCek.TEKLIFKONUSUColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DateTime TARIH
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableTeklifHrktCek.TARIHColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TeklifHrktCek' tablosundaki 'TARIH' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTeklifHrktCek.TARIHColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Decimal MIKTAR1
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableTeklifHrktCek.MIKTAR1Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TeklifHrktCek' tablosundaki 'MIKTAR1' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTeklifHrktCek.MIKTAR1Column] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Decimal MARKA1
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableTeklifHrktCek.MARKA1Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TeklifHrktCek' tablosundaki 'MARKA1' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTeklifHrktCek.MARKA1Column] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMIKTARNull() => this.IsNull(this.tableTeklifHrktCek.MIKTARColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMIKTARNull() => this[this.tableTeklifHrktCek.MIKTARColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMARKANull() => this.IsNull(this.tableTeklifHrktCek.MARKAColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMARKANull() => this[this.tableTeklifHrktCek.MARKAColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBIRIMADINull() => this.IsNull(this.tableTeklifHrktCek.BIRIMADIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBIRIMADINull() => this[this.tableTeklifHrktCek.BIRIMADIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsPLAKANull() => this.IsNull(this.tableTeklifHrktCek.PLAKAColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetPLAKANull() => this[this.tableTeklifHrktCek.PLAKAColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsARACACIKLAMANull() => this.IsNull(this.tableTeklifHrktCek.ARACACIKLAMAColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetARACACIKLAMANull() => this[this.tableTeklifHrktCek.ARACACIKLAMAColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsF1BIRIMFIYATNull() => this.IsNull(this.tableTeklifHrktCek.F1BIRIMFIYATColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetF1BIRIMFIYATNull() => this[this.tableTeklifHrktCek.F1BIRIMFIYATColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsF1TUTARNull() => this.IsNull(this.tableTeklifHrktCek.F1TUTARColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetF1TUTARNull() => this[this.tableTeklifHrktCek.F1TUTARColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsFIRMAADINull() => this.IsNull(this.tableTeklifHrktCek.FIRMAADIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetFIRMAADINull() => this[this.tableTeklifHrktCek.FIRMAADIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMALZEMEADINull() => this.IsNull(this.tableTeklifHrktCek.MALZEMEADIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMALZEMEADINull() => this[this.tableTeklifHrktCek.MALZEMEADIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsTEKLIFKONUSUNull() => this.IsNull(this.tableTeklifHrktCek.TEKLIFKONUSUColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetTEKLIFKONUSUNull() => this[this.tableTeklifHrktCek.TEKLIFKONUSUColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsTARIHNull() => this.IsNull(this.tableTeklifHrktCek.TARIHColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetTARIHNull() => this[this.tableTeklifHrktCek.TARIHColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMIKTAR1Null() => this.IsNull(this.tableTeklifHrktCek.MIKTAR1Column);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMIKTAR1Null() => this[this.tableTeklifHrktCek.MIKTAR1Column] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMARKA1Null() => this.IsNull(this.tableTeklifHrktCek.MARKA1Column);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMARKA1Null() => this[this.tableTeklifHrktCek.MARKA1Column] = Convert.DBNull;
    }

    public class TeklifToplamlariRow : DataRow
    {
      private teklifHrktCek.TeklifToplamlariDataTable tableTeklifToplamlari;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal TeklifToplamlariRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableTeklifToplamlari = (teklifHrktCek.TeklifToplamlariDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BIRIMADI
      {
        get
        {
          try
          {
            return (string) this[this.tableTeklifToplamlari.BIRIMADIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TeklifToplamlari' tablosundaki 'BIRIMADI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTeklifToplamlari.BIRIMADIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string MALZEMEADI
      {
        get
        {
          try
          {
            return (string) this[this.tableTeklifToplamlari.MALZEMEADIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TeklifToplamlari' tablosundaki 'MALZEMEADI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTeklifToplamlari.MALZEMEADIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string MALZEMEGRUP
      {
        get
        {
          try
          {
            return (string) this[this.tableTeklifToplamlari.MALZEMEGRUPColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TeklifToplamlari' tablosundaki 'MALZEMEGRUP' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTeklifToplamlari.MALZEMEGRUPColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BOLUMADI
      {
        get
        {
          try
          {
            return (string) this[this.tableTeklifToplamlari.BOLUMADIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TeklifToplamlari' tablosundaki 'BOLUMADI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTeklifToplamlari.BOLUMADIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Decimal Sum_MIKTAR
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableTeklifToplamlari.Sum_MIKTARColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TeklifToplamlari' tablosundaki 'Sum_MIKTAR' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTeklifToplamlari.Sum_MIKTARColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBIRIMADINull() => this.IsNull(this.tableTeklifToplamlari.BIRIMADIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBIRIMADINull() => this[this.tableTeklifToplamlari.BIRIMADIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMALZEMEADINull() => this.IsNull(this.tableTeklifToplamlari.MALZEMEADIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMALZEMEADINull() => this[this.tableTeklifToplamlari.MALZEMEADIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMALZEMEGRUPNull() => this.IsNull(this.tableTeklifToplamlari.MALZEMEGRUPColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMALZEMEGRUPNull() => this[this.tableTeklifToplamlari.MALZEMEGRUPColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBOLUMADINull() => this.IsNull(this.tableTeklifToplamlari.BOLUMADIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBOLUMADINull() => this[this.tableTeklifToplamlari.BOLUMADIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsSum_MIKTARNull() => this.IsNull(this.tableTeklifToplamlari.Sum_MIKTARColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetSum_MIKTARNull() => this[this.tableTeklifToplamlari.Sum_MIKTARColumn] = Convert.DBNull;
    }

    public class AylaraGoreCekRow : DataRow
    {
      private teklifHrktCek.AylaraGoreCekDataTable tableAylaraGoreCek;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal AylaraGoreCekRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableAylaraGoreCek = (teklifHrktCek.AylaraGoreCekDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ID
      {
        get => (int) this[this.tableAylaraGoreCek.IDColumn];
        set => this[this.tableAylaraGoreCek.IDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string PLAKA
      {
        get
        {
          try
          {
            return (string) this[this.tableAylaraGoreCek.PLAKAColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'AylaraGoreCek' tablosundaki 'PLAKA' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableAylaraGoreCek.PLAKAColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DateTime FATURATARIHI
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableAylaraGoreCek.FATURATARIHIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'AylaraGoreCek' tablosundaki 'FATURATARIHI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableAylaraGoreCek.FATURATARIHIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Decimal TUTAR
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableAylaraGoreCek.TUTARColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'AylaraGoreCek' tablosundaki 'TUTAR' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableAylaraGoreCek.TUTARColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string ay
      {
        get
        {
          try
          {
            return (string) this[this.tableAylaraGoreCek.ayColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'AylaraGoreCek' tablosundaki 'ay' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableAylaraGoreCek.ayColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string yıl
      {
        get
        {
          try
          {
            return (string) this[this.tableAylaraGoreCek.yılColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'AylaraGoreCek' tablosundaki 'yıl' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableAylaraGoreCek.yılColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsPLAKANull() => this.IsNull(this.tableAylaraGoreCek.PLAKAColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetPLAKANull() => this[this.tableAylaraGoreCek.PLAKAColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsFATURATARIHINull() => this.IsNull(this.tableAylaraGoreCek.FATURATARIHIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetFATURATARIHINull() => this[this.tableAylaraGoreCek.FATURATARIHIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsTUTARNull() => this.IsNull(this.tableAylaraGoreCek.TUTARColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetTUTARNull() => this[this.tableAylaraGoreCek.TUTARColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsayNull() => this.IsNull(this.tableAylaraGoreCek.ayColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetayNull() => this[this.tableAylaraGoreCek.ayColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsyılNull() => this.IsNull(this.tableAylaraGoreCek.yılColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetyılNull() => this[this.tableAylaraGoreCek.yılColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public class TeklifHrktCekRowChangeEvent : EventArgs
    {
      private teklifHrktCek.TeklifHrktCekRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public TeklifHrktCekRowChangeEvent(teklifHrktCek.TeklifHrktCekRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public teklifHrktCek.TeklifHrktCekRow Row => this.eventRow;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public class TeklifToplamlariRowChangeEvent : EventArgs
    {
      private teklifHrktCek.TeklifToplamlariRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public TeklifToplamlariRowChangeEvent(
        teklifHrktCek.TeklifToplamlariRow row,
        DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public teklifHrktCek.TeklifToplamlariRow Row => this.eventRow;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public class AylaraGoreCekRowChangeEvent : EventArgs
    {
      private teklifHrktCek.AylaraGoreCekRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AylaraGoreCekRowChangeEvent(teklifHrktCek.AylaraGoreCekRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public teklifHrktCek.AylaraGoreCekRow Row => this.eventRow;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataRowAction Action => this.eventAction;
    }
  }
}
