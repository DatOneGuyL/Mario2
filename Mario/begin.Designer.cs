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
            this.start = new System.Windows.Forms.Button();
            this.jumping = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.jumping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GameName
            // 
            this.GameName.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.GameName.AutoSize = true;
            this.GameName.BackColor = System.Drawing.Color.Transparent;
            this.GameName.Font = new System.Drawing.Font("VNI-Truck", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GameName.Location = new System.Drawing.Point(296, 38);
            this.GameName.Name = "GameName";
            this.GameName.Size = new System.Drawing.Size(207, 86);
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
            // jumping
            // 
            this.jumping.BackColor = System.Drawing.Color.Transparent;
            this.jumping.Image = ((System.Drawing.Image)(resources.GetObject("jumping.Image")));
            this.jumping.Location = new System.Drawing.Point(12, 199);
            this.jumping.Name = "jumping";
            this.jumping.Size = new System.Drawing.Size(221, 248);
            this.jumping.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.jumping.TabIndex = 6;
            this.jumping.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Mario.Properties.Resources.chill_guy;
            this.pictureBox1.Location = new System.Drawing.Point(589, 199);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // begin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 473);
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
            this.Text = "f";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.begin_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.jumping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}