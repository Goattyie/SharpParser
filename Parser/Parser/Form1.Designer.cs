
namespace Parser
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Listbox = new System.Windows.Forms.ListBox();
            this.StartUpDown = new System.Windows.Forms.NumericUpDown();
            this.EndUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StartUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Listbox
            // 
            this.Listbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Listbox.FormattingEnabled = true;
            this.Listbox.ItemHeight = 15;
            this.Listbox.Location = new System.Drawing.Point(13, 13);
            this.Listbox.Name = "Listbox";
            this.Listbox.Size = new System.Drawing.Size(609, 424);
            this.Listbox.TabIndex = 0;
            // 
            // StartUpDown
            // 
            this.StartUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartUpDown.Location = new System.Drawing.Point(634, 31);
            this.StartUpDown.Name = "StartUpDown";
            this.StartUpDown.Size = new System.Drawing.Size(154, 23);
            this.StartUpDown.TabIndex = 1;
            // 
            // EndUpDown
            // 
            this.EndUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EndUpDown.Location = new System.Drawing.Point(634, 79);
            this.EndUpDown.Name = "EndUpDown";
            this.EndUpDown.Size = new System.Drawing.Size(154, 23);
            this.EndUpDown.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(634, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Начало:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(634, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Конец:";
            // 
            // Start
            // 
            this.Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Start.Location = new System.Drawing.Point(634, 387);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(154, 23);
            this.Start.TabIndex = 5;
            this.Start.Text = "Старт";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Stop.Location = new System.Drawing.Point(634, 416);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(154, 21);
            this.Stop.TabIndex = 6;
            this.Stop.Text = "Стоп";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EndUpDown);
            this.Controls.Add(this.StartUpDown);
            this.Controls.Add(this.Listbox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.StartUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Listbox;
        private System.Windows.Forms.NumericUpDown StartUpDown;
        private System.Windows.Forms.NumericUpDown EndUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
    }
}

