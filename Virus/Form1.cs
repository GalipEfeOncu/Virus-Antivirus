namespace Virus
{
    public partial class Form1 : Form
    {
        // Zamanlayıcı ve rastgele sayı üretici
        private System.Windows.Forms.Timer _colorTimer = null!;
        private System.Windows.Forms.Timer _lifecycleTimer = null!;
        private Random _random = null!;

        private bool _isHidingPhase = false;

        public Form1()
        {
            InitializeComponent();
            InitializeVirusBehavior();
        }

        private void InitializeVirusBehavior()
        {
            _random = new Random();
            RandomizeAppearance();

            // --- Renk Timer Ayarları ---
            _colorTimer = new System.Windows.Forms.Timer();
            _colorTimer.Interval = 200;
            _colorTimer.Tick += ColorTimer_Tick;
            _colorTimer.Start();

            // --- Yaşam Döngüsü (Lifecycle) Timer Ayarları ---
            _lifecycleTimer = new System.Windows.Forms.Timer();
            _lifecycleTimer.Interval = 1500;
            _lifecycleTimer.Tick += LifecycleTimer_Tick;
            _lifecycleTimer.Start();
        }

        private void RandomizeAppearance()
        {
            // Ekran boyutlarını al
            Rectangle screen = Screen.PrimaryScreen.Bounds;

            // 200 600 arasında random boyut
            int w = _random.Next(200, 600);
            int h = _random.Next(200, 600);
            this.Size = new Size(w, h);

            // Rastgele pozisyon
            int x = _random.Next(0, screen.Width - w);
            int y = _random.Next(0, screen.Height - h);
            this.Location = new Point(x, y);
        }

        private void LifecycleTimer_Tick(object? sender, EventArgs e)
        {
            if (_isHidingPhase)
            {
                RandomizeAppearance();
                this.Show();

                // 3 saniye duracak
                _lifecycleTimer.Interval = 1500;
                _isHidingPhase = false;
            }
            else
            {
                this.Hide();

                // 1 saniye gizli
                _lifecycleTimer.Interval = 500;
                _isHidingPhase = true;
            }
        }

        private void ColorTimer_Tick(object? sender, EventArgs e)
        {
            if (_isHidingPhase) return;

            // Rastgele RGB renkleri oluştur
            int r = _random.Next(0, 256);
            int g = _random.Next(0, 256);
            int b = _random.Next(0, 256);

            this.BackColor = Color.FromArgb(r, g, b);
        }
    }
}
