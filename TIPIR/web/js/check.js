/* 
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/* global options, M */

$(document).ready(function () {
    const elemsDropdown = document.querySelectorAll(".dropdown-trigger");
    const instancesDropdown = M.Dropdown.init(elemsDropdown, {
        coverTrigger: false
    });
    $('.sidenav').sidenav();
    document.addEventListener('DOMContentLoaded', function () {
        var elems = document.querySelectorAll('.sidenav');
        var instances = M.Sidenav.init(elems, options);
    });
});

var Resim = {
    ResimGonder: function () {
        var formData = new FormData();
        formData.append('Resim', $('#SecResim')[0].files[0]);
        $.ajax({
            type: 'POST',
            async: false,
            url: "UserImage",
            data: formData,
            processData: false,
            contentType: false,
            success: function (data) {
                alert("Porfil Resmi Başarı ile Değiştirildi");
                $('#ProfilResim').attr("src", data);
            }
        });
    },
    ResimSil: function () {
        //e.preventDefault();

        var Filepath = $('#ProfilResim').attr('src');

        if (Filepath !== "") {
            if (confirm('Are you sure you want to Delete Files?'))
            {
                // Save it!
                $.ajax({
                    type: "POST",
                    async: false,
                    url: "UserImageRemove",
                    data: {DosyaYolu: Filepath},
                    //processData: false,
                    //
                    //contentType: false,

                    success: function (data) {
                        alert("resim başarı ile silindi");
                        $('#Profilresim').attr("src", data);
                        window.location.href = "check.jsp";
                    }
                });
            } else {
            }
            // Do nothing!
        } else {
            alert("Silinecek Resim Yok");
        }

    }


};

// Initialize collapsible (uncomment the lines below if you use the dropdown variation)
// var collapsibleElem = document.querySelector('.collapsible');
// var collapsibleInstance = M.Collapsible.init(collapsibleElem, options);

// Or with jQuery




