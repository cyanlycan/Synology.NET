﻿using SynologyClient.Response;

namespace SynologyClient
{
    public class FavoriteAddResponse : BaseSynologyResponse
    {
        public FavoriteAdd Data { get; set; }
    }
}