#pragma checksum "C:\Users\50068691866\Desktop\checkpoint\Views\Usuario\cadastra.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54f03534d100cdbe6f2a2fedf8432cb8fd96ac60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_cadastra), @"mvc.1.0.view", @"/Views/Usuario/cadastra.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/cadastra.cshtml", typeof(AspNetCore.Views_Usuario_cadastra))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54f03534d100cdbe6f2a2fedf8432cb8fd96ac60", @"/Views/Usuario/cadastra.cshtml")]
    public class Views_Usuario_cadastra : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\50068691866\Desktop\checkpoint\Views\Usuario\cadastra.cshtml"
   Layout = "MasterPageDeslogado";

#line default
#line hidden
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("styles", async() => {
                BeginContext(56, 56, true);
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"/css/cadastra.css\">\r\n");
                EndContext();
            }
            );
            BeginContext(115, 1040, true);
            WriteLiteral(@"
<html>

    <section class=""cadastrar"">
        <h2>Cadastrar</h2>

        <form action=""/Usuario/Cadastra"" method=""POST"">
            <label class=""eita"">Nome: </label>
                <input  class=""botao"" type=""text"" name=""nome"" placeholder=""Insira seu Nome"">
            <br/>

            <label class=""eita"">E-mail:
                <input class=""botao"" type=""email"" name=""email"" placeholder=""Insira seu E-mail"">
            </label>
            <br>

            <label class=""eita"">Senha:
                <input class=""botao"" type=""password"" name=""senha"" placeholder=""Informe sua Senha"">
            </label>
            <br>

            <button class=""btn-enviar"">ENVIAR</button>
    </section>

     <section class=""fim"">
        <h3>RUA BARÃO DE LIMEIRA
            Nº 444</h4>
        
        <div class=""mapa"">
            <img src=""/img/map.png"" alt=""mapa"">
        </div>
        <div class=""face"">
            <img src=""/img/face.png"" alt=""face"">
        </div>
    </sec");
            WriteLiteral("tion>\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591