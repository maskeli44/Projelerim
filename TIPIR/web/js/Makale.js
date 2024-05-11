/* 
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

$(document).ready(function () {
     const elemsDropdown = document.querySelectorAll(".dropdown-trigger");
    const instancesDropdown = M.Dropdown.init(elemsDropdown, {coverTrigger: false });
    $('.sidenav').sidenav();
    document.addEventListener('DOMContentLoaded', function () {
        var elems = document.querySelectorAll('.sidenav');
        var instances = M.Sidenav.init(elems, options);
    });
    document.addEventListener('DOMContentLoaded', function() {
    var elems = document.querySelectorAll('.parallax');
    var instance = M.Parallax.getInstance(elems);
  });

  // Or with jQuery

  $(document).ready(function(){
    $('.parallax').parallax();
  });


});
