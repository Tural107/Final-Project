#pragma checksum "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29bda3060cacf19bc17e2c2e2a5e3d57689927a8"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29bda3060cacf19bc17e2c2e2a5e3d57689927a8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6151167d9a2ba994a95b2c561fc54f88f68e8348", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card bg-info "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("50%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-sm bg-info border-info btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Views\Home\Index.cshtml"
   ViewData["Title"] = "Home"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral(@"<section class=""col-12 mt-5 md-5"">
    <div class=""col-12 bg-dark mb-3  border-bottom border-dark  border-2 rounded"">
        <div id=""carouselExampleInterval"" class=""carousel slide"" data-bs-ride=""carousel"">
            <div class=""carousel-inner"">
                <div class=""carousel-item active"" data-bs-interval=""3000"">
                    <img src=""https://www.asus.com/WebsitesBanner/US/banners/adfpzusllai3kch4/adfpzusllai3kch4-0_0_desktop_1X.jpg"" class=""d-block w-100"" alt=""..."">
                </div>
                <div class=""carousel-item"" data-bs-interval=""3000"">
                    <img src=""https://www.asus.com/WebsitesBanner/US/banners/i6i6w0kszhrwdqno/i6i6w0kszhrwdqno-0_0_desktop_1X.jpg"" class=""d-block w-100"" alt=""..."">
                </div>
                <div class=""carousel-item"" data-bs-interval=""3000"">
                    <img src=""https://www.asus.com/WebsitesBanner/US/banners/nym0z7tlamj1mfyg/nym0z7tlamj1mfyg-0_0_desktop_1X.jpg?webp"" class=""d-block w-100"" alt=""..."">
                </div");
            WriteLiteral(@">
            </div>
            <button class=""carousel-control-prev "" type=""button"" data-bs-target=""#carouselExampleInterval"" data-bs-slide=""prev"">
                <svg xmlns=""http://www.w3.org/2000/svg"" width=""30"" height=""30"" fill=""currentColor"" class=""bi bi-chevron-double-left btn-dark rounded rounded-pill p-1"" viewBox=""0 0 16 16"">
                    <path fill-rule=""evenodd"" d=""M8.354 1.646a.5.5 0 0 1 0 .708L2.707 8l5.647 5.646a.5.5 0 0 1-.708.708l-6-6a.5.5 0 0 1 0-.708l6-6a.5.5 0 0 1 .708 0z"" />
                    <path fill-rule=""evenodd"" d=""M12.354 1.646a.5.5 0 0 1 0 .708L6.707 8l5.647 5.646a.5.5 0 0 1-.708.708l-6-6a.5.5 0 0 1 0-.708l6-6a.5.5 0 0 1 .708 0z"" />
                </svg>
                <span class=""visually-hidden"">Previous</span>
            </button>
            <button class=""carousel-control-next"" type=""button"" data-bs-target=""#carouselExampleInterval"" data-bs-slide=""next"">
                <svg xmlns=""http://www.w3.org/2000/svg"" width=""30"" height=""30"" fill=""currentColor"" class=""bi b");
            WriteLiteral(@"i-chevron-double-right btn-dark rounded rounded-pill p-1"" viewBox=""0 0 16 16"">
                    <path fill-rule=""evenodd"" d=""M3.646 1.646a.5.5 0 0 1 .708 0l6 6a.5.5 0 0 1 0 .708l-6 6a.5.5 0 0 1-.708-.708L9.293 8 3.646 2.354a.5.5 0 0 1 0-.708z"" />
                    <path fill-rule=""evenodd"" d=""M7.646 1.646a.5.5 0 0 1 .708 0l6 6a.5.5 0 0 1 0 .708l-6 6a.5.5 0 0 1-.708-.708L13.293 8 7.646 2.354a.5.5 0 0 1 0-.708z"" />
                </svg>
                <span class=""visually-hidden"">Next</span>
            </button>
        </div>
    </div>
</section>
<section class=""col-12 mt-5 md-5"">
    <div class=""container "">
        <div class=""section-1 d-flex flex-wrap"">
            <div class=""card col-12 bg-dark main-item-scale-big mb-2 d-flex align-items-center justify-content-center"" style=""background-image: url(https://freepngimg.com/download/responsive_web_design/72916-website-web-apple-mockup-laptop-modern-design.png); "">
                <button onclick=""window.location.href= 'https://localhost:44373/shop?C");
            WriteLiteral(@"ategoryId=0&BrandId=1'"" class=""text-dark bg-info p-2 mb-2 rounded btn custom-span"">
                    <span>Apple Products</span>
                </button>
            </div>


            <div class=""card-group col-12 "">
                <div class=""card-group col-12 d-flex"">
                    <div class=""card main-item-scale bg-danger col-6 d-flex align-items-center justify-content-center"" style=""background-image: url(https://static-ecpa.acer.com/media/catalog/product/cache/88522f6c1d6da83084bf78ce2a2121bd/a/c/acer-nitro-5_an515-44_rgb-kb_modelmain.png);"">
                        <button onclick=""window.location.href='https://localhost:44373/shop?CategoryId=1&BrandId=0'"" class=""text-dark bg-info p-2 mb-2 rounded btn custom-span"">
                            <span>Laptop</span>
                        </button>
                    </div>
                    <div class=""card main-item-scale  col-6 d-flex align-items-center justify-content-center"" style=""background-image: url(https://www.pngall.com/wp-conte");
            WriteLiteral(@"nt/uploads/5/Hyperx-Cloud-II-Gaming-Headset-PNG-Clipart.png); background-color: rgb(57, 133, 168);"">
                        <button onclick=""window.location.href='https://localhost:44373/shop?CategoryId=3&BrandId=0'"" class=""text-dark bg-info p-2 mb-2 rounded btn custom-span"">
                            <span>Headset</span>
                        </button>
                    </div>
                </div>

                <div class=""card-group  col-12 d-flex"">
                    <div class=""card  main-item-scale col-6 d-flex align-items-center justify-content-center"" style=""background-image: url(https://cdn.discordapp.com/attachments/500597948317564928/961326156748058644/pngegg_2.png); background-color: rgb(67, 104, 67); "">
                        <button onclick=""window.location.href='https://localhost:44373/shop?CategoryId=2&BrandId=0'"" class=""text-dark bg-info p-2 mb-2 rounded btn custom-span"">
                            <span>Phone</span>
                        </button>
                    </div>
 ");
            WriteLiteral(@"                   <div class=""card  main-item-scale  col-6 d-flex align-items-center justify-content-center"" style=""background-image: url(https://cdn.discordapp.com/attachments/500597948317564928/961326571078160525/kisspng-samsung-gear-s3-frontier-samsung-galaxy-gear-samsu-samsung-gear-5b23b0c2d18352.6106965515290656668582.png); background-color: rgb(94, 23, 161);"">
                        <button onclick=""window.location.href='https://localhost:44373/shop?CategoryId=4&BrandId=0'"" class=""text-dark bg-info p-2 mb-2 rounded btn custom-span"">
                            <span>Watch</span>
                        </button>
                    </div>
                </div>
            </div>

        </div>
        <!-- carousel -->
        <div");
            BeginWriteAttribute("class", " class=\"", 6142, "\"", 6150, 0);
            EndWriteAttribute();
            WriteLiteral(">\n\n            <div class=\"bg-dark rounded splide p-2 mt-2  home-some-products\">\n                <h2 class=\"text-light text-center mt-3 \">Some Products</h2>\n                <div class=\"splide__track m-5\">\n                    <ul class=\"splide__list \">\n\n");
#nullable restore
#line 92 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Views\Home\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <li class=""splide__slide"">
                                <div class=""card custom-carousel-size"">
                                    <div class=""card-body d-flex row justify-content-center"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "29bda3060cacf19bc17e2c2e2a5e3d57689927a814320", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6776, "~/uploads/products/images/", 6776, 26, true);
#nullable restore
#line 97 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 6802, item.Images.FirstOrDefault(p=>p.IsMain == true)?.ImagePath, 6802, 59, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                        <div class=\"mt-5 pt-3 pb-3 d-flex justify-content-end row\">\n                                            <span class=\"d-flex justify-content-center \">\n                                                <p>");
#nullable restore
#line 100 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Views\Home\Index.cshtml"
                                              Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                            </span>\n                                            <div class=\"d-flex justify-content-around align-items-center mt-2\">\n                                                <div>PRICE: $");
#nullable restore
#line 103 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Views\Home\Index.cshtml"
                                                        Write(item.PriceList.FirstOrDefault(p => p.ProductId == item.Id).Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29bda3060cacf19bc17e2c2e2a5e3d57689927a817397", async() => {
                WriteLiteral("BUY\n                                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 104 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Views\Home\Index.cshtml"
                                                                                                 WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                            </div>\n                                        </div>\n                                    </div>\n                                </div>\n                            </li>\n");
#nullable restore
#line 111 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Views\Home\Index.cshtml"
                         }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                    </ul>\n                </div>\n            </div>\n        </div>\n\n    </div>\n</section>\n<!-- Carousel Start-->\n");
#nullable restore
#line 122 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("LastAddedProducts"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!-- top sell start -->\n");
#nullable restore
#line 124 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("TopSellProducts"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!-- brand -->\n");
#nullable restore
#line 126 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("Brands"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
