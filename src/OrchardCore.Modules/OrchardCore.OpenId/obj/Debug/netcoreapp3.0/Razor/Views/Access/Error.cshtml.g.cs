#pragma checksum "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.OpenId\Views\Access\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7bdb1e3fc2b6b603c6fcd365b8018f25c8dc10d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Access_Error), @"mvc.1.0.view", @"/Views/Access/Error.cshtml")]
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
#line 2 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.OpenId\Views\Access\Error.cshtml"
using OrchardCore.OpenId.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bdb1e3fc2b6b603c6fcd365b8018f25c8dc10d8", @"/Views/Access/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d72a8ba0531fd4434c909ab5f26ec5bca4a17065", @"/Views/_ViewImports.cshtml")]
    public class Views_Access_Error : OrchardCore.DisplayManagement.Razor.RazorPage<ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"jumbotron\">\r\n    <h2>");
#nullable restore
#line 5 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.OpenId\Views\Access\Error.cshtml"
   Write(T["Ooooops, something went really bad! :("]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <p class=\"lead text-left\">\r\n");
#nullable restore
#line 7 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.OpenId\Views\Access\Error.cshtml"
         if (!string.IsNullOrEmpty(Model.Error))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <strong>");
#nullable restore
#line 9 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.OpenId\Views\Access\Error.cshtml"
               Write(Model.Error);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n");
#nullable restore
#line 10 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.OpenId\Views\Access\Error.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 12 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.OpenId\Views\Access\Error.cshtml"
         if (!string.IsNullOrEmpty(Model.ErrorDescription))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <small>");
#nullable restore
#line 14 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.OpenId\Views\Access\Error.cshtml"
              Write(Model.ErrorDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n");
#nullable restore
#line 15 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.OpenId\Views\Access\Error.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
