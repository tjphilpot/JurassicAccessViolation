using System;
using System.IO;
using Jurassic;

namespace JurassicAccessViolationTest
{
	class Program
	{
		static void Main(string[] args)
		{
			string xmlDomJs = File.ReadAllText("xmldom.js");
			string loadAbbrevsJs = File.ReadAllText("loadabbrevs.js");
			string citeprocJs = File.ReadAllText("citeproc.js");

			for (int i = 0; i < 100; i++)
			{
				Console.WriteLine("Loading into engine - attempt {0}", i);
				ScriptEngine engine = new ScriptEngine();
				engine.Execute(xmlDomJs);
				engine.Execute(loadAbbrevsJs);
				engine.Execute(citeprocJs);
			}
		}
	}
}