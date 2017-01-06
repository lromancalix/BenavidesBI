
/**
* BOTONES
*/

$("#btn-nuevoLaboratorio").click(function () {
    //div-datosLaboratorio
    BENAVIDES.app.ShowTitleGeneralModal("Nuevo Laboratorio");
    BENAVIDES.app.ShowInGeneralModalBody($("#div-datosLaboratorio").html());
    BENAVIDES.app.ShowGeneralModal();
});