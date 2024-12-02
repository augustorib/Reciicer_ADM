(function ($) {
    // USE STRICT
    "use strict";

    try {
      //WidgetChart 1
      var ctx = document.getElementById("widgetChart1");
      if (ctx) {
        ctx.height = 130;
        var myChart = new Chart(ctx, {
          type: 'line',
          data: {
            labels: nomeMes,
            type: 'line',
            datasets: [{
              data: totalClientesMes,
              label: 'Clientes',
              backgroundColor: 'rgba(255,255,255,.1)',
              borderColor: 'rgba(255,255,255,.55)',
            },]
          },
          options: {
            maintainAspectRatio: true,
            legend: {
              display: false
            },
            layout: {
              padding: {
                left: 0,
                right: 0,
                top: 0,
                bottom: 0
              }
            },
            responsive: true,
            scales: {
              xAxes: [{
                gridLines: {
                  color: 'transparent',
                  zeroLineColor: 'transparent'
                },
                ticks: {
                  fontSize: 2,
                  fontColor: 'transparent'
                }
              }],
              yAxes: [{
                display: false,
                ticks: {
                  display: false,
                }
              }]
            },
            title: {
              display: false,
            },
            elements: {
              line: {
                borderWidth: 0
              },
              point: {
                radius: 0,
                hitRadius: 10,
                hoverRadius: 4
              }
            }
          }
        });
      }
    } 
    catch (error) {
      console.log(error);
    }

  try{
   //WidgetChart 4
   var ctx = document.getElementById("widgetChart4");
   if (ctx) {
     ctx.height = 115;
     var myChart = new Chart(ctx, {
       type: 'bar',
       data: {
         labels: nomeMesColetas,
         datasets: [
           {
             label: "Coletas",
             data: totalColetasMes,
             borderColor: "transparent",
             borderWidth: "0",
             backgroundColor: "rgba(255,255,255,.3)"
           }
         ]
       },
       options: {
         maintainAspectRatio: true,
         legend: {
           display: false
         },
         scales: {
           xAxes: [{
             display: false,
             categoryPercentage: 1,
             barPercentage: 0.65
           }],
           yAxes: [{
             display: false,
             ticks: {  
               min: 0
             },
           }]
         }
       }
     });
   }
  } catch (error) {
    console.log(error);
  }
  

    try {
    // Percent Chart
    var ctx = document.getElementById("percent-chart");
    if (ctx) {
      ctx.height = 280;
      var myChart = new Chart(ctx, {
        type: 'doughnut',
        data: {
          datasets: [
            {
              label: "Tipo materiais quantidade",
              data: quantidadeMateriaisChart,
              backgroundColor: ObterCoresParaTipoMaterial(labelsChart),
              hoverBackgroundColor: ObterCoresParaTipoMaterial(labelsChart),
              borderWidth: [
                0, 0
              ],
              hoverBorderColor: [
                'transparent',
                'transparent'
              ]
            }
          ],
          labels: labelsChart
        },
        options: {
          maintainAspectRatio: false,
          responsive: true,
          cutoutPercentage: 55,
          animation: {
            animateScale: true,
            animateRotate: true
          },
          legend: {
            display: false
          },
          tooltips: {
            titleFontFamily: "Poppins",
            xPadding: 15,
            yPadding: 10,
            caretPadding: 0,
            bodyFontSize: 16
          }
        }
      });
    }
  } catch (error) {
  console.log(error);
  }
  
})(jQuery);
  