#pragma checksum "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "210c9b36d74a0a845d74b87350abb860c1dffbc4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservation_Index), @"mvc.1.0.view", @"/Views/Reservation/Index.cshtml")]
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
#line 1 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Views\_ViewImports.cshtml"
using ReservationRestaurant;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Views\_ViewImports.cshtml"
using ReservationRestaurant.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"210c9b36d74a0a845d74b87350abb860c1dffbc4", @"/Views/Reservation/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea6782be1d593d9f5cbc6c344dd744601e61ed2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Reservation_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ReservationRestaurant.Data.Reservation>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PreCreate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index -- Reservations List</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "210c9b36d74a0a845d74b87350abb860c1dffbc45734", async() => {
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
            WriteLiteral("\r\n</p>\r\n<div class=\"card bg-transparent\">\r\n    <div class=\"card-body\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "210c9b36d74a0a845d74b87350abb860c1dffbc46981", async() => {
                WriteLiteral("\r\n\r\n            <div class=\"form-actions no-color\">\r\n                <p>\r\n                    Search Option:\r\n                    ");
#nullable restore
#line 19 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
               Write(Html.RadioButton("option", "ReservationId"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" <text> Reservation Id </text>\r\n                    <span> </span>\r\n                    ");
#nullable restore
#line 21 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
               Write(Html.RadioButton("option", "Email"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" <text>  Email </text>\r\n                    <span> </span>\r\n                    ");
#nullable restore
#line 23 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
               Write(Html.RadioButton("option", "Name"));

#line default
#line hidden
#nullable disable
                WriteLiteral("<text> Last Name</text>\r\n                    <br />\r\n                    <input type=\"text\" name=\"SearchString\"");
                BeginWriteAttribute("value", " value=\"", 835, "\"", 869, 1);
#nullable restore
#line 25 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
WriteAttributeValue("", 843, ViewData["CurrentFilter"], 843, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input type=\"submit\" value=\"Search\" class=\"btn btn-secondary\" /> |\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "210c9b36d74a0a845d74b87350abb860c1dffbc49173", async() => {
                    WriteLiteral("Back to Full List");
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
                WriteLiteral("\r\n                </p>\r\n                <p>\r\n                    ");
#nullable restore
#line 30 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
               Write(Html.ActionLink("Sort by Name", "Index", new { sortOrder = ViewBag.NameSortParm }, new { @class = " btn btn-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 31 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
               Write(Html.ActionLink("Sort by StartDate", "Index", new { sortOrder = ViewBag.DateSortParm }, new { @class = " btn btn-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 32 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
               Write(Html.ActionLink("Sort by SittingType", "Index", new { sortOrder = ViewBag.TypeSortParm }, new { @class = " btn btn-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </p>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>Id</th>\r\n            <th>Person Name</th>\r\n            <th>\r\n                Person Email\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 47 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StartTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 50 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 53 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Guests));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Reservation Status\r\n            </th>\r\n            <th>\r\n                Reservation Origin\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 62 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Sitting));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </th>
            <th>
                Booked Tables
            </th>
            <th>
                Sitting Type
            </th>

            <th>
                Special Requirement
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 78 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 80 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 81 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
           Write(item.Person.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 81 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
                                  Write(item.Person.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                ");
#nullable restore
#line 83 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Person.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 86 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.StartTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 89 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 92 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Guests));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 95 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ReservationStatus.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 98 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ReservationOrigin.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 101 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Sitting.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <div>\r\n");
#nullable restore
#line 105 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
                     foreach (var table in item.Tables)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div>\r\n                            ");
#nullable restore
#line 108 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
                       Write(table.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 110 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 114 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Sitting.SittingType.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 118 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SpecialRequirement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "210c9b36d74a0a845d74b87350abb860c1dffbc421013", async() => {
                WriteLiteral("Edit");
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
#line 121 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
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
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "210c9b36d74a0a845d74b87350abb860c1dffbc423236", async() => {
                WriteLiteral("Details");
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
#line 122 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
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
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "210c9b36d74a0a845d74b87350abb860c1dffbc425463", async() => {
                WriteLiteral("Delete");
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
#line 123 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
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
#line 126 "C:\Users\cratl\OneDrive\Desktop\DIPS PROG\GroupF_BeanScene\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ReservationRestaurant.Data.Reservation>> Html { get; private set; }
    }
}
#pragma warning restore 1591
