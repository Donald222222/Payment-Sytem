using Payment_Sytem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment_Sytem.Repository
{
    public interface Irepository
    {

        Payments AddPayments(Payments payments);

       
        List<Payments> ProofOfPaymment();
        List<string> GetMnagers();
        List<string> GetSignature();
    }
}
