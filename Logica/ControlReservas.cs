using System.Net.Mail;
using Logica.Modelos;

namespace Logica;

public record DatosReserva(string Nombre, string Correo, TipoReserva Tipo, TipoSala Sala,
    DateTime Fecha, int Horas);

public class ControlReservas
{
    private readonly List<Reserva> reservas = new();
    private int siguienteCodigo = 1;

    public Dictionary<string, string> Validar(DatosReserva datos)
    {
        var errores = new Dictionary<string, string>();
        if (string.IsNullOrWhiteSpace(datos.Nombre))
            errores[nameof(datos.Nombre)] = "Escribe el nombre del cliente.";
        if (!MailAddress.TryCreate(datos.Correo.Trim(), out var correo)
            || correo.Address != datos.Correo.Trim() || !correo.Host.Contains('.'))
            errores[nameof(datos.Correo)] = "Escribe un correo válido, por ejemplo ana@empresa.cr.";
        if (datos.Fecha <= DateTime.Now)
            errores[nameof(datos.Fecha)] = "Elige una fecha y hora futuras.";
        if (datos.Horas is < 1 or > 4)
            errores[nameof(datos.Horas)] = "Selecciona de 1 a 4 horas.";
        if (!Enum.IsDefined(datos.Sala)) errores[nameof(datos.Sala)] = "Selecciona una sala.";
        if (!Enum.IsDefined(datos.Tipo)) errores[nameof(datos.Tipo)] = "Selecciona el tipo de reserva.";
        return errores;
    }

    private static Reserva Crear(DatosReserva d, int codigo, DateTime registro) =>
        d.Tipo == TipoReserva.Corporativa
            ? new ReservaCorporativa(codigo, d.Nombre, d.Correo, d.Sala, d.Fecha, d.Horas, registro)
            : new Reserva(codigo, d.Nombre, d.Correo, d.Sala, d.Fecha, d.Horas, registro);

    public Reserva Cotizar(DatosReserva datos) => Crear(datos, 0, DateTime.Now);

    private void Revisar(DatosReserva datos)
    {
        var errores = Validar(datos);
        if (errores.Count > 0) throw new ArgumentException(string.Join(Environment.NewLine, errores.Values));
    }

    public Reserva Registrar(DatosReserva datos)
    {
        Revisar(datos);
        var reserva = Crear(datos, siguienteCodigo++, DateTime.Now);
        reservas.Add(reserva);
        return reserva;
    }

    public void Modificar(int codigo, DatosReserva datos)
    {
        Revisar(datos);
        int indice = reservas.FindIndex(r => r.Codigo == codigo);
        if (indice < 0) throw new KeyNotFoundException("La reserva ya no existe.");
        reservas[indice] = Crear(datos, codigo, reservas[indice].FechaRegistro);
    }

    public bool Eliminar(int codigo) => reservas.RemoveAll(r => r.Codigo == codigo) > 0;

    public List<Reserva> BuscarPorNombre(string nombre) =>
        reservas.FindAll(r => r.NombreCliente.Contains(nombre.Trim(), StringComparison.CurrentCultureIgnoreCase));

    public (int Cantidad, decimal Monto) Resumen()
    {
        decimal monto = 0;
        foreach (var reserva in reservas) monto += reserva.Total;
        return (reservas.Count, monto);
    }
}
