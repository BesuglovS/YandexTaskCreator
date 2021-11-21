using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexTaskCreator.Data
{
    public static class Txt
    {
        public static string metaJson1 = "{\"localizedNames\":{\"ru\":\"";
        public static string metaJson2 = "\",\"en\":\"";
        public static string metaJson3 = "\"},\"author\":\"Сергей Безуглов\",\"invocationLimits\":{\"timeLimitMillis\":1000,\"idlenessLimitMillis\":10000,\"memoryLimit\":67108864,\"outputLimit\":67108864},\"testSets\":{\"1\":{\"from\":1,\"to\":5,\"example\":false}},\"perCompilerInvocationLimits\":{},\"maxSourceSizeBytes\":262144,\"authorSolutionFile2CompilerId\":{},\"checkerSettings\":{\"processEnvironment\":{},\"standardName\":\"cmp_file\",\"type\":\"standard-checker\",\"invocationLimits\":{\"timeLimitMillis\":10000,\"idlenessLimitMillis\":10000,\"memoryLimit\":268435456,\"outputLimit\":268435456}},\"problemType\":\"problem-with-checker\",\"testFileType\":\"text\",\"generatorLaunchers\":[],\"defaultLocale\":\"ru\",\"fileSet\":{\"inputFile\":\"input.txt\",\"outputFile\":\"output.txt\",\"redirectStdin\":true,\"redirectStdout\":true}}";

        public static string metaXml1 = "<problem-meta><localized-names><key>ru</key><value>";
        public static string metaXml2 = "</value></localized-names><localized-names><key>en</key><value>";
        public static string metaXml3 = "</value></localized-names><author>Сергей Безуглов</author><invocation-limits><time-limit-millis>1000</time-limit-millis><idleness-limit-millis>10000</idleness-limit-millis><memory-limit>67108864</memory-limit><output-limit>67108864</output-limit></invocation-limits><test-sets><key>1</key><value><from>1</from><to>5</to><example>false</example></value></test-sets><max-source-size-bytes>262144</max-source-size-bytes><checker-settings><standard-name>cmp_file</standard-name><type>standard-checker</type><invocation-limits><time-limit-millis>10000</time-limit-millis><idleness-limit-millis>10000</idleness-limit-millis><memory-limit>268435456</memory-limit><output-limit>268435456</output-limit></invocation-limits></checker-settings><problem-type>problem-with-checker</problem-type><test-file-type>text</test-file-type><default-locale>ru</default-locale><file-set><input-file>input.txt</input-file><output-file>output.txt</output-file><redirect-stdin>true</redirect-stdin><redirect-stdout>true</redirect-stdout></file-set></problem-meta>";

        public static string statementHtml1 = "<div class=\"problem-statement problem-statement_type_markdown\">" + Environment.NewLine +
            "    <div class=\"header\">" + Environment.NewLine +
            "        <h1 class=\"title\">";
        public static string statementHtml2 = "</h1>" + Environment.NewLine +
            "        <table class=\"limits\">" + Environment.NewLine +
            "            <tbody>" + Environment.NewLine +
            "                <tr class=\"time-limit\">" + Environment.NewLine +
            "                    <td class=\"property-title\">Ограничение времени</td>" + Environment.NewLine +
            "                    <td>1 секунда</td>" + Environment.NewLine +
            "                </tr>" + Environment.NewLine +
            "                <tr class=\"memory-limit\">" + Environment.NewLine +
            "                    <td class=\"property-title\">Ограничение памяти</td>" + Environment.NewLine +
            "                    <td>64.0 Мб</td>" + Environment.NewLine +
            "                </tr>" + Environment.NewLine +
            "                <tr class=\"input-file\">" + Environment.NewLine +
            "                    <td class=\"property-title\">Ввод</td>" + Environment.NewLine +
            "                    <td colSpan=\"1\">стандартный ввод или input.txt</td>" + Environment.NewLine +
            "                </tr>" + Environment.NewLine +
            "                <tr class=\"output-file\">" + Environment.NewLine +
            "                    <td class=\"property-title\">Вывод</td>" + Environment.NewLine +
            "                    <td colSpan=\"1\">стандартный вывод или output.txt</td>" + Environment.NewLine +
            "                </tr>" + Environment.NewLine +
            "            </tbody>" + Environment.NewLine +
            "        </table>" + Environment.NewLine +
            "    </div>" + Environment.NewLine +
            "    <h2></h2>" + Environment.NewLine +
            "    <div class=\"legend\">" + Environment.NewLine +
            "        <div class=\"Markdown\">" + Environment.NewLine +
            "            <p class=\"paragraph\">";
        public static string statementHtml3 = "</p>" + Environment.NewLine +
            "        </div>" + Environment.NewLine +
            "    </div>" + Environment.NewLine +
            "    <h2>Формат ввода</h2>" + Environment.NewLine +
            "    <div class=\"input-specification\">" + Environment.NewLine +
            "        <div class=\"Markdown\">" + Environment.NewLine +
            "            <p class=\"paragraph\">";
        public static string statementHtml4 = "</p>" + Environment.NewLine +
            "        </div>" + Environment.NewLine +
            "    </div>" + Environment.NewLine +
            "    <h2>Формат вывода</h2>" + Environment.NewLine +
            "    <div class=\"output-specification\">" + Environment.NewLine +
            "        <div class=\"Markdown\">" + Environment.NewLine +
            "            <p class=\"paragraph\">";
        public static string statementHtml5 = "</p>" + Environment.NewLine +
            "        </div>" + Environment.NewLine +
            "    </div>" + Environment.NewLine +
            "</div>";

        public static string statementMarkdown1 = "{\"locale\":\"ru\",\"type\":\"markdown\",\"path\":\"statements/.html/ru/texstatement.html\",\"additional\":false,\"state\":\"valid\",\"rendered\":false,\"markdownStatement\":{\"legend\":\"";
        public static string statementMarkdown2 = "\",\"inputFormat\":\"";
        public static string statementMarkdown3 = "\",\"outputFormat\":\"";
        public static string statementMarkdown4 = "\",\"notes\":\"\",\"showLimits\":true}}";
    }
}
