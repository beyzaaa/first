#pragma checksum "C:\Users\safao\Desktop\Soruyorum-SQLite\Soruyorum\Soruyorum\Views\Home\Comments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93267510d9e55a5c71a7298a130447d4294109f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Comments), @"mvc.1.0.view", @"/Views/Home/Comments.cshtml")]
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
#line 1 "C:\Users\safao\Desktop\Soruyorum-SQLite\Soruyorum\Soruyorum\Views\_ViewImports.cshtml"
using Soruyorum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\safao\Desktop\Soruyorum-SQLite\Soruyorum\Soruyorum\Views\_ViewImports.cshtml"
using Soruyorum.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93267510d9e55a5c71a7298a130447d4294109f6", @"/Views/Home/Comments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93303847d5a02bd910e9e2d683e3af97c91145e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Comments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Comments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\safao\Desktop\Soruyorum-SQLite\Soruyorum\Soruyorum\Views\Home\Comments.cshtml"
  
    ViewData["Title"] = "Comments";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"card\">\r\n    <h5 class=\"card-header\">");
#nullable restore
#line 7 "C:\Users\safao\Desktop\Soruyorum-SQLite\Soruyorum\Soruyorum\Views\Home\Comments.cshtml"
                       Write(ViewBag.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n    <div class=\"card-body\">\r\n        <h5 class=\"card-title\">");
#nullable restore
#line 9 "C:\Users\safao\Desktop\Soruyorum-SQLite\Soruyorum\Soruyorum\Views\Home\Comments.cshtml"
                          Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <p class=\"card-text\">");
#nullable restore
#line 10 "C:\Users\safao\Desktop\Soruyorum-SQLite\Soruyorum\Soruyorum\Views\Home\Comments.cshtml"
                        Write(ViewBag.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n<h5 class=\"ml-3\">  Comments</h5>\r\n\r\n");
#nullable restore
#line 15 "C:\Users\safao\Desktop\Soruyorum-SQLite\Soruyorum\Soruyorum\Views\Home\Comments.cshtml"
 foreach (var comment in ViewBag.Comments)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card\">\r\n        <div class=\"card-header\">\r\n            ");
#nullable restore
#line 19 "C:\Users\safao\Desktop\Soruyorum-SQLite\Soruyorum\Soruyorum\Views\Home\Comments.cshtml"
       Write(comment.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"card-body\">\r\n            <blockquote class=\"blockquote mb-0\">\r\n                <footer class=\"blockquote-footer\">");
#nullable restore
#line 23 "C:\Users\safao\Desktop\Soruyorum-SQLite\Soruyorum\Soruyorum\Views\Home\Comments.cshtml"
                                             Write(comment.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</footer>\r\n            </blockquote>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 27 "C:\Users\safao\Desktop\Soruyorum-SQLite\Soruyorum\Soruyorum\Views\Home\Comments.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h5 class=\"ml-3\">Yorum yap</h5>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93267510d9e55a5c71a7298a130447d4294109f67018", async() => {
                WriteLiteral(@"


    <div class=""form-group"">
        <label for=""exampleFormControlTextarea1"">Yorum</label>
        <textarea class=""form-control"" id=""exampleFormControlTextarea1"" rows=""3"" name=""Text""></textarea>
    </div>
    <div class=""form-group "">
        <button type=""submit"" class=""btn btn-primary btn-block"">Yayınla</button>
    </div>
    <textarea style=""display:none;"" class=""form-control"" id=""exampleFormControlTextarea1474"" rows=""3"" name=""QuestionId"">");
#nullable restore
#line 42 "C:\Users\safao\Desktop\Soruyorum-SQLite\Soruyorum\Soruyorum\Views\Home\Comments.cshtml"
                                                                                                                   Write(ViewBag.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\r\n\r\n\r\n\r\n    <hr />\r\n    ");
#nullable restore
#line 47 "C:\Users\safao\Desktop\Soruyorum-SQLite\Soruyorum\Soruyorum\Views\Home\Comments.cshtml"
Write(ViewBag.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
