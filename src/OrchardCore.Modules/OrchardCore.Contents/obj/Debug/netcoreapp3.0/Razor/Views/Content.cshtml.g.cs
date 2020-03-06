#pragma checksum "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Contents\Views\Content.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bf5f8c66c26753d92950a7ebd71982477ab2b73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Content), @"mvc.1.0.view", @"/Views/Content.cshtml")]
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
#nullable restore
#line 1 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Contents\Views\Content.cshtml"
using OrchardCore.Mvc.Utilities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bf5f8c66c26753d92950a7ebd71982477ab2b73", @"/Views/Content.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"299e2d4f940da2d8e09ef62c09317195268ffa7b", @"/Views/_ViewImports.cshtml")]
    public class Views_Content : OrchardCore.DisplayManagement.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Contents\Views\Content.cshtml"
  

    Model.Classes.Add("content-item");

    var contentTypeClassName = ((string)Model.ContentItem.ContentType).HtmlClassify();
    Model.Classes.Add(contentTypeClassName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<article");
            BeginWriteAttribute("class", " class=\"", 232, "\"", 282, 1);
#nullable restore
#line 11 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Contents\Views\Content.cshtml"
WriteAttributeValue("", 240, String.Join(" ", Model.Classes.ToArray()), 240, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 12 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Contents\Views\Content.cshtml"
     if (Model.Header != null || Model.Meta != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <header>\r\n        ");
#nullable restore
#line 15 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Contents\Views\Content.cshtml"
   Write(await DisplayAsync(Model.Header));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 16 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Contents\Views\Content.cshtml"
         if (Model.Meta != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"metadata\">\r\n                ");
#nullable restore
#line 19 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Contents\Views\Content.cshtml"
           Write(await DisplayAsync(Model.Meta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 21 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Contents\Views\Content.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </header>\r\n");
#nullable restore
#line 23 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Contents\Views\Content.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
#nullable restore
#line 24 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Contents\Views\Content.cshtml"
Write(await DisplayAsync(Model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 25 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Contents\Views\Content.cshtml"
     if (Model.Footer != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <footer>\r\n        ");
#nullable restore
#line 28 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Contents\Views\Content.cshtml"
   Write(await DisplayAsync(Model.Footer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </footer>\r\n");
#nullable restore
#line 30 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Contents\Views\Content.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</article>");
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
