using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Text;
using Jace;

namespace Calculator
{
    [Activity(Label = "Calculator", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            // Button button = FindViewById<Button>(Resource.Id.MyButton);

            EditText txtDisplay = FindViewById<EditText>(Resource.Id.txtDisplay);

            Button btn1 = FindViewById<Button>(Resource.Id.btn1);
            Button btn2 = FindViewById<Button>(Resource.Id.btn2);
            Button btn3 = FindViewById<Button>(Resource.Id.btn3);
            Button btn4 = FindViewById<Button>(Resource.Id.btn4);
            Button btn5 = FindViewById<Button>(Resource.Id.btn5);
            Button btn6 = FindViewById<Button>(Resource.Id.btn6);
            Button btn7 = FindViewById<Button>(Resource.Id.btn7);
            Button btn8 = FindViewById<Button>(Resource.Id.btn8);
            Button btn9 = FindViewById<Button>(Resource.Id.btn9);
            Button btnZero = FindViewById<Button>(Resource.Id.btnZero);
            Button btnClear = FindViewById<Button>(Resource.Id.btnC);
            Button btnPlus = FindViewById<Button>(Resource.Id.btnPlus);
            Button btnMinus = FindViewById<Button>(Resource.Id.btnMinus);
            Button btnTimes = FindViewById<Button>(Resource.Id.btnTimes);
            Button btnDivide = FindViewById<Button>(Resource.Id.btnDivide);
            Button btnDel = FindViewById<Button>(Resource.Id.btnBack);
            Button btnEqual = FindViewById<Button>(Resource.Id.btnEqual);
            Button btnDot = FindViewById<Button>(Resource.Id.btnFloat);

            StringBuilder strText = new StringBuilder();

            btn1.Click += delegate { txtDisplay.Text = OperationMethod.removeZero(strText, btn1.Text); };
            btn2.Click += delegate { txtDisplay.Text = OperationMethod.removeZero(strText, btn2.Text); };
            btn3.Click += delegate { txtDisplay.Text = OperationMethod.removeZero(strText, btn3.Text); };
            btn4.Click += delegate { txtDisplay.Text = OperationMethod.removeZero(strText, btn4.Text); };
            btn5.Click += delegate { txtDisplay.Text = OperationMethod.removeZero(strText, btn5.Text); };
            btn6.Click += delegate { txtDisplay.Text = OperationMethod.removeZero(strText, btn6.Text); };
            btn7.Click += delegate { txtDisplay.Text = OperationMethod.removeZero(strText, btn7.Text); };
            btn8.Click += delegate { txtDisplay.Text = OperationMethod.removeZero(strText, btn8.Text); };
            btn9.Click += delegate { txtDisplay.Text = OperationMethod.removeZero(strText, btn9.Text); };

            btnZero.Click += delegate { txtDisplay.Text = OperationMethod.zeroRule(strText, btnZero.Text); };
            btnPlus.Click += delegate { txtDisplay.Text = OperationMethod.operationDisplay(strText, btnPlus.Text, txtDisplay.Text); };
            btnMinus.Click += delegate { txtDisplay.Text = OperationMethod.operationDisplay(strText, btnMinus.Text, txtDisplay.Text); };
            btnTimes.Click += delegate { txtDisplay.Text = OperationMethod.operationDisplay(strText, "*", txtDisplay.Text); };
            btnDivide.Click += delegate { txtDisplay.Text = OperationMethod.operationDisplay(strText, btnDivide.Text, txtDisplay.Text); };

            btnDel.Click += delegate { txtDisplay.Text = OperationMethod.delRule(strText); };
            btnClear.Click += delegate { strText.Clear();  txtDisplay.Text = ""; };
            btnEqual.Click += delegate { txtDisplay.Text = OperationMethod.answer(strText); strText.Clear(); };
            btnDot.Click += delegate { txtDisplay.Text = OperationMethod.dotRule(strText, btnDot.Text); };
        }
    }
}

