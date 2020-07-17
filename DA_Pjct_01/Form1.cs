using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_Pjct_01
{
    public partial class Pepe01 : Form
    {
        //
        private class OutComeNTimes
        {
            public int _outcome = 0, _times = 0;
            public OutComeNTimes(int _oc=0,int tm=0) {
                _outcome = _oc;
                _times = tm;
            }
        }
        private class SortComparer : IComparer<OutComeNTimes> {
            public int Compare(OutComeNTimes a,OutComeNTimes b) {
                return (a._outcome - b._outcome);
            }
        }
        //
        private bool form_moving = false, EnterPressed = false;
        private int OrgLoct_frm_x = 0, OrgLoct_frm_y = 0, OrgLoct_Mus_x = 0, OrgLoct_Mus_y = 0,
            Trial_Times_01 = 0, Expe_Times_01 = 0,
            Trial_Times_02 = 0, Expe_Times_02 = 0;
        private List<OutComeNTimes> Gardevoir = new List<OutComeNTimes>(),Gengar = new List<OutComeNTimes>();
        private SortComparer SC = new SortComparer();
        private Color mainColor = Color.FromArgb(50, 50, 50), Color_01 = Color.FromArgb(125, 173, 255, 47), Color_02 = Color.FromArgb(125, 234, 70, 112);


        private Bernoulli_Machine BM_01 = new Bernoulli_Machine(0.5), BM_02 = new Bernoulli_Machine(0.5);

        public Pepe01()
        {
            InitializeComponent();
        }

        private void Exit_Button_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        private void Pepe01_MouseDown(object sender, MouseEventArgs e)
        {
            form_moving = true;

            OrgLoct_frm_x = this.Location.X;
            OrgLoct_frm_y = this.Location.Y;
            OrgLoct_Mus_x = MousePosition.X;
            OrgLoct_Mus_y = MousePosition.Y;
        }
        private void Pepe01_MouseUp(object sender, MouseEventArgs e)
        {
            form_moving = false;
        }
        private void Pepe01_MouseLeave(object sender, EventArgs e)
        {
            form_moving = false;
        }
        private void Pepe01_MouseMove(object sender, MouseEventArgs e)
        {
            if (form_moving)
                this.SetDesktopLocation(OrgLoct_frm_x + MousePosition.X - OrgLoct_Mus_x, OrgLoct_frm_y + MousePosition.Y - OrgLoct_Mus_y);
        }
        //
        private void Trial_01_Button_Click(object sender, EventArgs e)
        {
            Gardevoir.Clear();
            for (int i = 0; i < Expe_Times_01; i++)
            {
                int _count = BM_01.Trial(Trial_Times_01);
                int _index = Gardevoir.FindIndex(x => x._outcome == _count);

                if (_index >= 0) Gardevoir[_index]._times++;
                else Gardevoir.Add(new OutComeNTimes(_count, 1));
            }
            Gardevoir.Sort(SC);
            //
            this.Refresh();
        }
        private void Trial_Button_Click(object sender, EventArgs e)
        {
            Gengar.Clear();
            for (int i = 0; i < Expe_Times_02; i++)
            {
                int _count = BM_02.Trial(Trial_Times_02);
                int _index = Gengar.FindIndex(x => x._outcome == _count);

                if (_index >= 0) Gengar[_index]._times++;
                else Gengar.Add(new OutComeNTimes(_count, 1));
            }
            Gengar.Sort(SC);
            //
            this.Refresh();
        }
        //
        private void Theta_01_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') { EnterPressed = true; }
        }
        private void TrialTimes_01_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') { EnterPressed = true; }
        }
        private void ExpeTimes_01_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') { EnterPressed = true; }
        }

        private void Theta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') { EnterPressed = true; }
        }
        private void ExpeTimes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') { EnterPressed = true; }
        }
        private void TrialTimes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') { EnterPressed = true; }
        }
        //
        private void Theta_01_TextChanged(object sender, EventArgs e)
        {
            if (EnterPressed)
            {
                EnterPressed = false;
                Theta_01.Text = BM_01.Probability.ToString();
                label1.Focus();
                return;
            }

            try
            {
                double _prb = double.Parse(Theta_01.Text);
                //輸入為數字
                if (_prb >= 0 && _prb <= 1) BM_01.Probability = _prb;
            }
            catch { }
        }
        private void TrialTimes_01_TextChanged(object sender, EventArgs e)
        {
            if (EnterPressed)
            {
                EnterPressed = false;
                TrialTimes_01.Text = Trial_Times_01.ToString();
                label1.Focus();
                return;
            }

            try
            {
                int _trl = int.Parse(TrialTimes_01.Text);
                //輸入為數字
                if (_trl > 0) Trial_Times_01 = _trl;
            }
            catch { }
            TrialTimes_01.Text = Trial_Times_01.ToString();
        }
        private void ExpeTimes_01_TextChanged(object sender, EventArgs e)
        {
            if (EnterPressed)
            {
                EnterPressed = false;
                ExpeTimes_01.Text = Expe_Times_01.ToString();
                label1.Focus();
                return;
            }

            try
            {
                int _exp = int.Parse(ExpeTimes_01.Text);
                //輸入為數字
                if (_exp > 0) Expe_Times_01 = _exp;
            }
            catch { }
            ExpeTimes_01.Text = Expe_Times_01.ToString();
        }

        private void Theta_TextChanged(object sender, EventArgs e)
        {
            if (EnterPressed)
            {
                EnterPressed = false;
                Theta_02.Text = BM_02.Probability.ToString();
                label1.Focus();
                return;
            }

            try
            {
                double _prb = double.Parse(Theta_02.Text);
                //輸入為數字
                if (_prb >= 0 && _prb <= 1) BM_02.Probability = _prb;
            }
            catch { }
        }
        private void ExpeTimes_TextChanged(object sender, EventArgs e)
        {
            if (EnterPressed) {
                EnterPressed = false;
                ExpeTimes_02.Text = Expe_Times_02.ToString();
                label1.Focus();
                return;
            }

            try
            {
                int _exp = int.Parse(ExpeTimes_02.Text);
                //輸入為數字
                if (_exp > 0) Expe_Times_02 = _exp;
            }
            catch { }
            ExpeTimes_02.Text = Expe_Times_02.ToString();
        }
        private void TrialTimes_TextChanged(object sender, EventArgs e)
        {
            if (EnterPressed)
            {
                EnterPressed = false;
                TrialTimes_02.Text = Trial_Times_02.ToString();
                label1.Focus();
                return;
            }

            try
            {
                int _trl = int.Parse(TrialTimes_02.Text);
                //輸入為數字
                if (_trl > 0) Trial_Times_02 = _trl;
            }
            catch { }
            TrialTimes_02.Text = Trial_Times_02.ToString();
        }

        private void Pepe01_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics g = this.CreateGraphics())
            {
                g.Clear(this.BackColor);
                g.DrawLine(new Pen(mainColor, 3), new Point(20, 20), new Point(20, 421));
                g.DrawLine(new Pen(mainColor, 3), new Point(20, 421), new Point(1200, 421));
                //

                int minimum = 0, maximum = 0,x_crnt=40,y_crnt=420;
                SolidBrush brush_01 = new SolidBrush(Color_01), brush_02 = new SolidBrush(Color_02),brush_text =new SolidBrush(Color.FromArgb(195,49,237));
                Font _font=new Font("Andalus",10);

                if (Gardevoir.Count != 0)
                {
                    if (Gengar.Count != 0)
                    {
                        minimum = (Gardevoir[0]._outcome < Gengar[0]._outcome) ? Gardevoir[0]._outcome : Gengar[0]._outcome;
                        maximum =
                            (Gardevoir[Gardevoir.Count - 1]._outcome > Gengar[Gengar.Count - 1]._outcome) ? Gardevoir[Gardevoir.Count - 1]._outcome : Gengar[Gengar.Count - 1]._outcome;
                    }
                    else
                    {
                        minimum = Gardevoir[0]._outcome;
                        maximum = Gardevoir[Gardevoir.Count - 1]._outcome;
                    }
                }
                else if (Gengar.Count != 0)
                {
                    if (Gardevoir.Count != 0)
                    {
                        minimum = (Gardevoir[0]._outcome < Gengar[0]._outcome) ? Gardevoir[0]._outcome : Gengar[0]._outcome;
                        maximum =
                            (Gardevoir[Gardevoir.Count - 1]._outcome > Gengar[Gengar.Count - 1]._outcome) ? Gardevoir[Gardevoir.Count - 1]._outcome : Gengar[Gengar.Count - 1]._outcome;
                    }
                    minimum = Gengar[0]._outcome;
                    maximum = Gengar[Gengar.Count - 1]._outcome;
                }
                //
                for (int i = minimum; i <= maximum; i++)
                {
                    int _index = Gardevoir.FindIndex(x => x._outcome == i);
                    if (_index >= 0) g.FillRectangle(brush_01, x_crnt, (y_crnt - Gardevoir[_index]._times * 10), 14, (Gardevoir[_index]._times * 10));

                    int _index_02 = Gengar.FindIndex(x => x._outcome == i);
                    if (_index_02 >= 0) g.FillRectangle(brush_02, x_crnt, (y_crnt - Gengar[_index_02]._times * 10), 14, (Gengar[_index_02]._times * 10));

                    if (_index >= 0 || _index_02 >= 0)
                    {
                        g.DrawString(i.ToString(), _font, brush_text, new Point(x_crnt, y_crnt + 5));
                        x_crnt += 16;
                    }
                }
            }
        }      
    }
    public class Bernoulli_Machine {
        //
        private double _probability = 0.5;
        public Random RNG;
        //
        public Bernoulli_Machine(double prb) {
            if (prb >= 0 && prb <= 1) _probability = prb;
            RNG = new Random(Guid.NewGuid().GetHashCode()); //Thanks for internet :D
        }
        public int Trial(int t_times) { 
            int success_outcomes=0;
            for (int i = 0; i < t_times; i++) {
                if (RNG.NextDouble() < _probability) success_outcomes++;
            }
            return success_outcomes;
        }
        public double Probability {
            set {
                if (value > 0 && value <= 1) _probability = value;   
            }
            get {
                return _probability;
            }
        }
    }
}
