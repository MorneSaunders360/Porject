#pragma checksum "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceGraphs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bd2e8b042a8126e8527b9fec6519e43b69f8ad9"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bd2e8b042a8126e8527b9fec6519e43b69f8ad9", @"/Views/Home/PortalDeviceGraphs.cshtml")]
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
        List<Entities.Models.PortalDeviceUsage> PortalDeviceUsageList = new List<Entities.Models.PortalDeviceUsage>();
        string res = "dailySalesChart" + @item.Id;
        string ress = "dailySalesChartPower" + @item.Id;
        string DeviceLastActiveDiv = "DeviceLastActiveDiv" + @item.Id;
        string DeviceChartPower = "DeviceChartPower" + @item.Id;
        foreach (var itesm in item.PortalDevice.PortalDeviceChildern)
        {
            var r = PortalDeviceUsageController.GetItemByPortalDeviceId(itesm.Id);
            var rs = string.Join(",", r.Select(x => x.Power == null | x.Power == "" ? "0" : x.Power).ToArray().Reverse());
            if (rs.Contains("0,0,0,0,0,0,0,0,0,0"))
            {
                rs = "";
            }
            PortalDeviceUsageList.Add(new Entities.Models.PortalDeviceUsage { Power = rs.ToString(), Temps = string.Join(",", r.Select(x => x.Temps).ToArray().Reverse()), PortalDevice = new Entities.Models.PortalDevice { Name = itesm.Name }, WhenCreatedList = r.Select(x => x.WhenCreated).ToList() });

        }


#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n\r\n");
#nullable restore
#line 35 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceGraphs.cshtml"
              
                string tempname = "";
                string temp = "";
                string power = "";
                string Date = "";

            

#line default
#line hidden
#nullable disable
            WriteLiteral("        $(\'#");
#nullable restore
#line 42 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceGraphs.cshtml"
       Write(DeviceLastActiveDiv);

#line default
#line hidden
#nullable disable
            WriteLiteral("\').html(\'Updated ");
#nullable restore
#line 42 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceGraphs.cshtml"
                                            Write(item.PortalDevice.LastActiveTime.AddHours(2).ToShortTimeString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" on ");
#nullable restore
#line 42 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceGraphs.cshtml"
                                                                                                                 Write(item.PortalDevice.LastActiveTime.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\');\r\n\r\n\r\n\r\n");
#nullable restore
#line 46 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceGraphs.cshtml"
     foreach (var items in PortalDeviceUsageList)
    {
        if (string.IsNullOrEmpty(Date))
        {
            Date += string.Join(",", items.WhenCreatedList.Select(x => x.AddHours(2).ToString("HH:mm")).ToArray().Reverse()) + ",";
        }

        tempname += items.PortalDevice.Name + ",";
        temp += "[" + items.Temps + "],";
        power += "[" + items.Power+ "],";
    
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("        if (\'");
#nullable restore
#line 58 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceGraphs.cshtml"
        Write(power);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'.length<10) {\r\n            $(\'#");
#nullable restore
#line 59 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceGraphs.cshtml"
           Write(DeviceChartPower);

#line default
#line hidden
#nullable disable
            WriteLiteral("\').css(\'display\',\'none\');\r\n        }\r\n\r\n            var str = \'");
#nullable restore
#line 62 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceGraphs.cshtml"
                  Write(tempname);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
            str = str.substring(0, str.length - 1);

            var entryArray = str.split("","");
            var entryArrayNew = [];
            entryArray.forEach(function (entry) {
                var arr = [entry];
                entryArrayNew.push(arr);
            });
            entryArrayNew.reverse();

             var str1 = '");
#nullable restore
#line 73 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceGraphs.cshtml"
                    Write(Date);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
                str1 = str1.substring(0, str1.length - 1);

                var entryArray1 = str1.split("","");
                var entryArrayNew1 = [];
                entryArray1.forEach(function (entry) {
                    var arr = [entry];
                    entryArrayNew1.push(arr);
                });



        var chart;
        if ($('#");
#nullable restore
#line 86 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceGraphs.cshtml"
           Write(res);

#line default
#line hidden
#nullable disable
            WriteLiteral("\').length != 0) {\r\n\r\n            chart = new Chartist.Line(\'#");
#nullable restore
#line 88 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceGraphs.cshtml"
                                   Write(res);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', {\r\n                labels: entryArrayNew1,\r\n                series: [");
#nullable restore
#line 90 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceGraphs.cshtml"
                    Write(temp);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"]
            },
           {
                fullWidth: true,
                chartPadding: {
                    right: 40
                },
                plugins: [
                    Chartist.plugins.legend({
                        legendNames: entryArrayNew,
                    }),
                    Chartist.plugins.ctPointLabels({
                        textAnchor: 'middle'
                    }),
                ]
            });
        }

        if ('");
#nullable restore
#line 108 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceGraphs.cshtml"
        Write(power.Split(",").All(x=>x=="[]"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\'==\'False\') {\r\n              var chart1;\r\n                if ($(\'#");
#nullable restore
#line 110 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceGraphs.cshtml"
                   Write(ress);

#line default
#line hidden
#nullable disable
            WriteLiteral("\').length != 0) {\r\n\r\n                    chart1 = new Chartist.Line(\'#");
#nullable restore
#line 112 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceGraphs.cshtml"
                                            Write(ress);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', {\r\n                        labels: entryArrayNew1,\r\n                        series: [");
#nullable restore
#line 114 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceGraphs.cshtml"
                            Write(power);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"]
                    },
                   {
                       fullWidth: true,
                        chartPadding: {
                            right: 40
                        },
                        plugins: [
                            Chartist.plugins.legend({
                                legendNames: entryArrayNew,
                            }),
                            Chartist.plugins.ctPointLabels({
                                textAnchor: 'middle'
                            }),
                        ]
                    });

                }
        }
        else {
            console.log('#");
#nullable restore
#line 134 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceGraphs.cshtml"
                     Write(ress);

#line default
#line hidden
#nullable disable
            WriteLiteral("\')\r\n        }\r\n\r\n\r\n\r\n    </script>\r\n");
#nullable restore
#line 140 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\PortalDeviceGraphs.cshtml"
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
