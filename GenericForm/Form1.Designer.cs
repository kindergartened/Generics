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
            label3 = new Label();
            label2 = new Label();
            N = new TextBox();
            generate = new Button();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label4 = new Label();
            isMerge = new RadioButton();
            isQuick = new RadioButton();
            isBubble = new RadioButton();
            isPartition = new RadioButton();
            first = new RichTextBox();
            result = new RichTextBox();
            qweqweqwe = new Label();
            resultqweqwe = new Label();
            sort = new Button();
            splitter1 = new Splitter();
            button1 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // listType
            // 
            listType.DropDownStyle = ComboBoxStyle.DropDownList;
            resources.ApplyResources(listType, "listType");
            listType.ForeColor = Color.White;
            listType.FormattingEnabled = true;
            listType.Items.AddRange(new object[] { resources.GetString("listType.Items"), resources.GetString("listType.Items1"), resources.GetString("listType.Items2"), resources.GetString("listType.Items3"), resources.GetString("listType.Items4"), resources.GetString("listType.Items5") });
            listType.Name = "listType";
            // 
            // groupBox1
            // 
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.BackColor = SystemColors.AppWorkspace;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(N);
            groupBox1.Controls.Add(generate);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(listType);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.ForeColor = Color.White;
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // N
            // 
            N.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(N, "N");
            N.ForeColor = Color.White;
            N.Name = "N";
            // 
            // generate
            // 
            generate.BackColor = SystemColors.Highlight;
            resources.ApplyResources(generate, "generate");
            generate.ForeColor = SystemColors.ControlLightLight;
            generate.Name = "generate";
            generate.UseVisualStyleBackColor = false;
            generate.Click += generate_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // groupBox2
            // 
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(isMerge);
            groupBox2.Controls.Add(isQuick);
            groupBox2.Controls.Add(isBubble);
            groupBox2.Controls.Add(isPartition);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.ForeColor = Color.White;
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
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
            // isBubble
            // 
            resources.ApplyResources(isBubble, "isBubble");
            isBubble.Name = "isBubble";
            isBubble.UseVisualStyleBackColor = true;
            // 
            // isPartition
            // 
            resources.ApplyResources(isPartition, "isPartition");
            isPartition.Name = "isPartition";
            isPartition.UseVisualStyleBackColor = true;
            // 
            // first
            // 
            first.BorderStyle = BorderStyle.None;
            resources.ApplyResources(first, "first");
            first.ForeColor = Color.White;
            first.Name = "first";
            // 
            // result
            // 
            result.BorderStyle = BorderStyle.None;
            resources.ApplyResources(result, "result");
            result.ForeColor = Color.White;
            result.Name = "result";
            // 
            // qweqweqwe
            // 
            resources.ApplyResources(qweqweqwe, "qweqweqwe");
            qweqweqwe.ForeColor = Color.White;
            qweqweqwe.Name = "qweqweqwe";
            // 
            // resultqweqwe
            // 
            resources.ApplyResources(resultqweqwe, "resultqweqwe");
            resultqweqwe.ForeColor = Color.White;
            resultqweqwe.Name = "resultqweqwe";
            // 
            // sort
            // 
            sort.BackColor = SystemColors.Highlight;
            resources.ApplyResources(sort, "sort");
            sort.ForeColor = SystemColors.ButtonHighlight;
            sort.Name = "sort";
            sort.UseVisualStyleBackColor = false;
            sort.Click += sort_Click;
            // 
            // splitter1
            // 
            resources.ApplyResources(splitter1, "splitter1");
            splitter1.Name = "splitter1";
            splitter1.TabStop = false;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.night_mode;
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.bulb;
            resources.ApplyResources(button3, "button3");
            button3.Name = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Generics
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(splitter1);
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
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox listType;
        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private RadioButton isBubble;
        private RadioButton isPartition;
        private RadioButton isQuick;
        private RichTextBox first;
        private RichTextBox result;
        private Button generate;
        private Label qweqweqwe;
        private Label resultqweqwe;
        private TextBox N;
        private RadioButton isMerge;
        private Button sort;
        private Label label3;
        private Label label2;
        private Label label4;
        private Splitter splitter1;
        private Button button1;
        private Button button3;
    }
}