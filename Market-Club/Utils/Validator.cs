using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Club.Utils
{
    internal static class Validator
    {
        static string patron = @"^[a-zA-Z\s]+$";
        static string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";


        public static bool isValidText(string text, string fieldCamp)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show($"El campo {fieldCamp} no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!Regex.IsMatch(text, patron))
            {
                MessageBox.Show($"El campo {fieldCamp} solo puede contener letras y espacios.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        // Validación de número
        public static bool isValidNum(string text, string fieldCamp)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show($"El campo {fieldCamp} no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!int.TryParse(text, out int num))
            {
                MessageBox.Show($"El campo {fieldCamp} debe contener un número válido.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        // Validación de email
        public static bool isValidEmail(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("El campo de correo electrónico no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!Regex.IsMatch(text, emailPattern))
            {
                MessageBox.Show("El correo electrónico no tiene un formato válido.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static bool isValidImage(object image, string fieldCamp)
        {
            if (image == null)
            {
                MessageBox.Show($"El campo {fieldCamp} no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}