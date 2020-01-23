using System.Collections.Generic;

namespace Application.Interfaces {
    public interface IEnvelopes<T>where T : class
     {
        List<T> Data { get; set; }
        int RecordsCount { get; set; }
       
    }
}