﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Notion.Client
{
    public interface IDatabasesCreateBodyParameters
    {
        [JsonProperty("parent")]
        ParentPageInput Parent { get; set; }

        [JsonProperty("properties")]
        Dictionary<string, IPropertySchema> Properties { get; set; }

        [JsonProperty("title")]
        List<RichTextBaseInput> Title { get; set; }
    }
}
