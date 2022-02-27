

using BenchmarkDotNet.Attributes;

namespace SyncVsAsync
{
    [HtmlExporter]
    public class BenchmarkSyncVsAsync
    {
        private readonly RestClient _client = new RestClient();

        [Params(200, 200)]
        public int IterationCount;

        [Benchmark]
        public async Task GetAsyncEndpoint()
        {
            const string endpoint = "weatherforecast-async";
            var tasks = new List<Task>();

            for (int i = 0; i < IterationCount; i++)
            {
                tasks.Add(_client.GetData(endpoint));
            }

            await Task.WhenAll(tasks.ToArray());
        }

        [Benchmark]
        public async Task GetSyncEndpoint()
        {
            const string endpoint = "weatherforecast-sync";
            var tasks = new List<Task>();

            for (int i = 0; i < IterationCount; i++)
            {
                tasks.Add(_client.GetData(endpoint));
            }

            await Task.WhenAll(tasks.ToArray());
        }


    }
}
