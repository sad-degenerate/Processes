
namespace OpenAtSomeTime.UI
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblBrowseStatus = new System.Windows.Forms.Label();
            this.btnTime = new System.Windows.Forms.Button();
            this.lblSetTime = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(12, 12);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(108, 36);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblBrowseStatus
            // 
            this.lblBrowseStatus.AutoSize = true;
            this.lblBrowseStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBrowseStatus.ForeColor = System.Drawing.Color.Red;
            this.lblBrowseStatus.Location = new System.Drawing.Point(153, 19);
            this.lblBrowseStatus.Name = "lblBrowseStatus";
            this.lblBrowseStatus.Size = new System.Drawing.Size(20, 20);
            this.lblBrowseStatus.TabIndex = 1;
            this.lblBrowseStatus.Text = "X";
            // 
            // btnTime
            // 
            this.btnTime.Location = new System.Drawing.Point(12, 54);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(108, 36);
            this.btnTime.TabIndex = 2;
            this.btnTime.Text = "Set Time";
            this.btnTime.UseVisualStyleBackColor = true;
            this.btnTime.Click += new System.EventHandler(this.btnTime_Click);
            // 
            // lblSetTime
            // 
            this.lblSetTime.AutoSize = true;
            this.lblSetTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSetTime.ForeColor = System.Drawing.Color.Red;
            this.lblSetTime.Location = new System.Drawing.Point(153, 61);
            this.lblSetTime.Name = "lblSetTime";
            this.lblSetTime.Size = new System.Drawing.Size(20, 20);
            this.lblSetTime.TabIndex = 3;
            this.lblSetTime.Text = "X";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(113, 133);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(108, 36);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 181);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblSetTime);
            this.Controls.Add(this.btnTime);
            this.Controls.Add(this.lblBrowseStatus);
            this.Controls.Add(this.btnBrowse);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "OpenAtSomeTime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblBrowseStatus;
        private System.Windows.Forms.Button btnTime;
        private System.Windows.Forms.Label lblSetTime;
        private System.Windows.Forms.Button btnStart;
    }
}

