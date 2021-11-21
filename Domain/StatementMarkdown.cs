using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexTaskCreator.Domain
{
    public class MarkdownStatement
    {
        public string legend { get; set; }
        public string inputFormat { get; set; }
        public string outputFormat { get; set; }
        public string notes { get; set; }
        public bool showLimits { get; set; }
    }

    public class StatementMarkdown
    {
        public string locale { get; set; }
        public string type { get; set; }
        public string path { get; set; }
        public bool additional { get; set; }
        public string state { get; set; }
        public bool rendered { get; set; }
        public MarkdownStatement markdownStatement { get; set; }

        public static StatementMarkdown NewInstance(string legend, string input, string output)
        {
            return new StatementMarkdown()
            {
                locale = "ru",
                type = "markdown",
                path = "statements/.html/ru/texstatement.html",
                additional = false,
                state = "valid",
                rendered = false,
                markdownStatement = new MarkdownStatement()
                {
                    legend = legend,
                    inputFormat = input,
                    outputFormat = output,
                    notes = "",
                    showLimits = true,
                },
            };
        }
    }    
}
