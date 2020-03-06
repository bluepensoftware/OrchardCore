#pragma checksum "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Items\ContentDefinitionDeploymentStep.Fields.Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a726397f08d06f721ae66109491307fcb6a73d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_ContentDefinitionDeploymentStep_Fields_Edit), @"mvc.1.0.view", @"/Views/Items/ContentDefinitionDeploymentStep.Fields.Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a726397f08d06f721ae66109491307fcb6a73d1", @"/Views/Items/ContentDefinitionDeploymentStep.Fields.Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce76cbeb629f4393153146c98d0e602b38ff9b3d", @"/Views/_ViewImports.cshtml")]
    public class Views_Items_ContentDefinitionDeploymentStep_Fields_Edit : OrchardCore.DisplayManagement.Razor.RazorPage<ContentDefinitionStepViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "checkbox", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("custom-control-input"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-reverseToggle", new global::Microsoft.AspNetCore.Html.HtmlString(".cdsel"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("custom-control-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::OrchardCore.ResourceManagement.TagHelpers.ScriptTagHelper __OrchardCore_ResourceManagement_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Items\ContentDefinitionDeploymentStep.Fields.Edit.cshtml"
  
    var contentTypes = (string[])Model.ContentTypes;
    var contentParts = (string[])Model.ContentParts;

    var allTypes = ContentDefinitionManager.ListTypeDefinitions();
    var allParts = ContentDefinitionManager.ListPartDefinitions();

    var avaParts = allParts.Where(x => !allTypes.Any(y => y.Name == x.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h5>");
#nullable restore
#line 15 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Items\ContentDefinitionDeploymentStep.Fields.Edit.cshtml"
Write(T["Content Definitions"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n<fieldset class=\"form-group mt-4 mb-5\">\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            <div class=\"custom-control custom-checkbox\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0a726397f08d06f721ae66109491307fcb6a73d16060", async() => {
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 21 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Items\ContentDefinitionDeploymentStep.Fields.Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IncludeAll);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __OrchardCore_DisplayManagement_TagHelpers_InputIsDisabledTagHelper.For = __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For;
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a726397f08d06f721ae66109491307fcb6a73d18608", async() => {
#nullable restore
#line 22 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Items\ContentDefinitionDeploymentStep.Fields.Edit.cshtml"
                                                                    Write(T["Include all content types and parts definitions."]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 22 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Items\ContentDefinitionDeploymentStep.Fields.Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IncludeAll);

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
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</fieldset>\r\n\r\n\r\n<fieldset");
            BeginWriteAttribute("class", " class=\"", 995, "\"", 1071, 5);
            WriteAttributeValue("", 1003, "cdsel", 1003, 5, true);
            WriteAttributeValue(" ", 1008, "form-group", 1009, 11, true);
            WriteAttributeValue(" ", 1019, "mt-4", 1020, 5, true);
            WriteAttributeValue(" ", 1024, "mb-5", 1025, 5, true);
#nullable restore
#line 29 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Items\ContentDefinitionDeploymentStep.Fields.Edit.cshtml"
WriteAttributeValue(" ", 1029, Model.IncludeAll ? "collapse" : "show", 1030, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"row mb-3\">\r\n        <div class=\"col\">\r\n            <h6>Content Types</h6>\r\n            <span class=\"hint\">");
#nullable restore
#line 33 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Items\ContentDefinitionDeploymentStep.Fields.Edit.cshtml"
                          Write(T["The content types to add as part of the plan."]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n    </div>\r\n    <div class=\"row mb-2\">\r\n        <div class=\"col\">\r\n            <ul class=\"list-group\">\r\n");
#nullable restore
#line 39 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Items\ContentDefinitionDeploymentStep.Fields.Edit.cshtml"
                 foreach (var contentTypeDefinition in allTypes)
                {
                    var ctypename = contentTypeDefinition.Name;
                    var checkd = contentTypes?.Contains(ctypename);


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"list-group-item\">\r\n");
#nullable restore
#line 46 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Items\ContentDefinitionDeploymentStep.Fields.Edit.cshtml"
                         if (contentTypeDefinition.Parts.Any(x => x.Name == ctypename))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <input class=\"invisible\" style=\"position:absolute\" type=\"checkbox\"");
            BeginWriteAttribute("name", " name=\"", 1989, "\"", 2030, 1);
#nullable restore
#line 48 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Items\ContentDefinitionDeploymentStep.Fields.Edit.cshtml"
WriteAttributeValue("", 1996, Html.NameFor(m => m.ContentParts), 1996, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2031, "\"", 2049, 1);
#nullable restore
#line 48 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Items\ContentDefinitionDeploymentStep.Fields.Edit.cshtml"
WriteAttributeValue("", 2039, ctypename, 2039, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", "\r\n                                   id=\"", 2050, "\"", 2106, 2);
            WriteAttributeValue("", 2091, "part_", 2091, 5, true);
#nullable restore
#line 49 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Items\ContentDefinitionDeploymentStep.Fields.Edit.cshtml"
WriteAttributeValue("", 2096, ctypename, 2096, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("checked", " checked=\"", 2107, "\"", 2124, 1);
#nullable restore
#line 49 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Items\ContentDefinitionDeploymentStep.Fields.Edit.cshtml"
WriteAttributeValue("", 2117, checkd, 2117, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 50 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Items\ContentDefinitionDeploymentStep.Fields.Edit.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"custom-control custom-checkbox\">\r\n                            <input type=\"checkbox\" class=\"custom-control-input\"");
            BeginWriteAttribute("id", " id=\"", 2306, "\"", 2363, 1);
#nullable restore
#line 52 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Items\ContentDefinitionDeploymentStep.Fields.Edit.cshtml"
WriteAttributeValue("", 2311, Html.IdFor(m => m.ContentTypes) + "_" + ctypename, 2311, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 2364, "\"", 2405, 1);
#nullable restore
#line 52 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Items\ContentDefinitionDeploymentStep.Fields.Edit.cshtml"
WriteAttributeValue("", 2371, Html.NameFor(m => m.ContentTypes), 2371, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2406, "\"", 2424, 1);
#nullable restore
#line 52 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Items\ContentDefinitionDeploymentStep.Fields.Edit.cshtml"
WriteAttributeValue("", 2414, ctypename, 2414, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("checked", " checked=\"", 2425, "\"", 2442, 1);
#nullable restore
#line 52 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Items\ContentDefinitionDeploymentStep.Fields.Edit.cshtml"
WriteAttributeValue("", 2435, checkd, 2435, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"collapse\" data-target=\"#sub_");
#nullable restore
#line 52 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Items\ContentDefinitionDeploymentStep.Fields.Edit.cshtml"
                                                                                                                                                                                                                                                             Write(ctypename);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-checkbox=\"#part_");
#nullable restore
#line 52 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Items\ContentDefinitionDeploymentStep.Fields.Edit.cshtml"
                                                                                                                                                                                                                                                                                              Write(ctypename);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                            <label class=\"custom-control-label\"");
            BeginWriteAttribute("for", " for=\"", 2595, "\"", 2653, 1);
#nullable restore
#line 53 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Items\ContentDefinitionDeploymentStep.Fields.Edit.cshtml"
WriteAttributeValue("", 2601, Html.IdFor(m => m.ContentTypes) + "_" + ctypename, 2601, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 53 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Items\ContentDefinitionDeploymentStep.Fields.Edit.cshtml"
                                                                                                                      Write(contentTypeDefinition.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        </div>\r\n\r\n\r\n                        <ul");
            BeginWriteAttribute("class", " class=\"", 2762, "\"", 2815, 2);
            WriteAttributeValue("", 2770, "list-group", 2770, 10, true);
#nullable restore
#line 57 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Items\ContentDefinitionDeploymentStep.Fields.Edit.cshtml"
WriteAttributeValue(" ", 2780, checkd??false ? "" : "collapse", 2781, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 2816, "\"", 2835, 2);
            WriteAttributeValue("", 2821, "sub_", 2821, 4, true);
#nullable restore
#line 57 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Items\ContentDefinitionDeploymentStep.Fields.Edit.cshtml"
WriteAttributeValue("", 2825, ctypename, 2825, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 58 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Items\ContentDefinitionDeploymentStep.Fields.Edit.cshtml"
                             foreach (var part in contentTypeDefinition.Parts.Where(x => x.Name != ctypename))
                            {
                                var partName = part.PartDefinition.Name;
                                var partChecked = contentParts?.Contains(partName);


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"list-group-item\">\r\n                                    <div class=\"custom-control custom-checkbox\">\r\n                                        <input type=\"checkbox\"");
            BeginWriteAttribute("class", " class=\"", 3349, "\"", 3392, 3);
            WriteAttributeValue("", 3357, "custom-control-input", 3357, 20, true);
            WriteAttributeValue(" ", 3377, "part_", 3378, 6, true);
#nullable restore
#line 65 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Items\ContentDefinitionDeploymentStep.Fields.Edit.cshtml"
WriteAttributeValue("", 3383, partName, 3383, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 3393, "\"", 3445, 1);
#nullable restore
#line 65 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Items\ContentDefinitionDeploymentStep.Fields.Edit.cshtml"
WriteAttributeValue("", 3398, ctypename + "_" + partName + '_' + part.Name, 3398, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"tempparts\"");
            BeginWriteAttribute("value", " value=\"", 3463, "\"", 3471, 0);
            EndWriteAttribute();
            WriteLiteral(" type=\"checkbox\"");
            BeginWriteAttribute("checked", " checked=\"", 3488, "\"", 3510, 1);
#nullable restore
#line 65 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Items\ContentDefinitionDeploymentStep.Fields.Edit.cshtml"
WriteAttributeValue("", 3498, partChecked, 3498, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-checkboxChecked=\"#part_");
#nullable restore
#line 65 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Items\ContentDefinitionDeploymentStep.Fields.Edit.cshtml"
                                                                                                                                                                                                                                                        Write(part.PartDefinition.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                        <label class=\"custom-control-label\"");
            BeginWriteAttribute("for", " for=\"", 3644, "\"", 3697, 1);
#nullable restore
#line 66 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Items\ContentDefinitionDeploymentStep.Fields.Edit.cshtml"
WriteAttributeValue("", 3650, ctypename + "_" + partName + '_' + part.Name, 3650, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 67 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Items\ContentDefinitionDeploymentStep.Fields.Edit.cshtml"
                                             if (part.PartDefinition.Name == part.Name)
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Items\ContentDefinitionDeploymentStep.Fields.Edit.cshtml"
                                           Write(part.Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Items\ContentDefinitionDeploymentStep.Fields.Edit.cshtml"
                                                          
                                            }
                                            else
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Items\ContentDefinitionDeploymentStep.Fields.Edit.cshtml"
                                           Write(part.PartDefinition.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 73 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Items\ContentDefinitionDeploymentStep.Fields.Edit.cshtml"
                                                                             Write(part.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(")");
#nullable restore
#line 73 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Items\ContentDefinitionDeploymentStep.Fields.Edit.cshtml"
                                                                                                    
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </label>\r\n                                    </div>\r\n\r\n\r\n                                </li>\r\n");
#nullable restore
#line 80 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Items\ContentDefinitionDeploymentStep.Fields.Edit.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n\r\n                    </li>\r\n");
#nullable restore
#line 84 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Items\ContentDefinitionDeploymentStep.Fields.Edit.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </div>\r\n    </div>\r\n</fieldset>\r\n\r\n<fieldset");
            BeginWriteAttribute("class", " class=\"", 4508, "\"", 4584, 5);
            WriteAttributeValue("", 4516, "cdsel", 4516, 5, true);
            WriteAttributeValue(" ", 4521, "form-group", 4522, 11, true);
            WriteAttributeValue(" ", 4532, "mt-4", 4533, 5, true);
            WriteAttributeValue(" ", 4537, "mb-5", 4538, 5, true);
#nullable restore
#line 90 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Items\ContentDefinitionDeploymentStep.Fields.Edit.cshtml"
WriteAttributeValue(" ", 4542, Model.IncludeAll ? "collapse" : "show", 4543, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"row mb-3\">\r\n        <div class=\"col\">\r\n            <h6>Content Parts</h6>\r\n            <span class=\"hint\">");
#nullable restore
#line 94 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Items\ContentDefinitionDeploymentStep.Fields.Edit.cshtml"
                          Write(T["The content parts to add as part of the plan."]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n    </div>\r\n    <div class=\"row mb-2\">\r\n        <div class=\"col\">\r\n            <ul class=\"list-group\">\r\n");
#nullable restore
#line 100 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Items\ContentDefinitionDeploymentStep.Fields.Edit.cshtml"
                 foreach (var contentPartDefinition in avaParts)
                {
                    var partName = contentPartDefinition.Name;
                    var checkd = contentParts?.Contains(partName);


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"list-group-item\">\r\n                        <div class=\"custom-control custom-checkbox\">\r\n                            <input type=\"checkbox\" class=\"custom-control-input\"");
            BeginWriteAttribute("name", " name=\"", 5308, "\"", 5349, 1);
#nullable restore
#line 107 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Items\ContentDefinitionDeploymentStep.Fields.Edit.cshtml"
WriteAttributeValue("", 5315, Html.NameFor(m => m.ContentParts), 5315, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 5350, "\"", 5367, 1);
#nullable restore
#line 107 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Items\ContentDefinitionDeploymentStep.Fields.Edit.cshtml"
WriteAttributeValue("", 5358, partName, 5358, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("checked", " checked=\"", 5368, "\"", 5385, 1);
#nullable restore
#line 107 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Items\ContentDefinitionDeploymentStep.Fields.Edit.cshtml"
WriteAttributeValue("", 5378, checkd, 5378, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 5386, "\"", 5405, 2);
            WriteAttributeValue("", 5391, "part_", 5391, 5, true);
#nullable restore
#line 107 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Items\ContentDefinitionDeploymentStep.Fields.Edit.cshtml"
WriteAttributeValue("", 5396, partName, 5396, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-checkboxUnchecked=\".part_");
#nullable restore
#line 107 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Items\ContentDefinitionDeploymentStep.Fields.Edit.cshtml"
                                                                                                                                                                                                           Write(partName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                            <label class=\"custom-control-label\"");
            BeginWriteAttribute("for", " for=\"", 5513, "\"", 5533, 2);
            WriteAttributeValue("", 5519, "part_", 5519, 5, true);
#nullable restore
#line 108 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Items\ContentDefinitionDeploymentStep.Fields.Edit.cshtml"
WriteAttributeValue("", 5524, partName, 5524, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 108 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Items\ContentDefinitionDeploymentStep.Fields.Edit.cshtml"
                                                                                Write(partName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        </div>\r\n                    </li>\r\n");
#nullable restore
#line 111 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Items\ContentDefinitionDeploymentStep.Fields.Edit.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </div>\r\n    </div>\r\n</fieldset>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a726397f08d06f721ae66109491307fcb6a73d132269", async() => {
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
        $(""[data-checkbox]"").on(""click"", function () {
            var state = this.checked;
            $($(this).attr(""data-checkbox""))
                .prop(""checked"", state);
        });

        $(""[data-checkboxChecked]"").on(""click"", function () {
            var state = this.checked;
            if (state) {
                $($(this).attr(""data-checkboxChecked""))
                    .prop(""checked"", state);
            }
        });

        $(""[data-checkboxUnchecked]"").on(""click"", function () {
            var state = this.checked;
            if (!state) {
                $($(this).attr(""data-checkboxUnchecked""))
                    .prop(""che");
                WriteLiteral("cked\", state);\r\n            }\r\n        });\r\n    });\r\n");
            }
            );
            __OrchardCore_ResourceManagement_TagHelpers_ScriptTagHelper = CreateTagHelper<global::OrchardCore.ResourceManagement.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__OrchardCore_ResourceManagement_TagHelpers_ScriptTagHelper);
#nullable restore
#line 117 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.ContentTypes\Views\Items\ContentDefinitionDeploymentStep.Fields.Edit.cshtml"
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
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public OrchardCore.ContentManagement.Metadata.IContentDefinitionManager ContentDefinitionManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContentDefinitionStepViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
