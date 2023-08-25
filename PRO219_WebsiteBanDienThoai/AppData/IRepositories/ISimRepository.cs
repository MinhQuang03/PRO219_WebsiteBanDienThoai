using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppData.Models;
using Microsoft.AspNetCore.Identity;

namespace AppData.IRepositories
{
    public interface ISimRepository
    {
        Task<bool> Create(Sim obj);
    }
}
