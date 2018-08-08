namespace Task_Manager
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
            this.components = new System.ComponentModel.Container();
            this.listBox_Proc = new System.Windows.Forms.ListBox();
            this.textBox_EXE = new System.Windows.Forms.TextBox();
            this.button_End = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_Run = new System.Windows.Forms.Button();
            this.button_Sort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_Proc
            // 
            this.listBox_Proc.FormattingEnabled = true;
            this.listBox_Proc.Location = new System.Drawing.Point(12, 12);
            this.listBox_Proc.Name = "listBox_Proc";
            this.listBox_Proc.Size = new System.Drawing.Size(437, 381);
            this.listBox_Proc.TabIndex = 0;
            // 
            // textBox_EXE
            // 
            this.textBox_EXE.Location = new System.Drawing.Point(13, 400);
            this.textBox_EXE.Name = "textBox_EXE";
            this.textBox_EXE.Size = new System.Drawing.Size(195, 20);
            this.textBox_EXE.TabIndex = 1;
            // 
            // button_End
            // 
            this.button_End.Location = new System.Drawing.Point(374, 398);
            this.button_End.Name = "button_End";
            this.button_End.Size = new System.Drawing.Size(75, 23);
            this.button_End.TabIndex = 2;
            this.button_End.Text = "End Task";
            this.button_End.UseVisualStyleBackColor = true;
            this.button_End.Click += new System.EventHandler(this.button_End_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_Run
            // 
            this.button_Run.Location = new System.Drawing.Point(214, 398);
            this.button_Run.Name = "button_Run";
            this.button_Run.Size = new System.Drawing.Size(75, 23);
            this.button_Run.TabIndex = 3;
            this.button_Run.Text = "Run";
            this.button_Run.UseVisualStyleBackColor = true;
            this.button_Run.Click += new System.EventHandler(this.button_Run_Click);
            // 
            // button_Sort
            // 
            this.button_Sort.Location = new System.Drawing.Point(295, 398);
            this.button_Sort.Name = "button_Sort";
            this.button_Sort.Size = new System.Drawing.Size(75, 23);
            this.button_Sort.TabIndex = 4;
            this.button_Sort.Text = "Sort Tasks";
            this.button_Sort.UseVisualStyleBackColor = true;
            this.button_Sort.Click += new System.EventHandler(this.button_Sort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 436);
            this.Controls.Add(this.button_Sort);
            this.Controls.Add(this.button_Run);
            this.Controls.Add(this.button_End);
            this.Controls.Add(this.textBox_EXE);
            this.Controls.Add(this.listBox_Proc);
            this.Name = "Form1";
            this.Text = "Task Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Proc;
        private System.Windows.Forms.TextBox textBox_EXE;
        private System.Windows.Forms.Button button_End;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_Run;
        private System.Windows.Forms.Button button_Sort;
    }
}

