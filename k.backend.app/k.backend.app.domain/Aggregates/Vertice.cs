using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k.backend.app.domain.Aggregates
{
    public class Vertice
    {
        public long Id { get; set; }
        public long BoundingPolyId { get; set; }
        public BoundingPoly BoundingPoly { get; set; }
        public decimal X { get; set; }
        public decimal Y { get; set; }
    }
}