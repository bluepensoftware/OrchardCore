#pragma checksum "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.CustomSettings\Views\Items\CustomSettingsDeploymentStep.Fields.Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f475205f93144c42d765c3cea36c17df484d9041"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_CustomSettingsDeploymentStep_Fields_Edit), @"mvc.1.0.view", @"/Views/Items/CustomSettingsDeploymentStep.Fields.Edit.cshtml")]
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
#line 7 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.CustomSettings\Views\_ViewImports.cshtml"
using OrchardCore.DisplayManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.CustomSettings\Views\_ViewImports.cshtml"
using OrchardCore.DisplayManagement.Views;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.CustomSettings\Views\_ViewImports.cshtml"
using OrchardCore.CustomSettings.Deployment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.CustomSettings\Views\_ViewImports.cshtml"
using OrchardCore.CustomSettings.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f475205f93144c42d765c3cea36c17df484d9041", @"/Views/Items/CustomSettingsDeploymentStep.Fields.Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"574ec38b65580022b8ca4b564079eba1a2c70d24", @"/Views/_ViewImports.cshtml")]
    public class Views_Items_CustomSettingsDeploymentStep_Fields_Edit : OrchardCore.DisplayManagement.Razor.RazorPage<CustomSettingsDeploymentStepViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-check-input"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-reverseToggle", new global::Microsoft.AspNetCore.Html.HtmlString(".cssel"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::OrchardCore.DisplayManagement.TagHelpers.InputIsDisabledTagHelper __OrchardCore_DisplayManagement_TagHelpers_InputIsDisabledTagHelper;
        private global::OrchardCore.ResourceManagement.TagHelpers.ScriptTagHelper __OrchardCore_ResourceManagement_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.CustomSettings\Views\Items\CustomSettingsDeploymentStep.Fields.Edit.cshtml"
  
    var settingsTypeNames = Model.SettingsTypeNames;
    var allSettingsTypeNames = Model.AllSettingsTypeNames;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h5>");
#nullable restore
#line 8 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.CustomSettings\Views\Items\CustomSettingsDeploymentStep.Fields.Edit.cshtml"
Write(T["Custom Settings"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n<fieldset class=\"form-group mt-4 mb-5\">\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            <div class=\"form-check\">\r\n                <label class=\"form-check-label\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f475205f93144c42d765c3cea36c17df484d90415778", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __OrchardCore_DisplayManagement_TagHelpers_InputIsDisabledTagHelper = CreateTagHelper<global::OrchardCore.DisplayManagement.TagHelpers.InputIsDisabledTagHelper>();
            __tagHelperExecutionContext.Add(__OrchardCore_DisplayManagement_TagHelpers_InputIsDisabledTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 15 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.CustomSettings\Views\Items\CustomSettingsDeploymentStep.Fields.Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IncludeAll);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __OrchardCore_DisplayManagement_TagHelpers_InputIsDisabledTagHelper.For = __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For;
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
#nullable restore
#line 17 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.CustomSettings\Views\Items\CustomSettingsDeploymentStep.Fields.Edit.cshtml"
               Write(T["Include all custom settings."]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </label>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</fieldset>\r\n\r\n<fieldset");
            BeginWriteAttribute("class", " class=\"", 671, "\"", 747, 5);
            WriteAttributeValue("", 679, "cssel", 679, 5, true);
            WriteAttributeValue(" ", 684, "form-group", 685, 11, true);
            WriteAttributeValue(" ", 695, "mt-4", 696, 5, true);
            WriteAttributeValue(" ", 700, "mb-5", 701, 5, true);
#nullable restore
#line 24 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.CustomSettings\Views\Items\CustomSettingsDeploymentStep.Fields.Edit.cshtml"
WriteAttributeValue(" ", 705, Model.IncludeAll ? "collapse" : "show", 706, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"row\">\r\n        <div class=\"col-sm\">\r\n            <span class=\"hint\">");
#nullable restore
#line 27 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.CustomSettings\Views\Items\CustomSettingsDeploymentStep.Fields.Edit.cshtml"
                          Write(T["The custom settings to add as part of the plan."]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-sm\">\r\n            <ul class=\"list-group\">\r\n");
#nullable restore
#line 33 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.CustomSettings\Views\Items\CustomSettingsDeploymentStep.Fields.Edit.cshtml"
                 foreach (var settingsTypeName in allSettingsTypeNames)
                {
                    var checkd = settingsTypeNames?.Contains(settingsTypeName);


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"list-group-item\">\r\n                        <div class=\"form-check\">\r\n                            <label class=\"form-check-label\">\r\n                                <input class=\"form-check-input\" type=\"checkbox\"");
            BeginWriteAttribute("name", " name=\"", 1431, "\"", 1477, 1);
#nullable restore
#line 40 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.CustomSettings\Views\Items\CustomSettingsDeploymentStep.Fields.Edit.cshtml"
WriteAttributeValue("", 1438, Html.NameFor(m => m.SettingsTypeNames), 1438, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 1478, "\"", 1503, 1);
#nullable restore
#line 40 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.CustomSettings\Views\Items\CustomSettingsDeploymentStep.Fields.Edit.cshtml"
WriteAttributeValue("", 1486, settingsTypeName, 1486, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("checked", " checked=\"", 1504, "\"", 1521, 1);
#nullable restore
#line 40 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.CustomSettings\Views\Items\CustomSettingsDeploymentStep.Fields.Edit.cshtml"
WriteAttributeValue("", 1514, checkd, 1514, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                ");
#nullable restore
#line 41 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.CustomSettings\Views\Items\CustomSettingsDeploymentStep.Fields.Edit.cshtml"
                           Write(settingsTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </label>\r\n                        </div>\r\n                    </li>\r\n");
#nullable restore
#line 45 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.CustomSettings\Views\Items\CustomSettingsDeploymentStep.Fields.Edit.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </div>\r\n    </div>\r\n</fieldset>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f475205f93144c42d765c3cea36c17df484d904112369", async() => {
                WriteLiteral(@"
    $(function () {
        $(""[data-reversetoggle]"").on(""click"", function () {
            var state = this.checked;
            if (state) {
                $($(this).attr(""data-reversetoggle"")).collapse('hide');
            } else {
                $($(this).attr(""data-reversetoggle"")).collapse('show');
            }
        });
    });
");
            }
            );
            __OrchardCore_ResourceManagement_TagHelpers_ScriptTagHelper = CreateTagHelper<global::OrchardCore.ResourceManagement.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__OrchardCore_ResourceManagement_TagHelpers_ScriptTagHelper);
#nullable restore
#line 51 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.CustomSettings\Views\Items\CustomSettingsDeploymentStep.Fields.Edit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CustomSettingsDeploymentStepViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
