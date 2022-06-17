
namespace TestAndScore
{
    partial class SystemForm
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
<<<<<<< HEAD
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
=======
            this.customButton1 = new CustomControls.CustomControls.CustomButton();
            this.customButton2 = new CustomControls.CustomControls.CustomButton();
>>>>>>> 07880e5d68c4b13ac0667928e256ec7b90f27273
            this.SuspendLayout();
            // 
            // customButton1
            // 
<<<<<<< HEAD
            this.button1.Location = new System.Drawing.Point(158, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 68);
            this.button1.TabIndex = 0;
            this.button1.Text = "Quản lý tài khoản";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
=======
            this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(162)))), ((int)(((byte)(93)))));
            this.customButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(162)))), ((int)(((byte)(93)))));
            this.customButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton1.BorderRadius = 15;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(237, 178);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(200, 72);
            this.customButton1.TabIndex = 2;
            this.customButton1.Text = "Quản lý tài khoản";
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
>>>>>>> 07880e5d68c4b13ac0667928e256ec7b90f27273
            // 
            // customButton2
            // 
<<<<<<< HEAD
            this.button2.Location = new System.Drawing.Point(469, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 68);
            this.button2.TabIndex = 1;
            this.button2.Text = "Quản lý câu hỏi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
=======
            this.customButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(162)))), ((int)(((byte)(93)))));
            this.customButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(162)))), ((int)(((byte)(93)))));
            this.customButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton2.BorderRadius = 15;
            this.customButton2.BorderSize = 0;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.Location = new System.Drawing.Point(237, 282);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(200, 72);
            this.customButton2.TabIndex = 3;
            this.customButton2.Text = "Quản lý câu hỏi";
            this.customButton2.TextColor = System.Drawing.Color.White;
            this.customButton2.UseVisualStyleBackColor = false;
            this.customButton2.Click += new System.EventHandler(this.customButton2_Click);
>>>>>>> 07880e5d68c4b13ac0667928e256ec7b90f27273
            // 
            // SystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(246)))));
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(773, 719);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
=======
            this.ClientSize = new System.Drawing.Size(687, 575);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.customButton1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> 07880e5d68c4b13ac0667928e256ec7b90f27273
            this.Name = "SystemForm";
            this.Text = "SystemForm";
            this.ResumeLayout(false);

        }

        #endregion

<<<<<<< HEAD
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
=======
        private CustomControls.CustomControls.CustomButton customButton1;
        private CustomControls.CustomControls.CustomButton customButton2;
>>>>>>> 07880e5d68c4b13ac0667928e256ec7b90f27273
    }
}