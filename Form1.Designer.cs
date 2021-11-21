
namespace YandexTaskCreator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ArchivePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.browsePath = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TaskTitleRu = new System.Windows.Forms.TextBox();
            this.TaskTitleEn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TaskText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.InputFormat = new System.Windows.Forms.TextBox();
            this.OutputFormat = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Test1Out = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Test1In = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Test2Out = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Test2In = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Test3Out = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Test3In = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Test4Out = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Test4In = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.Test5Out = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Test5In = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.SaveTask = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // ArchivePath
            // 
            this.ArchivePath.Location = new System.Drawing.Point(208, 16);
            this.ArchivePath.Name = "ArchivePath";
            this.ArchivePath.Size = new System.Drawing.Size(475, 20);
            this.ArchivePath.TabIndex = 0;
            this.ArchivePath.Text = "C:\\Users\\bs\\Desktop\\Яндекс-задачи";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Путь для сохранения архива задачи";
            // 
            // browsePath
            // 
            this.browsePath.Location = new System.Drawing.Point(689, 14);
            this.browsePath.Name = "browsePath";
            this.browsePath.Size = new System.Drawing.Size(75, 23);
            this.browsePath.TabIndex = 2;
            this.browsePath.Text = "Обзор ...";
            this.browsePath.UseVisualStyleBackColor = true;
            this.browsePath.Click += new System.EventHandler(this.browsePath_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Название задачи (русский)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Название задачи (английский)";
            // 
            // TaskTitleRu
            // 
            this.TaskTitleRu.Location = new System.Drawing.Point(208, 47);
            this.TaskTitleRu.Name = "TaskTitleRu";
            this.TaskTitleRu.Size = new System.Drawing.Size(556, 20);
            this.TaskTitleRu.TabIndex = 5;
            // 
            // TaskTitleEn
            // 
            this.TaskTitleEn.Location = new System.Drawing.Point(208, 78);
            this.TaskTitleEn.Name = "TaskTitleEn";
            this.TaskTitleEn.Size = new System.Drawing.Size(556, 20);
            this.TaskTitleEn.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Текст задачи";
            // 
            // TaskText
            // 
            this.TaskText.Location = new System.Drawing.Point(208, 112);
            this.TaskText.Multiline = true;
            this.TaskText.Name = "TaskText";
            this.TaskText.Size = new System.Drawing.Size(556, 89);
            this.TaskText.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Формат входных данных";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Формат выходных данных";
            // 
            // InputFormat
            // 
            this.InputFormat.Location = new System.Drawing.Point(208, 215);
            this.InputFormat.Name = "InputFormat";
            this.InputFormat.Size = new System.Drawing.Size(556, 20);
            this.InputFormat.TabIndex = 11;
            // 
            // OutputFormat
            // 
            this.OutputFormat.Location = new System.Drawing.Point(208, 247);
            this.OutputFormat.Name = "OutputFormat";
            this.OutputFormat.Size = new System.Drawing.Size(556, 20);
            this.OutputFormat.TabIndex = 12;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(15, 289);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(749, 291);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Test1Out);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.Test1In);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(741, 265);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Тест 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Test1Out
            // 
            this.Test1Out.Location = new System.Drawing.Point(373, 30);
            this.Test1Out.Multiline = true;
            this.Test1Out.Name = "Test1Out";
            this.Test1Out.Size = new System.Drawing.Size(357, 220);
            this.Test1Out.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(500, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Тест 1 - Выход";
            // 
            // Test1In
            // 
            this.Test1In.Location = new System.Drawing.Point(10, 30);
            this.Test1In.Multiline = true;
            this.Test1In.Name = "Test1In";
            this.Test1In.Size = new System.Drawing.Size(357, 220);
            this.Test1In.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(140, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Тест 1 - Вход";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Test2Out);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.Test2In);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(741, 265);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Тест 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Test2Out
            // 
            this.Test2Out.Location = new System.Drawing.Point(373, 30);
            this.Test2Out.Multiline = true;
            this.Test2Out.Name = "Test2Out";
            this.Test2Out.Size = new System.Drawing.Size(357, 220);
            this.Test2Out.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(500, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Тест 2 - Выход";
            // 
            // Test2In
            // 
            this.Test2In.Location = new System.Drawing.Point(10, 30);
            this.Test2In.Multiline = true;
            this.Test2In.Name = "Test2In";
            this.Test2In.Size = new System.Drawing.Size(357, 220);
            this.Test2In.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(140, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Тест 2 - Вход";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Test3Out);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.Test3In);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(741, 265);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Тест 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Test3Out
            // 
            this.Test3Out.Location = new System.Drawing.Point(373, 30);
            this.Test3Out.Multiline = true;
            this.Test3Out.Name = "Test3Out";
            this.Test3Out.Size = new System.Drawing.Size(357, 220);
            this.Test3Out.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(500, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Тест 3 - Выход";
            // 
            // Test3In
            // 
            this.Test3In.Location = new System.Drawing.Point(10, 30);
            this.Test3In.Multiline = true;
            this.Test3In.Name = "Test3In";
            this.Test3In.Size = new System.Drawing.Size(357, 220);
            this.Test3In.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(140, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Тест 3 - Вход";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.Test4Out);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.Test4In);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(741, 265);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Тест 4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Test4Out
            // 
            this.Test4Out.Location = new System.Drawing.Point(373, 30);
            this.Test4Out.Multiline = true;
            this.Test4Out.Name = "Test4Out";
            this.Test4Out.Size = new System.Drawing.Size(357, 220);
            this.Test4Out.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(500, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Тест 4 - Выход";
            // 
            // Test4In
            // 
            this.Test4In.Location = new System.Drawing.Point(10, 30);
            this.Test4In.Multiline = true;
            this.Test4In.Name = "Test4In";
            this.Test4In.Size = new System.Drawing.Size(357, 220);
            this.Test4In.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(140, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Тест 4 - Вход";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.Test5Out);
            this.tabPage5.Controls.Add(this.label15);
            this.tabPage5.Controls.Add(this.Test5In);
            this.tabPage5.Controls.Add(this.label16);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(741, 265);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Тест 5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // Test5Out
            // 
            this.Test5Out.Location = new System.Drawing.Point(373, 30);
            this.Test5Out.Multiline = true;
            this.Test5Out.Name = "Test5Out";
            this.Test5Out.Size = new System.Drawing.Size(357, 220);
            this.Test5Out.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(500, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Тест 5 - Выход";
            // 
            // Test5In
            // 
            this.Test5In.Location = new System.Drawing.Point(10, 30);
            this.Test5In.Multiline = true;
            this.Test5In.Name = "Test5In";
            this.Test5In.Size = new System.Drawing.Size(357, 220);
            this.Test5In.TabIndex = 26;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(140, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "Тест 5 - Вход";
            // 
            // SaveTask
            // 
            this.SaveTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 54F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveTask.Location = new System.Drawing.Point(19, 586);
            this.SaveTask.Name = "SaveTask";
            this.SaveTask.Size = new System.Drawing.Size(741, 124);
            this.SaveTask.TabIndex = 14;
            this.SaveTask.Text = "Сохранить задачу";
            this.SaveTask.UseVisualStyleBackColor = true;
            this.SaveTask.Click += new System.EventHandler(this.SaveTask_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 722);
            this.Controls.Add(this.SaveTask);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.OutputFormat);
            this.Controls.Add(this.InputFormat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TaskText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TaskTitleEn);
            this.Controls.Add(this.TaskTitleRu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.browsePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ArchivePath);
            this.Name = "Form1";
            this.Text = "Генератор задач для Яндекс-Контеста";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ArchivePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button browsePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TaskTitleRu;
        private System.Windows.Forms.TextBox TaskTitleEn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TaskText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox InputFormat;
        private System.Windows.Forms.TextBox OutputFormat;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox Test1Out;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Test1In;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox Test2Out;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Test2In;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox Test3Out;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Test3In;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox Test4Out;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Test4In;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox Test5Out;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Test5In;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button SaveTask;
    }
}

