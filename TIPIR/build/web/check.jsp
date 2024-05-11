<%-- 
    Document   : welcome
    Created on : 16.Tem.2020, 14:55:46
    Author     : ALİ KARACA
--%>

<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@page contentType="text/html" pageEncoding="UTF-8"%>

<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>TIPIR</title>
        <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
        <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
        <link rel="text/css" href="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.0/jquery.js"/>
        <style type="text/css" class="init"> </style>
        <!--<script src="js/jqyery.js"></script>-->
        <!--Import materialize.css-->
        <link type="text/css" rel="stylesheet" href="css/materialize.min.css"  media="screen,projection"/>
        <!--Let browser know website is optimized for mobile-->
        <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no" />
        
    </head>

    <body class="sayfa" style="background-color: #fffacd;">
        <script src="js/check.js"></script>
        <!-- Dropdown Structure -->

        <ul id="dropdown1" class="dropdown-content">
            <li class="divider"></li>
                <c:if test="${KullaniciMail!=null}"> 
                <li><a href="logout">Çıkış Yap</a></li>
                </c:if>
        </ul>
        <nav style="background-color: orange">
            <div class="nav-wrapper" >
                <a href="#!" class="brand-logo" style="margin-left: 30px;">TIPIR</a>
                <ul class="right hide-on-med-and-down">
                    <li><a href="index.jsp">Anasayfa</a></li>
                    <!-- Dropdown Trigger -->
                    <li><a class="dropdown-trigger" href="#!" data-target="dropdown1" id="ad">
                            <%
                                HttpSession oturum = request.getSession();
                                String Isim = (String) oturum.getAttribute("KullaniciMail");
                                if (Isim == null) {
                                    out.print("Hoş Geldin " + "Guest");
                                } else {
                                    out.print("Hoş Geldin " + Isim);
                                }
                            %>
                        </a>
                    </li>
                </ul>
                <ul id="slide-out" class="sidenav">
                    <c:if test="${KullaniciMail!=null}">
                        <li><img id="MobilResim"src="${KullaniciResim}" style="width: 260px;height: 200px;padding-left: 20px;padding-top: 10px"/></li>
                        <li><label for="#MobilResim" style="padding-left: 30px; color: orange;">${KullaniciMail}</label></li>
                        </c:if>
                        <c:if test="${KullaniciMail==null}">
                        <li><img id="MobilResim"src="image\admin.jpg" style="padding-left: 20px;padding-top: 10px"/></li>
                        <li><label for="#MobilResim" style="padding-left: 30px; color: orange;">${"Hoş Geldiniz Sayın Misafir"}</label></li>

                    </c:if>
                    <li><a href="index.jsp">Anasayfa</a></li> 
                        <c:if test="${KullaniciMail!=null}">     
                        <li> <a id="giris" class="waves-effect waves-light btn " href="logout">Çıkış Yap</a></li>
                        </c:if>
                </ul>
                <a href="#" data-target="slide-out" class="sidenav-trigger"><i class="material-icons">menu</i></a>
            </div>
        </nav>
        <c:if test="${KullaniciMail!=null}"> 
            <table>
                <tr>
                    <th>               
                        <h3>PROFİL RESMİ</h3> 

                    </th>                 
                </tr>
                <tr style="height: 100px">

                    <td>
                        <div>
                            <input id="SecResim" type = "file" name = "file" size = "50" accept=".png,.jpeg,.jpg " class="waves-effect waves-blue-grey btn-flat blue-grey" />

                            <input type = "button" value = "Upload File" class="waves-effect waves-blue-grey btn-flat green" onclick="Resim.ResimGonder()" />

                            <button class="waves-effect waves-orange btn-flat red" onclick="Resim.ResimSil()"> Sil</button>
                                
                        </div>
                    </td>

                </tr>
                <tr>
                    <td>
                        <div>
                            <img id="ProfilResim" src="${KullaniciResim}" style="width: 200px"/>
                        </div>
                    </td>
                </tr>

            </table></c:if>



        <script type="text/javascript" src="js/materialize.min.js"></script>
    </body>
</html>
