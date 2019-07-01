using Panacea.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modularity.AppBar
{
    public static class PanaceaServicesExtensions
    {
        public static bool TryGetAppBar(this PanaceaServices core, out IAppBar appbar)
        {
            appbar = core.PluginLoader.GetPlugins<IAppBarPlugin>().FirstOrDefault()?.GetAppBar();
            return appbar != null;
        }
    }
}
