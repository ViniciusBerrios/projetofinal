#pragma checksum "C:\Users\50068691866\Desktop\checkpoint\Views\Comentario\adm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f747d0d464b8992636066c12c44f68425eac3b87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comentario_adm), @"mvc.1.0.view", @"/Views/Comentario/adm.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Comentario/adm.cshtml", typeof(AspNetCore.Views_Comentario_adm))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f747d0d464b8992636066c12c44f68425eac3b87", @"/Views/Comentario/adm.cshtml")]
    public class Views_Comentario_adm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\50068691866\Desktop\checkpoint\Views\Comentario\adm.cshtml"
   Layout = "MasterPageDeslogado";

#line default
#line hidden
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("styles", async() => {
                BeginContext(56, 51, true);
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"/css/adm.css\">\r\n");
                EndContext();
            }
            );
            BeginContext(110, 93, true);
            WriteLiteral("\r\n<html>\r\n\r\n\r\n    <section class=\"adm\">\r\n        <h2>Administrador</h2>\r\n        <center>\r\n\r\n");
            EndContext();
#line 14 "C:\Users\50068691866\Desktop\checkpoint\Views\Comentario\adm.cshtml"
         foreach (var item in ViewBag.lista)
        {

#line default
#line hidden
            BeginContext(260, 98, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <br><br><br><br>\r\n                    ");
            EndContext();
            BeginContext(359, 9, false);
#line 19 "C:\Users\50068691866\Desktop\checkpoint\Views\Comentario\adm.cshtml"
               Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(368, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(436, 16, false);
#line 22 "C:\Users\50068691866\Desktop\checkpoint\Views\Comentario\adm.cshtml"
               Write(item.DataCriacao);

#line default
#line hidden
            EndContext();
            BeginContext(452, 93, true);
            WriteLiteral("\r\n                    <br>\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(546, 10, false);
#line 26 "C:\Users\50068691866\Desktop\checkpoint\Views\Comentario\adm.cshtml"
               Write(item.Texto);

#line default
#line hidden
            EndContext();
            BeginContext(556, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 29 "C:\Users\50068691866\Desktop\checkpoint\Views\Comentario\adm.cshtml"
             if (item.Status == false)
            {

#line default
#line hidden
            BeginContext(655, 14, true);
            WriteLiteral("            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 669, "\"", 706, 2);
            WriteAttributeValue("", 676, "/Comentario/Aprova?id=", 676, 22, true);
#line 31 "C:\Users\50068691866\Desktop\checkpoint\Views\Comentario\adm.cshtml"
WriteAttributeValue("", 698, item.ID, 698, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(707, 30, true);
            WriteLiteral(">Aprova</a>   \r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 737, "\"", 775, 2);
            WriteAttributeValue("", 744, "/Comentario/Rejeita?id=", 744, 23, true);
#line 32 "C:\Users\50068691866\Desktop\checkpoint\Views\Comentario\adm.cshtml"
WriteAttributeValue("", 767, item.ID, 767, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(776, 14, true);
            WriteLiteral(">Rejeita</a>\r\n");
            EndContext();
#line 33 "C:\Users\50068691866\Desktop\checkpoint\Views\Comentario\adm.cshtml"
            }

#line default
#line hidden
#line 33 "C:\Users\50068691866\Desktop\checkpoint\Views\Comentario\adm.cshtml"
             
        }

#line default
#line hidden
            BeginContext(816, 345, true);
            WriteLiteral(@"        </center>
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
    </section>

</html>");
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
