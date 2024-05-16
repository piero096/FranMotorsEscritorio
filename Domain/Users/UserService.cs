using Common.Models;
using Connection;
using Domain.Users.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Users
{
    public class UserService : IUserRepository
    {
        private readonly ConnectionContext context;

        public UserService()
        {
            context = new ConnectionContext();
        }
        public void ActualizarUsuario(int Id, User user)
        {
            
            var usuario = context.User.Find(Id);
            usuario.LoginName = user.LoginName;
            usuario.Password = user.Password;
            usuario.Name = user.Name;
            usuario.LastName = user.LastName;
            usuario.Position = user.Position;
            usuario.Email = user.Email; 
            usuario.Estado = user.Estado;

            context.SaveChanges();
        }

        public void CrearUsuario(User user)
        {
            context.User.Add(user);
            context.SaveChanges();
        }

        public void EliminarUsuario(int id)
        {
            var user = context.User.Where(o => o.Id == id).FirstOrDefault();
            
            context.User.Remove(user);
            context.SaveChanges();
        }

        public List<User> ObtenerTodosLosUsuarios()
        {
            return context.User.ToList();
        }

        public User ObtenerUsuarioPorDniNombreApellido(string datos)
        {
            throw new NotImplementedException();
        }

        public List<User> ObtenerUsuarioPorDniNombreApellidos(string datos)
        {
            throw new NotImplementedException();
        }

        public User ObtenerUsuarioPorEmail(string email)
        {
            throw new NotImplementedException();
        }

        public User ObtenerUsuarioPorId(int id)
        {
            return context.User
                .Where(o => o.Id == id).FirstOrDefault();
        }
    }
}
