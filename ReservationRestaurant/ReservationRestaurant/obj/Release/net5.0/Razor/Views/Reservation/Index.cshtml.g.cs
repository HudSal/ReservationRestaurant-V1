#pragma checksum "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdbb511c49ebcc48ed3b65fabf267e66a8e879cf"
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
#line 1 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Views\_ViewImports.cshtml"
using ReservationRestaurant;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Views\_ViewImports.cshtml"
using ReservationRestaurant.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdbb511c49ebcc48ed3b65fabf267e66a8e879cf", @"/Views/Reservation/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea6782be1d593d9f5cbc6c344dd744601e61ed2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Reservation_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ReservationRestaurant.Data.Reservation>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PreCreate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sandy"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index -- Reservations List</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fdbb511c49ebcc48ed3b65fabf267e66a8e879cf6103", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fdbb511c49ebcc48ed3b65fabf267e66a8e879cf7350", async() => {
                WriteLiteral(@"

            <div class=""form-actions no-color"">
                <p>
                    Search Option:
                    <label> Reservation Id </label>
                    <input id=""ReservationId"" name=""option"" type=""radio"" value=""ReservationId"" checked=""checked"" />
                    <span> </span>
                    <label>Email </label>
                    <input id=""Email"" name=""option"" type=""radio"" value=""Email"" />
                    <span> </span>
                    <label>Last Name</label>
                    <input id=""Name"" name=""option"" type=""radio"" value=""Name"" />
                    <br />
                    <input type=""text"" name=""SearchString""");
                BeginWriteAttribute("value", " value=\"", 1002, "\"", 1036, 1);
#nullable restore
#line 28 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
WriteAttributeValue("", 1010, ViewData["CurrentFilter"], 1010, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input type=\"submit\" value=\"Search\" class=\"btn btn-sandy\" /> |\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fdbb511c49ebcc48ed3b65fabf267e66a8e879cf8896", async() => {
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
#line 33 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
               Write(Html.ActionLink("Sort by Name", "Index", new { sortOrder = ViewBag.NameSortParm }, new { @class = " btn btn-primary" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 34 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
               Write(Html.ActionLink("Sort by StartDate", "Index", new { sortOrder = ViewBag.DateSortParm }, new { @class = " btn btn-primary" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 35 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
               Write(Html.ActionLink("Sort by SittingType", "Index", new { sortOrder = ViewBag.TypeSortParm }, new { @class = " btn btn-primary" }));

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
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>Id</th>\r\n            <th>Person Name</th>\r\n");
            WriteLiteral("            <th>\r\n                ");
#nullable restore
#line 50 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StartTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 53 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 56 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Guests));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Reservation Status\r\n            </th>\r\n            <th>\r\n                Reservation Origin\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 65 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Sitting));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Booked Tables\r\n            </th>\r\n            <th>\r\n                Sitting Type\r\n            </th>\r\n\r\n");
            WriteLiteral("            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 81 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
         foreach (var item in Model)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr ");
#nullable restore
#line 84 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
                 if (item.ReservationStatus.Name == "Pending") { 

#line default
#line hidden
#nullable disable
            WriteLiteral(" style=\"color:red\" ");
#nullable restore
#line 84 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
                                                                                                   } else if (item.ReservationStatus.Name == "Confirmed") { 

#line default
#line hidden
#nullable disable
            WriteLiteral(" style=\"color:blue\" ");
#nullable restore
#line 84 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
                                                                                                                                                                                              } else if (item.ReservationStatus.Name == "Cancelled") { 

#line default
#line hidden
#nullable disable
            WriteLiteral(" style=\"color:grey\" ");
#nullable restore
#line 84 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
                                                                                                                                                                                                                                                                                         }

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                <td>");
#nullable restore
#line 85 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 86 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
               Write(item.Person.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 86 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
                                      Write(item.Person.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 91 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.StartTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 94 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 97 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Guests));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"sittingTypes\">\r\n                    ");
#nullable restore
#line 100 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ReservationStatus.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 103 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ReservationOrigin.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
            WriteLiteral("                <td>\r\n                    <div>\r\n");
#nullable restore
#line 110 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
                         foreach (var table in item.Tables)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div>\r\n                                ");
#nullable restore
#line 113 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
                           Write(table.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n");
#nullable restore
#line 115 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 119 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Sitting.SittingType.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n");
            WriteLiteral("\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fdbb511c49ebcc48ed3b65fabf267e66a8e879cf21763", async() => {
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
#line 127 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
                                             WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fdbb511c49ebcc48ed3b65fabf267e66a8e879cf24079", async() => {
                WriteLiteral("Details");
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
#line 128 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
                                              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fdbb511c49ebcc48ed3b65fabf267e66a8e879cf26399", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 129 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"
                                             WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 132 "C:\Users\craig\Desktop\Project\ReservationRestaurant-V4-Master\ReservationRestaurant\ReservationRestaurant\Views\Reservation\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script>







        //var h1 = document.getElementsByTagName(""H1"");   // Get the first <h1> element in the document
        //var att = document.createAttribute(""class"");       // Create a ""class"" attribute
        //att.value = ""democlass"";                           // Set the value of the class attribute
        //h1.setAttributeNode(att);
    </script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ReservationRestaurant.Data.Reservation>> Html { get; private set; }
    }
}
#pragma warning restore 1591
