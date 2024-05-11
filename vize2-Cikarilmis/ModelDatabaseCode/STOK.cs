using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace vize2.Database4
{

    public partial class STOK
    {
        public STOK(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
