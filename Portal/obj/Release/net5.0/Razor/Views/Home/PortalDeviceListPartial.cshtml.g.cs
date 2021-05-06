#pragma checksum "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0164afbac2538a37c838a54f152a5d4ecaa96f33"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0164afbac2538a37c838a54f152a5d4ecaa96f33", @"/Views/Home/PortalDeviceListPartial.cshtml")]
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
    Portal.Controllers.Api.PortalNotificationController PortalNotificationController = new Portal.Controllers.Api.PortalNotificationController();
    portalUserDeviceDashList = portalUserDeviceController.GetItemList(CurrentUser.Id);
    string PanelColor = "White";
    Portal.Controllers.Api.PortalUserOrganizationController portalUserOrganizationController = new Portal.Controllers.Api.PortalUserOrganizationController();
    var OrganizationList = portalUserOrganizationController.GetItemsByPortalUserId(CurrentUser.Id);


#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
 foreach (var item in PortalNotificationController.GetItemListActivePortal())
{

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
 if (CurrentUser.AllowNotifications)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\r\n            $.notify({\r\n                // options\r\n                message: \'");
#nullable restore
#line 21 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
                     Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - Offline\'\r\n            }, {\r\n                // settings\r\n                type: \'warning\'\r\n            });\r\n\r\n</script>\r\n");
#nullable restore
#line 28 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
        item.SoftDelete = true;
        PortalNotificationController.SaveItem(item);
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
     

}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n");
#nullable restore
#line 34 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
     foreach (var item in OrganizationList)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""col-xl-3 col-lg-6 col-md-6 col-sm-6"">
            <div class=""card card-stats"">
                <div class=""card-header card-header-info card-header-icon"">
                    <div class=""card-icon"">
                        <i class=""material-icons"">store</i>
                    </div>
                    <p class=""card-category"">Organization</p>
                    <h3 class=""card-title"">
                        ");
#nullable restore
#line 44 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </h3>\r\n                </div>\r\n                <div class=\"card-footer\">\r\n                    <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2184, "\"", 2223, 3);
            WriteAttributeValue("", 2194, "copyToClipboard(\'", 2194, 17, true);
#nullable restore
#line 48 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
WriteAttributeValue("", 2211, item.Name, 2211, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2221, "\')", 2221, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary pull-right\">Copy</button>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 53 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div class=\"row\">\r\n");
#nullable restore
#line 57 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
     foreach (var item in portalUserDeviceDashList.OrderBy(x => x.PortalDevice.Name))
    {
        if (item.PortalDevice.Active)
        {
            PanelColor = "card-header card-header-success card-header-icon";
        }
        else
        {
            PanelColor = "card-header card-header-danger card-header-icon";
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-xl-3 col-lg-6 col-md-6 col-sm-6\">\r\n        <div class=\"card card-stats\">\r\n\r\n            <div");
            BeginWriteAttribute("class", " class=\"", 2831, "\"", 2858, 2);
#nullable restore
#line 70 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
WriteAttributeValue("", 2839, PanelColor, 2839, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2850, "pointer", 2851, 8, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"card-icon pointer\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2908, "\"", 2984, 3);
            WriteAttributeValue("", 2918, "location.href=\'/PortalUserDevice/Edit?PortalUserDeviceId=", 2918, 57, true);
#nullable restore
#line 71 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
WriteAttributeValue("", 2975, item.Id, 2975, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2983, "\'", 2983, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <i class=\"material-icons\">cloud</i>\r\n                </div>\r\n\r\n");
#nullable restore
#line 75 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
                 if (item.PortalDevice.Active)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"card-category\">Online&nbsp;");
#nullable restore
#line 77 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
                                                    Write(item.PortalDevice.LastActiveTime.ToShortTimeString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 78 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"card-category\">Offline&nbsp;");
#nullable restore
#line 81 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
                                                     Write(item.PortalDevice.LastActiveTime.ToShortTimeString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 82 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <h3 class=\"card-title\">\r\n                    ");
#nullable restore
#line 86 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
               Write(item.PortalDevice.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h3>\r\n            </div>\r\n            <div class=\"card-footer\">\r\n                <div class=\"stats\">\r\n                    <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3700, "\"", 3842, 12);
            WriteAttributeValue("", 3710, "DisplayMessage(\'Are", 3710, 19, true);
            WriteAttributeValue(" ", 3729, "you", 3730, 4, true);
            WriteAttributeValue(" ", 3733, "sure", 3734, 5, true);
            WriteAttributeValue(" ", 3738, "you", 3739, 4, true);
            WriteAttributeValue(" ", 3742, "want", 3743, 5, true);
            WriteAttributeValue(" ", 3747, "to", 3748, 3, true);
            WriteAttributeValue(" ", 3750, "restart", 3751, 8, true);
            WriteAttributeValue(" ", 3758, ":", 3759, 2, true);
#nullable restore
#line 91 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
WriteAttributeValue(" ", 3760, item.PortalDevice.Name, 3761, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3784, "\',\'Restart\',1,\'RestartPortalDevice(", 3784, 35, true);
#nullable restore
#line 91 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
WriteAttributeValue("", 3819, item.PortalDeviceId, 3819, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3839, ")\')", 3839, 3, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary pull-right\">Restart</button>\r\n                    <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3938, "\"", 4083, 12);
            WriteAttributeValue("", 3948, "DisplayMessage(\'Are", 3948, 19, true);
            WriteAttributeValue(" ", 3967, "you", 3968, 4, true);
            WriteAttributeValue(" ", 3971, "sure", 3972, 5, true);
            WriteAttributeValue(" ", 3976, "you", 3977, 4, true);
            WriteAttributeValue(" ", 3980, "want", 3981, 5, true);
            WriteAttributeValue(" ", 3985, "to", 3986, 3, true);
            WriteAttributeValue(" ", 3988, "shutdown", 3989, 9, true);
            WriteAttributeValue(" ", 3997, ":", 3998, 2, true);
#nullable restore
#line 92 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
WriteAttributeValue(" ", 3999, item.PortalDevice.Name, 4000, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4023, "\',\'Shutdown\',1,\'ShutdownPortalDevice(", 4023, 37, true);
#nullable restore
#line 92 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
WriteAttributeValue("", 4060, item.PortalDeviceId, 4060, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4080, ")\')", 4080, 3, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary pull-right\">Shutdown</button>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 95 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
             foreach (var ChildDevice in item.PortalDevice.PortalDeviceChildern)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card-footer\">\r\n                    <div class=\"stats\">\r\n\r\n                        <div><label>");
#nullable restore
#line 100 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
                               Write(ChildDevice.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;</label><label></label></div>\r\n");
#nullable restore
#line 101 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
                         if (int.Parse(ChildDevice.Temp) > 80)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a style=\"font-size:medium\" class=\"danger-link\">&nbsp;<b>");
#nullable restore
#line 103 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
                                                                                Write(ChildDevice.Temp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b><span>&#8451;</span></a>\r\n");
#nullable restore
#line 104 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
                        }
                        else if (int.Parse(ChildDevice.Temp) > 60)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a style=\"font-size:medium\" class=\"warning-link\">&nbsp;<b>");
#nullable restore
#line 107 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
                                                                                 Write(ChildDevice.Temp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b><span>&#8451;</span></a>\r\n");
#nullable restore
#line 108 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a style=\"font-size:medium;\" class=\"success-link\">&nbsp;<b>");
#nullable restore
#line 111 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
                                                                                  Write(ChildDevice.Temp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b><span>&#8451;</span></a>\r\n");
#nullable restore
#line 112 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n                    </div>\r\n\r\n\r\n");
            WriteLiteral("                </div>\r\n");
#nullable restore
#line 123 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 128 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>
<script>
    function copyToClipboard(text) {
        var $temp = $(""<input>"");
        $(""body"").append($temp);
        $temp.val(text).select();
        $.notify({
            // options
            message: text + ' - Copied to clipboard'
        }, {
            // settings
            type: 'info'
        });
        document.execCommand(""copy"");
        $temp.remove();
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
