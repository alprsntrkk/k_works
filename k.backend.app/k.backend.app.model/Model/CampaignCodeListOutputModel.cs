using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k.backend.app.model.Model
{
    public class CampaignCodeListOutputModel
    {
        public List<CampaignCodeDataModel> Models { get; set; } = new List<CampaignCodeDataModel>();
    }

    public class CampaignCodeDataModel
    {
        public long Id { get; set; }
        public string Code { get; set; }
    }
}