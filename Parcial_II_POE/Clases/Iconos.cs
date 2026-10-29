using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Parcial_II_POE.Clases
{
    // Pone iconos a formularios, botones y opciones de menu usando las imagenes de Resources
    public static class Iconos
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern bool DestroyIcon(IntPtr handle);

        // Icono de la ventana (esquina superior izquierda)
        public static void Formulario(Form frm, Image imagen)
        {
            using (Bitmap bmp = new Bitmap(imagen, new Size(32, 32)))
            {
                IntPtr handle = bmp.GetHicon();
                frm.Icon = (Icon)Icon.FromHandle(handle).Clone();
                DestroyIcon(handle);
            }
            frm.ShowIcon = true;
        }

        // Icono a la izquierda y texto centrado, ambos centrados en vertical
        public static void Boton(Button boton, Image imagen)
        {
            boton.Image = new Bitmap(imagen, new Size(18, 18));
            boton.ImageAlign = ContentAlignment.MiddleLeft;
            boton.TextAlign = ContentAlignment.MiddleCenter;
            boton.TextImageRelation = TextImageRelation.Overlay;
            boton.Padding = new Padding(6, 0, 0, 0);
            if (boton.Width < 90) boton.Width = 90;
            boton.Height = 31;
        }

        // Imagen en una opcion del menu
        public static void Menu(ToolStripMenuItem opcion, Image imagen)
        {
            opcion.Image = imagen;
        }
    }
}
