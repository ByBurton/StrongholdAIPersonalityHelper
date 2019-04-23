namespace SAIPH
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.AICdataGridView = new System.Windows.Forms.DataGridView();
            this.CheBoxOnlyUnknown = new System.Windows.Forms.CheckBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.BtnPath = new System.Windows.Forms.Button();
            this.LoadingprogressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.AICdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Location = new System.Drawing.Point(114, 10);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(75, 23);
            this.BtnRefresh.TabIndex = 1;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // AICdataGridView
            // 
            this.AICdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AICdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AICdataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.AICdataGridView.Location = new System.Drawing.Point(0, 39);
            this.AICdataGridView.Name = "AICdataGridView";
            this.AICdataGridView.RowHeadersWidth = 70;
            this.AICdataGridView.Size = new System.Drawing.Size(800, 416);
            this.AICdataGridView.TabIndex = 0;
            // 
            // CheBoxOnlyUnkown
            // 
            this.CheBoxOnlyUnknown.AutoSize = true;
            this.CheBoxOnlyUnknown.Location = new System.Drawing.Point(195, 14);
            this.CheBoxOnlyUnknown.Name = "CheBoxOnlyUnkown";
            this.CheBoxOnlyUnknown.Size = new System.Drawing.Size(96, 17);
            this.CheBoxOnlyUnknown.TabIndex = 2;
            this.CheBoxOnlyUnknown.Text = "Only Unknown";
            this.CheBoxOnlyUnknown.UseVisualStyleBackColor = true;
            // 
            // BtnPath
            // 
            this.BtnPath.Location = new System.Drawing.Point(12, 10);
            this.BtnPath.Name = "BtnPath";
            this.BtnPath.Size = new System.Drawing.Size(96, 23);
            this.BtnPath.TabIndex = 3;
            this.BtnPath.Text = "Select Path";
            this.BtnPath.UseVisualStyleBackColor = true;
            this.BtnPath.Click += new System.EventHandler(this.BtnPath_Click);
            // 
            // LoadingprogressBar
            // 
            this.LoadingprogressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadingprogressBar.Location = new System.Drawing.Point(588, 10);
            this.LoadingprogressBar.Name = "LoadingprogressBar";
            this.LoadingprogressBar.Size = new System.Drawing.Size(200, 23);
            this.LoadingprogressBar.TabIndex = 4;
            this.LoadingprogressBar.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 455);
            this.Controls.Add(this.LoadingprogressBar);
            this.Controls.Add(this.BtnPath);
            this.Controls.Add(this.CheBoxOnlyUnknown);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.AICdataGridView);
            this.MaximumSize = new System.Drawing.Size(4000, 494);
            this.MinimumSize = new System.Drawing.Size(600, 494);
            this.Name = "MainForm";
            this.Text = "SAIPH";
            ((System.ComponentModel.ISupportInitialize)(this.AICdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.DataGridView AICdataGridView;
        private System.Windows.Forms.CheckBox CheBoxOnlyUnknown;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button BtnPath;
        private System.Windows.Forms.ProgressBar LoadingprogressBar;
    }
}

