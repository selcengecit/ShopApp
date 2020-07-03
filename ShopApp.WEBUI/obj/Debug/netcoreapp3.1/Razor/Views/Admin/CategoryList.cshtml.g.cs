#pragma checksum "C:\Users\selcuk\source\repos\ShopApp\ShopApp.WEBUI\Views\Admin\CategoryList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3664c96f10d43c383e815ecff30c5eb6e7fc350"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_CategoryList), @"mvc.1.0.view", @"/Views/Admin/CategoryList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3664c96f10d43c383e815ecff30c5eb6e7fc350", @"/Views/Admin/CategoryList.cshtml")]
    public class Views_Admin_CategoryList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopApp.WEBUI.Models.CategoryListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\selcuk\source\repos\ShopApp\ShopApp.WEBUI\Views\Admin\CategoryList.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3664c96f10d43c383e815ecff30c5eb6e7fc3503905", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3664c96f10d43c383e815ecff30c5eb6e7fc3505184", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 16 "C:\Users\selcuk\source\repos\ShopApp\ShopApp.WEBUI\Views\Admin\CategoryList.cshtml"
     if (TempData["message"] != null)
    {
        var message = Newtonsoft.Json.JsonConvert.DeserializeObject<ShopApp.WEBUI.Models.AlertMessage>(TempData["message"] as String);

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-md-12\">\r\n                <div");
                BeginWriteAttribute("class", " class=\"", 754, "\"", 792, 3);
                WriteAttributeValue("", 762, "alert", 762, 5, true);
                WriteAttributeValue(" ", 767, "alert-", 768, 7, true);
#nullable restore
#line 21 "C:\Users\selcuk\source\repos\ShopApp\ShopApp.WEBUI\Views\Admin\CategoryList.cshtml"
WriteAttributeValue("", 774, message.AlertType, 774, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    ");
#nullable restore
#line 22 "C:\Users\selcuk\source\repos\ShopApp\ShopApp.WEBUI\Views\Admin\CategoryList.cshtml"
               Write(message.Message);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 26 "C:\Users\selcuk\source\repos\ShopApp\ShopApp.WEBUI\Views\Admin\CategoryList.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <a href=""/admin/CreateCategories"" class=""btn btn-primary"">AddCategory</a>


    <table class=""table table-bordered"">
        <thead>
            <tr>
                <td style=""width:30px;"">Id</td>
                <td style=""width:100px;"">CategoryName</td>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 38 "C:\Users\selcuk\source\repos\ShopApp\ShopApp.WEBUI\Views\Admin\CategoryList.cshtml"
             if (Model.Categories.Count > 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\selcuk\source\repos\ShopApp\ShopApp.WEBUI\Views\Admin\CategoryList.cshtml"
                 foreach (var item in Model.Categories)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 43 "C:\Users\selcuk\source\repos\ShopApp\ShopApp.WEBUI\Views\Admin\CategoryList.cshtml"
                       Write(item.CategoryID);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 44 "C:\Users\selcuk\source\repos\ShopApp\ShopApp.WEBUI\Views\Admin\CategoryList.cshtml"
                       Write(item.CategoryName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 1551, "\"", 1596, 2);
                WriteAttributeValue("", 1558, "/admin/EditCategories/", 1558, 22, true);
#nullable restore
#line 46 "C:\Users\selcuk\source\repos\ShopApp\ShopApp.WEBUI\Views\Admin\CategoryList.cshtml"
WriteAttributeValue("", 1580, item.CategoryID, 1580, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-primary\">Edit</a>\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3664c96f10d43c383e815ecff30c5eb6e7fc3509030", async() => {
                    WriteLiteral("\r\n                                <input type=\"hidden\" name=\"categoryId\"");
                    BeginWriteAttribute("value", " value=\"", 1825, "\"", 1849, 1);
#nullable restore
#line 48 "C:\Users\selcuk\source\repos\ShopApp\ShopApp.WEBUI\Views\Admin\CategoryList.cshtml"
WriteAttributeValue("", 1833, item.CategoryID, 1833, 16, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                                <button type=\"submit\" class=\"btn btn-danger\">Delete</button>\r\n\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1674, "/admin/DeleteCategory/", 1674, 22, true);
#nullable restore
#line 47 "C:\Users\selcuk\source\repos\ShopApp\ShopApp.WEBUI\Views\Admin\CategoryList.cshtml"
AddHtmlAttributeValue("", 1696, item.CategoryID, 1696, 16, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 54 "C:\Users\selcuk\source\repos\ShopApp\ShopApp.WEBUI\Views\Admin\CategoryList.cshtml"

                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\selcuk\source\repos\ShopApp\ShopApp.WEBUI\Views\Admin\CategoryList.cshtml"
                 


            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopApp.WEBUI.Models.CategoryListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
