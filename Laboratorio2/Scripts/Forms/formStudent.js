const nameInp = document.querySelector('#nameInput');
const apellidoInp = document.querySelector('#apellidoInput');
const emailInp = document.querySelector('#emailInput');
const radioBtnM = document.getElementById('radioM');
const radioBtnF = document.getElementById('radioF');
const adressInp = document.querySelector('#addressInput');
const dropDownCity = document.querySelector('#DropDownList1');
const requiredArea = document.querySelector('#requiredArea');
// Captura el div del modal para colorcar texto
const errors_camp = document.querySelector('#content-modal-text');


let nombre;
let apellido;


// Expresiones regulares para hacer la validacion de los inputs
const expresiones = {
    //nombre: /^[a-zA-ZÀ-ÿ\s]{1,40}$/, // Letras y espacios, pueden llevar acentos.
    nombre: /^(?!.*\s{2})[a-zA-ZÀ-ÿ\s]{1,40}$/,
    correo: /^[^\s]+[a-zA-Z0-9_.+-]+@unsa\.edu\.pe$/,
}


function add_error(text_error) {
    const renderText = document.createElement("p");
    renderText.innerText = text_error;
    errors_camp.appendChild(renderText);
}

function cleanHTML() {
    // Eliminar los elementos p 
    while (errors_camp.childNodes[1]) {
        errors_camp.removeChild(errors_camp.childNodes[1]);
    }
};

function sendInformation() {
    const fechaActual = new Date();
    let formatearFecha = fechaActual.toLocaleString();
    let error;
    let formGood;

    let verificador = false;
    if (!expresiones.nombre.test(nameInp.value)) {
        error = 'Revisar que el nombre este bien escrito';
        add_error(error);
        verificador = true;
    }
    if (!expresiones.nombre.test(apellidoInp.value)) {
        error = 'Error en el apellido';
        add_error(error);
        vericador = true;
    }
    if (radioBtnM.checked == false && radioBtnF.checked == false) {
        error = 'Sexo no seleccionado';
        add_error(error);
        verificador = true;
    }
    if (!expresiones.correo.test(emailInp.value)) {
        error = 'Correo invalido, solo correo de la UNSA';
        add_error(error);
        verificador = true;
    }
    //console.log(`espacio${emailInp.value}espacio`)
    if (dropDownCity.value == 0) {
        error = 'Seleccionar una ciudad';
        add_error(error);
        verificador = true;
    }

    if (verificador == false) {
        formGood = `Formulario registrado: ${formatearFecha}`;
        alert(formGood);
        add_error(formGood);
        return true;
    } else {
        return false;
    }
}


function Clean() {
    let voidContent = "";
    nameInp.value = voidContent;
    apellidoInp.value = voidContent;
    radioBtnM.checked = false;
    radioBtnF.checked = false;
    emailInp.value = voidContent;
    adressInp.value = voidContent;
    dropDownCity.value = 0;
    requiredArea.value = voidContent;
    return false;
}

function verifyAjax(nombre, apellido) {
    var jsonData = {
        name: nombre,
        lastname: apellido
    };
    console.log(JSON.stringify(jsonData));
    $.ajax({
        url: 'FormStudents.aspx/getInfo',
        type: 'POST',
        async: true,
        data: JSON.stringify(jsonData),
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: exito,
     
    return false;
}

function exito(data) {
    let verify = data.d;
    $('#boxRegisterError').css("display", "block");
    $('#text').text(data.d);

    var palabraBuscada = "ya";
    var palabraEncontrada = verify.includes(palabraBuscada);
    $('#boxRegisterError').removeClass('bg-danger bg-success');
    if (palabraEncontrada) {
        $('#boxRegisterError').addClass('bg-danger');
    } else {
        $('#boxRegisterError').addClass('bg-success');
    }

    return false;
}

function onInputFinish() {
    nombre = document.getElementById('nameInput').value;
    apellido = document.getElementById('apellidoInput').value;

    verifyAjax(nombre, apellido);
    console.log("Nombre:", nombre);
    console.log("Apellidos:", apellido);
}
document.getElementById('apellidoInput').addEventListener('input', onInputFinish);
