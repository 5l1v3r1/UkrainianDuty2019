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

        private void CalculateUsd_Click(object sender, EventArgs e)
        {
            priceProduct_ = Convert.ToDouble(ConvertToDouble(priceProductUsd.Text));

            // получим курс евро к доллару
            var httpRequest_ = new HttpRequest();
            httpRequest_.ConnectTimeout = 15000;

            // получим ответ от api.exchangeratesapi.io
            string content_ = httpRequest_.Send(HttpMethod.GET, new Uri("https://api.exchangeratesapi.io/latest?base=USD")).ToString();

            // получили курс
            string kurs_ = regex_("EUR\":(.*),\"MYR", content_, 1);

            // переведем доллары в евро
            double kurs_in_double = priceProduct_ * ConvertToDouble(kurs_);
            priceProduct_ = (double)kurs_in_double;

            // TODO: сделано для физ.лица
            // добавить для юридического

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
