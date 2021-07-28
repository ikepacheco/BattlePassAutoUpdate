
namespace BattlePassPanelAutomatico
{
    partial class Content
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Content));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UGradeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BattlePass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BattlePassPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this._AID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._NameChar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XP_OLD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XP_REST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TimerBP = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.TimerAssis = new System.Windows.Forms.Timer(this.components);
            this.label_time = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AID,
            this.UserID,
            this.UGradeID,
            this.BattlePass,
            this.BattlePassPoints,
            this.ColorName});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(763, 344);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AID
            // 
            this.AID.HeaderText = "AID";
            this.AID.Name = "AID";
            // 
            // UserID
            // 
            this.UserID.HeaderText = "UserID";
            this.UserID.Name = "UserID";
            // 
            // UGradeID
            // 
            this.UGradeID.HeaderText = "UGradeID";
            this.UGradeID.Name = "UGradeID";
            // 
            // BattlePass
            // 
            this.BattlePass.HeaderText = "BattlePass";
            this.BattlePass.Name = "BattlePass";
            // 
            // BattlePassPoints
            // 
            this.BattlePassPoints.HeaderText = "BattlePassPoints";
            this.BattlePassPoints.Name = "BattlePassPoints";
            // 
            // ColorName
            // 
            this.ColorName.HeaderText = "ColorName";
            this.ColorName.Name = "ColorName";
            this.ColorName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColorName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColorName.ToolTipText = "Color";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(777, 376);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(769, 350);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "XP Old";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._AID,
            this._CID,
            this._NameChar,
            this.XP,
            this.XP_OLD,
            this.XP_REST});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(763, 344);
            this.dataGridView2.TabIndex = 0;
            // 
            // _AID
            // 
            this._AID.HeaderText = "AID";
            this._AID.Name = "_AID";
            // 
            // _CID
            // 
            this._CID.HeaderText = "CID";
            this._CID.Name = "_CID";
            // 
            // _NameChar
            // 
            this._NameChar.HeaderText = "NameChar";
            this._NameChar.Name = "_NameChar";
            // 
            // XP
            // 
            this.XP.HeaderText = "XP";
            this.XP.Name = "XP";
            // 
            // XP_OLD
            // 
            this.XP_OLD.HeaderText = "XP_OLD";
            this.XP_OLD.Name = "XP_OLD";
            // 
            // XP_REST
            // 
            this.XP_REST.HeaderText = "XP_REST";
            this.XP_REST.Name = "XP_REST";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(769, 350);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TimerBP
            // 
            this.TimerBP.Enabled = true;
            this.TimerBP.Interval = 1000;
            this.TimerBP.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Battle Pass Points AutoUpdate";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // TimerAssis
            // 
            this.TimerAssis.Enabled = true;
            this.TimerAssis.Interval = 1000;
            this.TimerAssis.Tick += new System.EventHandler(this.TimerAssis_Tick);
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(565, 4);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(35, 13);
            this.label_time.TabIndex = 1;
            this.label_time.Text = "label1";
            // 
            // Content
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 376);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Content";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Battle Pass Points AutoUpdate";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Content_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Timer TimerBP;
        private System.Windows.Forms.DataGridViewTextBoxColumn AID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UGradeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BattlePass;
        private System.Windows.Forms.DataGridViewTextBoxColumn BattlePassPoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _AID;
        private System.Windows.Forms.DataGridViewTextBoxColumn _CID;
        private System.Windows.Forms.DataGridViewTextBoxColumn _NameChar;
        private System.Windows.Forms.DataGridViewTextBoxColumn XP;
        private System.Windows.Forms.DataGridViewTextBoxColumn XP_OLD;
        private System.Windows.Forms.DataGridViewTextBoxColumn XP_REST;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer TimerAssis;
        private System.Windows.Forms.Label label_time;
    }
}

