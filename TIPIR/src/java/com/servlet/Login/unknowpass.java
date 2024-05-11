/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.servlet.Login;

import com.servlet.DataBase.DataBaseConnection;
import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 *
 * @author ALİ KARACA
 */
public class unknowpass extends HttpServlet {

    static String Eposta, Sifre, YenidenSifre, GunvenlikSorusu, GuvenlikCevap;

    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        Eposta = request.getParameter("Email");
        Sifre = request.getParameter("Password");
        YenidenSifre = request.getParameter("YenidenPassword");
        GunvenlikSorusu = request.getParameter("GuvenlikCevap");
        GuvenlikCevap = request.getParameter("GuvenlikSoru");
        System.out.println(GunvenlikSorusu);
        System.out.println(GuvenlikCevap);
        System.out.println(Sifre);
        System.out.println(YenidenSifre);
        DataBaseConnection Baglan = new DataBaseConnection();
        response.setContentType("text/plain");
        response.getWriter().write(Baglan.SifremiUnuttum(Eposta, Sifre, YenidenSifre, GunvenlikSorusu, GuvenlikCevap));//burada uye kayit fonksiyonundan dönen sonuç ile geri dönecek sonuc bastırılır
    }
}
