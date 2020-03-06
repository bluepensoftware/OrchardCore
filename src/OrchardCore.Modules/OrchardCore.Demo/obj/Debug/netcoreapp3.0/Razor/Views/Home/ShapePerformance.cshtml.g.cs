#pragma checksum "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Demo\Views\Home\ShapePerformance.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06a408e096909662865ab6b1f41d784c279ac061"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShapePerformance), @"mvc.1.0.view", @"/Views/Home/ShapePerformance.cshtml")]
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
#line 4 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Demo\Views\Home\ShapePerformance.cshtml"
using OrchardCore.DisplayManagement;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06a408e096909662865ab6b1f41d784c279ac061", @"/Views/Home/ShapePerformance.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d20c272d16f0751d43b929c1894a18efb7e8c685", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShapePerformance : OrchardCore.DisplayManagement.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Demo\Views\Home\ShapePerformance.cshtml"
   
    var iterations = 100;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>Rendering a \"Fake\" shape ");
#nullable restore
#line 10 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Demo\Views\Home\ShapePerformance.cshtml"
                        Write(iterations);

#line default
#line hidden
#nullable disable
            WriteLiteral(" times using different ways to instantiate the shapes</h4>\r\n\r\nVIEW COMPONENTS\r\n");
#nullable restore
#line 13 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Demo\Views\Home\ShapePerformance.cshtml"
  
    var sw = new System.Diagnostics.Stopwatch();
    sw.Start();

    var buffer = new Microsoft.AspNetCore.Html.HtmlContentBuilder();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 20 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Demo\Views\Home\ShapePerformance.cshtml"
 for (int i = 0; i < iterations; i++)
{
    buffer.AppendHtml(await Component.InvokeAsync("Fake", new { value = i.ToString() }));
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 25 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Demo\Views\Home\ShapePerformance.cshtml"
Write(sw.Elapsed.TotalMilliseconds);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ms\r\n\r\n<br/>\r\nSHAPES (Arguments)\r\n\r\n");
#nullable restore
#line 30 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Demo\Views\Home\ShapePerformance.cshtml"
  
    buffer = new Microsoft.AspNetCore.Html.HtmlContentBuilder();
    sw.Restart();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 35 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Demo\Views\Home\ShapePerformance.cshtml"
 for (int i = 0; i < iterations; i++)
{
    buffer.AppendHtml(await DisplayAsync(await New.Fake(Value: i.ToString())));
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 40 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Demo\Views\Home\ShapePerformance.cshtml"
Write(sw.Elapsed.TotalMilliseconds);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ms\r\n\r\n<br />\r\nSHAPES (Method call)\r\n\r\n");
#nullable restore
#line 45 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Demo\Views\Home\ShapePerformance.cshtml"
  
    buffer = new Microsoft.AspNetCore.Html.HtmlContentBuilder();
    sw.Restart();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 50 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Demo\Views\Home\ShapePerformance.cshtml"
 for (int i = 0; i < iterations; i++)
{
    buffer.AppendHtml(await DisplayAsync((await New.Fake()).Value(i.ToString())));
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 55 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Demo\Views\Home\ShapePerformance.cshtml"
Write(sw.Elapsed.TotalMilliseconds);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ms\r\n\r\n\r\n<br />\r\nSHAPES (Dynamic Proxy - Dynamic View Model)\r\n\r\n");
#nullable restore
#line 61 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Demo\Views\Home\ShapePerformance.cshtml"
  
    buffer = new Microsoft.AspNetCore.Html.HtmlContentBuilder();
    sw.Restart();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 66 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Demo\Views\Home\ShapePerformance.cshtml"
 for (int i = 0; i < iterations; i++)
{
    var proxy = await Factory.CreateAsync<OrchardCore.Demo.Models.FakeShape>("Fake", f => f.Value = "666");
    
    buffer.AppendHtml(await DisplayAsync(proxy));
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 73 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Demo\Views\Home\ShapePerformance.cshtml"
Write(sw.Elapsed.TotalMilliseconds);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ms\r\n\r\n<br />\r\nSHAPES (Dynamic Proxy - Strong Typed View Model)\r\n\r\n");
#nullable restore
#line 78 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Demo\Views\Home\ShapePerformance.cshtml"
  
    buffer = new Microsoft.AspNetCore.Html.HtmlContentBuilder();
    sw.Restart();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 83 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Demo\Views\Home\ShapePerformance.cshtml"
 for (int i = 0; i < iterations; i++)
{
    var proxy = await Factory.CreateAsync<OrchardCore.Demo.Models.FakeShape>("Fake__Typed", f => f.Value = "666");

    buffer.AppendHtml(await DisplayAsync(proxy));
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 90 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Demo\Views\Home\ShapePerformance.cshtml"
Write(sw.Elapsed.TotalMilliseconds);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ms\r\n\r\n<br />\r\nSHAPES (Custom Strong Typed View Model)\r\n\r\n");
#nullable restore
#line 95 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Demo\Views\Home\ShapePerformance.cshtml"
  
    buffer = new Microsoft.AspNetCore.Html.HtmlContentBuilder();
    sw.Restart();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 100 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Demo\Views\Home\ShapePerformance.cshtml"
 for (int i = 0; i < iterations; i++)
{
    var instance = new OrchardCore.Demo.Models.CustomViewModel();
    instance.Value = "666";
    instance.Metadata.Type = "Fake";

    buffer.AppendHtml(await DisplayAsync(instance));
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 109 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Demo\Views\Home\ShapePerformance.cshtml"
Write(sw.Elapsed.TotalMilliseconds);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ms\r\n\r\n<br />\r\nSHAPES (Reuse instance)\r\n\r\n");
#nullable restore
#line 114 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Demo\Views\Home\ShapePerformance.cshtml"
  
    buffer = new Microsoft.AspNetCore.Html.HtmlContentBuilder();
    sw.Restart();

    var shape = (await New.Fake()).Value("666");


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 122 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Demo\Views\Home\ShapePerformance.cshtml"
 for (int i = 0; i < iterations; i++)
{
    buffer.AppendHtml(await DisplayAsync(shape));
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 127 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Demo\Views\Home\ShapePerformance.cshtml"
Write(sw.Elapsed.TotalMilliseconds);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ms\r\n\r\n\r\n<br />\r\nSHAPES (Just instantiation)\r\n\r\n");
#nullable restore
#line 133 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Demo\Views\Home\ShapePerformance.cshtml"
  
    buffer = new Microsoft.AspNetCore.Html.HtmlContentBuilder();
    sw.Restart();


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 139 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Demo\Views\Home\ShapePerformance.cshtml"
 for (int i = 0; i < iterations; i++)
{
    shape = (await New.Fake()).Value(i.ToString());
    buffer.AppendHtml("666");
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 145 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Demo\Views\Home\ShapePerformance.cshtml"
Write(sw.Elapsed.TotalMilliseconds);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ms\r\n\r\n<br />\r\nSHAPES (Cached)\r\n\r\n");
#nullable restore
#line 150 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Demo\Views\Home\ShapePerformance.cshtml"
  
    buffer = new Microsoft.AspNetCore.Html.HtmlContentBuilder();
    sw.Restart();


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 156 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Demo\Views\Home\ShapePerformance.cshtml"
 for (int i = 0; i < iterations; i++)
{
    shape = (await New.Fake()).Value(i.ToString());
    shape.Metadata.Cache("fake");

    buffer.AppendHtml(await DisplayAsync(shape));
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 164 "C:\projects\orchard\OrchardCore\src\OrchardCore.Modules\OrchardCore.Demo\Views\Home\ShapePerformance.cshtml"
Write(sw.Elapsed.TotalMilliseconds);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ms\r\n");
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
