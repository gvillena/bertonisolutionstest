﻿using Newtonsoft.Json;

namespace BertoniSolutionsTest.Data
{
  public class Photo
  {
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("albumId")]
    public int AlbumId { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("url")]
    public string Url { get; set; }

    [JsonProperty("thumbnailUrl")]
    public string ThumbnailUrl { get; set; }
  }
}
