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
            this.tick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.act = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgBusLoad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progressBarA = new System.Windows.Forms.ProgressBar();
            this.progressBarB = new System.Windows.Forms.ProgressBar();
            this.progressBarC = new System.Windows.Forms.ProgressBar();
            this.nDelay = new System.Windows.Forms.NumericUpDown();
            this.labelDelay = new System.Windows.Forms.Label();
            this.labelStA = new System.Windows.Forms.Label();
            this.labelStB = new System.Windows.Forms.Label();
            this.labelStC = new System.Windows.Forms.Label();
            this.labelStAA = new System.Windows.Forms.Label();
            this.labelStBB = new System.Windows.Forms.Label();
            this.labelStCC = new System.Windows.Forms.Label();
            this.nNearBarA = new System.Windows.Forms.NumericUpDown();
            this.nNearBarB = new System.Windows.Forms.NumericUpDown();
            this.nNearBarC = new System.Windows.Forms.NumericUpDown();
            this.labelModelProgress = new System.Windows.Forms.Label();
            this.pbModelProgress = new System.Windows.Forms.ProgressBar();
            this.labelBusBrokenCnt = new System.Windows.Forms.Label();
            this.nBusBrokenCnt = new System.Windows.Forms.NumericUpDown();
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
            ((System.ComponentModel.ISupportInitialize)(this.nNearBarA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNearBarB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNearBarC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBusBrokenCnt)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDeterm
            // 
            this.cbDeterm.AutoSize = true;
            this.cbDeterm.Enabled = false;
            this.cbDeterm.Location = new System.Drawing.Point(12, 12);
            this.cbDeterm.Name = "cbDeterm";
            this.cbDeterm.Size = new System.Drawing.Size(193, 24);
            this.cbDeterm.TabIndex = 0;
            this.cbDeterm.Text = "Детерминированная";
            this.cbDeterm.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Период появления людей";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "t между A и B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "t между B и C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "t между C и A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Прирост едущих 1 ост.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Прирост едущих 2 ост.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Макс. число авто";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Макс. вместим. авто";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Шанс поломки авто, %";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 380);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(238, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Ср. t ожидания автобуса (мин)";
            // 
            // nStSpawnRate
            // 
            this.nStSpawnRate.Location = new System.Drawing.Point(195, 50);
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
            this.nTAB.Location = new System.Drawing.Point(195, 80);
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
            this.nTBC.Location = new System.Drawing.Point(195, 110);
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
            this.nTCA.Location = new System.Drawing.Point(195, 140);
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
            this.nU1SpawnCnt.Location = new System.Drawing.Point(195, 170);
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
            this.nU2SpawnCnt.Location = new System.Drawing.Point(195, 200);
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
            this.nBusMaxCnt.Location = new System.Drawing.Point(195, 230);
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
            this.nBusMaxCapacity.Location = new System.Drawing.Point(195, 260);
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
            this.nBreackingChance.Location = new System.Drawing.Point(195, 290);
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
            this.nAvgAwaitTime.Location = new System.Drawing.Point(195, 403);
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
            this.dataGridView1.Location = new System.Drawing.Point(276, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(531, 356);
            this.dataGridView1.TabIndex = 31;
            // 
            // tick
            // 
            this.tick.HeaderText = "такт";
            this.tick.MinimumWidth = 8;
            this.tick.Name = "tick";
            this.tick.ReadOnly = true;
            this.tick.Width = 50;
            // 
            // a
            // 
            this.a.HeaderText = "людей на А";
            this.a.MinimumWidth = 8;
            this.a.Name = "a";
            this.a.ReadOnly = true;
            this.a.Width = 50;
            // 
            // b
            // 
            this.b.HeaderText = "людей на B";
            this.b.MinimumWidth = 8;
            this.b.Name = "b";
            this.b.ReadOnly = true;
            this.b.Width = 50;
            // 
            // c
            // 
            this.c.HeaderText = "людей на C";
            this.c.MinimumWidth = 8;
            this.c.Name = "c";
            this.c.ReadOnly = true;
            this.c.Width = 50;
            // 
            // act
            // 
            this.act.HeaderText = "событие";
            this.act.MinimumWidth = 8;
            this.act.Name = "act";
            this.act.ReadOnly = true;
            this.act.Width = 75;
            // 
            // avgBusLoad
            // 
            this.avgBusLoad.HeaderText = "ср. загр. авто";
            this.avgBusLoad.MinimumWidth = 8;
            this.avgBusLoad.Name = "avgBusLoad";
            this.avgBusLoad.ReadOnly = true;
            this.avgBusLoad.Width = 50;
            // 
            // progressBarA
            // 
            this.progressBarA.Location = new System.Drawing.Point(989, 50);
            this.progressBarA.Maximum = 300;
            this.progressBarA.Name = "progressBarA";
            this.progressBarA.Size = new System.Drawing.Size(112, 23);
            this.progressBarA.TabIndex = 32;
            // 
            // progressBarB
            // 
            this.progressBarB.Location = new System.Drawing.Point(989, 80);
            this.progressBarB.Maximum = 300;
            this.progressBarB.Name = "progressBarB";
            this.progressBarB.Size = new System.Drawing.Size(112, 23);
            this.progressBarB.TabIndex = 33;
            // 
            // progressBarC
            // 
            this.progressBarC.Location = new System.Drawing.Point(989, 110);
            this.progressBarC.Maximum = 300;
            this.progressBarC.Name = "progressBarC";
            this.progressBarC.Size = new System.Drawing.Size(112, 23);
            this.progressBarC.TabIndex = 34;
            // 
            // nDelay
            // 
            this.nDelay.Enabled = false;
            this.nDelay.Location = new System.Drawing.Point(440, 10);
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
            this.labelDelay.Location = new System.Drawing.Point(270, 10);
            this.labelDelay.Name = "labelDelay";
            this.labelDelay.Size = new System.Drawing.Size(154, 20);
            this.labelDelay.TabIndex = 36;
            this.labelDelay.Text = "Доп. задержка (мс)";
            // 
            // labelStA
            // 
            this.labelStA.AutoSize = true;
            this.labelStA.Location = new System.Drawing.Point(818, 50);
            this.labelStA.Name = "labelStA";
            this.labelStA.Size = new System.Drawing.Size(106, 20);
            this.labelStA.TabIndex = 37;
            this.labelStA.Text = "Остановка A";
            // 
            // labelStB
            // 
            this.labelStB.AutoSize = true;
            this.labelStB.Location = new System.Drawing.Point(818, 80);
            this.labelStB.Name = "labelStB";
            this.labelStB.Size = new System.Drawing.Size(106, 20);
            this.labelStB.TabIndex = 38;
            this.labelStB.Text = "Остановка B";
            // 
            // labelStC
            // 
            this.labelStC.AutoSize = true;
            this.labelStC.Location = new System.Drawing.Point(818, 110);
            this.labelStC.Name = "labelStC";
            this.labelStC.Size = new System.Drawing.Size(106, 20);
            this.labelStC.TabIndex = 39;
            this.labelStC.Text = "Остановка C";
            // 
            // labelStAA
            // 
            this.labelStAA.AutoSize = true;
            this.labelStAA.Location = new System.Drawing.Point(818, 190);
            this.labelStAA.Name = "labelStAA";
            this.labelStAA.Size = new System.Drawing.Size(20, 20);
            this.labelStAA.TabIndex = 40;
            this.labelStAA.Text = "A";
            // 
            // labelStBB
            // 
            this.labelStBB.AutoSize = true;
            this.labelStBB.Location = new System.Drawing.Point(1047, 190);
            this.labelStBB.Name = "labelStBB";
            this.labelStBB.Size = new System.Drawing.Size(20, 20);
            this.labelStBB.TabIndex = 41;
            this.labelStBB.Text = "B";
            // 
            // labelStCC
            // 
            this.labelStCC.AutoSize = true;
            this.labelStCC.Location = new System.Drawing.Point(931, 402);
            this.labelStCC.Name = "labelStCC";
            this.labelStCC.Size = new System.Drawing.Size(20, 20);
            this.labelStCC.TabIndex = 42;
            this.labelStCC.Text = "C";
            // 
            // nNearBarA
            // 
            this.nNearBarA.Location = new System.Drawing.Point(926, 50);
            this.nNearBarA.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nNearBarA.Name = "nNearBarA";
            this.nNearBarA.ReadOnly = true;
            this.nNearBarA.Size = new System.Drawing.Size(59, 26);
            this.nNearBarA.TabIndex = 43;
            // 
            // nNearBarB
            // 
            this.nNearBarB.Location = new System.Drawing.Point(926, 80);
            this.nNearBarB.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nNearBarB.Name = "nNearBarB";
            this.nNearBarB.ReadOnly = true;
            this.nNearBarB.Size = new System.Drawing.Size(59, 26);
            this.nNearBarB.TabIndex = 44;
            // 
            // nNearBarC
            // 
            this.nNearBarC.Location = new System.Drawing.Point(926, 110);
            this.nNearBarC.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nNearBarC.Name = "nNearBarC";
            this.nNearBarC.ReadOnly = true;
            this.nNearBarC.Size = new System.Drawing.Size(59, 26);
            this.nNearBarC.TabIndex = 45;
            // 
            // labelModelProgress
            // 
            this.labelModelProgress.AutoSize = true;
            this.labelModelProgress.Location = new System.Drawing.Point(12, 451);
            this.labelModelProgress.Name = "labelModelProgress";
            this.labelModelProgress.Size = new System.Drawing.Size(143, 20);
            this.labelModelProgress.TabIndex = 46;
            this.labelModelProgress.Text = "Прогресс модели";
            // 
            // pbModelProgress
            // 
            this.pbModelProgress.Location = new System.Drawing.Point(161, 451);
            this.pbModelProgress.Maximum = 300;
            this.pbModelProgress.Name = "pbModelProgress";
            this.pbModelProgress.Size = new System.Drawing.Size(940, 23);
            this.pbModelProgress.TabIndex = 47;
            // 
            // labelBusBrokenCnt
            // 
            this.labelBusBrokenCnt.AutoSize = true;
            this.labelBusBrokenCnt.Location = new System.Drawing.Point(623, 10);
            this.labelBusBrokenCnt.Name = "labelBusBrokenCnt";
            this.labelBusBrokenCnt.Size = new System.Drawing.Size(194, 20);
            this.labelBusBrokenCnt.TabIndex = 49;
            this.labelBusBrokenCnt.Text = "Число поломанных авто";
            // 
            // nBusBrokenCnt
            // 
            this.nBusBrokenCnt.Enabled = false;
            this.nBusBrokenCnt.Location = new System.Drawing.Point(822, 10);
            this.nBusBrokenCnt.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nBusBrokenCnt.Name = "nBusBrokenCnt";
            this.nBusBrokenCnt.ReadOnly = true;
            this.nBusBrokenCnt.Size = new System.Drawing.Size(58, 26);
            this.nBusBrokenCnt.TabIndex = 48;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 494);
            this.Controls.Add(this.labelBusBrokenCnt);
            this.Controls.Add(this.nBusBrokenCnt);
            this.Controls.Add(this.pbModelProgress);
            this.Controls.Add(this.labelModelProgress);
            this.Controls.Add(this.nNearBarC);
            this.Controls.Add(this.nNearBarB);
            this.Controls.Add(this.nNearBarA);
            this.Controls.Add(this.labelStCC);
            this.Controls.Add(this.labelStBB);
            this.Controls.Add(this.labelStAA);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "ММПП, ТенНМ ПИ-41";
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
            ((System.ComponentModel.ISupportInitialize)(this.nNearBarA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNearBarB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNearBarC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBusBrokenCnt)).EndInit();
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
        private System.Windows.Forms.Label labelStAA;
        private System.Windows.Forms.Label labelStBB;
        private System.Windows.Forms.Label labelStCC;
        internal System.Windows.Forms.NumericUpDown nNearBarA;
        internal System.Windows.Forms.NumericUpDown nNearBarB;
        internal System.Windows.Forms.NumericUpDown nNearBarC;
        private System.Windows.Forms.Label labelModelProgress;
        internal System.Windows.Forms.ProgressBar pbModelProgress;
        private System.Windows.Forms.DataGridViewTextBoxColumn tick;
        private System.Windows.Forms.DataGridViewTextBoxColumn a;
        private System.Windows.Forms.DataGridViewTextBoxColumn b;
        private System.Windows.Forms.DataGridViewTextBoxColumn c;
        private System.Windows.Forms.DataGridViewTextBoxColumn act;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgBusLoad;
        private System.Windows.Forms.Label labelBusBrokenCnt;
        internal System.Windows.Forms.NumericUpDown nBusBrokenCnt;
    }
}

