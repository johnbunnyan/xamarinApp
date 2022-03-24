using System;

using AppKit;
using Foundation;

namespace Hello_Mac
{
    public partial class ViewController : NSViewController
    {
        int randomTiming = randomTime();
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
            string message = stringRandom();
            // Update counter and label
            System.Diagnostics.Debug.WriteLine(randomTiming,"랜덤");
            System.Diagnostics.Debug.WriteLine(numberOfTimesClicked);
            if (randomTiming == numberOfTimesClicked)
            {
                ClickedLabel.StringValue = string.Format("The button has been clicked {0} time{1}.", message, (numberOfTimesClicked < 2) ? "🫠" : "😆");
                
            }
            else
            {
                ClickedLabel.StringValue = string.Format("The button has been clicked {0} time{1}.", ++numberOfTimesClicked, (numberOfTimesClicked < 2) ? "" : "s");
            }
        }

      public string stringRandom()
        {
            string[] text = { "멋지십니다", "행운이네요", "정신 차리고 밖에 나가세요", "잘하고 계십니다", "누구세요?", "날이 좋네요" };
                Random random = new Random();

            int index = random.Next(text.Length);
            return text[index];

        }

        public static int randomTime()
        { 
            Random random = new Random();

            int randomNum = random.Next(50);
            return randomNum;

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
