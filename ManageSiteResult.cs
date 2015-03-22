﻿using System.Collections.Generic;

namespace Servant.Shared
{
    public class ManageSiteResult
    {
        public int IisSiteId { get; set; }
        public Enums.SiteResult Result { get; set; }
        public List<string> Errors { get; set; }

        public ManageSiteResult()
        {
            Errors = new List<string>();
        }
    }
}