#pragma checksum "C:\Users\g_vil\Desktop\Prueba\BertoniSolutionsTest\BertoniSolutionsTest\Pages\Photos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c8d3851c7405175a73c3b6c501b23898f192fe3"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BertoniSolutionsTest.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\g_vil\Desktop\Prueba\BertoniSolutionsTest\BertoniSolutionsTest\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\g_vil\Desktop\Prueba\BertoniSolutionsTest\BertoniSolutionsTest\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\g_vil\Desktop\Prueba\BertoniSolutionsTest\BertoniSolutionsTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\g_vil\Desktop\Prueba\BertoniSolutionsTest\BertoniSolutionsTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\g_vil\Desktop\Prueba\BertoniSolutionsTest\BertoniSolutionsTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\g_vil\Desktop\Prueba\BertoniSolutionsTest\BertoniSolutionsTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\g_vil\Desktop\Prueba\BertoniSolutionsTest\BertoniSolutionsTest\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\g_vil\Desktop\Prueba\BertoniSolutionsTest\BertoniSolutionsTest\_Imports.razor"
using BertoniSolutionsTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\g_vil\Desktop\Prueba\BertoniSolutionsTest\BertoniSolutionsTest\_Imports.razor"
using BertoniSolutionsTest.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\g_vil\Desktop\Prueba\BertoniSolutionsTest\BertoniSolutionsTest\Pages\Photos.razor"
using BertoniSolutionsTest.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/albums/{albumId:int}/photos")]
    public partial class Photos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\g_vil\Desktop\Prueba\BertoniSolutionsTest\BertoniSolutionsTest\Pages\Photos.razor"
       
    private Album album;
    private List<Photo> albumPhotos;

    [Parameter]
    public int albumId { get; set; }

    protected override async Task OnInitializedAsync()
    {
        album = await AlbumsService.GetAlbumAsync(albumId);
        albumPhotos = await AlbumsService.GetAlbumPhotosAsync(albumId);
    }

    private void VerComentarios(int photoId)
    {
        NavigationManager.NavigateTo($"albums/{albumId}/photos/{photoId}/comments");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AlbumsService AlbumsService { get; set; }
    }
}
#pragma warning restore 1591
