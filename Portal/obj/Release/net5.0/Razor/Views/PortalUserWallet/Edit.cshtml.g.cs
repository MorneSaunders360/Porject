#pragma checksum "C:\Users\morne\source\repos\Porject\Portal\Views\PortalUserWallet\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd3faa6f21d81b444007017265eefc1553bbabf5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PortalUserWallet_Edit), @"mvc.1.0.view", @"/Views/PortalUserWallet/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd3faa6f21d81b444007017265eefc1553bbabf5", @"/Views/PortalUserWallet/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3c9b80973263e36d1a86c8bd2ea5f5ea26ac45f", @"/Views/_ViewImports.cshtml")]
    public class Views_PortalUserWallet_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities.Models.PortalUserWallet>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\morne\source\repos\Porject\Portal\Views\PortalUserWallet\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Portal.Controllers.Api.PortalUserController PortalUserController = new Portal.Controllers.Api.PortalUserController();

    Entities.Models.PortalUser CurrentUser = new Entities.Models.PortalUser();
    CurrentUser = PortalUserController.GetItemByName(User.Identity.Name);
    Model.PortalUserId = CurrentUser.Id;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-8\">\r\n        <div class=\"card\">\r\n            <div class=\"card-header card-header-primary\">\r\n                <h4 class=\"card-title\">");
#nullable restore
#line 14 "C:\Users\morne\source\repos\Porject\Portal\Views\PortalUserWallet\Edit.cshtml"
                                  Write(Model.PortalWallet.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <p class=\"card-category\">Edit your Wallet</p>\r\n            </div>\r\n            <div class=\"card-body\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd3faa6f21d81b444007017265eefc1553bbabf55170", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 18 "C:\Users\morne\source\repos\Porject\Portal\Views\PortalUserWallet\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd3faa6f21d81b444007017265eefc1553bbabf56791", async() => {
                WriteLiteral("\r\n                    ");
#nullable restore
#line 20 "C:\Users\morne\source\repos\Porject\Portal\Views\PortalUserWallet\Edit.cshtml"
               Write(Html.HiddenFor(x => x.PortalWalletId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 21 "C:\Users\morne\source\repos\Porject\Portal\Views\PortalUserWallet\Edit.cshtml"
               Write(Html.HiddenFor(x => x.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 22 "C:\Users\morne\source\repos\Porject\Portal\Views\PortalUserWallet\Edit.cshtml"
               Write(Html.HiddenFor(x => x.PortalUserId));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                    <div class=""row"">
                        <div class=""col-md-5"">
                            <div class=""form-group bmd-form-group"">
                                <label class=""bmd-label-floating"">Name</label>
                                ");
#nullable restore
#line 28 "C:\Users\morne\source\repos\Porject\Portal\Views\PortalUserWallet\Edit.cshtml"
                           Write(Html.TextBoxFor(m => m.PortalWallet.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-5"">
                            <div class=""form-group bmd-form-group"">
                                <label class=""bmd-label-floating"">Secret</label>
                                ");
#nullable restore
#line 36 "C:\Users\morne\source\repos\Porject\Portal\Views\PortalUserWallet\Edit.cshtml"
                           Write(Html.TextBoxFor(m => m.PortalWallet.Secret, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-5"">
                            <div class=""form-group bmd-form-group"">
                                <label class=""bmd-label-floating"">Access Key</label>
                                ");
#nullable restore
#line 44 "C:\Users\morne\source\repos\Porject\Portal\Views\PortalUserWallet\Edit.cshtml"
                           Write(Html.TextBoxFor(m => m.PortalWallet.AccessKey, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-5"">
                            <div class=""form-group bmd-form-group"">
                                <label class=""bmd-label-floating"">Password</label>
                                ");
#nullable restore
#line 52 "C:\Users\morne\source\repos\Porject\Portal\Views\PortalUserWallet\Edit.cshtml"
                           Write(Html.TextBoxFor(m => m.PortalWallet.Password, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                    <button type=""submit"" class=""btn btn-primary pull-right"">Save</button>
                    <div class=""clearfix""></div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n\r\n\r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 73 "C:\Users\morne\source\repos\Porject\Portal\Views\PortalUserWallet\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entities.Models.PortalUserWallet> Html { get; private set; }
    }
}
#pragma warning restore 1591
