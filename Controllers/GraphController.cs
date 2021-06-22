using System.IO;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Routing.Internal;

namespace routing_sample.Controllers
{
    public class GraphController : ControllerBase
    {
        private readonly EndpointDataSource _endpointDataSource;
        private readonly DfaGraphWriter _graphWriter;

        public GraphController(
            EndpointDataSource endpointDataSource,
            DfaGraphWriter graphWriter)
        {
            _endpointDataSource = endpointDataSource;
            _graphWriter = graphWriter;
        }

        [HttpGet("graph")]
        public void GetGraph()
        {
            using var writer = new StreamWriter(HttpContext.Response.Body, Encoding.ASCII, 1024, true);
            _graphWriter.Write(_endpointDataSource, writer);
        }
    }
}