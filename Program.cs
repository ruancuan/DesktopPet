using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using Newtonsoft.Json;
using System.IO;
using LitJson;

namespace test
{
    public class Program
    {
        const string apiAddress = @"http://openapi.tuling123.com/openapi/api/v2";
        const string key="820c4a6ca4694063ab6002be1d1c63d3";
        static Dictionary<int,string> errorDic=new Dictionary<int, string>();

        public static void Main(string[] args)
        {
            InitDic();
            string inputString="{'reqType':0,'perception':{'inputText':{'text':'Hello'}},'userInfo':{'apiKey':'820c4a6ca4694063ab6002be1d1c63d3','userId':'213'}}";
            inputString.Split('\'','"');
            Console.WriteLine(GetResponse(inputString,1));
            Console.Read();
        }

        public static void InitDic(){
            errorDic.Add(5000,"无解析结果");
            errorDic.Add(6000,"暂不支持此功能");
            errorDic.Add(4000,"请求参数格式错误");
            errorDic.Add(4001,"加密方式错误");
            errorDic.Add(4002,"无功能权限");
            errorDic.Add(4003,"该apikey没有可用请求次数");
            errorDic.Add(4005,"无功能权限");
            errorDic.Add(4007,"apikey不合法");
            errorDic.Add(4100,"userid获取失败");
            errorDic.Add(4200,"上传格式错误");
            errorDic.Add(4300,"批量操作超过限制");
            errorDic.Add(4400,"没有上传合法userid");
            errorDic.Add(4500,"userid申请个数超过限制");
            errorDic.Add(4600,"输入内容为空");
            errorDic.Add(4602,"输入文本内容超长(上限150)");
            errorDic.Add(7002,"上传信息失败");
            errorDic.Add(8008,"服务器错误");
        }

        public static string HttpGet(string url, Encoding encoding)
        {
            string data = "";
            try
            {
                byte[] byteArray=Encoding.UTF8.GetBytes(url);
                HttpWebRequest request;
                request = (HttpWebRequest)WebRequest.Create(apiAddress);
                request.Method="POST";
                request.ContentLength=byteArray.Length;
                request.Timeout = 10000;
                Stream newStream=request.GetRequestStream();
                newStream.Write(byteArray,0,byteArray.Length);
                newStream.Close();
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                data = new StreamReader(response.GetResponseStream(), encoding).ReadToEnd();
                response.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return data;
        }

        public static string GetResponse(string url,int userId)
        {
            if (url == null)
                return "";
            Encoding encoding = Encoding.GetEncoding("utf-8");
            string data = HttpGet(url, encoding);
            Newtonsoft.Json.JsonReader reader = new JsonTextReader(new StringReader(data));
            while (reader.Read())
            {
                if (reader.TokenType == Newtonsoft.Json.JsonToken.PropertyName
                    && reader.ValueType == Type.GetType("System.String")
                    && Convert.ToString(reader.Value) == "code")
                {
                    reader.Read();
                    int excode = Convert.ToInt32(reader.Value);
                    if(errorDic.ContainsKey(excode)){
                        Console.WriteLine(errorDic[excode]);
                    }
                    else{
                        if(excode==100000){
                            reader.Read();
                            reader.Read();
                            return reader.Value.ToString();
                        }
                    }
                }
            }
            return data;
        }
    }
}
