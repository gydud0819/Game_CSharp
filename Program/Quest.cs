using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Quest
    {
        private Reward reward;
        private string title;
        private string contents;


        public bool isClear = false;
        public Quest(string _title, string _contents, Reward _reward)
        {
            title = _title;
            contents = _contents;
            reward = _reward;
        }

        public void Print()
        {
            Console.WriteLine("퀘스트 : " + title);
            Console.WriteLine("내용 : " + contents);

            reward.GetReward();
        }

        public void Clear()
        {
            if (isClear == true)
            {
                Console.WriteLine("전달 완료!");
            }
            else
            {
                Console.WriteLine("완료 여부 : 미완료된 퀘스트입니다.");
            }
        }


    }
}
