#pragma checksum "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Admin\AddFieldTo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "898f4aecd3df356b6f6933dfbc9fcd3f0823e486"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AddFieldTo), @"mvc.1.0.view", @"/Views/Admin/AddFieldTo.cshtml")]
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
#line 10 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\_ViewImports.cshtml"
using OrchardCore.ContentTypes.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Admin\AddFieldTo.cshtml"
using OrchardCore.Mvc.Utilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Admin\AddFieldTo.cshtml"
using OrchardCore.ContentManagement.Metadata.Settings;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"898f4aecd3df356b6f6933dfbc9fcd3f0823e486", @"/Views/Admin/AddFieldTo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce76cbeb629f4393153146c98d0e602b38ff9b3d", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AddFieldTo : OrchardCore.DisplayManagement.Razor.RazorPage<AddFieldViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "radio", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("custom-control-input"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("custom-control-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddFieldTo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::OrchardCore.DisplayManagement.TagHelpers.InputIsDisabledTagHelper __OrchardCore_DisplayManagement_TagHelpers_InputIsDisabledTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::OrchardCore.ResourceManagement.TagHelpers.ScriptTagHelper __OrchardCore_ResourceManagement_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Admin\AddFieldTo.cshtml"
  
    var returnUrl = ViewData["returnUrl"]?.ToString();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1>");
#nullable restore
#line 11 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Admin\AddFieldTo.cshtml"
Write(RenderTitleSegments(T["Add New Field To \"{0}\"", Model.Part.DisplayName()]));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "898f4aecd3df356b6f6933dfbc9fcd3f0823e4866854", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 14 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Admin\AddFieldTo.cshtml"
Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <fieldset class=\"form-group\">\r\n        <div class=\"row col-md\">\r\n            <label for=\"DisplayName\">");
#nullable restore
#line 17 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Admin\AddFieldTo.cshtml"
                                Write(T["Display Name"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "898f4aecd3df356b6f6933dfbc9fcd3f0823e4867807", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __OrchardCore_DisplayManagement_TagHelpers_InputIsDisabledTagHelper = CreateTagHelper<global::OrchardCore.DisplayManagement.TagHelpers.InputIsDisabledTagHelper>();
                __tagHelperExecutionContext.Add(__OrchardCore_DisplayManagement_TagHelpers_InputIsDisabledTagHelper);
#nullable restore
#line 18 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Admin\AddFieldTo.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DisplayName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __OrchardCore_DisplayManagement_TagHelpers_InputIsDisabledTagHelper.For = __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For;
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("autofocus", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <span class=\"hint\">");
#nullable restore
#line 19 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Admin\AddFieldTo.cshtml"
                          Write(T["Name of the field as it will be displayed in screens."]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n        </div>\r\n    </fieldset>\r\n\r\n    <fieldset class=\"form-group\">\r\n        <div class=\"row col-sm\">\r\n            <label for=\"Name\">");
#nullable restore
#line 25 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Admin\AddFieldTo.cshtml"
                         Write(T["Technical Name"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "898f4aecd3df356b6f6933dfbc9fcd3f0823e48611008", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __OrchardCore_DisplayManagement_TagHelpers_InputIsDisabledTagHelper = CreateTagHelper<global::OrchardCore.DisplayManagement.TagHelpers.InputIsDisabledTagHelper>();
                __tagHelperExecutionContext.Add(__OrchardCore_DisplayManagement_TagHelpers_InputIsDisabledTagHelper);
#nullable restore
#line 26 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Admin\AddFieldTo.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __OrchardCore_DisplayManagement_TagHelpers_InputIsDisabledTagHelper.For = __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For;
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <span class=\"hint\">");
#nullable restore
#line 27 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Admin\AddFieldTo.cshtml"
                          Write(T["Technical name of the field."]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n        </div>\r\n    </fieldset>\r\n\r\n    <fieldset class=\"form-group\">\r\n        <label for=\"DisplayName\">");
#nullable restore
#line 32 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Admin\AddFieldTo.cshtml"
                            Write(T["Field Type"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n        <ul class=\"list-group w-md-50\">\r\n");
#nullable restore
#line 34 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Admin\AddFieldTo.cshtml"
             for (var i = 0; i < Model.Fields.Count; i++)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <li class=\"list-group-item\">\r\n                    <div class=\"custom-control custom-radio\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "898f4aecd3df356b6f6933dfbc9fcd3f0823e48614293", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __OrchardCore_DisplayManagement_TagHelpers_InputIsDisabledTagHelper = CreateTagHelper<global::OrchardCore.DisplayManagement.TagHelpers.InputIsDisabledTagHelper>();
                __tagHelperExecutionContext.Add(__OrchardCore_DisplayManagement_TagHelpers_InputIsDisabledTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __OrchardCore_DisplayManagement_TagHelpers_InputIsDisabledTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 38 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Admin\AddFieldTo.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FieldTypeName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __OrchardCore_DisplayManagement_TagHelpers_InputIsDisabledTagHelper.For = __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For;
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 38 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Admin\AddFieldTo.cshtml"
AddHtmlAttributeValue("", 1446, Html.IdFor(m => m.Fields[i]), 1446, 29, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Admin\AddFieldTo.cshtml"
                                                                                                                               WriteLiteral(Model.Fields[i]);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __OrchardCore_DisplayManagement_TagHelpers_InputIsDisabledTagHelper.Value = __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value;
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "checked", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 38 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Admin\AddFieldTo.cshtml"
AddHtmlAttributeValue("", 1511, i == 0, 1511, 9, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "898f4aecd3df356b6f6933dfbc9fcd3f0823e48618795", async() => {
#nullable restore
#line 39 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Admin\AddFieldTo.cshtml"
                                                                           Write(Model.Fields[i].CamelFriendly());

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 39 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Admin\AddFieldTo.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Fields[i]);

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
                WriteLiteral("\r\n                    </div>\r\n                </li>\r\n");
#nullable restore
#line 42 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Admin\AddFieldTo.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </ul>\r\n    </fieldset>\r\n\r\n    <fieldset class=\"form-group\">\r\n        <button class=\"btn btn-primary\" type=\"submit\">");
#nullable restore
#line 47 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Admin\AddFieldTo.cshtml"
                                                 Write(T["Save"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n");
#nullable restore
#line 48 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Admin\AddFieldTo.cshtml"
         if (Url.IsLocalUrl(returnUrl))
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <a class=\"btn btn-secondary\"");
                BeginWriteAttribute("href", " href=\"", 1948, "\"", 1965, 1);
#nullable restore
#line 50 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Admin\AddFieldTo.cshtml"
WriteAttributeValue("", 1955, returnUrl, 1955, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 50 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Admin\AddFieldTo.cshtml"
                                                      Write(T["Cancel"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n");
#nullable restore
#line 51 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Admin\AddFieldTo.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </fieldset>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnUrl", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 13 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Admin\AddFieldTo.cshtml"
                                       WriteLiteral(ViewData["returnUrl"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "898f4aecd3df356b6f6933dfbc9fcd3f0823e48624987", async() => {
                WriteLiteral("\r\n//<![CDATA[\r\n    $(function(){\r\n        var $name = $(\"#");
#nullable restore
#line 58 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Admin\AddFieldTo.cshtml"
                   Write(Html.IdFor(m => m.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\");\r\n        var $displayName = $(\"#");
#nullable restore
#line 59 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Admin\AddFieldTo.cshtml"
                          Write(Html.IdFor(m => m.DisplayName));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""");

        var nameAltered;
        $name.keypress(function() {
            nameAltered = true;
        });

        var compute = function() {
            // stop processing automatically if altered by the user
            if(nameAltered) {
                return true;
            }

            $name.val(getTechnicalName($displayName.val()));
        };

        $displayName.keyup(compute);
        $displayName.blur(compute);
    })
//]]>
");
            }
            );
            __OrchardCore_ResourceManagement_TagHelpers_ScriptTagHelper = CreateTagHelper<global::OrchardCore.ResourceManagement.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__OrchardCore_ResourceManagement_TagHelpers_ScriptTagHelper);
#nullable restore
#line 55 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Admin\AddFieldTo.cshtml"
__OrchardCore_ResourceManagement_TagHelpers_ScriptTagHelper.At = global::OrchardCore.ResourceManagement.ResourceLocation.Foot;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("at", __OrchardCore_ResourceManagement_TagHelpers_ScriptTagHelper.At, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AddFieldViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
