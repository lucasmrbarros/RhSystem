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
});

$("#postRelTecVaga").submit(function (event) {
    event.preventDefault();

    var valdata = $("#postRelTecVaga").serialize();

    $.ajax({
        url: "https://localhost:44342/VagaNNTecnologia",
        type: "POST",
        dataType: 'json',
        contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
        data: valdata
    });
});

$("#postEntrevista").submit(function (event) {
    event.preventDefault();

    var valdata = $("#postEntrevista").serialize();

    $.ajax({
        url: "https://localhost:44342/EntrevistadoNNTecnologia",
        type: "POST",
        dataType: 'json',
        contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
        data: valdata
    });
});

$("#PutPontVaga").submit(function (event) {
    event.preventDefault();

    var a = "https://localhost:44342/VagaNNTecnologia/",
    var b = "1/",
    var c = "1",
    var url = a.concat(a).concat(b).concat(c);
    /*
    var $form = (this),
        vagaid = $form.find("option[name='vagaid']").val(),*/

    var valdata = $("#Pontos");

    $.ajax({
        url: url,
        type: "PUT",
        dataType: 'json',
        contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
        data: valdata
    });
});