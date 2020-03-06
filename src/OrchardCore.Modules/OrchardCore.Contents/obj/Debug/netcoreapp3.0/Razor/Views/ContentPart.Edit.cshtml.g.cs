#pragma checksum "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Contents\Views\ContentPart.Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2952a0d0dc4ddc28e792421b4ea90222899bee5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ContentPart_Edit), @"mvc.1.0.view", @"/Views/ContentPart.Edit.cshtml")]
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
#line 1 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Contents\Views\ContentPart.Edit.cshtml"
using OrchardCore.ContentManagement.Metadata.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Contents\Views\ContentPart.Edit.cshtml"
using OrchardCore.ContentManagement.Metadata.Settings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Contents\Views\ContentPart.Edit.cshtml"
using OrchardCore.ContentManagement;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2952a0d0dc4ddc28e792421b4ea90222899bee5", @"/Views/ContentPart.Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"299e2d4f940da2d8e09ef62c09317195268ffa7b", @"/Views/_ViewImports.cshtml")]
    public class Views_ContentPart_Edit : OrchardCore.DisplayManagement.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Contents\Views\ContentPart.Edit.cshtml"
  
    ContentPart contentPart = Model.ContentPart;
    ContentTypePartDefinition typePartDefinition = Model.ContentTypePartDefinition;
    var description = typePartDefinition.Description();
    var namedPart = typePartDefinition.PartDefinition.IsReusable() && typePartDefinition.Name != typePartDefinition.PartDefinition.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 12 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Contents\Views\ContentPart.Edit.cshtml"
 if (namedPart)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h5>\r\n        ");
#nullable restore
#line 15 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Contents\Views\ContentPart.Edit.cshtml"
   Write(typePartDefinition.DisplayName());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 17 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Contents\Views\ContentPart.Edit.cshtml"
         if (!String.IsNullOrEmpty(description))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span class=\"hint\">— ");
#nullable restore
#line 19 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Contents\Views\ContentPart.Edit.cshtml"
                            Write(description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 20 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Contents\Views\ContentPart.Edit.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </h5>\r\n");
#nullable restore
#line 22 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Contents\Views\ContentPart.Edit.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Contents\Views\ContentPart.Edit.cshtml"
 foreach (var shape in Model)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Contents\Views\ContentPart.Edit.cshtml"
Write(await DisplayAsync(shape));

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Contents\Views\ContentPart.Edit.cshtml"
                              
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
