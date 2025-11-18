using System.Drawing;

namespace JogoDaVelha
{
    partial class FormJogo
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.gbPlacar = new System.Windows.Forms.GroupBox();
            this.lbEmpate = new System.Windows.Forms.Label();
            this.lbJogadorO = new System.Windows.Forms.Label();
            this.lbJogadorX = new System.Windows.Forms.Label();
            this.btnResetar = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.gbPlacar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btn1.Location = new System.Drawing.Point(12, 12);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(60, 60);
            this.btn1.TabIndex = 0;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btn2.Location = new System.Drawing.Point(78, 12);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(60, 60);
            this.btn2.TabIndex = 1;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btn3.Location = new System.Drawing.Point(144, 12);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(60, 60);
            this.btn3.TabIndex = 2;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btn5.Location = new System.Drawing.Point(78, 78);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(60, 60);
            this.btn5.TabIndex = 4;
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btn6.Location = new System.Drawing.Point(144, 78);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(60, 60);
            this.btn6.TabIndex = 5;
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn_Click);
            // 
            // gbPlacar
            // 
            this.gbPlacar.Controls.Add(this.lbEmpate);
            this.gbPlacar.Controls.Add(this.lbJogadorO);
            this.gbPlacar.Controls.Add(this.lbJogadorX);
            this.gbPlacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.gbPlacar.Location = new System.Drawing.Point(210, 12);
            this.gbPlacar.Name = "gbPlacar";
            this.gbPlacar.Size = new System.Drawing.Size(200, 120);
            this.gbPlacar.TabIndex = 6;
            this.gbPlacar.TabStop = false;
            this.gbPlacar.Text = "Placar";
            // 
            // lbEmpate
            // 
            this.lbEmpate.AutoSize = true;
            this.lbEmpate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbEmpate.Location = new System.Drawing.Point(6, 88);
            this.lbEmpate.Name = "lbEmpate";
            this.lbEmpate.Size = new System.Drawing.Size(60, 17);
            this.lbEmpate.TabIndex = 10;
            this.lbEmpate.Text = "Empate: 0";
            // 
            // lbJogadorO
            // 
            this.lbJogadorO.AutoSize = true;
            this.lbJogadorO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbJogadorO.Location = new System.Drawing.Point(6, 55);
            this.lbJogadorO.Name = "lbJogadorO";
            this.lbJogadorO.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbJogadorO.Size = new System.Drawing.Size(79, 17);
            this.lbJogadorO.TabIndex = 9;
            this.lbJogadorO.Text = "Jogador O: 0";
            this.lbJogadorO.ForeColor = Color.Red;
            // 
            // lbJogadorX
            // 
            this.lbJogadorX.AutoSize = true;
            this.lbJogadorX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbJogadorX.Location = new System.Drawing.Point(6, 22);
            this.lbJogadorX.Name = "lbJogadorX";
            this.lbJogadorX.Size = new System.Drawing.Size(81, 17);
            this.lbJogadorX.TabIndex = 8;
            this.lbJogadorX.Text = "Jogador X: 0";
            this.lbJogadorX.ForeColor = Color.Blue;
            // 
            // btnResetar
            // 
            this.btnResetar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnResetar.Location = new System.Drawing.Point(210, 168);
            this.btnResetar.Name = "btnResetar";
            this.btnResetar.Size = new System.Drawing.Size(200, 36);
            this.btnResetar.TabIndex = 7;
            this.btnResetar.Text = "Resetar";
            this.btnResetar.UseVisualStyleBackColor = true;
            this.btnResetar.Click += new System.EventHandler(this.btnResetar_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btn4.Location = new System.Drawing.Point(12, 78);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(60, 60);
            this.btn4.TabIndex = 3;
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btn9.Location = new System.Drawing.Point(144, 144);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(60, 60);
            this.btn9.TabIndex = 12;
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btn8.Location = new System.Drawing.Point(78, 144);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(60, 60);
            this.btn8.TabIndex = 13;
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btn7.Location = new System.Drawing.Point(12, 144);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(60, 60);
            this.btn7.TabIndex = 14;
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn_Click);
            // 
            // tbResultado
            // 
            this.tbResultado.Location = new System.Drawing.Point(210, 144);
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.ReadOnly = true;
            this.tbResultado.Size = new System.Drawing.Size(200, 20);
            this.tbResultado.TabIndex = 15;
            // 
            // FormJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 211);
            this.Controls.Add(this.tbResultado);
            this.Controls.Add(this.btnResetar);
            this.Controls.Add(this.gbPlacar);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.MaximizeBox = false;
            this.Name = "FormJogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Velha";
            this.Load += new System.EventHandler(this.FormJogo_Load);
            this.gbPlacar.ResumeLayout(false);
            this.gbPlacar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.GroupBox gbPlacar;
        private System.Windows.Forms.Button btnResetar;
        private System.Windows.Forms.Label lbJogadorX;
        private System.Windows.Forms.Label lbEmpate;
        private System.Windows.Forms.Label lbJogadorO;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.TextBox tbResultado;
    }
}

