using SQLite;
using SQLiteNetExtensions.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;


namespace sqllite
{
    public class DatabaseContext
    {
        readonly SQLiteConnection _database;

        public DatabaseContext(string dbPath)
        {
            _database = new SQLiteConnection(dbPath);
            _database.CreateTable<Usuario>();
        }

        public List<Usuario> ObtenerUsuarios()
        {
            return _database.GetAllWithChildren<Usuario>().ToList();
        }

        public void InsertarUsuario(Usuario usuario)
        {
            _database.InsertWithChildren(usuario);
        }
    }
}
