using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using child = Child.Domain.Entities;
namespace Child.Infrasructure.Adapters.PersonService
{
    public class KpsServiceManager : IKpsService
    {
        public async Task<bool> Verify(child.Child child)
        {
            return await VerifyId(child);
        }

        private async Task<bool> VerifyId(child.Child child)
        {
            var kps = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var kpsVerification = await kps.TCKimlikNoDogrulaAsync(Convert.ToInt64(child.NationalId), child.FirstName.ToUpper(),child.LastName.ToUpper(),child.DateOfBirth.Year);
            return kpsVerification.Body.TCKimlikNoDogrulaResult;
          
        }
    }
}
