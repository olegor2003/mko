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
            this.periodsTabControl = new System.Windows.Forms.TabControl();
            this.startPeriodControl = new System.Windows.Forms.TabPage();
            this.midiatePeriodControl = new System.Windows.Forms.TabPage();
            this.finalPeriodControl = new System.Windows.Forms.TabPage();
            this.pupilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayaout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pupilsGridControl)).BeginInit();
            this.periodsTabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pupilBindingSource)).BeginInit();
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
            // periodsTabControl
            // 
            this.periodsTabControl.Controls.Add(this.startPeriodControl);
            this.periodsTabControl.Controls.Add(this.midiatePeriodControl);
            this.periodsTabControl.Controls.Add(this.finalPeriodControl);
            this.periodsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.periodsTabControl.Location = new System.Drawing.Point(303, 3);
            this.periodsTabControl.Name = "periodsTabControl";
            this.periodsTabControl.SelectedIndex = 0;
            this.periodsTabControl.Size = new System.Drawing.Size(462, 423);
            this.periodsTabControl.TabIndex = 1;
            // 
            // startPeriodControl
            // 
            this.startPeriodControl.Location = new System.Drawing.Point(4, 22);
            this.startPeriodControl.Name = "startPeriodControl";
            this.startPeriodControl.Padding = new System.Windows.Forms.Padding(3);
            this.startPeriodControl.Size = new System.Drawing.Size(454, 397);
            this.startPeriodControl.TabIndex = 0;
            this.startPeriodControl.Text = "Начальный";
            this.startPeriodControl.UseVisualStyleBackColor = true;
            // 
            // midiatePeriodControl
            // 
            this.midiatePeriodControl.Location = new System.Drawing.Point(4, 22);
            this.midiatePeriodControl.Name = "midiatePeriodControl";
            this.midiatePeriodControl.Padding = new System.Windows.Forms.Padding(3);
            this.midiatePeriodControl.Size = new System.Drawing.Size(454, 397);
            this.midiatePeriodControl.TabIndex = 1;
            this.midiatePeriodControl.Text = "Промежуточный";
            this.midiatePeriodControl.UseVisualStyleBackColor = true;
            // 
            // finalPeriodControl
            // 
            this.finalPeriodControl.Location = new System.Drawing.Point(4, 22);
            this.finalPeriodControl.Name = "finalPeriodControl";
            this.finalPeriodControl.Size = new System.Drawing.Size(454, 397);
            this.finalPeriodControl.TabIndex = 2;
            this.finalPeriodControl.Text = "Итоговый";
            this.finalPeriodControl.UseVisualStyleBackColor = true;
            // 
            // pupilBindingSource
            // 
            this.pupilBindingSource.AllowNew = false;
            this.pupilBindingSource.DataSource = typeof(Mko.ObjectModel.Model.Pupil);
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "FullName";
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
            this.periodsTabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pupilBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayaout;
        private System.Windows.Forms.DataGridView pupilsGridControl;
        private System.Windows.Forms.TabControl periodsTabControl;
        private System.Windows.Forms.TabPage startPeriodControl;
        private System.Windows.Forms.TabPage midiatePeriodControl;
        private System.Windows.Forms.TabPage finalPeriodControl;
        private System.Windows.Forms.BindingSource pupilBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
    }
}
