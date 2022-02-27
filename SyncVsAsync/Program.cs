// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using SyncVsAsync;

BenchmarkRunner.Run<BenchmarkSyncVsAsync>();

Console.ReadLine();