

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

function errorContraseña() {
    swal('Mensaje de Sistema',
        'Has ingresado una contraseña incorrecta',
        'info');
}

function errorIngreso() {
    swal('Mensaje de Sistema',
        'Se ha producido un error al ingresar',
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
