﻿using System;
using Microsoft.AspNetCore.Mvc;

namespace VersioningOptions.Controllers.v2019_08_01_1_0
{
    [ApiController]
    [Obsolete]
    [Route("api/[controller]")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public string Get(ApiVersion apiVersion) 
            => $"Controller = {GetType().Name}\nVersion = {apiVersion}";
    }
}
