namespace MMEP
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
            this.cbDeterm = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nStSpawnRate = new System.Windows.Forms.NumericUpDown();
            this.nTAB = new System.Windows.Forms.NumericUpDown();
            this.nTBC = new System.Windows.Forms.NumericUpDown();
            this.nTCA = new System.Windows.Forms.NumericUpDown();
            this.nU1SpawnCnt = new System.Windows.Forms.NumericUpDown();
            this.nU2SpawnCnt = new System.Windows.Forms.NumericUpDown();
            this.nBusMaxCnt = new System.Windows.Forms.NumericUpDown();
            this.nBusMaxCapacity = new System.Windows.Forms.NumericUpDown();
            this.nBreackingChance = new System.Windows.Forms.NumericUpDown();
            this.nAvgAwaitTime = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.progressBarA = new System.Windows.Forms.ProgressBar();
            this.progressBarB = new System.Windows.Forms.ProgressBar();
            this.progressBarC = new System.Windows.Forms.ProgressBar();
            this.nDelay = new System.Windows.Forms.NumericUpDown();
            this.labelDelay = new System.Windows.Forms.Label();
            this.labelStA = new System.Windows.Forms.Label();
            this.labelStB = new System.Windows.Forms.Label();
            this.labelStC = new System.Windows.Forms.Label();
            this.tick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.act = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgBusLoad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nStSpawnRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTAB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTBC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTCA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nU1SpawnCnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nU2SpawnCnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBusMaxCnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBusMaxCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBreackingChance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAvgAwaitTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDeterm
            // 
            this.cbDeterm.AutoSize = true;
            this.cbDeterm.Enabled = false;
            this.cbDeterm.Location = new System.Drawing.Point(12, 12);
            this.cbDeterm.Name = "cbDeterm";
            this.cbDeterm.Size = new System.Drawing.Size(85, 24);
            this.cbDeterm.TabIndex = 0;
            this.cbDeterm.Text = "determ";
            this.cbDeterm.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "stSpawnRate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "tAB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "tBC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "tCA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "u1SpawnCnt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "u2SpawnCnt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "busMaxCnt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "busMaxCapacity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "breackingChance";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 380);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "avgAwaitTime";
            // 
            // nStSpawnRate
            // 
            this.nStSpawnRate.Location = new System.Drawing.Point(154, 50);
            this.nStSpawnRate.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nStSpawnRate.Name = "nStSpawnRate";
            this.nStSpawnRate.Size = new System.Drawing.Size(75, 26);
            this.nStSpawnRate.TabIndex = 21;
            // 
            // nTAB
            // 
            this.nTAB.Location = new System.Drawing.Point(154, 80);
            this.nTAB.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nTAB.Name = "nTAB";
            this.nTAB.Size = new System.Drawing.Size(75, 26);
            this.nTAB.TabIndex = 22;
            // 
            // nTBC
            // 
            this.nTBC.Location = new System.Drawing.Point(154, 110);
            this.nTBC.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nTBC.Name = "nTBC";
            this.nTBC.Size = new System.Drawing.Size(75, 26);
            this.nTBC.TabIndex = 23;
            // 
            // nTCA
            // 
            this.nTCA.Location = new System.Drawing.Point(154, 140);
            this.nTCA.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nTCA.Name = "nTCA";
            this.nTCA.Size = new System.Drawing.Size(75, 26);
            this.nTCA.TabIndex = 24;
            // 
            // nU1SpawnCnt
            // 
            this.nU1SpawnCnt.Location = new System.Drawing.Point(154, 170);
            this.nU1SpawnCnt.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nU1SpawnCnt.Name = "nU1SpawnCnt";
            this.nU1SpawnCnt.Size = new System.Drawing.Size(75, 26);
            this.nU1SpawnCnt.TabIndex = 25;
            // 
            // nU2SpawnCnt
            // 
            this.nU2SpawnCnt.Location = new System.Drawing.Point(154, 200);
            this.nU2SpawnCnt.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nU2SpawnCnt.Name = "nU2SpawnCnt";
            this.nU2SpawnCnt.Size = new System.Drawing.Size(75, 26);
            this.nU2SpawnCnt.TabIndex = 26;
            // 
            // nBusMaxCnt
            // 
            this.nBusMaxCnt.Location = new System.Drawing.Point(154, 230);
            this.nBusMaxCnt.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nBusMaxCnt.Name = "nBusMaxCnt";
            this.nBusMaxCnt.Size = new System.Drawing.Size(75, 26);
            this.nBusMaxCnt.TabIndex = 27;
            // 
            // nBusMaxCapacity
            // 
            this.nBusMaxCapacity.Location = new System.Drawing.Point(154, 260);
            this.nBusMaxCapacity.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nBusMaxCapacity.Name = "nBusMaxCapacity";
            this.nBusMaxCapacity.Size = new System.Drawing.Size(75, 26);
            this.nBusMaxCapacity.TabIndex = 28;
            // 
            // nBreackingChance
            // 
            this.nBreackingChance.Location = new System.Drawing.Point(154, 290);
            this.nBreackingChance.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nBreackingChance.Name = "nBreackingChance";
            this.nBreackingChance.Size = new System.Drawing.Size(75, 26);
            this.nBreackingChance.TabIndex = 29;
            // 
            // nAvgAwaitTime
            // 
            this.nAvgAwaitTime.Enabled = false;
            this.nAvgAwaitTime.Location = new System.Drawing.Point(154, 380);
            this.nAvgAwaitTime.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nAvgAwaitTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nAvgAwaitTime.Name = "nAvgAwaitTime";
            this.nAvgAwaitTime.ReadOnly = true;
            this.nAvgAwaitTime.Size = new System.Drawing.Size(75, 26);
            this.nAvgAwaitTime.TabIndex = 30;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tick,
            this.a,
            this.b,
            this.c,
            this.act,
            this.avgBusLoad});
            this.dataGridView1.Location = new System.Drawing.Point(254, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(553, 356);
            this.dataGridView1.TabIndex = 31;
            // 
            // progressBarA
            // 
            this.progressBarA.Location = new System.Drawing.Point(870, 50);
            this.progressBarA.Maximum = 300;
            this.progressBarA.Name = "progressBarA";
            this.progressBarA.Size = new System.Drawing.Size(231, 23);
            this.progressBarA.TabIndex = 32;
            // 
            // progressBarB
            // 
            this.progressBarB.Location = new System.Drawing.Point(870, 80);
            this.progressBarB.Maximum = 300;
            this.progressBarB.Name = "progressBarB";
            this.progressBarB.Size = new System.Drawing.Size(231, 23);
            this.progressBarB.TabIndex = 33;
            // 
            // progressBarC
            // 
            this.progressBarC.Location = new System.Drawing.Point(870, 110);
            this.progressBarC.Maximum = 300;
            this.progressBarC.Name = "progressBarC";
            this.progressBarC.Size = new System.Drawing.Size(231, 23);
            this.progressBarC.TabIndex = 34;
            // 
            // nDelay
            // 
            this.nDelay.Enabled = false;
            this.nDelay.Location = new System.Drawing.Point(302, 13);
            this.nDelay.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nDelay.Name = "nDelay";
            this.nDelay.ReadOnly = true;
            this.nDelay.Size = new System.Drawing.Size(136, 26);
            this.nDelay.TabIndex = 35;
            // 
            // labelDelay
            // 
            this.labelDelay.AutoSize = true;
            this.labelDelay.Location = new System.Drawing.Point(250, 13);
            this.labelDelay.Name = "labelDelay";
            this.labelDelay.Size = new System.Drawing.Size(46, 20);
            this.labelDelay.TabIndex = 36;
            this.labelDelay.Text = "delay";
            // 
            // labelStA
            // 
            this.labelStA.AutoSize = true;
            this.labelStA.Location = new System.Drawing.Point(818, 50);
            this.labelStA.Name = "labelStA";
            this.labelStA.Size = new System.Drawing.Size(33, 20);
            this.labelStA.TabIndex = 37;
            this.labelStA.Text = "stA";
            // 
            // labelStB
            // 
            this.labelStB.AutoSize = true;
            this.labelStB.Location = new System.Drawing.Point(818, 80);
            this.labelStB.Name = "labelStB";
            this.labelStB.Size = new System.Drawing.Size(33, 20);
            this.labelStB.TabIndex = 38;
            this.labelStB.Text = "stB";
            // 
            // labelStC
            // 
            this.labelStC.AutoSize = true;
            this.labelStC.Location = new System.Drawing.Point(818, 110);
            this.labelStC.Name = "labelStC";
            this.labelStC.Size = new System.Drawing.Size(33, 20);
            this.labelStC.TabIndex = 39;
            this.labelStC.Text = "stC";
            // 
            // tick
            // 
            this.tick.HeaderText = "tick";
            this.tick.MinimumWidth = 8;
            this.tick.Name = "tick";
            this.tick.ReadOnly = true;
            this.tick.Width = 50;
            // 
            // a
            // 
            this.a.HeaderText = "a";
            this.a.MinimumWidth = 8;
            this.a.Name = "a";
            this.a.ReadOnly = true;
            this.a.Width = 50;
            // 
            // b
            // 
            this.b.HeaderText = "b";
            this.b.MinimumWidth = 8;
            this.b.Name = "b";
            this.b.ReadOnly = true;
            this.b.Width = 50;
            // 
            // c
            // 
            this.c.HeaderText = "c";
            this.c.MinimumWidth = 8;
            this.c.Name = "c";
            this.c.ReadOnly = true;
            this.c.Width = 50;
            // 
            // act
            // 
            this.act.HeaderText = "act";
            this.act.MinimumWidth = 8;
            this.act.Name = "act";
            this.act.ReadOnly = true;
            this.act.Width = 75;
            // 
            // avgBusLoad
            // 
            this.avgBusLoad.HeaderText = "avgBusLoad";
            this.avgBusLoad.MinimumWidth = 8;
            this.avgBusLoad.Name = "avgBusLoad";
            this.avgBusLoad.ReadOnly = true;
            this.avgBusLoad.Width = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 450);
            this.Controls.Add(this.labelStC);
            this.Controls.Add(this.labelStB);
            this.Controls.Add(this.labelStA);
            this.Controls.Add(this.labelDelay);
            this.Controls.Add(this.nDelay);
            this.Controls.Add(this.progressBarC);
            this.Controls.Add(this.progressBarB);
            this.Controls.Add(this.progressBarA);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.nAvgAwaitTime);
            this.Controls.Add(this.nBreackingChance);
            this.Controls.Add(this.nBusMaxCapacity);
            this.Controls.Add(this.nBusMaxCnt);
            this.Controls.Add(this.nU2SpawnCnt);
            this.Controls.Add(this.nU1SpawnCnt);
            this.Controls.Add(this.nTCA);
            this.Controls.Add(this.nTBC);
            this.Controls.Add(this.nTAB);
            this.Controls.Add(this.nStSpawnRate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDeterm);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.nStSpawnRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTAB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTBC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTCA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nU1SpawnCnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nU2SpawnCnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBusMaxCnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBusMaxCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBreackingChance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAvgAwaitTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbDeterm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nStSpawnRate;
        private System.Windows.Forms.NumericUpDown nTAB;
        private System.Windows.Forms.NumericUpDown nTBC;
        private System.Windows.Forms.NumericUpDown nTCA;
        private System.Windows.Forms.NumericUpDown nU1SpawnCnt;
        private System.Windows.Forms.NumericUpDown nU2SpawnCnt;
        private System.Windows.Forms.NumericUpDown nBusMaxCnt;
        private System.Windows.Forms.NumericUpDown nBusMaxCapacity;
        private System.Windows.Forms.NumericUpDown nBreackingChance;
        internal System.Windows.Forms.NumericUpDown nAvgAwaitTime;
        internal System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.ProgressBar progressBarA;
        internal System.Windows.Forms.ProgressBar progressBarB;
        internal System.Windows.Forms.ProgressBar progressBarC;
        private System.Windows.Forms.NumericUpDown nDelay;
        private System.Windows.Forms.Label labelDelay;
        private System.Windows.Forms.Label labelStA;
        private System.Windows.Forms.Label labelStB;
        private System.Windows.Forms.Label labelStC;
        private System.Windows.Forms.DataGridViewTextBoxColumn tick;
        private System.Windows.Forms.DataGridViewTextBoxColumn a;
        private System.Windows.Forms.DataGridViewTextBoxColumn b;
        private System.Windows.Forms.DataGridViewTextBoxColumn c;
        private System.Windows.Forms.DataGridViewTextBoxColumn act;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgBusLoad;
    }
}

