using Models.Klasser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Interfaces
{
    public interface IKategoriRepository
    {
        Task<List<Kategori>> HämtaAllaKategorier();
        Task SkapaKategori(Kategori kategori);

        Task UppdateraKategori(Kategori kategori);
        Task TaBortKategori(string id);
    }
}
