#pragma checksum "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d3a3d743e1538f34204f8d46caf170d12722ab3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Sitting_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Sitting/Details.cshtml")]
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
#line 1 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\_ViewImports.cshtml"
using ReservationRestaurant;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\_ViewImports.cshtml"
using ReservationRestaurant.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\_ViewImports.cshtml"
using ReservationRestaurant.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d3a3d743e1538f34204f8d46caf170d12722ab3", @"/Areas/Admin/Views/Sitting/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf12f7b8690ae81fc5708e64f50692d140680dba", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Sitting_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReservationRestaurant.Data.Sitting>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Sitting</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StartTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Details.cshtml"
       Write(Html.DisplayFor(model => model.StartTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EndTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Details.cshtml"
       Write(Html.DisplayFor(model => model.EndTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Capacity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Details.cshtml"
       Write(Html.DisplayFor(model => model.Capacity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 38 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Vacancies));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Details.cshtml"
       Write(Html.DisplayFor(model => model.Vacancies));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Pax));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pax));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Restaurant));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Details.cshtml"
       Write(Html.DisplayFor(model => model.Restaurant.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SittingType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Details.cshtml"
       Write(Html.DisplayFor(model => model.SittingType.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsClosed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsClosed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d3a3d743e1538f34204f8d46caf170d12722ab311575", async() => {
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
#line 70 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Details.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d3a3d743e1538f34204f8d46caf170d12722ab313784", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReservationRestaurant.Data.Sitting> Html { get; private set; }
    }
}
#pragma warning restore 1591
