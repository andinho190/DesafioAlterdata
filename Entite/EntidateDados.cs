using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAlterdata.Entite
{
    public class EntidateDados
    {
        public DateTime CreatedAt { get; set; }
        public string Name { get; set; }

        public string Avatar { get; set; }

        public string Squad { get; set; }

        public string Login { get; set; }

        public string Email { get; set; }

        public string Id { get; set; }

        public string StatusCode { get; set; }

        
        public EntidateDados(DateTime createdAt, string name, string avatar, string squad, string login, string email, string id, string statusCode)
        {
            CreatedAt = createdAt;
            Name = name;
            Avatar = avatar;
            Squad = squad;
            Login = login;
            Email = email;
            Id = id;
            StatusCode = statusCode;

        }

        public EntidateDados()
        {


        }
    }
}
