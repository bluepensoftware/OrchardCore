#pragma checksum "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Navigation\Views\NavigationItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "100f9eba4fa49defac6f65f028ce0c98c40261c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NavigationItem), @"mvc.1.0.view", @"/Views/NavigationItem.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"100f9eba4fa49defac6f65f028ce0c98c40261c9", @"/Views/NavigationItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f7745b9955b4597ef082516786864c2ede637b8", @"/Views/_ViewImports.cshtml")]
    public class Views_NavigationItem : OrchardCore.DisplayManagement.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Navigation\Views\NavigationItem.cshtml"
  
    TagBuilder tag = Tag(Model, "li");

    // Morphing the shape to keep Model untouched
    Model.Metadata.Alternates.Clear();
    Model.Metadata.Type = "NavigationItemLink";

    tag.InnerHtml.AppendHtml(await DisplayAsync(Model));

    // Render sub-items (MenuItem)
    if (Model.HasItems)
    {
        tag.InnerHtml.AppendHtml("<ul>");
        foreach (var item in Model)
        {
            tag.InnerHtml.AppendHtml(await DisplayAsync(item));
        }
        tag.InnerHtml.AppendHtml("</ul>");
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 22 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Navigation\Views\NavigationItem.cshtml"
Write(tag);

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
