using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace service.Models
{
    public class ArtifactModel
    {
        public long Id { get; set; }
        public string ItemName { get; set; }
        public long BitstreamId { get; set; }
        public string ContentType { get; set; }
    }
}