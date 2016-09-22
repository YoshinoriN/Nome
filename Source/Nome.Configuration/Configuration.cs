﻿using Newtonsoft.Json;

namespace Nome.Configuration
{
    [JsonObject("configuration")]
    public class Configuration
    {
        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("connection")]
        public Connection Connection { get; set; }
    }

    [JsonObject("connection")]
    public class Connection
    {
        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }
}
