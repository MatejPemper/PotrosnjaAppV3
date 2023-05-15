using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotrosnjaAppV3
{
    internal class potrosnja
    {

        int najam, rezije, transport, namirnice, usluge, ostalo;

        public potrosnja(int najam, int rezije, int transport, int namirnice, int usluge, int ostalo)
        {
            this.najam = najam;
            this.rezije = rezije;
            this.transport = transport;
            this.namirnice = namirnice;
            this.usluge = usluge;
            this.ostalo = ostalo;
        }

        public int Najam { get => najam; set => najam = value; }
        public int Rezije { get => rezije; set => rezije = value; }
        public int Transport { get => transport; set => transport = value; }
        public int Namirnice { get => namirnice; set => namirnice = value; }
        public int Usluge { get => usluge; set => usluge = value; }
        public int Ostalo { get => ostalo; set => ostalo = value; }
    }
}
