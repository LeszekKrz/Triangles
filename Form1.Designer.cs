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
            this.importButton = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel2.Controls.Add(this.importButton, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(404, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(194, 395);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // importButton
            // 
            this.importButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.importButton.Location = new System.Drawing.Point(3, 358);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(188, 34);
            this.importButton.TabIndex = 0;
            this.importButton.Text = "Import Object";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.animationButton, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.interpolateBox, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(188, 349);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // animationButton
            // 
            this.animationButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.animationButton.Location = new System.Drawing.Point(3, 247);
            this.animationButton.Name = "animationButton";
            this.animationButton.Size = new System.Drawing.Size(182, 46);
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
            this.tableLayoutPanel4.Size = new System.Drawing.Size(182, 240);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 40);
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
            this.ksBar.Size = new System.Drawing.Size(132, 36);
            this.ksBar.TabIndex = 1;
            this.ksBar.ValueChanged += new System.EventHandler(this.ksBar_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "k_d:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kdBar
            // 
            this.kdBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kdBar.Location = new System.Drawing.Point(47, 42);
            this.kdBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kdBar.Maximum = 19;
            this.kdBar.Name = "kdBar";
            this.kdBar.Size = new System.Drawing.Size(132, 36);
            this.kdBar.TabIndex = 3;
            this.kdBar.ValueChanged += new System.EventHandler(this.kdBar_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 40);
            this.label3.TabIndex = 4;
            this.label3.Text = "m:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mBar
            // 
            this.mBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mBar.Location = new System.Drawing.Point(47, 83);
            this.mBar.Maximum = 100;
            this.mBar.Minimum = 1;
            this.mBar.Name = "mBar";
            this.mBar.Size = new System.Drawing.Size(132, 34);
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
            this.label4.Location = new System.Drawing.Point(3, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 40);
            this.label4.TabIndex = 6;
            this.label4.Text = "z:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // zBar
            // 
            this.zBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zBar.Location = new System.Drawing.Point(47, 123);
            this.zBar.Maximum = 100;
            this.zBar.Minimum = 11;
            this.zBar.Name = "zBar";
            this.zBar.Size = new System.Drawing.Size(132, 34);
            this.zBar.TabIndex = 7;
            this.zBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.zBar.Value = 20;
            this.zBar.ValueChanged += new System.EventHandler(this.zBar_ValueChanged);
            // 
            // objectPicture
            // 
            this.objectPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectPicture.Location = new System.Drawing.Point(5, 165);
            this.objectPicture.Margin = new System.Windows.Forms.Padding(5);
            this.objectPicture.Name = "objectPicture";
            this.objectPicture.Size = new System.Drawing.Size(34, 30);
            this.objectPicture.TabIndex = 8;
            this.objectPicture.TabStop = false;
            this.objectPicture.SizeChanged += new System.EventHandler(this.objectPicture_SizeChanged);
            // 
            // objectColorButton
            // 
            this.objectColorButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectColorButton.Location = new System.Drawing.Point(47, 163);
            this.objectColorButton.Name = "objectColorButton";
            this.objectColorButton.Size = new System.Drawing.Size(132, 34);
            this.objectColorButton.TabIndex = 9;
            this.objectColorButton.Text = "Object color";
            this.objectColorButton.UseVisualStyleBackColor = true;
            this.objectColorButton.Click += new System.EventHandler(this.objectColorButton_Click);
            // 
            // lightPicture
            // 
            this.lightPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lightPicture.Location = new System.Drawing.Point(5, 205);
            this.lightPicture.Margin = new System.Windows.Forms.Padding(5);
            this.lightPicture.Name = "lightPicture";
            this.lightPicture.Size = new System.Drawing.Size(34, 30);
            this.lightPicture.TabIndex = 10;
            this.lightPicture.TabStop = false;
            this.lightPicture.SizeChanged += new System.EventHandler(this.lightPicture_SizeChanged);
            // 
            // lightColorButton
            // 
            this.lightColorButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lightColorButton.Location = new System.Drawing.Point(47, 203);
            this.lightColorButton.Name = "lightColorButton";
            this.lightColorButton.Size = new System.Drawing.Size(132, 34);
            this.lightColorButton.TabIndex = 11;
            this.lightColorButton.Text = "Light color";
            this.lightColorButton.UseVisualStyleBackColor = true;
            this.lightColorButton.Click += new System.EventHandler(this.lightColorButton_Click);
            // 
            // interpolateBox
            // 
            this.interpolateBox.Controls.Add(this.radioButton2);
            this.interpolateBox.Controls.Add(this.interpolateColorRadio);
            this.interpolateBox.Location = new System.Drawing.Point(3, 299);
            this.interpolateBox.Name = "interpolateBox";
            this.interpolateBox.Size = new System.Drawing.Size(182, 47);
            this.interpolateBox.TabIndex = 2;
            this.interpolateBox.TabStop = false;
            this.interpolateBox.Text = "Interpolate";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(85, 22);
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
            this.interpolateColorRadio.Location = new System.Drawing.Point(6, 22);
            this.interpolateColorRadio.Name = "interpolateColorRadio";
            this.interpolateColorRadio.Size = new System.Drawing.Size(59, 19);
            this.interpolateColorRadio.TabIndex = 0;
            this.interpolateColorRadio.TabStop = true;
            this.interpolateColorRadio.Text = "Colors";
            this.interpolateColorRadio.UseVisualStyleBackColor = true;
            this.interpolateColorRadio.CheckedChanged += new System.EventHandler(this.interpolateColorRadio_CheckedChanged);
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
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox drawArea;
        private TableLayoutPanel tableLayoutPanel2;
        private Button importButton;
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
    }
}