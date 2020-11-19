using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Web;
using System.Threading;
using System.Diagnostics;
using System.Collections;
using System.Net;

namespace Google_v1
{
    public partial class NaverForm : Form
    {
        IWebDriver driver;
        // 옵션 관련된 객체
        ChromeDriverService service;
        ChromeOptions option;
        ArrayList arrNaver = new ArrayList();
        ArrayList arrNaverImage = new ArrayList();
        string Direct = null;
        string Picture = null;
        int Count;

        public NaverForm(string z)
        {
            InitializeComponent();
            CenterToParent(); // 부모 중앙 위치

            Debug.WriteLine("검색어:" + z);
            
            // 인스턴스화 + IWebDriver -> 추가할 옵션들 설정
            service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            option = new ChromeOptions();
            option.AddArguments("headless");

            string Encode = HttpUtility.UrlEncode(z, Encoding.UTF8);

            using (driver = new ChromeDriver(service, option))
            //using (driver = new ChromeDriver(service))
            {
                try
                {
                    driver.Url = "https://search.shopping.naver.com/search/all?query=" + Encode;
                    Debug.WriteLine("네이버 driver.Url: " + driver.Url);
                    driver.FindElement(By.XPath("//*[@id=\"__next\"]/div/div[2]/div[2]/div[4]/div[1]/div[1]/ul/li[2]")).Click();
                    Thread.Sleep(1000);

                    List<IWebElement> elements = driver.FindElement(By.ClassName("basicList_mall_area__lIA7R")).FindElements(By.TagName("li")).ToList();
                    Debug.WriteLine("elements.Count: " + elements.Count);

                    Count = 0;
                    foreach (IWebElement x in elements)
                    {
                        if (Direct == null) { Direct = x.FindElement(By.TagName("a")).GetAttribute("href").ToString(); }

                        if (Count == 0) { label4.Text = x.Text; }
                        else if (Count == 1) { label5.Text = x.Text; }
                        else if (Count == 2) { label6.Text = x.Text; }
                        else if (Count == 3) { label7.Text = x.Text; }
                        else if (Count == 4) { label8.Text = x.Text; }
                        Count++;
                    }
                    //
                    label1.Text = driver.FindElement(By.ClassName("basicList_title__3P9Q7")).Text;
                    label2.Text = driver.FindElement(By.ClassName("basicList_price__2r23_")).Text;
                    label3.Text = driver.FindElement(By.ClassName("basicList_etc_box__1Jzg6")).FindElement(By.TagName("a")).Text;
                    //label3.Text = label3.Text.Insert(9, " ⊙참여한 인원수: ");
                    //
                    lblDetail.Text = driver.FindElement(By.ClassName("basicList_detail_box__3ta3h")).Text;
                    //
                    IWebElement e = driver.FindElement(By.ClassName("basicList_item__2XT81")).FindElement(By.TagName("img"));
                    Picture = e.GetAttribute("src").ToString();

                    var request = WebRequest.Create(Picture);
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    pictureBox1.Image = Bitmap.FromStream(stream);
                }
                catch // 다를 경우
                {
                    driver.Url = "https://search.shopping.naver.com/search/all?query=" + Encode;
                    Debug.WriteLine("네이버 driver.Url: " + driver.Url);
                    driver.FindElement(By.XPath("//*[@id=\"__next\"]/div/div[2]/div/div[3]/div[1]/div[1]/ul/li[2]")).Click();
                    Thread.Sleep(1000);

                    List<IWebElement> elements = driver.FindElement(By.ClassName("basicList_mall_area__lIA7R")).FindElements(By.TagName("li")).ToList();
                    Debug.WriteLine("elements.Count: " + elements.Count);

                    Count = 0;
                    foreach (IWebElement x in elements)
                    {
                        if (Direct == null) { Direct = x.FindElement(By.TagName("a")).GetAttribute("href").ToString(); }

                        if (Count == 0) { label4.Text = x.Text; }
                        else if (Count == 1) { label5.Text = x.Text; }
                        else if (Count == 2) { label6.Text = x.Text; }
                        else if (Count == 3) { label7.Text = x.Text; }
                        else if (Count == 4) { label8.Text = x.Text; }
                        Count++;
                    }
                    //
                    label1.Text = driver.FindElement(By.ClassName("basicList_title__3P9Q7")).Text;
                    label2.Text = driver.FindElement(By.ClassName("basicList_price__2r23_")).Text;
                    label3.Text = driver.FindElement(By.ClassName("basicList_etc_box__1Jzg6")).FindElement(By.TagName("a")).Text;
                    //label3.Text = label3.Text.Insert(9, " ⊙참여한 인원수: ");
                    //
                    lblDetail.Text = driver.FindElement(By.ClassName("basicList_detail_box__3ta3h")).Text;
                    //
                    IWebElement e = driver.FindElement(By.ClassName("basicList_item__2XT81")).FindElement(By.TagName("img"));
                    Picture = e.GetAttribute("src").ToString();

                    var request = WebRequest.Create(Picture);
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                        pictureBox1.Image = Bitmap.FromStream(stream);
                }

                driver.Close();
            }
        }

        private async void btnWindow_Click(object sender, EventArgs e)
        {
            using (driver = new ChromeDriver(service))
            {
                try
                {
                    driver.Url = Direct;
                    if (driver.Manage().Window == null) driver.Close();
                    await Task.Delay(60000);
                }
                catch { }
            }
        }
    }
}
