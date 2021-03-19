using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignupTemple.Models
{
    public class IProjectRepository
    {
        IQueryable<GroupInfo> Groups { get; }
    }
}
