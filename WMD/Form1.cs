using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.IO;

namespace WMD
{
    public partial class Form1 : Form
    {
        //this one is for using in fiel system
        public string searchKey;
        public bool valid = false,isOnline;
        public Thread loadthread = new Thread(showLoader);
        // all parameters done: the above parameters were for uploading to internet
        public Form1()
        {
            InitializeComponent();
        }
        public static void showLoader()
        {
                //show a loader , which will be   created dynamically
      
        }   
        private void Form1_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.Name = "main";
            //code to check if you are online or not
            check_and_set_online_status();
            
        }
        public void check_and_set_online_status()
        {
            if (check_internet())
            {
                isOnline = true;
                label_online.Text = "You are online";
            }
            else
            {
                isOnline = false;
                label_online.Text = "You are offline";
                PrintLog("You are offline. You need to get online to use this tool");
            }
        }
        private bool check_internet() {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private string download_html(string url)
        { 
            //this function downloads the content of html file
            try
            {
                HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(url);
                myRequest.Method = "GET";
                WebResponse myResponse = myRequest.GetResponse();
                StreamReader sr = new StreamReader(myResponse.GetResponseStream(), System.Text.Encoding.UTF8);
                string result = sr.ReadToEnd();//result has the data so returned from net
                sr.Close();
                myResponse.Close();
                return result;
            }
            catch(Exception ex) {
                PrintLog("exception occured while attempting to read " +url +" \nEXCEPTION: " +ex.Message);
                return "-1";
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            string textdata = domain.Text;
            if (textdata.Length == 0)
            {
                tmplog.Text = "Invalid";
                PrintLog("Empty domain name attempted");
            }
            else {
                tmplog.Text = "";
                PrintLog("Processing started for: " +textdata);
                string d = checkDomain(textdata);
                if (d!="-1")
                {
                    //a valid domain; it is exactly or one can be made
                    PrintLog("Domain refined as: " +d);
                    domain.Text = d;
                    //this coming function should be fecilitated by a loading sign or image
                    // in thread two
                    if (isUrlExists(d))
                    {
                        //url exists
                        //download data here
                        string html_data = download_html(d);
                        if (html_data == "-1")
                        {
                            PrintLog("proram halts here");
                        }
                        else { 
                        
                        }
                    }
                    else { 
                        //url does not exists
                    }

                }
                else 
                { 
                       //a valid domain not possible
                    PrintLog("invalid domain fed: DOMAIN:- " +textdata);
                    domain.Text = "";
                }
            }
            
        }
        private bool isUrlExists(string url)
        {
             try
             {
                  //creating a httpwebrequest
                  HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                  //setting the request method head
                  request.Method = "HEAD";
                  //getting the web response
                  HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                  //returns true if response is 200
                  return (response.StatusCode == HttpStatusCode.OK);
              }
              catch
              {
                  return false;
              }
        }
        private static string checkDomain(string key)
        {
            if (key.IndexOf("http://") != -1)
            {
                //it contains http://       //remove it then
                key.Replace("http://", "");
                
            }
            else if (key.IndexOf("https://") != -1)
            {
                //it contains https://      //remove it then
                key.Replace("https://", "");

            }
            //if in case http:// or https:// was there it ud have been removed
            //now something like abfdf.com /.net /.edu is left
            /*
             * now the string should be exploded for "/"  and the string in first index should be considered
             */
            string[] array = key.Split(new string[]{"/"},StringSplitOptions.None);
            key = array[0];
            if (key.Length == 0) { return "-1"; }
            // control will be returned in case the url is invalid till here
            if (key.IndexOf(".") == -1) {
                key = key + ".com";
                return key;
                // here if data is entered as abc daat is returned as abc.com
            }
            if (key.LastIndexOf(".") == (key.Length-1))
            {
                if (key.LastIndexOf(".") == 0) return "-1";
                key = key + "com";
                return key;
            }
            else return key;
        }
        public void PrintLog(string logstring)
        {
            log.Text += " \n \t::>  " + logstring + " ...";
            log.SelectionStart = log.Text.Length;
            log.ScrollToCaret();
        /*
         this functino prints log to the rtb
         */    
        }

        private void clearlogbutton_Click(object sender, EventArgs e)
        {
            /*this function clears the log table*/
            log.Text = "";
            // as simple as that
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

       
    }
}
