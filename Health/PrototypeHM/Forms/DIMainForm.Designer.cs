namespace PrototypeHM.Forms
{
    partial class DIMainForm
    {
        /// <summary>
        /// ��������� ���������� ������������.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// ���������� ��� ������������ �������.
        /// </summary>
        /// <param name="disposing">�������, ���� ����������� ������ ������ ���� ������; ����� �����.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region ���, ������������� ��������� ������������� ���� Windows

        /// <summary>
        /// ������������ ����� ��� ��������� ������������ - �� ���������
        /// ���������� ������� ������ ��� ������ ��������� ����.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.�������ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDoctors = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDiagnosis = new System.Windows.Forms.ToolStripMenuItem();
            this.�����������������ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.��������ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.�����ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.������������ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.��������ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.��������ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.��������������ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.multiSelector1 = new PrototypeHM.Components.MultiSelector();
            this.button1 = new System.Windows.Forms.Button();
            this.multiSelector2 = new PrototypeHM.Components.MultiSelector();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowsMenu,
            this.�������ToolStripMenuItem,
            this.������������ToolStripMenuItem,
            this.��������ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1072, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.arrangeIconsToolStripMenuItem});
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(47, 20);
            this.windowsMenu.Text = "&����";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.cascadeToolStripMenuItem.Text = "&��������";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItemClick);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.tileVerticalToolStripMenuItem.Text = "�&���� �������";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.TileVerticalToolStripMenuItemClick);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.tileHorizontalToolStripMenuItem.Text = "�&����� ����";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItemClick);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.closeAllToolStripMenuItem.Text = "&������� ���";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItemClick);
            // 
            // arrangeIconsToolStripMenuItem
            // 
            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.arrangeIconsToolStripMenuItem.Text = "&����������� ������";
            this.arrangeIconsToolStripMenuItem.Click += new System.EventHandler(this.ArrangeIconsToolStripMenuItemClick);
            // 
            // �������ToolStripMenuItem
            // 
            this.�������ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDoctors,
            this.tsmiUser,
            this.tsmiDiagnosis,
            this.�����������������ToolStripMenuItem});
            this.�������ToolStripMenuItem.Name = "�������ToolStripMenuItem";
            this.�������ToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.�������ToolStripMenuItem.Text = "��������������";
            this.�������ToolStripMenuItem.Click += new System.EventHandler(this.�������ToolStripMenuItem_Click);
            // 
            // tsmiDoctors
            // 
            this.tsmiDoctors.Name = "tsmiDoctors";
            this.tsmiDoctors.Size = new System.Drawing.Size(191, 22);
            this.tsmiDoctors.Text = "�������";
            this.tsmiDoctors.Click += new System.EventHandler(this.TsmiDoctorsClick);
            // 
            // tsmiUser
            // 
            this.tsmiUser.Name = "tsmiUser";
            this.tsmiUser.Size = new System.Drawing.Size(191, 22);
            this.tsmiUser.Text = "������������";
            this.tsmiUser.Click += new System.EventHandler(this.TsmiUserClick);
            // 
            // tsmiDiagnosis
            // 
            this.tsmiDiagnosis.Name = "tsmiDiagnosis";
            this.tsmiDiagnosis.Size = new System.Drawing.Size(191, 22);
            this.tsmiDiagnosis.Text = "��������";
            this.tsmiDiagnosis.Click += new System.EventHandler(this.TsmiDiagnosisClick);
            // 
            // �����������������ToolStripMenuItem
            // 
            this.�����������������ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.��������ToolStripMenuItem,
            this.�����ToolStripMenuItem});
            this.�����������������ToolStripMenuItem.Name = "�����������������ToolStripMenuItem";
            this.�����������������ToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.�����������������ToolStripMenuItem.Text = "��������� ��������";
            this.�����������������ToolStripMenuItem.Click += new System.EventHandler(this.�����������������ToolStripMenuItem_Click);
            // 
            // ��������ToolStripMenuItem
            // 
            this.��������ToolStripMenuItem.Name = "��������ToolStripMenuItem";
            this.��������ToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.��������ToolStripMenuItem.Text = "��������";
            this.��������ToolStripMenuItem.Click += new System.EventHandler(this.��������ToolStripMenuItem_Click);
            // 
            // �����ToolStripMenuItem
            // 
            this.�����ToolStripMenuItem.Name = "�����ToolStripMenuItem";
            this.�����ToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.�����ToolStripMenuItem.Text = "�����";
            this.�����ToolStripMenuItem.Click += new System.EventHandler(this.�����ToolStripMenuItem_Click);
            // 
            // ������������ToolStripMenuItem
            // 
            this.������������ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.��������ToolStripMenuItem});
            this.������������ToolStripMenuItem.Name = "������������ToolStripMenuItem";
            this.������������ToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.������������ToolStripMenuItem.Text = "����� (�������)";
            // 
            // ��������ToolStripMenuItem
            // 
            this.��������ToolStripMenuItem.Name = "��������ToolStripMenuItem";
            this.��������ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.��������ToolStripMenuItem.Text = "��������";
            this.��������ToolStripMenuItem.Click += new System.EventHandler(this.��������ToolStripMenuItem_Click);
            // 
            // ��������ToolStripMenuItem
            // 
            this.��������ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.��������������ToolStripMenuItem});
            this.��������ToolStripMenuItem.Name = "��������ToolStripMenuItem";
            this.��������ToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.��������ToolStripMenuItem.Text = "��������";
            // 
            // ��������������ToolStripMenuItem
            // 
            this.��������������ToolStripMenuItem.Name = "��������������ToolStripMenuItem";
            this.��������������ToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.��������������ToolStripMenuItem.Text = "���� ����������";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 705);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1072, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(66, 17);
            this.toolStripStatusLabel.Text = "���������";
            // 
            // multiSelector1
            // 
            this.multiSelector1.EditMode = false;
            this.multiSelector1.Location = new System.Drawing.Point(45, 204);
            this.multiSelector1.MinimumSize = new System.Drawing.Size(255, 400);
            this.multiSelector1.Name = "multiSelector1";
            this.multiSelector1.Size = new System.Drawing.Size(445, 400);
            this.multiSelector1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // multiSelector2
            // 
            this.multiSelector2.EditMode = false;
            this.multiSelector2.Location = new System.Drawing.Point(516, 204);
            this.multiSelector2.MinimumSize = new System.Drawing.Size(400, 400);
            this.multiSelector2.Name = "multiSelector2";
            this.multiSelector2.Size = new System.Drawing.Size(400, 400);
            this.multiSelector2.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(516, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DIMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 727);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.multiSelector2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.multiSelector1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "DIMainForm";
            this.Text = "MDIMainForm";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem �������ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiDoctors;
        private System.Windows.Forms.ToolStripMenuItem tsmiUser;
        private System.Windows.Forms.ToolStripMenuItem tsmiDiagnosis;
        private System.Windows.Forms.ToolStripMenuItem ������������ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ��������ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem �����������������ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ��������ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ��������������ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ��������ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem �����ToolStripMenuItem;
        private Components.MultiSelector multiSelector1;
        private System.Windows.Forms.Button button1;
        private Components.MultiSelector multiSelector2;
        private System.Windows.Forms.Button button2;
    }
}



