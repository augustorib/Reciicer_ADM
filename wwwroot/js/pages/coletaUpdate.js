$(document).ready(function (){

    ObterMaterialByTipoMaterialId();
    $('#Peso').val('');
    $('#Quantidade').val('');
    

    $('#Peso').on('input', function () {
        $('#Quantidade').prop('disabled', $(this).val().trim() !== '');
    });

    $('#Quantidade').on('input', function () {
        $('#Peso').prop('disabled', $(this).val().trim() !== '');
    });
});

$("#Material_TipoMaterialId").change(function(){
    ObterMaterialByTipoMaterialId(); 
});

var ObterMaterialByTipoMaterialId = function(){
    $.ajax({
        url: '/Coleta/ObterMaterialByTipoMaterialId',
        type: 'GET',
        data: {
            tipoMaterialId : $('#Material_TipoMaterialId').val(),
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
