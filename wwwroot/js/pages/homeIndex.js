(function ($) {
    // USE STRICT
    "use strict";
    console.log(intTeste);
    try {
      //WidgetChart 1
      var ctx = document.getElementById("widgetChart1");
      if (ctx) {
        ctx.height = 130;
        var myChart = new Chart(ctx, {
          type: 'line',
          data: {
            labels: ['January', 'February', 'March', 'April', 'May'],
            type: 'line',
            datasets: [{
              data: [78, 81, 80, 45, 34],
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
    } catch (error) {
      console.log(error);
    }
  })(jQuery);
  