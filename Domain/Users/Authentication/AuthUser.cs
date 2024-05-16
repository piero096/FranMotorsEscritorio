using Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain.Users.Authentication
{
    
    public static class AuthUser
    {
        private static readonly ConnectionContext context = new ConnectionContext();
        public static int UsuarioLogeadoId { get; private set; }

        

        public static bool Login(string usser, string password)
        {
            var user = context.User
                .FirstOrDefault(o => o.LoginName.Equals(usser) && o.Password.Equals(password));

            if (user != null)
            {
                if (user.LoginName == usser && user.Password == password && user.Estado == true)
                {
                    UsuarioLogeadoId = user.Id;
                    return true;
                }
                else
                {
                    //MessageBox.Show("Usuario inactivo, contactar con el administrador!!");
                    //Console.WriteLine("usuario nactivo");
                    return false;
                }

            }
            else
            {
                //MessageBox.Show("Usuario o contraseña incorrectos!!");
                //Console.WriteLine("usuario incorrecto");
                return false;
            }
        }
         public static void Logout()
        {
            UsuarioLogeadoId = 0;
        }

        public static string UserNameLoged()
        {
            var user = context.User.Where(o => o.Id == UsuarioLogeadoId).FirstOrDefault();

            return user.Name;
        }

        public static string UserLoguedTipo()
        {
            var user = context.User.Where(o => o.Id == UsuarioLogeadoId).FirstOrDefault();

            return user.Position;
        }
    }
}
