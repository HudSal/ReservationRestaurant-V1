#pragma checksum "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "251a39fb367c53c1534ff620788dae06589efa48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Sitting_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Sitting/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"251a39fb367c53c1534ff620788dae06589efa48", @"/Areas/Admin/Views/Sitting/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf12f7b8690ae81fc5708e64f50692d140680dba", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Sitting_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ReservationRestaurant.Data.Sitting>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ReservationList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Report", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "251a39fb367c53c1534ff620788dae06589efa485781", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<br />\r\n");
#nullable restore
#line 13 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Index.cshtml"
Write(Html.ActionLink("Sort by Name", "Index", new { sortOrder = ViewBag.NameSortParm }, new { @class = " btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Index.cshtml"
Write(Html.ActionLink("Sort by StartDate", "Index", new { sortOrder = ViewBag.DateSortParm }, new { @class = " btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 15 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Index.cshtml"
Write(Html.ActionLink("Sort by SittingType", "Index", new { sortOrder = ViewBag.TypeSortParm }, new { @class = " btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 16 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Index.cshtml"
Write(Html.ActionLink("Sort by IsOpen", "Index", new { sortOrder = ViewBag.BoolSortParm }, new { @class = " btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StartTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EndTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Capacity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 36 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Vacancies));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n         \r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SittingType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IsClosed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 49 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.StartTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EndTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 64 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Capacity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 67 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Vacancies));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n         \r\n            <td>\r\n                ");
#nullable restore
#line 71 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SittingType.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
#nullable restore
#line 73 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Index.cshtml"
             if (item.IsClosed)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>Closed</td>\r\n");
#nullable restore
#line 76 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>Open</td>\r\n");
#nullable restore
#line 80 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "251a39fb367c53c1534ff620788dae06589efa4815642", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 82 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Index.cshtml"
                                         WriteLiteral(item.Id);

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
            WriteLiteral(" ||\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "251a39fb367c53c1534ff620788dae06589efa4817873", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 83 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Index.cshtml"
                                          WriteLiteral(item.Id);

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
            WriteLiteral(" ||\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "251a39fb367c53c1534ff620788dae06589efa4820108", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 84 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Index.cshtml"
                                         WriteLiteral(item.Id);

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
            WriteLiteral(" ||\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "251a39fb367c53c1534ff620788dae06589efa4822341", async() => {
                WriteLiteral("Reservation List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 85 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Index.cshtml"
                                                  WriteLiteral(item.Id);

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
            WriteLiteral("||\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "251a39fb367c53c1534ff620788dae06589efa4824592", async() => {
                WriteLiteral("View Report");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 86 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Index.cshtml"
                                         WriteLiteral(item.Id);

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
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 89 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Areas\Admin\Views\Sitting\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ReservationRestaurant.Data.Sitting>> Html { get; private set; }
    }
}
#pragma warning restore 1591
