#pragma checksum "C:\Users\kaleh\source\repos\Asp.NetCoreMvcExample\Varli.Northwind.MvcWebUI\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4417b17ff2f2ddf947e575dd1b8877e344f088dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Index.cshtml", typeof(AspNetCore.Views_Product_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4417b17ff2f2ddf947e575dd1b8877e344f088dd", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d9e24a826489884372346efaf80cc26ffd0786a", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Varli.Northwind.MvcWebUI.Models.ProductListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-xs btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Varli.Northwind.MvcWebUI.TagHelpers.PagingTagHelper __Varli_Northwind_MvcWebUI_TagHelpers_PagingTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(63, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\kaleh\source\repos\Asp.NetCoreMvcExample\Varli.Northwind.MvcWebUI\Views\Product\Index.cshtml"
  
    Layout = "~/Views/_Layout.cshtml";

#line default
#line hidden
            BeginContext(112, 214, true);
            WriteLiteral("\r\n\r\n\r\n<div>\r\n    <table class=\"table table-responsive\">\r\n        <tr>\r\n            <td>Product Name</td>\r\n            <td>Unit Price</td>\r\n            <td>Units In Stock</td>\r\n            <td></td>\r\n        </tr>\r\n");
            EndContext();
#line 18 "C:\Users\kaleh\source\repos\Asp.NetCoreMvcExample\Varli.Northwind.MvcWebUI\Views\Product\Index.cshtml"
         foreach (var product in Model.Products)
        {

#line default
#line hidden
            BeginContext(387, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(426, 19, false);
#line 21 "C:\Users\kaleh\source\repos\Asp.NetCoreMvcExample\Varli.Northwind.MvcWebUI\Views\Product\Index.cshtml"
               Write(product.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(445, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(473, 17, false);
#line 22 "C:\Users\kaleh\source\repos\Asp.NetCoreMvcExample\Varli.Northwind.MvcWebUI\Views\Product\Index.cshtml"
               Write(product.UnitPrice);

#line default
#line hidden
            EndContext();
            BeginContext(490, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(518, 20, false);
#line 23 "C:\Users\kaleh\source\repos\Asp.NetCoreMvcExample\Varli.Northwind.MvcWebUI\Views\Product\Index.cshtml"
               Write(product.UnitsInStock);

#line default
#line hidden
            EndContext();
            BeginContext(538, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(565, 134, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81ff4cb18cb942d58c82daeb75e6c537", async() => {
                BeginContext(684, 11, true);
                WriteLiteral("add to cart");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 24 "C:\Users\kaleh\source\repos\Asp.NetCoreMvcExample\Varli.Northwind.MvcWebUI\Views\Product\Index.cshtml"
                                                                                                           WriteLiteral(product.ProductId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(699, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 26 "C:\Users\kaleh\source\repos\Asp.NetCoreMvcExample\Varli.Northwind.MvcWebUI\Views\Product\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(736, 22, true);
            WriteLiteral("    </table>\r\n</div>\r\n");
            EndContext();
            BeginContext(758, 183, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("product-list-pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "511bee10cc1d4dc0b387b74d1277809f", async() => {
            }
            );
            __Varli_Northwind_MvcWebUI_TagHelpers_PagingTagHelper = CreateTagHelper<global::Varli.Northwind.MvcWebUI.TagHelpers.PagingTagHelper>();
            __tagHelperExecutionContext.Add(__Varli_Northwind_MvcWebUI_TagHelpers_PagingTagHelper);
#line 30 "C:\Users\kaleh\source\repos\Asp.NetCoreMvcExample\Varli.Northwind.MvcWebUI\Views\Product\Index.cshtml"
__Varli_Northwind_MvcWebUI_TagHelpers_PagingTagHelper.CurrentCategory = Model.CurrentCategory;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("current-category", __Varli_Northwind_MvcWebUI_TagHelpers_PagingTagHelper.CurrentCategory, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 31 "C:\Users\kaleh\source\repos\Asp.NetCoreMvcExample\Varli.Northwind.MvcWebUI\Views\Product\Index.cshtml"
__Varli_Northwind_MvcWebUI_TagHelpers_PagingTagHelper.CurrentPage = Model.CurrentPage;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("current-page", __Varli_Northwind_MvcWebUI_TagHelpers_PagingTagHelper.CurrentPage, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 32 "C:\Users\kaleh\source\repos\Asp.NetCoreMvcExample\Varli.Northwind.MvcWebUI\Views\Product\Index.cshtml"
__Varli_Northwind_MvcWebUI_TagHelpers_PagingTagHelper.PageCount = Model.PageCount;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("page-count", __Varli_Northwind_MvcWebUI_TagHelpers_PagingTagHelper.PageCount, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 33 "C:\Users\kaleh\source\repos\Asp.NetCoreMvcExample\Varli.Northwind.MvcWebUI\Views\Product\Index.cshtml"
__Varli_Northwind_MvcWebUI_TagHelpers_PagingTagHelper.PageSize = Model.PageSize;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("page-size", __Varli_Northwind_MvcWebUI_TagHelpers_PagingTagHelper.PageSize, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(941, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Varli.Northwind.MvcWebUI.Models.ProductListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
