#pragma checksum "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Menu\Views\Admin\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa45d51df00c843a8d187b65717d348454daf362"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Create), @"mvc.1.0.view", @"/Views/Admin/Create.cshtml")]
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
#line 11 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Menu\Views\_ViewImports.cshtml"
using OrchardCore.Menu.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Menu\Views\_ViewImports.cshtml"
using OrchardCore.Menu.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Menu\Views\_ViewImports.cshtml"
using OrchardCore.DisplayManagement.Views;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Menu\Views\Admin\Create.cshtml"
using OrchardCore.ContentManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Menu\Views\Admin\Create.cshtml"
using OrchardCore.ContentManagement.Metadata;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Menu\Views\Admin\Create.cshtml"
using OrchardCore.Mvc.Utilities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa45d51df00c843a8d187b65717d348454daf362", @"/Views/Admin/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"961c567d30b6f54733154db4e126669072e5fd43", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Create : OrchardCore.DisplayManagement.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Menu\Views\Admin\Create.cshtml"
  
    ContentItem contentItem = Model.ContentItem;
    var contentTypeDefinition = ContentDefinitionManager.GetTypeDefinition(contentItem.ContentType);
    var typeDisplayName = contentTypeDefinition?.DisplayName ?? contentItem.ContentType.CamelFriendly();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 13 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Menu\Views\Admin\Create.cshtml"
Write(RenderTitleSegments(T["New {0}", typeDisplayName]));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa45d51df00c843a8d187b65717d348454daf3625932", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 15 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Menu\Views\Admin\Create.cshtml"
Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 16 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Menu\Views\Admin\Create.cshtml"
Write(await DisplayAsync(Model));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <input type=\"hidden\" name=\"MenuContentItemId\"");
                BeginWriteAttribute("value", " value=\"", 756, "\"", 788, 1);
#nullable restore
#line 18 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Menu\Views\Admin\Create.cshtml"
WriteAttributeValue("", 764, Model.MenuContentItemId, 764, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"MenuItemId\"");
                BeginWriteAttribute("value", " value=\"", 836, "\"", 861, 1);
#nullable restore
#line 19 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Menu\Views\Admin\Create.cshtml"
WriteAttributeValue("", 844, Model.MenuItemId, 844, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnUrl", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 14 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Menu\Views\Admin\Create.cshtml"
                                   WriteLiteral(Context.Request.Query["ReturnUrl"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
        public IContentDefinitionManager ContentDefinitionManager { get; private set; }
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
