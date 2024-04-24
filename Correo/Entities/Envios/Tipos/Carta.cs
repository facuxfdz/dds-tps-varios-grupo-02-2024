namespace Correo.Entities.Envios.Tipos;

public class Carta
{
    private CartaTipo _cartaTipo;
    private SelloTipo _selloTipo;

    public Carta(float precio, string codigoRastreo, CartaTipo cartaTipo, SelloTipo selloTipo)
    {
        _cartaTipo = cartaTipo;
        _selloTipo = selloTipo;
    }
}