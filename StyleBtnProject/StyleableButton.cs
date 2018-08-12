using System.Drawing;
using System.Windows.Forms;

namespace StyleBtnProject
{
    public partial class StyleableButton : Button
    {
        // StylePattern 
        public enum StylePatternEnum
        {
            none,
            pattern1,
            pattern2,
            pattern3,
            pattern4,
        }
        public void SetMyStyle()
        {
            switch (StylePattern)
            {
                case StylePatternEnum.none:
                    this.UseVisualStyleBackColor = true;
                    this.Font = new System.Drawing.Font("メイリオ", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
                    this.Size = new System.Drawing.Size(75, 23);
                    break;
                case StylePatternEnum.pattern1:
                    this.BackColor = Color.Red;
                    this.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
                    this.Size = new System.Drawing.Size(86, 32);
                    break;
                case StylePatternEnum.pattern2:
                    this.BackColor = Color.Yellow;
                    this.Font = new System.Drawing.Font("メイリオ", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
                    this.Size = new System.Drawing.Size(90, 36);
                    break;
                case StylePatternEnum.pattern3:
                    this.BackColor = Color.Blue;
                    this.Font = new System.Drawing.Font("メイリオ", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
                    this.Size = new System.Drawing.Size(100, 45);
                    break;
                case StylePatternEnum.pattern4:
                    this.BackColor = Color.White;
                    this.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
                    this.Size = new System.Drawing.Size(110, 55);
                    break;
                default:
                    break;
            }
        }
        private StylePatternEnum _stylePattern;
        public StylePatternEnum StylePattern
        {
            get
            {
                return _stylePattern;
            }
            set
            {
                _stylePattern = value;
                SetMyStyle();
            }
        }

        public StyleableButton()
        {
            InitializeComponent();
        }
    }
}
