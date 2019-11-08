namespace Alarm501Exam
{
    partial class Form1
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
            this.lbl_status = new System.Windows.Forms.Label();
            this.time_picker = new System.Windows.Forms.DateTimePicker();
            this.btn_set_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(146, 38);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(83, 25);
            this.lbl_status.TabIndex = 0;
            this.lbl_status.Text = "Not Set";
            // 
            // time_picker
            // 
            this.time_picker.CustomFormat = "H:mm:ss";
            this.time_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.time_picker.Location = new System.Drawing.Point(143, 68);
            this.time_picker.Name = "time_picker";
            this.time_picker.ShowUpDown = true;
            this.time_picker.Size = new System.Drawing.Size(92, 20);
            this.time_picker.TabIndex = 1;
            // 
            // btn_set_start
            // 
            this.btn_set_start.Location = new System.Drawing.Point(85, 110);
            this.btn_set_start.Name = "btn_set_start";
            this.btn_set_start.Size = new System.Drawing.Size(75, 23);
            this.btn_set_start.TabIndex = 2;
            this.btn_set_start.Text = "Set";
            this.btn_set_start.UseVisualStyleBackColor = true;
            this.btn_set_start.Click += new System.EventHandler(this.Btn_set_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Enabled = false;
            this.btn_stop.Location = new System.Drawing.Point(206, 110);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 3;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.Btn_stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 185);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_set_start);
            this.Controls.Add(this.time_picker);
            this.Controls.Add(this.lbl_status);
            this.Name = "Form1";
            this.Text = "Alarm 501";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.DateTimePicker time_picker;
        private System.Windows.Forms.Button btn_set_start;
        private System.Windows.Forms.Button btn_stop;
    }
}

