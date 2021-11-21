using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexTaskCreator.Domain
{
    public class LocalizedNames
    {
        public string ru { get; set; }
        public string en { get; set; }
    }

    public class InvocationLimits
    {
        public int timeLimitMillis { get; set; }
        public int idlenessLimitMillis { get; set; }
        public int memoryLimit { get; set; }
        public int outputLimit { get; set; }
    }

    public class _1
    {
        public int from { get; set; }
        public int to { get; set; }
        public bool example { get; set; }
    }

    public class TestSets
    {
        public _1 _1 { get; set; }
    }

    public class PerCompilerInvocationLimits
    {
    }

    public class AuthorSolutionFile2CompilerId
    {
    }

    public class ProcessEnvironment
    {
    }

    public class CheckerSettings
    {
        public ProcessEnvironment processEnvironment { get; set; }
        public string standardName { get; set; }
        public string type { get; set; }
        public InvocationLimits invocationLimits { get; set; }
    }

    public class FileSet
    {
        public string inputFile { get; set; }
        public string outputFile { get; set; }
        public bool redirectStdin { get; set; }
        public bool redirectStdout { get; set; }
    }

    public class TaskMetaJson
    {
        public LocalizedNames localizedNames { get; set; }
        public string author { get; set; }
        public InvocationLimits invocationLimits { get; set; }
        public Dictionary<string, _1> testSets { get; set; }
        public PerCompilerInvocationLimits perCompilerInvocationLimits { get; set; }
        public int maxSourceSizeBytes { get; set; }
        public AuthorSolutionFile2CompilerId authorSolutionFile2CompilerId { get; set; }
        public CheckerSettings checkerSettings { get; set; }
        public string problemType { get; set; }
        public string testFileType { get; set; }
        public List<object> generatorLaunchers { get; set; }
        public string defaultLocale { get; set; }
        public FileSet fileSet { get; set; }

        public static TaskMetaJson NewInstance(string ruName, string enName)
        {
            TaskMetaJson taskmetajson = new TaskMetaJson()
            {
                localizedNames = new LocalizedNames()
                {
                    ru = ruName,
                    en = enName,
                },
                author = "Сергей Безуглов",
                invocationLimits = new InvocationLimits()
                {
                    timeLimitMillis = 1000,
                    idlenessLimitMillis = 10000,
                    memoryLimit = 67108864,
                    outputLimit = 67108864,
                },
                testSets = new Dictionary<string, _1>()
                {
                    {
                        "1", new _1() { 
                            from = 1,
                            to = 5,
                            example = false
                        } 
                    }
                },
                perCompilerInvocationLimits = new PerCompilerInvocationLimits(),
                maxSourceSizeBytes = 262144,
                authorSolutionFile2CompilerId = new AuthorSolutionFile2CompilerId(),
                checkerSettings = new CheckerSettings()
                {
                    processEnvironment = new ProcessEnvironment(),
                    standardName = "cmp_file",
                    type = "standard-checker",
                    invocationLimits = new InvocationLimits()
                    {
                        timeLimitMillis = 10000,
                        idlenessLimitMillis = 10000,
                        memoryLimit = 268435456,
                        outputLimit = 268435456,
                    },
                },
                problemType = "problem-with-checker",
                testFileType = "text",
                generatorLaunchers = new List<object>(),
                defaultLocale = "ru",
                fileSet = new FileSet()
                {
                    inputFile = "input.txt",
                    outputFile = "output.txt",
                    redirectStdin = true,
                    redirectStdout = true,
                },
            };

            return taskmetajson;
        }
    }

    

}
