namespace Practice3_Ind
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownWeigth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLength = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownID = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxMaterial = new System.Windows.Forms.ComboBox();
            this.numericUpDownStrengthCoefficient = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxRoadType = new System.Windows.Forms.ComboBox();
            this.buttonAddBaseObject = new System.Windows.Forms.Button();
            this.buttonBaseQuality = new System.Windows.Forms.Button();
            this.buttonsAddSuccessorObject = new System.Windows.Forms.Button();
            this.buttonSuccessorQuality = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listBoxBaseObject = new System.Windows.Forms.ListBox();
            this.listBoxBaseQuality = new System.Windows.Forms.ListBox();
            this.listBoxSuccessorObject = new System.Windows.Forms.ListBox();
            this.listBoxSuccessorQuality = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonDeleteBaseObject = new System.Windows.Forms.Button();
            this.buttonDeleteSuccessorObject = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeigth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStrengthCoefficient)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Масса на 1 кв.м(кг)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Длина(м)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ширина(м)";
            // 
            // numericUpDownWeigth
            // 
            this.numericUpDownWeigth.DecimalPlaces = 2;
            this.numericUpDownWeigth.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownWeigth.Location = new System.Drawing.Point(160, 40);
            this.numericUpDownWeigth.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numericUpDownWeigth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownWeigth.Name = "numericUpDownWeigth";
            this.numericUpDownWeigth.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownWeigth.TabIndex = 3;
            this.numericUpDownWeigth.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // numericUpDownLength
            // 
            this.numericUpDownLength.DecimalPlaces = 2;
            this.numericUpDownLength.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownLength.Location = new System.Drawing.Point(18, 86);
            this.numericUpDownLength.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numericUpDownLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownLength.Name = "numericUpDownLength";
            this.numericUpDownLength.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownLength.TabIndex = 4;
            this.numericUpDownLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.DecimalPlaces = 2;
            this.numericUpDownWidth.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownWidth.Location = new System.Drawing.Point(18, 130);
            this.numericUpDownWidth.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numericUpDownWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownWidth.TabIndex = 5;
            this.numericUpDownWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // numericUpDownID
            // 
            this.numericUpDownID.Location = new System.Drawing.Point(18, 39);
            this.numericUpDownID.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownID.Name = "numericUpDownID";
            this.numericUpDownID.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownID.TabIndex = 6;
            this.numericUpDownID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Материал";
            // 
            // comboBoxMaterial
            // 
            this.comboBoxMaterial.FormattingEnabled = true;
            this.comboBoxMaterial.Location = new System.Drawing.Point(159, 85);
            this.comboBoxMaterial.Name = "comboBoxMaterial";
            this.comboBoxMaterial.Size = new System.Drawing.Size(121, 23);
            this.comboBoxMaterial.TabIndex = 9;
            // 
            // numericUpDownStrengthCoefficient
            // 
            this.numericUpDownStrengthCoefficient.Location = new System.Drawing.Point(443, 85);
            this.numericUpDownStrengthCoefficient.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownStrengthCoefficient.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownStrengthCoefficient.Name = "numericUpDownStrengthCoefficient";
            this.numericUpDownStrengthCoefficient.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownStrengthCoefficient.TabIndex = 10;
            this.numericUpDownStrengthCoefficient.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(443, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Коэффцициент прочности";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(443, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Тип дороги";
            // 
            // comboBoxRoadType
            // 
            this.comboBoxRoadType.FormattingEnabled = true;
            this.comboBoxRoadType.Location = new System.Drawing.Point(443, 129);
            this.comboBoxRoadType.Name = "comboBoxRoadType";
            this.comboBoxRoadType.Size = new System.Drawing.Size(262, 23);
            this.comboBoxRoadType.TabIndex = 13;
            // 
            // buttonAddBaseObject
            // 
            this.buttonAddBaseObject.Location = new System.Drawing.Point(18, 159);
            this.buttonAddBaseObject.Name = "buttonAddBaseObject";
            this.buttonAddBaseObject.Size = new System.Drawing.Size(264, 23);
            this.buttonAddBaseObject.TabIndex = 14;
            this.buttonAddBaseObject.Text = "Добавить базовый объект";
            this.buttonAddBaseObject.UseVisualStyleBackColor = true;
            this.buttonAddBaseObject.Click += new System.EventHandler(this.buttonAddBaseObject_Click);
            // 
            // buttonBaseQuality
            // 
            this.buttonBaseQuality.Location = new System.Drawing.Point(18, 188);
            this.buttonBaseQuality.Name = "buttonBaseQuality";
            this.buttonBaseQuality.Size = new System.Drawing.Size(264, 23);
            this.buttonBaseQuality.TabIndex = 15;
            this.buttonBaseQuality.Text = "Вычислить по формуле";
            this.buttonBaseQuality.UseVisualStyleBackColor = true;
            this.buttonBaseQuality.Click += new System.EventHandler(this.buttonBaseQuality_Click);
            // 
            // buttonsAddSuccessorObject
            // 
            this.buttonsAddSuccessorObject.Location = new System.Drawing.Point(441, 159);
            this.buttonsAddSuccessorObject.Name = "buttonsAddSuccessorObject";
            this.buttonsAddSuccessorObject.Size = new System.Drawing.Size(264, 23);
            this.buttonsAddSuccessorObject.TabIndex = 16;
            this.buttonsAddSuccessorObject.Text = "Добавить объект класса-наследника";
            this.buttonsAddSuccessorObject.UseVisualStyleBackColor = true;
            this.buttonsAddSuccessorObject.Click += new System.EventHandler(this.buttonsAddSuccessorObject_Click);
            // 
            // buttonSuccessorQuality
            // 
            this.buttonSuccessorQuality.Location = new System.Drawing.Point(443, 188);
            this.buttonSuccessorQuality.Name = "buttonSuccessorQuality";
            this.buttonSuccessorQuality.Size = new System.Drawing.Size(264, 23);
            this.buttonSuccessorQuality.TabIndex = 17;
            this.buttonSuccessorQuality.Text = "Вычислить по обновленной формуле";
            this.buttonSuccessorQuality.UseVisualStyleBackColor = true;
            this.buttonSuccessorQuality.Click += new System.EventHandler(this.buttonSuccessorQuality_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Объекты базового класса";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 424);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(234, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "Результаты вычислений базового класса";
            // 
            // listBoxBaseObject
            // 
            this.listBoxBaseObject.FormattingEnabled = true;
            this.listBoxBaseObject.ItemHeight = 15;
            this.listBoxBaseObject.Location = new System.Drawing.Point(18, 268);
            this.listBoxBaseObject.Name = "listBoxBaseObject";
            this.listBoxBaseObject.Size = new System.Drawing.Size(394, 139);
            this.listBoxBaseObject.TabIndex = 20;
            // 
            // listBoxBaseQuality
            // 
            this.listBoxBaseQuality.FormattingEnabled = true;
            this.listBoxBaseQuality.ItemHeight = 15;
            this.listBoxBaseQuality.Location = new System.Drawing.Point(18, 442);
            this.listBoxBaseQuality.Name = "listBoxBaseQuality";
            this.listBoxBaseQuality.Size = new System.Drawing.Size(394, 139);
            this.listBoxBaseQuality.TabIndex = 21;
            // 
            // listBoxSuccessorObject
            // 
            this.listBoxSuccessorObject.FormattingEnabled = true;
            this.listBoxSuccessorObject.ItemHeight = 15;
            this.listBoxSuccessorObject.Location = new System.Drawing.Point(443, 268);
            this.listBoxSuccessorObject.Name = "listBoxSuccessorObject";
            this.listBoxSuccessorObject.Size = new System.Drawing.Size(737, 139);
            this.listBoxSuccessorObject.TabIndex = 22;
            // 
            // listBoxSuccessorQuality
            // 
            this.listBoxSuccessorQuality.FormattingEnabled = true;
            this.listBoxSuccessorQuality.ItemHeight = 15;
            this.listBoxSuccessorQuality.Location = new System.Drawing.Point(441, 442);
            this.listBoxSuccessorQuality.Name = "listBoxSuccessorQuality";
            this.listBoxSuccessorQuality.Size = new System.Drawing.Size(739, 139);
            this.listBoxSuccessorQuality.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(441, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 15);
            this.label10.TabIndex = 24;
            this.label10.Text = "Объекты класса-наследника";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(443, 424);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(250, 15);
            this.label11.TabIndex = 25;
            this.label11.Text = "Результаты вычислений класса-наследника";
            // 
            // buttonDeleteBaseObject
            // 
            this.buttonDeleteBaseObject.Location = new System.Drawing.Point(18, 217);
            this.buttonDeleteBaseObject.Name = "buttonDeleteBaseObject";
            this.buttonDeleteBaseObject.Size = new System.Drawing.Size(264, 23);
            this.buttonDeleteBaseObject.TabIndex = 26;
            this.buttonDeleteBaseObject.Text = "Удалить объект базового класса";
            this.buttonDeleteBaseObject.UseVisualStyleBackColor = true;
            this.buttonDeleteBaseObject.Click += new System.EventHandler(this.buttonDeleteBaseObject_Click);
            // 
            // buttonDeleteSuccessorObject
            // 
            this.buttonDeleteSuccessorObject.Location = new System.Drawing.Point(443, 217);
            this.buttonDeleteSuccessorObject.Name = "buttonDeleteSuccessorObject";
            this.buttonDeleteSuccessorObject.Size = new System.Drawing.Size(264, 23);
            this.buttonDeleteSuccessorObject.TabIndex = 27;
            this.buttonDeleteSuccessorObject.Text = "Удалить объект класса-наследника";
            this.buttonDeleteSuccessorObject.UseVisualStyleBackColor = true;
            this.buttonDeleteSuccessorObject.Click += new System.EventHandler(this.buttonDeleteSuccessorObject_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 610);
            this.Controls.Add(this.buttonDeleteSuccessorObject);
            this.Controls.Add(this.buttonDeleteBaseObject);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.listBoxSuccessorQuality);
            this.Controls.Add(this.listBoxSuccessorObject);
            this.Controls.Add(this.listBoxBaseQuality);
            this.Controls.Add(this.listBoxBaseObject);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonSuccessorQuality);
            this.Controls.Add(this.buttonsAddSuccessorObject);
            this.Controls.Add(this.buttonBaseQuality);
            this.Controls.Add(this.buttonAddBaseObject);
            this.Controls.Add(this.comboBoxRoadType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownStrengthCoefficient);
            this.Controls.Add(this.comboBoxMaterial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownID);
            this.Controls.Add(this.numericUpDownWidth);
            this.Controls.Add(this.numericUpDownLength);
            this.Controls.Add(this.numericUpDownWeigth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeigth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStrengthCoefficient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownWeigth;
        private System.Windows.Forms.NumericUpDown numericUpDownLength;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxMaterial;
        private System.Windows.Forms.NumericUpDown numericUpDownStrengthCoefficient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxRoadType;
        private System.Windows.Forms.Button buttonAddBaseObject;
        private System.Windows.Forms.Button buttonBaseQuality;
        private System.Windows.Forms.Button buttonsAddSuccessorObject;
        private System.Windows.Forms.Button buttonSuccessorQuality;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBoxBaseObject;
        private System.Windows.Forms.ListBox listBoxBaseQuality;
        private System.Windows.Forms.ListBox listBoxSuccessorObject;
        private System.Windows.Forms.ListBox listBoxSuccessorQuality;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonDeleteBaseObject;
        private System.Windows.Forms.Button buttonDeleteSuccessorObject;
    }
}
