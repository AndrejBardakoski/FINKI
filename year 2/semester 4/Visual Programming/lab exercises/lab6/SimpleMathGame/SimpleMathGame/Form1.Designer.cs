namespace SimpleMathGame
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRemainingTime = new System.Windows.Forms.Label();
            this.pbPoints = new System.Windows.Forms.ProgressBar();
            this.pbTime = new System.Windows.Forms.ProgressBar();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnBestScores = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tbOperant1 = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbOperator = new System.Windows.Forms.TextBox();
            this.tbOperant2 = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Играч";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Поени:";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(79, 131);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(44, 16);
            this.lblPoints.TabIndex = 2;
            this.lblPoints.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Преостанато време:";
            // 
            // lblRemainingTime
            // 
            this.lblRemainingTime.AutoSize = true;
            this.lblRemainingTime.Location = new System.Drawing.Point(169, 228);
            this.lblRemainingTime.Name = "lblRemainingTime";
            this.lblRemainingTime.Size = new System.Drawing.Size(44, 16);
            this.lblRemainingTime.TabIndex = 4;
            this.lblRemainingTime.Text = "label5";
            // 
            // pbPoints
            // 
            this.pbPoints.Location = new System.Drawing.Point(12, 180);
            this.pbPoints.Name = "pbPoints";
            this.pbPoints.Size = new System.Drawing.Size(566, 23);
            this.pbPoints.TabIndex = 5;
            // 
            // pbTime
            // 
            this.pbTime.Location = new System.Drawing.Point(12, 269);
            this.pbTime.Name = "pbTime";
            this.pbTime.Size = new System.Drawing.Size(566, 23);
            this.pbTime.TabIndex = 6;
            // 
            // btnGuess
            // 
            this.btnGuess.Enabled = false;
            this.btnGuess.Location = new System.Drawing.Point(530, 76);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(75, 23);
            this.btnGuess.TabIndex = 7;
            this.btnGuess.Text = "Погоди";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(12, 319);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(126, 23);
            this.btnNewGame.TabIndex = 8;
            this.btnNewGame.Text = "Нова игра";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnBestScores
            // 
            this.btnBestScores.Location = new System.Drawing.Point(216, 319);
            this.btnBestScores.Name = "btnBestScores";
            this.btnBestScores.Size = new System.Drawing.Size(155, 23);
            this.btnBestScores.TabIndex = 9;
            this.btnBestScores.Text = "Најдобри играчи";
            this.btnBestScores.UseVisualStyleBackColor = true;
            this.btnBestScores.Click += new System.EventHandler(this.btnBestScores_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(495, 319);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Исклучи";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tbOperant1
            // 
            this.tbOperant1.Enabled = false;
            this.tbOperant1.Location = new System.Drawing.Point(38, 76);
            this.tbOperant1.Name = "tbOperant1";
            this.tbOperant1.Size = new System.Drawing.Size(100, 22);
            this.tbOperant1.TabIndex = 11;
            // 
            // tbName
            // 
            this.tbName.Enabled = false;
            this.tbName.Location = new System.Drawing.Point(82, 25);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(131, 22);
            this.tbName.TabIndex = 12;
            // 
            // tbOperator
            // 
            this.tbOperator.Enabled = false;
            this.tbOperator.Location = new System.Drawing.Point(164, 76);
            this.tbOperator.Name = "tbOperator";
            this.tbOperator.Size = new System.Drawing.Size(49, 22);
            this.tbOperator.TabIndex = 13;
            // 
            // tbOperant2
            // 
            this.tbOperant2.Enabled = false;
            this.tbOperant2.Location = new System.Drawing.Point(245, 76);
            this.tbOperant2.Name = "tbOperant2";
            this.tbOperant2.Size = new System.Drawing.Size(100, 22);
            this.tbOperant2.TabIndex = 14;
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(414, 76);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(100, 22);
            this.tbResult.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "=";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnGuess;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 379);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.tbOperant2);
            this.Controls.Add(this.tbOperator);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbOperant1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBestScores);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.pbTime);
            this.Controls.Add(this.pbPoints);
            this.Controls.Add(this.lblRemainingTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRemainingTime;
        private System.Windows.Forms.ProgressBar pbPoints;
        private System.Windows.Forms.ProgressBar pbTime;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnBestScores;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox tbOperant1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbOperator;
        private System.Windows.Forms.TextBox tbOperant2;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
    }
}

