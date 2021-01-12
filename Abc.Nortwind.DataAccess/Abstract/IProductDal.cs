using Abc.Core.DataAccess;
using Abc.Nortwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Nortwind.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
            
    }
}
