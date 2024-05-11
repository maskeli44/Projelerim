// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.bellDataSet7TableAdapters.TableAdapterManager
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Makina_Ikmal.bellDataSet7TableAdapters
{
  [DesignerCategory("code")]
  [ToolboxItem(true)]
  [Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [HelpKeyword("vs.data.TableAdapterManager")]
  public class TableAdapterManager : Component
  {
    private TableAdapterManager.UpdateOrderOption _updateOrder;
    private FAALIYETTableAdapter _fAALIYETTableAdapter;
    private TAHARACDURUMTableAdapter _tAHARACDURUMTableAdapter;
    private TAHARACHGSTableAdapter _tAHARACHGSTableAdapter;
    private TAHARACTIPITableAdapter _tAHARACTIPITableAdapter;
    private TAHARIZANEDENITableAdapter _tAHARIZANEDENITableAdapter;
    private TAHBAKIMDERECETableAdapter _tAHBAKIMDERECETableAdapter;
    private TAHBAKIMTURUTableAdapter _tAHBAKIMTURUTableAdapter;
    private TAHMODELYILITableAdapter _tAHMODELYILITableAdapter;
    private TBLARACGRUBUTableAdapter _tBLARACGRUBUTableAdapter;
    private TBLARACGRUBU2TableAdapter _tBLARACGRUBU2TableAdapter;
    private TBLARACLARTableAdapter _tBLARACLARTableAdapter;
    private TBLARACMARKATableAdapter _tBLARACMARKATableAdapter;
    private TBLARACMESTKPTableAdapter _tBLARACMESTKPTableAdapter;
    private TBLARACTRFCEZATableAdapter _tBLARACTRFCEZATableAdapter;
    private TBLARACYEDEKALIMTableAdapter _tBLARACYEDEKALIMTableAdapter;
    private TBLARACZIMMETTableAdapter _tBLARACZIMMETTableAdapter;
    private TBLATOLYEBOLUMTableAdapter _tBLATOLYEBOLUMTableAdapter;
    private TBLATOLYEUSTALARTableAdapter _tBLATOLYEUSTALARTableAdapter;
    private TBLAYARLARTableAdapter _tBLAYARLARTableAdapter;
    private TBLBAKIMGRUBUTableAdapter _tBLBAKIMGRUBUTableAdapter;
    private TBLBAKIMTANIMTableAdapter _tBLBAKIMTANIMTableAdapter;
    private TBLBAKIMYERITableAdapter _tBLBAKIMYERITableAdapter;
    private TBLBELDBIRIMLERTableAdapter _tBLBELDBIRIMLERTableAdapter;
    private TBLBELDMUDURLUKTableAdapter _tBLBELDMUDURLUKTableAdapter;
    private TBLBIRIMYETKILILERITableAdapter _tBLBIRIMYETKILILERITableAdapter;
    private TBLDEPOFISTableAdapter _tBLDEPOFISTableAdapter;
    private TBLDEPOFISHRKTTableAdapter _tBLDEPOFISHRKTTableAdapter;
    private TBLFIRMALARTableAdapter _tBLFIRMALARTableAdapter;
    private TBLFIRMASEKTORTableAdapter _tBLFIRMASEKTORTableAdapter;
    private TBLFORMKULLANICITableAdapter _tBLFORMKULLANICITableAdapter;
    private TBLIDARISARTHRKTTableAdapter _tBLIDARISARTHRKTTableAdapter;
    private TBLIDARISARTNAMETableAdapter _tBLIDARISARTNAMETableAdapter;
    private TBLIHALELERTableAdapter _tBLIHALELERTableAdapter;
    private TBLIHLHAKEDISTableAdapter _tBLIHLHAKEDISTableAdapter;
    private TBLISEMIRDURUMTableAdapter _tBLISEMIRDURUMTableAdapter;
    private TBLISEMRITableAdapter _tBLISEMRITableAdapter;
    private TBLISEMRIBAKIMLARTableAdapter _tBLISEMRIBAKIMLARTableAdapter;
    private TBLISEMRIEKRYNLTableAdapter _tBLISEMRIEKRYNLTableAdapter;
    private TBLISLEMTIPITableAdapter _tBLISLEMTIPITableAdapter;
    private TBLKULLANICILARTableAdapter _tBLKULLANICILARTableAdapter;
    private TBLLOGTableAdapter _tBLLOGTableAdapter;
    private TBLMALZBIRIMTableAdapter _tBLMALZBIRIMTableAdapter;
    private TBLMALZBOLUMTableAdapter _tBLMALZBOLUMTableAdapter;
    private TBLMALZDEPOTableAdapter _tBLMALZDEPOTableAdapter;
    private TBLMALZEMELERTableAdapter _tBLMALZEMELERTableAdapter;
    private TBLMALZGRUPTableAdapter _tBLMALZGRUPTableAdapter;
    private TBLMALZGRUP2TableAdapter _tBLMALZGRUP2TableAdapter;
    private TBLMALZKDVTableAdapter _tBLMALZKDVTableAdapter;
    private TBLMALZMARKATableAdapter _tBLMALZMARKATableAdapter;
    private TBLMENUTableAdapter _tBLMENUTableAdapter;
    private TBLPERIZINYILLARITableAdapter _tBLPERIZINYILLARITableAdapter;
    private TBLPERSEGITIMDRMTableAdapter _tBLPERSEGITIMDRMTableAdapter;
    private TBLPERSEHLIYETTableAdapter _tBLPERSEHLIYETTableAdapter;
    private TBLPERSIZINDURUMTableAdapter _tBLPERSIZINDURUMTableAdapter;
    private TBLPERSKURUMGOREVTableAdapter _tBLPERSKURUMGOREVTableAdapter;
    private TBLPERSMESAITableAdapter _tBLPERSMESAITableAdapter;
    private TBLPERSONELTableAdapter _tBLPERSONELTableAdapter;
    private TBLPERSONELDURUMTableAdapter _tBLPERSONELDURUMTableAdapter;
    private TBLPERSONELISTIHDAMDURUMTableAdapter _tBLPERSONELISTIHDAMDURUMTableAdapter;
    private TBLPERSONELIZINTableAdapter _tBLPERSONELIZINTableAdapter;
    private TBLPERSUNVANTableAdapter _tBLPERSUNVANTableAdapter;
    private TBLPERTOPLANTITableAdapter _tBLPERTOPLANTITableAdapter;
    private TBLSABITLERTableAdapter _tBLSABITLERTableAdapter;
    private TBLTALEPTableAdapter _tBLTALEPTableAdapter;
    private TBLTALEPFISTableAdapter _tBLTALEPFISTableAdapter;
    private TBLTALEPFISHRKTTableAdapter _tBLTALEPFISHRKTTableAdapter;
    private TBLTALEPHRKTTableAdapter _tBLTALEPHRKTTableAdapter;
    private TBLTALEPTEKNIKSARTTableAdapter _tBLTALEPTEKNIKSARTTableAdapter;
    private TBLTASITGOREVTableAdapter _tBLTASITGOREVTableAdapter;
    private TBLTASITPERSTableAdapter _tBLTASITPERSTableAdapter;
    private TBLTEKLIFTableAdapter _tBLTEKLIFTableAdapter;
    private TBLTEKLIFHRKTTableAdapter _tBLTEKLIFHRKTTableAdapter;
    private TBLTEKLIFIDARISARTTableAdapter _tBLTEKLIFIDARISARTTableAdapter;
    private TBLTEKNIKSARTTableAdapter _tBLTEKNIKSARTTableAdapter;
    private TBLTEKNIKSARTHRKTTableAdapter _tBLTEKNIKSARTHRKTTableAdapter;
    private TBLVARYOKTableAdapter _tBLVARYOKTableAdapter;
    private TBLYAKITKONTFORMTableAdapter _tBLYAKITKONTFORMTableAdapter;
    private TBLYAZIEKLERITableAdapter _tBLYAZIEKLERITableAdapter;
    private TBLYETKILIMZATableAdapter _tBLYETKILIMZATableAdapter;
    private TBLARACRESIMTableAdapter _tBLARACRESIMTableAdapter;
    private bool _backupDataSetBeforeUpdate;
    private IDbConnection _connection;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public TableAdapterManager.UpdateOrderOption UpdateOrder
    {
      get => this._updateOrder;
      set => this._updateOrder = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public FAALIYETTableAdapter FAALIYETTableAdapter
    {
      get => this._fAALIYETTableAdapter;
      set => this._fAALIYETTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TAHARACDURUMTableAdapter TAHARACDURUMTableAdapter
    {
      get => this._tAHARACDURUMTableAdapter;
      set => this._tAHARACDURUMTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TAHARACHGSTableAdapter TAHARACHGSTableAdapter
    {
      get => this._tAHARACHGSTableAdapter;
      set => this._tAHARACHGSTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TAHARACTIPITableAdapter TAHARACTIPITableAdapter
    {
      get => this._tAHARACTIPITableAdapter;
      set => this._tAHARACTIPITableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TAHARIZANEDENITableAdapter TAHARIZANEDENITableAdapter
    {
      get => this._tAHARIZANEDENITableAdapter;
      set => this._tAHARIZANEDENITableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TAHBAKIMDERECETableAdapter TAHBAKIMDERECETableAdapter
    {
      get => this._tAHBAKIMDERECETableAdapter;
      set => this._tAHBAKIMDERECETableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TAHBAKIMTURUTableAdapter TAHBAKIMTURUTableAdapter
    {
      get => this._tAHBAKIMTURUTableAdapter;
      set => this._tAHBAKIMTURUTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TAHMODELYILITableAdapter TAHMODELYILITableAdapter
    {
      get => this._tAHMODELYILITableAdapter;
      set => this._tAHMODELYILITableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLARACGRUBUTableAdapter TBLARACGRUBUTableAdapter
    {
      get => this._tBLARACGRUBUTableAdapter;
      set => this._tBLARACGRUBUTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLARACGRUBU2TableAdapter TBLARACGRUBU2TableAdapter
    {
      get => this._tBLARACGRUBU2TableAdapter;
      set => this._tBLARACGRUBU2TableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLARACLARTableAdapter TBLARACLARTableAdapter
    {
      get => this._tBLARACLARTableAdapter;
      set => this._tBLARACLARTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLARACMARKATableAdapter TBLARACMARKATableAdapter
    {
      get => this._tBLARACMARKATableAdapter;
      set => this._tBLARACMARKATableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLARACMESTKPTableAdapter TBLARACMESTKPTableAdapter
    {
      get => this._tBLARACMESTKPTableAdapter;
      set => this._tBLARACMESTKPTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLARACTRFCEZATableAdapter TBLARACTRFCEZATableAdapter
    {
      get => this._tBLARACTRFCEZATableAdapter;
      set => this._tBLARACTRFCEZATableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLARACYEDEKALIMTableAdapter TBLARACYEDEKALIMTableAdapter
    {
      get => this._tBLARACYEDEKALIMTableAdapter;
      set => this._tBLARACYEDEKALIMTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLARACZIMMETTableAdapter TBLARACZIMMETTableAdapter
    {
      get => this._tBLARACZIMMETTableAdapter;
      set => this._tBLARACZIMMETTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLATOLYEBOLUMTableAdapter TBLATOLYEBOLUMTableAdapter
    {
      get => this._tBLATOLYEBOLUMTableAdapter;
      set => this._tBLATOLYEBOLUMTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLATOLYEUSTALARTableAdapter TBLATOLYEUSTALARTableAdapter
    {
      get => this._tBLATOLYEUSTALARTableAdapter;
      set => this._tBLATOLYEUSTALARTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLAYARLARTableAdapter TBLAYARLARTableAdapter
    {
      get => this._tBLAYARLARTableAdapter;
      set => this._tBLAYARLARTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLBAKIMGRUBUTableAdapter TBLBAKIMGRUBUTableAdapter
    {
      get => this._tBLBAKIMGRUBUTableAdapter;
      set => this._tBLBAKIMGRUBUTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLBAKIMTANIMTableAdapter TBLBAKIMTANIMTableAdapter
    {
      get => this._tBLBAKIMTANIMTableAdapter;
      set => this._tBLBAKIMTANIMTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLBAKIMYERITableAdapter TBLBAKIMYERITableAdapter
    {
      get => this._tBLBAKIMYERITableAdapter;
      set => this._tBLBAKIMYERITableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLBELDBIRIMLERTableAdapter TBLBELDBIRIMLERTableAdapter
    {
      get => this._tBLBELDBIRIMLERTableAdapter;
      set => this._tBLBELDBIRIMLERTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLBELDMUDURLUKTableAdapter TBLBELDMUDURLUKTableAdapter
    {
      get => this._tBLBELDMUDURLUKTableAdapter;
      set => this._tBLBELDMUDURLUKTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLBIRIMYETKILILERITableAdapter TBLBIRIMYETKILILERITableAdapter
    {
      get => this._tBLBIRIMYETKILILERITableAdapter;
      set => this._tBLBIRIMYETKILILERITableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLDEPOFISTableAdapter TBLDEPOFISTableAdapter
    {
      get => this._tBLDEPOFISTableAdapter;
      set => this._tBLDEPOFISTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLDEPOFISHRKTTableAdapter TBLDEPOFISHRKTTableAdapter
    {
      get => this._tBLDEPOFISHRKTTableAdapter;
      set => this._tBLDEPOFISHRKTTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLFIRMALARTableAdapter TBLFIRMALARTableAdapter
    {
      get => this._tBLFIRMALARTableAdapter;
      set => this._tBLFIRMALARTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLFIRMASEKTORTableAdapter TBLFIRMASEKTORTableAdapter
    {
      get => this._tBLFIRMASEKTORTableAdapter;
      set => this._tBLFIRMASEKTORTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLFORMKULLANICITableAdapter TBLFORMKULLANICITableAdapter
    {
      get => this._tBLFORMKULLANICITableAdapter;
      set => this._tBLFORMKULLANICITableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLIDARISARTHRKTTableAdapter TBLIDARISARTHRKTTableAdapter
    {
      get => this._tBLIDARISARTHRKTTableAdapter;
      set => this._tBLIDARISARTHRKTTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLIDARISARTNAMETableAdapter TBLIDARISARTNAMETableAdapter
    {
      get => this._tBLIDARISARTNAMETableAdapter;
      set => this._tBLIDARISARTNAMETableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLIHALELERTableAdapter TBLIHALELERTableAdapter
    {
      get => this._tBLIHALELERTableAdapter;
      set => this._tBLIHALELERTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLIHLHAKEDISTableAdapter TBLIHLHAKEDISTableAdapter
    {
      get => this._tBLIHLHAKEDISTableAdapter;
      set => this._tBLIHLHAKEDISTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLISEMIRDURUMTableAdapter TBLISEMIRDURUMTableAdapter
    {
      get => this._tBLISEMIRDURUMTableAdapter;
      set => this._tBLISEMIRDURUMTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLISEMRITableAdapter TBLISEMRITableAdapter
    {
      get => this._tBLISEMRITableAdapter;
      set => this._tBLISEMRITableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLISEMRIBAKIMLARTableAdapter TBLISEMRIBAKIMLARTableAdapter
    {
      get => this._tBLISEMRIBAKIMLARTableAdapter;
      set => this._tBLISEMRIBAKIMLARTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLISEMRIEKRYNLTableAdapter TBLISEMRIEKRYNLTableAdapter
    {
      get => this._tBLISEMRIEKRYNLTableAdapter;
      set => this._tBLISEMRIEKRYNLTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLISLEMTIPITableAdapter TBLISLEMTIPITableAdapter
    {
      get => this._tBLISLEMTIPITableAdapter;
      set => this._tBLISLEMTIPITableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLKULLANICILARTableAdapter TBLKULLANICILARTableAdapter
    {
      get => this._tBLKULLANICILARTableAdapter;
      set => this._tBLKULLANICILARTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLLOGTableAdapter TBLLOGTableAdapter
    {
      get => this._tBLLOGTableAdapter;
      set => this._tBLLOGTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLMALZBIRIMTableAdapter TBLMALZBIRIMTableAdapter
    {
      get => this._tBLMALZBIRIMTableAdapter;
      set => this._tBLMALZBIRIMTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLMALZBOLUMTableAdapter TBLMALZBOLUMTableAdapter
    {
      get => this._tBLMALZBOLUMTableAdapter;
      set => this._tBLMALZBOLUMTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLMALZDEPOTableAdapter TBLMALZDEPOTableAdapter
    {
      get => this._tBLMALZDEPOTableAdapter;
      set => this._tBLMALZDEPOTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLMALZEMELERTableAdapter TBLMALZEMELERTableAdapter
    {
      get => this._tBLMALZEMELERTableAdapter;
      set => this._tBLMALZEMELERTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLMALZGRUPTableAdapter TBLMALZGRUPTableAdapter
    {
      get => this._tBLMALZGRUPTableAdapter;
      set => this._tBLMALZGRUPTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLMALZGRUP2TableAdapter TBLMALZGRUP2TableAdapter
    {
      get => this._tBLMALZGRUP2TableAdapter;
      set => this._tBLMALZGRUP2TableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLMALZKDVTableAdapter TBLMALZKDVTableAdapter
    {
      get => this._tBLMALZKDVTableAdapter;
      set => this._tBLMALZKDVTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLMALZMARKATableAdapter TBLMALZMARKATableAdapter
    {
      get => this._tBLMALZMARKATableAdapter;
      set => this._tBLMALZMARKATableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLMENUTableAdapter TBLMENUTableAdapter
    {
      get => this._tBLMENUTableAdapter;
      set => this._tBLMENUTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLPERIZINYILLARITableAdapter TBLPERIZINYILLARITableAdapter
    {
      get => this._tBLPERIZINYILLARITableAdapter;
      set => this._tBLPERIZINYILLARITableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLPERSEGITIMDRMTableAdapter TBLPERSEGITIMDRMTableAdapter
    {
      get => this._tBLPERSEGITIMDRMTableAdapter;
      set => this._tBLPERSEGITIMDRMTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLPERSEHLIYETTableAdapter TBLPERSEHLIYETTableAdapter
    {
      get => this._tBLPERSEHLIYETTableAdapter;
      set => this._tBLPERSEHLIYETTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLPERSIZINDURUMTableAdapter TBLPERSIZINDURUMTableAdapter
    {
      get => this._tBLPERSIZINDURUMTableAdapter;
      set => this._tBLPERSIZINDURUMTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLPERSKURUMGOREVTableAdapter TBLPERSKURUMGOREVTableAdapter
    {
      get => this._tBLPERSKURUMGOREVTableAdapter;
      set => this._tBLPERSKURUMGOREVTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLPERSMESAITableAdapter TBLPERSMESAITableAdapter
    {
      get => this._tBLPERSMESAITableAdapter;
      set => this._tBLPERSMESAITableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLPERSONELTableAdapter TBLPERSONELTableAdapter
    {
      get => this._tBLPERSONELTableAdapter;
      set => this._tBLPERSONELTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLPERSONELDURUMTableAdapter TBLPERSONELDURUMTableAdapter
    {
      get => this._tBLPERSONELDURUMTableAdapter;
      set => this._tBLPERSONELDURUMTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLPERSONELISTIHDAMDURUMTableAdapter TBLPERSONELISTIHDAMDURUMTableAdapter
    {
      get => this._tBLPERSONELISTIHDAMDURUMTableAdapter;
      set => this._tBLPERSONELISTIHDAMDURUMTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLPERSONELIZINTableAdapter TBLPERSONELIZINTableAdapter
    {
      get => this._tBLPERSONELIZINTableAdapter;
      set => this._tBLPERSONELIZINTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLPERSUNVANTableAdapter TBLPERSUNVANTableAdapter
    {
      get => this._tBLPERSUNVANTableAdapter;
      set => this._tBLPERSUNVANTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLPERTOPLANTITableAdapter TBLPERTOPLANTITableAdapter
    {
      get => this._tBLPERTOPLANTITableAdapter;
      set => this._tBLPERTOPLANTITableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLSABITLERTableAdapter TBLSABITLERTableAdapter
    {
      get => this._tBLSABITLERTableAdapter;
      set => this._tBLSABITLERTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLTALEPTableAdapter TBLTALEPTableAdapter
    {
      get => this._tBLTALEPTableAdapter;
      set => this._tBLTALEPTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLTALEPFISTableAdapter TBLTALEPFISTableAdapter
    {
      get => this._tBLTALEPFISTableAdapter;
      set => this._tBLTALEPFISTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLTALEPFISHRKTTableAdapter TBLTALEPFISHRKTTableAdapter
    {
      get => this._tBLTALEPFISHRKTTableAdapter;
      set => this._tBLTALEPFISHRKTTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLTALEPHRKTTableAdapter TBLTALEPHRKTTableAdapter
    {
      get => this._tBLTALEPHRKTTableAdapter;
      set => this._tBLTALEPHRKTTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLTALEPTEKNIKSARTTableAdapter TBLTALEPTEKNIKSARTTableAdapter
    {
      get => this._tBLTALEPTEKNIKSARTTableAdapter;
      set => this._tBLTALEPTEKNIKSARTTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLTASITGOREVTableAdapter TBLTASITGOREVTableAdapter
    {
      get => this._tBLTASITGOREVTableAdapter;
      set => this._tBLTASITGOREVTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLTASITPERSTableAdapter TBLTASITPERSTableAdapter
    {
      get => this._tBLTASITPERSTableAdapter;
      set => this._tBLTASITPERSTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLTEKLIFTableAdapter TBLTEKLIFTableAdapter
    {
      get => this._tBLTEKLIFTableAdapter;
      set => this._tBLTEKLIFTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLTEKLIFHRKTTableAdapter TBLTEKLIFHRKTTableAdapter
    {
      get => this._tBLTEKLIFHRKTTableAdapter;
      set => this._tBLTEKLIFHRKTTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLTEKLIFIDARISARTTableAdapter TBLTEKLIFIDARISARTTableAdapter
    {
      get => this._tBLTEKLIFIDARISARTTableAdapter;
      set => this._tBLTEKLIFIDARISARTTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLTEKNIKSARTTableAdapter TBLTEKNIKSARTTableAdapter
    {
      get => this._tBLTEKNIKSARTTableAdapter;
      set => this._tBLTEKNIKSARTTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLTEKNIKSARTHRKTTableAdapter TBLTEKNIKSARTHRKTTableAdapter
    {
      get => this._tBLTEKNIKSARTHRKTTableAdapter;
      set => this._tBLTEKNIKSARTHRKTTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLVARYOKTableAdapter TBLVARYOKTableAdapter
    {
      get => this._tBLVARYOKTableAdapter;
      set => this._tBLVARYOKTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLYAKITKONTFORMTableAdapter TBLYAKITKONTFORMTableAdapter
    {
      get => this._tBLYAKITKONTFORMTableAdapter;
      set => this._tBLYAKITKONTFORMTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLYAZIEKLERITableAdapter TBLYAZIEKLERITableAdapter
    {
      get => this._tBLYAZIEKLERITableAdapter;
      set => this._tBLYAZIEKLERITableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLYETKILIMZATableAdapter TBLYETKILIMZATableAdapter
    {
      get => this._tBLYETKILIMZATableAdapter;
      set => this._tBLYETKILIMZATableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public TBLARACRESIMTableAdapter TBLARACRESIMTableAdapter
    {
      get => this._tBLARACRESIMTableAdapter;
      set => this._tBLARACRESIMTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool BackupDataSetBeforeUpdate
    {
      get => this._backupDataSetBeforeUpdate;
      set => this._backupDataSetBeforeUpdate = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public IDbConnection Connection
    {
      get
      {
        if (this._connection != null)
          return this._connection;
        if (this._fAALIYETTableAdapter != null && this._fAALIYETTableAdapter.Connection != null)
          return (IDbConnection) this._fAALIYETTableAdapter.Connection;
        if (this._tAHARACDURUMTableAdapter != null && this._tAHARACDURUMTableAdapter.Connection != null)
          return (IDbConnection) this._tAHARACDURUMTableAdapter.Connection;
        if (this._tAHARACHGSTableAdapter != null && this._tAHARACHGSTableAdapter.Connection != null)
          return (IDbConnection) this._tAHARACHGSTableAdapter.Connection;
        if (this._tAHARACTIPITableAdapter != null && this._tAHARACTIPITableAdapter.Connection != null)
          return (IDbConnection) this._tAHARACTIPITableAdapter.Connection;
        if (this._tAHARIZANEDENITableAdapter != null && this._tAHARIZANEDENITableAdapter.Connection != null)
          return (IDbConnection) this._tAHARIZANEDENITableAdapter.Connection;
        if (this._tAHBAKIMDERECETableAdapter != null && this._tAHBAKIMDERECETableAdapter.Connection != null)
          return (IDbConnection) this._tAHBAKIMDERECETableAdapter.Connection;
        if (this._tAHBAKIMTURUTableAdapter != null && this._tAHBAKIMTURUTableAdapter.Connection != null)
          return (IDbConnection) this._tAHBAKIMTURUTableAdapter.Connection;
        if (this._tAHMODELYILITableAdapter != null && this._tAHMODELYILITableAdapter.Connection != null)
          return (IDbConnection) this._tAHMODELYILITableAdapter.Connection;
        if (this._tBLARACGRUBUTableAdapter != null && this._tBLARACGRUBUTableAdapter.Connection != null)
          return (IDbConnection) this._tBLARACGRUBUTableAdapter.Connection;
        if (this._tBLARACGRUBU2TableAdapter != null && this._tBLARACGRUBU2TableAdapter.Connection != null)
          return (IDbConnection) this._tBLARACGRUBU2TableAdapter.Connection;
        if (this._tBLARACLARTableAdapter != null && this._tBLARACLARTableAdapter.Connection != null)
          return (IDbConnection) this._tBLARACLARTableAdapter.Connection;
        if (this._tBLARACMARKATableAdapter != null && this._tBLARACMARKATableAdapter.Connection != null)
          return (IDbConnection) this._tBLARACMARKATableAdapter.Connection;
        if (this._tBLARACMESTKPTableAdapter != null && this._tBLARACMESTKPTableAdapter.Connection != null)
          return (IDbConnection) this._tBLARACMESTKPTableAdapter.Connection;
        if (this._tBLARACTRFCEZATableAdapter != null && this._tBLARACTRFCEZATableAdapter.Connection != null)
          return (IDbConnection) this._tBLARACTRFCEZATableAdapter.Connection;
        if (this._tBLARACYEDEKALIMTableAdapter != null && this._tBLARACYEDEKALIMTableAdapter.Connection != null)
          return (IDbConnection) this._tBLARACYEDEKALIMTableAdapter.Connection;
        if (this._tBLARACZIMMETTableAdapter != null && this._tBLARACZIMMETTableAdapter.Connection != null)
          return (IDbConnection) this._tBLARACZIMMETTableAdapter.Connection;
        if (this._tBLATOLYEBOLUMTableAdapter != null && this._tBLATOLYEBOLUMTableAdapter.Connection != null)
          return (IDbConnection) this._tBLATOLYEBOLUMTableAdapter.Connection;
        if (this._tBLATOLYEUSTALARTableAdapter != null && this._tBLATOLYEUSTALARTableAdapter.Connection != null)
          return (IDbConnection) this._tBLATOLYEUSTALARTableAdapter.Connection;
        if (this._tBLAYARLARTableAdapter != null && this._tBLAYARLARTableAdapter.Connection != null)
          return (IDbConnection) this._tBLAYARLARTableAdapter.Connection;
        if (this._tBLBAKIMGRUBUTableAdapter != null && this._tBLBAKIMGRUBUTableAdapter.Connection != null)
          return (IDbConnection) this._tBLBAKIMGRUBUTableAdapter.Connection;
        if (this._tBLBAKIMTANIMTableAdapter != null && this._tBLBAKIMTANIMTableAdapter.Connection != null)
          return (IDbConnection) this._tBLBAKIMTANIMTableAdapter.Connection;
        if (this._tBLBAKIMYERITableAdapter != null && this._tBLBAKIMYERITableAdapter.Connection != null)
          return (IDbConnection) this._tBLBAKIMYERITableAdapter.Connection;
        if (this._tBLBELDBIRIMLERTableAdapter != null && this._tBLBELDBIRIMLERTableAdapter.Connection != null)
          return (IDbConnection) this._tBLBELDBIRIMLERTableAdapter.Connection;
        if (this._tBLBELDMUDURLUKTableAdapter != null && this._tBLBELDMUDURLUKTableAdapter.Connection != null)
          return (IDbConnection) this._tBLBELDMUDURLUKTableAdapter.Connection;
        if (this._tBLBIRIMYETKILILERITableAdapter != null && this._tBLBIRIMYETKILILERITableAdapter.Connection != null)
          return (IDbConnection) this._tBLBIRIMYETKILILERITableAdapter.Connection;
        if (this._tBLDEPOFISTableAdapter != null && this._tBLDEPOFISTableAdapter.Connection != null)
          return (IDbConnection) this._tBLDEPOFISTableAdapter.Connection;
        if (this._tBLDEPOFISHRKTTableAdapter != null && this._tBLDEPOFISHRKTTableAdapter.Connection != null)
          return (IDbConnection) this._tBLDEPOFISHRKTTableAdapter.Connection;
        if (this._tBLFIRMALARTableAdapter != null && this._tBLFIRMALARTableAdapter.Connection != null)
          return (IDbConnection) this._tBLFIRMALARTableAdapter.Connection;
        if (this._tBLFIRMASEKTORTableAdapter != null && this._tBLFIRMASEKTORTableAdapter.Connection != null)
          return (IDbConnection) this._tBLFIRMASEKTORTableAdapter.Connection;
        if (this._tBLFORMKULLANICITableAdapter != null && this._tBLFORMKULLANICITableAdapter.Connection != null)
          return (IDbConnection) this._tBLFORMKULLANICITableAdapter.Connection;
        if (this._tBLIDARISARTHRKTTableAdapter != null && this._tBLIDARISARTHRKTTableAdapter.Connection != null)
          return (IDbConnection) this._tBLIDARISARTHRKTTableAdapter.Connection;
        if (this._tBLIDARISARTNAMETableAdapter != null && this._tBLIDARISARTNAMETableAdapter.Connection != null)
          return (IDbConnection) this._tBLIDARISARTNAMETableAdapter.Connection;
        if (this._tBLIHALELERTableAdapter != null && this._tBLIHALELERTableAdapter.Connection != null)
          return (IDbConnection) this._tBLIHALELERTableAdapter.Connection;
        if (this._tBLIHLHAKEDISTableAdapter != null && this._tBLIHLHAKEDISTableAdapter.Connection != null)
          return (IDbConnection) this._tBLIHLHAKEDISTableAdapter.Connection;
        if (this._tBLISEMIRDURUMTableAdapter != null && this._tBLISEMIRDURUMTableAdapter.Connection != null)
          return (IDbConnection) this._tBLISEMIRDURUMTableAdapter.Connection;
        if (this._tBLISEMRITableAdapter != null && this._tBLISEMRITableAdapter.Connection != null)
          return (IDbConnection) this._tBLISEMRITableAdapter.Connection;
        if (this._tBLISEMRIBAKIMLARTableAdapter != null && this._tBLISEMRIBAKIMLARTableAdapter.Connection != null)
          return (IDbConnection) this._tBLISEMRIBAKIMLARTableAdapter.Connection;
        if (this._tBLISEMRIEKRYNLTableAdapter != null && this._tBLISEMRIEKRYNLTableAdapter.Connection != null)
          return (IDbConnection) this._tBLISEMRIEKRYNLTableAdapter.Connection;
        if (this._tBLISLEMTIPITableAdapter != null && this._tBLISLEMTIPITableAdapter.Connection != null)
          return (IDbConnection) this._tBLISLEMTIPITableAdapter.Connection;
        if (this._tBLKULLANICILARTableAdapter != null && this._tBLKULLANICILARTableAdapter.Connection != null)
          return (IDbConnection) this._tBLKULLANICILARTableAdapter.Connection;
        if (this._tBLLOGTableAdapter != null && this._tBLLOGTableAdapter.Connection != null)
          return (IDbConnection) this._tBLLOGTableAdapter.Connection;
        if (this._tBLMALZBIRIMTableAdapter != null && this._tBLMALZBIRIMTableAdapter.Connection != null)
          return (IDbConnection) this._tBLMALZBIRIMTableAdapter.Connection;
        if (this._tBLMALZBOLUMTableAdapter != null && this._tBLMALZBOLUMTableAdapter.Connection != null)
          return (IDbConnection) this._tBLMALZBOLUMTableAdapter.Connection;
        if (this._tBLMALZDEPOTableAdapter != null && this._tBLMALZDEPOTableAdapter.Connection != null)
          return (IDbConnection) this._tBLMALZDEPOTableAdapter.Connection;
        if (this._tBLMALZEMELERTableAdapter != null && this._tBLMALZEMELERTableAdapter.Connection != null)
          return (IDbConnection) this._tBLMALZEMELERTableAdapter.Connection;
        if (this._tBLMALZGRUPTableAdapter != null && this._tBLMALZGRUPTableAdapter.Connection != null)
          return (IDbConnection) this._tBLMALZGRUPTableAdapter.Connection;
        if (this._tBLMALZGRUP2TableAdapter != null && this._tBLMALZGRUP2TableAdapter.Connection != null)
          return (IDbConnection) this._tBLMALZGRUP2TableAdapter.Connection;
        if (this._tBLMALZKDVTableAdapter != null && this._tBLMALZKDVTableAdapter.Connection != null)
          return (IDbConnection) this._tBLMALZKDVTableAdapter.Connection;
        if (this._tBLMALZMARKATableAdapter != null && this._tBLMALZMARKATableAdapter.Connection != null)
          return (IDbConnection) this._tBLMALZMARKATableAdapter.Connection;
        if (this._tBLMENUTableAdapter != null && this._tBLMENUTableAdapter.Connection != null)
          return (IDbConnection) this._tBLMENUTableAdapter.Connection;
        if (this._tBLPERIZINYILLARITableAdapter != null && this._tBLPERIZINYILLARITableAdapter.Connection != null)
          return (IDbConnection) this._tBLPERIZINYILLARITableAdapter.Connection;
        if (this._tBLPERSEGITIMDRMTableAdapter != null && this._tBLPERSEGITIMDRMTableAdapter.Connection != null)
          return (IDbConnection) this._tBLPERSEGITIMDRMTableAdapter.Connection;
        if (this._tBLPERSEHLIYETTableAdapter != null && this._tBLPERSEHLIYETTableAdapter.Connection != null)
          return (IDbConnection) this._tBLPERSEHLIYETTableAdapter.Connection;
        if (this._tBLPERSIZINDURUMTableAdapter != null && this._tBLPERSIZINDURUMTableAdapter.Connection != null)
          return (IDbConnection) this._tBLPERSIZINDURUMTableAdapter.Connection;
        if (this._tBLPERSKURUMGOREVTableAdapter != null && this._tBLPERSKURUMGOREVTableAdapter.Connection != null)
          return (IDbConnection) this._tBLPERSKURUMGOREVTableAdapter.Connection;
        if (this._tBLPERSMESAITableAdapter != null && this._tBLPERSMESAITableAdapter.Connection != null)
          return (IDbConnection) this._tBLPERSMESAITableAdapter.Connection;
        if (this._tBLPERSONELTableAdapter != null && this._tBLPERSONELTableAdapter.Connection != null)
          return (IDbConnection) this._tBLPERSONELTableAdapter.Connection;
        if (this._tBLPERSONELDURUMTableAdapter != null && this._tBLPERSONELDURUMTableAdapter.Connection != null)
          return (IDbConnection) this._tBLPERSONELDURUMTableAdapter.Connection;
        if (this._tBLPERSONELISTIHDAMDURUMTableAdapter != null && this._tBLPERSONELISTIHDAMDURUMTableAdapter.Connection != null)
          return (IDbConnection) this._tBLPERSONELISTIHDAMDURUMTableAdapter.Connection;
        if (this._tBLPERSONELIZINTableAdapter != null && this._tBLPERSONELIZINTableAdapter.Connection != null)
          return (IDbConnection) this._tBLPERSONELIZINTableAdapter.Connection;
        if (this._tBLPERSUNVANTableAdapter != null && this._tBLPERSUNVANTableAdapter.Connection != null)
          return (IDbConnection) this._tBLPERSUNVANTableAdapter.Connection;
        if (this._tBLPERTOPLANTITableAdapter != null && this._tBLPERTOPLANTITableAdapter.Connection != null)
          return (IDbConnection) this._tBLPERTOPLANTITableAdapter.Connection;
        if (this._tBLSABITLERTableAdapter != null && this._tBLSABITLERTableAdapter.Connection != null)
          return (IDbConnection) this._tBLSABITLERTableAdapter.Connection;
        if (this._tBLTALEPTableAdapter != null && this._tBLTALEPTableAdapter.Connection != null)
          return (IDbConnection) this._tBLTALEPTableAdapter.Connection;
        if (this._tBLTALEPFISTableAdapter != null && this._tBLTALEPFISTableAdapter.Connection != null)
          return (IDbConnection) this._tBLTALEPFISTableAdapter.Connection;
        if (this._tBLTALEPFISHRKTTableAdapter != null && this._tBLTALEPFISHRKTTableAdapter.Connection != null)
          return (IDbConnection) this._tBLTALEPFISHRKTTableAdapter.Connection;
        if (this._tBLTALEPHRKTTableAdapter != null && this._tBLTALEPHRKTTableAdapter.Connection != null)
          return (IDbConnection) this._tBLTALEPHRKTTableAdapter.Connection;
        if (this._tBLTALEPTEKNIKSARTTableAdapter != null && this._tBLTALEPTEKNIKSARTTableAdapter.Connection != null)
          return (IDbConnection) this._tBLTALEPTEKNIKSARTTableAdapter.Connection;
        if (this._tBLTASITGOREVTableAdapter != null && this._tBLTASITGOREVTableAdapter.Connection != null)
          return (IDbConnection) this._tBLTASITGOREVTableAdapter.Connection;
        if (this._tBLTASITPERSTableAdapter != null && this._tBLTASITPERSTableAdapter.Connection != null)
          return (IDbConnection) this._tBLTASITPERSTableAdapter.Connection;
        if (this._tBLTEKLIFTableAdapter != null && this._tBLTEKLIFTableAdapter.Connection != null)
          return (IDbConnection) this._tBLTEKLIFTableAdapter.Connection;
        if (this._tBLTEKLIFHRKTTableAdapter != null && this._tBLTEKLIFHRKTTableAdapter.Connection != null)
          return (IDbConnection) this._tBLTEKLIFHRKTTableAdapter.Connection;
        if (this._tBLTEKLIFIDARISARTTableAdapter != null && this._tBLTEKLIFIDARISARTTableAdapter.Connection != null)
          return (IDbConnection) this._tBLTEKLIFIDARISARTTableAdapter.Connection;
        if (this._tBLTEKNIKSARTTableAdapter != null && this._tBLTEKNIKSARTTableAdapter.Connection != null)
          return (IDbConnection) this._tBLTEKNIKSARTTableAdapter.Connection;
        if (this._tBLTEKNIKSARTHRKTTableAdapter != null && this._tBLTEKNIKSARTHRKTTableAdapter.Connection != null)
          return (IDbConnection) this._tBLTEKNIKSARTHRKTTableAdapter.Connection;
        if (this._tBLVARYOKTableAdapter != null && this._tBLVARYOKTableAdapter.Connection != null)
          return (IDbConnection) this._tBLVARYOKTableAdapter.Connection;
        if (this._tBLYAKITKONTFORMTableAdapter != null && this._tBLYAKITKONTFORMTableAdapter.Connection != null)
          return (IDbConnection) this._tBLYAKITKONTFORMTableAdapter.Connection;
        if (this._tBLYAZIEKLERITableAdapter != null && this._tBLYAZIEKLERITableAdapter.Connection != null)
          return (IDbConnection) this._tBLYAZIEKLERITableAdapter.Connection;
        if (this._tBLYETKILIMZATableAdapter != null && this._tBLYETKILIMZATableAdapter.Connection != null)
          return (IDbConnection) this._tBLYETKILIMZATableAdapter.Connection;
        return this._tBLARACRESIMTableAdapter != null && this._tBLARACRESIMTableAdapter.Connection != null ? (IDbConnection) this._tBLARACRESIMTableAdapter.Connection : (IDbConnection) null;
      }
      set => this._connection = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int TableAdapterInstanceCount
    {
      get
      {
        int adapterInstanceCount = 0;
        if (this._fAALIYETTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tAHARACDURUMTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tAHARACHGSTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tAHARACTIPITableAdapter != null)
          ++adapterInstanceCount;
        if (this._tAHARIZANEDENITableAdapter != null)
          ++adapterInstanceCount;
        if (this._tAHBAKIMDERECETableAdapter != null)
          ++adapterInstanceCount;
        if (this._tAHBAKIMTURUTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tAHMODELYILITableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLARACGRUBUTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLARACGRUBU2TableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLARACLARTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLARACMARKATableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLARACMESTKPTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLARACTRFCEZATableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLARACYEDEKALIMTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLARACZIMMETTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLATOLYEBOLUMTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLATOLYEUSTALARTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLAYARLARTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLBAKIMGRUBUTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLBAKIMTANIMTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLBAKIMYERITableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLBELDBIRIMLERTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLBELDMUDURLUKTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLBIRIMYETKILILERITableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLDEPOFISTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLDEPOFISHRKTTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLFIRMALARTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLFIRMASEKTORTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLFORMKULLANICITableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLIDARISARTHRKTTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLIDARISARTNAMETableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLIHALELERTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLIHLHAKEDISTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLISEMIRDURUMTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLISEMRITableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLISEMRIBAKIMLARTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLISEMRIEKRYNLTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLISLEMTIPITableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLKULLANICILARTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLLOGTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLMALZBIRIMTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLMALZBOLUMTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLMALZDEPOTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLMALZEMELERTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLMALZGRUPTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLMALZGRUP2TableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLMALZKDVTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLMALZMARKATableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLMENUTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLPERIZINYILLARITableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLPERSEGITIMDRMTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLPERSEHLIYETTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLPERSIZINDURUMTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLPERSKURUMGOREVTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLPERSMESAITableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLPERSONELTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLPERSONELDURUMTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLPERSONELISTIHDAMDURUMTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLPERSONELIZINTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLPERSUNVANTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLPERTOPLANTITableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLSABITLERTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLTALEPTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLTALEPFISTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLTALEPFISHRKTTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLTALEPHRKTTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLTALEPTEKNIKSARTTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLTASITGOREVTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLTASITPERSTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLTEKLIFTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLTEKLIFHRKTTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLTEKLIFIDARISARTTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLTEKNIKSARTTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLTEKNIKSARTHRKTTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLVARYOKTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLYAKITKONTFORMTableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLYAZIEKLERITableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLYETKILIMZATableAdapter != null)
          ++adapterInstanceCount;
        if (this._tBLARACRESIMTableAdapter != null)
          ++adapterInstanceCount;
        return adapterInstanceCount;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private int UpdateUpdatedRows(
      bellDataSet7 dataSet,
      List<DataRow> allChangedRows,
      List<DataRow> allAddedRows)
    {
      int num = 0;
      if (this._fAALIYETTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.FAALIYET.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._fAALIYETTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLPERSONELDURUMTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLPERSONELDURUM.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLPERSONELDURUMTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLPERSONELTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLPERSONEL.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLPERSONELTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLPERSMESAITableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLPERSMESAI.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLPERSMESAITableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLPERSKURUMGOREVTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLPERSKURUMGOREV.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLPERSKURUMGOREVTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLPERSIZINDURUMTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLPERSIZINDURUM.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLPERSIZINDURUMTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLPERSEHLIYETTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLPERSEHLIYET.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLPERSEHLIYETTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLPERSEGITIMDRMTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLPERSEGITIMDRM.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLPERSEGITIMDRMTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLPERSONELISTIHDAMDURUMTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLPERSONELISTIHDAMDURUM.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLPERSONELISTIHDAMDURUMTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLPERIZINYILLARITableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLPERIZINYILLARI.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLPERIZINYILLARITableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLMALZMARKATableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLMALZMARKA.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLMALZMARKATableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLMALZKDVTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLMALZKDV.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLMALZKDVTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLMALZGRUP2TableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLMALZGRUP2.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLMALZGRUP2TableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLMALZGRUPTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLMALZGRUP.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLMALZGRUPTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLMALZEMELERTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLMALZEMELER.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLMALZEMELERTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLMALZDEPOTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLMALZDEPO.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLMALZDEPOTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLMALZBOLUMTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLMALZBOLUM.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLMALZBOLUMTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLMENUTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLMENU.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLMENUTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLMALZBIRIMTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLMALZBIRIM.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLMALZBIRIMTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLPERSONELIZINTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLPERSONELIZIN.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLPERSONELIZINTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLPERTOPLANTITableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLPERTOPLANTI.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLPERTOPLANTITableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLYAZIEKLERITableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLYAZIEKLERI.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLYAZIEKLERITableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLYAKITKONTFORMTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLYAKITKONTFORM.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLYAKITKONTFORMTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLVARYOKTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLVARYOK.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLVARYOKTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLTEKNIKSARTHRKTTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLTEKNIKSARTHRKT.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLTEKNIKSARTHRKTTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLTEKNIKSARTTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLTEKNIKSART.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLTEKNIKSARTTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLTEKLIFIDARISARTTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLTEKLIFIDARISART.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLTEKLIFIDARISARTTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLTEKLIFHRKTTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLTEKLIFHRKT.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLTEKLIFHRKTTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLPERSUNVANTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLPERSUNVAN.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLPERSUNVANTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLTEKLIFTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLTEKLIF.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLTEKLIFTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLTASITGOREVTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLTASITGOREV.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLTASITGOREVTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLTALEPTEKNIKSARTTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLTALEPTEKNIKSART.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLTALEPTEKNIKSARTTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLTALEPHRKTTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLTALEPHRKT.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLTALEPHRKTTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLTALEPFISHRKTTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLTALEPFISHRKT.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLTALEPFISHRKTTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLTALEPFISTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLTALEPFIS.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLTALEPFISTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLTALEPTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLTALEP.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLTALEPTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLSABITLERTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLSABITLER.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLSABITLERTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLTASITPERSTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLTASITPERS.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLTASITPERSTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLLOGTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLLOG.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLLOGTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLKULLANICILARTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLKULLANICILAR.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLKULLANICILARTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLISLEMTIPITableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLISLEMTIPI.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLISLEMTIPITableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLATOLYEBOLUMTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLATOLYEBOLUM.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLATOLYEBOLUMTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLARACZIMMETTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLARACZIMMET.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLARACZIMMETTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLARACYEDEKALIMTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLARACYEDEKALIM.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLARACYEDEKALIMTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLARACTRFCEZATableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLARACTRFCEZA.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLARACTRFCEZATableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLARACMESTKPTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLARACMESTKP.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLARACMESTKPTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLARACMARKATableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLARACMARKA.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLARACMARKATableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLARACLARTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLARACLAR.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLARACLARTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLATOLYEUSTALARTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLATOLYEUSTALAR.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLATOLYEUSTALARTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLARACGRUBU2TableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLARACGRUBU2.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLARACGRUBU2TableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tAHMODELYILITableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TAHMODELYILI.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tAHMODELYILITableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tAHBAKIMTURUTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TAHBAKIMTURU.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tAHBAKIMTURUTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tAHBAKIMDERECETableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TAHBAKIMDERECE.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tAHBAKIMDERECETableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tAHARIZANEDENITableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TAHARIZANEDENI.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tAHARIZANEDENITableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tAHARACTIPITableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TAHARACTIPI.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tAHARACTIPITableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tAHARACHGSTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TAHARACHGS.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tAHARACHGSTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tAHARACDURUMTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TAHARACDURUM.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tAHARACDURUMTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLARACGRUBUTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLARACGRUBU.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLARACGRUBUTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLAYARLARTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLAYARLAR.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLAYARLARTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLBAKIMGRUBUTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLBAKIMGRUBU.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLBAKIMGRUBUTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLBAKIMTANIMTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLBAKIMTANIM.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLBAKIMTANIMTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLISEMRIEKRYNLTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLISEMRIEKRYNL.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLISEMRIEKRYNLTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLISEMRIBAKIMLARTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLISEMRIBAKIMLAR.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLISEMRIBAKIMLARTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLISEMRITableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLISEMRI.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLISEMRITableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLISEMIRDURUMTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLISEMIRDURUM.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLISEMIRDURUMTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLIHLHAKEDISTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLIHLHAKEDIS.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLIHLHAKEDISTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLIHALELERTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLIHALELER.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLIHALELERTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLIDARISARTNAMETableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLIDARISARTNAME.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLIDARISARTNAMETableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLIDARISARTHRKTTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLIDARISARTHRKT.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLIDARISARTHRKTTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLFORMKULLANICITableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLFORMKULLANICI.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLFORMKULLANICITableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLFIRMASEKTORTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLFIRMASEKTOR.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLFIRMASEKTORTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLFIRMALARTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLFIRMALAR.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLFIRMALARTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLDEPOFISHRKTTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLDEPOFISHRKT.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLDEPOFISHRKTTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLDEPOFISTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLDEPOFIS.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLDEPOFISTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLBIRIMYETKILILERITableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLBIRIMYETKILILERI.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLBIRIMYETKILILERITableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLBELDMUDURLUKTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLBELDMUDURLUK.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLBELDMUDURLUKTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLBELDBIRIMLERTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLBELDBIRIMLER.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLBELDBIRIMLERTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLBAKIMYERITableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLBAKIMYERI.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLBAKIMYERITableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLYETKILIMZATableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLYETKILIMZA.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLYETKILIMZATableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tBLARACRESIMTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.TBLARACRESIM.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && realUpdatedRows.Length != 0)
        {
          num += this._tBLARACRESIMTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      return num;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private int UpdateInsertedRows(bellDataSet7 dataSet, List<DataRow> allAddedRows)
    {
      int num = 0;
      if (this._fAALIYETTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.FAALIYET.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._fAALIYETTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLPERSONELDURUMTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLPERSONELDURUM.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLPERSONELDURUMTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLPERSONELTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLPERSONEL.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLPERSONELTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLPERSMESAITableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLPERSMESAI.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLPERSMESAITableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLPERSKURUMGOREVTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLPERSKURUMGOREV.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLPERSKURUMGOREVTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLPERSIZINDURUMTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLPERSIZINDURUM.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLPERSIZINDURUMTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLPERSEHLIYETTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLPERSEHLIYET.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLPERSEHLIYETTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLPERSEGITIMDRMTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLPERSEGITIMDRM.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLPERSEGITIMDRMTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLPERSONELISTIHDAMDURUMTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLPERSONELISTIHDAMDURUM.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLPERSONELISTIHDAMDURUMTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLPERIZINYILLARITableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLPERIZINYILLARI.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLPERIZINYILLARITableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLMALZMARKATableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLMALZMARKA.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLMALZMARKATableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLMALZKDVTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLMALZKDV.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLMALZKDVTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLMALZGRUP2TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLMALZGRUP2.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLMALZGRUP2TableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLMALZGRUPTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLMALZGRUP.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLMALZGRUPTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLMALZEMELERTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLMALZEMELER.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLMALZEMELERTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLMALZDEPOTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLMALZDEPO.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLMALZDEPOTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLMALZBOLUMTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLMALZBOLUM.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLMALZBOLUMTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLMENUTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLMENU.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLMENUTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLMALZBIRIMTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLMALZBIRIM.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLMALZBIRIMTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLPERSONELIZINTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLPERSONELIZIN.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLPERSONELIZINTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLPERTOPLANTITableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLPERTOPLANTI.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLPERTOPLANTITableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLYAZIEKLERITableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLYAZIEKLERI.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLYAZIEKLERITableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLYAKITKONTFORMTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLYAKITKONTFORM.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLYAKITKONTFORMTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLVARYOKTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLVARYOK.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLVARYOKTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLTEKNIKSARTHRKTTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLTEKNIKSARTHRKT.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLTEKNIKSARTHRKTTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLTEKNIKSARTTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLTEKNIKSART.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLTEKNIKSARTTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLTEKLIFIDARISARTTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLTEKLIFIDARISART.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLTEKLIFIDARISARTTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLTEKLIFHRKTTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLTEKLIFHRKT.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLTEKLIFHRKTTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLPERSUNVANTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLPERSUNVAN.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLPERSUNVANTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLTEKLIFTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLTEKLIF.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLTEKLIFTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLTASITGOREVTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLTASITGOREV.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLTASITGOREVTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLTALEPTEKNIKSARTTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLTALEPTEKNIKSART.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLTALEPTEKNIKSARTTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLTALEPHRKTTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLTALEPHRKT.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLTALEPHRKTTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLTALEPFISHRKTTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLTALEPFISHRKT.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLTALEPFISHRKTTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLTALEPFISTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLTALEPFIS.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLTALEPFISTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLTALEPTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLTALEP.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLTALEPTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLSABITLERTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLSABITLER.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLSABITLERTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLTASITPERSTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLTASITPERS.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLTASITPERSTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLLOGTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLLOG.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLLOGTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLKULLANICILARTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLKULLANICILAR.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLKULLANICILARTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLISLEMTIPITableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLISLEMTIPI.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLISLEMTIPITableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLATOLYEBOLUMTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLATOLYEBOLUM.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLATOLYEBOLUMTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLARACZIMMETTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLARACZIMMET.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLARACZIMMETTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLARACYEDEKALIMTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLARACYEDEKALIM.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLARACYEDEKALIMTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLARACTRFCEZATableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLARACTRFCEZA.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLARACTRFCEZATableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLARACMESTKPTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLARACMESTKP.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLARACMESTKPTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLARACMARKATableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLARACMARKA.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLARACMARKATableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLARACLARTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLARACLAR.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLARACLARTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLATOLYEUSTALARTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLATOLYEUSTALAR.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLATOLYEUSTALARTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLARACGRUBU2TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLARACGRUBU2.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLARACGRUBU2TableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tAHMODELYILITableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TAHMODELYILI.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tAHMODELYILITableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tAHBAKIMTURUTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TAHBAKIMTURU.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tAHBAKIMTURUTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tAHBAKIMDERECETableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TAHBAKIMDERECE.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tAHBAKIMDERECETableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tAHARIZANEDENITableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TAHARIZANEDENI.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tAHARIZANEDENITableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tAHARACTIPITableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TAHARACTIPI.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tAHARACTIPITableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tAHARACHGSTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TAHARACHGS.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tAHARACHGSTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tAHARACDURUMTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TAHARACDURUM.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tAHARACDURUMTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLARACGRUBUTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLARACGRUBU.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLARACGRUBUTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLAYARLARTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLAYARLAR.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLAYARLARTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLBAKIMGRUBUTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLBAKIMGRUBU.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLBAKIMGRUBUTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLBAKIMTANIMTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLBAKIMTANIM.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLBAKIMTANIMTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLISEMRIEKRYNLTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLISEMRIEKRYNL.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLISEMRIEKRYNLTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLISEMRIBAKIMLARTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLISEMRIBAKIMLAR.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLISEMRIBAKIMLARTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLISEMRITableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLISEMRI.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLISEMRITableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLISEMIRDURUMTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLISEMIRDURUM.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLISEMIRDURUMTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLIHLHAKEDISTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLIHLHAKEDIS.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLIHLHAKEDISTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLIHALELERTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLIHALELER.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLIHALELERTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLIDARISARTNAMETableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLIDARISARTNAME.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLIDARISARTNAMETableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLIDARISARTHRKTTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLIDARISARTHRKT.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLIDARISARTHRKTTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLFORMKULLANICITableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLFORMKULLANICI.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLFORMKULLANICITableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLFIRMASEKTORTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLFIRMASEKTOR.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLFIRMASEKTORTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLFIRMALARTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLFIRMALAR.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLFIRMALARTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLDEPOFISHRKTTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLDEPOFISHRKT.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLDEPOFISHRKTTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLDEPOFISTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLDEPOFIS.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLDEPOFISTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLBIRIMYETKILILERITableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLBIRIMYETKILILERI.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLBIRIMYETKILILERITableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLBELDMUDURLUKTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLBELDMUDURLUK.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLBELDMUDURLUKTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLBELDBIRIMLERTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLBELDBIRIMLER.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLBELDBIRIMLERTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLBAKIMYERITableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLBAKIMYERI.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLBAKIMYERITableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLYETKILIMZATableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLYETKILIMZA.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLYETKILIMZATableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLARACRESIMTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLARACRESIM.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLARACRESIMTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      return num;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private int UpdateDeletedRows(bellDataSet7 dataSet, List<DataRow> allChangedRows)
    {
      int num = 0;
      if (this._tBLARACRESIMTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLARACRESIM.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLARACRESIMTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLYETKILIMZATableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLYETKILIMZA.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLYETKILIMZATableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLBAKIMYERITableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLBAKIMYERI.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLBAKIMYERITableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLBELDBIRIMLERTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLBELDBIRIMLER.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLBELDBIRIMLERTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLBELDMUDURLUKTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLBELDMUDURLUK.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLBELDMUDURLUKTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLBIRIMYETKILILERITableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLBIRIMYETKILILERI.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLBIRIMYETKILILERITableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLDEPOFISTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLDEPOFIS.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLDEPOFISTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLDEPOFISHRKTTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLDEPOFISHRKT.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLDEPOFISHRKTTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLFIRMALARTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLFIRMALAR.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLFIRMALARTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLFIRMASEKTORTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLFIRMASEKTOR.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLFIRMASEKTORTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLFORMKULLANICITableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLFORMKULLANICI.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLFORMKULLANICITableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLIDARISARTHRKTTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLIDARISARTHRKT.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLIDARISARTHRKTTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLIDARISARTNAMETableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLIDARISARTNAME.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLIDARISARTNAMETableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLIHALELERTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLIHALELER.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLIHALELERTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLIHLHAKEDISTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLIHLHAKEDIS.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLIHLHAKEDISTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLISEMIRDURUMTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLISEMIRDURUM.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLISEMIRDURUMTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLISEMRITableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLISEMRI.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLISEMRITableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLISEMRIBAKIMLARTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLISEMRIBAKIMLAR.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLISEMRIBAKIMLARTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLISEMRIEKRYNLTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLISEMRIEKRYNL.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLISEMRIEKRYNLTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLBAKIMTANIMTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLBAKIMTANIM.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLBAKIMTANIMTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLBAKIMGRUBUTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLBAKIMGRUBU.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLBAKIMGRUBUTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLAYARLARTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLAYARLAR.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLAYARLARTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLARACGRUBUTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLARACGRUBU.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLARACGRUBUTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tAHARACDURUMTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TAHARACDURUM.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tAHARACDURUMTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tAHARACHGSTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TAHARACHGS.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tAHARACHGSTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tAHARACTIPITableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TAHARACTIPI.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tAHARACTIPITableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tAHARIZANEDENITableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TAHARIZANEDENI.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tAHARIZANEDENITableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tAHBAKIMDERECETableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TAHBAKIMDERECE.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tAHBAKIMDERECETableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tAHBAKIMTURUTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TAHBAKIMTURU.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tAHBAKIMTURUTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tAHMODELYILITableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TAHMODELYILI.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tAHMODELYILITableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLARACGRUBU2TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLARACGRUBU2.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLARACGRUBU2TableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLATOLYEUSTALARTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLATOLYEUSTALAR.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLATOLYEUSTALARTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLARACLARTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLARACLAR.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLARACLARTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLARACMARKATableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLARACMARKA.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLARACMARKATableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLARACMESTKPTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLARACMESTKP.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLARACMESTKPTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLARACTRFCEZATableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLARACTRFCEZA.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLARACTRFCEZATableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLARACYEDEKALIMTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLARACYEDEKALIM.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLARACYEDEKALIMTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLARACZIMMETTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLARACZIMMET.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLARACZIMMETTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLATOLYEBOLUMTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLATOLYEBOLUM.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLATOLYEBOLUMTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLISLEMTIPITableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLISLEMTIPI.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLISLEMTIPITableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLKULLANICILARTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLKULLANICILAR.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLKULLANICILARTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLLOGTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLLOG.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLLOGTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLTASITPERSTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLTASITPERS.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLTASITPERSTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLSABITLERTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLSABITLER.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLSABITLERTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLTALEPTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLTALEP.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLTALEPTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLTALEPFISTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLTALEPFIS.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLTALEPFISTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLTALEPFISHRKTTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLTALEPFISHRKT.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLTALEPFISHRKTTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLTALEPHRKTTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLTALEPHRKT.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLTALEPHRKTTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLTALEPTEKNIKSARTTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLTALEPTEKNIKSART.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLTALEPTEKNIKSARTTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLTASITGOREVTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLTASITGOREV.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLTASITGOREVTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLTEKLIFTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLTEKLIF.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLTEKLIFTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLPERSUNVANTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLPERSUNVAN.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLPERSUNVANTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLTEKLIFHRKTTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLTEKLIFHRKT.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLTEKLIFHRKTTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLTEKLIFIDARISARTTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLTEKLIFIDARISART.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLTEKLIFIDARISARTTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLTEKNIKSARTTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLTEKNIKSART.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLTEKNIKSARTTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLTEKNIKSARTHRKTTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLTEKNIKSARTHRKT.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLTEKNIKSARTHRKTTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLVARYOKTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLVARYOK.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLVARYOKTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLYAKITKONTFORMTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLYAKITKONTFORM.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLYAKITKONTFORMTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLYAZIEKLERITableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLYAZIEKLERI.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLYAZIEKLERITableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLPERTOPLANTITableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLPERTOPLANTI.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLPERTOPLANTITableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLPERSONELIZINTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLPERSONELIZIN.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLPERSONELIZINTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLMALZBIRIMTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLMALZBIRIM.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLMALZBIRIMTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLMENUTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLMENU.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLMENUTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLMALZBOLUMTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLMALZBOLUM.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLMALZBOLUMTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLMALZDEPOTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLMALZDEPO.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLMALZDEPOTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLMALZEMELERTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLMALZEMELER.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLMALZEMELERTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLMALZGRUPTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLMALZGRUP.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLMALZGRUPTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLMALZGRUP2TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLMALZGRUP2.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLMALZGRUP2TableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLMALZKDVTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLMALZKDV.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLMALZKDVTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLMALZMARKATableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLMALZMARKA.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLMALZMARKATableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLPERIZINYILLARITableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLPERIZINYILLARI.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLPERIZINYILLARITableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLPERSONELISTIHDAMDURUMTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLPERSONELISTIHDAMDURUM.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLPERSONELISTIHDAMDURUMTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLPERSEGITIMDRMTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLPERSEGITIMDRM.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLPERSEGITIMDRMTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLPERSEHLIYETTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLPERSEHLIYET.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLPERSEHLIYETTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLPERSIZINDURUMTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLPERSIZINDURUM.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLPERSIZINDURUMTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLPERSKURUMGOREVTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLPERSKURUMGOREV.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLPERSKURUMGOREVTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLPERSMESAITableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLPERSMESAI.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLPERSMESAITableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLPERSONELTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLPERSONEL.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLPERSONELTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._tBLPERSONELDURUMTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.TBLPERSONELDURUM.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._tBLPERSONELDURUMTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._fAALIYETTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.FAALIYET.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && dataRowArray.Length != 0)
        {
          num += this._fAALIYETTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      return num;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private DataRow[] GetRealUpdatedRows(DataRow[] updatedRows, List<DataRow> allAddedRows)
    {
      if (updatedRows == null || updatedRows.Length < 1 || allAddedRows == null || allAddedRows.Count < 1)
        return updatedRows;
      List<DataRow> dataRowList = new List<DataRow>();
      for (int index = 0; index < updatedRows.Length; ++index)
      {
        DataRow updatedRow = updatedRows[index];
        if (!allAddedRows.Contains(updatedRow))
          dataRowList.Add(updatedRow);
      }
      return dataRowList.ToArray();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public virtual int UpdateAll(bellDataSet7 dataSet)
    {
      if (dataSet == null)
        throw new ArgumentNullException(nameof (dataSet));
      if (!dataSet.HasChanges())
        return 0;
      if (this._fAALIYETTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._fAALIYETTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tAHARACDURUMTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tAHARACDURUMTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tAHARACHGSTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tAHARACHGSTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tAHARACTIPITableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tAHARACTIPITableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tAHARIZANEDENITableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tAHARIZANEDENITableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tAHBAKIMDERECETableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tAHBAKIMDERECETableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tAHBAKIMTURUTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tAHBAKIMTURUTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tAHMODELYILITableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tAHMODELYILITableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLARACGRUBUTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLARACGRUBUTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLARACGRUBU2TableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLARACGRUBU2TableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLARACLARTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLARACLARTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLARACMARKATableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLARACMARKATableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLARACMESTKPTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLARACMESTKPTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLARACTRFCEZATableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLARACTRFCEZATableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLARACYEDEKALIMTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLARACYEDEKALIMTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLARACZIMMETTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLARACZIMMETTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLATOLYEBOLUMTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLATOLYEBOLUMTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLATOLYEUSTALARTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLATOLYEUSTALARTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLAYARLARTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLAYARLARTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLBAKIMGRUBUTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLBAKIMGRUBUTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLBAKIMTANIMTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLBAKIMTANIMTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLBAKIMYERITableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLBAKIMYERITableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLBELDBIRIMLERTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLBELDBIRIMLERTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLBELDMUDURLUKTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLBELDMUDURLUKTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLBIRIMYETKILILERITableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLBIRIMYETKILILERITableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLDEPOFISTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLDEPOFISTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLDEPOFISHRKTTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLDEPOFISHRKTTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLFIRMALARTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLFIRMALARTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLFIRMASEKTORTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLFIRMASEKTORTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLFORMKULLANICITableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLFORMKULLANICITableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLIDARISARTHRKTTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLIDARISARTHRKTTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLIDARISARTNAMETableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLIDARISARTNAMETableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLIHALELERTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLIHALELERTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLIHLHAKEDISTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLIHLHAKEDISTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLISEMIRDURUMTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLISEMIRDURUMTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLISEMRITableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLISEMRITableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLISEMRIBAKIMLARTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLISEMRIBAKIMLARTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLISEMRIEKRYNLTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLISEMRIEKRYNLTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLISLEMTIPITableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLISLEMTIPITableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLKULLANICILARTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLKULLANICILARTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLLOGTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLLOGTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLMALZBIRIMTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLMALZBIRIMTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLMALZBOLUMTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLMALZBOLUMTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLMALZDEPOTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLMALZDEPOTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLMALZEMELERTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLMALZEMELERTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLMALZGRUPTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLMALZGRUPTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLMALZGRUP2TableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLMALZGRUP2TableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLMALZKDVTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLMALZKDVTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLMALZMARKATableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLMALZMARKATableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLMENUTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLMENUTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLPERIZINYILLARITableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLPERIZINYILLARITableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLPERSEGITIMDRMTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLPERSEGITIMDRMTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLPERSEHLIYETTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLPERSEHLIYETTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLPERSIZINDURUMTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLPERSIZINDURUMTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLPERSKURUMGOREVTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLPERSKURUMGOREVTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLPERSMESAITableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLPERSMESAITableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLPERSONELTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLPERSONELTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLPERSONELDURUMTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLPERSONELDURUMTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLPERSONELISTIHDAMDURUMTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLPERSONELISTIHDAMDURUMTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLPERSONELIZINTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLPERSONELIZINTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLPERSUNVANTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLPERSUNVANTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLPERTOPLANTITableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLPERTOPLANTITableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLSABITLERTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLSABITLERTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLTALEPTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLTALEPTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLTALEPFISTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLTALEPFISTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLTALEPFISHRKTTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLTALEPFISHRKTTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLTALEPHRKTTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLTALEPHRKTTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLTALEPTEKNIKSARTTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLTALEPTEKNIKSARTTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLTASITGOREVTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLTASITGOREVTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLTASITPERSTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLTASITPERSTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLTEKLIFTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLTEKLIFTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLTEKLIFHRKTTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLTEKLIFHRKTTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLTEKLIFIDARISARTTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLTEKLIFIDARISARTTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLTEKNIKSARTTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLTEKNIKSARTTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLTEKNIKSARTHRKTTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLTEKNIKSARTHRKTTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLVARYOKTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLVARYOKTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLYAKITKONTFORMTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLYAKITKONTFORMTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLYAZIEKLERITableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLYAZIEKLERITableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLYETKILIMZATableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLYETKILIMZATableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      if (this._tBLARACRESIMTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tBLARACRESIMTableAdapter.Connection))
        throw new ArgumentException("TableAdapterManager tarafından yönetilen tüm TableAdapter'lar aynı bağlantı dizesini kullanmalıdır.");
      IDbConnection connection = this.Connection;
      if (connection == null)
        throw new ApplicationException("TableAdapterManager bağlantı bilgisi içermiyor. TableAdapterManager TableAdapter özelliklerinin her birini geçerli bir TableAdapter örneğine ayarlayın.");
      bool flag = false;
      if ((connection.State & ConnectionState.Broken) == ConnectionState.Broken)
        connection.Close();
      if (connection.State == ConnectionState.Closed)
      {
        connection.Open();
        flag = true;
      }
      IDbTransaction dbTransaction = connection.BeginTransaction();
      if (dbTransaction == null)
        throw new ApplicationException("İşlem başlatılamıyor. Geçerli veri bağlantısı işlemleri desteklemiyor veya geçerli durum işlemin başlatılmasına izin vermiyor.");
      List<DataRow> allChangedRows = new List<DataRow>();
      List<DataRow> allAddedRows = new List<DataRow>();
      List<DataAdapter> dataAdapterList = new List<DataAdapter>();
      Dictionary<object, IDbConnection> dictionary = new Dictionary<object, IDbConnection>();
      int num = 0;
      DataSet dataSet1 = (DataSet) null;
      if (this.BackupDataSetBeforeUpdate)
      {
        dataSet1 = new DataSet();
        dataSet1.Merge((DataSet) dataSet);
      }
      try
      {
        if (this._fAALIYETTableAdapter != null)
        {
          dictionary.Add((object) this._fAALIYETTableAdapter, (IDbConnection) this._fAALIYETTableAdapter.Connection);
          this._fAALIYETTableAdapter.Connection = (SqlConnection) connection;
          this._fAALIYETTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._fAALIYETTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._fAALIYETTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._fAALIYETTableAdapter.Adapter);
          }
        }
        if (this._tAHARACDURUMTableAdapter != null)
        {
          dictionary.Add((object) this._tAHARACDURUMTableAdapter, (IDbConnection) this._tAHARACDURUMTableAdapter.Connection);
          this._tAHARACDURUMTableAdapter.Connection = (SqlConnection) connection;
          this._tAHARACDURUMTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tAHARACDURUMTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tAHARACDURUMTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tAHARACDURUMTableAdapter.Adapter);
          }
        }
        if (this._tAHARACHGSTableAdapter != null)
        {
          dictionary.Add((object) this._tAHARACHGSTableAdapter, (IDbConnection) this._tAHARACHGSTableAdapter.Connection);
          this._tAHARACHGSTableAdapter.Connection = (SqlConnection) connection;
          this._tAHARACHGSTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tAHARACHGSTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tAHARACHGSTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tAHARACHGSTableAdapter.Adapter);
          }
        }
        if (this._tAHARACTIPITableAdapter != null)
        {
          dictionary.Add((object) this._tAHARACTIPITableAdapter, (IDbConnection) this._tAHARACTIPITableAdapter.Connection);
          this._tAHARACTIPITableAdapter.Connection = (SqlConnection) connection;
          this._tAHARACTIPITableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tAHARACTIPITableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tAHARACTIPITableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tAHARACTIPITableAdapter.Adapter);
          }
        }
        if (this._tAHARIZANEDENITableAdapter != null)
        {
          dictionary.Add((object) this._tAHARIZANEDENITableAdapter, (IDbConnection) this._tAHARIZANEDENITableAdapter.Connection);
          this._tAHARIZANEDENITableAdapter.Connection = (SqlConnection) connection;
          this._tAHARIZANEDENITableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tAHARIZANEDENITableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tAHARIZANEDENITableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tAHARIZANEDENITableAdapter.Adapter);
          }
        }
        if (this._tAHBAKIMDERECETableAdapter != null)
        {
          dictionary.Add((object) this._tAHBAKIMDERECETableAdapter, (IDbConnection) this._tAHBAKIMDERECETableAdapter.Connection);
          this._tAHBAKIMDERECETableAdapter.Connection = (SqlConnection) connection;
          this._tAHBAKIMDERECETableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tAHBAKIMDERECETableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tAHBAKIMDERECETableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tAHBAKIMDERECETableAdapter.Adapter);
          }
        }
        if (this._tAHBAKIMTURUTableAdapter != null)
        {
          dictionary.Add((object) this._tAHBAKIMTURUTableAdapter, (IDbConnection) this._tAHBAKIMTURUTableAdapter.Connection);
          this._tAHBAKIMTURUTableAdapter.Connection = (SqlConnection) connection;
          this._tAHBAKIMTURUTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tAHBAKIMTURUTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tAHBAKIMTURUTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tAHBAKIMTURUTableAdapter.Adapter);
          }
        }
        if (this._tAHMODELYILITableAdapter != null)
        {
          dictionary.Add((object) this._tAHMODELYILITableAdapter, (IDbConnection) this._tAHMODELYILITableAdapter.Connection);
          this._tAHMODELYILITableAdapter.Connection = (SqlConnection) connection;
          this._tAHMODELYILITableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tAHMODELYILITableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tAHMODELYILITableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tAHMODELYILITableAdapter.Adapter);
          }
        }
        if (this._tBLARACGRUBUTableAdapter != null)
        {
          dictionary.Add((object) this._tBLARACGRUBUTableAdapter, (IDbConnection) this._tBLARACGRUBUTableAdapter.Connection);
          this._tBLARACGRUBUTableAdapter.Connection = (SqlConnection) connection;
          this._tBLARACGRUBUTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLARACGRUBUTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLARACGRUBUTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLARACGRUBUTableAdapter.Adapter);
          }
        }
        if (this._tBLARACGRUBU2TableAdapter != null)
        {
          dictionary.Add((object) this._tBLARACGRUBU2TableAdapter, (IDbConnection) this._tBLARACGRUBU2TableAdapter.Connection);
          this._tBLARACGRUBU2TableAdapter.Connection = (SqlConnection) connection;
          this._tBLARACGRUBU2TableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLARACGRUBU2TableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLARACGRUBU2TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLARACGRUBU2TableAdapter.Adapter);
          }
        }
        if (this._tBLARACLARTableAdapter != null)
        {
          dictionary.Add((object) this._tBLARACLARTableAdapter, (IDbConnection) this._tBLARACLARTableAdapter.Connection);
          this._tBLARACLARTableAdapter.Connection = (SqlConnection) connection;
          this._tBLARACLARTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLARACLARTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLARACLARTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLARACLARTableAdapter.Adapter);
          }
        }
        if (this._tBLARACMARKATableAdapter != null)
        {
          dictionary.Add((object) this._tBLARACMARKATableAdapter, (IDbConnection) this._tBLARACMARKATableAdapter.Connection);
          this._tBLARACMARKATableAdapter.Connection = (SqlConnection) connection;
          this._tBLARACMARKATableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLARACMARKATableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLARACMARKATableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLARACMARKATableAdapter.Adapter);
          }
        }
        if (this._tBLARACMESTKPTableAdapter != null)
        {
          dictionary.Add((object) this._tBLARACMESTKPTableAdapter, (IDbConnection) this._tBLARACMESTKPTableAdapter.Connection);
          this._tBLARACMESTKPTableAdapter.Connection = (SqlConnection) connection;
          this._tBLARACMESTKPTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLARACMESTKPTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLARACMESTKPTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLARACMESTKPTableAdapter.Adapter);
          }
        }
        if (this._tBLARACTRFCEZATableAdapter != null)
        {
          dictionary.Add((object) this._tBLARACTRFCEZATableAdapter, (IDbConnection) this._tBLARACTRFCEZATableAdapter.Connection);
          this._tBLARACTRFCEZATableAdapter.Connection = (SqlConnection) connection;
          this._tBLARACTRFCEZATableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLARACTRFCEZATableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLARACTRFCEZATableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLARACTRFCEZATableAdapter.Adapter);
          }
        }
        if (this._tBLARACYEDEKALIMTableAdapter != null)
        {
          dictionary.Add((object) this._tBLARACYEDEKALIMTableAdapter, (IDbConnection) this._tBLARACYEDEKALIMTableAdapter.Connection);
          this._tBLARACYEDEKALIMTableAdapter.Connection = (SqlConnection) connection;
          this._tBLARACYEDEKALIMTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLARACYEDEKALIMTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLARACYEDEKALIMTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLARACYEDEKALIMTableAdapter.Adapter);
          }
        }
        if (this._tBLARACZIMMETTableAdapter != null)
        {
          dictionary.Add((object) this._tBLARACZIMMETTableAdapter, (IDbConnection) this._tBLARACZIMMETTableAdapter.Connection);
          this._tBLARACZIMMETTableAdapter.Connection = (SqlConnection) connection;
          this._tBLARACZIMMETTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLARACZIMMETTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLARACZIMMETTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLARACZIMMETTableAdapter.Adapter);
          }
        }
        if (this._tBLATOLYEBOLUMTableAdapter != null)
        {
          dictionary.Add((object) this._tBLATOLYEBOLUMTableAdapter, (IDbConnection) this._tBLATOLYEBOLUMTableAdapter.Connection);
          this._tBLATOLYEBOLUMTableAdapter.Connection = (SqlConnection) connection;
          this._tBLATOLYEBOLUMTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLATOLYEBOLUMTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLATOLYEBOLUMTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLATOLYEBOLUMTableAdapter.Adapter);
          }
        }
        if (this._tBLATOLYEUSTALARTableAdapter != null)
        {
          dictionary.Add((object) this._tBLATOLYEUSTALARTableAdapter, (IDbConnection) this._tBLATOLYEUSTALARTableAdapter.Connection);
          this._tBLATOLYEUSTALARTableAdapter.Connection = (SqlConnection) connection;
          this._tBLATOLYEUSTALARTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLATOLYEUSTALARTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLATOLYEUSTALARTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLATOLYEUSTALARTableAdapter.Adapter);
          }
        }
        if (this._tBLAYARLARTableAdapter != null)
        {
          dictionary.Add((object) this._tBLAYARLARTableAdapter, (IDbConnection) this._tBLAYARLARTableAdapter.Connection);
          this._tBLAYARLARTableAdapter.Connection = (SqlConnection) connection;
          this._tBLAYARLARTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLAYARLARTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLAYARLARTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLAYARLARTableAdapter.Adapter);
          }
        }
        if (this._tBLBAKIMGRUBUTableAdapter != null)
        {
          dictionary.Add((object) this._tBLBAKIMGRUBUTableAdapter, (IDbConnection) this._tBLBAKIMGRUBUTableAdapter.Connection);
          this._tBLBAKIMGRUBUTableAdapter.Connection = (SqlConnection) connection;
          this._tBLBAKIMGRUBUTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLBAKIMGRUBUTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLBAKIMGRUBUTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLBAKIMGRUBUTableAdapter.Adapter);
          }
        }
        if (this._tBLBAKIMTANIMTableAdapter != null)
        {
          dictionary.Add((object) this._tBLBAKIMTANIMTableAdapter, (IDbConnection) this._tBLBAKIMTANIMTableAdapter.Connection);
          this._tBLBAKIMTANIMTableAdapter.Connection = (SqlConnection) connection;
          this._tBLBAKIMTANIMTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLBAKIMTANIMTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLBAKIMTANIMTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLBAKIMTANIMTableAdapter.Adapter);
          }
        }
        if (this._tBLBAKIMYERITableAdapter != null)
        {
          dictionary.Add((object) this._tBLBAKIMYERITableAdapter, (IDbConnection) this._tBLBAKIMYERITableAdapter.Connection);
          this._tBLBAKIMYERITableAdapter.Connection = (SqlConnection) connection;
          this._tBLBAKIMYERITableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLBAKIMYERITableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLBAKIMYERITableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLBAKIMYERITableAdapter.Adapter);
          }
        }
        if (this._tBLBELDBIRIMLERTableAdapter != null)
        {
          dictionary.Add((object) this._tBLBELDBIRIMLERTableAdapter, (IDbConnection) this._tBLBELDBIRIMLERTableAdapter.Connection);
          this._tBLBELDBIRIMLERTableAdapter.Connection = (SqlConnection) connection;
          this._tBLBELDBIRIMLERTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLBELDBIRIMLERTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLBELDBIRIMLERTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLBELDBIRIMLERTableAdapter.Adapter);
          }
        }
        if (this._tBLBELDMUDURLUKTableAdapter != null)
        {
          dictionary.Add((object) this._tBLBELDMUDURLUKTableAdapter, (IDbConnection) this._tBLBELDMUDURLUKTableAdapter.Connection);
          this._tBLBELDMUDURLUKTableAdapter.Connection = (SqlConnection) connection;
          this._tBLBELDMUDURLUKTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLBELDMUDURLUKTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLBELDMUDURLUKTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLBELDMUDURLUKTableAdapter.Adapter);
          }
        }
        if (this._tBLBIRIMYETKILILERITableAdapter != null)
        {
          dictionary.Add((object) this._tBLBIRIMYETKILILERITableAdapter, (IDbConnection) this._tBLBIRIMYETKILILERITableAdapter.Connection);
          this._tBLBIRIMYETKILILERITableAdapter.Connection = (SqlConnection) connection;
          this._tBLBIRIMYETKILILERITableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLBIRIMYETKILILERITableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLBIRIMYETKILILERITableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLBIRIMYETKILILERITableAdapter.Adapter);
          }
        }
        if (this._tBLDEPOFISTableAdapter != null)
        {
          dictionary.Add((object) this._tBLDEPOFISTableAdapter, (IDbConnection) this._tBLDEPOFISTableAdapter.Connection);
          this._tBLDEPOFISTableAdapter.Connection = (SqlConnection) connection;
          this._tBLDEPOFISTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLDEPOFISTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLDEPOFISTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLDEPOFISTableAdapter.Adapter);
          }
        }
        if (this._tBLDEPOFISHRKTTableAdapter != null)
        {
          dictionary.Add((object) this._tBLDEPOFISHRKTTableAdapter, (IDbConnection) this._tBLDEPOFISHRKTTableAdapter.Connection);
          this._tBLDEPOFISHRKTTableAdapter.Connection = (SqlConnection) connection;
          this._tBLDEPOFISHRKTTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLDEPOFISHRKTTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLDEPOFISHRKTTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLDEPOFISHRKTTableAdapter.Adapter);
          }
        }
        if (this._tBLFIRMALARTableAdapter != null)
        {
          dictionary.Add((object) this._tBLFIRMALARTableAdapter, (IDbConnection) this._tBLFIRMALARTableAdapter.Connection);
          this._tBLFIRMALARTableAdapter.Connection = (SqlConnection) connection;
          this._tBLFIRMALARTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLFIRMALARTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLFIRMALARTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLFIRMALARTableAdapter.Adapter);
          }
        }
        if (this._tBLFIRMASEKTORTableAdapter != null)
        {
          dictionary.Add((object) this._tBLFIRMASEKTORTableAdapter, (IDbConnection) this._tBLFIRMASEKTORTableAdapter.Connection);
          this._tBLFIRMASEKTORTableAdapter.Connection = (SqlConnection) connection;
          this._tBLFIRMASEKTORTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLFIRMASEKTORTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLFIRMASEKTORTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLFIRMASEKTORTableAdapter.Adapter);
          }
        }
        if (this._tBLFORMKULLANICITableAdapter != null)
        {
          dictionary.Add((object) this._tBLFORMKULLANICITableAdapter, (IDbConnection) this._tBLFORMKULLANICITableAdapter.Connection);
          this._tBLFORMKULLANICITableAdapter.Connection = (SqlConnection) connection;
          this._tBLFORMKULLANICITableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLFORMKULLANICITableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLFORMKULLANICITableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLFORMKULLANICITableAdapter.Adapter);
          }
        }
        if (this._tBLIDARISARTHRKTTableAdapter != null)
        {
          dictionary.Add((object) this._tBLIDARISARTHRKTTableAdapter, (IDbConnection) this._tBLIDARISARTHRKTTableAdapter.Connection);
          this._tBLIDARISARTHRKTTableAdapter.Connection = (SqlConnection) connection;
          this._tBLIDARISARTHRKTTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLIDARISARTHRKTTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLIDARISARTHRKTTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLIDARISARTHRKTTableAdapter.Adapter);
          }
        }
        if (this._tBLIDARISARTNAMETableAdapter != null)
        {
          dictionary.Add((object) this._tBLIDARISARTNAMETableAdapter, (IDbConnection) this._tBLIDARISARTNAMETableAdapter.Connection);
          this._tBLIDARISARTNAMETableAdapter.Connection = (SqlConnection) connection;
          this._tBLIDARISARTNAMETableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLIDARISARTNAMETableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLIDARISARTNAMETableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLIDARISARTNAMETableAdapter.Adapter);
          }
        }
        if (this._tBLIHALELERTableAdapter != null)
        {
          dictionary.Add((object) this._tBLIHALELERTableAdapter, (IDbConnection) this._tBLIHALELERTableAdapter.Connection);
          this._tBLIHALELERTableAdapter.Connection = (SqlConnection) connection;
          this._tBLIHALELERTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLIHALELERTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLIHALELERTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLIHALELERTableAdapter.Adapter);
          }
        }
        if (this._tBLIHLHAKEDISTableAdapter != null)
        {
          dictionary.Add((object) this._tBLIHLHAKEDISTableAdapter, (IDbConnection) this._tBLIHLHAKEDISTableAdapter.Connection);
          this._tBLIHLHAKEDISTableAdapter.Connection = (SqlConnection) connection;
          this._tBLIHLHAKEDISTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLIHLHAKEDISTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLIHLHAKEDISTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLIHLHAKEDISTableAdapter.Adapter);
          }
        }
        if (this._tBLISEMIRDURUMTableAdapter != null)
        {
          dictionary.Add((object) this._tBLISEMIRDURUMTableAdapter, (IDbConnection) this._tBLISEMIRDURUMTableAdapter.Connection);
          this._tBLISEMIRDURUMTableAdapter.Connection = (SqlConnection) connection;
          this._tBLISEMIRDURUMTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLISEMIRDURUMTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLISEMIRDURUMTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLISEMIRDURUMTableAdapter.Adapter);
          }
        }
        if (this._tBLISEMRITableAdapter != null)
        {
          dictionary.Add((object) this._tBLISEMRITableAdapter, (IDbConnection) this._tBLISEMRITableAdapter.Connection);
          this._tBLISEMRITableAdapter.Connection = (SqlConnection) connection;
          this._tBLISEMRITableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLISEMRITableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLISEMRITableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLISEMRITableAdapter.Adapter);
          }
        }
        if (this._tBLISEMRIBAKIMLARTableAdapter != null)
        {
          dictionary.Add((object) this._tBLISEMRIBAKIMLARTableAdapter, (IDbConnection) this._tBLISEMRIBAKIMLARTableAdapter.Connection);
          this._tBLISEMRIBAKIMLARTableAdapter.Connection = (SqlConnection) connection;
          this._tBLISEMRIBAKIMLARTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLISEMRIBAKIMLARTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLISEMRIBAKIMLARTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLISEMRIBAKIMLARTableAdapter.Adapter);
          }
        }
        if (this._tBLISEMRIEKRYNLTableAdapter != null)
        {
          dictionary.Add((object) this._tBLISEMRIEKRYNLTableAdapter, (IDbConnection) this._tBLISEMRIEKRYNLTableAdapter.Connection);
          this._tBLISEMRIEKRYNLTableAdapter.Connection = (SqlConnection) connection;
          this._tBLISEMRIEKRYNLTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLISEMRIEKRYNLTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLISEMRIEKRYNLTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLISEMRIEKRYNLTableAdapter.Adapter);
          }
        }
        if (this._tBLISLEMTIPITableAdapter != null)
        {
          dictionary.Add((object) this._tBLISLEMTIPITableAdapter, (IDbConnection) this._tBLISLEMTIPITableAdapter.Connection);
          this._tBLISLEMTIPITableAdapter.Connection = (SqlConnection) connection;
          this._tBLISLEMTIPITableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLISLEMTIPITableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLISLEMTIPITableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLISLEMTIPITableAdapter.Adapter);
          }
        }
        if (this._tBLKULLANICILARTableAdapter != null)
        {
          dictionary.Add((object) this._tBLKULLANICILARTableAdapter, (IDbConnection) this._tBLKULLANICILARTableAdapter.Connection);
          this._tBLKULLANICILARTableAdapter.Connection = (SqlConnection) connection;
          this._tBLKULLANICILARTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLKULLANICILARTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLKULLANICILARTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLKULLANICILARTableAdapter.Adapter);
          }
        }
        if (this._tBLLOGTableAdapter != null)
        {
          dictionary.Add((object) this._tBLLOGTableAdapter, (IDbConnection) this._tBLLOGTableAdapter.Connection);
          this._tBLLOGTableAdapter.Connection = (SqlConnection) connection;
          this._tBLLOGTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLLOGTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLLOGTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLLOGTableAdapter.Adapter);
          }
        }
        if (this._tBLMALZBIRIMTableAdapter != null)
        {
          dictionary.Add((object) this._tBLMALZBIRIMTableAdapter, (IDbConnection) this._tBLMALZBIRIMTableAdapter.Connection);
          this._tBLMALZBIRIMTableAdapter.Connection = (SqlConnection) connection;
          this._tBLMALZBIRIMTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLMALZBIRIMTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLMALZBIRIMTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLMALZBIRIMTableAdapter.Adapter);
          }
        }
        if (this._tBLMALZBOLUMTableAdapter != null)
        {
          dictionary.Add((object) this._tBLMALZBOLUMTableAdapter, (IDbConnection) this._tBLMALZBOLUMTableAdapter.Connection);
          this._tBLMALZBOLUMTableAdapter.Connection = (SqlConnection) connection;
          this._tBLMALZBOLUMTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLMALZBOLUMTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLMALZBOLUMTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLMALZBOLUMTableAdapter.Adapter);
          }
        }
        if (this._tBLMALZDEPOTableAdapter != null)
        {
          dictionary.Add((object) this._tBLMALZDEPOTableAdapter, (IDbConnection) this._tBLMALZDEPOTableAdapter.Connection);
          this._tBLMALZDEPOTableAdapter.Connection = (SqlConnection) connection;
          this._tBLMALZDEPOTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLMALZDEPOTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLMALZDEPOTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLMALZDEPOTableAdapter.Adapter);
          }
        }
        if (this._tBLMALZEMELERTableAdapter != null)
        {
          dictionary.Add((object) this._tBLMALZEMELERTableAdapter, (IDbConnection) this._tBLMALZEMELERTableAdapter.Connection);
          this._tBLMALZEMELERTableAdapter.Connection = (SqlConnection) connection;
          this._tBLMALZEMELERTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLMALZEMELERTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLMALZEMELERTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLMALZEMELERTableAdapter.Adapter);
          }
        }
        if (this._tBLMALZGRUPTableAdapter != null)
        {
          dictionary.Add((object) this._tBLMALZGRUPTableAdapter, (IDbConnection) this._tBLMALZGRUPTableAdapter.Connection);
          this._tBLMALZGRUPTableAdapter.Connection = (SqlConnection) connection;
          this._tBLMALZGRUPTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLMALZGRUPTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLMALZGRUPTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLMALZGRUPTableAdapter.Adapter);
          }
        }
        if (this._tBLMALZGRUP2TableAdapter != null)
        {
          dictionary.Add((object) this._tBLMALZGRUP2TableAdapter, (IDbConnection) this._tBLMALZGRUP2TableAdapter.Connection);
          this._tBLMALZGRUP2TableAdapter.Connection = (SqlConnection) connection;
          this._tBLMALZGRUP2TableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLMALZGRUP2TableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLMALZGRUP2TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLMALZGRUP2TableAdapter.Adapter);
          }
        }
        if (this._tBLMALZKDVTableAdapter != null)
        {
          dictionary.Add((object) this._tBLMALZKDVTableAdapter, (IDbConnection) this._tBLMALZKDVTableAdapter.Connection);
          this._tBLMALZKDVTableAdapter.Connection = (SqlConnection) connection;
          this._tBLMALZKDVTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLMALZKDVTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLMALZKDVTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLMALZKDVTableAdapter.Adapter);
          }
        }
        if (this._tBLMALZMARKATableAdapter != null)
        {
          dictionary.Add((object) this._tBLMALZMARKATableAdapter, (IDbConnection) this._tBLMALZMARKATableAdapter.Connection);
          this._tBLMALZMARKATableAdapter.Connection = (SqlConnection) connection;
          this._tBLMALZMARKATableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLMALZMARKATableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLMALZMARKATableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLMALZMARKATableAdapter.Adapter);
          }
        }
        if (this._tBLMENUTableAdapter != null)
        {
          dictionary.Add((object) this._tBLMENUTableAdapter, (IDbConnection) this._tBLMENUTableAdapter.Connection);
          this._tBLMENUTableAdapter.Connection = (SqlConnection) connection;
          this._tBLMENUTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLMENUTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLMENUTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLMENUTableAdapter.Adapter);
          }
        }
        if (this._tBLPERIZINYILLARITableAdapter != null)
        {
          dictionary.Add((object) this._tBLPERIZINYILLARITableAdapter, (IDbConnection) this._tBLPERIZINYILLARITableAdapter.Connection);
          this._tBLPERIZINYILLARITableAdapter.Connection = (SqlConnection) connection;
          this._tBLPERIZINYILLARITableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLPERIZINYILLARITableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLPERIZINYILLARITableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLPERIZINYILLARITableAdapter.Adapter);
          }
        }
        if (this._tBLPERSEGITIMDRMTableAdapter != null)
        {
          dictionary.Add((object) this._tBLPERSEGITIMDRMTableAdapter, (IDbConnection) this._tBLPERSEGITIMDRMTableAdapter.Connection);
          this._tBLPERSEGITIMDRMTableAdapter.Connection = (SqlConnection) connection;
          this._tBLPERSEGITIMDRMTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLPERSEGITIMDRMTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLPERSEGITIMDRMTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLPERSEGITIMDRMTableAdapter.Adapter);
          }
        }
        if (this._tBLPERSEHLIYETTableAdapter != null)
        {
          dictionary.Add((object) this._tBLPERSEHLIYETTableAdapter, (IDbConnection) this._tBLPERSEHLIYETTableAdapter.Connection);
          this._tBLPERSEHLIYETTableAdapter.Connection = (SqlConnection) connection;
          this._tBLPERSEHLIYETTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLPERSEHLIYETTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLPERSEHLIYETTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLPERSEHLIYETTableAdapter.Adapter);
          }
        }
        if (this._tBLPERSIZINDURUMTableAdapter != null)
        {
          dictionary.Add((object) this._tBLPERSIZINDURUMTableAdapter, (IDbConnection) this._tBLPERSIZINDURUMTableAdapter.Connection);
          this._tBLPERSIZINDURUMTableAdapter.Connection = (SqlConnection) connection;
          this._tBLPERSIZINDURUMTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLPERSIZINDURUMTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLPERSIZINDURUMTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLPERSIZINDURUMTableAdapter.Adapter);
          }
        }
        if (this._tBLPERSKURUMGOREVTableAdapter != null)
        {
          dictionary.Add((object) this._tBLPERSKURUMGOREVTableAdapter, (IDbConnection) this._tBLPERSKURUMGOREVTableAdapter.Connection);
          this._tBLPERSKURUMGOREVTableAdapter.Connection = (SqlConnection) connection;
          this._tBLPERSKURUMGOREVTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLPERSKURUMGOREVTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLPERSKURUMGOREVTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLPERSKURUMGOREVTableAdapter.Adapter);
          }
        }
        if (this._tBLPERSMESAITableAdapter != null)
        {
          dictionary.Add((object) this._tBLPERSMESAITableAdapter, (IDbConnection) this._tBLPERSMESAITableAdapter.Connection);
          this._tBLPERSMESAITableAdapter.Connection = (SqlConnection) connection;
          this._tBLPERSMESAITableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLPERSMESAITableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLPERSMESAITableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLPERSMESAITableAdapter.Adapter);
          }
        }
        if (this._tBLPERSONELTableAdapter != null)
        {
          dictionary.Add((object) this._tBLPERSONELTableAdapter, (IDbConnection) this._tBLPERSONELTableAdapter.Connection);
          this._tBLPERSONELTableAdapter.Connection = (SqlConnection) connection;
          this._tBLPERSONELTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLPERSONELTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLPERSONELTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLPERSONELTableAdapter.Adapter);
          }
        }
        if (this._tBLPERSONELDURUMTableAdapter != null)
        {
          dictionary.Add((object) this._tBLPERSONELDURUMTableAdapter, (IDbConnection) this._tBLPERSONELDURUMTableAdapter.Connection);
          this._tBLPERSONELDURUMTableAdapter.Connection = (SqlConnection) connection;
          this._tBLPERSONELDURUMTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLPERSONELDURUMTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLPERSONELDURUMTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLPERSONELDURUMTableAdapter.Adapter);
          }
        }
        if (this._tBLPERSONELISTIHDAMDURUMTableAdapter != null)
        {
          dictionary.Add((object) this._tBLPERSONELISTIHDAMDURUMTableAdapter, (IDbConnection) this._tBLPERSONELISTIHDAMDURUMTableAdapter.Connection);
          this._tBLPERSONELISTIHDAMDURUMTableAdapter.Connection = (SqlConnection) connection;
          this._tBLPERSONELISTIHDAMDURUMTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLPERSONELISTIHDAMDURUMTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLPERSONELISTIHDAMDURUMTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLPERSONELISTIHDAMDURUMTableAdapter.Adapter);
          }
        }
        if (this._tBLPERSONELIZINTableAdapter != null)
        {
          dictionary.Add((object) this._tBLPERSONELIZINTableAdapter, (IDbConnection) this._tBLPERSONELIZINTableAdapter.Connection);
          this._tBLPERSONELIZINTableAdapter.Connection = (SqlConnection) connection;
          this._tBLPERSONELIZINTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLPERSONELIZINTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLPERSONELIZINTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLPERSONELIZINTableAdapter.Adapter);
          }
        }
        if (this._tBLPERSUNVANTableAdapter != null)
        {
          dictionary.Add((object) this._tBLPERSUNVANTableAdapter, (IDbConnection) this._tBLPERSUNVANTableAdapter.Connection);
          this._tBLPERSUNVANTableAdapter.Connection = (SqlConnection) connection;
          this._tBLPERSUNVANTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLPERSUNVANTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLPERSUNVANTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLPERSUNVANTableAdapter.Adapter);
          }
        }
        if (this._tBLPERTOPLANTITableAdapter != null)
        {
          dictionary.Add((object) this._tBLPERTOPLANTITableAdapter, (IDbConnection) this._tBLPERTOPLANTITableAdapter.Connection);
          this._tBLPERTOPLANTITableAdapter.Connection = (SqlConnection) connection;
          this._tBLPERTOPLANTITableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLPERTOPLANTITableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLPERTOPLANTITableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLPERTOPLANTITableAdapter.Adapter);
          }
        }
        if (this._tBLSABITLERTableAdapter != null)
        {
          dictionary.Add((object) this._tBLSABITLERTableAdapter, (IDbConnection) this._tBLSABITLERTableAdapter.Connection);
          this._tBLSABITLERTableAdapter.Connection = (SqlConnection) connection;
          this._tBLSABITLERTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLSABITLERTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLSABITLERTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLSABITLERTableAdapter.Adapter);
          }
        }
        if (this._tBLTALEPTableAdapter != null)
        {
          dictionary.Add((object) this._tBLTALEPTableAdapter, (IDbConnection) this._tBLTALEPTableAdapter.Connection);
          this._tBLTALEPTableAdapter.Connection = (SqlConnection) connection;
          this._tBLTALEPTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLTALEPTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLTALEPTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLTALEPTableAdapter.Adapter);
          }
        }
        if (this._tBLTALEPFISTableAdapter != null)
        {
          dictionary.Add((object) this._tBLTALEPFISTableAdapter, (IDbConnection) this._tBLTALEPFISTableAdapter.Connection);
          this._tBLTALEPFISTableAdapter.Connection = (SqlConnection) connection;
          this._tBLTALEPFISTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLTALEPFISTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLTALEPFISTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLTALEPFISTableAdapter.Adapter);
          }
        }
        if (this._tBLTALEPFISHRKTTableAdapter != null)
        {
          dictionary.Add((object) this._tBLTALEPFISHRKTTableAdapter, (IDbConnection) this._tBLTALEPFISHRKTTableAdapter.Connection);
          this._tBLTALEPFISHRKTTableAdapter.Connection = (SqlConnection) connection;
          this._tBLTALEPFISHRKTTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLTALEPFISHRKTTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLTALEPFISHRKTTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLTALEPFISHRKTTableAdapter.Adapter);
          }
        }
        if (this._tBLTALEPHRKTTableAdapter != null)
        {
          dictionary.Add((object) this._tBLTALEPHRKTTableAdapter, (IDbConnection) this._tBLTALEPHRKTTableAdapter.Connection);
          this._tBLTALEPHRKTTableAdapter.Connection = (SqlConnection) connection;
          this._tBLTALEPHRKTTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLTALEPHRKTTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLTALEPHRKTTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLTALEPHRKTTableAdapter.Adapter);
          }
        }
        if (this._tBLTALEPTEKNIKSARTTableAdapter != null)
        {
          dictionary.Add((object) this._tBLTALEPTEKNIKSARTTableAdapter, (IDbConnection) this._tBLTALEPTEKNIKSARTTableAdapter.Connection);
          this._tBLTALEPTEKNIKSARTTableAdapter.Connection = (SqlConnection) connection;
          this._tBLTALEPTEKNIKSARTTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLTALEPTEKNIKSARTTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLTALEPTEKNIKSARTTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLTALEPTEKNIKSARTTableAdapter.Adapter);
          }
        }
        if (this._tBLTASITGOREVTableAdapter != null)
        {
          dictionary.Add((object) this._tBLTASITGOREVTableAdapter, (IDbConnection) this._tBLTASITGOREVTableAdapter.Connection);
          this._tBLTASITGOREVTableAdapter.Connection = (SqlConnection) connection;
          this._tBLTASITGOREVTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLTASITGOREVTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLTASITGOREVTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLTASITGOREVTableAdapter.Adapter);
          }
        }
        if (this._tBLTASITPERSTableAdapter != null)
        {
          dictionary.Add((object) this._tBLTASITPERSTableAdapter, (IDbConnection) this._tBLTASITPERSTableAdapter.Connection);
          this._tBLTASITPERSTableAdapter.Connection = (SqlConnection) connection;
          this._tBLTASITPERSTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLTASITPERSTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLTASITPERSTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLTASITPERSTableAdapter.Adapter);
          }
        }
        if (this._tBLTEKLIFTableAdapter != null)
        {
          dictionary.Add((object) this._tBLTEKLIFTableAdapter, (IDbConnection) this._tBLTEKLIFTableAdapter.Connection);
          this._tBLTEKLIFTableAdapter.Connection = (SqlConnection) connection;
          this._tBLTEKLIFTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLTEKLIFTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLTEKLIFTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLTEKLIFTableAdapter.Adapter);
          }
        }
        if (this._tBLTEKLIFHRKTTableAdapter != null)
        {
          dictionary.Add((object) this._tBLTEKLIFHRKTTableAdapter, (IDbConnection) this._tBLTEKLIFHRKTTableAdapter.Connection);
          this._tBLTEKLIFHRKTTableAdapter.Connection = (SqlConnection) connection;
          this._tBLTEKLIFHRKTTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLTEKLIFHRKTTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLTEKLIFHRKTTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLTEKLIFHRKTTableAdapter.Adapter);
          }
        }
        if (this._tBLTEKLIFIDARISARTTableAdapter != null)
        {
          dictionary.Add((object) this._tBLTEKLIFIDARISARTTableAdapter, (IDbConnection) this._tBLTEKLIFIDARISARTTableAdapter.Connection);
          this._tBLTEKLIFIDARISARTTableAdapter.Connection = (SqlConnection) connection;
          this._tBLTEKLIFIDARISARTTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLTEKLIFIDARISARTTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLTEKLIFIDARISARTTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLTEKLIFIDARISARTTableAdapter.Adapter);
          }
        }
        if (this._tBLTEKNIKSARTTableAdapter != null)
        {
          dictionary.Add((object) this._tBLTEKNIKSARTTableAdapter, (IDbConnection) this._tBLTEKNIKSARTTableAdapter.Connection);
          this._tBLTEKNIKSARTTableAdapter.Connection = (SqlConnection) connection;
          this._tBLTEKNIKSARTTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLTEKNIKSARTTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLTEKNIKSARTTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLTEKNIKSARTTableAdapter.Adapter);
          }
        }
        if (this._tBLTEKNIKSARTHRKTTableAdapter != null)
        {
          dictionary.Add((object) this._tBLTEKNIKSARTHRKTTableAdapter, (IDbConnection) this._tBLTEKNIKSARTHRKTTableAdapter.Connection);
          this._tBLTEKNIKSARTHRKTTableAdapter.Connection = (SqlConnection) connection;
          this._tBLTEKNIKSARTHRKTTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLTEKNIKSARTHRKTTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLTEKNIKSARTHRKTTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLTEKNIKSARTHRKTTableAdapter.Adapter);
          }
        }
        if (this._tBLVARYOKTableAdapter != null)
        {
          dictionary.Add((object) this._tBLVARYOKTableAdapter, (IDbConnection) this._tBLVARYOKTableAdapter.Connection);
          this._tBLVARYOKTableAdapter.Connection = (SqlConnection) connection;
          this._tBLVARYOKTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLVARYOKTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLVARYOKTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLVARYOKTableAdapter.Adapter);
          }
        }
        if (this._tBLYAKITKONTFORMTableAdapter != null)
        {
          dictionary.Add((object) this._tBLYAKITKONTFORMTableAdapter, (IDbConnection) this._tBLYAKITKONTFORMTableAdapter.Connection);
          this._tBLYAKITKONTFORMTableAdapter.Connection = (SqlConnection) connection;
          this._tBLYAKITKONTFORMTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLYAKITKONTFORMTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLYAKITKONTFORMTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLYAKITKONTFORMTableAdapter.Adapter);
          }
        }
        if (this._tBLYAZIEKLERITableAdapter != null)
        {
          dictionary.Add((object) this._tBLYAZIEKLERITableAdapter, (IDbConnection) this._tBLYAZIEKLERITableAdapter.Connection);
          this._tBLYAZIEKLERITableAdapter.Connection = (SqlConnection) connection;
          this._tBLYAZIEKLERITableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLYAZIEKLERITableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLYAZIEKLERITableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLYAZIEKLERITableAdapter.Adapter);
          }
        }
        if (this._tBLYETKILIMZATableAdapter != null)
        {
          dictionary.Add((object) this._tBLYETKILIMZATableAdapter, (IDbConnection) this._tBLYETKILIMZATableAdapter.Connection);
          this._tBLYETKILIMZATableAdapter.Connection = (SqlConnection) connection;
          this._tBLYETKILIMZATableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLYETKILIMZATableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLYETKILIMZATableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLYETKILIMZATableAdapter.Adapter);
          }
        }
        if (this._tBLARACRESIMTableAdapter != null)
        {
          dictionary.Add((object) this._tBLARACRESIMTableAdapter, (IDbConnection) this._tBLARACRESIMTableAdapter.Connection);
          this._tBLARACRESIMTableAdapter.Connection = (SqlConnection) connection;
          this._tBLARACRESIMTableAdapter.Transaction = (SqlTransaction) dbTransaction;
          if (this._tBLARACRESIMTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._tBLARACRESIMTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._tBLARACRESIMTableAdapter.Adapter);
          }
        }
        if (this.UpdateOrder == TableAdapterManager.UpdateOrderOption.UpdateInsertDelete)
        {
          num += this.UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows);
          num += this.UpdateInsertedRows(dataSet, allAddedRows);
        }
        else
        {
          num += this.UpdateInsertedRows(dataSet, allAddedRows);
          num += this.UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows);
        }
        num += this.UpdateDeletedRows(dataSet, allChangedRows);
        dbTransaction.Commit();
        if (0 < allAddedRows.Count)
        {
          DataRow[] array = new DataRow[allAddedRows.Count];
          allAddedRows.CopyTo(array);
          for (int index = 0; index < array.Length; ++index)
            array[index].AcceptChanges();
        }
        if (0 < allChangedRows.Count)
        {
          DataRow[] array = new DataRow[allChangedRows.Count];
          allChangedRows.CopyTo(array);
          for (int index = 0; index < array.Length; ++index)
            array[index].AcceptChanges();
        }
      }
      catch (Exception ex)
      {
        dbTransaction.Rollback();
        if (this.BackupDataSetBeforeUpdate)
        {
          Debug.Assert(dataSet1 != null);
          dataSet.Clear();
          dataSet.Merge(dataSet1);
        }
        else if (0 < allAddedRows.Count)
        {
          DataRow[] array = new DataRow[allAddedRows.Count];
          allAddedRows.CopyTo(array);
          for (int index = 0; index < array.Length; ++index)
          {
            DataRow dataRow = array[index];
            dataRow.AcceptChanges();
            dataRow.SetAdded();
          }
        }
        throw ex;
      }
      finally
      {
        if (flag)
          connection.Close();
        if (this._fAALIYETTableAdapter != null)
        {
          this._fAALIYETTableAdapter.Connection = (SqlConnection) dictionary[(object) this._fAALIYETTableAdapter];
          this._fAALIYETTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tAHARACDURUMTableAdapter != null)
        {
          this._tAHARACDURUMTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tAHARACDURUMTableAdapter];
          this._tAHARACDURUMTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tAHARACHGSTableAdapter != null)
        {
          this._tAHARACHGSTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tAHARACHGSTableAdapter];
          this._tAHARACHGSTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tAHARACTIPITableAdapter != null)
        {
          this._tAHARACTIPITableAdapter.Connection = (SqlConnection) dictionary[(object) this._tAHARACTIPITableAdapter];
          this._tAHARACTIPITableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tAHARIZANEDENITableAdapter != null)
        {
          this._tAHARIZANEDENITableAdapter.Connection = (SqlConnection) dictionary[(object) this._tAHARIZANEDENITableAdapter];
          this._tAHARIZANEDENITableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tAHBAKIMDERECETableAdapter != null)
        {
          this._tAHBAKIMDERECETableAdapter.Connection = (SqlConnection) dictionary[(object) this._tAHBAKIMDERECETableAdapter];
          this._tAHBAKIMDERECETableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tAHBAKIMTURUTableAdapter != null)
        {
          this._tAHBAKIMTURUTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tAHBAKIMTURUTableAdapter];
          this._tAHBAKIMTURUTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tAHMODELYILITableAdapter != null)
        {
          this._tAHMODELYILITableAdapter.Connection = (SqlConnection) dictionary[(object) this._tAHMODELYILITableAdapter];
          this._tAHMODELYILITableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLARACGRUBUTableAdapter != null)
        {
          this._tBLARACGRUBUTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLARACGRUBUTableAdapter];
          this._tBLARACGRUBUTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLARACGRUBU2TableAdapter != null)
        {
          this._tBLARACGRUBU2TableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLARACGRUBU2TableAdapter];
          this._tBLARACGRUBU2TableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLARACLARTableAdapter != null)
        {
          this._tBLARACLARTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLARACLARTableAdapter];
          this._tBLARACLARTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLARACMARKATableAdapter != null)
        {
          this._tBLARACMARKATableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLARACMARKATableAdapter];
          this._tBLARACMARKATableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLARACMESTKPTableAdapter != null)
        {
          this._tBLARACMESTKPTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLARACMESTKPTableAdapter];
          this._tBLARACMESTKPTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLARACTRFCEZATableAdapter != null)
        {
          this._tBLARACTRFCEZATableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLARACTRFCEZATableAdapter];
          this._tBLARACTRFCEZATableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLARACYEDEKALIMTableAdapter != null)
        {
          this._tBLARACYEDEKALIMTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLARACYEDEKALIMTableAdapter];
          this._tBLARACYEDEKALIMTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLARACZIMMETTableAdapter != null)
        {
          this._tBLARACZIMMETTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLARACZIMMETTableAdapter];
          this._tBLARACZIMMETTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLATOLYEBOLUMTableAdapter != null)
        {
          this._tBLATOLYEBOLUMTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLATOLYEBOLUMTableAdapter];
          this._tBLATOLYEBOLUMTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLATOLYEUSTALARTableAdapter != null)
        {
          this._tBLATOLYEUSTALARTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLATOLYEUSTALARTableAdapter];
          this._tBLATOLYEUSTALARTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLAYARLARTableAdapter != null)
        {
          this._tBLAYARLARTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLAYARLARTableAdapter];
          this._tBLAYARLARTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLBAKIMGRUBUTableAdapter != null)
        {
          this._tBLBAKIMGRUBUTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLBAKIMGRUBUTableAdapter];
          this._tBLBAKIMGRUBUTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLBAKIMTANIMTableAdapter != null)
        {
          this._tBLBAKIMTANIMTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLBAKIMTANIMTableAdapter];
          this._tBLBAKIMTANIMTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLBAKIMYERITableAdapter != null)
        {
          this._tBLBAKIMYERITableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLBAKIMYERITableAdapter];
          this._tBLBAKIMYERITableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLBELDBIRIMLERTableAdapter != null)
        {
          this._tBLBELDBIRIMLERTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLBELDBIRIMLERTableAdapter];
          this._tBLBELDBIRIMLERTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLBELDMUDURLUKTableAdapter != null)
        {
          this._tBLBELDMUDURLUKTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLBELDMUDURLUKTableAdapter];
          this._tBLBELDMUDURLUKTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLBIRIMYETKILILERITableAdapter != null)
        {
          this._tBLBIRIMYETKILILERITableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLBIRIMYETKILILERITableAdapter];
          this._tBLBIRIMYETKILILERITableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLDEPOFISTableAdapter != null)
        {
          this._tBLDEPOFISTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLDEPOFISTableAdapter];
          this._tBLDEPOFISTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLDEPOFISHRKTTableAdapter != null)
        {
          this._tBLDEPOFISHRKTTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLDEPOFISHRKTTableAdapter];
          this._tBLDEPOFISHRKTTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLFIRMALARTableAdapter != null)
        {
          this._tBLFIRMALARTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLFIRMALARTableAdapter];
          this._tBLFIRMALARTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLFIRMASEKTORTableAdapter != null)
        {
          this._tBLFIRMASEKTORTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLFIRMASEKTORTableAdapter];
          this._tBLFIRMASEKTORTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLFORMKULLANICITableAdapter != null)
        {
          this._tBLFORMKULLANICITableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLFORMKULLANICITableAdapter];
          this._tBLFORMKULLANICITableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLIDARISARTHRKTTableAdapter != null)
        {
          this._tBLIDARISARTHRKTTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLIDARISARTHRKTTableAdapter];
          this._tBLIDARISARTHRKTTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLIDARISARTNAMETableAdapter != null)
        {
          this._tBLIDARISARTNAMETableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLIDARISARTNAMETableAdapter];
          this._tBLIDARISARTNAMETableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLIHALELERTableAdapter != null)
        {
          this._tBLIHALELERTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLIHALELERTableAdapter];
          this._tBLIHALELERTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLIHLHAKEDISTableAdapter != null)
        {
          this._tBLIHLHAKEDISTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLIHLHAKEDISTableAdapter];
          this._tBLIHLHAKEDISTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLISEMIRDURUMTableAdapter != null)
        {
          this._tBLISEMIRDURUMTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLISEMIRDURUMTableAdapter];
          this._tBLISEMIRDURUMTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLISEMRITableAdapter != null)
        {
          this._tBLISEMRITableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLISEMRITableAdapter];
          this._tBLISEMRITableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLISEMRIBAKIMLARTableAdapter != null)
        {
          this._tBLISEMRIBAKIMLARTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLISEMRIBAKIMLARTableAdapter];
          this._tBLISEMRIBAKIMLARTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLISEMRIEKRYNLTableAdapter != null)
        {
          this._tBLISEMRIEKRYNLTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLISEMRIEKRYNLTableAdapter];
          this._tBLISEMRIEKRYNLTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLISLEMTIPITableAdapter != null)
        {
          this._tBLISLEMTIPITableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLISLEMTIPITableAdapter];
          this._tBLISLEMTIPITableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLKULLANICILARTableAdapter != null)
        {
          this._tBLKULLANICILARTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLKULLANICILARTableAdapter];
          this._tBLKULLANICILARTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLLOGTableAdapter != null)
        {
          this._tBLLOGTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLLOGTableAdapter];
          this._tBLLOGTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLMALZBIRIMTableAdapter != null)
        {
          this._tBLMALZBIRIMTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLMALZBIRIMTableAdapter];
          this._tBLMALZBIRIMTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLMALZBOLUMTableAdapter != null)
        {
          this._tBLMALZBOLUMTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLMALZBOLUMTableAdapter];
          this._tBLMALZBOLUMTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLMALZDEPOTableAdapter != null)
        {
          this._tBLMALZDEPOTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLMALZDEPOTableAdapter];
          this._tBLMALZDEPOTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLMALZEMELERTableAdapter != null)
        {
          this._tBLMALZEMELERTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLMALZEMELERTableAdapter];
          this._tBLMALZEMELERTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLMALZGRUPTableAdapter != null)
        {
          this._tBLMALZGRUPTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLMALZGRUPTableAdapter];
          this._tBLMALZGRUPTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLMALZGRUP2TableAdapter != null)
        {
          this._tBLMALZGRUP2TableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLMALZGRUP2TableAdapter];
          this._tBLMALZGRUP2TableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLMALZKDVTableAdapter != null)
        {
          this._tBLMALZKDVTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLMALZKDVTableAdapter];
          this._tBLMALZKDVTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLMALZMARKATableAdapter != null)
        {
          this._tBLMALZMARKATableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLMALZMARKATableAdapter];
          this._tBLMALZMARKATableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLMENUTableAdapter != null)
        {
          this._tBLMENUTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLMENUTableAdapter];
          this._tBLMENUTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLPERIZINYILLARITableAdapter != null)
        {
          this._tBLPERIZINYILLARITableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLPERIZINYILLARITableAdapter];
          this._tBLPERIZINYILLARITableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLPERSEGITIMDRMTableAdapter != null)
        {
          this._tBLPERSEGITIMDRMTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLPERSEGITIMDRMTableAdapter];
          this._tBLPERSEGITIMDRMTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLPERSEHLIYETTableAdapter != null)
        {
          this._tBLPERSEHLIYETTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLPERSEHLIYETTableAdapter];
          this._tBLPERSEHLIYETTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLPERSIZINDURUMTableAdapter != null)
        {
          this._tBLPERSIZINDURUMTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLPERSIZINDURUMTableAdapter];
          this._tBLPERSIZINDURUMTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLPERSKURUMGOREVTableAdapter != null)
        {
          this._tBLPERSKURUMGOREVTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLPERSKURUMGOREVTableAdapter];
          this._tBLPERSKURUMGOREVTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLPERSMESAITableAdapter != null)
        {
          this._tBLPERSMESAITableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLPERSMESAITableAdapter];
          this._tBLPERSMESAITableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLPERSONELTableAdapter != null)
        {
          this._tBLPERSONELTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLPERSONELTableAdapter];
          this._tBLPERSONELTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLPERSONELDURUMTableAdapter != null)
        {
          this._tBLPERSONELDURUMTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLPERSONELDURUMTableAdapter];
          this._tBLPERSONELDURUMTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLPERSONELISTIHDAMDURUMTableAdapter != null)
        {
          this._tBLPERSONELISTIHDAMDURUMTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLPERSONELISTIHDAMDURUMTableAdapter];
          this._tBLPERSONELISTIHDAMDURUMTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLPERSONELIZINTableAdapter != null)
        {
          this._tBLPERSONELIZINTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLPERSONELIZINTableAdapter];
          this._tBLPERSONELIZINTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLPERSUNVANTableAdapter != null)
        {
          this._tBLPERSUNVANTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLPERSUNVANTableAdapter];
          this._tBLPERSUNVANTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLPERTOPLANTITableAdapter != null)
        {
          this._tBLPERTOPLANTITableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLPERTOPLANTITableAdapter];
          this._tBLPERTOPLANTITableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLSABITLERTableAdapter != null)
        {
          this._tBLSABITLERTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLSABITLERTableAdapter];
          this._tBLSABITLERTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLTALEPTableAdapter != null)
        {
          this._tBLTALEPTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLTALEPTableAdapter];
          this._tBLTALEPTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLTALEPFISTableAdapter != null)
        {
          this._tBLTALEPFISTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLTALEPFISTableAdapter];
          this._tBLTALEPFISTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLTALEPFISHRKTTableAdapter != null)
        {
          this._tBLTALEPFISHRKTTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLTALEPFISHRKTTableAdapter];
          this._tBLTALEPFISHRKTTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLTALEPHRKTTableAdapter != null)
        {
          this._tBLTALEPHRKTTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLTALEPHRKTTableAdapter];
          this._tBLTALEPHRKTTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLTALEPTEKNIKSARTTableAdapter != null)
        {
          this._tBLTALEPTEKNIKSARTTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLTALEPTEKNIKSARTTableAdapter];
          this._tBLTALEPTEKNIKSARTTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLTASITGOREVTableAdapter != null)
        {
          this._tBLTASITGOREVTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLTASITGOREVTableAdapter];
          this._tBLTASITGOREVTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLTASITPERSTableAdapter != null)
        {
          this._tBLTASITPERSTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLTASITPERSTableAdapter];
          this._tBLTASITPERSTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLTEKLIFTableAdapter != null)
        {
          this._tBLTEKLIFTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLTEKLIFTableAdapter];
          this._tBLTEKLIFTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLTEKLIFHRKTTableAdapter != null)
        {
          this._tBLTEKLIFHRKTTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLTEKLIFHRKTTableAdapter];
          this._tBLTEKLIFHRKTTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLTEKLIFIDARISARTTableAdapter != null)
        {
          this._tBLTEKLIFIDARISARTTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLTEKLIFIDARISARTTableAdapter];
          this._tBLTEKLIFIDARISARTTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLTEKNIKSARTTableAdapter != null)
        {
          this._tBLTEKNIKSARTTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLTEKNIKSARTTableAdapter];
          this._tBLTEKNIKSARTTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLTEKNIKSARTHRKTTableAdapter != null)
        {
          this._tBLTEKNIKSARTHRKTTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLTEKNIKSARTHRKTTableAdapter];
          this._tBLTEKNIKSARTHRKTTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLVARYOKTableAdapter != null)
        {
          this._tBLVARYOKTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLVARYOKTableAdapter];
          this._tBLVARYOKTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLYAKITKONTFORMTableAdapter != null)
        {
          this._tBLYAKITKONTFORMTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLYAKITKONTFORMTableAdapter];
          this._tBLYAKITKONTFORMTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLYAZIEKLERITableAdapter != null)
        {
          this._tBLYAZIEKLERITableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLYAZIEKLERITableAdapter];
          this._tBLYAZIEKLERITableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLYETKILIMZATableAdapter != null)
        {
          this._tBLYETKILIMZATableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLYETKILIMZATableAdapter];
          this._tBLYETKILIMZATableAdapter.Transaction = (SqlTransaction) null;
        }
        if (this._tBLARACRESIMTableAdapter != null)
        {
          this._tBLARACRESIMTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tBLARACRESIMTableAdapter];
          this._tBLARACRESIMTableAdapter.Transaction = (SqlTransaction) null;
        }
        if (0 < dataAdapterList.Count)
        {
          DataAdapter[] array = new DataAdapter[dataAdapterList.Count];
          dataAdapterList.CopyTo(array);
          for (int index = 0; index < array.Length; ++index)
            array[index].AcceptChangesDuringUpdate = true;
        }
      }
      return num;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected virtual void SortSelfReferenceRows(
      DataRow[] rows,
      DataRelation relation,
      bool childFirst)
    {
      Array.Sort<DataRow>(rows, (IComparer<DataRow>) new TableAdapterManager.SelfReferenceComparer(relation, childFirst));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected virtual bool MatchTableAdapterConnection(IDbConnection inputConnection) => this._connection != null || this.Connection == null || inputConnection == null || string.Equals(this.Connection.ConnectionString, inputConnection.ConnectionString, StringComparison.Ordinal);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public enum UpdateOrderOption
    {
      InsertUpdateDelete,
      UpdateInsertDelete,
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private class SelfReferenceComparer : IComparer<DataRow>
    {
      private DataRelation _relation;
      private int _childFirst;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal SelfReferenceComparer(DataRelation relation, bool childFirst)
      {
        this._relation = relation;
        if (childFirst)
          this._childFirst = -1;
        else
          this._childFirst = 1;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      private DataRow GetRoot(DataRow row, out int distance)
      {
        Debug.Assert(row != null);
        DataRow root = row;
        distance = 0;
        IDictionary<DataRow, DataRow> dictionary = (IDictionary<DataRow, DataRow>) new Dictionary<DataRow, DataRow>();
        dictionary[row] = row;
        for (DataRow parentRow = row.GetParentRow(this._relation, DataRowVersion.Default); parentRow != null && !dictionary.ContainsKey(parentRow); parentRow = parentRow.GetParentRow(this._relation, DataRowVersion.Default))
        {
          ++distance;
          root = parentRow;
          dictionary[parentRow] = parentRow;
        }
        if (distance == 0)
        {
          dictionary.Clear();
          dictionary[row] = row;
          for (DataRow parentRow = row.GetParentRow(this._relation, DataRowVersion.Original); parentRow != null && !dictionary.ContainsKey(parentRow); parentRow = parentRow.GetParentRow(this._relation, DataRowVersion.Original))
          {
            ++distance;
            root = parentRow;
            dictionary[parentRow] = parentRow;
          }
        }
        return root;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int Compare(DataRow row1, DataRow row2)
      {
        if (row1 == row2)
          return 0;
        if (row1 == null)
          return -1;
        if (row2 == null)
          return 1;
        int distance1 = 0;
        DataRow root1 = this.GetRoot(row1, out distance1);
        int distance2 = 0;
        DataRow root2 = this.GetRoot(row2, out distance2);
        if (root1 == root2)
          return this._childFirst * distance1.CompareTo(distance2);
        Debug.Assert(root1.Table != null && root2.Table != null);
        return root1.Table.Rows.IndexOf(root1) < root2.Table.Rows.IndexOf(root2) ? -1 : 1;
      }
    }
  }
}
