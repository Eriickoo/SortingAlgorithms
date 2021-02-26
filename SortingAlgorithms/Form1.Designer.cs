
namespace SortingAlgorithms
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonBubbleS = new System.Windows.Forms.Button();
            this.buttonInsertionS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownNumbers = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDelay = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumbers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(657, 426);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "Sort";
            // 
            // buttonBubbleS
            // 
            this.buttonBubbleS.Location = new System.Drawing.Point(700, 212);
            this.buttonBubbleS.Name = "buttonBubbleS";
            this.buttonBubbleS.Size = new System.Drawing.Size(119, 30);
            this.buttonBubbleS.TabIndex = 1;
            this.buttonBubbleS.Text = "Bubble Sort";
            this.buttonBubbleS.UseVisualStyleBackColor = true;
            this.buttonBubbleS.Click += new System.EventHandler(this.buttonBubbleS_Click);
            // 
            // buttonInsertionS
            // 
            this.buttonInsertionS.Location = new System.Drawing.Point(700, 279);
            this.buttonInsertionS.Name = "buttonInsertionS";
            this.buttonInsertionS.Size = new System.Drawing.Size(119, 30);
            this.buttonInsertionS.TabIndex = 2;
            this.buttonInsertionS.Text = "Insertion Sort";
            this.buttonInsertionS.UseVisualStyleBackColor = true;
            this.buttonInsertionS.Click += new System.EventHandler(this.buttonInsertionS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(697, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number of datums:";
            // 
            // numericUpDownNumbers
            // 
            this.numericUpDownNumbers.Location = new System.Drawing.Point(799, 44);
            this.numericUpDownNumbers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumbers.Name = "numericUpDownNumbers";
            this.numericUpDownNumbers.Size = new System.Drawing.Size(65, 20);
            this.numericUpDownNumbers.TabIndex = 5;
            this.numericUpDownNumbers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownDelay
            // 
            this.numericUpDownDelay.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownDelay.Location = new System.Drawing.Point(799, 80);
            this.numericUpDownDelay.Name = "numericUpDownDelay";
            this.numericUpDownDelay.Size = new System.Drawing.Size(65, 20);
            this.numericUpDownDelay.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(697, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Delay (miliseconds):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownDelay);
            this.Controls.Add(this.numericUpDownNumbers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonInsertionS);
            this.Controls.Add(this.buttonBubbleS);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumbers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonBubbleS;
        private System.Windows.Forms.Button buttonInsertionS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownNumbers;
        private System.Windows.Forms.NumericUpDown numericUpDownDelay;
        private System.Windows.Forms.Label label2;
    }
}

