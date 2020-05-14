namespace Dragon_Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playground = new System.Windows.Forms.Panel();
            this.Pic_Missle4 = new System.Windows.Forms.PictureBox();
            this.Pic_Missle3 = new System.Windows.Forms.PictureBox();
            this.PicMissle2 = new System.Windows.Forms.PictureBox();
            this.PicMissle = new System.Windows.Forms.PictureBox();
            this.lbl_Endgame = new System.Windows.Forms.Label();
            this.Pic_Ring3 = new System.Windows.Forms.PictureBox();
            this.Pic_Ring4 = new System.Windows.Forms.PictureBox();
            this.Pic_Ring2 = new System.Windows.Forms.PictureBox();
            this.Pic_Ring1 = new System.Windows.Forms.PictureBox();
            this.lbl_Score = new System.Windows.Forms.Label();
            this.Pic_Dragon = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tmrMissle = new System.Windows.Forms.Timer(this.components);
            this.tmrMissle2 = new System.Windows.Forms.Timer(this.components);
            this.playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Missle4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Missle3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMissle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMissle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Ring3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Ring4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Ring2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Ring1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Dragon)).BeginInit();
            this.SuspendLayout();
            // 
            // playground
            // 
            this.playground.Controls.Add(this.Pic_Missle4);
            this.playground.Controls.Add(this.Pic_Missle3);
            this.playground.Controls.Add(this.PicMissle2);
            this.playground.Controls.Add(this.PicMissle);
            this.playground.Controls.Add(this.lbl_Endgame);
            this.playground.Controls.Add(this.Pic_Ring3);
            this.playground.Controls.Add(this.Pic_Ring4);
            this.playground.Controls.Add(this.Pic_Ring2);
            this.playground.Controls.Add(this.Pic_Ring1);
            this.playground.Controls.Add(this.lbl_Score);
            this.playground.Controls.Add(this.Pic_Dragon);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(800, 450);
            this.playground.TabIndex = 0;
            this.playground.Paint += new System.Windows.Forms.PaintEventHandler(this.Playground_Paint);
            // 
            // Pic_Missle4
            // 
            this.Pic_Missle4.BackColor = System.Drawing.Color.Transparent;
            this.Pic_Missle4.Image = global::Dragon_Game.Properties.Resources.Missle;
            this.Pic_Missle4.Location = new System.Drawing.Point(615, 193);
            this.Pic_Missle4.Name = "Pic_Missle4";
            this.Pic_Missle4.Size = new System.Drawing.Size(37, 81);
            this.Pic_Missle4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Missle4.TabIndex = 10;
            this.Pic_Missle4.TabStop = false;
            // 
            // Pic_Missle3
            // 
            this.Pic_Missle3.BackColor = System.Drawing.Color.Transparent;
            this.Pic_Missle3.Image = global::Dragon_Game.Properties.Resources.Missle;
            this.Pic_Missle3.Location = new System.Drawing.Point(528, 193);
            this.Pic_Missle3.Name = "Pic_Missle3";
            this.Pic_Missle3.Size = new System.Drawing.Size(37, 81);
            this.Pic_Missle3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Missle3.TabIndex = 9;
            this.Pic_Missle3.TabStop = false;
            // 
            // PicMissle2
            // 
            this.PicMissle2.BackColor = System.Drawing.Color.Transparent;
            this.PicMissle2.Image = global::Dragon_Game.Properties.Resources.Missle;
            this.PicMissle2.Location = new System.Drawing.Point(382, 185);
            this.PicMissle2.Name = "PicMissle2";
            this.PicMissle2.Size = new System.Drawing.Size(37, 81);
            this.PicMissle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicMissle2.TabIndex = 8;
            this.PicMissle2.TabStop = false;
            // 
            // PicMissle
            // 
            this.PicMissle.BackColor = System.Drawing.Color.Transparent;
            this.PicMissle.Image = global::Dragon_Game.Properties.Resources.Missle;
            this.PicMissle.Location = new System.Drawing.Point(461, 357);
            this.PicMissle.Name = "PicMissle";
            this.PicMissle.Size = new System.Drawing.Size(37, 81);
            this.PicMissle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicMissle.TabIndex = 7;
            this.PicMissle.TabStop = false;
            // 
            // lbl_Endgame
            // 
            this.lbl_Endgame.AutoSize = true;
            this.lbl_Endgame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Endgame.Location = new System.Drawing.Point(77, 278);
            this.lbl_Endgame.Name = "lbl_Endgame";
            this.lbl_Endgame.Size = new System.Drawing.Size(207, 125);
            this.lbl_Endgame.TabIndex = 6;
            this.lbl_Endgame.Text = "Game Over\r\n\r\n\r\nPress F1 to restart\r\nPress escape to exit";
            // 
            // Pic_Ring3
            // 
            this.Pic_Ring3.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Ring3.Image")));
            this.Pic_Ring3.Location = new System.Drawing.Point(669, 117);
            this.Pic_Ring3.Name = "Pic_Ring3";
            this.Pic_Ring3.Size = new System.Drawing.Size(58, 52);
            this.Pic_Ring3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Ring3.TabIndex = 5;
            this.Pic_Ring3.TabStop = false;
            // 
            // Pic_Ring4
            // 
            this.Pic_Ring4.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Ring4.Image")));
            this.Pic_Ring4.Location = new System.Drawing.Point(279, 73);
            this.Pic_Ring4.Name = "Pic_Ring4";
            this.Pic_Ring4.Size = new System.Drawing.Size(58, 52);
            this.Pic_Ring4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Ring4.TabIndex = 4;
            this.Pic_Ring4.TabStop = false;
            // 
            // Pic_Ring2
            // 
            this.Pic_Ring2.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Ring2.Image")));
            this.Pic_Ring2.Location = new System.Drawing.Point(362, 117);
            this.Pic_Ring2.Name = "Pic_Ring2";
            this.Pic_Ring2.Size = new System.Drawing.Size(58, 52);
            this.Pic_Ring2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Ring2.TabIndex = 3;
            this.Pic_Ring2.TabStop = false;
            // 
            // Pic_Ring1
            // 
            this.Pic_Ring1.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Ring1.Image")));
            this.Pic_Ring1.Location = new System.Drawing.Point(507, 73);
            this.Pic_Ring1.Name = "Pic_Ring1";
            this.Pic_Ring1.Size = new System.Drawing.Size(58, 52);
            this.Pic_Ring1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Ring1.TabIndex = 2;
            this.Pic_Ring1.TabStop = false;
            // 
            // lbl_Score
            // 
            this.lbl_Score.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Score.Location = new System.Drawing.Point(37, 11);
            this.lbl_Score.Name = "lbl_Score";
            this.lbl_Score.Size = new System.Drawing.Size(53, 17);
            this.lbl_Score.TabIndex = 1;
            this.lbl_Score.Text = "0";
            // 
            // Pic_Dragon
            // 
            this.Pic_Dragon.BackColor = System.Drawing.Color.Transparent;
            this.Pic_Dragon.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Dragon.Image")));
            this.Pic_Dragon.Location = new System.Drawing.Point(124, 74);
            this.Pic_Dragon.Name = "Pic_Dragon";
            this.Pic_Dragon.Size = new System.Drawing.Size(113, 95);
            this.Pic_Dragon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Dragon.TabIndex = 0;
            this.Pic_Dragon.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // tmrMissle
            // 
            this.tmrMissle.Enabled = true;
            this.tmrMissle.Interval = 1;
            this.tmrMissle.Tick += new System.EventHandler(this.TmrMissle_Tick);
            // 
            // tmrMissle2
            // 
            this.tmrMissle2.Interval = 1;
            this.tmrMissle2.Tick += new System.EventHandler(this.TmrMissle2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playground);
            this.Name = "Form1";
            this.Text = "Dragon Game Mr. Olson";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.playground.ResumeLayout(false);
            this.playground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Missle4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Missle3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMissle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMissle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Ring3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Ring4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Ring2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Ring1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Dragon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playground;
        private System.Windows.Forms.PictureBox Pic_Dragon;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Pic_Ring1;
        private System.Windows.Forms.Label lbl_Score;
        private System.Windows.Forms.PictureBox Pic_Ring3;
        private System.Windows.Forms.PictureBox Pic_Ring4;
        private System.Windows.Forms.PictureBox Pic_Ring2;
        private System.Windows.Forms.Label lbl_Endgame;
        private System.Windows.Forms.PictureBox PicMissle;
        private System.Windows.Forms.Timer tmrMissle;
        private System.Windows.Forms.PictureBox Pic_Missle4;
        private System.Windows.Forms.PictureBox Pic_Missle3;
        private System.Windows.Forms.PictureBox PicMissle2;
        private System.Windows.Forms.Timer tmrMissle2;
    }
}

