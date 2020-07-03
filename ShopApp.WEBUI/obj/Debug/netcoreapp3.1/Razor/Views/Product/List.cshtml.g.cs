#pragma checksum "C:\Users\selcuk\source\repos\ShopApp\ShopApp.WEBUI\Views\Product\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95c27f933b8b67ca05a99be26bab5b1faaae43d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_List), @"mvc.1.0.view", @"/Views/Product/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95c27f933b8b67ca05a99be26bab5b1faaae43d7", @"/Views/Product/List.cshtml")]
    public class Views_Product_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopApp.WEBUI.Models.ProductListViewModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\selcuk\source\repos\ShopApp\ShopApp.WEBUI\Views\Product\List.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95c27f933b8b67ca05a99be26bab5b1faaae43d72935", async() => {
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <title>index</title>
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"" integrity=""sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh"" crossorigin=""anonymous"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95c27f933b8b67ca05a99be26bab5b1faaae43d74214", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 16 "C:\Users\selcuk\source\repos\ShopApp\ShopApp.WEBUI\Views\Product\List.cshtml"
     if (TempData["message"] != null)
    {
        var message = Newtonsoft.Json.JsonConvert.DeserializeObject<ShopApp.WEBUI.Models.AlertMessage>(TempData["message"] as String);

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-md-12\">\r\n                <div");
                BeginWriteAttribute("class", " class=\"", 753, "\"", 791, 3);
                WriteAttributeValue("", 761, "alert", 761, 5, true);
                WriteAttributeValue(" ", 766, "alert-", 767, 7, true);
#nullable restore
#line 21 "C:\Users\selcuk\source\repos\ShopApp\ShopApp.WEBUI\Views\Product\List.cshtml"
WriteAttributeValue("", 773, message.AlertType, 773, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    ");
#nullable restore
#line 22 "C:\Users\selcuk\source\repos\ShopApp\ShopApp.WEBUI\Views\Product\List.cshtml"
               Write(message.Message);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 26 "C:\Users\selcuk\source\repos\ShopApp\ShopApp.WEBUI\Views\Product\List.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral(" \r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\">\r\n");
                WriteLiteral("        </div>\r\n        <div class=\"col-md-9\">\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 34 "C:\Users\selcuk\source\repos\ShopApp\ShopApp.WEBUI\Views\Product\List.cshtml"
                 foreach (var product in Model.Products)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"col-md-4\">\r\n                        ");
#nullable restore
#line 37 "C:\Users\selcuk\source\repos\ShopApp\ShopApp.WEBUI\Views\Product\List.cshtml"
                   Write(await Html.PartialAsync("_productAdmin", product));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 39 "C:\Users\selcuk\source\repos\ShopApp\ShopApp.WEBUI\Views\Product\List.cshtml"

                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col\">\r\n                    <nav aria-label=\"Page navigation example\">\r\n                        <ul class=\"pagination\">\r\n");
#nullable restore
#line 46 "C:\Users\selcuk\source\repos\ShopApp\ShopApp.WEBUI\Views\Product\List.cshtml"
                             for (int i = 0; i < Model.pageInfo.TotalPages(); i++)
                            {


#line default
#line hidden
#nullable disable
                WriteLiteral("                                <li");
                BeginWriteAttribute("class", " class=\"", 1694, "\"", 1759, 2);
                WriteAttributeValue("", 1702, "page-item", 1702, 9, true);
#nullable restore
#line 49 "C:\Users\selcuk\source\repos\ShopApp\ShopApp.WEBUI\Views\Product\List.cshtml"
WriteAttributeValue(" ", 1711, Model.pageInfo.CurrentPage==i+1?" active":"", 1712, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><a class=\"page-link\"");
                BeginWriteAttribute("href", " href=\"", 1781, "\"", 1813, 2);
                WriteAttributeValue("", 1788, "/product/list?page=", 1788, 19, true);
#nullable restore
#line 49 "C:\Users\selcuk\source\repos\ShopApp\ShopApp.WEBUI\Views\Product\List.cshtml"
WriteAttributeValue("", 1807, i+1, 1807, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 49 "C:\Users\selcuk\source\repos\ShopApp\ShopApp.WEBUI\Views\Product\List.cshtml"
                                                                                                                                                        Write(i+1);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></li>\r\n");
#nullable restore
#line 50 "C:\Users\selcuk\source\repos\ShopApp\ShopApp.WEBUI\Views\Product\List.cshtml"


                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <li class=\"page-item \"><a class=\"page-link\"");
                BeginWriteAttribute("href", " href=\"", 1938, "\"", 1990, 2);
                WriteAttributeValue("", 1945, "products?page=", 1945, 14, true);
#nullable restore
#line 53 "C:\Users\selcuk\source\repos\ShopApp\ShopApp.WEBUI\Views\Product\List.cshtml"
WriteAttributeValue("", 1959, Model.pageInfo.CurrentPage+1, 1959, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Next</a></li>\r\n\r\n\r\n                        </ul>\r\n                    </nav>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopApp.WEBUI.Models.ProductListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
