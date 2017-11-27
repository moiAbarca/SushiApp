

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

function validaFechaDDMMAAAA(fecha) {
    var dtCh = "/";
    var minYear = 1900;
    var maxYear = 2100;
    function isInteger(s) {
        var i;
        for (i = 0; i < s.length; i++) {
            var c = s.charAt(i);
            if (((c < "0") || (c > "9"))) return false;
        }
        return true;
    }
    function stripCharsInBag(s, bag) {
        var i;
        var returnString = "";
        for (i = 0; i < s.length; i++) {
            var c = s.charAt(i);
            if (bag.indexOf(c) == -1) returnString += c;
        }
        return returnString;
    }
    function daysInFebruary(year) {
        return (((year % 4 == 0) && ((!(year % 100 == 0)) || (year % 400 == 0))) ? 29 : 28);
    }
    function DaysArray(n) {
        for (var i = 1; i <= n; i++) {
            this[i] = 31
            if (i == 4 || i == 6 || i == 9 || i == 11) { this[i] = 30 }
            if (i == 2) { this[i] = 29 }
        }
        return this
    }
    function isDate(dtStr) {
        var daysInMonth = DaysArray(12)
        var pos1 = dtStr.indexOf(dtCh)
        var pos2 = dtStr.indexOf(dtCh, pos1 + 1)
        var strDay = dtStr.substring(0, pos1)
        var strMonth = dtStr.substring(pos1 + 1, pos2)
        var strYear = dtStr.substring(pos2 + 1)
        strYr = strYear
        if (strDay.charAt(0) == "0" && strDay.length > 1) strDay = strDay.substring(1)
        if (strMonth.charAt(0) == "0" && strMonth.length > 1) strMonth = strMonth.substring(1)
        for (var i = 1; i <= 3; i++) {
            if (strYr.charAt(0) == "0" && strYr.length > 1) strYr = strYr.substring(1)
        }
        month = parseInt(strMonth)
        day = parseInt(strDay)
        year = parseInt(strYr)
        if (pos1 == -1 || pos2 == -1) {
            return false
        }
        if (strMonth.length < 1 || month < 1 || month > 12) {
            return false
        }
        if (strDay.length < 1 || day < 1 || day > 31 || (month == 2 && day > daysInFebruary(year)) || day > daysInMonth[month]) {
            return false
        }
        if (strYear.length != 4 || year == 0 || year < minYear || year > maxYear) {
            return false
        }
        if (dtStr.indexOf(dtCh, pos2 + 1) != -1 || isInteger(stripCharsInBag(dtStr, dtCh)) == false) {
            return false
        }
        return true
    }
    if (isDate(fecha)) {
        return true;
    } else {
        return false;
    }
}

function existeFecha(fecha) {
    var fechaf = fecha.split("/");
    var day = fechaf[0];
    var month = fechaf[1];
    var year = fechaf[2];
    var date = new Date(year, month, '0');
    if ((day - 0) > (date.getDate() - 0)) {
        return false;
    }
    return true;
}

function validarFechaMenorActual(date) {
    var x = new Date();
    var fecha = date.split("/");
    x.setFullYear(fecha[2], fecha[1] - 1, fecha[0]);
    var today = new Date();

    if (x >= today)
        return false;
    else
        return true;
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
        'Su compra se ha realizado con éxito',
        'success');
}
