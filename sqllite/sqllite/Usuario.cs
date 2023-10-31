using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace sqllite
{
    public class Usuario
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public string CorreoElectronico { get; set; }
        public string Contraseña { get; set; }
    }

        
}
