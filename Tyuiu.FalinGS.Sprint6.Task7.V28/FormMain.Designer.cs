
namespace Tyuiu.FalinGS.Sprint6.Task7.V28
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.SaveFile = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridViewInMatrix = new System.Windows.Forms.DataGridView();
            this.dataGridViewOutMatrix = new System.Windows.Forms.DataGridView();
            this.saveFileDialogMatrix = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogTask = new System.Windows.Forms.OpenFileDialog();
            this.toolTipButton = new System.Windows.Forms.ToolTip(this.components);
            this.Ввод = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonHelp);
            this.panel1.Controls.Add(this.SaveFile);
            this.panel1.Controls.Add(this.buttonDone);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 71);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Image = global::Tyuiu.FalinGS.Sprint6.Task7.V28.Properties.Resources.folder_page_white;
            this.button1.Location = new System.Drawing.Point(7, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 57);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonOpenFile_Click);
            this.button1.MouseEnter += new System.EventHandler(this.buttonOpenFile_MouseEnter);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Image = global::Tyuiu.FalinGS.Sprint6.Task7.V28.Properties.Resources.help;
            this.buttonHelp.Location = new System.Drawing.Point(865, 10);
            this.buttonHelp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(58, 57);
            this.buttonHelp.TabIndex = 5;
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp__Click);
            this.buttonHelp.MouseEnter += new System.EventHandler(this.buttonHelp_MouseEnter);
            // 
            // SaveFile
            // 
            this.SaveFile.Image = global::Tyuiu.FalinGS.Sprint6.Task7.V28.Properties.Resources.page_white_ruby;
            this.SaveFile.Location = new System.Drawing.Point(137, 10);
            this.SaveFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(62, 57);
            this.SaveFile.TabIndex = 4;
            this.SaveFile.UseVisualStyleBackColor = true;
            this.SaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            this.SaveFile.MouseEnter += new System.EventHandler(this.buttonSaveFile_MouseEnter);
            // 
            // buttonDone
            // 
            this.buttonDone.Image = global::Tyuiu.FalinGS.Sprint6.Task7.V28.Properties.Resources.page_white_go;
            this.buttonDone.Location = new System.Drawing.Point(70, 10);
            this.buttonDone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(62, 57);
            this.buttonDone.TabIndex = 3;
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            this.buttonDone.MouseEnter += new System.EventHandler(this.buttonDone_MouseEnter);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 71);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.textBox1);
            this.groupBox12.Location = new System.Drawing.Point(0, 76);
            this.groupBox12.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox12.Size = new System.Drawing.Size(932, 81);
            this.groupBox12.TabIndex = 1;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Условие";
            this.groupBox12.Enter += new System.EventHandler(this.buttonHelp__Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 17);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(924, 60);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // dataGridViewInMatrix
            // 
            this.dataGridViewInMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInMatrix.Location = new System.Drawing.Point(10, 172);
            this.dataGridViewInMatrix.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewInMatrix.Name = "dataGridViewInMatrix";
            this.dataGridViewInMatrix.RowHeadersWidth = 51;
            this.dataGridViewInMatrix.RowTemplate.Height = 24;
            this.dataGridViewInMatrix.Size = new System.Drawing.Size(460, 315);
            this.dataGridViewInMatrix.TabIndex = 2;
            // 
            // dataGridViewOutMatrix
            // 
            this.dataGridViewOutMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutMatrix.Location = new System.Drawing.Point(475, 172);
            this.dataGridViewOutMatrix.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewOutMatrix.Name = "dataGridViewOutMatrix";
            this.dataGridViewOutMatrix.RowHeadersWidth = 51;
            this.dataGridViewOutMatrix.RowTemplate.Height = 24;
            this.dataGridViewOutMatrix.Size = new System.Drawing.Size(448, 315);
            this.dataGridViewOutMatrix.TabIndex = 3;
            // 
            // openFileDialogTask
            // 
            this.openFileDialogTask.FileName = "openFileDialog1";
            // 
            // Ввод
            // 
            this.Ввод.AutoSize = true;
            this.Ввод.Location = new System.Drawing.Point(9, 156);
            this.Ввод.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Ввод.Name = "Ввод";
            this.Ввод.Size = new System.Drawing.Size(75, 13);
            this.Ввод.TabIndex = 4;
            this.Ввод.Text = "Ввод данных:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Вывод данных:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 488);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ввод);
            this.Controls.Add(this.dataGridViewOutMatrix);
            this.Controls.Add(this.dataGridViewInMatrix);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Такс 7| Вариант 28 | Фалин Георгий Сергеевич";
            this.panel1.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutMatrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button SaveFile;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridViewInMatrix;
        private System.Windows.Forms.DataGridView dataGridViewOutMatrix;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask;
        private System.Windows.Forms.ToolTip toolTipButton;
        private System.Windows.Forms.Label Ввод;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

