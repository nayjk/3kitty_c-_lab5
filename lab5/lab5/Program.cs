using nam_reader;
using nam_student;

namespace lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student Ivanov = new Student("Иванов Никита", 17, 14);
            Reader IvanovReader = new Reader("Иванов Никита",4,"Азбука, Молодёжный журнал, Энциклопедия, Газета");

            Student Islyam = new Student("Исаев Ислям", 17, 18);
            Reader IslyamReader = new Reader("Исаев Ислям",1, "Энциклопедия");

            Student Liza = new Student("Лобкова Лизочка",17,3);
            Reader LizaReader = new Reader("Лобкова Лизочка",3,"Война и Мир, Межвремье, Алиса в стране чудес");

            Student[] student = new Student[] { Ivanov, Islyam, Liza };
            Reader[] reader = new Reader[] {IvanovReader, IslyamReader, LizaReader };

            student[0].Message();
            reader[0].takeBook();
            reader[0].returnBook();

            Console.WriteLine(" ");

            student[1].Message();
            reader[1].takeBook();
            reader[1].returnBook();

            Console.WriteLine(" ");

            student[2].Message();
            reader[2].takeBook();
            reader[2].returnBook();
        }
    }
}
namespace nam_student{
    class Student
    {
        string surname;
        int groub;
        private int age;
        public void Message()
        {
            Console.WriteLine("Студент " + surname + " из группы " + groub + " возрастом " + age + " лет");
        }
        public Student(string surname, int groub, int age)
        {
            this.surname = surname;
            this.groub = groub;
            this.age = age;
        }
    }
}

namespace nam_reader{
    class Reader{
        private string name;
        int number_book;
        string faculty; //факультет
        private int burth;
        int tele_number;
        int quantity_book; //количество взятых книг
        string book; //какие книги взял пользователь

        public Reader(string name, int quantity_book, string book)
        {
            this.name = name;
            this.quantity_book = quantity_book;
            this.book = book;
        }

        public void takeBook()
        {

            Console.WriteLine("Студент " + name + " взял " + quantity_book + " книги");
            Console.WriteLine("Читатель " + name +  " взял такие книги: " + book);
        }
        public void returnBook()
        {
            Console.WriteLine("Студент " + name + " вернул " + quantity_book + " книги");
        }
    }
    
}