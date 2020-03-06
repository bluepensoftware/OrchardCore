#pragma checksum "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Settings\Views\Shared\DisplayTemplates\RemovableCulture.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "073a2a56c41b1924a1990e657fa5d9a91fb54970"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_DisplayTemplates_RemovableCulture), @"mvc.1.0.view", @"/Views/Shared/DisplayTemplates/RemovableCulture.cshtml")]
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
#nullable restore
#line 1 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Settings\Views\Shared\DisplayTemplates\RemovableCulture.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"073a2a56c41b1924a1990e657fa5d9a91fb54970", @"/Views/Shared/DisplayTemplates/RemovableCulture.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0146ac83b76a8faba162dc3d4a63005510b6641", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_DisplayTemplates_RemovableCulture : OrchardCore.DisplayManagement.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("delete-culture"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteCulture", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Settings\Views\Shared\DisplayTemplates\RemovableCulture.cshtml"
  
    var culture = Model != null ? CultureInfo.GetCultureInfo(Model) : CultureInfo.InvariantCulture;

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "073a2a56c41b1924a1990e657fa5d9a91fb549705334", async() => {
                WriteLiteral("\r\n        <td class=\"align-middle\">");
#nullable restore
#line 7 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Settings\Views\Shared\DisplayTemplates\RemovableCulture.cshtml"
                            Write(culture.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        <td class=\"align-middle\">\r\n");
#nullable restore
#line 9 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Settings\Views\Shared\DisplayTemplates\RemovableCulture.cshtml"
             if (!String.IsNullOrEmpty(culture.DisplayName))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Settings\Views\Shared\DisplayTemplates\RemovableCulture.cshtml"
                 Write(culture.DisplayName);

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Settings\Views\Shared\DisplayTemplates\RemovableCulture.cshtml"
                                                 
            }
            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Settings\Views\Shared\DisplayTemplates\RemovableCulture.cshtml"
                 Write(culture.NativeName);

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Settings\Views\Shared\DisplayTemplates\RemovableCulture.cshtml"
                                                
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </td>\r\n        <td class=\"align-middle\">");
#nullable restore
#line 18 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Settings\Views\Shared\DisplayTemplates\RemovableCulture.cshtml"
                            Write(Model);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        <td class=\"align-middle text-center\">\r\n            ");
#nullable restore
#line 20 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Settings\Views\Shared\DisplayTemplates\RemovableCulture.cshtml"
       Write(Html.Hidden("cultureName", (string)Model, new { id = "" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <button type=\"submit\" class=\"btn btn-link\"");
                BeginWriteAttribute("title", " title=\"", 870, "\"", 890, 1);
#nullable restore
#line 21 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Settings\Views\Shared\DisplayTemplates\RemovableCulture.cshtml"
WriteAttributeValue("", 878, T["Delete"], 878, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <i class=\"fas fa-times\"></i>\r\n            </button>\r\n        </td>\r\n\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnUrl", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 6 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Settings\Views\Shared\DisplayTemplates\RemovableCulture.cshtml"
                                                                    WriteLiteral(Context.Request.Query["ReturnUrl"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</tr>");
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
