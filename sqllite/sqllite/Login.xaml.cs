using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace sqllite
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        private DatabaseContext _databaseContext;
        public Login()
        {
            InitializeComponent();
            _databaseContext = new DatabaseContext(App.DatabasePath);
        }

        private void IniciarSesion_Clicked(object sender, EventArgs e)
        {
            string correo = CorreoEntry.Text;
            string contraseña = ContraseñaEntry.Text;

            // Verificar si el usuario existe en la base de datos
            var usuario = _databaseContext.ObtenerUsuarios()
                .FirstOrDefault(u => u.CorreoElectronico == correo && u.Contraseña == contraseña);

            if (usuario != null)
            {
                // Inicio de sesión exitoso, navegar a la nueva interfaz
                Navigation.PushAsync(new PaginaPrincipal(usuario));
            }
            else
            {
                // Mostrar un mensaje de error si las credenciales son incorrectas
                DisplayAlert("Error", "Credenciales incorrectas", "OK");
            }
        }

        private void Registrarse_Clicked(object sender, EventArgs e)
        {
            
                
                Navigation.PushAsync(new MainPage());
           
        }
    }
}