using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashTable
{
	internal class LoggerRateLimiter
	{
		public Dictionary<string, int> logs;
		public LoggerRateLimiter()
		{
			logs = new Dictionary<string, int>();

		}

		//359. Logger Rate Limiter
		//Design a logger system that receives a stream of messages along with their timestamps. Each unique message should only be printed at most every 10 seconds (i.e. a message printed at timestamp t will prevent other identical messages from being printed until timestamp t + 10).

		//All messages will come in chronological order.Several messages may arrive at the same timestamp.
		//Implement the Logger class:
		//Logger() Initializes the logger object.
		//bool shouldPrintMessage(int timestamp, string message) Returns true if the message should be printed in the given timestamp, otherwise returns false.
		//
		
		//Example 1:		
		//Input
		//["Logger", "shouldPrintMessage", "shouldPrintMessage", "shouldPrintMessage", "shouldPrintMessage", "shouldPrintMessage", "shouldPrintMessage"]
		//[[], [1, "foo"], [2, "bar"], [3, "foo"], [8, "bar"], [10, "foo"], [11, "foo"]]
		//Output
		//[null, true, true, false, false, false, true]
		public bool ShouldPrintMessage(int timestamp, string message)
		{

			//Runtime: 218 ms
			//Memory Usage: 126.8 MB
			if (!logs.ContainsKey(message))
			{
				logs[message] = timestamp;
				return true;
			}
			int curTime = logs[message];
			if (curTime + 10 > timestamp)
				return false;

			logs[message] = timestamp;
			return true;
		}
	}
}
