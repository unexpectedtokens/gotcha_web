#pragma checksum "/Users/daniel/Projects/gotcha_web/Views/Shared/_GameDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27815ca3a624c690314a1977fe94135a04d69e4c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__GameDetail), @"mvc.1.0.view", @"/Views/Shared/_GameDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27815ca3a624c690314a1977fe94135a04d69e4c", @"/Views/Shared/_GameDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a70d52ce7354a726aabab18612a0c3f9aad00feb", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__GameDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Nav", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 2 "/Users/daniel/Projects/gotcha_web/Views/Shared/_GameDetail.cshtml"
  
    ViewData["render_db_home"] = true;
    ViewData["NavDark"] = true;
    var active = Convert.ToBoolean(ViewData["gameactive"]);
    var owner = Convert.ToBoolean(ViewData["owner"]);
    var inGame = Convert.ToBoolean(ViewData["playerInGame"]);
    var playercount = Convert.ToInt32(ViewData["playercount"]);
    var gameid = ViewData["Gameid"];
    var players = (ICollection<Player>)ViewData["players"];
    var playerEliminated = Convert.ToBoolean(ViewData["playereliminated"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div class=\"container p2\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "27815ca3a624c690314a1977fe94135a04d69e4c3971", async() => {
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
            WriteLiteral("</partial>\n</div>\n\n\n\n<div class=\"container p2\">\n    <div class=\"game-detail-container\">\n        <div>\n            <h1>");
#nullable restore
#line 24 "/Users/daniel/Projects/gotcha_web/Views/Shared/_GameDetail.cshtml"
           Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>\n            <div><span class=\"material-icons\">people</span>\n                        <span class=\"count\">");
#nullable restore
#line 26 "/Users/daniel/Projects/gotcha_web/Views/Shared/_GameDetail.cshtml"
                                       Write(playercount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\n        </div>\n        <p>Van: <span class=\"gameleader\">");
#nullable restore
#line 28 "/Users/daniel/Projects/gotcha_web/Views/Shared/_GameDetail.cshtml"
                                    Write(ViewData["gameleaderalias"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></span>\n        <p><span>Beschrijving</span>: ");
#nullable restore
#line 29 "/Users/daniel/Projects/gotcha_web/Views/Shared/_GameDetail.cshtml"
                                 Write(ViewData["description"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 30 "/Users/daniel/Projects/gotcha_web/Views/Shared/_GameDetail.cshtml"
          
            if(!owner && !inGame && !active){

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\'", 1053, "\'", 1087, 2);
            WriteAttributeValue("", 1060, "/Dashboard/JoinGame/", 1060, 20, true);
#nullable restore
#line 32 "/Users/daniel/Projects/gotcha_web/Views/Shared/_GameDetail.cshtml"
WriteAttributeValue("", 1080, gameid, 1080, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"join-game\">Neem deel aan spel</a>\n");
#nullable restore
#line 33 "/Users/daniel/Projects/gotcha_web/Views/Shared/_GameDetail.cshtml"
            }else if(owner && playercount >= 3){
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "/Users/daniel/Projects/gotcha_web/Views/Shared/_GameDetail.cshtml"
                 if(!active){

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 1231, "\"", 1266, 2);
            WriteAttributeValue("", 1238, "/Dashboard/StartGame/", 1238, 21, true);
#nullable restore
#line 35 "/Users/daniel/Projects/gotcha_web/Views/Shared/_GameDetail.cshtml"
WriteAttributeValue("", 1259, gameid, 1259, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"join-game\">Start spel</a>\n");
#nullable restore
#line 36 "/Users/daniel/Projects/gotcha_web/Views/Shared/_GameDetail.cshtml"
                }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 1346, "\"", 1380, 2);
            WriteAttributeValue("", 1353, "/Dashboard/StopGame/", 1353, 20, true);
#nullable restore
#line 37 "/Users/daniel/Projects/gotcha_web/Views/Shared/_GameDetail.cshtml"
WriteAttributeValue("", 1373, gameid, 1373, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"join-game\">Stop spel</a>\n");
#nullable restore
#line 38 "/Users/daniel/Projects/gotcha_web/Views/Shared/_GameDetail.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "/Users/daniel/Projects/gotcha_web/Views/Shared/_GameDetail.cshtml"
                 
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n");
#nullable restore
#line 42 "/Users/daniel/Projects/gotcha_web/Views/Shared/_GameDetail.cshtml"
     if(owner){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"players-container\">\n            <h2>Spelers</h2>\n            <div>\n");
#nullable restore
#line 46 "/Users/daniel/Projects/gotcha_web/Views/Shared/_GameDetail.cshtml"
                 if(playercount == 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>Er zitten nog geen spelers in dit spel</p>\n");
#nullable restore
#line 48 "/Users/daniel/Projects/gotcha_web/Views/Shared/_GameDetail.cshtml"
                }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"playeritems\">\n");
#nullable restore
#line 50 "/Users/daniel/Projects/gotcha_web/Views/Shared/_GameDetail.cshtml"
                         foreach (var p in players)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"playeritem\">\n                                <p><span>");
#nullable restore
#line 53 "/Users/daniel/Projects/gotcha_web/Views/Shared/_GameDetail.cshtml"
                                    Write(p.alias);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>");
#nullable restore
#line 53 "/Users/daniel/Projects/gotcha_web/Views/Shared/_GameDetail.cshtml"
                                                         if(playerEliminated){

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"eliminated\">Geëlimineerd</span>");
#nullable restore
#line 53 "/Users/daniel/Projects/gotcha_web/Views/Shared/_GameDetail.cshtml"
                                                                                                                          }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"active\">Actief</span>");
#nullable restore
#line 53 "/Users/daniel/Projects/gotcha_web/Views/Shared/_GameDetail.cshtml"
                                                                                                                                                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            </div>\n");
#nullable restore
#line 55 "/Users/daniel/Projects/gotcha_web/Views/Shared/_GameDetail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\n");
#nullable restore
#line 57 "/Users/daniel/Projects/gotcha_web/Views/Shared/_GameDetail.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n        </div>\n");
#nullable restore
#line 60 "/Users/daniel/Projects/gotcha_web/Views/Shared/_GameDetail.cshtml"
        
        
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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