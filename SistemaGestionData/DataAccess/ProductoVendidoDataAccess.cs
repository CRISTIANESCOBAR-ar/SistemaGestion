using System;
using SistemaGestionData;
using SistemaGestionData.Context;
using SistemaGestionEntities;

namespace SistemaGestionData.DataAccess;

public class ProductoVendidoDataAccess
{
    private SistemaGestionContext _context = new SistemaGestionContext();

    public ProductoVendidoDataAccess()
    {
        _context = new SistemaGestionContext();        
    }

    public ProductoVendido? ObtenerProductoVendido(int id)
    {
        return _context.ProductoVendido.FirstOrDefault(productov => productov.Id == id);
    }

    public List<ProductoVendido> ListarProductosVendidos()
    {
        return _context.ProductoVendido.ToList();
    }

    public void CrearProductoVendido(ProductoVendido productov)
    {
        _context.ProductoVendido.Add(productov);
        _context.SaveChanges();
    }

    public void ModificarProductoVendido(int id, ProductoVendido productov)
    {
        _context.ProductoVendido.Update(productov);
        _context.SaveChanges();
    }

    public void EliminarProductoVendido(int id)
    {
        var productov = ObtenerProductoVendido(id);
        if (productov != null)
        {
            _context.ProductoVendido.Remove(productov);
            _context.SaveChanges();
        }
    }
}
