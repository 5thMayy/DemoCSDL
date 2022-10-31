namespace quanLyRapChieuPhim
{
    partial class frmQuanLyRapChieuPhim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyRapChieuPhim));
            this.lbTittle = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.btnFunction = new System.Windows.Forms.Button();
            this.btnProcedure = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTittle
            // 
            this.lbTittle.AutoSize = true;
            this.lbTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTittle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbTittle.Location = new System.Drawing.Point(231, 60);
            this.lbTittle.Name = "lbTittle";
            this.lbTittle.Size = new System.Drawing.Size(341, 31);
            this.lbTittle.TabIndex = 0;
            this.lbTittle.Text = "Quản Lý Rạp Chiếu Phim";
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.Black;
            this.btnView.Location = new System.Drawing.Point(155, 272);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(79, 41);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnFunction
            // 
            this.btnFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFunction.ForeColor = System.Drawing.Color.Black;
            this.btnFunction.Location = new System.Drawing.Point(355, 272);
            this.btnFunction.Name = "btnFunction";
            this.btnFunction.Size = new System.Drawing.Size(97, 41);
            this.btnFunction.TabIndex = 2;
            this.btnFunction.Text = "Function";
            this.btnFunction.UseVisualStyleBackColor = true;
            this.btnFunction.Click += new System.EventHandler(this.btnFunction_Click);
            // 
            // btnProcedure
            // 
            this.btnProcedure.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcedure.ForeColor = System.Drawing.Color.Black;
            this.btnProcedure.Location = new System.Drawing.Point(566, 272);
            this.btnProcedure.Name = "btnProcedure";
            this.btnProcedure.Size = new System.Drawing.Size(116, 41);
            this.btnProcedure.TabIndex = 3;
            this.btnProcedure.Text = "Procedure";
            this.btnProcedure.UseVisualStyleBackColor = true;
            this.btnProcedure.Click += new System.EventHandler(this.btnProcedure_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogout.Location = new System.Drawing.Point(355, 370);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(97, 37);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbWelcome.Location = new System.Drawing.Point(149, 150);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(0, 31);
            this.lbWelcome.TabIndex = 5;
            // 
            // frmQuanLyRapChieuPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbWelcome);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnProcedure);
            this.Controls.Add(this.btnFunction);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.lbTittle);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuanLyRapChieuPhim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Rạp Chiếu Phim - Nhóm 5";
            this.Load += new System.EventHandler(this.frmQuanLyRapChieuPhim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTittle;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnFunction;
        private System.Windows.Forms.Button btnProcedure;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lbWelcome;
    }
}

