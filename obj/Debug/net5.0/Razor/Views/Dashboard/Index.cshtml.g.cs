#pragma checksum "/Users/daniel/Projects/gotcha_web/Views/Dashboard/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d10bba65f43a2b7fa71a723a59eabba68843740"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
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
#line 2 "/Users/daniel/Projects/gotcha_web/Views/Dashboard/Index.cshtml"
using gotcha_web.util;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d10bba65f43a2b7fa71a723a59eabba68843740", @"/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a70d52ce7354a726aabab18612a0c3f9aad00feb", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 4 "/Users/daniel/Projects/gotcha_web/Views/Dashboard/Index.cshtml"
  
    Layout = "~/Views/Shared/_LayoutDashboard.cshtml";
    ViewData["title"] = "Home";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div class=\"container p2\">\n    <div class=\"main-dashboard-container\">\n        <h1>Welkom ");
#nullable restore
#line 13 "/Users/daniel/Projects/gotcha_web/Views/Dashboard/Index.cshtml"
              Write(ViewData["user"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n    <ul class=\"main-dashboard-links\">\n");
#nullable restore
#line 15 "/Users/daniel/Projects/gotcha_web/Views/Dashboard/Index.cshtml"
          
            //Hier links toevoegen voor het dashboard
            var links = new List<Link>{
            new Link("Spellen", "Games"),
            new Link("Mijn profiel", "Profile"),
            new Link("Log uit", "Logout")
            };

            foreach(var x in links)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li><a");
            BeginWriteAttribute("href", " href=\"", 601, "\"", 626, 2);
            WriteAttributeValue("", 608, "/Dashboard/", 608, 11, true);
#nullable restore
#line 25 "/Users/daniel/Projects/gotcha_web/Views/Dashboard/Index.cshtml"
WriteAttributeValue("", 619, x.path, 619, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 25 "/Users/daniel/Projects/gotcha_web/Views/Dashboard/Index.cshtml"
                                                  if((String)ViewData["active"]== x.linktext){

#line default
#line hidden
#nullable disable
            WriteLiteral("class=\"active\"");
#nullable restore
#line 25 "/Users/daniel/Projects/gotcha_web/Views/Dashboard/Index.cshtml"
                                                                                                                         }

#line default
#line hidden
#nullable disable
            WriteLiteral(">");
#nullable restore
#line 25 "/Users/daniel/Projects/gotcha_web/Views/Dashboard/Index.cshtml"
                                                                                                                      Write(x.linktext);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\n");
#nullable restore
#line 26 "/Users/daniel/Projects/gotcha_web/Views/Dashboard/Index.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\n\n\n    </div>\n    \n    \n\n</div>");
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
