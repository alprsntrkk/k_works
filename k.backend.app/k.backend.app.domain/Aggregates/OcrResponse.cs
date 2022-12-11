using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k.backend.app.domain.Aggregates
{
    public class OcrResponse
    {
        public long Id { get; set; }
        public string Locale { get; set; }
        public string Description { get; set; }
        public BoundingPoly BoundingPoly { get; set; }
        public long BoundingPolyId { get; set; }
    }
}