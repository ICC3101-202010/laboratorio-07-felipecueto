namespace Lab7
{
    partial class Calculadora
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.HistoryPanel = new System.Windows.Forms.Panel();
            this.HistoryLabel = new System.Windows.Forms.Label();
            this.OperactionPanel = new System.Windows.Forms.Panel();
            this.SyntaxErrorLabel = new System.Windows.Forms.Label();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.OutputTextbox = new System.Windows.Forms.TextBox();
            this.IGUAL = new System.Windows.Forms.Button();
            this.MIN = new System.Windows.Forms.Button();
            this.HistorialButton = new System.Windows.Forms.Button();
            this.SUM = new System.Windows.Forms.Button();
            this.DIVITION = new System.Windows.Forms.Button();
            this.X = new System.Windows.Forms.Button();
            this.AC = new System.Windows.Forms.Button();
            this.DEL = new System.Windows.Forms.Button();
            this.Ans = new System.Windows.Forms.Button();
            this.Point = new System.Windows.Forms.Button();
            this.Button0 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.TextHistorial = new System.Windows.Forms.Label();
            this.DeleteHistoryButton = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.HistoryPanel.SuspendLayout();
            this.OperactionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.AutoSize = true;
            this.MainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainPanel.BackColor = System.Drawing.SystemColors.GrayText;
            this.MainPanel.Controls.Add(this.HistoryPanel);
            this.MainPanel.Controls.Add(this.OperactionPanel);
            this.MainPanel.Controls.Add(this.IGUAL);
            this.MainPanel.Controls.Add(this.MIN);
            this.MainPanel.Controls.Add(this.HistorialButton);
            this.MainPanel.Controls.Add(this.SUM);
            this.MainPanel.Controls.Add(this.DIVITION);
            this.MainPanel.Controls.Add(this.X);
            this.MainPanel.Controls.Add(this.AC);
            this.MainPanel.Controls.Add(this.DEL);
            this.MainPanel.Controls.Add(this.Ans);
            this.MainPanel.Controls.Add(this.Point);
            this.MainPanel.Controls.Add(this.Button0);
            this.MainPanel.Controls.Add(this.button9);
            this.MainPanel.Controls.Add(this.button8);
            this.MainPanel.Controls.Add(this.button7);
            this.MainPanel.Controls.Add(this.button6);
            this.MainPanel.Controls.Add(this.button5);
            this.MainPanel.Controls.Add(this.button4);
            this.MainPanel.Controls.Add(this.button3);
            this.MainPanel.Controls.Add(this.button2);
            this.MainPanel.Controls.Add(this.Button1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(848, 458);
            this.MainPanel.TabIndex = 0;
            // 
            // HistoryPanel
            // 
            this.HistoryPanel.AutoScroll = true;
            this.HistoryPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.HistoryPanel.Controls.Add(this.DeleteHistoryButton);
            this.HistoryPanel.Controls.Add(this.TextHistorial);
            this.HistoryPanel.Controls.Add(this.HistoryLabel);
            this.HistoryPanel.Location = new System.Drawing.Point(510, 23);
            this.HistoryPanel.Name = "HistoryPanel";
            this.HistoryPanel.Size = new System.Drawing.Size(276, 392);
            this.HistoryPanel.TabIndex = 21;
            this.HistoryPanel.Visible = false;
            // 
            // HistoryLabel
            // 
            this.HistoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryLabel.Location = new System.Drawing.Point(27, 68);
            this.HistoryLabel.Name = "HistoryLabel";
            this.HistoryLabel.Size = new System.Drawing.Size(222, 302);
            this.HistoryLabel.TabIndex = 0;
            // 
            // OperactionPanel
            // 
            this.OperactionPanel.BackColor = System.Drawing.Color.LightGray;
            this.OperactionPanel.Controls.Add(this.SyntaxErrorLabel);
            this.OperactionPanel.Controls.Add(this.OutputLabel);
            this.OperactionPanel.Controls.Add(this.OutputTextbox);
            this.OperactionPanel.Location = new System.Drawing.Point(62, 23);
            this.OperactionPanel.Name = "OperactionPanel";
            this.OperactionPanel.Size = new System.Drawing.Size(425, 163);
            this.OperactionPanel.TabIndex = 20;
            // 
            // SyntaxErrorLabel
            // 
            this.SyntaxErrorLabel.AutoSize = true;
            this.SyntaxErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SyntaxErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.SyntaxErrorLabel.Location = new System.Drawing.Point(191, 117);
            this.SyntaxErrorLabel.Name = "SyntaxErrorLabel";
            this.SyntaxErrorLabel.Size = new System.Drawing.Size(217, 40);
            this.SyntaxErrorLabel.TabIndex = 2;
            this.SyntaxErrorLabel.Text = "Syntax Error";
            this.SyntaxErrorLabel.Visible = false;
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.ForeColor = System.Drawing.Color.DimGray;
            this.OutputLabel.Location = new System.Drawing.Point(20, 36);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(0, 29);
            this.OutputLabel.TabIndex = 1;
            // 
            // OutputTextbox
            // 
            this.OutputTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputTextbox.Location = new System.Drawing.Point(25, 68);
            this.OutputTextbox.Multiline = true;
            this.OutputTextbox.Name = "OutputTextbox";
            this.OutputTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.OutputTextbox.Size = new System.Drawing.Size(383, 46);
            this.OutputTextbox.TabIndex = 0;
            this.OutputTextbox.Text = "0";
            this.OutputTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // IGUAL
            // 
            this.IGUAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IGUAL.Location = new System.Drawing.Point(390, 368);
            this.IGUAL.Name = "IGUAL";
            this.IGUAL.Size = new System.Drawing.Size(97, 48);
            this.IGUAL.TabIndex = 19;
            this.IGUAL.Text = "=";
            this.IGUAL.UseVisualStyleBackColor = true;
            this.IGUAL.Click += new System.EventHandler(this.IGUAL_Click);
            // 
            // MIN
            // 
            this.MIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MIN.Location = new System.Drawing.Point(390, 313);
            this.MIN.Name = "MIN";
            this.MIN.Size = new System.Drawing.Size(97, 49);
            this.MIN.TabIndex = 18;
            this.MIN.Text = "-";
            this.MIN.UseVisualStyleBackColor = true;
            this.MIN.Click += new System.EventHandler(this.Operation_Button);
            // 
            // HistorialButton
            // 
            this.HistorialButton.Location = new System.Drawing.Point(287, 368);
            this.HistorialButton.Name = "HistorialButton";
            this.HistorialButton.Size = new System.Drawing.Size(97, 48);
            this.HistorialButton.TabIndex = 17;
            this.HistorialButton.Text = "Historial";
            this.HistorialButton.UseVisualStyleBackColor = true;
            this.HistorialButton.Click += new System.EventHandler(this.HistorialButton_Click);
            // 
            // SUM
            // 
            this.SUM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUM.Location = new System.Drawing.Point(287, 313);
            this.SUM.Name = "SUM";
            this.SUM.Size = new System.Drawing.Size(97, 49);
            this.SUM.TabIndex = 16;
            this.SUM.Text = "+";
            this.SUM.UseVisualStyleBackColor = true;
            this.SUM.Click += new System.EventHandler(this.Operation_Button);
            // 
            // DIVITION
            // 
            this.DIVITION.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DIVITION.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIVITION.Location = new System.Drawing.Point(390, 258);
            this.DIVITION.MaximumSize = new System.Drawing.Size(97, 49);
            this.DIVITION.MinimumSize = new System.Drawing.Size(97, 49);
            this.DIVITION.Name = "DIVITION";
            this.DIVITION.Size = new System.Drawing.Size(97, 49);
            this.DIVITION.TabIndex = 15;
            this.DIVITION.Text = " ÷";
            this.DIVITION.UseVisualStyleBackColor = true;
            this.DIVITION.Click += new System.EventHandler(this.Operation_Button);
            // 
            // X
            // 
            this.X.Location = new System.Drawing.Point(287, 258);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(97, 49);
            this.X.TabIndex = 14;
            this.X.Text = "X";
            this.X.UseVisualStyleBackColor = true;
            this.X.Click += new System.EventHandler(this.Operation_Button);
            // 
            // AC
            // 
            this.AC.BackColor = System.Drawing.Color.IndianRed;
            this.AC.Location = new System.Drawing.Point(390, 201);
            this.AC.Name = "AC";
            this.AC.Size = new System.Drawing.Size(97, 49);
            this.AC.TabIndex = 13;
            this.AC.Text = "AC";
            this.AC.UseVisualStyleBackColor = false;
            this.AC.Click += new System.EventHandler(this.AC_Click);
            // 
            // DEL
            // 
            this.DEL.BackColor = System.Drawing.Color.IndianRed;
            this.DEL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DEL.Location = new System.Drawing.Point(287, 201);
            this.DEL.Name = "DEL";
            this.DEL.Size = new System.Drawing.Size(97, 49);
            this.DEL.TabIndex = 12;
            this.DEL.Text = "DEL";
            this.DEL.UseVisualStyleBackColor = false;
            this.DEL.Click += new System.EventHandler(this.DEL_Click);
            // 
            // Ans
            // 
            this.Ans.Location = new System.Drawing.Point(212, 368);
            this.Ans.Name = "Ans";
            this.Ans.Size = new System.Drawing.Size(69, 48);
            this.Ans.TabIndex = 11;
            this.Ans.Text = "Ans";
            this.Ans.UseVisualStyleBackColor = true;
            this.Ans.Click += new System.EventHandler(this.Ans_Click);
            // 
            // Point
            // 
            this.Point.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Point.Location = new System.Drawing.Point(137, 368);
            this.Point.Name = "Point";
            this.Point.Size = new System.Drawing.Size(69, 48);
            this.Point.TabIndex = 10;
            this.Point.Text = ".";
            this.Point.UseVisualStyleBackColor = true;
            this.Point.Click += new System.EventHandler(this.Button_Click);
            // 
            // Button0
            // 
            this.Button0.Location = new System.Drawing.Point(62, 368);
            this.Button0.Name = "Button0";
            this.Button0.Size = new System.Drawing.Size(69, 48);
            this.Button0.TabIndex = 9;
            this.Button0.Text = "0";
            this.Button0.UseVisualStyleBackColor = true;
            this.Button0.Click += new System.EventHandler(this.Button_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(212, 201);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(69, 49);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(137, 201);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(69, 49);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(62, 203);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(69, 49);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(212, 258);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(69, 49);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(137, 258);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(69, 49);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(62, 258);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(69, 49);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(212, 313);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 49);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(137, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(62, 313);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(69, 49);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "1";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button_Click);
            // 
            // TextHistorial
            // 
            this.TextHistorial.AutoSize = true;
            this.TextHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextHistorial.Location = new System.Drawing.Point(26, 24);
            this.TextHistorial.Name = "TextHistorial";
            this.TextHistorial.Size = new System.Drawing.Size(110, 29);
            this.TextHistorial.TabIndex = 1;
            this.TextHistorial.Text = "Historial";
            // 
            // DeleteHistoryButton
            // 
            this.DeleteHistoryButton.Location = new System.Drawing.Point(173, 24);
            this.DeleteHistoryButton.Name = "DeleteHistoryButton";
            this.DeleteHistoryButton.Size = new System.Drawing.Size(76, 29);
            this.DeleteHistoryButton.TabIndex = 2;
            this.DeleteHistoryButton.Text = "Borrar";
            this.DeleteHistoryButton.UseVisualStyleBackColor = true;
            this.DeleteHistoryButton.Click += new System.EventHandler(this.DeleteHistoryButton_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 458);
            this.Controls.Add(this.MainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(870, 514);
            this.MinimumSize = new System.Drawing.Size(870, 514);
            this.Name = "Calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.MainPanel.ResumeLayout(false);
            this.HistoryPanel.ResumeLayout(false);
            this.HistoryPanel.PerformLayout();
            this.OperactionPanel.ResumeLayout(false);
            this.OperactionPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button IGUAL;
        private System.Windows.Forms.Button MIN;
        private System.Windows.Forms.Button HistorialButton;
        private System.Windows.Forms.Button SUM;
        private System.Windows.Forms.Button DIVITION;
        private System.Windows.Forms.Button X;
        private System.Windows.Forms.Button AC;
        private System.Windows.Forms.Button DEL;
        private System.Windows.Forms.Button Ans;
        private System.Windows.Forms.Button Point;
        private System.Windows.Forms.Button Button0;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Panel HistoryPanel;
        private System.Windows.Forms.Panel OperactionPanel;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.TextBox OutputTextbox;
        private System.Windows.Forms.Label SyntaxErrorLabel;
        private System.Windows.Forms.Label HistoryLabel;
        private System.Windows.Forms.Button DeleteHistoryButton;
        private System.Windows.Forms.Label TextHistorial;
    }
}

