using Abc.Nortwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Nortwind.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
