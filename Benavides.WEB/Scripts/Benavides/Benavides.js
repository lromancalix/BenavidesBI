var BENAVIDES = window.BENAVIDES || {};

BENAVIDES.app = (function ($, window, document, undefined) {
    //var ContentHeader = function (titulo, subtitulo) {
    //    $(".content-header h1").text(titulo);

    //}

    var alerta = function (texto) {
        alert(texto);
    }

    var InitDialogModal = function (idModal) {
        $("#" + idModal).modal("hide");
        //$("#" + idModal).modal("hide")
    }

    var ShowModal = function (idModal) {
        $("#" + idModal).modal("show");
    }

    var HideModal = function (idModal) {
        $("#" + idModal).modal("hide")
    }

    var InitDatePicker = function () {
        $(".date").datepicker({
            format: 'yyyy-mm-dd',
            startDate: '-3d'
        });
    }

    var ShowGeneralModal =  function(){
        $("#modal-general").modal("show");
    }

    var HideGeneralModal = function () {
        $("#modal-general").modal("hide");
    }

    var ShowInGeneralModalBody = function (content) {
        $(".modal-body-general").html(content)
    }

    var ShowTitleGeneralModal = function (title) {
        $("#tituloModal").text(title)
    }

    return {
        //ContentHeader: ContentHeader,
        alerta: alerta,
        InitDialogModal: InitDialogModal,
        HideModal: HideModal,
        InitDatePicker: InitDatePicker,
        ShowModal: ShowModal,
        ShowGeneralModal: ShowGeneralModal,
        HideGeneralModal: HideGeneralModal,
        ShowInGeneralModalBody: ShowInGeneralModalBody,
        ShowTitleGeneralModal: ShowTitleGeneralModal
    }
}(jQuery,window,document,undefined));