using BenchmarkDotNet.Running;
using DotNetBenchmark.Common;

namespace DotNetBenchmark.WorkerService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            // var summary = BenchmarkRunner.Run<MathCustom>();
            // var summary = BenchmarkRunner.Run<Md5VsSha256>();
            var summary = BenchmarkRunner.Run<StringBenchmark>();


            //var random = new Random();
            //var watch = new Stopwatch();

            //while (!stoppingToken.IsCancellationRequested)
            //{
            //    int valueA = random.Next(0, 100);
            //    int valueB = random.Next(0, 100);

            //    watch.Start();
            //    int resultCustom = MathCustom.SumCustom(valueA, valueB);
            //    watch.Stop();
            //    _logger.LogInformation($"MathCustom elapsed: {watch.ElapsedTicks} - Result {resultCustom}");

            //    watch.Reset();
            //    watch.Start();
            //    int mathResult = MathCustom.SumStd(valueA, valueB);
            //    watch.Stop();
            //    _logger.LogInformation($"Default elapsed: {watch.ElapsedTicks} - Result {mathResult}");

            //    _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
            //    await Task.Delay(1000, stoppingToken);
            //}
        }
    }
}