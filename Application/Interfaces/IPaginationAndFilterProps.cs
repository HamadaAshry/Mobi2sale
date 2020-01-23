namespace Application.Interfaces {
    public interface IPaginationAndFilterProps {
        int? PageNumber { get; set; }
        int? PageSize { get; set; }
        int? SortColumn { get; set; }
        string SortDirection { get; set; }
        string SearchText { get; set; }
        string SatrtDateFiltr { get; set; }
        string EndtDateFiltr { get; set; }
        string MaxValueFilter { get; set; }
        string MinValueFilter { get; set; }

        

    }
}