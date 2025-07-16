using System;
using System.Security.Cryptography;
using System.Text;

namespace Eventum.Data
{
    public static class SeguridadHelper
    {
        /// <summary>
        /// Encripta una cadena de texto utilizando SHA256 y la retorna como una cadena Base64.
        /// </summary>
        /// <param name="texto">Texto a encriptar</param>
        /// <returns>Texto encriptado en Base64</returns>
        public static string EncriptarSHA256(string texto)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Convertir el texto en un arreglo de bytes
                byte[] bytes = Encoding.UTF8.GetBytes(texto);

                // Realizar el hash (encriptar)
                byte[] hash = sha256.ComputeHash(bytes);

                // Convertir el arreglo de bytes resultante en un string Base64
                return Convert.ToBase64String(hash);
            }
        }

        /// <summary>
        /// Verifica si una contraseña es válida comparándola con la contraseña encriptada.
        /// </summary>
        /// <param name="contrasenaIngresada">Contraseña proporcionada por el usuario</param>
        /// <param name="contrasenaGuardada">Contraseña guardada en la base de datos</param>
        /// <returns>True si las contraseñas coinciden, false si no</returns>
        public static bool VerificarContrasena(string contrasenaIngresada, string contrasenaGuardada)
        {
            // Encriptamos la contraseña ingresada por el usuario
            string hashIngresado = EncriptarSHA256(contrasenaIngresada);

            // Comparamos el hash de la contraseña ingresada con la contraseña guardada
            return hashIngresado == contrasenaGuardada;
        }
    }
}

