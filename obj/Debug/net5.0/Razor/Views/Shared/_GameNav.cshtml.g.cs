#pragma checksum "/Users/daniel/Projects/gotcha_web/Views/Shared/_GameNav.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab2b44ec58486968df44f2b5ea1774f734fec140"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__GameNav), @"mvc.1.0.view", @"/Views/Shared/_GameNav.cshtml")]
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
#line 2 "/Users/daniel/Projects/gotcha_web/Views/Shared/_GameNav.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/daniel/Projects/gotcha_web/Views/Shared/_GameNav.cshtml"
using gotcha_web.util;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab2b44ec58486968df44f2b5ea1774f734fec140", @"/Views/Shared/_GameNav.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a70d52ce7354a726aabab18612a0c3f9aad00feb", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__GameNav : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "/Users/daniel/Projects/gotcha_web/Views/Shared/_GameNav.cshtml"
 
    var alias = HttpContextAccessor.HttpContext.Session.GetString("alias");
    var gameleaderrights = HttpContextAccessor.HttpContext.Session.GetString("loggedinas") == "gameleader"; 
  
    var links = new List<Link>{
       new Link("Alle spellen", "Games"),
       new Link("Zoek naar een spel", "Findgame"),
        new Link("Spellen waar ik deel aan neem", "Mygamespl"),
    };
    if (gameleaderrights){
        links.Add(new Link("Spellen die ik beheer", "Mygamesgl"));
        links.Add(new Link("Maak een spel", "CreateGame"));
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n<header class=\"game-header\">\n    <div class=\"banner\"></div>\n    <div class=\"game-nav-container\">\n        <ul>\n");
#nullable restore
#line 26 "/Users/daniel/Projects/gotcha_web/Views/Shared/_GameNav.cshtml"
              
                
                foreach(var x in links){

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li><a");
            BeginWriteAttribute("href", " href=\"", 886, "\"", 900, 1);
#nullable restore
#line 29 "/Users/daniel/Projects/gotcha_web/Views/Shared/_GameNav.cshtml"
WriteAttributeValue("", 893, x.path, 893, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 29 "/Users/daniel/Projects/gotcha_web/Views/Shared/_GameNav.cshtml"
                                     Write(x.linktext);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\n");
#nullable restore
#line 30 "/Users/daniel/Projects/gotcha_web/Views/Shared/_GameNav.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\n    </div>\n\n</header>");
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
