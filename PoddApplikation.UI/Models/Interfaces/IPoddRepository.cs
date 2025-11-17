using Models.Klasser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Interfaces
{
    public interface IPoddRepository
    {
        Task<List<Podd>> HämtaAllaPoddar();
        Task<Podd> HämtaPoddMedId(string id);

        Task SparaPodd(Podd podd);
        Task UppdateraPodd(Podd podd);
        Task TabortPodd(string id); 

    }
}
