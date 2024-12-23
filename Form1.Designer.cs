namespace TicketQueueApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnIssueTicket;
        private System.Windows.Forms.Button btnServeNext;
        private System.Windows.Forms.ListBox lstTickets;
        private System.Windows.Forms.Label lblTotalTickets;
        private System.Windows.Forms.Label lblServedClients;
        private System.Windows.Forms.Label lblWaitingClients;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnIssueTicket = new System.Windows.Forms.Button();
            this.btnServeNext = new System.Windows.Forms.Button();
            this.lstTickets = new System.Windows.Forms.ListBox();
            this.lblTotalTickets = new System.Windows.Forms.Label();
            this.lblServedClients = new System.Windows.Forms.Label();
            this.lblWaitingClients = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIssueTicket
            // 
            this.btnIssueTicket.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnIssueTicket.Font = new System.Drawing.Font("Bell MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueTicket.Location = new System.Drawing.Point(343, 25);
            this.btnIssueTicket.Name = "btnIssueTicket";
            this.btnIssueTicket.Size = new System.Drawing.Size(106, 68);
            this.btnIssueTicket.TabIndex = 0;
            this.btnIssueTicket.Text = "Issue Ticket";
            this.btnIssueTicket.UseVisualStyleBackColor = false;
            this.btnIssueTicket.Click += new System.EventHandler(this.btnIssueTicket_Click);
            // 
            // btnServeNext
            // 
            this.btnServeNext.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnServeNext.Font = new System.Drawing.Font("Bell MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServeNext.Location = new System.Drawing.Point(21, 25);
            this.btnServeNext.Name = "btnServeNext";
            this.btnServeNext.Size = new System.Drawing.Size(106, 68);
            this.btnServeNext.TabIndex = 1;
            this.btnServeNext.Text = "Serve Next";
            this.btnServeNext.UseVisualStyleBackColor = false;
            this.btnServeNext.Click += new System.EventHandler(this.btnServeNext_Click);
            // 
            // lstTickets
            // 
            this.lstTickets.BackColor = System.Drawing.SystemColors.Info;
            this.lstTickets.ItemHeight = 25;
            this.lstTickets.Location = new System.Drawing.Point(32, 283);
            this.lstTickets.Name = "lstTickets";
            this.lstTickets.Size = new System.Drawing.Size(417, 204);
            this.lstTickets.TabIndex = 5;
            // 
            // lblTotalTickets
            // 
            this.lblTotalTickets.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalTickets.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTickets.ForeColor = System.Drawing.Color.Gold;
            this.lblTotalTickets.Location = new System.Drawing.Point(132, 228);
            this.lblTotalTickets.Name = "lblTotalTickets";
            this.lblTotalTickets.Size = new System.Drawing.Size(212, 32);
            this.lblTotalTickets.TabIndex = 2;
            // 
            // lblServedClients
            // 
            this.lblServedClients.BackColor = System.Drawing.Color.Transparent;
            this.lblServedClients.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServedClients.ForeColor = System.Drawing.Color.Gold;
            this.lblServedClients.Location = new System.Drawing.Point(132, 182);
            this.lblServedClients.Name = "lblServedClients";
            this.lblServedClients.Size = new System.Drawing.Size(212, 32);
            this.lblServedClients.TabIndex = 3;
            // 
            // lblWaitingClients
            // 
            this.lblWaitingClients.BackColor = System.Drawing.Color.Transparent;
            this.lblWaitingClients.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaitingClients.ForeColor = System.Drawing.Color.Gold;
            this.lblWaitingClients.Location = new System.Drawing.Point(132, 135);
            this.lblWaitingClients.Name = "lblWaitingClients";
            this.lblWaitingClients.Size = new System.Drawing.Size(212, 32);
            this.lblWaitingClients.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LavenderBlush;
            this.button1.Font = new System.Drawing.Font("Bell MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(182, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 68);
            this.button1.TabIndex = 6;
            this.button1.Text = "Reset Ticket list";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ResetTicketList_Click);
            // 
            // Form1
            // 
            this.BackgroundImage = global::DataStrucutreProjectC_.Properties.Resources.Untitled;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(485, 509);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnIssueTicket);
            this.Controls.Add(this.btnServeNext);
            this.Controls.Add(this.lblTotalTickets);
            this.Controls.Add(this.lblServedClients);
            this.Controls.Add(this.lblWaitingClients);
            this.Controls.Add(this.lstTickets);
            this.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button button1;
    }
}

