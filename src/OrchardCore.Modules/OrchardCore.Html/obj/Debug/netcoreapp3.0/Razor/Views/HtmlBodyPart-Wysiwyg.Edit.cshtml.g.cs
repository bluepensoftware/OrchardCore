#pragma checksum "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Html\Views\HtmlBodyPart-Wysiwyg.Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f32f74e9b5c7f1f6124d436b9835a259ec84088a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HtmlBodyPart_Wysiwyg_Edit), @"mvc.1.0.view", @"/Views/HtmlBodyPart-Wysiwyg.Edit.cshtml")]
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
#line 7 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Html\Views\_ViewImports.cshtml"
using OrchardCore.DisplayManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Html\Views\HtmlBodyPart-Wysiwyg.Edit.cshtml"
using OrchardCore.Html.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Html\Views\HtmlBodyPart-Wysiwyg.Edit.cshtml"
using OrchardCore.Html.Settings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Html\Views\HtmlBodyPart-Wysiwyg.Edit.cshtml"
using OrchardCore.ContentLocalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Html\Views\HtmlBodyPart-Wysiwyg.Edit.cshtml"
using OrchardCore.ContentManagement.Metadata.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Html\Views\HtmlBodyPart-Wysiwyg.Edit.cshtml"
using OrchardCore.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f32f74e9b5c7f1f6124d436b9835a259ec84088a", @"/Views/HtmlBodyPart-Wysiwyg.Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61f649e09c06bfc36a937117f2bb667ed280f489", @"/Views/_ViewImports.cshtml")]
    public class Views_HtmlBodyPart_Wysiwyg_Edit : OrchardCore.DisplayManagement.Razor.RazorPage<HtmlBodyPartViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-name", "trumbowyg", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("depends-on", "admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-src", "~/OrchardCore.Resources/Scripts/trumbowyg.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("debug-src", "~/OrchardCore.Resources/Scripts/trumbowyg.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-src", "~/OrchardCore.Resources/Styles/trumbowyg.min.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("debug-src", "~/OrchardCore.Resources/Styles/trumbowyg.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rows", new global::Microsoft.AspNetCore.Html.HtmlString("5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::OrchardCore.ResourceManagement.TagHelpers.ScriptTagHelper __OrchardCore_ResourceManagement_TagHelpers_ScriptTagHelper;
        private global::OrchardCore.ResourceManagement.TagHelpers.StyleTagHelper __OrchardCore_ResourceManagement_TagHelpers_StyleTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Html\Views\HtmlBodyPart-Wysiwyg.Edit.cshtml"
  
    var settings = Model.TypePartDefinition.GetSettings<HtmlBodyPartSettings>();
    var culture = await Orchard.GetContentCultureAsync(Model.ContentItem);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f32f74e9b5c7f1f6124d436b9835a259ec84088a7634", async() => {
            }
            );
            __OrchardCore_ResourceManagement_TagHelpers_ScriptTagHelper = CreateTagHelper<global::OrchardCore.ResourceManagement.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__OrchardCore_ResourceManagement_TagHelpers_ScriptTagHelper);
            __OrchardCore_ResourceManagement_TagHelpers_ScriptTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __OrchardCore_ResourceManagement_TagHelpers_ScriptTagHelper.DependsOn = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __OrchardCore_ResourceManagement_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __OrchardCore_ResourceManagement_TagHelpers_ScriptTagHelper.DebugSrc = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 13 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Html\Views\HtmlBodyPart-Wysiwyg.Edit.cshtml"
__OrchardCore_ResourceManagement_TagHelpers_ScriptTagHelper.At = global::OrchardCore.ResourceManagement.ResourceLocation.Foot;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("at", __OrchardCore_ResourceManagement_TagHelpers_ScriptTagHelper.At, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("style", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f32f74e9b5c7f1f6124d436b9835a259ec84088a9940", async() => {
            }
            );
            __OrchardCore_ResourceManagement_TagHelpers_StyleTagHelper = CreateTagHelper<global::OrchardCore.ResourceManagement.TagHelpers.StyleTagHelper>();
            __tagHelperExecutionContext.Add(__OrchardCore_ResourceManagement_TagHelpers_StyleTagHelper);
            __OrchardCore_ResourceManagement_TagHelpers_StyleTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __OrchardCore_ResourceManagement_TagHelpers_StyleTagHelper.Src = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __OrchardCore_ResourceManagement_TagHelpers_StyleTagHelper.DebugSrc = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<fieldset class=\"form-group\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f32f74e9b5c7f1f6124d436b9835a259ec84088a11532", async() => {
#nullable restore
#line 17 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Html\Views\HtmlBodyPart-Wysiwyg.Edit.cshtml"
                       Write(Model.TypePartDefinition.DisplayName());

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 17 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Html\Views\HtmlBodyPart-Wysiwyg.Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Source);

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
            WriteLiteral("\r\n");
#nullable restore
#line 18 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Html\Views\HtmlBodyPart-Wysiwyg.Edit.cshtml"
     if (culture.IsRightToLeft())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div style=\"text-align:right\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f32f74e9b5c7f1f6124d436b9835a259ec84088a13586", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#nullable restore
#line 21 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Html\Views\HtmlBodyPart-Wysiwyg.Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Source);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 23 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Html\Views\HtmlBodyPart-Wysiwyg.Edit.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f32f74e9b5c7f1f6124d436b9835a259ec84088a15512", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#nullable restore
#line 26 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Html\Views\HtmlBodyPart-Wysiwyg.Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Source);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 27 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Html\Views\HtmlBodyPart-Wysiwyg.Edit.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span class=\"hint\">");
#nullable restore
#line 28 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Html\Views\HtmlBodyPart-Wysiwyg.Edit.cshtml"
                  Write(T["The body of the content item."]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n</fieldset>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f32f74e9b5c7f1f6124d436b9835a259ec84088a17736", async() => {
                WriteLiteral("\r\n    $(function () {\r\n        $(\'#");
#nullable restore
#line 33 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Html\Views\HtmlBodyPart-Wysiwyg.Edit.cshtml"
       Write(Html.IdFor(m => m.Source));

#line default
#line hidden
#nullable disable
                WriteLiteral("\').trumbowyg().on(\'tbwchange\', function () {\r\n            $(document).trigger(\'contentpreview:render\');\r\n        });\r\n    });\r\n");
            }
            );
            __OrchardCore_ResourceManagement_TagHelpers_ScriptTagHelper = CreateTagHelper<global::OrchardCore.ResourceManagement.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__OrchardCore_ResourceManagement_TagHelpers_ScriptTagHelper);
#nullable restore
#line 31 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Html\Views\HtmlBodyPart-Wysiwyg.Edit.cshtml"
__OrchardCore_ResourceManagement_TagHelpers_ScriptTagHelper.At = global::OrchardCore.ResourceManagement.ResourceLocation.Foot;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("at", __OrchardCore_ResourceManagement_TagHelpers_ScriptTagHelper.At, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HtmlBodyPartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
