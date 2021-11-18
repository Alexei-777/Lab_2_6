using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

//Разработать в WPF приложении класс WeatherControl, моделирующий погодную сводку
//– температуру (целое число в диапазоне от -50 до +50),
//направление ветра(строка), скорость ветра(целое число),
//наличие осадков(возможные значения: 0 – солнечно, 1 – облачно, 2 – дождь, 3 – снег.
//Можно использовать целочисленное значение, либо создать перечисление enum).
//Свойство «температура» преобразовать в свойство зависимости. 

namespace Lab_2_6
{
    class WeatherControl : DependencyObject
    {
        public string WindDirection { get; set; }

        public int WindSpeed { get; set; }

        public enum Railfall
        {
            Sunny = 0,
            Cloudy = 1,
            Rainy = 2,
            Snowy = 3
        }

        public int Temperature
        {
            get => (int)GetValue(TemperatureProperty);
            set => SetValue(TemperatureProperty, value);
        }

        public static readonly DependencyProperty TemperatureProperty;

        static WeatherControl()
        {
            TemperatureProperty = DependencyProperty.Register(
                nameof(Temperature),
                typeof(int),
                typeof(WeatherControl),
                new FrameworkPropertyMetadata(
                    0,
                    FrameworkPropertyMetadataOptions.AffectsMeasure |
                    FrameworkPropertyMetadataOptions.AffectsRender,
                    null,
                    new CoerceValueCallback(CoerceTemperature)),
                new ValidateValueCallback(ValidateTemperature));
        }

        public static object CoerceTemperature(DependencyObject d, object baseValue)
        {
            int v = (int)baseValue;
            if (v >= -50 && v <= 50)
            {
                return v;
            }
            else
            {
                return 0;
            }
        }

        public static bool ValidateTemperature(object value)
        {
            int v = (int)value;
            if (v >= -50 && v <= 50)
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