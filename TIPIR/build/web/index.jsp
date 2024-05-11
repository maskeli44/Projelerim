<%-- 
    Document   : index
    Created on : 16.Tem.2020, 14:08:07
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
        <title>TIPIR</title>
        <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
        <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
        <!--Import materialize.css-->
        <link type="text/css" rel="stylesheet" href="css/materialize.min.css"  media="screen,projection"/>
        <!--Let browser know website is optimized for mobile-->
        <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no" />
        <script src="ckeditor/ckeditor.js"></script>
    </head>
    <body style="background-color: #fffacd">
        <script src="js/anasayfa.js"></script>

        <ul id="dropdown1" class="dropdown-content">
            <li><a href="check.jsp">Profil Ayarları</a>
            <li class="divider"></li>
            <li><a href="logout">Çıkış Yap</a></li>
        </ul>
        <nav style="background-color: orange">
            <div class="nav-wrapper">
                <a href="#!" class="brand-logo" style="margin-left: 30px;">TIPIR</a>

                <a href="#" data-target="mobile-demo" class="sidenav-trigger"><i class="material-icons">menu</i></a>
                <ul class="right hide-on-med-and-down">
                    <li><a href="index.jsp">Anasayfa</a></li>
                        <c:set var="oturum" scope="session" value="${KullaniciMail}"/>  
                        <c:if test="${KullaniciMail==null}">  
                        <li> <a id="Giris" class="waves-effect waves-light btn modal-trigger" href="#ModalUyeGiris">Giriş Yap</a></li>
                        <li><a id="Kayit" class="waves-effect waves-light btn modal-trigger" href="#ModalUyeKayit">Kayıt Ol</a></li>
                        </c:if>  
                        <c:if test="${KullaniciMail!=null}">  
                        <li><a class="dropdown-trigger" href="#!" data-target="dropdown1">
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
                    </c:if>  
                </ul>

            </div>
        </nav>

        <ul class="sidenav" id="mobile-demo">
            <c:if test="${KullaniciMail!=null}">
                <li><img id="MobilResim"src="${KullaniciResim}" style=" width: 260px;height: 200px;padding-left: 30px;padding-top: 10px"/></li>
                <li><label for="#MobilResim" style="padding-left: 30px; color: orange;">${KullaniciMail}</label></li>
                </c:if>
                <c:if test="${KullaniciMail==null}">
                <li><img id="MobilResim"src="image\admin.jpg" style="padding-left: 20px;padding-top: 10px"/></li>
                <li><label for="#MobilResim" style="padding-left: 30px; color: orange;">${"Hoş Geldiniz Sayın Misafir"}</label></li>

            </c:if>
            <li><a href="index.jsp">Anasayfa</a></li>
                <c:if test="${KullaniciMail==null}">   
                <li> <a id="giris" class="waves-effect waves-light btn modal-trigger" href="#ModalUyeGiris">Giriş Yap</a></li>
                <li><a id="kayit" class="waves-effect waves-light btn modal-trigger" href="#ModalUyeKayit">Kayıt Ol</a></li>
                </c:if>
                <c:if test="${KullaniciMail!=null}">
                <li><a href="check.jsp">Profil Ayarları</a></li>
                <li> <a id="giris" class="waves-effect waves-light btn " href="logout">Çıkış Yap</a></li>
                </c:if>
        </ul>

        <script></script>
        <div id="ModalUyeGiris" class="modal modal-fixed-footer">
            <div class="modal-content" >
                <h4>Kullanıcı Girişi</h4>


                <div class="row">
                    <div class="input-field col s12">
                        <input id="GirisEmail"  type="email" class="validate">
                        <label for="GirisEmail" style="size: 50px;">Email</label>
                    </div>
                </div>
                <div class="row">
                    <div class="input-field col s12">
                        <input  id="GirisPassword"  type="password" class="validate" >
                        <label for="GirisPassword">Şifre</label>
                    </div>
                </div>
                <div class="row">
                    <div>
                        <a id="unutmak" href="#ModalSifremiUnuttum" class="modal-trigger modal-close">Şifrenizi mi unuttunuz?</a> <a id="gecersiz1" style="display: none;color: red;" href=""> Yanlış Giriş Denemesi</a>
                    </div>
                </div>
            </div>
            <div class="modal-footer" id="gir">
                <button class=" waves-effect waves-green btn-flat" id="giris2" onclick="uyelik.SignIn()"> Giriş Yap </button>
                <a href="#!" class="modal-close waves-effect waves-red btn-flat" id="iptal1"> İptal</a>
            </div>
        </div>



        <div id="ModalUyeKayit" class="modal modal-fixed-footer">
            <div class="modal-content" >
                <h4>Kayıt Ol</h4>

                <div class="row">
                    <div class="input-field col s12">
                        <input id="KaydolEmail" name="KaydolEmail" type="email" class="validate" required>
                        <label for="KaydolEmail">Email</label>
                    </div>
                </div>
                <div class="row">
                    <div class="input-field col s12">
                        <input id="KaydolPassword" name="KaydolPassword" type="password" class="validate" >
                        <label for="KaydolPassword">Şifre</label>
                    </div>
                </div>
                <div class="row">
                    <div class="input-field col s12">
                        <input id="KaydolYenidenPass" name="KaydolYenidenPass" type="password" class="validate" >
                        <label for="KaydolYenidenPass">Şifreyi Yeniden Girin</label>
                    </div>
                </div>
                <div class="input-field col s12" >
                    <select id="KaydolGuvenlikSorusu">
                        <option value="" disabled selected>Güvenlik Sorusu Seçin</option>
                        <option value="1">Ananızın Kızlık Soyadı</option>
                        <option value="2">İlk Okul Öğretmeniniz Kim di?</option>
                        <option value="3">İlk Okul Numaranız</option>
                    </select>
                </div>
                <div class="row">
                    <div class="input-field col s12">
                        <input id="KaydolGuvenlikCevap" name="cevap" type="text" class="validate">
                        <label for="KaydolGuvenlikCevap">Cevabınız...</label>
                    </div>
                </div>
                <div class="row">
                    <div>
                        <a class="modal-trigger modal-close" href="#ModalSifremiUnuttum">Şifrenizi mi unuttunuz?</a> <a id="KaydolGecersizYazi" style="display: none;color: red;" href=""></a>
                    </div>

                </div>
            </div>
            <div class="modal-footer" id="Gir">
                <button class=" waves-effect waves-green btn-flat " id="KayitGiris" type="submit" onclick="KayitButonuClick()"> Kayıt Yap </button>
                <a href="#!" class="modal-close waves-effect waves-red btn-flat"> İptal</a>
            </div>
        </div>



        <div id="ModalSifremiUnuttum" class="modal modal-fixed-footer">
            <div class="modal-content" >
                <h4>Şifremi Unuttum</h4>


                <div class="row">
                    <div class="input-field col s12">
                        <input id="SifremiUnuttumEmail" name="SifremiUnuttumEmail" type="text" class="validate">
                        <label for="SifremiUnuttumEmail">Email</label>
                    </div>
                </div>
                <div class="row">
                    <div class="input-field col s12">
                        <input id="SifremiUnuttumPassword" name="SifremiUnuttumPassword" type="password" class="validate" >
                        <label for="SifremiUnuttumPassword">Yeni Şifre</label>
                    </div>
                </div>
                <div class="row">
                    <div class="input-field col s12">
                        <input id="SifremiUnuttumPasswordYeniden" name="SifremiUnuttumPasswordYeniden" type="password" class="validate" >
                        <label for="SifremiUnuttumPasswordYeniden">Yeni Şifre'yi Yeniden Yazınız</label>
                    </div>
                </div>
                <div class="input-field col s12" >
                    <select id="SifremiUnuttumGunvenlikSorusu">
                        <option value="" disabled selected>Güvenlik Sorunuzu Seçin</option>
                        <option value="1">Ananızın Kızlık Soyadı</option>
                        <option value="2">İlk Okul Öğretmeniniz Kim di?</option>
                        <option value="3">İlk Okul Numaranız</option>
                    </select>
                </div>
                <div class="row">
                    <div class="input-field col s12">
                        <input id="SifremiUnuttumGunvenlikCevap" name="SifremiUnuttumGunvenlikCevap" type="text" class="validate">
                        <label for="SifremiUnuttumGunvenlikCevap">Cevabınız...</label>
                    </div>
                </div>
                <div class="row">
                    <div>
                        <a href="#ModalUyeGiris" class="modal-trigger modal-close">Giriş Yap</a> <a id="SifremiUnuttumGecersizYazi" style="display: none;color: red;" href=""> Yanlış Giriş Denemesi</a>
                    </div>

                </div>
            </div>
            <div class="modal-footer" id="Gir">
                <button class=" waves-effect waves-green btn-flat" id="SifremiUnuttumGiris" onclick="uyelik.sifremiunuttum()">Şifreyi Güncele</button>
                <a href="#!" class="modal-close waves-effect waves-red btn-flat"> İptal</a>
            </div>
        </div>

        <div id="ModalMakale" class="modal modal-fixed-footer">
            <div class="modal-content">

                <h4>Makale Ekle</h4>

                <div class="row">
                    <div class="input-field col s6">
                        <input id="MakaleBaslik" type="text" data-length="30" required="">
                        <label for="MakaleBaslik">Makele Başlığı</label>
                    </div>
                </div>
                <div class="row">
                    <div class="input-field col s12">
                        <textarea id="MakaleKonu" class="materialize-textarea" data-length="200" required=""></textarea>
                        <label for="MakaleKonu">Makale Konusu</label>
                    </div>
                </div>
                <div class="row">
                    Makale Resmi
                    <input id="SecResim" type = "file" name = "file" size = "50" accept=".png,.jpeg,.jpg " class="waves-effect waves-blue-grey btn-flat blue-grey" />                  
                </div>
                <div class="row">
                    <div class="input-field col s12">
                        <textarea id="MakaleIcerik" class="left-align" required=""></textarea>
                        <script>
                            var editor = CKEDITOR.replace('MakaleIcerik');
                            editor.on('change', function (evt) {
                                // getData() returns CKEditor's HTML content.

                                //console.log('Total bytes: ' + evt.editor.getData());
                                EditorDegerEkle(evt.editor.getData());

                            });
                            ;


                        </script>

                    </div>
                </div>
            </div>
            <div class="modal-footer">
                <button class=" waves-effect waves-green btn-flat" id="MakaleGonder" type="submit" onclick="Makale.Ekle();"> Makale Ekle </button>
                <a href="#!" class="modal-close waves-effect waves-red btn-flat"> İptal</a>
            </div>
        </div>    








        <div id="MakaleEkle" >
            <c:set var="oturum" scope="session" value="${KullaniciMail}"/>  
            <c:if test="${KullaniciMail!=null}">  
                <div class="fixed-action-btn direction-top">
                    <a class="btn-floating btn-large red waves-effect waves-light btn modal-trigger" href="#ModalMakale">                      
                        <i class="large material-icons">mode_edit</i>
                    </a>           
                </div>
            </c:if>  </div> 
        <h3>Makaleler</h3>
        <div>
            <div style="overflow-x:auto;">
                <div class="row s12 m5">
                    <c:set var="i" scope="session" value="${1}" />
                    <%
                        String JBDC_DRIVER = "com.mysql.jdbc.Driver";
                        String DOMAIN_NAME = "projedb.cfcbomc1men9.us-east-1.rds.amazonaws.com";
                        String DB_NAME = "projedb";
                        String DB_URL = "jdbc:mysql://" + DOMAIN_NAME + "/" + DB_NAME;
                        String USER = "root";
                        String PASS = "Zarfali44.";
                        Connection Conn = null;
                        response.setContentType("text/html;charset=UTF-8");
                        String MakaleBaslik, MakaleId;
                        String MakaleKonu;
                        String MakaleIcerik, KullaniciMail;
                        DataBaseConnection Baglan = new DataBaseConnection();

                        //String modalmakaleicerik;
                        try {
                            Class.forName("com.mysql.jdbc.Driver").newInstance();
                            Conn = DriverManager.getConnection(DB_URL, USER, PASS);
                            String Sorgu = "SELECT * FROM `makale` order by makale_id desc";
                            PreparedStatement stmt = Conn.prepareStatement(Sorgu);
                            ResultSet rs = stmt.executeQuery();

                            while (rs.next()) {
                                MakaleBaslik = rs.getString("makale_baslik");
                                MakaleKonu = rs.getString("makale_konu");
                                MakaleIcerik = rs.getString("makale_icerik");
                                KullaniciMail = rs.getString("kullanici_nick");
                                MakaleId = rs.getString("makale_id");
                                String MakaleResim = rs.getString("makale_resim");
                                HttpSession Makale = request.getSession();
                                Makale.setAttribute("MakaleId", MakaleId);
                                Makale.setAttribute("MakaleBaslik", MakaleBaslik);
                                Makale.setAttribute("MakaleKonu", MakaleKonu);
                                Makale.setAttribute("MakaleIcerik", MakaleIcerik);
                                Makale.setAttribute("KullaniciMailMakale", KullaniciMail);
                                Makale.setAttribute("MakaleResim", MakaleResim);
                    %> 



                    <div class="col ">
                        <div class="card " style="width: 250px; height: 375px" id="Makale${MakaleId}">

                            <div class="card-image waves-effect waves-block waves-light">
                                <img class="activator" src="${MakaleResim}" style="width: 250px;height: 175px;">
                                <label id="ResimAltNick">${KullaniciMailMakale}</label>
                            </div>
                            <div class="card-content">
                                <span class="card-title activator grey-text text-darken-4 truncate">${MakaleBaslik}<i class="material-icons right">more_vert</i></span>
                                <p><a href="Makale.jsp?id=${MakaleId}">Devamını Oku</a></p><br/>
                                <c:if test="${KullaniciMail==KullaniciMailMakale}">
                                        <button data-id="${MakaleId}" class="btn-floating btn-small red waves-effect waves-light"  onclick="Makale.Sil(this)"><i class="large material-icons" >delete</i> </button>
                                    <a data-id="${MakaleId}" class="btn-floating btn-small red waves-effect waves-light modal-trigger"  href="#modalMakaleGuncelle${MakaleId}"><i class="large material-icons">cached</i></a>
                                </c:if>

                            </div>
                            <div class="card-reveal">
                                <span class="card-title grey-text text-darken-4"> ${MakaleBaslik}<i class="material-icons right">close</i></span>
                                <p>${MakaleKonu}</p>
                                <a id="OkuyanSayaci${MakaleId}"></a>                            
                            </div>                         
                        </div>
                    </div>




                    <div id="modalMakaleGuncelle${MakaleId}" class="modal modal-fixed-footer">
                        <div class="modal-content">
                            <div class="row">
                                <div class="input-field col s6">
                                    <input id="MakaleBaslikGuncelle${MakaleId}" type="text" data-length="30" required="" value="${MakaleBaslik}">
                                    <label for="MakaleBaslikGuncelle${MakaleId}">Makele Başlığı</label>
                                </div>
                            </div>
                            <div class="row">
                                <div class="input-field col s12">
                                    <input id="MakaleKonuGuncelle${MakaleId}" type="text" data-length="100" required="" value="${MakaleKonu}" >
                                    <label for="MakaleKonuGuncelle${MakaleId}">Makale Konusu</label>
                                </div>
                            </div>
                            <div class="row">
                                Makale Resmi
                                <img id="ProfilResim${MakaleId}" src="${MakaleResim}" style="width: 200px"/>
                                <input id="SecResim${MakaleId}" type = "file" name = "file" size = "50" accept=".png,.jpeg,.jpg " class="waves-effect waves-blue-grey btn-flat blue-grey" />                  
                            </div>
                            <div class="row">
                                <div class="input-field col s12">

                                    <div class="container">


                                        <textarea id="MakaleIcerikGuncelle${MakaleId}" name="deneme" required="">${MakaleIcerik}</textarea>
                                        <script>
                                            var editor = CKEDITOR.replace('MakaleIcerikGuncelle${MakaleId}');
                                            editor.on('change', function (evt) {
                                                // getData() returns CKEditor's HTML content.

                                                //console.log('Total bytes: ' + evt.editor.getData());
                                                EditorDegerGuncelle(evt.editor.getData());

                                            });
                                        </script>
                                    </div>

                                </div>

                            </div>

                        </div>
                        <div class="modal-footer">
                            <button data-id="${MakaleId}" class="waves-effect waves-green btn-flat" onclick="Makale.Guncelle(this)">Güncelle</a>
                        </div>
                    </div>


                    <c:set var="i" scope="session"  value="${i+1}"/>



                    <% }
                        } catch (Exception e) {
                            System.out.println("islemde hata");
                        }

                    %>


                </div> 
            </div>
        </div>



        <script type="text/javascript" src="js/materialize.min.js"></script>
    </body>
</html>
