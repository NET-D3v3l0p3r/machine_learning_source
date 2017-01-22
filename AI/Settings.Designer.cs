namespace can_sat_image.AI
{
    partial class Settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._maxIteration = new System.Windows.Forms.TextBox();
            this._epsilon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._treshold = new System.Windows.Forms.TrackBar();
            this.val = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._treshold)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Miramonte", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Criteria-Settings:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Miramonte", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Max-Iterations:";
            // 
            // _maxIteration
            // 
            this._maxIteration.BackColor = System.Drawing.SystemColors.WindowFrame;
            this._maxIteration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._maxIteration.Location = new System.Drawing.Point(15, 92);
            this._maxIteration.Multiline = true;
            this._maxIteration.Name = "_maxIteration";
            this._maxIteration.Size = new System.Drawing.Size(183, 20);
            this._maxIteration.TabIndex = 8;
            this._maxIteration.TextChanged += new System.EventHandler(this._maxIteration_TextChanged);
            // 
            // _epsilon
            // 
            this._epsilon.BackColor = System.Drawing.SystemColors.WindowFrame;
            this._epsilon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._epsilon.Location = new System.Drawing.Point(15, 137);
            this._epsilon.Multiline = true;
            this._epsilon.Name = "_epsilon";
            this._epsilon.Size = new System.Drawing.Size(183, 20);
            this._epsilon.TabIndex = 10;
            this._epsilon.TextChanged += new System.EventHandler(this._epsilon_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Miramonte", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Epsilon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Miramonte", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Treshold:";
            // 
            // _treshold
            // 
            this._treshold.Location = new System.Drawing.Point(12, 189);
            this._treshold.Maximum = 1000;
            this._treshold.Name = "_treshold";
            this._treshold.Size = new System.Drawing.Size(257, 45);
            this._treshold.TabIndex = 12;
            this._treshold.TickFrequency = 50;
            this._treshold.ValueChanged += new System.EventHandler(this.Treshold_ValueChanged);
            // 
            // val
            // 
            this.val.AutoSize = true;
            this.val.Font = new System.Drawing.Font("Miramonte", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.val.Location = new System.Drawing.Point(201, 237);
            this.val.Name = "val";
            this.val.Size = new System.Drawing.Size(42, 16);
            this.val.TabIndex = 13;
            this.val.Text = "Value:";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(91, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 38);
            this.button2.TabIndex = 14;
            this.button2.Text = "Apply";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(284, 278);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.val);
            this.Controls.Add(this._treshold);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._epsilon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._maxIteration);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Settings";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this._treshold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _maxIteration;
        private System.Windows.Forms.TextBox _epsilon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label val;
        private System.Windows.Forms.TrackBar _treshold;
        private System.Windows.Forms.Button button2;
    }
}