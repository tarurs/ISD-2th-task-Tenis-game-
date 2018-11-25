namespace Tenis_Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playground = new System.Windows.Forms.Panel();
            this.gameOver_label = new System.Windows.Forms.Label();
            this.point_label = new System.Windows.Forms.Label();
            this.score_label = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.rocket = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocket)).BeginInit();
            this.SuspendLayout();
            // 
            // playground
            // 
            this.playground.Controls.Add(this.gameOver_label);
            this.playground.Controls.Add(this.point_label);
            this.playground.Controls.Add(this.score_label);
            this.playground.Controls.Add(this.ball);
            this.playground.Controls.Add(this.rocket);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(590, 430);
            this.playground.TabIndex = 0;
            // 
            // gameOver_label
            // 
            this.gameOver_label.AutoSize = true;
            this.gameOver_label.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameOver_label.Location = new System.Drawing.Point(62, 65);
            this.gameOver_label.Name = "gameOver_label";
            this.gameOver_label.Size = new System.Drawing.Size(471, 285);
            this.gameOver_label.TabIndex = 4;
            this.gameOver_label.Text = "Oops...you lose. Try again!\r\n\r\n\r\nF1 - restart\r\nEsc - exit";
            this.gameOver_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // point_label
            // 
            this.point_label.AutoSize = true;
            this.point_label.BackColor = System.Drawing.Color.Transparent;
            this.point_label.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.point_label.Location = new System.Drawing.Point(67, 3);
            this.point_label.Name = "point_label";
            this.point_label.Size = new System.Drawing.Size(23, 25);
            this.point_label.TabIndex = 3;
            this.point_label.Text = "0";
            // 
            // score_label
            // 
            this.score_label.AutoSize = true;
            this.score_label.BackColor = System.Drawing.Color.Transparent;
            this.score_label.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.score_label.Location = new System.Drawing.Point(3, 3);
            this.score_label.Name = "score_label";
            this.score_label.Size = new System.Drawing.Size(68, 25);
            this.score_label.TabIndex = 2;
            this.score_label.Text = "Score:";
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Transparent;
            this.ball.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ball.BackgroundImage")));
            this.ball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ball.Location = new System.Drawing.Point(26, 44);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(30, 30);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // rocket
            // 
            this.rocket.BackColor = System.Drawing.Color.Black;
            this.rocket.Location = new System.Drawing.Point(245, 395);
            this.rocket.Name = "rocket";
            this.rocket.Size = new System.Drawing.Size(200, 10);
            this.rocket.TabIndex = 0;
            this.rocket.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 430);
            this.Controls.Add(this.playground);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Tenis";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.playground.ResumeLayout(false);
            this.playground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playground;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox rocket;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label point_label;
        private System.Windows.Forms.Label score_label;
        private System.Windows.Forms.Label gameOver_label;
    }
}

