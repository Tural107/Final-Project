#pragma checksum "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\Users\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30b1cf718235c257f443445198842498125e9355"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Users_Detail), @"mvc.1.0.view", @"/Areas/Admin/Views/Users/Detail.cshtml")]
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
#line 1 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\_ViewImports.cshtml"
using ECommerceProjectWithMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\_ViewImports.cshtml"
using ECommerceProjectWithMVC.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\_ViewImports.cshtml"
using ECommerceProjectWithMVC.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\_ViewImports.cshtml"
using ECommerceProjectWithMVC.AppCode.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\_ViewImports.cshtml"
using ECommerceProjectWithMVC.Models.Entities.Membership;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\_ViewImports.cshtml"
using ECommerceProjectWithMVC.Models.FormModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30b1cf718235c257f443445198842498125e9355", @"/Areas/Admin/Views/Users/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3923ea598022e84d31cb38e8062980867bf2fd16", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Users_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("forms-sample"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libraries/jquery-validate/jquery.validate.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libraries/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\Users\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-md-12 grid-margin stretch-card"">
              <div class=""card"">
                <div class=""card-body card-body-bg-color"">
                  <h4 class=""card-title"">Users</h4>
                  <p class=""card-description"">
                      ");
#nullable restore
#line 11 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\Users\Detail.cshtml"
                 Write(Model.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" User Detail\n                  </p>\n                  \n                    <h1 class=\"display-4\">Username: ");
#nullable restore
#line 14 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\Users\Detail.cshtml"
                                               Write(Model.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n");
#nullable restore
#line 15 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\Users\Detail.cshtml"
                     if(Model.User.Email != null){

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h1 class=\"display-4\">Email: ");
#nullable restore
#line 16 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\Users\Detail.cshtml"
                                                Write(Model.User.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n                        <h1 class=\"display-4\">Email Confirmed:</h1>\n");
#nullable restore
#line 18 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\Users\Detail.cshtml"
                         if(Model.User.EmailConfirmed == true){

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"badge badge-success\">Confirmed</span>\n");
#nullable restore
#line 20 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\Users\Detail.cshtml"
                          }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"badge badge-danger\">Not Confirmed</span>\n");
#nullable restore
#line 22 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\Users\Detail.cshtml"
                          }

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\Users\Detail.cshtml"
                           
                    }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h1 class=\"display-4\">Email: Not Have Email Address</h1>\n");
#nullable restore
#line 25 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\Users\Detail.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 28 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\Users\Detail.cshtml"
                     if(Model.User.LockoutEnd != null){

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h1 class=\"display-4\">Ban End Time: ");
#nullable restore
#line 29 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\Users\Detail.cshtml"
                                                       Write(Model.User.LockoutEnd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n");
#nullable restore
#line 30 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\Users\Detail.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    \n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30b1cf718235c257f443445198842498125e935512904", async() => {
                WriteLiteral("\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30b1cf718235c257f443445198842498125e935513185", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 34 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\Users\Detail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Roles);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                        <h2>Roles</h2>\n                        <div class=\"form-group\">\n");
#nullable restore
#line 37 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\Users\Detail.cshtml"
                              
                                int index = 0;
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\Users\Detail.cshtml"
                                 foreach (var item in Model.Roles)
                               {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                   <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 1775, "\"", 1808, 3);
                WriteAttributeValue("", 1782, "SelectedRoles[", 1782, 14, true);
#nullable restore
#line 42 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\Users\Detail.cshtml"
WriteAttributeValue("", 1796, index, 1796, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1804, "].Id", 1804, 4, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", "  value=\"", 1809, "\"", 1832, 1);
#nullable restore
#line 42 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\Users\Detail.cshtml"
WriteAttributeValue("", 1818, item.Item1.Id, 1818, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                                 <div class=\"form-check\">\n                                    <label class=\"form-check-label\">\n                                      <input type=\"checkbox\"");
                BeginWriteAttribute("name", " name=\"", 2022, "\"", 2063, 3);
                WriteAttributeValue("", 2029, "SelectedRoles[", 2029, 14, true);
#nullable restore
#line 45 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\Users\Detail.cshtml"
WriteAttributeValue("", 2043, index++, 2043, 10, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2053, "].Selected", 2053, 10, true);
                EndWriteAttribute();
                WriteLiteral(" ");
#nullable restore
#line 45 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\Users\Detail.cshtml"
                                                                                                   Write(@item.Item2 ? "checked" : "");

#line default
#line hidden
#nullable disable
                WriteLiteral("  class=\"form-check-input\">\n                                      ");
#nullable restore
#line 46 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\Users\Detail.cshtml"
                                 Write(item.Item1.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                    <i class=\"input-helper\"></i></label>\n                                  </div>\n");
#nullable restore
#line 49 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\Users\Detail.cshtml"
                               }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </div>\n");
#nullable restore
#line 51 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\Users\Detail.cshtml"
                          
                                int index2 = 0;
                            

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <h2>Claims</h2>\n                        <div class=\"form-group\">\n");
#nullable restore
#line 56 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\Users\Detail.cshtml"
                                 foreach (var item in Model.Claims)
                               {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                   <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 2707, "\"", 2749, 3);
                WriteAttributeValue("", 2714, "SelectedClaims[", 2714, 15, true);
#nullable restore
#line 58 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\Users\Detail.cshtml"
WriteAttributeValue("", 2729, index2, 2729, 9, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2738, "].ClaimType", 2738, 11, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", "  value=\"", 2750, "\"", 2770, 1);
#nullable restore
#line 58 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\Users\Detail.cshtml"
WriteAttributeValue("", 2759, item.Item1, 2759, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                                 <div class=\"form-check\">\n                                    <label class=\"form-check-label\">\n                                      <input type=\"checkbox\"");
                BeginWriteAttribute("name", " name=\"", 2960, "\"", 3003, 3);
                WriteAttributeValue("", 2967, "SelectedClaims[", 2967, 15, true);
#nullable restore
#line 61 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\Users\Detail.cshtml"
WriteAttributeValue("", 2982, index2++, 2982, 11, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2993, "].Selected", 2993, 10, true);
                EndWriteAttribute();
                WriteLiteral(" ");
#nullable restore
#line 61 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\Users\Detail.cshtml"
                                                                                                     Write(item.Item2 ? "checked" : "");

#line default
#line hidden
#nullable disable
                WriteLiteral(" class=\"form-check-input\">\n                                      ");
#nullable restore
#line 62 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\Users\Detail.cshtml"
                                 Write(item.Item1);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                    <i class=\"input-helper\"></i></label>\n                                  </div>\n");
#nullable restore
#line 65 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\Users\Detail.cshtml"
                               }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </div>\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "30b1cf718235c257f443445198842498125e935522284", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 67 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\Users\Detail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.User.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                        <button type=\"submit\" class=\"btn btn-success me-2\">Submit</button>\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30b1cf718235c257f443445198842498125e935524147", async() => {
                    WriteLiteral("Cancel");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div>\n              </div>\n            </div>\n");
            DefineSection("addjs", async() => {
                WriteLiteral("\n ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30b1cf718235c257f443445198842498125e935527305", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30b1cf718235c257f443445198842498125e935528400", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
