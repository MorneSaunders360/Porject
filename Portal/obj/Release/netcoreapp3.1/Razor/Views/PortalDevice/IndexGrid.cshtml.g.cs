#pragma checksum "C:\Users\morne\Source\Repos\Projects\Portal\Views\PortalDevice\IndexGrid.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51e836276d743791462b2b62a476fbc6a88a6505"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PortalDevice_IndexGrid), @"mvc.1.0.view", @"/Views/PortalDevice/IndexGrid.cshtml")]
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
#line 1 "C:\Users\morne\Source\Repos\Projects\Portal\Views\_ViewImports.cshtml"
using Portal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\morne\Source\Repos\Projects\Portal\Views\_ViewImports.cshtml"
using Portal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51e836276d743791462b2b62a476fbc6a88a6505", @"/Views/PortalDevice/IndexGrid.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3c9b80973263e36d1a86c8bd2ea5f5ea26ac45f", @"/Views/_ViewImports.cshtml")]
    public class Views_PortalDevice_IndexGrid : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Entities.Models.PortalDevice>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container-fluid"" id=""container"">
    <div class=""panel panel-default-withline"">
        <div class=""panel-body"">

            <table id=""example"" class=""mdl-data-table responsive no-wrap"" style=""width:100%"">
                <thead>
                    <tr>
                        <th>Commands</th>
                        <th>Name</th>
                        <th>Description</th>
                        <th>DeviceId</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 17 "C:\Users\morne\Source\Repos\Projects\Portal\Views\PortalDevice\IndexGrid.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td><a class=\"btn-command\"");
            BeginWriteAttribute("onclick", " onclick=\"", 727, "\"", 775, 3);
            WriteAttributeValue("", 737, "EditPortalDevice(", 737, 17, true);
#nullable restore
#line 20 "C:\Users\morne\Source\Repos\Projects\Portal\Views\PortalDevice\IndexGrid.cshtml"
WriteAttributeValue("", 754, item.PortalDeviceId, 754, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 774, ")", 774, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Edit</a> </td>\r\n                            <td>");
#nullable restore
#line 21 "C:\Users\morne\Source\Repos\Projects\Portal\Views\PortalDevice\IndexGrid.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 22 "C:\Users\morne\Source\Repos\Projects\Portal\Views\PortalDevice\IndexGrid.cshtml"
                           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 23 "C:\Users\morne\Source\Repos\Projects\Portal\Views\PortalDevice\IndexGrid.cshtml"
                           Write(item.DeviceGIUD);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 25 "C:\Users\morne\Source\Repos\Projects\Portal\Views\PortalDevice\IndexGrid.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Entities.Models.PortalDevice>> Html { get; private set; }
    }
}
#pragma warning restore 1591
