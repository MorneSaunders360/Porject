#pragma checksum "C:\Users\morne\source\repos\Porject\Portal\Views\PortalUserDevice\IndexGrid.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c336645faa136478d5a9a8093f4e58eeb511e9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PortalUserDevice_IndexGrid), @"mvc.1.0.view", @"/Views/PortalUserDevice/IndexGrid.cshtml")]
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
#line 1 "C:\Users\morne\source\repos\Porject\Portal\Views\_ViewImports.cshtml"
using Portal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\morne\source\repos\Porject\Portal\Views\_ViewImports.cshtml"
using Portal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c336645faa136478d5a9a8093f4e58eeb511e9d", @"/Views/PortalUserDevice/IndexGrid.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3c9b80973263e36d1a86c8bd2ea5f5ea26ac45f", @"/Views/_ViewImports.cshtml")]
    public class Views_PortalUserDevice_IndexGrid : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\morne\source\repos\Porject\Portal\Views\PortalUserDevice\IndexGrid.cshtml"
  
    Portal.Controllers.Api.PortalUserController PortalUserController = new Portal.Controllers.Api.PortalUserController();
    List<Entities.Models.PortalUserDevice> portalUserDeviceDashList = new List<Entities.Models.PortalUserDevice>();
    Entities.Models.PortalUser CurrentUser = new Entities.Models.PortalUser();
    CurrentUser = PortalUserController.GetItemByName(User.Identity.Name);
    Portal.Controllers.Api.PortalUserDeviceController portalUserDeviceController = new Portal.Controllers.Api.PortalUserDeviceController();
    portalUserDeviceDashList = portalUserDeviceController.GetItemList(CurrentUser.Id).Where(x => x.SoftDelete == false).ToList();


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card"">
                <div class=""card-header card-header-primary"">
                    <h4 class=""card-title "">User Device</h4>
                    <p class=""card-category""> Here is a subtitle for this table</p>
                </div>
                <div class=""card-body"">
                    <div class=""table-responsive"">
                        <table class=""table"">
                            <thead class="" text-primary"">
                                <tr>
                                    <th>Commands</th>
                                    <th>Name</th>
                                    <th>Description</th>
                                    <th>Status</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 31 "C:\Users\morne\source\repos\Porject\Portal\Views\PortalUserDevice\IndexGrid.cshtml"
                                 foreach (var item in portalUserDeviceDashList)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <tr>
                                        <td>
                                            <div>
                                                <div style=""width:35px;height:35px;display:inline-block;font-size: 20px;"" class=""pointer""");
            BeginWriteAttribute("onclick", " onclick=\"", 1991, "\"", 2067, 3);
            WriteAttributeValue("", 2001, "location.href=\'/PortalUserDevice/Edit?PortalUserDeviceId=", 2001, 57, true);
#nullable restore
#line 36 "C:\Users\morne\source\repos\Porject\Portal\Views\PortalUserDevice\IndexGrid.cshtml"
WriteAttributeValue("", 2058, item.Id, 2058, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2066, "\'", 2066, 1, true);
            EndWriteAttribute();
            WriteLiteral("><a class=\"fas fa-edit\"></a></div>\r\n                                                <div style=\"width: 35px; height: 35px; display: inline-block; font-size: 20px;\" class=\"pointer\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2247, "\"", 2379, 12);
            WriteAttributeValue(" ", 2257, "DisplayMessage(\'Are", 2258, 20, true);
            WriteAttributeValue(" ", 2277, "you", 2278, 4, true);
            WriteAttributeValue(" ", 2281, "sure", 2282, 5, true);
            WriteAttributeValue(" ", 2286, "you", 2287, 4, true);
            WriteAttributeValue(" ", 2290, "want", 2291, 5, true);
            WriteAttributeValue(" ", 2295, "to", 2296, 3, true);
            WriteAttributeValue(" ", 2298, "delete", 2299, 7, true);
            WriteAttributeValue(" ", 2305, ":", 2306, 2, true);
#nullable restore
#line 37 "C:\Users\morne\source\repos\Porject\Portal\Views\PortalUserDevice\IndexGrid.cshtml"
WriteAttributeValue(" ", 2307, item.PortalDevice.Name, 2308, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2331, "\',\'Delete\',1,\'DeletePortalUserDevice(", 2331, 37, true);
#nullable restore
#line 37 "C:\Users\morne\source\repos\Porject\Portal\Views\PortalUserDevice\IndexGrid.cshtml"
WriteAttributeValue("", 2368, item.Id, 2368, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2376, ")\')", 2376, 3, true);
            EndWriteAttribute();
            WriteLiteral("><a class=\"fas fa-trash-alt\"></a></div>\r\n                                            </div>\r\n                                        </td>\r\n                                        <td>");
#nullable restore
#line 40 "C:\Users\morne\source\repos\Porject\Portal\Views\PortalUserDevice\IndexGrid.cshtml"
                                       Write(item.PortalDevice.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 41 "C:\Users\morne\source\repos\Porject\Portal\Views\PortalUserDevice\IndexGrid.cshtml"
                                       Write(item.PortalDevice.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 42 "C:\Users\morne\source\repos\Porject\Portal\Views\PortalUserDevice\IndexGrid.cshtml"
                                         if (item.PortalDevice.Active)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td>Online</td>\r\n");
#nullable restore
#line 45 "C:\Users\morne\source\repos\Porject\Portal\Views\PortalUserDevice\IndexGrid.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td>Offline</td>\r\n");
#nullable restore
#line 49 "C:\Users\morne\source\repos\Porject\Portal\Views\PortalUserDevice\IndexGrid.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </tr>\r\n");
#nullable restore
#line 51 "C:\Users\morne\source\repos\Porject\Portal\Views\PortalUserDevice\IndexGrid.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>

    </div>
</div>


<script>

    function DeletePortalUserDevice(PortalUserDeviceId) {
        var ajaxType = ""Get"";
        var ajaxUrl = ""/PortalUserDevice/DeletePortalUserDevice?PortalUserDeviceId="" + PortalUserDeviceId;
        callGenAjax(ajaxType, ajaxUrl, false);

    }
</script>");
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
