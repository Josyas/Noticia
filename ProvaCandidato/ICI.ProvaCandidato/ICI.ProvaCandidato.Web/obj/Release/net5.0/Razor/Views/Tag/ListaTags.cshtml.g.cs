#pragma checksum "C:\Users\josia\Desktop\TesteICI\ProvaCandidato - 1\ProvaCandidato\ICI.ProvaCandidato\ICI.ProvaCandidato.Web\Views\Tag\ListaTags.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b23880b50721efe0f8c157f6754959577f038051"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tag_ListaTags), @"mvc.1.0.view", @"/Views/Tag/ListaTags.cshtml")]
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
#line 1 "C:\Users\josia\Desktop\TesteICI\ProvaCandidato - 1\ProvaCandidato\ICI.ProvaCandidato\ICI.ProvaCandidato.Web\Views\_ViewImports.cshtml"
using ICI.ProvaCandidato.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\josia\Desktop\TesteICI\ProvaCandidato - 1\ProvaCandidato\ICI.ProvaCandidato\ICI.ProvaCandidato.Web\Views\_ViewImports.cshtml"
using ICI.ProvaCandidato.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\josia\Desktop\TesteICI\ProvaCandidato - 1\ProvaCandidato\ICI.ProvaCandidato\ICI.ProvaCandidato.Web\Views\Tag\ListaTags.cshtml"
using ICI.ProvaCandidato.Web.AutoMapper.DTO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b23880b50721efe0f8c157f6754959577f038051", @"/Views/Tag/ListaTags.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dd312efccbabd6db444d6f769f6f349e825333a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Tag_ListaTags : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TagDTO>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ApagarTag", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditarTag", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2>Lista de Tags</h2>\r\n\r\n");
#nullable restore
#line 60 "C:\Users\josia\Desktop\TesteICI\ProvaCandidato - 1\ProvaCandidato\ICI.ProvaCandidato\ICI.ProvaCandidato.Web\Views\Tag\ListaTags.cshtml"
 if (TempData["AlertMessage"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success alert-dismissible fade show\" role=\"alert\">\r\n        ");
#nullable restore
#line 63 "C:\Users\josia\Desktop\TesteICI\ProvaCandidato - 1\ProvaCandidato\ICI.ProvaCandidato\ICI.ProvaCandidato.Web\Views\Tag\ListaTags.cshtml"
   Write(TempData["AlertMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
            <span aria-hidden=""true"">&times;</span>
        </button>
        <script>
            setTimeout(function () {
                $("".alert"").alert('close');
            }, 4000);
        </script>
    </div>
");
#nullable restore
#line 73 "C:\Users\josia\Desktop\TesteICI\ProvaCandidato - 1\ProvaCandidato\ICI.ProvaCandidato\ICI.ProvaCandidato.Web\Views\Tag\ListaTags.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<table id=\"myTable\" class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>Id</th>\r\n            <th>Descrição</th>\r\n            <th>Ações</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 85 "C:\Users\josia\Desktop\TesteICI\ProvaCandidato - 1\ProvaCandidato\ICI.ProvaCandidato\ICI.ProvaCandidato.Web\Views\Tag\ListaTags.cshtml"
         foreach (var tag in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 88 "C:\Users\josia\Desktop\TesteICI\ProvaCandidato - 1\ProvaCandidato\ICI.ProvaCandidato\ICI.ProvaCandidato.Web\Views\Tag\ListaTags.cshtml"
               Write(tag.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 89 "C:\Users\josia\Desktop\TesteICI\ProvaCandidato - 1\ProvaCandidato\ICI.ProvaCandidato\ICI.ProvaCandidato.Web\Views\Tag\ListaTags.cshtml"
               Write(tag.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <button type=\"button\" class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#modalEditarTag\" data-id=\"");
#nullable restore
#line 91 "C:\Users\josia\Desktop\TesteICI\ProvaCandidato - 1\ProvaCandidato\ICI.ProvaCandidato\ICI.ProvaCandidato.Web\Views\Tag\ListaTags.cshtml"
                                                                                                                        Write(tag.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-descricao=\"");
#nullable restore
#line 91 "C:\Users\josia\Desktop\TesteICI\ProvaCandidato - 1\ProvaCandidato\ICI.ProvaCandidato\ICI.ProvaCandidato.Web\Views\Tag\ListaTags.cshtml"
                                                                                                                                                 Write(tag.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Editar</button>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b23880b50721efe0f8c157f6754959577f0380518113", async() => {
                WriteLiteral("\r\n                        <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 2590, "\"", 2605, 1);
#nullable restore
#line 93 "C:\Users\josia\Desktop\TesteICI\ProvaCandidato - 1\ProvaCandidato\ICI.ProvaCandidato\ICI.ProvaCandidato.Web\Views\Tag\ListaTags.cshtml"
WriteAttributeValue("", 2598, tag.Id, 2598, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <button type=\"submit\" class=\"btn btn-danger\">Apagar</button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 98 "C:\Users\josia\Desktop\TesteICI\ProvaCandidato - 1\ProvaCandidato\ICI.ProvaCandidato\ICI.ProvaCandidato.Web\Views\Tag\ListaTags.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<!-- Modal de edição -->
<div class=""modal fade"" id=""modalEditarTag"" tabindex=""-1"" role=""dialog"" aria-labelledby=""modalEditarTagLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""modalEditarTagLabel"">Editar Tag</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b23880b50721efe0f8c157f6754959577f03805111290", async() => {
                WriteLiteral(@"
                <div class=""modal-body"">
                    <input type=""hidden"" name=""id"" id=""editarTagId"" />
                    <div class=""form-group"">
                        <label for=""editarTagDescricao"">Descrição</label>
                        <input type=""text"" class=""form-control"" name=""descricao"" id=""editarTagDescricao"" required />
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancelar</button>
                    <button type=""submit"" class=""btn btn-primary"">Salvar</button>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            // DataTable
            let table = new DataTable('#myTable');

            // Evento de clique no botão ""Editar""
            $(""#modalEditarTag"").on(""show.bs.modal"", function (event) {
                var button = $(event.relatedTarget);
                var id = button.data(""id"");
                var descricao = button.data(""descricao"");
                $(""#editarTagId"").val(id);
                $(""#editarTagDescricao"").val(descricao);
            });
        });
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TagDTO>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
