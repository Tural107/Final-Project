#pragma checksum "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\Categories\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3591c5b9201026d57b3b5c367760c145088228fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Categories_Detail), @"mvc.1.0.view", @"/Areas/Admin/Views/Categories/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3591c5b9201026d57b3b5c367760c145088228fd", @"/Areas/Admin/Views/Categories/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3923ea598022e84d31cb38e8062980867bf2fd16", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Categories_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\Categories\Detail.cshtml"
  
    ViewData["Title"] = "Category";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-md-12 grid-margin stretch-card"">
              <div class=""card"">
                <div class=""card-body card-body-bg-color"">
                  <h4 class=""card-title"">Categories</h4>
                  <p class=""card-description"">
                      ");
#nullable restore
#line 11 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\Categories\Detail.cshtml"
                 Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Brand Detail\n                  </p>\n                    <h1 class=\"display-4 border border-primary border-3 rounded\" style=\"width:max-content;\">Name: ");
#nullable restore
#line 13 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\Categories\Detail.cshtml"
                                                                                                             Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n                    <h1 class=\"display-4 border border-primary border-3 rounded\" style=\"width:max-content;\">Description: ");
#nullable restore
#line 14 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\Categories\Detail.cshtml"
                                                                                                                    Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n");
#nullable restore
#line 15 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\Categories\Detail.cshtml"
                     if(Model.ParentId != null){

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h1 class=\"display-4 border border-primary border-3 rounded\" style=\"width:max-content;\">Parent: ");
#nullable restore
#line 16 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\Categories\Detail.cshtml"
                                                                                                               Write(Model.Parent.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n");
#nullable restore
#line 17 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\Categories\Detail.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h1 class=\"display-4 border border-primary border-3 rounded\" style=\"width:max-content;\">Created Time: ");
#nullable restore
#line 18 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\Categories\Detail.cshtml"
                                                                                                                     Write(Model.CreatedTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n                    <h1 class=\"display-4 border border-primary border-3 rounded\" style=\"width:max-content;\">Created By User Id: ");
#nullable restore
#line 19 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\Categories\Detail.cshtml"
                                                                                                                           Write(Model.CreatedByUserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n");
#nullable restore
#line 20 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\Categories\Detail.cshtml"
                     if(Model.DeletedByUserId != null){

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h1 class=\"display-4 border border-primary border-3 rounded\" style=\"width:max-content;\">Deleted By User Id: ");
#nullable restore
#line 21 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\Categories\Detail.cshtml"
                                                                                                                           Write(Model.DeletedByUserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n                    <h1 class=\"display-4 border border-primary border-3 rounded\" style=\"width:max-content;\">Deleted Time: ");
#nullable restore
#line 22 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\Categories\Detail.cshtml"
                                                                                                                     Write(Model.DeletedTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n");
#nullable restore
#line 23 "C:\Users\quliy\Desktop\ECommerceProjectWithMVC-Folder-main\ECommerceProjectWithMVC\Areas\Admin\Views\Categories\Detail.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n              </div>\n            </div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
