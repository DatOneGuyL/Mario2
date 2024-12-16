namespace Mario
{
    partial class begin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(begin));
            this.GameName = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.Label();
            this.Ranking = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Subject = new System.Windows.Forms.ComboBox();
            this.start = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.jumping = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jumping)).BeginInit();
            this.SuspendLayout();
            // 
            // GameName
            // 
            this.GameName.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.GameName.AutoSize = true;
            this.GameName.BackColor = System.Drawing.Color.Transparent;
            this.GameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GameName.Location = new System.Drawing.Point(296, 38);
            this.GameName.Name = "GameName";
            this.GameName.Size = new System.Drawing.Size(184, 69);
            this.GameName.TabIndex = 0;
            this.GameName.Text = "Mario";
            // 
            // nameBox
            // 
            this.nameBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nameBox.Location = new System.Drawing.Point(311, 163);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(167, 22);
            this.nameBox.TabIndex = 1;
            this.nameBox.Click += new System.EventHandler(this.subbox_Click);
            this.nameBox.TextChanged += new System.EventHandler(this.EnterName);
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.BackColor = System.Drawing.Color.Transparent;
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(209, 166);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(85, 16);
            this.UserName.TabIndex = 2;
            this.UserName.Text = "Your name:";
            // 
            // Ranking
            // 
            this.Ranking.BackColor = System.Drawing.Color.Transparent;
            this.Ranking.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ranking.Location = new System.Drawing.Point(12, 12);
            this.Ranking.Name = "Ranking";
            this.Ranking.Size = new System.Drawing.Size(154, 52);
            this.Ranking.TabIndex = 7;
            this.Ranking.Text = "Rankings";
            this.Ranking.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(656, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 52);
            this.button1.TabIndex = 7;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Subject:";
            // 
            // cmb_Subject
            // 
            this.cmb_Subject.FormattingEnabled = true;
            this.cmb_Subject.Location = new System.Drawing.Point(311, 201);
            this.cmb_Subject.Name = "cmb_Subject";
            this.cmb_Subject.Size = new System.Drawing.Size(167, 24);
            this.cmb_Subject.TabIndex = 9;
            this.cmb_Subject.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Transparent;
            this.start.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Image = global::Mario.Properties.Resources.startt;
            this.start.Location = new System.Drawing.Point(288, 319);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(235, 94);
            this.start.TabIndex = 7;
            this.start.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Mario.Properties.Resources.chill_guy;
            this.pictureBox1.Location = new System.Drawing.Point(572, 246);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // jumping
            // 
            this.jumping.BackColor = System.Drawing.Color.Transparent;
            this.jumping.Image = ((System.Drawing.Image)(resources.GetObject("jumping.Image")));
            this.jumping.Location = new System.Drawing.Point(26, 260);
            this.jumping.Name = "jumping";
            this.jumping.Size = new System.Drawing.Size(221, 248);
            this.jumping.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.jumping.TabIndex = 6;
            this.jumping.TabStop = false;
            // 
            // begin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 473);
            this.Controls.Add(this.cmb_Subject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.GameName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.Ranking);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.jumping);
            this.Controls.Add(this.nameBox);
            this.HelpButton = true;
            this.Name = "begin";
            this.Text = "Mario";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.begin_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jumping)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GameName;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.PictureBox jumping;
        private System.Windows.Forms.Button Ranking;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Subject;
    }
}