namespace Finnotech.Abstractions.Core
{
    public class Response<TResult>
    {
        public string TrackId { get; set; }

        public TResult Result { get; set; }

        public string Status { get; set; }

        public ResponseError Error { get; set; }

        public bool IsSuccess => Status == "DONE";
    }
}
