$(document).ready(function(){

    $('#CPF').on('input', function () {
        $('#CNPJ').prop('disabled', $(this).val().trim() !== ''); 
    });
    
    $('#CNPJ').on('input', function () {
        $('#CPF').prop('disabled', $(this).val().trim() !== '');
    });

});
