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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string connection, sqlQuery;
        MySqlConnection sqlConn;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        DataTable dtPemain;
        public static List<string> listTeam;

        private void cmb_Team_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmb_Player.Items.Clear();
            for (int i = 0; i < dtPemain.Rows.Count; i++)
            {
                if (!cmb_Player.Items.Contains(dtPemain.Rows[i][0].ToString()) && (cmb_Team.Text == dtPemain.Rows[i][1].ToString()))
                {
                    cmb_Player.Items.Add(dtPemain.Rows[i][0].ToString());
                }
            }
        }

        private void cmb_Player_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable dtType = new DataTable();
            sqlQuery = $"select dmatch.type from dmatch, player where dmatch.player_id = player.player_id and player.player_name = '{cmb_Player.Text}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConn);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtType);
            string player = cmb_Player.Text;
            int cy = 0;
            int cr = 0;
            int gw = 0;
            int pm = 0;
            int gp = 0;
            int go = 0;
            for (int i = 0; i < dtPemain.Rows.Count; i++)
            {
                if (dtPemain.Rows[i][0].ToString() == player)
                {
                    name.Text = dtPemain.Rows[i][0].ToString();
                    team.Text = dtPemain.Rows[i][1].ToString();
                    position.Text = dtPemain.Rows[i][2].ToString();
                    nationality.Text = dtPemain.Rows[i][3].ToString();
                    number.Text = dtPemain.Rows[i][4].ToString();
                    for(int j = 0; j < dtType.Rows.Count; j++)
                    {
                        switch (dtType.Rows[j][0].ToString())
                        {
                            case "CY":
                                cy++;
                                break;
                            case "CR":
                                cr++;
                                break;
                            case "GO":
                                go++;
                                break;
                            case "PM":
                                pm++;
                                break;
                            case "GP":
                                gp++;
                                break;
                            case "GW":
                                gw++;
                                break;
                            default:
                                break;
                        }
                    } 
                }
                cardyellow.Text = cy.ToString();
                cardred.Text = cr.ToString();
                goal.Text = go.ToString();
                penaltymiss.Text = pm.ToString();
                goalpenalty.Text = gp.ToString();
                owngoal.Text = gw.ToString();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listTeam = new List<string>();
            dtPemain = new DataTable();
            connection = "server=localhost;uid=root;pwd=;database=premier_league";
            sqlConn = new MySqlConnection(connection);

            sqlQuery = "select p.player_name, t.team_name, p.playing_pos, n.nation, p.team_number from player p, team t, nationality n where p.team_id = t.team_id and p.nationality_id = n.nationality_id order by 2 asc, 1 asc;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConn);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPemain);

            for (int i = 0; i < dtPemain.Rows.Count; i++)
            {
                if (!cmb_Team.Items.Contains(dtPemain.Rows[i][1].ToString()))
                {
                    cmb_Team.Items.Add(dtPemain.Rows[i][1].ToString());
                    listTeam.Add(dtPemain.Rows[i][1].ToString());
                }
            }
        }
    }
}
