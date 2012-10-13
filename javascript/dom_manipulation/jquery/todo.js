
$(document).ready(function () {

    console.log("ready");

    $("#texto").keyup(function (evento) {
        if(evento.which == 13) { // ou evento.keyCode
            evento.preventDefault();
            var texto = $("#texto").val();
            $("#texto").val("");
            $("#lista").append('<li><label>' + texto + '</label><input type="checkbox"></li>');


            $("#lista input:last").click(function() {
                var checked = this.checked;
                console.log("onChecked: " + checked);
            });
        }
    });
});

