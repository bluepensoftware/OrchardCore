#pragma checksum "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Workflows\Views\Items\TimerEvent.Fields.Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bf11e4ceb4bb93e47b25252411b4dfc60414143"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_TimerEvent_Fields_Edit), @"mvc.1.0.view", @"/Views/Items/TimerEvent.Fields.Edit.cshtml")]
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
#line 2 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Workflows\Views\_ViewImports.cshtml"
using OrchardCore.Workflows.Deployment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Workflows\Views\_ViewImports.cshtml"
using OrchardCore.Workflows.Activities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Workflows\Views\_ViewImports.cshtml"
using OrchardCore.Workflows.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Workflows\Views\_ViewImports.cshtml"
using OrchardCore.Workflows.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Workflows\Views\_ViewImports.cshtml"
using OrchardCore.DisplayManagement.Views;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Workflows\Views\_ViewImports.cshtml"
using OrchardCore.Mvc.Utilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Workflows\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Workflows\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Workflows\Views\Items\TimerEvent.Fields.Edit.cshtml"
using OrchardCore.Workflows.Timers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bf11e4ceb4bb93e47b25252411b4dfc60414143", @"/Views/Items/TimerEvent.Fields.Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ae673631375598e89b007c6526480c06d3c9641", @"/Views/_ViewImports.cshtml")]
    public class Views_Items_TimerEvent_Fields_Edit : OrchardCore.DisplayManagement.Razor.RazorPage<TimerEventViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::OrchardCore.DisplayManagement.TagHelpers.InputIsDisabledTagHelper __OrchardCore_DisplayManagement_TagHelpers_InputIsDisabledTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("fieldset", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bf11e4ceb4bb93e47b25252411b4dfc604141436456", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bf11e4ceb4bb93e47b25252411b4dfc604141436722", async() => {
#nullable restore
#line 5 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Workflows\Views\Items\TimerEvent.Fields.Edit.cshtml"
                               Write(T["CRON Expression"]);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 5 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Workflows\Views\Items\TimerEvent.Fields.Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CronExpression);

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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9bf11e4ceb4bb93e47b25252411b4dfc604141438525", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __OrchardCore_DisplayManagement_TagHelpers_InputIsDisabledTagHelper = CreateTagHelper<global::OrchardCore.DisplayManagement.TagHelpers.InputIsDisabledTagHelper>();
                __tagHelperExecutionContext.Add(__OrchardCore_DisplayManagement_TagHelpers_InputIsDisabledTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __OrchardCore_DisplayManagement_TagHelpers_InputIsDisabledTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 6 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Workflows\Views\Items\TimerEvent.Fields.Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CronExpression);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __OrchardCore_DisplayManagement_TagHelpers_InputIsDisabledTagHelper.For = __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For;
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bf11e4ceb4bb93e47b25252411b4dfc6041414311368", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 7 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Workflows\Views\Items\TimerEvent.Fields.Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CronExpression);

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
#line 8 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Workflows\Views\Items\TimerEvent.Fields.Edit.cshtml"
                  Write(T["The CRON expression."]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n");
            }
            );
            __OrchardCore_DisplayManagement_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::OrchardCore.DisplayManagement.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__OrchardCore_DisplayManagement_TagHelpers_ValidationMessageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 4 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Workflows\Views\Items\TimerEvent.Fields.Edit.cshtml"
__OrchardCore_DisplayManagement_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CronExpression);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TimerEventViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
