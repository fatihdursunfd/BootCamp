#pragma checksum "C:\Users\fatih\source\repos\BootCampMovieApp\BootCampMovieApp\Views\Shared\Components\Genres\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ea64d505a690d5b08c2f3fe96937b61dbd09fe4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Genres_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Genres/Default.cshtml")]
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
#line 1 "C:\Users\fatih\source\repos\BootCampMovieApp\BootCampMovieApp\Views\_ViewImports.cshtml"
using BootCampMovieApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fatih\source\repos\BootCampMovieApp\BootCampMovieApp\Views\_ViewImports.cshtml"
using BootCampMovieApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\fatih\source\repos\BootCampMovieApp\BootCampMovieApp\Views\_ViewImports.cshtml"
using BootCampMovieApp.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\fatih\source\repos\BootCampMovieApp\BootCampMovieApp\Views\_ViewImports.cshtml"
using BootCampMovieApp.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ea64d505a690d5b08c2f3fe96937b61dbd09fe4", @"/Views/Shared/Components/Genres/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a658534b39d0e213e9b480197bea9d3f3cabe0ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Genres_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Genre>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"list-group\">\r\n    <a href=\"/movies/list\"");
            BeginWriteAttribute("class", " class=\"", 75, "\"", 171, 4);
            WriteAttributeValue("", 83, "list-group-item", 83, 15, true);
            WriteAttributeValue(" ", 98, "list-group-item-action", 99, 23, true);
#nullable restore
#line 4 "C:\Users\fatih\source\repos\BootCampMovieApp\BootCampMovieApp\Views\Shared\Components\Genres\Default.cshtml"
WriteAttributeValue(" ", 121, ViewBag.SelectedGenre == null ? "active" : "", 122, 48, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 170, "", 171, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        Tüm Filmler\r\n    </a>\r\n");
#nullable restore
#line 7 "C:\Users\fatih\source\repos\BootCampMovieApp\BootCampMovieApp\Views\Shared\Components\Genres\Default.cshtml"
     foreach(var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 272, "\"", 305, 2);
            WriteAttributeValue("", 279, "/movies/list/", 279, 13, true);
#nullable restore
#line 9 "C:\Users\fatih\source\repos\BootCampMovieApp\BootCampMovieApp\Views\Shared\Components\Genres\Default.cshtml"
WriteAttributeValue("", 292, item.GenreId, 292, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 306, "\"", 415, 4);
            WriteAttributeValue("", 314, "list-group-item", 314, 15, true);
            WriteAttributeValue(" ", 329, "list-group-item-action", 330, 23, true);
#nullable restore
#line 9 "C:\Users\fatih\source\repos\BootCampMovieApp\BootCampMovieApp\Views\Shared\Components\Genres\Default.cshtml"
WriteAttributeValue(" ", 352, ViewBag.SelectedGenre==item.GenreId.ToString()?"active":"", 353, 61, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 414, "", 415, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 10 "C:\Users\fatih\source\repos\BootCampMovieApp\BootCampMovieApp\Views\Shared\Components\Genres\Default.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </a>\r\n");
#nullable restore
#line 12 "C:\Users\fatih\source\repos\BootCampMovieApp\BootCampMovieApp\Views\Shared\Components\Genres\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Genre>> Html { get; private set; }
    }
}
#pragma warning restore 1591
