﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class CalloutUpdateBlock : UpdateBlock, IUpdateBlock
    {
        [JsonProperty("callout")]
        public Info Callout { get; set; }

        public class Info
        {
            [JsonProperty("text")]
            public IEnumerable<RichTextBaseInput> Text { get; set; }

            [JsonProperty("icon")]
            public IPageIcon Icon { get; set; }
        }
    }
}
