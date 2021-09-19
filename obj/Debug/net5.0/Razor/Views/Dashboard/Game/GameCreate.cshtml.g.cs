#pragma checksum "/Users/daniel/Projects/gotcha_web/Views/Dashboard/Game/GameCreate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4791e1bf09034eae10b4c7734e543141a51b8c5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Game_GameCreate), @"mvc.1.0.view", @"/Views/Dashboard/Game/GameCreate.cshtml")]
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
#line 1 "/Users/daniel/Projects/gotcha_web/Views/Dashboard/Game/GameCreate.cshtml"
using gotcha_web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4791e1bf09034eae10b4c7734e543141a51b8c5f", @"/Views/Dashboard/Game/GameCreate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a70d52ce7354a726aabab18612a0c3f9aad00feb", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Game_GameCreate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<gotcha_web.Forms.GameCreateForm>
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
            WriteLiteral("\n\n");
#nullable restore
#line 6 "/Users/daniel/Projects/gotcha_web/Views/Dashboard/Game/GameCreate.cshtml"
  
    ViewData["NavDark"] = true;
    ViewData["Title"] = "Spel aanmaken";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container p2\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4791e1bf09034eae10b4c7734e543141a51b8c5f3669", async() => {
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
            WriteLiteral("</partial>\n</div>\n\n\n<div class=\"container p2\">\n");
#nullable restore
#line 16 "/Users/daniel/Projects/gotcha_web/Views/Dashboard/Game/GameCreate.cshtml"
     using (Html.BeginForm("CreateGame", "Dashboard", FormMethod.Post)){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"formcontrol\">\n        <label>Naam van het spel:</label>\n        ");
#nullable restore
#line 19 "/Users/daniel/Projects/gotcha_web/Views/Dashboard/Game/GameCreate.cshtml"
   Write(Html.TextBoxFor(m => m.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\n\n    </div>\n    <div class=\"formcontrol\">\n        <label>Beschrijving/uitleg:</label>\n        ");
#nullable restore
#line 24 "/Users/daniel/Projects/gotcha_web/Views/Dashboard/Game/GameCreate.cshtml"
   Write(Html.TextAreaFor(m => m.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\n\n    </div>\n    <div class=\"formcontrol\">\n        <label>Regio:</label>\n        ");
#nullable restore
#line 29 "/Users/daniel/Projects/gotcha_web/Views/Dashboard/Game/GameCreate.cshtml"
   Write(Html.TextBoxFor(m => m.Region));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    </div>\n    <div class=\"formcontrol\">\n        <label>Speltype:</label>\n        ");
#nullable restore
#line 34 "/Users/daniel/Projects/gotcha_web/Views/Dashboard/Game/GameCreate.cshtml"
   Write(Html.DropDownListFor(m => m.gametypeid, new SelectList(ViewBag.gametypes, "GameTypeId", "GameTypeName")));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\n\n    </div>\n    <input type=\"submit\" value=\"Maak spel aan\"/>\n");
#nullable restore
#line 38 "/Users/daniel/Projects/gotcha_web/Views/Dashboard/Game/GameCreate.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \n\n\n</div>\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<gotcha_web.Forms.GameCreateForm> Html { get; private set; }
    }
}
#pragma warning restore 1591
