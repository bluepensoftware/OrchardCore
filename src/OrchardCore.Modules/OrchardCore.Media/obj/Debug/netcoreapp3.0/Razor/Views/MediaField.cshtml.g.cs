#pragma checksum "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Media\Views\MediaField.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbb93d7d3f3c1d33fdb2c86a12500e11157494bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MediaField), @"mvc.1.0.view", @"/Views/MediaField.cshtml")]
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
#line 11 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Media\Views\_ViewImports.cshtml"
using OrchardCore.DisplayManagement.Views;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Media\Views\_ViewImports.cshtml"
using OrchardCore.Media.Deployment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Media\Views\_ViewImports.cshtml"
using OrchardCore.Media.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Media\Views\MediaField.cshtml"
using OrchardCore.ContentManagement.Metadata.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbb93d7d3f3c1d33fdb2c86a12500e11157494bf", @"/Views/MediaField.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83fe21f529bda44d509614a960ad5525e2358e40", @"/Views/_ViewImports.cshtml")]
    public class Views_MediaField : OrchardCore.DisplayManagement.Razor.RazorPage<OrchardCore.Media.ViewModels.DisplayMediaFieldViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n    ");
#nullable restore
#line 5 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Media\Views\MediaField.cshtml"
Write(Model.PartFieldDefinition.DisplayName());

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 5 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Media\Views\MediaField.cshtml"
                                         Write(String.Join(", ", Model.Paths ?? Array.Empty<string>()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrchardCore.Media.ViewModels.DisplayMediaFieldViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
