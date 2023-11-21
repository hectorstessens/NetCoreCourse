namespace NetCoreCourse.CleanCodeDesignPatterns.Client
{
    public static class JapanWeatherClient
    {
        static double init = 0;
        public static void Login()  
        {
            init = 1;
        }
        public static void SetParameters() 
        {
            init += 1;
        }
        public static void SetConfiguration() 
        {
            init += 2;
        }
        public static double GetProbability() 
        {
            if (init.Equals(4))
                return 10;
            else
                throw new Exception("サービスに電話する正しい方法ではありません");
        }
    }
}
