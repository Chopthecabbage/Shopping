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
using System.Web; // 참조에서 직접 추가로 하세요.
using System.Threading;
using System.Diagnostics;
using System.Collections;
using System.Net;
/* 솔루션 패키지
크롬 버전 -> 86
Selenium.WebDriver
Selenium.WebDriver.ChromeDriver
Selenium.Chrome.WebDriver
*/
namespace Google_v1
{
    public partial class MainForm : Form
    {
        IWebDriver driver;
        // 옵션 관련된 객체
        ChromeDriverService service;
        ChromeOptions option;
        //
        ArrayList arrAuction = new ArrayList();
        ArrayList arrAuctionImage = new ArrayList();
        ArrayList arrGmarket = new ArrayList();
        ArrayList arrGmarketImage = new ArrayList();
        ArrayList arrTmon = new ArrayList();
        ArrayList arrTmonImage = new ArrayList();
        ArrayList arrWemakeprice = new ArrayList();
        ArrayList arrWemakepriceImage = new ArrayList();
        // 잡다한
        int PW;
        bool Hided;
        int Count;
        //
        NaverForm n;

        public MainForm()
        {
            InitializeComponent();
            CenterToScreen();
            // 인스턴스화 + IWebDriver -> 추가할 옵션들 설정
            service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            option = new ChromeOptions();
            option.AddArguments("headless");

            btnSearch.Click += btnSearch_Click;
            //
            PW = panel2.Width;
            Hided = false;
        }

        // 네이버 -> 가격비교
        private void btnDialog_Click(object sender, EventArgs e)
        {
            if (tbxSearch.Text != "")
            {
                n = new NaverForm(tbxSearch.Text);
                n.Show();
            }
            else
                AutoClosingMessageBox.Show("검색어가 없습니다.", "Error", 2000);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbxSearch.Text = ""; // tbxSearch.Text = null;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbxSearch.Text.Length < 1) return;

            using (driver = new ChromeDriver(service, option)) // IWebDriver 통해 웹을 열거나 닫거나 등등...
            //using (driver = new ChromeDriver(service))
            {
                // 초기화
                lbxAuction.Items.Clear(); // 옥션
                arrAuction.Clear();
                arrAuctionImage.Clear();
                lbxGmarket.Items.Clear(); // G마켓
                arrGmarket.Clear();
                arrGmarketImage.Clear();
                lbxTmon.Items.Clear(); // 티몬
                arrTmon.Clear();
                arrTmonImage.Clear();
                lbxWemakeprice.Items.Clear(); // 위메프
                arrWemakeprice.Clear();
                arrWemakepriceImage.Clear();
                Count = 0;

                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                }
                if (pictureBox2.Image != null)
                {
                    pictureBox2.Image.Dispose();
                    pictureBox2.Image = null;
                }
                if (pictureBox3.Image != null)
                {
                    pictureBox3.Image.Dispose();
                    pictureBox3.Image = null;
                }

                string Encode = HttpUtility.UrlEncode(tbxSearch.Text, Encoding.UTF8); // 인코딩 안하면 검색 결과가 원하는대로 안나올 수 있다.

                // 옥션 통합
                try
                {
                    if (rbtnRanking.Checked)
                    {
                        string Url = "http://browse.auction.co.kr/search?keyword=" + Encode;
                        driver.Navigate().GoToUrl(Url);
                        Debug.WriteLine("옥션 Url: " + Url);

                        List<IWebElement> elements = driver.FindElement(By.XPath("//*[@id=\"section--inner_content_body_container\"]")).FindElements(By.ClassName("section--itemcard_info_major")).ToList();
                        Debug.WriteLine("elements.Count: " + elements.Count);

                        foreach (IWebElement x in elements)
                        {
                            lbxAuction.Items.Add(x.Text);
                            arrAuction.Add(x.FindElement(By.TagName("a")).GetAttribute("href"));
                        }
                    }
                    else if (rbtnLowPrice.Checked)
                    {
                        string Tag = "&s=4";
                        string Url = "http://browse.auction.co.kr/search?keyword=" + Encode + Tag;
                        driver.Navigate().GoToUrl(Url);
                        Debug.WriteLine("옥션 Url: " + driver.Url);

                        List<IWebElement> elements = driver.FindElement(By.XPath("//*[@id=\"section--inner_content_body_container\"]")).FindElements(By.ClassName("section--itemcard_info_major")).ToList();
                        Debug.WriteLine("elements.Count: " + elements.Count);

                        foreach (IWebElement x in elements)
                        {
                            lbxAuction.Items.Add(x.Text);
                            arrAuction.Add(x.FindElement(By.TagName("a")).GetAttribute("href"));
                        }
                    }
                    else if (rbtnHighPrice.Checked)
                    {
                        string Tag = "&s=5";
                        string Url = "http://browse.auction.co.kr/search?keyword=" + Encode + Tag;
                        driver.Navigate().GoToUrl(Url);
                        Debug.WriteLine("옥션 Url: " + driver.Url);

                        List<IWebElement> elements = driver.FindElement(By.XPath("//*[@id=\"section--inner_content_body_container\"]")).FindElements(By.ClassName("section--itemcard_info_major")).ToList();
                        Debug.WriteLine("elements.Count: " + elements.Count);

                        foreach (IWebElement x in elements)
                        {
                            lbxAuction.Items.Add(x.Text);
                            arrAuction.Add(x.FindElement(By.TagName("a")).GetAttribute("href"));
                        }
                    }
                    else if (rbtnSalesVolume.Checked)
                    {
                        string Tag = "&s=8";
                        string Url = "http://browse.auction.co.kr/search?keyword=" + Encode + Tag;
                        driver.Navigate().GoToUrl(Url);
                        Debug.WriteLine("옥션 Url: " + driver.Url);

                        List<IWebElement> elements = driver.FindElement(By.XPath("//*[@id=\"section--inner_content_body_container\"]")).FindElements(By.ClassName("section--itemcard_info_major")).ToList();
                        Debug.WriteLine("elements.Count: " + elements.Count);

                        foreach (IWebElement x in elements)
                        {
                            lbxAuction.Items.Add(x.Text);
                            arrAuction.Add(x.FindElement(By.TagName("a")).GetAttribute("href"));
                        }
                    }
                    else if (rbtnLatest.Checked)
                    {
                        string Tag = "&s=3";
                        string Url = "http://browse.auction.co.kr/search?keyword=" + Encode + Tag;
                        driver.Navigate().GoToUrl(Url);
                        Debug.WriteLine("옥션 Url: " + driver.Url);

                        List<IWebElement> elements = driver.FindElement(By.XPath("//*[@id=\"section--inner_content_body_container\"]")).FindElements(By.ClassName("section--itemcard_info_major")).ToList();
                        Debug.WriteLine("elements.Count: " + elements.Count);

                        foreach (IWebElement x in elements)
                        {
                            lbxAuction.Items.Add(x.Text);
                            arrAuction.Add(x.FindElement(By.TagName("a")).GetAttribute("href"));
                        }
                    }

                    // 이미지
                    if (rbtnAuction.Checked)
                    {
                        List<IWebElement> imgs = driver.FindElement(By.XPath("//*[@id=\"section--inner_content_body_container\"]")).FindElements(By.TagName("img")).ToList();
                        Debug.WriteLine("imgs.Count: " + imgs.Count);

                        foreach (IWebElement i in imgs)
                        {
                            arrAuctionImage.Add(i.GetAttribute("src"));
                        }

                        for (int i = 0; i < arrAuctionImage.Count; i++)
                        {
                            if (arrAuctionImage[i].ToString().Contains("store")) { }
                            else
                            {
                                Count++; if (Count == 4) { break; };

                                var request = WebRequest.Create(arrAuctionImage[i].ToString());

                                using (var response = request.GetResponse())
                                using (var stream = response.GetResponseStream())
                                {
                                    if (Count == 1) { pictureBox1.Image = Bitmap.FromStream(stream); }
                                    else if (Count == 2) { pictureBox2.Image = Bitmap.FromStream(stream); }
                                    else if (Count == 3) { pictureBox3.Image = Bitmap.FromStream(stream); }
                                }
                            }
                        }

                        lblResultImage.Text = "옥\n션\n\n대\n표\n\n이\n미\n지";
                    }
                }
                catch { }

                // G마켓 통합
                try
                {
                    if (rbtnRanking.Checked)
                    {
                        string Url = "https://browse.gmarket.co.kr/search?keyword=" + Encode;
                        driver.Navigate().GoToUrl(Url);
                        Debug.WriteLine("G마켓 Url: " + Url);


                        List<IWebElement> elements = driver.FindElement(By.Id("region__content-body")).FindElements(By.ClassName("box__information-major")).ToList();
                        Debug.WriteLine("elements.Count: " + elements.Count);

                        foreach (IWebElement x in elements)
                        {
                            lbxGmarket.Items.Add(x.Text);
                            arrGmarket.Add(x.FindElement(By.TagName("a")).GetAttribute("href"));
                        }
                    }
                    else if (rbtnLowPrice.Checked)
                    {
                        string Tag = "&s=1";
                        string Url = "https://browse.gmarket.co.kr/search?keyword=" + Encode + Tag;
                        driver.Navigate().GoToUrl(Url);
                        Debug.WriteLine("G마켓 Url: " + Url);


                        List<IWebElement> elements = driver.FindElement(By.Id("region__content-body")).FindElements(By.ClassName("box__information-major")).ToList();
                        Debug.WriteLine("elements.Count: " + elements.Count);

                        foreach (IWebElement x in elements)
                        {
                            lbxGmarket.Items.Add(x.Text);
                            arrGmarket.Add(x.FindElement(By.TagName("a")).GetAttribute("href"));
                        }
                    }
                    else if (rbtnHighPrice.Checked)
                    {
                        string Tag = "&s=2";
                        string Url = "https://browse.gmarket.co.kr/search?keyword=" + Encode + Tag;
                        driver.Navigate().GoToUrl(Url);
                        Debug.WriteLine("G마켓 Url: " + Url);

                        List<IWebElement> elements = driver.FindElement(By.Id("region__content-body")).FindElements(By.ClassName("box__information-major")).ToList();
                        Debug.WriteLine("elements.Count: " + elements.Count);

                        foreach (IWebElement x in elements)
                        {
                            lbxGmarket.Items.Add(x.Text);
                            arrGmarket.Add(x.FindElement(By.TagName("a")).GetAttribute("href"));
                        }
                    }
                    else if (rbtnSalesVolume.Checked)
                    {
                        string Tag = "&s=8";
                        string Url = "https://browse.gmarket.co.kr/search?keyword=" + Encode + Tag;
                        driver.Navigate().GoToUrl(Url);
                        Debug.WriteLine("G마켓 Url: " + Url);

                        List<IWebElement> elements = driver.FindElement(By.Id("region__content-body")).FindElements(By.ClassName("box__information-major")).ToList();
                        Debug.WriteLine("elements.Count: " + elements.Count);

                        foreach (IWebElement x in elements)
                        {
                            lbxGmarket.Items.Add(x.Text);
                            arrGmarket.Add(x.FindElement(By.TagName("a")).GetAttribute("href"));
                        }
                    }
                    else if (rbtnLatest.Checked)
                    {
                        string Tag = "&s=3";
                        string Url = "https://browse.gmarket.co.kr/search?keyword=" + Encode + Tag;
                        driver.Navigate().GoToUrl(Url);
                        Debug.WriteLine("G마켓 Url: " + Url);

                        List<IWebElement> elements = driver.FindElement(By.Id("region__content-body")).FindElements(By.ClassName("box__information-major")).ToList();
                        Debug.WriteLine("elements.Count: " + elements.Count);

                        foreach (IWebElement x in elements)
                        {
                            lbxGmarket.Items.Add(x.Text);
                            arrGmarket.Add(x.FindElement(By.TagName("a")).GetAttribute("href"));
                        }
                    }

                    // 이미지
                    if (rbtnGmarket.Checked)
                    {
                        List<IWebElement> imgs = driver.FindElement(By.Id("region__content-body")).FindElements(By.TagName("img")).ToList();
                        Debug.WriteLine("imgs.Count: " + imgs.Count);

                        foreach (IWebElement i in imgs)
                        {
                            arrGmarketImage.Add(i.GetAttribute("src"));
                        }

                        for (int i = 0; i < arrGmarketImage.Count; i++)
                        {
                            if (arrGmarketImage[i].ToString().Contains("store")) { }
                            else if (arrGmarketImage[i].ToString().Contains("gdimg"))
                            {
                                Count++; if (Count == 4) { break; };

                                var request = WebRequest.Create(arrGmarketImage[i].ToString());

                                using (var response = request.GetResponse())
                                using (var stream = response.GetResponseStream())
                                {
                                    if (Count == 1) { pictureBox1.Image = Bitmap.FromStream(stream); }
                                    else if (Count == 2) { pictureBox2.Image = Bitmap.FromStream(stream); }
                                    else if (Count == 3) { pictureBox3.Image = Bitmap.FromStream(stream); }
                                }
                            }
                        }

                        lblResultImage.Text = "G\n마\n켓\n\n대\n표\n\n이\n미\n지";
                    }
                }
                catch { }

                // 티몬 통합
                try
                {
                    if (rbtnRanking.Checked)
                    {
                        //검색 -> 클릭
                        //driver.Url = "https://www.11st.co.kr/main";
                        //Debug.WriteLine("11번가: " + driver.Url);
                        //driver.FindElement(By.TagName("input")).Clear();
                        //driver.FindElement(By.TagName("input")).SendKeys(tbxSearch.Text);
                        //driver.FindElement(By.XPath("//*[@id=\"tSearch\"]/form/fieldset/button")).Click();

                        string Url = "https://search.tmon.co.kr/search/?keyword=" + Encode;
                        driver.Navigate().GoToUrl(Url);
                        Debug.WriteLine("티몬 Url: " + Url);
                        Thread.Sleep(1000);

                        List<IWebElement> elements = driver.FindElement(By.ClassName("search_deallist")).FindElements(By.TagName("li")).ToList();
                        Debug.WriteLine("elements.Count: " + elements.Count);
                        
                        foreach (IWebElement x in elements)
                        {
                            lbxTmon.Items.Add(x.Text);
                            arrTmon.Add(x.FindElement(By.TagName("a")).GetAttribute("href"));
                        }
                    }
                    else if (rbtnLowPrice.Checked)
                    {
                        string Tag = "&sortType=LOW_PRICE";
                        driver.Url = "https://search.tmon.co.kr/search/?keyword=" + Encode + Tag;
                        Debug.WriteLine("티몬: " + driver.Url);
                        Thread.Sleep(1000);

                        List<IWebElement> elements = driver.FindElement(By.ClassName("search_deallist")).FindElements(By.TagName("li")).ToList();
                        Debug.WriteLine("elements.Count: " + elements.Count);

                        foreach (IWebElement x in elements)
                        {
                            lbxTmon.Items.Add(x.Text);
                            arrTmon.Add(x.FindElement(By.TagName("a")).GetAttribute("href"));
                        }
                    }
                    else if (rbtnHighPrice.Checked)
                    {
                        string Tag = "&sortType=HIGH_PRICE";
                        driver.Url = "https://search.tmon.co.kr/search/?keyword=" + Encode + Tag;
                        Debug.WriteLine("티몬: " + driver.Url);
                        Thread.Sleep(1000);

                        List<IWebElement> elements = driver.FindElement(By.ClassName("search_deallist")).FindElements(By.TagName("li")).ToList();
                        Debug.WriteLine("elements.Count: " + elements.Count);

                        foreach (IWebElement x in elements)
                        {
                            lbxTmon.Items.Add(x.Text);
                            arrTmon.Add(x.FindElement(By.TagName("a")).GetAttribute("href"));
                        }
                    }
                    else if (rbtnSalesVolume.Checked)
                    {
                        string Tag = "&sortType=BUY_COUNT";
                        driver.Url = "https://search.tmon.co.kr/search/?keyword=" + Encode + Tag;
                        Debug.WriteLine("티몬: " + driver.Url);
                        Thread.Sleep(1000);

                        List<IWebElement> elements = driver.FindElement(By.ClassName("search_deallist")).FindElements(By.TagName("li")).ToList();
                        Debug.WriteLine("elements.Count: " + elements.Count);

                        foreach (IWebElement x in elements)
                        {
                            lbxTmon.Items.Add(x.Text);
                            arrTmon.Add(x.FindElement(By.TagName("a")).GetAttribute("href"));
                        }
                    }
                    else if (rbtnLatest.Checked)
                    {
                        string Tag = "&sortType=RECENT";
                        driver.Url = "https://search.tmon.co.kr/search/?keyword=" + Encode + Tag;
                        Debug.WriteLine("티몬: " + driver.Url);
                        Thread.Sleep(1000);

                        List<IWebElement> elements = driver.FindElement(By.ClassName("search_deallist")).FindElements(By.TagName("li")).ToList();
                        Debug.WriteLine("elements.Count: " + elements.Count);

                        foreach (IWebElement x in elements)
                        {
                            lbxTmon.Items.Add(x.Text);
                            arrTmon.Add(x.FindElement(By.TagName("a")).GetAttribute("href"));
                        }
                    }

                    // 이미지
                    if (rbtnTmon.Checked)
                    {
                        List<IWebElement> imgs = driver.FindElement(By.ClassName("search_deallist")).FindElements(By.TagName("li")).ToList();
                        Debug.WriteLine("imgs.Count: " + imgs.Count);

                        foreach (IWebElement i in imgs)
                        {
                            arrTmonImage.Add(i.FindElement(By.ClassName("thumb")).GetAttribute("data-src"));
                        }

                        for (int i = 0; i < arrTmonImage.Count; i++)
                        {
                            Count++; if (Count == 4) { break; };

                            var request = WebRequest.Create(arrTmonImage[i].ToString());

                            using (var response = request.GetResponse())
                            using (var stream = response.GetResponseStream())
                            {
                                if (Count == 1) { pictureBox1.Image = Bitmap.FromStream(stream); }
                                else if (Count == 2) { pictureBox2.Image = Bitmap.FromStream(stream); }
                                else if (Count == 3) { pictureBox3.Image = Bitmap.FromStream(stream); }
                            }
                        }

                        lblResultImage.Text = "티\n몬\n\n대\n표\n\n이\n미\n지";
                    }
                }
                catch { }
                
                // 위메프 통합
                try
                {
                    if (rbtnRanking.Checked)
                    {
                        //driver.Url = "https://search.shopping.naver.com/search/all?query=" + Encode;
                        //driver.Url = "https://search.wemakeprice.com/search?search_cate=top&keyword=" + Encode;
                        //Debug.WriteLine("위메프: " + driver.Url);

                        //검색 -> 클릭
                        driver.Url = "https://front.wemakeprice.com/main";
                        driver.FindElement(By.Name("search_keyword")).Clear();
                        driver.FindElement(By.Name("search_keyword")).SendKeys(tbxSearch.Text);
                        driver.FindElement(By.XPath("//*[@id=\"_searchKeywordBtn\"]")).Click();
                        Thread.Sleep(1000);

                        List<IWebElement> elements = driver.FindElement(By.ClassName("search_wrap")).FindElements(By.ClassName("list_conts_wrap")).ToList();
                        Debug.WriteLine("elements.Count: " + elements.Count);

                        bool check = true;

                        foreach (IWebElement x in elements)
                        {
                            if (x.Text == "") { }
                            else
                            {
                                if (x.Text.Contains("AD")) { } // 광고 컷
                                else
                                {
                                    for (int i = 0; i < lbxWemakeprice.Items.Count; i++)
                                        if (lbxWemakeprice.Items[i].ToString() == x.Text) { check = false; break; }
                                    if (check)
                                    {
                                        lbxWemakeprice.Items.Add(x.Text);
                                        arrWemakeprice.Add(x.FindElement(By.TagName("a")).GetAttribute("href"));
                                    }
                                }
                            }
                        }
                    }
                    else if (rbtnLowPrice.Checked)
                    {
                        //검색 -> 클릭
                        driver.Url = "https://front.wemakeprice.com/main";
                        driver.FindElement(By.Name("search_keyword")).Clear();
                        driver.FindElement(By.Name("search_keyword")).SendKeys(tbxSearch.Text);
                        driver.FindElement(By.XPath("//*[@id=\"_searchKeywordBtn\"]")).Click();
                        driver.FindElement(By.XPath("//*[@id=\"_contents\"]/div/div[2]/div[1]/div[1]/div/div")).Click();
                        driver.FindElement(By.XPath("//*[@id=\"_contents\"]/div/div[2]/div[1]/div[1]/div/div/ul/li[3]")).Click();
                        Thread.Sleep(1000);

                        List<IWebElement> elements = driver.FindElement(By.ClassName("search_wrap")).FindElements(By.ClassName("list_conts_wrap")).ToList();
                        Debug.WriteLine("elements.Count: " + elements.Count);

                        bool check = true;

                        foreach (IWebElement x in elements)
                        {
                            if (x.Text == "") { }
                            else
                            {
                                if (x.Text.Contains("AD")) { } // 광고 컷
                                else
                                {
                                    for (int i = 0; i < lbxWemakeprice.Items.Count; i++)
                                        if (lbxWemakeprice.Items[i].ToString() == x.Text) { check = false; break; }
                                    if (check)
                                    {
                                        lbxWemakeprice.Items.Add(x.Text);
                                        arrWemakeprice.Add(x.FindElement(By.TagName("a")).GetAttribute("href"));
                                    }
                                }
                            }
                        }
                    }
                    else if (rbtnHighPrice.Checked)
                    {
                        //검색 -> 클릭
                        driver.Url = "https://front.wemakeprice.com/main";
                        driver.FindElement(By.Name("search_keyword")).Clear();
                        driver.FindElement(By.Name("search_keyword")).SendKeys(tbxSearch.Text);
                        driver.FindElement(By.XPath("//*[@id=\"_searchKeywordBtn\"]")).Click();
                        driver.FindElement(By.XPath("//*[@id=\"_contents\"]/div/div[2]/div[1]/div[1]/div/div")).Click();
                        driver.FindElement(By.XPath("//*[@id=\"_contents\"]/div/div[2]/div[1]/div[1]/div/div/ul/li[4]")).Click();
                        Thread.Sleep(1000);

                        List<IWebElement> elements = driver.FindElement(By.ClassName("search_wrap")).FindElements(By.ClassName("list_conts_wrap")).ToList();
                        Debug.WriteLine("elements.Count: " + elements.Count);

                        bool check = true;

                        foreach (IWebElement x in elements)
                        {
                            if (x.Text == "") { }
                            else
                            {
                                if (x.Text.Contains("AD")) { } // 광고 컷
                                else
                                {
                                    for (int i = 0; i < lbxWemakeprice.Items.Count; i++)
                                        if (lbxWemakeprice.Items[i].ToString() == x.Text) { check = false; break; }
                                    if (check)
                                    {
                                        lbxWemakeprice.Items.Add(x.Text);
                                        arrWemakeprice.Add(x.FindElement(By.TagName("a")).GetAttribute("href"));
                                    }
                                }
                            }
                        }
                    }
                    else if (rbtnSalesVolume.Checked) // 판매량 -> 항목에 없다.
                    {
                        lbxWemakeprice.Items.Add("판매량순 항목이 없습니다.");
                    }
                    else if (rbtnLatest.Checked)
                    {
                        //검색 -> 클릭
                        driver.Url = "https://front.wemakeprice.com/main";
                        driver.FindElement(By.Name("search_keyword")).Clear();
                        driver.FindElement(By.Name("search_keyword")).SendKeys(tbxSearch.Text);
                        driver.FindElement(By.XPath("//*[@id=\"_searchKeywordBtn\"]")).Click();
                        driver.FindElement(By.XPath("//*[@id=\"_contents\"]/div/div[2]/div[1]/div[1]/div/div")).Click();
                        driver.FindElement(By.XPath("//*[@id=\"_contents\"]/div/div[2]/div[1]/div[1]/div/div/ul/li[2]")).Click();
                        Thread.Sleep(1000);

                        List<IWebElement> elements = driver.FindElement(By.ClassName("search_wrap")).FindElements(By.ClassName("list_conts_wrap")).ToList();
                        Debug.WriteLine("elements.Count: " + elements.Count);

                        bool check = true;

                        foreach (IWebElement x in elements)
                        {
                            if (x.Text == "") { }
                            else
                            {
                                if (x.Text.Contains("AD")) { } // 광고 컷
                                else
                                {
                                    for (int i = 0; i < lbxWemakeprice.Items.Count; i++)
                                        if (lbxWemakeprice.Items[i].ToString() == x.Text) { check = false; break; }
                                    if (check)
                                    {
                                        lbxWemakeprice.Items.Add(x.Text);
                                        arrWemakeprice.Add(x.FindElement(By.TagName("a")).GetAttribute("href"));
                                    }
                                }
                            }
                        }
                    }

                    // 이미지
                    if (rbtnWemakeprice.Checked)
                    {
                        List<IWebElement> imgs = driver.FindElement(By.ClassName("search_wrap")).FindElements(By.TagName("img")).ToList();
                        Debug.WriteLine("imgs.Count: " + imgs.Count);

                        foreach (IWebElement i in imgs)
                        {
                            arrWemakepriceImage.Add(i.GetAttribute("src"));
                        }

                        for (int i = 0; i < arrWemakepriceImage.Count; i++)
                        {
                            var request = WebRequest.Create(arrWemakepriceImage[i].ToString());

                            using (var response = request.GetResponse())
                            using (var stream = response.GetResponseStream())
                            {
                                if (i == 0) { pictureBox1.Image = Bitmap.FromStream(stream); }
                                else if (i == 1) { pictureBox2.Image = Bitmap.FromStream(stream); }
                                else if (i == 2) { pictureBox3.Image = Bitmap.FromStream(stream); }
                            }

                            if (i == 2) { break; }
                        }

                        lblResultImage.Text = "위\n메\n프\n\n대\n표\n\n이\n미\n지";
                    }
                }
                catch { }
                
                // 라벨
                if (rbtnRanking.Checked) { lblResultAuction.Text = "옥션 랭킹순 검색 결과"; lblResultGmarket.Text = "G마켓 랭킹순 검색 결과"; lblResultTmon.Text = "티몬 랭킹순 검색 결과"; lblResultWemakeprice.Text = "위메프 추천순 검색 결과"; }
                else if (rbtnLowPrice.Checked) { lblResultAuction.Text = "옥션 낮은가격순 검색 결과"; lblResultGmarket.Text = "G마켓 낮은가격순 검색 결과"; lblResultTmon.Text = "티몬 낮은가격순 검색 결과"; lblResultWemakeprice.Text = "위메프 낮은가격순 검색 결과"; }
                else if (rbtnHighPrice.Checked) { lblResultAuction.Text = "옥션 높은가격순 검색 결과"; lblResultGmarket.Text = "G마켓 높은가격순 검색 결과"; lblResultTmon.Text = "티몬 높은가격순 검색 결과"; lblResultWemakeprice.Text = "위메프 높은가격순 검색 결과"; }
                else if (rbtnSalesVolume.Checked) { lblResultAuction.Text = "옥션 판매량순 검색 결과"; lblResultGmarket.Text = "G마켓 판매량순 검색 결과"; lblResultTmon.Text = "티몬 판매량순 검색 결과"; lblResultWemakeprice.Text = "위메프 판매량순 검색 결과"; }
                else if (rbtnLatest.Checked) { lblResultAuction.Text = "옥션 최신순 검색 결과"; lblResultGmarket.Text = "G마켓 최신순 검색 결과"; lblResultTmon.Text = "티몬 최신순 검색 결과"; lblResultWemakeprice.Text = "위메프 최신순 검색 결과"; }

                driver.Close();                
            }
        }

        private void lbxAuction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxAuction.SelectedItem == null) { return; }
            else
            {
                try { BrowserStart(lbxAuction.SelectedIndex, 1); }
                catch { }
            }
        }

        private void lbxGmarket_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxGmarket.SelectedItem == null) { return; }
            else
            {
                try { BrowserStart(lbxGmarket.SelectedIndex, 2); }
                catch { }
            }
        }
        
        private void lbxTmon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbxTmon.SelectedItem == null) { return; }
            else
            {
                try { BrowserStart(lbxTmon.SelectedIndex, 3); }
                catch { }
            }
        }

        private void lbxWemakeprice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxWemakeprice.SelectedItem == null) { return; }
            else 
            {
                try { BrowserStart(lbxWemakeprice.SelectedIndex, 4); }
                catch { }
            }
        }

        private async void BrowserStart(int index, int mode) // 브라우저 띄울 때 윈폼에서 다른 행동 할 수 있도록
        {
            try
            {
                using (driver = new ChromeDriver(service))
                {
                    if (mode == 1) driver.Url = arrAuction[index].ToString();
                    else if (mode == 2) driver.Url = arrGmarket[index].ToString();
                    else if (mode == 3) driver.Url = arrTmon[index].ToString();
                    else if (mode == 4) driver.Url = arrWemakeprice[index].ToString();
                    if (driver.Manage().Window == null) driver.Close();        // 이렇게 하면 창은 남기고 드라이버만 닫을 수 있다.
                    await Task.Delay(60000);
                }
            }
            catch { }
        }

        private void ListBoxReset_btn_Click(object sender, EventArgs e)
        {
            lbxAuction.SelectedItem = null;
            lbxGmarket.SelectedItem = null;
            lbxTmon.SelectedItem = null;
            lbxWemakeprice.SelectedItem = null;
        }

        private void btnWindowClose_Click(object sender, EventArgs e)
        {
            try
            {
                Process[] process = new Process[100];
                process = Process.GetProcessesByName("chrome");
                foreach (Process x in process) x.Kill();
                process = Process.GetProcessesByName("chromedriver");
                foreach (Process x in process) x.Kill();
                process = Process.GetProcessesByName("conhost");
                foreach (Process x in process) x.Kill();
            }
            catch { }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Hided)
            {
                panel2.Width = panel2.Width + 20;
                if (panel2.Width >= PW)
                {
                    timer1.Stop();
                    Hided = false;
                    this.Refresh();
                }
            }
            else
            {
                panel2.Width = panel2.Width - 20;
                if (panel2.Width <= 0)
                {
                    timer1.Stop();
                    Hided = true;
                    this.Refresh();
                }
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (Hided) btnHide.Text = "숨\n기\n기";
            else btnHide.Text = "보\n여\n주\n기";
            timer1.Start();
        }
    }
}
