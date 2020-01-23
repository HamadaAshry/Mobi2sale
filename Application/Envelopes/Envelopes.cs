using System.Collections.Generic;
using Application.Interfaces;

namespace Application.Envelopes
{
    public class Envelopes<T>:IEnvelopes<T> where T : class
    {
        public List<T> Data { get; set; }
        public int RecordsCount { get; set; }   
        
    }
}