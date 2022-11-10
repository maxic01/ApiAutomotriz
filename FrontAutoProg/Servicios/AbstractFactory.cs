using FrontAutoProg.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontAutoProg.Servicios
{
    abstract class AbstractFactory
    {
        abstract public IServicio crearServicio();
    }
}
