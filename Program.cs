using DataStrucutreProjectC_;
using System;
using System.Windows.Forms;

namespace TicketQueueApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // عرض شاشة الترحيب
            using (var splash = new frmSplash())
            {
                splash.ShowDialog(); // عرض شاشة الترحيب
            }

            // تشغيل النموذج الرئيسي
            Application.Run(new Form1());
        }
    }
}
