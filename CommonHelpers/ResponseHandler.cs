namespace CommonHelpers
{
    public class ResponseHandler:IResponseHandler
    {
        public bool Success { get; set; }   
        public string Message { get; set; } 
        public string JsonObj { get; set; }
    }

    public interface IResponseHandler
    {
         bool Success { get; set; }   
         string Message { get; set; } 
         string JsonObj { get; set; }
    }
}