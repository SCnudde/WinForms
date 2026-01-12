namespace Clock
{
    partial class Alarm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alarm));
            this.dateTimePicker_1 = new System.Windows.Forms.DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dateTimePicker_2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_3 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSound1 = new System.Windows.Forms.ComboBox();
            this.comboBoxSound2 = new System.Windows.Forms.ComboBox();
            this.comboBoxSound3 = new System.Windows.Forms.ComboBox();
            this.toggle_buttons3 = new Clock.ToggleButtons.Toggle_buttons();
            this.toggle_buttons2 = new Clock.ToggleButtons.Toggle_buttons();
            this.toggle_buttons1 = new Clock.ToggleButtons.Toggle_buttons();
            this.SuspendLayout();
            // 
            // dateTimePicker_1
            // 
            this.dateTimePicker_1.CalendarFont = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_1.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dateTimePicker_1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_1.Location = new System.Drawing.Point(324, 85);
            this.dateTimePicker_1.Name = "dateTimePicker_1";
            this.dateTimePicker_1.Size = new System.Drawing.Size(198, 45);
            this.dateTimePicker_1.TabIndex = 0;
            this.dateTimePicker_1.Value = new System.DateTime(2026, 1, 11, 15, 10, 45, 0);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(418, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(157, 28);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Set an alarm";
            // 
            // dateTimePicker_2
            // 
            this.dateTimePicker_2.CalendarFont = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_2.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dateTimePicker_2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_2.Location = new System.Drawing.Point(325, 208);
            this.dateTimePicker_2.Name = "dateTimePicker_2";
            this.dateTimePicker_2.Size = new System.Drawing.Size(198, 45);
            this.dateTimePicker_2.TabIndex = 5;
            this.dateTimePicker_2.Value = new System.DateTime(2026, 1, 12, 14, 47, 35, 0);
            // 
            // dateTimePicker_3
            // 
            this.dateTimePicker_3.CalendarFont = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_3.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dateTimePicker_3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_3.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_3.Location = new System.Drawing.Point(325, 336);
            this.dateTimePicker_3.Name = "dateTimePicker_3";
            this.dateTimePicker_3.Size = new System.Drawing.Size(198, 45);
            this.dateTimePicker_3.TabIndex = 6;
            this.dateTimePicker_3.Value = new System.DateTime(2026, 1, 10, 21, 35, 13, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Alarm 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Alarm 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(320, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Alarm 3";
            // 
            // comboBoxSound1
            // 
            this.comboBoxSound1.FormattingEnabled = true;
            this.comboBoxSound1.Location = new System.Drawing.Point(324, 137);
            this.comboBoxSound1.Name = "comboBoxSound1";
            this.comboBoxSound1.Size = new System.Drawing.Size(198, 28);
            this.comboBoxSound1.TabIndex = 16;
            this.comboBoxSound1.Text = "alarm sounds...";
            this.comboBoxSound1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBoxSound1.Click += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxSound2
            // 
            this.comboBoxSound2.FormattingEnabled = true;
            this.comboBoxSound2.Location = new System.Drawing.Point(324, 259);
            this.comboBoxSound2.Name = "comboBoxSound2";
            this.comboBoxSound2.Size = new System.Drawing.Size(198, 28);
            this.comboBoxSound2.TabIndex = 17;
            this.comboBoxSound2.Text = "alarm sounds...";
            this.comboBoxSound2.SelectedIndexChanged += new System.EventHandler(this.comboBoxSound2_SelectedIndexChanged);
            // 
            // comboBoxSound3
            // 
            this.comboBoxSound3.FormattingEnabled = true;
            this.comboBoxSound3.Location = new System.Drawing.Point(324, 387);
            this.comboBoxSound3.Name = "comboBoxSound3";
            this.comboBoxSound3.Size = new System.Drawing.Size(198, 28);
            this.comboBoxSound3.TabIndex = 18;
            this.comboBoxSound3.Text = "alarm sounds...";
            this.comboBoxSound3.SelectedIndexChanged += new System.EventHandler(this.comboBoxSound3_SelectedIndexChanged_1);
            // 
            // toggle_buttons3
            // 
            this.toggle_buttons3.Location = new System.Drawing.Point(548, 336);
            this.toggle_buttons3.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggle_buttons3.Name = "toggle_buttons3";
            this.toggle_buttons3.OffBackColor = System.Drawing.Color.LightSkyBlue;
            this.toggle_buttons3.OffToggleColor = System.Drawing.Color.Crimson;
            this.toggle_buttons3.OnBackColor = System.Drawing.Color.LightSkyBlue;
            this.toggle_buttons3.OnToggleColor = System.Drawing.Color.LimeGreen;
            this.toggle_buttons3.Size = new System.Drawing.Size(104, 43);
            this.toggle_buttons3.TabIndex = 11;
            this.toggle_buttons3.UseVisualStyleBackColor = true;
            this.toggle_buttons3.CheckedChanged += new System.EventHandler(this.toggle_buttons3_CheckedChanged);
            this.toggle_buttons3.Click += new System.EventHandler(this.toggle_buttons3_CheckedChanged);
            // 
            // toggle_buttons2
            // 
            this.toggle_buttons2.Location = new System.Drawing.Point(548, 210);
            this.toggle_buttons2.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggle_buttons2.Name = "toggle_buttons2";
            this.toggle_buttons2.OffBackColor = System.Drawing.Color.LightSkyBlue;
            this.toggle_buttons2.OffToggleColor = System.Drawing.Color.Crimson;
            this.toggle_buttons2.OnBackColor = System.Drawing.Color.LightSkyBlue;
            this.toggle_buttons2.OnToggleColor = System.Drawing.Color.LimeGreen;
            this.toggle_buttons2.Size = new System.Drawing.Size(104, 43);
            this.toggle_buttons2.TabIndex = 10;
            this.toggle_buttons2.UseVisualStyleBackColor = true;
            this.toggle_buttons2.Click += new System.EventHandler(this.toggle_buttons2_CheckedChanged);
            // 
            // toggle_buttons1
            // 
            this.toggle_buttons1.Location = new System.Drawing.Point(547, 87);
            this.toggle_buttons1.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggle_buttons1.Name = "toggle_buttons1";
            this.toggle_buttons1.OffBackColor = System.Drawing.Color.LightSkyBlue;
            this.toggle_buttons1.OffToggleColor = System.Drawing.Color.Crimson;
            this.toggle_buttons1.OnBackColor = System.Drawing.Color.LightSkyBlue;
            this.toggle_buttons1.OnToggleColor = System.Drawing.Color.LimeGreen;
            this.toggle_buttons1.Size = new System.Drawing.Size(104, 43);
            this.toggle_buttons1.TabIndex = 9;
            this.toggle_buttons1.UseVisualStyleBackColor = true;
            this.toggle_buttons1.Click += new System.EventHandler(this.toggle_buttons1_CheckedChanged);
            // 
            // Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(692, 433);
            this.Controls.Add(this.comboBoxSound3);
            this.Controls.Add(this.comboBoxSound2);
            this.Controls.Add(this.comboBoxSound1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toggle_buttons3);
            this.Controls.Add(this.toggle_buttons2);
            this.Controls.Add(this.toggle_buttons1);
            this.Controls.Add(this.dateTimePicker_3);
            this.Controls.Add(this.dateTimePicker_2);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.dateTimePicker_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Alarm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarm clock";
            this.Load += new System.EventHandler(this.Alarm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DateTimePicker dateTimePicker_2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_3;
        private ToggleButtons.Toggle_buttons toggle_buttons1;
        private ToggleButtons.Toggle_buttons toggle_buttons2;
        private ToggleButtons.Toggle_buttons toggle_buttons3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSound1;
        private System.Windows.Forms.ComboBox comboBoxSound2;
        private System.Windows.Forms.ComboBox comboBoxSound3;
    }
}