#pragma checksum "d:\Platzi\Asp_NET\Asp-.NetCore\Views\Escuela\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea7fc3c4c18e57b90b54bad3be11590ad08ee228"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Escuela_Index), @"mvc.1.0.view", @"/Views/Escuela/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Escuela/Index.cshtml", typeof(AspNetCore.Views_Escuela_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea7fc3c4c18e57b90b54bad3be11590ad08ee228", @"/Views/Escuela/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7471c610fd56645fab5c40297afd15c23f6a5875", @"/Views/_ViewImports.cshtml")]
    public class Views_Escuela_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Escuela>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(16, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "d:\Platzi\Asp_NET\Asp-.NetCore\Views\Escuela\Index.cshtml"
  
    ViewData["Title"] = "Información Escuela";
    Layout = "_Simple";

#line default
#line hidden
            BeginContext(98, 14, true);
            WriteLiteral("\r\n<h1>Escuela ");
            EndContext();
            BeginContext(113, 17, false);
#line 8 "d:\Platzi\Asp_NET\Asp-.NetCore\Views\Escuela\Index.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(130, 20, true);
            WriteLiteral("</h1>\r\n<h2>Nombre : ");
            EndContext();
            BeginContext(151, 12, false);
#line 9 "d:\Platzi\Asp_NET\Asp-.NetCore\Views\Escuela\Index.cshtml"
        Write(Model.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(163, 38, true);
            WriteLiteral(" </h2>\r\n<p><strong>Año de Fundación : ");
            EndContext();
            BeginContext(202, 18, false);
#line 10 "d:\Platzi\Asp_NET\Asp-.NetCore\Views\Escuela\Index.cshtml"
                         Write(Model.AñoFundacion);

#line default
#line hidden
            EndContext();
            BeginContext(220, 26, true);
            WriteLiteral(" </strong></p>\r\n\r\n\r\n<p><i>");
            EndContext();
            BeginContext(247, 20, false);
#line 13 "d:\Platzi\Asp_NET\Asp-.NetCore\Views\Escuela\Index.cshtml"
 Write(ViewBag.cosaDinamica);

#line default
#line hidden
            EndContext();
            BeginContext(267, 12, true);
            WriteLiteral("</i></p>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Escuela> Html { get; private set; }
    }
}
#pragma warning restore 1591
