using System;
using System.Drawing;
using System.Windows.Forms;
using BattlePassPanelAutomatico.secure;

namespace BattlePassPanelAutomatico
{
    public partial class Content : Form
    {
        dbmanager cf = new dbmanager();
        public Content()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label_time.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            cf.GetChars(dataGridView2);
            cf.GetAccs(dataGridView1);
            cf.GetXP_OLD(dataGridView2);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cf.UpdateXP_CHAR(dataGridView2);
            cf.GetXP_REST(dataGridView2);
            cf.SQL_Update_BPP(dataGridView2);
            cf.UpdateXP_OLD(dataGridView2);
            
            
            
            cf.GetAccs(dataGridView1);
            cf.GetChars(dataGridView2);


        }

        private void Content_SizeChanged(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.BalloonTipText = "Background Application Manager";
                notifyIcon1.ShowBalloonTip(5000);
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void TimerAssis_Tick(object sender, EventArgs e)
        {
            cf.Update_Assistance();
            label_time.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
        }
    }
}
