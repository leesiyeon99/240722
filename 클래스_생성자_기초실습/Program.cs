namespace 클래스_생성자_기초실습
{/*과제 1. 트레이너와 몬스터 제작하기
트레이너와 몬스터 클래스를 구현하시오.
트레이너는 최대 6마리의 몬스터를 가질 수 있다.
트레이너가 몬스터 생성 시 몬스터의 체력을 지정 값으로 초기화 해야 한다.
Main 함수에서 트레이너 인스턴스 생성 시, 트레이너의 이름을 초기화 해야 한다.*/
    internal class Program
    {
        public class Trainer 
        {
            public string name;
            public Monster[] monsters = new Monster[6];

            public Trainer(string name)
            {
                this.name = name;
            }

            public void GetMonster(Monster monster)
            {
                for (int i = 0; i < monsters.Length; i++)
                {
                    if (monsters[i] == null)
                    {
                        monsters[i] = monster;
                        Console.WriteLine($"{monster.monsterName}를 잡았습니다. 체력은 {monster.monsterHp}입니다.");
                        return;
                    }
                }
                Console.WriteLine("가질 수 있는 몬스터의 갯수는 6마리 입니다.");
            }
        }

        public class Monster
        {
            public int monsterHp;
            public string monsterName;
            public Monster(int monsterHp, string monsterName)
            {
                this.monsterHp = monsterHp;
                this.monsterName = monsterName;
            }

        }

        static void Main(string[] args)
        {
            Trainer trainer = new Trainer("이시연");
            Monster 피카츄 = new Monster(1000, "피카츄");
            Monster 파이리 = new Monster(700, "파이리");

            trainer.GetMonster(피카츄);
            trainer.GetMonster(파이리);
            trainer.GetMonster(파이리);
            trainer.GetMonster(파이리);
            trainer.GetMonster(파이리);
            trainer.GetMonster(파이리);
            trainer.GetMonster(파이리);
            trainer.GetMonster(파이리);

        }
    }
}
