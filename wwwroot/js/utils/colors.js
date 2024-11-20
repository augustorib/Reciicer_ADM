//Obter as cores de acordo com o tipo de material para usar
//na visualização de gráficos Home/Index
function ObterCorParaTipoMaterial(tipoMaterial) {
    switch (tipoMaterial) {
        case 'Plástico':
            return '#fa4251';
        case 'Papel':
            return '#00b5e9';
        case 'Vidro':
            return '#51f590';
        case 'Metal':
            return '#f7f763';
        default:
            return '#cccccc'; 
    }
}

function ObterCoresParaTipoMaterial(tipoMateriais) {
    return tipoMateriais.map(ObterCorParaTipoMaterial);
}