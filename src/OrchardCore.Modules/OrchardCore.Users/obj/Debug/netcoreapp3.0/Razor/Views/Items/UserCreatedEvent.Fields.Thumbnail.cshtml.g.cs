#pragma checksum "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Users\Views\Items\UserCreatedEvent.Fields.Thumbnail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64c8a42cd91f5057a1b3a68ce8ce56cfa021ad72"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_UserCreatedEvent_Fields_Thumbnail), @"mvc.1.0.view", @"/Views/Items/UserCreatedEvent.Fields.Thumbnail.cshtml")]
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
#line 10 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Users\Views\_ViewImports.cshtml"
using OrchardCore.Users.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Users\Views\_ViewImports.cshtml"
using OrchardCore.Users.TimeZone;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Users\Views\_ViewImports.cshtml"
using OrchardCore.Users.TimeZone.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Users\Views\_ViewImports.cshtml"
using OrchardCore.Workflows.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64c8a42cd91f5057a1b3a68ce8ce56cfa021ad72", @"/Views/Items/UserCreatedEvent.Fields.Thumbnail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9ffc43f154042ee39543640b4ae93af46ef5f39", @"/Views/_ViewImports.cshtml")]
    public class Views_Items_UserCreatedEvent_Fields_Thumbnail : OrchardCore.DisplayManagement.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h4 class=\"card-title\"><i class=\"fa fa-user\"></i>");
#nullable restore
#line 1 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Users\Views\Items\UserCreatedEvent.Fields.Thumbnail.cshtml"
                                            Write(T["User Created"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<p>");
#nullable restore
#line 2 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Users\Views\Items\UserCreatedEvent.Fields.Thumbnail.cshtml"
Write(T["User is created."]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
