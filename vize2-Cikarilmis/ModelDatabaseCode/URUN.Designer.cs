﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace vize2.Database4
{

    public partial class URUN : XPLiteObject
    {
        string fad;
        [Size(255)]
        public string ad
        {
            get { return fad; }
            set { SetPropertyValue<string>(nameof(ad), ref fad, value); }
        }
        int fbirimdeğer;
        [ColumnDbDefaultValue("0")]
        public int birimdeğer
        {
            get { return fbirimdeğer; }
            set { SetPropertyValue<int>(nameof(birimdeğer), ref fbirimdeğer, value); }
        }
        int fid;
        [Key(true)]
        public int id
        {
            get { return fid; }
            set { SetPropertyValue<int>(nameof(id), ref fid, value); }
        }
        [Association(@"STOKReferencesURUN")]
        public XPCollection<STOK> STOKs { get { return GetCollection<STOK>(nameof(STOKs)); } }
    }

}