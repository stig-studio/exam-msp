namespace Converter_WF
{
    partial class main_form
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
            this.txtb_deg = new System.Windows.Forms.TextBox();
            this.btn_deg_to_rad = new System.Windows.Forms.Button();
            this.txtb_rad_res = new System.Windows.Forms.TextBox();
            this.lbl_deg_to_rad = new System.Windows.Forms.Label();
            this.lbl_rad_to_deg = new System.Windows.Forms.Label();
            this.txtb_deg_res = new System.Windows.Forms.TextBox();
            this.btn_rad_to_deg = new System.Windows.Forms.Button();
            this.txtb_rad = new System.Windows.Forms.TextBox();
            this.lbl_km_to_ml = new System.Windows.Forms.Label();
            this.txtb_ml_res = new System.Windows.Forms.TextBox();
            this.btn_km_to_ml = new System.Windows.Forms.Button();
            this.txtb_km = new System.Windows.Forms.TextBox();
            this.lbl_ml_to_km = new System.Windows.Forms.Label();
            this.txtb_km_res = new System.Windows.Forms.TextBox();
            this.btn_ml_to_km = new System.Windows.Forms.Button();
            this.txtb_ml = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtb_deg
            // 
            this.txtb_deg.Location = new System.Drawing.Point(54, 39);
            this.txtb_deg.Name = "txtb_deg";
            this.txtb_deg.Size = new System.Drawing.Size(78, 20);
            this.txtb_deg.TabIndex = 0;
            this.txtb_deg.TextChanged += new System.EventHandler(this.txtb_TextChanged);
            // 
            // btn_deg_to_rad
            // 
            this.btn_deg_to_rad.Enabled = false;
            this.btn_deg_to_rad.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_deg_to_rad.Location = new System.Drawing.Point(138, 38);
            this.btn_deg_to_rad.Name = "btn_deg_to_rad";
            this.btn_deg_to_rad.Size = new System.Drawing.Size(38, 22);
            this.btn_deg_to_rad.TabIndex = 1;
            this.btn_deg_to_rad.Text = "->";
            this.btn_deg_to_rad.UseVisualStyleBackColor = true;
            this.btn_deg_to_rad.Click += new System.EventHandler(this.btn_deg_to_rad_Click);
            // 
            // txtb_rad_res
            // 
            this.txtb_rad_res.Location = new System.Drawing.Point(181, 39);
            this.txtb_rad_res.Name = "txtb_rad_res";
            this.txtb_rad_res.Size = new System.Drawing.Size(78, 20);
            this.txtb_rad_res.TabIndex = 2;
            // 
            // lbl_deg_to_rad
            // 
            this.lbl_deg_to_rad.AutoSize = true;
            this.lbl_deg_to_rad.Location = new System.Drawing.Point(107, 22);
            this.lbl_deg_to_rad.Name = "lbl_deg_to_rad";
            this.lbl_deg_to_rad.Size = new System.Drawing.Size(106, 13);
            this.lbl_deg_to_rad.TabIndex = 3;
            this.lbl_deg_to_rad.Text = "Градусы в радианы";
            // 
            // lbl_rad_to_deg
            // 
            this.lbl_rad_to_deg.AutoSize = true;
            this.lbl_rad_to_deg.Location = new System.Drawing.Point(107, 82);
            this.lbl_rad_to_deg.Name = "lbl_rad_to_deg";
            this.lbl_rad_to_deg.Size = new System.Drawing.Size(106, 13);
            this.lbl_rad_to_deg.TabIndex = 7;
            this.lbl_rad_to_deg.Text = "Радианы в градусы";
            // 
            // txtb_deg_res
            // 
            this.txtb_deg_res.Location = new System.Drawing.Point(181, 99);
            this.txtb_deg_res.Name = "txtb_deg_res";
            this.txtb_deg_res.Size = new System.Drawing.Size(78, 20);
            this.txtb_deg_res.TabIndex = 6;
            // 
            // btn_rad_to_deg
            // 
            this.btn_rad_to_deg.Enabled = false;
            this.btn_rad_to_deg.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_rad_to_deg.Location = new System.Drawing.Point(138, 98);
            this.btn_rad_to_deg.Name = "btn_rad_to_deg";
            this.btn_rad_to_deg.Size = new System.Drawing.Size(38, 22);
            this.btn_rad_to_deg.TabIndex = 5;
            this.btn_rad_to_deg.Text = "->";
            this.btn_rad_to_deg.UseVisualStyleBackColor = true;
            this.btn_rad_to_deg.Click += new System.EventHandler(this.btn_rad_to_deg_Click);
            // 
            // txtb_rad
            // 
            this.txtb_rad.Location = new System.Drawing.Point(54, 99);
            this.txtb_rad.Name = "txtb_rad";
            this.txtb_rad.Size = new System.Drawing.Size(78, 20);
            this.txtb_rad.TabIndex = 4;
            this.txtb_rad.TextChanged += new System.EventHandler(this.txtb_TextChanged);
            // 
            // lbl_km_to_ml
            // 
            this.lbl_km_to_ml.AutoSize = true;
            this.lbl_km_to_ml.Location = new System.Drawing.Point(107, 138);
            this.lbl_km_to_ml.Name = "lbl_km_to_ml";
            this.lbl_km_to_ml.Size = new System.Drawing.Size(103, 13);
            this.lbl_km_to_ml.TabIndex = 11;
            this.lbl_km_to_ml.Text = "Километры в мили";
            // 
            // txtb_ml_res
            // 
            this.txtb_ml_res.Location = new System.Drawing.Point(181, 155);
            this.txtb_ml_res.Name = "txtb_ml_res";
            this.txtb_ml_res.Size = new System.Drawing.Size(78, 20);
            this.txtb_ml_res.TabIndex = 10;
            // 
            // btn_km_to_ml
            // 
            this.btn_km_to_ml.Enabled = false;
            this.btn_km_to_ml.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_km_to_ml.Location = new System.Drawing.Point(138, 154);
            this.btn_km_to_ml.Name = "btn_km_to_ml";
            this.btn_km_to_ml.Size = new System.Drawing.Size(38, 22);
            this.btn_km_to_ml.TabIndex = 9;
            this.btn_km_to_ml.Text = "->";
            this.btn_km_to_ml.UseVisualStyleBackColor = true;
            this.btn_km_to_ml.Click += new System.EventHandler(this.btn_km_to_ml_Click);
            // 
            // txtb_km
            // 
            this.txtb_km.Location = new System.Drawing.Point(54, 155);
            this.txtb_km.Name = "txtb_km";
            this.txtb_km.Size = new System.Drawing.Size(78, 20);
            this.txtb_km.TabIndex = 8;
            this.txtb_km.TextChanged += new System.EventHandler(this.txtb_TextChanged);
            // 
            // lbl_ml_to_km
            // 
            this.lbl_ml_to_km.AutoSize = true;
            this.lbl_ml_to_km.Location = new System.Drawing.Point(107, 191);
            this.lbl_ml_to_km.Name = "lbl_ml_to_km";
            this.lbl_ml_to_km.Size = new System.Drawing.Size(103, 13);
            this.lbl_ml_to_km.TabIndex = 15;
            this.lbl_ml_to_km.Text = "Мили в километры";
            // 
            // txtb_km_res
            // 
            this.txtb_km_res.Location = new System.Drawing.Point(181, 208);
            this.txtb_km_res.Name = "txtb_km_res";
            this.txtb_km_res.Size = new System.Drawing.Size(78, 20);
            this.txtb_km_res.TabIndex = 14;
            // 
            // btn_ml_to_km
            // 
            this.btn_ml_to_km.Enabled = false;
            this.btn_ml_to_km.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_ml_to_km.Location = new System.Drawing.Point(138, 207);
            this.btn_ml_to_km.Name = "btn_ml_to_km";
            this.btn_ml_to_km.Size = new System.Drawing.Size(38, 22);
            this.btn_ml_to_km.TabIndex = 13;
            this.btn_ml_to_km.Text = "->";
            this.btn_ml_to_km.UseVisualStyleBackColor = true;
            this.btn_ml_to_km.Click += new System.EventHandler(this.btn_ml_to_km_Click);
            // 
            // txtb_ml
            // 
            this.txtb_ml.Location = new System.Drawing.Point(54, 208);
            this.txtb_ml.Name = "txtb_ml";
            this.txtb_ml.Size = new System.Drawing.Size(78, 20);
            this.txtb_ml.TabIndex = 12;
            this.txtb_ml.TextChanged += new System.EventHandler(this.txtb_TextChanged);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 265);
            this.Controls.Add(this.lbl_ml_to_km);
            this.Controls.Add(this.txtb_km_res);
            this.Controls.Add(this.btn_ml_to_km);
            this.Controls.Add(this.txtb_ml);
            this.Controls.Add(this.lbl_km_to_ml);
            this.Controls.Add(this.txtb_ml_res);
            this.Controls.Add(this.btn_km_to_ml);
            this.Controls.Add(this.txtb_km);
            this.Controls.Add(this.lbl_rad_to_deg);
            this.Controls.Add(this.txtb_deg_res);
            this.Controls.Add(this.btn_rad_to_deg);
            this.Controls.Add(this.txtb_rad);
            this.Controls.Add(this.lbl_deg_to_rad);
            this.Controls.Add(this.txtb_rad_res);
            this.Controls.Add(this.btn_deg_to_rad);
            this.Controls.Add(this.txtb_deg);
            this.Name = "main_form";
            this.Text = "Converter";
            this.Load += new System.EventHandler(this.main_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb_deg;
        private System.Windows.Forms.Button btn_deg_to_rad;
        private System.Windows.Forms.TextBox txtb_rad_res;
        private System.Windows.Forms.Label lbl_deg_to_rad;
        private System.Windows.Forms.Label lbl_rad_to_deg;
        private System.Windows.Forms.TextBox txtb_deg_res;
        private System.Windows.Forms.Button btn_rad_to_deg;
        private System.Windows.Forms.TextBox txtb_rad;
        private System.Windows.Forms.Label lbl_km_to_ml;
        private System.Windows.Forms.TextBox txtb_ml_res;
        private System.Windows.Forms.Button btn_km_to_ml;
        private System.Windows.Forms.TextBox txtb_km;
        private System.Windows.Forms.Label lbl_ml_to_km;
        private System.Windows.Forms.TextBox txtb_km_res;
        private System.Windows.Forms.Button btn_ml_to_km;
        private System.Windows.Forms.TextBox txtb_ml;
    }
}

