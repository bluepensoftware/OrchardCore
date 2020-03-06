#pragma checksum "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Media\Views\Shared\MediaStoreEntries.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e16292d8c181e0bc1a607971ddd6b9ad5322db81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_MediaStoreEntries), @"mvc.1.0.view", @"/Views/Shared/MediaStoreEntries.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e16292d8c181e0bc1a607971ddd6b9ad5322db81", @"/Views/Shared/MediaStoreEntries.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83fe21f529bda44d509614a960ad5525e2358e40", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_MediaStoreEntries : OrchardCore.DisplayManagement.Razor.RazorPage<MediaDeploymentStepViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "MediaStoreEntries.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<ul class=\"list-group\">\r\n\r\n");
#nullable restore
#line 5 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Media\Views\Shared\MediaStoreEntries.cshtml"
     foreach (var entry in Model.Entries)
    {
        var checkd = (Model.DirectoryPaths?.Contains(entry.Path) ?? false) || (Model.FilePaths?.Contains(entry.Path) ?? false);
        var hasChildren = entry.Entries?.Count != 0;


#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"list-group-item\">\r\n            <div class=\"form-check\">\r\n                <label class=\"form-check-label\">\r\n");
#nullable restore
#line 13 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Media\Views\Shared\MediaStoreEntries.cshtml"
                     if (hasChildren)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input class=\"form-check-input\" data-parent-value=\"");
#nullable restore
#line 15 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Media\Views\Shared\MediaStoreEntries.cshtml"
                                                                       Write(entry.Parent?.Path ?? String.Empty);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" type=\"checkbox\"");
            BeginWriteAttribute("name", " name=\"", 618, "\"", 661, 1);
#nullable restore
#line 15 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Media\Views\Shared\MediaStoreEntries.cshtml"
WriteAttributeValue("", 625, Html.NameFor(m => m.DirectoryPaths), 625, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 662, "\"", 681, 1);
#nullable restore
#line 15 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Media\Views\Shared\MediaStoreEntries.cshtml"
WriteAttributeValue("", 670, entry.Path, 670, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("checked", " checked=\"", 682, "\"", 699, 1);
#nullable restore
#line 15 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Media\Views\Shared\MediaStoreEntries.cshtml"
WriteAttributeValue("", 692, checkd, 692, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 16 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Media\Views\Shared\MediaStoreEntries.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input class=\"form-check-input\" data-parent-value=\"");
#nullable restore
#line 19 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Media\Views\Shared\MediaStoreEntries.cshtml"
                                                                       Write(entry.Parent?.Path ?? String.Empty);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" type=\"checkbox\"");
            BeginWriteAttribute("name", " name=\"", 906, "\"", 944, 1);
#nullable restore
#line 19 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Media\Views\Shared\MediaStoreEntries.cshtml"
WriteAttributeValue("", 913, Html.NameFor(m => m.FilePaths), 913, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 945, "\"", 964, 1);
#nullable restore
#line 19 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Media\Views\Shared\MediaStoreEntries.cshtml"
WriteAttributeValue("", 953, entry.Path, 953, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("checked", " checked=\"", 965, "\"", 982, 1);
#nullable restore
#line 19 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Media\Views\Shared\MediaStoreEntries.cshtml"
WriteAttributeValue("", 975, checkd, 975, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 20 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Media\Views\Shared\MediaStoreEntries.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
#nullable restore
#line 21 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Media\Views\Shared\MediaStoreEntries.cshtml"
               Write(entry.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </label>\r\n            </div>\r\n        </li>\r\n");
#nullable restore
#line 25 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Media\Views\Shared\MediaStoreEntries.cshtml"

        if (hasChildren)
        {
            var partialModel = new MediaDeploymentStepViewModel
            {
                IncludeAll = Model.IncludeAll,
                DirectoryPaths = Model.DirectoryPaths,
                FilePaths = Model.FilePaths,
                Entries = entry.Entries
            };


#line default
#line hidden
#nullable disable
            WriteLiteral("            <li data-path=\"");
#nullable restore
#line 36 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Media\Views\Shared\MediaStoreEntries.cshtml"
                      Write(entry.Path);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("class", " class=\"", 1472, "\"", 1574, 2);
            WriteAttributeValue("", 1480, "list-group-item", 1480, 15, true);
#nullable restore
#line 36 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Media\Views\Shared\MediaStoreEntries.cshtml"
WriteAttributeValue(" ", 1495, (Model.DirectoryPaths?.Contains(entry.Path) ?? false) ? "collapse" : "show", 1496, 78, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e16292d8c181e0bc1a607971ddd6b9ad5322db8110153", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 37 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Media\Views\Shared\MediaStoreEntries.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = partialModel;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </li>\r\n");
#nullable restore
#line 39 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Media\Views\Shared\MediaStoreEntries.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MediaDeploymentStepViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
