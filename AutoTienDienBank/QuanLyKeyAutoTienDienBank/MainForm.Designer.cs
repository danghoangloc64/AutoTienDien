
namespace QuanLyKeyAutoTienDienBank
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlListKey = new DevExpress.XtraGrid.GridControl();
            this.gridViewListKey = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnThemMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnKhoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnMoKhoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlListKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewListKey)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControlListKey);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(914, 448);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Danh sách key";
            // 
            // gridControlListKey
            // 
            this.gridControlListKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlListKey.Location = new System.Drawing.Point(2, 23);
            this.gridControlListKey.MainView = this.gridViewListKey;
            this.gridControlListKey.Name = "gridControlListKey";
            this.gridControlListKey.Size = new System.Drawing.Size(910, 423);
            this.gridControlListKey.TabIndex = 0;
            this.gridControlListKey.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewListKey});
            // 
            // gridViewListKey
            // 
            this.gridViewListKey.GridControl = this.gridControlListKey;
            this.gridViewListKey.Name = "gridViewListKey";
            this.gridViewListKey.OptionsBehavior.ReadOnly = true;
            this.gridViewListKey.OptionsView.ShowGroupPanel = false;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(851, 466);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(75, 23);
            this.btnThemMoi.TabIndex = 1;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(770, 466);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnKhoa
            // 
            this.btnKhoa.Location = new System.Drawing.Point(689, 466);
            this.btnKhoa.Name = "btnKhoa";
            this.btnKhoa.Size = new System.Drawing.Size(75, 23);
            this.btnKhoa.TabIndex = 1;
            this.btnKhoa.Text = "Khóa key";
            this.btnKhoa.Click += new System.EventHandler(this.btnKhoa_Click);
            // 
            // btnMoKhoa
            // 
            this.btnMoKhoa.Location = new System.Drawing.Point(608, 466);
            this.btnMoKhoa.Name = "btnMoKhoa";
            this.btnMoKhoa.Size = new System.Drawing.Size(75, 23);
            this.btnMoKhoa.TabIndex = 1;
            this.btnMoKhoa.Text = "Mở khóa key";
            this.btnMoKhoa.Click += new System.EventHandler(this.btnMoKhoa_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 466);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 501);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnMoKhoa);
            this.Controls.Add(this.btnKhoa);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quan Ly Key Auto Tien Dien Bank";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlListKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewListKey)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControlListKey;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewListKey;
        private DevExpress.XtraEditors.SimpleButton btnThemMoi;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnKhoa;
        private DevExpress.XtraEditors.SimpleButton btnMoKhoa;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
    }
}