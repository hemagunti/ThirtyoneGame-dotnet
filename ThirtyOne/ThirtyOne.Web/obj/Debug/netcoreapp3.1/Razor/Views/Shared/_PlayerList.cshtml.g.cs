#pragma checksum "/Users/hemagunti/Projects/dotnet-hyf/ThirtyOne/ThirtyOne.Web/Views/Shared/_PlayerList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8899124a324f2a9483b16263b5ca8b46b144dcaf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PlayerList), @"mvc.1.0.view", @"/Views/Shared/_PlayerList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8899124a324f2a9483b16263b5ca8b46b144dcaf", @"/Views/Shared/_PlayerList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3416162202141b106904adccd89c7f378512a352", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PlayerList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ThirtyOne.Models.Game>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h3>Players:</h3>\r\n<div class=\"list-group\">\r\n");
#nullable restore
#line 4 "/Users/hemagunti/Projects/dotnet-hyf/ThirtyOne/ThirtyOne.Web/Views/Shared/_PlayerList.cshtml"
     foreach (var p in Model.Players)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div");
            BeginWriteAttribute("class", " class=\"", 133, "\"", 196, 2);
            WriteAttributeValue("", 141, "list-group-item", 141, 15, true);
#nullable restore
#line 6 "/Users/hemagunti/Projects/dotnet-hyf/ThirtyOne/ThirtyOne.Web/Views/Shared/_PlayerList.cshtml"
WriteAttributeValue(" ", 156, (Model.CurrentPlayer==p)?"active":"", 157, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <h4>");
#nullable restore
#line 7 "/Users/hemagunti/Projects/dotnet-hyf/ThirtyOne/ThirtyOne.Web/Views/Shared/_PlayerList.cshtml"
           Write(p.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
#nullable restore
#line 8 "/Users/hemagunti/Projects/dotnet-hyf/ThirtyOne/ThirtyOne.Web/Views/Shared/_PlayerList.cshtml"
             if (p.HasKnocked)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"badge\">Knocked</span>\r\n");
#nullable restore
#line 11 "/Users/hemagunti/Projects/dotnet-hyf/ThirtyOne/ThirtyOne.Web/Views/Shared/_PlayerList.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p class=\"list-group-item-text\">");
#nullable restore
#line 12 "/Users/hemagunti/Projects/dotnet-hyf/ThirtyOne/ThirtyOne.Web/Views/Shared/_PlayerList.cshtml"
                                       Write(p.LastAction);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n");
#nullable restore
#line 14 "/Users/hemagunti/Projects/dotnet-hyf/ThirtyOne/ThirtyOne.Web/Views/Shared/_PlayerList.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ThirtyOne.Models.Game> Html { get; private set; }
    }
}
#pragma warning restore 1591
