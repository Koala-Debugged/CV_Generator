#pragma checksum "C:\Users\jasan\source\repos\Koala-Debugged\CV_Generator\CV_Generator.Presentation\Views\Formulario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41318bc1dd3b5a650578a6c7fcb72108f66793a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Formulario_Index), @"mvc.1.0.view", @"/Views/Formulario/Index.cshtml")]
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
#line 1 "C:\Users\jasan\source\repos\Koala-Debugged\CV_Generator\CV_Generator.Presentation\Views\_ViewImports.cshtml"
using CV_Generator.Presentation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jasan\source\repos\Koala-Debugged\CV_Generator\CV_Generator.Presentation\Views\_ViewImports.cshtml"
using CV_Generator.Presentation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41318bc1dd3b5a650578a6c7fcb72108f66793a2", @"/Views/Formulario/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4460353cf6704b15474464c64d819be88cab79e", @"/Views/_ViewImports.cshtml")]
    public class Views_Formulario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InfoDTOModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("<div");
            BeginWriteAttribute("id", " id=\"", 159, "\"", 164, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"home\">\r\n    <div");
            BeginWriteAttribute("id", " id=\"", 189, "\"", 194, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""d-flex justify-content-center align-items-center h-100 panel"">
        <div id=""formulario"" class=""contenido container col-md-4"">
            <p class=""h3"">Al cumplimentar el siguiente formulario recibir??s mi CV autom??ticamente en tu e-mail:</p>
");
#nullable restore
#line 13 "C:\Users\jasan\source\repos\Koala-Debugged\CV_Generator\CV_Generator.Presentation\Views\Formulario\Index.cshtml"
             using (Html.BeginForm(FormMethod.Post))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\jasan\source\repos\Koala-Debugged\CV_Generator\CV_Generator.Presentation\Views\Formulario\Index.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 17 "C:\Users\jasan\source\repos\Koala-Debugged\CV_Generator\CV_Generator.Presentation\Views\Formulario\Index.cshtml"
               Write(Html.LabelFor(x => x.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 18 "C:\Users\jasan\source\repos\Koala-Debugged\CV_Generator\CV_Generator.Presentation\Views\Formulario\Index.cshtml"
               Write(Html.TextBoxFor(x => x.Nombre, null, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 19 "C:\Users\jasan\source\repos\Koala-Debugged\CV_Generator\CV_Generator.Presentation\Views\Formulario\Index.cshtml"
               Write(Html.ValidationMessageFor(x => x.Nombre, null, new { @class = "validacion" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 22 "C:\Users\jasan\source\repos\Koala-Debugged\CV_Generator\CV_Generator.Presentation\Views\Formulario\Index.cshtml"
               Write(Html.LabelFor(x => x.Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 23 "C:\Users\jasan\source\repos\Koala-Debugged\CV_Generator\CV_Generator.Presentation\Views\Formulario\Index.cshtml"
               Write(Html.TextBoxFor(x => x.Apellidos, null, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 24 "C:\Users\jasan\source\repos\Koala-Debugged\CV_Generator\CV_Generator.Presentation\Views\Formulario\Index.cshtml"
               Write(Html.ValidationMessageFor(x => x.Apellidos, null, new { @class = "validacion" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 27 "C:\Users\jasan\source\repos\Koala-Debugged\CV_Generator\CV_Generator.Presentation\Views\Formulario\Index.cshtml"
               Write(Html.LabelFor(x => x.Empresa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 28 "C:\Users\jasan\source\repos\Koala-Debugged\CV_Generator\CV_Generator.Presentation\Views\Formulario\Index.cshtml"
               Write(Html.TextBoxFor(x => x.Empresa, null, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 29 "C:\Users\jasan\source\repos\Koala-Debugged\CV_Generator\CV_Generator.Presentation\Views\Formulario\Index.cshtml"
               Write(Html.ValidationMessageFor(x => x.Empresa, null, new { @class = "validacion" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 32 "C:\Users\jasan\source\repos\Koala-Debugged\CV_Generator\CV_Generator.Presentation\Views\Formulario\Index.cshtml"
               Write(Html.LabelFor(x => x.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 33 "C:\Users\jasan\source\repos\Koala-Debugged\CV_Generator\CV_Generator.Presentation\Views\Formulario\Index.cshtml"
               Write(Html.TextBoxFor(x => x.Email, null, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 34 "C:\Users\jasan\source\repos\Koala-Debugged\CV_Generator\CV_Generator.Presentation\Views\Formulario\Index.cshtml"
               Write(Html.ValidationMessageFor(x => x.Email, null, new { @class = "validacion" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
            WriteLiteral("                <button type=\"submit\" id=\"btnSolicitar\" class=\"btn btn-primary\">Solicitar</button>\r\n");
#nullable restore
#line 38 "C:\Users\jasan\source\repos\Koala-Debugged\CV_Generator\CV_Generator.Presentation\Views\Formulario\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
        <div class=""d-flex justify-content-center"">
            <div class=""spinner-border text-light d-none"" id=""spinner"" style=""width: 6rem; height: 6rem;"" role=""status"">
                <span class=""sr-only"">Loading...</span>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InfoDTOModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
