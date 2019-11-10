namespace Clicker_by_Leyson.Conf
{
    partial class ClickerStore
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
            this.upgrade1Button = new System.Windows.Forms.Button();
            this.upgrade1CostLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // upgrade1Button
            // 
            this.upgrade1Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.upgrade1Button.Location = new System.Drawing.Point(13, 13);
            this.upgrade1Button.Name = "upgrade1Button";
            this.upgrade1Button.Size = new System.Drawing.Size(75, 23);
            this.upgrade1Button.TabIndex = 0;
            this.upgrade1Button.Text = "Upgrade #1\r\n";
            this.upgrade1Button.UseVisualStyleBackColor = true;
            this.upgrade1Button.Click += new System.EventHandler(this.Upgrade1Button_Click);
            // 
            // upgrade1CostLabel
            // 
            this.upgrade1CostLabel.AutoSize = true;
            this.upgrade1CostLabel.Location = new System.Drawing.Point(31, 39);
            this.upgrade1CostLabel.Name = "upgrade1CostLabel";
            this.upgrade1CostLabel.Size = new System.Drawing.Size(34, 13);
            this.upgrade1CostLabel.TabIndex = 1;
            this.upgrade1CostLabel.Text = "Price:";
            // 
            // ClickerStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 205);
            this.Controls.Add(this.upgrade1CostLabel);
            this.Controls.Add(this.upgrade1Button);
            this.Name = "ClickerStore";
            this.ShowIcon = false;
            this.Text = "ClickerStore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button upgrade1Button;
        private System.Windows.Forms.Label upgrade1CostLabel;
    }
}