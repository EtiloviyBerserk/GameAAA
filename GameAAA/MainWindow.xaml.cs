using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace GameAAA
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
        }

        public int sumClick = 0; //Счётчик нажатий

        //Кнопочки-поля,где будут крестики и нолики

        private void btn1_Click(object sender, RoutedEventArgs e) //объясню всё на одной кнопке. Остальные кнопки точно такие же)
        {
            if (btn1.Content.ToString() == "1") //По умолчанию я поставил свойству "Content" каждой кнопки её порядковый номер, чтоб при проверке пустых кнопок-полей значения не совпадали 
            {
                btn1.Content = CrossRing().ToString();
                btn1.FontSize = 80;
                sumClick++; //При каждом нажатии кнопки счётчик нажатий увеличивается на 1

                //Проверяем, есть ли по трём направлениям выиграшная комбинация 

                if (AllCheck()) //Если метод передаёт значение "true", значит Ура,победа!
                {
                    MessageBox.Show("Ура! Победа!");
                }
                else if (AllCheck() == false && sumClick == 9) //Иначе если метод передаёт "false"(выигрышных комбинаций нет) и счётчик нажатий равен 9(макс. кол-во нажатий за игру), то ничья

                {
                    MessageBox.Show("Увы( Всего лишь ничья");
                }

            }
        }
        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (btn2.Content.ToString() == "2")
            {
                btn2.Content = CrossRing();
                btn2.FontSize = 80;
                sumClick++;

                if (AllCheck())
                {
                    MessageBox.Show("Ура! Победа!");
                }

                else if (AllCheck() == false && sumClick == 9)
                {
                    MessageBox.Show("Увы( Всего лишь ничья");
                }
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (btn3.Content.ToString() == "3")
            {
                btn3.Content = CrossRing();
                btn3.FontSize = 80;
                sumClick++;

                if (AllCheck())
                {
                    MessageBox.Show("Ура! Победа!");
                }

                else if (AllCheck() == false && sumClick == 9)
                {
                    MessageBox.Show("Увы( Всего лишь ничья");
                }
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (btn4.Content.ToString() == "4")
            {
                btn4.Content = CrossRing();
                btn4.FontSize = 80;
                sumClick++;

                if (AllCheck())
                {
                    MessageBox.Show("Ура! Победа!");
                }
                else if (AllCheck() == false && sumClick == 9)
                {
                    MessageBox.Show("Увы( Всего лишь ничья");
                }
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (btn5.Content.ToString() == "5")
            {
                btn5.Content = CrossRing();
                btn5.FontSize = 80;
                sumClick++;

                if (AllCheck())
                {
                    MessageBox.Show("Ура! Победа!");
                }
                else if (AllCheck() == false && sumClick == 9)
                {
                    MessageBox.Show("Увы( Всего лишь ничья");
                }
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (btn6.Content.ToString() == "6")
            {
                btn6.Content = CrossRing();
                btn6.FontSize = 80;
                sumClick++;

                if (AllCheck())
                {
                    MessageBox.Show("Ура! Победа!");
                }
                else if (AllCheck() == false && sumClick == 9)
                {
                    MessageBox.Show("Увы( Всего лишь ничья");
                }
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (btn7.Content.ToString() == "7")
            {
                btn7.Content = CrossRing();
                btn7.FontSize = 80;
                sumClick++;

                if (AllCheck())
                {
                    MessageBox.Show("Ура! Победа!");
                }
                else if (AllCheck() == false && sumClick == 9)
                {
                    MessageBox.Show("Увы( Всего лишь ничья");
                }
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (btn8.Content.ToString() == "8")
            {
                btn8.Content = CrossRing();
                btn8.FontSize = 80;
                sumClick++;

                if (AllCheck())
                {
                    MessageBox.Show("Ура! Победа!");
                }
                else if (AllCheck() == false && sumClick == 9)
                {
                    MessageBox.Show("Увы( Всего лишь ничья");
                }
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (btn9.Content.ToString() == "9")
            {
                btn9.Content = CrossRing();
                btn9.FontSize = 80;
                sumClick++;

                if (AllCheck())
                {
                    MessageBox.Show("Ура! Победа!");
                }
                else if (AllCheck() == false && sumClick == 9)
                {
                    MessageBox.Show("Увы( Всего лишь ничья");
                }
            }
        }

        private void btnRestart_Click(object sender, RoutedEventArgs e) //Перезапуск игры 
        {
            btn1.Content = "1";
            btn1.FontSize = 0.5;
            btn2.Content = "2";
            btn2.FontSize = 0.5;
            btn3.Content = "3";
            btn3.FontSize = 0.5;
            btn4.Content = "4";
            btn4.FontSize = 0.5;
            btn5.Content = "5";
            btn5.FontSize = 0.5;
            btn6.Content = "6";
            btn6.FontSize = 0.5;
            btn7.Content = "7";
            btn7.FontSize = 0.5;
            btn8.Content = "8";
            btn8.FontSize = 0.5;
            btn9.Content = "9";
            btn9.FontSize = 0.5;

            sumClick = 0;
        }

        public string CrossRing() //Метод, который в зависимости от чётности нажатий кнопки возращает крестик или нолик 
        {
            if (sumClick % 2 != 0)
            {
                return "○";
            }
            else
            {
                return "🞩"; //Первый всегда крестик если вдруг что,хехе
            }
        }


        //Проверка крестиков и ноликов по разным направлениям

        public bool HorizontalCheck()
        {
            if (btn1.Content == btn2.Content && btn2.Content == btn3.Content ||
                btn4.Content == btn5.Content && btn5.Content == btn6.Content ||
                btn7.Content == btn8.Content && btn8.Content == btn9.Content)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool VerticalCheck()
        {
            if (btn1.Content == btn4.Content && btn4.Content == btn7.Content ||
                btn2.Content == btn5.Content && btn5.Content == btn8.Content ||
                btn3.Content == btn6.Content && btn6.Content == btn9.Content)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DiagonalCheck()
        {
            if (btn1.Content == btn5.Content && btn5.Content == btn9.Content ||
                btn3.Content == btn5.Content && btn5.Content == btn7.Content)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //Проверка всех методов в одном методе, шоб не париться

        public bool AllCheck()
        {
            if (HorizontalCheck() || VerticalCheck() || DiagonalCheck())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
