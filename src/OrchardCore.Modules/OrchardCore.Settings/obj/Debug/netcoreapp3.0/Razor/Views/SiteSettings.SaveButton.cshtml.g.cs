#pragma checksum "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Settings\Views\SiteSettings.SaveButton.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c21a36066edfccd6541a42abe526cdcf807b536"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SiteSettings_SaveButton), @"mvc.1.0.view", @"/Views/SiteSettings.SaveButton.cshtml")]
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
#line 10 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Settings\Views\_ViewImports.cshtml"
using OrchardCore.Settings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Settings\Views\_ViewImports.cshtml"
using OrchardCore.Settings.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c21a36066edfccd6541a42abe526cdcf807b536", @"/Views/SiteSettings.SaveButton.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0146ac83b76a8faba162dc3d4a63005510b6641", @"/Views/_ViewImports.cshtml")]
    public class Views_SiteSettings_SaveButton : OrchardCore.DisplayManagement.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<button class=\"primaryAction btn btn-primary\" type=\"submit\">");
#nullable restore
#line 1 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Settings\Views\SiteSettings.SaveButton.cshtml"
                                                       Write(T["Save"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n\r\n");
#nullable restore
#line 3 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Settings\Views\SiteSettings.SaveButton.cshtml"
  
    var returnUrl = Context.Request.Query["returnUrl"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Settings\Views\SiteSettings.SaveButton.cshtml"
 if (!String.IsNullOrWhiteSpace(returnUrl) && Url.IsLocalUrl(returnUrl)) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a id=\"button-cancel\"");
            BeginWriteAttribute("href", " href=\"", 250, "\"", 267, 1);
#nullable restore
#line 8 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Settings\Views\SiteSettings.SaveButton.cshtml"
WriteAttributeValue("", 257, returnUrl, 257, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-secondary\">");
#nullable restore
#line 8 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Settings\Views\SiteSettings.SaveButton.cshtml"
                                                                 Write(T["Cancel"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 9 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Settings\Views\SiteSettings.SaveButton.cshtml"
}

#line default
#line hidden
#nullable disable
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
