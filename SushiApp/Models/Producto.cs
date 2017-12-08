using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SushiApp.Models
{
    public class Producto
    {
        public Producto() { }

        private int _productoId;
        private int _categoriaProductoId;
        private String _nombreProducto;
        private int _porcionesProdcuto;
        private int _precioProducto;
        private String _descripcionProducto;
        private String _imagenProdcuto;
        private bool _disponibilidadProducto;

        public int ProductoId
        {
            get
            {
                return _productoId;
            }

            set
            {
                _productoId = value;
            }
        }

        public int CategoriaProductoId
        {
            get
            {
                return _categoriaProductoId;
            }

            set
            {
                _categoriaProductoId = value;
            }
        }

        public string NombreProducto
        {
            get
            {
                return _nombreProducto;
            }

            set
            {
                _nombreProducto = value;
            }
        }

        public int PorcionesProdcuto
        {
            get
            {
                return _porcionesProdcuto;
            }

            set
            {
                _porcionesProdcuto = value;
            }
        }

        public int PrecioProducto
        {
            get
            {
                return _precioProducto;
            }

            set
            {
                _precioProducto = value;
            }
        }

        public string DescripcionProducto
        {
            get
            {
                return _descripcionProducto;
            }

            set
            {
                _descripcionProducto = value;
            }
        }

        public string ImagenProdcuto
        {
            get
            {
                return _imagenProdcuto;
            }

            set
            {
                _imagenProdcuto = value;
            }
        }

        public bool DisponibilidadProducto
        {
            get
            {
                return _disponibilidadProducto;
            }

            set
            {
                _disponibilidadProducto = value;
            }
        }

        public static List<Producto> Add(Producto producto)
        {
            List<Producto> lst = new List<Producto>();


            return lst;
        }
    }
}