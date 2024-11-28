$(document).ready(function (){

    ObterMaterialByTipoMaterialId();
    $('#Peso').val('');
    $('#Quantidade').val('');
    

    $('#Peso').on('input', function () {
        $('#Quantidade').prop('disabled', $(this).val().trim() !== '');
        checkFormMaterialColeta();
    });

    $('#Quantidade').on('input', function () {
        $('#Peso').prop('disabled', $(this).val().trim() !== '');
        checkFormMaterialColeta();
    });

    DataOperacaoMaxima();
    checkFormCliente();
    
    $('#ClienteId').on('change', checkFormCliente);
    $('#Coleta_DataOperacao').on('input', checkFormCliente);
    
    checkFormMaterialColeta();

    new TomSelect('.clienteCreate', {
        create: false,
        sortField: {
            field: "text",
            direction: "asc"
        }
    });

});



$("#TipoMaterialId").change(function(){
    ObterMaterialByTipoMaterialId(); 
});


const ObterMaterialByTipoMaterialId = function(){
    $.ajax({
        url: '/Coleta/ObterMaterialByTipoMaterialId',
        type: 'GET',
        data: {
            tipoMaterialId : $('#TipoMaterialId').val(),
        },
        success: function(data){
            $('#MaterialId').find('option').remove();
            $(data).each(
                function(index,item){
                    $('#MaterialId').append('<option value="'+item.id+'">'+item.nome+'</option>');
                }
           
            )
        }
    });
};

const DataOperacaoMaxima = function(){
    let datetimeInput = document.getElementById('Coleta_DataOperacao');
    let now = new Date();
    let year = now.getFullYear();
    let month = ('0' + (now.getMonth() + 1)).slice(-2);
    let day = ('0' + now.getDate()).slice(-2);
    let hours = ('0' + now.getHours()).slice(-2);
    let minutes = ('0' + now.getMinutes()).slice(-2);
    let maxDateTime = year + '-' + month + '-' + day + 'T' + hours + ':' + minutes;
    datetimeInput.max = maxDateTime;
};

const checkFormCliente = function(){
    let clienteId = $('#ClienteId').val().trim();
    let dataOperacao = $('#Coleta_DataOperacao').val().trim();
    let okButton = $('#coletaCreateClienteButtonOK');

    if (clienteId !== '' && dataOperacao !== '') {
        okButton.prop('disabled', false);
    } else {
        okButton.prop('disabled', true);
    }
};

const checkFormMaterialColeta = function() {
    let tipoMaterialId = $('#TipoMaterialId').val();
    let materialId = $('#MaterialId').val();
    let peso = $('#Peso').val();
    let quantidade = $('#Quantidade').val();
    let okButton = $('#coletaCreateMaterialButtonOK');

    if (tipoMaterialId !== '' && materialId !== '' && (peso !== '' || quantidade !== '')) { 
        okButton.prop('disabled', false);
    } else {
        okButton.prop('disabled', true);
    }
};