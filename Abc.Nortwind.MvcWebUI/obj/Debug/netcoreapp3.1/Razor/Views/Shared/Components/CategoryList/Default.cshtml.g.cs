#pragma checksum "C:\Users\tayip\source\repos\Abc\Abc.Nortwind.MvcWebUI\Views\Shared\Components\CategoryList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "623d79df54d5736b7489c7b7578b0bdbec4eb4e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategoryList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"623d79df54d5736b7489c7b7578b0bdbec4eb4e6", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ee6ffa99e0fb71988cfc8c85b44c9b995c7967d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CategoryList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Abc.Nortwind.MvcWebUI.Models.CategoryListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <div class=\"list-group\">\r\n");
#nullable restore
#line 9 "C:\Users\tayip\source\repos\Abc\Abc.Nortwind.MvcWebUI\Views\Shared\Components\CategoryList\Default.cshtml"
         foreach (var category in Model.Categories)
        {
            var css = "list-group-item";
            if(category.CategoryId == Model.CurrentCategory)
            {
                css += " active";
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 464, "\"", 515, 2);
            WriteAttributeValue("", 471, "/product/index?category=", 471, 24, true);
#nullable restore
#line 16 "C:\Users\tayip\source\repos\Abc\Abc.Nortwind.MvcWebUI\Views\Shared\Components\CategoryList\Default.cshtml"
WriteAttributeValue("", 495, category.CategoryId, 495, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 516, "\"", 528, 1);
#nullable restore
#line 16 "C:\Users\tayip\source\repos\Abc\Abc.Nortwind.MvcWebUI\Views\Shared\Components\CategoryList\Default.cshtml"
WriteAttributeValue("", 524, css, 524, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" >");
#nullable restore
#line 16 "C:\Users\tayip\source\repos\Abc\Abc.Nortwind.MvcWebUI\Views\Shared\Components\CategoryList\Default.cshtml"
                                                                        Write(category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 17 "C:\Users\tayip\source\repos\Abc\Abc.Nortwind.MvcWebUI\Views\Shared\Components\CategoryList\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Abc.Nortwind.MvcWebUI.Models.CategoryListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
