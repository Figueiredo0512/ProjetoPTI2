#pragma checksum "C:\Users\mathe\Desktop\pti2v2\ProjetoPTI2\ProjetoPTI2\ProjetoPTI2\Views\PegaTickets\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3ad33a4b4f8a113c9b938372558b876fd513438"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PegaTickets_Index), @"mvc.1.0.view", @"/Views/PegaTickets/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PegaTickets/Index.cshtml", typeof(AspNetCore.Views_PegaTickets_Index))]
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
#line 1 "C:\Users\mathe\Desktop\pti2v2\ProjetoPTI2\ProjetoPTI2\ProjetoPTI2\Views\_ViewImports.cshtml"
using ProjetoPTI2;

#line default
#line hidden
#line 2 "C:\Users\mathe\Desktop\pti2v2\ProjetoPTI2\ProjetoPTI2\ProjetoPTI2\Views\_ViewImports.cshtml"
using ProjetoPTI2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3ad33a4b4f8a113c9b938372558b876fd513438", @"/Views/PegaTickets/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b6cf2c9110cddeeb69c0f00b6e2c39640cc5543", @"/Views/_ViewImports.cshtml")]
    public class Views_PegaTickets_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjetoPTI2.Models.PegaTicket>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\mathe\Desktop\pti2v2\ProjetoPTI2\ProjetoPTI2\ProjetoPTI2\Views\PegaTickets\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(94, 217, true);
            WriteLiteral("\r\n<h2>Atribuição de Ticket</h2>\r\n\r\n<p>\r\n    Tela destinada a atribuição dos tickets abertos aos técnicos que solucionarão os porblemas.\r\n</p>\r\n\r\n<hr />\r\n\r\n<div class=\"container\">\r\n    <table>\r\n\r\n    </table>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjetoPTI2.Models.PegaTicket>> Html { get; private set; }
    }
}
#pragma warning restore 1591
