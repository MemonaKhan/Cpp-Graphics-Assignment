namespace Assignment2
{
    partial class Form3
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
            this.killer = new System.Windows.Forms.PictureBox();
            this.obj1 = new System.Windows.Forms.PictureBox();
            this.obj2 = new System.Windows.Forms.PictureBox();
            this.obj3 = new System.Windows.Forms.PictureBox();
            this.obj4 = new System.Windows.Forms.PictureBox();
            this.obj5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.blast = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.killer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obj1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obj2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obj3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obj4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obj5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blast)).BeginInit();
            this.SuspendLayout();
            // 
            // killer
            // 
            this.killer.Location = new System.Drawing.Point(635, 101);
            this.killer.Name = "killer";
            this.killer.Size = new System.Drawing.Size(160, 170);
            this.killer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.killer.TabIndex = 0;
            this.killer.TabStop = false;
            // 
            // obj1
            // 
            this.obj1.Location = new System.Drawing.Point(145, 52);
            this.obj1.Name = "obj1";
            this.obj1.Size = new System.Drawing.Size(93, 89);
            this.obj1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obj1.TabIndex = 1;
            this.obj1.TabStop = false;
            // 
            // obj2
            // 
            this.obj2.Location = new System.Drawing.Point(308, 12);
            this.obj2.Name = "obj2";
            this.obj2.Size = new System.Drawing.Size(94, 92);
            this.obj2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obj2.TabIndex = 2;
            this.obj2.TabStop = false;
            // 
            // obj3
            // 
            this.obj3.Location = new System.Drawing.Point(13, 273);
            this.obj3.Name = "obj3";
            this.obj3.Size = new System.Drawing.Size(100, 97);
            this.obj3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obj3.TabIndex = 3;
            this.obj3.TabStop = false;
            // 
            // obj4
            // 
            this.obj4.Location = new System.Drawing.Point(290, 286);
            this.obj4.Name = "obj4";
            this.obj4.Size = new System.Drawing.Size(100, 95);
            this.obj4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obj4.TabIndex = 4;
            this.obj4.TabStop = false;
            // 
            // obj5
            // 
            this.obj5.Location = new System.Drawing.Point(464, 162);
            this.obj5.Name = "obj5";
            this.obj5.Size = new System.Drawing.Size(100, 109);
            this.obj5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obj5.TabIndex = 5;
            this.obj5.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(659, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 31);
            this.label1.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            // 
            // blast
            // 
            this.blast.Location = new System.Drawing.Point(13, 13);
            this.blast.Name = "blast";
            this.blast.Size = new System.Drawing.Size(85, 83);
            this.blast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blast.TabIndex = 7;
            this.blast.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 436);
            this.Controls.Add(this.blast);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.obj5);
            this.Controls.Add(this.obj4);
            this.Controls.Add(this.obj3);
            this.Controls.Add(this.obj2);
            this.Controls.Add(this.obj1);
            this.Controls.Add(this.killer);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.killer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obj1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obj2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obj3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obj4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obj5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox killer;
        private System.Windows.Forms.PictureBox obj1;
        private System.Windows.Forms.PictureBox obj2;
        private System.Windows.Forms.PictureBox obj3;
        private System.Windows.Forms.PictureBox obj4;
        private System.Windows.Forms.PictureBox obj5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox blast;
    }
}