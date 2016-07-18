using Abp.Application.Services.Dto;
using System.Collections.Generic;

namespace WexOne.Dto
{
    public class DatatablePagedResultDto<T> : IOutputDto
    {
        public DatatablePagedResultDto(int total,int filtered, IReadOnlyList<T> rows)
        {
            this.recordsTotal = total;
            this.recordsFiltered = filtered;
            this.data = rows;
        }

        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public IReadOnlyList<T> data { get; set; }
    }
}
