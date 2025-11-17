using System;
using System.Threading.Tasks;
using Models.Interfaces;
using Models.Klasser;
using Models.Undantag;
using System.Net.Http;
using System.Xml.Linq;

namespace DAL
{
    public class RssHämtare : IRssHämtare
    {
        public async Task<Podd> HämtaPoddFrånRssUrl(string rssUrl)
        {
            // Kollar att länken inte är tom att den ser ut som en riktig webbadress
            if (string.IsNullOrWhiteSpace(rssUrl) || !rssUrl.StartsWith("http" )) 
            {
                //Stannar programmet och säger att länken är ogiltig
                throw new InvalidRssUrl("Rss-adressen är ogiltig"); 
            }

            //Här kommer texten från RSS-filen hamna
            string xmlText;

            try
            {
                // skapar en httpklient-objekt som vi döper till "http" som kan hämta saker från internet
                using var http = new HttpClient(); //using i koden gör att metoden stängs av utan att behöva skriva close

                //Hämtar hela RSS-filen som text från webben (detta kan ta tid --> därför async)
                xmlText = await http.GetStringAsync(rssUrl); 
            }
            catch
            {
                //Om något går fel vid hämtningen slänger vi ett eget fel
                throw new RssHämtningMisslyckades("Kunde inte hämta RSS-flödet från internet.");
            }









            throw new NotImplementedException();
        }
    }
}
