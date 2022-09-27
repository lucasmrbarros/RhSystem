// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $('#table_id').DataTable();
});

//Drop Down do Candidato

let dropdown_Candidato = $('#Candidato-dropdown');

dropdown_Candidato.empty();

dropdown_Candidato.append('<option selected="true">Candidato</option>');
dropdown_Candidato.prop('selectedIndex', 0);

const url_candidato = 'https://localhost:44342/Entrevistado/';


$.getJSON(url_candidato, function (data) {
    $.each(data, function (_key, entry) {
        dropdown_Candidato.append($('<option></option>').attr('value', entry.abbreviation).text(entry.nome));
    })
});


//Drop Down da vaga

let dropdown_vaga = $('#Vaga-dropdown');

dropdown_vaga.empty();

dropdown_vaga.prop('selectedIndex', 0);

const url_vaga = 'https://localhost:44342/Vaga/';


$.getJSON(url_vaga, function (data) {
    $.each(data, function (_key, entry) {

        dropdown_vaga.append($('<option value="" name= "vagaid"></option>').attr('value', entry.id).text(entry.nome));
    })
});

//Drop Down tecnologias

let dropdown_tecnologia = $('#dropdown_tecnologia');

dropdown_tecnologia.empty();

dropdown_tecnologia.append('<option selected="true">Tecnologia</option>');
dropdown_tecnologia.prop('selectedIndex', 0);

const url_tecnologia_drop = 'https://localhost:44342/Tecnologias/';

$.getJSON(url_tecnologia_drop, function (data) {
    $.each(data, function (_key, entry) {
        dropdown_tecnologia.append($('<input type="checkbox" value="" name="TecnogiaId">  ').attr('value', entry.id));
        dropdown_tecnologia.append($('<label"></label>').text(entry.nome));
    })
});



//CheckBox de Tecnologias

let checkbox_tecnologias = $('#checkbox_tecnologias');

checkbox_tecnologias.empty();

checkbox_tecnologias.prop('selectedIndex', 0);

const url_tecnologia = 'https://localhost:44342/Tecnologias/';


$.getJSON(url_tecnologia, function (data) {
    $.each(data, function (_key, entry) {
        checkbox_tecnologias.append($('<input type="checkbox" value="" name="TecnogiaId">  ').attr('value', entry.id));
        checkbox_tecnologias.append($('<label"></label>').text(entry.nome));
        checkbox_tecnologias.append($('<br>'));
    })
});