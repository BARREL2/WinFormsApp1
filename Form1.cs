using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Stopwatch sw;
        private IInstrument _selectedInstrument;

        public Form1()
        {
            InitializeComponent();
            // コンボボックスに機種名を追加
            comboBox1.Items.Add("Instrument1");
            comboBox1.Items.Add("Instrument2");
        }

        private delegate void DeligProcess();

        private delegate void DeligProcess1();

        public async void Counter()
        {
            int counterValue;
            try
            {
                counterValue = Convert.ToInt32(TB_Box1.Text);
            }
            catch (Exception ex)
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
            if (LB_Timer.Text.Equals("timer"))
            {
                sw.Start();
            }
            else
            {
                sw.Restart();
            }
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

        private void CounterUpdate()
        {
            DeligProcess process = new DeligProcess(Counter);
            this.Invoke(process);
            return;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sw = new Stopwatch();
        }

        private void TimerUpdate()
        {
            DeligProcess1 process = new DeligProcess1(CTimer);
            this.Invoke(process);
            return;
        }

        private string folderPath;

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog.SelectedPath;
            }
        }

        private void Csv_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(folderPath))
            {
                string fileName = textBox2.Text + textBox3.Text + ".csv";
                string filePath = Path.Combine(folderPath, fileName);

                if (File.Exists(filePath))
                {
                    MessageBox.Show("同じ名前のファイルが既に存在します。別のファイル名を使用してください。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (StreamWriter streamWriter = new StreamWriter(filePath))
                {
                    streamWriter.WriteLine(textBox1.Text);
                }
                textBox3.Text = (int.Parse(textBox3.Text) + 1).ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 選択された機種に応じて、対応するクラスを生成
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Instrument1":
                    _selectedInstrument = new Instrument1();
                    break;

                case "Instrument2":
                    _selectedInstrument = new Instrument2();
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 選択された機種に応じて計測処理を実行
            var result = _selectedInstrument.Measure();
            MessageBox.Show(result);
        }
    }
}