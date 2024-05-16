using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Users.Repositories
{
    internal interface IUserRepository
    {
        void CrearUsuario(User user);
        List<User> ObtenerTodosLosUsuarios();
        void ActualizarUsuario(int Id, User user);
        void EliminarUsuario(int id);
        User ObtenerUsuarioPorId(int id);
        User ObtenerUsuarioPorDniNombreApellido(string datos);
        User ObtenerUsuarioPorEmail(string email);
        List<User> ObtenerUsuarioPorDniNombreApellidos(string datos);
    }
}
