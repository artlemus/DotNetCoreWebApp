#pragma checksum "C:\Users\Workstation11\Documents\110\erp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9431605d79aab000596eb5d67fac079a8d22310"
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
#line 1 "C:\Users\Workstation11\Documents\110\erp\Views\_ViewImports.cshtml"
using erp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Workstation11\Documents\110\erp\Views\_ViewImports.cshtml"
using erp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9431605d79aab000596eb5d67fac079a8d22310", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f7b04bb051901386e86885a6a55dc6ed5754237", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Workstation11\Documents\110\erp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9431605d79aab000596eb5d67fac079a8d223103168", async() => {
                WriteLiteral(@"
    <header class=""header-image container"">
    

    <h2>The best Selection or rentals!</h2>
    
    <blockquote class=""blockquote"">
  <p class=""mb-0"">It will cost you nothing to dream, And everything not to.</p>
  <footer class=""blockquote-footer blcquote-footer"">Unknown</footer>
    </blockquote>

</header>


<div class=""slider container"">
<div id=""carouselExampleIndicators"" class=""carousel slide"" style="" width:600px !important; height: 400px !important;"" data-ride=""carousel"">
  <ol class=""carousel-indicators"">
    <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
    <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li>
    <li data-target=""#carouselExampleIndicators"" data-slide-to=""2""></li>
  </ol>

  <div class=""carousel-inner"">
    <div class=""carousel-item active"">
      <img class=""d-block w-100"" src=""/images/rallycar1.jpg"" alt=""First slide"" style="" width:600px !important; height: 400px !important; text-align: center;"">
    <");
                WriteLiteral(@"/div>
    <div class=""carousel-item"">
      <img class=""d-block w-100"" src=""/images/rallycar2.jpg"" alt=""Second slide"" style="" width:600px !important; height: 400px !important; text-align: center;"">
    </div>
    <div class=""carousel-item"">
      <img class=""d-block w-100"" src=""/images/rallycar3.jpg"" alt=""Third slide"" style="" width:600px !important; height: 400px !important; text-align: center;"">
    </div>
  </div>
  <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
    <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
    <span class=""sr-only"">Previous</span>
  </a>
  <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
    <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
    <span class=""sr-only"">Next</span>
  </a>
</div>
 <div class=""col-sm-4"">
    <div class=""card"">
      <div class=""card-body"">
        <h5 class=""card-title"">Check out our Catalog!</h5>");
                WriteLiteral("\r\n        <p class=\"card-text\">Awesome new deals daily!</p>\r\n        <a href=\"/catalog/index\" class=\"btn btn-primary\">Click Here!</a>\r\n      </div>\r\n    </div>\r\n  </div>\r\n</div>\r\n\r\n  \r\n\r\n\r\n\r\n");
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
            WriteLiteral("\r\n\r\n\r\n\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"/css/home.css\">\r\n");
            }
            );
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
