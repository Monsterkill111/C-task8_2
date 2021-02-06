
namespace IT_Task8
{
    partial class MainForm
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
            this.Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.AddHouse = new System.Windows.Forms.Button();
            this.SlowTechnics = new System.Windows.Forms.Button();
            this.FastTechnics = new System.Windows.Forms.Button();
            this.InstantTechnics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.AutoScroll = true;
            this.Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Panel.Location = new System.Drawing.Point(158, 14);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(818, 447);
            this.Panel.TabIndex = 0;
            // 
            // AddHouse
            // 
            this.AddHouse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddHouse.Location = new System.Drawing.Point(12, 12);
            this.AddHouse.Name = "AddHouse";
            this.AddHouse.Size = new System.Drawing.Size(127, 64);
            this.AddHouse.TabIndex = 1;
            this.AddHouse.Text = "Add new\r\ncrosswalk";
            this.AddHouse.UseVisualStyleBackColor = true;
            this.AddHouse.Click += new System.EventHandler(this.AddCrosswalk_Click);
            // 
            // SlowTechnics
            // 
            this.SlowTechnics.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SlowTechnics.Location = new System.Drawing.Point(12, 225);
            this.SlowTechnics.Name = "SlowTechnics";
            this.SlowTechnics.Size = new System.Drawing.Size(127, 64);
            this.SlowTechnics.TabIndex = 2;
            this.SlowTechnics.Text = "Add slow\r\nemergency";
            this.SlowTechnics.UseVisualStyleBackColor = true;
            this.SlowTechnics.Click += new System.EventHandler(this.AddSlowEmergency_Click);
            // 
            // FastTechnics
            // 
            this.FastTechnics.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FastTechnics.Location = new System.Drawing.Point(12, 311);
            this.FastTechnics.Name = "FastTechnics";
            this.FastTechnics.Size = new System.Drawing.Size(127, 64);
            this.FastTechnics.TabIndex = 3;
            this.FastTechnics.Text = "Add fast \r\nemergency";
            this.FastTechnics.UseVisualStyleBackColor = true;
            this.FastTechnics.Click += new System.EventHandler(this.AddAverageEmergency_Click);
            // 
            // InstantTechnics
            // 
            this.InstantTechnics.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InstantTechnics.Location = new System.Drawing.Point(12, 397);
            this.InstantTechnics.Name = "InstantTechnics";
            this.InstantTechnics.Size = new System.Drawing.Size(127, 64);
            this.InstantTechnics.TabIndex = 4;
            this.InstantTechnics.Text = "Add very fast \r\nemergency";
            this.InstantTechnics.UseVisualStyleBackColor = true;
            this.InstantTechnics.Click += new System.EventHandler(this.AddFastEmergency_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 473);
            this.Controls.Add(this.SlowTechnics);
            this.Controls.Add(this.InstantTechnics);
            this.Controls.Add(this.FastTechnics);
            this.Controls.Add(this.AddHouse);
            this.Controls.Add(this.Panel);
            this.MaximumSize = new System.Drawing.Size(2000, 1000);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "MainForm";
            this.Text = "Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Panel;
        private System.Windows.Forms.Button AddHouse;
        private System.Windows.Forms.Button SlowTechnics;
        private System.Windows.Forms.Button FastTechnics;
        private System.Windows.Forms.Button InstantTechnics;
    }
}

