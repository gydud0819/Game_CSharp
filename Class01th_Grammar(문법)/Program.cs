namespace Grammar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Boxing
            // 값 형식의 데이터를 참조 형식으로 변환하는 과정
            // ex)
            //int value = 100;
            //
            //object generic = value;
            //
            //Console.WriteLine("value : " + value);
            //Console.WriteLine("generic : " + generic);
            #endregion

            #region Unboxing
            // 참조 형식의 데이터를 값 형식으로 변화하는 과정
            // ex)

            //int box = (int)generic;     // 명시적 형변환을 해줘야함 (ex. (int))
            //
            //Console.WriteLine("box : " +  box);

            // 요약: 박싱 언박싱이 안일어나게 하는 게 제일 조음 
            #endregion

            #region 매개 변수 한정자
            // 함수의 매개 변수 앞에 해당하는 인자의 전달 방식을 지정하는 키워드

            //Utility utility = new Utility();
            //
            //utility.Pause();
            //
            //int x = 10;
            //int y = 20;
            //utility.Swap(ref x, ref y);
            //
            //int a = -7;
            //
            //Console.WriteLine("절대값 : " + utility.Absolute(in a));
            //
            //float length;
            //
            //Vector2 dir = new Vector2(1, 2);
            //
            //utility.Magnitude(dir, out length);
            //Console.WriteLine("length : " + length);
            #endregion

        }
    }
}
