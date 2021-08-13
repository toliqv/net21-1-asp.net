#pragma checksum "C:\NET21-1\aspnet\07_BlazorHosted\07_BlazorHosted\Client\Pages\Products.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6044b490be7f576bccb4e09febe1178ffa770e9"
// <auto-generated/>
#pragma warning disable 1591
namespace _07_BlazorHosted.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\NET21-1\aspnet\07_BlazorHosted\07_BlazorHosted\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\NET21-1\aspnet\07_BlazorHosted\07_BlazorHosted\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\NET21-1\aspnet\07_BlazorHosted\07_BlazorHosted\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\NET21-1\aspnet\07_BlazorHosted\07_BlazorHosted\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\NET21-1\aspnet\07_BlazorHosted\07_BlazorHosted\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\NET21-1\aspnet\07_BlazorHosted\07_BlazorHosted\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\NET21-1\aspnet\07_BlazorHosted\07_BlazorHosted\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\NET21-1\aspnet\07_BlazorHosted\07_BlazorHosted\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\NET21-1\aspnet\07_BlazorHosted\07_BlazorHosted\Client\_Imports.razor"
using _07_BlazorHosted.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\NET21-1\aspnet\07_BlazorHosted\07_BlazorHosted\Client\_Imports.razor"
using _07_BlazorHosted.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\NET21-1\aspnet\07_BlazorHosted\07_BlazorHosted\Client\_Imports.razor"
using _07_BlazorHosted.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/products")]
    public partial class Products : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container my-5");
            __builder.OpenElement(2, "AddProduct");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row row-cols-1 row-cols-md-4 g-4");
#nullable restore
#line 7 "C:\NET21-1\aspnet\07_BlazorHosted\07_BlazorHosted\Client\Pages\Products.razor"
         foreach (var product in products)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "card shadow");
            __builder.OpenElement(12, "img");
            __builder.AddAttribute(13, "src", 
#nullable restore
#line 11 "C:\NET21-1\aspnet\07_BlazorHosted\07_BlazorHosted\Client\Pages\Products.razor"
                               product.ImageUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(14, "class", "card-img-top");
            __builder.AddAttribute(15, "alt", 
#nullable restore
#line 11 "C:\NET21-1\aspnet\07_BlazorHosted\07_BlazorHosted\Client\Pages\Products.razor"
                                                                            product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "card-body");
            __builder.OpenElement(19, "h5");
            __builder.AddAttribute(20, "class", "card-title");
            __builder.AddContent(21, 
#nullable restore
#line 13 "C:\NET21-1\aspnet\07_BlazorHosted\07_BlazorHosted\Client\Pages\Products.razor"
                                                product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                        ");
            __builder.OpenElement(23, "p");
            __builder.AddAttribute(24, "class", "card-text");
            __builder.AddContent(25, 
#nullable restore
#line 14 "C:\NET21-1\aspnet\07_BlazorHosted\07_BlazorHosted\Client\Pages\Products.razor"
                                              product.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.OpenElement(27, "p");
            __builder.AddAttribute(28, "class", "card-text");
            __builder.AddContent(29, 
#nullable restore
#line 15 "C:\NET21-1\aspnet\07_BlazorHosted\07_BlazorHosted\Client\Pages\Products.razor"
                                              product.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                        ");
            __builder.OpenElement(31, "p");
            __builder.AddAttribute(32, "class", "card-text");
            __builder.AddContent(33, 
#nullable restore
#line 16 "C:\NET21-1\aspnet\07_BlazorHosted\07_BlazorHosted\Client\Pages\Products.razor"
                                              product.Category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                        ");
            __builder.OpenElement(35, "p");
            __builder.AddAttribute(36, "class", "card-text");
            __builder.AddContent(37, 
#nullable restore
#line 17 "C:\NET21-1\aspnet\07_BlazorHosted\07_BlazorHosted\Client\Pages\Products.razor"
                                              product.Vendor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                        ");
            __builder.AddMarkupContent(39, "<button class=\"btn btn-success px-5\">KÖP</button>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 22 "C:\NET21-1\aspnet\07_BlazorHosted\07_BlazorHosted\Client\Pages\Products.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\NET21-1\aspnet\07_BlazorHosted\07_BlazorHosted\Client\Pages\Products.razor"
       
    private List<Product> products;

    protected override async Task OnInitializedAsync()
    {
        products = new();
        products = await Http.GetFromJsonAsync<List<Product>>("api/products");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591