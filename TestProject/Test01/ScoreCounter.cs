using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);
        }


        //メソッドの概要：点数データを読み込みStudetオブジェクトのリストを返す
        private static IEnumerable<Student> ReadScore(string filePath) {
            var students = new List<Student>();
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines) {
                var student_data = line.Split(',');
                var student = new Student
                {
                    Name = student_data[0],
                    Subject = student_data[1],
                    Score = int.Parse(student_data[2])
                };
                students.Add(student);
            }
            return students;
        }

        //メソッドの概要：生徒ごとに合計点数を求める
        public IDictionary<string, int> GetPerStudentScore() {
            var dict = new Dictionary<string, int>();
            foreach (var student in _score) {
                if (dict.ContainsKey(student.Subject))
                    dict[student.Subject] += student.Score;
                else
                    dict[student.Subject] = student.Score;
            }
            return dict;
        }
    }
}
