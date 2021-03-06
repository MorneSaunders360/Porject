#pragma checksum "C:\Users\morne\Source\Repos\Projects\Portal\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dca3196bccb3fa55ef3d435298e04823273b1f54"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\morne\Source\Repos\Projects\Portal\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dca3196bccb3fa55ef3d435298e04823273b1f54", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3c9b80973263e36d1a86c8bd2ea5f5ea26ac45f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\morne\Source\Repos\Projects\Portal\Views\Home\Index.cshtml"
  
    Portal.Controllers.Api.PortalUserController PortalUserController = new Portal.Controllers.Api.PortalUserController();
    Portal.Controllers.Api.PortalDeviceCommandController PortalDeviceCommandController = new Portal.Controllers.Api.PortalDeviceCommandController();
    List<Entities.Models.PortalUserDevice> portalUserDeviceDashList = new List<Entities.Models.PortalUserDevice>();
    if (User != null && User.Identity.Name != null)
    {
        var CurrentUser = PortalUserController.GetItemByName(User.Identity.Name);
        Portal.Controllers.Api.PortalUserDeviceController portalUserDeviceController = new Portal.Controllers.Api.PortalUserDeviceController();
        portalUserDeviceDashList = portalUserDeviceController.GetItemList(CurrentUser.PortalUserId);
    }


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">

        <div id=""timedate"" >
            <a id=""mon"">January</a>
            <a id=""d"">1</a>,
            <a id=""y"">0</a><br />
            <a id=""h"">12</a> :
            <a id=""m"">00</a>:
            <a id=""s"">00</a>
        </div>

</div>
<div class=""row"">
");
#nullable restore
#line 28 "C:\Users\morne\Source\Repos\Projects\Portal\Views\Home\Index.cshtml"
     foreach (var item in portalUserDeviceDashList.Where(x=>x.PortalDevice.PortalDeviceStatusId==1))
    {
        foreach (var PortalDeviceCommand in PortalDeviceCommandController.GetPortalDeviceCommandByPortalDeviceId(item.PortalDeviceId))
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-4 col-xs-10 panel panel-default-withline\" style=\"margin: 10px;\">\r\n                <div class=\"panel-body\">\r\n                    <div class=\"form-group\">\r\n                        <a style=\" margin-left: 98%\"");
            BeginWriteAttribute("href", " href=\"", 1630, "\"", 1702, 2);
            WriteAttributeValue("", 1637, "PortalUserDevice/Edit?PortalUserDeviceId=", 1637, 41, true);
#nullable restore
#line 36 "C:\Users\morne\Source\Repos\Projects\Portal\Views\Home\Index.cshtml"
WriteAttributeValue("", 1678, item.PortalUserDeviceId, 1678, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label class=\"control-label\" style=\"font-size: 20px;margin-right: 20px;color: darkred;\">");
#nullable restore
#line 39 "C:\Users\morne\Source\Repos\Projects\Portal\Views\Home\Index.cshtml"
                                                                                                           Write(item.PortalDevice.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 39 "C:\Users\morne\Source\Repos\Projects\Portal\Views\Home\Index.cshtml"
                                                                                                                                     Write(PortalDeviceCommand.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <label class=\"switch\" style=\"float: right;margin-top: -4px;\">\r\n");
#nullable restore
#line 41 "C:\Users\morne\Source\Repos\Projects\Portal\Views\Home\Index.cshtml"
                               bool Status = Convert.ToBoolean(PortalDeviceCommand.Status); 

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <input type=\"checkbox\"");
            BeginWriteAttribute("checked", " checked=\"", 2193, "\"", 2210, 1);
#nullable restore
#line 42 "C:\Users\morne\Source\Repos\Projects\Portal\Views\Home\Index.cshtml"
WriteAttributeValue("", 2203, Status, 2203, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 2211, "\"", 2267, 2);
            WriteAttributeValue("", 2216, "checkbox_", 2216, 9, true);
#nullable restore
#line 42 "C:\Users\morne\Source\Repos\Projects\Portal\Views\Home\Index.cshtml"
WriteAttributeValue("", 2225, PortalDeviceCommand.PortalDeviceCommandId, 2225, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 2268, "\"", 2398, 6);
            WriteAttributeValue("", 2278, "UpdateDeviceStatus(\'", 2278, 20, true);
#nullable restore
#line 42 "C:\Users\morne\Source\Repos\Projects\Portal\Views\Home\Index.cshtml"
WriteAttributeValue("", 2298, PortalDeviceCommand.PortalDeviceCommandId, 2298, 42, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2340, "\',", 2340, 2, true);
            WriteAttributeValue(" ", 2342, "$(this).prop(\'checked\'),", 2343, 25, true);
#nullable restore
#line 42 "C:\Users\morne\Source\Repos\Projects\Portal\Views\Home\Index.cshtml"
WriteAttributeValue("", 2367, PortalDeviceCommand.PinOutput, 2367, 30, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2397, ")", 2397, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <span class=\"slider round\"></span>\r\n                        </label>\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 49 "C:\Users\morne\Source\Repos\Projects\Portal\Views\Home\Index.cshtml"




        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>


<script>

    function UpdateDeviceStatus(PortalDeviceCommandId, status, PinOutput) {
        if (status) {
            status = 1;
        }
        else {
            status = 0;
        }
            var ajaxType = ""Get"";
        var ajaxUrl = ""/PortalDeviceCommand/SetDeviceStatus?PortalDeviceCommandId="" + PortalDeviceCommandId + ""&status="" + status + ""&PinOutput="" + PinOutput;
            var ajaxInputData = """";
            callAjax(ajaxType, ajaxUrl, ajaxInputData,true);
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
