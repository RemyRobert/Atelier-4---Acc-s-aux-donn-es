// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/invoices")]
    public partial class InvoiceList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "D:\jetbrains_project\Atelier-4---Acc-s-aux-donn-es\Invoicing\Invoicing\Client\Pages\InvoiceList.razor"
       

    static string ColorFromInvoiceState(Invoice invoice)
    {
        if (invoice.IsLate)
        {
            return "danger";
        }
        else if (invoice.IsPaid)
        {
            return "success";
        }
        else
        {
            return "default";
        }
    }

    private IEnumerable<Invoice> allInvoices = null;

    private Invoice newInvoice = new Invoice();
    private EditContext editContext;

    protected override async Task OnInitializedAsync()
    {
        allInvoices = await http.GetFromJsonAsync<IEnumerable<Invoice>>("api/invoices");

        editContext = new EditContext(newInvoice);
    }

    private async Task HandleValidSubmit()
    {
        var isValid = editContext.Validate();

        if (isValid)
        {
            await http.PostAsJsonAsync<Invoice>("api/invoices", newInvoice);
        }
        else
        {

        }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
