namespace 클래스_생성자_기초실습
{/*과제 1. 트레이너와 몬스터 제작하기
트레이너와 몬스터 클래스를 구현하시오.
트레이너는 최대 6마리의 몬스터를 가질 수 있다.
트레이너가 몬스터 생성 시 몬스터의 체력을 지정 값으로 초기화 해야 한다.
Main 함수에서 트레이너 인스턴스 생성 시, 트레이너의 이름을 초기화 해야 한다.*/
    internal class Program
    {
        class Trainer //객체지향 설명 테크톡 객체지향 설명, 예시
        {
            public string name;
            Monster[] monsters = new Monster[6];

            public Trainer(string name)
            {
                this.name = name;
            }
        }

        class Monster
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
        }
    }
}
