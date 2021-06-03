using AspNetCore.Study.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Study.Services
{
    public interface IMonumentService
    {
        IEnumerable<Monument> Get();
        Monument Get(int id);
        void Create(Monument monument);
        void Update(Monument monument);
        void Delete(int id);
    }
}
