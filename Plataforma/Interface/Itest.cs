using Microsoft.AspNetCore.Mvc;
using Plataforma.Models;
using Plataforma.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plataforma.Interface
{

   public interface Itest
    {
        public Task<EmpresasIndexViewModel> GetCustomersAsync(int anos);
    }
}
