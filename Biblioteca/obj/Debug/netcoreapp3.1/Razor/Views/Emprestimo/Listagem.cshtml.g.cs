#pragma checksum "C:\Users\Cliente\Desktop\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1cbb6205438dc39bb1b7ffb74aa4b9b4764cbb8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Emprestimo_Listagem), @"mvc.1.0.view", @"/Views/Emprestimo/Listagem.cshtml")]
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
#line 1 "C:\Users\Cliente\Desktop\Biblioteca - netcore3.1\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Cliente\Desktop\Biblioteca - netcore3.1\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1cbb6205438dc39bb1b7ffb74aa4b9b4764cbb8", @"/Views/Emprestimo/Listagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea07f0214da259abc315dec5bc842518e8ae187", @"/Views/_ViewImports.cshtml")]
    public class Views_Emprestimo_Listagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Emprestimo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Autor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Titulo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "10", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "15", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "30", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "50", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Cliente\Desktop\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
  
    ViewData["Title"] = "Listagem de Empréstimos";
    int FiltroPorPag = int.Parse(ViewData["livrosPorPagina"].ToString());
    int PaginaAtual = int.Parse(ViewData["PaginaAtual"].ToString());
    int NumLivrosPorPag = (Model.Count<FiltroPorPag ? Model.Count : FiltroPorPag);
    int NumTotalDePag = Model.Count/NumLivrosPorPag + (Model.Count%NumLivrosPorPag ==0 ? 0 : 1);
    string classe="classe";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1cbb6205438dc39bb1b7ffb74aa4b9b4764cbb86469", async() => {
                WriteLiteral("\r\n        <div class=\"form-group mb-2\">\r\n            <select name=\"TipoFiltro\" class=\"form-control\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1cbb6205438dc39bb1b7ffb74aa4b9b4764cbb86853", async() => {
                    WriteLiteral("Usuário");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1cbb6205438dc39bb1b7ffb74aa4b9b4764cbb88093", async() => {
                    WriteLiteral("Livro");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </select>
        </div>

        <div class=""form-group mb-2 mx-sm-3"">
            <input type=""text"" placeholder=""Filtro"" name=""Filtro"" class=""form-control"" />
        </div>

        <div>
            <select name=""itensPorPagina"" id=""itensPorPagina"">
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1cbb6205438dc39bb1b7ffb74aa4b9b4764cbb89620", async() => {
                    WriteLiteral("10 Livros");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1cbb6205438dc39bb1b7ffb74aa4b9b4764cbb810862", async() => {
                    WriteLiteral("15 Livros");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1cbb6205438dc39bb1b7ffb74aa4b9b4764cbb812105", async() => {
                    WriteLiteral("30 Livros");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1cbb6205438dc39bb1b7ffb74aa4b9b4764cbb813348", async() => {
                    WriteLiteral("50 Livros");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1cbb6205438dc39bb1b7ffb74aa4b9b4764cbb814591", async() => {
                    WriteLiteral("Todos");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\Cliente\Desktop\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                   WriteLiteral(Model.Count);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </select>\r\n        </div>\r\n\r\n        <button type=\"submit\" class=\"btn btn-primary mb-2\">Pesquisar</button>\r\n\r\n        <div id=\"SeletorPaginas\">\r\n            <span>Páginas:</span>\r\n");
#nullable restore
#line 40 "C:\Users\Cliente\Desktop\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
             for(int i=1; i<=NumTotalDePag;i++)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <span><a");
                BeginWriteAttribute("href", " href=\"", 1586, "\"", 1623, 2);
                WriteAttributeValue("", 1593, "/Livro/Listagem?PaginaAtual=", 1593, 28, true);
#nullable restore
#line 42 "C:\Users\Cliente\Desktop\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
WriteAttributeValue("", 1621, i, 1621, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("> ");
#nullable restore
#line 42 "C:\Users\Cliente\Desktop\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                                                           Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </a></span>\r\n");
#nullable restore
#line 43 "C:\Users\Cliente\Desktop\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n");
#nullable restore
#line 51 "C:\Users\Cliente\Desktop\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
         if(Model.Count!=0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table table-striped""> 
            <thead>
                <tr><th>Id</th>
                <th>Usuario</th>
                <th>Data Empréstimo</th>
                <th>Data Devolução</th>
                <th>Livro</th>
                <th>Autor</th>
                <th></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 65 "C:\Users\Cliente\Desktop\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                 foreach( var e in Model)
                {

                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\Cliente\Desktop\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                     if((System.DateTime.Compare(System.DateTime.Now, e.DataDevolucao)>0))
                    {
                        classe="text-danger";
                    }
                    else
                    {
                        classe="";
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\Cliente\Desktop\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                 for(int i = (PaginaAtual-1)*NumLivrosPorPag; i<(NumLivrosPorPag*PaginaAtual<Model.Count?NumLivrosPorPag*PaginaAtual:Model.Count); i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr");
            BeginWriteAttribute("class", " class=\"", 2718, "\"", 2733, 1);
#nullable restore
#line 78 "C:\Users\Cliente\Desktop\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
WriteAttributeValue("", 2726, classe, 2726, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <td>");
#nullable restore
#line 79 "C:\Users\Cliente\Desktop\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                   Write(e.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 80 "C:\Users\Cliente\Desktop\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                   Write(e.NomeUsuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 81 "C:\Users\Cliente\Desktop\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                   Write(e.DataEmprestimo.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 82 "C:\Users\Cliente\Desktop\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                   Write(e.DataDevolucao.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 83 "C:\Users\Cliente\Desktop\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                   Write(e.Livro.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 84 "C:\Users\Cliente\Desktop\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                   Write(e.Livro.Autor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 3076, "\"", 3109, 2);
            WriteAttributeValue("", 3083, "/Livro/Edicao/", 3083, 14, true);
#nullable restore
#line 85 "C:\Users\Cliente\Desktop\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
WriteAttributeValue("", 3097, Model[i].Id, 3097, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 87 "C:\Users\Cliente\Desktop\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\Cliente\Desktop\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                 
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 91 "C:\Users\Cliente\Desktop\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h2> Nenhum registro encontrado!</h2>\r\n");
#nullable restore
#line 95 "C:\Users\Cliente\Desktop\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Emprestimo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
