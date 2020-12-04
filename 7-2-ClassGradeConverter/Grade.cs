using System;
namespace GradeClass {
    public class Grade {

        public int number { get; set; }
        public string letter { get; set; }

        public Grade() {
            this.number = 0;
        }

        public Grade(int number, string letter) {
            this.number = number;
            this.letter = letter;
        }





    }
}
