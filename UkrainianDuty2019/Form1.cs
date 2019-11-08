using Leaf.xNet;
using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace UkrainianDuty2019
{
    public partial class App : Form
    {
        int priceProduct_;
        int fullPrice_;
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
            priceProduct_ = Int32.Parse(priceProductUsd.Text);

            // получим курс евро к доллару
            var httpRequest_ = new HttpRequest();

            httpRequest_.AddHeader(HttpHeader.Accept, "application/json, text/javascript, */*; q=0.01");
            httpRequest_.AddHeader(HttpHeader.ContentType, "application/x-www-form-urlencoded; charset=UTF-8");
            httpRequest_.AddXmlHttpRequestHeader();
            httpRequest_.UserAgentRandomize();

            // получим ответ от ПриватБанка
            string content_ = httpRequest_.Get("https://api.exchangeratesapi.io/latest?base=USD").ToString();

            // получили курс
            string kurs_ = regex_("EUR\":(.*),\"MYR", content_, 1);

            // переведем доллары в евро
            double kurs_in_double = priceProduct_ * ConvertToDouble(kurs_);
            priceProduct_ = (int)kurs_in_double;

            // TODO: сделано для физ.лица
            // добавить для юридического

            // 20% НДС
            // 10% Пошлина
            if (priceProduct_ >= 100)
            {
                fullPrice_ = ((priceProduct_ / 100) * 10) + ((priceProduct_ / 100) * 20) + priceProduct_;
            }
            else
            {
                fullPrice_ = priceProduct_;
            }

            in_eur.Text = fullPrice_.ToString();

            // конвертация из евро в гривны
            var httpRequest = new HttpRequest();

            httpRequest.AddHeader(HttpHeader.Accept, "application/json, text/javascript, */*; q=0.01");
            httpRequest.AddHeader(HttpHeader.ContentType, "application/x-www-form-urlencoded; charset=UTF-8");
            httpRequest.AddXmlHttpRequestHeader();
            httpRequest.UserAgentRandomize();

            // получим текущую дату минус один день
            DateTime date = DateTime.Now.AddDays(-1);
            string date_ = Convert.ToDateTime(date).ToString("yyyyMMdd");

            // получим ответ от ПриватБанка
            string content = httpRequest.Get("https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?valcode=EUR&date=" + date_ + "").ToString();

            // получим курс евро относительно гривны
            string kurs = regex_("<rate>(.*)</rate>", content, 1);

            double in_uah_ = fullPrice_ * ConvertToDouble(kurs);
            in_uah.Text = in_uah_.ToString();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            priceProduct_ = Int32.Parse(priceProduct.Text);
            // 20% НДС
            // 10% Пошлина
            if (priceProduct_ >= 100)
            {
                fullPrice_ = ((priceProduct_ / 100) * 10) + ((priceProduct_ / 100) * 20) + priceProduct_;
            } else
            {
                fullPrice_ = priceProduct_;
            }

            in_eur.Text = fullPrice_.ToString();

            // конвертация из евро в гривны
            var httpRequest = new HttpRequest();

            httpRequest.AddHeader(HttpHeader.Accept, "application/json, text/javascript, */*; q=0.01");
            httpRequest.AddHeader(HttpHeader.ContentType, "application/x-www-form-urlencoded; charset=UTF-8");
            httpRequest.AddXmlHttpRequestHeader();
            httpRequest.UserAgentRandomize();

            // получим текущую дату минус один день
            DateTime date = DateTime.Now.AddDays(-1);
            string date_ = Convert.ToDateTime(date).ToString("yyyyMMdd");

            // получим ответ от ПриватБанка
            string content = httpRequest.Get("https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?valcode=EUR&date=" + date_ + "").ToString();

            // получим курс евро относительно гривны
            string kurs = regex_("<rate>(.*)</rate>", content, 1);

            double in_uah_ = fullPrice_ * ConvertToDouble(kurs);
            in_uah.Text =  in_uah_.ToString();
        }
    }
}
