/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.servlet.Login;

import com.servlet.DataBase.DataBaseConnection;
import java.io.*;
import static java.lang.System.out;
import javax.servlet.ServletException;
import javax.servlet.http.*;

/**
 *
 * @author ALİ KARACA
 */
public class SignUp extends HttpServlet {

    public static String KayitName, KayitPass, KayitYenidenPass, KayitSorusu, KayitCevap;
    protected String myParam = null;
    static String Sonuc = "";
    static String Sonuc2 = "";

    public static String UyeKayit(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {

        try {

            //veriler javascript'den çekilir
            KayitName = request.getParameter("Email");
            KayitPass = request.getParameter("Password");
            KayitYenidenPass = request.getParameter("YenidenPass");
            KayitCevap = request.getParameter("GunvenlikCevap");
            KayitSorusu = request.getParameter("GuvenlikSoru");
            //hata olması durumuna karşın veriler yazdırılır
            System.out.println(KayitName);
            System.out.println(KayitPass);
            System.out.println(KayitYenidenPass);
            System.out.println(KayitCevap);
            System.out.println(KayitSorusu);
            DataBaseConnection Baglan = new DataBaseConnection();

            //kayit işleminde null karakter kullanılıp kullanılmadığı tespit edilir
            if (!"".equals(KayitName) && !"".equals(KayitPass) && !"".equals(KayitYenidenPass) && KayitPass.equals(KayitYenidenPass) && !"".equals(KayitCevap) && !"".equals(KayitSorusu)) {

                if (Baglan.KullaniciKontrol(KayitName) == false) {
                    try {
                        Baglan.KullaniciKayit(KayitName, KayitPass, "", KayitSorusu, KayitCevap);
                        Sonuc = "1";
                        return Sonuc;//kullanıcı başarı ile eklenilmişse geriye 1 sitringi döndürülür
                    } catch (Exception ex) {
                        Sonuc = "0";//hatalı işlem olursa işlem sonucu 0 olarak geri döndürülür
                        return Sonuc;
                    }
                } else if (Baglan.KullaniciGiris(KayitName, KayitPass) == true)//eğer kullanıncı varsa sonuc olarak 2 sitringi döner
                {
                    Sonuc = "2";
                    return Sonuc;
                }

            } else {
                Sonuc = "0";
                return Sonuc;
            }
        } catch (Exception ex) {
            out.println("Exemption :" + ex.getMessage());
            Sonuc = "0";
            return Sonuc;
        }
        return Sonuc;
    }

    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {

        response.setContentType("text/plain");
        response.getWriter().write(UyeKayit(request, response));//burada uye kayit fonksiyonundan dönen sonuç ile geri dönecek sonuc bastırılır

    }

}
