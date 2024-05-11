/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.servlet.makale;

import java.io.*;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;
import com.servlet.DataBase.DataBaseConnection;


/**
 *
 * @author ALİ KARACA
 */
public class MakaleKaydet extends HttpServlet {

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
        response.setContentType("text/html;charset=UTF-8");
        String MakaleBaslik = request.getParameter("MakaleBaslik");
        String MakaleKonu = request.getParameter("MakaleKonu");
        String MakaleIcerik = request.getParameter("MakaleIcerik");
        String MakaleResim=request.getParameter("MakaleResim");
        HttpSession oturum = request.getSession();
        String KullaniciMail = (String) oturum.getAttribute("KullaniciMail");
        

        DataBaseConnection Baglan = new DataBaseConnection();
        if (!"".equals(MakaleBaslik) && !"".equals(MakaleIcerik) && !"".equals(MakaleKonu)) {
            Baglan.MakaleEkle(MakaleBaslik, MakaleKonu, MakaleIcerik, KullaniciMail,MakaleResim);
        } else {
            System.out.println("makale iceriginde bosluk var");
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
