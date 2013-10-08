namespace TheGameTicTacToe
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tecken = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.easyRB = new System.Windows.Forms.RadioButton();
            this.normalRB = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Orange;
            this.button1.Location = new System.Drawing.Point(12, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 61);
            this.button2.TabIndex = 1;
            this.button2.Text = "O";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tecken
            // 
            this.tecken.AutoSize = true;
            this.tecken.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tecken.Location = new System.Drawing.Point(12, 76);
            this.tecken.Name = "tecken";
            this.tecken.Size = new System.Drawing.Size(108, 22);
            this.tecken.TabIndex = 2;
            this.tecken.Text = "Välj tecken:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Svårighetsgrad";
            // 
            // easyRB
            // 
            this.easyRB.AutoSize = true;
            this.easyRB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyRB.Location = new System.Drawing.Point(168, 115);
            this.easyRB.Name = "easyRB";
            this.easyRB.Size = new System.Drawing.Size(52, 22);
            this.easyRB.TabIndex = 4;
            this.easyRB.TabStop = true;
            this.easyRB.Text = "Lätt";
            this.easyRB.UseVisualStyleBackColor = true;
            // 
            // normalRB
            // 
            this.normalRB.AutoSize = true;
            this.normalRB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normalRB.Location = new System.Drawing.Point(168, 158);
            this.normalRB.Name = "normalRB";
            this.normalRB.Size = new System.Drawing.Size(81, 22);
            this.normalRB.TabIndex = 5;
            this.normalRB.TabStop = true;
            this.normalRB.Text = "Svårare";
            this.normalRB.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.normalRB);
            this.Controls.Add(this.easyRB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tecken);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label tecken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton easyRB;
        private System.Windows.Forms.RadioButton normalRB;
    }
}