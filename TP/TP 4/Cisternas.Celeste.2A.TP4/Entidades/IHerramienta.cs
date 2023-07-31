using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IHerramienta
    {
        string Uso(ETipoHerramienta tipo);

        int DurabilidadPorTipo(ETipoMaterial material);
    }
}
