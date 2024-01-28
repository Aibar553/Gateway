﻿using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.ApiGateway
{
    public class ApiGatewayResponseCacheSettings
    {
        //     Gets or sets the value of the cache profile name.
        public string CacheProfileName { get; set; }
        //     Gets or sets the duration in seconds for which the response is cached. This sets
        //     "max-age" in "Cache-control" header.
        public int Duration { get; set; }
        //     Gets or sets the location where the data from a particular URL must be cached.
        public ResponseCacheLocation Location { get; set; }
        //     Gets or sets the value which determines whether the data should be stored or
        //     not. When set to true, it sets "Cache-control" header to "no-store". Ignores
        //     the "Location" parameter for values other than "None". Ignores the "duration"
        //     parameter.
        public bool NoStore { get; set; }
        //     Gets or sets the value for the Vary response header.
        public string VaryByHeader { get; set; }
        //     Gets or sets the query keys to vary by.
        public string[] VaryByQueryKeys { get; set; }
    }
}
