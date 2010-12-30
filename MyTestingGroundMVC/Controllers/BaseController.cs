using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyTestingGroundMVC.ViewData;

namespace MyTestingGroundMVC.Controllers
{
    public class BaseController : Controller
    {
       

        // here an example of Constraints on Type Parameters (C# Programming Guide)
        // using 'new()' means that the type 'BaseViewData' must have a public
        // parameterless constructor
        public T CreateViewData<T>() where T : BaseViewData, new()
        {
            T viewData = new T() { };

            return viewData;
        }

    }
}
