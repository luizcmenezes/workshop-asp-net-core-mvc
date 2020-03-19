using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class SellerServices
    {
        private readonly SalesWebMvcContext _conetxt;

        public SellerServices(SalesWebMvcContext context)
        {
            _conetxt = context;
        }

        public List<Seller> FindAll()
        {
            return _conetxt.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _conetxt.Add(obj);
            _conetxt.SaveChanges();
        }
    }
}
