
$(document).ready(function () {

    $("#texto").keyup(function (evento) {
        if(evento.which == 13) { // ou evento.keyCode
            evento.preventDefault();
            var texto = $("#texto").val();
            $("#texto").val("");
            $("#lista").append('<li><label>' + texto + '</label><input type="checkbox"></li>');

            $("#lista input:last").click(function() {
                $(this).parent().children("label").toggleClass("marcado", this.checked);
            });
        }
    });
    
});

