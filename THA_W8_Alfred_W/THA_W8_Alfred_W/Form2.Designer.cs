namespace THA_W8_Alfred_W
{
    partial class Form2
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
            this.cmb_Player = new System.Windows.Forms.ComboBox();
            this.cmb_Team = new System.Windows.Forms.ComboBox();
            this.lbl_choosePlayer = new System.Windows.Forms.Label();
            this.lbl_chooseTeam = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_team = new System.Windows.Forms.Label();
            this.lbl_pos = new System.Windows.Forms.Label();
            this.lbl_nationality = new System.Windows.Forms.Label();
            this.lbl_playpos = new System.Windows.Forms.Label();
            this.lbl_yellow = new System.Windows.Forms.Label();
            this.lbl_red = new System.Windows.Forms.Label();
            this.lbl_penalty = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.team = new System.Windows.Forms.Label();
            this.position = new System.Windows.Forms.Label();
            this.nationality = new System.Windows.Forms.Label();
            this.cardyellow = new System.Windows.Forms.Label();
            this.cardred = new System.Windows.Forms.Label();
            this.goal = new System.Windows.Forms.Label();
            this.penaltymiss = new System.Windows.Forms.Label();
            this.lbl_num = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.Label();
            this.lbl_go = new System.Windows.Forms.Label();
            this.owngoal = new System.Windows.Forms.Label();
            this.lbl_gp = new System.Windows.Forms.Label();
            this.goalpenalty = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_Player
            // 
            this.cmb_Player.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Player.FormattingEnabled = true;
            this.cmb_Player.Location = new System.Drawing.Point(609, 61);
            this.cmb_Player.Name = "cmb_Player";
            this.cmb_Player.Size = new System.Drawing.Size(151, 24);
            this.cmb_Player.TabIndex = 7;
            this.cmb_Player.SelectionChangeCommitted += new System.EventHandler(this.cmb_Player_SelectionChangeCommitted);
            // 
            // cmb_Team
            // 
            this.cmb_Team.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Team.FormattingEnabled = true;
            this.cmb_Team.Location = new System.Drawing.Point(244, 61);
            this.cmb_Team.Name = "cmb_Team";
            this.cmb_Team.Size = new System.Drawing.Size(139, 24);
            this.cmb_Team.TabIndex = 6;
            this.cmb_Team.SelectionChangeCommitted += new System.EventHandler(this.cmb_Team_SelectionChangeCommitted);
            // 
            // lbl_choosePlayer
            // 
            this.lbl_choosePlayer.AutoSize = true;
            this.lbl_choosePlayer.Location = new System.Drawing.Point(504, 64);
            this.lbl_choosePlayer.Name = "lbl_choosePlayer";
            this.lbl_choosePlayer.Size = new System.Drawing.Size(99, 16);
            this.lbl_choosePlayer.TabIndex = 5;
            this.lbl_choosePlayer.Text = "Choose Player:";
            // 
            // lbl_chooseTeam
            // 
            this.lbl_chooseTeam.AutoSize = true;
            this.lbl_chooseTeam.Location = new System.Drawing.Point(142, 64);
            this.lbl_chooseTeam.Name = "lbl_chooseTeam";
            this.lbl_chooseTeam.Size = new System.Drawing.Size(96, 16);
            this.lbl_chooseTeam.TabIndex = 4;
            this.lbl_chooseTeam.Text = "Choose Team:";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(116, 121);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(160, 25);
            this.lbl_title.TabIndex = 8;
            this.lbl_title.Text = "PLAYER DATA";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(118, 172);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(47, 16);
            this.lbl_name.TabIndex = 9;
            this.lbl_name.Text = "Name:";
            // 
            // lbl_team
            // 
            this.lbl_team.AutoSize = true;
            this.lbl_team.Location = new System.Drawing.Point(118, 212);
            this.lbl_team.Name = "lbl_team";
            this.lbl_team.Size = new System.Drawing.Size(46, 16);
            this.lbl_team.TabIndex = 10;
            this.lbl_team.Text = "Team:";
            // 
            // lbl_pos
            // 
            this.lbl_pos.AutoSize = true;
            this.lbl_pos.Location = new System.Drawing.Point(118, 255);
            this.lbl_pos.Name = "lbl_pos";
            this.lbl_pos.Size = new System.Drawing.Size(58, 16);
            this.lbl_pos.TabIndex = 11;
            this.lbl_pos.Text = "Position:";
            // 
            // lbl_nationality
            // 
            this.lbl_nationality.AutoSize = true;
            this.lbl_nationality.Location = new System.Drawing.Point(118, 297);
            this.lbl_nationality.Name = "lbl_nationality";
            this.lbl_nationality.Size = new System.Drawing.Size(73, 16);
            this.lbl_nationality.TabIndex = 12;
            this.lbl_nationality.Text = "Nationality:";
            // 
            // lbl_playpos
            // 
            this.lbl_playpos.AutoSize = true;
            this.lbl_playpos.Location = new System.Drawing.Point(494, 172);
            this.lbl_playpos.Name = "lbl_playpos";
            this.lbl_playpos.Size = new System.Drawing.Size(89, 16);
            this.lbl_playpos.TabIndex = 13;
            this.lbl_playpos.Text = "Yellow Cards:";
            // 
            // lbl_yellow
            // 
            this.lbl_yellow.AutoSize = true;
            this.lbl_yellow.Location = new System.Drawing.Point(494, 212);
            this.lbl_yellow.Name = "lbl_yellow";
            this.lbl_yellow.Size = new System.Drawing.Size(75, 16);
            this.lbl_yellow.TabIndex = 14;
            this.lbl_yellow.Text = "Red Cards:";
            // 
            // lbl_red
            // 
            this.lbl_red.AutoSize = true;
            this.lbl_red.Location = new System.Drawing.Point(494, 255);
            this.lbl_red.Name = "lbl_red";
            this.lbl_red.Size = new System.Drawing.Size(86, 16);
            this.lbl_red.TabIndex = 15;
            this.lbl_red.Text = "Goal Scored:";
            // 
            // lbl_penalty
            // 
            this.lbl_penalty.AutoSize = true;
            this.lbl_penalty.Location = new System.Drawing.Point(494, 297);
            this.lbl_penalty.Name = "lbl_penalty";
            this.lbl_penalty.Size = new System.Drawing.Size(86, 16);
            this.lbl_penalty.TabIndex = 16;
            this.lbl_penalty.Text = "Penalty Miss:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(197, 172);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(42, 16);
            this.name.TabIndex = 17;
            this.name.Text = "_____";
            // 
            // team
            // 
            this.team.AutoSize = true;
            this.team.Location = new System.Drawing.Point(197, 212);
            this.team.Name = "team";
            this.team.Size = new System.Drawing.Size(42, 16);
            this.team.TabIndex = 18;
            this.team.Text = "_____";
            // 
            // position
            // 
            this.position.AutoSize = true;
            this.position.Location = new System.Drawing.Point(197, 255);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(42, 16);
            this.position.TabIndex = 19;
            this.position.Text = "_____";
            // 
            // nationality
            // 
            this.nationality.AutoSize = true;
            this.nationality.Location = new System.Drawing.Point(197, 297);
            this.nationality.Name = "nationality";
            this.nationality.Size = new System.Drawing.Size(42, 16);
            this.nationality.TabIndex = 20;
            this.nationality.Text = "_____";
            // 
            // cardyellow
            // 
            this.cardyellow.AutoSize = true;
            this.cardyellow.Location = new System.Drawing.Point(589, 172);
            this.cardyellow.Name = "cardyellow";
            this.cardyellow.Size = new System.Drawing.Size(42, 16);
            this.cardyellow.TabIndex = 21;
            this.cardyellow.Text = "_____";
            // 
            // cardred
            // 
            this.cardred.AutoSize = true;
            this.cardred.Location = new System.Drawing.Point(589, 212);
            this.cardred.Name = "cardred";
            this.cardred.Size = new System.Drawing.Size(42, 16);
            this.cardred.TabIndex = 22;
            this.cardred.Text = "_____";
            // 
            // goal
            // 
            this.goal.AutoSize = true;
            this.goal.Location = new System.Drawing.Point(589, 255);
            this.goal.Name = "goal";
            this.goal.Size = new System.Drawing.Size(42, 16);
            this.goal.TabIndex = 23;
            this.goal.Text = "_____";
            // 
            // penaltymiss
            // 
            this.penaltymiss.AutoSize = true;
            this.penaltymiss.Location = new System.Drawing.Point(589, 297);
            this.penaltymiss.Name = "penaltymiss";
            this.penaltymiss.Size = new System.Drawing.Size(42, 16);
            this.penaltymiss.TabIndex = 24;
            this.penaltymiss.Text = "_____";
            // 
            // lbl_num
            // 
            this.lbl_num.AutoSize = true;
            this.lbl_num.Location = new System.Drawing.Point(118, 337);
            this.lbl_num.Name = "lbl_num";
            this.lbl_num.Size = new System.Drawing.Size(58, 16);
            this.lbl_num.TabIndex = 25;
            this.lbl_num.Text = "Number:";
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Location = new System.Drawing.Point(197, 337);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(42, 16);
            this.number.TabIndex = 26;
            this.number.Text = "_____";
            // 
            // lbl_go
            // 
            this.lbl_go.AutoSize = true;
            this.lbl_go.Location = new System.Drawing.Point(494, 376);
            this.lbl_go.Name = "lbl_go";
            this.lbl_go.Size = new System.Drawing.Size(68, 16);
            this.lbl_go.TabIndex = 27;
            this.lbl_go.Text = "Own Goal:";
            // 
            // owngoal
            // 
            this.owngoal.AutoSize = true;
            this.owngoal.Location = new System.Drawing.Point(589, 376);
            this.owngoal.Name = "owngoal";
            this.owngoal.Size = new System.Drawing.Size(42, 16);
            this.owngoal.TabIndex = 28;
            this.owngoal.Text = "_____";
            // 
            // lbl_gp
            // 
            this.lbl_gp.AutoSize = true;
            this.lbl_gp.Location = new System.Drawing.Point(493, 337);
            this.lbl_gp.Name = "lbl_gp";
            this.lbl_gp.Size = new System.Drawing.Size(87, 16);
            this.lbl_gp.TabIndex = 29;
            this.lbl_gp.Text = "Goal Penalty:";
            // 
            // goalpenalty
            // 
            this.goalpenalty.AutoSize = true;
            this.goalpenalty.Location = new System.Drawing.Point(589, 337);
            this.goalpenalty.Name = "goalpenalty";
            this.goalpenalty.Size = new System.Drawing.Size(42, 16);
            this.goalpenalty.TabIndex = 30;
            this.goalpenalty.Text = "_____";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 502);
            this.Controls.Add(this.goalpenalty);
            this.Controls.Add(this.lbl_gp);
            this.Controls.Add(this.owngoal);
            this.Controls.Add(this.lbl_go);
            this.Controls.Add(this.number);
            this.Controls.Add(this.lbl_num);
            this.Controls.Add(this.penaltymiss);
            this.Controls.Add(this.goal);
            this.Controls.Add(this.cardred);
            this.Controls.Add(this.cardyellow);
            this.Controls.Add(this.nationality);
            this.Controls.Add(this.position);
            this.Controls.Add(this.team);
            this.Controls.Add(this.name);
            this.Controls.Add(this.lbl_penalty);
            this.Controls.Add(this.lbl_red);
            this.Controls.Add(this.lbl_yellow);
            this.Controls.Add(this.lbl_playpos);
            this.Controls.Add(this.lbl_nationality);
            this.Controls.Add(this.lbl_pos);
            this.Controls.Add(this.lbl_team);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.cmb_Player);
            this.Controls.Add(this.cmb_Team);
            this.Controls.Add(this.lbl_choosePlayer);
            this.Controls.Add(this.lbl_chooseTeam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Player Data";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Player;
        private System.Windows.Forms.ComboBox cmb_Team;
        private System.Windows.Forms.Label lbl_choosePlayer;
        private System.Windows.Forms.Label lbl_chooseTeam;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_team;
        private System.Windows.Forms.Label lbl_pos;
        private System.Windows.Forms.Label lbl_nationality;
        private System.Windows.Forms.Label lbl_playpos;
        private System.Windows.Forms.Label lbl_yellow;
        private System.Windows.Forms.Label lbl_red;
        private System.Windows.Forms.Label lbl_penalty;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label team;
        private System.Windows.Forms.Label position;
        private System.Windows.Forms.Label nationality;
        private System.Windows.Forms.Label cardyellow;
        private System.Windows.Forms.Label cardred;
        private System.Windows.Forms.Label goal;
        private System.Windows.Forms.Label penaltymiss;
        private System.Windows.Forms.Label lbl_num;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.Label lbl_go;
        private System.Windows.Forms.Label owngoal;
        private System.Windows.Forms.Label lbl_gp;
        private System.Windows.Forms.Label goalpenalty;
    }
}