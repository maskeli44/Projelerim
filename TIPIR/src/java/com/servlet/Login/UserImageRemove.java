/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.servlet.Login;

import com.servlet.DataBase.DataBaseConnection;
import java.io.File;
import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

/**
 *
 * @author ALİ KARACA
 */
public class UserImageRemove extends HttpServlet {

    /**
     * Processes requests for both HTTP <code>GET</code> and <code>POST</code> methods.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    protected void processRequest(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        String realPath = "\\TIPIR\\web\\";
        //String realPath=getServletContext().getRealPath(request.getParameter("dosyayolu"));
        System.out.println(realPath);
        // String aFileName = "D:\\önemli\\java projeler\\TIPIR\\web\\";
        String aFileName = realPath + request.getParameter("DosyaYolu");
        HttpSession oturum = request.getSession();
        String KullaniciMail = (String) oturum.getAttribute("KullaniciMail");

        // System.out.println(aFileName);
        File file = new File(aFileName);

        try {

            DataBaseConnection Baglan = new DataBaseConnection();
            if (!file.isDirectory()) {

                if (file.delete()) {
                    if (Baglan.UserImageRemove(KullaniciMail) == true) {
                        oturum.setAttribute("KullaniciResim", "");
                        response.getWriter().write("");

                    }
                    System.out.println("Dosya Başarı İle Silindi");
                } else {
                    System.out.println("Dosya Silinmesi Başarısız Oldu");
                }
            }
        } catch (IOException ex) {
            System.out.println("Exemption :" + ex.getMessage());
        }
    }

    // <editor-fold defaultstate="collapsed" desc="HttpServlet methods. Click on the + sign on the left to edit the code.">
    /**
     * Handles the HTTP <code>GET</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Handles the HTTP <code>POST</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Returns a short description of the servlet.
     *
     * @return a String containing servlet description
     */
    @Override
    public String getServletInfo() {
        return "Short description";
    }// </editor-fold>

}
