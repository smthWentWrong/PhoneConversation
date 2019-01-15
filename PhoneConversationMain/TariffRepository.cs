using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneConversation
{
    public class TariffRepository
    {
        public static List<Tariff> tariffs = new List<Tariff>()
        {
            new Tariff("Happy",3.5),new Tariff("Happy+",3),new Tariff("Rozmovy Bonus")
        };

        public Tariff GetTariff(string tar)
        {
            foreach (Tariff tmp in tariffs) {
                if (tmp.Name == tar)
                    return tmp;
            }
            return null;
        }
        public void Add(Tariff tariff)
        {
            tariffs.Add(tariff);
        }

        public List<Tariff> getAll()
        {
            return tariffs;
        }
    }
}
