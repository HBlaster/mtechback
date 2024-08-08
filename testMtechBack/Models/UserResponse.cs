using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testMtechBack.Models
{
    /*
            Represents the response structure for user-related operations.
            This model encapsulates the data that will be returned to the client
            in a structured format, making it easier to handle on the client side.
    */
    public class UserResponse
    {
        
        public int id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}