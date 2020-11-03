using Newtonsoft.Json;

namespace GlobalLogger.Logging
{
    public class DetalhesDoErro
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
