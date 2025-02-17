﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class SelectProperty : Property
    {
        public override PropertyType Type => PropertyType.Select;
        public OptionWrapper<SelectOption> Select { get; set; }
    }

    public class OptionWrapper<T>
    {
        [JsonProperty("options")]
        public List<T> Options { get; set; }
    }

    public class SelectOption
    {
        /// <summary>
        /// Name of the option as it appears in Notion.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// ID of the option.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Color of the option. Possible values are: "default", "gray", "brown", "red", "orange", "yellow", "green", "blue", "purple", "pink". Defaults to "default".
        /// </summary>
        [JsonProperty("color")]
        public string Color { get; set; }
    }

    public class MultiSelectProperty : Property
    {
        public override PropertyType Type => PropertyType.MultiSelect;

        [JsonProperty("multi_select")]
        public OptionWrapper<SelectOption> MultiSelect { get; set; }
    }
}
