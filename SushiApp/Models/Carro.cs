using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SushiApp.Models
{
    public class Carro
    {
        private int _pedidoId;
        private int _productoId;
        private String _nombreProducto;
        private String _imagenProducto;
        private int _precioUnitario;
        private string _cantidad;
        private int _descuento;
        private int _precioTotal;

        public int PedidoId
        {
            get
            {
                return _pedidoId;
            }
            set
            {
                _pedidoId = value;
            }
        }
            
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
        
        public string ImagenProducto
        {
            get
            {
                return _imagenProducto;
            }
            set
            {
                _imagenProducto = value;
            }
        }
        
        public int PrecioUnitario
        {
            get
            {
                return _precioUnitario;
            }
            set
            {
                _precioUnitario = value;
            }
        }
        
        public string Cantidad
        {
            get
            {
                return _cantidad;
            }
            set
            {
                _cantidad = value;
            }
        }
      
        public int Descuento
        {
            get
            {
                return _descuento;
            }
            set
            {
                _descuento = value;
            }
        }
       
        public int PrecioTotal
        {
            get
            {
                return _precioTotal;
            }
            set
            {
                _precioTotal = value;
            }
        }
     
    }
}