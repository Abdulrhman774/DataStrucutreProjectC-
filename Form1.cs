using System.Collections.Generic;
using System.Windows.Forms;
using System;
using TicketQueueApp;


namespace TicketQueueApp
{
    // نافذة التطبيق الرئيسية (Form1)
    public partial class Form1 : Form
    {
        private TicketQueue ticketQueue;  // متغير لتمثيل صف التذاكر

        // الكونستركتر لتهيئة التطبيق
        public Form1()
        {
            InitializeComponent();  // تهيئة المكونات (من خلال Designer)
            ticketQueue = new TicketQueue("A0", 10);  // تهيئة صف التذاكر مع البريفكس ووقت الخدمة
            UpdateQueueInfo();  // تحديث المعلومات المعروضة في واجهة المستخدم
        }

        // تعريف الكلاس Ticket لتمثيل التذاكر
        public class Ticket
        {
            // خاصية لوقت إصدار التذكرة
            public DateTime IssueTime { get; }

            // خاصية للاسم المسبق للتذكرة (مثل A0)
            public string Prefix { get; }

            // خاصية لرقم التذكرة
            public int Number { get; }

            // خاصية لعدد العملاء الذين ينتظرون
            public int WaitingClients { get; }

            // خاصية لوقت الخدمة المتوقع لكل عميل
            public int AverageServeTime { get; }

            // كونستركتر لتهيئة التذكرة
            public Ticket(string prefix, int number, int waitingClients, int averageServeTime)
            {
                IssueTime = DateTime.Now;  // تحديد وقت إصدار التذكرة
                Prefix = prefix;           // تعيين البريفكس (مثل A0)
                Number = number;           // تعيين رقم التذكرة
                WaitingClients = waitingClients;  // تعيين عدد العملاء الذين ينتظرون
                AverageServeTime = averageServeTime;  // تعيين وقت الخدمة المتوقع
            }


            // خاصية لدمج البريفكس مع الرقم في شكل تذكرة كاملة (مثل A01)
            public string FullNumber => $"{Prefix}{Number:D2}";

            // خاصية لعرض وقت إصدار التذكرة بتنسيق معين (اليوم/الشهر/السنة الساعة:الدقيقة:الثانية)
            public string TicketTime => IssueTime.ToString("dd/MM/yyyy HH:mm:ss");

            // خاصية لحساب وقت الخدمة المتوقع بناءً على عدد العملاء
            public int ExpectedServeTime => AverageServeTime * WaitingClients;

            // إعادة تعريف دالة ToString لعرض رقم التذكرة ووقت إصدارها
            public override string ToString()
            {
                return $"{FullNumber} - {TicketTime}";
            }
        }
        
        
        // تعريف الكلاس TicketQueue لإدارة صفوف التذاكر
        public class TicketQueue
        {
            public Queue<Ticket> QueueLineTicket = new Queue<Ticket>(); // قائمة انتظار لتمثيل الصف
            private string prefix;  // المتغير لتخزين البريفكس
            private int averageServeTime;  // المتغير لتخزين وقت الخدمة المتوقع
            private int totalTickets = 0;  // عداد لعدد التذاكر الصادرة



            // الكونستركتر لتهيئة الكلاس بالبيانات الأساسية (البريفكس ووقت الخدمة)
            public TicketQueue(string prefix, int averageServeTime)
            {
                this.prefix = prefix;  // تعيين البريفكس
                this.averageServeTime = averageServeTime;  // تعيين وقت الخدمة المتوقع
            }

            // دالة لإصدار تذكرة جديدة
            public void IssueTicket()
            {
                totalTickets++;  // زيادة عدد التذاكر الصادرة
                                 // إنشاء تذكرة جديدة وإضافتها إلى قائمة الانتظار
                QueueLineTicket.Enqueue(new Ticket(prefix, totalTickets, QueueLineTicket.Count, averageServeTime));
            }

            // دالة لخدمة العميل التالي
            public bool ServeNextClient()
            {
                if (QueueLineTicket.Count > 0)  // إذا كانت هناك تذاكر في قائمة الانتظار
                {
                    QueueLineTicket.Dequeue();  // إزالة التذكرة الأولى من قائمة الانتظار
                    return true;  // العودة بنجاح
                }
                return false;  // إذا كانت قائمة الانتظار فارغة
            }

            // خاصية للحصول على إجمالي عدد التذاكر
            public int TotalTickets => totalTickets;

            // خاصية للحصول على عدد العملاء الذين ينتظرون في قائمة الانتظار
            public int WaitingClients => QueueLineTicket.Count;

            // خاصية للحصول على عدد العملاء الذين تم خدمتهم
            public int ServedClients => totalTickets - QueueLineTicket.Count;

            // دالة للحصول على جميع التذاكر في قائمة الانتظار
            public IEnumerable<Ticket> GetAllTickets() => QueueLineTicket;
        }


        // الحدث عند النقر على زر "إصدار تذكرة"
        private void btnIssueTicket_Click(object sender, EventArgs e)
        {
            ticketQueue.IssueTicket();  // إصدار تذكرة جديدة
            UpdateQueueInfo();  // تحديث المعلومات المعروضة
        }

        // الحدث عند النقر على زر "خدمة العميل التالي"
        private void btnServeNext_Click(object sender, EventArgs e)
        {
            ticketQueue.ServeNextClient();  // خدمة العميل التالي
            UpdateQueueInfo();  // تحديث المعلومات المعروضة
        }

        // دالة لتحديث المعلومات المعروضة على واجهة المستخدم
        private void UpdateQueueInfo()
        { 
            lblTotalTickets.Text = $"Total Tickets: {ticketQueue.TotalTickets}";  // تحديث عدد التذاكر
            lblServedClients.Text = $"Served Clients: {ticketQueue.ServedClients}";  // تحديث عدد العملاء الذين تم خدمتهم
            lblWaitingClients.Text = $"Waiting Clients: {ticketQueue.WaitingClients}";  // تحديث عدد العملاء الذين ينتظرون

            lstTickets.Items.Clear();  // مسح العناصر الحالية في قائمة التذاكر
            // إضافة التذاكر الحالية إلى القائمة
            foreach (var ticket in ticketQueue.GetAllTickets())
                lstTickets.Items.Add(ticket);  // إضافة التذكرة إلى القائمة
        }

        // دالة لإعادة تعيين صف التذاكر
        private void ResetTicketList()
        {
            // تفريغ الصف بالكامل
            ticketQueue.QueueLineTicket.Clear();

            // تصفير القيم المرتبطة بصف التذاكر
            ticketQueue = new TicketQueue(ticketQueue.QueueLineTicket.Count > 0 ?
                ticketQueue.QueueLineTicket.Peek().Prefix : "A0", 10);


            // تحديث واجهة المستخدم
            UpdateQueueInfo();
        }

        private void ResetTicketList_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to reset system?", "Reset list", MessageBoxButtons.OKCancel
                , MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                ResetTicketList();
                MessageBox.Show("Reset is done successfully", "reset system", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
            }
            
        }

    }
}