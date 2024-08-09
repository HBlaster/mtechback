using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;
using System.Web;

using testMtechBack.Models;

namespace testMtechBack.Data
{
    public class UserData
    {

        private static readonly string jsonFilePath = HttpContext.Current.Server.MapPath("~/App_Data/usersData.json");

        public static List<UserResponse> retrieveUsers () {

            List<UserResponse> oUsers = new List<UserResponse>();

            try
            {
                // Leer el contenido del archivo JSON
                string jsonContent = File.ReadAllText(jsonFilePath);

                // Deserializar el contenido JSON en una lista de objetos
                oUsers = JsonConvert.DeserializeObject<List<UserResponse>>(jsonContent);
            }
            catch (Exception ex)
            {
                // Manejar posibles errores (como archivo no encontrado o errores de deserialización)
                Console.WriteLine("Error al leer el archivo JSON: " + ex.Message);
            }

            return oUsers;
        }
    }
}