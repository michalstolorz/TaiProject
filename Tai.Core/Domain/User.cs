using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tai.Core.Domain
{
    public class User : Entity
    {
        public string? Name { get; protected set; }
        public string? Password { get; protected set; }
        public DateTime? CreatedAt { get; protected set; }
        public List<Guid>? DocumentsId { get; protected set; }

        public User() { }
        public User(Guid id, string name, string password)
        {
            Id= id;
            SetName(name);
            SetPassword(password);
            CreatedAt= DateTime.Now;
        }

        public void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new Exception($"User with id={Id}: can not have an empty Name");
            }
            Name=name;

        }
        public void SetPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new Exception($"User with id={Id}: can not have an empty Password");
            }
            Password=password;
        }

    }
}
