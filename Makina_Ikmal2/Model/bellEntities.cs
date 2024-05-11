// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Model.bellEntities
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Makina_Ikmal.Model
{
  public class bellEntities : DbContext
  {
    public bellEntities()
      : base("name=bellEntities")
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder) => throw new UnintentionalCodeFirstException();

    public virtual DbSet<Makina_Ikmal.Model.FAALIYET> FAALIYET { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.HAKEDISAKARYAKIT> HAKEDISAKARYAKIT { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.HAKEDISYDKARAC> HAKEDISYDKARAC { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TAHARACDURUM> TAHARACDURUM { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TAHARACHGS> TAHARACHGS { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TAHARACTIPI> TAHARACTIPI { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TAHARIZANEDENI> TAHARIZANEDENI { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TAHBAKIMDERECE> TAHBAKIMDERECE { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TAHBAKIMTURU> TAHBAKIMTURU { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TAHMODELYILI> TAHMODELYILI { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLARACGRUBU> TBLARACGRUBU { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLARACGRUBU2> TBLARACGRUBU2 { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLARACIHALEGRUP> TBLARACIHALEGRUP { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLARACLAR> TBLARACLAR { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLARACMARKA> TBLARACMARKA { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLARACMESTKP> TBLARACMESTKP { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLARACRESIM> TBLARACRESIM { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLARACTRFCEZA> TBLARACTRFCEZA { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLARACYEDEKALIM> TBLARACYEDEKALIM { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLARACZIMMET> TBLARACZIMMET { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLATOLYEBOLUM> TBLATOLYEBOLUM { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLATOLYEUSTALAR> TBLATOLYEUSTALAR { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLAYARLAR> TBLAYARLAR { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLBAKIMGRUBU> TBLBAKIMGRUBU { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLBAKIMTANIM> TBLBAKIMTANIM { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLBAKIMYERI> TBLBAKIMYERI { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLBELDBIRIMLER> TBLBELDBIRIMLER { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLBELDMUDURLUK> TBLBELDMUDURLUK { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLBIRIMYETKILILERI> TBLBIRIMYETKILILERI { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLDEPOFIS> TBLDEPOFIS { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLDEPOFISHRKT> TBLDEPOFISHRKT { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLFIRMALAR> TBLFIRMALAR { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLFORMKULLANICI> TBLFORMKULLANICI { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLHAKARACHRKT> TBLHAKARACHRKT { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLHAKEDISANA> TBLHAKEDISANA { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLHAKEDISARACLAR> TBLHAKEDISARACLAR { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLHAKEDISTIP> TBLHAKEDISTIP { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLHAKEDISTIPHRKT> TBLHAKEDISTIPHRKT { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLIDARISARTHRKT> TBLIDARISARTHRKT { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLIDARISARTNAME> TBLIDARISARTNAME { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLIHALELER> TBLIHALELER { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLIHLHAKEDIS> TBLIHLHAKEDIS { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLISEMIRDURUM> TBLISEMIRDURUM { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLISEMRI> TBLISEMRI { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLISEMRIBAKIMLAR> TBLISEMRIBAKIMLAR { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLISEMRIEKRYNL> TBLISEMRIEKRYNL { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLISLEMTIPI> TBLISLEMTIPI { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLKULLANICILAR> TBLKULLANICILAR { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLLOG> TBLLOG { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLMALZBIRIM> TBLMALZBIRIM { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLMALZBOLUM> TBLMALZBOLUM { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLMALZDEPO> TBLMALZDEPO { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLMALZEMELER> TBLMALZEMELER { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLMALZGRUP> TBLMALZGRUP { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLMALZGRUP2> TBLMALZGRUP2 { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLMALZKDV> TBLMALZKDV { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLMALZMARKA> TBLMALZMARKA { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLMENU> TBLMENU { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLPERIZINYILLARI> TBLPERIZINYILLARI { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLPERSEGITIMDRM> TBLPERSEGITIMDRM { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLPERSEHLIYET> TBLPERSEHLIYET { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLPERSIZINDURUM> TBLPERSIZINDURUM { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLPERSKURUMGOREV> TBLPERSKURUMGOREV { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLPERSMESAI> TBLPERSMESAI { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLPERSONEL> TBLPERSONEL { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLPERSONELDURUM> TBLPERSONELDURUM { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLPERSONELISTIHDAMDURUM> TBLPERSONELISTIHDAMDURUM { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLPERSONELIZIN> TBLPERSONELIZIN { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLPERSUNVAN> TBLPERSUNVAN { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLPERTOPLANTI> TBLPERTOPLANTI { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLSABITLER> TBLSABITLER { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLTALEP> TBLTALEP { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLTALEPFIS> TBLTALEPFIS { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLTALEPFISHRKT> TBLTALEPFISHRKT { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLTALEPHRKT> TBLTALEPHRKT { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLTALEPTEKNIKSART> TBLTALEPTEKNIKSART { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLTASITGOREV> TBLTASITGOREV { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLTASITPERS> TBLTASITPERS { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLTEKLIF> TBLTEKLIF { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLTEKLIFHRKT> TBLTEKLIFHRKT { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLTEKLIFIDARISART> TBLTEKLIFIDARISART { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLTEKNIKSART> TBLTEKNIKSART { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLTEKNIKSARTHRKT> TBLTEKNIKSARTHRKT { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLVARYOK> TBLVARYOK { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLYAKITKARTI> TBLYAKITKARTI { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLYAKITKONTFORM> TBLYAKITKONTFORM { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLYAZIEKLERI> TBLYAZIEKLERI { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLYETKILIMZA> TBLYETKILIMZA { get; set; }

    public virtual DbSet<Makina_Ikmal.Model.TBLFIRMASEKTOR> TBLFIRMASEKTOR { get; set; }
  }
}
