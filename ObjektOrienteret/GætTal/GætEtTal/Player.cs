using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GætEtTal
{
    class Player
    {
        string name;

        // En property til at tage imod et navn hvis der i forvejen ikke er et. Hvis der er et navn kan det kun "Gettes"
        public string Name
        {
            get
            {
                return name;
            }
            
            set
            {
                if (string.IsNullOrEmpty(name))
                {
                    name = value;
                }
            }
        }
    }
}
