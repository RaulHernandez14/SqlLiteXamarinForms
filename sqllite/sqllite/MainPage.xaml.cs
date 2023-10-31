using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace sqllite
{
    public partial class MainPage : ContentPage
    {
        private DatabaseContext _databaseContext;

        public MainPage()
        {
            InitializeComponent();
            _databaseContext = new DatabaseContext(App.DatabasePath);
        }

        private void Registrar_Clicked(object sender, EventArgs e)
        {
            // Crear un nuevo usuario y guardar los datos ingresados en la base de datos
            var usuario = new Usuario
            {
                NombreCompleto = NombreEntry.Text,
                CorreoElectronico = CorreoEntry.Text,
                Contraseña = ContraseñaEntry.Text
            };

            _databaseContext.InsertarUsuario(usuario);

            // Limpiar los campos de entrada
            NombreEntry.Text = string.Empty;
            CorreoEntry.Text = string.Empty;
            ContraseñaEntry.Text = string.Empty;

            // Mostrar un mensaje de éxito
            DisplayAlert("Éxito", "Usuario registrado correctamente", "OK");
        }
    }
}
