using Better_xNet;
using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace UkrainianDuty2019
{
    public partial class App : Form
    {
        double priceProduct_;
        double fullPrice_;
        double shipUsd;
        double weight_;
        public App()
        {
            InitializeComponent();
        }

        private string regex_ (string regex, string input, int group)
        {
            Regex r1 = new Regex(regex);

            Match match = r1.Match(input);
            if (match.Success)
            {
               return match.Groups[group].Value;
            }
            else
            {
                return "err";
            }
        }
        private double ConvertToDouble(string s)
        {
            char systemSeparator = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator[0];
            double result = 0;
            try
            {
                if (s != null)
                    if (!s.Contains(","))
                        result = double.Parse(s, CultureInfo.InvariantCulture);
                    else
                        result = Convert.ToDouble(s.Replace(".", systemSeparator.ToString()).Replace(",", systemSeparator.ToString()));
            }
            catch (Exception e)
            {
                try
                {
                    result = Convert.ToDouble(s);
                }
                catch
                {
                    try
                    {
                        result = Convert.ToDouble(s.Replace(",", ";").Replace(".", ",").Replace(";", "."));
                    }
                    catch
                    {
                        throw new Exception("Wrong string-to-double format");
                    }
                }
            }
            return result;
        }
        private void CalculateShipment_Click(object sender, EventArgs e)
        {
            using (HttpRequest req = new HttpRequest())
            {
                req.UserAgent = Http.PaleMoonUserAgent();
                req.KeepAlive = true; // Sometimes useful

                req.AddParam("shiping_from", "0x8591001d600938f811de4ea3c35b6113"); // china
                req.AddParam("shiping_to", "0x9846d9604f41b62c4f69775367967a92"); // ukraine
                req.AddParam("shiping_weight", weight.Text);
                req.AddParam("shiping_dimensions_x", "1");
                req.AddParam("shiping_dimensions_y", "1");
                req.AddParam("shiping_dimensions_z", "1");
                req.AddParam("lang_code", "en");

                string source = req.Send(HttpMethod.POST, new Uri("https://mymeest.com/wp-content/themes/mymist/ajax_shiping_calculator.php")).ToString();

                // train
                string train = regex_("rates-ship active\">(.*) USD<\\/div", source, 1);
                ship_usd.Text = train;

                using (var httpRequest = new HttpRequest())
                {
                    httpRequest.ConnectTimeout = 15000;

                    // получим текущую дату минус один день
                    DateTime date = DateTime.Now.AddDays(-1);
                    string date_ = Convert.ToDateTime(date).ToString("yyyyMMdd");

                    // получим ответ от bank.gov.ua
                    string content = httpRequest.Send(HttpMethod.GET, new Uri("https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?valcode=USD&date=" + date_ + "")).ToString();
                    // получим курс зеленых относительно гривны
                    string kurs = regex_("<rate>(.*)</rate>", content, 1);

                    double ship_uah_ = Convert.ToDouble(train) * ConvertToDouble(kurs);
                    ship_uah.Text = ship_uah_.ToString();
                }

                // air
                string air = regex_("rates-air active\">(.*) USD<\\/div", source, 1);
                ship_air.Text = air;
                using (var httpRequest = new HttpRequest())
                {
                    httpRequest.ConnectTimeout = 15000;

                    // получим текущую дату минус один день
                    DateTime date = DateTime.Now.AddDays(-1);
                    string date_ = Convert.ToDateTime(date).ToString("yyyyMMdd");

                    // получим ответ от bank.gov.ua
                    string content = httpRequest.Send(HttpMethod.GET, new Uri("https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?valcode=USD&date=" + date_ + "")).ToString();
                    // получим курс зеленых относительно гривны
                    string kurs = regex_("<rate>(.*)</rate>", content, 1);

                    double ship_uah_air_ = Convert.ToDouble(air) * ConvertToDouble(kurs);
                    ship_uah_air.Text = ship_uah_air_.ToString();
                }
            }

        }
        private void CalculateUsd_Click(object sender, EventArgs e)
        {
            priceProduct_ = Convert.ToDouble(ConvertToDouble(priceProductUsd.Text));

            // получим курс евро
            var httpRequest_ = new HttpRequest();
            httpRequest_.ConnectTimeout = 15000;
            string content_ = httpRequest_.Send(HttpMethod.GET, new Uri("https://api.exchangeratesapi.io/latest?base=USD")).ToString();

            // получили курс
            string kurs_ = regex_("EUR\":(.*),\"MYR", content_, 1);

            // суммарно в евро
            double kurs_in_double = priceProduct_ * ConvertToDouble(kurs_);
            priceProduct_ = (double)kurs_in_double;

            // 20% НДС
            // 10% Пошлина
            // Alipay 3%
            // Торговый эквайринг 2%
            if (priceProduct_ >= 100)
            {
                fullPrice_ = ((priceProduct_ / 100) * 10) + ((priceProduct_ / 100) * 20) + priceProduct_ + ((priceProduct_ / 100) * 3) + ((priceProduct_ / 100) * 2);
            }
            else
            {
                fullPrice_ = priceProduct_ + ((priceProduct_ / 100) * 3) + ((priceProduct_ / 100) * 2);
            }

            in_eur.Text = fullPrice_.ToString();

            // конвертация из евро в гривны
            var httpRequest = new HttpRequest();
            httpRequest.ConnectTimeout = 15000;

            // получим текущую дату минус один день
            DateTime date = DateTime.Now.AddDays(-1);
            string date_ = Convert.ToDateTime(date).ToString("yyyyMMdd");

            // получим ответ от bank.gov.ua
            string content = httpRequest.Send(HttpMethod.GET, new Uri("https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?valcode=EUR&date=" + date_ + "")).ToString();
            // получим курс евро относительно гривны
            string kurs = regex_("<rate>(.*)</rate>", content, 1);

            double in_uah_ = fullPrice_ * ConvertToDouble(kurs);
            in_uah.Text = in_uah_.ToString();
        }
        private void CalculateCNY_Click(object sender, EventArgs e)
        {
            priceProduct_ = Convert.ToDouble(ConvertToDouble(priceProductCNY.Text));

            // получим курс евро к доллару
            var httpRequest_ = new HttpRequest();
            httpRequest_.ConnectTimeout = 15000;

            // получим ответ от api.exchangeratesapi.io
            string content_ = httpRequest_.Send(HttpMethod.GET, new Uri("https://api.exchangeratesapi.io/latest?base=CNY")).ToString();

            // получили курс
            string kurs_ = regex_("EUR\":(.*),\"MYR", content_, 1);

            // переведем доллары в евро
            double kurs_in_double = priceProduct_ * ConvertToDouble(kurs_);
            priceProduct_ = (double)kurs_in_double;

            // 20% НДС
            // 10% Пошлина
            // Alipay 3%
            // Торговый эквайринг 2%
            if (priceProduct_ >= 100)
            {
                fullPrice_ = ((priceProduct_ / 100) * 10) + ((priceProduct_ / 100) * 20) + priceProduct_ + ((priceProduct_ / 100) * 3) + ((priceProduct_ / 100) * 2);
            }
            else
            {
                fullPrice_ = priceProduct_ + ((priceProduct_ / 100) * 3) + ((priceProduct_ / 100) * 2);
            }

            in_eur.Text = fullPrice_.ToString();

            // конвертация из евро в гривны
            var httpRequest = new HttpRequest();
            httpRequest.ConnectTimeout = 15000;

            // получим текущую дату минус один день
            DateTime date = DateTime.Now.AddDays(-1);
            string date_ = Convert.ToDateTime(date).ToString("yyyyMMdd");

            // получим ответ от bank.gov.ua
            string content = httpRequest.Send(HttpMethod.GET, new Uri("https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?valcode=EUR&date=" + date_ + "")).ToString();
            // получим курс евро относительно гривны
            string kurs = regex_("<rate>(.*)</rate>", content, 1);

            double in_uah_ = fullPrice_ * ConvertToDouble(kurs);
            in_uah.Text = in_uah_.ToString();
        }
        private void Calculate_Click(object sender, EventArgs e)
        {
            priceProduct_ = Convert.ToDouble(ConvertToDouble(priceProduct.Text));
            // 20% НДС
            // 10% Пошлина
            // Alipay 3%
            // Торговый эквайринг 2%
            if (priceProduct_ >= 100)
            {
                fullPrice_ = ((priceProduct_ / 100) * 10) + ((priceProduct_ / 100) * 20) + priceProduct_ + ((priceProduct_ / 100) * 3) + ((priceProduct_ / 100) * 2);
            }
            else
            {
                fullPrice_ = priceProduct_ + ((priceProduct_ / 100) * 3) + ((priceProduct_ / 100) * 2);
            }

            in_eur.Text = fullPrice_.ToString();

            // конвертация из евро в гривны
            var httpRequest = new HttpRequest();
            httpRequest.ConnectTimeout = 15000;

            // получим текущую дату минус один день
            DateTime date = DateTime.Now.AddDays(-1);
            string date_ = Convert.ToDateTime(date).ToString("yyyyMMdd");

            // получим ответ от bank.gov.ua
            string content = httpRequest.Send(HttpMethod.GET, new Uri("https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?valcode=EUR&date=" + date_ + "")).ToString();
            // получим курс евро относительно гривны
            string kurs = regex_("<rate>(.*)</rate>", content, 1);

            double in_uah_ = fullPrice_ * ConvertToDouble(kurs);
            in_uah.Text = in_uah_.ToString();
        }
        private void Recalc_Click(object sender, EventArgs e)
        {
            priceProduct_ = Convert.ToDouble(ConvertToDouble(in_eur.Text));
            // 20% НДС
            // 10% Пошлина
            // Alipay 3%
            // Торговый эквайринг 2%
            if (priceProduct_ >= 100)
            {
                fullPrice_ = ((priceProduct_ / 100) * 10) + ((priceProduct_ / 100) * 20) + priceProduct_ + ((priceProduct_ / 100) * 3) + ((priceProduct_ / 100) * 2);
            }
            else
            {
                fullPrice_ = priceProduct_ + ((priceProduct_ / 100) * 3) + ((priceProduct_ / 100) * 2);
            }

            in_eur.Text = fullPrice_.ToString();

            // конвертация из евро в гривны
            var httpRequest = new HttpRequest();
            httpRequest.ConnectTimeout = 15000;

            // получим текущую дату минус один день
            DateTime date = DateTime.Now.AddDays(-1);
            string date_ = Convert.ToDateTime(date).ToString("yyyyMMdd");

            // получим ответ от bank.gov.ua
            string content = httpRequest.Send(HttpMethod.GET, new Uri("https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?valcode=EUR&date=" + date_ + "")).ToString();
            // получим курс евро относительно гривны
            string kurs = regex_("<rate>(.*)</rate>", content, 1);

            double in_uah_ = fullPrice_ * ConvertToDouble(kurs);
            in_uah.Text = in_uah_.ToString();
        }
    }
}
