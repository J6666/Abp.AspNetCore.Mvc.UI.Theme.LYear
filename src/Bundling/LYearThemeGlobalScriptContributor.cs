using System.Collections.Generic;
using System.Linq;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace EasyAbp.Abp.AspNetCore.Mvc.UI.Theme.LYear.Bundling
{
    public class LYearThemeGlobalScriptContributor : BundleContributor
    {
        public override void ConfigureBundle(BundleConfigurationContext context)
        {
            context.Files.Add("/themes/lyear/assets/js/bootstrap.min.js");
            context.Files.Add("/themes/lyear/assets/js/lightyear.js");
        }
    }
}
