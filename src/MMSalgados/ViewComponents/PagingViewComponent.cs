using Microsoft.AspNetCore.Mvc;
using MMSalgados.WebUI.ViewModels.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MMSalgados.WebUI.ViewComponents
{
    [ViewComponent(Name = "paging")]
    public class PagingViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(IPagedList pagingModel)
        {
            return View(pagingModel);
        }
    }
}
