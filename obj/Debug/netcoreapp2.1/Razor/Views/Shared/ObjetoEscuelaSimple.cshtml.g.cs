#pragma checksum "d:\Platzi\Asp_NET\Asp-.NetCore\Views\Shared\ObjetoEscuelaSimple.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bae5014dfb9e83be772666d4c842981ac5b8e6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ObjetoEscuelaSimple), @"mvc.1.0.view", @"/Views/Shared/ObjetoEscuelaSimple.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/ObjetoEscuelaSimple.cshtml", typeof(AspNetCore.Views_Shared_ObjetoEscuelaSimple))]
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
#line 1 "d:\Platzi\Asp_NET\Asp-.NetCore\Views\_ViewImports.cshtml"
using Asp_.NetCore;

#line default
#line hidden
#line 2 "d:\Platzi\Asp_NET\Asp-.NetCore\Views\_ViewImports.cshtml"
using Asp_.NetCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bae5014dfb9e83be772666d4c842981ac5b8e6e", @"/Views/Shared/ObjetoEscuelaSimple.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7471c610fd56645fab5c40297afd15c23f6a5875", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ObjetoEscuelaSimple : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ObjetoEscuelaBase>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 14, true);
            WriteLiteral("\r\n<p>Nombre : ");
            EndContext();
            BeginContext(41, 12, false);
#line 3 "d:\Platzi\Asp_NET\Asp-.NetCore\Views\Shared\ObjetoEscuelaSimple.cshtml"
       Write(Model.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(53, 16, true);
            WriteLiteral(" <br/>\r\n   ID : ");
            EndContext();
            BeginContext(70, 8, false);
#line 4 "d:\Platzi\Asp_NET\Asp-.NetCore\Views\Shared\ObjetoEscuelaSimple.cshtml"
   Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(78, 23, true);
            WriteLiteral(" <br/>\r\n   Dirección : ");
            EndContext();
            BeginContext(102, 15, false);
#line 5 "d:\Platzi\Asp_NET\Asp-.NetCore\Views\Shared\ObjetoEscuelaSimple.cshtml"
          Write(Model.Dirección);

#line default
#line hidden
            EndContext();
            BeginContext(117, 27, true);
            WriteLiteral("</p>\r\n   <td>\r\n            ");
            EndContext();
            BeginContext(145, 52, false);
#line 7 "d:\Platzi\Asp_NET\Asp-.NetCore\Views\Shared\ObjetoEscuelaSimple.cshtml"
       Write(Html.ActionLink("Edit", "Edit", new { id=Model.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(197, 16, true);
            WriteLiteral(" |\r\n            ");
            EndContext();
            BeginContext(214, 54, false);
#line 8 "d:\Platzi\Asp_NET\Asp-.NetCore\Views\Shared\ObjetoEscuelaSimple.cshtml"
       Write(Html.ActionLink("Index", "Index", new { id=Model.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(268, 16, true);
            WriteLiteral(" |\r\n            ");
            EndContext();
            BeginContext(285, 56, false);
#line 9 "d:\Platzi\Asp_NET\Asp-.NetCore\Views\Shared\ObjetoEscuelaSimple.cshtml"
       Write(Html.ActionLink("Delete", "Delete", new { id=Model.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(341, 9, true);
            WriteLiteral("\r\n  </td>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ObjetoEscuelaBase> Html { get; private set; }
    }
}
#pragma warning restore 1591
