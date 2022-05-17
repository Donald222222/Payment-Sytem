using Payment_Sytem.DataAcess;
using Payment_Sytem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment_Sytem.Repository
{
    public class CreatePayment : Irepository
    {
        private readonly DataContext _data;

        public CreatePayment(DataContext data)
        {
            _data = data;
        }

        public Payments AddPayments(Payments payments)
        {
            _data.Payments.Add(payments);
            _data.SaveChanges();
            return payments;

        }

        public List< string> GetMnagers()
        {

        
            return _data.Managers.Select(item => item.ManagerName
            ).ToList();

        

        }

        public List<string> GetSignature()
        {
            return _data.Managers.Select(item => item.ManagerSignature
            ).ToList();
        }

        public List<Payments> ProofOfPaymment()
        {
            return _data.Payments.ToList();
        }

   


    }


}
