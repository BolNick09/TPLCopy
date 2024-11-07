using System;
using System.Threading;
using System.Threading.Tasks;

namespace TPLCopy
{
    public partial class FrmCopy : Form
    {
        public FrmCopy()
        {
            InitializeComponent();
        }

        List<Task> tasks;
        List<ProgressBar> progressBars;

        private void FrmCopy_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            //pbCopy1.Maximum = random.Next(1000, 100001);
            //pbCopy2.Maximum = random.Next(1000, 100001);
            //pbCopy3.Maximum = random.Next(1000, 100001);
            //pbCopy4.Maximum = random.Next(1000, 100001);
            
            progressBars = new List<ProgressBar>();            
            progressBars.Add(pbCopy1);
            progressBars.Add(pbCopy2);
            progressBars.Add(pbCopy3);
            progressBars.Add(pbCopy4);

            tasks = new List<Task>();
            cts = new CancellationTokenSource();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            foreach (var pb in progressBars)
                pb.Value = 0;

            for (int i = 0; i < progressBars.Count; i++)
            {
                int index = i;
                tasks.Add(Task.Run(() => FillProgressBar(progressBars[index], cts.Token)));
            }
            Task megaTask = Task.WhenAll(tasks).ContinueWith(task =>
            {
                if (cts.IsCancellationRequested)                
                    MessageBox.Show("Копирование отменено");                
                else                
                    MessageBox.Show("Копирование завершено");
                
            });
        }

        private CancellationTokenSource cts;
        private void FillProgressBar(ProgressBar progressBar, CancellationToken cancellationToken)
        {
            
            while(progressBar.Value < progressBar.Maximum - 1)
            {

                
                int value = progressBar.Value + 1;
                if (cancellationToken.IsCancellationRequested)           
                   return;
                try
                {
                    cancellationToken.ThrowIfCancellationRequested();
                    Invoke(() => progressBar.Value = value);
                    Thread.Sleep(100);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Копирование отменено исключением");
                }
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            cts.Cancel();            
            foreach (var progressBar in progressBars)
                Invoke(() => progressBar.Value = 0);

        }
    }
}
