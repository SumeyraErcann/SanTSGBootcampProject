#pragma checksum "C:\Users\bersu\Desktop\DiyetisyenSec\BootcampProje\BootcampProje.Web\Views\Hotel\list.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "302dddd924491c939865ff16287830aa40cb81c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hotel_list), @"mvc.1.0.view", @"/Views/Hotel/list.cshtml")]
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
#line 1 "C:\Users\bersu\Desktop\DiyetisyenSec\BootcampProje\BootcampProje.Web\Views\_ViewImports.cshtml"
using BootcampProje.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bersu\Desktop\DiyetisyenSec\BootcampProje\BootcampProje.Web\Views\_ViewImports.cshtml"
using BootcampProje.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"302dddd924491c939865ff16287830aa40cb81c7", @"/Views/Hotel/list.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86c5e3a550ccab054d20c4b7fcfaf3673b7ff888", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Hotel_list : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BootcampProje.Web.Models.Response.HotelProduct.GetArrivalAutocompleteResponse.Item>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1> Oteller</h1>\r\n<table class=\"table\">\r\n    <thead class=\"thead-dark\">\r\n        <tr>\r\n            <th scope=\"col\">Şehir</th>\r\n            <th scope=\"col\">Otel Adı</th>\r\n            \r\n             \r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 19 "C:\Users\bersu\Desktop\DiyetisyenSec\BootcampProje\BootcampProje.Web\Views\Hotel\list.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr scope=\"row\">\r\n                \r\n                <td>");
#nullable restore
#line 23 "C:\Users\bersu\Desktop\DiyetisyenSec\BootcampProje\BootcampProje.Web\Views\Hotel\list.cshtml"
               Write(item.city.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\bersu\Desktop\DiyetisyenSec\BootcampProje\BootcampProje.Web\Views\Hotel\list.cshtml"
               Write(item.hotel.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n         \r\n\r\n            </tr>         \r\n");
#nullable restore
#line 28 "C:\Users\bersu\Desktop\DiyetisyenSec\BootcampProje\BootcampProje.Web\Views\Hotel\list.cshtml"
        }       

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        $(document).ready(function () {\r\n            $(\"#cities\").autocomplete(\'");
#nullable restore
#line 35 "C:\Users\bersu\Desktop\DiyetisyenSec\BootcampProje\BootcampProje.Web\Views\Hotel\list.cshtml"
                                  Write(Url.Action("CityList", "Hotel"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\');\r\n        });\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BootcampProje.Web.Models.Response.HotelProduct.GetArrivalAutocompleteResponse.Item>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
