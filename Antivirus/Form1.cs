using System.Diagnostics;

namespace Antivirus
{
    public partial class Form1 : Form
    {
        private const string TargetProcessName = "Virus";
        public Form1() => InitializeComponent();

        private void btnScan_Click(object sender, EventArgs e)
        {
            lstResults.Items.Clear();
            lstResults.Items.Add("Scanning started..."); // Tarama başlatılıyor

            bool isVirusFound = false;

            // Sistemde çalışan tüm process'leri (işlemleri) çekiyoruz
            Process[] activeProcesses = Process.GetProcesses();

            foreach (Process process in activeProcesses)
            {
                try
                {
                    // Process ismini kontrol et (Büyük/küçük harf duyarlılığı olmadan)
                    if (process.ProcessName.Equals(TargetProcessName, StringComparison.OrdinalIgnoreCase))
                    {
                        isVirusFound = true;

                        lstResults.Items.Add($"[DANGER] Virus Detected! Process: {process.ProcessName}, ID: {process.Id}");
                        lstResults.BackColor = Color.Red;
                        lstResults.ForeColor = Color.White;

                        // Kullanıcıya ne yapması gerektiğini soruyoruz
                        DialogResult userChoice = MessageBox.Show(
                            "Zararlı yazılım simülasyonu tespit edildi! Sonlandırılsın mı?",
                            "Security Alert",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);

                        if (userChoice == DialogResult.Yes)
                        {
                            process.Kill(); // İşlemi öldür 
                            process.WaitForExit(); // Kapanana kadar bekle ki UI saçmalamasın
                            lstResults.Items.Add("-> Threat neutralized. (Tehdit etkisiz hale getirildi)");
                        }
                    }
                }
                catch
                {
                    continue;
                }
            }

            if (!isVirusFound)
            {
                lstResults.Items.Add("Scan complete. System is clean.");
                lstResults.BackColor = Color.Green;
                lstResults.ForeColor = Color.White;
            }
        }
    }
}
