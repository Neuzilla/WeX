using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WexOne.Dto
{
    public class DatatablePagedResultDto<T> : IOutputDto
    {
        public DatatablePagedResultDto(int total, IReadOnlyList<T> rows)
        {
            this.recordsTotal = total;
            this.data = rows;
        }

        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public IReadOnlyList<T> data { get; set; }
    }
}
