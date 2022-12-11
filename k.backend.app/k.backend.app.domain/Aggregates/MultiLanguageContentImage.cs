using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k.backend.app.domain.Aggregates
{
    public class MultiLanguageContentImage
    {
        public long Id { get; set; }
        public string Url { get; set; }
        public long MultiLanguageContentId { get; set; }
        public MultiLanguageContent MultiLanguageContent { get; set; }
    }
}