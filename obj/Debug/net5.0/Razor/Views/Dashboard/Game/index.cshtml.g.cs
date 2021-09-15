#pragma checksum "/Users/daniel/Projects/gotcha_web/Views/Dashboard/Game/index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db889ea9efb3d23089e77b178cba10cac4b2bd65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Game_index), @"mvc.1.0.view", @"/Views/Dashboard/Game/index.cshtml")]
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
#line 1 "/Users/daniel/Projects/gotcha_web/Views/_ViewImports.cshtml"
using gotcha_web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/daniel/Projects/gotcha_web/Views/_ViewImports.cshtml"
using gotcha_web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/daniel/Projects/gotcha_web/Views/Dashboard/Game/index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/daniel/Projects/gotcha_web/Views/Dashboard/Game/index.cshtml"
using gotcha_web.util;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db889ea9efb3d23089e77b178cba10cac4b2bd65", @"/Views/Dashboard/Game/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a70d52ce7354a726aabab18612a0c3f9aad00feb", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Game_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_GameNav", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "/Users/daniel/Projects/gotcha_web/Views/Dashboard/Game/index.cshtml"
    ViewData["active"] = "Spellen";
    Layout = "~/Views/Shared/_LayoutDashboard.cshtml";   
    var games = (List<Game>)ViewData["games"];
    var gameleaderrights = HttpContextAccessor.HttpContext.Session.GetString("loggedinas") == "gameleader"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "db889ea9efb3d23089e77b178cba10cac4b2bd654030", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</partial>\n\n\n<div class=\"games-container\">\n    \n    <div class=\"games-list\">\n");
#nullable restore
#line 22 "/Users/daniel/Projects/gotcha_web/Views/Dashboard/Game/index.cshtml"
          
            foreach(var x in games){
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 572, "\"", 589, 2);
            WriteAttributeValue("", 579, "/", 579, 1, true);
#nullable restore
#line 25 "/Users/daniel/Projects/gotcha_web/Views/Dashboard/Game/index.cshtml"
WriteAttributeValue("", 580, x.GameId, 580, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"game-item\">\n                    <h3>");
#nullable restore
#line 26 "/Users/daniel/Projects/gotcha_web/Views/Dashboard/Game/index.cshtml"
                   Write(x.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                </a>\n");
#nullable restore
#line 28 "/Users/daniel/Projects/gotcha_web/Views/Dashboard/Game/index.cshtml"
            }   
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n");
#nullable restore
#line 31 "/Users/daniel/Projects/gotcha_web/Views/Dashboard/Game/index.cshtml"
      
        if(games.Count == 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"nogamesmessage\">Er zijn nog geen games</p>\n");
#nullable restore
#line 34 "/Users/daniel/Projects/gotcha_web/Views/Dashboard/Game/index.cshtml"
            if(gameleaderrights){

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button>Maak een game</button>\n");
#nullable restore
#line 36 "/Users/daniel/Projects/gotcha_web/Views/Dashboard/Game/index.cshtml"
                }
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    \n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
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