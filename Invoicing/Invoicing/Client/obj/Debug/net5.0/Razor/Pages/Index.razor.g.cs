#pragma checksum "D:\jetbrains_project\Atelier-4---Acc-s-aux-donn-es\Invoicing\Invoicing\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e0e25fc904406a51120dfaa5d8b41a0dfbd2439"
// <auto-generated/>
#pragma warning disable 1591
namespace Invoicing.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\jetbrains_project\Atelier-4---Acc-s-aux-donn-es\Invoicing\Invoicing\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\jetbrains_project\Atelier-4---Acc-s-aux-donn-es\Invoicing\Invoicing\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\jetbrains_project\Atelier-4---Acc-s-aux-donn-es\Invoicing\Invoicing\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\jetbrains_project\Atelier-4---Acc-s-aux-donn-es\Invoicing\Invoicing\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\jetbrains_project\Atelier-4---Acc-s-aux-donn-es\Invoicing\Invoicing\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\jetbrains_project\Atelier-4---Acc-s-aux-donn-es\Invoicing\Invoicing\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\jetbrains_project\Atelier-4---Acc-s-aux-donn-es\Invoicing\Invoicing\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\jetbrains_project\Atelier-4---Acc-s-aux-donn-es\Invoicing\Invoicing\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\jetbrains_project\Atelier-4---Acc-s-aux-donn-es\Invoicing\Invoicing\Client\_Imports.razor"
using Invoicing.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\jetbrains_project\Atelier-4---Acc-s-aux-donn-es\Invoicing\Invoicing\Client\_Imports.razor"
using Invoicing.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\jetbrains_project\Atelier-4---Acc-s-aux-donn-es\Invoicing\Invoicing\Client\_Imports.razor"
using Invoicing.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "D:\jetbrains_project\Atelier-4---Acc-s-aux-donn-es\Invoicing\Invoicing\Client\Pages\Index.razor"
 if (!init)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p>Interrogation du serveur...</p>");
#nullable restore
#line 8 "D:\jetbrains_project\Atelier-4---Acc-s-aux-donn-es\Invoicing\Invoicing\Client\Pages\Index.razor"
}
else
{


#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<h1>Your activity</h1>");
            __builder.OpenElement(2, "h2");
            __builder.AddContent(3, "Sales revenues : ");
            __builder.OpenElement(4, "strong");
            __builder.AddContent(5, 
#nullable restore
#line 14 "D:\jetbrains_project\Atelier-4---Acc-s-aux-donn-es\Invoicing\Invoicing\Client\Pages\Index.razor"
                                  SalesRevenue

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(6, " €");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(7, "h2");
            __builder.AddContent(8, "Outstanding : ");
            __builder.OpenElement(9, "strong");
            __builder.AddContent(10, 
#nullable restore
#line 16 "D:\jetbrains_project\Atelier-4---Acc-s-aux-donn-es\Invoicing\Invoicing\Client\Pages\Index.razor"
                               Outstanding

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(11, " €");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(12, "h2");
            __builder.AddContent(13, "Chiffre d\'affaire : ");
            __builder.OpenElement(14, "strong");
            __builder.AddContent(15, 
#nullable restore
#line 18 "D:\jetbrains_project\Atelier-4---Acc-s-aux-donn-es\Invoicing\Invoicing\Client\Pages\Index.razor"
                                     Ca

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(16, " €");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 19 "D:\jetbrains_project\Atelier-4---Acc-s-aux-donn-es\Invoicing\Invoicing\Client\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "D:\jetbrains_project\Atelier-4---Acc-s-aux-donn-es\Invoicing\Invoicing\Client\Pages\Index.razor"
      

    private string SalesRevenue;

    private string Outstanding;

    private string Ca;

    private bool init = false;

    protected override async Task OnInitializedAsync()
    {
        SalesRevenue = await http.GetStringAsync("api/invoices/dashboard/sales");

        Outstanding = await http.GetStringAsync("api/invoices/dashboard/outstanding");

        Ca = await http.GetStringAsync("api/invoices/dashboard/ca");

        init = true;

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
