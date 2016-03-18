﻿/*
 * Copyright 2016 Mikhail Shiryaev
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *     http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 * 
 * 
 * Product  : Rapid SCADA
 * Module   : PlgSchemeCommon
 * Summary  : Scheme layout web form
 * 
 * Author   : Mikhail Shiryaev
 * Created  : 2016
 * Modified : 2016
 */

#define DEBUG_MODE

using Scada.Scheme;
using System;

namespace Scada.Web.Plugins.Scheme
{
    /// <summary>
    /// Scheme layout web form
    /// <para>Веб-форма компоновки схемы</para>
    /// </summary>
    public partial class WFrmScheme : System.Web.UI.Page
    {
        protected int viewID;

        protected void Page_Load(object sender, EventArgs e)
        {
#if DEBUG_MODE
            AppData.Init(Server.MapPath("~"));
#endif

            viewID = 3; // ServerRoom.sch

            // загрузка представления в кеш, чтобы проверить, что оно доступно, 
            // и обеспечить возможность получения данных входных каналов через API 
            SchemeView schemeView = AppData.ViewCache.GetView<SchemeView>(viewID, true);
        }
    }
}