// Requisicoes http

//Post de vagas
$("#postec").submit(function (event) {
    event.preventDefault();

<<<<<<< Updated upstream
    $.post('https://localhost:44342/Tecnologias/',[nome]).done(function (response) {
    });

}); 
=======
   var valdata = $("#postec").serialize();

    $.ajax({
        url: "https://localhost:44342/Tecnologias/",
        type: "POST",
        dataType: 'json',
        contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
        data: valdata
    });

    alert("Tecnologia Adicionada!");
});
>>>>>>> Stashed changes

//Post de candidatos
$("#postcand").submit(function (event) {
    event.preventDefault();
    var valdata = $("#postcand").serialize();

    $.ajax({
        url: "https://localhost:44342/Entrevistado/",
        type: "POST",
        dataType: 'json',
        contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
        data: valdata
<<<<<<< Updated upstream
    });  

}); 

=======
    });

    alert("Candidato Adicionado!");
});

//Post de Vagas
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

    alert("Vaga Adicionada!");
});

//Post do Relacionamento entre vagas e tencologias
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
    alert("Tecnologia adicionada como requisito!")
});

//Post de tecnolgias conhecidas pelo o entrevistado
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

    alert("Conhecimento vinculado com sucesso")
});

//Put de atualiza~cao de pesos
$("#PutPontVaga").submit(function (event) {
    event.preventDefault();

    var valdata = $("#PutPontVaga").serialize();

    $.ajax({
        url: " https://localhost:44342/VagaNNTecnologia/",
        type: "PUT",
        dataType: 'json',
        contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
        data: valdata
    });

    alert("peso adicionado com sucesso")
});
>>>>>>> Stashed changes
