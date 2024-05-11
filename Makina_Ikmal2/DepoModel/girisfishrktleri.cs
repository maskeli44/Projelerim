// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.DepoModel.girisfishrktleri
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

namespace Makina_Ikmal.DepoModel
{
  [DesignerCategory("code")]
  [ToolboxItem(true)]
  [XmlSchemaProvider("GetTypedDataSetSchema")]
  [XmlRoot("girisfishrktleri")]
  [HelpKeyword("vs.data.DataSet")]
  [Serializable]
  public class girisfishrktleri : DataSet
  {
    private girisfishrktleri.DataTable1DataTable tableDataTable1;
    private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public girisfishrktleri()
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
    protected girisfishrktleri(SerializationInfo info, StreamingContext context)
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
          if (dataSet.Tables[nameof (DataTable1)] != null)
            base.Tables.Add((DataTable) new girisfishrktleri.DataTable1DataTable(dataSet.Tables[nameof (DataTable1)]));
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
    public girisfishrktleri.DataTable1DataTable DataTable1 => this.tableDataTable1;

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
      girisfishrktleri girisfishrktleri = (girisfishrktleri) base.Clone();
      girisfishrktleri.InitVars();
      girisfishrktleri.SchemaSerializationMode = this.SchemaSerializationMode;
      return (DataSet) girisfishrktleri;
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
        if (dataSet.Tables["DataTable1"] != null)
          base.Tables.Add((DataTable) new girisfishrktleri.DataTable1DataTable(dataSet.Tables["DataTable1"]));
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
      this.tableDataTable1 = (girisfishrktleri.DataTable1DataTable) base.Tables["DataTable1"];
      if (!initTable || this.tableDataTable1 == null)
        return;
      this.tableDataTable1.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.DataSetName = nameof (girisfishrktleri);
      this.Prefix = "";
      this.Namespace = "http://tempuri.org/girisfishrktleri.xsd";
      this.EnforceConstraints = true;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tableDataTable1 = new girisfishrktleri.DataTable1DataTable();
      base.Tables.Add((DataTable) this.tableDataTable1);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private bool ShouldSerializeDataTable1() => false;

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
      girisfishrktleri girisfishrktleri = new girisfishrktleri();
      XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
      {
        Namespace = girisfishrktleri.Namespace
      });
      typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = girisfishrktleri.GetSchemaSerializable();
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
    public delegate void DataTable1RowChangeEventHandler(
      object sender,
      girisfishrktleri.DataTable1RowChangeEvent e);

    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class DataTable1DataTable : TypedTableBase<girisfishrktleri.DataTable1Row>
    {
      private DataColumn columnDEPOFISID;
      private DataColumn columnPLAKA;
      private DataColumn columnARACACIKLAMA;
      private DataColumn columnKOD;
      private DataColumn columnTARIH;
      private DataColumn columnMALZEMEID;
      private DataColumn columnMALZEMEGRUP;
      private DataColumn columnMALZACIKLAMA;
      private DataColumn columnBIRIMID;
      private DataColumn columnMIKTAR;
      private DataColumn columnGIRISMIKTAR;
      private DataColumn columnCIKISMIKTAR;
      private DataColumn columnFIYAT;
      private DataColumn columnMALZEMEADI;
      private DataColumn columnMALZEMEGRUP2;
      private DataColumn columnTUTAR;
      private DataColumn columnGIRISTUTAR;
      private DataColumn columnCIKISTUTAR;
      private DataColumn columnKDVORAN;
      private DataColumn columnKDVTUTAR;
      private DataColumn columnSATIRTUTAR;
      private DataColumn columnGCKOD;
      private DataColumn columnDEPOID;
      private DataColumn columnMALZMARKAID;
      private DataColumn columnMALZSERINO;
      private DataColumn columnMALZURTTARIH;
      private DataColumn columnExpr1;
      private DataColumn columnBOLUMADI;
      private DataColumn columnID;
      private DataColumn columnDepoFisId1;
      private DataColumn columnISLEMTIPIID;
      private DataColumn columnMIKTAR1;
      private DataColumn columnGIRISMIKTAR1;
      private DataColumn columnCIKISMIKTAR1;
      private DataColumn columnKDVORAN1;
      private DataColumn columnSATIRTUTAR1;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataTable1DataTable()
      {
        this.TableName = "DataTable1";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal DataTable1DataTable(DataTable table)
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
      protected DataTable1DataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn DEPOFISIDColumn => this.columnDEPOFISID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn PLAKAColumn => this.columnPLAKA;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ARACACIKLAMAColumn => this.columnARACACIKLAMA;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn KODColumn => this.columnKOD;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn TARIHColumn => this.columnTARIH;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MALZEMEIDColumn => this.columnMALZEMEID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MALZEMEGRUPColumn => this.columnMALZEMEGRUP;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MALZACIKLAMAColumn => this.columnMALZACIKLAMA;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BIRIMIDColumn => this.columnBIRIMID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MIKTARColumn => this.columnMIKTAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn GIRISMIKTARColumn => this.columnGIRISMIKTAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn CIKISMIKTARColumn => this.columnCIKISMIKTAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn FIYATColumn => this.columnFIYAT;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MALZEMEADIColumn => this.columnMALZEMEADI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MALZEMEGRUP2Column => this.columnMALZEMEGRUP2;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn TUTARColumn => this.columnTUTAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn GIRISTUTARColumn => this.columnGIRISTUTAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn CIKISTUTARColumn => this.columnCIKISTUTAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn KDVORANColumn => this.columnKDVORAN;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn KDVTUTARColumn => this.columnKDVTUTAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn SATIRTUTARColumn => this.columnSATIRTUTAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn GCKODColumn => this.columnGCKOD;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn DEPOIDColumn => this.columnDEPOID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MALZMARKAIDColumn => this.columnMALZMARKAID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MALZSERINOColumn => this.columnMALZSERINO;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MALZURTTARIHColumn => this.columnMALZURTTARIH;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn Expr1Column => this.columnExpr1;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BOLUMADIColumn => this.columnBOLUMADI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn IDColumn => this.columnID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn DepoFisId1Column => this.columnDepoFisId1;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ISLEMTIPIIDColumn => this.columnISLEMTIPIID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MIKTAR1Column => this.columnMIKTAR1;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn GIRISMIKTAR1Column => this.columnGIRISMIKTAR1;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn CIKISMIKTAR1Column => this.columnCIKISMIKTAR1;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn KDVORAN1Column => this.columnKDVORAN1;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn SATIRTUTAR1Column => this.columnSATIRTUTAR1;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public girisfishrktleri.DataTable1Row this[int index] => (girisfishrktleri.DataTable1Row) this.Rows[index];

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event girisfishrktleri.DataTable1RowChangeEventHandler DataTable1RowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event girisfishrktleri.DataTable1RowChangeEventHandler DataTable1RowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event girisfishrktleri.DataTable1RowChangeEventHandler DataTable1RowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event girisfishrktleri.DataTable1RowChangeEventHandler DataTable1RowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void AddDataTable1Row(girisfishrktleri.DataTable1Row row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public girisfishrktleri.DataTable1Row AddDataTable1Row(
        int DEPOFISID,
        string PLAKA,
        string ARACACIKLAMA,
        string KOD,
        DateTime TARIH,
        int MALZEMEID,
        string MALZEMEGRUP,
        string MALZACIKLAMA,
        int BIRIMID,
        string MIKTAR,
        string GIRISMIKTAR,
        string CIKISMIKTAR,
        Decimal FIYAT,
        string MALZEMEADI,
        string MALZEMEGRUP2,
        Decimal TUTAR,
        Decimal GIRISTUTAR,
        Decimal CIKISTUTAR,
        string KDVORAN,
        Decimal KDVTUTAR,
        string SATIRTUTAR,
        string GCKOD,
        int DEPOID,
        int MALZMARKAID,
        string MALZSERINO,
        string MALZURTTARIH,
        string Expr1,
        string BOLUMADI,
        string ISLEMTIPIID,
        Decimal MIKTAR1,
        Decimal GIRISMIKTAR1,
        Decimal CIKISMIKTAR1,
        Decimal KDVORAN1,
        Decimal SATIRTUTAR1)
      {
        girisfishrktleri.DataTable1Row row = (girisfishrktleri.DataTable1Row) this.NewRow();
        object[] objArray = new object[36]
        {
          (object) DEPOFISID,
          (object) PLAKA,
          (object) ARACACIKLAMA,
          (object) KOD,
          (object) TARIH,
          (object) MALZEMEID,
          (object) MALZEMEGRUP,
          (object) MALZACIKLAMA,
          (object) BIRIMID,
          (object) MIKTAR,
          (object) GIRISMIKTAR,
          (object) CIKISMIKTAR,
          (object) FIYAT,
          (object) MALZEMEADI,
          (object) MALZEMEGRUP2,
          (object) TUTAR,
          (object) GIRISTUTAR,
          (object) CIKISTUTAR,
          (object) KDVORAN,
          (object) KDVTUTAR,
          (object) SATIRTUTAR,
          (object) GCKOD,
          (object) DEPOID,
          (object) MALZMARKAID,
          (object) MALZSERINO,
          (object) MALZURTTARIH,
          (object) Expr1,
          (object) BOLUMADI,
          null,
          null,
          (object) ISLEMTIPIID,
          (object) MIKTAR1,
          (object) GIRISMIKTAR1,
          (object) CIKISMIKTAR1,
          (object) KDVORAN1,
          (object) SATIRTUTAR1
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public girisfishrktleri.DataTable1Row FindByID(int ID) => (girisfishrktleri.DataTable1Row) this.Rows.Find(new object[1]
      {
        (object) ID
      });

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public override DataTable Clone()
      {
        girisfishrktleri.DataTable1DataTable dataTable1DataTable = (girisfishrktleri.DataTable1DataTable) base.Clone();
        dataTable1DataTable.InitVars();
        return (DataTable) dataTable1DataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataTable CreateInstance() => (DataTable) new girisfishrktleri.DataTable1DataTable();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal void InitVars()
      {
        this.columnDEPOFISID = this.Columns["DEPOFISID"];
        this.columnPLAKA = this.Columns["PLAKA"];
        this.columnARACACIKLAMA = this.Columns["ARACACIKLAMA"];
        this.columnKOD = this.Columns["KOD"];
        this.columnTARIH = this.Columns["TARIH"];
        this.columnMALZEMEID = this.Columns["MALZEMEID"];
        this.columnMALZEMEGRUP = this.Columns["MALZEMEGRUP"];
        this.columnMALZACIKLAMA = this.Columns["MALZACIKLAMA"];
        this.columnBIRIMID = this.Columns["BIRIMID"];
        this.columnMIKTAR = this.Columns["MIKTAR"];
        this.columnGIRISMIKTAR = this.Columns["GIRISMIKTAR"];
        this.columnCIKISMIKTAR = this.Columns["CIKISMIKTAR"];
        this.columnFIYAT = this.Columns["FIYAT"];
        this.columnMALZEMEADI = this.Columns["MALZEMEADI"];
        this.columnMALZEMEGRUP2 = this.Columns["MALZEMEGRUP2"];
        this.columnTUTAR = this.Columns["TUTAR"];
        this.columnGIRISTUTAR = this.Columns["GIRISTUTAR"];
        this.columnCIKISTUTAR = this.Columns["CIKISTUTAR"];
        this.columnKDVORAN = this.Columns["KDVORAN"];
        this.columnKDVTUTAR = this.Columns["KDVTUTAR"];
        this.columnSATIRTUTAR = this.Columns["SATIRTUTAR"];
        this.columnGCKOD = this.Columns["GCKOD"];
        this.columnDEPOID = this.Columns["DEPOID"];
        this.columnMALZMARKAID = this.Columns["MALZMARKAID"];
        this.columnMALZSERINO = this.Columns["MALZSERINO"];
        this.columnMALZURTTARIH = this.Columns["MALZURTTARIH"];
        this.columnExpr1 = this.Columns["Expr1"];
        this.columnBOLUMADI = this.Columns["BOLUMADI"];
        this.columnID = this.Columns["ID"];
        this.columnDepoFisId1 = this.Columns["DepoFisId1"];
        this.columnISLEMTIPIID = this.Columns["ISLEMTIPIID"];
        this.columnMIKTAR1 = this.Columns["MIKTAR1"];
        this.columnGIRISMIKTAR1 = this.Columns["GIRISMIKTAR1"];
        this.columnCIKISMIKTAR1 = this.Columns["CIKISMIKTAR1"];
        this.columnKDVORAN1 = this.Columns["KDVORAN1"];
        this.columnSATIRTUTAR1 = this.Columns["SATIRTUTAR1"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      private void InitClass()
      {
        this.columnDEPOFISID = new DataColumn("DEPOFISID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDEPOFISID);
        this.columnPLAKA = new DataColumn("PLAKA", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnPLAKA);
        this.columnARACACIKLAMA = new DataColumn("ARACACIKLAMA", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnARACACIKLAMA);
        this.columnKOD = new DataColumn("KOD", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnKOD);
        this.columnTARIH = new DataColumn("TARIH", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTARIH);
        this.columnMALZEMEID = new DataColumn("MALZEMEID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMALZEMEID);
        this.columnMALZEMEGRUP = new DataColumn("MALZEMEGRUP", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMALZEMEGRUP);
        this.columnMALZACIKLAMA = new DataColumn("MALZACIKLAMA", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMALZACIKLAMA);
        this.columnBIRIMID = new DataColumn("BIRIMID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBIRIMID);
        this.columnMIKTAR = new DataColumn("MIKTAR", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMIKTAR);
        this.columnGIRISMIKTAR = new DataColumn("GIRISMIKTAR", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGIRISMIKTAR);
        this.columnCIKISMIKTAR = new DataColumn("CIKISMIKTAR", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCIKISMIKTAR);
        this.columnFIYAT = new DataColumn("FIYAT", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnFIYAT);
        this.columnMALZEMEADI = new DataColumn("MALZEMEADI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMALZEMEADI);
        this.columnMALZEMEGRUP2 = new DataColumn("MALZEMEGRUP2", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMALZEMEGRUP2);
        this.columnTUTAR = new DataColumn("TUTAR", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTUTAR);
        this.columnGIRISTUTAR = new DataColumn("GIRISTUTAR", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGIRISTUTAR);
        this.columnCIKISTUTAR = new DataColumn("CIKISTUTAR", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCIKISTUTAR);
        this.columnKDVORAN = new DataColumn("KDVORAN", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnKDVORAN);
        this.columnKDVTUTAR = new DataColumn("KDVTUTAR", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnKDVTUTAR);
        this.columnSATIRTUTAR = new DataColumn("SATIRTUTAR", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSATIRTUTAR);
        this.columnGCKOD = new DataColumn("GCKOD", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGCKOD);
        this.columnDEPOID = new DataColumn("DEPOID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDEPOID);
        this.columnMALZMARKAID = new DataColumn("MALZMARKAID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMALZMARKAID);
        this.columnMALZSERINO = new DataColumn("MALZSERINO", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMALZSERINO);
        this.columnMALZURTTARIH = new DataColumn("MALZURTTARIH", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMALZURTTARIH);
        this.columnExpr1 = new DataColumn("Expr1", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnExpr1);
        this.columnBOLUMADI = new DataColumn("BOLUMADI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBOLUMADI);
        this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnID);
        this.columnDepoFisId1 = new DataColumn("DepoFisId1", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDepoFisId1);
        this.columnISLEMTIPIID = new DataColumn("ISLEMTIPIID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnISLEMTIPIID);
        this.columnMIKTAR1 = new DataColumn("MIKTAR1", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMIKTAR1);
        this.columnGIRISMIKTAR1 = new DataColumn("GIRISMIKTAR1", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGIRISMIKTAR1);
        this.columnCIKISMIKTAR1 = new DataColumn("CIKISMIKTAR1", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCIKISMIKTAR1);
        this.columnKDVORAN1 = new DataColumn("KDVORAN1", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnKDVORAN1);
        this.columnSATIRTUTAR1 = new DataColumn("SATIRTUTAR1", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSATIRTUTAR1);
        this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
        {
          this.columnID
        }, true));
        this.columnPLAKA.MaxLength = 50;
        this.columnARACACIKLAMA.MaxLength = 150;
        this.columnKOD.MaxLength = 50;
        this.columnMALZEMEGRUP.MaxLength = 50;
        this.columnMALZACIKLAMA.MaxLength = 100;
        this.columnMIKTAR.MaxLength = 50;
        this.columnGIRISMIKTAR.MaxLength = 50;
        this.columnCIKISMIKTAR.MaxLength = 50;
        this.columnMALZEMEADI.MaxLength = 80;
        this.columnMALZEMEGRUP2.MaxLength = 50;
        this.columnKDVORAN.MaxLength = 50;
        this.columnSATIRTUTAR.MaxLength = 50;
        this.columnGCKOD.MaxLength = 50;
        this.columnMALZSERINO.MaxLength = 50;
        this.columnMALZURTTARIH.MaxLength = 50;
        this.columnExpr1.MaxLength = 50;
        this.columnBOLUMADI.MaxLength = 50;
        this.columnID.AutoIncrement = true;
        this.columnID.AutoIncrementSeed = -1L;
        this.columnID.AutoIncrementStep = -1L;
        this.columnID.AllowDBNull = false;
        this.columnID.ReadOnly = true;
        this.columnID.Unique = true;
        this.columnDepoFisId1.AutoIncrement = true;
        this.columnDepoFisId1.AutoIncrementSeed = -1L;
        this.columnDepoFisId1.AutoIncrementStep = -1L;
        this.columnDepoFisId1.AllowDBNull = false;
        this.columnDepoFisId1.ReadOnly = true;
        this.columnISLEMTIPIID.MaxLength = 50;
        this.columnMIKTAR1.Caption = "MIKTAR";
        this.columnGIRISMIKTAR1.Caption = "GIRISMIKTAR";
        this.columnCIKISMIKTAR1.Caption = "CIKISMIKTAR";
        this.columnKDVORAN1.Caption = "KDVORAN";
        this.columnSATIRTUTAR1.Caption = "SATIRTUTAR";
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public girisfishrktleri.DataTable1Row NewDataTable1Row() => (girisfishrktleri.DataTable1Row) this.NewRow();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new girisfishrktleri.DataTable1Row(builder);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override Type GetRowType() => typeof (girisfishrktleri.DataTable1Row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.DataTable1RowChanged == null)
          return;
        this.DataTable1RowChanged((object) this, new girisfishrktleri.DataTable1RowChangeEvent((girisfishrktleri.DataTable1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.DataTable1RowChanging == null)
          return;
        this.DataTable1RowChanging((object) this, new girisfishrktleri.DataTable1RowChangeEvent((girisfishrktleri.DataTable1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.DataTable1RowDeleted == null)
          return;
        this.DataTable1RowDeleted((object) this, new girisfishrktleri.DataTable1RowChangeEvent((girisfishrktleri.DataTable1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.DataTable1RowDeleting == null)
          return;
        this.DataTable1RowDeleting((object) this, new girisfishrktleri.DataTable1RowChangeEvent((girisfishrktleri.DataTable1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void RemoveDataTable1Row(girisfishrktleri.DataTable1Row row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        girisfishrktleri girisfishrktleri = new girisfishrktleri();
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
          FixedValue = girisfishrktleri.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (DataTable1DataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = girisfishrktleri.GetSchemaSerializable();
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

    public class DataTable1Row : DataRow
    {
      private girisfishrktleri.DataTable1DataTable tableDataTable1;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal DataTable1Row(DataRowBuilder rb)
        : base(rb)
      {
        this.tableDataTable1 = (girisfishrktleri.DataTable1DataTable) this.Table;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int DEPOFISID
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable1.DEPOFISIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'DEPOFISID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.DEPOFISIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string PLAKA
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.PLAKAColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'PLAKA' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.PLAKAColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string ARACACIKLAMA
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.ARACACIKLAMAColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'ARACACIKLAMA' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.ARACACIKLAMAColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string KOD
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.KODColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'KOD' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.KODColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DateTime TARIH
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableDataTable1.TARIHColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'TARIH' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.TARIHColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int MALZEMEID
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable1.MALZEMEIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'MALZEMEID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.MALZEMEIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string MALZEMEGRUP
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.MALZEMEGRUPColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'MALZEMEGRUP' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.MALZEMEGRUPColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string MALZACIKLAMA
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.MALZACIKLAMAColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'MALZACIKLAMA' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.MALZACIKLAMAColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int BIRIMID
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable1.BIRIMIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'BIRIMID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.BIRIMIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string MIKTAR
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.MIKTARColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'MIKTAR' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.MIKTARColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string GIRISMIKTAR
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.GIRISMIKTARColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'GIRISMIKTAR' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.GIRISMIKTARColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string CIKISMIKTAR
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.CIKISMIKTARColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'CIKISMIKTAR' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.CIKISMIKTARColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Decimal FIYAT
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableDataTable1.FIYATColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'FIYAT' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.FIYATColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string MALZEMEADI
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.MALZEMEADIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'MALZEMEADI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.MALZEMEADIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string MALZEMEGRUP2
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.MALZEMEGRUP2Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'MALZEMEGRUP2' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.MALZEMEGRUP2Column] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Decimal TUTAR
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableDataTable1.TUTARColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'TUTAR' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.TUTARColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Decimal GIRISTUTAR
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableDataTable1.GIRISTUTARColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'GIRISTUTAR' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.GIRISTUTARColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Decimal CIKISTUTAR
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableDataTable1.CIKISTUTARColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'CIKISTUTAR' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.CIKISTUTARColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string KDVORAN
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.KDVORANColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'KDVORAN' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.KDVORANColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Decimal KDVTUTAR
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableDataTable1.KDVTUTARColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'KDVTUTAR' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.KDVTUTARColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string SATIRTUTAR
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.SATIRTUTARColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'SATIRTUTAR' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.SATIRTUTARColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string GCKOD
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.GCKODColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'GCKOD' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.GCKODColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int DEPOID
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable1.DEPOIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'DEPOID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.DEPOIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int MALZMARKAID
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable1.MALZMARKAIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'MALZMARKAID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.MALZMARKAIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string MALZSERINO
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.MALZSERINOColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'MALZSERINO' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.MALZSERINOColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string MALZURTTARIH
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.MALZURTTARIHColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'MALZURTTARIH' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.MALZURTTARIHColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string Expr1
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.Expr1Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'Expr1' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.Expr1Column] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BOLUMADI
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.BOLUMADIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'BOLUMADI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.BOLUMADIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ID
      {
        get => (int) this[this.tableDataTable1.IDColumn];
        set => this[this.tableDataTable1.IDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int DepoFisId1
      {
        get => (int) this[this.tableDataTable1.DepoFisId1Column];
        set => this[this.tableDataTable1.DepoFisId1Column] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string ISLEMTIPIID
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.ISLEMTIPIIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'ISLEMTIPIID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.ISLEMTIPIIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Decimal MIKTAR1
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableDataTable1.MIKTAR1Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'MIKTAR1' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.MIKTAR1Column] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Decimal GIRISMIKTAR1
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableDataTable1.GIRISMIKTAR1Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'GIRISMIKTAR1' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.GIRISMIKTAR1Column] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Decimal CIKISMIKTAR1
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableDataTable1.CIKISMIKTAR1Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'CIKISMIKTAR1' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.CIKISMIKTAR1Column] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Decimal KDVORAN1
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableDataTable1.KDVORAN1Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'KDVORAN1' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.KDVORAN1Column] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Decimal SATIRTUTAR1
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableDataTable1.SATIRTUTAR1Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'SATIRTUTAR1' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.SATIRTUTAR1Column] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsDEPOFISIDNull() => this.IsNull(this.tableDataTable1.DEPOFISIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetDEPOFISIDNull() => this[this.tableDataTable1.DEPOFISIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsPLAKANull() => this.IsNull(this.tableDataTable1.PLAKAColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetPLAKANull() => this[this.tableDataTable1.PLAKAColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsARACACIKLAMANull() => this.IsNull(this.tableDataTable1.ARACACIKLAMAColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetARACACIKLAMANull() => this[this.tableDataTable1.ARACACIKLAMAColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsKODNull() => this.IsNull(this.tableDataTable1.KODColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetKODNull() => this[this.tableDataTable1.KODColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsTARIHNull() => this.IsNull(this.tableDataTable1.TARIHColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetTARIHNull() => this[this.tableDataTable1.TARIHColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMALZEMEIDNull() => this.IsNull(this.tableDataTable1.MALZEMEIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMALZEMEIDNull() => this[this.tableDataTable1.MALZEMEIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMALZEMEGRUPNull() => this.IsNull(this.tableDataTable1.MALZEMEGRUPColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMALZEMEGRUPNull() => this[this.tableDataTable1.MALZEMEGRUPColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMALZACIKLAMANull() => this.IsNull(this.tableDataTable1.MALZACIKLAMAColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMALZACIKLAMANull() => this[this.tableDataTable1.MALZACIKLAMAColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBIRIMIDNull() => this.IsNull(this.tableDataTable1.BIRIMIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBIRIMIDNull() => this[this.tableDataTable1.BIRIMIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMIKTARNull() => this.IsNull(this.tableDataTable1.MIKTARColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMIKTARNull() => this[this.tableDataTable1.MIKTARColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsGIRISMIKTARNull() => this.IsNull(this.tableDataTable1.GIRISMIKTARColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetGIRISMIKTARNull() => this[this.tableDataTable1.GIRISMIKTARColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsCIKISMIKTARNull() => this.IsNull(this.tableDataTable1.CIKISMIKTARColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetCIKISMIKTARNull() => this[this.tableDataTable1.CIKISMIKTARColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsFIYATNull() => this.IsNull(this.tableDataTable1.FIYATColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetFIYATNull() => this[this.tableDataTable1.FIYATColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMALZEMEADINull() => this.IsNull(this.tableDataTable1.MALZEMEADIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMALZEMEADINull() => this[this.tableDataTable1.MALZEMEADIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMALZEMEGRUP2Null() => this.IsNull(this.tableDataTable1.MALZEMEGRUP2Column);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMALZEMEGRUP2Null() => this[this.tableDataTable1.MALZEMEGRUP2Column] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsTUTARNull() => this.IsNull(this.tableDataTable1.TUTARColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetTUTARNull() => this[this.tableDataTable1.TUTARColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsGIRISTUTARNull() => this.IsNull(this.tableDataTable1.GIRISTUTARColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetGIRISTUTARNull() => this[this.tableDataTable1.GIRISTUTARColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsCIKISTUTARNull() => this.IsNull(this.tableDataTable1.CIKISTUTARColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetCIKISTUTARNull() => this[this.tableDataTable1.CIKISTUTARColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsKDVORANNull() => this.IsNull(this.tableDataTable1.KDVORANColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetKDVORANNull() => this[this.tableDataTable1.KDVORANColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsKDVTUTARNull() => this.IsNull(this.tableDataTable1.KDVTUTARColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetKDVTUTARNull() => this[this.tableDataTable1.KDVTUTARColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsSATIRTUTARNull() => this.IsNull(this.tableDataTable1.SATIRTUTARColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetSATIRTUTARNull() => this[this.tableDataTable1.SATIRTUTARColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsGCKODNull() => this.IsNull(this.tableDataTable1.GCKODColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetGCKODNull() => this[this.tableDataTable1.GCKODColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsDEPOIDNull() => this.IsNull(this.tableDataTable1.DEPOIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetDEPOIDNull() => this[this.tableDataTable1.DEPOIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMALZMARKAIDNull() => this.IsNull(this.tableDataTable1.MALZMARKAIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMALZMARKAIDNull() => this[this.tableDataTable1.MALZMARKAIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMALZSERINONull() => this.IsNull(this.tableDataTable1.MALZSERINOColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMALZSERINONull() => this[this.tableDataTable1.MALZSERINOColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMALZURTTARIHNull() => this.IsNull(this.tableDataTable1.MALZURTTARIHColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMALZURTTARIHNull() => this[this.tableDataTable1.MALZURTTARIHColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsExpr1Null() => this.IsNull(this.tableDataTable1.Expr1Column);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetExpr1Null() => this[this.tableDataTable1.Expr1Column] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBOLUMADINull() => this.IsNull(this.tableDataTable1.BOLUMADIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBOLUMADINull() => this[this.tableDataTable1.BOLUMADIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsISLEMTIPIIDNull() => this.IsNull(this.tableDataTable1.ISLEMTIPIIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetISLEMTIPIIDNull() => this[this.tableDataTable1.ISLEMTIPIIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMIKTAR1Null() => this.IsNull(this.tableDataTable1.MIKTAR1Column);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMIKTAR1Null() => this[this.tableDataTable1.MIKTAR1Column] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsGIRISMIKTAR1Null() => this.IsNull(this.tableDataTable1.GIRISMIKTAR1Column);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetGIRISMIKTAR1Null() => this[this.tableDataTable1.GIRISMIKTAR1Column] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsCIKISMIKTAR1Null() => this.IsNull(this.tableDataTable1.CIKISMIKTAR1Column);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetCIKISMIKTAR1Null() => this[this.tableDataTable1.CIKISMIKTAR1Column] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsKDVORAN1Null() => this.IsNull(this.tableDataTable1.KDVORAN1Column);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetKDVORAN1Null() => this[this.tableDataTable1.KDVORAN1Column] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsSATIRTUTAR1Null() => this.IsNull(this.tableDataTable1.SATIRTUTAR1Column);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetSATIRTUTAR1Null() => this[this.tableDataTable1.SATIRTUTAR1Column] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public class DataTable1RowChangeEvent : EventArgs
    {
      private girisfishrktleri.DataTable1Row eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataTable1RowChangeEvent(girisfishrktleri.DataTable1Row row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public girisfishrktleri.DataTable1Row Row => this.eventRow;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataRowAction Action => this.eventAction;
    }
  }
}
