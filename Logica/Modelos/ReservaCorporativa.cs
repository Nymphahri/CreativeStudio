namespace Logica.Modelos;

public sealed class ReservaCorporativa : Reserva
{
    internal ReservaCorporativa(int codigo, string nombre, string correo, TipoSala sala,
        DateTime fecha, int horas, DateTime registro)
        : base(codigo, nombre, correo, sala, fecha, horas, registro) { }

    public override TipoReserva Tipo => TipoReserva.Corporativa;
    public override decimal Total => Subtotal * 0.90m;
}
