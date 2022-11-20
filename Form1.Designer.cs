namespace Triangles
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.drawArea = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.animationButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.ksBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.kdBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.mBar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.zBar = new System.Windows.Forms.TrackBar();
            this.objectPicture = new System.Windows.Forms.PictureBox();
            this.objectColorButton = new System.Windows.Forms.Button();
            this.lightPicture = new System.Windows.Forms.PictureBox();
            this.lightColorButton = new System.Windows.Forms.Button();
            this.interpolateBox = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.interpolateColorRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textureRadio = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.modifyCheck = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawArea)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ksBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kdBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightPicture)).BeginInit();
            this.interpolateBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Controls.Add(this.drawArea, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(601, 401);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // drawArea
            // 
            this.drawArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawArea.Location = new System.Drawing.Point(3, 3);
            this.drawArea.Name = "drawArea";
            this.drawArea.Size = new System.Drawing.Size(395, 395);
            this.drawArea.TabIndex = 0;
            this.drawArea.TabStop = false;
            this.drawArea.SizeChanged += new System.EventHandler(this.drawArea_SizeChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(404, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.16267F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.83733F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(194, 395);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.animationButton, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.interpolateBox, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(188, 310);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // animationButton
            // 
            this.animationButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.animationButton.Location = new System.Drawing.Point(3, 175);
            this.animationButton.Name = "animationButton";
            this.animationButton.Size = new System.Drawing.Size(182, 28);
            this.animationButton.TabIndex = 0;
            this.animationButton.Text = "Start animation";
            this.animationButton.UseVisualStyleBackColor = true;
            this.animationButton.Click += new System.EventHandler(this.animationButton_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.ksBar, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.kdBar, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.mBar, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.zBar, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.objectPicture, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.objectColorButton, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.lightPicture, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.lightColorButton, 1, 5);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(182, 168);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "k_s:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ksBar
            // 
            this.ksBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ksBar.Location = new System.Drawing.Point(47, 2);
            this.ksBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ksBar.Maximum = 19;
            this.ksBar.Name = "ksBar";
            this.ksBar.Size = new System.Drawing.Size(132, 23);
            this.ksBar.TabIndex = 1;
            this.ksBar.ValueChanged += new System.EventHandler(this.ksBar_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "k_d:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kdBar
            // 
            this.kdBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kdBar.Location = new System.Drawing.Point(47, 29);
            this.kdBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kdBar.Maximum = 19;
            this.kdBar.Name = "kdBar";
            this.kdBar.Size = new System.Drawing.Size(132, 23);
            this.kdBar.TabIndex = 3;
            this.kdBar.ValueChanged += new System.EventHandler(this.kdBar_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "m:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mBar
            // 
            this.mBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mBar.Location = new System.Drawing.Point(47, 57);
            this.mBar.Maximum = 100;
            this.mBar.Minimum = 1;
            this.mBar.Name = "mBar";
            this.mBar.Size = new System.Drawing.Size(132, 21);
            this.mBar.TabIndex = 5;
            this.mBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.mBar.Value = 1;
            this.mBar.ValueChanged += new System.EventHandler(this.mBar_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "z:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // zBar
            // 
            this.zBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zBar.Location = new System.Drawing.Point(47, 84);
            this.zBar.Maximum = 100;
            this.zBar.Minimum = 11;
            this.zBar.Name = "zBar";
            this.zBar.Size = new System.Drawing.Size(132, 21);
            this.zBar.TabIndex = 7;
            this.zBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.zBar.Value = 20;
            this.zBar.ValueChanged += new System.EventHandler(this.zBar_ValueChanged);
            // 
            // objectPicture
            // 
            this.objectPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectPicture.Location = new System.Drawing.Point(5, 113);
            this.objectPicture.Margin = new System.Windows.Forms.Padding(5);
            this.objectPicture.Name = "objectPicture";
            this.objectPicture.Size = new System.Drawing.Size(34, 17);
            this.objectPicture.TabIndex = 8;
            this.objectPicture.TabStop = false;
            this.objectPicture.SizeChanged += new System.EventHandler(this.objectPicture_SizeChanged);
            // 
            // objectColorButton
            // 
            this.objectColorButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectColorButton.Location = new System.Drawing.Point(47, 111);
            this.objectColorButton.Name = "objectColorButton";
            this.objectColorButton.Size = new System.Drawing.Size(132, 21);
            this.objectColorButton.TabIndex = 9;
            this.objectColorButton.Text = "Object color";
            this.objectColorButton.UseVisualStyleBackColor = true;
            this.objectColorButton.Click += new System.EventHandler(this.objectColorButton_Click);
            // 
            // lightPicture
            // 
            this.lightPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lightPicture.Location = new System.Drawing.Point(5, 140);
            this.lightPicture.Margin = new System.Windows.Forms.Padding(5);
            this.lightPicture.Name = "lightPicture";
            this.lightPicture.Size = new System.Drawing.Size(34, 23);
            this.lightPicture.TabIndex = 10;
            this.lightPicture.TabStop = false;
            this.lightPicture.SizeChanged += new System.EventHandler(this.lightPicture_SizeChanged);
            // 
            // lightColorButton
            // 
            this.lightColorButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lightColorButton.Location = new System.Drawing.Point(47, 138);
            this.lightColorButton.Name = "lightColorButton";
            this.lightColorButton.Size = new System.Drawing.Size(132, 27);
            this.lightColorButton.TabIndex = 11;
            this.lightColorButton.Text = "Light color";
            this.lightColorButton.UseVisualStyleBackColor = true;
            this.lightColorButton.Click += new System.EventHandler(this.lightColorButton_Click);
            // 
            // interpolateBox
            // 
            this.interpolateBox.Controls.Add(this.radioButton2);
            this.interpolateBox.Controls.Add(this.interpolateColorRadio);
            this.interpolateBox.Location = new System.Drawing.Point(3, 209);
            this.interpolateBox.Name = "interpolateBox";
            this.interpolateBox.Size = new System.Drawing.Size(182, 45);
            this.interpolateBox.TabIndex = 2;
            this.interpolateBox.TabStop = false;
            this.interpolateBox.Text = "Interpolate";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(85, 20);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(63, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Vectors";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // interpolateColorRadio
            // 
            this.interpolateColorRadio.AutoSize = true;
            this.interpolateColorRadio.Checked = true;
            this.interpolateColorRadio.Location = new System.Drawing.Point(6, 20);
            this.interpolateColorRadio.Name = "interpolateColorRadio";
            this.interpolateColorRadio.Size = new System.Drawing.Size(59, 19);
            this.interpolateColorRadio.TabIndex = 0;
            this.interpolateColorRadio.TabStop = true;
            this.interpolateColorRadio.Text = "Colors";
            this.interpolateColorRadio.UseVisualStyleBackColor = true;
            this.interpolateColorRadio.CheckedChanged += new System.EventHandler(this.interpolateColorRadio_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textureRadio);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 260);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 47);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color";
            // 
            // textureRadio
            // 
            this.textureRadio.AutoSize = true;
            this.textureRadio.Location = new System.Drawing.Point(85, 22);
            this.textureRadio.Name = "textureRadio";
            this.textureRadio.Size = new System.Drawing.Size(63, 19);
            this.textureRadio.TabIndex = 1;
            this.textureRadio.Text = "Texture";
            this.textureRadio.UseVisualStyleBackColor = true;
            this.textureRadio.CheckedChanged += new System.EventHandler(this.textureRadio_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Constant";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.modifyCheck, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 319);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(188, 73);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // modifyCheck
            // 
            this.modifyCheck.AutoSize = true;
            this.modifyCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modifyCheck.Location = new System.Drawing.Point(3, 50);
            this.modifyCheck.Name = "modifyCheck";
            this.modifyCheck.Size = new System.Drawing.Size(182, 20);
            this.modifyCheck.TabIndex = 0;
            this.modifyCheck.Text = "Modify vectors";
            this.modifyCheck.UseVisualStyleBackColor = true;
            this.modifyCheck.CheckedChanged += new System.EventHandler(this.modifyCheck_CheckedChanged);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(182, 41);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Object";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.importButton_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(94, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Texture";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.textureButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 401);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(352, 310);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drawArea)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ksBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kdBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightPicture)).EndInit();
            this.interpolateBox.ResumeLayout(false);
            this.interpolateBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox drawArea;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button animationButton;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label1;
        private TrackBar ksBar;
        private Label label2;
        private TrackBar kdBar;
        private Label label3;
        private TrackBar mBar;
        private Label label4;
        private TrackBar zBar;
        private PictureBox objectPicture;
        private Button objectColorButton;
        private PictureBox lightPicture;
        private Button lightColorButton;
        private GroupBox interpolateBox;
        private RadioButton radioButton2;
        private RadioButton interpolateColorRadio;
        private GroupBox groupBox1;
        private RadioButton textureRadio;
        private RadioButton radioButton1;
        private TableLayoutPanel tableLayoutPanel5;
        private CheckBox modifyCheck;
        private TableLayoutPanel tableLayoutPanel6;
        private Button button1;
        private Button button2;
    }
}