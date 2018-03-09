namespace SysInfo
{
    partial class Main
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
            this.killProcess = new System.Windows.Forms.Button();
            this.processes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // killProcess
            // 
            this.killProcess.Location = new System.Drawing.Point(152, 161);
            this.killProcess.Name = "killProcess";
            this.killProcess.Size = new System.Drawing.Size(166, 28);
            this.killProcess.TabIndex = 3;
            this.killProcess.Text = "Kill Process";
            this.killProcess.UseVisualStyleBackColor = true;
            this.killProcess.Click += new System.EventHandler(this.killProcess_Click);
            // 
            // processes
            // 
            this.processes.FormattingEnabled = true;
            this.processes.Location = new System.Drawing.Point(12, 12);
            this.processes.Name = "processes";
            this.processes.Size = new System.Drawing.Size(446, 95);
            this.processes.Sorted = true;
            this.processes.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 256);
            this.Controls.Add(this.processes);
            this.Controls.Add(this.killProcess);
            this.Name = "Main";
            this.Text = "SysTool";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button killProcess;
        private System.Windows.Forms.ListBox processes;
    }
}

