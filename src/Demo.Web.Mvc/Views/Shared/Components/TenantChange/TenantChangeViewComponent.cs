﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abp.AutoMapper;
using Demo.Sessions;

namespace Demo.Web.Views.Shared.Components.TenantChange
{
    public class TenantChangeViewComponent : DemoViewComponent
    {
        private readonly ISessionAppService _sessionAppService;

        public TenantChangeViewComponent(ISessionAppService sessionAppService)
        {
            _sessionAppService = sessionAppService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var loginInfo = await _sessionAppService.GetCurrentLoginInformations();
            var model = loginInfo.MapTo<TenantChangeViewModel>();
            return View(model);
        }
    }
}
