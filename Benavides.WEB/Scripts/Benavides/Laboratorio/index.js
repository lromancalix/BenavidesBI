$(document).ready(function () {

    jQuery("#contenedor-datosLaboratorio").validationEngine();
    BENAVIDES.app.InitDialogModal("modal-laboratorio");
    /**
    * BOTONES
    */

    $("#btn-nuevoLaboratorio").click(function () {
        //div-datosLaboratorio
        BENAVIDES.app.ShowModal("modal-laboratorio")

        
    });


    $("#btn-laboratorio-aceptar").click(function () {
        //div-datosLaboratorio
        // $("#div-datosLaboratorio").validationEngine('validate');
        //if (jQuery("#div-DetallePromocion").validationEngine('validate')) {
        //    alert("guardando");
        //}

        if (jQuery("#modal-body-laboratorio").validationEngine('validate')) {
            alert("guardando datos calix");
        }
    });

   
});
