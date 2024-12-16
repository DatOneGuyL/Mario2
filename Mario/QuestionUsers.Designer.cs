namespace Mario
{
    partial class QuestionUsers
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
            this.lb_Question = new System.Windows.Forms.Label();
            this.rad_A = new System.Windows.Forms.RadioButton();
            this.rad_B = new System.Windows.Forms.RadioButton();
            this.rad_C = new System.Windows.Forms.RadioButton();
            this.rad_D = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_Question
            // 
            this.lb_Question.BackColor = System.Drawing.Color.Transparent;
            this.lb_Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Question.Location = new System.Drawing.Point(14, 9);
            this.lb_Question.Name = "lb_Question";
            this.lb_Question.Size = new System.Drawing.Size(846, 66);
            this.lb_Question.TabIndex = 1;
            // 
            // rad_A
            // 
            this.rad_A.AutoSize = true;
            this.rad_A.BackColor = System.Drawing.Color.Transparent;
            this.rad_A.Location = new System.Drawing.Point(18, 136);
            this.rad_A.Name = "rad_A";
            this.rad_A.Size = new System.Drawing.Size(115, 20);
            this.rad_A.TabIndex = 2;
            this.rad_A.TabStop = true;
            this.rad_A.Text = "radioButton1";
            this.rad_A.UseVisualStyleBackColor = false;
            // 
            // rad_B
            // 
            this.rad_B.AutoSize = true;
            this.rad_B.BackColor = System.Drawing.Color.Transparent;
            this.rad_B.Location = new System.Drawing.Point(18, 199);
            this.rad_B.Name = "rad_B";
            this.rad_B.Size = new System.Drawing.Size(115, 20);
            this.rad_B.TabIndex = 3;
            this.rad_B.TabStop = true;
            this.rad_B.Text = "radioButton2";
            this.rad_B.UseVisualStyleBackColor = false;
            // 
            // rad_C
            // 
            this.rad_C.AutoSize = true;
            this.rad_C.BackColor = System.Drawing.Color.Transparent;
            this.rad_C.Location = new System.Drawing.Point(18, 270);
            this.rad_C.Name = "rad_C";
            this.rad_C.Size = new System.Drawing.Size(115, 20);
            this.rad_C.TabIndex = 4;
            this.rad_C.TabStop = true;
            this.rad_C.Text = "radioButton3";
            this.rad_C.UseVisualStyleBackColor = false;
            // 
            // rad_D
            // 
            this.rad_D.AutoSize = true;
            this.rad_D.BackColor = System.Drawing.Color.Transparent;
            this.rad_D.Location = new System.Drawing.Point(18, 352);
            this.rad_D.Name = "rad_D";
            this.rad_D.Size = new System.Drawing.Size(115, 20);
            this.rad_D.TabIndex = 5;
            this.rad_D.TabStop = true;
            this.rad_D.Text = "radioButton4";
            this.rad_D.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Answer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // QuestionUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mario.Properties.Resources.nen;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rad_D);
            this.Controls.Add(this.rad_C);
            this.Controls.Add(this.rad_B);
            this.Controls.Add(this.rad_A);
            this.Controls.Add(this.lb_Question);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "QuestionUsers";
            this.Text = "QuestionUsers";
            this.Load += new System.EventHandler(this.QuestionUsers_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.QuestionUsers_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Question;
        private System.Windows.Forms.RadioButton rad_A;
        private System.Windows.Forms.RadioButton rad_B;
        private System.Windows.Forms.RadioButton rad_C;
        private System.Windows.Forms.RadioButton rad_D;
        private System.Windows.Forms.Button button1;
    }
}