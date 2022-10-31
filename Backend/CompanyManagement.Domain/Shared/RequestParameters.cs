using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Domain.Shared
{
    public class RequestParameters
    {
        private int _pageSize = 200;

        private const int maxPageSize = 200;
        public int pageNumber { get; set; } = 1;
        public int pageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = (value > maxPageSize) ? maxPageSize : value;
            }
        }
    }
}
