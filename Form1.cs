using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using YandexTaskCreator.Data;
using YandexTaskCreator.Domain;

namespace YandexTaskCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveTask_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("Task"))
            {
                Directory.Delete("Task", true);
            }

            Directory.CreateDirectory(@"Task");
            Directory.CreateDirectory(@"Task\statements");
            Directory.CreateDirectory(@"Task\statements\ru");
            Directory.CreateDirectory(@"Task\statements\ru\html");
            Directory.CreateDirectory(@"Task\statements\ru\markdown");
            Directory.CreateDirectory(@"Task\tests");

            // Task\meta.json
            using (StreamWriter sw = new StreamWriter(@"Task\meta.json"))
            {                
                TaskMetaJson tmj = TaskMetaJson.NewInstance(TaskTitleRu.Text, TaskTitleEn.Text);
                string str = JsonConvert.SerializeObject(tmj);
                sw.Write(str);
            }

            // Task\meta.xml
            using (StreamWriter sw = new StreamWriter(@"Task\meta.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ProblemMeta));
                var xns = new XmlSerializerNamespaces();
                xns.Add(string.Empty, string.Empty);
                var m = ProblemMeta.NewInstance(TaskTitleRu.Text, TaskTitleEn.Text);
                XmlWriterSettings xws = new XmlWriterSettings();
                xws.Indent = false;
                xws.OmitXmlDeclaration = true;
                StringBuilder sb = new StringBuilder();
                XmlWriter xtw = XmlWriter.Create(sb, xws);
                serializer.Serialize(xtw, m, xns);
                string str = sb.ToString();
                sw.Write(str);
            }

            // Task\tests\001
            using (StreamWriter sw = new StreamWriter(@"Task\tests\001"))
            {                
                sw.Write(Test1In.Text);
            }
            // Task\tests\001.a
            using (StreamWriter sw = new StreamWriter(@"Task\tests\001.a"))
            {
                sw.Write(Test1Out.Text);
            }

            // Task\tests\002
            using (StreamWriter sw = new StreamWriter(@"Task\tests\002"))
            {
                sw.Write(Test2In.Text);
            }
            // Task\tests\002.a
            using (StreamWriter sw = new StreamWriter(@"Task\tests\002.a"))
            {
                sw.Write(Test2Out.Text);
            }

            // Task\tests\003
            using (StreamWriter sw = new StreamWriter(@"Task\tests\003"))
            {
                sw.Write(Test3In.Text);
            }
            // Task\tests\003.a
            using (StreamWriter sw = new StreamWriter(@"Task\tests\003.a"))
            {
                sw.Write(Test3Out.Text);
            }

            // Task\tests\004
            using (StreamWriter sw = new StreamWriter(@"Task\tests\004"))
            {
                sw.Write(Test4In.Text);
            }
            // Task\tests\004.a
            using (StreamWriter sw = new StreamWriter(@"Task\tests\004.a"))
            {
                sw.Write(Test4Out.Text);
            }

            // Task\tests\005
            using (StreamWriter sw = new StreamWriter(@"Task\tests\005"))
            {
                sw.Write(Test5In.Text);
            }
            // Task\tests\005.a
            using (StreamWriter sw = new StreamWriter(@"Task\tests\005.a"))
            {
                sw.Write(Test5Out.Text);
            }

            // Task\statements\ru\html\statement.html
            using (StreamWriter sw = new StreamWriter(@"Task\statements\ru\html\statement.html"))
            {
                var str = Txt.statementHtml1 + System.Security.SecurityElement.Escape(TaskTitleRu.Text) +
                    Txt.statementHtml2 + System.Security.SecurityElement.Escape(TaskText.Text) +
                    Txt.statementHtml3 + System.Security.SecurityElement.Escape(InputFormat.Text) + 
                    Txt.statementHtml4 + System.Security.SecurityElement.Escape(OutputFormat.Text) +
                    Txt.statementHtml5;
                sw.Write(str);
            }

            // Task\statements\ru\markdown\statement.json
            using (StreamWriter sw = new StreamWriter(@"Task\statements\ru\markdown\statement.json"))
            {
                StatementMarkdown sm = StatementMarkdown.NewInstance(TaskText.Text, InputFormat.Text, OutputFormat.Text);
                string str = JsonConvert.SerializeObject(sm);
                sw.Write(str);
            }

            var archiveName = ArchivePath.Text + "\\" + TaskTitleRu.Text + ".zip";
            if (File.Exists(archiveName))
            {
                File.Delete(archiveName);
            }
            ZipFile.CreateFromDirectory("Task", archiveName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TaskTitleRu.Text = "Периметр квадрата";
            TaskTitleEn.Text = "The perimeter of the square";
            TaskText.Text = "Вычислить и вывести значение периметра квадрата со строной равной числу подаваемому на ввод";
            InputFormat.Text = "Целое число. Длина стороны квадрата.";
            OutputFormat.Text = "Целое число. Периметр квадрата.";
            Test1In.Text = "25";
            Test1Out.Text = "100";
            Test2In.Text = "57";
            Test2Out.Text = "228";
            Test3In.Text = "66";
            Test3Out.Text = "264";
            Test4In.Text = "3704";
            Test4Out.Text = "14816";
            Test5In.Text = "8885";
            Test5Out.Text = "35540";
        }

        private void browsePath_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.SelectedPath = ArchivePath.Text;
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    ArchivePath.Text = fbd.SelectedPath;
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ProblemMeta));
            var xns = new XmlSerializerNamespaces();            
            xns.Add(string.Empty, string.Empty);
            var m = ProblemMeta.NewInstance("Наибольшее из двух чисел", "The largest of the two numbers");            
            XmlWriterSettings xws = new XmlWriterSettings();
            xws.Indent = false;
            xws.OmitXmlDeclaration = true;
            StringBuilder sb = new StringBuilder();
            XmlWriter xtw = XmlTextWriter.Create(sb, xws);
            serializer.Serialize(xtw, m, xns);
            string str = sb.ToString();
            

            var eprst = 999;
        }
    }
}
