#pragma checksum "C:\Users\melleuch\Documents\Visual Studio 2017\Projects\Repository\Repository\Views\Shared\_Modal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2ed1561386428641af63dda5651b9e87e032b04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Modal), @"mvc.1.0.view", @"/Views/Shared/_Modal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Modal.cshtml", typeof(AspNetCore.Views_Shared__Modal))]
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
#line 1 "C:\Users\melleuch\Documents\Visual Studio 2017\Projects\Repository\Repository\Views\_ViewImports.cshtml"
using Repository;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2ed1561386428641af63dda5651b9e87e032b04", @"/Views/Shared/_Modal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a006969bd6ea3dc9a4617d302f78f5d2a968ac2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Modal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Repository.ViewModels.BootstrapModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 25, true);
            WriteLiteral("\r\n<div aria-hidden=\"true\"");
            EndContext();
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 70, "\"", 108, 1);
#line 3 "C:\Users\melleuch\Documents\Visual Studio 2017\Projects\Repository\Repository\Views\Shared\_Modal.cshtml"
WriteAttributeValue("", 88, Model.AreaLabeledId, 88, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(109, 28, true);
            WriteLiteral(" role=\"dialog\" tabindex=\"-1\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 137, "\"", 151, 1);
#line 3 "C:\Users\melleuch\Documents\Visual Studio 2017\Projects\Repository\Repository\Views\Shared\_Modal.cshtml"
WriteAttributeValue("", 142, Model.ID, 142, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(152, 30, true);
            WriteLiteral(" class=\"modal fade\">\r\n    <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 182, "\"", 224, 2);
            WriteAttributeValue("", 190, "modal-dialog", 190, 12, true);
#line 4 "C:\Users\melleuch\Documents\Visual Studio 2017\Projects\Repository\Repository\Views\Shared\_Modal.cshtml"
WriteAttributeValue(" ", 202, Model.ModalSizeClass, 203, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(225, 90, true);
            WriteLiteral(">\r\n        <div class=\"modal-content\">          \r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Repository.ViewModels.BootstrapModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
