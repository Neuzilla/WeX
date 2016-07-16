using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WexOne.Dto
{
    public class DatatablesPagedAndSortedInputDto : IInputDto, IPagedResultRequest, ISortedResultRequest
    {
        /// <summary>
        /// Request sequence number sent by DataTable,
        /// same value must be returned in response
        /// </summary>       
        public string sEcho { get; set; }

        /// <summary>
        /// Text used for filtering
        /// </summary>
        public string sSearch { get; set; }

        /// <summary>
        /// Number of records that should be shown in table
        /// </summary>
        public int iDisplayLength { get; set; }

        /// <summary>
        /// First record that should be shown(used for paging)
        /// </summary>
        public int iDisplayStart { get; set; }

        /// <summary>
        /// Number of columns in table
        /// </summary>
        public int iColumns { get; set; }

        /// <summary>
        /// Number of columns that are used in sorting
        /// </summary>
        public int iSortingCols { get; set; }

        /// <summary>
        /// Comma separated list of column names
        /// </summary>
        public string sColumns { get; set; }

        public int MaxResultCount
        {
            get
            {
                return iDisplayLength;
            }

            set
            {
                iDisplayLength = value;
            }
        }

        public int SkipCount
        {
            get
            {
                return iDisplayStart;
            }

            set
            {
                iDisplayStart = value;
            }
        }

        public string Sorting
        {
            get
            {
                return sColumns;
            }

            set
            {
                sColumns = value;
            }
        }
    }
}
