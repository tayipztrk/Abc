using Abc.Nortwind.DataAccess.Abstract;
using Abc.Core.DataAccess.EntityFramework;
using Abc.Nortwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Nortwind.DataAccess.Concrete.EntityFramework
{
   public class EfCategoryDal:EfEntityRepositoryBase<Category,NorthwindContext>,ICategoryDal
    {

    }
}
