function eliminar(url)
{
    if (window.confirm('Realmente desea eliminar este registro?'))
    {
        window.location = url;
    }
}
function edit(nombre, correo) {
    document.getElementById('nombre').value = nombre;
    document.getElementById('correo').value = correo;
}