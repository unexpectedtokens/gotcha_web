#pragma checksum "/Users/daniel/Projects/gotcha_web/Views/Auth/Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5fcd804d8040e9bf7437185a7aad661e25afdf8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Auth_Register), @"mvc.1.0.view", @"/Views/Auth/Register.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5fcd804d8040e9bf7437185a7aad661e25afdf8", @"/Views/Auth/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a70d52ce7354a726aabab18612a0c3f9aad00feb", @"/Views/_ViewImports.cshtml")]
    public class Views_Auth_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<gotcha_web.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/daniel/Projects/gotcha_web/Views/Auth/Register.cshtml"
  
    ViewData["Title"] = "Maak account";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container p2"">
<nav class=""dark"">
                <div class=""nav-content"">
                    <div class=""nav-left""><a class=""logo logo-dark"" href=""/""><span>ZU</span><span>YD</span></a></div>
                    <div class=""nav-right"">
                        <ul><li><a href=""/Auth"">Log in</a></li><li><a href=""/Auth/register"">Maak een account</a></li></ul>
                    </div>
                    
                </div>
            </nav>
</div>

<main>
    <div class=""container p2"">
        <div class=""formcontainer"">

            <h1>Maak een speleraccount aan</h1>
            
");
#nullable restore
#line 24 "/Users/daniel/Projects/gotcha_web/Views/Auth/Register.cshtml"
             using (Html.BeginForm("Register", "Auth", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"formcontrol\">\n                    <label>\n                        Email\n                    </label>\n                \n                ");
#nullable restore
#line 31 "/Users/daniel/Projects/gotcha_web/Views/Auth/Register.cshtml"
           Write(Html.TextBoxFor(m => m.email, new { required = true, placeholder = "Email..."}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n                <div class=\"formcontrol\">\n                    <label>\n                        Alias\n                    </label>\n                    ");
#nullable restore
#line 37 "/Users/daniel/Projects/gotcha_web/Views/Auth/Register.cshtml"
               Write(Html.TextBoxFor(m=>m.alias, new { required = true, placeholder = "Alias..."}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        \n                    </div>\n                    <div class=\"formcontrol\">\n                    <label>\n                        Voornaam\n                    </label>\n                    ");
#nullable restore
#line 44 "/Users/daniel/Projects/gotcha_web/Views/Auth/Register.cshtml"
               Write(Html.TextBoxFor(m=>m.firstname, new { required = true, placeholder = "Voornaam..."}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        \n                    </div>\n                    <div class=\"formcontrol\">\n                    <label>\n                        Achternaam\n                    </label>\n                    ");
#nullable restore
#line 51 "/Users/daniel/Projects/gotcha_web/Views/Auth/Register.cshtml"
               Write(Html.TextBoxFor(m=>m.lastname, new { required = true, placeholder = "Achternaam..."}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        \n                    </div>\n                <div class=\"formcontrol\">\n                    <label>\n                        Wachtwoord\n                    </label>\n                    ");
#nullable restore
#line 58 "/Users/daniel/Projects/gotcha_web/Views/Auth/Register.cshtml"
               Write(Html.PasswordFor(m=>m.password, new { required = true, placeholder = "Wachtwoord..."}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        
                    </div>
                <div class=""form-buttonbar"">                    
                    <input type=""submit"" class=""button button-red button-big"" value=""Maak speler account aan""/>
                    <a href=""/Auth"" class=""button button-red-noborder"">Log in</a>
                </div>
");
#nullable restore
#line 65 "/Users/daniel/Projects/gotcha_web/Views/Auth/Register.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n</main>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<gotcha_web.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
