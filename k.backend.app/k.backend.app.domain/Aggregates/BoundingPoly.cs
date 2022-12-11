using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k.backend.app.domain.Aggregates
{
    public class BoundingPoly
    {
        public long Id { get; set; }
        public OcrResponse OcrResponse { get; set; }
        public IEnumerable<Vertice> Vertices { get; set; }
    }
}