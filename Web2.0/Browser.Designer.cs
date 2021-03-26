
namespace Web2._0
{
    partial class Browser
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browser));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.web = new System.Windows.Forms.WebBrowser();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_back = new System.Windows.Forms.ToolStripButton();
            this.btn_next = new System.Windows.Forms.ToolStripButton();
            this.btn_remove = new System.Windows.Forms.ToolStripButton();
            this.btn_home = new System.Windows.Forms.ToolStripButton();
            this.adressBar = new System.Windows.Forms.ToolStripTextBox();
            this.btn_search = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.25F));
            this.tableLayoutPanel1.Controls.Add(this.web, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.33334F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // web
            // 
            this.web.Dock = System.Windows.Forms.DockStyle.Fill;
            this.web.Location = new System.Drawing.Point(3, 32);
            this.web.MinimumSize = new System.Drawing.Size(20, 20);
            this.web.Name = "web";
            this.web.Size = new System.Drawing.Size(794, 415);
            this.web.TabIndex = 0;
            this.web.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.web_DocumentCompleted);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_back,
            this.btn_next,
            this.btn_remove,
            this.btn_home,
            this.adressBar,
            this.btn_search,
            this.toolStripButton6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_back
            // 
            this.btn_back.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_back.Image")));
            this.btn_back.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(23, 22);
            this.btn_back.Text = "toolStripButton1";
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_next
            // 
            this.btn_next.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_next.Image = ((System.Drawing.Image)(resources.GetObject("btn_next.Image")));
            this.btn_next.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(23, 22);
            this.btn_next.Text = "toolStripButton2";
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_remove.Image = ((System.Drawing.Image)(resources.GetObject("btn_remove.Image")));
            this.btn_remove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(23, 22);
            this.btn_remove.Text = "toolStripButton3";
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_home
            // 
            this.btn_home.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(23, 22);
            this.btn_home.Text = "toolStripButton4";
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // adressBar
            // 
            this.adressBar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.adressBar.Name = "adressBar";
            this.adressBar.Size = new System.Drawing.Size(600, 25);
            this.adressBar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.adressBar_KeyUp);
            // 
            // btn_search
            // 
            this.btn_search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(23, 22);
            this.btn_search.Text = "toolStripButton5";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "toolStripButton6";
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Browser";
            this.Text = "Browser";
            this.Load += new System.EventHandler(this.Browser_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.WebBrowser web;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_back;
        private System.Windows.Forms.ToolStripButton btn_next;
        private System.Windows.Forms.ToolStripButton btn_remove;
        private System.Windows.Forms.ToolStripButton btn_home;
        private System.Windows.Forms.ToolStripTextBox adressBar;
        private System.Windows.Forms.ToolStripButton btn_search;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
    }
}

