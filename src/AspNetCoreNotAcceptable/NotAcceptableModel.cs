using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AspNetCoreNotAcceptable
{
    internal class NotAcceptableModel
    {
        public const string NotAcceptableMessage = "The MIME type specified in the 'Accept' header is not acceptable.";

        [JsonProperty(PropertyName = "message")]
        public string Message { get; private set; }

        private NotAcceptableModel(string message)
        {
            Message = message;
        }

        internal static NotAcceptableModel Create()
        {
            return new NotAcceptableModel(NotAcceptableMessage);
        }
    }
}