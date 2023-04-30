using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace THA_W8_Alfred_W
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string connection, sqlQuery, match, home, away, date, team1, team2, matchID;
        MySqlConnection sqlConn;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        DataTable dtAllMatch;

        private void cmb_match_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable dtMatch = new DataTable();
            dtMatch.Columns.Add("Minute");
            dtMatch.Columns.Add("Team Name");
            dtMatch.Columns.Add("Player Name");
            dtMatch.Columns.Add("Type");
            for(int i = 0; i < dtAllMatch.Rows.Count; i++)
            {
                home = dtAllMatch.Rows[i][2].ToString();
                away = dtAllMatch.Rows[i][3].ToString();
                date = dtAllMatch.Rows[i][1].ToString();
                matchID = dtAllMatch.Rows[i][0].ToString();
                match = home + " vs " + away + ", on " + date + ", " + matchID;
                if (cmb_match.Text == match)
                {
                    dtMatch.Rows.Add(dtAllMatch.Rows[i][5].ToString(), dtAllMatch.Rows[i][4].ToString(), dtAllMatch.Rows[i][6].ToString(), dtAllMatch.Rows[i][7].ToString());
                    team1 = home;
                    team2 = away;
                }
            }
            dgv_match.DataSource = dtMatch;

            DataTable dtHome = new DataTable();
            sqlQuery = $"select t.team_name as 'Team Name', p.player_name as 'Player Name', p.playing_pos as 'Position' from team t, player p where t.team_id = p.team_id and t.team_name = '{team1}' order by 2 asc";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConn);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtHome);
            dgv_players1.DataSource = dtHome;

            DataTable dtAway = new DataTable();
            sqlQuery = $"select t.team_name as 'Team Name', p.player_name as 'Player Name', p.playing_pos as 'Position' from team t, player p where t.team_id = p.team_id and t.team_name = '{team2}' order by 2 asc";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConn);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtAway);
            dgv_players2.DataSource = dtAway;
        }

        private void cmb_team_SelectionChangeCommitted(object sender, EventArgs e)
        {
            for(int i = 0; i < dtAllMatch.Rows.Count; i++)
            {
                home = dtAllMatch.Rows[i][2].ToString();
                away = dtAllMatch.Rows[i][3].ToString();
                date = dtAllMatch.Rows[i][1].ToString();
                matchID = dtAllMatch.Rows[i][0].ToString();
                match = home + " vs " + away + ", on " + date + ", " + matchID;
                if (!cmb_match.Items.Contains(match) && (cmb_team.Text == home || cmb_team.Text == away))
                {
                    cmb_match.Items.Add(match);
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dtAllMatch = new DataTable();
            connection = "server=localhost;uid=root;pwd=;database=premier_league";
            sqlConn = new MySqlConnection(connection);

            sqlQuery = "select m.match_id, m.match_date, t1.team_name as 'team_home', t2.team_name as 'team_away', if(dm.team_id = t1.team_id, t1.team_name, t2.team_name) as 'team_name', dm.`minute`, p.player_name, if(dm.`type` = 'CY', \"Yellow Card\", if(dm.`type` = 'CR', \"Red Card\", if(dm.`type` = 'GO', \"Goal Scored\", if(dm.`type` = 'PM', \"Penalty Miss\", if(dm.`type` = 'GP', \"Penalty Goal\", \"Own Goal\"))))) as 'Type' from `match` m inner join team t1 on t1.team_id = m.team_home inner join team t2 on t2.team_id = m.team_away inner join dmatch dm on m.match_id = dm.match_id inner join player p on p.player_id = dm.player_id order by 1 asc;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConn);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtAllMatch);

            for(int i = 0; i < dtAllMatch.Rows.Count; i++)
            {
                if (!cmb_team.Items.Contains(dtAllMatch.Rows[i][3].ToString()))
                {
                    cmb_team.Items.Add(dtAllMatch.Rows[i][3].ToString());
                }
                else if (!cmb_team.Items.Contains(dtAllMatch.Rows[i][4].ToString()))
                {
                    cmb_team.Items.Add(dtAllMatch.Rows[i][4].ToString());
                }
            }
            cmb_team.Sorted = true;
        }
    }
}
