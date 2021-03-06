#pragma checksum "/Users/daniel/Projects/gotcha_web/Views/Dashboard/Game/index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48872db73f0a152446928999da72c454c695a74f"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48872db73f0a152446928999da72c454c695a74f", @"/Views/Dashboard/Game/index.cshtml")]
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
    ViewData["Title"] = "Spellen";
    Layout = "~/Views/Shared/_LayoutDashboard.cshtml";   
    var games = (List<Game>)ViewData["games"];
    var gameleaderrights = HttpContextAccessor.HttpContext.Session.GetString("loggedinas") == "gameleader"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "48872db73f0a152446928999da72c454c695a74f4029", async() => {
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
            WriteLiteral("</partial>\n\n\n<div class=\"games-container\">\n    \n\n");
#nullable restore
#line 22 "/Users/daniel/Projects/gotcha_web/Views/Dashboard/Game/index.cshtml"
      
        if(games.Count == 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"nogamesmessage\">Er zijn nog geen spellen</p>\n");
#nullable restore
#line 25 "/Users/daniel/Projects/gotcha_web/Views/Dashboard/Game/index.cshtml"
            if(gameleaderrights){

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a href=\"CreateGame\" class=\"button button-red\">Maak een spel</a>\n");
#nullable restore
#line 27 "/Users/daniel/Projects/gotcha_web/Views/Dashboard/Game/index.cshtml"
                }
        } else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"games-list\">\n");
#nullable restore
#line 30 "/Users/daniel/Projects/gotcha_web/Views/Dashboard/Game/index.cshtml"
          
            foreach(var x in games){
                var wordgame = x.GetType().Name == "WordGame";
                var gamestatus = x.Active ? "Spel is al bezig" : "Spel is nog niet begonnen";

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 977, "\"", 1076, 4);
            WriteAttributeValue("", 984, "/Dashboard/", 984, 11, true);
            WriteAttributeValue("", 995, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 34 "/Users/daniel/Projects/gotcha_web/Views/Dashboard/Game/index.cshtml"
                                     if(wordgame){

#line default
#line hidden
#nullable disable
                WriteLiteral("WordGameDetail");
#nullable restore
#line 34 "/Users/daniel/Projects/gotcha_web/Views/Dashboard/Game/index.cshtml"
                                                                             }else{

#line default
#line hidden
#nullable disable
                WriteLiteral("GameDetail");
#nullable restore
#line 34 "/Users/daniel/Projects/gotcha_web/Views/Dashboard/Game/index.cshtml"
                                                                                                          }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 995, 71, false);
            WriteAttributeValue("", 1066, "/", 1066, 1, true);
#nullable restore
#line 34 "/Users/daniel/Projects/gotcha_web/Views/Dashboard/Game/index.cshtml"
WriteAttributeValue("", 1067, x.GameId, 1067, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"game-item\">\n                <div class=\"game-item-innercont\">\n                    <div class=\"game-item-left\">\n                    <h3>");
#nullable restore
#line 37 "/Users/daniel/Projects/gotcha_web/Views/Dashboard/Game/index.cshtml"
                   Write(x.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                    <p>Speltype: ");
#nullable restore
#line 38 "/Users/daniel/Projects/gotcha_web/Views/Dashboard/Game/index.cshtml"
                                  if(x.GetType().Name == "WordGame"){

#line default
#line hidden
#nullable disable
            WriteLiteral("Woordspel");
#nullable restore
#line 38 "/Users/daniel/Projects/gotcha_web/Views/Dashboard/Game/index.cshtml"
                                                                                           }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("Normaal spel");
#nullable restore
#line 38 "/Users/daniel/Projects/gotcha_web/Views/Dashboard/Game/index.cshtml"
                                                                                                                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <p>Van: <span>");
#nullable restore
#line 39 "/Users/daniel/Projects/gotcha_web/Views/Dashboard/Game/index.cshtml"
                             Write(x.GameLeader.alias);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\n\n                    </div>\n                    <div>\n                        <p>");
#nullable restore
#line 43 "/Users/daniel/Projects/gotcha_web/Views/Dashboard/Game/index.cshtml"
                      Write(gamestatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n                    </div>\n                    <div class=\"game-item-right\">\n                        <span class=\"material-icons\">people</span>\n                        <span class=\"count\">");
#nullable restore
#line 48 "/Users/daniel/Projects/gotcha_web/Views/Dashboard/Game/index.cshtml"
                                       Write(x.GetPlayerCount());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                    </div>\n                    </div>\n                </a>\n");
#nullable restore
#line 52 "/Users/daniel/Projects/gotcha_web/Views/Dashboard/Game/index.cshtml"
            }   
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n");
#nullable restore
#line 55 "/Users/daniel/Projects/gotcha_web/Views/Dashboard/Game/index.cshtml"
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
