
var itemsViewModel = function() {
    this.item = ko.observable("");
    this.itens = ko.observableArray([]);
    this.incluirItem = function() { 
        this.itens.push({Texto: this.item(), Marcado: false, Class: ""});
        this.item("");
    };
};

$(function () {
    var itemsVM = new itemsViewModel()

    $("#textoKo").focus();    

    $("#textoKo").keypress(function (evento) {
        if(evento.which === 13) { // ou evento.keyCode
            evento.preventDefault();
            itemsVM.incluirItem();
        }

        $("#listaKo input:last").click(function() {
            $(this).parent().children("label").toggleClass("marcado", this.checked);
        });
    });
    
    ko.applyBindings(itemsVM);
});
