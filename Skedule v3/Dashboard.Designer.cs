namespace Skedule_v3
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelDashboardUp = new System.Windows.Forms.Panel();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelClock = new System.Windows.Forms.Label();
            this.label_upcomingquiz = new System.Windows.Forms.Label();
            this.label_pendingtasks = new System.Windows.Forms.Label();
            this.label_daysbefore = new System.Windows.Forms.Label();
            this.label_FINAL = new System.Windows.Forms.Label();
            this.labelNumUpcomingQuiz = new System.Windows.Forms.Label();
            this.labelNumPendingTasks = new System.Windows.Forms.Label();
            this.labelNumDayFinal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label_MyList = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelDashboardUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(755, 185);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelDashboardUp
            // 
            this.panelDashboardUp.Controls.Add(this.labelDate);
            this.panelDashboardUp.Controls.Add(this.labelClock);
            this.panelDashboardUp.Controls.Add(this.label_upcomingquiz);
            this.panelDashboardUp.Controls.Add(this.label_pendingtasks);
            this.panelDashboardUp.Controls.Add(this.label_daysbefore);
            this.panelDashboardUp.Controls.Add(this.pictureBox1);
            this.panelDashboardUp.Controls.Add(this.label_FINAL);
            this.panelDashboardUp.Controls.Add(this.labelNumUpcomingQuiz);
            this.panelDashboardUp.Controls.Add(this.labelNumPendingTasks);
            this.panelDashboardUp.Controls.Add(this.labelNumDayFinal);
            this.panelDashboardUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDashboardUp.Location = new System.Drawing.Point(0, 0);
            this.panelDashboardUp.Margin = new System.Windows.Forms.Padding(4);
            this.panelDashboardUp.Name = "panelDashboardUp";
            this.panelDashboardUp.Size = new System.Drawing.Size(1182, 213);
            this.panelDashboardUp.TabIndex = 12;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.White;
            this.labelDate.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.Black;
            this.labelDate.Location = new System.Drawing.Point(323, 102);
            this.labelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(245, 28);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "Thursday, 21 April, 2023";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelClock
            // 
            this.labelClock.AutoSize = true;
            this.labelClock.BackColor = System.Drawing.Color.White;
            this.labelClock.Font = new System.Drawing.Font("Ebrima", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClock.ForeColor = System.Drawing.Color.Black;
            this.labelClock.Location = new System.Drawing.Point(293, 15);
            this.labelClock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClock.Name = "labelClock";
            this.labelClock.Size = new System.Drawing.Size(285, 76);
            this.labelClock.TabIndex = 1;
            this.labelClock.Text = "12:00 PM";
            // 
            // label_upcomingquiz
            // 
            this.label_upcomingquiz.AutoSize = true;
            this.label_upcomingquiz.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_upcomingquiz.ForeColor = System.Drawing.SystemColors.Control;
            this.label_upcomingquiz.Location = new System.Drawing.Point(967, 170);
            this.label_upcomingquiz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_upcomingquiz.Name = "label_upcomingquiz";
            this.label_upcomingquiz.Size = new System.Drawing.Size(154, 23);
            this.label_upcomingquiz.TabIndex = 1;
            this.label_upcomingquiz.Text = "upcoming quizzes";
            // 
            // label_pendingtasks
            // 
            this.label_pendingtasks.AutoSize = true;
            this.label_pendingtasks.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pendingtasks.ForeColor = System.Drawing.SystemColors.Control;
            this.label_pendingtasks.Location = new System.Drawing.Point(817, 170);
            this.label_pendingtasks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_pendingtasks.Name = "label_pendingtasks";
            this.label_pendingtasks.Size = new System.Drawing.Size(122, 23);
            this.label_pendingtasks.TabIndex = 1;
            this.label_pendingtasks.Text = "pending tasks";
            // 
            // label_daysbefore
            // 
            this.label_daysbefore.AutoSize = true;
            this.label_daysbefore.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_daysbefore.ForeColor = System.Drawing.SystemColors.Control;
            this.label_daysbefore.Location = new System.Drawing.Point(949, 26);
            this.label_daysbefore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_daysbefore.Name = "label_daysbefore";
            this.label_daysbefore.Size = new System.Drawing.Size(123, 28);
            this.label_daysbefore.TabIndex = 1;
            this.label_daysbefore.Text = "days before";
            // 
            // label_FINAL
            // 
            this.label_FINAL.AutoSize = true;
            this.label_FINAL.Font = new System.Drawing.Font("Ebrima", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FINAL.ForeColor = System.Drawing.SystemColors.Control;
            this.label_FINAL.Location = new System.Drawing.Point(944, 41);
            this.label_FINAL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_FINAL.Name = "label_FINAL";
            this.label_FINAL.Size = new System.Drawing.Size(132, 52);
            this.label_FINAL.TabIndex = 1;
            this.label_FINAL.Text = "FINAL";
            // 
            // labelNumUpcomingQuiz
            // 
            this.labelNumUpcomingQuiz.AutoSize = true;
            this.labelNumUpcomingQuiz.Font = new System.Drawing.Font("Ebrima", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumUpcomingQuiz.ForeColor = System.Drawing.SystemColors.Control;
            this.labelNumUpcomingQuiz.Location = new System.Drawing.Point(1005, 112);
            this.labelNumUpcomingQuiz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumUpcomingQuiz.Name = "labelNumUpcomingQuiz";
            this.labelNumUpcomingQuiz.Size = new System.Drawing.Size(87, 67);
            this.labelNumUpcomingQuiz.TabIndex = 1;
            this.labelNumUpcomingQuiz.Text = "02";
            // 
            // labelNumPendingTasks
            // 
            this.labelNumPendingTasks.AutoSize = true;
            this.labelNumPendingTasks.Font = new System.Drawing.Font("Ebrima", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumPendingTasks.ForeColor = System.Drawing.SystemColors.Control;
            this.labelNumPendingTasks.Location = new System.Drawing.Point(839, 112);
            this.labelNumPendingTasks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumPendingTasks.Name = "labelNumPendingTasks";
            this.labelNumPendingTasks.Size = new System.Drawing.Size(87, 67);
            this.labelNumPendingTasks.TabIndex = 1;
            this.labelNumPendingTasks.Text = "08";
            // 
            // labelNumDayFinal
            // 
            this.labelNumDayFinal.AutoSize = true;
            this.labelNumDayFinal.Font = new System.Drawing.Font("Ebrima", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumDayFinal.ForeColor = System.Drawing.SystemColors.Control;
            this.labelNumDayFinal.Location = new System.Drawing.Point(855, 15);
            this.labelNumDayFinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumDayFinal.Name = "labelNumDayFinal";
            this.labelNumDayFinal.Size = new System.Drawing.Size(105, 81);
            this.labelNumDayFinal.TabIndex = 1;
            this.labelNumDayFinal.Text = "72";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(502, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 56);
            this.button1.TabIndex = 19;
            this.button1.Text = "Announcement";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_MyList
            // 
            this.label_MyList.AutoSize = true;
            this.label_MyList.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MyList.ForeColor = System.Drawing.SystemColors.Control;
            this.label_MyList.Location = new System.Drawing.Point(23, 235);
            this.label_MyList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_MyList.Name = "label_MyList";
            this.label_MyList.Size = new System.Drawing.Size(120, 41);
            this.label_MyList.TabIndex = 17;
            this.label_MyList.Text = "My List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1090, 305);
            this.dataGridView1.TabIndex = 18;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1182, 649);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelDashboardUp);
            this.Controls.Add(this.label_MyList);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelDashboardUp.ResumeLayout(false);
            this.panelDashboardUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelDashboardUp;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelClock;
        private System.Windows.Forms.Label label_upcomingquiz;
        private System.Windows.Forms.Label label_pendingtasks;
        private System.Windows.Forms.Label label_daysbefore;
        private System.Windows.Forms.Label label_FINAL;
        private System.Windows.Forms.Label labelNumUpcomingQuiz;
        private System.Windows.Forms.Label labelNumPendingTasks;
        private System.Windows.Forms.Label labelNumDayFinal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_MyList;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}