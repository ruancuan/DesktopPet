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
        const string key="4e2802cbe401441093e95b1400c33ea1";

        public static void Main(string[] args)
        {
            JsonData jsonData=new JsonData();
            jsonData["key"]=key;
            jsonData["info"]="Hello";
            jsonData["userid"]="213";
            string inputString=JsonMapper.ToJson(jsonData);
            Console.WriteLine(GetResponse(inputString,1));
            Console.Read();
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
            //string url = apiAddress+"?key=" + key + "&info=" + str+"&userid="+userId;

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
                    switch (excode)
                    {
                        case 100000:
                            reader.Read();
                            reader.Read();
                            return reader.Value.ToString();
                        case 5000:
                            return "无解析结果";
                        case 6000:
                            return "暂不支持此功能";
                        case 4000:
                            return "请求参数格式错误";
                        case 4001:
                            return "加密方式错误";
                        case 4002:
                            return "无功能权限";
                        case 4003:
                            return "该apikey没有可用请求次数";
                        case 4005:
                            return "无功能权限";
                        case 4007:
                            return "apikey不合法";
                        case 4100:
                            return "userid获取失败";
                        case 4200:
                            return "上传格式错误";
                        case 4300:
                            return "批量操作超过限制";
                        case 4400:
                            return "没有上传合法userid";
                        case 4500:
                            return "userid申请个数超过限制";
                        case 4600:
                            return "输入内容为空";
                        case 4602:
                            return "输入文本内容超长(上限150)";
                        case 7002:
                            return "上传信息失败";
                        case 8008:
                            return "服务器错误";
                        default:
                            return "发生异常,异常码为:" + excode.ToString();
                    }
                }
            }
            return data;
        }
    }
}
