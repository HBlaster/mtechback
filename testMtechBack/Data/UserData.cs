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
                string jsonContent = File.ReadAllText(jsonFilePath);

                oUsers = JsonConvert.DeserializeObject<List<UserResponse>>(jsonContent);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al leer el archivo JSON: " + ex.Message);
            }

            return oUsers;
        }
    }
}