
$(document).ready(function () {

    $("#texto").focus();    

    $("#texto").keypress(function (evento) {
        if(evento.which === 13) { // ou evento.keyCode
            evento.preventDefault();
            var texto = $("#texto").val();
            $("#texto").val("");

            incluirItemComStringHtml(texto);
            // ou 
            // incluirItemUsandoJQueryTemplate(texto);

            $("#lista input:last").click(function() {
                $(this).parent().children("label").toggleClass("marcado", this.checked);
            });
        }
    });
});

var incluirItemComStringHtml = function (texto) {
    var htmlItem = '<li><label>' + texto + '</label><input type="checkbox" /></li>';
    $("#lista").append(htmlItem);
}

var incluirItemUsandoJQueryTemplate = function (texto) {
    var template = $.template("#itemTempl");
    var dados = { "Texto" : texto };  
    $.tmpl(template, dados).appendTo("#lista");
}

