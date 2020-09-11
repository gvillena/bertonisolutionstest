using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace BertoniSolutionsTest.Data
{
  public class AlbumsService
  {
    private readonly IHttpClientFactory _clientFactory;
    public readonly string AlbumsServiceUrl = "http://jsonplaceholder.typicode.com/albums";
    public readonly string PhotosServiceUrl = "http://jsonplaceholder.typicode.com/photos";
    public readonly string CommentsServiceUrl = "http://jsonplaceholder.typicode.com/comments";


    public AlbumsService(IHttpClientFactory clientFactory)
    {
      _clientFactory = clientFactory ?? throw new ArgumentNullException(nameof(clientFactory));
    }

    public async Task<Album> GetAlbumAsync(int albumId)
    {
      var request = new HttpRequestMessage(HttpMethod.Get, $"{AlbumsServiceUrl}/{albumId}");

      var client = _clientFactory.CreateClient();

      var response = await client.SendAsync(request);

      if (response.IsSuccessStatusCode)
      {
        var responseString = await response.Content.ReadAsStringAsync();

        var responseAlbum = JsonConvert.DeserializeObject<Album>(responseString);

        return responseAlbum;
      }

      return null;
    }


    public async Task<List<Album>> GetAlbumsAsync()
    {
      var request = new HttpRequestMessage(HttpMethod.Get, AlbumsServiceUrl);

      var client = _clientFactory.CreateClient();

      var response = await client.SendAsync(request);

      if (response.IsSuccessStatusCode)
      {
        var responseString = await response.Content.ReadAsStringAsync();

        var responseCollection = JsonConvert.DeserializeObject<List<Album>>(responseString);

        return responseCollection;

      } else
      {
        return null;
      }

    }

    public async Task<Photo> GetAlbumPhotoAsync(int albumPhotoId)
    {
      var request = new HttpRequestMessage(HttpMethod.Get, $"{PhotosServiceUrl}/{albumPhotoId}");

      var client = _clientFactory.CreateClient();

      var response = await client.SendAsync(request);

      if (response.IsSuccessStatusCode)
      {
        var responseString = await response.Content.ReadAsStringAsync();

        var responsePhoto = JsonConvert.DeserializeObject<Photo>(responseString);

        return responsePhoto;
      }

      return null;
    }


    public async Task<List<Photo>> GetAlbumPhotosAsync(int albumId)
    {
      var request = new HttpRequestMessage(HttpMethod.Get, $"{PhotosServiceUrl}?albumId={albumId}");

      var client = _clientFactory.CreateClient();

      var response = await client.SendAsync(request);

      if (response.IsSuccessStatusCode)
      {
        var responseString = await response.Content.ReadAsStringAsync();

        var responseCollection = JsonConvert.DeserializeObject<List<Photo>>(responseString);

        return responseCollection;

      } else
      {
        return null;
      }
    }

    public async Task<List<Comment>> GetAlbumPhotoCommentsAsync(int photoId)
    {
      var request = new HttpRequestMessage(HttpMethod.Get, $"{CommentsServiceUrl}?postId={photoId}");

      var client = _clientFactory.CreateClient();

      var response = await client.SendAsync(request);

      if (response.IsSuccessStatusCode)
      {
        var responseString = await response.Content.ReadAsStringAsync();

        var responseCollection = JsonConvert.DeserializeObject<List<Comment>>(responseString);

        return responseCollection;

      } else
      {
        return null;
      }

    }
  }
}
