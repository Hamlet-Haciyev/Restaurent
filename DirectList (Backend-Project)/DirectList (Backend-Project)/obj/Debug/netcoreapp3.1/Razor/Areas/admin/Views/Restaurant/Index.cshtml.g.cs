#pragma checksum "C:\Users\FX505GT\Desktop\Asp.Net Project\DirectList (Backend-Project)\DirectList (Backend-Project)\Areas\admin\Views\Restaurant\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38d9a143da9f0435d723353e2e25661dd354a7ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_admin_Views_Restaurant_Index), @"mvc.1.0.view", @"/Areas/admin/Views/Restaurant/Index.cshtml")]
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
#line 1 "C:\Users\FX505GT\Desktop\Asp.Net Project\DirectList (Backend-Project)\DirectList (Backend-Project)\Areas\admin\Views\_ViewImports.cshtml"
using DirectList__Backend_Project_;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\FX505GT\Desktop\Asp.Net Project\DirectList (Backend-Project)\DirectList (Backend-Project)\Areas\admin\Views\_ViewImports.cshtml"
using DirectList__Backend_Project_.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\FX505GT\Desktop\Asp.Net Project\DirectList (Backend-Project)\DirectList (Backend-Project)\Areas\admin\Views\_ViewImports.cshtml"
using DirectList__Backend_Project_.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\FX505GT\Desktop\Asp.Net Project\DirectList (Backend-Project)\DirectList (Backend-Project)\Areas\admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38d9a143da9f0435d723353e2e25661dd354a7ae", @"/Areas/admin/Views/Restaurant/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ce89e927794c07fa9827d492275837a24cd22ee", @"/Areas/admin/Views/_ViewImports.cshtml")]
    public class Areas_admin_Views_Restaurant_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Restaurant>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Restaurant", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:50px;max-height:50px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Alternate Text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure?\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\FX505GT\Desktop\Asp.Net Project\DirectList (Backend-Project)\DirectList (Backend-Project)\Areas\admin\Views\Restaurant\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-6\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38d9a143da9f0435d723353e2e25661dd354a7ae8141", async() => {
                WriteLiteral("Create");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
        <hr />
        <div class=""col-lg-12 mt-3"">
            <table class=""table"" style=""overflow:auto;"">
                <thead>
                    <tr>
                        <th scope=""col"">#</th>
                        <th scope=""col"">Image</th>
                        <th scope=""col"">Name</th>
                        <th scope=""col"">About</th>
                        <th scope=""col"">Address</th>
                        <th scope=""col"">Phone_1</th>
                        <th scope=""col"">StartDate</th>
                        <th scope=""col"">EndDate</th>
                        <th scope=""col"">Tags</th>
                        <th scope=""col"">Features</th>
                        <th scope=""col""></th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 31 "C:\Users\FX505GT\Desktop\Asp.Net Project\DirectList (Backend-Project)\DirectList (Backend-Project)\Areas\admin\Views\Restaurant\Index.cshtml"
                       int i = 1;
                        foreach (var restaurant in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <th scope=\"row\">");
#nullable restore
#line 35 "C:\Users\FX505GT\Desktop\Asp.Net Project\DirectList (Backend-Project)\DirectList (Backend-Project)\Areas\admin\Views\Restaurant\Index.cshtml"
                                                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                            <td style=\"width:100%\">\r\n");
#nullable restore
#line 37 "C:\Users\FX505GT\Desktop\Asp.Net Project\DirectList (Backend-Project)\DirectList (Backend-Project)\Areas\admin\Views\Restaurant\Index.cshtml"
                                                 foreach (var item in restaurant.RestaurantImages)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "38d9a143da9f0435d723353e2e25661dd354a7ae11984", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1677, "~/Uploads/", 1677, 10, true);
#nullable restore
#line 39 "C:\Users\FX505GT\Desktop\Asp.Net Project\DirectList (Backend-Project)\DirectList (Backend-Project)\Areas\admin\Views\Restaurant\Index.cshtml"
AddHtmlAttributeValue("", 1687, item.Image, 1687, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 40 "C:\Users\FX505GT\Desktop\Asp.Net Project\DirectList (Backend-Project)\DirectList (Backend-Project)\Areas\admin\Views\Restaurant\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </td>\r\n\r\n                                            <td style=\"max-width:200px;\">");
#nullable restore
#line 43 "C:\Users\FX505GT\Desktop\Asp.Net Project\DirectList (Backend-Project)\DirectList (Backend-Project)\Areas\admin\Views\Restaurant\Index.cshtml"
                                                                    Write(restaurant.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td style=\"max-width:400px;\">");
#nullable restore
#line 44 "C:\Users\FX505GT\Desktop\Asp.Net Project\DirectList (Backend-Project)\DirectList (Backend-Project)\Areas\admin\Views\Restaurant\Index.cshtml"
                                                                    Write(Html.Raw(restaurant.About.Length > 100 ? restaurant.About.Substring(0, 100) + " ..." : restaurant.About));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td style=\"max-width:200px;\">");
#nullable restore
#line 45 "C:\Users\FX505GT\Desktop\Asp.Net Project\DirectList (Backend-Project)\DirectList (Backend-Project)\Areas\admin\Views\Restaurant\Index.cshtml"
                                                                    Write(restaurant.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td style=\"max-width:200px;\">");
#nullable restore
#line 46 "C:\Users\FX505GT\Desktop\Asp.Net Project\DirectList (Backend-Project)\DirectList (Backend-Project)\Areas\admin\Views\Restaurant\Index.cshtml"
                                                                    Write(restaurant.Phone_1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td style=\"max-width:200px;\">");
#nullable restore
#line 47 "C:\Users\FX505GT\Desktop\Asp.Net Project\DirectList (Backend-Project)\DirectList (Backend-Project)\Areas\admin\Views\Restaurant\Index.cshtml"
                                                                    Write(restaurant.StartDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td style=\"max-width:200px;\">");
#nullable restore
#line 48 "C:\Users\FX505GT\Desktop\Asp.Net Project\DirectList (Backend-Project)\DirectList (Backend-Project)\Areas\admin\Views\Restaurant\Index.cshtml"
                                                                    Write(restaurant.EndDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                            <td style=\"max-width:200px;\">\r\n");
#nullable restore
#line 51 "C:\Users\FX505GT\Desktop\Asp.Net Project\DirectList (Backend-Project)\DirectList (Backend-Project)\Areas\admin\Views\Restaurant\Index.cshtml"
                                                  
                                                    if (restaurant.TagToRestaurants.Count > 0)
                                                    {
                                                        foreach (var tagToRestaurant in restaurant.TagToRestaurants)
                                                        {

                                                            if (tagToRestaurant.Tag != null)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <span>");
#nullable restore
#line 59 "C:\Users\FX505GT\Desktop\Asp.Net Project\DirectList (Backend-Project)\DirectList (Backend-Project)\Areas\admin\Views\Restaurant\Index.cshtml"
                                                                 Write(tagToRestaurant.Tag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 60 "C:\Users\FX505GT\Desktop\Asp.Net Project\DirectList (Backend-Project)\DirectList (Backend-Project)\Areas\admin\Views\Restaurant\Index.cshtml"
                                                            }
                                                        }
                                                    }
                                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </td>\r\n\r\n                                            <td style=\"max-width: 200px;\">\r\n");
#nullable restore
#line 67 "C:\Users\FX505GT\Desktop\Asp.Net Project\DirectList (Backend-Project)\DirectList (Backend-Project)\Areas\admin\Views\Restaurant\Index.cshtml"
                                                  
                                                    if (restaurant.FeaturesToRestaurants.Count > 0)
                                                    {

                                                        foreach (var featuresToRestaurant in restaurant.FeaturesToRestaurants)
                                                        {

                                                            if (featuresToRestaurant.Features != null)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <span>");
#nullable restore
#line 76 "C:\Users\FX505GT\Desktop\Asp.Net Project\DirectList (Backend-Project)\DirectList (Backend-Project)\Areas\admin\Views\Restaurant\Index.cshtml"
                                                                  Write( featuresToRestaurant.Features.Name + "----" );

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 77 "C:\Users\FX505GT\Desktop\Asp.Net Project\DirectList (Backend-Project)\DirectList (Backend-Project)\Areas\admin\Views\Restaurant\Index.cshtml"
                                                            }
                                                        }
                                                    }
                                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </td>\r\n\r\n                                            <td>\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38d9a143da9f0435d723353e2e25661dd354a7ae20573", async() => {
                WriteLiteral("Update");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 84 "C:\Users\FX505GT\Desktop\Asp.Net Project\DirectList (Backend-Project)\DirectList (Backend-Project)\Areas\admin\Views\Restaurant\Index.cshtml"
                                                                                                                                              WriteLiteral(restaurant.Id);

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
            WriteLiteral("\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38d9a143da9f0435d723353e2e25661dd354a7ae23430", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 85 "C:\Users\FX505GT\Desktop\Asp.Net Project\DirectList (Backend-Project)\DirectList (Backend-Project)\Areas\admin\Views\Restaurant\Index.cshtml"
                                                                                                                                             WriteLiteral(restaurant.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 88 "C:\Users\FX505GT\Desktop\Asp.Net Project\DirectList (Backend-Project)\DirectList (Backend-Project)\Areas\admin\Views\Restaurant\Index.cshtml"
                            i++;
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Restaurant>> Html { get; private set; }
    }
}
#pragma warning restore 1591
