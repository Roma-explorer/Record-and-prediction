using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Record_and_prediction
{
    public class Prediction
    {

        public static int Host_Winter(List<int> data, double alpha=0.4, double beta=0.3, double gamma=0.2)
        {
            List<double> predictions = new List<double>();
            List<double> errors = new List<double>();
            List<double> first_seasons = first_season(data);
            var second_year_data = data.GetRange(12, 12);
            double first_second_y_level = second_year_data[0] / first_seasons[0];
            double twelve_level = data[11] / first_seasons[11];
            double first_second_y_trend = first_second_y_level - twelve_level;
            double first_second_y_season = gamma*data[12]/ first_second_y_level + (1 - gamma) * first_seasons[0];
            double first_prediction = (first_second_y_level + first_second_y_season) * first_seasons[0];
            predictions.Add(first_prediction);
            var further_levels = new List<double>();
            var further_trends = new List<double>();
            var all_seasons = new List<double>();
            further_levels.Add(first_second_y_level);
            further_trends.Add(first_second_y_trend);
            all_seasons.AddRange(first_seasons);
            all_seasons.Add(first_second_y_season);
            for(int i = 13; i<data.Count; i++)
            {
                double level = alpha * (data[i] / all_seasons[i - 12]) + (1 - alpha) * (further_levels[i - 13] + further_trends[i - 13]);
                further_levels.Add(level);
                double trend = beta * (level - further_levels[i - 13]) + (1 - beta) * further_trends[i - 13];
                further_trends.Add(trend);
                double season = gamma * data[i] / level + (1 - gamma) * all_seasons[i - 12];
                all_seasons.Add(season);
                double prediction = (level + trend) * all_seasons[i - 12];
                predictions.Add(prediction);
                if (i + 1 != data.Count)
                    errors.Add(Math.Abs(data[i + 1] - prediction) / data[i + 1]);
            }
            return (int)predictions.Last();
        }

        public double Error_HW(List<double> errors)
        {
            return errors.Average();
        }

        public static List<double> first_season(List<int> data)
        {
            List<double> first_seasons = new List<double>();
            for (int i = 0; i < 12; i++)
                first_seasons.Add(data[i] / data.GetRange(0, 12).Average());
            return first_seasons;
        }
    }

}
