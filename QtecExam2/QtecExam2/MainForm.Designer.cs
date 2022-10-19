namespace QtecExam2
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listContent = new DevExpress.XtraEditors.ListBoxControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelText = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnAmericano = new DevExpress.XtraEditors.SimpleButton();
            this.btnLatte = new DevExpress.XtraEditors.SimpleButton();
            this.btnEspresso = new DevExpress.XtraEditors.SimpleButton();
            this.btnReport = new DevExpress.XtraEditors.SimpleButton();
            this.btnIngredient = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listContent)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 425);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listContent);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 173);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(3);
            this.panel3.Size = new System.Drawing.Size(278, 252);
            this.panel3.TabIndex = 7;
            // 
            // listContent
            // 
            this.listContent.Appearance.Font = new System.Drawing.Font("굴림", 10F);
            this.listContent.Appearance.Options.UseFont = true;
            this.listContent.Appearance.Options.UseTextOptions = true;
            this.listContent.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.listContent.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.listContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listContent.Location = new System.Drawing.Point(3, 3);
            this.listContent.MultiColumn = true;
            this.listContent.Name = "listContent";
            this.listContent.Size = new System.Drawing.Size(272, 246);
            this.listContent.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelText);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 106);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(278, 67);
            this.panel2.TabIndex = 6;
            // 
            // labelText
            // 
            this.labelText.Appearance.Font = new System.Drawing.Font("굴림", 11F);
            this.labelText.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelText.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelText.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelText.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelText.Location = new System.Drawing.Point(5, 5);
            this.labelText.Name = "labelText";
            this.labelText.Padding = new System.Windows.Forms.Padding(5);
            this.labelText.Size = new System.Drawing.Size(268, 57);
            this.labelText.TabIndex = 0;
            this.labelText.Text = "☆ ★ 커피 자판기 ★ ☆";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnAmericano);
            this.panelControl1.Controls.Add(this.btnLatte);
            this.panelControl1.Controls.Add(this.btnEspresso);
            this.panelControl1.Controls.Add(this.btnReport);
            this.panelControl1.Controls.Add(this.btnIngredient);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(5);
            this.panelControl1.Size = new System.Drawing.Size(278, 106);
            this.panelControl1.TabIndex = 2;
            // 
            // btnAmericano
            // 
            this.btnAmericano.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAmericano.Appearance.Font = new System.Drawing.Font("굴림", 9F);
            this.btnAmericano.Appearance.Options.UseFont = true;
            this.btnAmericano.Location = new System.Drawing.Point(186, 63);
            this.btnAmericano.Name = "btnAmericano";
            this.btnAmericano.Size = new System.Drawing.Size(81, 33);
            this.btnAmericano.TabIndex = 5;
            this.btnAmericano.Text = "아메리카노";
            this.btnAmericano.Click += new System.EventHandler(this.btnAmericano_Click);
            // 
            // btnLatte
            // 
            this.btnLatte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLatte.Appearance.Font = new System.Drawing.Font("굴림", 9F);
            this.btnLatte.Appearance.Options.UseFont = true;
            this.btnLatte.Location = new System.Drawing.Point(99, 63);
            this.btnLatte.Name = "btnLatte";
            this.btnLatte.Size = new System.Drawing.Size(81, 33);
            this.btnLatte.TabIndex = 4;
            this.btnLatte.Text = "라떼";
            this.btnLatte.Click += new System.EventHandler(this.btnLatte_Click);
            // 
            // btnEspresso
            // 
            this.btnEspresso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEspresso.Appearance.Font = new System.Drawing.Font("굴림", 9F);
            this.btnEspresso.Appearance.Options.UseFont = true;
            this.btnEspresso.Location = new System.Drawing.Point(12, 63);
            this.btnEspresso.Name = "btnEspresso";
            this.btnEspresso.Size = new System.Drawing.Size(81, 33);
            this.btnEspresso.TabIndex = 3;
            this.btnEspresso.Text = "에스프레소";
            this.btnEspresso.Click += new System.EventHandler(this.btnEspresso_Click);
            // 
            // btnReport
            // 
            this.btnReport.Appearance.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.btnReport.Appearance.Options.UseFont = true;
            this.btnReport.Location = new System.Drawing.Point(142, 10);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(96, 40);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "정산보고";
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnIngredient
            // 
            this.btnIngredient.Appearance.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.btnIngredient.Appearance.Options.UseFont = true;
            this.btnIngredient.Location = new System.Drawing.Point(40, 10);
            this.btnIngredient.Name = "btnIngredient";
            this.btnIngredient.Size = new System.Drawing.Size(96, 40);
            this.btnIngredient.TabIndex = 1;
            this.btnIngredient.Text = "재료보고";
            this.btnIngredient.Click += new System.EventHandler(this.btnIngredient_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(286, 433);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listContent)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl labelText;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnAmericano;
        private DevExpress.XtraEditors.SimpleButton btnLatte;
        private DevExpress.XtraEditors.SimpleButton btnEspresso;
        private DevExpress.XtraEditors.SimpleButton btnReport;
        private DevExpress.XtraEditors.SimpleButton btnIngredient;
        private DevExpress.XtraEditors.ListBoxControl listContent;

    }
}

