using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace BibliotecaDDD.Presentation.WebApi.Utils
{
    /// <summary>
    /// Classe para serialização de objeto em Json.
    /// </summary>
    public class JsonContent : HttpContent
    {
        private readonly MemoryStream _Stream = new MemoryStream();

        /// <summary>
        /// Construtor padrão.
        /// </summary>
        /// <param name="value">Objeto para serializar.</param>
        public JsonContent(object value)
        {
            Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var jw = new JsonTextWriter(new StreamWriter(_Stream))
            {
                Formatting = Formatting.Indented
            };

            var serializer = new JsonSerializer();
            serializer.Serialize(jw, value);
            jw.Flush();
            _Stream.Position = 0;
        }

        /// <summary>
        ///  Serialize the HTTP content to a stream as an asynchronous operation.(Retirado da classe base).
        /// </summary>
        /// <param name="stream">The target stream.</param>
        /// <param name="context">Information about the transport (channel binding token, for example).
        ///     This parameter may be null.</param>
        /// <returns>System.Threading.Tasks.Task.The task object representing
        ///     the asynchronous operation.</returns>
        protected override Task SerializeToStreamAsync(Stream stream, TransportContext context)
        {
            return _Stream.CopyToAsync(stream);
        }

        /// <summary>
        /// Determines whether the HTTP content has a valid length in bytes.(Retirado da classe base).
        /// </summary>
        /// <param name="length">The length in bytes of the HTTP content.</param>
        /// <returns>System.Boolean.true if length is a valid length; otherwise, false.</returns>
        protected override bool TryComputeLength(out long length)
        {
            length = _Stream.Length;
            return true;
        }
    }
}