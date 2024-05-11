/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.servlet.DataBase;

import java.sql.*;

/**
 *
 * @author ALİ KARACA
 */
public class DataBaseConnection {

    static final String JBDC_DRIVER = "com.mysql.jdbc.Driver";
    static final String DOMAIN_NAME = "projedb.cfcbomc1men9.us-east-1.rds.amazonaws.com";
    static final String DB_NAME = "projedb";
    static final String DB_URL = "jdbc:mysql://" + DOMAIN_NAME + "/" + DB_NAME;
    static final String USER = "root";
    static final String PASS = "Zarfali44.";
            
    static Connection Conn = null;
    static Statement Stat = null;

    public DataBaseConnection() {

    }

    public static void Baglan() {
        try {
            Class.forName("com.mysql.jdbc.Driver").newInstance();
            Conn = (Connection) DriverManager.getConnection(DB_URL, USER, PASS);

        } catch (ClassNotFoundException | IllegalAccessException | InstantiationException | SQLException e) {

        }
    }

    static void BaglantiKapa() {

        try {
            if (Stat != null) {
                Conn.close();
            }
            try {
                if (Conn != null) {
                    Conn.close();
                }
            } catch (SQLException ex) {
                System.out.println("hata3 oldu" + ex.getLocalizedMessage());
            }
        } catch (SQLException ex) {
            System.out.println("hata2 oldu" + ex.getLocalizedMessage());
        }

    }

    public boolean KullaniciGiris(String Email, String Pass) {
        try {
            Baglan();

            String Sorgu = "SELECT * FROM kullanicilar where nick=? and pass =? ";
            PreparedStatement stmt = Conn.prepareStatement(Sorgu);
            stmt.setString(1, Email);
            stmt.setString(2, Pass);

            ResultSet rs = stmt.executeQuery();

            if (rs.next()) {
                BaglantiKapa();

                return true;
            } else {
                BaglantiKapa();

                return false;
            }

        } catch (SQLException ex) {
            BaglantiKapa();
            System.out.println("Ex:" + ex.getMessage());
            return false;
        }

    }

    public boolean KullaniciKontrol(String Email) {
        try {
            Baglan();

            String Sorgu = "SELECT * FROM kullanicilar where nick=? ";
            PreparedStatement stmt = Conn.prepareStatement(Sorgu);
            stmt.setString(1, Email);
            ResultSet rs = stmt.executeQuery();

            if (rs.next()) {
                BaglantiKapa();

                return true;
            } else {
                BaglantiKapa();

                return false;
            }

        } catch (SQLException ex) {
            BaglantiKapa();
            System.out.println("Ex:" + ex.getMessage());
            return false;
        }

    }

    public void KullaniciKayit(String Email, String Sifre, String Resim, String Soru, String Cevap) {
        try {
            Baglan();
            String Sorgu = "insert into kullanicilar (nick,pass,guvenliksorusu,guvenlikcevap,resim) VALUES (?,?,?,?,?)";//sorgunalacak ifade string ifadeye atanır
            try (PreparedStatement stmt = Conn.prepareStatement(Sorgu)) {

                stmt.setString(1, Email);
                stmt.setString(2, Sifre);

                stmt.setString(3, Soru);
                stmt.setString(4, Cevap);
                stmt.setString(5, Resim);
                stmt.executeUpdate();

                BaglantiKapa();
            } catch (Exception ex) {
                BaglantiKapa();
            }
        } catch (Exception ex) {
            System.out.println("Ex:" + ex.getMessage());
            BaglantiKapa();
        }
    }

    public static String DatabeseImageUpdate(String KullaniciMail, String DosyaAdi) {
        String Resim = "";
        try {
            Baglan();
            String Sorgu = "UPDATE `kullanicilar` SET resim =? WHERE `kullanicilar`.`nick` = ?";
            Resim = "image/" + DosyaAdi;
            //System.out.println(resim);
            //System.out.println(kullanici_mail);
            try (PreparedStatement stmt = Conn.prepareStatement(Sorgu)) {
                stmt.setString(1, Resim);
                stmt.setString(2, KullaniciMail);
                stmt.executeUpdate();
                System.out.println("resim veritabanina eklendi");
                BaglantiKapa();
            } catch (Exception ex) {
                System.out.println("resim veri tabanina eklenemedi");
                BaglantiKapa();
            }
        } catch (Exception ex) {
            System.out.println("hatali veritabani islemi");
            BaglantiKapa();
        }

        return Resim;
    }

    public String UserImageLoad(String MakaleKullaniciMail) {
        String Image;
        try {
            Baglan();
            DataBaseConnection Baglan = new DataBaseConnection();
            String Sorgu = "SELECT * from kullanicilar where nick=?";
            PreparedStatement stat = Conn.prepareStatement(Sorgu);
            stat.setString(1, MakaleKullaniciMail);
            ResultSet rs = stat.executeQuery();
            if (rs.next()) {
                Image = rs.getString("resim");
                BaglantiKapa();
                //System.out.println("resimyüklendi");
                return Image;
            } else {
                //System.out.println("hata resim sessiona ekelenemedi");
                BaglantiKapa();
                return Image = "";
            }

        } catch (SQLException ex) {
            System.out.println("Ex:" + ex.getMessage());
            BaglantiKapa();
            return Image = "";
        }

    }

    public boolean UserImageRemove(String Kullanici_Mail) {
        Baglan();
        String Sorgu = "UPDATE `kullanicilar` SET resim =? WHERE `kullanicilar`.`nick` = ?";
        try {
            try (PreparedStatement stmt = Conn.prepareStatement(Sorgu)) {
                stmt.setString(1, "");
                stmt.setString(2, Kullanici_Mail);
                stmt.executeUpdate();
                System.out.println("resim veritabanindan silindi");
                BaglantiKapa();
                return true;
            } catch (Exception ex) {
                System.out.println("resim veri tabanindan silinemedi");
                BaglantiKapa();
                return false;
            }

        } catch (Exception ex) {
            System.out.println("Ex:" + ex.getMessage());
            BaglantiKapa();
            return false;
        }
    }

    public String SifremiUnuttum(String Eposta, String Sifre, String YenidenSifre, String GuvenlikSorusu, String GuvenliCevap) {
        Baglan();
        String Kontrol;
        try {
            boolean Kullanici_Var_Onay = KullaniciCevapKontrol(Eposta, GuvenlikSorusu, GuvenliCevap);
            System.out.println(Kullanici_Var_Onay);
            if (Sifre != null && YenidenSifre != null && Kullanici_Var_Onay != false && Sifre.equals(YenidenSifre)) {
                System.out.println("kontrol edildi");
                String sorgu = "UPDATE `kullanicilar` SET `pass` =? WHERE `kullanicilar`.`nick` = ?";//sorgunalacak ifade string ifadeye atanır
                try (PreparedStatement stmt = Conn.prepareStatement(sorgu)) {
                    stmt.setString(1, Sifre);
                    stmt.setString(2, Eposta);
                    stmt.executeUpdate();
                    Kontrol = "1";
                    BaglantiKapa();
                    return Kontrol;//kullanıcı başarı ile eklenilmişse geriye 1 sitringi döndürülür
                } catch (Exception ex) {
                    System.out.println(ex.getMessage());
                    Kontrol = "0";//hatalı işlem olursa işlem sonucu 0 olarak geri döndürülür
                    BaglantiKapa();
                    return Kontrol;
                }
            } else {
                Kontrol = "0";
                BaglantiKapa();
                return Kontrol;
            }
        } catch (Exception ex) {
            Kontrol = "0";
            System.out.println("Ex:" + ex.getMessage());
            BaglantiKapa();
            return Kontrol;
        }

    }

    public boolean KullaniciCevapKontrol(String Eposta, String GuvenlikSorusu, String GuvenliCevap) {
        System.out.println("GEldi");//kullanıcının daha önce kayıt olup olmadığını bu fonksiyon sayesinde anlayabiliriz

        try {

            if (Eposta != null && GuvenlikSorusu != null && GuvenliCevap != null) {
                Baglan();
                String sorgu = "SELECT * from kullanicilar where nick=? and guvenliksorusu=? and guvenlikcevap=?";
                PreparedStatement stmt = Conn.prepareStatement(sorgu);
                stmt.setString(1, Eposta);
                stmt.setString(2, GuvenlikSorusu);
                stmt.setString(3, GuvenliCevap);
                ResultSet rs = stmt.executeQuery();
                return rs.next(); //bu kullanıcı daha önceden var mesajıdır
                //kullanıcı daha önce yoktur
            } else {
                System.out.println("ghelloooo");
                return false;//eğer kayit boş karakter ise bu kullancı var seçlinde 1 döner
            }
        } catch (SQLException ex) {
            System.out.println("Ex:" + ex.getMessage());
            return false;//hata durumunda işlem olmaması için bu kullanıcı var döner
        }
    }

    public boolean MakaleGuncelle(String MakaleId, String MakaleBaslik, String MakaleKonu, String MakaleIcerik,String MakaleResim) {
        Baglan();
        try {
            DataBaseConnection.Baglan();

            String sorgu = "UPDATE `makale` SET makale_baslik =? , makale_konu=? , makale_icerik=? , makale_resim=? WHERE makale_id = ?";
            try (PreparedStatement stmt = Conn.prepareStatement(sorgu)) {
                stmt.setString(1, MakaleBaslik);
                stmt.setString(2, MakaleKonu);
                stmt.setString(3, MakaleIcerik);
                stmt.setString(4, MakaleResim);
                stmt.setString(5, MakaleId);
                stmt.executeUpdate();
                BaglantiKapa();
                return true;
            } catch (Exception ex) {
                System.out.println("Ex:" + ex.getMessage());
                BaglantiKapa();
                return false;
            }
        } catch (Exception ex2) {
            System.out.println("Ex2:" + ex2.getMessage());
            BaglantiKapa();
            return false;
        }
    }

    public void MakaleEkle(String MakaleBaslik, String MakaleKonu, String MakaleIcerik, String KullaniciMail,String MakaleResim) {
        try {
            Baglan();
            
            String Sorgu = "insert into makale (makale_baslik,makale_konu,makale_icerik,kullanici_nick,makale_resim) VALUES (?,?,?,?,?)";
            
            try (PreparedStatement stmt = Conn.prepareStatement(Sorgu)) {

                stmt.setString(1, MakaleBaslik);
                stmt.setString(2, MakaleKonu);

                stmt.setString(3, MakaleIcerik);
                stmt.setString(4, KullaniciMail);
                stmt.setString(5, MakaleResim);
                stmt.executeUpdate();
                String Sorgu2="select * from makale where makale=?";
                
            } catch (Exception ex) {
                System.out.println("veritabanina bilgi eklenemedi"+ex);
                
            }
            BaglantiKapa();
            
        } catch (Exception e) {
            BaglantiKapa();
            
        }
    }

    public void MakaleSil(String MakaleId) {
        try {
            Baglan();
            String sorgu = "DELETE FROM `makale` where makale_id=? ";//database bağlantısını açar
            try (PreparedStatement stmt = Conn.prepareStatement(sorgu)) {
                stmt.setString(1, MakaleId);
                stmt.executeUpdate();
                BaglantiKapa();
            } catch (Exception ex) {
                System.out.println("islem hatası");
                BaglantiKapa();
            }
        } catch (Exception ex) {
            System.out.println("Ex:" + ex.getMessage());
            BaglantiKapa();
        }
    }

   
   

    public int OkunmaSayisi(String MakaleID, String Okuyucu) {
        int i = 0;
        try {
            Baglan();
            String Sorgu = "insert into OkunmaSayisi (Okuyucu,MakaleID)values(?,?)";
            try (PreparedStatement stmt = Conn.prepareStatement(Sorgu)) {
                if (Okuyucu == null) {
                    Okuyucu = "Misafir";
                }
                stmt.setString(1, Okuyucu);
                stmt.setString(2, MakaleID);
                stmt.executeUpdate();
                try {
                    String Sorgu2 = "select * from OkunmaSayisi where MakaleID=?";
                    PreparedStatement stmt2 = Conn.prepareStatement(Sorgu2);
                    stmt2.setString(1, MakaleID);
                    ResultSet rs = stmt2.executeQuery();
                    while (rs.next()) {
                        i = i + 1;
                    }
                    BaglantiKapa();
                    return i;
                } catch (SQLException exx) {

                    System.out.println("ex:" + exx);
                    BaglantiKapa();
                    return i;
                }

            } catch (SQLException ex) {
                System.out.println("ex:" + ex);
                BaglantiKapa();
                return i;
            }

        } catch (Exception e) {
            System.out.println("ex:" + e);
            BaglantiKapa();
            return i;
        }
    }

}
