
$(document).ready(function () {

    console.log("ready");

    $("#texto").keyup(function (event) {
        if(event.which == 13) { // ou event.keyCode
            event.preventDefault();
            var texto = $("#texto").val();
            $("#texto").val("");
            $("#lista").append('<li><label>' + texto + '</label><input type="checkbox"></li>')      
        }
    });
})
