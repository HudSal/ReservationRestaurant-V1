#pragma checksum "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Report.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3506d9a9225f9d4a9c2fdf79df79d50499436fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Sitting_Report), @"mvc.1.0.view", @"/Areas/Admin/Views/Sitting/Report.cshtml")]
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
#line 1 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\_ViewImports.cshtml"
using ReservationRestaurant;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\_ViewImports.cshtml"
using ReservationRestaurant.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\_ViewImports.cshtml"
using ReservationRestaurant.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3506d9a9225f9d4a9c2fdf79df79d50499436fc", @"/Areas/Admin/Views/Sitting/Report.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf12f7b8690ae81fc5708e64f50692d140680dba", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Sitting_Report : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReservationRestaurant.Areas.Admin.Models.Sitting.Report>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Report.cshtml"
  
    ViewData["Title"] = "Report";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Report</h1>\r\n\r\n<div>\r\n    <h4>Report</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-5\">\r\n            ");
#nullable restore
#line 14 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Report.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-7\">\r\n            ");
#nullable restore
#line 17 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Report.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-5\">\r\n            ");
#nullable restore
#line 20 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Report.cshtml"
       Write(Html.DisplayNameFor(model => model.StartTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-7\">\r\n            ");
#nullable restore
#line 23 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Report.cshtml"
       Write(Html.DisplayFor(model => model.StartTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-5\">\r\n            ");
#nullable restore
#line 26 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Report.cshtml"
       Write(Html.DisplayNameFor(model => model.EndTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-7\">\r\n            ");
#nullable restore
#line 29 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Report.cshtml"
       Write(Html.DisplayFor(model => model.EndTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-5\">\r\n            ");
#nullable restore
#line 32 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Report.cshtml"
       Write(Html.DisplayNameFor(model => model.Capacity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-7\">\r\n            ");
#nullable restore
#line 35 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Report.cshtml"
       Write(Html.DisplayFor(model => model.Capacity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-5\">\r\n            ");
#nullable restore
#line 38 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Report.cshtml"
       Write(Html.DisplayNameFor(model => model.ReservationCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-7\">\r\n            ");
#nullable restore
#line 41 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Report.cshtml"
       Write(Html.DisplayFor(model => model.ReservationCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-5\">\r\n            ");
#nullable restore
#line 44 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Report.cshtml"
       Write(Html.DisplayNameFor(model => model.Vacanies));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-7\">\r\n            ");
#nullable restore
#line 47 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Report.cshtml"
       Write(Html.DisplayFor(model => model.Vacanies));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-5\">\r\n            ");
#nullable restore
#line 50 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Report.cshtml"
       Write(Html.DisplayNameFor(model => model.pax));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-7\">\r\n            ");
#nullable restore
#line 53 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Report.cshtml"
       Write(Html.DisplayFor(model => model.pax));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-5\">\r\n            ");
#nullable restore
#line 56 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Report.cshtml"
       Write(Html.DisplayNameFor(model => model.Tables));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-7\">\r\n            ");
#nullable restore
#line 59 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Report.cshtml"
       Write(Html.DisplayFor(model => model.Tables));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-5\">\r\n            ");
#nullable restore
#line 62 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Report.cshtml"
       Write(Html.DisplayNameFor(model => model.NumberOfPhoneBookings));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-7\">\r\n            ");
#nullable restore
#line 65 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Report.cshtml"
       Write(Html.DisplayFor(model => model.NumberOfPhoneBookings));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-5\">\r\n            ");
#nullable restore
#line 68 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Report.cshtml"
       Write(Html.DisplayNameFor(model => model.NumberOfEmailBookings));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-7\">\r\n            ");
#nullable restore
#line 71 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Report.cshtml"
       Write(Html.DisplayFor(model => model.NumberOfEmailBookings));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-5\">\r\n            ");
#nullable restore
#line 74 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Report.cshtml"
       Write(Html.DisplayNameFor(model => model.NumberOfOnlineBookings));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-7\">\r\n            ");
#nullable restore
#line 77 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Report.cshtml"
       Write(Html.DisplayFor(model => model.NumberOfOnlineBookings));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-5\">\r\n            ");
#nullable restore
#line 80 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Report.cshtml"
       Write(Html.DisplayNameFor(model => model.NumberOfWalkInBookings));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-7\">\r\n            ");
#nullable restore
#line 83 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Report.cshtml"
       Write(Html.DisplayFor(model => model.NumberOfWalkInBookings));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3506d9a9225f9d4a9c2fdf79df79d50499436fc14111", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 88 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Report.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3506d9a9225f9d4a9c2fdf79df79d50499436fc16321", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReservationRestaurant.Areas.Admin.Models.Sitting.Report> Html { get; private set; }
    }
}
#pragma warning restore 1591
