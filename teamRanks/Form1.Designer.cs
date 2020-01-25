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
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiCloseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.listViewAdjacencyMatrix = new System.Windows.Forms.ListView();
            this.listViewStrenghtMatrix = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiGetRankings
            // 
            this.uiGetRankings.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.uiGetRankings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiGetRankings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiGetRankings.Location = new System.Drawing.Point(580, 80);
            this.uiGetRankings.Name = "uiGetRankings";
            this.uiGetRankings.Size = new System.Drawing.Size(107, 34);
            this.uiGetRankings.TabIndex = 0;
            this.uiGetRankings.Text = "Get Rankings";
            this.uiGetRankings.UseVisualStyleBackColor = false;
            this.uiGetRankings.Click += new System.EventHandler(this.uiGetRankings_Click);
            // 
            // listViewRanking
            // 
            this.listViewRanking.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listViewRanking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewRanking.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewRanking.HideSelection = false;
            this.listViewRanking.Location = new System.Drawing.Point(12, 120);
            this.listViewRanking.Name = "listViewRanking";
            this.listViewRanking.Size = new System.Drawing.Size(311, 245);
            this.listViewRanking.TabIndex = 2;
            this.listViewRanking.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.uiCloseButton);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 53);
            this.panel1.TabIndex = 3;
            // 
            // uiCloseButton
            // 
            this.uiCloseButton.FlatAppearance.BorderSize = 0;
            this.uiCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiCloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiCloseButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.uiCloseButton.Location = new System.Drawing.Point(623, 3);
            this.uiCloseButton.Name = "uiCloseButton";
            this.uiCloseButton.Size = new System.Drawing.Size(75, 50);
            this.uiCloseButton.TabIndex = 4;
            this.uiCloseButton.Text = "X";
            this.uiCloseButton.UseVisualStyleBackColor = true;
            this.uiCloseButton.Click += new System.EventHandler(this.uiCloseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rankings";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 34);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(0, 398);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(323, 34);
            this.panel3.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Adjacency matrix M";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(378, 398);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(323, 34);
            this.panel4.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(207, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "M + M^2 matrix";
            // 
            // listViewAdjacencyMatrix
            // 
            this.listViewAdjacencyMatrix.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listViewAdjacencyMatrix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewAdjacencyMatrix.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewAdjacencyMatrix.HideSelection = false;
            this.listViewAdjacencyMatrix.Location = new System.Drawing.Point(12, 452);
            this.listViewAdjacencyMatrix.Name = "listViewAdjacencyMatrix";
            this.listViewAdjacencyMatrix.Size = new System.Drawing.Size(233, 177);
            this.listViewAdjacencyMatrix.TabIndex = 9;
            this.listViewAdjacencyMatrix.UseCompatibleStateImageBehavior = false;
            // 
            // listViewStrenghtMatrix
            // 
            this.listViewStrenghtMatrix.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listViewStrenghtMatrix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewStrenghtMatrix.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewStrenghtMatrix.HideSelection = false;
            this.listViewStrenghtMatrix.Location = new System.Drawing.Point(454, 452);
            this.listViewStrenghtMatrix.Name = "listViewStrenghtMatrix";
            this.listViewStrenghtMatrix.Size = new System.Drawing.Size(233, 177);
            this.listViewStrenghtMatrix.TabIndex = 10;
            this.listViewStrenghtMatrix.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(9, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Team ranking";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(699, 641);
            this.Controls.Add(this.listViewStrenghtMatrix);
            this.Controls.Add(this.listViewAdjacencyMatrix);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listViewRanking);
            this.Controls.Add(this.uiGetRankings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uiGetRankings;
        private System.Windows.Forms.ListView listViewRanking;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button uiCloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewAdjacencyMatrix;
        private System.Windows.Forms.ListView listViewStrenghtMatrix;
        private System.Windows.Forms.Label label4;
    }
}

