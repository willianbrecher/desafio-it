using Newtonsoft.Json;

namespace DesafioIt.WebApi.Responses
{
    public class ExceptionResponse
    {
        public ExceptionResponse(List<string> messages)
        {
            Messages = messages ?? throw new ArgumentNullException(nameof(messages));
        }

        public List<string> Messages { get; set; } = new();

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
