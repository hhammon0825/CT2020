using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    [DesignerGenerated()]
    internal partial class FormArcTime
    {
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        [DebuggerNonUserCode()]
        public FormArcTime() : base()
        {
            // This is required by the Windows Form Designer.
            InitializeComponent();
        }
        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool Disposing)
        {
            if (Disposing)
            {
                if (components is object)
                {
                    components.Dispose();
                }
            }

            base.Dispose(Disposing);
        }
        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;
        public ToolTip ToolTip1;
        private TextBox _txtLoMin;

        public TextBox txtLoMin
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtLoMin;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtLoMin != null)
                {
                    _txtLoMin.TextChanged -= txtLoMin_TextChanged;
                    _txtLoMin.KeyPress -= txtLoMin_KeyPress;
                    _txtLoMin.Validating -= txtLoMin_Validating;
                    _txtLoMin.Enter -= txtLoMin_Enter;
                }

                _txtLoMin = value;
                if (_txtLoMin != null)
                {
                    _txtLoMin.TextChanged += txtLoMin_TextChanged;
                    _txtLoMin.KeyPress += txtLoMin_KeyPress;
                    _txtLoMin.Validating += txtLoMin_Validating;
                    _txtLoMin.Enter += txtLoMin_Enter;
                }
            }
        }

        public ComboBox cboLo;
        private TextBox _txtLoDeg;

        public TextBox txtLoDeg
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtLoDeg;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtLoDeg != null)
                {
                    _txtLoDeg.TextChanged -= txtLoDeg_TextChanged;
                    _txtLoDeg.KeyPress -= txtLoDeg_KeyPress;
                    _txtLoDeg.Validating -= txtLoDeg_Validating;
                    _txtLoDeg.Enter -= txtLoDeg_Enter;
                }

                _txtLoDeg = value;
                if (_txtLoDeg != null)
                {
                    _txtLoDeg.TextChanged += txtLoDeg_TextChanged;
                    _txtLoDeg.KeyPress += txtLoDeg_KeyPress;
                    _txtLoDeg.Validating += txtLoDeg_Validating;
                    _txtLoDeg.Enter += txtLoDeg_Enter;
                }
            }
        }

        private RadioButton _optZTtoLMT;

        public RadioButton optZTtoLMT
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optZTtoLMT;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optZTtoLMT != null)
                {
                    _optZTtoLMT.CheckedChanged -= optZTtoLMT_CheckedChanged;
                }

                _optZTtoLMT = value;
                if (_optZTtoLMT != null)
                {
                    _optZTtoLMT.CheckedChanged += optZTtoLMT_CheckedChanged;
                }
            }
        }

        private RadioButton _optLMTtoZT;

        public RadioButton optLMTtoZT
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optLMTtoZT;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optLMTtoZT != null)
                {
                    _optLMTtoZT.CheckedChanged -= optLMTtoZT_CheckedChanged;
                }

                _optLMTtoZT = value;
                if (_optLMTtoZT != null)
                {
                    _optLMTtoZT.CheckedChanged += optLMTtoZT_CheckedChanged;
                }
            }
        }

        public GroupBox Frame2;
        private Button _cmdPrint;

        public Button cmdPrint
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdPrint;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdPrint != null)
                {
                    _cmdPrint.Click -= cmdPrint_Click;
                }

                _cmdPrint = value;
                if (_cmdPrint != null)
                {
                    _cmdPrint.Click += cmdPrint_Click;
                }
            }
        }

        private Button _cmdConvert;

        public Button cmdConvert
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdConvert;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdConvert != null)
                {
                    _cmdConvert.Click -= cmdConvert_Click;
                }

                _cmdConvert = value;
                if (_cmdConvert != null)
                {
                    _cmdConvert.Click += cmdConvert_Click;
                }
            }
        }

        private TextBox _txtDeg;

        public TextBox txtDeg
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtDeg;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtDeg != null)
                {
                    _txtDeg.TextChanged -= txtDeg_TextChanged;
                    _txtDeg.KeyPress -= txtDeg_KeyPress;
                    _txtDeg.Validating -= txtDeg_Validating;
                    _txtDeg.Enter -= txtDeg_Enter;
                }

                _txtDeg = value;
                if (_txtDeg != null)
                {
                    _txtDeg.TextChanged += txtDeg_TextChanged;
                    _txtDeg.KeyPress += txtDeg_KeyPress;
                    _txtDeg.Validating += txtDeg_Validating;
                    _txtDeg.Enter += txtDeg_Enter;
                }
            }
        }

        private TextBox _txtMin;

        public TextBox txtMin
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtMin;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtMin != null)
                {
                    _txtMin.TextChanged -= txtMin_TextChanged;
                    _txtMin.KeyPress -= txtMin_KeyPress;
                    _txtMin.Validating -= txtMin_Validating;
                    _txtMin.Enter -= txtMin_Enter;
                }

                _txtMin = value;
                if (_txtMin != null)
                {
                    _txtMin.TextChanged += txtMin_TextChanged;
                    _txtMin.KeyPress += txtMin_KeyPress;
                    _txtMin.Validating += txtMin_Validating;
                    _txtMin.Enter += txtMin_Enter;
                }
            }
        }

        private RadioButton _optTimeToArc;

        public RadioButton optTimeToArc
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optTimeToArc;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optTimeToArc != null)
                {
                    _optTimeToArc.CheckedChanged -= optTimeToArc_CheckedChanged;
                }

                _optTimeToArc = value;
                if (_optTimeToArc != null)
                {
                    _optTimeToArc.CheckedChanged += optTimeToArc_CheckedChanged;
                }
            }
        }

        private RadioButton _optArcToTime;

        public RadioButton optArcToTime
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optArcToTime;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optArcToTime != null)
                {
                    _optArcToTime.CheckedChanged -= optArcToTime_CheckedChanged;
                }

                _optArcToTime = value;
                if (_optArcToTime != null)
                {
                    _optArcToTime.CheckedChanged += optArcToTime_CheckedChanged;
                }
            }
        }

        public GroupBox Frame1;
        public Label lblZT;
        public Label lblLMT;
        public Label lblLoMin;
        public Label lblLoDeg;
        public Label Label1;
        public Label lblArc;
        public Label lblDeg;
        public Label lblMin;
        public Label lblTime;
        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormArcTime));
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this._txtLoMin = new System.Windows.Forms.TextBox();
            this._txtLoDeg = new System.Windows.Forms.TextBox();
            this._cmdPrint = new System.Windows.Forms.Button();
            this._txtDeg = new System.Windows.Forms.TextBox();
            this._txtMin = new System.Windows.Forms.TextBox();
            this.lblArc = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.cboLo = new System.Windows.Forms.ComboBox();
            this.Frame2 = new System.Windows.Forms.GroupBox();
            this._optZTtoLMT = new System.Windows.Forms.RadioButton();
            this._optLMTtoZT = new System.Windows.Forms.RadioButton();
            this._cmdConvert = new System.Windows.Forms.Button();
            this.Frame1 = new System.Windows.Forms.GroupBox();
            this._optTimeToArc = new System.Windows.Forms.RadioButton();
            this._optArcToTime = new System.Windows.Forms.RadioButton();
            this.lblZT = new System.Windows.Forms.Label();
            this.lblLMT = new System.Windows.Forms.Label();
            this.lblLoMin = new System.Windows.Forms.Label();
            this.lblLoDeg = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.lblDeg = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.txtArcTime = new System.Windows.Forms.TextBox();
            this.txtLMTZT = new System.Windows.Forms.TextBox();
            this._ExitBtn = new System.Windows.Forms.Button();
            this._ClearBtn = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.ArcTime = new System.Windows.Forms.TabPage();
            this.DTTime = new System.Windows.Forms.DateTimePicker();
            this.LMTZT = new System.Windows.Forms.TabPage();
            this.DTLMT = new System.Windows.Forms.DateTimePicker();
            this.Frame2.SuspendLayout();
            this.Frame1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.ArcTime.SuspendLayout();
            this.LMTZT.SuspendLayout();
            this.SuspendLayout();
            // 
            // _txtLoMin
            // 
            this._txtLoMin.AcceptsReturn = true;
            this._txtLoMin.BackColor = System.Drawing.SystemColors.Window;
            this._txtLoMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtLoMin.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtLoMin.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtLoMin.Location = new System.Drawing.Point(216, 71);
            this._txtLoMin.MaxLength = 4;
            this._txtLoMin.Name = "_txtLoMin";
            this._txtLoMin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtLoMin.Size = new System.Drawing.Size(33, 20);
            this._txtLoMin.TabIndex = 15;
            this.ToolTip1.SetToolTip(this._txtLoMin, "Range 0 to 59.9");
            this._txtLoMin.TextChanged += new System.EventHandler(this.txtLoMin_TextChanged);
            this._txtLoMin.Enter += new System.EventHandler(this.txtLoMin_Enter);
            this._txtLoMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLoMin_KeyPress);
            this._txtLoMin.Validating += new System.ComponentModel.CancelEventHandler(this.txtLoMin_Validating);
            // 
            // _txtLoDeg
            // 
            this._txtLoDeg.AcceptsReturn = true;
            this._txtLoDeg.BackColor = System.Drawing.SystemColors.Window;
            this._txtLoDeg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtLoDeg.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtLoDeg.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtLoDeg.Location = new System.Drawing.Point(173, 71);
            this._txtLoDeg.MaxLength = 3;
            this._txtLoDeg.Name = "_txtLoDeg";
            this._txtLoDeg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtLoDeg.Size = new System.Drawing.Size(33, 20);
            this._txtLoDeg.TabIndex = 14;
            this.ToolTip1.SetToolTip(this._txtLoDeg, "Range 0 to 180");
            this._txtLoDeg.TextChanged += new System.EventHandler(this.txtLoDeg_TextChanged);
            this._txtLoDeg.Enter += new System.EventHandler(this.txtLoDeg_Enter);
            this._txtLoDeg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLoDeg_KeyPress);
            this._txtLoDeg.Validating += new System.ComponentModel.CancelEventHandler(this.txtLoDeg_Validating);
            // 
            // _cmdPrint
            // 
            this._cmdPrint.BackColor = System.Drawing.SystemColors.Control;
            this._cmdPrint.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdPrint.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdPrint.Image = ((System.Drawing.Image)(resources.GetObject("_cmdPrint.Image")));
            this._cmdPrint.Location = new System.Drawing.Point(440, 0);
            this._cmdPrint.Name = "_cmdPrint";
            this._cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdPrint.Size = new System.Drawing.Size(21, 21);
            this._cmdPrint.TabIndex = 23;
            this._cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ToolTip1.SetToolTip(this._cmdPrint, "Print window");
            this._cmdPrint.UseVisualStyleBackColor = false;
            this._cmdPrint.Click += new System.EventHandler(this.cmdPrint_Click);
            // 
            // _txtDeg
            // 
            this._txtDeg.AcceptsReturn = true;
            this._txtDeg.BackColor = System.Drawing.SystemColors.Window;
            this._txtDeg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtDeg.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtDeg.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtDeg.Location = new System.Drawing.Point(198, 66);
            this._txtDeg.MaxLength = 3;
            this._txtDeg.Name = "_txtDeg";
            this._txtDeg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtDeg.Size = new System.Drawing.Size(33, 20);
            this._txtDeg.TabIndex = 3;
            this.ToolTip1.SetToolTip(this._txtDeg, "Range 0 to 359");
            this._txtDeg.TextChanged += new System.EventHandler(this.txtDeg_TextChanged);
            this._txtDeg.Enter += new System.EventHandler(this.txtDeg_Enter);
            this._txtDeg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeg_KeyPress);
            this._txtDeg.Validating += new System.ComponentModel.CancelEventHandler(this.txtDeg_Validating);
            // 
            // _txtMin
            // 
            this._txtMin.AcceptsReturn = true;
            this._txtMin.BackColor = System.Drawing.SystemColors.Window;
            this._txtMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtMin.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtMin.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtMin.Location = new System.Drawing.Point(244, 66);
            this._txtMin.MaxLength = 4;
            this._txtMin.Name = "_txtMin";
            this._txtMin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtMin.Size = new System.Drawing.Size(33, 20);
            this._txtMin.TabIndex = 4;
            this.ToolTip1.SetToolTip(this._txtMin, "Range 0 to 59.9");
            this._txtMin.TextChanged += new System.EventHandler(this.txtMin_TextChanged);
            this._txtMin.Enter += new System.EventHandler(this.txtMin_Enter);
            this._txtMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMin_KeyPress);
            this._txtMin.Validating += new System.ComponentModel.CancelEventHandler(this.txtMin_Validating);
            // 
            // lblArc
            // 
            this.lblArc.BackColor = System.Drawing.SystemColors.Window;
            this.lblArc.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblArc.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblArc.Location = new System.Drawing.Point(155, 66);
            this.lblArc.Name = "lblArc";
            this.lblArc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblArc.Size = new System.Drawing.Size(26, 22);
            this.lblArc.TabIndex = 9;
            this.lblArc.Text = "Arc";
            this.lblArc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ToolTip1.SetToolTip(this.lblArc, "Sextant Altitude");
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.SystemColors.Window;
            this.lblTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTime.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTime.Location = new System.Drawing.Point(108, 92);
            this.lblTime.Name = "lblTime";
            this.lblTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTime.Size = new System.Drawing.Size(89, 20);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "Time (hh:mm:ss)";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ToolTip1.SetToolTip(this.lblTime, "Watch Time");
            this.lblTime.Visible = false;
            // 
            // cboLo
            // 
            this.cboLo.BackColor = System.Drawing.SystemColors.Window;
            this.cboLo.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboLo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLo.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboLo.Items.AddRange(new object[] {
            "W",
            "E"});
            this.cboLo.Location = new System.Drawing.Point(258, 70);
            this.cboLo.Name = "cboLo";
            this.cboLo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboLo.Size = new System.Drawing.Size(41, 22);
            this.cboLo.TabIndex = 17;
            // 
            // Frame2
            // 
            this.Frame2.BackColor = System.Drawing.SystemColors.Window;
            this.Frame2.Controls.Add(this._optZTtoLMT);
            this.Frame2.Controls.Add(this._optLMTtoZT);
            this.Frame2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame2.Location = new System.Drawing.Point(128, 23);
            this.Frame2.Name = "Frame2";
            this.Frame2.Padding = new System.Windows.Forms.Padding(0);
            this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame2.Size = new System.Drawing.Size(185, 41);
            this.Frame2.TabIndex = 10;
            this.Frame2.TabStop = false;
            this.Frame2.Text = "Convert";
            // 
            // _optZTtoLMT
            // 
            this._optZTtoLMT.BackColor = System.Drawing.SystemColors.Window;
            this._optZTtoLMT.Cursor = System.Windows.Forms.Cursors.Default;
            this._optZTtoLMT.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optZTtoLMT.ForeColor = System.Drawing.SystemColors.ControlText;
            this._optZTtoLMT.Location = new System.Drawing.Point(96, 16);
            this._optZTtoLMT.Name = "_optZTtoLMT";
            this._optZTtoLMT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optZTtoLMT.Size = new System.Drawing.Size(73, 17);
            this._optZTtoLMT.TabIndex = 12;
            this._optZTtoLMT.TabStop = true;
            this._optZTtoLMT.Text = "ZT to LMT";
            this._optZTtoLMT.UseVisualStyleBackColor = false;
            this._optZTtoLMT.CheckedChanged += new System.EventHandler(this.optZTtoLMT_CheckedChanged);
            // 
            // _optLMTtoZT
            // 
            this._optLMTtoZT.BackColor = System.Drawing.SystemColors.Window;
            this._optLMTtoZT.Checked = true;
            this._optLMTtoZT.Cursor = System.Windows.Forms.Cursors.Default;
            this._optLMTtoZT.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optLMTtoZT.ForeColor = System.Drawing.SystemColors.ControlText;
            this._optLMTtoZT.Location = new System.Drawing.Point(8, 16);
            this._optLMTtoZT.Name = "_optLMTtoZT";
            this._optLMTtoZT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optLMTtoZT.Size = new System.Drawing.Size(73, 17);
            this._optLMTtoZT.TabIndex = 11;
            this._optLMTtoZT.TabStop = true;
            this._optLMTtoZT.Text = "LMT to ZT";
            this._optLMTtoZT.UseVisualStyleBackColor = false;
            this._optLMTtoZT.CheckedChanged += new System.EventHandler(this.optLMTtoZT_CheckedChanged);
            // 
            // _cmdConvert
            // 
            this._cmdConvert.BackColor = System.Drawing.SystemColors.Control;
            this._cmdConvert.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdConvert.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmdConvert.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdConvert.Location = new System.Drawing.Point(186, 241);
            this._cmdConvert.Name = "_cmdConvert";
            this._cmdConvert.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdConvert.Size = new System.Drawing.Size(92, 25);
            this._cmdConvert.TabIndex = 22;
            this._cmdConvert.Text = "&Convert";
            this._cmdConvert.UseVisualStyleBackColor = false;
            this._cmdConvert.Click += new System.EventHandler(this.cmdConvert_Click);
            // 
            // Frame1
            // 
            this.Frame1.BackColor = System.Drawing.SystemColors.Window;
            this.Frame1.Controls.Add(this._optTimeToArc);
            this.Frame1.Controls.Add(this._optArcToTime);
            this.Frame1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame1.Location = new System.Drawing.Point(113, 18);
            this.Frame1.Name = "Frame1";
            this.Frame1.Padding = new System.Windows.Forms.Padding(0);
            this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame1.Size = new System.Drawing.Size(185, 41);
            this.Frame1.TabIndex = 0;
            this.Frame1.TabStop = false;
            this.Frame1.Text = "Convert";
            // 
            // _optTimeToArc
            // 
            this._optTimeToArc.BackColor = System.Drawing.SystemColors.Window;
            this._optTimeToArc.Cursor = System.Windows.Forms.Cursors.Default;
            this._optTimeToArc.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optTimeToArc.ForeColor = System.Drawing.SystemColors.ControlText;
            this._optTimeToArc.Location = new System.Drawing.Point(96, 16);
            this._optTimeToArc.Name = "_optTimeToArc";
            this._optTimeToArc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optTimeToArc.Size = new System.Drawing.Size(81, 17);
            this._optTimeToArc.TabIndex = 2;
            this._optTimeToArc.TabStop = true;
            this._optTimeToArc.Text = "Time to Arc";
            this._optTimeToArc.UseVisualStyleBackColor = false;
            this._optTimeToArc.CheckedChanged += new System.EventHandler(this.optTimeToArc_CheckedChanged);
            // 
            // _optArcToTime
            // 
            this._optArcToTime.BackColor = System.Drawing.SystemColors.Window;
            this._optArcToTime.Checked = true;
            this._optArcToTime.Cursor = System.Windows.Forms.Cursors.Default;
            this._optArcToTime.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optArcToTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this._optArcToTime.Location = new System.Drawing.Point(8, 16);
            this._optArcToTime.Name = "_optArcToTime";
            this._optArcToTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optArcToTime.Size = new System.Drawing.Size(81, 17);
            this._optArcToTime.TabIndex = 1;
            this._optArcToTime.TabStop = true;
            this._optArcToTime.Text = "Arc to Time";
            this._optArcToTime.UseVisualStyleBackColor = false;
            this._optArcToTime.CheckedChanged += new System.EventHandler(this.optArcToTime_CheckedChanged);
            // 
            // lblZT
            // 
            this.lblZT.BackColor = System.Drawing.SystemColors.Window;
            this.lblZT.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblZT.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblZT.Location = new System.Drawing.Point(147, 98);
            this.lblZT.Name = "lblZT";
            this.lblZT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblZT.Size = new System.Drawing.Size(90, 17);
            this.lblZT.TabIndex = 21;
            this.lblZT.Text = "ZT (hh:mm:ss)";
            this.lblZT.Visible = false;
            // 
            // lblLMT
            // 
            this.lblLMT.BackColor = System.Drawing.SystemColors.Window;
            this.lblLMT.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLMT.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLMT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLMT.Location = new System.Drawing.Point(147, 98);
            this.lblLMT.Name = "lblLMT";
            this.lblLMT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLMT.Size = new System.Drawing.Size(90, 17);
            this.lblLMT.TabIndex = 20;
            this.lblLMT.Text = "LMT (hh:mm:ss)";
            this.lblLMT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLoMin
            // 
            this.lblLoMin.BackColor = System.Drawing.SystemColors.Window;
            this.lblLoMin.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLoMin.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoMin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLoMin.Location = new System.Drawing.Point(249, 71);
            this.lblLoMin.Name = "lblLoMin";
            this.lblLoMin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLoMin.Size = new System.Drawing.Size(9, 17);
            this.lblLoMin.TabIndex = 18;
            this.lblLoMin.Text = "\'";
            // 
            // lblLoDeg
            // 
            this.lblLoDeg.BackColor = System.Drawing.SystemColors.Window;
            this.lblLoDeg.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLoDeg.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoDeg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLoDeg.Location = new System.Drawing.Point(207, 71);
            this.lblLoDeg.Name = "lblLoDeg";
            this.lblLoDeg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLoDeg.Size = new System.Drawing.Size(9, 17);
            this.lblLoDeg.TabIndex = 16;
            this.lblLoDeg.Text = "°";
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.Window;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(144, 71);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(26, 22);
            this.Label1.TabIndex = 13;
            this.Label1.Text = "Lo";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeg
            // 
            this.lblDeg.BackColor = System.Drawing.SystemColors.Window;
            this.lblDeg.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDeg.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDeg.Location = new System.Drawing.Point(231, 66);
            this.lblDeg.Name = "lblDeg";
            this.lblDeg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDeg.Size = new System.Drawing.Size(9, 17);
            this.lblDeg.TabIndex = 8;
            this.lblDeg.Text = "°";
            // 
            // lblMin
            // 
            this.lblMin.BackColor = System.Drawing.SystemColors.Window;
            this.lblMin.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMin.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMin.Location = new System.Drawing.Point(279, 68);
            this.lblMin.Name = "lblMin";
            this.lblMin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMin.Size = new System.Drawing.Size(9, 17);
            this.lblMin.TabIndex = 7;
            this.lblMin.Text = "\'";
            // 
            // txtArcTime
            // 
            this.txtArcTime.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArcTime.Location = new System.Drawing.Point(103, 121);
            this.txtArcTime.Multiline = true;
            this.txtArcTime.Name = "txtArcTime";
            this.txtArcTime.ReadOnly = true;
            this.txtArcTime.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtArcTime.Size = new System.Drawing.Size(226, 45);
            this.txtArcTime.TabIndex = 25;
            this.txtArcTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLMTZT
            // 
            this.txtLMTZT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLMTZT.Location = new System.Drawing.Point(109, 122);
            this.txtLMTZT.Multiline = true;
            this.txtLMTZT.Name = "txtLMTZT";
            this.txtLMTZT.ReadOnly = true;
            this.txtLMTZT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLMTZT.Size = new System.Drawing.Size(226, 45);
            this.txtLMTZT.TabIndex = 26;
            this.txtLMTZT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _ExitBtn
            // 
            this._ExitBtn.BackColor = System.Drawing.Color.Red;
            this._ExitBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this._ExitBtn.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ExitBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this._ExitBtn.Location = new System.Drawing.Point(394, 241);
            this._ExitBtn.Name = "_ExitBtn";
            this._ExitBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._ExitBtn.Size = new System.Drawing.Size(60, 25);
            this._ExitBtn.TabIndex = 27;
            this._ExitBtn.Text = "Exit";
            this._ExitBtn.UseVisualStyleBackColor = false;
            this._ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // _ClearBtn
            // 
            this._ClearBtn.BackColor = System.Drawing.SystemColors.Control;
            this._ClearBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this._ClearBtn.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ClearBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this._ClearBtn.Location = new System.Drawing.Point(4, 241);
            this._ClearBtn.Name = "_ClearBtn";
            this._ClearBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._ClearBtn.Size = new System.Drawing.Size(92, 25);
            this._ClearBtn.TabIndex = 28;
            this._ClearBtn.Text = "Clear";
            this._ClearBtn.UseVisualStyleBackColor = false;
            this._ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::CelestialTools.My.Resources.Resources.ABC_white;
            this.PictureBox1.Location = new System.Drawing.Point(76, 271);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(316, 50);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 102;
            this.PictureBox1.TabStop = false;
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.ArcTime);
            this.TabControl1.Controls.Add(this.LMTZT);
            this.TabControl1.Location = new System.Drawing.Point(0, 5);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(463, 231);
            this.TabControl1.TabIndex = 103;
            // 
            // ArcTime
            // 
            this.ArcTime.Controls.Add(this.DTTime);
            this.ArcTime.Controls.Add(this.txtArcTime);
            this.ArcTime.Controls.Add(this.lblDeg);
            this.ArcTime.Controls.Add(this.lblArc);
            this.ArcTime.Controls.Add(this.Frame1);
            this.ArcTime.Controls.Add(this._txtMin);
            this.ArcTime.Controls.Add(this._txtDeg);
            this.ArcTime.Controls.Add(this.lblMin);
            this.ArcTime.Controls.Add(this.lblTime);
            this.ArcTime.Location = new System.Drawing.Point(4, 22);
            this.ArcTime.Name = "ArcTime";
            this.ArcTime.Padding = new System.Windows.Forms.Padding(3);
            this.ArcTime.Size = new System.Drawing.Size(455, 205);
            this.ArcTime.TabIndex = 0;
            this.ArcTime.Text = "Arc-Time";
            this.ArcTime.UseVisualStyleBackColor = true;
            // 
            // DTTime
            // 
            this.DTTime.CustomFormat = "HH:mm:ss";
            this.DTTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTTime.Location = new System.Drawing.Point(198, 91);
            this.DTTime.Name = "DTTime";
            this.DTTime.ShowUpDown = true;
            this.DTTime.Size = new System.Drawing.Size(79, 21);
            this.DTTime.TabIndex = 26;
            this.DTTime.Visible = false;
            // 
            // LMTZT
            // 
            this.LMTZT.Controls.Add(this.DTLMT);
            this.LMTZT.Controls.Add(this.txtLMTZT);
            this.LMTZT.Controls.Add(this.Label1);
            this.LMTZT.Controls.Add(this.lblLoDeg);
            this.LMTZT.Controls.Add(this.lblLoMin);
            this.LMTZT.Controls.Add(this.lblLMT);
            this.LMTZT.Controls.Add(this.lblZT);
            this.LMTZT.Controls.Add(this._txtLoMin);
            this.LMTZT.Controls.Add(this.Frame2);
            this.LMTZT.Controls.Add(this.cboLo);
            this.LMTZT.Controls.Add(this._txtLoDeg);
            this.LMTZT.Location = new System.Drawing.Point(4, 22);
            this.LMTZT.Name = "LMTZT";
            this.LMTZT.Padding = new System.Windows.Forms.Padding(3);
            this.LMTZT.Size = new System.Drawing.Size(455, 205);
            this.LMTZT.TabIndex = 1;
            this.LMTZT.Text = "LMT-ZT";
            this.LMTZT.UseVisualStyleBackColor = true;
            // 
            // DTLMT
            // 
            this.DTLMT.CustomFormat = "HH:mm:ss";
            this.DTLMT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTLMT.Location = new System.Drawing.Point(241, 96);
            this.DTLMT.Name = "DTLMT";
            this.DTLMT.ShowUpDown = true;
            this.DTLMT.Size = new System.Drawing.Size(72, 21);
            this.DTLMT.TabIndex = 27;
            // 
            // FormArcTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(466, 323);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this._ClearBtn);
            this.Controls.Add(this._ExitBtn);
            this.Controls.Add(this._cmdPrint);
            this.Controls.Add(this._cmdConvert);
            this.Controls.Add(this.TabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(285, 99);
            this.MaximizeBox = false;
            this.Name = "FormArcTime";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arc-Time, LMT-ZT Conversion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormArcTime_FormClosed);
            this.Load += new System.EventHandler(this.FormArcTime_Load);
            this.Frame2.ResumeLayout(false);
            this.Frame1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.ArcTime.ResumeLayout(false);
            this.ArcTime.PerformLayout();
            this.LMTZT.ResumeLayout(false);
            this.LMTZT.PerformLayout();
            this.ResumeLayout(false);

        }

        internal TextBox txtArcTime;
        internal TextBox txtLMTZT;
        private Button _ExitBtn;

        public Button ExitBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ExitBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ExitBtn != null)
                {
                    _ExitBtn.Click -= ExitBtn_Click;
                }

                _ExitBtn = value;
                if (_ExitBtn != null)
                {
                    _ExitBtn.Click += ExitBtn_Click;
                }
            }
        }

        private Button _ClearBtn;

        public Button ClearBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ClearBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ClearBtn != null)
                {
                    _ClearBtn.Click -= ClearBtn_Click;
                }

                _ClearBtn = value;
                if (_ClearBtn != null)
                {
                    _ClearBtn.Click += ClearBtn_Click;
                }
            }
        }

        internal PictureBox PictureBox1;
        internal TabControl TabControl1;
        internal TabPage ArcTime;
        internal TabPage LMTZT;
        internal DateTimePicker DTTime;
        internal DateTimePicker DTLMT;
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}