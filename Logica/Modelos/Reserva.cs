namespace Logica.Modelos;

public enum TipoSala { Podcast, Video }
public enum TipoReserva { Individual, Corporativa }

public class Reserva
{
    private string nombreCliente;
    private string correoCliente;

    public int Codigo { get; }
    public DateTime FechaRegistro { get; }
    public string NombreCliente { get => nombreCliente; private set => nombreCliente = value.Trim(); }
    public string CorreoCliente { get => correoCliente; private set => correoCliente = value.Trim(); }
    public TipoSala Sala { get; }
    public DateTime FechaReserva { get; }
    public int Horas { get; }
    public virtual TipoReserva Tipo => TipoReserva.Individual;
    public decimal Tarifa => Sala == TipoSala.Podcast ? 7000m : 10000m;
    public decimal Subtotal => Horas * Tarifa;
    public virtual decimal Total => Subtotal;
    public decimal Descuento => Subtotal - Total;

    internal Reserva(int codigo, string nombre, string correo, TipoSala sala,
        DateTime fecha, int horas, DateTime registro)
    {
        Codigo = codigo;
        nombreCliente = correoCliente = string.Empty;
        NombreCliente = nombre;
        CorreoCliente = correo;
        Sala = sala;
        FechaReserva = fecha;
        Horas = horas;
        FechaRegistro = registro;
    }
}
