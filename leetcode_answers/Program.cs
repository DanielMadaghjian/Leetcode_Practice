using Serilog;
using Serilog.Events;
using Serilog.Formatting.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_answers
{
    public class Program
    {
        static void Main(string[] args)
        {
            // create logger
            Log.Logger = new LoggerConfiguration()
                // add console as logging target
                .WriteTo.Console()
                // add a logging target for warnings and higher severity  logs
                // structured in JSON format
                .WriteTo.File(new JsonFormatter(),
                              "important.json",
                              restrictedToMinimumLevel: LogEventLevel.Warning)
                // add a rolling file for all logs
                .WriteTo.File("all-.logs",
                              rollingInterval: RollingInterval.Day)
                // set default minimum level
                .MinimumLevel.Debug()
                .CreateLogger();
            // arrays and strings
            ArraysandStringsAnswers arraysandStringsAnswers = new ArraysandStringsAnswers();
            int[] nums2 = [2];
            int val2 = 3;
            arraysandStringsAnswers.RemoveElement(nums2, val2);


        }
    }
}
