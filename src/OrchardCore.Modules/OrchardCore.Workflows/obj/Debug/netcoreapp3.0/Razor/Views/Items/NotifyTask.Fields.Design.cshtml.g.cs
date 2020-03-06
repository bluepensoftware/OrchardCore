#pragma checksum "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Workflows\Views\Items\NotifyTask.Fields.Design.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b150e085259d63ab5fe0018b2dc54388690e355"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_NotifyTask_Fields_Design), @"mvc.1.0.view", @"/Views/Items/NotifyTask.Fields.Design.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Workflows\Views\_ViewImports.cshtml"
using OrchardCore.Workflows.Deployment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Workflows\Views\_ViewImports.cshtml"
using OrchardCore.Workflows.Activities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Workflows\Views\_ViewImports.cshtml"
using OrchardCore.Workflows.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Workflows\Views\_ViewImports.cshtml"
using OrchardCore.Workflows.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Workflows\Views\_ViewImports.cshtml"
using OrchardCore.DisplayManagement.Views;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Workflows\Views\_ViewImports.cshtml"
using OrchardCore.Mvc.Utilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Workflows\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Workflows\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Workflows\Views\Items\NotifyTask.Fields.Design.cshtml"
using OrchardCore.DisplayManagement.Notify;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b150e085259d63ab5fe0018b2dc54388690e355", @"/Views/Items/NotifyTask.Fields.Design.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ae673631375598e89b007c6526480c06d3c9641", @"/Views/_ViewImports.cshtml")]
    public class Views_Items_NotifyTask_Fields_Design : OrchardCore.DisplayManagement.Razor.RazorPage<ActivityViewModel<NotifyTask>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Workflows\Views\Items\NotifyTask.Fields.Design.cshtml"
  
    string className = "info-circle";

    switch (Model.Activity.NotificationType)
    {
        case NotifyType.Error:
            className = "exclamation-circle";
            break;
        case NotifyType.Success:
            className = "check-circle";
            break;
        case NotifyType.Warning:
            className = "warning";
            break;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<header>\r\n    <h4><i");
            BeginWriteAttribute("class", " class=\"", 495, "\"", 519, 3);
            WriteAttributeValue("", 503, "fa", 503, 2, true);
            WriteAttributeValue(" ", 505, "fa-", 506, 4, true);
#nullable restore
#line 20 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Workflows\Views\Items\NotifyTask.Fields.Design.cshtml"
WriteAttributeValue("", 509, className, 509, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>");
#nullable restore
#line 20 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Workflows\Views\Items\NotifyTask.Fields.Design.cshtml"
                                   Write(Model.Activity.GetTitleOrDefault(() => T["{0} Notification", Model.Activity.NotificationType]));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n</header>\r\n<em>&quot;");
#nullable restore
#line 22 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Workflows\Views\Items\NotifyTask.Fields.Design.cshtml"
     Write(Model.Activity.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("&quot;</em>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ActivityViewModel<NotifyTask>> Html { get; private set; }
    }
}
#pragma warning restore 1591
