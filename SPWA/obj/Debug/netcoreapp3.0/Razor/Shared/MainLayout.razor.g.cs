#pragma checksum "C:\Dev\School\SeniorProjectWebApp\SPWA\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70759f07c8db88386eaf622df9c620f7e7cf0fbb"
// <auto-generated/>
#pragma warning disable 1591
namespace SPWA.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Dev\School\SeniorProjectWebApp\SPWA\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Dev\School\SeniorProjectWebApp\SPWA\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Dev\School\SeniorProjectWebApp\SPWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Dev\School\SeniorProjectWebApp\SPWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Dev\School\SeniorProjectWebApp\SPWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Dev\School\SeniorProjectWebApp\SPWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Dev\School\SeniorProjectWebApp\SPWA\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Dev\School\SeniorProjectWebApp\SPWA\_Imports.razor"
using SPWA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Dev\School\SeniorProjectWebApp\SPWA\_Imports.razor"
using SPWA.Shared;

#line default
#line hidden
#nullable disable
    public class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<SPWA.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "main");
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "top-row px-4");
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenComponent<SPWA.Shared.LoginDisplay>(12);
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.AddMarkupContent(14, "<a href=\"https://docs.microsoft.com/en-us/aspnet/\" target=\"_blank\">About</a>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n\r\n    ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "content px-4");
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.AddContent(19, 
#nullable restore
#line 14 "C:\Dev\School\SeniorProjectWebApp\SPWA\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
