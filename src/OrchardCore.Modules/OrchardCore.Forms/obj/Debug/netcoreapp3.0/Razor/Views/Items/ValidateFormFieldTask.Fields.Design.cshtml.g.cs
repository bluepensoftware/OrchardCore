#pragma checksum "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Forms\Views\Items\ValidateFormFieldTask.Fields.Design.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "321db7c2410b6005d9290b02d1c6d7e6614ab53e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_ValidateFormFieldTask_Fields_Design), @"mvc.1.0.view", @"/Views/Items/ValidateFormFieldTask.Fields.Design.cshtml")]
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
#line 6 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Forms\Views\_ViewImports.cshtml"
using OrchardCore.ContentManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Forms\Views\_ViewImports.cshtml"
using OrchardCore.DisplayManagement.Views;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Forms\Views\_ViewImports.cshtml"
using OrchardCore.Workflows.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Forms\Views\_ViewImports.cshtml"
using OrchardCore.Workflows.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Forms\Views\_ViewImports.cshtml"
using OrchardCore.Forms.Workflows.Activities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"321db7c2410b6005d9290b02d1c6d7e6614ab53e", @"/Views/Items/ValidateFormFieldTask.Fields.Design.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8ece941fca7bc3de8e9cbb2d046454bf0845f21", @"/Views/_ViewImports.cshtml")]
    public class Views_Items_ValidateFormFieldTask_Fields_Design : OrchardCore.DisplayManagement.Razor.RazorPage<ActivityViewModel<ValidateFormFieldTask>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<header>\r\n    <h4><i class=\"fa fa-shield-alt\"></i>");
#nullable restore
#line 4 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Forms\Views\Items\ValidateFormFieldTask.Fields.Design.cshtml"
                                   Write(Model.Activity.GetTitleOrDefault(() => T["Validate Form Field"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n</header>\r\n<span>");
#nullable restore
#line 6 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Forms\Views\Items\ValidateFormFieldTask.Fields.Design.cshtml"
 Write(T["Validate <em>{0}</em>", Model.Activity.FieldName]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ActivityViewModel<ValidateFormFieldTask>> Html { get; private set; }
    }
}
#pragma warning restore 1591
