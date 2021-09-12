using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DC_Engine
{
    public class DCDBConfig
    {
        //Hardcoded because of demo project
        public string Database_Name { get; set; } = "DC";
        public string Movie_Collection_Name { get; set; } = "Movies";
        public string Connection_String { get; set; } = "mongodb+srv://dbUserDC:Z9iCwn4nIIus99U1@cluster0.qkyaj.mongodb.net/DC?retryWrites=true&w=majority";
    }
}
