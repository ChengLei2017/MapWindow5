﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MW5.Api.Helpers;
using MW5.Plugins;
using MW5.Plugins.Mvp;
using MW5.Plugins.Services;
using MW5.UI.Repository;
using MW5.UI.Repository.UI;
using MW5.UI.SyncfusionStyle;

namespace MW5.UI
{
    public static class CompositionRoot
    {
        public static void Compose(IApplicationContainer container)
        {
            container.RegisterService<IStyleService, SyncfusionStyleService>()
            .RegisterSingleton<ControlStyleSettings>()
            .RegisterSingleton<RepositoryDockPanel>()
            .RegisterSingleton<RepositoryPresenter>();

            EnumHelper.RegisterConverter(new RepositoryItemTypeConverter());
        }
    }
}
