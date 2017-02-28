namespace AddMeToRun
{
    partial class frm_Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Edit));
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Path = new System.Windows.Forms.TextBox();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lb_NameTips = new System.Windows.Forms.Label();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(48, 8);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(149, 20);
            this.txt_Name.TabIndex = 1;
            this.txt_Name.TextChanged += new System.EventHandler(this.txt_Name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Path:";
            // 
            // txt_Path
            // 
            this.txt_Path.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Path.Location = new System.Drawing.Point(48, 34);
            this.txt_Path.Name = "txt_Path";
            this.txt_Path.Size = new System.Drawing.Size(355, 20);
            this.txt_Path.TabIndex = 2;
            // 
            // btn_Edit
            // 
            this.btn_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(258, 64);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 4;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(339, 63);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // lb_NameTips
            // 
            this.lb_NameTips.AutoSize = true;
            this.lb_NameTips.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lb_NameTips.ForeColor = System.Drawing.Color.Red;
            this.lb_NameTips.Location = new System.Drawing.Point(4, 57);
            this.lb_NameTips.Name = "lb_NameTips";
            this.lb_NameTips.Size = new System.Drawing.Size(167, 30);
            this.lb_NameTips.TabIndex = 8;
            this.lb_NameTips.Text = "** Name should be \".exe\" \r\nExample: \"text.txt\" = \"text.exe\"";
            // 
            // btn_Browse
            // 
            this.btn_Browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browse.Location = new System.Drawing.Point(177, 62);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(75, 23);
            this.btn_Browse.TabIndex = 9;
            this.btn_Browse.Text = "Browse File";
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // frm_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(422, 96);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.lb_NameTips);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Path);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(954, 135);
            this.MinimumSize = new System.Drawing.Size(438, 135);
            this.Name = "frm_Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_Edit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Edit_FormClosing);
            this.Load += new System.EventHandler(this.frm_Edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Path;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lb_NameTips;
        private System.Windows.Forms.Button btn_Browse;
    }
}