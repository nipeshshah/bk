using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JSONFw.Models;

namespace JSONFw
{
    public class MockData
    {
        internal List<Temple> GetSearchedTemples()
        {
            List<Temple> temples = new List<Temple>();
            temples.Add(new Temple()
            {
                id = 1,
                City = GetMockCity(),
                ContactDetails = "Hello Saheb",
                ContactNumber = "8976843988",
                Title = "ABC KMONS TTTH",
                MoolnayakId = GetIdolMaster(),
                MoolnayakImage = new List<string>() { "https://bountifield.org/wp-content/uploads/2018/04/placeholder-man.png" },
                TempleImage = new List<string>() { "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRz2zqoUlJkI5FR6aBPHWgyj4DUQkOoFLpsLA&usqp=CAU" },
                Trust = GetTrust()
            });

            return temples;
        }

        private TrustMaster GetTrust()
        {
            return new TrustMaster()
            {
                id = 1,
                title = "Some TRST"
            };
        }

        private IdolMaster GetIdolMaster()
        {
            return new IdolMaster()
            {
                id = 1,
                title = "Shree shree shree",
                type = TirthType.Tirthankar
            };
        }

        private CityMaster GetMockCity()
        {
            return new CityMaster()
            {
                id = 1,
                country = "India",
                latitude = "24.52",
                longitude = "65.35",
                name = "Ahmedabad",
                state = "Gujarat"
            };
        }
    }
}
