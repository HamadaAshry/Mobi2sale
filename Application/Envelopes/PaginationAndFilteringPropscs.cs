using Application.Interfaces;

namespace Application.Envelopes
{
    public class PaginationAndFilteringPropscs : IPaginationAndFilterProps
    {
        public int? PageNumber { get ; set ; }
        public int? PageSize { get ; set ; }
        public int? SortColumn { get ; set ; }
        public string SortDirection { get ; set ; }
        public string SearchText { get; set; }
        public string SatrtDateFiltr { get ; set ; }
        public string EndtDateFiltr { get ; set ; }
        public string MaxValueFilter { get ; set ; }
        public string MinValueFilter { get ; set; }
    }
}