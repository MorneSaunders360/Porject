#pragma checksum "C:\Users\Morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "226152cc84be3c7c745d15787e3f7e79468b6bd4"
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
#line 1 "C:\Users\Morne\source\repos\Porject\Portal\Views\_ViewImports.cshtml"
using Portal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Morne\source\repos\Porject\Portal\Views\_ViewImports.cshtml"
using Portal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"226152cc84be3c7c745d15787e3f7e79468b6bd4", @"/Views/Home/PortalDeviceListPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3c9b80973263e36d1a86c8bd2ea5f5ea26ac45f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PortalDeviceListPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
  
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
#line 14 "C:\Users\Morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
 foreach (var item in PortalNotificationController.GetItemListActivePortal())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
     if (CurrentUser.AllowNotifications)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <script>\r\n            $.notify({\r\n                // options\r\n                message: \'");
#nullable restore
#line 21 "C:\Users\Morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
                     Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - Offline\'\r\n            }, {\r\n                // settings\r\n                type: \'warning\'\r\n            });\r\n\r\n        </script>\r\n");
#nullable restore
#line 28 "C:\Users\Morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
        item.SoftDelete = true;
        PortalNotificationController.SaveItem(item);
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
     

}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n");
#nullable restore
#line 34 "C:\Users\Morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
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
#line 44 "C:\Users\Morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </h3>\r\n                </div>\r\n                <div class=\"card-footer\">\r\n                    <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2204, "\"", 2243, 3);
            WriteAttributeValue("", 2214, "copyToClipboard(\'", 2214, 17, true);
#nullable restore
#line 48 "C:\Users\Morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
WriteAttributeValue("", 2231, item.Name, 2231, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2241, "\')", 2241, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary pull-right\">Copy</button>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 53 "C:\Users\Morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div class=\"row\">\r\n");
#nullable restore
#line 57 "C:\Users\Morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
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
            WriteLiteral("        <div class=\"col-xl-3 col-lg-6 col-md-6 col-sm-6\">\r\n            <div class=\"card card-stats\">\r\n\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 2863, "\"", 2890, 2);
#nullable restore
#line 70 "C:\Users\Morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
WriteAttributeValue("", 2871, PanelColor, 2871, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2882, "pointer", 2883, 8, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"card-icon pointer\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2944, "\"", 3020, 3);
            WriteAttributeValue("", 2954, "location.href=\'/PortalUserDevice/Edit?PortalUserDeviceId=", 2954, 57, true);
#nullable restore
#line 71 "C:\Users\Morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
WriteAttributeValue("", 3011, item.Id, 3011, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3019, "\'", 3019, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <i class=\"material-icons\">cloud</i>\r\n                    </div>\r\n\r\n");
#nullable restore
#line 75 "C:\Users\Morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
                     if (item.PortalDevice.Active)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p class=\"card-category\">Online&nbsp;");
#nullable restore
#line 77 "C:\Users\Morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
                                                        Write(item.PortalDevice.LastActiveTime.ToShortTimeString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 78 "C:\Users\Morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p class=\"card-category\">Offline&nbsp;");
#nullable restore
#line 81 "C:\Users\Morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
                                                         Write(item.PortalDevice.LastActiveTime.ToShortTimeString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 82 "C:\Users\Morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <h3 class=\"card-title\">\r\n                        ");
#nullable restore
#line 86 "C:\Users\Morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
                   Write(item.PortalDevice.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </h3>\r\n                </div>\r\n                <div class=\"card-footer\">\r\n                    <div class=\"stats\">\r\n                        <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3804, "\"", 3946, 12);
            WriteAttributeValue("", 3814, "DisplayMessage(\'Are", 3814, 19, true);
            WriteAttributeValue(" ", 3833, "you", 3834, 4, true);
            WriteAttributeValue(" ", 3837, "sure", 3838, 5, true);
            WriteAttributeValue(" ", 3842, "you", 3843, 4, true);
            WriteAttributeValue(" ", 3846, "want", 3847, 5, true);
            WriteAttributeValue(" ", 3851, "to", 3852, 3, true);
            WriteAttributeValue(" ", 3854, "restart", 3855, 8, true);
            WriteAttributeValue(" ", 3862, ":", 3863, 2, true);
#nullable restore
#line 91 "C:\Users\Morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
WriteAttributeValue(" ", 3864, item.PortalDevice.Name, 3865, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3888, "\',\'Restart\',1,\'RestartPortalDevice(", 3888, 35, true);
#nullable restore
#line 91 "C:\Users\Morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
WriteAttributeValue("", 3923, item.PortalDeviceId, 3923, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3943, ")\')", 3943, 3, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary pull-right\">Restart</button>\r\n                        <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4046, "\"", 4191, 12);
            WriteAttributeValue("", 4056, "DisplayMessage(\'Are", 4056, 19, true);
            WriteAttributeValue(" ", 4075, "you", 4076, 4, true);
            WriteAttributeValue(" ", 4079, "sure", 4080, 5, true);
            WriteAttributeValue(" ", 4084, "you", 4085, 4, true);
            WriteAttributeValue(" ", 4088, "want", 4089, 5, true);
            WriteAttributeValue(" ", 4093, "to", 4094, 3, true);
            WriteAttributeValue(" ", 4096, "shutdown", 4097, 9, true);
            WriteAttributeValue(" ", 4105, ":", 4106, 2, true);
#nullable restore
#line 92 "C:\Users\Morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
WriteAttributeValue(" ", 4107, item.PortalDevice.Name, 4108, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4131, "\',\'Shutdown\',1,\'ShutdownPortalDevice(", 4131, 37, true);
#nullable restore
#line 92 "C:\Users\Morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
WriteAttributeValue("", 4168, item.PortalDeviceId, 4168, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4188, ")\')", 4188, 3, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary pull-right\">Shutdown</button>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 95 "C:\Users\Morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
                  
                    double Power = 0;
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 98 "C:\Users\Morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
                 foreach (var ChildDevice in item.PortalDevice.PortalDeviceChildern)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card-footer\">\r\n                        <div class=\"stats\">\r\n\r\n                            <div><label>");
#nullable restore
#line 103 "C:\Users\Morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
                                   Write(ChildDevice.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;</label><label></label></div>\r\n");
#nullable restore
#line 104 "C:\Users\Morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
                             if (int.Parse(ChildDevice.Temp) > 80)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a style=\"font-size:medium\" class=\"danger-link\">&nbsp;<b>");
#nullable restore
#line 106 "C:\Users\Morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
                                                                                    Write(ChildDevice.Temp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b><span>&#8451;</span></a>\r\n");
#nullable restore
#line 107 "C:\Users\Morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
                            }
                            else if (int.Parse(ChildDevice.Temp) > 60)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a style=\"font-size:medium\" class=\"warning-link\">&nbsp;<b>");
#nullable restore
#line 110 "C:\Users\Morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
                                                                                     Write(ChildDevice.Temp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b><span>&#8451;</span></a>\r\n");
#nullable restore
#line 111 "C:\Users\Morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a style=\"font-size:medium;\" class=\"success-link\">&nbsp;<b>");
#nullable restore
#line 114 "C:\Users\Morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
                                                                                      Write(ChildDevice.Temp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b><span>&#8451;</span></a>\r\n");
#nullable restore
#line 115 "C:\Users\Morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 116 "C:\Users\Morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
                              
                                if (ChildDevice.Power != null)
                                {
                                    Power += double.Parse(ChildDevice.Power);
                                }

                            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n\r\n\r\n\r\n                    </div>\r\n");
#nullable restore
#line 129 "C:\Users\Morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"


                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 132 "C:\Users\Morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
                 if (Power != 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a style=\"font-size:medium;\" class=\"success-link\">&nbsp;<b>");
#nullable restore
#line 134 "C:\Users\Morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
                                                                          Write(Power);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - W</b></a>\r\n");
#nullable restore
#line 135 "C:\Users\Morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 141 "C:\Users\Morne\source\repos\Porject\Portal\Views\Home\PortalDeviceListPartial.cshtml"
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
