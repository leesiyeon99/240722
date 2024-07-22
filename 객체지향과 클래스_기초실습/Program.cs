using static 객체지향과_클래스_기초실습.Program;

namespace 객체지향과_클래스_기초실습
{
    internal class Program
    {
        public class Character
        {

            public int level;
            public int hp;
            public float speed;
            public int attack;

            public void MoveForward()
            {

            }

            public void MoveBackward()
            {

            }

            public void MoveLeft()
            {

            }

            public void MoveRight()
            {

            }

            public void Attack()
            {

            }

            public void GetAttack(int playerHp)
            {
                Console.WriteLine("공격을 받았습니다");
                Console.WriteLine($"체력이 {hp - playerHp}이 되었습니다.");
            }
        }

        static void Main(string[] args)
        {
            Character player = new Character();
            player.level = 10;
            player.hp = 100;
            player.speed = 4.5f;
            player.attack = 40;

            Console.WriteLine($"레벨: {player.level} 체력: {player.hp} 속도: {player.speed} 공격력: {player.attack}");
            player.GetAttack(10);
        }
    }
}


