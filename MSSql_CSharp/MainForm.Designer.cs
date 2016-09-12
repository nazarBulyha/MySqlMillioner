namespace MSSql_CSharp
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.continueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logDbDataSet = new MSSql_CSharp.LogDbDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new MSSql_CSharp.LogDbDataSetTableAdapters.UsersTableAdapter();
            this.btnPhys = new System.Windows.Forms.Button();
            this.btnMath = new System.Windows.Forms.Button();
            this.btnProg = new System.Windows.Forms.Button();
            this.lblChoose = new System.Windows.Forms.Label();
            this.gbChoose = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.gbChoose.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programmToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.helpMeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(10, 10);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1896, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programmToolStripMenuItem
            // 
            this.programmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startGameToolStripMenuItem,
            this.logInToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.programmToolStripMenuItem.Name = "programmToolStripMenuItem";
            this.programmToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programmToolStripMenuItem.Text = "Program";
            // 
            // startGameToolStripMenuItem
            // 
            this.startGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.continueToolStripMenuItem});
            this.startGameToolStripMenuItem.Name = "startGameToolStripMenuItem";
            this.startGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.startGameToolStripMenuItem.Text = "Start Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // continueToolStripMenuItem
            // 
            this.continueToolStripMenuItem.Name = "continueToolStripMenuItem";
            this.continueToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.continueToolStripMenuItem.Text = "Continue";
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.logInToolStripMenuItem.Text = "Log in";
            this.logInToolStripMenuItem.Click += new System.EventHandler(this.logInToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // helpMeToolStripMenuItem
            // 
            this.helpMeToolStripMenuItem.Name = "helpMeToolStripMenuItem";
            this.helpMeToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.helpMeToolStripMenuItem.Text = "Help me";
            // 
            // logDbDataSet
            // 
            this.logDbDataSet.DataSetName = "LogDbDataSet";
            this.logDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.logDbDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // btnPhys
            // 
            this.btnPhys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPhys.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPhys.ForeColor = System.Drawing.Color.Black;
            this.btnPhys.Location = new System.Drawing.Point(33, 85);
            this.btnPhys.Name = "btnPhys";
            this.btnPhys.Size = new System.Drawing.Size(463, 49);
            this.btnPhys.TabIndex = 4;
            this.btnPhys.Text = "Physics";
            this.btnPhys.UseVisualStyleBackColor = false;
            this.btnPhys.Click += new System.EventHandler(this.btnPhys_Click);
            // 
            // btnMath
            // 
            this.btnMath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMath.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMath.ForeColor = System.Drawing.Color.Black;
            this.btnMath.Location = new System.Drawing.Point(33, 140);
            this.btnMath.Name = "btnMath";
            this.btnMath.Size = new System.Drawing.Size(463, 49);
            this.btnMath.TabIndex = 5;
            this.btnMath.Text = "Mathematics";
            this.btnMath.UseVisualStyleBackColor = false;
            this.btnMath.Click += new System.EventHandler(this.btnMath_Click);
            // 
            // btnProg
            // 
            this.btnProg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnProg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProg.ForeColor = System.Drawing.Color.Black;
            this.btnProg.Location = new System.Drawing.Point(33, 195);
            this.btnProg.Name = "btnProg";
            this.btnProg.Size = new System.Drawing.Size(463, 49);
            this.btnProg.TabIndex = 6;
            this.btnProg.Text = "Programming";
            this.btnProg.UseVisualStyleBackColor = false;
            this.btnProg.Click += new System.EventHandler(this.btnProg_Click);
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.BackColor = System.Drawing.Color.Yellow;
            this.lblChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChoose.Location = new System.Drawing.Point(6, 16);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(504, 55);
            this.lblChoose.TabIndex = 7;
            this.lblChoose.Text = "Choose your Subject:";
            // 
            // gbChoose
            // 
            this.gbChoose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gbChoose.Controls.Add(this.lblChoose);
            this.gbChoose.Controls.Add(this.btnProg);
            this.gbChoose.Controls.Add(this.btnPhys);
            this.gbChoose.Controls.Add(this.btnMath);
            this.gbChoose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbChoose.Location = new System.Drawing.Point(10, 37);
            this.gbChoose.Name = "gbChoose";
            this.gbChoose.Size = new System.Drawing.Size(518, 254);
            this.gbChoose.TabIndex = 8;
            this.gbChoose.TabStop = false;
            this.gbChoose.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1916, 1053);
            this.Controls.Add(this.gbChoose);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Millionaire";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.gbChoose.ResumeLayout(false);
            this.gbChoose.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMeToolStripMenuItem;
        private LogDbDataSet logDbDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private LogDbDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Button btnPhys;
        private System.Windows.Forms.Button btnMath;
        private System.Windows.Forms.Button btnProg;
        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.GroupBox gbChoose;
        private System.Windows.Forms.ToolStripMenuItem startGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem continueToolStripMenuItem;
    }
}

