#pragma checksum "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Menu\Views\MenuPart.Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0875ef6bf8db9ecf5115c3d6b32a602deaf67cb0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MenuPart_Edit), @"mvc.1.0.view", @"/Views/MenuPart.Edit.cshtml")]
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
#line 13 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Menu\Views\_ViewImports.cshtml"
using OrchardCore.ContentManagement;

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
#line 15 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Menu\Views\MenuPart.Edit.cshtml"
using OrchardCore.ContentManagement.Metadata.Settings;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0875ef6bf8db9ecf5115c3d6b32a602deaf67cb0", @"/Views/MenuPart.Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"961c567d30b6f54733154db4e126669072e5fd43", @"/Views/_ViewImports.cshtml")]
    public class Views_MenuPart_Edit : OrchardCore.DisplayManagement.Razor.RazorPage<MenuPartEditViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-src", "~/OrchardCore.Menu/Scripts/menu.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("depends-on", "admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-src", "~/OrchardCore.Menu/Styles/menu.min.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("debug-src", "~/OrchardCore.Menu/Styles/menu.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::OrchardCore.DisplayManagement.TagHelpers.InputIsDisabledTagHelper __OrchardCore_DisplayManagement_TagHelpers_InputIsDisabledTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0875ef6bf8db9ecf5115c3d6b32a602deaf67cb06161", async() => {
            }
            );
            __OrchardCore_ResourceManagement_TagHelpers_ScriptTagHelper = CreateTagHelper<global::OrchardCore.ResourceManagement.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__OrchardCore_ResourceManagement_TagHelpers_ScriptTagHelper);
            __OrchardCore_ResourceManagement_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 12 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Menu\Views\MenuPart.Edit.cshtml"
__OrchardCore_ResourceManagement_TagHelpers_ScriptTagHelper.At = global::OrchardCore.ResourceManagement.ResourceLocation.Foot;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("at", __OrchardCore_ResourceManagement_TagHelpers_ScriptTagHelper.At, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __OrchardCore_ResourceManagement_TagHelpers_ScriptTagHelper.DependsOn = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("style", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0875ef6bf8db9ecf5115c3d6b32a602deaf67cb08039", async() => {
            }
            );
            __OrchardCore_ResourceManagement_TagHelpers_StyleTagHelper = CreateTagHelper<global::OrchardCore.ResourceManagement.TagHelpers.StyleTagHelper>();
            __tagHelperExecutionContext.Add(__OrchardCore_ResourceManagement_TagHelpers_StyleTagHelper);
            __OrchardCore_ResourceManagement_TagHelpers_StyleTagHelper.Src = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __OrchardCore_ResourceManagement_TagHelpers_StyleTagHelper.DebugSrc = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 17 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Menu\Views\MenuPart.Edit.cshtml"
  
    var updater = ModelUpdaterAccessor.ModelUpdater;
    var menuItemContentTypes = ContentDefinitionManager.ListTypeDefinitions().Where(t => t.GetSettings<ContentTypeSettings>().Stereotype == "MenuItem");
    var canAddMenuItem = Model.MenuPart.ContentItem.Id != 0;
    var index = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<nav class=\"admin-toolbar\">\r\n    <button type=\"button\" ");
#nullable restore
#line 25 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Menu\Views\MenuPart.Edit.cshtml"
                      Write(canAddMenuItem ? null : "disabled=\"disabled\"");

#line default
#line hidden
#nullable disable
            WriteLiteral(" class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#modalMenuItems\">\r\n        ");
#nullable restore
#line 26 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Menu\Views\MenuPart.Edit.cshtml"
   Write(T["Add Menu Item"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </button>\r\n</nav>\r\n\r\n<p>\r\n    <ol id=\"menu\">\r\n");
#nullable restore
#line 32 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Menu\Views\MenuPart.Edit.cshtml"
         foreach (var menuItem in Model.MenuPart.ContentItem.As<MenuItemsListPart>().MenuItems)
        {
            dynamic menuItemShape = await ContentItemDisplayManager.BuildDisplayAsync(menuItem, updater, "Admin");
            menuItemShape.MenuPart = Model.MenuPart;
            menuItemShape.Index = index++;
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Menu\Views\MenuPart.Edit.cshtml"
       Write(await DisplayAsync(menuItemShape));

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Menu\Views\MenuPart.Edit.cshtml"
                                              ;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </ol>
</p>

<!-- Modal -->
<div class=""modal fade"" id=""modalMenuItems"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">");
#nullable restore
#line 47 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Menu\Views\MenuPart.Edit.cshtml"
                                   Write(T["Available Menu Items"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div class=""row"">
");
#nullable restore
#line 54 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Menu\Views\MenuPart.Edit.cshtml"
                     foreach (var type in menuItemContentTypes)
                    {
                        var menuItem = await ContentManager.NewAsync(type.Name);
                        dynamic thumbnail = await ContentItemDisplayManager.BuildDisplayAsync(menuItem, updater, "Thumbnail");
                        thumbnail.MenuItemType = type.Name;
                        thumbnail.MenuItemTypeDisplayName = type.DisplayName;
                        thumbnail.MenuContentItemId = Model.MenuPart.ContentItem.ContentItemId;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-sm-6\">\r\n                            ");
#nullable restore
#line 62 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Menu\Views\MenuPart.Edit.cshtml"
                       Write(await DisplayAsync(thumbnail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 64 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Menu\Views\MenuPart.Edit.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n            <div class=\"modal-footer\">\r\n                <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">");
#nullable restore
#line 68 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Menu\Views\MenuPart.Edit.cshtml"
                                                                                Write(T["Cancel"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0875ef6bf8db9ecf5115c3d6b32a602deaf67cb014583", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __OrchardCore_DisplayManagement_TagHelpers_InputIsDisabledTagHelper = CreateTagHelper<global::OrchardCore.DisplayManagement.TagHelpers.InputIsDisabledTagHelper>();
            __tagHelperExecutionContext.Add(__OrchardCore_DisplayManagement_TagHelpers_InputIsDisabledTagHelper);
#nullable restore
#line 74 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Menu\Views\MenuPart.Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Hierarchy);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __OrchardCore_DisplayManagement_TagHelpers_InputIsDisabledTagHelper.For = __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For;
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __OrchardCore_DisplayManagement_TagHelpers_InputIsDisabledTagHelper.InputTypeName = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __OrchardCore_DisplayManagement_TagHelpers_InputIsDisabledTagHelper.Value = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div id=\"msg-leave\" style=\"display:none\" data>");
#nullable restore
#line 75 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Menu\Views\MenuPart.Edit.cshtml"
                                         Write(T["You have reordered the navigation."]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0875ef6bf8db9ecf5115c3d6b32a602deaf67cb017685", async() => {
                WriteLiteral(@"
    var menuItemId;
    var confirmLeave;

    $('#modalMenuItems').on('show.bs.modal', function (event) {
        var button = $(event.relatedTarget) // Button that triggered the modal
        menuItemId = button.data('menuitemid') // Extract info from data-* attributes
    })

    $('.thumbnail-link-create').on('click', function () {
        // there is no value for a new root menu item
        if (menuItemId) {
            var link = $(this);
            var href = link.attr('href');
            href += '&menuitemid=' + menuItemId;
            link.attr('href', href);
        }
    });

    $(function () {
        $('#menu')
            .nestedSortable({
                handle: 'div.menu-item-title',
                items: 'li.menu-item',
                toleranceElement: '> div.menu-item-title',
                relocate: function () {
                    confirmLeave = true;
                    $('#");
#nullable restore
#line 104 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Menu\Views\MenuPart.Edit.cshtml"
                   Write(Html.IdFor(m => m.Hierarchy));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"').attr('value', JSON.stringify($('#menu').nestedSortable('toHierarchy')));
                }
            });

        window.onbeforeunload = function () {
            if (confirmLeave) {
                return $('#msg-leave').text();
            }
        }

        $('#menu').closest(""form"").on('submit', function (e) {
            confirmLeave = false;
            window.onbeforeunload = function () { };
        });
    });


");
            }
            );
            __OrchardCore_ResourceManagement_TagHelpers_ScriptTagHelper = CreateTagHelper<global::OrchardCore.ResourceManagement.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__OrchardCore_ResourceManagement_TagHelpers_ScriptTagHelper);
#nullable restore
#line 77 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Menu\Views\MenuPart.Edit.cshtml"
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
        public OrchardCore.ContentManagement.Metadata.IContentDefinitionManager ContentDefinitionManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public OrchardCore.DisplayManagement.ModelBinding.IUpdateModelAccessor ModelUpdaterAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public OrchardCore.ContentManagement.Display.IContentItemDisplayManager ContentItemDisplayManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IContentManager ContentManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MenuPartEditViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
