#pragma checksum "C:\Users\morne\source\repos\Porject\Portal\Views\PortalDeviceUsage\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b921070d4685bf7d5662fe9933984f93ca1792d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PortalDeviceUsage_Index), @"mvc.1.0.view", @"/Views/PortalDeviceUsage/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b921070d4685bf7d5662fe9933984f93ca1792d", @"/Views/PortalDeviceUsage/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3c9b80973263e36d1a86c8bd2ea5f5ea26ac45f", @"/Views/_ViewImports.cshtml")]
    public class Views_PortalDeviceUsage_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""col-md-12"">
    <div class=""card"">
        <div class=""card-header card-header-primary"">
            <h4 class=""card-title"">Temps</h4>
            <p class=""card-category"">Device Temps</p>
        </div>
        <div class=""card-body"">
            ");
#nullable restore
#line 10 "C:\Users\morne\source\repos\Porject\Portal\Views\PortalDeviceUsage\Index.cshtml"
       Write(Html.Partial("~/Views/Home/PortalDeviceGraphsDiv.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

        </div>
    </div>
</div>

<div id=""PortalDeviceGraphsId""></div>
<script>
    $(document).ready(function () {
  
        LoadPortalDeviceGraphs();
    });


    function LoadPortalDeviceGraphs() {
        var ajaxType = ""Get"";
        var ajaxUrl = ""/PortalUserDevice/PortalDeviceGraphsPartial"";
        var result = callGenAjax(ajaxType, ajaxUrl, false);
        $('#PortalDeviceGraphsId').html(result);
    }

    setInterval(() => {
        LoadPortalDeviceGraphs();
    }, 60000);

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
