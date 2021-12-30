
namespace CSharp_Work15_PainterWithForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxMain = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.buttonLoadFile = new System.Windows.Forms.Button();
            this.labelSquareSize = new System.Windows.Forms.Label();
            this.textBoxSquare = new System.Windows.Forms.TextBox();
            this.buttonEnterSquareSize = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 460);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(576, 628);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(183, 23);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(576, 497);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(116, 15);
            this.labelResult.TabIndex = 14;
            this.labelResult.Text = "Свободных клеток: ";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxMain
            // 
            this.textBoxMain.Location = new System.Drawing.Point(304, 494);
            this.textBoxMain.Multiline = true;
            this.textBoxMain.Name = "textBoxMain";
            this.textBoxMain.Size = new System.Drawing.Size(185, 118);
            this.textBoxMain.TabIndex = 4;
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(304, 628);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(185, 23);
            this.buttonEnter.TabIndex = 5;
            this.buttonEnter.Text = "Выполнить";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(88, 536);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(79, 19);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "Вариант 1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(88, 561);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(79, 19);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "Вариант 2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // buttonLoadFile
            // 
            this.buttonLoadFile.Location = new System.Drawing.Point(43, 628);
            this.buttonLoadFile.Name = "buttonLoadFile";
            this.buttonLoadFile.Size = new System.Drawing.Size(185, 23);
            this.buttonLoadFile.TabIndex = 3;
            this.buttonLoadFile.Text = "Загрузить из файла...";
            this.buttonLoadFile.UseVisualStyleBackColor = true;
            this.buttonLoadFile.Click += new System.EventHandler(this.buttonLoadFile_Click);
            // 
            // labelSquareSize
            // 
            this.labelSquareSize.AutoSize = true;
            this.labelSquareSize.Location = new System.Drawing.Point(576, 536);
            this.labelSquareSize.Name = "labelSquareSize";
            this.labelSquareSize.Size = new System.Drawing.Size(110, 15);
            this.labelSquareSize.TabIndex = 15;
            this.labelSquareSize.Text = "Размер ячейки:  50";
            // 
            // textBoxSquare
            // 
            this.textBoxSquare.Location = new System.Drawing.Point(576, 560);
            this.textBoxSquare.Name = "textBoxSquare";
            this.textBoxSquare.Size = new System.Drawing.Size(38, 23);
            this.textBoxSquare.TabIndex = 16;
            // 
            // buttonEnterSquareSize
            // 
            this.buttonEnterSquareSize.Location = new System.Drawing.Point(620, 561);
            this.buttonEnterSquareSize.Name = "buttonEnterSquareSize";
            this.buttonEnterSquareSize.Size = new System.Drawing.Size(139, 23);
            this.buttonEnterSquareSize.TabIndex = 17;
            this.buttonEnterSquareSize.Text = "Установить";
            this.buttonEnterSquareSize.UseVisualStyleBackColor = true;
            this.buttonEnterSquareSize.Click += new System.EventHandler(this.buttonEnterSquareSize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 675);
            this.Controls.Add(this.buttonEnterSquareSize);
            this.Controls.Add(this.textBoxSquare);
            this.Controls.Add(this.labelSquareSize);
            this.Controls.Add(this.buttonLoadFile);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textBoxMain);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Художник";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxMain;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button buttonLoadFile;
        private System.Windows.Forms.Label labelSquareSize;
        private System.Windows.Forms.TextBox textBoxSquare;
        private System.Windows.Forms.Button buttonEnterSquareSize;
    }
}

