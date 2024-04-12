using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.UI.Theming;
using Volo.Abp.UI.Navigation;

namespace EasyAbp.Abp.AspNetCore.Mvc.UI.Theme.LYear.Themes.LYear.Components.Toolbar.SkinSwitch
{
    public class SkinSwitchViewComponent : AbpViewComponent
    {
        private readonly IThemeManager _themeManager;

        public SkinSwitchViewComponent(IThemeManager themeManager)
        {
            _themeManager = themeManager;
        }

        public IViewComponentResult Invoke()
        {
            var theme = _themeManager.CurrentTheme;
            return View("~/Themes/LYear/Components/Toolbar/SkinSwitchViewComponent/Default.cshtml", theme);
        }
    }
}
