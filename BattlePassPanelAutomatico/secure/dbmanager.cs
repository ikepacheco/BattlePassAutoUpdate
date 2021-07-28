using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BattlePassPanelAutomatico.secure
{
    class dbmanager
    {
        static SqlConnection cn;
        static SqlCommand cmd;

        public dbmanager()
        {
            cn = new SqlConnection();
            cn.ConnectionString = @"Server=" + variables.server + ";Database=" + variables.database + ";Trusted_Connection=True;";
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
        }
        public void GetChars(DataGridView dataGridView2)
        {
            dataGridView2.Rows.Clear();
            int i = 0;
            try
            {
                cmd.CommandText = "select AID, CID, Name, XP from Character where DeleteFlag = 0 order by AID asc";
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        dataGridView2.Rows.Add(dr.GetInt32(0), dr.GetInt32(1), dr.GetString(2), dr.GetInt32(3), dr.GetInt32(3), 0);
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public void GetAccs(DataGridView dataGridView1)
        {
            dataGridView1.Rows.Clear();
            int i = 0;
            try
            {
                cmd.CommandText = "select AID, UserID, UGradeID, BattlePass, BattlePassPoints, RedColor,GreenColor, BlueColor from Account order by AID asc";
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        dataGridView1.Rows.Add(dr.GetInt32(0), dr.GetString(1), dr.GetInt32(2), dr.GetInt32(3), dr.GetInt32(4), dr.GetString(1));
                        dataGridView1.Rows[i].Cells["ColorName"].Style.ForeColor = Color.FromArgb(dr.GetInt32(5), dr.GetInt32(6), dr.GetInt32(7));
                        dataGridView1.Rows[i].Cells["ColorName"].Style.BackColor = Color.FromArgb(dr.GetInt32(5) ^ 100, dr.GetInt32(6) ^ 100, dr.GetInt32(7) ^ 100);
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public void GetXP_OLD(DataGridView dataGridView2)
        {
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                dataGridView2.Rows[i].Cells["XP_OLD"].Value = dataGridView2.Rows[i].Cells["XP"].Value;
            }
        }
        public void GetXP_REST(DataGridView dataGridView2)
        {
            int i = 0;
            for (i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                    dataGridView2.Rows[i].Cells["XP_REST"].Value = int.Parse(dataGridView2.Rows[i].Cells["XP"].Value.ToString()) - int.Parse(dataGridView2.Rows[i].Cells["XP_OLD"].Value.ToString());
            }
        }
        public void SQL_Update_BPP (DataGridView dataGridView2)
        {
            int XP = 0;
            int AID = 0;
            try
            {
                int i = 0;
                for (i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {
                    cmd.Parameters.Clear();
                    XP = int.Parse(dataGridView2.Rows[i].Cells["XP_REST"].Value.ToString());
                    AID = int.Parse(dataGridView2.Rows[i].Cells["_AID"].Value.ToString());
                    if(XP <= 0)
                    {
                        cmd.CommandText = @"update Account set BattlePassPoints = BattlePassPoints where AID = @AID AND BattlePass = 1";
                    }
                    else
                    {
                        cmd.CommandText = @"update Account set BattlePassPoints = (BattlePassPoints + (@XP / 20)) where AID = @AID AND BattlePass = 1";
                    }

                    cmd.Parameters.AddWithValue("@XP", XP);
                    cmd.Parameters.AddWithValue("@AID", AID);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void UpdateXP_CHAR(DataGridView dataGridView2)
        {
            int i = 0;
            try
            {
                cmd.CommandText = "select XP from Character where DeleteFlag = 0 order by AID asc";
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        dataGridView2.Rows[i].Cells["XP"].Value = dr.GetInt32(0);
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public void UpdateXP_OLD(DataGridView dataGridView2)
        {
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                dataGridView2.Rows[i].Cells["XP_OLD"].Value = dataGridView2.Rows[i].Cells["XP"].Value.ToString() ;
            }
        }
    }
}
