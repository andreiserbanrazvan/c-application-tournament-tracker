namespace frmDashboard
{
    partial class frmTournamentDashboard
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.loadExistingTournamentLabel = new System.Windows.Forms.Label();
            this.loadExistingTournamentDropDown = new System.Windows.Forms.ComboBox();
            this.loadTournamentbutton = new System.Windows.Forms.Button();
            this.createTournamentbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.headerLabel.Location = new System.Drawing.Point(82, 16);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(385, 50);
            this.headerLabel.TabIndex = 15;
            this.headerLabel.Text = "Tournament Dashboard";
            // 
            // loadExistingTournamentLabel
            // 
            this.loadExistingTournamentLabel.AutoSize = true;
            this.loadExistingTournamentLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadExistingTournamentLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.loadExistingTournamentLabel.Location = new System.Drawing.Point(129, 88);
            this.loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
            this.loadExistingTournamentLabel.Size = new System.Drawing.Size(290, 32);
            this.loadExistingTournamentLabel.TabIndex = 19;
            this.loadExistingTournamentLabel.Text = "Load Existing Tournament";
            // 
            // loadExistingTournamentDropDown
            // 
            this.loadExistingTournamentDropDown.FormattingEnabled = true;
            this.loadExistingTournamentDropDown.Location = new System.Drawing.Point(109, 124);
            this.loadExistingTournamentDropDown.Name = "loadExistingTournamentDropDown";
            this.loadExistingTournamentDropDown.Size = new System.Drawing.Size(330, 38);
            this.loadExistingTournamentDropDown.TabIndex = 18;
            // 
            // loadTournamentbutton
            // 
            this.loadTournamentbutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.loadTournamentbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.loadTournamentbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.loadTournamentbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadTournamentbutton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadTournamentbutton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.loadTournamentbutton.Location = new System.Drawing.Point(150, 185);
            this.loadTournamentbutton.Name = "loadTournamentbutton";
            this.loadTournamentbutton.Size = new System.Drawing.Size(248, 41);
            this.loadTournamentbutton.TabIndex = 29;
            this.loadTournamentbutton.Text = "Load Tournament";
            this.loadTournamentbutton.UseVisualStyleBackColor = true;
            // 
            // createTournamentbutton
            // 
            this.createTournamentbutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamentbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.createTournamentbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.createTournamentbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentbutton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournamentbutton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.createTournamentbutton.Location = new System.Drawing.Point(140, 258);
            this.createTournamentbutton.Name = "createTournamentbutton";
            this.createTournamentbutton.Size = new System.Drawing.Size(269, 84);
            this.createTournamentbutton.TabIndex = 30;
            this.createTournamentbutton.Text = "Create Tournament";
            this.createTournamentbutton.UseVisualStyleBackColor = true;
            // 
            // frmTournamentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(560, 373);
            this.Controls.Add(this.createTournamentbutton);
            this.Controls.Add(this.loadTournamentbutton);
            this.Controls.Add(this.loadExistingTournamentLabel);
            this.Controls.Add(this.loadExistingTournamentDropDown);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.Name = "frmTournamentDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tournament Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label loadExistingTournamentLabel;
        private System.Windows.Forms.ComboBox loadExistingTournamentDropDown;
        private System.Windows.Forms.Button loadTournamentbutton;
        private System.Windows.Forms.Button createTournamentbutton;
    }
}