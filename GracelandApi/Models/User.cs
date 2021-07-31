using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GracelandApi.Models
{
    public record User(string Id, string FirstName, string LastName, string Email);
}
