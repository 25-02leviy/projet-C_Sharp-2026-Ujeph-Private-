namespace projet_c__ROMEUS_Eliezer_Joel_Levi
{
    using projet_c__ROMEUS_Eliezer_Joel_Levi.Data;
    using projet_c__ROMEUS_Eliezer_Joel_Levi.Forms;

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            try
            {
                // Affiche le splash avant l'initialisation MySQL et l'écran d'authentification.
                using (var startupLoading = new loading())
                    startupLoading.ShowDialog();

                var data = new AppData();
                data.InitializeAsync().GetAwaiter().GetResult();
                var firstLaunch = !data.HasUserAsync().GetAwaiter().GetResult();
                using var login = new Form1(data, firstLaunch);
                if (login.ShowDialog() != DialogResult.OK || login.Session is null) return;
                Application.Run(new MainForm(data, login.Session));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Impossible de démarrer l'application.\n\n{ex.Message}", "Erreur de démarrage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
