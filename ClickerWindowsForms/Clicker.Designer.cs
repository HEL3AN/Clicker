namespace Clicker_by_Leyson.Conf
{
    partial class Clicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clicker));
            this.oneClickButton = new System.Windows.Forms.Button();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.oneClickLabel = new System.Windows.Forms.Label();
            this.storeButton = new System.Windows.Forms.Button();
            this.antiEnterButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameVersionLabel = new System.Windows.Forms.Label();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // oneClickButton
            // 
            this.oneClickButton.AutoSize = true;
            this.oneClickButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.oneClickButton.BackColor = System.Drawing.SystemColors.Control;
            this.oneClickButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.oneClickButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.oneClickButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.oneClickButton.FlatAppearance.BorderSize = 0;
            this.oneClickButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.oneClickButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.oneClickButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.oneClickButton.Font = new System.Drawing.Font("Plump", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneClickButton.Image = ((System.Drawing.Image)(resources.GetObject("oneClickButton.Image")));
            this.oneClickButton.Location = new System.Drawing.Point(221, 91);
            this.oneClickButton.Name = "oneClickButton";
            this.oneClickButton.Size = new System.Drawing.Size(263, 262);
            this.oneClickButton.TabIndex = 0;
            this.oneClickButton.TabStop = false;
            this.oneClickButton.Text = "CLICK";
            this.oneClickButton.UseVisualStyleBackColor = false;
            this.oneClickButton.Click += new System.EventHandler(this.OneClickButton_Click);
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moneyLabel.Location = new System.Drawing.Point(12, 24);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(66, 20);
            this.moneyLabel.TabIndex = 1;
            this.moneyLabel.Text = "Money:";
            // 
            // oneClickLabel
            // 
            this.oneClickLabel.AutoSize = true;
            this.oneClickLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oneClickLabel.Location = new System.Drawing.Point(11, 44);
            this.oneClickLabel.Name = "oneClickLabel";
            this.oneClickLabel.Size = new System.Drawing.Size(90, 20);
            this.oneClickLabel.TabIndex = 2;
            this.oneClickLabel.Text = "OneClick: ";
            // 
            // storeButton
            // 
            this.storeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.storeButton.Location = new System.Drawing.Point(315, 410);
            this.storeButton.Name = "storeButton";
            this.storeButton.Size = new System.Drawing.Size(75, 23);
            this.storeButton.TabIndex = 0;
            this.storeButton.TabStop = false;
            this.storeButton.Text = "Store";
            this.storeButton.UseVisualStyleBackColor = true;
            this.storeButton.Click += new System.EventHandler(this.StoreButton_Click);
            // 
            // antiEnterButton
            // 
            this.antiEnterButton.Location = new System.Drawing.Point(0, 0);
            this.antiEnterButton.Name = "antiEnterButton";
            this.antiEnterButton.Size = new System.Drawing.Size(0, 0);
            this.antiEnterButton.TabIndex = 0;
            this.antiEnterButton.TabStop = false;
            this.antiEnterButton.UseCompatibleTextRendering = true;
            this.antiEnterButton.UseVisualStyleBackColor = true;
            this.antiEnterButton.Click += new System.EventHandler(this.AntiEnterButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(704, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.resetDataToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.RestartToolStripMenuItem_Click);
            // 
            // resetDataToolStripMenuItem
            // 
            this.resetDataToolStripMenuItem.Name = "resetDataToolStripMenuItem";
            this.resetDataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetDataToolStripMenuItem.Text = "!!!Reset Data!!!";
            this.resetDataToolStripMenuItem.Click += new System.EventHandler(this.ResetDataToolStripMenuItem_Click);
            // 
            // gameVersionLabel
            // 
            this.gameVersionLabel.AutoSize = true;
            this.gameVersionLabel.ForeColor = System.Drawing.Color.Silver;
            this.gameVersionLabel.Location = new System.Drawing.Point(13, 420);
            this.gameVersionLabel.Name = "gameVersionLabel";
            this.gameVersionLabel.Size = new System.Drawing.Size(76, 13);
            this.gameVersionLabel.TabIndex = 4;
            this.gameVersionLabel.Text = "Game Version:";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // Clicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(704, 445);
            this.ControlBox = false;
            this.Controls.Add(this.gameVersionLabel);
            this.Controls.Add(this.antiEnterButton);
            this.Controls.Add(this.storeButton);
            this.Controls.Add(this.oneClickLabel);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.oneClickButton);
            this.Controls.Add(this.menuStrip1);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Clicker";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clicker by LeysonConf";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button oneClickButton;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Label oneClickLabel;
        private System.Windows.Forms.Button storeButton;
        private System.Windows.Forms.Button antiEnterButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetDataToolStripMenuItem;
        private System.Windows.Forms.Label gameVersionLabel;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

