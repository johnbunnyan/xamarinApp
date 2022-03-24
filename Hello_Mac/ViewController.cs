using System;

using AppKit;
using Foundation;

namespace Hello_Mac
{
    public partial class ViewController : NSViewController
    {
        private int numberOfTimesClicked = 0;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Set the initial value for the label
            ClickedLabel.StringValue = "버튼을 눌러보세요!😘";
        }


        partial void ClickedButton(Foundation.NSObject sender)
        {
            stringRandom();
            // Update counter and label
            ClickedLabel.StringValue = string.Format("The button has been clicked {0} time{1}.", ++numberOfTimesClicked, (numberOfTimesClicked < 2) ? "" : "s");
        }

      public void stringRandom()
        {
            string[] text = { "멋지십니다", "행운이네요", "정신 차리고 밖에 나가세요", "잘하고 계십니다", "누구세요?", "날이 좋네요" };
                Random random = new Random();

            int index = random.Next(text.Length);
            int index2 = random.Next(text.Length);
            int index3 = random.Next(text.Length);
            int index4 = random.Next(text.Length);
            int index5 = random.Next(text.Length);
            int index6 = random.Next(text.Length);
            int index7 = random.Next(text.Length);

        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }
    }
}
