namespace insert_update_delete.cs
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.LAPProudectID = new System.Windows.Forms.Label();
            this.lAPProudectname = new System.Windows.Forms.Label();
            this.comboProudectID = new System.Windows.Forms.ComboBox();
            this.textProudectName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnInsert.Location = new System.Drawing.Point(64, 342);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(141, 51);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnUpdate.Location = new System.Drawing.Point(331, 342);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(141, 51);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btndelete.Location = new System.Drawing.Point(648, 342);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(141, 51);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // LAPProudectID
            // 
            this.LAPProudectID.AutoSize = true;
            this.LAPProudectID.Location = new System.Drawing.Point(98, 97);
            this.LAPProudectID.Name = "LAPProudectID";
            this.LAPProudectID.Size = new System.Drawing.Size(78, 17);
            this.LAPProudectID.TabIndex = 3;
            this.LAPProudectID.Text = "ProudectID";
            // 
            // lAPProudectname
            // 
            this.lAPProudectname.AutoSize = true;
            this.lAPProudectname.Location = new System.Drawing.Point(98, 182);
            this.lAPProudectname.Name = "lAPProudectname";
            this.lAPProudectname.Size = new System.Drawing.Size(99, 17);
            this.lAPProudectname.TabIndex = 4;
            this.lAPProudectname.Text = "ProudectName";
            // 
            // comboProudectID
            // 
            this.comboProudectID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboProudectID.FormattingEnabled = true;
            this.comboProudectID.Location = new System.Drawing.Point(243, 90);
            this.comboProudectID.Name = "comboProudectID";
            this.comboProudectID.Size = new System.Drawing.Size(258, 24);
            this.comboProudectID.TabIndex = 5;
            // 
            // textProudectName
            // 
            this.textProudectName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textProudectName.Location = new System.Drawing.Point(243, 175);
            this.textProudectName.Name = "textProudectName";
            this.textProudectName.Size = new System.Drawing.Size(263, 24);
            this.textProudectName.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textProudectName);
            this.Controls.Add(this.comboProudectID);
            this.Controls.Add(this.lAPProudectname);
            this.Controls.Add(this.LAPProudectID);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label LAPProudectID;
        private System.Windows.Forms.Label lAPProudectname;
        private System.Windows.Forms.ComboBox comboProudectID;
        private System.Windows.Forms.TextBox textProudectName;
    }
}

