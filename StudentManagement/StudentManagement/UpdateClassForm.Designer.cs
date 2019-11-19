namespace StudentManagement
{
    partial class UpdateClassForm
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
            this.lblname = new System.Windows.Forms.Label();
            this.lbldes = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(27, 13);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(71, 13);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Class\'s name:";
            // 
            // lbldes
            // 
            this.lbldes.AutoSize = true;
            this.lbldes.Location = new System.Drawing.Point(27, 41);
            this.lbldes.Name = "lbldes";
            this.lbldes.Size = new System.Drawing.Size(63, 13);
            this.lbldes.TabIndex = 1;
            this.lbldes.Text = "Description:";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(104, 6);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(316, 20);
            this.txtname.TabIndex = 2;
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(104, 38);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(316, 20);
            this.txtdescription.TabIndex = 3;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(185, 77);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 4;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(104, 77);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 5;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // UpdateClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 114);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.txtdescription);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lbldes);
            this.Controls.Add(this.lblname);
            this.Name = "UpdateClassForm";
            this.Text = "UpdateClassForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbldes;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsave;
    }
}