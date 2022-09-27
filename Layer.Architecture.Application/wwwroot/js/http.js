// Anexa um manipulador de envio ao formulário
$("#postec").submit(function (event) {
    event.preventDefault();

    $.post('https://localhost:44342/Tecnologias/', [nome]).done(function (response) {
    });

});

$("#postcand").submit(function (event) {
    event.preventDefault();

    var valdata = $("#postcand").serialize();

    $.ajax({
        url: "https://localhost:44342/Entrevistado/",
        type: "POST",
        dataType: 'json',
        contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
        data: valdata
    });
});

$("#postVaga").submit(function (event) {
    event.preventDefault();

    var valdata = $("#postVaga").serialize();

    $.ajax({
        url: "https://localhost:44342/Vaga",
        type: "POST",
        dataType: 'json',
        contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
        data: valdata
    });

    //ideia: repetir a estrutura acima para a tabela de relacioanemento


});
