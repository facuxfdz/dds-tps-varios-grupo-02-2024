using Correo.Envios;

namespace Correo.Entities.Envios.Tipos;

public class Giro : Envio
{
    private float _importe;
    
    public Giro(float precio, string codigoRastreo, float importe) : base(precio, codigoRastreo)
    {
        _importe = importe;
    }
    
    public float Importe => _importe;
}