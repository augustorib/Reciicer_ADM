$(document).ready(function () {
    $('#Telefone').mask('(00) 0000-0000');
    $('#CPF').mask('000.000.000-00', {reverse: true});
    $('#CNPJ').mask('00.000.000/0000-00', {reverse: true});
    $('#Email').mask("A", {
        translation: {
            "A": { pattern: /[\w@\-.+]/, recursive: true }
        }
    });
});