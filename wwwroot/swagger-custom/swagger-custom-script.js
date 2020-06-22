(function () {
    window.addEventListener("load", function () {
        setTimeout(function () {
            var logo = document.getElementsByClassName('link');
            logo[0].href = "https://rashik.com.np/";
            logo[0].target = "_blank";

            logo[0].children[0].alt = "Implemeting Swagger";
            logo[0].children[0].src = "https://blog.rashik.com.np/wp-content/uploads/2020/06/rashikLogo-2-300x113.png";
        });
    });
})();

