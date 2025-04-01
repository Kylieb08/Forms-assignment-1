namespace Forms_assignment_1
{
    partial class FormGoodBad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGoodBad));
            this.btnGood = new System.Windows.Forms.Button();
            this.btnBad = new System.Windows.Forms.Button();
            this.imgBad = new System.Windows.Forms.PictureBox();
            this.imgGood = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgBad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGood)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGood
            // 
            this.btnGood.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnGood.Font = new System.Drawing.Font("Script MT Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGood.Location = new System.Drawing.Point(97, 41);
            this.btnGood.Name = "btnGood";
            this.btnGood.Size = new System.Drawing.Size(102, 344);
            this.btnGood.TabIndex = 0;
            this.btnGood.Text = "Good";
            this.btnGood.UseVisualStyleBackColor = false;
            this.btnGood.Click += new System.EventHandler(this.btnGood_Click);
            // 
            // btnBad
            // 
            this.btnBad.BackColor = System.Drawing.Color.DarkRed;
            this.btnBad.Font = new System.Drawing.Font("Viner Hand ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBad.Location = new System.Drawing.Point(564, 41);
            this.btnBad.Name = "btnBad";
            this.btnBad.Size = new System.Drawing.Size(102, 334);
            this.btnBad.TabIndex = 1;
            this.btnBad.Text = "BAD";
            this.btnBad.UseVisualStyleBackColor = false;
            this.btnBad.Click += new System.EventHandler(this.btnBad_Click);
            // 
            // imgBad
            // 
            this.imgBad.Image = ((System.Drawing.Image)(resources.GetObject("imgBad.Image")));
            this.imgBad.Location = new System.Drawing.Point(220, 115);
            this.imgBad.Name = "imgBad";
            this.imgBad.Size = new System.Drawing.Size(320, 195);
            this.imgBad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBad.TabIndex = 2;
            this.imgBad.TabStop = false;
            this.imgBad.Visible = false;
            // 
            // imgGood
            // 
            this.imgGood.Image = ((System.Drawing.Image)(resources.GetObject("imgGood.Image")));
            this.imgGood.Location = new System.Drawing.Point(220, 115);
            this.imgGood.Name = "imgGood";
            this.imgGood.Size = new System.Drawing.Size(320, 195);
            this.imgGood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgGood.TabIndex = 3;
            this.imgGood.TabStop = false;
            this.imgGood.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.CadetBlue;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(220, 41);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(320, 59);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear Image";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FormGoodBad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.imgGood);
            this.Controls.Add(this.imgBad);
            this.Controls.Add(this.btnBad);
            this.Controls.Add(this.btnGood);
            this.Name = "FormGoodBad";
            this.Text = "Assignment one - good/bad";
            ((System.ComponentModel.ISupportInitialize)(this.imgBad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGood;
        private System.Windows.Forms.Button btnBad;
        private System.Windows.Forms.PictureBox imgBad;
        private System.Windows.Forms.PictureBox imgGood;
        private System.Windows.Forms.Button btnClear;
    }
}

