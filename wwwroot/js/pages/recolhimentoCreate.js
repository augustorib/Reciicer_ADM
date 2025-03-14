$(document).ready(function (){
    DataOperacaoMaxima();
});

function validateInput(input) {
    const max = parseInt(input.getAttribute('max'));
    if (parseInt(input.value) > max) {
        input.value = max;
    }
}

const DataOperacaoMaxima = function(){
let datetimeInput = document.getElementById('Recolhimento_DataRecolhimento');
let now = new Date();
let year = now.getFullYear();
let month = ('0' + (now.getMonth() + 1)).slice(-2);
let day = ('0' + now.getDate()).slice(-2);
let hours = ('0' + now.getHours()).slice(-2);
let minutes = ('0' + now.getMinutes()).slice(-2);
let maxDateTime = year + '-' + month + '-' + day + 'T' + hours + ':' + minutes;
datetimeInput.max = maxDateTime;
};