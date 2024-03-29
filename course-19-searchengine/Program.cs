internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string,string> search_ch = new(){
          {"人工智能","通过计算机程序和机器学习技术来实现智能行为的技术和方法。"},
          {"区块链","一种去中心化的分布式账本技术，可以安全地记录数字交易和数据。"},
          {"云计算","通过互联网将计算资源和服务提供给用户的一种方式"},
          {"物联网","通过互联网连接到的各种设备和传感器，可以通过互联网进行通信和数据交换。"},
          {"大数据","规模巨大、类型繁多的数据集合，需要使用特殊的技术和工具进行处理和分析。"},
          {"虚拟现实","通过计算机生成的三维场景和交互式体验，可以让用户感觉身临其境。"},
          {"增强现实","通过计算机生成的虚拟信息与现实世界结合的技术，可以让用户看到更多的信息、实现交互式体验。"},
          {"自动驾驶汽车","通过计算机控制车辆自主行驶的一种交通工具。"}
        };

        Dictionary<string,string> search_en = new(){
          {"AI","人工智能"},
          {"BLOCKCHAIN","区块链"},
          {"CLOUD COMPUTING","云计算"},
          {"IOT","物联网"},
          {"BIG DATA","大数据"},
          {"VR","虚拟现实"},
          {"AR","增强现实"},
          {"AUTONOMOUS VEHICLES","自动驾驶汽车"}
        };

        while (true)
        {
            Console.WriteLine("請搜尋你的關鍵詞");
            string? input = Console.ReadLine();

            if (input != null)
            {
                input = input.ToUpper();
                if (search_ch.ContainsKey(input))
                {
                    Console.WriteLine(search_ch[input]);
                }
                else if (search_en.ContainsKey(input))
                {
                    Console.WriteLine(search_ch[search_en[input]]);
                }
                else
                {
                    Console.WriteLine("內容不存在");
                }
            }
            else
            {
                Console.WriteLine("沒有內容，從新輪入");
            }
        }
    }
}