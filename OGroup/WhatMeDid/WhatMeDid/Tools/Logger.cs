using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatMeDid.Tools
{
	public static class Logger
	{
		private static string filename = "log.txt";
		public static void Write(string msg)
		{
			File.AppendAllText(filename, msg, Encoding.UTF8);
			File.AppendAllText(filename, "\n", Encoding.UTF8);
		}
	}
}
