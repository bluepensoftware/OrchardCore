#pragma checksum "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Contents\Views\Items\ContentVersionedEvent.Fields.Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71d4b10aac966253e5b9191e1a117036cc0d8cf4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_ContentVersionedEvent_Fields_Edit), @"mvc.1.0.view", @"/Views/Items/ContentVersionedEvent.Fields.Edit.cshtml")]
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
#line 1 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Contents\Views\Items\ContentVersionedEvent.Fields.Edit.cshtml"
using OrchardCore.Contents.Workflows.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71d4b10aac966253e5b9191e1a117036cc0d8cf4", @"/Views/Items/ContentVersionedEvent.Fields.Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"299e2d4f940da2d8e09ef62c09317195268ffa7b", @"/Views/_ViewImports.cshtml")]
    public class Views_Items_ContentVersionedEvent_Fields_Edit : OrchardCore.DisplayManagement.Razor.RazorPage<ContentVersionedEventViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::OrchardCore.DisplayManagement.TagHelpers.ValidationMessageTagHelper __OrchardCore_DisplayManagement_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("fieldset", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71d4b10aac966253e5b9191e1a117036cc0d8cf45858", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71d4b10aac966253e5b9191e1a117036cc0d8cf46124", async() => {
#nullable restore
#line 5 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Contents\Views\Items\ContentVersionedEvent.Fields.Edit.cshtml"
                                         Write(T["Content Types"]);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 5 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Contents\Views\Items\ContentVersionedEvent.Fields.Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SelectedContentTypeNames);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
#nullable restore
#line 6 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Contents\Views\Items\ContentVersionedEvent.Fields.Edit.cshtml"
Write(await Component.InvokeAsync("SelectContentTypes", new { selectedContentTypes = Model.SelectedContentTypeNames, htmlName = Html.NameFor(m => m.SelectedContentTypeNames) }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71d4b10aac966253e5b9191e1a117036cc0d8cf48398", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 7 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Contents\Views\Items\ContentVersionedEvent.Fields.Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SelectedContentTypeNames);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <span class=\"hint\">");
#nullable restore
#line 8 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Contents\Views\Items\ContentVersionedEvent.Fields.Edit.cshtml"
                  Write(T["Select any content types to filter on."]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n");
            }
            );
            __OrchardCore_DisplayManagement_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::OrchardCore.DisplayManagement.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__OrchardCore_DisplayManagement_TagHelpers_ValidationMessageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 4 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Contents\Views\Items\ContentVersionedEvent.Fields.Edit.cshtml"
__OrchardCore_DisplayManagement_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SelectedContentTypeNames);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-class-for", __OrchardCore_DisplayManagement_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContentVersionedEventViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
