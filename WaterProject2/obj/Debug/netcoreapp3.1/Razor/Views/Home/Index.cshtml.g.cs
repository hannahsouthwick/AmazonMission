#pragma checksum "/Users/hannahsouthwick/Documents/GitHub/WaterProject2/WaterProject2/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f203c249397893b61bb06d64a3e1f3cd440abecd"
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
#line 1 "/Users/hannahsouthwick/Documents/GitHub/WaterProject2/WaterProject2/Views/_ViewImports.cshtml"
using WaterProject2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/hannahsouthwick/Documents/GitHub/WaterProject2/WaterProject2/Views/_ViewImports.cshtml"
using WaterProject2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/hannahsouthwick/Documents/GitHub/WaterProject2/WaterProject2/Views/_ViewImports.cshtml"
using WaterProject2.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f203c249397893b61bb06d64a3e1f3cd440abecd", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd8a45ceb702fc56766a6acda9d874e236d942ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::WaterProject2.Infrastructure.PaginationTagHelper __WaterProject2_Infrastructure_PaginationTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/hannahsouthwick/Documents/GitHub/WaterProject2/WaterProject2/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Index Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>");
#nullable restore
#line 6 "/Users/hannahsouthwick/Documents/GitHub/WaterProject2/WaterProject2/Views/Home/Index.cshtml"
Write(ViewBag.Calc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n<div class=\"text-center\">\n    <h1>The Water Project</h1>\n</div>\n");
#nullable restore
#line 10 "/Users/hannahsouthwick/Documents/GitHub/WaterProject2/WaterProject2/Views/Home/Index.cshtml"
 foreach (Project p in Model.Projects)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>");
#nullable restore
#line 12 "/Users/hannahsouthwick/Documents/GitHub/WaterProject2/WaterProject2/Views/Home/Index.cshtml"
   Write(p.ProjectName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n    <ul>\n        <li>Project Type: ");
#nullable restore
#line 14 "/Users/hannahsouthwick/Documents/GitHub/WaterProject2/WaterProject2/Views/Home/Index.cshtml"
                     Write(p.ProjectType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n        <li>Regional Program: ");
#nullable restore
#line 15 "/Users/hannahsouthwick/Documents/GitHub/WaterProject2/WaterProject2/Views/Home/Index.cshtml"
                         Write(p.ProjectRegionalProgram);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n        <li>Impact: ");
#nullable restore
#line 16 "/Users/hannahsouthwick/Documents/GitHub/WaterProject2/WaterProject2/Views/Home/Index.cshtml"
               Write(p.ProjectImpact);

#line default
#line hidden
#nullable disable
            WriteLiteral(" served</li>\n        <li>Project Phase: ");
#nullable restore
#line 17 "/Users/hannahsouthwick/Documents/GitHub/WaterProject2/WaterProject2/Views/Home/Index.cshtml"
                      Write(p.ProjectPhase);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n        <li>Project Status: ");
#nullable restore
#line 18 "/Users/hannahsouthwick/Documents/GitHub/WaterProject2/WaterProject2/Views/Home/Index.cshtml"
                       Write(p.ProjectFunctionalityStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n    </ul>\n    <br />\n");
#nullable restore
#line 21 "/Users/hannahsouthwick/Documents/GitHub/WaterProject2/WaterProject2/Views/Home/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f203c249397893b61bb06d64a3e1f3cd440abecd6177", async() => {
            }
            );
            __WaterProject2_Infrastructure_PaginationTagHelper = CreateTagHelper<global::WaterProject2.Infrastructure.PaginationTagHelper>();
            __tagHelperExecutionContext.Add(__WaterProject2_Infrastructure_PaginationTagHelper);
#nullable restore
#line 23 "/Users/hannahsouthwick/Documents/GitHub/WaterProject2/WaterProject2/Views/Home/Index.cshtml"
__WaterProject2_Infrastructure_PaginationTagHelper.PageBlah = Model.PageInfo;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-blah", __WaterProject2_Infrastructure_PaginationTagHelper.PageBlah, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __WaterProject2_Infrastructure_PaginationTagHelper.PageAction = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
