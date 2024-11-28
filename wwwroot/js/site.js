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

//Drop down em cascata Coleta/Create
$(document).ready(function (){  

    $('#dataTableInit').DataTable({
      "language": {
                    "sEmptyTable": "Nenhum dado disponível na tabela",
                    "sInfo": "Mostrando _START_ até _END_ de _TOTAL_ registros",
                    "sInfoEmpty": "Mostrando 0 até 0 de 0 registros",
                    "sInfoFiltered": "(filtrado de _MAX_ registros no total)",
                    "sInfoPostFix": "",
                    "sInfoThousands": ".",
                    "sLengthMenu": "Mostrar _MENU_ registros",
                    "sLoadingRecords": "Carregando...",
                    "sProcessing": "Processando...",
                    "sSearch": "Buscar:",
                    "sZeroRecords": "Nenhum registro encontrado",
                    "oPaginate": {
                        "sFirst": "Primeiro",
                        "sLast": "Último",
                        "sNext": "Próximo",
                        "sPrevious": "Anterior"
                    },
                    "oAria": {
                        "sSortAscending": ": Ordenar colunas de forma ascendente",
                        "sSortDescending": ": Ordenar colunas de forma descendente"
                    },
                },
        "order": []
      });


});


