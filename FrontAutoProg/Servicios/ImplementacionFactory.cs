using FrontAutoProg.Servicios.Implementaciones;
using FrontAutoProg.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontAutoProg.Servicios
{
    internal class ImplementacionFactory : AbstractFactory
    {
        public override IServicio crearServicio()
        {
            return new FacturaServicio();
        }
    }
}
