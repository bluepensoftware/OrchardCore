#pragma checksum "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Contents\Views\Items\ContentUpdatedEvent.Fields.Design.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2b49520eb52b65597434f7d71ee82240666d2c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_ContentUpdatedEvent_Fields_Design), @"mvc.1.0.view", @"/Views/Items/ContentUpdatedEvent.Fields.Design.cshtml")]
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
#line 5 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Contents\Views\_ViewImports.cshtml"
using OrchardCore.ContentManagement.Display.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Contents\Views\_ViewImports.cshtml"
using OrchardCore.ContentManagement.Metadata.Settings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Contents\Views\_ViewImports.cshtml"
using OrchardCore.Contents.Workflows.Activities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Contents\Views\_ViewImports.cshtml"
using OrchardCore.Contents.Workflows.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Contents\Views\_ViewImports.cshtml"
using OrchardCore.DisplayManagement.Views;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Contents\Views\_ViewImports.cshtml"
using OrchardCore.Deployment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Contents\Views\_ViewImports.cshtml"
using OrchardCore.Contents.Deployment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Contents\Views\_ViewImports.cshtml"
using OrchardCore.Contents.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Contents\Views\_ViewImports.cshtml"
using OrchardCore.Contents.AdminNodes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Contents\Views\_ViewImports.cshtml"
using OrchardCore.Workflows.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2b49520eb52b65597434f7d71ee82240666d2c6", @"/Views/Items/ContentUpdatedEvent.Fields.Design.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"299e2d4f940da2d8e09ef62c09317195268ffa7b", @"/Views/_ViewImports.cshtml")]
    public class Views_Items_ContentUpdatedEvent_Fields_Design : OrchardCore.DisplayManagement.Razor.RazorPage<ContentEventViewModel<ContentUpdatedEvent>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<header>\r\n    <h4><i class=\"fa fa-bolt\"></i>");
#nullable restore
#line 4 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Contents\Views\Items\ContentUpdatedEvent.Fields.Design.cshtml"
                             Write(Model.Activity.GetTitleOrDefault(() => T["Content Updated"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n</header>\r\n<em>");
#nullable restore
#line 6 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Contents\Views\Items\ContentUpdatedEvent.Fields.Design.cshtml"
Write(Model.ContentTypeFilter.Any() ? (object)string.Join(", ", Model.ContentTypeFilter.Select(x => x.DisplayName)) : T["Any content type"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</em>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContentEventViewModel<ContentUpdatedEvent>> Html { get; private set; }
    }
}
#pragma warning restore 1591
