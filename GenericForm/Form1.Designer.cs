namespace GenericForm
{
    partial class Generics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Generics));
            listType = new ComboBox();
            groupBox1 = new GroupBox();
            Nqwe = new Label();
            N = new TextBox();
            generate = new Button();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            isMerge = new RadioButton();
            isQuick = new RadioButton();
            isPartition = new RadioButton();
            isBubble = new RadioButton();
            first = new RichTextBox();
            result = new RichTextBox();
            qweqweqwe = new Label();
            resultqweqwe = new Label();
            sort = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // listType
            // 
            resources.ApplyResources(listType, "listType");
            listType.FormattingEnabled = true;
            listType.Items.AddRange(new object[] { resources.GetString("listType.Items"), resources.GetString("listType.Items1"), resources.GetString("listType.Items2"), resources.GetString("listType.Items3"), resources.GetString("listType.Items4"), resources.GetString("listType.Items5") });
            listType.Name = "listType";
            // 
            // groupBox1
            // 
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(Nqwe);
            groupBox1.Controls.Add(N);
            groupBox1.Controls.Add(generate);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(listType);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // Nqwe
            // 
            resources.ApplyResources(Nqwe, "Nqwe");
            Nqwe.BackColor = SystemColors.Control;
            Nqwe.Name = "Nqwe";
            // 
            // N
            // 
            resources.ApplyResources(N, "N");
            N.Name = "N";
            // 
            // generate
            // 
            resources.ApplyResources(generate, "generate");
            generate.Name = "generate";
            generate.UseVisualStyleBackColor = true;
            generate.Click += generate_Click;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = SystemColors.Control;
            label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox3);
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.Control;
            groupBox3.Controls.Add(isMerge);
            groupBox3.Controls.Add(isQuick);
            groupBox3.Controls.Add(isPartition);
            groupBox3.Controls.Add(isBubble);
            groupBox3.Cursor = Cursors.Hand;
            groupBox3.FlatStyle = FlatStyle.Flat;
            resources.ApplyResources(groupBox3, "groupBox3");
            groupBox3.Name = "groupBox3";
            groupBox3.TabStop = false;
            groupBox3.UseCompatibleTextRendering = true;
            // 
            // isMerge
            // 
            resources.ApplyResources(isMerge, "isMerge");
            isMerge.Name = "isMerge";
            isMerge.UseVisualStyleBackColor = true;
            // 
            // isQuick
            // 
            resources.ApplyResources(isQuick, "isQuick");
            isQuick.Checked = true;
            isQuick.Name = "isQuick";
            isQuick.TabStop = true;
            isQuick.UseVisualStyleBackColor = true;
            // 
            // isPartition
            // 
            resources.ApplyResources(isPartition, "isPartition");
            isPartition.Name = "isPartition";
            isPartition.UseVisualStyleBackColor = true;
            // 
            // isBubble
            // 
            resources.ApplyResources(isBubble, "isBubble");
            isBubble.Name = "isBubble";
            isBubble.UseVisualStyleBackColor = true;
            // 
            // first
            // 
            resources.ApplyResources(first, "first");
            first.Name = "first";
            // 
            // result
            // 
            resources.ApplyResources(result, "result");
            result.Name = "result";
            // 
            // qweqweqwe
            // 
            resources.ApplyResources(qweqweqwe, "qweqweqwe");
            qweqweqwe.Name = "qweqweqwe";
            // 
            // resultqweqwe
            // 
            resources.ApplyResources(resultqweqwe, "resultqweqwe");
            resultqweqwe.Name = "resultqweqwe";
            // 
            // sort
            // 
            resources.ApplyResources(sort, "sort");
            sort.Name = "sort";
            sort.UseVisualStyleBackColor = true;
            sort.Click += sort_Click;
            // 
            // Generics
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(sort);
            Controls.Add(resultqweqwe);
            Controls.Add(qweqweqwe);
            Controls.Add(result);
            Controls.Add(first);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Generics";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox listType;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private GroupBox groupBox2;
        private RadioButton isBubble;
        private RadioButton isPartition;
        private RadioButton isQuick;
        private GroupBox groupBox3;
        private RichTextBox first;
        private RichTextBox result;
        private Button generate;
        private Label qweqweqwe;
        private Label resultqweqwe;
        private Label Nqwe;
        private TextBox N;
        private RadioButton isMerge;
        private Button sort;
    }
}