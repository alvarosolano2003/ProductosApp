namespace ProductosAppM1.Forms
{
    partial class FrmProductManage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbFinder = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.pnlFinByID = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlMeasurentUnit = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbMeasureUnit = new System.Windows.Forms.ComboBox();
            this.pnlPrice = new System.Windows.Forms.FlowLayoutPanel();
            this.nudFromPrice = new System.Windows.Forms.NumericUpDown();
            this.nudToPrice = new System.Windows.Forms.NumericUpDown();
            this.pnlCaducity = new System.Windows.Forms.FlowLayoutPanel();
            this.dtpCaducity = new System.Windows.Forms.DateTimePicker();
            this.rtbProductView = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlFinByID.SuspendLayout();
            this.pnlMeasurentUnit.SuspendLayout();
            this.pnlPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFromPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudToPrice)).BeginInit();
            this.pnlCaducity.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnNew);
            this.flowLayoutPanel1.Controls.Add(this.btnUpdate);
            this.flowLayoutPanel1.Controls.Add(this.btnDelete);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 408);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(709, 30);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(631, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(550, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Modificar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(469, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbFinder
            // 
            this.cmbFinder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFinder.FormattingEnabled = true;
            this.cmbFinder.Items.AddRange(new object[] {
            "Id",
            "Unidad de medida",
            "Rango de precio",
            "Fecha de vencimiento"});
            this.cmbFinder.Location = new System.Drawing.Point(12, 14);
            this.cmbFinder.Name = "cmbFinder";
            this.cmbFinder.Size = new System.Drawing.Size(223, 21);
            this.cmbFinder.TabIndex = 1;
            this.cmbFinder.SelectedIndexChanged += new System.EventHandler(this.CmbFinder_SelectedIndexChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(3, 3);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(465, 20);
            this.txtID.TabIndex = 7;
            // 
            // pnlFinByID
            // 
            this.pnlFinByID.Controls.Add(this.txtID);
            this.pnlFinByID.Location = new System.Drawing.Point(254, 12);
            this.pnlFinByID.Name = "pnlFinByID";
            this.pnlFinByID.Size = new System.Drawing.Size(468, 36);
            this.pnlFinByID.TabIndex = 4;
            this.pnlFinByID.Visible = false;
            // 
            // pnlMeasurentUnit
            // 
            this.pnlMeasurentUnit.Controls.Add(this.cmbMeasureUnit);
            this.pnlMeasurentUnit.Location = new System.Drawing.Point(254, 12);
            this.pnlMeasurentUnit.Name = "pnlMeasurentUnit";
            this.pnlMeasurentUnit.Size = new System.Drawing.Size(468, 36);
            this.pnlMeasurentUnit.TabIndex = 8;
            this.pnlMeasurentUnit.Visible = false;
            // 
            // cmbMeasureUnit
            // 
            this.cmbMeasureUnit.FormattingEnabled = true;
            this.cmbMeasureUnit.Location = new System.Drawing.Point(3, 3);
            this.cmbMeasureUnit.Name = "cmbMeasureUnit";
            this.cmbMeasureUnit.Size = new System.Drawing.Size(465, 21);
            this.cmbMeasureUnit.TabIndex = 9;
            // 
            // pnlPrice
            // 
            this.pnlPrice.Controls.Add(this.nudFromPrice);
            this.pnlPrice.Controls.Add(this.nudToPrice);
            this.pnlPrice.Location = new System.Drawing.Point(254, 12);
            this.pnlPrice.Name = "pnlPrice";
            this.pnlPrice.Size = new System.Drawing.Size(468, 36);
            this.pnlPrice.TabIndex = 10;
            this.pnlPrice.Visible = false;
            // 
            // nudFromPrice
            // 
            this.nudFromPrice.Location = new System.Drawing.Point(3, 3);
            this.nudFromPrice.Name = "nudFromPrice";
            this.nudFromPrice.Size = new System.Drawing.Size(220, 20);
            this.nudFromPrice.TabIndex = 12;
            // 
            // nudToPrice
            // 
            this.nudToPrice.Location = new System.Drawing.Point(229, 3);
            this.nudToPrice.Name = "nudToPrice";
            this.nudToPrice.Size = new System.Drawing.Size(220, 20);
            this.nudToPrice.TabIndex = 12;
            // 
            // pnlCaducity
            // 
            this.pnlCaducity.Controls.Add(this.dtpCaducity);
            this.pnlCaducity.Location = new System.Drawing.Point(254, 12);
            this.pnlCaducity.Name = "pnlCaducity";
            this.pnlCaducity.Size = new System.Drawing.Size(468, 36);
            this.pnlCaducity.TabIndex = 12;
            this.pnlCaducity.Visible = false;
            // 
            // dtpCaducity
            // 
            this.dtpCaducity.Location = new System.Drawing.Point(3, 3);
            this.dtpCaducity.Name = "dtpCaducity";
            this.dtpCaducity.Size = new System.Drawing.Size(272, 20);
            this.dtpCaducity.TabIndex = 0;
            // 
            // rtbProductView
            // 
            this.rtbProductView.Location = new System.Drawing.Point(12, 68);
            this.rtbProductView.Name = "rtbProductView";
            this.rtbProductView.ReadOnly = true;
            this.rtbProductView.Size = new System.Drawing.Size(706, 320);
            this.rtbProductView.TabIndex = 13;
            this.rtbProductView.Text = "";
            // 
            // FrmProductManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 450);
            this.Controls.Add(this.rtbProductView);
            this.Controls.Add(this.pnlMeasurentUnit);
            this.Controls.Add(this.pnlCaducity);
            this.Controls.Add(this.cmbFinder);
            this.Controls.Add(this.pnlPrice);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnlFinByID);
            this.Name = "FrmProductManage";
            this.Text = "FrmProductManage";
            this.Load += new System.EventHandler(this.FrmProductManage_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlFinByID.ResumeLayout(false);
            this.pnlFinByID.PerformLayout();
            this.pnlMeasurentUnit.ResumeLayout(false);
            this.pnlPrice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudFromPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudToPrice)).EndInit();
            this.pnlCaducity.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbFinder;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.FlowLayoutPanel pnlFinByID;
        private System.Windows.Forms.FlowLayoutPanel pnlMeasurentUnit;
        private System.Windows.Forms.ComboBox cmbMeasureUnit;
        private System.Windows.Forms.FlowLayoutPanel pnlPrice;
        private System.Windows.Forms.NumericUpDown nudFromPrice;
        private System.Windows.Forms.NumericUpDown nudToPrice;
        private System.Windows.Forms.FlowLayoutPanel pnlCaducity;
        private System.Windows.Forms.DateTimePicker dtpCaducity;
        private System.Windows.Forms.RichTextBox rtbProductView;
    }
}