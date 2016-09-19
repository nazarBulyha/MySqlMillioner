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
            this.btnPhys = new System.Windows.Forms.Button();
            this.btnMath = new System.Windows.Forms.Button();
            this.btnProg = new System.Windows.Forms.Button();
            this.lblChoose = new System.Windows.Forms.Label();
            this.gbChoose = new System.Windows.Forms.GroupBox();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblQuestionNumber = new System.Windows.Forms.Label();
            this.gbQA = new System.Windows.Forms.GroupBox();
            this.btnA = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.gbChoose.SuspendLayout();
            this.gbQA.SuspendLayout();
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
            this.gbChoose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
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
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnB.Location = new System.Drawing.Point(763, 85);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(404, 60);
            this.btnB.TabIndex = 10;
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnC.Location = new System.Drawing.Point(27, 184);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(404, 60);
            this.btnC.TabIndex = 11;
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnD.Location = new System.Drawing.Point(763, 184);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(404, 60);
            this.btnD.TabIndex = 12;
            this.btnD.UseVisualStyleBackColor = false;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(41, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(772, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "B:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(41, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "C:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(772, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "D:";
            // 
            // lblQuestion
            // 
            this.lblQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblQuestion.Location = new System.Drawing.Point(437, 16);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(321, 66);
            this.lblQuestion.TabIndex = 17;
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblQuestionNumber
            // 
            this.lblQuestionNumber.AutoSize = true;
            this.lblQuestionNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblQuestionNumber.Location = new System.Drawing.Point(437, 16);
            this.lblQuestionNumber.Name = "lblQuestionNumber";
            this.lblQuestionNumber.Size = new System.Drawing.Size(0, 13);
            this.lblQuestionNumber.TabIndex = 18;
            // 
            // gbQA
            // 
            this.gbQA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gbQA.Controls.Add(this.label3);
            this.gbQA.Controls.Add(this.label4);
            this.gbQA.Controls.Add(this.btnC);
            this.gbQA.Controls.Add(this.label1);
            this.gbQA.Controls.Add(this.lblQuestionNumber);
            this.gbQA.Controls.Add(this.lblQuestion);
            this.gbQA.Controls.Add(this.label2);
            this.gbQA.Controls.Add(this.btnB);
            this.gbQA.Controls.Add(this.btnD);
            this.gbQA.Controls.Add(this.btnA);
            this.gbQA.Location = new System.Drawing.Point(367, 796);
            this.gbQA.Name = "gbQA";
            this.gbQA.Size = new System.Drawing.Size(1182, 263);
            this.gbQA.TabIndex = 19;
            this.gbQA.TabStop = false;
            this.gbQA.Visible = false;
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnA.Location = new System.Drawing.Point(27, 85);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(404, 60);
            this.btnA.TabIndex = 20;
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
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
            this.Controls.Add(this.gbQA);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Millionaire";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Click += new System.EventHandler(this.btnA_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbChoose.ResumeLayout(false);
            this.gbChoose.PerformLayout();
            this.gbQA.ResumeLayout(false);
            this.gbQA.PerformLayout();
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
        private System.Windows.Forms.Button btnPhys;
        private System.Windows.Forms.Button btnMath;
        private System.Windows.Forms.Button btnProg;
        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.GroupBox gbChoose;
        private System.Windows.Forms.ToolStripMenuItem startGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem continueToolStripMenuItem;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblQuestionNumber;
        private System.Windows.Forms.GroupBox gbQA;
        private System.Windows.Forms.Button btnA;
    }
}

