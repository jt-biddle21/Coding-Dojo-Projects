public class FizzBuzz {
    public String fizzBuzz(int number) {
        String word = "";
        if(number % 3 == 0 && number % 5 == 0)
        {
            word = "FizzBuzz";
            return word;
        }
        else if(number % 3 == 0)
        {
            word = "Fizz";
            return word;
        }
        else if(number % 5 == 0)
        {
            word = "Buzz";
            return word;
        }
        else
        {
            word += number;
            return word;
        }
    }
}
