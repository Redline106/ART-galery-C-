namespace GalerieArtSGIWin
{
    partial class Form_vendre
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
            this.vendreoeuvreButton = new System.Windows.Forms.Button();
            this.IDOEUVREVENDREtEXTBOX = new System.Windows.Forms.TextBox();
            this.PrixOeuvretextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vendreoeuvreButton
            // 
            this.vendreoeuvreButton.Location = new System.Drawing.Point(87, 130);
            this.vendreoeuvreButton.Name = "vendreoeuvreButton";
            this.vendreoeuvreButton.Size = new System.Drawing.Size(75, 23);
            this.vendreoeuvreButton.TabIndex = 0;
            this.vendreoeuvreButton.Text = "OK";
            this.vendreoeuvreButton.UseVisualStyleBackColor = true;
            this.vendreoeuvreButton.Click += new System.EventHandler(this.vendreoeuvreButton_Click);
            // 
            // IDOEUVREVENDREtEXTBOX
            // 
            this.IDOEUVREVENDREtEXTBOX.Location = new System.Drawing.Point(87, 34);
            this.IDOEUVREVENDREtEXTBOX.Name = "IDOEUVREVENDREtEXTBOX";
            this.IDOEUVREVENDREtEXTBOX.Size = new System.Drawing.Size(100, 20);
            this.IDOEUVREVENDREtEXTBOX.TabIndex = 1;
            this.IDOEUVREVENDREtEXTBOX.TextChanged += new System.EventHandler(this.IDOEUVREVENDREtEXTBOX_TextChanged);
            // 
            // PrixOeuvretextBox
            // 
            this.PrixOeuvretextBox.Location = new System.Drawing.Point(87, 77);
            this.PrixOeuvretextBox.Name = "PrixOeuvretextBox";
            this.PrixOeuvretextBox.Size = new System.Drawing.Size(100, 20);
            this.PrixOeuvretextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID  OEUVRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "PRIX";
            // 
            // Form_vendre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 179);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrixOeuvretextBox);
            this.Controls.Add(this.IDOEUVREVENDREtEXTBOX);
            this.Controls.Add(this.vendreoeuvreButton);
            this.Name = "Form_vendre";
            this.Text = "Form_vendre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button vendreoeuvreButton;
        private System.Windows.Forms.TextBox IDOEUVREVENDREtEXTBOX;
        private System.Windows.Forms.TextBox PrixOeuvretextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}