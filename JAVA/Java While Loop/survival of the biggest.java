import java.util.Scanner;
public class Main {
    public static void main (String args[]) {
        Scanner input = new Scanner(System.in);
        int num = input.nextInt();
        int a = 0;

        while (num > 0) {
            if(num % 10 > a) {
                a = num % 10;
            }
            num /= 10;
        }
        System.out.println(a);
    }
}