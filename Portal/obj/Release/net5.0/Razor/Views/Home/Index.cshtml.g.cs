#pragma checksum "C:\Users\morne\source\repos\Porject\Portal\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ea128308ae7f8ced56375852e75fc8747e5b24f"
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
#nullable restore
#line 1 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ea128308ae7f8ced56375852e75fc8747e5b24f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3c9b80973263e36d1a86c8bd2ea5f5ea26ac45f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""text-center"">
    <div class=""box"">
        <div class=""hour"">
            <div id=""hour""></div>
            <span class=""numberspan"" id=""hourVal"">00</span>
        </div>
        <div class=""minute"">
            <div id=""minute""></div>
            <span class=""numberspan""  id=""minuteVal"">00</span>
        </div>
        <div class=""second"">
            <div id=""second""></div>
            <span class=""numberspan"" id=""secondVal"">00</span>
        </div>
        <div class=""half"">
            <div id=""half""></div>
            <span class=""numberspan"" id=""halfVal"">||</span>
        </div>
    </div>
</div>
<div class=""row"">
");
#nullable restore
#line 24 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\Index.cshtml"
     if (User != null && User.Identity.Name != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"portalUserDeviceDashList\"></div>\r\n");
#nullable restore
#line 26 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ea128308ae7f8ced56375852e75fc8747e5b24f4773", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 859, "~/js/Clock.js?", 859, 14, true);
#nullable restore
#line 30 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 873, Guid.NewGuid().ToString(), 873, 26, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 31 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\Index.cshtml"
 if (User != null && User.Identity.Name != null)
{


#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <script>
        $(document).ready(function () {
           
            LoadPortalUserDevice();
        });
        function DeletePortalUserDevice(PortalUserDeviceId) {
            var ajaxType = ""Get"";
            var ajaxUrl = ""/PortalUserDevice/DeletePortalUserDevice?PortalUserDeviceId="" + PortalUserDeviceId;
             callGenAjax(ajaxType, ajaxUrl, false);
            LoadPortalUserDevice();

        }
        function RestartPortalDevice(PortalDeviceId) {
            var ajaxType = ""Get"";
            var ajaxUrl = ""/PortalDevice/RestartPortalDevice?PortalDeviceId="" + PortalDeviceId;
             callGenAjax(ajaxType, ajaxUrl, false);
            LoadPortalUserDevice();

        }
        function ShutdownPortalDevice(PortalDeviceId) {
            var ajaxType = ""Get"";
            var ajaxUrl = ""/PortalDevice/ShutdownPortalDevice?PortalDeviceId="" + PortalDeviceId;
             callGenAjax(ajaxType, ajaxUrl, false);
            LoadPortalUserDevice();

        }
        f");
            WriteLiteral(@"unction LoadPortalUserDevice() {
            var ajaxType = ""Get"";
            var ajaxUrl = ""/PortalUserDevice/PortalDeviceListPartial/"";
            var result = callGenAjax(ajaxType, ajaxUrl, false);
            $('#portalUserDeviceDashList').html(result);
        }
        setInterval(() => {
            LoadPortalUserDevice();
        }, 5000);

    </script>
");
#nullable restore
#line 71 "C:\Users\morne\source\repos\Porject\Portal\Views\Home\Index.cshtml"
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
