using System;
using SistemaGestionData;
using SistemaGestionData.Context;
using SistemaGestionEntities;

namespace SistemaGestionData.DataAccess;

public class VentaDataAccess
{
    private SistemaGestionContext _context;

    public VentaDataAccess()
    {
        _context = new SistemaGestionContext();
    }

    public Venta? ObtenerVenta(int id)
    {
        return _context.Venta.FirstOrDefault(venta => venta.Id == id);
    }

    public List<Venta> ListarVentas()
    {
        return _context.Venta.ToList();
    }

    public void CrearVenta(Venta venta)
    {
        _context.Venta.Add(venta);
        _context.SaveChanges();
    }

    public void ModificarVenta(int id, Venta venta)
    {
        _context.Venta.Update(venta);
        _context.SaveChanges();
    }

    public void EliminarVenta(int id)
    {
        var venta = ObtenerVenta(id);
        if (venta != null)
        {
            _context.Venta.Remove(venta);
            _context.SaveChanges();
        }
    }
}
