#pragma checksum "C:\Users\marce\source\repos\.NET-Caelum\Blog\Blog\Areas\Admin\Views\Shared\EditorTemplates\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36620fef533878d9edc24cb52a65c0028812c673"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_EditorTemplates_Post), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/EditorTemplates/Post.cshtml")]
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
#line 1 "C:\Users\marce\source\repos\.NET-Caelum\Blog\Blog\Areas\Admin\Views\_ViewImports.cshtml"
using Blog.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36620fef533878d9edc24cb52a65c0028812c673", @"/Areas/Admin/Views/Shared/EditorTemplates/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ba6d000e4da28050915fd9e3327521c39c3164f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_EditorTemplates_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Post>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\marce\source\repos\.NET-Caelum\Blog\Blog\Areas\Admin\Views\Shared\EditorTemplates\Post.cshtml"
Write(Html.LabelFor(p => p.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\marce\source\repos\.NET-Caelum\Blog\Blog\Areas\Admin\Views\Shared\EditorTemplates\Post.cshtml"
Write(Html.TextBoxFor(p => p.Titulo, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\marce\source\repos\.NET-Caelum\Blog\Blog\Areas\Admin\Views\Shared\EditorTemplates\Post.cshtml"
Write(Html.ValidationMessageFor(p => p.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\marce\source\repos\.NET-Caelum\Blog\Blog\Areas\Admin\Views\Shared\EditorTemplates\Post.cshtml"
Write(Html.LabelFor(p => p.Resumo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\marce\source\repos\.NET-Caelum\Blog\Blog\Areas\Admin\Views\Shared\EditorTemplates\Post.cshtml"
Write(Html.TextAreaFor(p => p.Resumo, new { @class = "form-control", rows = 6 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\marce\source\repos\.NET-Caelum\Blog\Blog\Areas\Admin\Views\Shared\EditorTemplates\Post.cshtml"
Write(Html.ValidationMessageFor(p => p.Resumo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\marce\source\repos\.NET-Caelum\Blog\Blog\Areas\Admin\Views\Shared\EditorTemplates\Post.cshtml"
Write(Html.LabelFor(p => p.Categoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\marce\source\repos\.NET-Caelum\Blog\Blog\Areas\Admin\Views\Shared\EditorTemplates\Post.cshtml"
Write(Html.TextBoxFor(p => p.Categoria, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\Users\marce\source\repos\.NET-Caelum\Blog\Blog\Areas\Admin\Views\Shared\EditorTemplates\Post.cshtml"
Write(Html.ValidationMessageFor(p => p.Categoria));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Post> Html { get; private set; }
    }
}
#pragma warning restore 1591
