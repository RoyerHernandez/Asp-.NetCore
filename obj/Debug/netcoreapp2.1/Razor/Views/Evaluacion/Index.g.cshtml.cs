#pragma checksum "d:\Platzi\Asp_NET\Asp-.NetCore\Views\Evaluacion\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba0aba3586c187ae8fa7cb3abd1e3db8fe83d6da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Evaluacion_Index), @"mvc.1.0.view", @"/Views/Evaluacion/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Evaluacion/Index.cshtml", typeof(AspNetCore.Views_Evaluacion_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba0aba3586c187ae8fa7cb3abd1e3db8fe83d6da", @"/Views/Evaluacion/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7471c610fd56645fab5c40297afd15c23f6a5875", @"/Views/_ViewImports.cshtml")]
    public class Views_Evaluacion_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Evaluaciones>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "ObjetoEscuelaSimple", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(21, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "d:\Platzi\Asp_NET\Asp-.NetCore\Views\Evaluacion\Index.cshtml"
  
    ViewData["Title"] = "Información Evaluación";
    Layout = "_Simple";

#line default
#line hidden
            BeginContext(106, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(113, 17, false);
#line 8 "d:\Platzi\Asp_NET\Asp-.NetCore\Views\Evaluacion\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(130, 59, true);
            WriteLiteral("</h1>\r\n<strong>Desde la vista normal</strong>\r\n<p>Nombre : ");
            EndContext();
            BeginContext(190, 12, false);
#line 10 "d:\Platzi\Asp_NET\Asp-.NetCore\Views\Evaluacion\Index.cshtml"
       Write(Model.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(202, 20, true);
            WriteLiteral(" <br/>\r\n   Nombre : ");
            EndContext();
            BeginContext(223, 14, false);
#line 11 "d:\Platzi\Asp_NET\Asp-.NetCore\Views\Evaluacion\Index.cshtml"
       Write(Model.UniqueId);

#line default
#line hidden
            EndContext();
            BeginContext(237, 49, true);
            WriteLiteral(" </p>\r\n\r\n<strong>Desde la vista normal</strong>\r\n");
            EndContext();
            BeginContext(286, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "acfbe5129f6c427f85d43831bc819eb7", async() => {
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
            EndContext();
            BeginContext(322, 8, true);
            WriteLiteral("\r\n<p><i>");
            EndContext();
            BeginContext(331, 13, false);
#line 15 "d:\Platzi\Asp_NET\Asp-.NetCore\Views\Evaluacion\Index.cshtml"
 Write(ViewBag.fecha);

#line default
#line hidden
            EndContext();
            BeginContext(344, 12, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Evaluaciones> Html { get; private set; }
    }
}
#pragma warning restore 1591