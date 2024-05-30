// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//Carregar dinamicamente select da tela "View/ReciclagemCreate"
// document.getElementById('carregarSelects').addEventListener('click', function () {
//     var qtdMateriais = document.getElementById('QtdMateriais').value;

//     $.ajax({
//         url: 'CarregarSelectMateriais',
//         type: 'GET',
//         data: {count : qtdMateriais},
//         success: function (response) {
//              $('#selectMateriais').html(response);
//         },
//         error: function (xhr, status, error) {
//             console.error('Erro ao carregar materiais: ', error);
//         }
//     });
// });

//Drop down em cascata Reciclagem/Create
$(document).ready(function (){
    ObterTipoMaterialByMaterialId();

});

$("#MaterialId").change(function(){
    ObterTipoMaterialByMaterialId();
   
});

var ObterTipoMaterialByMaterialId = function(){
    $.ajax({
        url: 'ObterTipoMaterialByMaterialId',
        type: 'GET',
        data: {
            materialId : $('#MaterialId').val(),
        },
        success: function(data){
            $('#TipoMaterialId').find('option').remove();
            $(data).each(
                function(index,item){
                    $('#TipoMaterialId').append('<option value="'+item.id+'">'+item.nome+'</option>');
                }
           
            )
        }
    });
}