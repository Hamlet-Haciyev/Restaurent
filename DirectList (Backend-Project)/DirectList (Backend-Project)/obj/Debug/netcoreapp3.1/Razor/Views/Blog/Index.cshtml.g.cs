#pragma checksum "C:\Users\FX505GT\Desktop\Asp.Net Project\DirectList (Backend-Project)\DirectList (Backend-Project)\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f54a9c007eebeaaf73e6ca93135d93a77b9137ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 1 "C:\Users\FX505GT\Desktop\Asp.Net Project\DirectList (Backend-Project)\DirectList (Backend-Project)\Views\_ViewImports.cshtml"
using DirectList__Backend_Project_;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\FX505GT\Desktop\Asp.Net Project\DirectList (Backend-Project)\DirectList (Backend-Project)\Views\_ViewImports.cshtml"
using DirectList__Backend_Project_.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\FX505GT\Desktop\Asp.Net Project\DirectList (Backend-Project)\DirectList (Backend-Project)\Views\_ViewImports.cshtml"
using DirectList__Backend_Project_.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\FX505GT\Desktop\Asp.Net Project\DirectList (Backend-Project)\DirectList (Backend-Project)\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f54a9c007eebeaaf73e6ca93135d93a77b9137ab", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c1d06de07b062fa06f6ab954d7aa179e0e0d6fd", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VmBlog>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_BannerPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("search-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\FX505GT\Desktop\Asp.Net Project\DirectList (Backend-Project)\DirectList (Backend-Project)\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"main-wrapper\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f54a9c007eebeaaf73e6ca93135d93a77b9137ab7469", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 7 "C:\Users\FX505GT\Desktop\Asp.Net Project\DirectList (Backend-Project)\DirectList (Backend-Project)\Views\Blog\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.Banner;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <!-- Content -->
    <div class=""content"">
        <div class=""container"">
            <!-- Blog Posts -->
            <div class=""blog-page"">
                <div class=""row"">
                    <div class=""col-lg-9 col-md-8 padding-right-30"">
                        <!-- Blog Post -->
");
#nullable restore
#line 16 "C:\Users\FX505GT\Desktop\Asp.Net Project\DirectList (Backend-Project)\DirectList (Backend-Project)\Views\Blog\Index.cshtml"
                         foreach (var item in Model.Blogs)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"card card-lift--hover shadow border-0 mb-4\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f54a9c007eebeaaf73e6ca93135d93a77b9137ab9839", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 701, "~/Uploads/", 701, 10, true);
#nullable restore
#line 19 "C:\Users\FX505GT\Desktop\Asp.Net Project\DirectList (Backend-Project)\DirectList (Backend-Project)\Views\Blog\Index.cshtml"
AddHtmlAttributeValue("", 711, item.Image, 711, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <div class=\"card-body py-4\">\r\n                                    <h5 class=\"text-primary\">");
#nullable restore
#line 21 "C:\Users\FX505GT\Desktop\Asp.Net Project\DirectList (Backend-Project)\DirectList (Backend-Project)\Views\Blog\Index.cshtml"
                                                        Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                    <p class=\"text-primary\">");
#nullable restore
#line 22 "C:\Users\FX505GT\Desktop\Asp.Net Project\DirectList (Backend-Project)\DirectList (Backend-Project)\Views\Blog\Index.cshtml"
                                                       Write(item.CreatedDate.ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <p class=\"description mt-3\">");
#nullable restore
#line 23 "C:\Users\FX505GT\Desktop\Asp.Net Project\DirectList (Backend-Project)\DirectList (Backend-Project)\Views\Blog\Index.cshtml"
                                                           Write(item.About);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f54a9c007eebeaaf73e6ca93135d93a77b9137ab12810", async() => {
                WriteLiteral("Read More");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
#line 24 "C:\Users\FX505GT\Desktop\Asp.Net Project\DirectList (Backend-Project)\DirectList (Backend-Project)\Views\Blog\Index.cshtml"
                                                                                                           WriteLiteral(item.Id);

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
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 27 "C:\Users\FX505GT\Desktop\Asp.Net Project\DirectList (Backend-Project)\DirectList (Backend-Project)\Views\Blog\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                       
                    </div>
                    <!-- Blog Posts / End -->
                    <!-- Widgets -->
                    <div class=""col-lg-3 col-md-4"">
                        <div class=""sidebar right"">
                            <!-- Widget -->
                            <div class=""widget"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f54a9c007eebeaaf73e6ca93135d93a77b9137ab16083", async() => {
                WriteLiteral(@"
                                    <div class=""form-group"">
                                        <div class=""input-group mb-4"">
                                            <div class=""input-group-prepend"">
                                                <span class=""input-group-text""><i class=""fa fa-search""></i></span>
                                            </div>
                                            <input class=""form-control"" placeholder=""Search"" type=""text"" name=""searchData"">
                                        </div>
                                    </div>
                                  
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                            <div class=""widget margin-top-40"">
                                <h3>Popular Posts</h3>
                                <ul class=""widget-tabs"">
                                    <!-- Post #1 -->
");
#nullable restore
#line 52 "C:\Users\FX505GT\Desktop\Asp.Net Project\DirectList (Backend-Project)\DirectList (Backend-Project)\Views\Blog\Index.cshtml"
                                     foreach (var item in Model.PopularPosts)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <li>
                                            <div class=""widget-content"">
                                                <div class=""widget-thumb"">
                                                    <a href=""#"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f54a9c007eebeaaf73e6ca93135d93a77b9137ab19576", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3099, "~/Uploads/", 3099, 10, true);
#nullable restore
#line 57 "C:\Users\FX505GT\Desktop\Asp.Net Project\DirectList (Backend-Project)\DirectList (Backend-Project)\Views\Blog\Index.cshtml"
AddHtmlAttributeValue("", 3109, item.Image, 3109, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                                                </div>\r\n                                                <div class=\"widget-text\">\r\n                                                    <h5><a href=\"#\">");
#nullable restore
#line 60 "C:\Users\FX505GT\Desktop\Asp.Net Project\DirectList (Backend-Project)\DirectList (Backend-Project)\Views\Blog\Index.cshtml"
                                                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\r\n                                                    <span>");
#nullable restore
#line 61 "C:\Users\FX505GT\Desktop\Asp.Net Project\DirectList (Backend-Project)\DirectList (Backend-Project)\Views\Blog\Index.cshtml"
                                                     Write(item.CreatedDate.ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                </div>\r\n                                                <div class=\"clearfix\"></div>\r\n                                            </div>\r\n                                        </li>\r\n");
#nullable restore
#line 66 "C:\Users\FX505GT\Desktop\Asp.Net Project\DirectList (Backend-Project)\DirectList (Backend-Project)\Views\Blog\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <!-- Post #2 -->
                                    <!--<li>
        <div class=""widget-content"">
            <div class=""widget-thumb"">
                <a href=""#""><img src=""assets/images/bw-2.jpg"" alt=""image""></a>
            </div>
            <div class=""widget-text"">
                <h5><a href=""#"">The 50 Greatest Street Arts In London</a></h5>
                <span>November 9, 2016</span>
            </div>
            <div class=""clearfix""></div>
        </div>
    </li>-->
                                    <!-- Post #3 -->
                                    <!--<li>
        <div class=""widget-content"">
            <div class=""widget-thumb"">
                <a href=""3.html""><img src=""assets/images/bw-3.jpg"" alt=""image""></a>
            </div>
            <div class=""widget-text"">
                <h5><a href=""#"">The Best Cofee Shops In Sydney Neighborhoods</a></h5>
                <span>November 12, 2016</span>
            </div>
           ");
            WriteLiteral(@" <div class=""clearfix""></div>
        </div>
    </li>-->
                                </ul>
                            </div>
                            <!-- Widget / End-->
                            <!-- Widget -->
                            <div class=""widget margin-top-40"">
                                <h3 class=""margin-bottom-25"">Social</h3>
                                <div class=""btn-wrapper"">
");
#nullable restore
#line 100 "C:\Users\FX505GT\Desktop\Asp.Net Project\DirectList (Backend-Project)\DirectList (Backend-Project)\Views\Blog\Index.cshtml"
                                     foreach (var item in Model.Socials)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a target=\"_blank\"");
            BeginWriteAttribute("href", " href=\"", 5365, "\"", 5382, 1);
#nullable restore
#line 102 "C:\Users\FX505GT\Desktop\Asp.Net Project\DirectList (Backend-Project)\DirectList (Backend-Project)\Views\Blog\Index.cshtml"
WriteAttributeValue("", 5372, item.Link, 5372, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-neutral btn-icon-only btn-twitter btn-round btn-lg\" data-toggle=\"tooltip\" data-original-title=\"Follow us\">\r\n                                            <i");
            BeginWriteAttribute("class", " class=\"", 5553, "\"", 5571, 1);
#nullable restore
#line 103 "C:\Users\FX505GT\Desktop\Asp.Net Project\DirectList (Backend-Project)\DirectList (Backend-Project)\Views\Blog\Index.cshtml"
WriteAttributeValue("", 5561, item.Icon, 5561, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                                        </a>\r\n");
#nullable restore
#line 105 "C:\Users\FX505GT\Desktop\Asp.Net Project\DirectList (Backend-Project)\DirectList (Backend-Project)\Views\Blog\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <!-- Widget / End-->
                            <div class=""clearfix""></div>
                            <div class=""margin-bottom-40""></div>
                        </div>
                    </div>
                </div>
                <!-- Sidebar / End -->
            </div>
        </div>
    </div>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VmBlog> Html { get; private set; }
    }
}
#pragma warning restore 1591
