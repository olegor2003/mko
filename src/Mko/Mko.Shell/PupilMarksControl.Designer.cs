namespace Mko.Shell
{
    partial class PupilMarksControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayaout = new System.Windows.Forms.TableLayoutPanel();
            this.pupilsGridControl = new System.Windows.Forms.DataGridView();
            this.pupilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.periodsTabControl = new System.Windows.Forms.TabControl();
            this.startPeriodControl = new System.Windows.Forms.TabPage();
            this.rbFinish = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbStartPeriod = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.subjectMarkDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectMarksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayaout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pupilsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pupilBindingSource)).BeginInit();
            this.periodsTabControl.SuspendLayout();
            this.startPeriodControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectMarkDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectMarksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayaout
            // 
            this.tableLayaout.AutoSize = true;
            this.tableLayaout.ColumnCount = 2;
            this.tableLayaout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayaout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayaout.Controls.Add(this.pupilsGridControl, 0, 0);
            this.tableLayaout.Controls.Add(this.periodsTabControl, 1, 0);
            this.tableLayaout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayaout.Location = new System.Drawing.Point(0, 0);
            this.tableLayaout.Name = "tableLayaout";
            this.tableLayaout.RowCount = 1;
            this.tableLayaout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayaout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayaout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayaout.Size = new System.Drawing.Size(768, 429);
            this.tableLayaout.TabIndex = 2;
            // 
            // pupilsGridControl
            // 
            this.pupilsGridControl.AutoGenerateColumns = false;
            this.pupilsGridControl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pupilsGridControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pupilsGridControl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullName});
            this.pupilsGridControl.DataSource = this.pupilBindingSource;
            this.pupilsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pupilsGridControl.Location = new System.Drawing.Point(3, 3);
            this.pupilsGridControl.MultiSelect = false;
            this.pupilsGridControl.Name = "pupilsGridControl";
            this.pupilsGridControl.ReadOnly = true;
            this.pupilsGridControl.Size = new System.Drawing.Size(294, 423);
            this.pupilsGridControl.TabIndex = 0;
            // 
            // pupilBindingSource
            // 
            this.pupilBindingSource.AllowNew = false;
            this.pupilBindingSource.DataSource = typeof(Mko.ObjectModel.Model.Pupil);
            // 
            // periodsTabControl
            // 
            this.periodsTabControl.Controls.Add(this.startPeriodControl);
            this.periodsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.periodsTabControl.Location = new System.Drawing.Point(303, 3);
            this.periodsTabControl.Name = "periodsTabControl";
            this.periodsTabControl.SelectedIndex = 0;
            this.periodsTabControl.Size = new System.Drawing.Size(462, 423);
            this.periodsTabControl.TabIndex = 1;
            // 
            // startPeriodControl
            // 
            this.startPeriodControl.Controls.Add(this.rbFinish);
            this.startPeriodControl.Controls.Add(this.rbMedium);
            this.startPeriodControl.Controls.Add(this.rbStartPeriod);
            this.startPeriodControl.Controls.Add(this.btnSave);
            this.startPeriodControl.Controls.Add(this.subjectMarkDataGridView);
            this.startPeriodControl.Location = new System.Drawing.Point(4, 22);
            this.startPeriodControl.Name = "startPeriodControl";
            this.startPeriodControl.Padding = new System.Windows.Forms.Padding(3);
            this.startPeriodControl.Size = new System.Drawing.Size(454, 397);
            this.startPeriodControl.TabIndex = 0;
            this.startPeriodControl.Text = "Оценивание";
            this.startPeriodControl.UseVisualStyleBackColor = true;
            // 
            // rbFinish
            // 
            this.rbFinish.AutoSize = true;
            this.rbFinish.Location = new System.Drawing.Point(8, 66);
            this.rbFinish.Name = "rbFinish";
            this.rbFinish.Size = new System.Drawing.Size(75, 17);
            this.rbFinish.TabIndex = 9;
            this.rbFinish.TabStop = true;
            this.rbFinish.Tag = "3";
            this.rbFinish.Text = "Итоговый";
            this.rbFinish.UseVisualStyleBackColor = true;
            this.rbFinish.CheckedChanged += new System.EventHandler(this.rbStartPeriod_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(8, 43);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(108, 17);
            this.rbMedium.TabIndex = 8;
            this.rbMedium.Tag = "2";
            this.rbMedium.Text = "Промежуточный";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbStartPeriod_CheckedChanged);
            // 
            // rbStartPeriod
            // 
            this.rbStartPeriod.AutoSize = true;
            this.rbStartPeriod.Checked = true;
            this.rbStartPeriod.Location = new System.Drawing.Point(8, 20);
            this.rbStartPeriod.Name = "rbStartPeriod";
            this.rbStartPeriod.Size = new System.Drawing.Size(82, 17);
            this.rbStartPeriod.TabIndex = 7;
            this.rbStartPeriod.TabStop = true;
            this.rbStartPeriod.Tag = "1";
            this.rbStartPeriod.Text = "Начальный";
            this.rbStartPeriod.UseVisualStyleBackColor = true;
            this.rbStartPeriod.CheckedChanged += new System.EventHandler(this.rbStartPeriod_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(349, 353);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // subjectMarkDataGridView
            // 
            this.subjectMarkDataGridView.AutoGenerateColumns = false;
            this.subjectMarkDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectMarkDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.subjectMarkDataGridView.DataSource = this.subjectMarksBindingSource;
            this.subjectMarkDataGridView.Location = new System.Drawing.Point(5, 96);
            this.subjectMarkDataGridView.Name = "subjectMarkDataGridView";
            this.subjectMarkDataGridView.Size = new System.Drawing.Size(442, 251);
            this.subjectMarkDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Subject";
            this.dataGridViewTextBoxColumn3.HeaderText = "Умение";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Value";
            this.dataGridViewTextBoxColumn4.HeaderText = "Оценка";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // subjectMarksBindingSource
            // 
            this.subjectMarksBindingSource.DataSource = typeof(Mko.ViewModel.SubjectMark);
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Имя учащегося";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // PupilMarksControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayaout);
            this.Name = "PupilMarksControl";
            this.Size = new System.Drawing.Size(768, 429);
            this.tableLayaout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pupilsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pupilBindingSource)).EndInit();
            this.periodsTabControl.ResumeLayout(false);
            this.startPeriodControl.ResumeLayout(false);
            this.startPeriodControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectMarkDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectMarksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayaout;
        private System.Windows.Forms.DataGridView pupilsGridControl;
        private System.Windows.Forms.BindingSource pupilBindingSource;
        private System.Windows.Forms.BindingSource subjectMarksBindingSource;
        private System.Windows.Forms.TabControl periodsTabControl;
        private System.Windows.Forms.TabPage startPeriodControl;
        private System.Windows.Forms.RadioButton rbFinish;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbStartPeriod;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView subjectMarkDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
    }
}
