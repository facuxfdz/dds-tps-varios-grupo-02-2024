namespace Correo.Entities.Envios.Tipos;

public class Encomienda
{
    private EncomiendaTipo _tipo;

    public Encomienda(float precio, string codigoRastreo, EncomiendaTipo tipo)
    {
        _tipo = tipo;
    }
}

