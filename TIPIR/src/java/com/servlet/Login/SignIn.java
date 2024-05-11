/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.servlet.Login;

import com.servlet.DataBase.DataBaseConnection;
import java.io.IOException;
import static java.lang.System.out;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpSession;

/**
 *
 * @author ALİ KARACA
 */
@WebServlet("/SigIn")
public class SignIn extends HttpServlet {

    public static String _UserName, _Password, _Image;
    String Sonuc = "";

    //static boolean asd;
    //@RequestMapping(value=“SignIn”, method=RequestMethod.POST)
    private String uyegiris(HttpServletRequest request) throws ServletException, IOException {
        try {
            _UserName = request.getParameter("Email");
            _Password = request.getParameter("Password");
            System.out.println(_UserName);
            System.out.println(_Password);
            if (_UserName != null && _Password != null) {
                DataBaseConnection Baglan = new DataBaseConnection();

                if (Baglan.KullaniciGiris(_UserName, _Password) == true) {
                    //response.sendRedirect("check.jsp"); 
                    HttpSession oturum = request.getSession();
                    oturum.setAttribute("KullaniciMail", _UserName);
                    oturum.setAttribute("KullaniciSifre", _Password);

                    Sonuc = "1";
                    return Sonuc;
                } else {
                    Sonuc = "0";
                    return Sonuc;
                }
            } else {
                System.out.println("ghelloooo");
                Sonuc = "0";
                return Sonuc;
            }
        } catch (Exception ex) {
            out.println("Exemption :" + ex.getMessage());
            Sonuc = "0";
            return Sonuc;
        }
    }

    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        response.setContentType("text/plain");
        response.getWriter().write(uyegiris(request));
    }

}
