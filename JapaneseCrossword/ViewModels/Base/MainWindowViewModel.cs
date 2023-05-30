using JapaneseCrossword.Infrastructure.Commands.Base;
using JapaneseCrossword.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;
using System.Windows.Input;
using JapaneseCrossword.Infrastructure.Commands;
using JapaneseCrossword.Views.Window;
using JapaneseCrossword;
using System.Windows.Controls;

namespace JapaneseCrossword.ViewModels.Base
{
    internal class MainWindowViewModel : ViewModel
    {
        public static MainWindow Win;
        public static Rules Rul_name;

        #region заглавие
        private string _title = "Японский кроссворд";


        public string Title
        {
            get { return _title; }
            set => Set(ref _title, value);
        }
        #endregion

        #region команды
        public ICommand CloseApplicationCommand { get; }

        private bool CanCloseApplicationCommandExecute(object p) => true;

        private void OnCloseApplicationCommandExecute(object p) 
        {
            Application.Current.Shutdown();
        }

        public ICommand Play { get; }

        private bool CanPlay (object p) => true;

        private void OnPlay(object p)
        {
            if (Win == null)
            {
                Win = new MainWindow();
                Win.Show();
                Menu menu = new Menu();
                menu.Hide();                   
            }
            else
            {
                Win .Activate();
            }
        }

        public ICommand Rul { get; }

        private bool CanRul(object p) => true;

        private void OnRul(object p)
        {
            Rul_name = new Rules();
            Rul_name.Show();   
        }

        public ICommand But2 { get; }

        private bool CanBut2(object p) => true;

        private void OnBut2(object p) 
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).button2.Background =  Brushes.Black;
                }
            }
        }
        public ICommand But6 { get; }

        private bool CanBut6(object p) => true;

        private void OnBut6(object p)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).button6.Background = Brushes.Black;
                }
            }
        }
        public ICommand But7 { get; }

        private bool CanBut7(object p) => true;

        private void OnBut7(object p)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).button7.Background = Brushes.Black;
                }
            }
        }
        public ICommand But8 { get; }

        private bool CanBut8(object p) => true;

        private void OnBut8(object p)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).button8.Background = Brushes.Black;
                }
            }
        }
        public ICommand But9 { get; }

        private bool CanBut9(object p) => true;

        private void OnBut9(object p)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).button9.Background = Brushes.Black;
                }
            }
        }
        public ICommand But10 { get; }

        private bool CanBut10(object p) => true;

        private void OnBut10(object p)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).button10.Background = Brushes.Black;
                }
            }
        }
        public ICommand But11 { get; }

        private bool CanBut11(object p) => true;

        private void OnBut11(object p)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).button11.Background = Brushes.Black;
                }
            }
        }
        public ICommand But13 { get; }

        private bool CanBut13(object p) => true;

        private void OnBut13(object p)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).button13.Background = Brushes.Black;
                }
            }
        }
        public ICommand But14 { get; }

        private bool CanBut14(object p) => true;

        private void OnBut14(object p)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).button14.Background = Brushes.Black;
                }
            }
        }
        public ICommand But16 { get; }

        private bool CanBut16(object p) => true;

        private void OnBut16(object p)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).button16.Background = Brushes.Black;
                }
            }
        }
        public ICommand But17 { get; }

        private bool CanBut17(object p) => true;

        private void OnBut17(object p)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).button17.Background = Brushes.Black;
                }
            }
        }
        public ICommand But28 { get; }

        private bool CanBut28(object p) => true;

        private void OnBut28(object p)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).button28.Background = Brushes.Black;
                }
            }
        }
        public ICommand But0 { get; }

        private bool CanBut0 (object p) => true;

        private void OnBut0(object p)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).button0.Background = Brushes.Black;
                }
            }
        }
        public ICommand But1 { get; }

        private bool CanBut1(object p) => true;

        private void OnBut1(object p)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).button1.Background = Brushes.Black;
                }
            }
        }
        public ICommand But3 { get; }

        private bool CanBut3(object p) => true;

        private void OnBut3(object p)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).button3.Background = Brushes.Black;
                }
            }
        }
        public ICommand But4 { get; }

        private bool CanBut4(object p) => true;

        private void OnBut4(object p)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).button4.Background = Brushes.Black;
                }
            }
        }
        public ICommand But5 { get; }

        private bool CanBut5(object p) => true;

        private void OnBut5(object p)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).button5.Background = Brushes.Black;
                }
            }
        }
        public ICommand But12 { get; }

        private bool CanBut12(object p) => true;

        private void OnBut12(object p)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).button12.Background = Brushes.Black;
                }
            }
        }
        public ICommand But15 { get; }

        private bool CanBut15(object p) => true;

        private void OnBut15(object p)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).button15.Background = Brushes.Black;
                }
            }
        }
        public ICommand But18 { get; }

        private bool CanBut18(object p) => true;

        private void OnBut18(object p)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).button18.Background = Brushes.Black;
                }
            }
        }
        public ICommand But19 { get; }

        private bool CanBut19(object p) => true;

        private void OnBut19(object p)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).button19.Background = Brushes.Black;
                }
            }
        }
        public ICommand But20 { get; }

        private bool CanBut20(object p) => true;

        private void OnBut20(object p)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).button20.Background = Brushes.Black;
                }
            }
        }
        public ICommand But25 { get; }

        private bool CanBut25(object p) => true;

        private void OnBut25(object p)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).button25.Background = Brushes.Black;
                }
            }
        }
        public ICommand But26 { get; }

        private bool CanBut26(object p) => true;

        private void OnBut26(object p)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).button26.Background = Brushes.Black;
                }
            }
        }
        public ICommand But27 { get; }

        private bool CanBut27(object p) => true;

        private void OnBut27(object p)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).button27.Background = Brushes.Black;
                }
            }
        }
        public ICommand Check { get; }

        private bool CanCheck(object p) => true;

        private void OnCheck(object p)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    if ((window as MainWindow).button1.Background != Brushes.Black && (window as MainWindow).button26.Background != Brushes.Black && (window as MainWindow).button0.Background != Brushes.Black && (window as MainWindow).button12.Background != Brushes.Black && (window as MainWindow).button3.Background != Brushes.Black && (window as MainWindow).button4.Background != Brushes.Black && (window as MainWindow).button5.Background != Brushes.Black && (window as MainWindow).button15.Background != Brushes.Black && (window as MainWindow).button20.Background != Brushes.Black && (window as MainWindow).button25.Background != Brushes.Black && (window as MainWindow).button18.Background != Brushes.Black && (window as MainWindow).button27.Background != Brushes.Black && (window as MainWindow).button19.Background != Brushes.Black && (window as MainWindow).button14.Background == Brushes.Black && (window as MainWindow).button13.Background == Brushes.Black && (window as MainWindow).button8.Background == Brushes.Black && (window as MainWindow).button9.Background == Brushes.Black && (window as MainWindow).button10.Background == Brushes.Black && (window as MainWindow).button11.Background == Brushes.Black && (window as MainWindow).button6.Background == Brushes.Black && (window as MainWindow).button7.Background == Brushes.Black && (window as MainWindow).button16.Background == Brushes.Black && (window as MainWindow).button17.Background == Brushes.Black && (window as MainWindow).button2.Background == Brushes.Black)
                    {
                        MessageBox.Show("Все верно! Так держать");
                    }
                    else
                    {
                        MessageBox.Show("Как-то не так(");
                    }
                }
            }
        }
        public ICommand Clear { get; }
        private bool CanClear (object p) => true;

        private void OnClear(object p)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).button0.Background = Brushes.White;
                    (window as MainWindow).button1.Background = Brushes.White;
                    (window as MainWindow).button2.Background = Brushes.White;
                    (window as MainWindow).button3.Background = Brushes.White;
                    (window as MainWindow).button4.Background = Brushes.White;
                    (window as MainWindow).button5.Background = Brushes.White;
                    (window as MainWindow).button6.Background = Brushes.White;
                    (window as MainWindow).button7.Background = Brushes.White;
                    (window as MainWindow).button8.Background = Brushes.White;
                    (window as MainWindow).button9.Background = Brushes.White;
                    (window as MainWindow).button10.Background = Brushes.White;
                    (window as MainWindow).button11.Background = Brushes.White;
                    (window as MainWindow).button12.Background = Brushes.White;
                    (window as MainWindow).button13.Background = Brushes.White;
                    (window as MainWindow).button14.Background = Brushes.White;
                    (window as MainWindow).button15.Background = Brushes.White;
                    (window as MainWindow).button16.Background = Brushes.White;
                    (window as MainWindow).button17.Background = Brushes.White;
                    (window as MainWindow).button18.Background = Brushes.White;
                    (window as MainWindow).button19.Background = Brushes.White;
                    (window as MainWindow).button20.Background = Brushes.White;
                    (window as MainWindow).button25.Background = Brushes.White;
                    (window as MainWindow).button26.Background = Brushes.White;
                    (window as MainWindow).button27.Background = Brushes.White;
                    (window as MainWindow).button28.Background = Brushes.White;
                }
            }
        }
        



        #endregion
        public MainWindowViewModel()
        {
            CloseApplicationCommand = new LamdaComands(OnCloseApplicationCommandExecute, CanCloseApplicationCommandExecute);
            Play = new LamdaComands(OnPlay, CanPlay);
            Rul = new LamdaComands(OnRul, CanRul);
            But2 = new LamdaComands(OnBut2, CanBut2);
            But6 = new LamdaComands(OnBut6, CanBut6);
            But7 = new LamdaComands(OnBut7, CanBut7);
            But8 = new LamdaComands(OnBut8, CanBut8);
            But9 = new LamdaComands(OnBut9, CanBut9);
            But10 = new LamdaComands(OnBut10, CanBut10);
            But11 = new LamdaComands(OnBut11, CanBut11);
            But13 = new LamdaComands(OnBut13, CanBut13);
            But14 = new LamdaComands(OnBut14, CanBut14);
            But16 = new LamdaComands(OnBut16, CanBut16);
            But17 = new LamdaComands(OnBut17, CanBut17);
            But28 = new LamdaComands(OnBut28, CanBut28);
            But0 = new LamdaComands(OnBut0, CanBut0);
            But1 = new LamdaComands(OnBut1, CanBut1);
            But3 = new LamdaComands(OnBut3, CanBut3);
            But4 = new LamdaComands(OnBut4, CanBut4);
            But5 = new LamdaComands(OnBut5, CanBut5);
            But12 = new LamdaComands(OnBut12, CanBut12);
            But15 = new LamdaComands(OnBut15, CanBut15);
            But18 = new LamdaComands(OnBut18, CanBut18);
            But19 = new LamdaComands(OnBut19, CanBut19);
            But20 = new LamdaComands(OnBut20, CanBut20);
            But25 = new LamdaComands(OnBut25, CanBut25);
            But26 = new LamdaComands(OnBut26, CanBut26);
            But27 = new LamdaComands(OnBut27, CanBut27);
            Check = new LamdaComands(OnCheck, CanCheck);
            Clear = new LamdaComands(OnClear, CanClear);
        }

        
    }
}
