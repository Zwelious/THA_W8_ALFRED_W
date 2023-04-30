namespace THA_W8_Alfred_W
{
    partial class Form3
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
            this.lbl_pick = new System.Windows.Forms.Label();
            this.cmb_team = new System.Windows.Forms.ComboBox();
            this.lbl_pickmatch = new System.Windows.Forms.Label();
            this.cmb_match = new System.Windows.Forms.ComboBox();
            this.lbl_details = new System.Windows.Forms.Label();
            this.dgv_match = new System.Windows.Forms.DataGridView();
            this.lbl_team1 = new System.Windows.Forms.Label();
            this.lbl_team2 = new System.Windows.Forms.Label();
            this.dgv_players1 = new System.Windows.Forms.DataGridView();
            this.dgv_players2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_match)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_players1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_players2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_pick
            // 
            this.lbl_pick.AutoSize = true;
            this.lbl_pick.Location = new System.Drawing.Point(242, 41);
            this.lbl_pick.Name = "lbl_pick";
            this.lbl_pick.Size = new System.Drawing.Size(80, 16);
            this.lbl_pick.TabIndex = 5;
            this.lbl_pick.Text = "Pick a team:";
            // 
            // cmb_team
            // 
            this.cmb_team.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_team.FormattingEnabled = true;
            this.cmb_team.Location = new System.Drawing.Point(368, 38);
            this.cmb_team.Name = "cmb_team";
            this.cmb_team.Size = new System.Drawing.Size(211, 24);
            this.cmb_team.TabIndex = 6;
            this.cmb_team.SelectionChangeCommitted += new System.EventHandler(this.cmb_team_SelectionChangeCommitted);
            // 
            // lbl_pickmatch
            // 
            this.lbl_pickmatch.AutoSize = true;
            this.lbl_pickmatch.Location = new System.Drawing.Point(131, 100);
            this.lbl_pickmatch.Name = "lbl_pickmatch";
            this.lbl_pickmatch.Size = new System.Drawing.Size(86, 16);
            this.lbl_pickmatch.TabIndex = 7;
            this.lbl_pickmatch.Text = "Pick a match:";
            // 
            // cmb_match
            // 
            this.cmb_match.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_match.FormattingEnabled = true;
            this.cmb_match.Location = new System.Drawing.Point(223, 97);
            this.cmb_match.Name = "cmb_match";
            this.cmb_match.Size = new System.Drawing.Size(540, 24);
            this.cmb_match.TabIndex = 8;
            this.cmb_match.SelectionChangeCommitted += new System.EventHandler(this.cmb_match_SelectionChangeCommitted);
            // 
            // lbl_details
            // 
            this.lbl_details.AutoSize = true;
            this.lbl_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_details.Location = new System.Drawing.Point(12, 152);
            this.lbl_details.Name = "lbl_details";
            this.lbl_details.Size = new System.Drawing.Size(101, 16);
            this.lbl_details.TabIndex = 9;
            this.lbl_details.Text = "Match Details";
            // 
            // dgv_match
            // 
            this.dgv_match.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_match.Location = new System.Drawing.Point(12, 180);
            this.dgv_match.Name = "dgv_match";
            this.dgv_match.RowHeadersWidth = 51;
            this.dgv_match.RowTemplate.Height = 24;
            this.dgv_match.Size = new System.Drawing.Size(399, 316);
            this.dgv_match.TabIndex = 10;
            // 
            // lbl_team1
            // 
            this.lbl_team1.AutoSize = true;
            this.lbl_team1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_team1.Location = new System.Drawing.Point(414, 152);
            this.lbl_team1.Name = "lbl_team1";
            this.lbl_team1.Size = new System.Drawing.Size(105, 16);
            this.lbl_team1.TabIndex = 11;
            this.lbl_team1.Text = "Home Players";
            // 
            // lbl_team2
            // 
            this.lbl_team2.AutoSize = true;
            this.lbl_team2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_team2.Location = new System.Drawing.Point(418, 332);
            this.lbl_team2.Name = "lbl_team2";
            this.lbl_team2.Size = new System.Drawing.Size(101, 16);
            this.lbl_team2.TabIndex = 12;
            this.lbl_team2.Text = "Away Players";
            // 
            // dgv_players1
            // 
            this.dgv_players1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_players1.Location = new System.Drawing.Point(417, 180);
            this.dgv_players1.Name = "dgv_players1";
            this.dgv_players1.RowHeadersWidth = 51;
            this.dgv_players1.RowTemplate.Height = 24;
            this.dgv_players1.Size = new System.Drawing.Size(481, 149);
            this.dgv_players1.TabIndex = 13;
            // 
            // dgv_players2
            // 
            this.dgv_players2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_players2.Location = new System.Drawing.Point(417, 351);
            this.dgv_players2.Name = "dgv_players2";
            this.dgv_players2.RowHeadersWidth = 51;
            this.dgv_players2.RowTemplate.Height = 24;
            this.dgv_players2.Size = new System.Drawing.Size(481, 145);
            this.dgv_players2.TabIndex = 14;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 522);
            this.Controls.Add(this.dgv_players2);
            this.Controls.Add(this.dgv_players1);
            this.Controls.Add(this.lbl_team2);
            this.Controls.Add(this.lbl_team1);
            this.Controls.Add(this.dgv_match);
            this.Controls.Add(this.lbl_details);
            this.Controls.Add(this.cmb_match);
            this.Controls.Add(this.lbl_pickmatch);
            this.Controls.Add(this.cmb_team);
            this.Controls.Add(this.lbl_pick);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Match Details";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_match)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_players1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_players2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_pick;
        private System.Windows.Forms.ComboBox cmb_team;
        private System.Windows.Forms.Label lbl_pickmatch;
        private System.Windows.Forms.ComboBox cmb_match;
        private System.Windows.Forms.Label lbl_details;
        private System.Windows.Forms.DataGridView dgv_match;
        private System.Windows.Forms.Label lbl_team1;
        private System.Windows.Forms.Label lbl_team2;
        private System.Windows.Forms.DataGridView dgv_players1;
        private System.Windows.Forms.DataGridView dgv_players2;
    }
}