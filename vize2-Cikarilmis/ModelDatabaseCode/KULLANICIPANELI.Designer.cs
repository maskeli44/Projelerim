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

    public partial class KULLANICIPANELI : XPLiteObject
    {
        string fad;
        [Size(255)]
        public string ad
        {
            get { return fad; }
            set { SetPropertyValue<string>(nameof(ad), ref fad, value); }
        }
        int fid;
        [Key(true)]
        public int id
        {
            get { return fid; }
            set { SetPropertyValue<int>(nameof(id), ref fid, value); }
        }
        string fnick;
        [Size(255)]
        public string nick
        {
            get { return fnick; }
            set { SetPropertyValue<string>(nameof(nick), ref fnick, value); }
        }
        string fsifre;
        [Size(255)]
        public string sifre
        {
            get { return fsifre; }
            set { SetPropertyValue<string>(nameof(sifre), ref fsifre, value); }
        }
        string fsoyad;
        [Size(255)]
        public string soyad
        {
            get { return fsoyad; }
            set { SetPropertyValue<string>(nameof(soyad), ref fsoyad, value); }
        }
        string ftel;
        [Size(255)]
        public string tel
        {
            get { return ftel; }
            set { SetPropertyValue<string>(nameof(tel), ref ftel, value); }
        }
        string ftip;
        [Size(255)]
        public string tip
        {
            get { return ftip; }
            set { SetPropertyValue<string>(nameof(tip), ref ftip, value); }
        }
        [Association(@"AMBARReferencesKULLANICIPANELI")]
        public XPCollection<AMBAR> AMBARs { get { return GetCollection<AMBAR>(nameof(AMBARs)); } }
    }

}