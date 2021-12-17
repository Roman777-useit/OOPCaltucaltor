namespace task_paint
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.figureRectangle = new System.Windows.Forms.RadioButton();
            this.figureCircle = new System.Windows.Forms.RadioButton();
            this.figureWagon = new System.Windows.Forms.RadioButton();
            this.figureWagonCoal = new System.Windows.Forms.RadioButton();
            this.radioMove = new System.Windows.Forms.RadioButton();
            this.figureTrain = new System.Windows.Forms.RadioButton();
            this.radioRemove = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(1400, 700);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 700);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // figureRectangle
            // 
            this.figureRectangle.AutoSize = true;
            this.figureRectangle.Dock = System.Windows.Forms.DockStyle.Left;
            this.figureRectangle.Location = new System.Drawing.Point(0, 700);
            this.figureRectangle.Name = "figureRectangle";
            this.figureRectangle.Size = new System.Drawing.Size(74, 0);
            this.figureRectangle.TabIndex = 0;
            this.figureRectangle.TabStop = true;
            this.figureRectangle.Text = "Rectangle";
            this.figureRectangle.UseVisualStyleBackColor = true;
            // 
            // figureCircle
            // 
            this.figureCircle.AutoSize = true;
            this.figureCircle.Dock = System.Windows.Forms.DockStyle.Left;
            this.figureCircle.Location = new System.Drawing.Point(74, 700);
            this.figureCircle.Name = "figureCircle";
            this.figureCircle.Size = new System.Drawing.Size(51, 0);
            this.figureCircle.TabIndex = 2;
            this.figureCircle.TabStop = true;
            this.figureCircle.Text = "Circle";
            this.figureCircle.UseVisualStyleBackColor = true;
            // 
            // figureWagon
            // 
            this.figureWagon.AutoSize = true;
            this.figureWagon.Dock = System.Windows.Forms.DockStyle.Left;
            this.figureWagon.Location = new System.Drawing.Point(125, 700);
            this.figureWagon.Name = "figureWagon";
            this.figureWagon.Size = new System.Drawing.Size(60, 0);
            this.figureWagon.TabIndex = 3;
            this.figureWagon.TabStop = true;
            this.figureWagon.Text = "Wagon";
            this.figureWagon.UseVisualStyleBackColor = true;
            // 
            // figureWagonCoal
            // 
            this.figureWagonCoal.AutoSize = true;
            this.figureWagonCoal.Dock = System.Windows.Forms.DockStyle.Left;
            this.figureWagonCoal.Location = new System.Drawing.Point(185, 700);
            this.figureWagonCoal.Name = "figureWagonCoal";
            this.figureWagonCoal.Size = new System.Drawing.Size(81, 0);
            this.figureWagonCoal.TabIndex = 4;
            this.figureWagonCoal.TabStop = true;
            this.figureWagonCoal.Text = "WagonCoal";
            this.figureWagonCoal.UseVisualStyleBackColor = true;
            // 
            // radioMove
            // 
            this.radioMove.AutoSize = true;
            this.radioMove.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioMove.Location = new System.Drawing.Point(266, 700);
            this.radioMove.Name = "radioMove";
            this.radioMove.Size = new System.Drawing.Size(52, 0);
            this.radioMove.TabIndex = 5;
            this.radioMove.TabStop = true;
            this.radioMove.Text = "Move";
            this.radioMove.UseVisualStyleBackColor = true;
            // 
            // figureTrain
            // 
            this.figureTrain.AutoSize = true;
            this.figureTrain.Dock = System.Windows.Forms.DockStyle.Left;
            this.figureTrain.Location = new System.Drawing.Point(318, 700);
            this.figureTrain.Name = "figureTrain";
            this.figureTrain.Size = new System.Drawing.Size(49, 0);
            this.figureTrain.TabIndex = 6;
            this.figureTrain.TabStop = true;
            this.figureTrain.Text = "Train";
            this.figureTrain.UseVisualStyleBackColor = true;
            // 
            // radioRemove
            // 
            this.radioRemove.AutoSize = true;
            this.radioRemove.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioRemove.Location = new System.Drawing.Point(367, 700);
            this.radioRemove.Name = "radioRemove";
            this.radioRemove.Size = new System.Drawing.Size(65, 0);
            this.radioRemove.TabIndex = 7;
            this.radioRemove.TabStop = true;
            this.radioRemove.Text = "Remove";
            this.radioRemove.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 520);
            this.Controls.Add(this.radioRemove);
            this.Controls.Add(this.figureTrain);
            this.Controls.Add(this.radioMove);
            this.Controls.Add(this.figureWagonCoal);
            this.Controls.Add(this.figureWagon);
            this.Controls.Add(this.figureCircle);
            this.Controls.Add(this.figureRectangle);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton figureRectangle;
        private System.Windows.Forms.RadioButton figureCircle;
        private System.Windows.Forms.RadioButton figureWagon;
        private System.Windows.Forms.RadioButton figureWagonCoal;
        private System.Windows.Forms.RadioButton radioMove;
        private System.Windows.Forms.RadioButton figureTrain;
        private System.Windows.Forms.RadioButton radioRemove;
    }
}

