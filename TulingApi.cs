using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using Newtonsoft.Json;
using System.IO;

namespace Snowy
{
    class TulingApi
    {
        const string KEY = "4e2802cbe401441093e95b1400c33ea1";

        const string Url=@"{
            'reqType':{0},
            'perception': {
                'inputText': {
                    'text': '{1}'
                }
            },
            'userInfo': {
                'apiKey': '{2}',
                'userId': '{3}'
            }
        }";

        public static string HttpGet(string url, Encoding encoding)
        {
            string data = "";
            try
            {
                WebRequest request;
                request = WebRequest.Create(url);
                request.Credentials = CredentialCache.DefaultCredentials;
                request.Timeout = 10000;
                WebResponse response;
                response = request.GetResponse();
                data = new StreamReader(response.GetResponseStream(), encoding).ReadToEnd();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return data;
        }

        public static string GetResponse(string str)
        {
            if (str == null)
                return "";
            // string url = "http://openapi.tuling123.com/openapi/api/v2?key=" + KEY + "&info=" + str;
            string url=Url.Replace('\'','"');
            url=string.Format(url,0,str);
            Encoding encoding = Encoding.GetEncoding("utf-8");
            string data = HttpGet(url, encoding);
            JsonReader reader = new JsonTextReader(new StringReader(data));
            while (reader.Read())
            {
                if (reader.TokenType == JsonToken.PropertyName
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
