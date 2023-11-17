using DemoLogin.Models;

namespace DemoLogin.Repositories
{
    public class UsuarioRepository
    {
        public Usuario Get(string email)
        => GetUsuarios().FirstOrDefault(x => x.Email == email);


        private List<Usuario> GetUsuarios()
        {
            return new List<Usuario>()
            {
                new Usuario()
                {
                    Email = "diego@dominio.com",
                    Senha = "123456",
                    Role = "admin"
                },
                new Usuario()
                {
                    Email = "joao@dominio.com",
                    Senha = "111111",
                    Role = "user"
                }
            };
        }        
    }     
}
