#pragma checksum "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41387190b60aa6443b55090a3306c9b02a515e9b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PortalDeviceListPartial), @"mvc.1.0.view", @"/Views/Home/PortalDeviceListPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41387190b60aa6443b55090a3306c9b02a515e9b", @"/Views/Home/PortalDeviceListPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3c9b80973263e36d1a86c8bd2ea5f5ea26ac45f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PortalDeviceListPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
  
    Portal.Controllers.Api.PortalUserController PortalUserController = new Portal.Controllers.Api.PortalUserController();
    List<Entities.Models.PortalUserDevice> portalUserDeviceDashList = new List<Entities.Models.PortalUserDevice>();
    Entities.Models.PortalUser CurrentUser = new Entities.Models.PortalUser();
    CurrentUser = PortalUserController.GetItemByName(User.Identity.Name);
    Portal.Controllers.Api.PortalUserDeviceController portalUserDeviceController = new Portal.Controllers.Api.PortalUserDeviceController();
    portalUserDeviceDashList = portalUserDeviceController.GetItemList(CurrentUser.Id);
    string PanelColor = "White";


#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
 foreach (var item in portalUserDeviceDashList)
{
    if (item.PortalDevice.Active)
    {
        PanelColor = "Green";
    }
    else
    {
        PanelColor = "Red";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<div");
            BeginWriteAttribute("style", " style=\"", 856, "\"", 937, 5);
            WriteAttributeValue("", 864, "margin:20px;background:rgba(255,", 864, 32, true);
            WriteAttributeValue(" ", 896, "255,", 897, 5, true);
            WriteAttributeValue(" ", 901, "255,", 902, 5, true);
            WriteAttributeValue(" ", 906, "0.05);border-color:", 907, 20, true);
#nullable restore
#line 21 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
WriteAttributeValue("", 926, PanelColor, 926, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"col-md-4 panel panel-default-withline\">\r\n\r\n    <div class=\"panel-body\">\r\n        <div class=\"form-group\" onclick=\"window.location.href=\'/PortalUserDevice/Edit?PortalUserDeviceId=1\'\">\r\n            <div><label>");
#nullable restore
#line 25 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
                   Write(item.PortalDevice.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></div>\r\n");
#nullable restore
#line 26 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
             if (item.PortalDevice.Active)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label>Online</label>\r\n");
#nullable restore
#line 29 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label>Offline</label>\r\n");
#nullable restore
#line 33 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 38 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"


}

#line default
#line hidden
#nullable disable
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
