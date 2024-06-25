namespace ConcurrencyAcademyWinForms
{
    public partial class Form1 : Form
    {
        CancellationTokenSource? cancellationTokenSource;

        public Form1()
        {
            InitializeComponent();

            var context = System.Threading.SynchronizationContext.Current;
            var threadId = Environment.CurrentManagedThreadId;
        }

        private async void WorkButton_Click(object sender, EventArgs e)
        {
            using (cancellationTokenSource = new CancellationTokenSource())
            {
                workButton.Enabled = false;
                stopButton.Enabled = true;
                
                try
                {
                    await Task.Run(() => FindPrimeNumber(300_000, cancellationTokenSource.Token));
                }
                finally
                {
                    workButton.Enabled = true;
                    stopButton.Enabled = false;
                }
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            stopButton.Enabled = false;
            cancellationTokenSource?.Cancel();
        }

        void SetLabelText(string text)
        {
            var context = System.Threading.SynchronizationContext.Current;
            var threadId = Environment.CurrentManagedThreadId;

            Invoke(() =>
            {
                var context = System.Threading.SynchronizationContext.Current;
                var threadId = Environment.CurrentManagedThreadId;

                statusLabel.Text = text;
            });
        }

        /// <summary>
        /// Calculate nth prime number
        /// </summary>
        /// <param name="n">nth prime</param>
        /// <returns>nth prime number</returns>
        public long FindPrimeNumber(int n, CancellationToken cancellationToken)
        {
            int count = 0;
            long a = 2;

            while (count < n && !cancellationToken.IsCancellationRequested)
            {
                SetLabelText($"calculating prime no {count}");

                long b = 2;
                bool prime = true;

                while ((b * b <= a))
                {
                    if (a % b == 0)
                    {
                        prime = false;
                        break;
                    }

                    b++;
                }

                if (prime)
                {
                    count++;
                }

                a++;
            }

            return --a;
        }
    }
}
