﻿using System;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class RelationUpdatePropertySchema : UpdatePropertySchema, IUpdatePropertySchema
    {
        [JsonProperty("relation")]
        public RelationInfo Relation { get; set; }

        public class RelationInfo
        {
            [JsonProperty("database_id")]
            public Guid DatabaseId { get; set; }

            [JsonProperty("synced_property_id")]
            public string SynchedPropertyId { get; set; }

            [JsonProperty("synced_property_name")]
            public string SynchedPropertyName { get; set; }
        }
    }
}
