namespace Personregister
{
    partial class PersonViewer
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
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPnr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProfession = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(92, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(85, 29);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pnr";
            // 
            // txtPnr
            // 
            this.txtPnr.Location = new System.Drawing.Point(140, 89);
            this.txtPnr.Name = "txtPnr";
            this.txtPnr.Size = new System.Drawing.Size(100, 22);
            this.txtPnr.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Profession";
            // 
            // txtProfession
            // 
            this.txtProfession.Location = new System.Drawing.Point(140, 125);
            this.txtProfession.Name = "txtProfession";
            this.txtProfession.Size = new System.Drawing.Size(100, 22);
            this.txtProfession.TabIndex = 4;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(97, 207);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(93, 34);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "Kool";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // PersonViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtProfession);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPnr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Name = "PersonViewer";
            this.Text = "PersonViewer";
            this.Load += new System.EventHandler(this.PersonViewer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPnr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProfession;
        private System.Windows.Forms.Button btnOK;
    }
}