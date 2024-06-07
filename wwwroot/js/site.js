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
};

//const ctx = document.getElementById('myChart');
//const ctx2 = document.getElementById('myChart2').getContext('2d');

var barChart = new Chart(ctx, {
    type: 'bar',
    data: {
      labels: ['Red', 'Blue', 'Yellow', 'Green', 'Purple', 'Orange'],
      datasets: [{
        label: '# of Votes',
        data: [12, 19, 3, 5, 2, 3],
        borderWidth: 1
      }]
    },
    options: {
      scales: {
        y: {
          beginAtZero: true
        }
      }
    }
  });

//   var barChart = new Chart(ctx, {
//     type: 'bar',
//     data: {
//       labels: ['Red', 'Blue', 'Yellow', 'Green'],
//       datasets: [{
//         label: '# of Votes',
//         data: [12, 19, 3, 5],
//         borderWidth: 3
//       }]
//     },
//     options: {
//       scales: {
//         y: {
//           beginAtZero: true
//         }
//       }
//     }
//   });
  

  // var myPieChart = new Chart(ctx2, {
  //     type: 'pie',
  //     data: {
  //         labels: ['Plástico', 'Metal', 'Papel', 'Vidro'],
  //         datasets: [{
  //             label: '# of Votes',
  //             data: [12, 19, 3, 5],
  //             backgroundColor: [
  //                 'rgba(255, 0, 0, 1)',
  //                 'rgba(255, 240, 0, 1)',
  //                 'rgba(0, 0, 255, 1)',
  //                 'rgba(0, 135, 0)'
  //             ],
  //             borderColor: [
  //                 'rgba(255, 0, 0, 1)',
  //                 'rgba(255, 240, 0, 1)',
  //                 'rgba(255, 206, 86, 1)',
  //                 'rgba(0, 135, 0, 1)'
  //             ],
  //             borderWidth: 1
  //         }]
  //     },
  //     options: {
  //         responsive: true,
  //         plugins: {
  //             legend: {
  //                 position: 'top',
  //             },
  //             tooltip: {
  //                 callbacks: {
  //                     label: function(context) {
  //                         let label = context.label || '';
  //                         if (label) {
  //                             label += ': ';
  //                         }
  //                         label += Math.round(context.raw * 100) / 100;
  //                         return label;
  //                     }
  //                 }
  //             }
  //         }
  //     }
  // });