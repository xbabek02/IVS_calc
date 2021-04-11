namespace IVS_calc
{
    partial class Kalkulátor
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kalkulátor));
            this.button_1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.help = new System.Windows.Forms.PictureBox();
            this.button_bracketsecond = new System.Windows.Forms.Button();
            this.button_sqrt = new System.Windows.Forms.Button();
            this.button_divide = new System.Windows.Forms.Button();
            this.button_eq = new System.Windows.Forms.Button();
            this.button_power = new System.Windows.Forms.Button();
            this.button_brackerfirst = new System.Windows.Forms.Button();
            this.button_multiply = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_factor = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.button_delOne = new System.Windows.Forms.Button();
            this.button2_delAll = new System.Windows.Forms.Button();
            this.textbox_example = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_point = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.help)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_1
            // 
            this.button_1.BackColor = System.Drawing.SystemColors.Window;
            this.button_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_1.Font = new System.Drawing.Font("Orbitron", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_1.Location = new System.Drawing.Point(7, 3);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(71, 68);
            this.button_1.TabIndex = 0;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = false;
            this.button_1.Click += new System.EventHandler(this.button_1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button_0);
            this.panel1.Controls.Add(this.button_point);
            this.panel1.Controls.Add(this.button_9);
            this.panel1.Controls.Add(this.button_8);
            this.panel1.Controls.Add(this.button_7);
            this.panel1.Controls.Add(this.button_6);
            this.panel1.Controls.Add(this.button_5);
            this.panel1.Controls.Add(this.button_4);
            this.panel1.Controls.Add(this.button_3);
            this.panel1.Controls.Add(this.button_2);
            this.panel1.Controls.Add(this.button_1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 302);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.help);
            this.panel2.Controls.Add(this.button_bracketsecond);
            this.panel2.Controls.Add(this.button_sqrt);
            this.panel2.Controls.Add(this.button_divide);
            this.panel2.Controls.Add(this.button_eq);
            this.panel2.Controls.Add(this.button_power);
            this.panel2.Controls.Add(this.button_brackerfirst);
            this.panel2.Controls.Add(this.button_multiply);
            this.panel2.Controls.Add(this.button_minus);
            this.panel2.Controls.Add(this.button_factor);
            this.panel2.Controls.Add(this.button_plus);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(254, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 302);
            this.panel2.TabIndex = 2;
            // 
            // help
            // 
            this.help.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("help.BackgroundImage")));
            this.help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.help.Location = new System.Drawing.Point(157, 225);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(71, 68);
            this.help.TabIndex = 1;
            this.help.TabStop = false;
            // 
            // button_bracketsecond
            // 
            this.button_bracketsecond.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button_bracketsecond.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_bracketsecond.Font = new System.Drawing.Font("Orbitron", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_bracketsecond.Location = new System.Drawing.Point(157, 151);
            this.button_bracketsecond.Name = "button_bracketsecond";
            this.button_bracketsecond.Size = new System.Drawing.Size(71, 68);
            this.button_bracketsecond.TabIndex = 0;
            this.button_bracketsecond.Text = ")";
            this.button_bracketsecond.UseVisualStyleBackColor = false;
            this.button_bracketsecond.Click += new System.EventHandler(this.button_1_Click);
            // 
            // button_sqrt
            // 
            this.button_sqrt.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button_sqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sqrt.Font = new System.Drawing.Font("Orbitron", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sqrt.Location = new System.Drawing.Point(80, 151);
            this.button_sqrt.Name = "button_sqrt";
            this.button_sqrt.Size = new System.Drawing.Size(71, 68);
            this.button_sqrt.TabIndex = 0;
            this.button_sqrt.Text = "√";
            this.button_sqrt.UseVisualStyleBackColor = false;
            this.button_sqrt.Click += new System.EventHandler(this.button_power_Click);
            // 
            // button_divide
            // 
            this.button_divide.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button_divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_divide.Font = new System.Drawing.Font("Orbitron", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_divide.Location = new System.Drawing.Point(80, 77);
            this.button_divide.Name = "button_divide";
            this.button_divide.Size = new System.Drawing.Size(71, 68);
            this.button_divide.TabIndex = 0;
            this.button_divide.Text = "/";
            this.button_divide.UseVisualStyleBackColor = false;
            this.button_divide.Click += new System.EventHandler(this.button_1_Click);
            // 
            // button_eq
            // 
            this.button_eq.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button_eq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_eq.Font = new System.Drawing.Font("Orbitron", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_eq.Location = new System.Drawing.Point(3, 225);
            this.button_eq.Name = "button_eq";
            this.button_eq.Size = new System.Drawing.Size(148, 68);
            this.button_eq.TabIndex = 0;
            this.button_eq.Text = "=";
            this.button_eq.UseVisualStyleBackColor = false;
            this.button_eq.Click += new System.EventHandler(this.button_eq_Click);
            // 
            // button_power
            // 
            this.button_power.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button_power.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_power.Font = new System.Drawing.Font("Orbitron", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_power.Location = new System.Drawing.Point(3, 151);
            this.button_power.Name = "button_power";
            this.button_power.Size = new System.Drawing.Size(71, 68);
            this.button_power.TabIndex = 0;
            this.button_power.Text = "^";
            this.button_power.UseVisualStyleBackColor = false;
            this.button_power.Click += new System.EventHandler(this.button_power_Click);
            // 
            // button_brackerfirst
            // 
            this.button_brackerfirst.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button_brackerfirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_brackerfirst.Font = new System.Drawing.Font("Orbitron", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_brackerfirst.Location = new System.Drawing.Point(157, 77);
            this.button_brackerfirst.Name = "button_brackerfirst";
            this.button_brackerfirst.Size = new System.Drawing.Size(71, 68);
            this.button_brackerfirst.TabIndex = 0;
            this.button_brackerfirst.Text = "(";
            this.button_brackerfirst.UseVisualStyleBackColor = false;
            this.button_brackerfirst.Click += new System.EventHandler(this.button_1_Click);
            // 
            // button_multiply
            // 
            this.button_multiply.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button_multiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_multiply.Font = new System.Drawing.Font("Orbitron", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_multiply.Location = new System.Drawing.Point(3, 77);
            this.button_multiply.Name = "button_multiply";
            this.button_multiply.Size = new System.Drawing.Size(71, 68);
            this.button_multiply.TabIndex = 0;
            this.button_multiply.Text = "*";
            this.button_multiply.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_multiply.UseVisualStyleBackColor = false;
            this.button_multiply.Click += new System.EventHandler(this.button_1_Click);
            // 
            // button_minus
            // 
            this.button_minus.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button_minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minus.Font = new System.Drawing.Font("Orbitron", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_minus.Location = new System.Drawing.Point(80, 3);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(71, 68);
            this.button_minus.TabIndex = 0;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = false;
            this.button_minus.Click += new System.EventHandler(this.button_1_Click);
            // 
            // button_factor
            // 
            this.button_factor.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button_factor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_factor.Font = new System.Drawing.Font("Orbitron", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_factor.Location = new System.Drawing.Point(157, 3);
            this.button_factor.Name = "button_factor";
            this.button_factor.Size = new System.Drawing.Size(71, 68);
            this.button_factor.TabIndex = 0;
            this.button_factor.Text = "!";
            this.button_factor.UseVisualStyleBackColor = false;
            this.button_factor.Click += new System.EventHandler(this.button_1_Click);
            // 
            // button_plus
            // 
            this.button_plus.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button_plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_plus.Font = new System.Drawing.Font("Orbitron", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_plus.Location = new System.Drawing.Point(3, 3);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(71, 68);
            this.button_plus.TabIndex = 0;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = false;
            this.button_plus.Click += new System.EventHandler(this.button_1_Click);
            // 
            // button_0
            // 
            this.button_0.BackColor = System.Drawing.SystemColors.Window;
            this.button_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_0.Font = new System.Drawing.Font("Orbitron", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_0.Location = new System.Drawing.Point(7, 225);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(148, 68);
            this.button_0.TabIndex = 0;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = false;
            this.button_0.Click += new System.EventHandler(this.button_1_Click);
            // 
            // button_9
            // 
            this.button_9.BackColor = System.Drawing.SystemColors.Window;
            this.button_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_9.Font = new System.Drawing.Font("Orbitron", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_9.Location = new System.Drawing.Point(161, 151);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(71, 68);
            this.button_9.TabIndex = 0;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = false;
            this.button_9.Click += new System.EventHandler(this.button_1_Click);
            // 
            // button_8
            // 
            this.button_8.BackColor = System.Drawing.SystemColors.Window;
            this.button_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_8.Font = new System.Drawing.Font("Orbitron", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_8.Location = new System.Drawing.Point(84, 151);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(71, 68);
            this.button_8.TabIndex = 0;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = false;
            this.button_8.Click += new System.EventHandler(this.button_1_Click);
            // 
            // button_7
            // 
            this.button_7.BackColor = System.Drawing.SystemColors.Window;
            this.button_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_7.Font = new System.Drawing.Font("Orbitron", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_7.Location = new System.Drawing.Point(7, 151);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(71, 68);
            this.button_7.TabIndex = 0;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = false;
            this.button_7.Click += new System.EventHandler(this.button_1_Click);
            // 
            // button_6
            // 
            this.button_6.BackColor = System.Drawing.SystemColors.Window;
            this.button_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_6.Font = new System.Drawing.Font("Orbitron", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_6.Location = new System.Drawing.Point(161, 77);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(71, 68);
            this.button_6.TabIndex = 0;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = false;
            this.button_6.Click += new System.EventHandler(this.button_1_Click);
            // 
            // button_5
            // 
            this.button_5.BackColor = System.Drawing.SystemColors.Window;
            this.button_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_5.Font = new System.Drawing.Font("Orbitron", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_5.Location = new System.Drawing.Point(84, 77);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(71, 68);
            this.button_5.TabIndex = 0;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = false;
            this.button_5.Click += new System.EventHandler(this.button_1_Click);
            // 
            // button_4
            // 
            this.button_4.BackColor = System.Drawing.SystemColors.Window;
            this.button_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_4.Font = new System.Drawing.Font("Orbitron", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_4.Location = new System.Drawing.Point(7, 77);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(71, 68);
            this.button_4.TabIndex = 0;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = false;
            this.button_4.Click += new System.EventHandler(this.button_1_Click);
            // 
            // button_3
            // 
            this.button_3.BackColor = System.Drawing.SystemColors.Window;
            this.button_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_3.Font = new System.Drawing.Font("Orbitron", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_3.Location = new System.Drawing.Point(161, 3);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(71, 68);
            this.button_3.TabIndex = 0;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = false;
            this.button_3.Click += new System.EventHandler(this.button_1_Click);
            // 
            // button_2
            // 
            this.button_2.BackColor = System.Drawing.SystemColors.Window;
            this.button_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_2.Font = new System.Drawing.Font("Orbitron", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_2.Location = new System.Drawing.Point(84, 3);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(71, 68);
            this.button_2.TabIndex = 0;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = false;
            this.button_2.Click += new System.EventHandler(this.button_1_Click);
            // 
            // textBox_result
            // 
            this.textBox_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_result.Location = new System.Drawing.Point(160, 139);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.Size = new System.Drawing.Size(321, 42);
            this.textBox_result.TabIndex = 1;
            this.textBox_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button_delOne
            // 
            this.button_delOne.BackColor = System.Drawing.SystemColors.Window;
            this.button_delOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delOne.Font = new System.Drawing.Font("Orbitron", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delOne.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_delOne.Location = new System.Drawing.Point(104, 139);
            this.button_delOne.Name = "button_delOne";
            this.button_delOne.Size = new System.Drawing.Size(50, 43);
            this.button_delOne.TabIndex = 0;
            this.button_delOne.Text = "⌫";
            this.button_delOne.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_delOne.UseVisualStyleBackColor = false;
            this.button_delOne.Click += new System.EventHandler(this.button_delOne_Click);
            // 
            // button2_delAll
            // 
            this.button2_delAll.BackColor = System.Drawing.SystemColors.Window;
            this.button2_delAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2_delAll.Font = new System.Drawing.Font("Orbitron", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2_delAll.Location = new System.Drawing.Point(7, 139);
            this.button2_delAll.Name = "button2_delAll";
            this.button2_delAll.Size = new System.Drawing.Size(91, 43);
            this.button2_delAll.TabIndex = 0;
            this.button2_delAll.Text = "DEL";
            this.button2_delAll.UseVisualStyleBackColor = false;
            this.button2_delAll.Click += new System.EventHandler(this.button2_delAll_Click);
            // 
            // textbox_example
            // 
            this.textbox_example.Font = new System.Drawing.Font("Orbitron", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_example.Location = new System.Drawing.Point(5, 4);
            this.textbox_example.Multiline = true;
            this.textbox_example.Name = "textbox_example";
            this.textbox_example.ReadOnly = true;
            this.textbox_example.Size = new System.Drawing.Size(463, 114);
            this.textbox_example.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Controls.Add(this.textbox_example);
            this.panel3.Location = new System.Drawing.Point(7, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(474, 125);
            this.panel3.TabIndex = 2;
            // 
            // button_point
            // 
            this.button_point.BackColor = System.Drawing.SystemColors.Window;
            this.button_point.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_point.Font = new System.Drawing.Font("Orbitron", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_point.Location = new System.Drawing.Point(160, 225);
            this.button_point.Name = "button_point";
            this.button_point.Size = new System.Drawing.Size(71, 68);
            this.button_point.TabIndex = 0;
            this.button_point.Text = ",";
            this.button_point.UseVisualStyleBackColor = false;
            this.button_point.Click += new System.EventHandler(this.button_1_Click);
            // 
            // Kalkulátor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(493, 495);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2_delAll);
            this.Controls.Add(this.button_delOne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Kalkulátor";
            this.Text = "Kalkulátor";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.help)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_sqrt;
        private System.Windows.Forms.Button button_divide;
        private System.Windows.Forms.Button button_eq;
        private System.Windows.Forms.Button button_power;
        private System.Windows.Forms.Button button_multiply;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_bracketsecond;
        private System.Windows.Forms.Button button_brackerfirst;
        private System.Windows.Forms.Button button_factor;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Button button_delOne;
        private System.Windows.Forms.Button button2_delAll;
        private System.Windows.Forms.TextBox textbox_example;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox help;
        private System.Windows.Forms.Button button_point;
    }
}

