using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace YandexTaskCreator.Domain
{
	[XmlRoot(ElementName = "localized-names")]
	public class Localizednames
	{

		[XmlElement(ElementName = "key")]
		public string Key { get; set; }

		[XmlElement(ElementName = "value")]
		public string Value { get; set; }
	}

	[XmlRoot(ElementName = "invocation-limits")]
	public class Invocationlimits
	{

		[XmlElement(ElementName = "time-limit-millis")]
		public int Timelimitmillis { get; set; }

		[XmlElement(ElementName = "idleness-limit-millis")]
		public int Idlenesslimitmillis { get; set; }

		[XmlElement(ElementName = "memory-limit")]
		public int Memorylimit { get; set; }

		[XmlElement(ElementName = "output-limit")]
		public int Outputlimit { get; set; }
	}

	[XmlRoot(ElementName = "value")]
	public class Value
	{

		[XmlElement(ElementName = "from")]
		public int From { get; set; }

		[XmlElement(ElementName = "to")]
		public int To { get; set; }

		[XmlElement(ElementName = "example")]
		public bool Example { get; set; }
	}

	[XmlRoot(ElementName = "test-sets")]
	public class Testsets
	{

		[XmlElement(ElementName = "key")]
		public int Key { get; set; }

		[XmlElement(ElementName = "value")]
		public Value Value { get; set; }
	}

	[XmlRoot(ElementName = "checker-settings")]
	public class Checkersettings
	{

		[XmlElement(ElementName = "standard-name")]
		public string Standardname { get; set; }

		[XmlElement(ElementName = "type")]
		public string Type { get; set; }

		[XmlElement(ElementName = "invocation-limits")]
		public Invocationlimits Invocationlimits { get; set; }
	}

	[XmlRoot(ElementName = "file-set")]
	public class Fileset
	{

		[XmlElement(ElementName = "input-file")]
		public string Inputfile { get; set; }

		[XmlElement(ElementName = "output-file")]
		public string Outputfile { get; set; }

		[XmlElement(ElementName = "redirect-stdin")]
		public bool Redirectstdin { get; set; }

		[XmlElement(ElementName = "redirect-stdout")]
		public bool Redirectstdout { get; set; }
	}

	[XmlRoot(ElementName = "problem-meta")]
	public class ProblemMeta
	{

		[XmlElement(ElementName = "localized-names")]
		public List<Localizednames> Localizednames { get; set; }

		[XmlElement(ElementName = "author")]
		public string Author { get; set; }

		[XmlElement(ElementName = "invocation-limits")]
		public Invocationlimits Invocationlimits { get; set; }

		[XmlElement(ElementName = "test-sets")]
		public List<Testsets> Testsets { get; set; }

		[XmlElement(ElementName = "max-source-size-bytes")]
		public int Maxsourcesizebytes { get; set; }

		[XmlElement(ElementName = "checker-settings")]
		public Checkersettings Checkersettings { get; set; }

		[XmlElement(ElementName = "problem-type")]
		public string Problemtype { get; set; }

		[XmlElement(ElementName = "test-file-type")]
		public string Testfiletype { get; set; }

		[XmlElement(ElementName = "default-locale")]
		public string Defaultlocale { get; set; }

		[XmlElement(ElementName = "file-set")]
		public Fileset Fileset { get; set; }

		public static ProblemMeta NewInstance(string ruName, string enName)
        {
			return new ProblemMeta()
			{
				Localizednames = new List<Localizednames>()
				{
					new Localizednames() {Key = "ru", Value = ruName},
					new Localizednames() {Key = "en", Value = enName}
				},
				Author = "Сергей Безуглов",
				Invocationlimits = new Invocationlimits()
				{
					Timelimitmillis = 1000,
					Idlenesslimitmillis = 10000,
					Memorylimit = 67108864,
					Outputlimit = 67108864,
				},
				Testsets = new List<Testsets> { 
					new Testsets()
                    {
						Key = 1,
						Value = new Value()
						{
							From = 1,
							To = 3,
							Example = true,
						},
					},
					new Testsets()
					{
						Key = 2,
						Value = new Value()
						{
							From = 1,
							To = 5,
							Example = false,
						},
					}
				},
				Maxsourcesizebytes = 262144,
				Checkersettings = new Checkersettings()
				{
					Standardname = "cmp_file",
					Type = "standard-checker",
					Invocationlimits = new Invocationlimits()
					{
						Timelimitmillis = 10000,
						Idlenesslimitmillis = 10000,
						Memorylimit = 268435456,
						Outputlimit = 268435456,
					},
				},
				Problemtype = "problem-with-checker",
				Testfiletype = "text",
				Defaultlocale = "ru",
				Fileset = new Fileset()
				{
					Inputfile = "input.txt",
					Outputfile = "output.txt",
					Redirectstdin = true,
					Redirectstdout = true,
				},
			};
		}
	}
}
