#pragma checksum "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Views\Card\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a3c13dd83f8389e30df635f5cbd5133e3c73fac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Card_Index), @"mvc.1.0.view", @"/Views/Card/Index.cshtml")]
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
#line 1 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Views\_ViewImports.cshtml"
using ECommerceProjectWithMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Views\_ViewImports.cshtml"
using ECommerceProjectWithMVC.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Views\_ViewImports.cshtml"
using ECommerceProjectWithMVC.Models.DataContexts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Views\_ViewImports.cshtml"
using ECommerceProjectWithMVC.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Views\_ViewImports.cshtml"
using ECommerceProjectWithMVC.Models.Entities.Membership;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Views\_ViewImports.cshtml"
using ECommerceProjectWithMVC.Models.FormModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Views\_ViewImports.cshtml"
using ECommerceProjectWithMVC.AppCode.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a3c13dd83f8389e30df635f5cbd5133e3c73fac", @"/Views/Card/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6151167d9a2ba994a95b2c561fc54f88f68e8348", @"/Views/_ViewImports.cshtml")]
    public class Views_Card_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<UserCardItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary custom-button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteAll", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Card", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Views\Card\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n      <section\n        class=\"card-body d-flex flex-column justify-content-center align-items-center\"\n      >\n        <div class=\"shopping-cart border border-3 border-dark\">\n          <!-- Title -->\n");
#nullable restore
#line 12 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Views\Card\Index.cshtml"
           if(Model.Count !=0){

#line default
#line hidden
#nullable disable
            WriteLiteral("              <div>\n                  <div class=\"title d-flex justify-content-between\">\n\n                      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a3c13dd83f8389e30df635f5cbd5133e3c73fac8861", async() => {
                WriteLiteral("Go To Shop");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                      <h4>Bag</h4>\n                      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a3c13dd83f8389e30df635f5cbd5133e3c73fac10365", async() => {
                WriteLiteral("Delete All");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                  </div>\n          </div>\n          <!-- Products -->\n");
#nullable restore
#line 22 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Views\Card\Index.cshtml"
           foreach (var item in Model)
         {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a3c13dd83f8389e30df635f5cbd5133e3c73fac11960", async() => {
                WriteLiteral(@"
             <div class=""item align-items-center border-0 border-top border-dark"" style=""background-color: var(--secondary); "">
                <div class=""buttons"">
                  <span class=""delete-btn-card""></span>
                  <span class=""like-btn-card""></span>
                </div>

                <div class=""image bg-primary rounded"">
                  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9a3c13dd83f8389e30df635f5cbd5133e3c73fac12602", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1390, "~/uploads/products/images/", 1390, 26, true);
#nullable restore
#line 34 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Views\Card\Index.cshtml"
AddHtmlAttributeValue("", 1416, item.ProductPricing.Product.Images.FirstOrDefault(pp=>pp.IsMain == true).ImagePath, 1416, 83, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                </div>\n\n                <div class=\"description\">\n                  <span>");
#nullable restore
#line 40 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Views\Card\Index.cshtml"
                   Write(item.ProductPricing.Product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\n");
                WriteLiteral("                  <span>");
#nullable restore
#line 42 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Views\Card\Index.cshtml"
                   Write(item.ProductPricing.Size.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\n");
                WriteLiteral("                  <span>");
#nullable restore
#line 44 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Views\Card\Index.cshtml"
                   Write(item.ProductPricing.Color.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\n");
                WriteLiteral("                </div>\n\n                <div class=\"quantity\">\n");
                WriteLiteral("                  <p id=\"product-count\" data-product-count=\"");
#nullable restore
#line 52 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Views\Card\Index.cshtml"
                                                       Write(item.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">Count:");
#nullable restore
#line 52 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Views\Card\Index.cshtml"
                                                                          Write(item.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n              \n              \n                </div>\n\n                \n\n                <div class=\"total-price\">Product price: $");
#nullable restore
#line 59 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Views\Card\Index.cshtml"
                                                    Write(item.ProductPricing.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                \n                </div>\n                <div class=\"total-price\" id=\"total-price\" data-product-price=\"");
#nullable restore
#line 62 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Views\Card\Index.cshtml"
                                                                         Write(item.ProductPricing.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"> Total Price Product: $<span class=\"total-amount  badge-primary dark\">");
#nullable restore
#line 62 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Views\Card\Index.cshtml"
                                                                                                                                                                            Write(item.ProductPricing.Price*item.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\n                </div>\n\n                <div");
                BeginWriteAttribute("class", " class=\"", 2891, "\"", 2899, 0);
                EndWriteAttribute();
                WriteLiteral(">\n                    <button class=\"minus-btn-card\" type=\"submit\">\n                        <img src=\"./assets/svg/minus.svg\"");
                BeginWriteAttribute("alt", " alt=\"", 3025, "\"", 3031, 0);
                EndWriteAttribute();
                WriteLiteral(" />\n                  </button>\n                </div>\n              </div>\n             ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-colorId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 24 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Views\Card\Index.cshtml"
                                             WriteLiteral(item.ProductPricing.Color.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["colorId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-colorId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["colorId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 24 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Views\Card\Index.cshtml"
                                                                                              WriteLiteral(item.ProductPricing.Size.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["sizeId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sizeId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["sizeId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 24 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Views\Card\Index.cshtml"
                                                                                                                                                 WriteLiteral(item.ProductPricing.Product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 72 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Views\Card\Index.cshtml"
             }

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Views\Card\Index.cshtml"
              

          }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("              <div class=\"title d-flex justify-content-between\">\n              <h4>Not Have Product</h4>\n              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a3c13dd83f8389e30df635f5cbd5133e3c73fac22846", async() => {
                WriteLiteral("Go To Shop");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n");
#nullable restore
#line 79 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Views\Card\Index.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n");
#nullable restore
#line 81 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Views\Card\Index.cshtml"
           if (Model.Count != 0) { 

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a3c13dd83f8389e30df635f5cbd5133e3c73fac24827", async() => {
                WriteLiteral("Complete the order");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 83 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Views\Card\Index.cshtml"

            }
            else
            {

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("      </section>\n    \n\n");
            DefineSection("addjs", async() => {
                WriteLiteral("\n");
                WriteLiteral("      ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<UserCardItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591