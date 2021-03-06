#pragma checksum "C:\Users\g_vil\Desktop\Prueba\BertoniSolutionsTest\BertoniSolutionsTest\Pages\Comments.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9671288b7f0fafc846911bbd7c0a4db200ce0d81"
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
#line 3 "C:\Users\g_vil\Desktop\Prueba\BertoniSolutionsTest\BertoniSolutionsTest\Pages\Comments.razor"
using BertoniSolutionsTest.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/albums/{albumId:int}/photos/{albumPhotoId:int}/comments")]
    public partial class Comments : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\g_vil\Desktop\Prueba\BertoniSolutionsTest\BertoniSolutionsTest\Pages\Comments.razor"
       
    private Album album;
    private Photo albumPhoto;
    private List<Comment> albumPhotoComments;

    [Parameter]
    public int albumId { get; set; }

    [Parameter]
    public int albumPhotoId { get; set; }

    protected override async Task OnInitializedAsync()
    {
        album = await AlbumsService.GetAlbumAsync(albumId);
        albumPhoto = await AlbumsService.GetAlbumPhotoAsync(albumPhotoId);
        albumPhotoComments = await AlbumsService.GetAlbumPhotoCommentsAsync(albumPhotoId);
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AlbumsService AlbumsService { get; set; }
    }
}
#pragma warning restore 1591
