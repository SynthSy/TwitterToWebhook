﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Twitter2D
{
    class TwitterConfig
    {
        [JsonProperty(Required = Required.Always)]
        public string ConsumerKey { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string ConsumerSecret { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string BearerToken { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string ImgurToken { get; set; }

        [JsonProperty]
        public string DebugWebhookURL { get; set; }

        [JsonProperty(Required = Required.Always)]
        public Dictionary<string, List<string>> AccountsToMonitor { get; set; }

        [JsonProperty(Required = Required.Always)]
        public Dictionary<string, string> DisplayNames { get; set; }

        [JsonProperty(Required = Required.Always)]
        public Dictionary<string, string> CustomMessages { get; set; }

        [JsonProperty(Required = Required.Always)]
        public Dictionary<string, string> RequiredKeywords { get; set; }

        [JsonProperty(Required = Required.Always)]
        public Dictionary<string, Uri> WebhookUrls { get; set; }
    }
}
