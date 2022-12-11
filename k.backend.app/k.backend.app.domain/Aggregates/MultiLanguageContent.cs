using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k.backend.app.domain.Aggregates
{
    public class MultiLanguageContent
    {
        public long Id { get; private set; }
        public string Title { get; private set; }
        public string Detail { get; private set; }
        public string Category { get; private set; }
        private List<MultiLanguageContentImage> _multiLanguageContentImages { get; set; } = new List<MultiLanguageContentImage>();
        public IReadOnlyCollection<MultiLanguageContentImage> MultiLanguageContentImages => _multiLanguageContentImages;
        public string LanguageCode { get; private set; }
    }
}