namespace NetCore
{
    partial class SettingForm
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
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            groupBox1 = new System.Windows.Forms.GroupBox();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtAddressBroker = new System.Windows.Forms.TextBox();
            txtPort = new System.Windows.Forms.TextBox();
            txtTopic = new System.Windows.Forms.TextBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            label4 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            Caption = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            txtCaptionWindown = new System.Windows.Forms.TextBox();
            txtClassTextBox = new System.Windows.Forms.TextBox();
            txtClassButton = new System.Windows.Forms.TextBox();
            txtCaptionButton = new System.Windows.Forms.TextBox();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            btnSave = new System.Windows.Forms.Button();
            btnFind = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            txtPath = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = System.Drawing.Color.SlateGray;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            tableLayoutPanel1.Controls.Add(groupBox1, 1, 1);
            tableLayoutPanel1.Controls.Add(groupBox2, 1, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 5);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 1, 4);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            tableLayoutPanel1.Size = new System.Drawing.Size(699, 522);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox1.Controls.Add(tableLayoutPanel3);
            groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox1.ForeColor = System.Drawing.Color.Red;
            groupBox1.Location = new System.Drawing.Point(8, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(683, 154);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "MQTT";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(label2, 0, 2);
            tableLayoutPanel3.Controls.Add(label3, 0, 4);
            tableLayoutPanel3.Controls.Add(txtAddressBroker, 1, 0);
            tableLayoutPanel3.Controls.Add(txtPort, 1, 2);
            tableLayoutPanel3.Controls.Add(txtTopic, 1, 4);
            tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            tableLayoutPanel3.Location = new System.Drawing.Point(3, 29);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3333359F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3333359F));
            tableLayoutPanel3.Size = new System.Drawing.Size(677, 122);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(184, 33);
            label1.TabIndex = 0;
            label1.Text = "Address Broker:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(3, 43);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(184, 34);
            label2.TabIndex = 1;
            label2.Text = "Port:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(3, 87);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(184, 35);
            label3.TabIndex = 2;
            label3.Text = "Topic:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAddressBroker
            // 
            txtAddressBroker.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtAddressBroker.BackColor = System.Drawing.Color.SteelBlue;
            txtAddressBroker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtAddressBroker.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtAddressBroker.ForeColor = System.Drawing.Color.White;
            txtAddressBroker.Location = new System.Drawing.Point(193, 3);
            txtAddressBroker.Name = "txtAddressBroker";
            txtAddressBroker.Size = new System.Drawing.Size(481, 33);
            txtAddressBroker.TabIndex = 3;
            // 
            // txtPort
            // 
            txtPort.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtPort.BackColor = System.Drawing.Color.SteelBlue;
            txtPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtPort.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPort.ForeColor = System.Drawing.Color.White;
            txtPort.Location = new System.Drawing.Point(193, 46);
            txtPort.Name = "txtPort";
            txtPort.Size = new System.Drawing.Size(481, 33);
            txtPort.TabIndex = 4;
            // 
            // txtTopic
            // 
            txtTopic.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtTopic.BackColor = System.Drawing.Color.SteelBlue;
            txtTopic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtTopic.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtTopic.ForeColor = System.Drawing.Color.White;
            txtTopic.Location = new System.Drawing.Point(193, 90);
            txtTopic.Name = "txtTopic";
            txtTopic.Size = new System.Drawing.Size(481, 33);
            txtTopic.TabIndex = 5;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox2.Controls.Add(tableLayoutPanel4);
            groupBox2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox2.ForeColor = System.Drawing.Color.Red;
            groupBox2.Location = new System.Drawing.Point(8, 178);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(683, 236);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Class Optel";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(label4, 0, 6);
            tableLayoutPanel4.Controls.Add(label6, 0, 4);
            tableLayoutPanel4.Controls.Add(Caption, 0, 0);
            tableLayoutPanel4.Controls.Add(label5, 0, 2);
            tableLayoutPanel4.Controls.Add(txtCaptionWindown, 1, 0);
            tableLayoutPanel4.Controls.Add(txtClassTextBox, 1, 2);
            tableLayoutPanel4.Controls.Add(txtClassButton, 1, 4);
            tableLayoutPanel4.Controls.Add(txtCaptionButton, 1, 6);
            tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            tableLayoutPanel4.Location = new System.Drawing.Point(3, 29);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 7;
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new System.Drawing.Size(677, 204);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(3, 159);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(184, 45);
            label4.TabIndex = 7;
            label4.Text = "Caption Button:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label6.AutoSize = true;
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(3, 106);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(184, 43);
            label6.TabIndex = 5;
            label6.Text = "Class button:";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Caption
            // 
            Caption.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            Caption.AutoSize = true;
            Caption.ForeColor = System.Drawing.Color.White;
            Caption.Location = new System.Drawing.Point(3, 0);
            Caption.Name = "Caption";
            Caption.Size = new System.Drawing.Size(184, 43);
            Caption.TabIndex = 0;
            Caption.Text = "Caption Windown:";
            Caption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(3, 53);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(184, 43);
            label5.TabIndex = 1;
            label5.Text = "Class textbox:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCaptionWindown
            // 
            txtCaptionWindown.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtCaptionWindown.BackColor = System.Drawing.Color.SteelBlue;
            txtCaptionWindown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtCaptionWindown.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtCaptionWindown.ForeColor = System.Drawing.Color.White;
            txtCaptionWindown.Location = new System.Drawing.Point(193, 3);
            txtCaptionWindown.Name = "txtCaptionWindown";
            txtCaptionWindown.Size = new System.Drawing.Size(481, 33);
            txtCaptionWindown.TabIndex = 3;
            // 
            // txtClassTextBox
            // 
            txtClassTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtClassTextBox.BackColor = System.Drawing.Color.SteelBlue;
            txtClassTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtClassTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtClassTextBox.ForeColor = System.Drawing.Color.White;
            txtClassTextBox.Location = new System.Drawing.Point(193, 56);
            txtClassTextBox.Name = "txtClassTextBox";
            txtClassTextBox.Size = new System.Drawing.Size(481, 33);
            txtClassTextBox.TabIndex = 4;
            // 
            // txtClassButton
            // 
            txtClassButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtClassButton.BackColor = System.Drawing.Color.SteelBlue;
            txtClassButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtClassButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtClassButton.ForeColor = System.Drawing.Color.White;
            txtClassButton.Location = new System.Drawing.Point(193, 109);
            txtClassButton.Name = "txtClassButton";
            txtClassButton.Size = new System.Drawing.Size(481, 33);
            txtClassButton.TabIndex = 6;
            // 
            // txtCaptionButton
            // 
            txtCaptionButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtCaptionButton.BackColor = System.Drawing.Color.SteelBlue;
            txtCaptionButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtCaptionButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtCaptionButton.ForeColor = System.Drawing.Color.White;
            txtCaptionButton.Location = new System.Drawing.Point(193, 162);
            txtCaptionButton.Name = "txtCaptionButton";
            txtCaptionButton.Size = new System.Drawing.Size(481, 33);
            txtCaptionButton.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.99744F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.3401642F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.8312F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.8312F));
            tableLayoutPanel2.Controls.Add(btnSave, 5, 0);
            tableLayoutPanel2.Controls.Add(btnFind, 0, 0);
            tableLayoutPanel2.Controls.Add(btnCancel, 3, 0);
            tableLayoutPanel2.Location = new System.Drawing.Point(8, 470);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new System.Drawing.Size(683, 44);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnSave.BackColor = System.Drawing.Color.Indigo;
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.Location = new System.Drawing.Point(583, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(97, 38);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnFind
            // 
            btnFind.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnFind.BackColor = System.Drawing.Color.Orange;
            btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFind.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnFind.ForeColor = System.Drawing.Color.White;
            btnFind.Location = new System.Drawing.Point(3, 3);
            btnFind.Name = "btnFind";
            btnFind.Size = new System.Drawing.Size(116, 38);
            btnFind.TabIndex = 2;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnCancel.BackColor = System.Drawing.Color.FromArgb(0, 64, 0);
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancel.ForeColor = System.Drawing.Color.White;
            btnCancel.Location = new System.Drawing.Point(462, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(95, 38);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 193F));
            tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(txtPath, 1, 0);
            tableLayoutPanel5.Controls.Add(label7, 0, 0);
            tableLayoutPanel5.Location = new System.Drawing.Point(8, 420);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new System.Drawing.Size(683, 44);
            tableLayoutPanel5.TabIndex = 4;
            // 
            // txtPath
            // 
            txtPath.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtPath.BackColor = System.Drawing.Color.SteelBlue;
            txtPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtPath.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPath.ForeColor = System.Drawing.Color.White;
            txtPath.Location = new System.Drawing.Point(196, 3);
            txtPath.Name = "txtPath";
            txtPath.Size = new System.Drawing.Size(484, 33);
            txtPath.TabIndex = 5;
            // 
            // label7
            // 
            label7.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.ForeColor = System.Drawing.Color.White;
            label7.Location = new System.Drawing.Point(3, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(187, 44);
            label7.TabIndex = 3;
            label7.Text = "Path file:";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SettingForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(699, 522);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Name = "SettingForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "SettingForm";
            Load += SettingForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label Caption;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCaptionWindown;
        private System.Windows.Forms.TextBox txtClassTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtClassButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddressBroker;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtTopic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCaptionButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label7;
    }
}