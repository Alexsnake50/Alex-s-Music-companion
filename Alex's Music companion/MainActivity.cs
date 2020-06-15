using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;
using System;

namespace Alex_s_Music_companion
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            String Mode = "Chord";
            String Type = "triad";
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Android.Widget.Button button1 = FindViewById<Android.Widget.Button>(Resource.Id.button1);
            Android.Widget.Button button2 = FindViewById<Android.Widget.Button>(Resource.Id.button2);
            Android.Widget.Button button3 = FindViewById<Android.Widget.Button>(Resource.Id.button3);
            Android.Widget.Button button4 = FindViewById<Android.Widget.Button>(Resource.Id.button4);
            Android.Widget.Button button5 = FindViewById<Android.Widget.Button>(Resource.Id.button5);
            Android.Widget.Button button6 = FindViewById<Android.Widget.Button>(Resource.Id.button6);
            Android.Widget.Button button7 = FindViewById<Android.Widget.Button>(Resource.Id.button7);
            Android.Widget.Button button8 = FindViewById<Android.Widget.Button>(Resource.Id.button8);
            Android.Widget.Button button9 = FindViewById<Android.Widget.Button>(Resource.Id.button9);
            Android.Widget.Button button10 = FindViewById<Android.Widget.Button>(Resource.Id.button10);
            Android.Widget.Button button11 = FindViewById<Android.Widget.Button>(Resource.Id.button11);
            Android.Widget.Button button12 = FindViewById<Android.Widget.Button>(Resource.Id.button12);
            Android.Widget.Button button13 = FindViewById<Android.Widget.Button>(Resource.Id.button13);
            Android.Widget.Button button14 = FindViewById<Android.Widget.Button>(Resource.Id.button14);
            Android.Widget.Button button15 = FindViewById<Android.Widget.Button>(Resource.Id.button15);
            Android.Widget.Button button16 = FindViewById<Android.Widget.Button>(Resource.Id.button16);
            Android.Widget.Button button17 = FindViewById<Android.Widget.Button>(Resource.Id.button17);
            Android.Widget.Button button18 = FindViewById<Android.Widget.Button>(Resource.Id.button18);
            Android.Widget.Button button19 = FindViewById<Android.Widget.Button>(Resource.Id.button19);



            button1.Click += (o, e) => OnClick(Resource.Id.button1, Mode, Type);
            button2.Click += (o, e) => OnClick(Resource.Id.button2, Mode, Type);
            button3.Click += (o, e) => OnClick(Resource.Id.button3, Mode, Type);
            button4.Click += (o, e) => OnClick(Resource.Id.button4, Mode, Type);
            button5.Click += (o, e) => OnClick(Resource.Id.button5, Mode, Type);
            button6.Click += (o, e) => OnClick(Resource.Id.button6, Mode, Type);
            button7.Click += (o, e) => OnClick(Resource.Id.button7, Mode, Type);
            button8.Click += (o, e) => OnClick(Resource.Id.button8, Mode, Type);
            button9.Click += (o, e) => OnClick(Resource.Id.button9, Mode, Type);
            button10.Click += (o, e) => OnClick(Resource.Id.button10, Mode, Type);
            button11.Click += (o, e) => OnClick(Resource.Id.button11, Mode, Type);
            button12.Click += (o, e) => OnClick(Resource.Id.button12, Mode, Type);
            button13.Click += (o, e) => Mode = "Chord";
            button14.Click += (o, e) => Mode = "MajorScale";
            button15.Click += (o, e) => Type = "triad";
            button16.Click += (o, e) => Type = "7";
            button17.Click += (o, e) => Type = "sus2";
            button18.Click += (o, e) => Type = "sus4";
            button19.Click += (o, e) => Type = "minor";

           

        }
        public void OnClick(int id, string mode,string Type)
        {
            switch (mode)
            {
                case "MajorScale":
                    FindViewById<TextView>(Resource.Id.textView1).Text = Scale.MajorScale(FindViewById<Android.Widget.Button>(id).Text);
                    break;
                case "Chord":
                    FindViewById<TextView>(Resource.Id.textView1).Text = Scale.Chord(FindViewById<Android.Widget.Button>(id).Text, Type);
                    break;
            }                 
        }
    }
    public class Scale
    {
        public static void Main()
        {
           
        }
        readonly static String[] Notes = { "C", "C#/Db", "D", "D#/Eb", "E", "F", "F#/Gb", "G", "G#/Ab", "A", "A#/Bb", "B", "C", "C#/Db", "D", "D#/Eb", "E", "F", "F#/Gb", "G", "G#/Ab", "A", "A#/Bb", "B", "C", "C#/Db", "D", "D#/Eb", "E", "F", "F#/Gb", "G", "G#/Ab", "A", "A#/Bb", "B", "C", "C#/Db", "D", "D#/Eb", "E", "F", "F#/Gb", "G", "G#/Ab", "A", "A#/Bb", "B" };
        public static string MajorScale(string Note)
        {
            int Index_Of_Note_input = Array.IndexOf(Notes, Note);
            string Your_Scale = "null";
            for (int i = Index_Of_Note_input; i < Index_Of_Note_input + 12; i++)
            {
                if (i == Index_Of_Note_input)
                {
                    Your_Scale = Notes[i];
                }
                if (i != Index_Of_Note_input && i != Index_Of_Note_input + 5)
                {
                    Your_Scale += " - " + Notes[i + 1];
                    i += 1;
                }
                else if (i == Index_Of_Note_input + 5)
                {
                    Your_Scale += " - " + Notes[i];
                }
            }
            return Your_Scale;
        }
        public static string Chord(string Note, string ChordType)
        {
            string mode = ChordType;
            int Index_Of_Note_input = Array.IndexOf(Notes, Note);
            String Your_Chord = "null";
            switch (mode)
            {
                case "triad":
                    Your_Chord = Notes[Index_Of_Note_input] + " - " + Notes[Index_Of_Note_input + 4] + " - " + Notes[Index_Of_Note_input + 7];
                    break;
                case "minor":
                    Your_Chord = Notes[Index_Of_Note_input] + " - " + Notes[Index_Of_Note_input + 3] + " - " + Notes[Index_Of_Note_input + 7];
                    break;
                case "sus2":
                    Your_Chord = Notes[Index_Of_Note_input] + " - " + Notes[Index_Of_Note_input + 2] + " - " + Notes[Index_Of_Note_input + 7];
                    break;
                case "sus4":
                    Your_Chord = Notes[Index_Of_Note_input] + " - " + Notes[Index_Of_Note_input + 5] + " - " + Notes[Index_Of_Note_input + 7];
                    break;
                case "7":
                    Your_Chord = Notes[Index_Of_Note_input] + " - " + Notes[Index_Of_Note_input + 4] + " - " + Notes[Index_Of_Note_input + 7] + " - " + Notes[Index_Of_Note_input + 10];
                    break;
            }
            return Your_Chord;
        }
        public static void ChrodRenderer(object sender, SKPaintSurfaceEventArgs e)
        {
            SKSurface surface = e.Surface;
            SKCanvas canvas = surface.Canvas;

            canvas.Clear(SKColors.CornflowerBlue);
        }
    }
}