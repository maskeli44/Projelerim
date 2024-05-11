namespace LokantaProjes3
{
    partial class RaporForm
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
            this.listBoxRapor = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxRapor
            // 
            this.listBoxRapor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.listBoxRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBoxRapor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listBoxRapor.FormattingEnabled = true;
            this.listBoxRapor.ItemHeight = 25;
            this.listBoxRapor.Location = new System.Drawing.Point(-3, 3);
            this.listBoxRapor.Name = "listBoxRapor";
            this.listBoxRapor.Size = new System.Drawing.Size(804, 454);
            this.listBoxRapor.TabIndex = 0;
            // 
            // RaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxRapor);
            this.Name = "RaporForm";
            this.Text = "RaporForm";
            this.Load += new System.EventHandler(this.RaporForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxRapor;
    }
}