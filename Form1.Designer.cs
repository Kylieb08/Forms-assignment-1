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
            ((System.ComponentModel.ISupportInitialize)(this.imgBad)).BeginInit();
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
            // FormGoodBad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imgBad);
            this.Controls.Add(this.btnBad);
            this.Controls.Add(this.btnGood);
            this.Name = "FormGoodBad";
            this.Text = "Assignment one - good/bad";
            ((System.ComponentModel.ISupportInitialize)(this.imgBad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGood;
        private System.Windows.Forms.Button btnBad;
        private System.Windows.Forms.PictureBox imgBad;
    }
}

