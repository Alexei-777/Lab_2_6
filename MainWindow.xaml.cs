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

//Разработать в WPF приложении класс WeatherControl, моделирующий погодную сводку
//– температуру (целое число в диапазоне от -50 до +50),
//направление ветра(строка), скорость ветра(целое число),
//наличие осадков(возможные значения: 0 – солнечно, 1 – облачно, 2 – дождь, 3 – снег.
//Можно использовать целочисленное значение, либо создать перечисление enum).
//Свойство «температура» преобразовать в свойство зависимости.

namespace Lab_2_6
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
    }
}
