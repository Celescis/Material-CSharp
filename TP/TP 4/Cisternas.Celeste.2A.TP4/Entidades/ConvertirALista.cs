using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ConvertirALista
    {
        public static Wiki ListaJugadoresConInventario(DataTable dt)
        {
            Wiki wiki = new Wiki();
            Jugador player;
            Inventario inv;
            Cubo cubo = new Cubo();
            Herramienta tool = new Herramienta();
            bool isOk;

            foreach (DataRow dr in dt.Rows)
            {
                inv = new Inventario();
                int c = 0;
                int h = 0;

                if (!string.IsNullOrEmpty(dr[6].ToString()))
                {
                    if (bool.Parse(dr[6].ToString()) == false)
                    {
                        cubo = new Cubo((ETipoMaterial)Enum.Parse(typeof(ETipoMaterial), dr[5].ToString()), int.Parse(dr[4].ToString()));
                        inv.ListaElementos.Add(cubo);
                        c = 1;
                    }
                    else
                    {
                        tool = new Herramienta((ETipoHerramienta)Enum.Parse(typeof(ETipoHerramienta), dr[7].ToString()), (ETipoMaterial)Enum.Parse(typeof(ETipoMaterial), dr[5].ToString()), int.Parse(dr[4].ToString()));
                        inv.ListaElementos.Add(tool);
                        h = 1;
                    }
                }

                if (!string.IsNullOrEmpty(dr[3].ToString()))
                {
                    inv.Capacidad = int.Parse(dr[3].ToString());
                }

                inv.ID = int.Parse(dr[2].ToString());
                player = wiki.GetJugador(dr[1].ToString(), out isOk);
                player.Id = int.Parse(dr[0].ToString());

                if (!isOk)
                {
                    if (c == 1 && h == 1)
                    {
                        player.Inventario.ListaElementos.Add(cubo);
                        player.Inventario.ListaElementos.Add(tool);
                    }
                    else
                    {
                        if (c == 1 && h == 0)
                        {
                            player.Inventario.ListaElementos.Add(cubo);
                        }
                        else
                        {
                            player.Inventario.ListaElementos.Add(tool);
                        }
                    }
                    player.Inventario.OrdenarInventario();
                }
                else
                {
                    wiki.Jugadores.Add(new Jugador(int.Parse(dr[0].ToString()), dr[1].ToString(), inv));
                }
            }

            return wiki;
        }
    }
}
