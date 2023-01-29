using System.Diagnostics;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Stopwatch sw;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             sw = new Stopwatch();
        }

        delegate void DeligProcess();
        delegate void DeligProcess1();
        private void CounterUpdate()
        {
            DeligProcess process = new DeligProcess(Counter);
            this.Invoke(process);
            return;
        }
        private void TimerUpdate()
        {
            DeligProcess1 process = new DeligProcess1(CTimer);
            this.Invoke(process);
            return;
        }
        private void BT_ButtonA_Click(object sender, EventArgs e)
        {
            LB_ToUpper.Text = TB_Box1.Text.ToUpper();
            LB_ToLower.Text = TB_Box1.Text.ToLower();
            BT_ButtonA.Enabled = false;

            Task task = Task.Run(() =>
            {
                CounterUpdate();
            });

            Task task1 = Task.Run(() =>
            {
                TimerUpdate();
            });
        }

        public async void Counter()
        {
            int counterValue;
            try
            {
                counterValue = Convert.ToInt32(TB_Box1.Text);
            }
            catch(Exception ex)
            {
                counterValue = 50;
            }
            for (int i = 0; i < counterValue; i++)
            {
                await Task.Delay(100);
                LB_Counter.Text = i.ToString();
            }
            TB_Box1.Text = "Counter end";
            BT_ButtonA.Enabled = true;
            sw.Stop();
            LB_Timer.Text = sw.Elapsed.ToString();
        }

        public async void CTimer()
        {   
            if(LB_Timer.Text.Equals("timer"))
            {
                sw.Start();
            }
            else
            {
                sw.Restart();
            }
        }
    }
}