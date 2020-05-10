namespace Dhgms.Whipstaff.Tests.Benchmarks.ValueConverters
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    using BenchmarkIt;

    using Xunit;

    using System.Windows.Data;

    public class ExpandedConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return ((string)value == (string)parameter);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return parameter;
        }
    }

    public class ExpandedValueConverterBenchmarkTests
    {
        [Fact]
        public void EnsureQuicker()
        {
            const string str = "abcedf";
            Benchmark.This("string.Contains 1", () => "abcedf".Contains("ef"))
                .Against.This("string.Contains 2", () => "abcdef".Contains("ef"))
                .Against.This("string.IndexOf", () => "abcdef".IndexOf("ef"))
                .Against.This("string.IndexOf Ordinal", () => "abcdef".IndexOf("ef", StringComparison.Ordinal))
                .Against.This("string.Contains with Closure", () => str.Contains("ef"))
                .Against.This("string.IndexOf with Closure", () => str.IndexOf("ef"))
                .Against.This("string.Contains with Closure", () => str.Contains("ef"))
                .Against.This("string.IndexOf Closure Ordinal", () => str.IndexOf("ef", StringComparison.Ordinal))
                .WithWarmup(1000)
                .For(10000000)
                .Iterations().PrintComparison();

            Console.WriteLine("V2");
            BenchMark2("string.Contains 1", () => "abcedf".Contains("ef"));
            BenchMark2("string.Contains 2", () => "abcdef".Contains("ef"));
            BenchMark2("string.IndexOf", () => "abcdef".IndexOf("ef"));
            BenchMark2("string.IndexOf Ordinal", () => "abcdef".IndexOf("ef", StringComparison.Ordinal));
            BenchMark2("string.Contains with Closure", () => str.Contains("ef"));
            BenchMark2("string.IndexOf with Closure", () => str.IndexOf("ef"));
            BenchMark2("string.Contains with Closure", () => str.Contains("ef"));
            BenchMark2("string.IndexOf Closure Ordinal", () => str.IndexOf("ef", StringComparison.Ordinal));
            var x = new DeterministicHelper<bool>(() => str.Contains("ef"));
            BenchMark2("string.Contains with Closure with Deterministic Wrapper", () => { var a = x.Value; });
        }

        [Fact]
        public void DoBenchmark()
        {
            var vc = new ExpandedConverter();
            Benchmark.This("ValueConverter", () => { var a = (bool)vc.Convert("1", null, "1", null); })
                .Against.This("Static Helper Method", () => { var a = IsExpanded("1", "1"); })
                .WithWarmup(1000)
                .For(10000000)
                .Iterations().PrintComparison();
        }

        static bool IsExpanded(string a, string b)
        {
            return a == b;
        }

        public static void BenchMark2(string name, Action subject)
        {
            GC.Collect();  // compact Heap
            GC.WaitForPendingFinalizers(); // and wait for the finalizer queue to empty

            for (int i = 0; i < 1000; i++)
            {
                subject();     // warm up
            }

            var watch = new Stopwatch();
            watch.Reset();
            watch.Start();

            for (int i = 0; i < 10000000; i++)
            {
                subject();
            }

            watch.Stop();
            Console.WriteLine(name + " : " + watch.Elapsed.TotalMilliseconds);
        }

        internal class DeterministicHelper<T>
            where T: struct
        {
            private readonly Lazy<T> lazyResult;

            internal DeterministicHelper(Func<T> function)
            {
                lazyResult = new Lazy<T>(function);
            }

            internal T Value
            {
                get
                {
                    return lazyResult.Value;
                }
            }
        }
    }
}