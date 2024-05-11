<%-- 
    Document   : Makale
    Created on : Aug 17, 2020, 2:15:39 PM
    Author     : ALİ KARACA
--%>
<%@page import="com.servlet.DataBase.DataBaseConnection"%>
<%@page import="java.sql.*"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Makale</title>
        <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
        <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
        <script src="js/jquery.js"></script>
        <!--Import materialize.css-->
        <link type="text/css" rel="stylesheet" href="css/materialize.min.css"  media="screen,projection"/>
        <!--Let browser know website is optimized for mobile-->
        <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no" />
        <link type="text/css" rel="stylesheet"href="css/Makale.css">
    </head>
    <body>
        <script src="js/Makale.js"></script>
        <ul id="dropdown1" class="dropdown-content">
            <c:if test="${KullaniciMail!=null}"> 
                <li><a href="check.jsp">Profil Ayarları</a></li>
                <li class="divider"></li>
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
                        <li><img id="MobilResim"src="${KullaniciResim}" style=" width: 260px;height: 200px;padding-left: 35px;padding-top: 10px"/></li>
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





        <%
            String JBDC_DRIVER = "com.mysql.jdbc.Driver";
            String DOMAIN_NAME = "projedb.cfcbomc1men9.us-east-1.rds.amazonaws.com";
            String DB_NAME = "projedb";
            String DB_URL = "jdbc:mysql://" + DOMAIN_NAME + "/" + DB_NAME;
            String USER = "root";
            String PASS = "Zarfali44.";
            Connection Conn = null;
            response.setContentType("text/html;charset=UTF-8");
            String MakaleBaslik;
            String MakaleKonu;
            String MakaleIcerik, YazarMail, MakaleResim;
            String id = request.getParameter("id");
            try {
                Class.forName("com.mysql.jdbc.Driver").newInstance();
                Conn = DriverManager.getConnection(DB_URL, USER, PASS);
                String Sorgu = "SELECT * FROM `makale` where makale_id=?";
                PreparedStatement stmt = Conn.prepareStatement(Sorgu);
                stmt.setString(1, id);
                ResultSet rs = stmt.executeQuery();
                DataBaseConnection Baglan = new DataBaseConnection();
                if (rs.next()) {
                    MakaleBaslik = rs.getString("makale_baslik");
                    MakaleKonu = rs.getString("makale_konu");
                    MakaleIcerik = rs.getString("makale_icerik");
                    YazarMail = rs.getString("kullanici_nick");
                    MakaleResim = rs.getString("makale_resim");
                    HttpSession makale=request.getSession();
                    makale.setAttribute("MakaleResim", MakaleResim);
        %> 
        <c:set var="makale" scope="session" value="${MakaleResim}"/>
        <c:if test="${MakaleResim!=null}">
        <div class="parallax-container" style="position: relative">
            <div class="parallax" ><img id="MakaleResim" src="<%out.println(MakaleResim);%>">
                <label for="MakaleResim"><h1 style="color: white; position: absolute" class="center-align"><%out.println(MakaleBaslik);%></h1>
                <p class="right-align" style="font-size:15px;color: white; position: absolute; ">Yazan: <%out.println(YazarMail);%></p>
                </label>
                
            </div>
        </div></c:if>
        <div id="Makale" class=" container" >
            

            <div id="MakaleIcerik" >
                <div>
                    <%out.println(MakaleIcerik);%>
                </div>
            </div>
        </div>
        <% }
            } catch (Exception e) {
                System.out.println("islemde hata");
            }
        %>




        <script type="text/javascript" src="js/materialize.min.js"></script>
    </body>
</html>
