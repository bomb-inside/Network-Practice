namespace NetworkCheck
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolStripBar = new System.Windows.Forms.ToolStrip();
            this.listViewStatus = new System.Windows.Forms.ListView();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.toolStripButtonAddHost = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStart = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBoxTime = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripStatusLabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripBar.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripBar
            // 
            this.toolStripBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddHost,
            this.toolStripButtonStart,
            this.toolStripButtonStop,
            this.toolStripComboBoxTime});
            this.toolStripBar.Location = new System.Drawing.Point(0, 0);
            this.toolStripBar.Name = "toolStripBar";
            this.toolStripBar.Size = new System.Drawing.Size(816, 28);
            this.toolStripBar.TabIndex = 0;
            this.toolStripBar.Text = "toolStrip1";
            // 
            // listViewStatus
            // 
            this.listViewStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewStatus.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewStatus.HideSelection = false;
            this.listViewStatus.Location = new System.Drawing.Point(0, 28);
            this.listViewStatus.MultiSelect = false;
            this.listViewStatus.Name = "listViewStatus";
            this.listViewStatus.Size = new System.Drawing.Size(816, 498);
            this.listViewStatus.TabIndex = 1;
            this.listViewStatus.UseCompatibleStateImageBehavior = false;
            this.listViewStatus.View = System.Windows.Forms.View.Details;
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelStatus});
            this.statusBar.Location = new System.Drawing.Point(0, 500);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(816, 26);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusStrip1";
            // 
            // Timer
            // 
            this.Timer.Interval = 5000;
            // 
            // toolStripButtonAddHost
            // 
            this.toolStripButtonAddHost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddHost.Image = global::NetworkCheck.Properties.Resources.server;
            this.toolStripButtonAddHost.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddHost.Name = "toolStripButtonAddHost";
            this.toolStripButtonAddHost.Size = new System.Drawing.Size(29, 25);
            this.toolStripButtonAddHost.Text = "AddHost";
            // 
            // toolStripButtonStart
            // 
            this.toolStripButtonStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStart.Image = global::NetworkCheck.Properties.Resources.start;
            this.toolStripButtonStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStart.Name = "toolStripButtonStart";
            this.toolStripButtonStart.Size = new System.Drawing.Size(29, 25);
            this.toolStripButtonStart.Text = "Start";
            // 
            // toolStripButtonStop
            // 
            this.toolStripButtonStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStop.Image = global::NetworkCheck.Properties.Resources.stop;
            this.toolStripButtonStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStop.Name = "toolStripButtonStop";
            this.toolStripButtonStop.Size = new System.Drawing.Size(29, 25);
            this.toolStripButtonStop.Text = "Stop";
            // 
            // toolStripComboBoxTime
            // 
            this.toolStripComboBoxTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxTime.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.toolStripComboBoxTime.Items.AddRange(new object[] {
            "5s",
            "10s",
            "15s",
            "20s",
            "30s"});
            this.toolStripComboBoxTime.Name = "toolStripComboBoxTime";
            this.toolStripComboBoxTime.Size = new System.Drawing.Size(121, 28);
            // 
            // toolStripStatusLabelStatus
            // 
            this.toolStripStatusLabelStatus.Name = "toolStripStatusLabelStatus";
            this.toolStripStatusLabelStatus.Size = new System.Drawing.Size(94, 20);
            this.toolStripStatusLabelStatus.Text = "Status : Stop";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 526);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.listViewStatus);
            this.Controls.Add(this.toolStripBar);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Network Check";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStripBar.ResumeLayout(false);
            this.toolStripBar.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripBar;
        private System.Windows.Forms.ListView listViewStatus;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddHost;
        private System.Windows.Forms.ToolStripButton toolStripButtonStart;
        private System.Windows.Forms.ToolStripButton toolStripButtonStop;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxTime;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelStatus;
    }
}

