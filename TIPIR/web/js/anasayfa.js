
/* global tinymce */

$(document).ready(function () {
    const elemsDropdown = document.querySelectorAll(".dropdown-trigger");
    const instancesDropdown = M.Dropdown.init(elemsDropdown, {
        coverTrigger: false
    });
    $('.sidenav').sidenav();// body...
    M.updateTextFields();

    document.addEventListener('DOMContentLoaded', function () {
        var elems = document.querySelectorAll('.modal');
        //var instances = M.Modal.init(elems, options);
    });

    document.addEventListener('DOMContentLoaded', function () {
        var elems = document.querySelectorAll('select');
        var instances = M.FormSelect.init(elems, options);


    });

    // Or with jQuery

    $('select').formSelect();
    $('.modal').modal();



    document.addEventListener('DOMContentLoaded', function () {
        var elems = document.querySelectorAll('.fixed-action-btn');
        var instances = M.FloatingActionButton.init(elems, options);
    });

    // Or with jQuery

    $(document).ready(function () {
        $('.fixed-action-btn').floatingActionButton();
    });

    $.ajax({//java servlet fonksiyonuna değerler buradan gönderilir
        type: 'POST',
        async: false,
        url: "UserImageLoad"

    });

});



function KayitButonuClick() {
    var Email = $("input#KaydolEmail").val();
    if (MailKontrol(Email)) {
        uyelik.SignUp();
    } else {
        alert("Email hatalı");
        return false;
    }
}
function MailKontrol(Email) {
    var Kontrol = new RegExp(/^[^0-9][a-zA-Z0-9_]+([.][a-zA-Z0-9_]+)*[@][a-zA-Z0-9_]+([.][a-zA-Z0-9_]+)*[.][a-zA-Z]{2,4}$/i);
    return Kontrol.test(Email);
}
var DataMakaleGuncelle;
function EditorDegerGuncelle(data) {
    return DataMakaleGuncelle = data;
}
var DataMakaleEkle;
function EditorDegerEkle(data) {
    return DataMakaleEkle = data;
}

var uyelik = {
    SignIn: function () {
        var userNick = $('#GirisEmail').val();
        var userPass = $('#GirisPassword').val();//kullanıcıdan gelen bilgiler jsp deki textboxlardan çekilir

        $.ajax({//java servlet fonksiyonuna değerler buradan gönderilir
            type: 'POST',
            async: false,
            url: "SignIn",
            data: {//gönderilecek veriler
                'Email': userNick,

                'Password': userPass},
            success: function (data) {//işlem başarılı ise çalışacak fonksiyon
                console.log(data);
                if (data === "0")
                {
                    $('#gecersiz1').show();//hata mesajının ekranda görünür yapılması
                } else if (data === "1") {
                    window.location.href = "index.jsp";//işlem başarılı olduğunda yönlendirilecek sayfa
                }
            }
        });


    },
    SignUp: function () {

        var userNickKaydol = $('#KaydolEmail').val();
        var userPassKaydol = $('#KaydolPassword').val();
        var userPassKaydolYeniden = $('#KaydolYenidenPass').val();
        var userCevap = $('#KaydolGuvenlikCevap').val();
        var userSoru = $('#KaydolGuvenlikSorusu').val();

        $.ajax({
            type: 'POST',
            async: false,
            url: "SignUp",
            data: {
                'Email': userNickKaydol,

                'Password': userPassKaydol,

                'YenidenPass': userPassKaydolYeniden,

                'GunvenlikCevap': userCevap,

                'GuvenlikSoru': userSoru

            },

            success: function (data) {
                console.log(data);
                if (data === "0")
                {
                    $('#KaydolGecersizYazi').text("Hatali Kayit Denemesi");
                    $('#KaydolGecersizYazi').show();
                    $("#ModalUyeKayit .modal-content").animate({
                        scrollTop: $("#KaydolGecersizYazi").offset().top
                    }, 2000);
                } else if (data === "1") {
                    alert("Kayıt Başarı ile Eklenildi");

                } else if (data === "2") {
                    $('#KaydolGecersizYazi').text("Bu Kullanici Zaten Kayıtlı");
                    $('#KaydolGecersizYazi').show();

                }

            }
        });
    },
    sifremiunuttum: function () {
        var userNick = $('#SifremiUnuttumEmail').val();
        var userPass = $('#SifremiUnuttumPassword').val();
        var userPassYenien = $('#SifremiUnuttumPasswordYeniden').val();
        var userCevap = $('#SifremiUnuttumGunvenlikCevap').val();
        var userSoru = $('#SifremiUnuttumGunvenlikSorusu').val();


        $.ajax({
            type: 'POST',
            async: false,
            url: "unknowpass",
            data: {
                'Email': userNick,

                'Password': userPass,

                'YenidenPassword': userPassYenien,

                'GuvenlikCevap': userCevap,

                'GuvenlikSoru': userSoru

            },

            success: function (data) {

                if (data === "0")
                {
                    $('#SifremiUnuttumGecersizYazi').text("Hatali Kayit Denemesi");
                    $('#SifremiUnuttumGecersizYazi').show();
                } else if (data === "1") {
                    alert("Kayıt Başarı ile Eklenildi");
                } else if (data === "2") {
                    $('#SifremiUnuttumGecersizYazi').text("Bu Kullanici Kayıtlı Değil");
                    $('#SifremiUnuttumGecersizYazi').show();
                }

            }
        });
    }
};

var Makale = {
    Ekle: function () {
        var MakaleBaslik = $('#MakaleBaslik').val();
        var MakaleKonu = $('#MakaleKonu').val();
        var MakaleIcerik = DataMakaleEkle;

        var formData = new FormData();
        var MakaleResim;
        formData.append("MakaleResim", $('#SecResim')[0].files[0]);
        $.ajax({
            type: 'POST',
            async: false,
            url: 'MakaleResim',
            processData: false,
            contentType: false,
            data: formData,
            success: function (data) {
                // window.location.href = "index.jsp";
                MakaleResim = data;
            }
        });
        $.ajax({
            type: 'POST',
            async: false,
            url: 'MakaleKaydet',

            data: {
                'MakaleBaslik': MakaleBaslik,
                'MakaleKonu': MakaleKonu,
                'MakaleIcerik': MakaleIcerik,
                'MakaleResim': MakaleResim
            },
            success: function (data) {
                window.location.href = "index.jsp";
                
            }
        });


    },

    Sil: function (button) {
        var Mak_Id = $(button).attr("data-id");

        if (Mak_Id !== "") {
            if (confirm('Bu Makale Silinecek Emin misiniz?'))
            {
                $.ajax({
                    type: 'POST',
                    async: false,
                    url: 'MakaleSil',
                    data: {"MakaleId": Mak_Id},
                    success: function (data) {
                        window.location.href = "index.jsp";
                    }

                });
            } else {
            }
            // Do nothing!
        } else {
            alert("Silinecek Makale Yok");
        }

    },
    Guncelle: function (button) {

        var Makale_Id = $(button).attr("data-id");
        var Makale_Bas = $("#" + "MakaleBaslikGuncelle" + Makale_Id).val();
        var Makale_Kon = $("#" + "MakaleKonuGuncelle" + Makale_Id).val();
        var Makale_Ic = DataMakaleGuncelle;
        var formData = new FormData();
        var MakaleResim;
        formData.append("MakaleResim", $('#SecResim' + Makale_Id)[0].files[0]);
        if (Makale_Id !== "") {
            if (confirm('Bu Makale Güncellenecek Emin misiniz?'))
            {

                $.ajax({
                    type: 'POST',
                    async: false,
                    url: 'MakaleResim',
                    processData: false,
                    contentType: false,
                    data: formData,
                    success: function (data) {
                        // window.location.href = "index.jsp";
                        if(data==='image\\'){
                            MakaleResim=$('#ProfilResim'+Makale_Id).attr('src');
                        }else{
                         MakaleResim = data;   
                        }
                        
                    }
                });
                $.ajax({
                    type: 'POST',
                    async: false,
                    url: 'MakaleGuncelle',
                    data: {
                        "MakaleId": Makale_Id,
                        "MakaleBaslik": Makale_Bas,
                        "MakaleKonu": Makale_Kon,
                        "MakaleIcerik": Makale_Ic,
                        "MakaleResim": MakaleResim
                    },
                    success: function (data) {
                        if(data==="Eklendi"){
                        window.location.href = "index.jsp";}
                        else{
                            alert("Bir Harf Dahi Olsa İçerikte Güncelleme Yapin");
                        }
                    }
                    
                });
            } else {
            }
            // Do nothing!
        } else {
            alert("Güncellenen Makale Yok");
        }
    },
    OkunmaSayisi: function (MakaleId, KullaniciMail) {
        $.ajax({
            type: 'POST',
            async: false,
            url: 'OkunmaSayisi',
            data: {
                "MakaleId": MakaleId,
                "KullaniciMail": KullaniciMail
            },
            success: function (data) {
                $("#" + "OkuyanSayaci" + MakaleId).text("Okuyan Kişi Sayisi:" + data);
            }

        });

    }



};

