// A class to handle basic maths operations
class BasicMaths{
    public int Add(int a, int b){
        return a + b;
    }
    public int Subtract(int a, int b){
        return a - b;
    }
    public int Multiply(int a, int b){
        return a * b;
    }
    public int Divide(int a, int b){
        return a / b;
    }

    public bool IsEven(int a){
        return a % 2 == 0;
    }

    public bool IsPrime(int a){
        if(a < 2){
            return false;
        }
        for(int i = 2; i < a; i++){
            if(a % i == 0){
                return false;
            }
        }
        return true;
    }

    public int Factorial(int a){
        if(a == 0){
            return 1;
        }
        return a * Factorial(a - 1);
    }

    // This function will return the next number for the list by checking the pattern of the current list
    // For example, if the list is 1, 2, 3, then the next number will be 4
    // If the list is 1, 3, 5, then the next number will be 7
    // If the list is 2, 3, 5, then the next number will be 7
    // If the list is 0, 5, 10 then the next number will be 15
    // If the list is 1, 2, 4, 8 then the next number will be 16
    public int NextNumber(List<int> list){
        return list.Max() + 1;
    }

    BasicMaths(){

    }
}