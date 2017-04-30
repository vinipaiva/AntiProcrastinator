namespace ProductivityApp.WinForm
{
    partial class MainForm
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
            this.tabControlPage = new System.Windows.Forms.TabControl();
            this.tabPageStudyPlan = new System.Windows.Forms.TabPage();
            this.groupBoxTimer = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblElapsedTime = new System.Windows.Forms.Label();
            this.btnStartTimer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownMinutes = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHours = new System.Windows.Forms.NumericUpDown();
            this.tabPagePomodoro = new System.Windows.Forms.TabPage();
            this.tabPageConfiguration = new System.Windows.Forms.TabPage();
            this.groupBoxExecution = new System.Windows.Forms.GroupBox();
            this.dataGridViewExecution = new System.Windows.Forms.DataGridView();
            this.tabControlPage.SuspendLayout();
            this.tabPageStudyPlan.SuspendLayout();
            this.groupBoxTimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).BeginInit();
            this.groupBoxExecution.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExecution)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlPage
            // 
            this.tabControlPage.Controls.Add(this.tabPageStudyPlan);
            this.tabControlPage.Controls.Add(this.tabPagePomodoro);
            this.tabControlPage.Controls.Add(this.tabPageConfiguration);
            this.tabControlPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPage.Location = new System.Drawing.Point(0, 0);
            this.tabControlPage.Name = "tabControlPage";
            this.tabControlPage.SelectedIndex = 0;
            this.tabControlPage.Size = new System.Drawing.Size(992, 542);
            this.tabControlPage.TabIndex = 0;
            // 
            // tabPageStudyPlan
            // 
            this.tabPageStudyPlan.Controls.Add(this.groupBoxExecution);
            this.tabPageStudyPlan.Controls.Add(this.groupBoxTimer);
            this.tabPageStudyPlan.Location = new System.Drawing.Point(4, 25);
            this.tabPageStudyPlan.Name = "tabPageStudyPlan";
            this.tabPageStudyPlan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStudyPlan.Size = new System.Drawing.Size(984, 513);
            this.tabPageStudyPlan.TabIndex = 2;
            this.tabPageStudyPlan.Text = "Study Plan";
            this.tabPageStudyPlan.UseVisualStyleBackColor = true;
            // 
            // groupBoxTimer
            // 
            this.groupBoxTimer.Controls.Add(this.label5);
            this.groupBoxTimer.Controls.Add(this.label4);
            this.groupBoxTimer.Controls.Add(this.label3);
            this.groupBoxTimer.Controls.Add(this.lblElapsedTime);
            this.groupBoxTimer.Controls.Add(this.btnStartTimer);
            this.groupBoxTimer.Controls.Add(this.label2);
            this.groupBoxTimer.Controls.Add(this.label1);
            this.groupBoxTimer.Controls.Add(this.numericUpDownMinutes);
            this.groupBoxTimer.Controls.Add(this.numericUpDownHours);
            this.groupBoxTimer.Location = new System.Drawing.Point(8, 6);
            this.groupBoxTimer.Name = "groupBoxTimer";
            this.groupBoxTimer.Size = new System.Drawing.Size(968, 142);
            this.groupBoxTimer.TabIndex = 0;
            this.groupBoxTimer.TabStop = false;
            this.groupBoxTimer.Text = "Timer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(267, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 39);
            this.label5.TabIndex = 8;
            this.label5.Text = "Remaining time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(307, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 39);
            this.label4.TabIndex = 7;
            this.label4.Text = "Elapsed time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(536, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(399, 39);
            this.label3.TabIndex = 6;
            this.label3.Text = "1 hour and 37 min 16 sec";
            // 
            // lblElapsedTime
            // 
            this.lblElapsedTime.AutoSize = true;
            this.lblElapsedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElapsedTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblElapsedTime.Location = new System.Drawing.Point(536, 23);
            this.lblElapsedTime.Name = "lblElapsedTime";
            this.lblElapsedTime.Size = new System.Drawing.Size(399, 39);
            this.lblElapsedTime.TabIndex = 5;
            this.lblElapsedTime.Text = "1 hour and 37 min 16 sec";
            // 
            // btnStartTimer
            // 
            this.btnStartTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartTimer.Location = new System.Drawing.Point(20, 79);
            this.btnStartTimer.Name = "btnStartTimer";
            this.btnStartTimer.Size = new System.Drawing.Size(183, 48);
            this.btnStartTimer.TabIndex = 4;
            this.btnStartTimer.Text = "START";
            this.btnStartTimer.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Minutes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hours:";
            // 
            // numericUpDownMinutes
            // 
            this.numericUpDownMinutes.Increment = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownMinutes.Location = new System.Drawing.Point(83, 49);
            this.numericUpDownMinutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownMinutes.Name = "numericUpDownMinutes";
            this.numericUpDownMinutes.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownMinutes.TabIndex = 1;
            // 
            // numericUpDownHours
            // 
            this.numericUpDownHours.Location = new System.Drawing.Point(83, 21);
            this.numericUpDownHours.Name = "numericUpDownHours";
            this.numericUpDownHours.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownHours.TabIndex = 0;
            // 
            // tabPagePomodoro
            // 
            this.tabPagePomodoro.Location = new System.Drawing.Point(4, 25);
            this.tabPagePomodoro.Name = "tabPagePomodoro";
            this.tabPagePomodoro.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePomodoro.Size = new System.Drawing.Size(984, 513);
            this.tabPagePomodoro.TabIndex = 1;
            this.tabPagePomodoro.Text = "Pomodoro";
            this.tabPagePomodoro.UseVisualStyleBackColor = true;
            // 
            // tabPageConfiguration
            // 
            this.tabPageConfiguration.Location = new System.Drawing.Point(4, 25);
            this.tabPageConfiguration.Name = "tabPageConfiguration";
            this.tabPageConfiguration.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConfiguration.Size = new System.Drawing.Size(984, 513);
            this.tabPageConfiguration.TabIndex = 0;
            this.tabPageConfiguration.Text = "Configuration";
            this.tabPageConfiguration.UseVisualStyleBackColor = true;
            // 
            // groupBoxExecution
            // 
            this.groupBoxExecution.Controls.Add(this.dataGridViewExecution);
            this.groupBoxExecution.Location = new System.Drawing.Point(9, 155);
            this.groupBoxExecution.Name = "groupBoxExecution";
            this.groupBoxExecution.Size = new System.Drawing.Size(967, 350);
            this.groupBoxExecution.TabIndex = 1;
            this.groupBoxExecution.TabStop = false;
            this.groupBoxExecution.Text = "Executions";
            // 
            // dataGridViewExecution
            // 
            this.dataGridViewExecution.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExecution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewExecution.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewExecution.Name = "dataGridViewExecution";
            this.dataGridViewExecution.RowTemplate.Height = 24;
            this.dataGridViewExecution.Size = new System.Drawing.Size(961, 329);
            this.dataGridViewExecution.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 542);
            this.Controls.Add(this.tabControlPage);
            this.Name = "MainForm";
            this.Text = "Anti Procrastinator";
            this.tabControlPage.ResumeLayout(false);
            this.tabPageStudyPlan.ResumeLayout(false);
            this.groupBoxTimer.ResumeLayout(false);
            this.groupBoxTimer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).EndInit();
            this.groupBoxExecution.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExecution)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPage;
        private System.Windows.Forms.TabPage tabPageConfiguration;
        private System.Windows.Forms.TabPage tabPagePomodoro;
        private System.Windows.Forms.TabPage tabPageStudyPlan;
        private System.Windows.Forms.GroupBox groupBoxTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownMinutes;
        private System.Windows.Forms.NumericUpDown numericUpDownHours;
        private System.Windows.Forms.Button btnStartTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblElapsedTime;
        private System.Windows.Forms.GroupBox groupBoxExecution;
        private System.Windows.Forms.DataGridView dataGridViewExecution;
    }
}

