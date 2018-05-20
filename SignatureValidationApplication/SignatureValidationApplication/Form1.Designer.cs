namespace SignatureValidationApplication
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbresult = new System.Windows.Forms.TextBox();
            this.btBrowseResult = new System.Windows.Forms.Button();
            this.dgCSVData = new System.Windows.Forms.DataGridView();
            this.dgRepository = new System.Windows.Forms.DataGridView();
            this.btnRepository = new System.Windows.Forms.Button();
            this.tbRepository = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExport = new System.Windows.Forms.Button();
            this.btUpload = new System.Windows.Forms.Button();
            this.btnValidate = new System.Windows.Forms.Button();
            this.txtClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgCSVData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRepository)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File path:";
            // 
            // tbresult
            // 
            this.tbresult.Location = new System.Drawing.Point(71, 18);
            this.tbresult.Name = "tbresult";
            this.tbresult.Size = new System.Drawing.Size(269, 20);
            this.tbresult.TabIndex = 1;
            // 
            // btBrowseResult
            // 
            this.btBrowseResult.Location = new System.Drawing.Point(346, 18);
            this.btBrowseResult.Name = "btBrowseResult";
            this.btBrowseResult.Size = new System.Drawing.Size(101, 23);
            this.btBrowseResult.TabIndex = 2;
            this.btBrowseResult.Text = "Browse Result";
            this.btBrowseResult.UseVisualStyleBackColor = true;
            this.btBrowseResult.Click += new System.EventHandler(this.btBrowseResult_Click);
            // 
            // dgCSVData
            // 
            this.dgCSVData.AllowUserToAddRows = false;
            this.dgCSVData.AllowUserToDeleteRows = false;
            this.dgCSVData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCSVData.Location = new System.Drawing.Point(12, 61);
            this.dgCSVData.Name = "dgCSVData";
            this.dgCSVData.ReadOnly = true;
            this.dgCSVData.Size = new System.Drawing.Size(572, 216);
            this.dgCSVData.TabIndex = 4;
            // 
            // dgRepository
            // 
            this.dgRepository.AllowUserToAddRows = false;
            this.dgRepository.AllowUserToDeleteRows = false;
            this.dgRepository.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRepository.Location = new System.Drawing.Point(12, 338);
            this.dgRepository.Name = "dgRepository";
            this.dgRepository.ReadOnly = true;
            this.dgRepository.Size = new System.Drawing.Size(572, 219);
            this.dgRepository.TabIndex = 4;
            // 
            // btnRepository
            // 
            this.btnRepository.Location = new System.Drawing.Point(346, 299);
            this.btnRepository.Name = "btnRepository";
            this.btnRepository.Size = new System.Drawing.Size(111, 23);
            this.btnRepository.TabIndex = 7;
            this.btnRepository.Text = "Browse Repository";
            this.btnRepository.UseVisualStyleBackColor = true;
            this.btnRepository.Click += new System.EventHandler(this.btnRepository_Click);
            // 
            // tbRepository
            // 
            this.tbRepository.Location = new System.Drawing.Point(71, 299);
            this.tbRepository.Name = "tbRepository";
            this.tbRepository.Size = new System.Drawing.Size(269, 20);
            this.tbRepository.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "File path:";
            // 
            // txtExport
            // 
            this.txtExport.Location = new System.Drawing.Point(494, 580);
            this.txtExport.Name = "txtExport";
            this.txtExport.Size = new System.Drawing.Size(75, 23);
            this.txtExport.TabIndex = 8;
            this.txtExport.Text = "Export";
            this.txtExport.UseVisualStyleBackColor = true;
            this.txtExport.Click += new System.EventHandler(this.txtExport_Click);
            // 
            // btUpload
            // 
            this.btUpload.Location = new System.Drawing.Point(468, 20);
            this.btUpload.Name = "btUpload";
            this.btUpload.Size = new System.Drawing.Size(101, 23);
            this.btUpload.TabIndex = 3;
            this.btUpload.Text = "Upload CSV";
            this.btUpload.UseVisualStyleBackColor = true;
            this.btUpload.Click += new System.EventHandler(this.btUpload_Click);
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(494, 301);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(75, 23);
            this.btnValidate.TabIndex = 8;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // txtClear
            // 
            this.txtClear.Location = new System.Drawing.Point(401, 580);
            this.txtClear.Name = "txtClear";
            this.txtClear.Size = new System.Drawing.Size(75, 23);
            this.txtClear.TabIndex = 9;
            this.txtClear.Text = "Clear";
            this.txtClear.UseVisualStyleBackColor = true;
            this.txtClear.Click += new System.EventHandler(this.txtClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(12, 583);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 618);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtClear);
            this.Controls.Add(this.txtExport);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.btnRepository);
            this.Controls.Add(this.tbRepository);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgRepository);
            this.Controls.Add(this.dgCSVData);
            this.Controls.Add(this.btUpload);
            this.Controls.Add(this.btBrowseResult);
            this.Controls.Add(this.tbresult);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CSVImporter";
            ((System.ComponentModel.ISupportInitialize)(this.dgCSVData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRepository)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbresult;
        private System.Windows.Forms.Button btBrowseResult;
        private System.Windows.Forms.DataGridView dgCSVData;
        private System.Windows.Forms.DataGridView dgRepository;
        private System.Windows.Forms.Button btnRepository;
        private System.Windows.Forms.TextBox tbRepository;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button txtExport;
        private System.Windows.Forms.Button btUpload;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Button txtClear;
        private System.Windows.Forms.Label label3;
    }
}