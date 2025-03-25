namespace KP_WINFORM_RACE
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            this.blueRunner = new System.Windows.Forms.Button();
            this.redRunner = new System.Windows.Forms.Button();
            this.purpleRunner = new System.Windows.Forms.Button();
            this.yellowRunner = new System.Windows.Forms.Button();
            this.greenRunner = new System.Windows.Forms.Button();
            this.lblMoney = new System.Windows.Forms.Label();
            this.tbBet = new System.Windows.Forms.TextBox();
            this.btnBet = new System.Windows.Forms.Button();
            this.lblRunner = new System.Windows.Forms.Label();
            this.lblBet = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblError = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // blueRunner
            // 
            this.blueRunner.Location = new System.Drawing.Point(255, 38);
            this.blueRunner.Margin = new System.Windows.Forms.Padding(4);
            this.blueRunner.Name = "blueRunner";
            this.blueRunner.Size = new System.Drawing.Size(133, 66);
            this.blueRunner.TabIndex = 0;
            this.blueRunner.Text = "blueRunner";
            this.blueRunner.UseVisualStyleBackColor = true;
            this.blueRunner.Click += new System.EventHandler(this.blueRunner_Click);
            // 
            // redRunner
            // 
            this.redRunner.Location = new System.Drawing.Point(255, 114);
            this.redRunner.Margin = new System.Windows.Forms.Padding(4);
            this.redRunner.Name = "redRunner";
            this.redRunner.Size = new System.Drawing.Size(133, 70);
            this.redRunner.TabIndex = 1;
            this.redRunner.Text = "redRunner";
            this.redRunner.UseVisualStyleBackColor = true;
            this.redRunner.Click += new System.EventHandler(this.redRunner_Click);
            // 
            // purpleRunner
            // 
            this.purpleRunner.Location = new System.Drawing.Point(255, 266);
            this.purpleRunner.Margin = new System.Windows.Forms.Padding(4);
            this.purpleRunner.Name = "purpleRunner";
            this.purpleRunner.Size = new System.Drawing.Size(133, 70);
            this.purpleRunner.TabIndex = 3;
            this.purpleRunner.Text = "purpleRunner";
            this.purpleRunner.UseVisualStyleBackColor = true;
            this.purpleRunner.Click += new System.EventHandler(this.purpleRunner_Click);
            // 
            // yellowRunner
            // 
            this.yellowRunner.Location = new System.Drawing.Point(255, 190);
            this.yellowRunner.Margin = new System.Windows.Forms.Padding(4);
            this.yellowRunner.Name = "yellowRunner";
            this.yellowRunner.Size = new System.Drawing.Size(133, 70);
            this.yellowRunner.TabIndex = 2;
            this.yellowRunner.Text = "yellowRunner";
            this.yellowRunner.UseVisualStyleBackColor = true;
            this.yellowRunner.Click += new System.EventHandler(this.yellowRunner_Click);
            // 
            // greenRunner
            // 
            this.greenRunner.Location = new System.Drawing.Point(255, 342);
            this.greenRunner.Margin = new System.Windows.Forms.Padding(4);
            this.greenRunner.Name = "greenRunner";
            this.greenRunner.Size = new System.Drawing.Size(133, 70);
            this.greenRunner.TabIndex = 4;
            this.greenRunner.Text = "greenRunner";
            this.greenRunner.UseVisualStyleBackColor = true;
            this.greenRunner.Click += new System.EventHandler(this.greenRunner_Click);
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblMoney.Location = new System.Drawing.Point(627, 38);
            this.lblMoney.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(159, 29);
            this.lblMoney.TabIndex = 5;
            this.lblMoney.Text = "Money: 5000";
            // 
            // tbBet
            // 
            this.tbBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbBet.Location = new System.Drawing.Point(610, 281);
            this.tbBet.Margin = new System.Windows.Forms.Padding(4);
            this.tbBet.Name = "tbBet";
            this.tbBet.Size = new System.Drawing.Size(143, 36);
            this.tbBet.TabIndex = 6;
            this.tbBet.TextChanged += new System.EventHandler(this.tbBet_TextChanged);
            // 
            // btnBet
            // 
            this.btnBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnBet.Location = new System.Drawing.Point(535, 379);
            this.btnBet.Margin = new System.Windows.Forms.Padding(4);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(154, 36);
            this.btnBet.TabIndex = 7;
            this.btnBet.Text = "Bet";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // lblRunner
            // 
            this.lblRunner.AutoSize = true;
            this.lblRunner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblRunner.Location = new System.Drawing.Point(16, 15);
            this.lblRunner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRunner.Name = "lblRunner";
            this.lblRunner.Size = new System.Drawing.Size(191, 29);
            this.lblRunner.TabIndex = 8;
            this.lblRunner.Text = "Runner: Runner";
            // 
            // lblBet
            // 
            this.lblBet.AutoSize = true;
            this.lblBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblBet.Location = new System.Drawing.Point(15, 59);
            this.lblBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(107, 29);
            this.lblBet.TabIndex = 9;
            this.lblBet.Text = "Bet: 100";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblError.ForeColor = System.Drawing.Color.Brown;
            this.lblError.Location = new System.Drawing.Point(478, 342);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 20);
            this.lblError.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblRunner);
            this.panel1.Controls.Add(this.lblBet);
            this.panel1.Location = new System.Drawing.Point(467, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 113);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(478, 290);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Enter your bet";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.lblResult);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.lblMoney);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.tbBet);
            this.panel2.Controls.Add(this.greenRunner);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.purpleRunner);
            this.panel2.Controls.Add(this.btnBet);
            this.panel2.Controls.Add(this.yellowRunner);
            this.panel2.Controls.Add(this.redRunner);
            this.panel2.Controls.Add(this.lblError);
            this.panel2.Controls.Add(this.blueRunner);
            this.panel2.Location = new System.Drawing.Point(62, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(944, 433);
            this.panel2.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(798, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::KP_WINFORM_RACE.Properties.Resources.Зеленый;
            this.pictureBox5.Location = new System.Drawing.Point(178, 342);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(70, 70);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::KP_WINFORM_RACE.Properties.Resources.Фиолетовый;
            this.pictureBox4.Location = new System.Drawing.Point(178, 266);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(70, 70);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(723, 24);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 16);
            this.lblResult.TabIndex = 18;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::KP_WINFORM_RACE.Properties.Resources.Желтый1;
            this.pictureBox3.Location = new System.Drawing.Point(178, 190);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(70, 70);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::KP_WINFORM_RACE.Properties.Resources.Красный;
            this.pictureBox2.Location = new System.Drawing.Point(178, 114);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KP_WINFORM_RACE.Properties.Resources.Синий;
            this.pictureBox1.Location = new System.Drawing.Point(178, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::KP_WINFORM_RACE.Properties.Resources.InsideTrack_GTASAde_Logo;
            this.pictureBox6.Location = new System.Drawing.Point(457, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(138, 75);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(798, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Set Money";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 564);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox6);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button blueRunner;
        private System.Windows.Forms.Button redRunner;
        private System.Windows.Forms.Button purpleRunner;
        private System.Windows.Forms.Button yellowRunner;
        private System.Windows.Forms.Button greenRunner;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.TextBox tbBet;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.Label lblRunner;
        private System.Windows.Forms.Label lblBet;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

