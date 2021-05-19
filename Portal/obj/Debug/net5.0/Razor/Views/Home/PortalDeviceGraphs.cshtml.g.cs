#pragma checksum "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceGraphs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c6d24417db2cc6b07b513e8f5c3962b72d24ff6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PortalDeviceGraphs), @"mvc.1.0.view", @"/Views/Home/PortalDeviceGraphs.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c6d24417db2cc6b07b513e8f5c3962b72d24ff6", @"/Views/Home/PortalDeviceGraphs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3c9b80973263e36d1a86c8bd2ea5f5ea26ac45f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PortalDeviceGraphs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceGraphs.cshtml"
  
    Portal.Controllers.Api.PortalUserController PortalUserController = new Portal.Controllers.Api.PortalUserController();
    List<Entities.Models.PortalUserDevice> portalUserDeviceDashList = new List<Entities.Models.PortalUserDevice>();
    Entities.Models.PortalUser CurrentUser = new Entities.Models.PortalUser();
    CurrentUser = PortalUserController.GetItemByName(User.Identity.Name);
    Portal.Controllers.Api.PortalUserDeviceController portalUserDeviceController = new Portal.Controllers.Api.PortalUserDeviceController();
    portalUserDeviceDashList = portalUserDeviceController.GetItemList(CurrentUser.Id);
    Portal.Controllers.Api.PortalDeviceUsageController PortalDeviceUsageController = new Portal.Controllers.Api.PortalDeviceUsageController();



#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n");
#nullable restore
#line 14 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceGraphs.cshtml"
     foreach (var item in portalUserDeviceDashList.OrderBy(x => x.PortalDevice.Name))
    {
        List<string> DeviceNamesList = new List<string>();
        List<string> TempsList = new List<string>();
        string res = "dailySalesChart" + @item.Id;
        string DeviceLastActiveDiv = "DeviceLastActiveDiv" + @item.Id;
        foreach (var itesm in item.PortalDevice.PortalDeviceChildern)
        {
            TempsList.Add(string.Join(",", PortalDeviceUsageController.GetItemByPortalDeviceId(itesm.Id).Select(x => x.Temps).ToArray().Reverse()));
            TempsList = TempsList.Where(s => !string.IsNullOrWhiteSpace(s)).Distinct().ToList();
            DeviceNamesList.Add(itesm.Name);
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n");
#nullable restore
#line 27 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceGraphs.cshtml"
              
                string temp = "";
                string DeviceNames = "";
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        $(\'#");
#nullable restore
#line 31 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceGraphs.cshtml"
       Write(DeviceLastActiveDiv);

#line default
#line hidden
#nullable disable
            WriteLiteral("\').html(\'Updated ");
#nullable restore
#line 31 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceGraphs.cshtml"
                                            Write(item.PortalDevice.LastActiveTime.AddHours(2).ToShortTimeString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" on ");
#nullable restore
#line 31 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceGraphs.cshtml"
                                                                                                                 Write(item.PortalDevice.LastActiveTime.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\');\r\n\r\n\r\n");
#nullable restore
#line 34 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceGraphs.cshtml"
     foreach (var items in TempsList)
    {
        temp += "["+ @items + "],";

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceGraphs.cshtml"
         foreach (var items in DeviceNamesList)
    {
        DeviceNames += "["+ @items + "],";

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        if ($(\'#");
#nullable restore
#line 45 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceGraphs.cshtml"
           Write(res);

#line default
#line hidden
#nullable disable
            WriteLiteral("\').length != 0) {\r\n\r\n       var chart= new Chartist.Line(\'#");
#nullable restore
#line 47 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceGraphs.cshtml"
                                 Write(res);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', {\r\n                labels: [1, 2, 3, 4, 5, 6, 7, 8, 9, 10],\r\n                series: [\r\n                            ");
#nullable restore
#line 50 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceGraphs.cshtml"
                       Write(temp);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        ]
            },
           {
                fullWidth: true,
                chartPadding: {
                    right: 40
                },
                plugins: [
                    Chartist.plugins.legend({
                        legendNames: [{ name: 'Red-ish', series: [0] }, { name: 'Yellow', series: [1] }],
                    }),
                    Chartist.plugins.ctPointLabels({
                        textAnchor: 'middle'
                    }),
                ]
            });

        }

    </script>
");
#nullable restore
#line 71 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceGraphs.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n</div>\r\n");
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
