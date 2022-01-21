namespace Words_with_Friends_project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnEnterWord = new System.Windows.Forms.Button();
            this.lblletter1 = new System.Windows.Forms.Label();
            this.lblletter2 = new System.Windows.Forms.Label();
            this.lblletter3 = new System.Windows.Forms.Label();
            this.lblletter4 = new System.Windows.Forms.Label();
            this.lblletter5 = new System.Windows.Forms.Label();
            this.txtword = new System.Windows.Forms.TextBox();
            this.lblletter6 = new System.Windows.Forms.Label();
            this.lblletter7 = new System.Windows.Forms.Label();
            this.lblletter8 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnRandomise = new System.Windows.Forms.Button();
            this.lblscore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnterWord
            // 
            this.btnEnterWord.Location = new System.Drawing.Point(633, 144);
            this.btnEnterWord.Name = "btnEnterWord";
            this.btnEnterWord.Size = new System.Drawing.Size(75, 77);
            this.btnEnterWord.TabIndex = 0;
            this.btnEnterWord.Text = "Enter Word";
            this.btnEnterWord.UseVisualStyleBackColor = true;
            this.btnEnterWord.Click += new System.EventHandler(this.BtnEnterWord_Click);
            // 
            // lblletter1
            // 
            this.lblletter1.AutoSize = true;
            this.lblletter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblletter1.Location = new System.Drawing.Point(58, 295);
            this.lblletter1.Name = "lblletter1";
            this.lblletter1.Size = new System.Drawing.Size(2, 15);
            this.lblletter1.TabIndex = 1;
            // 
            // lblletter2
            // 
            this.lblletter2.AutoSize = true;
            this.lblletter2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblletter2.Location = new System.Drawing.Point(157, 295);
            this.lblletter2.Name = "lblletter2";
            this.lblletter2.Size = new System.Drawing.Size(2, 15);
            this.lblletter2.TabIndex = 2;
            // 
            // lblletter3
            // 
            this.lblletter3.AutoSize = true;
            this.lblletter3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblletter3.Location = new System.Drawing.Point(246, 295);
            this.lblletter3.Name = "lblletter3";
            this.lblletter3.Size = new System.Drawing.Size(2, 15);
            this.lblletter3.TabIndex = 3;
            // 
            // lblletter4
            // 
            this.lblletter4.AutoSize = true;
            this.lblletter4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblletter4.Location = new System.Drawing.Point(334, 295);
            this.lblletter4.Name = "lblletter4";
            this.lblletter4.Size = new System.Drawing.Size(2, 15);
            this.lblletter4.TabIndex = 4;
            // 
            // lblletter5
            // 
            this.lblletter5.AutoSize = true;
            this.lblletter5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblletter5.Location = new System.Drawing.Point(425, 295);
            this.lblletter5.Name = "lblletter5";
            this.lblletter5.Size = new System.Drawing.Size(2, 15);
            this.lblletter5.TabIndex = 5;
            // 
            // txtword
            // 
            this.txtword.Location = new System.Drawing.Point(171, 144);
            this.txtword.Multiline = true;
            this.txtword.Name = "txtword";
            this.txtword.Size = new System.Drawing.Size(418, 77);
            this.txtword.TabIndex = 6;
            // 
            // lblletter6
            // 
            this.lblletter6.AutoSize = true;
            this.lblletter6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblletter6.Location = new System.Drawing.Point(519, 295);
            this.lblletter6.Name = "lblletter6";
            this.lblletter6.Size = new System.Drawing.Size(2, 15);
            this.lblletter6.TabIndex = 7;
            // 
            // lblletter7
            // 
            this.lblletter7.AutoSize = true;
            this.lblletter7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblletter7.Location = new System.Drawing.Point(611, 295);
            this.lblletter7.Name = "lblletter7";
            this.lblletter7.Size = new System.Drawing.Size(2, 15);
            this.lblletter7.TabIndex = 8;
            // 
            // lblletter8
            // 
            this.lblletter8.AutoSize = true;
            this.lblletter8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblletter8.Location = new System.Drawing.Point(694, 295);
            this.lblletter8.Name = "lblletter8";
            this.lblletter8.Size = new System.Drawing.Size(2, 15);
            this.lblletter8.TabIndex = 9;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Ravie", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(205, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(356, 34);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Words With Friends";
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(355, 397);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 11;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // btnRandomise
            // 
            this.btnRandomise.Location = new System.Drawing.Point(58, 144);
            this.btnRandomise.Name = "btnRandomise";
            this.btnRandomise.Size = new System.Drawing.Size(75, 77);
            this.btnRandomise.TabIndex = 12;
            this.btnRandomise.Text = "Randomise";
            this.btnRandomise.UseVisualStyleBackColor = true;
            this.btnRandomise.Click += new System.EventHandler(this.BtnRandomise_Click_1);
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.Location = new System.Drawing.Point(630, 32);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(41, 13);
            this.lblscore.TabIndex = 13;
            this.lblscore.Text = "Score :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.btnRandomise);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblletter8);
            this.Controls.Add(this.lblletter7);
            this.Controls.Add(this.lblletter6);
            this.Controls.Add(this.txtword);
            this.Controls.Add(this.lblletter5);
            this.Controls.Add(this.lblletter4);
            this.Controls.Add(this.lblletter3);
            this.Controls.Add(this.lblletter2);
            this.Controls.Add(this.lblletter1);
            this.Controls.Add(this.btnEnterWord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnterWord;
        private System.Windows.Forms.Label lblletter1;
        private System.Windows.Forms.Label lblletter2;
        private System.Windows.Forms.Label lblletter3;
        private System.Windows.Forms.Label lblletter4;
        private System.Windows.Forms.Label lblletter5;
        private System.Windows.Forms.TextBox txtword;
        private System.Windows.Forms.Label lblletter6;
        private System.Windows.Forms.Label lblletter7;
        private System.Windows.Forms.Label lblletter8;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnRandomise;
        private System.Windows.Forms.Label lblscore;
    }
}

