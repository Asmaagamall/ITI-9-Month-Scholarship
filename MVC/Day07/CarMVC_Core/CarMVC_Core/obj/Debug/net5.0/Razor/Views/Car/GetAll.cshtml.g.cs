#pragma checksum "D:\ITI\MVC\Day7\Lab\CarMVC_Core\CarMVC_Core\Views\Car\GetAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94e3fbcf84da2f9850b4d73a8abbf13cef40bb47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Car_GetAll), @"mvc.1.0.view", @"/Views/Car/GetAll.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94e3fbcf84da2f9850b4d73a8abbf13cef40bb47", @"/Views/Car/GetAll.cshtml")]
    #nullable restore
    public class Views_Car_GetAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\ITI\MVC\Day7\Lab\CarMVC_Core\CarMVC_Core\Views\Car\GetAll.cshtml"
  
    ViewBag.Title = "GetAll";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>GetAll</h2>

<a href=""/Car/Create"">Create new car</a>

<div>
    <table>
        <tr>
            <th>Num</th>
            <th>Manfacture</th>
            <th>Model</th>
            <th>Color</th>
            <th>&nbsp;</th>
            <th>&nbsp;</th>
            <th>&nbsp;</th>
        </tr>

");
#nullable restore
#line 22 "D:\ITI\MVC\Day7\Lab\CarMVC_Core\CarMVC_Core\Views\Car\GetAll.cshtml"
         foreach(var item in ViewBag.Cars)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 25 "D:\ITI\MVC\Day7\Lab\CarMVC_Core\CarMVC_Core\Views\Car\GetAll.cshtml"
                   Write(item.Num);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "D:\ITI\MVC\Day7\Lab\CarMVC_Core\CarMVC_Core\Views\Car\GetAll.cshtml"
                   Write(item.Manfacture);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "D:\ITI\MVC\Day7\Lab\CarMVC_Core\CarMVC_Core\Views\Car\GetAll.cshtml"
                   Write(item.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "D:\ITI\MVC\Day7\Lab\CarMVC_Core\CarMVC_Core\Views\Car\GetAll.cshtml"
                   Write(item.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td> <a");
            BeginWriteAttribute("href", " href=\"", 637, "\"", 670, 2);
            WriteAttributeValue("", 644, "/Car/GetCarByNum/", 644, 17, true);
#nullable restore
#line 29 "D:\ITI\MVC\Day7\Lab\CarMVC_Core\CarMVC_Core\Views\Car\GetAll.cshtml"
WriteAttributeValue("", 661, item.Num, 661, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Select Car</a> </td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 720, "\"", 746, 2);
            WriteAttributeValue("", 727, "/Car/Edit/", 727, 10, true);
#nullable restore
#line 30 "D:\ITI\MVC\Day7\Lab\CarMVC_Core\CarMVC_Core\Views\Car\GetAll.cshtml"
WriteAttributeValue("", 737, item.Num, 737, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit Car</a></td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 793, "\"", 824, 2);
            WriteAttributeValue("", 800, "/Car/DeleteCar/", 800, 15, true);
#nullable restore
#line 31 "D:\ITI\MVC\Day7\Lab\CarMVC_Core\CarMVC_Core\Views\Car\GetAll.cshtml"
WriteAttributeValue("", 815, item.Num, 815, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete Car</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 33 "D:\ITI\MVC\Day7\Lab\CarMVC_Core\CarMVC_Core\Views\Car\GetAll.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
