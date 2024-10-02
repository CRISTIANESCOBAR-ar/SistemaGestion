using System;
using SistemaGestionData;
using SistemaGestionData.Context;
using SistemaGestionEntities;

namespace SistemaGestionData.DataAccess;

public class ProductoDataAccess
{
private readonly SistemaGestionContext _context;

//VER GRABACION CLASE 12

    public ProductoDataAccess(SistemaGestionContext context)
    {
        _context = context;
    }

    public List<Producto> GetProductos()
    {
        return _context.Producto.ToList();
    }

    public List<Producto> GetProductosBy(string filtro)
    {
        return _context.Producto.Where(p => p.Descripcion.Contains(filtro)).ToList();
    }

    public Producto? GetOneProducto(int id)
    {
        return _context.Producto.FirstOrDefault(p => p.Id == id);
    }

    public void InsertProducto(Producto producto)
    {
        _context.Producto.Add(producto);
        _context.SaveChanges();
    }

    public void UpdateProducto(int id, Producto producto)
    {
        var productoToUpdate = GetOneProducto(id);
        if (productoToUpdate != null)
        {
            productoToUpdate.Descripcion = producto.Descripcion;
            productoToUpdate.Stock = producto.Stock;
            productoToUpdate.Costo = producto.Costo;
            productoToUpdate.PrecioVenta = producto.PrecioVenta;
            productoToUpdate.IdUsuario = producto.IdUsuario;
            _context.SaveChanges();
        }
    }

    public void DeleteProducto(int id)
    {
        var productoToDelete = GetOneProducto(id);
        if (productoToDelete != null)
        {
            _context.Producto.Remove(productoToDelete);
            _context.SaveChanges();
        }
    }
}
