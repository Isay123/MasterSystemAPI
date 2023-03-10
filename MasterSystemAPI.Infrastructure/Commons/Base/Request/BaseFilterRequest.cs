using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterSystemAPI.Infrastructure.Commons.Base.Request
{
    public class BaseFilterRequest : BasePaginationRequest
    {
        public int? NumFilter { get; set; } = null;

        public string? TextFilter { get; set; } = null;
        public int? StateFilter { get; set; } = null;

        public string? StartDate { get; set; } = null;

        public string? EndData { get; set; } = null;

        public bool Download { get; set; } = false;
    }
}
