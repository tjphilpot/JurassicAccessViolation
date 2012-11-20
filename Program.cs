using System;
using System.IO;
using Jurassic;

namespace JurassicAccessViolationTest
{
	class Program
	{
		static void Main(string[] args)
		{
			string xmlDomJS = File.ReadAllText("xmldom.js");
			string loadAbbrevsJS = File.ReadAllText("loadabbrevs.js");
			string citeprocJS = File.ReadAllText("citeproc.js");

			for (int i = 0; i < 100; i++)
			{
				Console.WriteLine("Loading into engine - attempt {0}", i);
				ScriptEngine engine = new ScriptEngine();
				engine.Execute(xmlDomJS);
				engine.Execute(loadAbbrevsJS);
				engine.Execute(citeprocJS);
			}
		}
	}
}
