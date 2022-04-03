
namespace Puzzle
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
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.Shuffle = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.movesMade = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.frame3 = new System.Windows.Forms.PictureBox();
            this.frame9 = new System.Windows.Forms.PictureBox();
            this.frame7 = new System.Windows.Forms.PictureBox();
            this.frame5 = new System.Windows.Forms.PictureBox();
            this.frame2 = new System.Windows.Forms.PictureBox();
            this.frame1 = new System.Windows.Forms.PictureBox();
            this.frame8 = new System.Windows.Forms.PictureBox();
            this.frame6 = new System.Windows.Forms.PictureBox();
            this.frame4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frame3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frame9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frame7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frame5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frame2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frame1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frame8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frame6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frame4)).BeginInit();
            this.SuspendLayout();
            // 
            // Shuffle
            // 
            this.Shuffle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Shuffle.Location = new System.Drawing.Point(502, 455);
            this.Shuffle.Name = "Shuffle";
            this.Shuffle.Size = new System.Drawing.Size(75, 23);
            this.Shuffle.TabIndex = 13;
            this.Shuffle.Text = "Shuffle";
            this.Shuffle.UseVisualStyleBackColor = true;
            this.Shuffle.Click += new System.EventHandler(this.Shuffle_Click);
            // 
            // Quit
            // 
            this.Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Quit.Location = new System.Drawing.Point(777, 455);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(75, 23);
            this.Quit.TabIndex = 14;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            // 
            // Pause
            // 
            this.Pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pause.Location = new System.Drawing.Point(638, 455);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(75, 23);
            this.Pause.TabIndex = 15;
            this.Pause.Text = "Pause";
            this.Pause.UseVisualStyleBackColor = true;
            // 
            // movesMade
            // 
            this.movesMade.AutoSize = true;
            this.movesMade.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.movesMade.Location = new System.Drawing.Point(11, 455);
            this.movesMade.Name = "movesMade";
            this.movesMade.Size = new System.Drawing.Size(267, 39);
            this.movesMade.TabIndex = 18;
            this.movesMade.Text = "Moves made: 0";
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timer.Location = new System.Drawing.Point(599, 389);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(159, 39);
            this.timer.TabIndex = 19;
            this.timer.Text = "00:01:30";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::Puzzle.Properties.Resources.чихуахуа;
            this.pictureBox.Location = new System.Drawing.Point(502, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(350, 350);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 12;
            this.pictureBox.TabStop = false;
            // 
            // frame3
            // 
            this.frame3.Image = global::Puzzle.Properties.Resources.image_part_003;
            this.frame3.Location = new System.Drawing.Point(284, 12);
            this.frame3.Name = "frame3";
            this.frame3.Size = new System.Drawing.Size(130, 130);
            this.frame3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frame3.TabIndex = 11;
            this.frame3.TabStop = false;
            // 
            // frame9
            // 
            this.frame9.Image = global::Puzzle.Properties.Resources.image_part_009;
            this.frame9.Location = new System.Drawing.Point(284, 284);
            this.frame9.Name = "frame9";
            this.frame9.Size = new System.Drawing.Size(130, 130);
            this.frame9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frame9.TabIndex = 10;
            this.frame9.TabStop = false;
            // 
            // frame7
            // 
            this.frame7.Image = global::Puzzle.Properties.Resources.image_part_007;
            this.frame7.Location = new System.Drawing.Point(12, 284);
            this.frame7.Name = "frame7";
            this.frame7.Size = new System.Drawing.Size(130, 130);
            this.frame7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frame7.TabIndex = 9;
            this.frame7.TabStop = false;
            // 
            // frame5
            // 
            this.frame5.Image = global::Puzzle.Properties.Resources.image_part_005;
            this.frame5.Location = new System.Drawing.Point(148, 148);
            this.frame5.Name = "frame5";
            this.frame5.Size = new System.Drawing.Size(130, 130);
            this.frame5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frame5.TabIndex = 8;
            this.frame5.TabStop = false;
            // 
            // frame2
            // 
            this.frame2.Image = global::Puzzle.Properties.Resources.image_part_002;
            this.frame2.Location = new System.Drawing.Point(148, 12);
            this.frame2.Name = "frame2";
            this.frame2.Size = new System.Drawing.Size(130, 130);
            this.frame2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frame2.TabIndex = 7;
            this.frame2.TabStop = false;
            // 
            // frame1
            // 
            this.frame1.Image = global::Puzzle.Properties.Resources.black;
            this.frame1.Location = new System.Drawing.Point(12, 12);
            this.frame1.Name = "frame1";
            this.frame1.Size = new System.Drawing.Size(130, 130);
            this.frame1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frame1.TabIndex = 6;
            this.frame1.TabStop = false;
            // 
            // frame8
            // 
            this.frame8.Image = global::Puzzle.Properties.Resources.image_part_008;
            this.frame8.Location = new System.Drawing.Point(148, 284);
            this.frame8.Name = "frame8";
            this.frame8.Size = new System.Drawing.Size(130, 130);
            this.frame8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frame8.TabIndex = 5;
            this.frame8.TabStop = false;
            // 
            // frame6
            // 
            this.frame6.Image = global::Puzzle.Properties.Resources.image_part_006;
            this.frame6.Location = new System.Drawing.Point(284, 148);
            this.frame6.Name = "frame6";
            this.frame6.Size = new System.Drawing.Size(130, 130);
            this.frame6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frame6.TabIndex = 3;
            this.frame6.TabStop = false;
            // 
            // frame4
            // 
            this.frame4.Image = global::Puzzle.Properties.Resources.image_part_004;
            this.frame4.Location = new System.Drawing.Point(12, 148);
            this.frame4.Name = "frame4";
            this.frame4.Size = new System.Drawing.Size(130, 130);
            this.frame4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frame4.TabIndex = 1;
            this.frame4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 524);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.movesMade);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Shuffle);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.frame3);
            this.Controls.Add(this.frame9);
            this.Controls.Add(this.frame7);
            this.Controls.Add(this.frame5);
            this.Controls.Add(this.frame2);
            this.Controls.Add(this.frame1);
            this.Controls.Add(this.frame8);
            this.Controls.Add(this.frame6);
            this.Controls.Add(this.frame4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frame3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frame9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frame7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frame5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frame2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frame1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frame8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frame6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frame4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox frame4;
        private System.Windows.Forms.PictureBox frame6;
        private System.Windows.Forms.PictureBox frame8;
        private System.Windows.Forms.PictureBox frame1;
        private System.Windows.Forms.PictureBox frame2;
        private System.Windows.Forms.PictureBox frame5;
        private System.Windows.Forms.PictureBox frame7;
        private System.Windows.Forms.PictureBox frame9;
        private System.Windows.Forms.PictureBox frame3;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Button Shuffle;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Label movesMade;
        private System.Windows.Forms.Label timer;
    }
}

