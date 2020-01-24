namespace teamRanks
{
    partial class Form1
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
            this.uiGetRankings = new System.Windows.Forms.Button();
            this.listViewRanking = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // uiGetRankings
            // 
            this.uiGetRankings.Location = new System.Drawing.Point(13, 13);
            this.uiGetRankings.Name = "uiGetRankings";
            this.uiGetRankings.Size = new System.Drawing.Size(83, 23);
            this.uiGetRankings.TabIndex = 0;
            this.uiGetRankings.Text = "Get Rankings";
            this.uiGetRankings.UseVisualStyleBackColor = true;
            this.uiGetRankings.Click += new System.EventHandler(this.uiGetRankings_Click);
            // 
            // listViewRanking
            // 
            this.listViewRanking.HideSelection = false;
            this.listViewRanking.Location = new System.Drawing.Point(13, 42);
            this.listViewRanking.Name = "listViewRanking";
            this.listViewRanking.Size = new System.Drawing.Size(311, 245);
            this.listViewRanking.TabIndex = 2;
            this.listViewRanking.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 332);
            this.Controls.Add(this.listViewRanking);
            this.Controls.Add(this.uiGetRankings);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uiGetRankings;
        private System.Windows.Forms.ListView listViewRanking;
    }
}

