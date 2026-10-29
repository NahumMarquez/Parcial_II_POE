using System.Globalization;
using System.Windows.Forms;

namespace Parcial_II_POE.Clases
{
    public static class Validaciones
    {
        // KeyPress: solo letras y espacios
        public static void SoloLetras(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        // KeyPress: solo digitos
        public static void SoloNumeros(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        // KeyPress: letras y numeros (codigo)
        public static void LetrasYNumeros(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
                e.Handled = true;
        }

        // KeyPress: letras, numeros, espacio, '-' y '/' (ciclo, nombre de materia)
        public static void TextoGeneral(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar)
                && e.KeyChar != ' ' && e.KeyChar != '-' && e.KeyChar != '/')
                e.Handled = true;
        }

        // KeyPress: digitos y un unico punto decimal ('-' bloqueado => no hay negativos)
        public static void SoloDecimal(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar)) return;
            if (e.KeyChar == '.' && !txt.Text.Contains(".")) return;
            e.Handled = true;
        }

        // Convierte a decimal y valida 0 <= nota <= 10
        public static bool TryNota(string texto, out decimal nota)
        {
            return decimal.TryParse(texto, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out nota)
                   && nota >= 0m && nota <= 10m;
        }

        // BONUS: pasa a MAYUSCULA el contenido de todos los TextBox del contenedor
        public static void TextBoxesAMayuscula(Control contenedor)
        {
            foreach (Control c in contenedor.Controls)
            {
                TextBox txt = c as TextBox;
                if (txt != null) txt.Text = txt.Text.Trim().ToUpper();
                else if (c.HasChildren) TextBoxesAMayuscula(c);
            }
        }
    }
}
