using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL_1
{
    class Cola
    {
        cliente _inicio;
        public void Encolar(cliente unCliente)
        {
            if (_inicio == null)
            {
                _inicio = unCliente;
            }
            else
            {
                cliente aux = Buscar_ultimo(_inicio);
                aux.Siguiente = unCliente;
            }
        }

        private cliente Buscar_ultimo(cliente unCliente)
        {
            if(unCliente.Siguiente == null)
            {
                return unCliente;
            }
            else
            {
                return Buscar_ultimo(unCliente.Siguiente);
            }
        }

        public void Desencolar()
        {
            _inicio = _inicio.Siguiente;
        }

        public cliente Inicio
        {
            get
            {
                return _inicio;
            }
        }

        public bool Vacio()
        {
            return (_inicio == null);
        }
    }
}
