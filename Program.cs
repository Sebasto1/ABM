using System;
using System.Linq;
using ABM;



public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lista de Productos");

        List<Producto> lista = ProductoData.ListarProductos();
        foreach (var item in lista)
        {
            Console.WriteLine("Descripcion " + item.Descripciones);

        }

    }
}

