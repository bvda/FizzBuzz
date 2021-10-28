using System.Threading;
using System.Collections.Generic;

namespace FizzBuzz {
    public class ResultCollector {
        public bool Running { get; set; } = true;
        public string nextValue { private get; set; }
        public readonly IList<string> result = new List<string>();

        private readonly AutoResetEvent _event_1;
        private readonly AutoResetEvent _event_2;
        public ResultCollector(AutoResetEvent event_1, AutoResetEvent event_2) {
            _event_1 = event_1;
            _event_2 = event_2;
        }
        public void Run() {
            _event_2.WaitOne();
            while (Running) {
                result.Add(nextValue);
                _event_1.Set();
                _event_2.WaitOne();
            }
            _event_1.Set();
            System.Console.WriteLine("Goodbye from ResultCollector");
        }
    }
}