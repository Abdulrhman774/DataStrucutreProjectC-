using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DataStrucutreProjectC_
{
    public partial class frmSplash : Form
    {
        private Timer splashTimer;


        public frmSplash()
        {
            InitializeComponent();// إعداد مؤقت الشاشة الترحيبية

            // إعداد خصائص النافذة
            this.FormBorderStyle = FormBorderStyle.None;  // إخفاء الشريط العلوي (Title Bar)
            this.ControlBox = false;  // إخفاء الأزرار الخاصة بالتصغير والتكبير والإغلاق
            this.StartPosition = FormStartPosition.CenterScreen;  // تعيين النافذة لتكون في منتصف الشاشة

            // إضافة الشعار
            PictureBox logo = new PictureBox();
            logo.Image = Image.FromFile(@"C:\QueueLineTicketLogo.png");  // ضع هنا المسار للشعار الخاص بك
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.Dock = DockStyle.Fill;  // تعيين الشعار ليملأ النافذة
            this.Controls.Add(logo);

            // إعداد مؤقت الشاشة الترحيبية
            splashTimer = new Timer();
            splashTimer.Interval = 3000; // مدة العرض: 3 ثواني
            splashTimer.Tick += SplashTimer_Tick; // ربط الحدث
            splashTimer.Start();

        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            splashTimer.Stop(); // إيقاف المؤقت
            this.Close(); // إغلاق شاشة الترحيب
        }
    }
}
