using Newtonsoft.Json;

namespace CustomerApi.Model
{
    public class ErrorModel
    {
        public string Detail { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public int StatusCode { get; set; }
        public string Instance { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
