#pragma checksum "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Email\Views\SmtpSettings.TestButton.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53e9ca741c3a6a5009c2b66061e16af23a3a7a57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SmtpSettings_TestButton), @"mvc.1.0.view", @"/Views/SmtpSettings.TestButton.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53e9ca741c3a6a5009c2b66061e16af23a3a7a57", @"/Views/SmtpSettings.TestButton.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0da9d301c9cad0c597a5a15a03d09c98fea5c1b", @"/Views/_ViewImports.cshtml")]
    public class Views_SmtpSettings_TestButton : OrchardCore.DisplayManagement.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<a");
            BeginWriteAttribute("href", " href=\"", 2, "\"", 74, 1);
#nullable restore
#line 1 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Email\Views\SmtpSettings.TestButton.cshtml"
WriteAttributeValue("", 9, Url.Action("Index", "Admin", new { area = "OrchardCore.Email" }), 9, 65, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-secondary\">");
#nullable restore
#line 1 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Email\Views\SmtpSettings.TestButton.cshtml"
                                                                                                 Write(T["Test settings"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
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
