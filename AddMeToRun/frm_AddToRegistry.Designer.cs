namespace AddMeToRun
{
    partial class frm_AddToRegistry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddToRegistry));
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lb_Name = new System.Windows.Forms.Label();
            this.lb_AppPath = new System.Windows.Forms.Label();
            this.txt_Path = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lb_DragnDrop = new System.Windows.Forms.Label();
            this.lb_NameTips = new System.Windows.Forms.Label();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(50, 9);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(166, 20);
            this.txt_Name.TabIndex = 1;
            this.txt_Name.TextChanged += new System.EventHandler(this.txt_Name_TextChanged);
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name.Location = new System.Drawing.Point(3, 10);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(44, 15);
            this.lb_Name.TabIndex = 1;
            this.lb_Name.Text = "Name:";
            // 
            // lb_AppPath
            // 
            this.lb_AppPath.AutoSize = true;
            this.lb_AppPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AppPath.Location = new System.Drawing.Point(12, 36);
            this.lb_AppPath.Name = "lb_AppPath";
            this.lb_AppPath.Size = new System.Drawing.Size(35, 15);
            this.lb_AppPath.TabIndex = 2;
            this.lb_AppPath.Text = "Path:";
            // 
            // txt_Path
            // 
            this.txt_Path.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Path.Location = new System.Drawing.Point(48, 36);
            this.txt_Path.Name = "txt_Path";
            this.txt_Path.Size = new System.Drawing.Size(382, 20);
            this.txt_Path.TabIndex = 2;
            this.txt_Path.DoubleClick += new System.EventHandler(this.txt_Path_DoubleClick);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(274, 62);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(355, 62);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // lb_DragnDrop
            // 
            this.lb_DragnDrop.AutoSize = true;
            this.lb_DragnDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lb_DragnDrop.ForeColor = System.Drawing.Color.Green;
            this.lb_DragnDrop.Location = new System.Drawing.Point(236, 12);
            this.lb_DragnDrop.Name = "lb_DragnDrop";
            this.lb_DragnDrop.Size = new System.Drawing.Size(168, 13);
            this.lb_DragnDrop.TabIndex = 6;
            this.lb_DragnDrop.Text = "** Double click TextBox to add file";
            this.lb_DragnDrop.Visible = false;
            // 
            // lb_NameTips
            // 
            this.lb_NameTips.AutoSize = true;
            this.lb_NameTips.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lb_NameTips.ForeColor = System.Drawing.Color.Red;
            this.lb_NameTips.Location = new System.Drawing.Point(12, 58);
            this.lb_NameTips.Name = "lb_NameTips";
            this.lb_NameTips.Size = new System.Drawing.Size(167, 30);
            this.lb_NameTips.TabIndex = 7;
            this.lb_NameTips.Text = "** Name should be \".exe\" \r\nExample: \"text.txt\" = \"text.exe\"";
            // 
            // btn_Browse
            // 
            this.btn_Browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browse.Location = new System.Drawing.Point(193, 62);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(75, 23);
            this.btn_Browse.TabIndex = 5;
            this.btn_Browse.Text = "Browse File";
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // frm_AddToRegistry
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(437, 93);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.lb_NameTips);
            this.Controls.Add(this.lb_DragnDrop);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_Path);
            this.Controls.Add(this.lb_AppPath);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.txt_Name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(954, 132);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(453, 132);
            this.Name = "frm_AddToRegistry";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add to run";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frm_AddToRegistry_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frm_AddToRegistry_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.frm_AddToRegistry_DragEnter);
            this.DragLeave += new System.EventHandler(this.frm_AddToRegistry_DragLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label lb_AppPath;
        private System.Windows.Forms.TextBox txt_Path;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lb_DragnDrop;
        private System.Windows.Forms.Label lb_NameTips;
        private System.Windows.Forms.Button btn_Browse;
    }
}