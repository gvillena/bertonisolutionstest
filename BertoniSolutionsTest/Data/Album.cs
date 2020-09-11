﻿using Newtonsoft.Json;

namespace BertoniSolutionsTest.Data
{
  public class Album
  {
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("userId")]
    public int UserId { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }
  }
}
