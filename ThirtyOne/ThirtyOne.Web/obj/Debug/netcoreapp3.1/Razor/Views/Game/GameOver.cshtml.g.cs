#pragma checksum "/Users/hemagunti/Projects/dotnet-hyf/ThirtyOne/ThirtyOne.Web/Views/Game/GameOver.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e52c32e5552896480dbb4457e20f691ed8be387"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Game_GameOver), @"mvc.1.0.view", @"/Views/Game/GameOver.cshtml")]
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
#line 1 "/Users/hemagunti/Projects/dotnet-hyf/ThirtyOne/ThirtyOne.Web/Views/_ViewImports.cshtml"
using ThirtyOne.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/hemagunti/Projects/dotnet-hyf/ThirtyOne/ThirtyOne.Web/Views/_ViewImports.cshtml"
using ThirtyOne.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/hemagunti/Projects/dotnet-hyf/ThirtyOne/ThirtyOne.Web/Views/Game/GameOver.cshtml"
using ThirtyOne.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/hemagunti/Projects/dotnet-hyf/ThirtyOne/ThirtyOne.Web/Views/Game/GameOver.cshtml"
using ThirtyOne.Web.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e52c32e5552896480dbb4457e20f691ed8be387", @"/Views/Game/GameOver.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3416162202141b106904adccd89c7f378512a352", @"/Views/_ViewImports.cshtml")]
    public class Views_Game_GameOver : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ThirtyOne.Models.Game>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("playingcard"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100px;margin:20px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "/Users/hemagunti/Projects/dotnet-hyf/ThirtyOne/ThirtyOne.Web/Views/Game/GameOver.cshtml"
  
    ViewData["Title"] = "GameOver";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"jumbotron jumbotron-fluid\">\r\n    <div class=\"container\">\r\n        <h1 class=\"display-4\">Game Over - <span class=\"winner-name\">");
#nullable restore
#line 9 "/Users/hemagunti/Projects/dotnet-hyf/ThirtyOne/ThirtyOne.Web/Views/Game/GameOver.cshtml"
                                                               Write(Model.Winner.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> won!</h1>\r\n        <p class=\"lead\">Thanks for playing!</p>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"container\">\r\n");
#nullable restore
#line 15 "/Users/hemagunti/Projects/dotnet-hyf/ThirtyOne/ThirtyOne.Web/Views/Game/GameOver.cshtml"
     foreach (var p in Model.Players.OrderByDescending(p => p.Hand.CalculateScore()))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <h2>");
#nullable restore
#line 18 "/Users/hemagunti/Projects/dotnet-hyf/ThirtyOne/ThirtyOne.Web/Views/Game/GameOver.cshtml"
           Write(p.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 18 "/Users/hemagunti/Projects/dotnet-hyf/ThirtyOne/ThirtyOne.Web/Views/Game/GameOver.cshtml"
                    Write(p.Hand.CalculateScore());

#line default
#line hidden
#nullable disable
            WriteLiteral(" points</h2>\r\n");
#nullable restore
#line 19 "/Users/hemagunti/Projects/dotnet-hyf/ThirtyOne/ThirtyOne.Web/Views/Game/GameOver.cshtml"
             foreach (var c in p.Hand)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5e52c32e5552896480dbb4457e20f691ed8be3876017", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 666, "~/images/Cards/", 666, 15, true);
#nullable restore
#line 21 "/Users/hemagunti/Projects/dotnet-hyf/ThirtyOne/ThirtyOne.Web/Views/Game/GameOver.cshtml"
AddHtmlAttributeValue("", 681, c.FileName(), 681, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 22 "/Users/hemagunti/Projects/dotnet-hyf/ThirtyOne/ThirtyOne.Web/Views/Game/GameOver.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 24 "/Users/hemagunti/Projects/dotnet-hyf/ThirtyOne/ThirtyOne.Web/Views/Game/GameOver.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ThirtyOne.Models.Game> Html { get; private set; }
    }
}
#pragma warning restore 1591
