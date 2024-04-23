namespace Correo.Envios;

public abstract class Envio
{
    private float _precio;
    private string _codigoRastreo;
    private bool _entregado;
    
    public Envio(float precio, string codigoRastreo)
    {
        _precio = precio;
        _codigoRastreo = codigoRastreo;
        _entregado = false;
    }
    
    public float Precio => _precio;
    public string CodigoRastreo => _codigoRastreo;
    public bool Entregado => _entregado;
}