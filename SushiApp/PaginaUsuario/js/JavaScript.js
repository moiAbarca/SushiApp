
function modalLoginEmpty() {
    swal('Oops!',
        'Debes ingresar datos',
        'info');
}

function usuarioNoExiste() {
    swal('Mensaje de Sistema',
        'Usuario ingresado no existe',
        'error');
}

function errorConexion() {
    swal('Mensaje de Sistema',
        'Error al conectar. Compruebe que tiene acceso a Internet e intente nuevamente',
        'error');
}

function errorContraseña() {
    swal('Mensaje de Sistema',
        'Has ingresado una contraseña incorrecta',
        'info');
}

function errorIngreso() {
    swal('Mensaje de Sistema',
        'Se ha producido un error al cargar',
        'error');
}

function UserCreateSuccess() {
    swal('Felicitaciones!',
        'Usuario creado exitosamente',
        'success');
}

function usuarioExiste() {
    swal('Mensaje de Sistema',
        'Usuario ingresado ya existe en nuestro Sistema',
        'error');
}

function customerCreateSuccess() {
    swal('Felicitaciones!',
        'Cliente creado exitosamente',
        'success');
}

function contraModificada() {
    swal('Exito!',
        'Contraseña modificada exitosamente',
        'success');
}

function samePassword() {
    swal('Atención!',
        'Contraseña nueva no debe ser idéntica a la anterior',
        'warning');
}


function errorFecha() {
    swal('Atención!',
        'Fecha ingresada debe ser del estilo dd/mm/aaaa',
        'info');
}

function fechaMenorFecha() {
    swal('Atención!',
        'Fecha no puede ser mayor a la fecha actual',
        'warning');
}

function ventaOk() {
    swal('Felicitaciones!',
        'Su compra se ha procesado con éxito',
        'success');
}

function shopBasketEmpty() {
    swal('Atención!',
        'Su carrito se encuentra vacio',
        'info');
}

function error() {
    swal('Atención!',
        'Fecha no puede ser mayor a la fecha actual',
        'warning');
}