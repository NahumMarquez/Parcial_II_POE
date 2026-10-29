using System;

namespace Parcial_II_POE.Clases
{
    // Aviso global: los repositorios lo disparan cuando se guarda algo en la BD
    // y el Panel lo escucha para refrescar su grilla al instante.
    public static class Notificador
    {
        public static event Action DatosCambiaron;

        public static void Avisar()
        {
            Action handler = DatosCambiaron;
            if (handler != null) handler();
        }
    }
}
