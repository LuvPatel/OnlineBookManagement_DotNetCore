#pragma checksum "C:\Users\ProBook\Desktop\test2\Views\Catalog\Hold.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07babfa3deb6f209a395d3b182eb732c0bc5f9a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalog_Hold), @"mvc.1.0.view", @"/Views/Catalog/Hold.cshtml")]
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
#line 1 "C:\Users\ProBook\Desktop\test2\Views\_ViewImports.cshtml"
using Lib_Management;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ProBook\Desktop\test2\Views\_ViewImports.cshtml"
using Lib_Management.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07babfa3deb6f209a395d3b182eb732c0bc5f9a2", @"/Views/Catalog/Hold.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cebbc6dc6ae9d35f9064e8b08ccbd25a2110dcef", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalog_Hold : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lib_Management.Models.CheckOutModels.CheckOutModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ProBook\Desktop\test2\Views\Catalog\Hold.cshtml"
  
    ViewBag.Title = @Model.Title;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""header clearfix detailHeading"">
        <h2 class=""text-muted"">Place Hold on Library Item</h2>
    </div>

    <div class=""jumbotron"">
        <div class=""row"">
            <div class=""col-md-3"">
                <div>
                    <p id=""itemTitle"">");
#nullable restore
#line 15 "C:\Users\ProBook\Desktop\test2\Views\Catalog\Hold.cshtml"
                                 Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <img class=\"detailImage\"");
            BeginWriteAttribute("src", " src=\"", 470, "\"", 491, 1);
#nullable restore
#line 16 "C:\Users\ProBook\Desktop\test2\Views\Catalog\Hold.cshtml"
WriteAttributeValue("", 476, Model.ImageUrl, 476, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"col-md-9\">\r\n                <p>There are currently ");
#nullable restore
#line 21 "C:\Users\ProBook\Desktop\test2\Views\Catalog\Hold.cshtml"
                                  Write(Model.HoldCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" holds in the queue for this item.</p>\r\n");
#nullable restore
#line 23 "C:\Users\ProBook\Desktop\test2\Views\Catalog\Hold.cshtml"
                 using (Html.BeginForm("PlaceHold", "Catalog", FormMethod.Post))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\ProBook\Desktop\test2\Views\Catalog\Hold.cshtml"
               Write(Html.HiddenFor(a => a.AssetId));

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>\r\n                        Please insert a Library Card ID.\r\n                        ");
#nullable restore
#line 28 "C:\Users\ProBook\Desktop\test2\Views\Catalog\Hold.cshtml"
                   Write(Html.TextBoxFor(a => a.LibraryCardId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                    </div>\r\n                    <div>\r\n                        <button type=\"submit\" class=\"btn btn-info btn-lg\">Place Hold</button>\r\n                    </div>\r\n");
#nullable restore
#line 34 "C:\Users\ProBook\Desktop\test2\Views\Catalog\Hold.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lib_Management.Models.CheckOutModels.CheckOutModel> Html { get; private set; }
    }
}
#pragma warning restore 1591