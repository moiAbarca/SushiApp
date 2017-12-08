using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SushiApp.Models
{
    public class Usuario
    {
        public Usuario() { }

        private int _usuario_Id;
        private int _pass;
        private String _usuario1;

        public int Usuario_Id
        {
            get
            {
                return _usuario_Id;
            }

            set
            {
                _usuario_Id = value;
            }
        }

        public int Pass
        {
            get
            {
                return _pass;
            }

            set
            {
                _pass = value;
            }
        }

        public string Usuario1
        {
            get
            {
                return _usuario1;
            }

            set
            {
                _usuario1 = value;
            }
        }

        public static explicit operator Usuario(List<object> v)
        {
            throw new NotImplementedException();
        }
    }
}